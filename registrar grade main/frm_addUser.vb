Imports MySql.Data.MySqlClient

Public Class frm_addUser
    Dim connection As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Sub AddEntry()
        DBConnect()
        Dim READER As MySqlDataReader

        Dim user_id = tbx_userID.Text
        Dim user_pass = tbx_userPass.Text
        Dim confirm_pass = tbx_confirmPass.Text

        If user_pass.Length > 4 Then
            If user_pass.Equals(confirm_pass) Then
                Try
                    'Open Connection
                    connection.Open()

                    'Insert new user
                    Dim Query = "insert into credentials (id_user, id_password, control_level) values ('" & user_id & "', '" & user_pass & "', 1);"
                    COMMAND = New MySqlCommand(Query, connection)
                    READER = COMMAND.ExecuteReader()
                    READER.Close()
                    connection.Close()
                    MsgBox("Entry Added")
                Catch ex As MySqlException
                    MsgBox("Entry Adding Failed # Error Code: " & ex.Message)
                Finally
                    connection.Dispose()
                    frm_main.Enabled = True
                    Me.Close()
                End Try
            Else
                MsgBox("Password did not match!")
            End If
        Else
            MsgBox("Password must be at least 8 characters")
        End If
    End Sub

    Private Sub DBConnect()
        'Create Connection
        connection.ConnectionString = "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name & ";"
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_main.Enabled = True
        Me.Close()
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        If frm_login.user_level >= 2 Then
            AddEntry()
        Else
            MsgBox("Administrator account level required", MsgBoxStyle.Exclamation, "Unable to add new user account")
        End If
        frm_main.Enabled = True
        Me.Close()
    End Sub

    Private Sub frm_addUser_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        frm_main.Enabled = True
    End Sub
End Class