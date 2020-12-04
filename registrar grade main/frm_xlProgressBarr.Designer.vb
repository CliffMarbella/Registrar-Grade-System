<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_xlProgressBarr
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
        Me.pb_xlProgress = New System.Windows.Forms.ProgressBar()
        Me.lbl_progress = New System.Windows.Forms.Label()
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'pb_xlProgress
        '
        Me.pb_xlProgress.Location = New System.Drawing.Point(12, 12)
        Me.pb_xlProgress.Name = "pb_xlProgress"
        Me.pb_xlProgress.Size = New System.Drawing.Size(326, 23)
        Me.pb_xlProgress.TabIndex = 0
        Me.pb_xlProgress.Value = 10
        '
        'lbl_progress
        '
        Me.lbl_progress.AutoSize = True
        Me.lbl_progress.Location = New System.Drawing.Point(12, 38)
        Me.lbl_progress.Name = "lbl_progress"
        Me.lbl_progress.Size = New System.Drawing.Size(74, 13)
        Me.lbl_progress.TabIndex = 1
        Me.lbl_progress.Text = "Progress: 10%"
        '
        'frm_xlProgressBarr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(350, 60)
        Me.Controls.Add(Me.lbl_progress)
        Me.Controls.Add(Me.pb_xlProgress)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_xlProgressBarr"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excel Export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_xlProgress As ProgressBar
    Friend WithEvents lbl_progress As Label
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
End Class
