<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_removeStudent
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
        Me.tbx_studID = New System.Windows.Forms.TextBox()
        Me.lbl_studID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.cbx_remove = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'tbx_studID
        '
        Me.tbx_studID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_studID.Location = New System.Drawing.Point(98, 88)
        Me.tbx_studID.Name = "tbx_studID"
        Me.tbx_studID.Size = New System.Drawing.Size(232, 25)
        Me.tbx_studID.TabIndex = 17
        '
        'lbl_studID
        '
        Me.lbl_studID.AutoSize = True
        Me.lbl_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_studID.Location = New System.Drawing.Point(12, 88)
        Me.lbl_studID.Name = "lbl_studID"
        Me.lbl_studID.Size = New System.Drawing.Size(67, 17)
        Me.lbl_studID.TabIndex = 32
        Me.lbl_studID.Text = "Student ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(77, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Remove Student"
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
        Me.btn_cancel.Location = New System.Drawing.Point(131, 258)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 34)
        Me.btn_cancel.TabIndex = 28
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
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
        Me.btn_apply.Location = New System.Drawing.Point(15, 258)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(110, 34)
        Me.btn_apply.TabIndex = 27
        Me.btn_apply.Text = "Remove"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'cbx_remove
        '
        Me.cbx_remove.AutoSize = True
        Me.cbx_remove.Location = New System.Drawing.Point(15, 222)
        Me.cbx_remove.Name = "cbx_remove"
        Me.cbx_remove.Size = New System.Drawing.Size(167, 17)
        Me.cbx_remove.TabIndex = 33
        Me.cbx_remove.Text = "Permanently Remove Student"
        Me.cbx_remove.UseVisualStyleBackColor = True
        '
        'frm_removeStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(342, 308)
        Me.Controls.Add(Me.cbx_remove)
        Me.Controls.Add(Me.tbx_studID)
        Me.Controls.Add(Me.lbl_studID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_removeStudent"
        Me.Text = "Remove Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbx_studID As TextBox
    Friend WithEvents lbl_studID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_apply As Button
    Friend WithEvents cbx_remove As CheckBox
End Class
