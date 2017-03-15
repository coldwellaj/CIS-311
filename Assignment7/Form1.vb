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
        Dim intTotalBytes As Integer = 0
        Dim intBytesProcessed As Integer = 0
        Dim intTotalFiles As Integer = 0
        Dim intFilesProcessed As Integer = 1

        For Each file In lstSourceFiles.SelectedItems()
            strSource = txtSource.Text + "\" + file
            intTotalBytes += FileLen(strSource)
            intTotalFiles += 1
        Next


        lblFileProcess.Text = ""
        lblByteProcess.Text = "Bytes Processed: " & intBytesProcessed &
                " / " & intTotalBytes
        ProgressBar1.Maximum = intTotalBytes
        ProgressBar1.Value = intBytesProcessed

        For Each file In lstSourceFiles.SelectedItems()
            strSource = txtSource.Text + "\" + file
            strDestination = txtDestination.Text + "\" + file

            ' Print labels for progress toolstrip
            lblFileProcess.Text = "Processing File: " & strSource
            lblFileNumber.Text = "Processing File: " & intFilesProcessed &
                " of " & intTotalFiles


            If IO.File.Exists(strDestination) Then
                If tbrOverwrite.Value = 1 Then
                    intBytesProcessed += FileLen(strSource)
                    My.Computer.FileSystem.DeleteFile(strDestination)
                    My.Computer.FileSystem.MoveFile(strSource, strDestination)
                Else
                    MessageBox.Show("The file you selected to move already exists in the" + vbCrLf +
                    "destination directory. You selected to not copy if the file already" + vbCrLf +
                    "exist, so if you would like to overwrite the file please select the" + vbCrLf +
                    "option on the trackbar.")
                End If
            Else
                intBytesProcessed += FileLen(strSource)
                My.Computer.FileSystem.MoveFile(strSource, strDestination)
            End If
            intFilesProcessed += 1
            lblByteProcess.Text = "Bytes Processed: " & intBytesProcessed &
                " / " & intTotalBytes
        Next
        ProgressBar1.Value = intBytesProcessed
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblByteProcess.Text = ""
        lblFileNumber.Text = ""
        lblFileProcess.Text = ""
    End Sub
End Class
