Imports System.Drawing
Imports System.IO

Public Class frmMain

#Region "Fields"

    Private _templatePath As String
    Private _allTemplates As List(Of Template)
    Private _availableTemplates As Dictionary(Of Guid, String)
    Private _availablePresets As Dictionary(Of Guid, String)
    Private _currentTemplate As Template
    Private _currentSet As Preset
    Private _noFont As Font
    Friend _nameFont As Font

#End Region

#Region "Constructor"

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        'Initializing
        _templatePath = Path.Combine(Environment.CurrentDirectory, "Templates")
        _allTemplates = New List(Of Template)
        _availableTemplates = New Dictionary(Of Guid, String)
        _availablePresets = New Dictionary(Of Guid, String)
        _noFont = New Font("Impact", 40)
        _nameFont = New Font("Arial", 16)
        txtNoFont.Text = _noFont.Name
        txtNameFont.Text = _nameFont.Name

        'Loading
        LoadTemplates()
    End Sub

#End Region

#Region "GUI - General"

    Private Sub btnBaseColor_Click(sender As Object, e As EventArgs) Handles btnBaseColor.Click
        'choose new text color
        pnlBaseColor.BackColor = ChooseColor(pnlBaseColor.BackColor)
    End Sub

    Private Sub btnAccentColor_Click(sender As Object, e As EventArgs) Handles btnAccentColor.Click
        'choose new accent color
        pnlAccentColor.BackColor = ChooseColor(pnlAccentColor.BackColor)
    End Sub

    Private Sub btnThirdColor_Click(sender As Object, e As EventArgs) Handles btnThirdColor.Click
        'choose new third color
        pnlThirdColor.BackColor = ChooseColor(pnlThirdColor.BackColor)
    End Sub

    Private Sub btnNoFont_Click(sender As Object, e As EventArgs) Handles btnNoFont.Click
        'choose new number font
        _noFont = ChooseFont(_noFont)
        txtNoFont.Text = _noFont.Name
    End Sub

    Private Sub btnNameFont_Click(sender As Object, e As EventArgs) Handles btnNameFont.Click
        'choose new text font
        _nameFont = ChooseFont(_nameFont)
        txtNameFont.Text = _nameFont.Name
    End Sub

    Private Sub btnLiveryBasicsPreview_Click(sender As Object, e As EventArgs) Handles btnLiveryBasicsPreview.Click
        'Update basic settings' preview
        If Not String.IsNullOrWhiteSpace(txtDriverName.Text) Then
            UpdateBasicPreview()
        Else
            MessageBox.Show("Please provide a driver name.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmbCarSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCarSelection.SelectedIndexChanged
        'get the selected template's GUID (two ways needed as SelectedValue returns an array when cmbBox is first created/filled)
        Dim tmpGuid As Guid
        If Guid.TryParseExact(cmbCarSelection.ComboBox.SelectedValue.ToString, "D", tmpGuid) Then
            SelectTemplate(tmpGuid)
        Else
            SelectTemplate(DirectCast(cmbCarSelection.ComboBox.SelectedValue, KeyValuePair(Of Guid, String)).Key)
        End If
    End Sub

    Private Sub cmbPresetCollection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPresetCollection.SelectedIndexChanged
        'get the selected preset's GUID (two ways needed as SelectedValue returns an array when cmbBox is first created/filled)
        Dim tmpGuid As Guid
        If Guid.TryParseExact(cmbPresetCollection.ComboBox.SelectedValue.ToString, "D", tmpGuid) Then
            SelectPreset(tmpGuid)
        Else
            SelectPreset(DirectCast(cmbPresetCollection.ComboBox.SelectedValue, KeyValuePair(Of Guid, String)).Key)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        LoadTemplateDefault()
    End Sub

    Private Sub lviChassisLayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lviChassisLayers.SelectedIndexChanged
        'disable edit button if layer is not colordecal
        If lviChassisLayers.SelectedItems.Count = 1 Then
            If {LayerType.ColorDecal, LayerType.Base}.Contains(_currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = Guid.ParseExact(lviChassisLayers.SelectedItems(0).Text, "D")).Type) Then
                btnChassisEditLayer.Enabled = True
            Else
                btnChassisEditLayer.Enabled = False
            End If
        End If
    End Sub

#End Region

#Region "GUI - Adding, Editing & Moving Stuff"

    Private Sub btnChassisAddDecal_Click(sender As Object, e As EventArgs) Handles btnChassisAddDecal.Click
        OpenLayerAddDialog(LayerType.Decal)
    End Sub

    Private Sub btnChassisAddColorableDecal_Click(sender As Object, e As EventArgs) Handles btnChassisAddColorableDecal.Click
        OpenLayerAddDialog(LayerType.ColorDecal)
    End Sub

    Private Sub btnChassisAddDetail_Click(sender As Object, e As EventArgs) Handles btnChassisAddDetail.Click
        OpenLayerAddDialog(LayerType.Detail)
    End Sub

    Private Sub btnChassisAddNumberplate_Click(sender As Object, e As EventArgs) Handles btnChassisAddNumberplate.Click
        OpenLayerAddDialog(LayerType.Numberplate)
    End Sub

    Private Sub btnChassisAddParts_Click(sender As Object, e As EventArgs) Handles btnChassisAddParts.Click
        OpenLayerAddDialog(LayerType.Parts)
    End Sub

    Private Sub btnChassisAddShading_Click(sender As Object, e As EventArgs) Handles btnChassisAddShading.Click
        OpenLayerAddDialog(LayerType.Shading)
    End Sub

    Private Sub btnChassisAddFreeText_Click(sender As Object, e As EventArgs) Handles btnChassisAddFreeText.Click
        OpenElementDialog(ElementType.Text, Guid.Empty)
    End Sub

    Private Sub btnChassisAddSponsor_Click(sender As Object, e As EventArgs) Handles btnChassisAddSponsor.Click
        OpenElementDialog(ElementType.Sponsor, Guid.Empty)
    End Sub

    Private Sub btnChassisLayerUp_Click(sender As Object, e As EventArgs) Handles btnChassisLayerUp.Click
        MoveLayer(False)
    End Sub

    Private Sub btnChassisLayerDown_Click(sender As Object, e As EventArgs) Handles btnChassisLayerDown.Click
        MoveLayer(True)
    End Sub

    Private Sub btnChassisElementUp_Click(sender As Object, e As EventArgs) Handles btnChassisElementUp.Click
        MoveElement(False)
    End Sub

    Private Sub btnChassisElementDown_Click(sender As Object, e As EventArgs) Handles btnChassisElementDown.Click
        MoveElement(True)
    End Sub

    Private Sub btnChassisEditLayer_Click(sender As Object, e As EventArgs) Handles btnChassisEditLayer.Click
        OpenLayerEditDialog()
    End Sub

    Private Sub btnChassisRemoveLayer_Click(sender As Object, e As EventArgs) Handles btnChassisRemoveLayer.Click
        RemoveLayer()
    End Sub

    Private Sub btnChassisEditElement_Click(sender As Object, e As EventArgs) Handles btnChassisEditElement.Click
        If lviChassisElements.SelectedItems.Count = 1 Then
            OpenElementDialog(_currentSet.Elements.FirstOrDefault(Function(x) x.Guid = Guid.ParseExact(lviChassisElements.SelectedItems(0).Text, "D")).ElementType, Guid.ParseExact(lviChassisElements.SelectedItems(0).Text, "D"))
        End If
    End Sub

    Private Sub btnChassisRemoveElement_Click(sender As Object, e As EventArgs) Handles btnChassisRemoveElement.Click
        RemoveElement()
    End Sub

#End Region

#Region "Methods - General"

#End Region

#Region "Methods - Dialogs"

    Private Function ChooseColor(ByVal currentColor As Color) As Color
        'Multi-Use colorchooser
        Using cld As New ColorDialog
            cld.Color = currentColor
            If cld.ShowDialog = Windows.Forms.DialogResult.OK Then
                Return cld.Color
            Else
                Return currentColor
            End If
        End Using
    End Function

    Private Function ChooseFont(ByVal currentFont As Font) As Font
        'Multi-Use colorchooser
        Using fd As New FontDialog
            fd.Font = currentFont
            If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Return fd.Font
            Else
                Return currentFont
            End If
        End Using
    End Function



#End Region

#Region "Methods - Imaging"

    Private Sub UpdateBasicPreview()
        'Initialize
        Dim basicsPreview As New Bitmap(370, 141)
        Dim bpGfx As Graphics = Graphics.FromImage(basicsPreview)
        Dim baseBrush As New SolidBrush(pnlBaseColor.BackColor)
        Dim accentBrush As New SolidBrush(pnlAccentColor.BackColor)
        Dim textBrush As New SolidBrush(pnlThirdColor.BackColor)
        Dim nameFont As Font = _nameFont
        Dim noFont As Font = _noFont

        'Ensure centered text (Number)
        Dim noFormat As New StringFormat()
        noFormat.LineAlignment = StringAlignment.Center
        noFormat.Alignment = StringAlignment.Center
        'Enable Antialiasing
        bpGfx.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        'Fill with base color
        bpGfx.FillRegion(baseBrush, New Region(New Rectangle(0, 0, 370, 141)))
        'Lines (accent color)
        bpGfx.DrawLine(New Pen(accentBrush, 25), 0, 70, 370, 70)
        bpGfx.DrawLine(New Pen(accentBrush, 25), 0, 105, 370, 105)
        'Numberplate (black/white)
        bpGfx.FillRectangle(Brushes.White, New Rectangle(30, 52, 70, 70))
        bpGfx.DrawRectangle(New Pen(Brushes.Black, 2), New Rectangle(30, 52, 70, 70))
        'Number image (black)
        bpGfx.DrawString(nudDriverNo.Value.ToString, noFont, Brushes.Black, New Rectangle(20, 52, 90, 70), noFormat)
        'Name (text color)
        bpGfx.DrawString(txtDriverName.Text, nameFont, textBrush, New Rectangle(30, 10, 300, 30))

        'Cleanup
        bpGfx.Dispose()

        'Set image
        picLiveryBasicsPreview.Image = basicsPreview
    End Sub

#End Region

#Region "Methods - Loading, Selecting & Updating Lists"

    Private Sub LoadTemplates()
        'initialize
        Dim xmlDeser As New Xml.Serialization.XmlSerializer((New Template).GetType)
        Dim xmlStream As FileStream
        Dim tmpTemplate As Template
        Dim tmpDirName As String
        _allTemplates.Clear()
        _availableTemplates.Clear()

        Try
            'iterate possible template directories
            For Each tmpDir In Directory.EnumerateDirectories(_templatePath)
                'check whether the current directory name is a guid
                tmpDirName = tmpDir.Split(CChar("\")).Last()
                If Guid.TryParseExact(tmpDirName, "D", New Guid) Then
                    Try
                        'deserialize template
                        xmlStream = New FileStream(Path.Combine(tmpDir, "template.xml"), FileMode.Open, FileAccess.Read)
                        tmpTemplate = CType(xmlDeser.Deserialize(xmlStream), Template)
                        xmlStream.Close()
                        xmlStream.Dispose()
                    Catch ex As Exception
                        MessageBox.Show(String.Format("Error deserializing template {0}: {2}", tmpDirName, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Continue For
                    End Try

                    'add template to available templates if error-free
                    If tmpTemplate.Check(_templatePath) OrElse _
                        MessageBox.Show(String.Format("The template {0} by {1} contained erroneous layers and/or presets. Do you want to continue loading the template without those?", tmpTemplate.CarName, tmpTemplate.AuthorName), _
                                        "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                        _allTemplates.Add(tmpTemplate)
                        _availableTemplates.Add(tmpTemplate.Guid, String.Format("{0} ({1})", tmpTemplate.CarName, tmpTemplate.AuthorName))
                    End If

                    're-bind template dictionary to combobox
                    cmbCarSelection.ComboBox.DataSource = New BindingSource(_availableTemplates, Nothing)
                    cmbCarSelection.ComboBox.DisplayMember = "Value"
                    cmbCarSelection.ComboBox.ValueMember = "Key"
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(String.Format("Error loading templates: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub SelectTemplate(ByVal templateGuid As Guid)
        Try
            'find template in list of available templates
            Dim tmpLoadTemplate As Template = _allTemplates.FirstOrDefault(Function(x) x.Guid = templateGuid)
            If tmpLoadTemplate IsNot Nothing Then
                'load template
                _currentTemplate = tmpLoadTemplate

                'clear current presets
                _availablePresets.Clear()

                If _currentTemplate.Presets.Count > 0 Then
                    'load presets
                    For Each tmpPreset In _currentTemplate.Presets
                        _availablePresets.Add(tmpPreset.Guid, tmpPreset.Name)
                    Next
                Else
                    cmbPresetCollection.Enabled = False
                End If

                cmbPresetCollection.ComboBox.DataSource = New BindingSource(_availablePresets, Nothing)
                cmbPresetCollection.ComboBox.DisplayMember = "Value"
                cmbPresetCollection.ComboBox.ValueMember = "Key"
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error loading template: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub LoadTemplateDefault()
        Dim defPreset As Preset = _currentTemplate.Presets.FirstOrDefault(Function(x) x.Guid = _currentTemplate.DefaultPreset)

        If defPreset IsNot Nothing Then
            LoadPreset(defPreset)
        Else
            MessageBox.Show("Error: Default template style could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SelectPreset(ByVal presetGuid As Guid)
        Dim tmpLoadPreset As Preset = _currentTemplate.Presets.FirstOrDefault(Function(x) x.Guid = presetGuid)
        If tmpLoadPreset IsNot Nothing Then
            LoadPreset(tmpLoadPreset)
        End If
    End Sub

    Private Sub LoadPreset(ByVal preset As Preset)
        Try
            'clear
            lviChassisLayers.Items.Clear()
            lviChassisElements.Items.Clear()

            'load layers
            For Each tmpLayer In preset.Layers
                lviChassisLayers.Items.Add(New ListViewItem({_currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = tmpLayer.LayerGuid).Guid.ToString, _
                                            _currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = tmpLayer.LayerGuid).Name}))
            Next

            'load elements
            For Each tmpElement In preset.Elements
                lviChassisElements.Items.Add(New ListViewItem({tmpElement.Guid.ToString, String.Format("{0}: {1}", tmpElement.ElementType.ToString, tmpElement.Content)}))
            Next

            'set preset active
            _currentSet = preset

            'color matching
            For Each tmpLayer In _currentSet.Layers
                If {LayerType.Base, LayerType.ColorDecal}.Contains(_currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = tmpLayer.LayerGuid).Type) Then
                    Select Case tmpLayer.PresetColor
                        Case PresetColorType.Main
                            tmpLayer.Color = pnlBaseColor.BackColor.ToArgb
                        Case PresetColorType.Accent
                            tmpLayer.Color = pnlAccentColor.BackColor.ToArgb
                        Case PresetColorType.Third
                            tmpLayer.Color = pnlThirdColor.BackColor.ToArgb
                    End Select
                    tmpLayer.PresetColor = PresetColorType.CustomPreset
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(String.Format("Error loading preset: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Methods - Adding, Editing & Moving Stuff"

    Private Sub OpenLayerAddDialog(ByVal type As LayerType)
        'opens up the layer chooser for the given type
        Dim lad As New frmLayerAddDialog(_templatePath, type, _currentTemplate, _currentSet.Layers)
        If lad.ShowDialog = Windows.Forms.DialogResult.OK Then
            AddLayer(lad.SelectedLayer, lad.SelectedColor)
        End If
        lad.Dispose()
    End Sub

    Private Sub OpenLayerEditDialog()
        'opens up the layer edit dialog
        If lviChassisLayers.SelectedItems.Count = 1 Then
            Dim led As New frmLayerEditDialog(Guid.ParseExact(lviChassisLayers.SelectedItems(0).Text, "D"), _templatePath, _currentTemplate, _currentSet.Layers)
            If led.ShowDialog = Windows.Forms.DialogResult.OK Then
                UpdateLayer(Guid.ParseExact(lviChassisLayers.SelectedItems(0).Text, "D"), led.SelectedColor)
            End If
            led.Dispose()
        End If
    End Sub

    Private Sub OpenElementDialog(ByVal elementType As ElementType, ByVal elementGuid As Guid)
        'opens up the element add/edit dialog
        Dim ed As New frmElementDialog(elementType, elementGuid, _currentSet.Elements)
        If ed.ShowDialog = Windows.Forms.DialogResult.OK Then
            'add/edit element
            If elementGuid = Guid.Empty Then
                AddElement(ed.Element)
            Else
                UpdateElement(ed.Element)
            End If
        End If
        ed.Dispose()
    End Sub

    Private Sub AddLayer(ByVal layerGuid As Guid, ByVal layerColor As Color)
        'initialise
        Dim insertIndex As Integer
        Dim currentSetTypes As New List(Of LayerType)
        Dim newPresetLayer As New PresetLayer
        Dim tmpLayer As Layer = _currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = layerGuid)

        newPresetLayer.LayerGuid = layerGuid
        newPresetLayer.PresetColor = PresetColorType.NonColorable

        'get current set's layertypes
        For Each tmpPresetLayer In _currentSet.Layers
            currentSetTypes.Add(_currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = tmpPresetLayer.LayerGuid).Type)
        Next

        'determine where to insert the new layer
        insertIndex = currentSetTypes.FindIndex(Function(x) CInt(x) > CInt(tmpLayer.Type))
        If tmpLayer.Type = LayerType.ColorDecal Then
            newPresetLayer.PresetColor = PresetColorType.CustomPreset
            newPresetLayer.Color = layerColor.ToArgb
        End If
        If insertIndex = -1 Then insertIndex = lviChassisLayers.Items.Count

        'add layer to current set
        _currentSet.Layers.Insert(insertIndex, newPresetLayer)

        'reload set (lists, etc)
        LoadPreset(_currentSet)
    End Sub

    Private Sub AddElement(ByVal element As PresetElement)
        'add alement ot current set
        _currentSet.Elements.Add(element)

        'reload set (lists, etc)
        LoadPreset(_currentSet)
    End Sub

    Private Sub UpdateLayer(ByVal layerGuid As Guid, ByVal layerColor As Color)
        'update the edited layer's color, no reload necessary
        _currentSet.Layers.FirstOrDefault(Function(x) x.LayerGuid = layerGuid).Color = layerColor.ToArgb
    End Sub

    Private Sub UpdateElement(ByVal element As PresetElement)
        'update the edited layer's properties
        _currentSet.Elements.FirstOrDefault(Function(x) x.Guid = element.Guid).Content = element.Content
        _currentSet.Elements.FirstOrDefault(Function(x) x.Guid = element.Guid).Area = element.Area

        'reload set (lists, etc)
        LoadPreset(_currentSet)
    End Sub

    Private Sub MoveLayer(ByVal moveDown As Boolean)
        'check whether an item is selected
        If lviChassisLayers.SelectedItems.Count = 1 Then
            'find item in current set & get new index if it's NOT the first/last
            Dim insertIndex As Integer
            If moveDown Then
                insertIndex = _currentSet.Layers.FindIndex(Function(x) x.LayerGuid = Guid.ParseExact(lviChassisLayers.SelectedItems(0).Text, "D")) + 2
                If insertIndex > _currentSet.Layers.Count Then Exit Sub
            Else
                insertIndex = _currentSet.Layers.FindIndex(Function(x) x.LayerGuid = Guid.ParseExact(lviChassisLayers.SelectedItems(0).Text, "D")) - 1
                If insertIndex < 0 Then Exit Sub
            End If

            'insert item at new index & remove at old
            _currentSet.Layers.Insert(insertIndex, _currentSet.Layers.FirstOrDefault(Function(x) x.LayerGuid = Guid.ParseExact(lviChassisLayers.SelectedItems(0).Text, "D")))
            If moveDown Then
                _currentSet.Layers.RemoveAt(insertIndex - 2)
            Else
                _currentSet.Layers.RemoveAt(insertIndex + 2)
            End If

            'reload current set
            LoadPreset(_currentSet)

            'reselect item
            If moveDown Then
                lviChassisLayers.Items(insertIndex - 1).Selected = True
            Else
                lviChassisLayers.Items(insertIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub MoveElement(ByVal moveDown As Boolean)
        'check whether an item is selected
        If lviChassisElements.SelectedItems.Count = 1 Then
            'find item in current set & get new index if it's NOT the first/last
            Dim insertIndex As Integer
            If moveDown Then
                insertIndex = _currentSet.Elements.FindIndex(Function(x) x.Guid = Guid.ParseExact(lviChassisElements.SelectedItems(0).Text, "D")) + 2
                If insertIndex > _currentSet.Elements.Count Then Exit Sub
            Else
                insertIndex = _currentSet.Elements.FindIndex(Function(x) x.Guid = Guid.ParseExact(lviChassisElements.SelectedItems(0).Text, "D")) - 1
                If insertIndex < 0 Then Exit Sub
            End If

            'insert item at new index & remove at old
            _currentSet.Elements.Insert(insertIndex, _currentSet.Elements.FirstOrDefault(Function(x) x.Guid = Guid.ParseExact(lviChassisElements.SelectedItems(0).Text, "D")))
            If moveDown Then
                _currentSet.Elements.RemoveAt(insertIndex - 2)
            Else
                _currentSet.Elements.RemoveAt(insertIndex + 2)
            End If

            'reload current set
            LoadPreset(_currentSet)

            'reselect item
            If moveDown Then
                lviChassisElements.Items(insertIndex - 1).Selected = True
            Else
                lviChassisElements.Items(insertIndex).Selected = True
            End If
        End If
    End Sub

    Private Sub RemoveLayer()
        'check whether an item is selected
        If lviChassisLayers.SelectedItems.Count = 1 Then
            'check whether the selected item is the base layer and warn accordingly
            If Not _currentTemplate.Layers.FirstOrDefault(Function(x) x.Guid = Guid.ParseExact(lviChassisLayers.SelectedItems(0).Text, "D")).Type = LayerType.Base _
                OrElse MessageBox.Show("You are trying to remove the base layer, which is NOT recommended - do you want to continue anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                'remove layer
                _currentSet.Layers.RemoveAll(Function(x) x.LayerGuid = Guid.ParseExact(lviChassisLayers.SelectedItems(0).Text, "D"))

                'reload current set
                LoadPreset(_currentSet)
            End If
        End If
    End Sub

    Private Sub RemoveElement()
        'check whether an item is selected
        If lviChassisElements.SelectedItems.Count = 1 Then
            'remove layer
            _currentSet.Elements.RemoveAll(Function(x) x.Guid = Guid.ParseExact(lviChassisElements.SelectedItems(0).Text, "D"))

            'reload current set
            LoadPreset(_currentSet)
        End If
    End Sub

#End Region


    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        'Dim lad As New frmLayerAddDialog(_templatePath, LayerType.ColorDecal, _currentTemplate, _currentSet.Layers)
        'If lad.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    MessageBox.Show(lad.SelectedColor.ToArgb.ToString)
        '    MessageBox.Show(lad.SelectedLayer.ToString)
        'End If
        'lad.Dispose()



        'Dim xmlDeser As New Xml.Serialization.XmlSerializer((New Template).GetType)
        'Dim xmlStream As FileStream
        'Dim tmpTemplate As Template
        'Dim ofd As New OpenFileDialog
        'ofd.InitialDirectory = Environment.CurrentDirectory
        'If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    xmlStream = New FileStream(ofd.FileName, FileMode.Open, FileAccess.Read)
        '    tmpTemplate = CType(xmlDeser.Deserialize(xmlStream), Template)
        '    xmlStream.Close()
        '    xmlStream.Dispose()

        '    Dim tmpPreset As New Preset
        '    tmpPreset.TemplateGuid = tmpTemplate.Guid
        '    tmpPreset.Name = "Default"

        '    Dim tmpPresetLayer As PresetLayer
        '    For Each defLayer In tmpTemplate.Layers.Where(Function(x) x.isDefault)
        '        tmpPresetLayer = New PresetLayer
        '        tmpPresetLayer.LayerGuid = defLayer.Guid
        '        If defLayer.Type = LayerType.Base Then
        '            tmpPresetLayer.PresetColor = PresetColorType.Main
        '            tmpPresetLayer.DefaultColor = Color.White.ToArgb
        '        ElseIf defLayer.Type = LayerType.ColorDecal Then
        '            tmpPresetLayer.PresetColor = PresetColorType.Accent
        '            tmpPresetLayer.DefaultColor = Color.Black.ToArgb
        '        Else
        '            tmpPresetLayer.PresetColor = PresetColorType.NonColorable
        '        End If
        '        tmpPreset.Layers.Add(tmpPresetLayer)
        '    Next

        '    tmpTemplate.Presets.Add(tmpPreset)
        '    tmpTemplate.DefaultPreset = tmpPreset.Guid

        '    xmlDeser = New Xml.Serialization.XmlSerializer(tmpTemplate.GetType)
        '    xmlStream = New FileStream("D:\testTemplate.xml", FileMode.OpenOrCreate, FileAccess.Write)
        '    xmlDeser.Serialize(xmlStream, tmpTemplate)
        '    xmlStream.Close()
        '    xmlStream.Dispose()
        'End If


        'LoadTemplateDefault()



        'MsgBox(cmbCarSelection.ComboBox.SelectedValue.ToString)



        'LoadTemplates()



        'My.Computer.Clipboard.SetText(Guid.NewGuid.ToString)



        'Dim tmpTemplate As New Template
        'tmpTemplate.CarName = "BMW Mini Cooper"
        'tmpTemplate.AuthorName = "Björn Golda"
        'tmpTemplate.Description = "A basic template for BMW's Mini Cooper."
        'tmpTemplate.Layers = New List(Of Layer)
        'tmpTemplate.Presets = New List(Of Preset)
        'tmpTemplate.LiveryScope = LiveryScope.Chassis

        'Dim tmpLayer As Layer
        'For i = 0 To 10
        '    tmpLayer = New Layer
        '    tmpLayer.Type = LayerType.Base
        '    tmpLayer.FileName = "file.png"
        '    tmpLayer.Description = "layerInfo"
        '    tmpLayer.isDefault = False
        '    tmpLayer.Name = "layerName"

        '    If i = 6 Then
        '        Dim tmpArea As New Area(20, 40, 30, 50)
        '        tmpArea.AreaRotation = 90
        '        tmpArea.AreaPadding = {5, 5, 5, 5}

        '        tmpLayer.Areas = New List(Of Area)
        '        tmpLayer.Areas.Add(tmpArea)
        '    End If

        '    tmpTemplate.Layers.Add(tmpLayer)
        'Next

        'Dim xmlSer As New Xml.Serialization.XmlSerializer(tmpTemplate.GetType)
        'Dim xmlStream As New FileStream("D:\testTemplate.xml", FileMode.OpenOrCreate, FileAccess.Write)
        'xmlSer.Serialize(xmlStream, tmpTemplate)
        'xmlStream.Close()
        'xmlStream.Dispose()
    End Sub

End Class
