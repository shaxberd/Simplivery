Public Class Settings

    Public Property SaveDriverInfo As Boolean
    Public Property DriverName As String
    Public Property DriverTeam As String
    Public Property DriverNo As Integer
    Public Property SaveFontInfo As Boolean
    Public Property NoFont As String
    Public Property NameFont As String
    Public Property SaveColorInfo As Boolean
    Public Property BaseColor As Integer
    Public Property AccentColor As Integer
    Public Property ThirdColor As Integer

    Public Sub New()
        SaveDriverInfo = False
        DriverName = String.Empty
        DriverTeam = String.Empty
        DriverNo = 0
        SaveFontInfo = False
        NoFont = String.Empty
        NameFont = String.Empty
        SaveColorInfo = False
        BaseColor = 0
        AccentColor = 0
        ThirdColor = 0
    End Sub
End Class
