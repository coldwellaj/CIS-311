Public Class Form1
    Private Sub cmdSetSource_Click(sender As Object, e As EventArgs) Handles cmdSetSource.Click
        Dim strSource As String

        FolderBrowserDialog1.ShowDialog()
        strSource = FolderBrowserDialog1.SelectedPath()
        txtSource.Text = strSource

        printSource(strSource)

    End Sub

    Private Sub cmdSetDestination_Click(sender As Object, e As EventArgs) Handles cmdSetDestination.Click
        Dim strDestination As String

        FolderBrowserDialog1.ShowDialog()
        strDestination = FolderBrowserDialog1.SelectedPath()
        txtDestination.Text = strDestination

        printDestination(strDestination)

    End Sub

    Private Sub lstSourceFiles_MouseMove(sender As Object, e As MouseEventArgs) Handles lstSourceFiles.MouseMove
        Dim dropEffect As DragDropEffects

        'If no mouse button was pressed, get out of here 
        If e.Button = 0 Then
            Exit Sub
        End If

        If e.Button = MouseButtons.Left Then
            'If the left mouse button is down, proceed with the             
            'drag-and-drop, passing in the list item.                                 
            dropEffect = lstSourceFiles.DoDragDrop(lstSourceFiles.Items(lstSourceFiles.SelectedIndex),
                                                   DragDropEffects.All Or
                                                   DragDropEffects.Link)
        End If
    End Sub

    Private Sub lstDestinationFiles_DragEnter(sender As Object, e As DragEventArgs) Handles lstDestinationFiles.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub lstDestination_DragDrop(sender As Object, e As DragEventArgs) Handles lstDestinationFiles.DragDrop
        Dim strSource As String
        Dim strDestination As String

        For Each elem In lstSourceFiles.SelectedItems()
            strSource = txtSource.Text + "\" + elem
            strDestination = txtDestination.Text + "\" + elem
            If IO.File.Exists(strDestination) Then
                If tbrOverwrite.Value = 1 Then
                    My.Computer.FileSystem.DeleteFile(strDestination)
                    My.Computer.FileSystem.MoveFile(strSource, strDestination)
                Else
                    MessageBox.Show("The file you selected to move already exists in the" + vbCrLf +
                    "destination directory. You selected to not copy if the file already" + vbCrLf +
                    "exist, so if you would like to overwrite the file please select the" + vbCrLf +
                    "option on the trackbar.")
                End If
            Else
                My.Computer.FileSystem.MoveFile(strSource, strDestination)
            End If
        Next

        printSource(txtSource.Text)
        printDestination(txtDestination.Text)
    End Sub

    Public Sub printSource(address As String)
        Dim strFileName As String
        Dim strFiles As Object

        strFiles = IO.Directory.GetFiles(address)

        lstSourceFiles.Items.Clear()
        For Each elem In strFiles
            strFileName = elem
            strFileName = strFileName.Remove(0, address.Length() + 1)
            lstSourceFiles.Items.Add(strFileName)
        Next
    End Sub

    Public Sub printDestination(address As String)
        Dim strFileName As String
        Dim strFiles As Object

        strFiles = IO.Directory.GetFiles(address)

        lstDestinationFiles.Items.Clear()
        For Each elem In strFiles
            strFileName = elem
            strFileName = strFileName.Remove(0, address.Length() + 1)
            lstDestinationFiles.Items.Add(strFileName)
        Next
    End Sub
End Class
