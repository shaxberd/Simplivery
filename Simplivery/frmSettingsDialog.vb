Public Class frmSettingsDialog

#Region "Fields"

    Friend Settings As Settings

#End Region

#Region "Constructor"

    Public Sub New(ByVal currentSettings As Settings)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Settings = currentSettings
        chkSaveDriverSettings.Checked = currentSettings.SaveDriverInfo
        chkSaveFontSettings.Checked = currentSettings.SaveFontInfo
        chkSaveColorSettings.Checked = currentSettings.SaveColorInfo
        chkAutoUpdate.Checked = currentSettings.AutoUpdate
        radUseCustomFolder.Checked = currentSettings.UseCustomFolder
        radUseCustomSkinFolder.Checked = Not radUseCustomFolder.Checked
        txtCustomFolder.Text = currentSettings.CustomFolder
        chkCreateZip.Checked = currentSettings.CreateZip
    End Sub

#End Region

#Region "Buttons"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If radUseCustomFolder.Checked AndAlso (String.IsNullOrWhiteSpace(txtCustomFolder.Text) OrElse Not IO.Directory.Exists(txtCustomFolder.Text)) Then
            MessageBox.Show("Please provide a custom folder for saving skins or select the default option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Settings.SaveDriverInfo = chkSaveDriverSettings.Checked
            Settings.SaveFontInfo = chkSaveFontSettings.Checked
            Settings.SaveColorInfo = chkSaveColorSettings.Checked
            Settings.AutoUpdate = chkAutoUpdate.Checked
            Settings.UseCustomFolder = radUseCustomFolder.Checked
            Settings.CustomFolder = txtCustomFolder.Text
            Settings.CreateZip = chkCreateZip.Checked

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnChooseCustomFolder_Click(sender As Object, e As EventArgs) Handles btnChooseCustomFolder.Click
        Dim fbd As New FolderBrowserDialog
        If Not String.IsNullOrWhiteSpace(txtCustomFolder.Text) Then fbd.SelectedPath = txtCustomFolder.Text
        If fbd.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtCustomFolder.Text = fbd.SelectedPath
        End If
    End Sub

#End Region

End Class