Imports MySql.Data.MySqlClient

Public Class frm_addInstructor
    Dim connection As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Dim instructorId As String
    Dim fname As String
    Dim lname As String
    Dim department As String

    Sub AddEntry()
        'Add New Instructor
        DBConnect()
        Try
            connection.Open()
            Dim READER As MySqlDataReader
            Dim Query As String = "insert into instructorinfo (instructor_id, first_name, last_name, department) values ('" & instructorId & "', '" & fname & "', '" & lname & "', '" & department & "');"
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader
            READER.Close()
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

    Private Sub tbx_instructorID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_instructorID.KeyPress
        'Only Allow Integers
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

#Region "Control Button"
    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        'Get textbox value
        instructorId = tbx_instructorID.Text
        fname = tbx_fname.Text
        lname = tbx_lname.Text
        department = tbx_department.Text

        'Check if student id si not null
        If Not String.IsNullOrEmpty(instructorId) Then
            Try
                'Connect to Database
                Dim READER As MySqlDataReader
                DBConnect()
                connection.Open()
                Dim Query As String = "SELECT * FROM instructorinfo WHERE instructor_id =" & instructorId & ";"
                COMMAND = New MySqlCommand(Query, connection)
                READER = COMMAND.ExecuteReader

                'Check for duplicate instructor id
                If READER.Read() Then
                    MsgBox("Duplicate Instructor ID found")
                Else
                    connection.Close()
                    'Add Entry
                    AddEntry()
                End If
            Catch ex As MySqlException
                MsgBox("There is an error in adding new instructor: " & ex.Message)
            End Try
        Else
            MsgBox("Instructor ID should not be empty!")
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

#End Region
End Class