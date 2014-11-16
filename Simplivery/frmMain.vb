Imports System.Drawing

Public Class frmMain

#Region "Constructor"

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        LoadFontList()


    End Sub

#End Region
    
#Region "GUI"

    Private Sub btnBaseColor_Click(sender As Object, e As EventArgs) Handles btnBaseColor.Click
        'Colorchooser for base color
        Dim cld As New ColorDialog
        cld.Color = pnlBaseColor.BackColor
        If cld.ShowDialog = Windows.Forms.DialogResult.OK Then
            pnlBaseColor.BackColor = cld.Color
        End If
    End Sub

    Private Sub btnAccentColor_Click(sender As Object, e As EventArgs) Handles btnAccentColor.Click
        'Colorchooser for accent color
        Dim cld As New ColorDialog
        cld.Color = pnlAccentColor.BackColor
        If cld.ShowDialog = Windows.Forms.DialogResult.OK Then
            pnlAccentColor.BackColor = cld.Color
        End If
    End Sub

    Private Sub btnTextColor_Click(sender As Object, e As EventArgs) Handles btnTextColor.Click
        'Colorchooser for text color
        Dim cld As New ColorDialog
        cld.Color = pnlTextColor.BackColor
        If cld.ShowDialog = Windows.Forms.DialogResult.OK Then
            pnlTextColor.BackColor = cld.Color
        End If
    End Sub

    Private Sub LoadFontList()
        'Load list of installed fonts into comboboxes
        Dim tmpFontCollection As New Drawing.Text.InstalledFontCollection
        cmbNoFont.Items.AddRange((From tmp In tmpFontCollection.Families Select tmp.Name).ToArray)
        cmbNameFont.Items.AddRange((From tmp In tmpFontCollection.Families Select tmp.Name).ToArray)
        tmpFontCollection.Dispose()
    End Sub

#End Region

End Class
