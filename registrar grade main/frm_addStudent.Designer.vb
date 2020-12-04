<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addStudent
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
        Me.lbl_studID = New System.Windows.Forms.Label()
        Me.rbn_female = New System.Windows.Forms.RadioButton()
        Me.rbn_male = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_mname = New System.Windows.Forms.TextBox()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.tbx_address = New System.Windows.Forms.TextBox()
        Me.lbl_adress = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.tbx_lname = New System.Windows.Forms.TextBox()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.tbx_fname = New System.Windows.Forms.TextBox()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.tbx_studID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_studID
        '
        Me.lbl_studID.AutoSize = True
        Me.lbl_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_studID.Location = New System.Drawing.Point(9, 60)
        Me.lbl_studID.Name = "lbl_studID"
        Me.lbl_studID.Size = New System.Drawing.Size(67, 17)
        Me.lbl_studID.TabIndex = 16
        Me.lbl_studID.Text = "Student ID"
        '
        'rbn_female
        '
        Me.rbn_female.AutoSize = True
        Me.rbn_female.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbn_female.Location = New System.Drawing.Point(224, 183)
        Me.rbn_female.Name = "rbn_female"
        Me.rbn_female.Size = New System.Drawing.Size(77, 25)
        Me.rbn_female.TabIndex = 5
        Me.rbn_female.TabStop = True
        Me.rbn_female.Text = "Female"
        Me.rbn_female.UseVisualStyleBackColor = True
        '
        'rbn_male
        '
        Me.rbn_male.AutoSize = True
        Me.rbn_male.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbn_male.Location = New System.Drawing.Point(126, 183)
        Me.rbn_male.Name = "rbn_male"
        Me.rbn_male.Size = New System.Drawing.Size(62, 25)
        Me.rbn_male.TabIndex = 4
        Me.rbn_male.TabStop = True
        Me.rbn_male.Text = "Male"
        Me.rbn_male.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(75, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Add Student"
        '
        'tbx_mname
        '
        Me.tbx_mname.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_mname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_mname.Location = New System.Drawing.Point(95, 157)
        Me.tbx_mname.Name = "tbx_mname"
        Me.tbx_mname.Size = New System.Drawing.Size(235, 25)
        Me.tbx_mname.TabIndex = 3
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_age.Location = New System.Drawing.Point(9, 157)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(84, 17)
        Me.lbl_age.TabIndex = 11
        Me.lbl_age.Text = "Middle Name"
        '
        'tbx_address
        '
        Me.tbx_address.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_address.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_address.Location = New System.Drawing.Point(95, 223)
        Me.tbx_address.Name = "tbx_address"
        Me.tbx_address.Size = New System.Drawing.Size(235, 25)
        Me.tbx_address.TabIndex = 6
        '
        'lbl_adress
        '
        Me.lbl_adress.AutoSize = True
        Me.lbl_adress.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_adress.Location = New System.Drawing.Point(9, 223)
        Me.lbl_adress.Name = "lbl_adress"
        Me.lbl_adress.Size = New System.Drawing.Size(51, 17)
        Me.lbl_adress.TabIndex = 9
        Me.lbl_adress.Text = "Address"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_gender.Location = New System.Drawing.Point(9, 188)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(49, 17)
        Me.lbl_gender.TabIndex = 7
        Me.lbl_gender.Text = "Gender"
        '
        'tbx_lname
        '
        Me.tbx_lname.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_lname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_lname.Location = New System.Drawing.Point(95, 126)
        Me.tbx_lname.Name = "tbx_lname"
        Me.tbx_lname.Size = New System.Drawing.Size(235, 25)
        Me.tbx_lname.TabIndex = 2
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_lname.Location = New System.Drawing.Point(9, 126)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(68, 17)
        Me.lbl_lname.TabIndex = 5
        Me.lbl_lname.Text = "Last Name"
        '
        'tbx_fname
        '
        Me.tbx_fname.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_fname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_fname.Location = New System.Drawing.Point(95, 91)
        Me.tbx_fname.Name = "tbx_fname"
        Me.tbx_fname.Size = New System.Drawing.Size(235, 25)
        Me.tbx_fname.TabIndex = 1
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_fname.Location = New System.Drawing.Point(9, 91)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(68, 17)
        Me.lbl_fname.TabIndex = 3
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
        Me.btn_cancel.Location = New System.Drawing.Point(129, 262)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 34)
        Me.btn_cancel.TabIndex = 8
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
        Me.btn_apply.Location = New System.Drawing.Point(13, 262)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(110, 34)
        Me.btn_apply.TabIndex = 7
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'tbx_studID
        '
        Me.tbx_studID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_studID.Location = New System.Drawing.Point(95, 60)
        Me.tbx_studID.Name = "tbx_studID"
        Me.tbx_studID.Size = New System.Drawing.Size(235, 25)
        Me.tbx_studID.TabIndex = 0
        '
        'frm_addStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(342, 308)
        Me.Controls.Add(Me.tbx_studID)
        Me.Controls.Add(Me.lbl_studID)
        Me.Controls.Add(Me.rbn_female)
        Me.Controls.Add(Me.rbn_male)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbx_mname)
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.tbx_address)
        Me.Controls.Add(Me.lbl_adress)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.tbx_lname)
        Me.Controls.Add(Me.lbl_lname)
        Me.Controls.Add(Me.tbx_fname)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_addStudent"
        Me.Text = "Add Student Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_studID As Label
    Friend WithEvents rbn_female As RadioButton
    Friend WithEvents rbn_male As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tbx_mname As TextBox
    Friend WithEvents lbl_age As Label
    Friend WithEvents tbx_address As TextBox
    Friend WithEvents lbl_adress As Label
    Friend WithEvents lbl_gender As Label
    Friend WithEvents tbx_lname As TextBox
    Friend WithEvents lbl_lname As Label
    Friend WithEvents tbx_fname As TextBox
    Friend WithEvents lbl_fname As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_apply As Button
    Friend WithEvents tbx_studID As TextBox
End Class
