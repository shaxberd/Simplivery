Public Class Settings

    Public Property ImagingEngine As ImagingEngines

    Public Enum ImagingEngines As Integer
        SystemDrawing = 0
        ImageMagick = 1
    End Enum

End Class
