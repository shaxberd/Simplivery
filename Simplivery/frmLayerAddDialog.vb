Public Class frmLayerAddDialog

    Private _availableLayers As List(Of Layer)

    Friend SelectedLayer As Guid
    Friend SelectedColor As Color

    Public Sub New(ByVal templatePath As String, ByVal layerType As LayerType, ByVal currentTemplate As Template, ByVal currentSetLayers As List(Of PresetLayer))

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        'initialize
        Dim tmpImageList As New ImageList
        tmpImageList.ImageSize = New Size(120, 60)
        Dim tmpListViewItem As ListViewItem

        'GUI
        Me.Text = String.Format("{0} {1}", Me.Text, layerType.ToString)
        
        'determine usable layers
        Dim tmpUsedLayers As List(Of Guid) = (From presetLayer In currentSetLayers Select presetLayer.LayerGuid).ToList
        _availableLayers = currentTemplate.Layers.Where(Function(x) x.Type = layerType AndAlso Not tmpUsedLayers.Contains(x.Guid)).ToList

        For Each tmpLayer In _availableLayers
            'add image to list
            tmpImageList.Images.Add(Image.FromFile(IO.Path.Combine(templatePath, currentTemplate.Guid.ToString, tmpLayer.FileName)))

            'add item
            tmpListViewItem = New ListViewItem({tmpLayer.Name, tmpLayer.Description}, tmpImageList.Images.Count - 1)
            tmpListViewItem.Tag = tmpLayer.Guid
            lviLayerList.Items.Add(tmpListViewItem)
        Next

        'set imagelist
        lviLayerList.LargeImageList = tmpImageList

        'disable color choosing or adjust color
        If Not layerType = Simplivery.LayerType.ColorDecal Then
            btnLayerColor.Enabled = False
            pnlLayerColor.Enabled = False
            lblLayerColor.Enabled = False
        Else
            pnlLayerColor.BackColor = frmMain.pnlAccentColor.BackColor
            SelectedColor = pnlLayerColor.BackColor
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnLayerColor_Click(sender As Object, e As EventArgs) Handles btnLayerColor.Click
        'choose and set selected color
        Using cld As New ColorDialog
            cld.Color = pnlLayerColor.BackColor
            If cld.ShowDialog = Windows.Forms.DialogResult.OK Then
                SelectedColor = cld.Color
                pnlLayerColor.BackColor = cld.Color
            End If
        End Using
    End Sub

    Private Sub lviLayerList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lviLayerList.SelectedIndexChanged
        If lviLayerList.SelectedItems.Count = 1 Then
            'display information on layer, set layer selected
            txtLayerName.Text = lviLayerList.SelectedItems(0).Text
            txtLayerDescription.Text = lviLayerList.SelectedItems(0).SubItems(1).Text

            SelectedLayer = DirectCast(lviLayerList.SelectedItems(0).Tag, Guid)
        End If
    End Sub
End Class