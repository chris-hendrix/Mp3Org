Imports System.IO

Module Tools

    Function RemoveInvalidFileNameChars(UserInput As String, Optional repl As String = "_") As String
        UserInput = UserInput.Trim
        For Each invalidChar In IO.Path.GetInvalidFileNameChars
            UserInput = UserInput.Replace(invalidChar, repl)
        Next
        Return UserInput
    End Function

    Sub CleanDirectories(path As String)
        For Each dir As String In Directory.GetDirectories(path)
            CleanDirectories(dir)
            If Directory.GetFiles(dir).Length = 0 AndAlso Directory.GetDirectories(dir).Length = 0 Then
                Directory.Delete(dir, False)
            End If
        Next
    End Sub

    ' return a list of all controls in a container
    Function GetControls(control As Control, Optional ByRef controlList As List(Of Control) = Nothing) As List(Of Control)

        ' create control list if it is null
        If IsNothing(controlList) Then controlList = New List(Of Control)
        controlList.Add(control)
        For Each c As Control In control.Controls
            GetControls(c, controlList)
        Next
        Return controlList
    End Function

    Sub BindTextBoxes(control As Control, item As Object, Optional autoSetIndices As Boolean = False)

        Dim controls As List(Of Control) = GetControls(control)
        If autoSetIndices Then SetTabIndices(controls)

        For Each c As Control In controls
            If TypeOf c Is TextBox Then
                If c.Name.Contains("Track") And CType(c, TextBox).Text <> "" Then
                    Dim x = 2
                End If
                BindTextBox(c, item)
            End If
        Next
    End Sub




    Sub BindTextBox(tb As TextBox, item As Object)

        Dim dataMember As String = tb.Name.Substring(3)
        If item.GetType.GetProperty(dataMember) Is Nothing Then Return

        With tb.DataBindings
            .Clear()
            .Add("Text", item, dataMember)
        End With

    End Sub

    Public Sub SetTabIndices(list As IEnumerable(Of Control), Optional ByRef index As Integer = 0)

        Dim z As List(Of Control) = list.OrderBy(Function(x) x.Location.X).ThenBy(Function(x) x.Location.Y).ToList
        For Each c As Control In list.OrderBy(Function(x) x.Location.Y).ThenBy(Function(x) x.Location.X).ToList
            If TypeOf c Is CheckBox Or TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.TabIndex = index
                index += 1
            Else
                c.TabStop = False
            End If
        Next
    End Sub
    'Sub RemoveEmptyFolders(ByVal path As String)
    '    Dim di As New IO.DirectoryInfo(path)
    '    For Each directory As IO.DirectoryInfo In di.GetDirectories
    '        If GetAllFiles(directory.FullName).Count = 0 Then directory.Delete()
    '    Next
    'End Sub




End Module
