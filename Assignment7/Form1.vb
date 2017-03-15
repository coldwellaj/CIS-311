'--------------------------------------------------------------------'
'-          File name: Form1.vb                                     -'
'-          Part of project: Assignment7                            -'
'--------------------------------------------------------------------'
'-          Written By: Alex Coldwell                               -'
'-          Written On: 03/14/2017                                  -'
'--------------------------------------------------------------------'
'- File Purpose:                                                    -'
'-                                                                  -'
'- This file allows the user to set the directory source, and the   -'
'- directory destination. This program then allows them to select,  -'
'- then drag and drop the files they would like to move into the    -'
'- destination directory.                                           -'
'--------------------------------------------------------------------'
'- Program Purpose:                                                 -'
'-                                                                  -'
'- This program allows users to move files around on their machines -'
'- using a simple drag and drop interface. The user can set their   -'
'- source directory, and their destination directory, then select   -'
'- and drag and drop their selected files from the source directory -'
'- into the destination directory.                                  -'
'--------------------------------------------------------------------'
'- Global Variable Dictionary                                       -'
'- (none)                                                           -'
'--------------------------------------------------------------------'

Public Class Form1
    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdSetSource_Click          -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 03/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the Set Source    -'
    '-   command button. This sub give the user a folder browser dialog-'
    '-   box for the user to select a source directory from. After the -'
    '-   user selects a source directory the sub then calls printSource-'
    '-   to print all the files from the directory into the source     -'
    '-   listbox.                                                      -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   strSource - String to hold the memory address of the source   -'
    '-------------------------------------------------------------------'
    Private Sub cmdSetSource_Click(sender As Object, e As EventArgs) Handles cmdSetSource.Click
        Dim strSource As String

        ' Show dialog and get source file
        FolderBrowserDialog1.ShowDialog()
        strSource = FolderBrowserDialog1.SelectedPath()
        txtSource.Text = strSource

        ' Print source directory
        printSource(strSource)

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: cmdSetDestination_Click     -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 03/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user presses the Set Destina-  -'
    '-   tion command button. This sub give the user a folder browser  -'
    '-   dialog box for the user to select a destionation directory    -'
    '-   from. After the user selects a destination directory the sub  -'
    '-   then calls printDestination to print all the files from the   -'
    '-   destionation directory into the destination listbox.          -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   strDestination - String to hold the memory address of the     -'
    '-                    destionation directory                       -'
    '-------------------------------------------------------------------'
    Private Sub cmdSetDestination_Click(sender As Object, e As EventArgs) Handles cmdSetDestination.Click
        Dim strDestination As String

        ' Show dialog and get source file
        FolderBrowserDialog1.ShowDialog()
        strDestination = FolderBrowserDialog1.SelectedPath()
        txtDestination.Text = strDestination

        ' Print destination directory
        printDestination(strDestination)

    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: lstSourceFiles_MouseMove    -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 03/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user moves the mouse over the  -'
    '-   source files listbox. If the user is not clicking down on the -'
    '-   mouse then the sub will exit. if the user is clicking down on -'
    '-   a selected item then the sub will start a drag drop event.    -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          mouse move event                                       -'
    '- e – Holds the MouseEventArgs object sent to the routine         -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   dropEffect - DragDropEffects object to hold the drag drop.    -'
    '-------------------------------------------------------------------'
    Private Sub lstSourceFiles_MouseMove(sender As Object, e As MouseEventArgs) Handles lstSourceFiles.MouseMove
        Dim dropEffect As DragDropEffects

        'If no mouse button was pressed, get out of here 
        If e.Button = 0 Then
            Exit Sub
        End If

        Try
            If e.Button = MouseButtons.Left Then
                'If the left mouse button is down, proceed with the             
                'drag-and-drop, passing in the list item.                                 
                dropEffect = lstSourceFiles.DoDragDrop(lstSourceFiles.Items(lstSourceFiles.SelectedIndex),
                                                       DragDropEffects.All Or
                                                       DragDropEffects.Link)
            End If
        Catch ex As Exception
        End Try

    End Sub

    '-------------------------------------------------------------------'
    '-               Subprogram Name: lstDestinationFiles_DragEnter    -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 03/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user moves the mouse over the  -'
    '-   destination files listbox durring a dragdrop. This sub changes-'
    '-   the courser to Copy effect                                    -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          drag drop event                                        -'
    '- e – Holds the DragEventArgs object sent to the routine          -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub lstDestinationFiles_DragEnter(sender As Object, e As DragEventArgs) Handles lstDestinationFiles.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    '-------------------------------------------------------------------'
    '-               Subprogram Name: lstDestination_DragDrop          -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 03/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the user drops after a drag drop   -'
    '-   into the destination listbox. This sub finds the total number -'
    '-   of bytes to move, and then the total number of files to move. -'
    '-   The sub then copies each file selected from the source        -'
    '-   directory to the destination directory. If the file already   -'
    '-   exists then the sub will either copy over the file or notify  -'
    '-   the user that they selected to do nothing and that the sub    -'
    '-   did nothing with the file.                                    -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          drag drop event                                        -'
    '- e – Holds the DragEventArgs object sent to the routine          -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   intBytesProcessed - int to hold the number of bytes processed -'
    '-   intFilesProcessed - int to hold the number of files processed -'
    '-   intTotalBytes - int to hold the total bytes to process        -'
    '-   intTotalFiles - int to hold the total files to process        -'
    '-   strDestination - string to hold the destination address       -'
    '-   strSource - string to hold the source directory address       -'
    '-------------------------------------------------------------------'
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
                    My.Computer.FileSystem.CopyFile(strSource, strDestination)
                Else
                    intBytesProcessed += FileLen(strSource)
                    MessageBox.Show("The file you selected to move already exists in the" + vbCrLf +
                    "destination directory. You selected to not copy if the file already" + vbCrLf +
                    "exist, so if you would like to overwrite the file please select the" + vbCrLf +
                    "option on the trackbar.")
                End If
            Else
                intBytesProcessed += FileLen(strSource)
                My.Computer.FileSystem.CopyFile(strSource, strDestination)
            End If
            intFilesProcessed += 1
            lblByteProcess.Text = "Bytes Processed: " & intBytesProcessed &
                " / " & intTotalBytes
        Next
        ProgressBar1.Value = intBytesProcessed
        printSource(txtSource.Text)
        printDestination(txtDestination.Text)
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: printSource                 -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 03/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub prints all of the files in the source directory into -'
    '-   the source listbox.                                           -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  address - string of the memory address of the source directory -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   objFiles - object to hold the files in the source directory   -'
    '-   strFileName - string to hold the file name                    -'
    '-------------------------------------------------------------------'
    Public Sub printSource(address As String)
        Dim strFileName As String
        Dim objFiles As Object

        objFiles = IO.Directory.GetFiles(address)

        ' Clear listbox and print files
        lstSourceFiles.Items.Clear()
        For Each elem In objFiles
            strFileName = elem
            strFileName = strFileName.Remove(0, address.Length() + 1)
            lstSourceFiles.Items.Add(strFileName)
        Next
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: printDestination            -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 03/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub prints all of the files in the destination directory -'
    '-   into the destination listbox.                                 -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '-  address - string of the memory address of the dest. directory  -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   objFiles - object to hold the files in the dest. directory     -'
    '-   strFileName - string to hold the file name                    -'
    '-------------------------------------------------------------------'
    Public Sub printDestination(address As String)
        Dim strFileName As String
        Dim strFiles As Object

        strFiles = IO.Directory.GetFiles(address)

        ' Clear listbox and print files
        lstDestinationFiles.Items.Clear()
        For Each elem In strFiles
            strFileName = elem
            strFileName = strFileName.Remove(0, address.Length() + 1)
            lstDestinationFiles.Items.Add(strFileName)
        Next
    End Sub

    '-------------------------------------------------------------------'
    '-                    Subprogram Name: Form1_Load                  -'
    '-------------------------------------------------------------------'
    '-                    Written By: Alex Coldwell                    -'
    '-                    Written On: 03/14/17                         -'
    '-------------------------------------------------------------------'
    '- Sub Purpose:                                                    -'
    '-   This sub is triggered when the form is loaded into memory.    -'
    '-   The sub sets the toolbar lables text to "".                   -'
    '-------------------------------------------------------------------'
    '- Parameter Dictionary (in parameter order):                      -'
    '- sender – Identifies which particular control raised the         –'
    '-          click event                                            -'
    '- e – Holds the EventArgs object sent to the routine              -'
    '-------------------------------------------------------------------'
    '- Local Variable Dictionary (alphabetically):                     -'
    '-   (none)                                                        -'
    '-------------------------------------------------------------------'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblByteProcess.Text = ""
        lblFileNumber.Text = ""
        lblFileProcess.Text = ""
    End Sub
End Class
