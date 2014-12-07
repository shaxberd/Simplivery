<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsDialog
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.grpSaveSettings = New System.Windows.Forms.GroupBox()
        Me.chkSaveColorSettings = New System.Windows.Forms.CheckBox()
        Me.chkSaveFontSettings = New System.Windows.Forms.CheckBox()
        Me.chkSaveDriverSettings = New System.Windows.Forms.CheckBox()
        Me.grpPreviewSettings = New System.Windows.Forms.GroupBox()
        Me.grpExportSettings = New System.Windows.Forms.GroupBox()
        Me.radUseCustomSkinFolder = New System.Windows.Forms.RadioButton()
        Me.radUseCustomFolder = New System.Windows.Forms.RadioButton()
        Me.txtCustomFolder = New System.Windows.Forms.TextBox()
        Me.btnChooseCustomFolder = New System.Windows.Forms.Button()
        Me.chkCreateZip = New System.Windows.Forms.CheckBox()
        Me.chkAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.grpSaveSettings.SuspendLayout()
        Me.grpPreviewSettings.SuspendLayout()
        Me.grpExportSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(366, 217)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(472, 217)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(100, 32)
        Me.btnApply.TabIndex = 15
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'grpSaveSettings
        '
        Me.grpSaveSettings.Controls.Add(Me.chkSaveColorSettings)
        Me.grpSaveSettings.Controls.Add(Me.chkSaveFontSettings)
        Me.grpSaveSettings.Controls.Add(Me.chkSaveDriverSettings)
        Me.grpSaveSettings.Location = New System.Drawing.Point(13, 13)
        Me.grpSaveSettings.Name = "grpSaveSettings"
        Me.grpSaveSettings.Size = New System.Drawing.Size(182, 198)
        Me.grpSaveSettings.TabIndex = 17
        Me.grpSaveSettings.TabStop = False
        Me.grpSaveSettings.Text = "Settings"
        '
        'chkSaveColorSettings
        '
        Me.chkSaveColorSettings.AutoSize = True
        Me.chkSaveColorSettings.Location = New System.Drawing.Point(6, 66)
        Me.chkSaveColorSettings.Name = "chkSaveColorSettings"
        Me.chkSaveColorSettings.Size = New System.Drawing.Size(119, 17)
        Me.chkSaveColorSettings.TabIndex = 2
        Me.chkSaveColorSettings.Text = "Save Color Settings"
        Me.chkSaveColorSettings.UseVisualStyleBackColor = True
        '
        'chkSaveFontSettings
        '
        Me.chkSaveFontSettings.AutoSize = True
        Me.chkSaveFontSettings.Location = New System.Drawing.Point(6, 43)
        Me.chkSaveFontSettings.Name = "chkSaveFontSettings"
        Me.chkSaveFontSettings.Size = New System.Drawing.Size(116, 17)
        Me.chkSaveFontSettings.TabIndex = 1
        Me.chkSaveFontSettings.Text = "Save Font Settings"
        Me.chkSaveFontSettings.UseVisualStyleBackColor = True
        '
        'chkSaveDriverSettings
        '
        Me.chkSaveDriverSettings.AutoSize = True
        Me.chkSaveDriverSettings.Location = New System.Drawing.Point(6, 20)
        Me.chkSaveDriverSettings.Name = "chkSaveDriverSettings"
        Me.chkSaveDriverSettings.Size = New System.Drawing.Size(123, 17)
        Me.chkSaveDriverSettings.TabIndex = 0
        Me.chkSaveDriverSettings.Text = "Save Driver Settings"
        Me.chkSaveDriverSettings.UseVisualStyleBackColor = True
        '
        'grpPreviewSettings
        '
        Me.grpPreviewSettings.Controls.Add(Me.chkAutoUpdate)
        Me.grpPreviewSettings.Location = New System.Drawing.Point(201, 13)
        Me.grpPreviewSettings.Name = "grpPreviewSettings"
        Me.grpPreviewSettings.Size = New System.Drawing.Size(182, 198)
        Me.grpPreviewSettings.TabIndex = 18
        Me.grpPreviewSettings.TabStop = False
        Me.grpPreviewSettings.Text = "Previews"
        '
        'grpExportSettings
        '
        Me.grpExportSettings.Controls.Add(Me.chkCreateZip)
        Me.grpExportSettings.Controls.Add(Me.btnChooseCustomFolder)
        Me.grpExportSettings.Controls.Add(Me.txtCustomFolder)
        Me.grpExportSettings.Controls.Add(Me.radUseCustomFolder)
        Me.grpExportSettings.Controls.Add(Me.radUseCustomSkinFolder)
        Me.grpExportSettings.Location = New System.Drawing.Point(389, 13)
        Me.grpExportSettings.Name = "grpExportSettings"
        Me.grpExportSettings.Size = New System.Drawing.Size(182, 198)
        Me.grpExportSettings.TabIndex = 19
        Me.grpExportSettings.TabStop = False
        Me.grpExportSettings.Text = "Export"
        '
        'radUseCustomSkinFolder
        '
        Me.radUseCustomSkinFolder.AutoSize = True
        Me.radUseCustomSkinFolder.Location = New System.Drawing.Point(6, 19)
        Me.radUseCustomSkinFolder.Name = "radUseCustomSkinFolder"
        Me.radUseCustomSkinFolder.Size = New System.Drawing.Size(137, 17)
        Me.radUseCustomSkinFolder.TabIndex = 0
        Me.radUseCustomSkinFolder.TabStop = True
        Me.radUseCustomSkinFolder.Text = "Use custom skins folder"
        Me.radUseCustomSkinFolder.UseVisualStyleBackColor = True
        '
        'radUseCustomFolder
        '
        Me.radUseCustomFolder.AutoSize = True
        Me.radUseCustomFolder.Location = New System.Drawing.Point(6, 42)
        Me.radUseCustomFolder.Name = "radUseCustomFolder"
        Me.radUseCustomFolder.Size = New System.Drawing.Size(113, 17)
        Me.radUseCustomFolder.TabIndex = 1
        Me.radUseCustomFolder.TabStop = True
        Me.radUseCustomFolder.Text = "Use custom folder:"
        Me.radUseCustomFolder.UseVisualStyleBackColor = True
        '
        'txtCustomFolder
        '
        Me.txtCustomFolder.Location = New System.Drawing.Point(22, 65)
        Me.txtCustomFolder.Name = "txtCustomFolder"
        Me.txtCustomFolder.Size = New System.Drawing.Size(111, 20)
        Me.txtCustomFolder.TabIndex = 2
        '
        'btnChooseCustomFolder
        '
        Me.btnChooseCustomFolder.Location = New System.Drawing.Point(139, 65)
        Me.btnChooseCustomFolder.Name = "btnChooseCustomFolder"
        Me.btnChooseCustomFolder.Size = New System.Drawing.Size(37, 20)
        Me.btnChooseCustomFolder.TabIndex = 3
        Me.btnChooseCustomFolder.Text = "..."
        Me.btnChooseCustomFolder.UseVisualStyleBackColor = True
        '
        'chkCreateZip
        '
        Me.chkCreateZip.AutoSize = True
        Me.chkCreateZip.Location = New System.Drawing.Point(6, 114)
        Me.chkCreateZip.Name = "chkCreateZip"
        Me.chkCreateZip.Size = New System.Drawing.Size(77, 17)
        Me.chkCreateZip.TabIndex = 5
        Me.chkCreateZip.Text = "Create ZIP"
        Me.chkCreateZip.UseVisualStyleBackColor = True
        '
        'chkAutoUpdate
        '
        Me.chkAutoUpdate.AutoSize = True
        Me.chkAutoUpdate.Location = New System.Drawing.Point(6, 20)
        Me.chkAutoUpdate.Name = "chkAutoUpdate"
        Me.chkAutoUpdate.Size = New System.Drawing.Size(156, 30)
        Me.chkAutoUpdate.TabIndex = 6
        Me.chkAutoUpdate.Text = "Update previews whenever" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "layers or elements change"
        Me.chkAutoUpdate.UseVisualStyleBackColor = True
        '
        'frmSettingsDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.grpExportSettings)
        Me.Controls.Add(Me.grpPreviewSettings)
        Me.Controls.Add(Me.grpSaveSettings)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 300)
        Me.Name = "frmSettingsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.grpSaveSettings.ResumeLayout(False)
        Me.grpSaveSettings.PerformLayout()
        Me.grpPreviewSettings.ResumeLayout(False)
        Me.grpPreviewSettings.PerformLayout()
        Me.grpExportSettings.ResumeLayout(False)
        Me.grpExportSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents grpSaveSettings As System.Windows.Forms.GroupBox
    Friend WithEvents chkSaveColorSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaveFontSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaveDriverSettings As System.Windows.Forms.CheckBox
    Friend WithEvents grpPreviewSettings As System.Windows.Forms.GroupBox
    Friend WithEvents grpExportSettings As System.Windows.Forms.GroupBox
    Friend WithEvents btnChooseCustomFolder As System.Windows.Forms.Button
    Friend WithEvents txtCustomFolder As System.Windows.Forms.TextBox
    Friend WithEvents radUseCustomFolder As System.Windows.Forms.RadioButton
    Friend WithEvents radUseCustomSkinFolder As System.Windows.Forms.RadioButton
    Friend WithEvents chkAutoUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents chkCreateZip As System.Windows.Forms.CheckBox
End Class
