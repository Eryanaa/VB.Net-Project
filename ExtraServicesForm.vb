Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ExtraServicesForm

    Private Sub ExtraServicesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Reset session discount state
        OrderSession.AppliedPromoCode = ""
        OrderSession.DiscountAmount = 0D

        ' Initial calculation
        RecalculateSummary()
    End Sub

    ' Recompute totals whenever an extra service checkbox state changes
    Private Sub chkPremiumPackaging_CheckedChanged(sender As Object, e As EventArgs) Handles chkPremiumPackaging.CheckedChanged
        RecalculateSummary()
    End Sub

    Private Sub chkExpressDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkExpressDelivery.CheckedChanged
        RecalculateSummary()

        If chkExpressDelivery.Checked = True Then
            lblAddress.Visible = True
            txtAddress.Visible = True
        End If

        If chkExpressDelivery.Checked = False Then
            lblAddress.Visible = False
            txtAddress.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Central calculation engine for Services, Discounts, and Final Totals
    ''' </summary>
    Private Sub RecalculateSummary()
        Dim subtotal As Decimal = OrderSession.ProductsSubtotal
        Dim packagingFee As Decimal = If(chkPremiumPackaging.Checked, OrderSession.FEE_PACKAGING, 0D)
        Dim expressFee As Decimal = If(chkExpressDelivery.Checked, OrderSession.FEE_EXPRESS, 0D)

        ' 1. Automatic Tiered Promotion: Free Express Delivery if Subtotal >= RM 100
        Dim autoDiscount As Decimal = 0D
        If subtotal >= 100D AndAlso chkExpressDelivery.Checked Then
            autoDiscount += OrderSession.FEE_EXPRESS ' Waive the RM 10 express delivery fee
        End If

        ' 2. Promo Code Calculation
        Dim codeDiscount As Decimal = 0D
        Select Case OrderSession.AppliedPromoCode.ToUpper()
            Case "WELCOME10"
                codeDiscount = Math.Round(subtotal * 0.1D, 2) ' 10% off items
            Case "SAVE15"
                If subtotal >= 50D Then
                    codeDiscount = 15D
                End If
            Case "VIP20"
                codeDiscount = Math.Round(subtotal * 0.2D, 2) ' 20% off items
        End Select

        ' Combine discounts (Total discount cannot exceed order total)
        Dim totalServices As Decimal = packagingFee + expressFee
        Dim grossTotal As Decimal = subtotal + totalServices
        Dim totalDiscount As Decimal = autoDiscount + codeDiscount

        If totalDiscount > grossTotal Then
            totalDiscount = grossTotal
        End If

        Dim finalAmount As Decimal = grossTotal - totalDiscount

        ' Store in Session
        OrderSession.ServiceFee = totalServices
        OrderSession.DiscountAmount = totalDiscount
        OrderSession.FinalTotal = finalAmount

        ' Update Display Fields
        txtTotalPayment.Text = "RM " & grossTotal.ToString("0.00")
        txtDiscountApplied.Text = "RM " & totalDiscount.ToString("0.00")
        txtFinalPayment.Text = "RM " & finalAmount.ToString("0.00")
    End Sub

    ' Promo Code Button Handler
    Private Sub btnApplyPromo_Click(sender As Object, e As EventArgs) Handles btnApplyPromo.Click
        Dim inputCode As String = txtPromoCode.Text.Trim().ToUpper()

        If String.IsNullOrEmpty(inputCode) Then
            MessageBox.Show("Please enter a promo code.", "Empty Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Select Case inputCode
            Case "WELCOME10"
                OrderSession.AppliedPromoCode = "WELCOME10"
                lblPromoMessage.ForeColor = Color.Green
                lblPromoMessage.Text = "Code Applied: 10% discount on clothing items!"

            Case "SAVE15"
                If OrderSession.ProductsSubtotal < 50D Then
                    MessageBox.Show("Promo code 'SAVE15' requires a minimum product subtotal of RM 50.00.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                OrderSession.AppliedPromoCode = "SAVE15"
                lblPromoMessage.ForeColor = Color.Green
                lblPromoMessage.Text = "Code Applied: RM 15.00 flat discount!"

            Case "VIP20"
                OrderSession.AppliedPromoCode = "VIP20"
                lblPromoMessage.ForeColor = Color.Green
                lblPromoMessage.Text = "Code Applied: VIP 20% discount on clothing items!"

            Case Else
                MessageBox.Show("Invalid promo code. Please check and try again.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        RecalculateSummary()
    End Sub

    ' Submit Order & Generate Receipt
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim address As String = txtAddress.Text.Trim()
            Dim hasPackaging As Boolean = chkPremiumPackaging.Checked
            Dim hasExpress As Boolean = chkExpressDelivery.Checked

            ' Address check if express delivery is chosen
            If hasExpress AndAlso String.IsNullOrEmpty(address) Then
                MessageBox.Show("Delivery Address is required when Express Delivery is selected.", "Address Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddress.Focus()
                Return
            End If

            ' Recalculate to ensure absolute accuracy
            RecalculateSummary()

            ' Confirmation Dialog (using standard '&' string concatenation)
            Dim packagingText As String = If(hasPackaging, "RM " & OrderSession.FEE_PACKAGING.ToString("0.00"), "None")
            Dim expressText As String = If(hasExpress, "RM " & OrderSession.FEE_EXPRESS.ToString("0.00"), "None")
            Dim promoText As String = If(String.IsNullOrEmpty(OrderSession.AppliedPromoCode), "None", OrderSession.AppliedPromoCode)

            Dim confirmPrompt As String = "Please review your final order:" & vbCrLf & vbCrLf &
                                          "- Products Subtotal: RM " & OrderSession.ProductsSubtotal.ToString("0.00") & vbCrLf &
                                          "- Packaging Fee: " & packagingText & vbCrLf &
                                          "- Express Delivery: " & expressText & vbCrLf &
                                          "- Promo Code: " & promoText & vbCrLf &
                                          "- Total Discount: -RM " & OrderSession.DiscountAmount.ToString("0.00") & vbCrLf &
                                          "- Final Total: RM " & OrderSession.FinalTotal.ToString("0.00") & vbCrLf & vbCrLf &
                                          "Proceed to generate customer receipt and save to database?"

            If MessageBox.Show(confirmPrompt, "Confirm Final Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If

            ' Build Formatted Receipt Text
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("==================================================")
            sb.AppendLine("                 CLOTHING STORE                   ")
            sb.AppendLine("         REMOTE ORDERING MANAGEMENT SYSTEM        ")
            sb.AppendLine("==================================================")
            sb.AppendLine("Order ID       : #" & OrderSession.CurrentOrderId.ToString())
            sb.AppendLine("Date & Time    : " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            sb.AppendLine("Customer Name  : " & OrderSession.CustomerName)
            sb.AppendLine("Contact Number : " & OrderSession.CustomerContact)
            If Not String.IsNullOrEmpty(address) Then
                sb.AppendLine("Delivery Addr  : " & address)
            End If
            sb.AppendLine("--------------------------------------------------")
            sb.AppendLine(String.Format("{0,-20} {1,-6} {2,5} {3,12}", "Item", "Size", "Qty", "Total (RM)"))
            sb.AppendLine("--------------------------------------------------")

            If OrderSession.SelectedItems IsNot Nothing Then
                For Each item In OrderSession.SelectedItems
                    sb.AppendLine(String.Format("{0,-20} {1,-6} {2,5} {3,12:0.00}", item.ProductName, item.Size, item.Quantity, item.Subtotal))
                Next
            End If

            sb.AppendLine("--------------------------------------------------")
            sb.AppendLine(String.Format("{0,-33} {1,12:0.00}", "Products Subtotal:", OrderSession.ProductsSubtotal))
            If hasPackaging Then
                sb.AppendLine(String.Format("{0,-33} {1,12:0.00}", "Premium Packaging:", OrderSession.FEE_PACKAGING))
            End If
            If hasExpress Then
                sb.AppendLine(String.Format("{0,-33} {1,12:0.00}", "Express Delivery:", OrderSession.FEE_EXPRESS))
            End If

            If OrderSession.DiscountAmount > 0D Then
                Dim discountLabel As String = "Discount Applied"
                If Not String.IsNullOrEmpty(OrderSession.AppliedPromoCode) Then
                    discountLabel &= " (" & OrderSession.AppliedPromoCode & ")"
                End If
                discountLabel &= ":"
                sb.AppendLine(String.Format("{0,-33} -{1,11:0.00}", discountLabel, OrderSession.DiscountAmount))
            End If

            sb.AppendLine("==================================================")
            sb.AppendLine(String.Format("{0,-33} {1,12:0.00}", "FINAL TOTAL (RM):", OrderSession.FinalTotal))
            sb.AppendLine("==================================================")
            sb.AppendLine("           Thank you for shopping with us!        ")

            Dim receiptContent As String = sb.ToString()

            ' Prompt Save File Dialog
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Text Files (*.txt)|*.txt"
                sfd.FileName = "Receipt_Order_" & OrderSession.CurrentOrderId.ToString() & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".txt"
                sfd.Title = "Save Customer Receipt"

                If sfd.ShowDialog() = DialogResult.OK Then
                    File.WriteAllText(sfd.FileName, receiptContent)

                    ' Update Database Record
                    Using conn As New MySqlConnection(OrderSession.ConnStr)
                        conn.Open()
                        Dim updateSql As String = "UPDATE `orders` SET " &
                                                  "`address` = @addr, " &
                                                  "`premium_packaging` = @pkg, " &
                                                  "`express_delivery` = @exp, " &
                                                  "`promo_code` = @promo, " &
                                                  "`discount_applied` = @discount, " &
                                                  "`services_fee` = @fee, " &
                                                  "`total_amount` = @total " &
                                                  "WHERE `order_id` = @oid;"

                        Using cmd As New MySqlCommand(updateSql, conn)
                            cmd.Parameters.Add("@addr", MySqlDbType.VarChar).Value = If(String.IsNullOrEmpty(address), "", address)
                            cmd.Parameters.Add("@pkg", MySqlDbType.Int32).Value = If(hasPackaging, 1, 0)
                            cmd.Parameters.Add("@exp", MySqlDbType.Int32).Value = If(hasExpress, 1, 0)
                            cmd.Parameters.Add("@promo", MySqlDbType.VarChar).Value = If(String.IsNullOrEmpty(OrderSession.AppliedPromoCode), DBNull.Value, OrderSession.AppliedPromoCode)
                            cmd.Parameters.Add("@discount", MySqlDbType.Decimal).Value = OrderSession.DiscountAmount
                            cmd.Parameters.Add("@fee", MySqlDbType.Decimal).Value = OrderSession.ServiceFee
                            cmd.Parameters.Add("@total", MySqlDbType.Decimal).Value = OrderSession.FinalTotal
                            cmd.Parameters.Add("@oid", MySqlDbType.Int32).Value = OrderSession.CurrentOrderId

                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Order finalized successfully!" & vbCrLf & "Receipt saved at: " & sfd.FileName, "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open the receipt automatically in Notepad
                    Process.Start("notepad.exe", sfd.FileName)

                    MainDashboardForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Save cancelled. Order was not finalized.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error processing final order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub
End Class

