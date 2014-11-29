Imports System.Drawing
Imports System.IO

Public Class frmMain

#Region "Fields"

    Private _myFontManager As FontManager
    Private _templatePath As String
    Private _allTemplates As List(Of Template)
    Private _availableTemplates As Dictionary(Of Guid, String)
    Private _availablePresets As Dictionary(Of Guid, String)
    Private _currentTemplate As Template
    Private _currentSet As Preset

#End Region

#Region "Constructor"

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        'Initializing
        _myFontManager = New FontManager
        _templatePath = Path.Combine(Environment.CurrentDirectory, "Templates")
        _allTemplates = New List(Of Template)
        _availableTemplates = New Dictionary(Of Guid, String)
        _availablePresets = New Dictionary(Of Guid, String)

        'Loading
        LoadFontLists()
        LoadTemplates()

    End Sub

#End Region

#Region "GUI"

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

    Private Sub LoadFontLists()
        'Load list of installed fonts into comboboxes
        cmbNoFont.Items.AddRange(_myFontManager.InstalledFonts)
        cmbNameFont.Items.AddRange(_myFontManager.InstalledFonts)
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

#End Region

#Region "Methods - Imaging"

    Private Sub UpdateBasicPreview()
        'Initialize
        Dim basicsPreview As New Bitmap(370, 141)
        Dim bpGfx As Graphics = Graphics.FromImage(basicsPreview)
        Dim baseBrush As New SolidBrush(pnlBaseColor.BackColor)
        Dim accentBrush As New SolidBrush(pnlAccentColor.BackColor)
        Dim textBrush As New SolidBrush(pnlThirdColor.BackColor)
        Dim nameFont As Font = _myFontManager.GetFont(cmbNameFont.Text, 25, chkNameFontBold.Checked, chkNameFontItalic.Checked)
        Dim noFont As Font = _myFontManager.GetFont(cmbNoFont.Text, 60, chkNoFontBold.Checked, chkNoFontItalic.Checked)

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

#Region "Methods - Loading & Selecting"

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
                lviChassisElements.Items.Add(New ListViewItem({tmpElement.Guid.ToString, tmpElement.ElementType.ToString}))
            Next

            'set preset active
            _currentSet = preset
        Catch ex As Exception
            MessageBox.Show(String.Format("Error loading preset: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Methods - Adding Stuff"



#End Region

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
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
