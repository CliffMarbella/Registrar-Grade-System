Imports MySql.Data.MySqlClient

Public Class frm_addStudent
    Dim connection As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Dim studId As String
    Dim fname As String
    Dim lname As String
    Dim mname As String
    Dim gender As String
    Dim address As String

    Sub AddEntry()
        'Add New Student
        DBConnect()
        Try
            connection.Open()
            Dim READER As MySqlDataReader
            Dim Query As String = "insert into studentinfo (student_id, first_name, last_name, gender, address, middle_name) values ('" & studId & "', '" & fname & "', '" & lname & "', '" & gender & "', '" & address & "', '" & mname & "');"
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

    Private Sub tbx_studID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_studID.KeyPress
        'Only Allow Integers
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


#Region "Radio Button"
    Private Sub rbn_male_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_male.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rbn_femal_CheckedChanged(sender As Object, e As EventArgs) Handles rbn_female.CheckedChanged
        gender = "Female"
    End Sub
#End Region

#Region "Control Button"
    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        'Get textbox value
        studId = tbx_studID.Text
        fname = tbx_fname.Text
        lname = tbx_lname.Text
        mname = tbx_mname.Text
        address = tbx_address.Text

        'Check if student id si not null
        If Not String.IsNullOrEmpty(studId) Then
            Try
                'Connect to Database
                Dim READER As MySqlDataReader
                DBConnect()
                connection.Open()
                Dim Query As String = "SELECT * FROM studentinfo WHERE student_id =" & studId & ";"
                COMMAND = New MySqlCommand(Query, connection)
                READER = COMMAND.ExecuteReader

                'Check for duplicate student id
                If READER.Read() Then
                    MsgBox("Duplicate Student ID found")
                Else
                    connection.Close()
                    'Add Entry
                    AddEntry()
                End If
            Catch ex As MySqlException
                MsgBox("There is an error in adding new student: " & ex.Message)
            End Try
        Else
            MsgBox("Student ID should not be empty!")
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

#End Region
End Class