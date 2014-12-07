Public Class frmSettingsDialog

    Friend Settings As Settings

    Public Sub New(ByVal currentSettings As Settings)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Settings = currentSettings
        chkSaveDriverSettings.Checked = currentSettings.SaveDriverInfo
        chkSaveFontSettings.Checked = currentSettings.SaveFontInfo
        chkSaveColorSettings.Checked = currentSettings.SaveColorInfo
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Settings.SaveDriverInfo = chkSaveDriverSettings.Checked
        Settings.SaveFontInfo = chkSaveFontSettings.Checked
        Settings.SaveColorInfo = chkSaveColorSettings.Checked

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class