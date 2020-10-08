
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports TagLib
Imports Un4seen.Bass

<Serializable> Public Class SongList
    Inherits BindingList(Of Song)


#Region "Data / Constructor"
    Property Project As Project
    ReadOnly Property RunPath As String
        Get
            If Project Is Nothing Then Return Nothing
            Return Project.RunPath
        End Get
    End Property

    Sub New(Project As Project)
        Me.AllowNew = False
        Me.AllowRemove = True
    End Sub

#End Region

#Region "Methods"

    Sub Fill(Path As String)

        Dim fullNames As String() = Directory.GetFiles(Path, Song.ExtensionFilter, SearchOption.AllDirectories)
        Dim s As Song


        Me.Clear()
        For Each fn As String In fullNames
            s = Song.Create(fn)
            If s IsNot Nothing Then Me.Add(s)
        Next

    End Sub

    Sub ChangeDirectories(Path As String)

        For Each s As Song In Me
            s.ChangeDirectory(Path)
        Next

    End Sub


#End Region

#Region "Add / Insert / Delete"

    Protected Overrides Sub RemoveItem(index As Integer)
        Dim item As Song = Me.Items(index)
        item.DeleteFile()
        MyBase.RemoveItem(index)
    End Sub
#End Region


End Class

<Serializable> Public Class Song

#Region "Writable Tags"

    Property Artist As String
        Get
            If Tag Is Nothing Then Return Nothing
            If Tag.Performers.Count < 1 Then Return Nothing
            Return Tag.Performers(0)
        End Get
        Set(value As String)
            If Tag Is Nothing Then Return
            If value Is Nothing Then Tag.Performers = {} Else Tag.Performers = {value}
            SaveFile()
        End Set
    End Property
    Property Title As String
        Get
            If Tag Is Nothing Then Return Nothing
            Return Tag.Title
        End Get
        Set(value As String)
            If Tag Is Nothing Then Return
            Tag.Title = value
            SaveFile()
        End Set
    End Property
    Property Album As String
        Get
            If Tag Is Nothing Then Return Nothing
            Return Tag.Album
        End Get
        Set(value As String)
            If Tag Is Nothing Then Return
            Tag.Album = value
            SaveFile()
        End Set
    End Property
    Property AlbumArtist As String
        Get
            If Tag Is Nothing Then Return Nothing
            If Tag.AlbumArtists.Count < 1 Then Return Nothing
            Return Tag.AlbumArtists(0)
        End Get
        Set(value As String)
            If Tag Is Nothing Then Return
            If value Is Nothing Then Tag.AlbumArtists = {} Else Tag.AlbumArtists = {value}
            SaveFile()
        End Set
    End Property
    Property Genre As String
        Get
            If Tag Is Nothing Then Return Nothing
            If Tag.Genres.Count < 1 Then Return Nothing
            Return Tag.Genres(0)
        End Get
        Set(value As String)
            If Tag Is Nothing Then Return
            If value Is Nothing Then Tag.Genres = {} Else Tag.Genres = {value}
            SaveFile()
        End Set
    End Property
    Property Year As Integer
        Get
            If Tag Is Nothing Then Return Nothing
            Return Tag.Year
        End Get
        Set(value As Integer)
            If Tag Is Nothing Then Return
            Tag.Year = value
            SaveFile()
        End Set
    End Property
    Property Composer As String
        Get
            If Tag Is Nothing Then Return Nothing
            If Tag.Composers.Count < 1 Then Return Nothing
            Return Tag.Composers(0)
        End Get
        Set(value As String)
            If Tag Is Nothing Then Return
            If value Is Nothing Then Tag.Composers = {} Else Tag.Composers = {value}
            SaveFile()
        End Set
    End Property
    Property Track As Integer
        Get
            If Tag Is Nothing Then Return Nothing
            Return Tag.Track
        End Get
        Set(value As Integer)
            If Tag Is Nothing Then Return
            Tag.Track = value
            SaveFile()
        End Set
    End Property
    Property TrackCount As Integer
        Get
            If Tag Is Nothing Then Return Nothing
            Return Tag.TrackCount
        End Get
        Set(value As Integer)
            If Tag Is Nothing Then Return
            Tag.TrackCount = value
            SaveFile()
        End Set
    End Property
    Property Disc As Integer
        Get
            If Tag Is Nothing Then Return Nothing
            Return Tag.Disc
        End Get
        Set(value As Integer)
            If Tag Is Nothing Then Return
            Tag.Disc = value
            SaveFile()
        End Set
    End Property
    Property DiscCount As Integer
        Get
            If Tag Is Nothing Then Return Nothing
            Return Tag.DiscCount
        End Get
        Set(value As Integer)
            If Tag Is Nothing Then Return
            Tag.DiscCount = value
            SaveFile()
        End Set
    End Property
    Property Comment As String
        Get
            If Tag Is Nothing Then Return Nothing
            Return Tag.Comment
        End Get
        Set(value As String)
            If Tag Is Nothing Then Return
            Tag.Comment = value
            SaveFile()
        End Set
    End Property
    Property CoverData As Byte()
        Get
            If Tag Is Nothing Then Return Nothing
            If Tag.Pictures.Count < 1 Then Return Nothing
            Return Tag.Pictures(0).Data.Data
        End Get
        Set(value As Byte())
            If Tag Is Nothing Then Return
            Dim ipic As IPicture = GetIPicture(value)
            If ipic Is Nothing Then Tag.Pictures = {} Else Tag.Pictures = {ipic}
            SaveFile()
        End Set
    End Property

#End Region

#Region "Readable Tags"

    ReadOnly Property BitRate As Integer?
        Get
            If File Is Nothing Then Return Nothing
            Return File.Properties.AudioBitrate
        End Get
    End Property

    ReadOnly Property BitRateString As String
        Get
            If BitRate Is Nothing Then Return Nothing
            Return BitRate & " kb/s"
        End Get
    End Property

    ReadOnly Property Length As String
        Get
            If File Is Nothing Then Return Nothing
            Return File.Properties.Duration.ToString("m\:ss")
        End Get
    End Property

    ReadOnly Property CoverSize As String
        Get
            If Cover Is Nothing Then Return Nothing
            Dim h As Integer = Cover.Height
            Dim w As Integer = Cover.Width
            Return w & "x" & h

        End Get
    End Property


#End Region

#Region "Tag DAta"

    Property File As TagLib.File
    ReadOnly Property Tag As TagLib.Tag
        Get
            If File Is Nothing Then Return Nothing
            Return File.Tag
        End Get
    End Property

    Private _FullName As String
    Property FullName As String
        Get
            Return _FullName
        End Get
        Set(value As String)
            _FullName = value
            File = CreateTaglibFile(value)
        End Set
    End Property

#End Region


#Region "Other Data"

    Shared ReadOnly Property EmptyTag As String = "empty"
    Shared ReadOnly Property ExtensionFilter As String = "*.mp3"

    ReadOnly Property FileName As String
        Get
            If FullName Is Nothing Then Return Nothing
            Return Path.GetFileNameWithoutExtension(FullName)
        End Get
    End Property
    ReadOnly Property Cover As Drawing.Image
        Get
            If CoverData Is Nothing Then Return Nothing
            Return GetImage(CoverData)
        End Get
    End Property
    ReadOnly Property Picture As IPicture
        Get
            If Tag Is Nothing Then Return Nothing
            If Tag.Pictures.Count < 1 Then Return Nothing
            Return Tag.Pictures(0)
        End Get
    End Property
    ReadOnly Property WaveFormImage As Drawing.Image
        Get
            Dim wf As New Un4seen.Bass.Misc.WaveForm(FullName)
            wf.CallbackFrequency = 500 ' every 10 seconds rendered
            wf.ColorBackground = Color.Black
            'wf.ColorBase = Color.Lime
            'wf.ColorPeak = Color.Red
            wf.RenderStart(True, BASSFlag.BASS_SAMPLE_FLOAT)
            Return DirectCast(wf.CreateBitmap(600, 150, -1, -1, False), Drawing.Image)
        End Get
    End Property
    ReadOnly Property HasCover As Boolean
        Get
            Return Cover IsNot Nothing
        End Get
    End Property
    ReadOnly Property Extension As String
        Get
            Return Path.GetExtension(FullName)
        End Get
    End Property
    ReadOnly Property OutputFileName As String
        Get
            Dim str As String = ""
            str &= Track.ToString("00") & " "
            If Title Is Nothing Or Title = "" Then str &= EmptyTag Else str &= RemoveInvalidFileNameChars(Title)
            Return str
        End Get
    End Property
    ReadOnly Property OutputFileNameWithExtension As String
        Get
            Return OutputFileName & Extension
        End Get
    End Property
    ReadOnly Property OutputSubDirectory As String
        Get
            Dim str As String = "\"
            If AlbumArtist Is Nothing Or AlbumArtist = "" Then str &= EmptyTag Else str &= RemoveInvalidFileNameChars(AlbumArtist)
            str &= "\"
            If Album Is Nothing Or Album = "" Then str &= EmptyTag Else str &= RemoveInvalidFileNameChars(Album)
            Return str
        End Get
    End Property
    ReadOnly Property OutputFullName As String
        Get
            Return OutputSubDirectory & "\" & OutputFileNameWithExtension
        End Get
    End Property
    ReadOnly Property SearchTerm As String
        Get
            Dim str As String = ""
            If Artist IsNot Nothing Then str &= Artist & " "
            If Album IsNot Nothing Then str &= Album
            Return str.Trim
        End Get
    End Property

#End Region

#Region "Constructors"

    Sub New()

    End Sub

    Sub New(FullName As String)
        Me.FullName = FullName
        CleanTag()

    End Sub

#End Region

#Region "Methods"


    Sub ChangeDirectory(RunPath As String)

        Dim dir As String = RunPath & OutputSubDirectory
        Dim fn As String = RunPath & OutputFullName
        Directory.CreateDirectory(dir)
        IO.File.Move(FullName, fn)

    End Sub

    'Function GetWaveForm() As Drawing.Image
    '    ' http://www.bass.radio42.com/
    '    Dim wf As New Un4seen.Bass.Misc.WaveForm(FullName)
    '    wf.CallbackFrequency = 500 ' every 10 seconds rendered
    '    wf.ColorBackground = Color.Black

    '    'wf.ColorBase = Color.Lime
    '    'wf.ColorPeak = Color.Red
    '    Dim x As Boolean = wf.RenderStart(True, BASSFlag.BASS_SAMPLE_FLOAT)
    '    Return wf.CreateBitmap(600, 150, -1, -1, False)
    '    'Return Nothing
    'End Function

    Sub SaveFile()
        Try
            If File Is Nothing Then Return
            File.Save()
        Catch ex As Exception
            Return
        End Try
    End Sub

    Sub DeleteFile()
        Try
            If File Is Nothing Then Return
            If FullName Is Nothing Then Return
            IO.File.Delete(FullName)
        Catch ex As Exception
            Return
        End Try
    End Sub

    Sub CleanTag()

        If Tag Is Nothing Then Return
        Dim props As PropertyInfo() = GetWritableTags()
        Dim values As New List(Of Object)

        For Each pi As PropertyInfo In props
            Dim val As Object = pi.GetValue(Me)

            If pi.PropertyType Is GetType(String) Then
                If val Is Nothing Then values.Add("") Else values.Add(val)
            ElseIf pi.PropertyType Is GetType(Byte()) Then
                If val Is Nothing Then values.Add(CType({}, Byte())) Else values.Add(CType(val, Byte()).Clone)
            Else
                values.Add(val)
            End If
        Next

        Tag.Clear()

        For i = 0 To props.Count - 1
            props(i).SetValue(Me, values(i))
        Next

        Me.Comment = ""
        If Track = 0 Then Track = 1
        If Disc = 0 Then Disc = 1
        If DiscCount = 0 Then DiscCount = 1
        If TrackCount = 0 Then TrackCount = 1
        If AlbumArtist = Nothing Then AlbumArtist = Artist
        If Album = Nothing Then Album = Title

        Call TryToName()

    End Sub

    Sub TryToName()
        Dim artist As String = ""
        Dim feat As String = ""
        Dim title As String = ""

        Dim filename As String = Me.FileName

        If filename.Contains("_") And Not filename.Contains(" ") Then filename = filename.Replace("_", " ")
        filename = filename.Replace("(proposemusic.com)", "")
        filename = filename.Replace("[ClapCrate.me]", "")

        If filename.Contains("-") Then
            artist = filename.Split("-")(0).Trim
            title = filename.Split("-")(1).Trim
        End If


        If title = "" Then title = filename
        If artist = "" Then artist = filename

        If Me.Title Is Nothing Or Me.Title = "" Then Me.Title = title
        If Me.Artist Is Nothing Or Me.Artist = "" Then Me.Artist = artist
        If Me.AlbumArtist Is Nothing Or Me.AlbumArtist = "" Then Me.AlbumArtist = artist
        If Me.Album Is Nothing Or Me.Album = "" Then Me.Album = title



    End Sub


#End Region

#Region "Shared Methods"

    Shared Function Create(FullName As String) As Song
        Try
            Return New Song(FullName)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Shared Function IsSong(FullName As String) As Boolean
        Try
            Dim file As TagLib.File = TagLib.File.Create(FullName)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function CreateTaglibFile(fullName As String) As TagLib.File
        Try
            Return TagLib.File.Create(fullName)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Shared Function GetIPicture(data As Byte()) As IPicture
        Try
            Return New TagLib.Picture(data)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Shared Function GetImage(data As Byte()) As Drawing.Image

        Dim ms As MemoryStream = Nothing
        Dim image As Drawing.Image = Nothing
        Try
            ms = New MemoryStream(data)
            image = Drawing.Image.FromStream(ms)
            ms.Close()
        Catch ex As Exception
            If ms IsNot Nothing Then ms.Close()
        End Try
        Return image

    End Function

    Shared Function GetWritableTags() As PropertyInfo()
        With GetType(Song)
            Return {
                .GetProperty("Artist"),
                .GetProperty("Title"),
                .GetProperty("Album"),
                .GetProperty("AlbumArtist"),
                .GetProperty("Genre"),
                .GetProperty("Year"),
                .GetProperty("Track"),
                .GetProperty("TrackCount"),
                .GetProperty("Disc"),
                .GetProperty("DiscCount"),
                .GetProperty("CoverData"),
                .GetProperty("Comment")
                }
        End With
    End Function

#End Region






End Class
