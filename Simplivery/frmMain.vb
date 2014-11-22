Imports System.Drawing

Public Class frmMain

#Region "Fields"

    Private myFontManager As FontManager


#End Region

#Region "Constructor"

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        'Initializing
        myFontManager = New FontManager

        'Loading
        LoadFontLists()

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

    Private Sub btnTextColor_Click(sender As Object, e As EventArgs) Handles btnTextColor.Click
        'choose new text color
        pnlTextColor.BackColor = ChooseColor(pnlTextColor.BackColor)
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

    Private Function ChooseColor(ByVal currentColor As Color)
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
        Dim textBrush As New SolidBrush(pnlTextColor.BackColor)
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


End Class
