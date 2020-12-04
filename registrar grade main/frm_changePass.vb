Imports MySql.Data.MySqlClient

Public Class frm_changePass

    Dim connection As New MySqlConnection
    Dim Command As MySqlCommand

    Dim tempPass As String

    Private Sub DBConnect()
        connection.ConnectionString = "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name & ";"
    End Sub

    Private Sub frm_changePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbx_accountID.Text = frm_login.user_id
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM credentials WHERE id_number = '" & frm_login.user_id & "'"
            Command = New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            If reader.Read() Then
                tbx_accountUser.Text = reader("id_user")
                tbx_accountPass.Text = reader("id_password")
                tbx_conAccountPass.Text = reader("id_password")
                tempPass = reader("id_password")
            End If
            reader.Close()
            connection.Close()
        Catch ex As Exception
            MsgBox(" # Error Code: " & ex.Message)
            Me.Close()
        End Try
        btn_apply.Enabled = False
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        If String.IsNullOrWhiteSpace(tbx_accountPass.Text) Then
            MsgBox("Password can't be null")
        Else
            If cb_update.Checked Then
                If tbx_accountPass.Text.Length > 4 Then
                    If tbx_accountPass.Text.Equals(tbx_conAccountPass.Text) Then
                        changePass(tbx_accountPass.Text)
                    Else
                        MsgBox("Password does not match")
                    End If
                Else
                    MsgBox("Confirm changes", MsgBoxStyle.Exclamation, "Warning")
                End If
            Else
                MsgBox("Password must be at least 8 characters")
            End If
        End If
    End Sub

    Private Sub changePass(pass As String)
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "UPDATE credentials SET id_password = '" & pass & "' WHERE id_number = '" & frm_login.user_id & "'"
            Try
                Command = New MySqlCommand(str, connection)
                reader = Command.ExecuteReader
                If tempPass.Equals(pass) Then
                    MsgBox("No changes has been made")
                Else
                    MsgBox("Password changed")
                End If
                Me.Close()
                reader.Close()
            Catch ex As Exception
                MsgBox("Password already exist try another")
            End Try
            connection.Close()
        Catch ex As Exception
            MsgBox("there was an error updating the account: " & ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub tbx_accountPass_TextChanged(sender As Object, e As EventArgs) Handles tbx_accountPass.TextChanged
        btn_apply.Enabled = True
    End Sub

    Private Sub tbx_conAccountPass_TextChanged(sender As Object, e As EventArgs) Handles tbx_conAccountPass.TextChanged
        btn_apply.Enabled = True
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub changePass_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        frm_main.Enabled = True
        frm_enterPass.Close()
    End Sub
End Class