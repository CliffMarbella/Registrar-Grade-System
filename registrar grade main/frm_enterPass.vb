Imports MySql.Data.MySqlClient

Public Class frm_enterPass

    Dim connection As New MySqlConnection
    Dim Command As MySqlCommand
    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        enterPass(frm_login.user_id)
    End Sub

    Private Sub enterPass(id As String)
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM credentials WHERE id_number = '" & id & "'"
            Command = New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            If reader.Read() Then
                If reader("id_password") = tbx_accountPass.Text Then
                    frm_changePass.Show()
                    tbx_accountPass.Text = ""
                    Me.Hide()
                Else
                    MsgBox("Passwor is incorrect")
                End If
            End If
            reader.Close()
            connection.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub DBConnect()
        connection.ConnectionString = "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name & ";"
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_enterPass_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        frm_main.Enabled = True
    End Sub
End Class