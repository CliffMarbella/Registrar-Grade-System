<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_addGradeLevel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbx_levelID = New System.Windows.Forms.TextBox()
        Me.lbl_studID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_subjects = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_glevel = New System.Windows.Forms.ComboBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        CType(Me.dgv_subjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbx_levelID
        '
        Me.tbx_levelID.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tbx_levelID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_levelID.Location = New System.Drawing.Point(223, 120)
        Me.tbx_levelID.Name = "tbx_levelID"
        Me.tbx_levelID.Size = New System.Drawing.Size(243, 25)
        Me.tbx_levelID.TabIndex = 17
        '
        'lbl_studID
        '
        Me.lbl_studID.AutoSize = True
        Me.lbl_studID.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_studID.Location = New System.Drawing.Point(220, 100)
        Me.lbl_studID.Name = "lbl_studID"
        Me.lbl_studID.Size = New System.Drawing.Size(75, 17)
        Me.lbl_studID.TabIndex = 25
        Me.lbl_studID.Text = "Grade Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(88, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Add Grade Level"
        '
        'dgv_subjects
        '
        Me.dgv_subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_subjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgv_subjects.Location = New System.Drawing.Point(12, 96)
        Me.dgv_subjects.Name = "dgv_subjects"
        Me.dgv_subjects.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_subjects.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_subjects.RowHeadersVisible = False
        Me.dgv_subjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.dgv_subjects.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_subjects.ShowEditingIcon = False
        Me.dgv_subjects.Size = New System.Drawing.Size(203, 282)
        Me.dgv_subjects.TabIndex = 26
        '
        'Column1
        '
        Me.Column1.HeaderText = "Subject"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
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
        Me.btn_cancel.Location = New System.Drawing.Point(356, 344)
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
        Me.btn_apply.Location = New System.Drawing.Point(223, 344)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(127, 34)
        Me.btn_apply.TabIndex = 27
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(221, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Select Subjects"
        '
        'cbx_glevel
        '
        Me.cbx_glevel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbx_glevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_glevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_glevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_glevel.FormattingEnabled = True
        Me.cbx_glevel.Location = New System.Drawing.Point(221, 177)
        Me.cbx_glevel.Name = "cbx_glevel"
        Me.cbx_glevel.Size = New System.Drawing.Size(167, 26)
        Me.cbx_glevel.TabIndex = 30
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_add.FlatAppearance.BorderSize = 2
        Me.btn_add.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add.Location = New System.Drawing.Point(405, 177)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(61, 26)
        Me.btn_add.TabIndex = 31
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_remove.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_remove.FlatAppearance.BorderSize = 2
        Me.btn_remove.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_remove.Location = New System.Drawing.Point(405, 209)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(61, 26)
        Me.btn_remove.TabIndex = 32
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'frm_addGradeLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 390)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.cbx_glevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.dgv_subjects)
        Me.Controls.Add(Me.tbx_levelID)
        Me.Controls.Add(Me.lbl_studID)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_addGradeLevel"
        Me.Text = "Add level"
        CType(Me.dgv_subjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbx_levelID As TextBox
    Friend WithEvents lbl_studID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_subjects As DataGridView
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_apply As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents cbx_glevel As ComboBox
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_remove As Button
End Class
