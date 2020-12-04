Imports MySql.Data.MySqlClient
Public Class frm_removeStudent
    Dim connection As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        'check if control level 2
        If frm_login.user_level Then
            'Check if checkbux checked
            If cbx_remove.Checked = True And tbx_studID.Text IsNot vbNullString Then
                Dim con As Integer = MsgBox("Confirm deletion", MsgBoxStyle.YesNo, "Warning")
                If con = MsgBoxResult.Yes Then
                    'Delete Entry
                    RemoveEntry()
                End If
            Else
                'Archive
                ArchiveEntry()
            End If
        Else
            MsgBox("Administrator account level required", MsgBoxStyle.Exclamation, "Cannot delete student entry")
        End If
    End Sub

    Function GetName(sid As Integer) As String
        Dim Name As String = "Student Name"
        'Delete Student
        DBConnect()
        Try
            connection.Open()
            Dim READER As MySqlDataReader
            Dim Query As String = "SELECT first_name, last_name from studentinfo WHERE WHERE student_id=" & tbx_studID.Text & ";"

            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader
            READER.Read()
            Name = READER(0).GetString & " " & READER(1).GetString

            READER.Close()
            connection.Close()
        Catch ex As MySqlException
            MsgBox("Unable to fetch Student Name")
        Finally
            connection.Dispose()
            Me.Close()
        End Try
        Return Name
    End Function

    Sub RemoveEntry()
        'Delete Student
        DBConnect()
        Try
            connection.Open()
            Dim READER As MySqlDataReader
            Dim Query As String = "DELETE FROM studentinfo WHERE student_id=" & tbx_studID.Text & ";"

            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader

            READER.Close()
            connection.Close()
            MsgBox("Student Info Deletion Successful")
        Catch ex As MySqlException
            MsgBox("Entry Delete Failed # Error Code: " & ex.Message)
        Finally
            connection.Dispose()
            Me.Close()
        End Try
        frm_main.Load_StudentTable()
    End Sub

    Sub ArchiveEntry()
        'Archive
        DBConnect()
        Try
            connection.Open()
            Dim READER As MySqlDataReader
            Dim Query As String = "INSERT INTO studentarchived(student_id, last_name, first_name, middle_name, address, gender, grade_level, status)
                                        SELECT student_id, last_name, first_name, middle_name, address, gender, grade_level, status
                                        FROM studentinfo WHERE student_id=" & tbx_studID.Text & ";
                                        DELETE FROM studentinfo WHERE student_id=" & tbx_studID.Text & ";"

            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader

            READER.Close()
            connection.Close()
            MsgBox("Student Info Archive Successful")
        Catch ex As MySqlException
            MsgBox("Entry Delete Failed # Error Code: " & ex.Message)
        Finally
            connection.Dispose()
            Me.Close()
        End Try

        frm_main.Load_StudentTable()
    End Sub

    Private Sub DBConnect()
        'Create Connection
        connection.ConnectionString = frm_main.DBConnectionString()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class