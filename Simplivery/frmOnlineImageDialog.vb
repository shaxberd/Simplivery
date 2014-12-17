Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmOnlineImageDialog

#Region "Fields"

    Friend SelectedPath As String
    Private MyTempPath As String
    Private MyImagePath As String
    Private MyLastSearch As String
    Private MySearchPage As Integer

#End Region

#Region "Constructor"

    Public Sub New(ByVal tmpPath As String, ByVal imgPath As String)
        InitializeComponent()

        'initialize
        MyTempPath = tmpPath
        MyImagePath = imgPath
    End Sub

#End Region

#Region "Buttons"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lviImageList.SelectedItems.Count = 1 Then
            'copy image
            SelectedPath = Path.Combine(MyImagePath, Path.GetFileName(lviImageList.SelectedItems(0).Tag.ToString))
            File.Copy(lviImageList.SelectedItems(0).Tag.ToString, SelectedPath)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Please select an image to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Not String.IsNullOrWhiteSpace(txtSearchTerm.Text) Then
            Search(txtSearchTerm.Text, 0)
        Else
            MessageBox.Show("Please provide a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPrevPage_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click
        If Not String.IsNullOrWhiteSpace(MyLastSearch) Then
            Search(txtSearchTerm.Text, MySearchPage - 1)
        End If
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        If Not String.IsNullOrWhiteSpace(MyLastSearch) Then
            Search(txtSearchTerm.Text, MySearchPage + 1)
        End If
    End Sub

#End Region

#Region "Methods"

    Private Sub Search(ByVal searchTerm As String, ByVal page As Integer)
        'disable ui
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        'initialize ui
        Dim tmpImageList As New ImageList
        tmpImageList.ImageSize = New Size(250, 60)
        Dim tmpListViewItem As ListViewItem
        lviImageList.Items.Clear()
        'initialize web & dir/files
        Dim httpClient As New WebClient
        Dim searchString As String = searchTerm.Replace(" ", "%20")
        If Not Directory.Exists(MyTempPath) Then Directory.CreateDirectory(MyTempPath)
        Dim tmpFile As String
        Dim tmpImage As Image

        Try
            'initialize request
            Dim httpReq As HttpWebRequest = DirectCast(WebRequest.Create(String.Format("https://ajax.googleapis.com/ajax/services/search/images?v=1.0&q={0}&as_filetype=png&rsz=8&start={1}", searchString, page * 8)), HttpWebRequest)
            httpReq.Referer = "http://www.google.de"
            Dim httpStream As Stream = httpReq.GetResponse().GetResponseStream
            Dim httpResponse As New StreamReader(httpStream)
            Dim jsonString As String = httpResponse.ReadToEnd

            httpResponse.Dispose()
            httpStream.Close()
            httpStream.Dispose()

            Dim jsonPattern As String = "(?<=unescapedUrl"":"")[^""]*(?="",""url"")"
            For Each tmpMatch As Match In Regex.Matches(jsonString, jsonPattern)
                Try
                    'add image to list
                    tmpFile = Path.Combine(MyTempPath, String.Format("{0}.png", Guid.NewGuid.ToString))
                    httpClient.DownloadFile(tmpMatch.Value, tmpFile)

                    'load image & dispose (otherwise it will stay blocked later on)
                    tmpImage = Image.FromFile(tmpFile)
                    tmpImageList.Images.Add(New Bitmap(tmpImage))
                    tmpImage.Dispose()

                    'add item
                    tmpListViewItem = New ListViewItem("", tmpImageList.Images.Count - 1)
                    tmpListViewItem.Tag = tmpFile
                    lviImageList.Items.Add(tmpListViewItem)
                Catch ex As Exception
                    MessageBox.Show(String.Format("Image {0} could not be downloaded: {1}", tmpMatch.Value, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

            'set imagelist
            lviImageList.LargeImageList = tmpImageList

            'save search & infos; handle page buttons
            If lblCurrentPage.Enabled = False Then lblCurrentPage.Enabled = True
            lblCurrentPage.Text = String.Format("Page {0}", page.ToString)
            If page = 0 Then
                MyLastSearch = searchTerm
                MySearchPage = 0
                btnPrevPage.Enabled = False
                btnNextPage.Enabled = True
            Else
                MySearchPage = page
                btnPrevPage.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error retrieving or displaying results: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'clean up
        httpClient.Dispose()
        GC.Collect()

        'enable ui
        Me.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

#End Region


End Class