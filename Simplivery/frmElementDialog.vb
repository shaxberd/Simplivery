Public Class frmElementDialog

    Private _newElement As Boolean
    Private _elementType As ElementType
    Private _fontConverter As FontConverter
    Private _elementFont As Font

    Friend Element As PresetElement

#Region "Constructor"

    Public Sub New(ByVal elementType As ElementType, ByVal elementGuid As Guid, ByVal currentElements As List(Of PresetElement))

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        'initialise
        _fontConverter = New FontConverter
        _elementType = elementType
        Me.Text = String.Format("{0} {1}", Me.Text, elementType.ToString)

        'load element (if edit)
        If Not elementGuid = Guid.Empty Then
            Element = currentElements.FirstOrDefault(Function(x) x.Guid = elementGuid)
            _elementFont = TryCast(_fontConverter.ConvertFromString(Element.Settings), Font)

            'load settings
            Select Case elementType
                Case Simplivery.ElementType.Sponsor
                    txtElementImage.Text = Element.Content
                Case Simplivery.ElementType.Text
                    txtElementText.Text = Element.Content
                    txtElementTextFont.Text = _elementFont.Name
                    pnlElementTextColor.BackColor = Color.FromArgb(Element.Color)
            End Select

            nudElementPositionX.Value = Element.Area.AreaX
            nudElementPositionY.Value = Element.Area.AreaY
            nudElementWidth.Value = Element.Area.AreaWidth
            nudElementHeight.Value = Element.Area.AreaHeight
            nudElementRotation.Value = Element.Area.AreaRotation
            nudElementPaddingTop.Value = Element.Area.AreaPadding(0)
            nudElementPaddingBottom.Value = Element.Area.AreaPadding(1)
        Else
            'new element
            _newElement = True
            _elementFont = frmMain._nameFont
            txtElementTextFont.Text = _elementFont.Name
            Element = New PresetElement
            Element.ElementType = elementType
            Element.Color = frmMain.pnlThirdColor.BackColor.ToArgb
            btnApply.Text = "Add"
        End If

        Select Case elementType
            Case Simplivery.ElementType.Sponsor
                tbcElementSettings.TabPages.RemoveAt(1)
            Case Simplivery.ElementType.Text
                tbcElementSettings.TabPages.RemoveAt(2)
        End Select
    End Sub

#End Region

#Region "GUI - Values"

    Private Sub tbrElementPositionX_Scroll(sender As Object, e As EventArgs) Handles tbrElementPositionX.Scroll
        nudElementPositionX.Value = tbrElementPositionX.Value
    End Sub

    Private Sub nudElementPositionX_ValueChanged(sender As Object, e As EventArgs) Handles nudElementPositionX.ValueChanged
        tbrElementPositionX.Value = CInt(nudElementPositionX.Value)
    End Sub

    Private Sub tbrElementPositionY_Scroll(sender As Object, e As EventArgs) Handles tbrElementPositionY.Scroll
        nudElementPositionY.Value = tbrElementPositionY.Value
    End Sub

    Private Sub nudElementPositionY_ValueChanged(sender As Object, e As EventArgs) Handles nudElementPositionY.ValueChanged
        tbrElementPositionY.Value = CInt(nudElementPositionY.Value)
    End Sub

    Private Sub tbrElementRotation_Scroll(sender As Object, e As EventArgs) Handles tbrElementRotation.Scroll
        nudElementRotation.Value = tbrElementRotation.Value
    End Sub

    Private Sub nudElementRotation_ValueChanged(sender As Object, e As EventArgs) Handles nudElementRotation.ValueChanged
        tbrElementRotation.Value = CInt(nudElementRotation.Value)
    End Sub

    Private Sub tbrElementWidth_Scroll(sender As Object, e As EventArgs) Handles tbrElementWidth.Scroll
        nudElementWidth.Value = tbrElementWidth.Value
    End Sub

    Private Sub nudElementWidth_ValueChanged(sender As Object, e As EventArgs) Handles nudElementWidth.ValueChanged
        tbrElementWidth.Value = CInt(nudElementWidth.Value)
    End Sub

    Private Sub tbrElementHeight_Scroll(sender As Object, e As EventArgs) Handles tbrElementHeight.Scroll
        nudElementHeight.Value = tbrElementHeight.Value
    End Sub

    Private Sub nudElementHeight_ValueChanged(sender As Object, e As EventArgs) Handles nudElementHeight.ValueChanged
        tbrElementHeight.Value = CInt(nudElementHeight.Value)
    End Sub

#End Region

#Region "GUI - Dialogs"

    Private Sub btnElementTextColor_Click(sender As Object, e As EventArgs) Handles btnElementTextColor.Click
        'choose color
        Using cld As New ColorDialog
            cld.Color = pnlElementTextColor.BackColor
            If cld.ShowDialog = Windows.Forms.DialogResult.OK Then
                pnlElementTextColor.BackColor = cld.Color
            End If
        End Using
    End Sub

    Private Sub btnBrowseElementImage_Click(sender As Object, e As EventArgs) Handles btnBrowseElementImage.Click
        'choose sponsor image file
        Using ofd As New OpenFileDialog
            ofd.Filter = "PNG|*.png"
            ofd.Multiselect = False
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtElementImage.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btnElementTextFont_Click(sender As Object, e As EventArgs) Handles btnElementTextFont.Click
        'choose fonts/load current font
        Dim fd As New FontDialog
        If Not String.IsNullOrWhiteSpace(Element.Settings) Then fd.Font = _elementFont
        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Element.Settings = _fontConverter.ConvertToString(fd.Font)
            _elementFont = fd.Font
            txtElementTextFont.Text = fd.Font.Name
        End If
    End Sub

#End Region

#Region "GUI - Buttons"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        'depending on element type and check data
        Select Case _elementType
            Case ElementType.Sponsor
                If Not IO.File.Exists(txtElementImage.Text) Then
                    MessageBox.Show("Error: No or non-existing image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Element.Content = txtElementImage.Text
            Case ElementType.Text
                If String.IsNullOrWhiteSpace(txtElementText.Text) Then
                    MessageBox.Show("Error: No text given.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Element.Content = txtElementText.Text
        End Select

        'create area
        Element.Area = New Area(tbrElementPositionX.Value, tbrElementPositionY.Value, tbrElementHeight.Value, tbrElementHeight.Value)
        Element.Area.AreaRotation = tbrElementRotation.Value
        Element.Area.AreaPadding = {CInt(nudElementPaddingTop.Value), CInt(nudElementPaddingBottom.Value)}

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

#End Region

End Class