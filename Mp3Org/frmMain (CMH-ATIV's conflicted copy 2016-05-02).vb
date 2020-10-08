Imports System.IO
Imports id3

Public Class frmMain


    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click

        With dlgFolderBrowser
            If .ShowDialog = DialogResult.OK Then
                Dim Files As String() = Directory.GetFiles(.SelectedPath)


            End If


        End With

    End Sub
End Class

