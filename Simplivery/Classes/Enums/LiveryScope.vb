Public Enum LiveryScope

    Chassis = 1
    Windows = 2
    WindowsInt = 4
    ChassisAndWindows = Chassis Or Windows
    ChassisAndWindowsInt = Chassis Or WindowsInt
    Complete = Chassis Or Windows Or WindowsInt

End Enum
