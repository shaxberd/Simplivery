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
    Public Property AutoUpdate As Boolean
    Public Property UseCustomFolder As Boolean
    Public Property CustomFolder As String
    Public Property CreateZip As Boolean

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
        AutoUpdate = False
        UseCustomFolder = False
        CustomFolder = String.Empty
        CreateZip = False
    End Sub
End Class
