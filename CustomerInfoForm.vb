Imports MySql.Data.MySqlClient
Public Class CustomerInfoForm

    Private Sub txtContact_Leave(sender As Object, e As EventArgs) Handles txtContact.Leave
        Dim phone As String = txtContact.Text.Trim()
        If String.IsNullOrWhiteSpace(phone) Then Return

        Try
            Using conn As New MySqlConnection(OrderSession.ConnStr)
                conn.Open()
                Dim query As String = "SELECT customer_id, name FROM customers WHERE contact_number = @phone LIMIT 1;"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@phone", phone)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            OrderSession.CurrentCustomerId = Convert.ToInt32(reader("customer_id"))
                            txtName.Text = reader("name").ToString()
                            MessageBox.Show("Existing customer found: " & txtName.Text, "Customer Recognized", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            OrderSession.CurrentCustomerId = 0
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking customer: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim cName As String = txtName.Text.Trim()
        Dim cPhone As String = txtContact.Text.Trim()

        If String.IsNullOrEmpty(cName) OrElse String.IsNullOrEmpty(cPhone) Then
            MessageBox.Show("Please enter both Customer Name and Contact Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim isExisting As Boolean = (OrderSession.CurrentCustomerId > 0)
        Dim confirmMsg As String = "Please verify customer information:" & vbCrLf & vbCrLf &
                                   "Name: " & cName & vbCrLf &
                                   "Contact: " & cPhone & vbCrLf &
                                   "Status: " & If(isExisting, "Returning Customer", "New Customer") & vbCrLf & vbCrLf &
                                   "Is this information correct?"

        If MessageBox.Show(confirmMsg, "Confirm Customer Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If

        Try
            Using conn As New MySqlConnection(OrderSession.ConnStr)
                conn.Open()

                If OrderSession.CurrentCustomerId = 0 Then
                    Dim insertSql As String = "INSERT INTO customers (name, contact_number) VALUES (@name, @phone); SELECT LAST_INSERT_ID();"
                    Using cmd As New MySqlCommand(insertSql, conn)
                        cmd.Parameters.AddWithValue("@name", cName)
                        cmd.Parameters.AddWithValue("@phone", cPhone)
                        OrderSession.CurrentCustomerId = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
                Else
                    Dim updateSql As String = "UPDATE customers SET name = @name WHERE customer_id = @id;"
                    Using cmd As New MySqlCommand(updateSql, conn)
                        cmd.Parameters.AddWithValue("@name", cName)
                        cmd.Parameters.AddWithValue("@id", OrderSession.CurrentCustomerId)
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End Using

            OrderSession.CustomerName = cName
            OrderSession.CustomerContact = cPhone

            ChooseProductForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AboutBox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim historyForm As New OrderHistoryForm()
        historyForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        Dim confirmation As String = "Are you sure you want to exit?"

        Dim confirmResult As DialogResult = MessageBox.Show(confirmation, "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainDashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class