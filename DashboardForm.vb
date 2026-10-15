Imports MySql.Data.MySqlClient

Public Class MainDashboardForm

    Private Sub MainDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardMetrics()
    End Sub

    Private Sub MainDashboardForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Automatically refresh metrics whenever staff returns to the dashboard
        LoadDashboardMetrics()
    End Sub

    ''' <summary>
    ''' Queries database for summary figures: today's revenue, order count, and pending queue
    ''' </summary>
    Public Sub LoadDashboardMetrics()
        Try
            Using conn As New MySqlConnection(OrderSession.ConnStr)
                conn.Open()

                ' 1. Today's Revenue
                Dim sqlSales As String = "SELECT IFNULL(SUM(total_amount), 0.00) FROM orders WHERE DATE(order_date) = CURDATE();"
                Using cmdSales As New MySqlCommand(sqlSales, conn)
                    Dim todaySales As Decimal = Convert.ToDecimal(cmdSales.ExecuteScalar())
                    lblTodaySales.Text = "RM " & todaySales.ToString("0.00")
                End Using

                ' 2. Today's Total Orders
                Dim sqlOrders As String = "SELECT COUNT(*) FROM orders WHERE DATE(order_date) = CURDATE();"
                Using cmdOrders As New MySqlCommand(sqlOrders, conn)
                    Dim countOrders As Integer = Convert.ToInt32(cmdOrders.ExecuteScalar())
                    lblTodayOrders.Text = countOrders.ToString()
                End Using

                ' 3. Total Pending Orders
                Dim sqlPending As String = "SELECT COUNT(*) FROM orders WHERE order_status = 'Pending';"
                Using cmdPending As New MySqlCommand(sqlPending, conn)
                    Dim countPending As Integer = Convert.ToInt32(cmdPending.ExecuteScalar())
                    lblPendingOrders.Text = countPending.ToString()
                End Using
            End Using
        Catch ex As Exception
            ' Keep dashboard accessible even if database connection is temporarily offline
            lblTodaySales.Text = "RM 0.00"
            lblTodayOrders.Text = "0"
            lblPendingOrders.Text = "0"
        End Try
    End Sub

    ' 1. Place Order Button -> Starts with CustomerInfoForm
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        ' Clear previous customer and cart data
        OrderSession.ResetOrderSession()

        ' Open CustomerInfoForm and hide Dashboard
        Dim customerForm As New CustomerInfoForm()
        customerForm.Show()
        Me.Hide()
    End Sub

    ' 2. Order History Button -> Opens OrderHistoryForm
    Private Sub btnOrderHistory_Click(sender As Object, e As EventArgs) Handles btnOrderHistory.Click
        Dim historyForm As New OrderHistoryForm()
        historyForm.Show()
        Me.Hide()
        ' Refresh metrics after closing history in case statuses were updated
        LoadDashboardMetrics()
    End Sub

    ' 3. About Box Button -> Opens AboutBox
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim about As New AboutBox()
        about.ShowDialog()
    End Sub

    ' 4. Exit Button -> Closes System Safely
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to exit the Ordering System?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Refresh Button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDashboardMetrics()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
