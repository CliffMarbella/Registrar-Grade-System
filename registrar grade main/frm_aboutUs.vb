Public NotInheritable Class frm_aboutUs
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Me.Close()
    End Sub

    Dim clickCount = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        clickCount += 1
        If clickCount = 3 Then
            'Initialize CMD Process
            Dim game As New Process
            game.StartInfo.FileName = "minigame.exe"
            game.Start()
        End If
    End Sub
End Class
