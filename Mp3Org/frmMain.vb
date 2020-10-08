Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class frmMain

#Region "Data"

    Private Property Project As New Project
    Private ReadOnly Property Settings As Settings
        Get
            If Project Is Nothing Then Return Nothing
            Return Project.Settings
        End Get
    End Property
    Private ReadOnly Property SongList As SongList
        Get
            If Project Is Nothing Then Return Nothing
            Return Project.SongList
        End Get
    End Property
    Private ReadOnly Property RunPath As String
        Get
            If txtRunPath.Text.Trim = "" Then Return Nothing
            Return txtRunPath.Text.Trim
        End Get
    End Property
    Private ReadOnly Property SelectedSong As Song
        Get
            With dgvSongList

                If .SelectedCells.Count = 0 Then Return Nothing
                If .Rows.Count = 0 Then Return Nothing
                Return .Rows(.SelectedCells(0).RowIndex).DataBoundItem

            End With

        End Get
    End Property

#End Region

#Region "Subs"

    Private Sub BindControls()

        If SelectedSong Is Nothing Then Return

        With picCover.DataBindings
            .Clear()
            Try
                .Add("Image", SelectedSong, "Cover")
            Catch ex As Exception
                picCover.Image = Nothing
            End Try
        End With

        With lblCoverSize.DataBindings
            .Clear()
            .Add("Text", SelectedSong, "CoverSize")
        End With

        BindTextBoxes(tlpTagEditor, SelectedSong)

        For Each c As Control In GetControls(tlpTagEditor)
            If TypeOf c Is TextBox Then
                AddHandler CType(c, TextBox).Validated, AddressOf Me.txt_Validated
            End If
        Next

    End Sub





#End Region

#Region "General Handlers"

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized
        With dgvSongList
            .AutoGenerateColumns = False
            .DataSource = Nothing
            .DataSource = SongList
        End With

        txtRunPath.TextBox.DataBindings.Add("Text", Project, "RunPath")


    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If SongList Is Nothing Then Return
        If RunPath Is Nothing Then Return
        Project.Load(RunPath)
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Project.Run(RunPath)
    End Sub

    Private Sub btnSearchCovers_Click(sender As Object, e As EventArgs) Handles btnSearchCovers.Click
        Dim query As String = ""

        For Each s As Song In SongList
            query = s.SearchTerm
            Process.Start("https://www.google.com/search?tbm=isch&q=" + Uri.EscapeDataString(query))
        Next
    End Sub

    Private Sub btnRemoveCover_Click(sender As Object, e As EventArgs) Handles btnRemoveCover.Click
        If SelectedSong Is Nothing Then Return
        SelectedSong.CoverData = {}
        picCover.Image = Nothing
        dgvSongList.Refresh()
    End Sub

#End Region

#Region "Dgv Handlers"

    Private Sub dgvSongList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSongList.SelectionChanged
        With picCover
            .DataBindings.Clear()
            If SelectedSong Is Nothing Then Return
            BindControls()
        End With

        ' picVisualizer.Image = SelectedSong.GetWaveForm


    End Sub

    Private Sub dgvSongList_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvSongList.UserDeletingRow
        e.Cancel = MsgBox("Delete file?", MsgBoxStyle.YesNo) = MsgBoxResult.No
    End Sub

    Private Sub dgvSongList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSongList.KeyDown
        Dim dgv As DataGridView = sender

        ' delete
        If e.KeyCode = Keys.Delete Then
            If dgv.SelectedRows.Count > 0 Then Return
            For Each c As DataGridViewCell In dgv.SelectedCells
                If c.ColumnIndex = colCoverImage.Index Then
                    SelectedSong.CoverData = Nothing
                Else
                    c.Value = Nothing
                End If
            Next
            dgvSongList.Refresh()
        End If

        ' ctrl c
        If e.Control AndAlso e.KeyCode = Keys.C Then
            Dim d As DataObject = dgv.GetClipboardContent()
            Clipboard.SetDataObject(d)
            e.Handled = True
        End If

        ' ctrl v
        If e.Control AndAlso e.KeyCode = Keys.V Then

            Dim vals As New List(Of String())
            For Each ln As String In Clipboard.GetText().Split(ControlChars.Lf)
                vals.Add(ln.Split(ControlChars.Tab))
            Next


            Dim rows As List(Of Integer) = dgv.SelectedCells.Cast(Of DataGridViewCell)().[Select](Function(cell) cell.RowIndex).Distinct().ToList
            Dim cols As List(Of Integer) = dgv.SelectedCells.Cast(Of DataGridViewCell)().[Select](Function(cell) cell.ColumnIndex).Distinct().ToList
            rows.Sort()
            cols.Sort()

            Dim i As Integer = 0

            For Each r As Integer In rows
                Dim j As Integer = 0
                For Each c As Integer In cols
                    dgv.Rows(r).Cells(c).Value = vals(i Mod vals.Count)(j Mod vals(0).Count)
                    j += 1
                Next
                i += 1
            Next



        End If
    End Sub

    Private Sub dgvSongList_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSongList.CellValueChanged
        If Project Is Nothing Then Return
        Project.SaveSettings()

        dgvSongList.Refresh()
    End Sub


#End Region

#Region "TextBox Handlers"

    Private Sub txt_Validated(sender As Object, e As EventArgs)
        'Me.Refresh()
    End Sub

#End Region

#Region "DragDrop Handlers"

    ' https://www.codeproject.com/Articles/19120/Drop-images-from-IE

    Private Sub dgvSongList_DragEnter(sender As Object, e As DragEventArgs) Handles dgvSongList.DragEnter
        If e.Data.GetDataPresent("HTML Format") Then
            e.Effect = DragDropEffects.Copy
            dgvSongList.Select()
        End If
    End Sub

    Private Sub dgvSongList_DragDrop(sender As Object, e As DragEventArgs) Handles dgvSongList.DragDrop
        Dim clipboardHtml As String = DirectCast(e.Data.GetData("HTML Format"), String)
        Dim htmlFragment As String = getHtmlFragment(clipboardHtml)
        Dim imageSrc As String = parseImageSrc(htmlFragment)
        Dim baseURL As String = parseBaseURL(clipboardHtml)


        ' If imageSrc.ToUpper().IndexOf("HTTP://") <> 0 Then imageSrc = baseURL & imageSrc.Substring(1)

        Dim client As New WebClient
        Dim imgArr As Byte() = client.DownloadData(imageSrc)
        Dim pt As Point = dgvSongList.PointToClient(New Point(e.X, e.Y))
        With dgvSongList
            .Select()
            Dim hti As DataGridView.HitTestInfo = .HitTest(pt.X, pt.Y)
            If hti.RowIndex < 0 Then Return
            Dim song As Song = .Rows(hti.RowIndex).DataBoundItem
            Try
                song.CoverData = imgArr
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            .Refresh()
        End With

        With picCover.DataBindings
            .Clear()
            .Add("Image", SelectedSong, "Cover")
        End With
    End Sub

    Private Function getHtmlFragment(clipboardHtml As String) As String
        Dim fragStartPos As Integer = Integer.Parse(Regex.Match(clipboardHtml, "^StartFragment:(\d+)", RegexOptions.Multiline).Groups(1).Value)
        Dim fragEndPos As Integer = Integer.Parse(Regex.Match(clipboardHtml, "^EndFragment:(\d+)", RegexOptions.Multiline).Groups(1).Value)
        Return clipboardHtml.Substring(fragStartPos, fragEndPos - fragStartPos)
    End Function

    Private Function parseImageSrc(html As String) As String
        Return Regex.Match(html, "<img.*?src=[""'](.*?)[""'].*>", RegexOptions.IgnoreCase Or RegexOptions.Singleline).Groups(1).Value
    End Function

    Private Function parseBaseURL(html As String) As String
        '.*?/, 
        Return Regex.Match(html, "http://.*?/", RegexOptions.IgnoreCase).Groups(0).Value
    End Function






#End Region

End Class