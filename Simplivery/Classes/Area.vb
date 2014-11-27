Public Class Area

    Public Property AreaX As Integer
    Public Property AreaY As Integer
    Public Property AreaWidth As Integer
    Public Property AreaHeight As Integer
    Public Property AreaRotation As Integer
    Public Property AreaPadding As Integer()

    Public Sub New()
        Me.New(0, 0, 0, 0)
    End Sub

    Public Sub New(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer)
        Me.AreaX = X
        Me.AreaY = Y
        Me.AreaWidth = Width
        Me.AreaHeight = Height
        Me.AreaRotation = 0
    End Sub
End Class
