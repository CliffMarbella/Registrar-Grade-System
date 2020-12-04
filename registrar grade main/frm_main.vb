Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frm_main

#Region "Initialize Variables"
    Dim connection As New MySqlConnection
    Dim COMMAND As New MySqlCommand

    Dim dbTable As New DataTable

    Dim db_connected As Boolean

    'Student Filter Vars
    Dim sf_lname, sf_fname, sf_status, sf_level As String

    'Student Update Info Vars
    Dim su_sid As Int64

    'Grades - Prevent Simultaneous Grae Sync to prevent error
    Dim SyncingGrades As Boolean = False

    'Student grade vars
    Dim sg_sid As String
#End Region

#Region "Menu Header"

#Region "Header Button Click"
    Private Sub btn_addStudent_Click(sender As Object, e As EventArgs) Handles btn_addStudent.Click
        frm_addStudent.Show()
    End Sub
    Private Sub btn_addlevel_Click(sender As Object, e As EventArgs) Handles btn_addlevel.Click
        frm_addGradeLevel.Show()
    End Sub
    Private Sub btn_addSubject_Click(sender As Object, e As EventArgs) Handles btn_addSubject.Click
        frm_addSubject.Show()
    End Sub
    Private Sub btn_addInstructor_Click(sender As Object, e As EventArgs)
        frm_addInstructor.Show()
    End Sub
    Private Sub btn_addAccount_Click(sender As Object, e As EventArgs) Handles btn_addAccount.Click
        Me.Enabled = False
        frm_addUser.Show()
    End Sub
    Private Sub btn_removeStud_Click(sender As Object, e As EventArgs) Handles btn_removeStud.Click
        frm_removeStudent.Show()
    End Sub
#End Region

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        'Logout current user
        frm_login.Logout()
        'Go to login form
        Me.Close()
        frm_login.Show()
    End Sub

#End Region 'Main Header Buttons and functions

#Region "Menu Page: Main"
    Private Sub DbTest_Click(sender As Object, e As EventArgs)
        DBTest()
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tss_userLoggedLabel.Text = "User: " & frm_login.user_current
        disableAdminControlBtn()
        DBTest()
        Load_StudentTable()
        LoadLevelList()
    End Sub

    'Test Connection Every Timer Tick
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        DBTest()
        If Not db_connected Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If
    End Sub

    'Load list of Grade Level to ComboBoxes
    Public Sub LoadLevelList()
        Load_levelList(cbx_level)
        Load_levelList(cbx_ulevel)
        Load_levelList(cbx_flevel)
    End Sub

    'Disable Admin Buttons if Logged in as regular user
    Sub disableAdminControlBtn()
        If frm_login.user_level < 2 Then
            btn_addAccount.Enabled = False
            btn_deleteAccount.Enabled = False
            btn_editUser.Enabled = False
            btn_backup.Enabled = False
            btn_import.Enabled = False
        End If
    End Sub

    Private Sub frm_main_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        'Close other forms
        frm_addStudent.Close()
        frm_addInstructor.Close()
        frm_addUser.Close()
        frm_addGradeLevel.Close()
        frm_addSubject.Close()
        frm_removeStudent.Close()
        frm_deleteAccount.Close()
        frm_editAccount.Close()
        frm_viewArchived.Close()
        frm_searchAccount.Close()
        frm_enterPass.Close()
        'Logout current user
        frm_login.Logout()
        'Open login
        frm_login.Show()
    End Sub

    Private Sub DBTest()
        'Test Connection
        Dim temp_conn As New MySqlConnection
        temp_conn.ConnectionString = DBConnectionString()
        tss_DBStatusLabel.Text = "Connecting"
        Try
            temp_conn.Open()
            tss_DBStatusLabel.Text = "Database Connection: Connected"
            db_connected = True
            temp_conn.Close()
        Catch ex As MySqlException
            tss_DBStatusLabel.Text = "Database Connection: Disconnected"
            db_connected = False
        Finally
            temp_conn.Dispose()
        End Try
    End Sub

    'View Archived Students
    Private Sub btn_viewArchived_Click(sender As Object, e As EventArgs) Handles btn_viewArchived.Click
        frm_viewArchived.Show()
    End Sub

    Private Sub DBConnect()
        'Create Connection
        connection.ConnectionString = DBConnectionString()
    End Sub

    Public Function DBConnectionString() As String
        Return "server=" & frm_login.db_address & "; port=" & frm_login.db_port & "; userId=" & frm_login.db_user & "; password=" & frm_login.db_pass & "; database=" & frm_login.db_name
    End Function
#End Region 'Formwide controller Procedures

#Region "Menu Page: Student"
    'Load Data from DB
#Region "Table Load"
    Private Sub btn_tableLoad_Click(sender As Object, e As EventArgs) Handles btn_tableLoad.Click
        Load_StudentTable()
    End Sub

    Public Sub Load_StudentTable()
        'Load Student List Table
        DBConnect()
        Dim ADAPTER As New MySqlDataAdapter
        Dim dbBindSource As New BindingSource
        Try
            'Get DB Data
            connection.Open()
            Dim Query As String = "select student_id, last_name, first_name, gender, grade_level, status from studentinfo"
            COMMAND = New MySqlCommand(Query, connection)
            ADAPTER.SelectCommand = COMMAND

            'Store Data to DataTable Var
            dbTable = New DataTable
            ADAPTER.Fill(dbTable)
            dbBindSource.DataSource = dbTable

            'Insert Data to Data Grid View
            dgv_studList.DataSource = dbBindSource
            ADAPTER.Update(dbTable)
            ADAPTER.Dispose()

            connection.Close()
        Catch ex As MySqlException
            MsgBox("Student Table Load: There's an Error Loading Data # Error Code: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Dispose()
        End Try
    End Sub

#End Region
    'Filter Data Grid View Table
#Region "Table Filter"
    Private Sub cbx_studStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_fstatus.SelectedIndexChanged
        If cbx_fstatus.SelectedItem.ToString IsNot "All" Then
            sf_status = cbx_fstatus.SelectedItem.ToString
        Else
            sf_status = ""
        End If
        Filter_StudentTable()
    End Sub

    Private Sub tbx_ffname_TextChanged(sender As Object, e As EventArgs) Handles tbx_ffname.TextChanged
        sf_fname = tbx_ffname.Text
        Filter_StudentTable()
    End Sub

    Private Sub cbx_flevel_TextChanged(sender As Object, e As EventArgs) Handles cbx_flevel.SelectedIndexChanged
        sf_level = cbx_flevel.SelectedItem
        Filter_StudentTable()
    End Sub

    Private Sub tbx_flname_TextChanged(sender As Object, e As EventArgs) Handles tbx_flname.TextChanged
        sf_lname = tbx_flname.Text
        Filter_StudentTable()
    End Sub

    Private Sub tbx_ustudentid_Clicked(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_ustudentid.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_freset_Click(sender As Object, e As EventArgs) Handles btn_freset.Click
        cbx_flevel.SelectedIndex = -1
        tbx_ffname.Text = ""
        tbx_flname.Text = ""
        sf_level = ""
        sf_fname = ""
        sf_lname = ""
        sf_status = ""
        Filter_StudentTable()
    End Sub

    Private Sub Filter_StudentTable()
        Dim dvFiltered As New DataView(dbTable)
        dvFiltered.RowFilter = String.Format("first_name Like '%{0}%' and last_name Like '%{1}%' and CONVERT(grade_level, System.String) Like '%{2}%' and status Like '%{3}%'", sf_fname, sf_lname, sf_level, sf_status)
        dgv_studList.DataSource = dvFiltered
    End Sub



#End Region
    'Change/Update Data
#Region "Update Data"

    Private Sub dgv_studList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_studList.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgv_studList.Rows(e.RowIndex)
            get_dgvVal(row)
        End If
    End Sub

    Private Sub get_dgvVal(row As DataGridViewRow)
        'Get Selected Row Val to Text Box
        tbx_ufname.Text = row.Cells("first_name").Value.ToString
        tbx_ulname.Text = row.Cells("last_name").Value.ToString
        tbx_ustudentid.Text = row.Cells("student_id").Value.ToString
        cbx_ugender.SelectedIndex = cbx_ugender.FindString(row.Cells("gender").Value.ToString)
        cbx_ustatus.SelectedIndex = cbx_ustatus.FindString(row.Cells("status").Value.ToString)
        cbx_ulevel.SelectedIndex = cbx_ulevel.FindString(row.Cells("grade_level").Value.ToString)

        su_sid = Convert.ToInt64(row.Cells("student_id").Value)
    End Sub

    Private Sub btn_uapply_Click(sender As Object, e As EventArgs) Handles btn_uapply.Click
        'Apply Changes to Database
        If su_sid > 0 Then
            'Get Data
            Dim su_fname As String = "undefined"
            Dim su_lname As String = "undefined"
            Dim su_gender As String = "undefined"
            Dim su_level As String = "NULL"
            Dim su_status As String = "NULL"

            su_fname = tbx_ufname.Text
            su_lname = tbx_ulname.Text
            su_gender = cbx_ugender.SelectedItem
            su_level = cbx_ulevel.SelectedItem
            su_status = cbx_ustatus.SelectedItem

            'Create Conntect to DB
            DBConnect()
            Dim ADAPTER As New MySqlDataAdapter
            Dim dbBindSource As New BindingSource
            Try
                'Update DB Data
                connection.Open()
                Dim Query As String = "update studentinfo set student_id=" & su_sid & ", last_name='" & su_lname & "', first_name='" & su_fname & "', gender='" & su_gender & "', grade_level=" & su_level & ", status='" & su_status & "' where student_id = " & su_sid & ";"
                COMMAND = New MySqlCommand(Query, connection)
                ADAPTER.SelectCommand = COMMAND
                COMMAND.ExecuteNonQuery()

                connection.Close()
            Catch ex As MySqlException
                MsgBox("Apply Update Student Data: There's an Error Updating Data # Error Code: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                ADAPTER.Dispose()
                connection.Dispose()
            End Try
            'Refresh Table
            Load_StudentTable()
        End If
    End Sub

    'Goto Grades - Show selected students grade
    Private Sub btn_gotoGrade_Click(sender As Object, e As EventArgs) Handles btn_gotoGrade.Click
        tbx_gstudid.Text = su_sid
        tcn_main.SelectedTab = TabPage4
        LoadGradeNow()
    End Sub

    Private Sub btn_ureset_Click(sender As Object, e As EventArgs) Handles btn_ureset.Click
        'Get Selected Row Val to Text Box
        tbx_ufname.Text = ""
        tbx_ulname.Text = ""
        tbx_ustudentid.Text = ""
        cbx_ugender.SelectedIndex = -1
        cbx_ustatus.SelectedIndex = -1

        su_sid = 0
    End Sub


#End Region
#End Region

#Region "Menu Page: Grade Level"
    Private Sub btn_showlevelInfo_Click(sender As Object, e As EventArgs) Handles btn_showlevelInfo.Click
        If String.IsNullOrEmpty(cbx_level.SelectedItem) Then
            MsgBox("Select Grade Level", MsgBoxStyle.Exclamation)
        Else
            Dim dtlevel As New DataTable
            Dim ADAPTER As New MySqlDataAdapter
            Dim dbBindSource As New BindingSource
            DBConnect()
            Try
                'Connecto to DB
                connection.Open()
                'Get items from db
                Dim Query As String = "SELECT c.grade_level, s.subject_name
                                            FROM levelinfo as c, subjectinfo as s
                                            WHERE c.subject_id = s.subject_id AND c.grade_level ='" & cbx_level.SelectedItem & "'"
                COMMAND = New MySqlCommand(Query, connection)
                ADAPTER.SelectCommand = COMMAND
                'Add Items to data table
                ADAPTER.Fill(dtlevel)
                dbBindSource.DataSource = dtlevel
                'Add items to data grid view
                dgv_levelList.DataSource = dbBindSource

                'Resize Columns
                Dim column As DataGridViewColumn = dgv_levelList.Columns(1)
                column.Width = 256

                ADAPTER.Dispose()
                connection.Close()
            Catch ex As MySqlException
                MsgBox("Show Grade Level Info: There's an error loading level list # Error Code:" & ex.Message, MsgBoxStyle.Critical)
            Finally
                connection.Dispose()
            End Try
        End If
    End Sub

    '============ Mahilig sa senior high si boss Lherry!

    Private Sub Load_levelList(cbx As ComboBox)
        DBConnect()
        Dim READER As MySqlDataReader
        Try
            'Connecto to DB
            connection.Open()
            'Get items from db
            Dim Query As String = "SELECT DISTINCT grade_level FROM levelinfo"
            COMMAND = New MySqlCommand(Query, connection)
            READER = COMMAND.ExecuteReader
            'Delete previous items of cbx
            cbx.Items.Clear()
            'Add Items to Combo box
            While READER.Read
                Dim ccode As String = READER.GetString("grade_level")
                cbx.Items.Add(ccode)
            End While
            READER.Dispose()
            connection.Close()
        Catch ex As MySqlException
            MsgBox("Load Grade Level: There's an error loading level list # Error Code:" & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Dispose()
        End Try
    End Sub
#End Region

#Region "Menu Page: Grades"
    Private Sub btn_showGrade_Click(sender As Object, e As EventArgs) Handles btn_showGrade.Click
        LoadGradeNow()
    End Sub

    Sub LoadGradeNow()
        If Not SyncingGrades Then
            SyncingGrades = True
            btn_gotoGrade.Enabled = False
            sg_sid = tbx_gstudid.Text
            If Not sg_sid = vbNullString And IsNumeric(sg_sid) Then
                'Load Grades
                LoadGrade(sg_sid, 1, dgv_grade0)
                LoadGrade(sg_sid, 2, dgv_grade1)
                LoadGrade(sg_sid, 3, dgv_grade2)
                LoadGrade(sg_sid, 4, dgv_grade3)
                LoadGrade(sg_sid, 5, dgv_grade4)
                LoadGrade(sg_sid, 6, dgv_grade5)
                'Get Average
                GetSubjAverage(dgv_g0ave, dgv_grade0, lbl_gAve0)
                GetSubjAverage(dgv_g1ave, dgv_grade1, lbl_gAve1)
                GetSubjAverage(dgv_g2ave, dgv_grade2, lbl_gAve2)
                GetSubjAverage(dgv_g3ave, dgv_grade3, lbl_gAve3)
                GetSubjAverage(dgv_g4ave, dgv_grade4, lbl_gAve4)
                GetSubjAverage(dgv_g5ave, dgv_grade5, lbl_gAve5)
            Else
                MsgBox("Enter a valid student ID", MsgBoxStyle.Exclamation)
            End If
            SyncingGrades = False
            btn_gotoGrade.Enabled = True
        End If
    End Sub

    'Load Grade
    Sub LoadGrade(sid As String, glevel As Integer, dgv As DataGridView)
        Dim dbTable As DataTable
        'Load Student List Table
        DBConnect()

        Dim ADAPTER As New MySqlDataAdapter
        Dim dbBindSource As New BindingSource
        Try
            'Get DB Data
            connection.Open()
            Dim Query As String = "SELECT 
                                    levelinfo.subject_id,
                                    subjectinfo.subject_name,
                                    1_grade, 2_grade, 3_grade, 4_grade
                                    FROM
                                        subjectinfo, levelinfo
                                            LEFT JOIN
                                            gradelist ON gradelist.subject_id = levelinfo.subject_id
                                            AND gradelist.student_id = " & sid & "
                                            AND gradelist.subject_id = levelinfo.subject_id
                                            AND gradelist.grade_level = " & glevel & "
                                    WHERE
                                        levelinfo.grade_level = " & glevel & "
                                        AND subjectinfo.subject_id = levelinfo.subject_id"
            COMMAND = New MySqlCommand(Query, connection)
            ADAPTER.SelectCommand = COMMAND


            'Store Data to DataTable Vara
            dbTable = New DataTable
            ADAPTER.Fill(dbTable)

            'Insert Data to Data Grid View
            dgv.DataSource = dbTable

            'Resize grade column width to fit the view
            Dim column As DataGridViewColumn
            column = dgv.Columns(0)
            column.Width = 38
            column = dgv.Columns(1)
            column.Width = 198
            For i = 2 To dgv.Columns.GetColumnCount(DataGridViewElementStates.None) - 1
                column = dgv.Columns(i)
                column.Width = 64
            Next

            ADAPTER.Update(dbTable)

            COMMAND.Dispose()
            ADAPTER.Dispose()
            dbBindSource.Dispose()
            connection.Close()
        Catch ex As MySqlException
            MsgBox("Load Grades: There's an Error Loading Grade Data # Error Code: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Dispose()
        End Try
    End Sub

    'Compute subj grades
    Sub GetSubjAverage(target As DataGridView, source As DataGridView, text As Label)
        Dim row As DataGridViewRow
        Dim ave As Integer
        Dim nullFound As Boolean
        Dim height = source.Rows.Count - 1
        Dim genAve = 0
        Dim val As String

        'Pre-resetValues
        text.Text = "0.00"
        target.Rows.Clear()

        'Check if
        If height > 0 Then
            target.Rows.Add(height + 1)

            'Loop rows
            For i = 0 To height
                row = source.Rows(source.Rows(i).Index)
                'Loop Cells
                For j = 2 To 5
                    val = row.Cells(j).Value.ToString()
                    If val = vbNullString Then
                        'nullFound = True
                        Exit For
                    Else
                        ave += CInt(row.Cells(j).Value.ToString())
                    End If
                Next

                'Get subject name
                Dim ind = target.Rows(i).Index
                Dim temp_row = target.Rows(ind)
                temp_row.Cells(0).Value = row.Cells(1).Value

                'Fill Average
                If nullFound = False Then
                    'Get Average
                    target.Rows(source.Rows(i).Index).Cells(1).Value = ave / 4
                End If

                genAve += ave / 4

                ave = 0
            Next

            'Get General Average
            text.Text = genAve / height
        End If
    End Sub


    'Update Grade - Edit
    Sub UpdateGrade(sid As String, level As Integer, dgv As DataGridView)
        'Create Conntect to DB
        DBConnect()

        Dim READER As MySqlDataReader
        Dim dbBindSource As New BindingSource

        Dim subj, g1, g2, g3, g4 As String
        Dim entryExists As Integer

        '=== Update data
        Try
            'Update DB Data
            connection.Open()

            'Update/Insert Entries
            Dim Query As String
            For i = 0 To (dgv.Rows.Count - 1)
                'Get subject ID
                subj = dgv.Rows(dgv.Rows(i).Index).Cells(0).Value.ToString()

                g1 = dgv.Rows(dgv.Rows(i).Index).Cells(2).Value.ToString()
                g2 = dgv.Rows(dgv.Rows(i).Index).Cells(3).Value.ToString()
                g3 = dgv.Rows(dgv.Rows(i).Index).Cells(4).Value.ToString()
                g4 = dgv.Rows(dgv.Rows(i).Index).Cells(5).Value.ToString()

                'Check if entry exists
                COMMAND = New MySqlCommand("SELECT * FROM gradelist where student_id=" & sid & " and grade_level =" & level & " and subject_id =" & subj & "", connection)
                READER = COMMAND.ExecuteReader
                While READER.Read()
                    entryExists += 1
                End While
                READER.Close()
                COMMAND.Dispose()

                'Create query
                If entryExists > 0 Then
                    'Update existing entry  gradekey=" & entryCount
                    Dim q1 = "null"
                    Dim q2 = "null"
                    Dim q3 = "null"
                    Dim q4 = "null"

                    If Not g1 = "" Then
                        q1 = g1
                    End If
                    If Not g2 = "" Then
                        q2 = g2
                    End If
                    If Not g3 = "" Then
                        q3 = g3
                    End If
                    If Not g4 = "" Then
                        q4 = g4
                    End If
                    Query = "UPDATE gradelist 
                                SET 1_grade =" & q1 & ",2_grade =" & q2 & ",3_grade =" & q3 & ",4_grade =" & q4 & "
                                WHERE student_id=" & sid & " and subject_id =" & subj & " and grade_level=" & level
                Else
                    'Add New entry
                    Dim q1 = "null"
                    Dim q2 = "null"
                    Dim q3 = "null"
                    Dim q4 = "null"

                    If Not g1 = "" Then
                        q1 = g1
                    End If
                    If Not g2 = "" Then
                        q2 = g2
                    End If
                    If Not g3 = "" Then
                        q3 = g3
                    End If
                    If Not g4 = "" Then
                        q4 = g4
                    End If

                    Query = "INSERT INTO gradelist (student_id, subject_id, grade_level, 1_grade, 2_grade, 3_grade, 4_grade)
                                VALUES(" & sid & "," & subj & "," & level & "," & q1 & "," & q2 & "," & q3 & "," & q4 & ")"
                End If

                'Execute Mysql Command
                COMMAND = New MySqlCommand(Query, connection)
                READER = COMMAND.ExecuteReader
                READER.Close()
                COMMAND.Dispose()
                'Reset Value
                entryExists = 0

            Next
            connection.Close()
        Catch ex As MySqlException
            MsgBox("Update Grade: There's an Error Updating Data # Error Code: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub btn_gupdate_Click(sender As Object, e As EventArgs) Handles btn_gupdate.Click
        Dim con As Integer = MsgBox("This will overwrite existing Grade Data. Do you want to continue?", MsgBoxStyle.YesNo, "Apply Changes")
        If con = MsgBoxResult.Yes Then
            UpdateGrade(sg_sid, 1, dgv_grade0)
            UpdateGrade(sg_sid, 2, dgv_grade1)
            UpdateGrade(sg_sid, 3, dgv_grade2)
            UpdateGrade(sg_sid, 4, dgv_grade3)
            UpdateGrade(sg_sid, 5, dgv_grade4)
            UpdateGrade(sg_sid, 6, dgv_grade5)
        End If
    End Sub

#End Region

#Region "User Account Control"
    Private Sub btn_deleteAccount_Click(sender As Object, e As EventArgs) Handles btn_deleteAccount.Click
        If frm_login.user_level >= 2 Then
            frm_deleteAccount.Show()
            Me.Enabled = False
        Else
            MsgBox("Administrator account level required", MsgBoxStyle.Exclamation, "Unable to add new user account")
        End If
    End Sub

    Private Sub btn_editUser_Click(sender As Object, e As EventArgs) Handles btn_editUser.Click
        If frm_login.user_level >= 2 Then
            frm_searchAccount.Show()
            Me.Enabled = False
        Else
            MsgBox("Administrator account level required", MsgBoxStyle.Exclamation, "Unable to add new user account")
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Me.Enabled = False
        frm_enterPass.Show()
    End Sub
#End Region

#Region "Data Backup/Restore"
    Private Sub btn_backup_Click(sender As Object, e As EventArgs) Handles btn_backup.Click
        VBCore.ExportFolder(sfd_exportData)
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        Dim pro = New Process
        pro.StartInfo.FileName = "Manual.exe"
        pro.Start()
    End Sub
    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        frm_aboutUs.Show()
    End Sub

    Private Sub btn_xlExport_Click(sender As Object, e As EventArgs) Handles btn_xlExport.Click
        If Not String.IsNullOrWhiteSpace(tbx_gstudid.Text) Then
            If VBExcelExport.studExist(tbx_gstudid.Text) Then
                VBExcelExport.exportFolder(sfd_xlExport, tbx_gstudid.Text)
            Else
                MsgBox("Student doesnt exist")
            End If
        Else
            MsgBox("No student selected")
        End If
    End Sub

    Private Sub sfd_xlExport_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd_xlExport.FileOk
        ''start background worker
        frm_xlProgressBarr.Show()
        VBExcelExport.xlExport(sfd_xlExport.FileName)
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd_exportData.FileOk
        VBCore.ExportDatabase(DBConnectionString(), sfd_exportData.FileName)
    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click
        Dim m As Integer = MsgBox("This process will overwrite existing data." & vbCrLf & "Do you want to continue?", MsgBoxStyle.YesNo, "Data Import")
        If m = DialogResult.Yes Then
            'Import
            VBCore.ImportFolder(ofd_importData)
        End If
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_importData.FileOk
        Dim m As Integer = MsgBox("Do you want to create restore point?", MsgBoxStyle.YesNo, "Data Import")
        If m = DialogResult.Yes Then
            'Create backup
            Dim fileName As String = "DataExport-" & DateTime.Now.ToString("MM-dd-yyyy") + ".sql"
            VBCore.ExportDatabase(DBConnectionString(), VBCore.filePath & "\" & fileName)
        End If
        'Continue to import
        VBCore.ImportDatabase(DBConnectionString(), ofd_importData.FileName)
    End Sub
#End Region

End Class