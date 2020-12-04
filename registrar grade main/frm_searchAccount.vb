Imports MySql.Data.MySqlClient

Public Class frm_searchAccount

    Dim connection As New MySqlConnection
    Dim Command As MySqlCommand

    Dim accountId As String
    Dim accountUser As String
    Dim accountPass As String

    Private Sub frm_searchAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.Close()
        End Try
    End Sub

    Private Sub DBConnect()
        connection.ConnectionString = "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name & ";"
    End Sub

    Private Sub btn_upadate_Click(sender As Object, e As EventArgs) Handles btn_upadate.Click
        If frm_login.user_level >= 2 Then
            If Not adminAccount(tbx_accountID.Text) Then
                editAccount(tbx_accountID.Text)
            End If
        Else
            MsgBox("Administrator account level required", MsgBoxStyle.Exclamation, "Unable to edit account")
        End If
    End Sub

    Private Sub editAccount(user As String)
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM credentials WHERE id_number = " & user & ""
            Command = New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            If reader.Read() Then
                accountId = CType(user, Integer)
                accountUser = reader("id_user")
                accountPass = reader("id_password")
                passValues()
            Else
                MsgBox("User doesnt exist!")
            End If
            connection.Close()
            reader.Close()
        Catch ex As Exception
            MsgBox(" There was a problem editing the account # Error Code: " & ex.Message)
            Me.Close()
        End Try
    End Sub

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
                        MsgBox("Adimistrator account cannot be edited here!")
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

    Sub passValues()
        If frm_login.user_level >= 2 Then
            Dim obj As New frm_editAccount
            obj.account_id = accountId
            obj.account_user = accountUser
            obj.account_pass = accountPass
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Administrator account level required", MsgBoxStyle.Exclamation, "Unable to edit account")
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_searchAccount_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        frm_main.Enabled = True
    End Sub
End Class