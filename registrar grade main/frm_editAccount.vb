Imports MySql.Data.MySqlClient

Public Class frm_editAccount

    Dim connection As New MySqlConnection
    Dim Command As MySqlCommand

    Public Property account_id
    Public Property account_user
    Public Property account_pass
    Private Sub frm_editAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbx_accountID.Text = account_id
        tbx_accountUser.Text = account_user
        tbx_accountPass.Text = account_pass
        tbx_conAccountPass.Text = account_pass
        btn_apply.Enabled = False
        frm_main.Enabled = False
    End Sub

    Private Sub DBConnect()
        connection.ConnectionString = "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name & ";"
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        If String.IsNullOrWhiteSpace(tbx_accountUser.Text) Or String.IsNullOrWhiteSpace(tbx_accountPass.Text) Then
            MsgBox("Invalid password/username")
        Else
            If frm_login.user_level >= 2 Then
                If cb_update.Checked Then
                    If tbx_accountPass.Text.Equals(tbx_conAccountPass.Text) Then
                        If Not userExist(tbx_accountUser.Text) Then
                            If Not passExist(tbx_accountPass.Text) Then
                                updateAccount(account_id, tbx_accountUser.Text, tbx_accountPass.Text)
                            End If
                        End If
                    Else
                        MsgBox("Password did not match", MsgBoxStyle.Exclamation)
                    End If
                Else
                    MsgBox("Confirm changes", MsgBoxStyle.Exclamation, "Warning")
                End If
            Else
                MsgBox("Administrator account level required", MsgBoxStyle.Exclamation, "Unable to edit account")
            End If
        End If
    End Sub

    Private Function userExist(user As String) As Boolean
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM credentials WHERE id_user = '" & user & "'"
            Command = New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            If reader.Read Then
                If tbx_accountUser.Text <> account_user Then
                    MsgBox("Username already existing")
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return True
        Finally
            connection.Close()
        End Try
    End Function

    Private Function passExist(pass As String) As Boolean
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM credentials WHERE id_password = '" & pass & "'"
            Command = New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            If reader.Read Then
                If tbx_accountPass.Text <> account_pass Then
                    MsgBox("Password already existing")
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error " & ex.Message)
            Return True
        Finally
            connection.Close()
        End Try
    End Function

    Private Sub updateAccount(id As String, user As String, pass As String)
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "UPDATE credentials SET id_user = '" & user & "', id_password = '" & pass & "' WHERE id_number = '" & id & "'"
            Command = New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            If user = account_user And pass = account_pass Then
                MsgBox("No changes has been made")
            Else
                MsgBox("User has been updated")
            End If
            frm_searchAccount.Show()
            connection.Close()
            reader.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(" There was a problem updating the user # Error Code: " & ex.Message)
            frm_main.Enabled = True
            Me.Close()
        End Try
    End Sub

    Private Sub tbx_accountUser_TextChanged(sender As Object, e As EventArgs) Handles tbx_accountUser.TextChanged
        btn_apply.Enabled = True
    End Sub

    Private Sub tbx_accountPass_TextChanged(sender As Object, e As EventArgs) Handles tbx_accountPass.TextChanged
        btn_apply.Enabled = True
    End Sub

    Private Sub tbx_conAccountPass_TextChanged(sender As Object, e As EventArgs) Handles tbx_conAccountPass.TextChanged
        btn_apply.Enabled = True
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_searchAccount.Show()
        Me.Close()
    End Sub

    Private Sub frm_editAccount_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        frm_searchAccount.Show()
    End Sub
End Class