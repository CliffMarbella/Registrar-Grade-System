Imports MySql.Data.MySqlClient

Public Class frm_deleteAccount

    Dim connection As New MySqlConnection
    Dim Command As MySqlCommand

    Private Sub DBConnect()
        connection.ConnectionString = "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name & ";"
    End Sub

    Private Sub frm_deleteAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim bindSource As New BindingSource
        DBConnect()
        Try
            connection.Open()
            Dim str As String
            str = "SELECT id_number, id_user, control_level FROM credentials"
            Command = New MySqlCommand(str, connection)
            adapter = New MySqlDataAdapter(Command)
            adapter.Fill(table)
            bindSource.DataSource = table
            dgv_accountList.DataSource = bindSource
            adapter.Update(table)
            adapter.Dispose()
            connection.Close()
        Catch ex As Exception
            MsgBox(" # Error Code: " & ex.Message)
            closeFrm()
        End Try
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        Dim user_id As String
        user_id = tbx_accountID.Text
        If frm_login.user_level >= 2 Then
            If cb_remove.Checked Then
                If Not adminAccount(user_id) Then
                    deleteUser(user_id)
                End If
            Else
                MsgBox("Confirm deletion", MsgBoxStyle.Exclamation, "Warning")
            End If
        Else
            MsgBox("Administrator account level required", MsgBoxStyle.Exclamation, "Unable to remove user account")
        End If
    End Sub

    Sub deleteUser(user As String)
        DBConnect()
        Try
            If userExist(user) Then
                connection.Open()
                Dim reader As MySqlDataReader
                Dim str As String
                str = "DELETE FROM credentials WHERE id_number = " & user & ""
                Command = New MySqlCommand(str, connection)
                reader = Command.ExecuteReader
                connection.Close()
                reader.Close()
                MsgBox("User has been removed")
            Else
                MsgBox("User doesnt exist!")
            End If
        Catch ex As Exception
            MsgBox(" There was a problem removing the user # Error Code: " & ex.Message)
            closeFrm()
        End Try
    End Sub

    Private Function userExist(user As String) As Boolean
        DBConnect()
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim str As String
            str = "SELECT * FROM credentials WHERE id_number = " & user & ""
            Command = New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            If reader.Read Then
                Return True
            Else
                Return False
            End If
            reader.Close()
        Catch ex As Exception
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Private Function adminAccount(user As String) As Boolean
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM credentials WHERE id_number = " & user & ""
            Try
                Command = New MySqlCommand(str, connection)
                reader = Command.ExecuteReader
                If reader.Read() Then
                    Dim level As Integer
                    level = CInt(reader("control_level"))
                    If level >= 2 Then
                        MsgBox("Adimistrator account cannot be deleted here!")
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox("Error: integer input expected ", MsgBoxStyle.Exclamation, " Unable to find user")
                Return True
            End Try
            reader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return True
        Finally
            connection.Close()
        End Try
    End Function

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim table As New DataTable
        Dim adapter As New MySqlDataAdapter
        Dim bindSource As New BindingSource
        DBConnect()
        Try
            connection.Open()
            Dim str As String
            str = "SELECT id_number, id_user, control_level FROM credentials"
            Command = New MySqlCommand(str, connection)
            adapter = New MySqlDataAdapter(Command)
            adapter.Fill(table)
            bindSource.DataSource = table
            dgv_accountList.DataSource = bindSource
            adapter.Update(table)
            adapter.Dispose()
            connection.Close()
        Catch ex As Exception
            MsgBox(" # Error Code: " & ex.Message)
            closeFrm()
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        closeFrm()
    End Sub

    Sub closeFrm()
        frm_main.Enabled = True
        Me.Close()
    End Sub

    Private Sub frm_deleteAccount_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        frm_main.Enabled = True
    End Sub
End Class