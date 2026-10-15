<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderHistoryForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.cmsOrderStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkAsPendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsPaidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsShippedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsCompletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbStatusFilter = New System.Windows.Forms.ComboBox()
        Me.Filter = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsOrderStatus.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvOrders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(126, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrders.ColumnHeadersHeight = 38
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvOrders.ContextMenuStrip = Me.cmsOrderStatus
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrders.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrders.EnableHeadersVisualStyles = False
        Me.dgvOrders.GridColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvOrders.Location = New System.Drawing.Point(0, 112)
        Me.dgvOrders.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.ReadOnly = True
        Me.dgvOrders.RowHeadersVisible = False
        Me.dgvOrders.RowHeadersWidth = 51
        Me.dgvOrders.RowTemplate.Height = 28
        Me.dgvOrders.Size = New System.Drawing.Size(1000, 448)
        Me.dgvOrders.TabIndex = 0
        '
        'cmsOrderStatus
        '
        Me.cmsOrderStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cmsOrderStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cmsOrderStatus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsOrderStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkAsPendingToolStripMenuItem, Me.MarkAsPaidToolStripMenuItem, Me.MarkAsShippedToolStripMenuItem, Me.MarkAsCompletedToolStripMenuItem, Me.CancelOrderToolStripMenuItem, Me.DeleteOrderToolStripMenuItem})
        Me.cmsOrderStatus.Name = "cmsOrderStatus"
        Me.cmsOrderStatus.ShowImageMargin = False
        Me.cmsOrderStatus.Size = New System.Drawing.Size(183, 148)
        '
        'MarkAsPendingToolStripMenuItem
        '
        Me.MarkAsPendingToolStripMenuItem.Name = "MarkAsPendingToolStripMenuItem"
        Me.MarkAsPendingToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.MarkAsPendingToolStripMenuItem.Text = "Mark as Pending"
        '
        'MarkAsPaidToolStripMenuItem
        '
        Me.MarkAsPaidToolStripMenuItem.Name = "MarkAsPaidToolStripMenuItem"
        Me.MarkAsPaidToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.MarkAsPaidToolStripMenuItem.Text = "Mark as Paid"
        '
        'MarkAsShippedToolStripMenuItem
        '
        Me.MarkAsShippedToolStripMenuItem.Name = "MarkAsShippedToolStripMenuItem"
        Me.MarkAsShippedToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.MarkAsShippedToolStripMenuItem.Text = "Mark as Shipped"
        '
        'MarkAsCompletedToolStripMenuItem
        '
        Me.MarkAsCompletedToolStripMenuItem.Name = "MarkAsCompletedToolStripMenuItem"
        Me.MarkAsCompletedToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.MarkAsCompletedToolStripMenuItem.Text = "Mark as Completed"
        '
        'CancelOrderToolStripMenuItem
        '
        Me.CancelOrderToolStripMenuItem.Name = "CancelOrderToolStripMenuItem"
        Me.CancelOrderToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.CancelOrderToolStripMenuItem.Text = "Cancel Order"
        '
        'DeleteOrderToolStripMenuItem
        '
        Me.DeleteOrderToolStripMenuItem.Name = "DeleteOrderToolStripMenuItem"
        Me.DeleteOrderToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.DeleteOrderToolStripMenuItem.Text = "Remove Order"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.btnReset)
        Me.pnlHeader.Controls.Add(Me.cmbStatusFilter)
        Me.pnlHeader.Controls.Add(Me.Filter)
        Me.pnlHeader.Controls.Add(Me.txtSearch)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1000, 112)
        Me.pnlHeader.TabIndex = 7
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(685, 68)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 34)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(585, 68)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 34)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cmbStatusFilter
        '
        Me.cmbStatusFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatusFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatusFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cmbStatusFilter.FormattingEnabled = True
        Me.cmbStatusFilter.Location = New System.Drawing.Point(415, 73)
        Me.cmbStatusFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbStatusFilter.Name = "cmbStatusFilter"
        Me.cmbStatusFilter.Size = New System.Drawing.Size(140, 31)
        Me.cmbStatusFilter.TabIndex = 4
        '
        'Filter
        '
        Me.Filter.AutoSize = True
        Me.Filter.BackColor = System.Drawing.Color.Transparent
        Me.Filter.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filter.ForeColor = System.Drawing.Color.White
        Me.Filter.Location = New System.Drawing.Point(315, 77)
        Me.Filter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(115, 21)
        Me.Filter.TabIndex = 3
        Me.Filter.Text = "Filter by Status:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(80, 73)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(210, 30)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(18, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(212, 41)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Order History"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 10)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(154, 20)
        Me.lblSubtitle.TabIndex = 8
        Me.lblSubtitle.Text = "Staff Ordering System"
        '
        'OrderHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 560)
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(820, 400)
        Me.Name = "OrderHistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clothing Store Staff Ordering System - Order History"
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsOrderStatus.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents dgvOrders As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Filter As System.Windows.Forms.Label
    Friend WithEvents cmbStatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cmsOrderStatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MarkAsPendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkAsPaidToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkAsShippedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkAsCompletedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
End Class
