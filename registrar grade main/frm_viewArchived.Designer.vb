<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_viewArchived
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
        Me.dgv_studList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_studentID = New System.Windows.Forms.TextBox()
        Me.lbl_studID = New System.Windows.Forms.Label()
        Me.btn_recover = New System.Windows.Forms.Button()
        CType(Me.dgv_studList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_studList
        '
        Me.dgv_studList.AllowUserToAddRows = False
        Me.dgv_studList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv_studList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dgv_studList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_studList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_studList.Location = New System.Drawing.Point(12, 57)
        Me.dgv_studList.Name = "dgv_studList"
        Me.dgv_studList.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_studList.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_studList.RowTemplate.ReadOnly = True
        Me.dgv_studList.Size = New System.Drawing.Size(428, 316)
        Me.dgv_studList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Archived Student"
        '
        'tbx_studentID
        '
        Me.tbx_studentID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_studentID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_studentID.Location = New System.Drawing.Point(100, 383)
        Me.tbx_studentID.Name = "tbx_studentID"
        Me.tbx_studentID.ReadOnly = True
        Me.tbx_studentID.Size = New System.Drawing.Size(227, 25)
        Me.tbx_studentID.TabIndex = 35
        '
        'lbl_studID
        '
        Me.lbl_studID.AutoSize = True
        Me.lbl_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!)
        Me.lbl_studID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_studID.Location = New System.Drawing.Point(13, 383)
        Me.lbl_studID.Name = "lbl_studID"
        Me.lbl_studID.Size = New System.Drawing.Size(81, 21)
        Me.lbl_studID.TabIndex = 36
        Me.lbl_studID.Text = "Student ID"
        '
        'btn_recover
        '
        Me.btn_recover.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_recover.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_recover.FlatAppearance.BorderSize = 2
        Me.btn_recover.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_recover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_recover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_recover.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_recover.Location = New System.Drawing.Point(333, 379)
        Me.btn_recover.Name = "btn_recover"
        Me.btn_recover.Size = New System.Drawing.Size(107, 33)
        Me.btn_recover.TabIndex = 37
        Me.btn_recover.Text = "Recover"
        Me.btn_recover.UseVisualStyleBackColor = False
        '
        'frm_viewArchived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(455, 469)
        Me.Controls.Add(Me.btn_recover)
        Me.Controls.Add(Me.tbx_studentID)
        Me.Controls.Add(Me.lbl_studID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_studList)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_viewArchived"
        Me.Text = "frm_viewArchived"
        CType(Me.dgv_studList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_studList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents tbx_studentID As TextBox
    Friend WithEvents lbl_studID As Label
    Friend WithEvents btn_recover As Button
End Class
