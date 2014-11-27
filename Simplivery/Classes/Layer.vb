Public Class Layer

    Public Property Guid As Guid
    Public Property Type As LayerType
    Public Property Name As String
    Public Property FileName As String
    Public Property Description As String
    Public Property isDefault As Boolean
    Public Property Areas As List(Of Area)

    Public Sub New()
        Me.Guid = Guid.NewGuid
    End Sub
End Class
