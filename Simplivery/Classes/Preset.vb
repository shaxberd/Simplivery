Public Class Preset

    Public Property Guid As Guid
    Public Property TemplateGuid As Guid
    Public Property Layers As List(Of PresetLayer)
    Public Property Elements As List(Of PresetElement)

    Public Sub New()
        Me.Guid = Guid.NewGuid
    End Sub
End Class
