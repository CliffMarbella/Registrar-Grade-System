Imports MySql.Data.MySqlClient

Public Class frm_addGradeLevel
    Dim connection As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Dim levelID As String

    Sub AddEntry()
        'Add New level Section
        DBConnect()
        Try
            connection.Open()

            Dim READER As MySqlDataReader
            Dim Query As String

            'Insert Entries
            For i = 0 To (dgv_subjects.Rows.Count - 2)
                Query = "INSERT INTO levelinfo (subject_id, grade_level)
                            VALUES (
                                (SELECT subject_id 
                                    FROM subjectinfo
                                    WHERE subject_name ='" & dgv_subjects.Item(0, i).Value & "')
                                ," & levelID & ");"
                COMMAND = New MySqlCommand(Query, connection)
                READER = COMMAND.ExecuteReader
                READER.Close()
            Next
            MsgBox("Entry Added")
            connection.Close()

            'Request frm main to reload level list
            frm_main.LoadLevelList()

            'Close after success
            Me.Close()

        Catch ex As MySqlException
            MsgBox("Entry Adding Failed # Error Code: " & ex.Message)
        Finally
            connection.Dispose()
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
        levelID = tbx_levelID.Text

        'Check if student id si not null
        If Not String.IsNullOrEmpty(levelID) Then
            Try
                'Connect to Database
                Dim READER As MySqlDataReader
                DBConnect()
                connection.Open()
                Dim Query As String = "SELECT * FROM levelinfo WHERE grade_level ='" & levelID & "';"
                COMMAND = New MySqlCommand(Query, connection)
                READER = COMMAND.ExecuteReader

                'Check for duplicate student id
                If READER.Read() Then
                    connection.Close()
                    MsgBox("Duplicate Grade Level found", MsgBoxStyle.Exclamation)
                Else
                    connection.Close()
                    'Add Entry
                    AddEntry()
                End If

            Catch ex As MySqlException
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            MsgBox("level ID should not be empty!")
        End If
    End Sub

    Private Sub frm_addlevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnect()
        Dim READER As MySqlDataReader
        Try
            'Connecto to DB
            connection.Open()

            'Get items from db
            Dim Query As String = "SELECT DISTINCT subject_name FROM subjectinfo"
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader

            'Delete previous items of cbx
            cbx_glevel.Items.Clear()

            'Add Items to Combo box
            While READER.Read
                Dim ccode As String = READER.GetString("subject_name")
                cbx_glevel.Items.Add(ccode)
            End While

            READER.Dispose()
            connection.Close()
        Catch ex As MySqlException
            MsgBox("Load Grade Level: There's an error loading level list # Error Code:" & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim entry As String = cbx_glevel.SelectedItem
        If Not entry = "" Then
            'Add Entry
            If checkExists(entry) = -1 Then
                Dim row As String = entry
                dgv_subjects.Rows.Add(row)
            End If
        Else
            MsgBox("Error Adding Entry")
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim entry As String = cbx_glevel.SelectedItem
        If Not entry = "" Then
            'Add Entry
            Dim pos = checkExists(entry)
            If pos >= 0 Then
                'Resort
                dgv_subjects.Rows.RemoveAt(pos)
            End If
        Else
            MsgBox("Error Adding Entry")
        End If
    End Sub

    Private Function checkExists(entry As String) As Integer
        Dim found = False
        Return (-1)
        'Check for duplicate entry
        For i = 0 To dgv_subjects.Rows.Count - 1
            If dgv_subjects.Rows(i).Cells(0).Value = entry Then
                'If a duplicate is found
                Return (i)
                found = True
                Exit For
            End If
        Next
    End Function

    'Note3: Kelan kaya ako matatapos?

End Class