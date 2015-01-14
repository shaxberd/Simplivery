Imports System.IO

Public Class frmElementDialog

#Region "Fields"

    Private _newElement As Boolean
    Private _elementType As ElementType
    Private _fontConverter As FontConverter
    Private _elementFont As Font

    Private _selStart As Point
    Private _selRect As Rectangle
    Private _selBrush As Brush

    Friend Element As PresetElement

#End Region

#Region "Constructor"

    Public Sub New(ByVal elementType As ElementType, ByVal elementGuid As Guid, ByVal currentElements As List(Of PresetElement), ByVal backgroundImage As Image)
        InitializeComponent()

        Try
            'initialise
            Me.Icon = My.Resources.icon
            _fontConverter = New FontConverter
            _elementType = elementType
            Me.Text = String.Format("{0} {1}", Me.Text, elementType.ToString)
            _selBrush = New SolidBrush(Color.FromArgb(150, 32, 74, 135))

            'insert image
            picElementPreview.Image = backgroundImage

            'load element (if edit)
            If Not elementGuid = Guid.Empty Then
                Element = currentElements.FirstOrDefault(Function(x) x.Guid = elementGuid)

                'load settings
                Select Case elementType
                    Case Simplivery.ElementType.Sponsor
                        txtElementImage.Text = Element.Content
                    Case Simplivery.ElementType.Text
                        _elementFont = TryCast(_fontConverter.ConvertFromString(Element.Settings), Font)
                        txtElementText.Text = Element.Content
                        txtElementTextFont.Text = _elementFont.Name
                        pnlElementTextColor.BackColor = Color.FromArgb(Element.Color)
                End Select

                nudElementPositionX.Value = Element.Area.AreaX
                nudElementPositionY.Value = Element.Area.AreaY
                nudElementWidth.Value = Element.Area.AreaWidth
                nudElementHeight.Value = Element.Area.AreaHeight
                nudElementRotation.Value = Element.Area.AreaRotation

                'draw selection
                _selRect = Fullsize2Selection(New Rectangle(Element.Area.AreaX, Element.Area.AreaY, Element.Area.AreaWidth, Element.Area.AreaHeight))
                picElementPreview.Invalidate()
            Else
                'new element
                _newElement = True
                _elementFont = frmMain._nameFont
                txtElementTextFont.Text = _elementFont.Name
                Element = New PresetElement
                Element.ElementType = elementType
                pnlElementTextColor.BackColor = frmMain.pnlThirdColor.BackColor
                Element.Color = pnlElementTextColor.BackColor.ToArgb
                btnApply.Text = "Add"
            End If

            'remove unneeded pages
            Select Case elementType
                Case Simplivery.ElementType.Sponsor
                    tbcElementSettings.TabPages.RemoveAt(1)
                Case Simplivery.ElementType.Text
                    tbcElementSettings.TabPages.RemoveAt(2)
            End Select
        Catch ex As Exception
            MessageBox.Show(String.Format("Error initializing element dialog: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try

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
            Dim tmpPath As String = Path.Combine(Environment.CurrentDirectory, "Images")
            If Directory.Exists(tmpPath) Then ofd.InitialDirectory = tmpPath
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
        'check data
        If nudElementWidth.Value = 0 OrElse nudElementHeight.Value = 0 Then
            MessageBox.Show("Error: No size or invalid size given.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
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

                Element.Color = pnlElementTextColor.BackColor.ToArgb
                Element.Content = txtElementText.Text
        End Select

        'create area
        Element.Area = New Area(tbrElementPositionX.Value, tbrElementPositionY.Value, tbrElementWidth.Value, tbrElementHeight.Value)
        Element.Area.AreaRotation = tbrElementRotation.Value

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnOnlineElementImage_Click(sender As Object, e As EventArgs) Handles btnOnlineElementImage.Click
        Dim oid As New frmOnlineImageDialog(Path.Combine(Environment.CurrentDirectory, "Temp"), Path.Combine(Environment.CurrentDirectory, "Images"))
        If oid.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtElementImage.Text = oid.SelectedPath
        End If
        oid.Dispose()

        'empty temp
        For Each tmpFile In Directory.EnumerateFiles(Path.Combine(Environment.CurrentDirectory, "Temp"))
            Try
                File.Delete(tmpFile)
            Catch ex As Exception
                'don't display errors
            End Try
        Next
    End Sub

#End Region

#Region "Selection"

    Private Sub picElementPreview_MouseDown(sender As Object, e As MouseEventArgs) Handles picElementPreview.MouseDown
        'initialize new selection
        _selRect = New Rectangle
        _selStart = e.Location
        picElementPreview.Invalidate()
    End Sub

    Private Sub picElementPreview_MouseMove(sender As Object, e As MouseEventArgs) Handles picElementPreview.MouseMove
        'evaluate mouse movement
        If e.Button <> MouseButtons.Left Then
            Return
        End If
        Dim tmpSelEnd As Point = e.Location
        _selRect.Location = New Point(Math.Min(_selStart.X, tmpSelEnd.X), Math.Min(_selStart.Y, tmpSelEnd.Y))
        _selRect.Size = New Size(Math.Abs(_selStart.X - tmpSelEnd.X), Math.Abs(_selStart.Y - tmpSelEnd.Y))
        picElementPreview.Invalidate()
    End Sub

    Private Sub picElementPreview_MouseUp(sender As Object, e As MouseEventArgs) Handles picElementPreview.MouseUp
        'translate rectangle
        Dim tmpRect As Rectangle = Selection2Fullsize(_selRect)
        'check rectangle on oversize
        If tmpRect.X + tmpRect.Width > 2048 Then tmpRect.Width = 2048 - tmpRect.X
        If tmpRect.Y + tmpRect.Height > 1024 Then tmpRect.Height = 1024 - tmpRect.Y
        If tmpRect.X < 0 Then
            tmpRect.Width = tmpRect.Width + tmpRect.X
            tmpRect.X = 0
        End If
        If tmpRect.Y < 0 Then
            tmpRect.Height = tmpRect.Height + tmpRect.Y
            tmpRect.Y = 0
        End If
        'apply values
        nudElementPositionX.Value = tmpRect.X
        nudElementPositionY.Value = tmpRect.Y
        nudElementWidth.Value = tmpRect.Width
        nudElementHeight.Value = tmpRect.Height
    End Sub

    Private Sub picElementPreview_Paint(sender As Object, e As PaintEventArgs) Handles picElementPreview.Paint
        'draw rectangle
        If picElementPreview.Image IsNot Nothing Then
            If _selRect.Width > 0 AndAlso _selRect.Height > 0 Then
                e.Graphics.FillRectangle(_selBrush, _selRect)
            End If
        End If
    End Sub

    Private Function Selection2Fullsize(ByVal inRect As Rectangle) As Rectangle
        Dim factor As Double = 2048 / picElementPreview.Width
        inRect.Width = CInt(inRect.Width * factor)
        inRect.Height = CInt(inRect.Height * factor)
        inRect.X = CInt(inRect.X * factor)
        inRect.Y = CInt(inRect.Y * factor)
        Return inRect
    End Function

    Private Function Fullsize2Selection(ByVal inRect As Rectangle) As Rectangle
        Dim factor As Double = picElementPreview.Width / 2048
        inRect.Width = CInt(inRect.Width * factor)
        inRect.Height = CInt(inRect.Height * factor)
        inRect.X = CInt(inRect.X * factor)
        inRect.Y = CInt(inRect.Y * factor)
        Return inRect
    End Function

#End Region


End Class