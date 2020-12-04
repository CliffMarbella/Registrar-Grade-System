Imports MySql.Data.MySqlClient

Public Class frm_login
    Public Shared db_address = ""
    Public Shared db_port = ""
    Public Shared db_name = ""
    Public Shared db_user = ""
    Public Shared db_pass = ""
    Public Shared db_mySqlBin = ""

    Public Shared user_current = "Undefined"
    Public Shared user_level = 0

    Public Shared user_id As String

    Dim control_id = "ctrl_admin"
    Dim control_pass = "0000"

    Dim connection As New MySqlConnection
    Dim noConfig As Boolean

    Dim COMMAND As New MySqlCommand
    Dim conn_established As Boolean

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load DB Config from file
        Dim str As String
        str = VBCore.readFileBase64("dbSettings")

        'Check if there's a config file
        If Not str = vbNullString Then
            'Set data
            'Dim arrstr() = str.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries) '' kiel pinalitan ko yung newline na parameter ng split kasi di ko magamit sa export db
            Dim arrstr() = str.Split(vbNewLine)
            db_address = arrstr(0).Replace(vbNewLine, "").Replace(vbLf, "")
            db_port = arrstr(1).Replace(vbNewLine, "").Replace(vbLf, "")
            db_name = arrstr(2).Replace(vbNewLine, "").Replace(vbLf, "")
            db_user = arrstr(3).Replace(vbNewLine, "").Replace(vbLf, "")
            db_pass = arrstr(4).Replace(vbNewLine, "").Replace(vbLf, "")
            db_mySqlBin = arrstr(5).Replace(vbNewLine, "").Replace(vbLf, "")
        Else
            'Show no config msgbox
            noConfig = True
        End If

        'Test Connection
        DBTestConnection()
    End Sub

    Private Sub frm_login_Enter(sender As Object, e As EventArgs) Handles MyBase.Shown
        If noConfig Then
            MsgBox("There is no database connection configuration file found!" & vbNewLine & "Please login as control admin and set configuration", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Init Vars
        Dim id_user As String
        Dim id_pass As String

        'Get Textbox String
        id_user = tbx_user.Text
        id_pass = tbx_pass.Text

        If String.IsNullOrWhiteSpace(id_user) Or String.IsNullOrWhiteSpace(id_pass) Then
            'Invalid Text
            MsgBox("Enter Valid Username and Password")
        Else
            'Start Authenticate Process
            If id_user.Equals(control_id) Then
                'Check if trying to login as db control admin
                If id_pass.Equals(control_pass) Then
                    'Login to db control admin
                    frm_dbSettings.Show()
                    frm_dbSettings.form_previous = Me
                    Me.Enabled = False
                Else
                    MsgBox("Invalid Credentials")
                End If
            ElseIf conn_established Then
                'Login as user
                Login(id_user, id_pass)
            End If
        End If
    End Sub

    Private Sub DBConnect()
        'Create Connection
        connection.ConnectionString = "server=" & db_address & "; port=" & db_port & "; userId=" & db_user & "; password=" & db_pass & "; database=" & db_name & ";"
    End Sub

    Private Sub DBTestConnection()
        'Change status
        lbl_connStatus.Text = "Connecting"

        'Connect to DB
        DBConnect()

        'Test Connection
        Try
            connection.Open()
            conn_established = True

            lbl_connStatus.Text = "Connected"
        Catch ex As MySqlException
            connection.Close()
            conn_established = False

            lbl_connStatus.Text = "Connection Failed"
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Login(id_user As String, id_pass As String)
        'Init Vars
        Dim READER As MySqlDataReader
        Dim Query As String
        Query = "select * from " & db_name & ".credentials where id_user='" & id_user & "' and id_password='" & id_pass & "'"

        'Connect to DB
        DBConnect()

        Try
            'Read Table from db
            connection.Open()
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader()

            If READER.Read() Then
                user_level = CInt(READER("control_level"))
                user_current = "User" & READER("id_number")
                user_id = READER("id_number")
            End If

            'Close Reader
            READER.Close()
        Catch ex As MySqlException
            'Show Error
            MsgBox("Login Error :" & ex.ToString)
        Finally
            'Check Read Value
            If user_level = 2 Then
                'Login as Admin
                MsgBox("Administrator Account: Welcome " & user_current)
                Me.Hide()
                frm_main.Show()
            ElseIf user_level = 1 Then
                'Login as teacher
                MsgBox("Welcome " & user_current)
                Me.Hide()
                frm_main.Show()
            Else
                'Login Failed
                MsgBox("Invalid Credentials")
            End If

            'Clear Password Text
            tbx_pass.Text = ""

            'Close Connection
            connection.Close()
        End Try
    End Sub

    Public Sub Logout()
        user_current = "undefined"
        user_level = 0
    End Sub

    Private Sub tmr_time_Tick(sender As Object, e As EventArgs) Handles tmr_time.Tick
        If conn_established = False Then
            DBTestConnection()
        End If
    End Sub

End Class