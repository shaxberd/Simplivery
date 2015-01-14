Public Class frmLayerEditDialog

#Region "Field"

    Friend SelectedColor As Color
    Friend SelectedColorType As PresetColorType

#End Region

#Region "Constructor"

    Public Sub New(ByVal layerGuid As Guid, ByVal templatePath As String, ByVal currentTemplate As Template, ByVal currentSetLayers As List(Of PresetLayer))
        InitializeComponent()

        Try
            'get layer & initialise GUI
            Me.Icon = My.Resources.icon
            Dim tmpLayer As Layer = currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = layerGuid)
            If tmpLayer IsNot Nothing Then
                'load image, text & name
                picLayer.Image = Image.FromFile(IO.Path.Combine(templatePath, currentTemplate.Guid.ToString, tmpLayer.FileName))
                Me.Text = String.Format("{0} {1}", Me.Text, tmpLayer.Name)
                txtLayerName.Text = tmpLayer.Name

                'load color setting
                Dim tmpPreset As PresetLayer = currentSetLayers.FirstOrDefault(Function(x) x.LayerGuid = layerGuid)
                If Not tmpPreset.PresetColor = PresetColorType.NonColorable Then
                    SelectedColorType = tmpPreset.PresetColor
                    Select Case tmpPreset.PresetColor
                        Case PresetColorType.Main
                            cmbColorStyle.SelectedIndex = 0
                        Case PresetColorType.Accent
                            cmbColorStyle.SelectedIndex = 1
                        Case PresetColorType.Third
                            cmbColorStyle.SelectedIndex = 2
                        Case PresetColorType.CustomPreset
                            pnlLayerColor.Enabled = True
                            btnLayerColor.Enabled = True
                            cmbColorStyle.SelectedIndex = 3
                    End Select
                    pnlLayerColor.BackColor = Color.FromArgb(tmpPreset.Color)
                    SelectedColor = pnlLayerColor.BackColor
                Else
                    cmbColorStyle.Enabled = False
                End If
                
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Abort
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error initializing layer dialog: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub

#End Region

#Region "Buttons & GUI"

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

    Private Sub cmbColorStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColorStyle.SelectedIndexChanged
        Select Case cmbColorStyle.SelectedIndex
            Case 0
                SelectedColorType = PresetColorType.Main
                pnlLayerColor.BackColor = frmMain.pnlBaseColor.BackColor
            Case 1
                SelectedColorType = PresetColorType.Accent
                pnlLayerColor.BackColor = frmMain.pnlAccentColor.BackColor
            Case 2
                SelectedColorType = PresetColorType.Third
                pnlLayerColor.BackColor = frmMain.pnlThirdColor.BackColor
            Case 3
                'enable color choosing, exit out
                SelectedColorType = PresetColorType.CustomPreset
                pnlLayerColor.Enabled = True
                btnLayerColor.Enabled = True
                Exit Sub
        End Select
        'set color & disable color choosing
        SelectedColor = pnlLayerColor.BackColor
        pnlLayerColor.Enabled = False
        btnLayerColor.Enabled = False
    End Sub

#End Region


End Class