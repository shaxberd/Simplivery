Public Class PresetElement

    Public Property Guid As Guid
    Public Property ElementType As ElementType
    Public Property Content As String
    Public Property Area As Area


    Public Sub New()
        Me.Guid = Guid.NewGuid
    End Sub
End Class
