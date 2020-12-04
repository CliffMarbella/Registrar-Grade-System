Imports MySql.Data.MySqlClient

Public Class frm_addSubject
    Dim connection As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Dim subjID As String
    Dim subjName As String

    Sub AddEntry()
        'Add New Student
        DBConnect()
        Try
            connection.Open()
            Dim READER As MySqlDataReader
            Dim Query As String = "insert into " & frm_login.db_name & ".subjectinfo (subject_name) values ('" & subjName & "');"
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MsgBox("Entry Adding Failed # Error Code: " & ex.Message)
        Finally
            MsgBox("Entry Added")
            connection.Dispose()
            Me.Close()
        End Try
    End Sub

    Private Sub DBConnect()
        'Create Connection
        connection.ConnectionString = "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name & ";"
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        'Get textbox value
        subjName = txt_subjName.Text

        'Check if code and name is nut null
        If Not String.IsNullOrEmpty(subjName) Then
            'Add Entry
            AddEntry()
        End If

    End Sub

    Private Sub tbx_subjID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Only Allow Integers
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class