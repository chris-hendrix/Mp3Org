Imports System.IO
Imports TagLib
Imports Mp3Org
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmMainOLD

    Property Mp3Org As New Mp3OrgOld
    Property Path As String
        Get
            Return Mp3Org.Path
        End Get
        Set(value As String)
            Mp3Org.Path = value
        End Set
    End Property


    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mp3Org.LoadSettings()
        txtPath.DataBindings.Add("Text", Me, "Path")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            If dlgFolderBrowser.ShowDialog = DialogResult.OK Then txtPath.Text = dlgFolderBrowser.SelectedPath
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'Try

        Call Mp3Org.Run()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Me.Close()
    End Sub
End Class


Public Class Mp3OrgOld



    Property Path As String
        Get
            If Settings Is Nothing Then Return Nothing
            Return Settings.RunPath
        End Get
        Set(value As String)
            If Settings Is Nothing Then Return
            Settings.RunPath = value
        End Set
    End Property
    Property Settings As Settings
    Property SettingsFullname As String = Application.StartupPath & "\" & Settings.FileName

    Sub New()
        LoadSettings()
    End Sub



    Public Sub Run()
        Dim di As New DirectoryInfo(Path)

        Dim genre As String = ""
        Dim artist As String = ""
        Dim album As String = ""


        For Each fi As FileInfo In di.GetFiles("*mp3", SearchOption.AllDirectories)

            Dim mp3 As TagLib.File = TagLib.File.Create(fi.FullName)
            With mp3.Tag

                If .JoinedAlbumArtists Is Nothing Then
                    .AlbumArtists() = New String() { .FirstArtist}
                ElseIf .JoinedAlbumArtists.Trim = "" Then

                    .AlbumArtists() = New String() { .FirstArtist}
                End If

                If .AlbumArtists.Count > 0 Then artist = .AlbumArtists(0)
                If .Genres.Count > 0 Then genre = .Genres(0)
                album = .Album

                If artist.Trim = "" Then artist = "empty"
                If genre.Trim = "" Then genre = "empty"
                If album.Trim = "" Then album = "empty"

                Dim genreDir = RemoveInvalidFileNameChars(genre)
                Dim artistDir = genreDir & "\" & RemoveInvalidFileNameChars(artist)
                Dim albumDir = artistDir & "\" & RemoveInvalidFileNameChars(album)

                di.CreateSubdirectory(genreDir)
                di.CreateSubdirectory(artistDir)
                di.CreateSubdirectory(albumDir)
                fi.MoveTo(di.FullName & "\" & albumDir & "\" & fi.Name)
            End With


        Next

        Call SaveSettings()
    End Sub


    Public Sub LoadSettings()
        Dim fs As FileStream
        Dim bf As BinaryFormatter

        Try
            fs = New FileStream(SettingsFullname, FileMode.Open)
            bf = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
            Settings = bf.Deserialize(fs)
            fs.Close()
        Catch ex As Exception
            If fs IsNot Nothing Then fs.Close()
            Settings = New Settings
            SaveSettings()
        End Try

    End Sub

    Public Sub SaveSettings()
        If Settings Is Nothing Then Return
        Dim fs As New FileStream(SettingsFullname, FileMode.Create)
        Dim bf As New BinaryFormatter
        bf.Serialize(fs, Settings)
        fs.Close()
    End Sub

    Private Function RemoveInvalidFileNameChars(UserInput As String, Optional repl As String = "_") As String
        For Each invalidChar In IO.Path.GetInvalidFileNameChars
            UserInput = UserInput.Replace(invalidChar, repl)
        Next
        Return UserInput
    End Function


End Class



