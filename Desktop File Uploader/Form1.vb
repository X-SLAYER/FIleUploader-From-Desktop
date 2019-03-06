Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions


Public Class Form1

    'CODED BY X-SLAYER
    '03/06/2019 09:41 pm
    'YOUTUBE : https://www.youtube.com/c/XSLAYERTN
    'INSTAGRAM : https://www.instagram.com/ih3_b/
    'FACEBOOK : https://www.facebook.com/XSLAYER404


    Public MoveForm As Boolean
    Public MouseX, MouseY As Integer
    '//-------------------------------------------------------
    Private Items As New Dictionary(Of WebClient, ListViewItem)
    Private Files As New ArrayList


    Private Sub GetURI(ByVal Fichier As String)
       Try
            IM.Images.Add(Icon.ExtractAssociatedIcon(Fichier))
            Dim NewItem As New ListViewItem
            NewItem.UseItemStyleForSubItems = False
            NewItem.Text = Path.GetFileName(Fichier)
            NewItem.SubItems.Add("Getting Data...").ForeColor = Color.Yellow
            NewItem.ImageIndex = IM.Images.Count - 1
            Dim Info As New FIleInfo
            NewItem.Tag = Info
            Lv1.Items.Add(NewItem)
            Using WC As New WebClient
                WC.Encoding = Encoding.UTF8
                AddHandler WC.DownloadStringCompleted, AddressOf COMPLETE
                WC.DownloadStringTaskAsync(New Uri("https://anonfile.com/"))
                Items.Add(WC, NewItem)
                Files.Add(Fichier)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub COMPLETE(sender As Object, e As DownloadStringCompletedEventArgs)
        On Error Resume Next
        If e.Cancelled = True Then
            Items(sender).SubItems(1).Text = "Cancelled..."
            Items(sender).SubItems(1).ForeColor = Color.Orange
        ElseIf e.Error IsNot Nothing Then
            Items(sender).SubItems(1).Text = "Error..."
            Items(sender).SubItems(1).ForeColor = Color.Red
        ElseIf e.Result IsNot Nothing Then
            Dim URL As String = "https://anonfile.com/api/upload"
            Dim token As String = Regex.Match(e.Result, " {'X-CSRF-Token': '(.*?)'}").Groups(1).Value
            Using WC As New WebClient

                WC.Headers.Add("Origin", "https://anonfile.com")
                WC.Headers.Add("X-CSRF-Token", token)
                WC.Headers.Add("X-Requested-With", "XMLHttpRequest")

                AddHandler WC.UploadProgressChanged, AddressOf LOADING
                AddHandler WC.UploadFileCompleted, AddressOf COMPLETE

                WC.UploadFileTaskAsync(New Uri(URL), Files(Items(sender).Index))

                Dim NewItem As ListViewItem = Items(sender)
                Items.Remove(sender)
                Items.Add(WC, NewItem)

            End Using
        Else
            Items(sender).SubItems(1).Text = "Error..."
        End If
    End Sub

    Private Sub LOADING(sender As Object, e As UploadProgressChangedEventArgs)
        On Error Resume Next
        Items(sender).SubItems(1).Text = "Uploading: (" & FileSize(e.BytesSent) & "/" & FileSize(e.TotalBytesToSend) & ")..."
    End Sub

    Private Sub COMPLETE(sender As Object, e As UploadFileCompletedEventArgs)
        Try
            If e.Cancelled = True Then
                Items(sender).SubItems(1).Text = "Cancelled..."
                Items(sender).SubItems(1).ForeColor = Color.OrangeRed
            ElseIf e.Error IsNot Nothing Then
                Items(sender).SubItems(1).Text = "Error..."
                Items(sender).SubItems(1).ForeColor = Color.Red
            ElseIf e.Result IsNot Nothing Then
                Dim Result As String = Encoding.UTF8.GetString(e.Result)
                If Result.Contains("{""status"":true,") Then
                    Items(sender).Tag.SetInfo(Result)
                    Items(sender).SubItems(1).Text = "Done."
                    Items(sender).SubItems(1).ForeColor = Color.Green
                ElseIf Result.Contains("The file is too large") Then
                    Items(sender).SubItems(1).Text = "Max File Size = 5GB."
                    Items(sender).SubItems(1).ForeColor = Color.DarkOrange
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
        End Try

    End Sub

#Region "DRAG & DROP , FILE SIZE"



    Private Function FileSize(ByVal Tamanho As Double) As String
        Dim Tipos As String() = {"B", "KB", "MB", "GB"}
        Dim TamanhoDouble As Double = Tamanho
        Dim CSA As Integer = 0
        While TamanhoDouble >= 1024 AndAlso CSA + 1 < Tipos.Length
            CSA += 1
            TamanhoDouble = TamanhoDouble / 1024
        End While
        Return [String].Format("{0:0.##} {1}", TamanhoDouble, Tipos(CSA))
    End Function

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop, Lv1.DragDrop
        For Each X In e.Data.GetData(DataFormats.FileDrop)
            If File.Exists(X) Then
                GetURI(X)
            ElseIf Directory.Exists(X) Then
                For Each O In Directory.GetFiles(X, "*.*", SearchOption.AllDirectories)
                    GetURI(O)
                Next
            End If
        Next
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter, Lv1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

#End Region

    Private Sub CopyFullLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyFullLinkToolStripMenuItem.Click
        On Error Resume Next
        Lv1.FocusedItem.Tag.GetClipboard("FULL")
    End Sub

    Private Sub CopyShortLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyShortLinkToolStripMenuItem.Click
        On Error Resume Next
        Lv1.FocusedItem.Tag.GetClipboard("SHORT")
    End Sub

#Region "Form Moving"

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, lb1.MouseDown, P1.MouseDown
        MoveForm = True
        MouseX = Cursor.Position.X - Me.Left
        MouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, lb1.MouseMove, P1.MouseMove
        If MoveForm Then
            MoveForm = True
            Me.Left = Cursor.Position.X - MouseX
            Me.Top = Cursor.Position.Y - MouseY
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, lb1.MouseUp, P1.MouseMove
        MoveForm = False
    End Sub

#End Region

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim I As New OpenFileDialog
        I.Title = "Browse File"
        I.Filter = "All Files (*.*)|*.*"
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            GetURI(I.FileName)
        End If
    End Sub

    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click
        Dim I As New FolderBrowserDialog
        I.Description = "Browse Folder"
        I.ShowNewFolderButton = True
        If I.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each O In Directory.GetFiles(I.SelectedPath, "*.*", SearchOption.AllDirectories)
                GetURI(O)
            Next
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Coded By : X-SLAYER" & vbCrLf & "Youtube : X-SLAYER", MsgBoxStyle.Information, "About Coder")
    End Sub

    Private Sub CM1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CM1.Opening
        If Lv1.Items.Count = 0 Then
            CopyFullLinkToolStripMenuItem.Enabled = False
            CopyShortLinkToolStripMenuItem.Enabled = False
        ElseIf Lv1.FocusedItem.SubItems(1).Text.Contains("Done") Then
            CopyFullLinkToolStripMenuItem.Enabled = True
            CopyShortLinkToolStripMenuItem.Enabled = True
        End If

    End Sub
End Class
