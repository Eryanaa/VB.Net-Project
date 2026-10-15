<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutBox
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblBrandIcon As System.Windows.Forms.Label
    Friend WithEvents lblBrandName As System.Windows.Forms.Label
    Friend WithEvents lblBrandSub As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.pnlBrand = New System.Windows.Forms.Panel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblBrandSub = New System.Windows.Forms.Label()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.lblBrandIcon = New System.Windows.Forms.Label()
        Me.TableLayoutPanel.SuspendLayout()
        Me.pnlBrand.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TableLayoutPanel.ColumnCount = 1
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 0, 4)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(190, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.Padding = New System.Windows.Forms.Padding(24, 24, 24, 18)
        Me.TableLayoutPanel.RowCount = 5
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.Size = New System.Drawing.Size(450, 400)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LabelProductName
        '
        Me.LabelProductName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.ForeColor = System.Drawing.Color.White
        Me.LabelProductName.Location = New System.Drawing.Point(27, 24)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(3, 0, 3, 6)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(390, 0)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(388, 64)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Clothing Store Remote Ordering Management"
        '
        'LabelVersion
        '
        Me.LabelVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.LabelVersion.Location = New System.Drawing.Point(27, 94)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(106, 23)
        Me.LabelVersion.TabIndex = 1
        Me.LabelVersion.Text = "Version 5.1.1"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.LabelCopyright.Location = New System.Drawing.Point(27, 119)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(244, 20)
        Me.LabelCopyright.TabIndex = 2
        Me.LabelCopyright.Text = "© 2026 Group 4. All rights reserved."
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDescription.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextBoxDescription.Location = New System.Drawing.Point(27, 155)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(3, 16, 3, 12)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDescription.Size = New System.Drawing.Size(396, 175)
        Me.TextBoxDescription.TabIndex = 3
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'OKButton
        '
        Me.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.OKButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.OKButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.FlatAppearance.BorderSize = 0
        Me.OKButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.ForeColor = System.Drawing.Color.White
        Me.OKButton.Location = New System.Drawing.Point(323, 345)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(100, 34)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'pnlBrand
        '
        Me.pnlBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.pnlBrand.Controls.Add(Me.LogoPictureBox)
        Me.pnlBrand.Controls.Add(Me.lblBrandSub)
        Me.pnlBrand.Controls.Add(Me.lblBrandName)
        Me.pnlBrand.Controls.Add(Me.lblBrandIcon)
        Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(190, 400)
        Me.pnlBrand.TabIndex = 1
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(1, 1)
        Me.LogoPictureBox.TabIndex = 3
        Me.LogoPictureBox.TabStop = False
        Me.LogoPictureBox.Visible = False
        '
        'lblBrandSub
        '
        Me.lblBrandSub.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandSub.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblBrandSub.Location = New System.Drawing.Point(0, 232)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Size = New System.Drawing.Size(190, 20)
        Me.lblBrandSub.TabIndex = 2
        Me.lblBrandSub.Text = "Staff Ordering System"
        Me.lblBrandSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrandName
        '
        Me.lblBrandName.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandName.ForeColor = System.Drawing.Color.White
        Me.lblBrandName.Location = New System.Drawing.Point(0, 200)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(190, 30)
        Me.lblBrandName.TabIndex = 1
        Me.lblBrandName.Text = "Clothing Store"
        Me.lblBrandName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrandIcon
        '
        Me.lblBrandIcon.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandIcon.ForeColor = System.Drawing.Color.White
        Me.lblBrandIcon.Location = New System.Drawing.Point(0, 110)
        Me.lblBrandIcon.Name = "lblBrandIcon"
        Me.lblBrandIcon.Size = New System.Drawing.Size(190, 85)
        Me.lblBrandIcon.TabIndex = 0
        Me.lblBrandIcon.Text = "🛍"
        Me.lblBrandIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.pnlBrand)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About - Clothing Store Staff Ordering System"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.pnlBrand.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class