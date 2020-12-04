Imports System.ComponentModel
Public Class frm_xlProgressBarr

    Public Property sfd As SaveFileDialog
    Private finish As Boolean

    Private Sub frm_xlProgressBarr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''initialize components
        finish = False
        bw.WorkerReportsProgress = True
        bw.WorkerSupportsCancellation = True
        ''add handlers for dowork, progresschanged, and runworkercomplete events
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        ''start
        processStart()
    End Sub

    ''start process
    Private Sub processStart()
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub

    ''executes if canceled, finished or error occurs
    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            lbl_progress.Text = "Error!"
        ElseIf e.Error IsNot Nothing Then
            lbl_progress.Text = "Error: " & e.Error.Message
            MsgBox(" ")
            Me.Close()
        Else
            lbl_progress.Text = "Progress: 100%"
        End If
    End Sub

    ''update progress label and progress bar
    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        lbl_progress.Text = "Progress: " & e.ProgressPercentage.ToString() & "%"
        pb_xlProgress.Value = e.ProgressPercentage
    End Sub

    ''progress
    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        For i = 1 To 10
            If finish = True Then
                bw.ReportProgress(100)
                Exit For
            Else
                If bw.CancellationPending = True Then
                    e.Cancel = True
                    Exit For
                Else
                    System.Threading.Thread.Sleep(500)
                    bw.ReportProgress(i * 10)
                End If
            End If
        Next
    End Sub

    ''cancel background worker
    Public Sub cancel()
        If bw.WorkerSupportsCancellation = True Then
            bw.CancelAsync()
        End If
    End Sub

    ''finish background worker
    Public Sub finished()
        finish = True
    End Sub
End Class