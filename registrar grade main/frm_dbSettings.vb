Imports MySql.Data.MySqlClient

Public Class frm_dbSettings
    Dim connection As New MySqlConnection
    Dim address, port, schema, user, password, mySqlBin As String

    Public form_previous As Form

    Private Sub DBConnect()
        'Create Connection
        connection.ConnectionString = "server=" & address & "; port=" & port & "; userId=" & user & "; password=" & password & "; database=" & schema & ";"
    End Sub

    Private Sub btn_folderBrowse_Click(sender As Object, e As EventArgs) Handles btn_folderBrowse.Click
        FolderBrowserDialog.ShowDialog()
        tbx_mysqlPath.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub frm_dbSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbx_address.Text = frm_login.db_address
        tbx_port.Text = frm_login.db_port
        tbx_schema.Text = frm_login.db_name
        tbx_user.Text = frm_login.db_user
        tbx_password.Text = frm_login.db_pass
        tbx_mysqlPath.Text = frm_login.db_mySqlBin
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        address = tbx_address.Text
        port = tbx_port.Text
        schema = tbx_schema.Text
        user = tbx_user.Text
        password = tbx_password.Text
        mySqlBin = tbx_mysqlPath.Text

        'TEST ONLY
        Dim str As String
        str = address & vbNewLine & port & vbNewLine & schema & vbNewLine & user & vbNewLine & password & vbNewLine & mySqlBin
        VBCore.writeFileBase64(str, "dbsettings", False)

        'Test Connection
        DBConnect()
        Try
            connection.Open()
            MsgBox("Settings Changed", MsgBoxStyle.OkOnly, "Successful")

            'Open Previous Form
            form_previous.Enabled = True

            'Save db data locally
            Dim saveString As String
            saveString = address & vbNewLine & port & vbNewLine & schema & vbNewLine & user & vbNewLine & password & vbNewLine & mySqlBin
            VBCore.writeFileBase64(saveString, "dbsettings", False)

            'throw data to login form
            frm_login.db_address = address
            frm_login.db_port = port
            frm_login.db_name = schema
            frm_login.db_user = user
            frm_login.db_pass = password
            frm_login.db_mySqlBin = mySqlBin

        Catch ex As MySqlException
            MsgBox("Invalid Settings", MsgBoxStyle.Exclamation)
        Catch ex As System.ArgumentException
            MsgBox("Invalid Settings", MsgBoxStyle.Exclamation)
        Finally
            connection.Close()
            connection.Dispose()
            'Close Form
            Me.Close()
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        'Open Previous Form
        form_previous.Enabled = True
        'Close Form
        Me.Close()
    End Sub

    Private Sub frm_dbSettings_FormCloses(sender As Object, e As EventArgs) Handles Me.Closed
        'Enable login form
        form_previous.Enabled = True
    End Sub

    Private Sub tbx_port_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_port.KeyPress
        'Only Allow Integers
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class