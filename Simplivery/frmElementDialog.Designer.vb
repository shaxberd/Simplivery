<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElementDialog
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
        Me.lblElementTextColor = New System.Windows.Forms.Label()
        Me.pnlElementTextColor = New System.Windows.Forms.Panel()
        Me.btnElementTextColor = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.tbcElementSettings = New System.Windows.Forms.TabControl()
        Me.tbpElementLocation = New System.Windows.Forms.TabPage()
        Me.tbrElementRotation = New System.Windows.Forms.TrackBar()
        Me.nudElementRotation = New System.Windows.Forms.NumericUpDown()
        Me.tbrElementPositionY = New System.Windows.Forms.TrackBar()
        Me.nudElementPositionY = New System.Windows.Forms.NumericUpDown()
        Me.lblElementHeight = New System.Windows.Forms.Label()
        Me.tbrElementHeight = New System.Windows.Forms.TrackBar()
        Me.nudElementHeight = New System.Windows.Forms.NumericUpDown()
        Me.lblElementWidth = New System.Windows.Forms.Label()
        Me.tbrElementWidth = New System.Windows.Forms.TrackBar()
        Me.nudElementWidth = New System.Windows.Forms.NumericUpDown()
        Me.lblElementRotation = New System.Windows.Forms.Label()
        Me.lblElementPositionY = New System.Windows.Forms.Label()
        Me.lblElementPositionX = New System.Windows.Forms.Label()
        Me.tbrElementPositionX = New System.Windows.Forms.TrackBar()
        Me.nudElementPositionX = New System.Windows.Forms.NumericUpDown()
        Me.tbpElementText = New System.Windows.Forms.TabPage()
        Me.txtElementTextFont = New System.Windows.Forms.TextBox()
        Me.btnElementTextFont = New System.Windows.Forms.Button()
        Me.lblElementTextFont = New System.Windows.Forms.Label()
        Me.lblElementText = New System.Windows.Forms.Label()
        Me.txtElementText = New System.Windows.Forms.TextBox()
        Me.tbpElementImage = New System.Windows.Forms.TabPage()
        Me.btnOnlineElementImage = New System.Windows.Forms.Button()
        Me.btnLibraryElementImage = New System.Windows.Forms.Button()
        Me.btnBrowseElementImage = New System.Windows.Forms.Button()
        Me.lblElementImage = New System.Windows.Forms.Label()
        Me.txtElementImage = New System.Windows.Forms.TextBox()
        Me.picElementPreview = New System.Windows.Forms.PictureBox()
        Me.tbcElementSettings.SuspendLayout()
        Me.tbpElementLocation.SuspendLayout()
        CType(Me.tbrElementRotation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudElementRotation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrElementPositionY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudElementPositionY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrElementHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudElementHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrElementWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudElementWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrElementPositionX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudElementPositionX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpElementText.SuspendLayout()
        Me.tbpElementImage.SuspendLayout()
        CType(Me.picElementPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblElementTextColor
        '
        Me.lblElementTextColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblElementTextColor.AutoSize = True
        Me.lblElementTextColor.Location = New System.Drawing.Point(315, 10)
        Me.lblElementTextColor.Name = "lblElementTextColor"
        Me.lblElementTextColor.Size = New System.Drawing.Size(58, 13)
        Me.lblElementTextColor.TabIndex = 27
        Me.lblElementTextColor.Text = "Text Color:"
        '
        'pnlElementTextColor
        '
        Me.pnlElementTextColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlElementTextColor.BackColor = System.Drawing.Color.White
        Me.pnlElementTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlElementTextColor.Location = New System.Drawing.Point(379, 6)
        Me.pnlElementTextColor.Name = "pnlElementTextColor"
        Me.pnlElementTextColor.Size = New System.Drawing.Size(94, 20)
        Me.pnlElementTextColor.TabIndex = 26
        '
        'btnElementTextColor
        '
        Me.btnElementTextColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnElementTextColor.Location = New System.Drawing.Point(479, 6)
        Me.btnElementTextColor.Name = "btnElementTextColor"
        Me.btnElementTextColor.Size = New System.Drawing.Size(67, 20)
        Me.btnElementTextColor.TabIndex = 25
        Me.btnElementTextColor.Text = "Choose"
        Me.btnElementTextColor.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(366, 416)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(472, 416)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(100, 32)
        Me.btnApply.TabIndex = 22
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'tbcElementSettings
        '
        Me.tbcElementSettings.Controls.Add(Me.tbpElementLocation)
        Me.tbcElementSettings.Controls.Add(Me.tbpElementText)
        Me.tbcElementSettings.Controls.Add(Me.tbpElementImage)
        Me.tbcElementSettings.Location = New System.Drawing.Point(12, 298)
        Me.tbcElementSettings.Name = "tbcElementSettings"
        Me.tbcElementSettings.SelectedIndex = 0
        Me.tbcElementSettings.Size = New System.Drawing.Size(560, 112)
        Me.tbcElementSettings.TabIndex = 30
        '
        'tbpElementLocation
        '
        Me.tbpElementLocation.Controls.Add(Me.tbrElementRotation)
        Me.tbpElementLocation.Controls.Add(Me.nudElementRotation)
        Me.tbpElementLocation.Controls.Add(Me.tbrElementPositionY)
        Me.tbpElementLocation.Controls.Add(Me.nudElementPositionY)
        Me.tbpElementLocation.Controls.Add(Me.lblElementHeight)
        Me.tbpElementLocation.Controls.Add(Me.tbrElementHeight)
        Me.tbpElementLocation.Controls.Add(Me.nudElementHeight)
        Me.tbpElementLocation.Controls.Add(Me.lblElementWidth)
        Me.tbpElementLocation.Controls.Add(Me.tbrElementWidth)
        Me.tbpElementLocation.Controls.Add(Me.nudElementWidth)
        Me.tbpElementLocation.Controls.Add(Me.lblElementRotation)
        Me.tbpElementLocation.Controls.Add(Me.lblElementPositionY)
        Me.tbpElementLocation.Controls.Add(Me.lblElementPositionX)
        Me.tbpElementLocation.Controls.Add(Me.tbrElementPositionX)
        Me.tbpElementLocation.Controls.Add(Me.nudElementPositionX)
        Me.tbpElementLocation.Location = New System.Drawing.Point(4, 22)
        Me.tbpElementLocation.Name = "tbpElementLocation"
        Me.tbpElementLocation.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpElementLocation.Size = New System.Drawing.Size(552, 86)
        Me.tbpElementLocation.TabIndex = 0
        Me.tbpElementLocation.Text = "Location"
        Me.tbpElementLocation.UseVisualStyleBackColor = True
        '
        'tbrElementRotation
        '
        Me.tbrElementRotation.AutoSize = False
        Me.tbrElementRotation.BackColor = System.Drawing.Color.White
        Me.tbrElementRotation.LargeChange = 45
        Me.tbrElementRotation.Location = New System.Drawing.Point(66, 58)
        Me.tbrElementRotation.Maximum = 360
        Me.tbrElementRotation.Name = "tbrElementRotation"
        Me.tbrElementRotation.Size = New System.Drawing.Size(119, 20)
        Me.tbrElementRotation.SmallChange = 15
        Me.tbrElementRotation.TabIndex = 25
        Me.tbrElementRotation.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'nudElementRotation
        '
        Me.nudElementRotation.Location = New System.Drawing.Point(191, 58)
        Me.nudElementRotation.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudElementRotation.Name = "nudElementRotation"
        Me.nudElementRotation.Size = New System.Drawing.Size(60, 20)
        Me.nudElementRotation.TabIndex = 24
        '
        'tbrElementPositionY
        '
        Me.tbrElementPositionY.AutoSize = False
        Me.tbrElementPositionY.BackColor = System.Drawing.Color.White
        Me.tbrElementPositionY.LargeChange = 25
        Me.tbrElementPositionY.Location = New System.Drawing.Point(66, 32)
        Me.tbrElementPositionY.Maximum = 1024
        Me.tbrElementPositionY.Name = "tbrElementPositionY"
        Me.tbrElementPositionY.Size = New System.Drawing.Size(119, 20)
        Me.tbrElementPositionY.SmallChange = 5
        Me.tbrElementPositionY.TabIndex = 23
        Me.tbrElementPositionY.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'nudElementPositionY
        '
        Me.nudElementPositionY.Location = New System.Drawing.Point(191, 32)
        Me.nudElementPositionY.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nudElementPositionY.Name = "nudElementPositionY"
        Me.nudElementPositionY.Size = New System.Drawing.Size(60, 20)
        Me.nudElementPositionY.TabIndex = 22
        '
        'lblElementHeight
        '
        Me.lblElementHeight.AutoSize = True
        Me.lblElementHeight.Location = New System.Drawing.Point(301, 36)
        Me.lblElementHeight.Name = "lblElementHeight"
        Me.lblElementHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblElementHeight.TabIndex = 17
        Me.lblElementHeight.Text = "Height"
        '
        'tbrElementHeight
        '
        Me.tbrElementHeight.AutoSize = False
        Me.tbrElementHeight.BackColor = System.Drawing.Color.White
        Me.tbrElementHeight.LargeChange = 25
        Me.tbrElementHeight.Location = New System.Drawing.Point(361, 32)
        Me.tbrElementHeight.Maximum = 1024
        Me.tbrElementHeight.Name = "tbrElementHeight"
        Me.tbrElementHeight.Size = New System.Drawing.Size(119, 20)
        Me.tbrElementHeight.SmallChange = 5
        Me.tbrElementHeight.TabIndex = 16
        Me.tbrElementHeight.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'nudElementHeight
        '
        Me.nudElementHeight.Location = New System.Drawing.Point(486, 32)
        Me.nudElementHeight.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nudElementHeight.Name = "nudElementHeight"
        Me.nudElementHeight.Size = New System.Drawing.Size(60, 20)
        Me.nudElementHeight.TabIndex = 15
        '
        'lblElementWidth
        '
        Me.lblElementWidth.AutoSize = True
        Me.lblElementWidth.Location = New System.Drawing.Point(301, 10)
        Me.lblElementWidth.Name = "lblElementWidth"
        Me.lblElementWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblElementWidth.TabIndex = 14
        Me.lblElementWidth.Text = "Width"
        '
        'tbrElementWidth
        '
        Me.tbrElementWidth.AutoSize = False
        Me.tbrElementWidth.BackColor = System.Drawing.Color.White
        Me.tbrElementWidth.LargeChange = 25
        Me.tbrElementWidth.Location = New System.Drawing.Point(361, 6)
        Me.tbrElementWidth.Maximum = 2048
        Me.tbrElementWidth.Name = "tbrElementWidth"
        Me.tbrElementWidth.Size = New System.Drawing.Size(119, 20)
        Me.tbrElementWidth.SmallChange = 5
        Me.tbrElementWidth.TabIndex = 13
        Me.tbrElementWidth.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'nudElementWidth
        '
        Me.nudElementWidth.Location = New System.Drawing.Point(486, 6)
        Me.nudElementWidth.Maximum = New Decimal(New Integer() {2048, 0, 0, 0})
        Me.nudElementWidth.Name = "nudElementWidth"
        Me.nudElementWidth.Size = New System.Drawing.Size(60, 20)
        Me.nudElementWidth.TabIndex = 12
        '
        'lblElementRotation
        '
        Me.lblElementRotation.AutoSize = True
        Me.lblElementRotation.Location = New System.Drawing.Point(6, 62)
        Me.lblElementRotation.Name = "lblElementRotation"
        Me.lblElementRotation.Size = New System.Drawing.Size(47, 13)
        Me.lblElementRotation.TabIndex = 11
        Me.lblElementRotation.Text = "Rotation"
        '
        'lblElementPositionY
        '
        Me.lblElementPositionY.AutoSize = True
        Me.lblElementPositionY.Location = New System.Drawing.Point(6, 36)
        Me.lblElementPositionY.Name = "lblElementPositionY"
        Me.lblElementPositionY.Size = New System.Drawing.Size(14, 13)
        Me.lblElementPositionY.TabIndex = 8
        Me.lblElementPositionY.Text = "Y"
        '
        'lblElementPositionX
        '
        Me.lblElementPositionX.AutoSize = True
        Me.lblElementPositionX.Location = New System.Drawing.Point(6, 10)
        Me.lblElementPositionX.Name = "lblElementPositionX"
        Me.lblElementPositionX.Size = New System.Drawing.Size(14, 13)
        Me.lblElementPositionX.TabIndex = 5
        Me.lblElementPositionX.Text = "X"
        '
        'tbrElementPositionX
        '
        Me.tbrElementPositionX.AutoSize = False
        Me.tbrElementPositionX.BackColor = System.Drawing.Color.White
        Me.tbrElementPositionX.LargeChange = 25
        Me.tbrElementPositionX.Location = New System.Drawing.Point(66, 6)
        Me.tbrElementPositionX.Maximum = 2048
        Me.tbrElementPositionX.Name = "tbrElementPositionX"
        Me.tbrElementPositionX.Size = New System.Drawing.Size(119, 20)
        Me.tbrElementPositionX.SmallChange = 5
        Me.tbrElementPositionX.TabIndex = 2
        Me.tbrElementPositionX.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'nudElementPositionX
        '
        Me.nudElementPositionX.Location = New System.Drawing.Point(191, 6)
        Me.nudElementPositionX.Maximum = New Decimal(New Integer() {2048, 0, 0, 0})
        Me.nudElementPositionX.Name = "nudElementPositionX"
        Me.nudElementPositionX.Size = New System.Drawing.Size(60, 20)
        Me.nudElementPositionX.TabIndex = 1
        '
        'tbpElementText
        '
        Me.tbpElementText.Controls.Add(Me.txtElementTextFont)
        Me.tbpElementText.Controls.Add(Me.btnElementTextFont)
        Me.tbpElementText.Controls.Add(Me.lblElementTextFont)
        Me.tbpElementText.Controls.Add(Me.lblElementText)
        Me.tbpElementText.Controls.Add(Me.txtElementText)
        Me.tbpElementText.Controls.Add(Me.btnElementTextColor)
        Me.tbpElementText.Controls.Add(Me.pnlElementTextColor)
        Me.tbpElementText.Controls.Add(Me.lblElementTextColor)
        Me.tbpElementText.Location = New System.Drawing.Point(4, 22)
        Me.tbpElementText.Name = "tbpElementText"
        Me.tbpElementText.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpElementText.Size = New System.Drawing.Size(552, 86)
        Me.tbpElementText.TabIndex = 1
        Me.tbpElementText.Text = "Text"
        Me.tbpElementText.UseVisualStyleBackColor = True
        '
        'txtElementTextFont
        '
        Me.txtElementTextFont.Location = New System.Drawing.Point(379, 32)
        Me.txtElementTextFont.Name = "txtElementTextFont"
        Me.txtElementTextFont.ReadOnly = True
        Me.txtElementTextFont.Size = New System.Drawing.Size(94, 20)
        Me.txtElementTextFont.TabIndex = 33
        '
        'btnElementTextFont
        '
        Me.btnElementTextFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnElementTextFont.Location = New System.Drawing.Point(479, 32)
        Me.btnElementTextFont.Name = "btnElementTextFont"
        Me.btnElementTextFont.Size = New System.Drawing.Size(67, 20)
        Me.btnElementTextFont.TabIndex = 32
        Me.btnElementTextFont.Text = "Choose"
        Me.btnElementTextFont.UseVisualStyleBackColor = True
        '
        'lblElementTextFont
        '
        Me.lblElementTextFont.AutoSize = True
        Me.lblElementTextFont.Location = New System.Drawing.Point(315, 35)
        Me.lblElementTextFont.Name = "lblElementTextFont"
        Me.lblElementTextFont.Size = New System.Drawing.Size(55, 13)
        Me.lblElementTextFont.TabIndex = 31
        Me.lblElementTextFont.Text = "Text Font:"
        '
        'lblElementText
        '
        Me.lblElementText.AutoSize = True
        Me.lblElementText.Location = New System.Drawing.Point(6, 10)
        Me.lblElementText.Name = "lblElementText"
        Me.lblElementText.Size = New System.Drawing.Size(31, 13)
        Me.lblElementText.TabIndex = 29
        Me.lblElementText.Text = "Text:"
        '
        'txtElementText
        '
        Me.txtElementText.Location = New System.Drawing.Point(43, 7)
        Me.txtElementText.Name = "txtElementText"
        Me.txtElementText.Size = New System.Drawing.Size(222, 20)
        Me.txtElementText.TabIndex = 28
        '
        'tbpElementImage
        '
        Me.tbpElementImage.Controls.Add(Me.btnOnlineElementImage)
        Me.tbpElementImage.Controls.Add(Me.btnLibraryElementImage)
        Me.tbpElementImage.Controls.Add(Me.btnBrowseElementImage)
        Me.tbpElementImage.Controls.Add(Me.lblElementImage)
        Me.tbpElementImage.Controls.Add(Me.txtElementImage)
        Me.tbpElementImage.Location = New System.Drawing.Point(4, 22)
        Me.tbpElementImage.Name = "tbpElementImage"
        Me.tbpElementImage.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpElementImage.Size = New System.Drawing.Size(552, 86)
        Me.tbpElementImage.TabIndex = 2
        Me.tbpElementImage.Text = "Image"
        Me.tbpElementImage.UseVisualStyleBackColor = True
        '
        'btnOnlineElementImage
        '
        Me.btnOnlineElementImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOnlineElementImage.Location = New System.Drawing.Point(479, 58)
        Me.btnOnlineElementImage.Name = "btnOnlineElementImage"
        Me.btnOnlineElementImage.Size = New System.Drawing.Size(67, 20)
        Me.btnOnlineElementImage.TabIndex = 35
        Me.btnOnlineElementImage.Text = "Online"
        Me.btnOnlineElementImage.UseVisualStyleBackColor = True
        '
        'btnLibraryElementImage
        '
        Me.btnLibraryElementImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLibraryElementImage.Location = New System.Drawing.Point(479, 32)
        Me.btnLibraryElementImage.Name = "btnLibraryElementImage"
        Me.btnLibraryElementImage.Size = New System.Drawing.Size(67, 20)
        Me.btnLibraryElementImage.TabIndex = 34
        Me.btnLibraryElementImage.Text = "Library"
        Me.btnLibraryElementImage.UseVisualStyleBackColor = True
        Me.btnLibraryElementImage.Visible = False
        '
        'btnBrowseElementImage
        '
        Me.btnBrowseElementImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseElementImage.Location = New System.Drawing.Point(479, 6)
        Me.btnBrowseElementImage.Name = "btnBrowseElementImage"
        Me.btnBrowseElementImage.Size = New System.Drawing.Size(67, 20)
        Me.btnBrowseElementImage.TabIndex = 32
        Me.btnBrowseElementImage.Text = "Open"
        Me.btnBrowseElementImage.UseVisualStyleBackColor = True
        '
        'lblElementImage
        '
        Me.lblElementImage.AutoSize = True
        Me.lblElementImage.Location = New System.Drawing.Point(6, 9)
        Me.lblElementImage.Name = "lblElementImage"
        Me.lblElementImage.Size = New System.Drawing.Size(55, 13)
        Me.lblElementImage.TabIndex = 31
        Me.lblElementImage.Text = "Image file:"
        '
        'txtElementImage
        '
        Me.txtElementImage.Location = New System.Drawing.Point(67, 6)
        Me.txtElementImage.Name = "txtElementImage"
        Me.txtElementImage.Size = New System.Drawing.Size(406, 20)
        Me.txtElementImage.TabIndex = 30
        '
        'picElementPreview
        '
        Me.picElementPreview.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picElementPreview.BackColor = System.Drawing.Color.White
        Me.picElementPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picElementPreview.Location = New System.Drawing.Point(12, 12)
        Me.picElementPreview.Name = "picElementPreview"
        Me.picElementPreview.Size = New System.Drawing.Size(560, 280)
        Me.picElementPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picElementPreview.TabIndex = 29
        Me.picElementPreview.TabStop = False
        '
        'frmElementDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(584, 460)
        Me.Controls.Add(Me.tbcElementSettings)
        Me.Controls.Add(Me.picElementPreview)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 499)
        Me.Name = "frmElementDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New element:"
        Me.tbcElementSettings.ResumeLayout(False)
        Me.tbpElementLocation.ResumeLayout(False)
        Me.tbpElementLocation.PerformLayout()
        CType(Me.tbrElementRotation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudElementRotation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrElementPositionY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudElementPositionY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrElementHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudElementHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrElementWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudElementWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrElementPositionX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudElementPositionX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpElementText.ResumeLayout(False)
        Me.tbpElementText.PerformLayout()
        Me.tbpElementImage.ResumeLayout(False)
        Me.tbpElementImage.PerformLayout()
        CType(Me.picElementPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picElementPreview As System.Windows.Forms.PictureBox
    Friend WithEvents lblElementTextColor As System.Windows.Forms.Label
    Friend WithEvents pnlElementTextColor As System.Windows.Forms.Panel
    Friend WithEvents btnElementTextColor As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents tbcElementSettings As System.Windows.Forms.TabControl
    Friend WithEvents tbpElementLocation As System.Windows.Forms.TabPage
    Friend WithEvents tbpElementText As System.Windows.Forms.TabPage
    Friend WithEvents lblElementText As System.Windows.Forms.Label
    Friend WithEvents txtElementText As System.Windows.Forms.TextBox
    Friend WithEvents tbpElementImage As System.Windows.Forms.TabPage
    Friend WithEvents lblElementTextFont As System.Windows.Forms.Label
    Friend WithEvents btnBrowseElementImage As System.Windows.Forms.Button
    Friend WithEvents lblElementImage As System.Windows.Forms.Label
    Friend WithEvents txtElementImage As System.Windows.Forms.TextBox
    Friend WithEvents btnLibraryElementImage As System.Windows.Forms.Button
    Friend WithEvents nudElementPositionX As System.Windows.Forms.NumericUpDown
    Friend WithEvents tbrElementPositionX As System.Windows.Forms.TrackBar
    Friend WithEvents lblElementHeight As System.Windows.Forms.Label
    Friend WithEvents tbrElementHeight As System.Windows.Forms.TrackBar
    Friend WithEvents nudElementHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblElementWidth As System.Windows.Forms.Label
    Friend WithEvents tbrElementWidth As System.Windows.Forms.TrackBar
    Friend WithEvents nudElementWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblElementRotation As System.Windows.Forms.Label
    Friend WithEvents lblElementPositionY As System.Windows.Forms.Label
    Friend WithEvents lblElementPositionX As System.Windows.Forms.Label
    Friend WithEvents tbrElementRotation As System.Windows.Forms.TrackBar
    Friend WithEvents nudElementRotation As System.Windows.Forms.NumericUpDown
    Friend WithEvents tbrElementPositionY As System.Windows.Forms.TrackBar
    Friend WithEvents nudElementPositionY As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnElementTextFont As System.Windows.Forms.Button
    Friend WithEvents txtElementTextFont As System.Windows.Forms.TextBox
    Friend WithEvents btnOnlineElementImage As System.Windows.Forms.Button
End Class
