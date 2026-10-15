Imports MySql.Data.MySqlClient

Public Class OrderHistoryForm

    Private Sub OrderHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Setup Filter Dropdown
        cmbStatusFilter.Items.Clear()
        cmbStatusFilter.Items.AddRange(New String() {"All", "Pending", "Paid", "Shipped", "Completed"})
        cmbStatusFilter.SelectedIndex = 0

        LoadOrders()
    End Sub

    Private Sub StyleControls(ctls As Control.ControlCollection, panelBlue As Color, headerBlue As Color, cardBlue As Color, inputBg As Color, textLight As Color)
        For Each c As Control In ctls
            If TypeOf c Is Panel Then
                c.BackColor = panelBlue
            ElseIf TypeOf c Is Label Then
                c.ForeColor = textLight
                c.BackColor = Color.Transparent
            ElseIf TypeOf c Is Button Then
                Dim b As Button = DirectCast(c, Button)
                b.FlatStyle = FlatStyle.Flat
                b.FlatAppearance.BorderSize = 0
                b.BackColor = cardBlue
                b.ForeColor = Color.White
                b.Cursor = Cursors.Hand
            ElseIf TypeOf c Is TextBox Then
                c.BackColor = inputBg
                c.ForeColor = textLight
                DirectCast(c, TextBox).BorderStyle = BorderStyle.FixedSingle
            ElseIf TypeOf c Is ComboBox Then
                Dim cb As ComboBox = DirectCast(c, ComboBox)
                cb.FlatStyle = FlatStyle.Flat
                cb.BackColor = inputBg
                cb.ForeColor = textLight
            ElseIf TypeOf c Is DataGridView Then
                Dim g As DataGridView = DirectCast(c, DataGridView)
                g.BackgroundColor = Color.FromArgb(13, 23, 33)
                g.BorderStyle = BorderStyle.None
                g.GridColor = Color.FromArgb(40, 65, 90)
                g.EnableHeadersVisualStyles = False
                g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                g.ColumnHeadersDefaultCellStyle.BackColor = headerBlue
                g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                g.ColumnHeadersDefaultCellStyle.SelectionBackColor = headerBlue
                g.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                g.ColumnHeadersHeight = 36
                g.DefaultCellStyle.BackColor = Color.FromArgb(20, 34, 48)
                g.DefaultCellStyle.ForeColor = textLight
                g.DefaultCellStyle.SelectionBackColor = cardBlue
                g.DefaultCellStyle.SelectionForeColor = Color.White
                g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(26, 42, 58)
                g.RowHeadersVisible = False
                g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

            If c.HasChildren Then
                StyleControls(c.Controls, panelBlue, headerBlue, cardBlue, inputBg, textLight)
            End If
        Next
    End Sub
    ' ============================================================================

    ' Search Box live filtering as user types
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadOrders()
    End Sub

    ' Dropdown status filter change
    Private Sub cmbStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatusFilter.SelectedIndexChanged
        LoadOrders()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSearch.Clear()
        cmbStatusFilter.SelectedIndex = 0
        LoadOrders()
    End Sub

    Public Sub LoadOrders()
        Dim keyword As String = txtSearch.Text.Trim()
        Dim selectedStatus As String = If(cmbStatusFilter.SelectedItem IsNot Nothing, cmbStatusFilter.SelectedItem.ToString(), "All")

        ' Base Query
        Dim query As String = "SELECT " &
                              "  o.order_id AS `Order ID`, " &
                              "  c.name AS `Customer Name`, " &
                              "  c.contact_number AS `Contact Number`, " &
                              "  GROUP_CONCAT(CONCAT(oi.product_name, ' (', oi.size, ') x', oi.quantity) SEPARATOR '; ') AS `Purchased Products`, " &
                              "  o.total_amount AS `Total (RM)`, " &
                              "  o.order_status AS `Order Status`, " &
                              "  o.order_date AS `Order Date` " &
                              "FROM orders o " &
                              "INNER JOIN customers c ON o.customer_id = c.customer_id " &
                              "LEFT JOIN order_items oi ON o.order_id = oi.order_id " &
                              "WHERE 1=1 "

        ' Append Search Filters
        If Not String.IsNullOrEmpty(keyword) Then
            query &= " AND (c.name LIKE @kw OR c.contact_number LIKE @kw OR CAST(o.order_id AS CHAR) LIKE @kw) "
        End If

        If selectedStatus <> "All" Then
            query &= " AND o.order_status = @status "
        End If

        query &= " GROUP BY o.order_id, c.name, c.contact_number, o.total_amount, o.order_status, o.order_date " &
                 " ORDER BY o.order_id DESC;"

        Try
            Using conn As New MySqlConnection(OrderSession.ConnStr)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    If Not String.IsNullOrEmpty(keyword) Then
                        cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    End If
                    If selectedStatus <> "All" Then
                        cmd.Parameters.AddWithValue("@status", selectedStatus)
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvOrders.DataSource = dt

                        ' Layout styling
                        dgvOrders.ReadOnly = True
                        dgvOrders.AllowUserToAddRows = False
                        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        dgvOrders.MultiSelect = False
                        dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        dgvOrders.DefaultCellStyle.WrapMode = DataGridViewTriState.True

                        ' Give the products column more room than the others
                        If dgvOrders.Columns.Contains("Purchased Products") Then
                            dgvOrders.Columns("Purchased Products").FillWeight = 250
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to fetch records: " & ex.Message, "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Auto-select the row on right-click so context menu targets the correct order
    Private Sub dgvOrders_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOrders.CellMouseDown
        If e.Button = MouseButtons.Right AndAlso e.RowIndex >= 0 Then
            dgvOrders.ClearSelection()
            dgvOrders.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    ' Helper to update status in Database
    Private Sub UpdateSelectedOrderStatus(newStatus As String)
        If dgvOrders.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an order row first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvOrders.SelectedRows(0)
        Dim orderId As Integer = Convert.ToInt32(selectedRow.Cells("Order ID").Value)

        Try
            Using conn As New MySqlConnection(OrderSession.ConnStr)
                conn.Open()
                Dim updateSql As String = "UPDATE orders SET order_status = @status WHERE order_id = @oid;"
                Using cmd As New MySqlCommand(updateSql, conn)
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@oid", orderId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Order #" & orderId & " marked as '" & newStatus & "'.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadOrders()

        Catch ex As Exception
            MessageBox.Show("Failed to update status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Context Menu Click Handlers
    Private Sub MarkAsPendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsPendingToolStripMenuItem.Click
        UpdateSelectedOrderStatus("Pending")
    End Sub

    Private Sub MarkAsPaidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsPaidToolStripMenuItem.Click
        UpdateSelectedOrderStatus("Paid")
    End Sub

    Private Sub MarkAsShippedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsShippedToolStripMenuItem.Click
        UpdateSelectedOrderStatus("Shipped")
    End Sub

    Private Sub MarkAsCompletedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsCompletedToolStripMenuItem.Click
        UpdateSelectedOrderStatus("Completed")
    End Sub

    Private Sub CancelOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelOrderToolStripMenuItem.Click
        If dgvOrders.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an order to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvOrders.SelectedRows(0)
        Dim orderId As Integer = Convert.ToInt32(selectedRow.Cells("Order ID").Value)

        Dim confirmMsg As String = "Are you sure you want to mark Order #" & orderId.ToString() & " as Cancelled?"
        If MessageBox.Show(confirmMsg, "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UpdateSelectedOrderStatus("Cancelled")
        End If
    End Sub

    Private Sub DeleteOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteOrderToolStripMenuItem.Click
        If dgvOrders.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an order to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvOrders.SelectedRows(0)
        Dim orderId As Integer = Convert.ToInt32(selectedRow.Cells("Order ID").Value)

        Dim confirmMsg As String = "Are you sure you want to permanently DELETE Order #" & orderId.ToString() & "?" & vbCrLf & vbCrLf &
                                   "WARNING: This will permanently remove the order and all its clothing items from the database!"

        If MessageBox.Show(confirmMsg, "Confirm Permanent Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(OrderSession.ConnStr)
                    conn.Open()

                    ' Use a Transaction to ensure both tables stay synchronized
                    Using trans As MySqlTransaction = conn.BeginTransaction()
                        Try
                            ' Step 1: Delete from child table (order_items) first
                            Dim deleteItemsSql As String = "DELETE FROM `order_items` WHERE `order_id` = @oid;"
                            Using cmdItems As New MySqlCommand(deleteItemsSql, conn, trans)
                                cmdItems.Parameters.AddWithValue("@oid", orderId)
                                cmdItems.ExecuteNonQuery()
                            End Using

                            ' Step 2: Delete from parent table (orders)
                            Dim deleteOrderSql As String = "DELETE FROM `orders` WHERE `order_id` = @oid;"
                            Using cmdOrder As New MySqlCommand(deleteOrderSql, conn, trans)
                                cmdOrder.Parameters.AddWithValue("@oid", orderId)
                                cmdOrder.ExecuteNonQuery()
                            End Using

                            ' Commit transaction
                            trans.Commit()

                            MessageBox.Show("Order #" & orderId.ToString() & " has been successfully removed.", "Order Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the table
                            LoadOrders()

                        Catch exTrans As Exception
                            trans.Rollback()
                            Throw exTrans
                        End Try
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Failed to delete order from database:" & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainDashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub dgvOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrders.CellContentClick

    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub
End Class

