<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_deleteAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.tbx_accountID = New System.Windows.Forms.TextBox()
        Me.lbl_studID = New System.Windows.Forms.Label()
        Me.cb_remove = New System.Windows.Forms.CheckBox()
        Me.dgv_accountList = New System.Windows.Forms.DataGridView()
        Me.btn_refresh = New System.Windows.Forms.Button()
        CType(Me.dgv_accountList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(110, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Account list"
        '
        'btn_apply
        '
        Me.btn_apply.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_apply.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_apply.FlatAppearance.BorderSize = 2
        Me.btn_apply.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_apply.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_apply.Location = New System.Drawing.Point(26, 262)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(80, 34)
        Me.btn_apply.TabIndex = 35
        Me.btn_apply.Text = "Remove"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_cancel.FlatAppearance.BorderSize = 2
        Me.btn_cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancel.Location = New System.Drawing.Point(249, 262)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(81, 34)
        Me.btn_cancel.TabIndex = 36
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'tbx_accountID
        '
        Me.tbx_accountID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_accountID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_accountID.Location = New System.Drawing.Point(98, 202)
        Me.tbx_accountID.Name = "tbx_accountID"
        Me.tbx_accountID.Size = New System.Drawing.Size(232, 25)
        Me.tbx_accountID.TabIndex = 37
        '
        'lbl_studID
        '
        Me.lbl_studID.AutoSize = True
        Me.lbl_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_studID.Location = New System.Drawing.Point(23, 205)
        Me.lbl_studID.Name = "lbl_studID"
        Me.lbl_studID.Size = New System.Drawing.Size(69, 17)
        Me.lbl_studID.TabIndex = 38
        Me.lbl_studID.Text = "Account ID"
        '
        'cb_remove
        '
        Me.cb_remove.AutoSize = True
        Me.cb_remove.Location = New System.Drawing.Point(26, 233)
        Me.cb_remove.Name = "cb_remove"
        Me.cb_remove.Size = New System.Drawing.Size(108, 17)
        Me.cb_remove.TabIndex = 39
        Me.cb_remove.Text = "Remove account"
        Me.cb_remove.UseVisualStyleBackColor = True
        '
        'dgv_accountList
        '
        Me.dgv_accountList.AllowUserToAddRows = False
        Me.dgv_accountList.AllowUserToDeleteRows = False
        Me.dgv_accountList.AllowUserToResizeColumns = False
        Me.dgv_accountList.AllowUserToResizeRows = False
        Me.dgv_accountList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgv_accountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_accountList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_accountList.Location = New System.Drawing.Point(12, 37)
        Me.dgv_accountList.MultiSelect = False
        Me.dgv_accountList.Name = "dgv_accountList"
        Me.dgv_accountList.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_accountList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_accountList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv_accountList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_accountList.Size = New System.Drawing.Size(327, 150)
        Me.dgv_accountList.TabIndex = 40
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_refresh.FlatAppearance.BorderSize = 2
        Me.btn_refresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_refresh.Location = New System.Drawing.Point(136, 262)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(80, 34)
        Me.btn_refresh.TabIndex = 41
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'frm_deleteAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(351, 308)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.dgv_accountList)
        Me.Controls.Add(Me.cb_remove)
        Me.Controls.Add(Me.lbl_studID)
        Me.Controls.Add(Me.tbx_accountID)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_deleteAccount"
        Me.Text = "Remove User"
        CType(Me.dgv_accountList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_apply As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents tbx_accountID As TextBox
    Friend WithEvents lbl_studID As Label
    Friend WithEvents cb_remove As CheckBox
    Friend WithEvents dgv_accountList As DataGridView
    Friend WithEvents btn_refresh As Button
End Class
