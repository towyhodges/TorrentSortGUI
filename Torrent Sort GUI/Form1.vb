Imports System.ComponentModel
Imports System.Web.Script.Serialization

Public Class Form1
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If CheckBoxSaveExit.Checked = False Then Exit Sub

        Dim FileOutput As System.IO.StreamWriter

        FileOutput = My.Computer.FileSystem.OpenTextFileWriter("Formats.txt", False)

        For Each Item In ListBoxFormats.Items
            FileOutput.WriteLine(Item)
        Next

        FileOutput.Close()

        FileOutput = My.Computer.FileSystem.OpenTextFileWriter("Ignore.txt", False)

        For Each Item In ListBoxIgnore.Items
            FileOutput.WriteLine(Item)
        Next

        FileOutput.Close()

        FileOutput = My.Computer.FileSystem.OpenTextFileWriter("Tags.txt", False)

        For Each Item In ListBoxTags.Items
            FileOutput.WriteLine(Item)
        Next

        FileOutput.Close()

        FileOutput = My.Computer.FileSystem.OpenTextFileWriter("Shows.txt", False)

        For Each Item In ListBoxShows.Items
            FileOutput.WriteLine(Item)
        Next

        FileOutput.Close()

        Dim JSS As New JavaScriptSerializer, SettingsOutput As New Dictionary(Of String, String)

        SettingsOutput.Add("Source", TextBoxSource.Text)
        SettingsOutput.Add("Target", TextBoxTarget.Text)
        SettingsOutput.Add("TVTarget", TextBoxTVTarget.Text)

        FileOutput = My.Computer.FileSystem.OpenTextFileWriter("Settings.json", False)

        FileOutput.Write(JSS.Serialize(SettingsOutput))

        FileOutput.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim FileInput As System.IO.StreamReader, CurLine As String

        If My.Computer.FileSystem.FileExists("Formats.txt") Then
            FileInput = My.Computer.FileSystem.OpenTextFileReader("Formats.txt")

            Do Until FileInput.EndOfStream
                CurLine = FileInput.ReadLine()
                If CurLine <> "" Then ListBoxFormats.Items.Add(CurLine)
            Loop

            FileInput.Close()
        End If

        If My.Computer.FileSystem.FileExists("Ignore.txt") Then
            FileInput = My.Computer.FileSystem.OpenTextFileReader("Ignore.txt")

            Do Until FileInput.EndOfStream
                CurLine = FileInput.ReadLine()
                If CurLine <> "" Then ListBoxIgnore.Items.Add(CurLine)
            Loop

            FileInput.Close()
        End If

        If My.Computer.FileSystem.FileExists("Tags.txt") Then
            FileInput = My.Computer.FileSystem.OpenTextFileReader("Tags.txt")

            Do Until FileInput.EndOfStream
                CurLine = FileInput.ReadLine()
                If CurLine <> "" Then ListBoxTags.Items.Add(CurLine)
            Loop

            FileInput.Close()
        End If

        If My.Computer.FileSystem.FileExists("Shows.txt") Then
            FileInput = My.Computer.FileSystem.OpenTextFileReader("Shows.txt")

            Do Until FileInput.EndOfStream
                CurLine = FileInput.ReadLine()
                If CurLine <> "" Then ListBoxShows.Items.Add(CurLine)
            Loop

            FileInput.Close()
        End If

        If My.Computer.FileSystem.FileExists("Settings.json") Then

            FileInput = My.Computer.FileSystem.OpenTextFileReader("Settings.json")

            CurLine = FileInput.ReadToEnd

            FileInput.Close()

            Dim JSS As New JavaScriptSerializer
            Dim SettingsInput As Dictionary(Of String, String) = JSS.Deserialize(Of Dictionary(Of String, String))(CurLine)

            TextBoxSource.Text = SettingsInput("Source")
            TextBoxTarget.Text = SettingsInput("Target")
            TextBoxTVTarget.Text = SettingsInput("TVTarget")

        End If

        PopulateItems()

    End Sub
    Private Sub ButtonAddFormat_Click(sender As Object, e As EventArgs) Handles ButtonAddFormat.Click

        Dim NewFormat As String = InputBox("Enter New File Extension", "New Format")

        If Not NewFormat.StartsWith(".") Then
            MsgBox("Invalid Extension")
            Exit Sub
        End If

        ListBoxFormats.Items.Add(NewFormat)

    End Sub
    Private Sub ButtonAddIgnore_Click(sender As Object, e As EventArgs) Handles ButtonAddIgnore.Click

        Dim NewFormat As String = InputBox("Enter New File Extension", "New Format")

        If Not NewFormat.StartsWith(".") Then
            MsgBox("Invalid Extension")
            Exit Sub
        End If

        ListBoxIgnore.Items.Add(NewFormat)

    End Sub

    Private Sub ButtonAddTag_Click(sender As Object, e As EventArgs) Handles ButtonAddTag.Click

        Dim NewTag As String = InputBox("Enter Torrent Tag To Strip", "New Tag")

        If NewTag = "" Then
            Exit Sub
        End If

        ListBoxTags.Items.Add(NewTag)

    End Sub

    Private Sub ButtonAddTV_Click(sender As Object, e As EventArgs) Handles ButtonAddTV.Click

        Dim SelectedItem As String = ""
        Dim SelectedSplit

        If Not ListBoxItems.SelectedItem Is Nothing Then
            If InStr(ListBoxItems.SelectedItem, " S") <> 0 Then
                SelectedSplit = Split(ListBoxItems.SelectedItem, " S")
                ReDim Preserve SelectedSplit(UBound(SelectedSplit) - 1)
                SelectedItem = Join(SelectedSplit, " S")
            End If
        End If

        Dim NewShow As String = InputBox("Enter Torrent Tag To Strip", "New Tag", SelectedItem)

        If NewShow = "" Then
            Exit Sub
        End If

        ListBoxShows.Items.Add(NewShow)

    End Sub

    Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click

        Dim SourceFolder As String = TextBoxSource.Text

        If Not My.Computer.FileSystem.DirectoryExists(SourceFolder) Then
            MsgBox("Source Folder Cannot Be Found")
            Exit Sub
        End If

        Dim TargetFolder As String = TextBoxTarget.Text

        If Not My.Computer.FileSystem.DirectoryExists(TargetFolder) Then
            My.Computer.FileSystem.CreateDirectory(TargetFolder)
        End If

        MoveFiles(SourceFolder, TargetFolder)

        PopulateItems()

    End Sub

    Sub MoveFiles(SourceFolder, TargetFolder)

        Dim FileInfo As IO.FileInfo
        Dim TargetFile As String

        For Each Subfolder In My.Computer.FileSystem.GetDirectories(SourceFolder)
            MoveFiles(Subfolder, TextBoxTarget.Text)
        Next

        For Each SourceFile In My.Computer.FileSystem.GetFiles(SourceFolder)
            For Each FormatExt In ListBoxFormats.Items
                If InStr(SourceFile, FormatExt) <> 0 Then
                    FileInfo = My.Computer.FileSystem.GetFileInfo(SourceFile)
                    TargetFile = TargetFolder & "\" & FileInfo.Name
                    My.Computer.FileSystem.MoveFile(SourceFile, TargetFile)
                End If
            Next
        Next

    End Sub

    Sub PopulateItems()

        ListBoxItems.Items.Clear()

        Dim TargetFolder As String = TextBoxTarget.Text
        Dim FileInfo As IO.FileInfo

        If Not My.Computer.FileSystem.DirectoryExists(TargetFolder) Then
            Exit Sub
        End If

        For Each TargetFile In My.Computer.FileSystem.GetFiles(TargetFolder)
            FileInfo = My.Computer.FileSystem.GetFileInfo(TargetFile)
            ListBoxItems.Items.Add(FileInfo.Name)
        Next

        If My.Computer.FileSystem.GetFiles(TargetFolder).Count = 0 Then
            If My.Computer.FileSystem.GetDirectories(TargetFolder).Count = 0 Then My.Computer.FileSystem.DeleteDirectory(TargetFolder, FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)
        End If

    End Sub
    Private Sub ButtonBrowseSource_Click(sender As Object, e As EventArgs) Handles ButtonBrowseSource.Click
        If (FolderBrowserDialogMain.ShowDialog() = DialogResult.OK) Then
            TextBoxSource.Text = FolderBrowserDialogMain.SelectedPath
        End If
    End Sub

    Private Sub ButtonBrowseTarget_Click(sender As Object, e As EventArgs) Handles ButtonBrowseTarget.Click
        If (FolderBrowserDialogMain.ShowDialog() = DialogResult.OK) Then
            TextBoxTarget.Text = FolderBrowserDialogMain.SelectedPath
        End If
    End Sub

    Private Sub ButtonBrowseTV_Click(sender As Object, e As EventArgs) Handles ButtonBrowseTV.Click
        If (FolderBrowserDialogMain.ShowDialog() = DialogResult.OK) Then
            TextBoxTVTarget.Text = FolderBrowserDialogMain.SelectedPath
        End If
    End Sub
    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        PopulateItems()
    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click

        If Not My.Computer.FileSystem.DirectoryExists(TextBoxTarget.Text) Then
            MsgBox("Sort Folder Does Not Exist")
            Exit Sub
        End If

        Process.Start(TextBoxTarget.Text)

    End Sub
    Private Sub ButtonStrip_Click(sender As Object, e As EventArgs) Handles ButtonStrip.Click

        Dim NewName As String, FileInfo As IO.FileInfo, TestChar As String

        For Each StripFile In My.Computer.FileSystem.GetFiles(TextBoxTarget.Text)

            FileInfo = My.Computer.FileSystem.GetFileInfo(StripFile)
            NewName = Replace(FileInfo.Name, FileInfo.Extension, "")
            NewName = Replace(NewName, ".", " ")

            NewName = Strings.UCase(Strings.Left(NewName, 1)) & Strings.Right(NewName, Len(NewName) - 1)

            For x = 2 To Len(NewName)

                TestChar = Strings.Mid(NewName, x - 1, 1)

                If TestChar = " " Or IsNumeric(TestChar) Then
                    NewName = Strings.Left(NewName, x - 1) & Strings.UCase(Strings.Mid(NewName, x, 1)) & Strings.Right(NewName, Len(NewName) - x)
                End If
            Next

            NewName = FileInfo.DirectoryName & "\" & NewName & FileInfo.Extension

            If StripFile <> NewName Then
                My.Computer.FileSystem.MoveFile(StripFile, NewName)
            End If

        Next

        For Each TorTag In ListBoxTags.Items
            For Each StripFile In My.Computer.FileSystem.GetFiles(TextBoxTarget.Text)
                If InStr(StripFile, TorTag) <> 0 Then
                    NewName = Replace(StripFile, TorTag, "")
                    My.Computer.FileSystem.MoveFile(StripFile, NewName)
                End If
            Next
        Next

        PopulateItems()

    End Sub
    Private Sub ListBoxTags_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxTags.DoubleClick
        Try
            ListBoxTags.Items.Remove(ListBoxTags.SelectedItem)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonSortTV_Click(sender As Object, e As EventArgs) Handles ButtonSortTV.Click

        Dim NewName As String, FileInfo As IO.FileInfo
        Dim TVTarget As String = TextBoxTVTarget.Text

        If Not My.Computer.FileSystem.DirectoryExists(TVTarget) Then
            My.Computer.FileSystem.CreateDirectory(TVTarget)
        End If


        For Each ShowName In ListBoxShows.Items
            For Each TargetFile In My.Computer.FileSystem.GetFiles(TextBoxTarget.Text)
                If InStr(TargetFile, ShowName, CompareMethod.Text) <> 0 Then

                    If Not My.Computer.FileSystem.DirectoryExists(TVTarget & "\" & ShowName) Then
                        My.Computer.FileSystem.CreateDirectory(TVTarget & "\" & ShowName)
                    End If

                    FileInfo = My.Computer.FileSystem.GetFileInfo(TargetFile)
                    NewName = TVTarget & "\" & ShowName & "\" & FileInfo.Name
                    My.Computer.FileSystem.MoveFile(TargetFile, NewName)

                End If
            Next
        Next

        If My.Computer.FileSystem.GetFiles(TextBoxTarget.Text).Count <> 0 Then
            If My.Computer.FileSystem.GetDirectories(TextBoxTarget.Text).Count = 0 Then Process.Start(TextBoxTarget.Text)
        End If

        Process.Start(TVTarget)

        PopulateItems()
    End Sub

    Private Sub ListBoxShows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxShows.SelectedIndexChanged
        Try
            ListBoxShows.Items.Remove(ListBoxShows.SelectedItem)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonCleanDir_Click(sender As Object, e As EventArgs) Handles ButtonCleanDir.Click

        Dim SourceFolder As String = TextBoxSource.Text

        If Not My.Computer.FileSystem.DirectoryExists(SourceFolder) Then
            MsgBox("Source Folder Cannot Be Found.")
            Exit Sub
        End If

        CleanDirs(SourceFolder)

    End Sub

    Sub CleanDirs(SourceFolder)

        Dim FileInfo As IO.FileInfo
        Dim TargetFile As String

        For Each Subfolder In My.Computer.FileSystem.GetDirectories(SourceFolder)
            CleanDirs(Subfolder)
        Next

        For Each SourceFile In My.Computer.FileSystem.GetFiles(SourceFolder)
            For Each FormatExt In ListBoxIgnore.Items
                If SourceFile.EndsWith(FormatExt) Then
                    My.Computer.FileSystem.DeleteFile(SourceFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                End If
            Next
        Next

        If My.Computer.FileSystem.GetFiles(SourceFolder).Count = 0 Then
            If My.Computer.FileSystem.GetDirectories(SourceFolder).Count = 0 Then My.Computer.FileSystem.DeleteDirectory(SourceFolder, FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)
        End If

    End Sub

    Private Sub ButtonHelp_Click(sender As Object, e As EventArgs) Handles ButtonHelp.Click

        Dim HelpString As String = "How to use Torrent GUI:" & vbCrLf & vbCrLf
        HelpString = HelpString & "Source Folder: This folder is where your torrents download to." & vbCrLf & vbCrLf
        HelpString = HelpString & "NOTE: A file that is in use (seeding) will not be movable.  Close your torrent engine before importing." & vbCrLf & vbCrLf
        HelpString = HelpString & "Sort Target: This is where the imported files will end up" & vbCrLf & vbCrLf
        HelpString = HelpString & "TV Sort Folder: This is where sorted TV Shows will be moved to." & vbCrLf & vbCrLf
        HelpString = HelpString & "Steps:" & vbCrLf
        HelpString = HelpString & "1) Set up Settings" & vbCrLf
        HelpString = HelpString & "2) Click Import Files to Find all files with matching extensions" & vbCrLf
        HelpString = HelpString & "3) Click Strip Files to remove designated tags" & vbCrLf
        HelpString = HelpString & "4) Click Sort Shows to move matching shows into the TV directory" & vbCrLf
        HelpString = HelpString & "5) Click Clean Dir to delete leftover files in torrent folder matching the designated extensions" & vbCrLf

        MsgBox(HelpString)
    End Sub
End Class
