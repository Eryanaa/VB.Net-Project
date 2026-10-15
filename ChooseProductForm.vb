Imports MySql.Data.MySqlClient
Public Class ChooseProductForm

    Private Function ProcessProduct(chk As CheckBox, txtQty As TextBox, cmbSize As ComboBox, productName As String, price As Decimal) As Boolean
        If chk.Checked Then
            Dim qty As Integer
            If Not Integer.TryParse(txtQty.Text.Trim(), qty) OrElse qty <= 0 Then
                MessageBox.Show("Please enter a valid quantity for " & productName, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If cmbSize.SelectedIndex = -1 Then
                MessageBox.Show("Please select a size for " & productName, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Dim item As OrderSession.OrderItem
            item.ProductName = productName
            item.Price = price
            item.Quantity = qty
            item.Size = cmbSize.SelectedIndex.ToString()
            item.Subtotal = price * qty

            OrderSession.SelectedItems.Add(item)
            OrderSession.ProductsSubtotal += item.Subtotal
        End If
        Return True
    End Function

    Private Sub ClothingPictureBox_Click(sender As Object, e As EventArgs) _
    Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click,
            PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)

        'Check if the PictureBox contains an image
        If clickedPictureBox.Image Is Nothing Then
            MessageBox.Show("No image available.")
            Exit Sub
        End If

        'Create the preview window
        Dim previewForm As New Form()
        Dim bigPic As New PictureBox()

        'Set the image
        bigPic.Image = clickedPictureBox.Image
        bigPic.SizeMode = PictureBoxSizeMode.Zoom
        bigPic.Dock = DockStyle.Fill

        'Set the preview window
        previewForm.Text = "Clothing Image Preview"
        previewForm.Size = New Size(600, 600)
        previewForm.StartPosition = FormStartPosition.CenterScreen

        'Add PictureBox to the preview window
        previewForm.Controls.Add(bigPic)

        'Show preview
        previewForm.ShowDialog()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        OrderSession.SelectedItems.Clear()
        OrderSession.ProductsSubtotal = 0D

        If Not ProcessProduct(BasicTShirtCheckBox, BasicQuantityTextBox, BasicSizeComboBox, "Basic T-Shirt", 20D) Then Return
        If Not ProcessProduct(SlimFitTShirtCheckBox, FitQuantityTextBox, FitSizeComboBox, "Slim Fit T-Shirt", 28D) Then Return
        If Not ProcessProduct(OversizedTShirtCheckBox, OversizedQuantityTextBox, OversizedSizeComboBox, "Oversized T-Shirt", 35D) Then Return
        If Not ProcessProduct(HoodieCheckBox, HoodieQuantityTextBox, HoodieSizeComboBox, "Hoodie", 45D) Then Return
        If Not ProcessProduct(JeansCheckBox, JeansQuantityTextBox, JeansSizeComboBox, "Jeans", 42D) Then Return
        If Not ProcessProduct(CasualShortCheckBox, CasualQuantityTextBox, CasualSizeComboBox, "Casual Short", 25D) Then Return
        If Not ProcessProduct(CargoPantsCheckBox, CargoQuantityTextBox, CargoSizeComboBox, "Cargo Pants", 40D) Then Return
        If Not ProcessProduct(SkirtCheckBox, SkirtQuantityTextBox, SkirtSizeComboBox, "Skirt", 39D) Then Return
        If Not ProcessProduct(PyjamasCheckBox, PyjamasQuantityTextBox, PyjamasSizeComboBox, "Pyjamas", 55D) Then Return
        If Not ProcessProduct(SwimsuitCheckBox, SwimsuitQuantityTextBox, SwimsuitSizeComboBox, "Swimsuit", 69D) Then Return

        If OrderSession.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select at least one product before continuing.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim summary As String = "Selected Products:" & vbCrLf
        For Each item In OrderSession.SelectedItems
            summary &= "- " & item.ProductName & "(" & item.Size & ")" & " x " & item.Quantity & " = RM" & item.Subtotal.ToString("F2") & vbCrLf
        Next
        summary &= vbCrLf & "Subtotal: RM" & OrderSession.ProductsSubtotal.ToString("F2") & vbCrLf & "Confirm these items?"

        Dim result As DialogResult = MessageBox.Show(summary, "Confirm Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(OrderSession.ConnStr)
                    conn.Open()
                    Dim orderSql As String = "INSERT INTO orders (customer_id, subtotal, total_amount) VALUES (@cid, @subtotal, @subtotal); SELECT LAST_INSERT_ID();"
                    Using cmd As New MySqlCommand(orderSql, conn)
                        cmd.Parameters.AddWithValue("@cid", OrderSession.CurrentCustomerId)
                        cmd.Parameters.AddWithValue("@subtotal", OrderSession.ProductsSubtotal)
                        OrderSession.CurrentOrderId = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using

                    Dim itemSql As String = "INSERT INTO order_items (order_id, product_name, price, quantity, size, item_total) " &
                                            "VALUES (@oid, @pname, @price, @qty, @size, @total);"
                    For Each item In OrderSession.SelectedItems
                        Using itemCmd As New MySqlCommand(itemSql, conn)
                            itemCmd.Parameters.AddWithValue("@oid", OrderSession.CurrentOrderId)
                            itemCmd.Parameters.AddWithValue("@pname", item.ProductName)
                            itemCmd.Parameters.AddWithValue("@price", item.Price)
                            itemCmd.Parameters.AddWithValue("@qty", item.Quantity)
                            itemCmd.Parameters.AddWithValue("@size", item.Size)
                            itemCmd.Parameters.AddWithValue("@total", item.Subtotal)
                            itemCmd.ExecuteNonQuery()
                        End Using
                    Next
                End Using

                ExtraServicesForm.Show()
                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AboutBox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim historyForm As New OrderHistoryForm()
        historyForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        Dim confirmation As String = "Are you sure you want to exit?"

        Dim confirmResult As DialogResult = MessageBox.Show(confirmation, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ChooseProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class