Public Class frmLayerEditDialog

#Region "Field"

    Friend SelectedColor As Color

#End Region

#Region "Constructor"

    Public Sub New(ByVal layerGuid As Guid, ByVal templatePath As String, ByVal currentTemplate As Template, ByVal currentSetLayers As List(Of PresetLayer))
        InitializeComponent()

        Try
            'get layer & initialise GUI
            Dim tmpLayer As Layer = currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = layerGuid)
            If tmpLayer IsNot Nothing Then
                picLayer.Image = Image.FromFile(IO.Path.Combine(templatePath, currentTemplate.Guid.ToString, tmpLayer.FileName))
                Me.Text = String.Format("{0} {1}", Me.Text, tmpLayer.Name)
                txtLayerName.Text = tmpLayer.Name
                pnlLayerColor.BackColor = Color.FromArgb(currentSetLayers.FirstOrDefault(Function(x) x.LayerGuid = layerGuid).Color)
                SelectedColor = pnlLayerColor.BackColor
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Abort
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error initializing layer dialog: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub

#End Region

#Region "Buttons"

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

#End Region


End Class