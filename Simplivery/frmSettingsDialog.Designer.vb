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
        Me.chkSaveDriverSettings = New System.Windows.Forms.CheckBox()
        Me.chkSaveFontSettings = New System.Windows.Forms.CheckBox()
        Me.chkSaveColorSettings = New System.Windows.Forms.CheckBox()
        Me.grpSaveSettings.SuspendLayout()
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
        Me.grpSaveSettings.Size = New System.Drawing.Size(189, 198)
        Me.grpSaveSettings.TabIndex = 17
        Me.grpSaveSettings.TabStop = False
        Me.grpSaveSettings.Text = "Saving"
        '
        'chkSaveDriverSettings
        '
        Me.chkSaveDriverSettings.AutoSize = True
        Me.chkSaveDriverSettings.Location = New System.Drawing.Point(6, 19)
        Me.chkSaveDriverSettings.Name = "chkSaveDriverSettings"
        Me.chkSaveDriverSettings.Size = New System.Drawing.Size(123, 17)
        Me.chkSaveDriverSettings.TabIndex = 0
        Me.chkSaveDriverSettings.Text = "Save Driver Settings"
        Me.chkSaveDriverSettings.UseVisualStyleBackColor = True
        '
        'chkSaveFontSettings
        '
        Me.chkSaveFontSettings.AutoSize = True
        Me.chkSaveFontSettings.Location = New System.Drawing.Point(6, 42)
        Me.chkSaveFontSettings.Name = "chkSaveFontSettings"
        Me.chkSaveFontSettings.Size = New System.Drawing.Size(116, 17)
        Me.chkSaveFontSettings.TabIndex = 1
        Me.chkSaveFontSettings.Text = "Save Font Settings"
        Me.chkSaveFontSettings.UseVisualStyleBackColor = True
        '
        'chkSaveColorSettings
        '
        Me.chkSaveColorSettings.AutoSize = True
        Me.chkSaveColorSettings.Location = New System.Drawing.Point(6, 65)
        Me.chkSaveColorSettings.Name = "chkSaveColorSettings"
        Me.chkSaveColorSettings.Size = New System.Drawing.Size(119, 17)
        Me.chkSaveColorSettings.TabIndex = 2
        Me.chkSaveColorSettings.Text = "Save Color Settings"
        Me.chkSaveColorSettings.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.grpSaveSettings)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 300)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.grpSaveSettings.ResumeLayout(False)
        Me.grpSaveSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents grpSaveSettings As System.Windows.Forms.GroupBox
    Friend WithEvents chkSaveColorSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaveFontSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaveDriverSettings As System.Windows.Forms.CheckBox
End Class
