Imports System.Drawing
Imports System.IO

Public Class frmMain

#Region "Fields"

    Private myFontManager As FontManager
    Private templatePath As String
    Private allTemplates As List(Of Template)
    Private availableTemplates As Dictionary(Of Guid, String)
    Private currentTemplate As Template

#End Region

#Region "Constructor"

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        'Initializing
        myFontManager = New FontManager
        templatePath = Path.Combine(Environment.CurrentDirectory, "Templates")
        allTemplates = New List(Of Template)
        availableTemplates = New Dictionary(Of Guid, String)

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
        cmbNoFont.Items.AddRange(myFontManager.InstalledFonts)
        cmbNameFont.Items.AddRange(myFontManager.InstalledFonts)
    End Sub

    Private Sub btnLiveryBasicsPreview_Click(sender As Object, e As EventArgs) Handles btnLiveryBasicsPreview.Click
        'Update basic settings' preview
        If Not String.IsNullOrWhiteSpace(txtDriverName.Text) Then
            UpdateBasicPreview()
        Else
            MessageBox.Show("Please provide a driver name.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Methods - General Usage"


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
        Dim nameFont As Font = myFontManager.GetFont(cmbNameFont.Text, 25, chkNameFontBold.Checked, chkNameFontItalic.Checked)
        Dim noFont As Font = myFontManager.GetFont(cmbNoFont.Text, 60, chkNoFontBold.Checked, chkNoFontItalic.Checked)

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

#Region "Methods - Template handling"

    Private Sub LoadTemplates()
        'initialize
        Dim xmlDeser As New Xml.Serialization.XmlSerializer((New Template).GetType)
        Dim xmlStream As FileStream
        Dim tmpTemplate As Template
        Dim tmpDirName As String
        allTemplates.Clear()
        availableTemplates.Clear()

        Try
            'iterate possible template directories
            For Each tmpDir In Directory.EnumerateDirectories(templatePath)
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
                    If tmpTemplate.Check(templatePath) OrElse _
                        MessageBox.Show(String.Format("The template {0} by {1} contained erroneous layers and/or presets. Do you want to continue loading the template without those?", tmpTemplate.CarName, tmpTemplate.AuthorName), _
                                        "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                        allTemplates.Add(tmpTemplate)
                        availableTemplates.Add(tmpTemplate.Guid, String.Format("{0} ({1})", tmpTemplate.CarName, tmpTemplate.AuthorName))
                    End If

                    're-bind template dictionary to combobox
                    cmbCarSelection.ComboBox.DataSource = New BindingSource(availableTemplates, Nothing)
                    cmbCarSelection.ComboBox.DisplayMember = "Value"
                    cmbCarSelection.ComboBox.ValueMember = "Key"
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(String.Format("Error loading templates: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub UpdatePresetCollection()

    End Sub

#End Region


    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click




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
