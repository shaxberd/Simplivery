Public Class Layer

    Public Property Guid As Guid
    Public Property Type As LayerType
    Public Property Name As String
    Public Property FileName As String
    Public Property Description As String
    Public Property Areas As List(Of Area)

    Public Sub New()
        Me.Guid = Guid.NewGuid
        Areas = New List(Of Area)
    End Sub
End Class
