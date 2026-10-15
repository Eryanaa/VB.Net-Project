<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExtraServicesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExtraServicesForm))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpServices = New System.Windows.Forms.GroupBox()
        Me.lblPromoMessage = New System.Windows.Forms.Label()
        Me.btnApplyPromo = New System.Windows.Forms.Button()
        Me.txtPromoCode = New System.Windows.Forms.TextBox()
        Me.lblPromoCaption = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.chkExpressDelivery = New System.Windows.Forms.CheckBox()
        Me.chkPremiumPackaging = New System.Windows.Forms.CheckBox()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.txtFinalPayment = New System.Windows.Forms.TextBox()
        Me.lblFinalCaption = New System.Windows.Forms.Label()
        Me.txtDiscountApplied = New System.Windows.Forms.TextBox()
        Me.lblDiscountCaption = New System.Windows.Forms.Label()
        Me.txtTotalPayment = New System.Windows.Forms.TextBox()
        Me.lblTotalCaption = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpServices.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(500, 80)
        Me.pnlHeader.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(213, 41)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Extra Services"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 12)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(154, 20)
        Me.lblSubtitle.TabIndex = 0
        Me.lblSubtitle.Text = "Staff Ordering System"
        '
        'grpServices
        '
        Me.grpServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.grpServices.Controls.Add(Me.lblPromoMessage)
        Me.grpServices.Controls.Add(Me.btnApplyPromo)
        Me.grpServices.Controls.Add(Me.txtPromoCode)
        Me.grpServices.Controls.Add(Me.lblPromoCaption)
        Me.grpServices.Controls.Add(Me.txtAddress)
        Me.grpServices.Controls.Add(Me.lblAddress)
        Me.grpServices.Controls.Add(Me.chkExpressDelivery)
        Me.grpServices.Controls.Add(Me.chkPremiumPackaging)
        Me.grpServices.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grpServices.Location = New System.Drawing.Point(30, 100)
        Me.grpServices.Name = "grpServices"
        Me.grpServices.Size = New System.Drawing.Size(440, 240)
        Me.grpServices.TabIndex = 0
        Me.grpServices.TabStop = False
        Me.grpServices.Text = "Extra Services"
        '
        'lblPromoMessage
        '
        Me.lblPromoMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromoMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblPromoMessage.Location = New System.Drawing.Point(24, 196)
        Me.lblPromoMessage.Name = "lblPromoMessage"
        Me.lblPromoMessage.Size = New System.Drawing.Size(392, 32)
        Me.lblPromoMessage.TabIndex = 7
        Me.lblPromoMessage.Text = "-- NONE DISCOUNT APPLIED --"
        Me.lblPromoMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnApplyPromo
        '
        Me.btnApplyPromo.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnApplyPromo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApplyPromo.FlatAppearance.BorderSize = 0
        Me.btnApplyPromo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnApplyPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyPromo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyPromo.ForeColor = System.Drawing.Color.White
        Me.btnApplyPromo.Location = New System.Drawing.Point(305, 151)
        Me.btnApplyPromo.Name = "btnApplyPromo"
        Me.btnApplyPromo.Size = New System.Drawing.Size(110, 32)
        Me.btnApplyPromo.TabIndex = 6
        Me.btnApplyPromo.Text = "Apply"
        Me.btnApplyPromo.UseVisualStyleBackColor = False
        '
        'txtPromoCode
        '
        Me.txtPromoCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtPromoCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPromoCode.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromoCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtPromoCode.Location = New System.Drawing.Point(110, 154)
        Me.txtPromoCode.Name = "txtPromoCode"
        Me.txtPromoCode.Size = New System.Drawing.Size(180, 30)
        Me.txtPromoCode.TabIndex = 5
        '
        'lblPromoCaption
        '
        Me.lblPromoCaption.AutoSize = True
        Me.lblPromoCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromoCaption.ForeColor = System.Drawing.Color.White
        Me.lblPromoCaption.Location = New System.Drawing.Point(24, 158)
        Me.lblPromoCaption.Name = "lblPromoCaption"
        Me.lblPromoCaption.Size = New System.Drawing.Size(100, 21)
        Me.lblPromoCaption.TabIndex = 4
        Me.lblPromoCaption.Text = "Promo Code:"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(100, 108)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(315, 30)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Visible = False
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(24, 112)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(69, 21)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.Visible = False
        '
        'chkExpressDelivery
        '
        Me.chkExpressDelivery.AutoSize = True
        Me.chkExpressDelivery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkExpressDelivery.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExpressDelivery.ForeColor = System.Drawing.Color.White
        Me.chkExpressDelivery.Location = New System.Drawing.Point(24, 72)
        Me.chkExpressDelivery.Name = "chkExpressDelivery"
        Me.chkExpressDelivery.Size = New System.Drawing.Size(153, 27)
        Me.chkExpressDelivery.TabIndex = 1
        Me.chkExpressDelivery.Text = "Express Delivery"
        Me.chkExpressDelivery.UseVisualStyleBackColor = True
        '
        'chkPremiumPackaging
        '
        Me.chkPremiumPackaging.AutoSize = True
        Me.chkPremiumPackaging.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkPremiumPackaging.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPremiumPackaging.ForeColor = System.Drawing.Color.White
        Me.chkPremiumPackaging.Location = New System.Drawing.Point(24, 36)
        Me.chkPremiumPackaging.Name = "chkPremiumPackaging"
        Me.chkPremiumPackaging.Size = New System.Drawing.Size(183, 27)
        Me.chkPremiumPackaging.TabIndex = 0
        Me.chkPremiumPackaging.Text = "Premium Packaging"
        Me.chkPremiumPackaging.UseVisualStyleBackColor = True
        '
        'grpSummary
        '
        Me.grpSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.grpSummary.Controls.Add(Me.txtFinalPayment)
        Me.grpSummary.Controls.Add(Me.lblFinalCaption)
        Me.grpSummary.Controls.Add(Me.txtDiscountApplied)
        Me.grpSummary.Controls.Add(Me.lblDiscountCaption)
        Me.grpSummary.Controls.Add(Me.txtTotalPayment)
        Me.grpSummary.Controls.Add(Me.lblTotalCaption)
        Me.grpSummary.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.grpSummary.Location = New System.Drawing.Point(30, 358)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(440, 160)
        Me.grpSummary.TabIndex = 1
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary"
        '
        'txtFinalPayment
        '
        Me.txtFinalPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txtFinalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinalPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalPayment.ForeColor = System.Drawing.Color.White
        Me.txtFinalPayment.Location = New System.Drawing.Point(180, 108)
        Me.txtFinalPayment.Name = "txtFinalPayment"
        Me.txtFinalPayment.ReadOnly = True
        Me.txtFinalPayment.Size = New System.Drawing.Size(215, 34)
        Me.txtFinalPayment.TabIndex = 5
        Me.txtFinalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFinalCaption
        '
        Me.lblFinalCaption.AutoSize = True
        Me.lblFinalCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCaption.ForeColor = System.Drawing.Color.White
        Me.lblFinalCaption.Location = New System.Drawing.Point(40, 114)
        Me.lblFinalCaption.Name = "lblFinalCaption"
        Me.lblFinalCaption.Size = New System.Drawing.Size(128, 23)
        Me.lblFinalCaption.TabIndex = 4
        Me.lblFinalCaption.Text = "Final Payment:"
        '
        'txtDiscountApplied
        '
        Me.txtDiscountApplied.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtDiscountApplied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscountApplied.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountApplied.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtDiscountApplied.Location = New System.Drawing.Point(180, 68)
        Me.txtDiscountApplied.Name = "txtDiscountApplied"
        Me.txtDiscountApplied.ReadOnly = True
        Me.txtDiscountApplied.Size = New System.Drawing.Size(215, 30)
        Me.txtDiscountApplied.TabIndex = 3
        Me.txtDiscountApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiscountCaption
        '
        Me.lblDiscountCaption.AutoSize = True
        Me.lblDiscountCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountCaption.ForeColor = System.Drawing.Color.White
        Me.lblDiscountCaption.Location = New System.Drawing.Point(40, 72)
        Me.lblDiscountCaption.Name = "lblDiscountCaption"
        Me.lblDiscountCaption.Size = New System.Drawing.Size(131, 21)
        Me.lblDiscountCaption.TabIndex = 2
        Me.lblDiscountCaption.Text = "Discount Applied:"
        '
        'txtTotalPayment
        '
        Me.txtTotalPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPayment.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtTotalPayment.Location = New System.Drawing.Point(180, 32)
        Me.txtTotalPayment.Name = "txtTotalPayment"
        Me.txtTotalPayment.ReadOnly = True
        Me.txtTotalPayment.Size = New System.Drawing.Size(215, 30)
        Me.txtTotalPayment.TabIndex = 1
        Me.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalCaption
        '
        Me.lblTotalCaption.AutoSize = True
        Me.lblTotalCaption.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCaption.ForeColor = System.Drawing.Color.White
        Me.lblTotalCaption.Location = New System.Drawing.Point(40, 36)
        Me.lblTotalCaption.Name = "lblTotalCaption"
        Me.lblTotalCaption.Size = New System.Drawing.Size(109, 21)
        Me.lblTotalCaption.TabIndex = 0
        Me.lblTotalCaption.Text = "Total Payment:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(140, 536)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(220, 44)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'ExtraServicesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 600)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.grpServices)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ExtraServicesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clothing Store Staff Ordering System - Extra Services"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpServices.ResumeLayout(False)
        Me.grpServices.PerformLayout()
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpServices As System.Windows.Forms.GroupBox
    Friend WithEvents chkPremiumPackaging As System.Windows.Forms.CheckBox
    Friend WithEvents chkExpressDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblPromoCaption As System.Windows.Forms.Label
    Friend WithEvents txtPromoCode As System.Windows.Forms.TextBox
    Friend WithEvents btnApplyPromo As System.Windows.Forms.Button
    Friend WithEvents lblPromoMessage As System.Windows.Forms.Label
    Friend WithEvents grpSummary As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalCaption As System.Windows.Forms.Label
    Friend WithEvents txtTotalPayment As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscountCaption As System.Windows.Forms.Label
    Friend WithEvents txtDiscountApplied As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalCaption As System.Windows.Forms.Label
    Friend WithEvents txtFinalPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
