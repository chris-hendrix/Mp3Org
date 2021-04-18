Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable> Public Class Project

#Region "Data"

    Property SongList As SongList
    Property Settings As Settings

    Property FileNameOptionIndex As Integer
        Get
            If Settings Is Nothing Then Return 0
            Return Settings.FileNameOptionIndex
        End Get
        Set(value As Integer)
            If Settings Is Nothing Then Return
            Settings.FileNameOptionIndex = value
        End Set
    End Property
    Property RunPath As String
        Get
            If Settings Is Nothing Then Return Nothing
            Return Settings.RunPath
        End Get
        Set(value As String)
            If Settings Is Nothing Then Return
            Settings.RunPath = value
        End Set
    End Property

    ReadOnly Property SettingsFullname As String = Application.StartupPath & "\" & Settings.FileName

    Shared Property FileNameOptions As List(Of String) = New List(Of String)(
    {"...Artist\Album\01 Title.mp3", "...\Artist - Title - Album.mp3"})

#End Region

#Region "Constructor"

    Sub New()
        SongList = New SongList(Me)
        LoadSettings()
    End Sub

#End Region

#Region "Methods"


    Public Sub LoadSettings()
        Dim fs As FileStream = Nothing
        Dim bf As BinaryFormatter = Nothing

        Try
            fs = New FileStream(SettingsFullname, FileMode.Open)
            bf = New BinaryFormatter
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
        Settings.RunPath = RunPath
        Dim fs As New FileStream(SettingsFullname, FileMode.Create)
        Dim bf As New BinaryFormatter
        bf.Serialize(fs, Settings)
        fs.Close()
    End Sub

    Public Sub Load(RunPath As String)
        If SongList Is Nothing Then Return
        SongList.Fill(RunPath)
        Call SaveSettings()
    End Sub

    Public Sub Run(RunPath As String)
        If SongList Is Nothing Then Return
        SongList.ChangeDirectories(RunPath, FileNameOptionIndex)
        SongList.Fill(RunPath)
        CleanDirectories(RunPath)
        Call SaveSettings()

        MsgBox("Complete")
    End Sub

#End Region



End Class

<Serializable()> Public Class Settings

    Shared Property FileName As String = "Settings.dat"
    Property RunPath As String
    Property FileNameOptionIndex As Integer


End Class
