Public Class FontManager

    Public Property InstalledFonts As String()


    Public Sub New()
        Using tmpFc As New Drawing.Text.InstalledFontCollection
            InstalledFonts = (From tmpF In tmpFc.Families Select tmpF.Name).ToArray
        End Using
    End Sub

    Public Function GetFont(ByVal fontName As String, ByVal fontSize As Integer, ByVal isBold As Boolean, ByVal isItalic As Boolean) As Font
        If isBold AndAlso isItalic Then
            Return New Font(fontName, fontSize, (FontStyle.Bold Or FontStyle.Italic), GraphicsUnit.Pixel)
        ElseIf isBold Then
            Return New Font(fontName, fontSize, FontStyle.Bold, GraphicsUnit.Pixel)
        ElseIf isItalic Then
            Return New Font(fontName, fontSize, FontStyle.Italic, GraphicsUnit.Pixel)
        Else
            Return New Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel)
        End If
    End Function

End Class
