Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.AccessControl

Public Class VBCore
    Public Shared appFolder As String = "Registrar Grade"
    Public Shared filePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & appFolder
    Public Shared saveType As String = ".cfg"

    Public Shared connection As New MySqlConnection

    Public Shared pathMysqlBin As String

    'Write Enrypted File
    Public Shared Sub writeFileBase64(str As String, fname As String, append As Boolean)
        Dim tobytes = System.Text.Encoding.UTF8.GetBytes(str)
        Dim saveString = System.Convert.ToBase64String(tobytes)
        Dim pathString = filePath & "\" & fname & saveType

        Dim file As System.IO.FileStream
        If Not System.IO.File.Exists(pathString) = True Then
            'Create directory if it doesnt exists
            checkCreateFolder(filePath)
            'Create file
            Try
                file = System.IO.File.Create(pathString)
                file.Close()
            Catch e As System.UnauthorizedAccessException
                MsgBox("Access to file folder " & pathString & " denied", MsgBoxStyle.Critical)
            Catch e As Exception
                MsgBox("File write error! Error code: " & e.Message, MsgBoxStyle.Critical)
            End Try
        End If
        'Write File
        Try
            My.Computer.FileSystem.WriteAllText(pathString, saveString, append)
        Catch e As Exception
            MsgBox("File write error! Error code: " & e.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Read Encrypted File
    Public Shared Function readFileBase64(fname As String)
        Dim savestring As String
        Dim pathString = filePath & "\" & fname & saveType

        Try
            If System.IO.File.Exists(pathString) = True Then
                'Get text from file as string
                Dim fromtext = My.Computer.FileSystem.ReadAllText(pathString)
                'Convert encrypted string to ASCII Value
                Dim frombyte = System.Convert.FromBase64String(fromtext)
                'Convert ASCII Value to String
                savestring = System.Text.ASCIIEncoding.ASCII.GetString(frombyte)
                Return savestring
            End If
        Catch e As Exception
            MsgBox("File read error! Error code: " & e.Message, MsgBoxStyle.Critical)
        End Try

        Return vbNullString
    End Function

    'Check and Create Folder Path
    Public Shared Sub checkCreateFolder(path As String)
        'Check if directory exists
        If Not Directory.Exists(path) Then
            ' Try to create the directory
            Dim sr As New DirectorySecurity
            sr.SetAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Allow))
            Dim di As DirectoryInfo = Directory.CreateDirectory(path, sr)
        End If
    End Sub

    'Export Find Path
    Public Shared Sub ExportFolder(sDialog As SaveFileDialog)
        Dim path = filePath 'Default filepath on VBCore

        'Find if path exists
        checkCreateFolder(path)

        'Find savepath
        sDialog.Filter = "SQL Dump file (*.sql)|*.sql|All files (*.*)|*.*"
        sDialog.InitialDirectory = path
        sDialog.FileName = "DataExport-" & DateTime.Now.ToString("MM-dd-yyyy") + ".sql"
        sDialog.ShowDialog()
    End Sub

    'Create connection
    Public Shared Sub DBConnect(connString As String)
        'Create Connection
        connection.ConnectionString = connString
    End Sub

    'Export File
    Public Shared Sub ExportDatabase(connString As String, filename As String)

        pathMysqlBin = frm_login.db_mySqlBin

        If Not pathMysqlBin = vbNullString Then
            DBConnect(connString)
            Try
                connection.Open()

                Dim dbFileName As String = filename

                'Initialize CMD Process
                Dim exportProcess As New Process
                exportProcess.StartInfo.FileName = "cmd.exe"
                exportProcess.StartInfo.UseShellExecute = False
                exportProcess.StartInfo.WorkingDirectory = pathMysqlBin
                exportProcess.StartInfo.RedirectStandardInput = True
                exportProcess.StartInfo.RedirectStandardOutput = True
                exportProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                exportProcess.StartInfo.CreateNoWindow = True
                exportProcess.Start()

                Dim exportStream As StreamWriter = exportProcess.StandardInput
                Dim streamReader As StreamReader = exportProcess.StandardOutput

                'Start CMD Process
                Dim str = "mysqldump --user=" & frm_login.db_user & " --password=" & frm_login.db_pass & " -h " & frm_login.db_address & " " & frm_login.db_name & " > """ & dbFileName & """"
                exportStream.WriteLine(str)
                exportStream.Close()
                exportProcess.WaitForExit()
                exportProcess.Close()

                MsgBox("Database backup successful", MsgBoxStyle.Information, "Database Backup")
            Catch ex As Exception
                MsgBox("Export Database: Error " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MsgBox("Error: MySql bin path has not been set " & vbCrLf & "Additional info: login as ctr_admin and set mySql bin path", MsgBoxStyle.Exclamation, "Error 404 Mysql bin path not found")
        End If
    End Sub

    'Find Import File
    Public Shared Sub ImportFolder(filePath As OpenFileDialog)
        Dim path = VBCore.filePath 'Default filepath on VBCore

        'Find if path exists
        checkCreateFolder(path)

        'Filter files on explorer
        filePath.Filter = "SQL Dump file (*.sql)|*.sql|All files (*.*)|*.*"
        filePath.InitialDirectory = path
        filePath.ShowDialog()
    End Sub

    'Import File
    Public Shared Sub ImportDatabase(connString As String, filename As String)

        pathMysqlBin = frm_login.db_mySqlBin

        If Not pathMysqlBin = vbNullString Then
            DBConnect(connString)
            Try
                connection.Open()
                '
                Dim dbFileName As String = filename

                'Start CMD Process
                Dim importProcess As New Process
                importProcess.StartInfo.FileName = "cmd.exe"
                importProcess.StartInfo.UseShellExecute = False
                importProcess.StartInfo.WorkingDirectory = pathMysqlBin
                importProcess.StartInfo.RedirectStandardInput = True
                importProcess.StartInfo.RedirectStandardOutput = True
                importProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                importProcess.StartInfo.CreateNoWindow = True
                importProcess.Start()

                Dim exportStream As StreamWriter = importProcess.StandardInput
                Dim streamReader As StreamReader = importProcess.StandardOutput

                'Create Schema
                createDBRegistrar(connection)

                'Create File
                Dim str = "mysql --user=" & frm_login.db_user & " --password=" & frm_login.db_pass & " -h " & frm_login.db_address & " " & frm_login.db_name & " < """ & dbFileName & """"
                exportStream.WriteLine(str)
                exportStream.Close()
                importProcess.WaitForExit()
                importProcess.Close()
                MsgBox("Database Restore successful", MsgBoxStyle.Information, "Database Restore")
            Catch ex As Exception
                MsgBox("Import Database: Error " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MsgBox("Error: MySql bin path has not been set " & vbCrLf & "Additional info: login as ctr_admin and set mySql bin path", MsgBoxStyle.Exclamation, "Error 404 Mysql bin path not found")
        End If
    End Sub

    'Create new Registrar
    Public Shared Sub createDBRegistrar(connection As MySqlConnection)
        Try
            Dim reader As MySqlDataReader
            Dim str As String
            str = "CREATE SCHEMA " & frm_login.db_name & ";"
            Dim Command As New MySqlCommand(str, connection)
            reader = Command.ExecuteReader
            reader.Close()
        Catch ex As MySqlException
            ''if db_registrar already exist then do not create another this catch has no function no error either
        End Try
    End Sub
End Class
