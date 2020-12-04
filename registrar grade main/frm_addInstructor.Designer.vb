<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addInstructor
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
        Me.tbx_instructorID = New System.Windows.Forms.TextBox()
        Me.lbl_studID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_department = New System.Windows.Forms.TextBox()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.tbx_lname = New System.Windows.Forms.TextBox()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.tbx_fname = New System.Windows.Forms.TextBox()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbx_instructorID
        '
        Me.tbx_instructorID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_instructorID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_instructorID.Location = New System.Drawing.Point(98, 108)
        Me.tbx_instructorID.Name = "tbx_instructorID"
        Me.tbx_instructorID.Size = New System.Drawing.Size(235, 25)
        Me.tbx_instructorID.TabIndex = 17
        '
        'lbl_studID
        '
        Me.lbl_studID.AutoSize = True
        Me.lbl_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_studID.Location = New System.Drawing.Point(12, 108)
        Me.lbl_studID.Name = "lbl_studID"
        Me.lbl_studID.Size = New System.Drawing.Size(75, 17)
        Me.lbl_studID.TabIndex = 32
        Me.lbl_studID.Text = "Instructor ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(93, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Add Instructor"
        '
        'tbx_department
        '
        Me.tbx_department.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_department.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_department.Location = New System.Drawing.Point(98, 201)
        Me.tbx_department.Name = "tbx_department"
        Me.tbx_department.Size = New System.Drawing.Size(235, 25)
        Me.tbx_department.TabIndex = 20
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_age.Location = New System.Drawing.Point(12, 205)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(75, 17)
        Me.lbl_age.TabIndex = 30
        Me.lbl_age.Text = "Department"
        '
        'tbx_lname
        '
        Me.tbx_lname.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_lname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_lname.Location = New System.Drawing.Point(98, 170)
        Me.tbx_lname.Name = "tbx_lname"
        Me.tbx_lname.Size = New System.Drawing.Size(235, 25)
        Me.tbx_lname.TabIndex = 19
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_lname.Location = New System.Drawing.Point(12, 174)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(68, 17)
        Me.lbl_lname.TabIndex = 24
        Me.lbl_lname.Text = "Last Name"
        '
        'tbx_fname
        '
        Me.tbx_fname.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_fname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_fname.Location = New System.Drawing.Point(98, 139)
        Me.tbx_fname.Name = "tbx_fname"
        Me.tbx_fname.Size = New System.Drawing.Size(235, 25)
        Me.tbx_fname.TabIndex = 18
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_fname.Location = New System.Drawing.Point(12, 139)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(68, 17)
        Me.lbl_fname.TabIndex = 21
        Me.lbl_fname.Text = "First Name"
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
        Me.btn_cancel.Location = New System.Drawing.Point(131, 278)
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
        Me.btn_apply.Location = New System.Drawing.Point(15, 278)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(110, 34)
        Me.btn_apply.TabIndex = 27
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'frm_addInstructor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(345, 346)
        Me.Controls.Add(Me.tbx_instructorID)
        Me.Controls.Add(Me.lbl_studID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbx_department)
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.tbx_lname)
        Me.Controls.Add(Me.lbl_lname)
        Me.Controls.Add(Me.tbx_fname)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_addInstructor"
        Me.Text = "Add Instructor Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbx_instructorID As TextBox
    Friend WithEvents lbl_studID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbx_department As TextBox
    Friend WithEvents lbl_age As Label
    Friend WithEvents tbx_lname As TextBox
    Friend WithEvents lbl_lname As Label
    Friend WithEvents tbx_fname As TextBox
    Friend WithEvents lbl_fname As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_apply As Button
End Class
