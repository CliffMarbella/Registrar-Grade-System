Imports MySql.Data.MySqlClient

Public Class VBExcelExport

    Public Shared connection As New MySqlConnection
    Public Shared command As MySqlCommand
    '' declare container for student id
    Public Shared id As String

    Public Shared Sub DBConnect()
        connection.ConnectionString = "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name & ";"
    End Sub

    ''initialize save file dialog
    Public Shared Sub exportFolder(savePath As SaveFileDialog, studId As String)
        savePath.Filter = "MS Excel File (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        savePath.FileName = studId & " Grade Record.xlsx"
        savePath.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        savePath.ShowDialog()
    End Sub

    '' check if student exist
    Public Shared Function studExist(studId As String) As Boolean
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM studentinfo WHERE student_id = '" & studId & "'"
            command = New MySqlCommand(str, connection)
            reader = command.ExecuteReader
            If reader.Read Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            id = studId
            connection.Close()
        End Try
    End Function

    ''create temporary table to store the raw stud grade table
    Public Shared Function tempTable(gLevel As String) As DataTable
        DBConnect()
        Dim table As New DataTable
        Try
            connection.Open()
            Dim adapter As MySqlDataAdapter
            Dim str As String
            str = "SELECT subject_id, 1_grade, 2_grade, 3_grade, 4_grade FROM gradelist WHERE student_id = '" & id & "' AND grade_level = '" & gLevel & "'"
            command = New MySqlCommand(str, connection)
            adapter = New MySqlDataAdapter(command)
            adapter.Fill(table)
            adapter.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
        Return table
    End Function

    ''gets the row count of the table based on the number of subject per grade
    Public Shared Function rowCount(gLevel As String) As Integer
        DBConnect()
        Dim count = 0
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * FROM gradelist WHERE student_id = '" & id & "' AND grade_level = '" & gLevel & "'"
            command = New MySqlCommand(str, connection)
            reader = command.ExecuteReader
            count = 1
            While reader.Read
                count = count + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
        Return count
    End Function

    ''fill the tables array with the temporary tables data
    Public Shared Sub fillTables(arrTable() As DataTable)
        '' initialize new instance of dt
        arrTable(0) = New DataTable
        arrTable(1) = New DataTable
        arrTable(2) = New DataTable
        arrTable(3) = New DataTable
        arrTable(4) = New DataTable
        arrTable(5) = New DataTable
        ''fill table array from 0 to 5
        For num As Integer = 1 To 6
            arrTable(num - 1).Columns.Add("Subject")
            arrTable(num - 1).Columns.Add("1st Grading")
            arrTable(num - 1).Columns.Add("2nd Grading")
            arrTable(num - 1).Columns.Add("3rd Grading")
            arrTable(num - 1).Columns.Add("4th Grading")
            For row As Integer = 0 To (rowCount(num) - 1)
                If Not row = rowCount(num) - 1 Then
                    arrTable(num - 1).Rows.Add(getSubject(tempTable(num).Rows(row)(0).ToString), tempTable(num).Rows(row)(1), tempTable(num).Rows(row)(2), tempTable(num).Rows(row)(3), tempTable(num).Rows(row)(4))
                End If
            Next
        Next
    End Sub

    ''gets the subject name using student id
    Public Shared Function getSubject(subjId As String)
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            str = "SELECT * From subjectinfo WHERE subject_id = '" & subjId & "'"
            command = New MySqlCommand(str, connection)
            reader = command.ExecuteReader
            If reader.Read Then
                Return reader("subject_name").ToString
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Function

    ''start export
    Public Shared Sub xlExport(fileName As String)
        ''create data table array
        Dim arrTable(0 To 5) As DataTable
        ''declare microsoft office interop excel components
        Dim excelApp As Microsoft.Office.Interop.Excel.Application
        Dim excelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim excelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misVal As Object = System.Reflection.Missing.Value
        ''initialize microsoft office interop excel components
        excelApp = New Microsoft.Office.Interop.Excel.Application
        excelWorkBook = excelApp.Workbooks.Add(misVal)
        excelWorkSheet = excelWorkBook.Sheets("sheet1")
        ''fill datatable array
        fillTables(arrTable)
        ''write headers in worksheet 
        excelWorkSheet.Cells(1, 1) = "LRN Number: " & id
        excelWorkSheet.Cells(2, 1) = "Name: " & getStudName()
        excelWorkSheet.Cells(3, 1) = "Address: " & getStudAddress()
        ''algorithm for writing every rows/column elements in corresponding work sheet cells
        Dim m = 1
        Dim n = 5
        Dim j = 6
        Dim k = 0
        Dim h, w
        Dim highestRC = 0
        For tCount As Integer = 1 To 6
            excelWorkSheet.Cells(j - 1, m) = "Grade " & tCount
            If highestRC < rowCount(tCount) Then
                highestRC = rowCount(tCount)
            End If
            h = -1
            For yStart = j To ((rowCount(tCount) - 1) + 6 + k)
                w = 0
                Dim tColumnCount = 0
                If yStart = j Then
                    For xStart = m To n
                        excelWorkSheet.Cells(yStart, xStart) = arrTable(tCount - 1).Columns(tColumnCount).ColumnName
                        tColumnCount = tColumnCount + 1
                    Next
                Else
                    For xStart = m To n
                        excelWorkSheet.Cells(yStart, xStart) = arrTable(tCount - 1).Rows(h)(w)
                        w = w + 1
                    Next
                End If
                If Not h = rowCount(tCount) - 2 Then
                    h = h + 1
                End If
            Next
            If tCount = 3 Then
                m = 1
                n = 5
                j = j + highestRC + 2
                k = highestRC + 2
            Else
                n = n + 6
                m = m + 6
            End If
        Next
        ''start saving process
        Try
            ''delete if file already exist
            If My.Computer.FileSystem.FileExists(fileName) Then
                My.Computer.FileSystem.DeleteFile(fileName)
            End If
            ''save file
            excelWorkSheet.SaveAs(fileName)
            ''dispose components
            excelWorkBook.Close()
            excelApp.Quit()
            ''release objects
            releaseObject(excelApp)
            releaseObject(excelWorkBook)
            releaseObject(excelWorkSheet)
            ''end background worker
            frm_xlProgressBarr.finished()
            MsgBox("Export successfull", MsgBoxStyle.Information, "Excel Export")
            frm_xlProgressBarr.Close()
        Catch ex As Exception
            ''cancel backgroung worker if exception occurs
            frm_xlProgressBarr.cancel()
            MsgBox("You cant perform this action because the file is open in another window")
            frm_xlProgressBarr.Close()
        End Try
    End Sub

    ''gets student name
    Public Shared Function getStudName() As String
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            Dim first, mid, last
            first = ""
            mid = ""
            last = ""
            str = "SELECT * FROM studentinfo WHERE student_id = '" & id & "'"
            command = New MySqlCommand(str, connection)
            reader = command.ExecuteReader
            If reader.Read Then
                first = reader("first_name").ToString
                Mid = reader("middle_name").ToString
                last = reader("last_name").ToString
            End If
            Return last & " " & first & " " & mid
        Catch ex As Exception
            Return ""
            MsgBox("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Function

    ''gets student address
    Public Shared Function getStudAddress() As String
        DBConnect()
        Try
            connection.Open()
            Dim reader As MySqlDataReader
            Dim str As String
            Dim address As String = ""
            str = "SELECT * FROM studentinfo WHERE student_id = '" & id & "'"
            command = New MySqlCommand(str, connection)
            reader = command.ExecuteReader
            If reader.Read Then
                address = reader("address")
            End If
            Return address
        Catch ex As Exception
            Return ""
            MsgBox("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Function

    ''clean up
    Public Shared Sub releaseObject(ByVal obj As Object)
        ''reinitialize components to nothing
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
