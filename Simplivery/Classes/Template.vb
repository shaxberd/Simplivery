Public Class Template

    Public Property Guid As Guid
    Public Property CarName As String
    Public Property AuthorName As String
    Public Property Description As String
    Public Property LiveryScope As LiveryScope
    Public Property Layers As List(Of Layer)
    Public Property DefaultPreset As Guid
    Public Property Presets As List(Of Preset)

    Public Sub New()
        Me.Guid = Guid.NewGuid
        Layers = New List(Of Layer)
        Presets = New List(Of Preset)
    End Sub

    Public Function Check(ByVal templatePath As String) As Boolean
        Dim layerCheck As Integer = Layers.Count
        Dim presetCheck As Integer = Presets.Count
        Dim presetLayerCheck As Integer = (From tmpPreset In Presets Select tmpPreset.Layers.Count).Sum

        Layers = Layers.Where(Function(x) IO.File.Exists(IO.Path.Combine(templatePath, Me.Guid.ToString, x.FileName))).ToList
        Presets = Presets.Where(Function(x) x.TemplateGuid = Me.Guid).ToList
        For Each tmpPreset In Presets
            tmpPreset.Layers = tmpPreset.Layers.Where(Function(x) Layers.FirstOrDefault(Function(y) y.Guid = x.LayerGuid) IsNot Nothing).ToList
        Next

        If layerCheck = Layers.Count AndAlso presetCheck = Presets.Count AndAlso _
            presetLayerCheck = (From tmpPreset In Presets Select tmpPreset.Layers.Count).Sum _
            Then Return True Else Return False
    End Function

End Class
