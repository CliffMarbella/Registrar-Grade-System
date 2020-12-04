<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dbSettings
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
        Me.tbx_address = New System.Windows.Forms.TextBox()
        Me.lbl_studID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_user = New System.Windows.Forms.TextBox()
        Me.lbl_age = New System.Windows.Forms.Label()
        Me.tbx_password = New System.Windows.Forms.TextBox()
        Me.lbl_adress = New System.Windows.Forms.Label()
        Me.tbx_schema = New System.Windows.Forms.TextBox()
        Me.lbl_lname = New System.Windows.Forms.Label()
        Me.tbx_port = New System.Windows.Forms.TextBox()
        Me.lbl_fname = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.tbx_mysqlPath = New System.Windows.Forms.TextBox()
        Me.btn_folderBrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbx_address
        '
        Me.tbx_address.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_address.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_address.Location = New System.Drawing.Point(132, 115)
        Me.tbx_address.Name = "tbx_address"
        Me.tbx_address.Size = New System.Drawing.Size(235, 25)
        Me.tbx_address.TabIndex = 17
        '
        'lbl_studID
        '
        Me.lbl_studID.AutoSize = True
        Me.lbl_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_studID.Location = New System.Drawing.Point(13, 115)
        Me.lbl_studID.Name = "lbl_studID"
        Me.lbl_studID.Size = New System.Drawing.Size(91, 17)
        Me.lbl_studID.TabIndex = 32
        Me.lbl_studID.Text = "Server Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(127, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Database Settings"
        '
        'tbx_user
        '
        Me.tbx_user.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_user.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_user.Location = New System.Drawing.Point(132, 208)
        Me.tbx_user.Name = "tbx_user"
        Me.tbx_user.Size = New System.Drawing.Size(235, 25)
        Me.tbx_user.TabIndex = 20
        '
        'lbl_age
        '
        Me.lbl_age.AutoSize = True
        Me.lbl_age.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_age.Location = New System.Drawing.Point(13, 208)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(65, 17)
        Me.lbl_age.TabIndex = 30
        Me.lbl_age.Text = "Username"
        '
        'tbx_password
        '
        Me.tbx_password.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_password.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_password.Location = New System.Drawing.Point(132, 239)
        Me.tbx_password.Name = "tbx_password"
        Me.tbx_password.Size = New System.Drawing.Size(235, 25)
        Me.tbx_password.TabIndex = 25
        '
        'lbl_adress
        '
        Me.lbl_adress.AutoSize = True
        Me.lbl_adress.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_adress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_adress.Location = New System.Drawing.Point(13, 239)
        Me.lbl_adress.Name = "lbl_adress"
        Me.lbl_adress.Size = New System.Drawing.Size(59, 17)
        Me.lbl_adress.TabIndex = 29
        Me.lbl_adress.Text = "Password"
        '
        'tbx_schema
        '
        Me.tbx_schema.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_schema.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_schema.Location = New System.Drawing.Point(132, 177)
        Me.tbx_schema.Name = "tbx_schema"
        Me.tbx_schema.Size = New System.Drawing.Size(235, 25)
        Me.tbx_schema.TabIndex = 19
        '
        'lbl_lname
        '
        Me.lbl_lname.AutoSize = True
        Me.lbl_lname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_lname.Location = New System.Drawing.Point(13, 177)
        Me.lbl_lname.Name = "lbl_lname"
        Me.lbl_lname.Size = New System.Drawing.Size(91, 17)
        Me.lbl_lname.TabIndex = 24
        Me.lbl_lname.Text = "Schema Name"
        '
        'tbx_port
        '
        Me.tbx_port.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_port.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_port.Location = New System.Drawing.Point(132, 146)
        Me.tbx_port.Name = "tbx_port"
        Me.tbx_port.Size = New System.Drawing.Size(235, 25)
        Me.tbx_port.TabIndex = 18
        '
        'lbl_fname
        '
        Me.lbl_fname.AutoSize = True
        Me.lbl_fname.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fname.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_fname.Location = New System.Drawing.Point(13, 146)
        Me.lbl_fname.Name = "lbl_fname"
        Me.lbl_fname.Size = New System.Drawing.Size(70, 17)
        Me.lbl_fname.TabIndex = 21
        Me.lbl_fname.Text = "Server Port"
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
        Me.btn_cancel.Location = New System.Drawing.Point(132, 354)
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
        Me.btn_apply.Location = New System.Drawing.Point(16, 354)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(110, 34)
        Me.btn_apply.TabIndex = 27
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'tbx_mysqlPath
        '
        Me.tbx_mysqlPath.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_mysqlPath.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_mysqlPath.Location = New System.Drawing.Point(132, 283)
        Me.tbx_mysqlPath.Name = "tbx_mysqlPath"
        Me.tbx_mysqlPath.Size = New System.Drawing.Size(193, 25)
        Me.tbx_mysqlPath.TabIndex = 33
        '
        'btn_folderBrowse
        '
        Me.btn_folderBrowse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_folderBrowse.Location = New System.Drawing.Point(331, 283)
        Me.btn_folderBrowse.Name = "btn_folderBrowse"
        Me.btn_folderBrowse.Size = New System.Drawing.Size(36, 25)
        Me.btn_folderBrowse.TabIndex = 34
        Me.btn_folderBrowse.Text = "..."
        Me.btn_folderBrowse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(13, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "MySql Server Bin"
        '
        'frm_dbSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(409, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_folderBrowse)
        Me.Controls.Add(Me.tbx_mysqlPath)
        Me.Controls.Add(Me.tbx_address)
        Me.Controls.Add(Me.lbl_studID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbx_user)
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.tbx_password)
        Me.Controls.Add(Me.lbl_adress)
        Me.Controls.Add(Me.tbx_schema)
        Me.Controls.Add(Me.lbl_lname)
        Me.Controls.Add(Me.tbx_port)
        Me.Controls.Add(Me.lbl_fname)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_dbSettings"
        Me.Text = "Database Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbx_address As TextBox
    Friend WithEvents lbl_studID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbx_user As TextBox
    Friend WithEvents lbl_age As Label
    Friend WithEvents tbx_password As TextBox
    Friend WithEvents lbl_adress As Label
    Friend WithEvents tbx_schema As TextBox
    Friend WithEvents lbl_lname As Label
    Friend WithEvents tbx_port As TextBox
    Friend WithEvents lbl_fname As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_apply As Button
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents tbx_mysqlPath As TextBox
    Friend WithEvents btn_folderBrowse As Button
    Friend WithEvents Label2 As Label
End Class
