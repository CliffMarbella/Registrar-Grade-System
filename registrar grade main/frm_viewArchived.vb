Imports MySql.Data.MySqlClient
Public Class frm_viewArchived
    Dim connection As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Dim selectedRow As Integer

    Private Sub DBConnect()
        'Create Connection
        connection.ConnectionString = frm_main.DBConnectionString()
    End Sub


    Private Sub frm_viewArchived_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_StudentTable()
    End Sub

    Private Sub btn_recover_Click(sender As Object, e As EventArgs) Handles btn_recover.Click
        RecoverEntry()
    End Sub

    Private Sub dgv_studList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_studList.CellContentClick
        Dim row As DataGridViewRow
        row = Me.dgv_studList.Rows(e.RowIndex)

        'Get Selected Row Val to Text Box
        selectedRow = row.Cells("archived_key").Value.ToString
        tbx_studentID.Text = row.Cells("student_id").Value.ToString
    End Sub


    Private Sub Load_StudentTable()
        'Load Student List Table
        DBConnect()
        Dim ADAPTER As New MySqlDataAdapter
        Dim dbBindSource As New BindingSource
        Try
            'Get DB Data
            connection.Open()
            Dim Query As String = "select * from studentarchived"
            COMMAND = New MySqlCommand(Query, connection)
            ADAPTER.SelectCommand = COMMAND

            'Store Data to DataTable Var
            Dim dbTable = New DataTable
            ADAPTER.Fill(dbTable)
            dbBindSource.DataSource = dbTable

            'Insert Data to Data Grid View
            dgv_studList.DataSource = dbBindSource
            ADAPTER.Update(dbTable)
            ADAPTER.Dispose()

            connection.Close()
        Catch ex As MySqlException
            MsgBox("Archived Student Table Load: There's an Error Loading Data # Error Code: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Recover Student 
    Sub RecoverEntry()
        If Not selectedRow = -1 Then
            DBConnect()
            Try
                connection.Open()
                Dim READER As MySqlDataReader
                Dim Query As String = "INSERT INTO studentinfo(student_id, last_name, first_name, middle_name, address, gender, grade_level, status)
                                        SELECT student_id, last_name, first_name, middle_name, address, gender, grade_level, status
                                        FROM studentarchived WHERE archived_key=" & selectedRow & ";
                                        DELETE FROM studentarchived WHERE archived_key=" & selectedRow & ";"

                COMMAND = New MySqlCommand(Query, connection)
                READER = COMMAND.ExecuteReader

                READER.Close()
                connection.Close()
                MsgBox("Student Information Recovery Successful")
            Catch ex As MySqlException
                MsgBox("Entry Recovery Failed # Error Code: " & ex.Message)
            Finally
                connection.Dispose()
                Me.Close()
            End Try
            'Reset value
            selectedRow = -1
        End If

        frm_main.Load_StudentTable()
    End Sub
End Class