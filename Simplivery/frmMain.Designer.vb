<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.spcMain = New System.Windows.Forms.SplitContainer()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.picHeader = New System.Windows.Forms.PictureBox()
        Me.tbcLiveryDesign = New System.Windows.Forms.TabControl()
        Me.tbpLiveryBasics = New System.Windows.Forms.TabPage()
        Me.spcLiveryBasics = New System.Windows.Forms.SplitContainer()
        Me.spcLiveryBasicsSettings1 = New System.Windows.Forms.SplitContainer()
        Me.grpBasicDriver = New System.Windows.Forms.GroupBox()
        Me.lblDriverName = New System.Windows.Forms.Label()
        Me.lblDriverNo = New System.Windows.Forms.Label()
        Me.txtDriverName = New System.Windows.Forms.TextBox()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.nudDriverNo = New System.Windows.Forms.NumericUpDown()
        Me.spcLiveryBasicsSettings2 = New System.Windows.Forms.SplitContainer()
        Me.grpBasicFonts = New System.Windows.Forms.GroupBox()
        Me.lblNameFontInfo = New System.Windows.Forms.Label()
        Me.txtNameFont = New System.Windows.Forms.TextBox()
        Me.btnNameFont = New System.Windows.Forms.Button()
        Me.txtNoFont = New System.Windows.Forms.TextBox()
        Me.btnNoFont = New System.Windows.Forms.Button()
        Me.lblNoFont = New System.Windows.Forms.Label()
        Me.lblNameFont = New System.Windows.Forms.Label()
        Me.grpBasicColors = New System.Windows.Forms.GroupBox()
        Me.lblThirdColorInfo = New System.Windows.Forms.Label()
        Me.lblThirdColor = New System.Windows.Forms.Label()
        Me.pnlThirdColor = New System.Windows.Forms.Panel()
        Me.btnThirdColor = New System.Windows.Forms.Button()
        Me.lblBaseColor = New System.Windows.Forms.Label()
        Me.pnlBaseColor = New System.Windows.Forms.Panel()
        Me.lblAccentColor = New System.Windows.Forms.Label()
        Me.pnlAccentColor = New System.Windows.Forms.Panel()
        Me.btnBaseColor = New System.Windows.Forms.Button()
        Me.btnAccentColor = New System.Windows.Forms.Button()
        Me.picLiveryBasicsPreview = New System.Windows.Forms.PictureBox()
        Me.btnLiveryBasicsPreview = New System.Windows.Forms.Button()
        Me.tbpChassis = New System.Windows.Forms.TabPage()
        Me.spcChassis1 = New System.Windows.Forms.SplitContainer()
        Me.grpChassisLayers = New System.Windows.Forms.GroupBox()
        Me.pnlChassisLayers = New System.Windows.Forms.Panel()
        Me.lviChassisLayers = New System.Windows.Forms.ListView()
        Me.clhGuid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tstChassisLayers = New System.Windows.Forms.ToolStrip()
        Me.btnChassisEditLayer = New System.Windows.Forms.ToolStripButton()
        Me.btnChassisRemoveLayer = New System.Windows.Forms.ToolStripButton()
        Me.btnChassisLayerDown = New System.Windows.Forms.ToolStripButton()
        Me.btnChassisLayerUp = New System.Windows.Forms.ToolStripButton()
        Me.btnChassisAddShading = New System.Windows.Forms.Button()
        Me.btnChassisAddParts = New System.Windows.Forms.Button()
        Me.btnChassisAddNumberplate = New System.Windows.Forms.Button()
        Me.btnChassisAddDetail = New System.Windows.Forms.Button()
        Me.btnChassisAddColorableDecal = New System.Windows.Forms.Button()
        Me.btnChassisAddDecal = New System.Windows.Forms.Button()
        Me.spcChassis2 = New System.Windows.Forms.SplitContainer()
        Me.btnChassisPreview = New System.Windows.Forms.Button()
        Me.picChassisPreview = New System.Windows.Forms.PictureBox()
        Me.grpChassisElements = New System.Windows.Forms.GroupBox()
        Me.pnlChassisElements = New System.Windows.Forms.Panel()
        Me.lviChassisElements = New System.Windows.Forms.ListView()
        Me.clhElementGuid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhElementType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tstChassisElements = New System.Windows.Forms.ToolStrip()
        Me.btnChassisEditElement = New System.Windows.Forms.ToolStripButton()
        Me.btnChassisRemoveElement = New System.Windows.Forms.ToolStripButton()
        Me.btnChassisElementDown = New System.Windows.Forms.ToolStripButton()
        Me.btnChassisElementUp = New System.Windows.Forms.ToolStripButton()
        Me.btnChassisAddSponsor = New System.Windows.Forms.Button()
        Me.btnChassisAddFreeText = New System.Windows.Forms.Button()
        Me.tbpWindows = New System.Windows.Forms.TabPage()
        Me.lblWindowsWip = New System.Windows.Forms.Label()
        Me.tbpIntWindows = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tstActions = New System.Windows.Forms.ToolStrip()
        Me.btnReset = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnLoad = New System.Windows.Forms.ToolStripButton()
        Me.btnExport = New System.Windows.Forms.ToolStripButton()
        Me.tstCarSelection = New System.Windows.Forms.ToolStrip()
        Me.lblCarSelection = New System.Windows.Forms.ToolStripLabel()
        Me.cmbCarSelection = New System.Windows.Forms.ToolStripComboBox()
        Me.lblPresetSelection = New System.Windows.Forms.ToolStripLabel()
        Me.cmbPresetCollection = New System.Windows.Forms.ToolStripComboBox()
        Me.btnCarImport = New System.Windows.Forms.ToolStripButton()
        Me.btnCarEditor = New System.Windows.Forms.ToolStripButton()
        Me.btnCarDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnSettings = New System.Windows.Forms.ToolStripButton()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcMain.Panel1.SuspendLayout()
        Me.spcMain.Panel2.SuspendLayout()
        Me.spcMain.SuspendLayout()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcLiveryDesign.SuspendLayout()
        Me.tbpLiveryBasics.SuspendLayout()
        CType(Me.spcLiveryBasics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcLiveryBasics.Panel1.SuspendLayout()
        Me.spcLiveryBasics.Panel2.SuspendLayout()
        Me.spcLiveryBasics.SuspendLayout()
        CType(Me.spcLiveryBasicsSettings1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcLiveryBasicsSettings1.Panel1.SuspendLayout()
        Me.spcLiveryBasicsSettings1.Panel2.SuspendLayout()
        Me.spcLiveryBasicsSettings1.SuspendLayout()
        Me.grpBasicDriver.SuspendLayout()
        CType(Me.nudDriverNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcLiveryBasicsSettings2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcLiveryBasicsSettings2.Panel1.SuspendLayout()
        Me.spcLiveryBasicsSettings2.Panel2.SuspendLayout()
        Me.spcLiveryBasicsSettings2.SuspendLayout()
        Me.grpBasicFonts.SuspendLayout()
        Me.grpBasicColors.SuspendLayout()
        CType(Me.picLiveryBasicsPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpChassis.SuspendLayout()
        CType(Me.spcChassis1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcChassis1.Panel1.SuspendLayout()
        Me.spcChassis1.Panel2.SuspendLayout()
        Me.spcChassis1.SuspendLayout()
        Me.grpChassisLayers.SuspendLayout()
        Me.pnlChassisLayers.SuspendLayout()
        Me.tstChassisLayers.SuspendLayout()
        CType(Me.spcChassis2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcChassis2.Panel1.SuspendLayout()
        Me.spcChassis2.Panel2.SuspendLayout()
        Me.spcChassis2.SuspendLayout()
        CType(Me.picChassisPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpChassisElements.SuspendLayout()
        Me.pnlChassisElements.SuspendLayout()
        Me.tstChassisElements.SuspendLayout()
        Me.tbpWindows.SuspendLayout()
        Me.tbpIntWindows.SuspendLayout()
        Me.tstActions.SuspendLayout()
        Me.tstCarSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'spcMain
        '
        Me.spcMain.BackColor = System.Drawing.Color.White
        Me.spcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spcMain.IsSplitterFixed = True
        Me.spcMain.Location = New System.Drawing.Point(0, 0)
        Me.spcMain.Name = "spcMain"
        Me.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcMain.Panel1
        '
        Me.spcMain.Panel1.Controls.Add(Me.btnDebug)
        Me.spcMain.Panel1.Controls.Add(Me.picHeader)
        Me.spcMain.Panel1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'spcMain.Panel2
        '
        Me.spcMain.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.spcMain.Panel2.Controls.Add(Me.tbcLiveryDesign)
        Me.spcMain.Panel2.Controls.Add(Me.tstActions)
        Me.spcMain.Panel2.Controls.Add(Me.tstCarSelection)
        Me.spcMain.Size = New System.Drawing.Size(784, 561)
        Me.spcMain.SplitterDistance = 60
        Me.spcMain.TabIndex = 0
        Me.spcMain.TabStop = False
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(12, 12)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(75, 23)
        Me.btnDebug.TabIndex = 1
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'picHeader
        '
        Me.picHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picHeader.Image = Global.Simplivery.My.Resources.Resources.logo_header
        Me.picHeader.Location = New System.Drawing.Point(0, 5)
        Me.picHeader.Name = "picHeader"
        Me.picHeader.Size = New System.Drawing.Size(784, 55)
        Me.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeader.TabIndex = 0
        Me.picHeader.TabStop = False
        '
        'tbcLiveryDesign
        '
        Me.tbcLiveryDesign.Controls.Add(Me.tbpLiveryBasics)
        Me.tbcLiveryDesign.Controls.Add(Me.tbpChassis)
        Me.tbcLiveryDesign.Controls.Add(Me.tbpWindows)
        Me.tbcLiveryDesign.Controls.Add(Me.tbpIntWindows)
        Me.tbcLiveryDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcLiveryDesign.ItemSize = New System.Drawing.Size(62, 32)
        Me.tbcLiveryDesign.Location = New System.Drawing.Point(0, 31)
        Me.tbcLiveryDesign.Multiline = True
        Me.tbcLiveryDesign.Name = "tbcLiveryDesign"
        Me.tbcLiveryDesign.SelectedIndex = 0
        Me.tbcLiveryDesign.Size = New System.Drawing.Size(784, 435)
        Me.tbcLiveryDesign.TabIndex = 2
        '
        'tbpLiveryBasics
        '
        Me.tbpLiveryBasics.Controls.Add(Me.spcLiveryBasics)
        Me.tbpLiveryBasics.Location = New System.Drawing.Point(4, 36)
        Me.tbpLiveryBasics.Name = "tbpLiveryBasics"
        Me.tbpLiveryBasics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLiveryBasics.Size = New System.Drawing.Size(776, 395)
        Me.tbpLiveryBasics.TabIndex = 0
        Me.tbpLiveryBasics.Text = "Livery basics"
        Me.tbpLiveryBasics.UseVisualStyleBackColor = True
        '
        'spcLiveryBasics
        '
        Me.spcLiveryBasics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcLiveryBasics.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spcLiveryBasics.IsSplitterFixed = True
        Me.spcLiveryBasics.Location = New System.Drawing.Point(3, 3)
        Me.spcLiveryBasics.Name = "spcLiveryBasics"
        Me.spcLiveryBasics.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcLiveryBasics.Panel1
        '
        Me.spcLiveryBasics.Panel1.Controls.Add(Me.spcLiveryBasicsSettings1)
        '
        'spcLiveryBasics.Panel2
        '
        Me.spcLiveryBasics.Panel2.Controls.Add(Me.picLiveryBasicsPreview)
        Me.spcLiveryBasics.Panel2.Controls.Add(Me.btnLiveryBasicsPreview)
        Me.spcLiveryBasics.Size = New System.Drawing.Size(770, 389)
        Me.spcLiveryBasics.SplitterDistance = 140
        Me.spcLiveryBasics.SplitterWidth = 1
        Me.spcLiveryBasics.TabIndex = 0
        Me.spcLiveryBasics.TabStop = False
        '
        'spcLiveryBasicsSettings1
        '
        Me.spcLiveryBasicsSettings1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcLiveryBasicsSettings1.IsSplitterFixed = True
        Me.spcLiveryBasicsSettings1.Location = New System.Drawing.Point(0, 0)
        Me.spcLiveryBasicsSettings1.Name = "spcLiveryBasicsSettings1"
        '
        'spcLiveryBasicsSettings1.Panel1
        '
        Me.spcLiveryBasicsSettings1.Panel1.Controls.Add(Me.grpBasicDriver)
        '
        'spcLiveryBasicsSettings1.Panel2
        '
        Me.spcLiveryBasicsSettings1.Panel2.Controls.Add(Me.spcLiveryBasicsSettings2)
        Me.spcLiveryBasicsSettings1.Size = New System.Drawing.Size(770, 140)
        Me.spcLiveryBasicsSettings1.SplitterDistance = 256
        Me.spcLiveryBasicsSettings1.SplitterWidth = 1
        Me.spcLiveryBasicsSettings1.TabIndex = 0
        Me.spcLiveryBasicsSettings1.TabStop = False
        '
        'grpBasicDriver
        '
        Me.grpBasicDriver.Controls.Add(Me.lblDriverName)
        Me.grpBasicDriver.Controls.Add(Me.lblDriverNo)
        Me.grpBasicDriver.Controls.Add(Me.txtDriverName)
        Me.grpBasicDriver.Controls.Add(Me.lblTeamName)
        Me.grpBasicDriver.Controls.Add(Me.txtTeamName)
        Me.grpBasicDriver.Controls.Add(Me.nudDriverNo)
        Me.grpBasicDriver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBasicDriver.Location = New System.Drawing.Point(0, 0)
        Me.grpBasicDriver.Name = "grpBasicDriver"
        Me.grpBasicDriver.Size = New System.Drawing.Size(256, 140)
        Me.grpBasicDriver.TabIndex = 6
        Me.grpBasicDriver.TabStop = False
        Me.grpBasicDriver.Text = "Driver Settings"
        '
        'lblDriverName
        '
        Me.lblDriverName.AutoSize = True
        Me.lblDriverName.Location = New System.Drawing.Point(6, 22)
        Me.lblDriverName.Name = "lblDriverName"
        Me.lblDriverName.Size = New System.Drawing.Size(73, 13)
        Me.lblDriverName.TabIndex = 0
        Me.lblDriverName.Text = "Driver's Name"
        '
        'lblDriverNo
        '
        Me.lblDriverNo.AutoSize = True
        Me.lblDriverNo.Location = New System.Drawing.Point(6, 74)
        Me.lblDriverNo.Name = "lblDriverNo"
        Me.lblDriverNo.Size = New System.Drawing.Size(55, 13)
        Me.lblDriverNo.TabIndex = 5
        Me.lblDriverNo.Text = "Driver No."
        '
        'txtDriverName
        '
        Me.txtDriverName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDriverName.Location = New System.Drawing.Point(83, 19)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(167, 20)
        Me.txtDriverName.TabIndex = 1
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Location = New System.Drawing.Point(6, 48)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(65, 13)
        Me.lblTeamName.TabIndex = 4
        Me.lblTeamName.Text = "Team Name"
        '
        'txtTeamName
        '
        Me.txtTeamName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTeamName.Location = New System.Drawing.Point(83, 45)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(167, 20)
        Me.txtTeamName.TabIndex = 2
        '
        'nudDriverNo
        '
        Me.nudDriverNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudDriverNo.Location = New System.Drawing.Point(83, 72)
        Me.nudDriverNo.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudDriverNo.Name = "nudDriverNo"
        Me.nudDriverNo.Size = New System.Drawing.Size(167, 20)
        Me.nudDriverNo.TabIndex = 3
        '
        'spcLiveryBasicsSettings2
        '
        Me.spcLiveryBasicsSettings2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcLiveryBasicsSettings2.IsSplitterFixed = True
        Me.spcLiveryBasicsSettings2.Location = New System.Drawing.Point(0, 0)
        Me.spcLiveryBasicsSettings2.Name = "spcLiveryBasicsSettings2"
        '
        'spcLiveryBasicsSettings2.Panel1
        '
        Me.spcLiveryBasicsSettings2.Panel1.Controls.Add(Me.grpBasicFonts)
        '
        'spcLiveryBasicsSettings2.Panel2
        '
        Me.spcLiveryBasicsSettings2.Panel2.Controls.Add(Me.grpBasicColors)
        Me.spcLiveryBasicsSettings2.Size = New System.Drawing.Size(513, 140)
        Me.spcLiveryBasicsSettings2.SplitterDistance = 256
        Me.spcLiveryBasicsSettings2.SplitterWidth = 1
        Me.spcLiveryBasicsSettings2.TabIndex = 0
        Me.spcLiveryBasicsSettings2.TabStop = False
        '
        'grpBasicFonts
        '
        Me.grpBasicFonts.Controls.Add(Me.lblNameFontInfo)
        Me.grpBasicFonts.Controls.Add(Me.txtNameFont)
        Me.grpBasicFonts.Controls.Add(Me.btnNameFont)
        Me.grpBasicFonts.Controls.Add(Me.txtNoFont)
        Me.grpBasicFonts.Controls.Add(Me.btnNoFont)
        Me.grpBasicFonts.Controls.Add(Me.lblNoFont)
        Me.grpBasicFonts.Controls.Add(Me.lblNameFont)
        Me.grpBasicFonts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBasicFonts.Location = New System.Drawing.Point(0, 0)
        Me.grpBasicFonts.Name = "grpBasicFonts"
        Me.grpBasicFonts.Size = New System.Drawing.Size(256, 140)
        Me.grpBasicFonts.TabIndex = 4
        Me.grpBasicFonts.TabStop = False
        Me.grpBasicFonts.Text = "Font Settings"
        '
        'lblNameFontInfo
        '
        Me.lblNameFontInfo.AutoSize = True
        Me.lblNameFontInfo.Location = New System.Drawing.Point(82, 68)
        Me.lblNameFontInfo.Name = "lblNameFontInfo"
        Me.lblNameFontInfo.Size = New System.Drawing.Size(139, 13)
        Me.lblNameFontInfo.TabIndex = 38
        Me.lblNameFontInfo.Text = "(used for new text elements)"
        '
        'txtNameFont
        '
        Me.txtNameFont.Location = New System.Drawing.Point(85, 45)
        Me.txtNameFont.Name = "txtNameFont"
        Me.txtNameFont.ReadOnly = True
        Me.txtNameFont.Size = New System.Drawing.Size(92, 20)
        Me.txtNameFont.TabIndex = 37
        '
        'btnNameFont
        '
        Me.btnNameFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNameFont.Location = New System.Drawing.Point(183, 45)
        Me.btnNameFont.Name = "btnNameFont"
        Me.btnNameFont.Size = New System.Drawing.Size(67, 20)
        Me.btnNameFont.TabIndex = 36
        Me.btnNameFont.Text = "Choose"
        Me.btnNameFont.UseVisualStyleBackColor = True
        '
        'txtNoFont
        '
        Me.txtNoFont.Location = New System.Drawing.Point(85, 19)
        Me.txtNoFont.Name = "txtNoFont"
        Me.txtNoFont.ReadOnly = True
        Me.txtNoFont.Size = New System.Drawing.Size(92, 20)
        Me.txtNoFont.TabIndex = 35
        '
        'btnNoFont
        '
        Me.btnNoFont.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoFont.Location = New System.Drawing.Point(183, 19)
        Me.btnNoFont.Name = "btnNoFont"
        Me.btnNoFont.Size = New System.Drawing.Size(67, 20)
        Me.btnNoFont.TabIndex = 34
        Me.btnNoFont.Text = "Choose"
        Me.btnNoFont.UseVisualStyleBackColor = True
        '
        'lblNoFont
        '
        Me.lblNoFont.AutoSize = True
        Me.lblNoFont.Location = New System.Drawing.Point(6, 22)
        Me.lblNoFont.Name = "lblNoFont"
        Me.lblNoFont.Size = New System.Drawing.Size(48, 13)
        Me.lblNoFont.TabIndex = 2
        Me.lblNoFont.Text = "No. Font"
        '
        'lblNameFont
        '
        Me.lblNameFont.AutoSize = True
        Me.lblNameFont.Location = New System.Drawing.Point(6, 48)
        Me.lblNameFont.Name = "lblNameFont"
        Me.lblNameFont.Size = New System.Drawing.Size(52, 13)
        Me.lblNameFont.TabIndex = 3
        Me.lblNameFont.Text = "Text Font"
        '
        'grpBasicColors
        '
        Me.grpBasicColors.Controls.Add(Me.lblThirdColorInfo)
        Me.grpBasicColors.Controls.Add(Me.lblThirdColor)
        Me.grpBasicColors.Controls.Add(Me.pnlThirdColor)
        Me.grpBasicColors.Controls.Add(Me.btnThirdColor)
        Me.grpBasicColors.Controls.Add(Me.lblBaseColor)
        Me.grpBasicColors.Controls.Add(Me.pnlBaseColor)
        Me.grpBasicColors.Controls.Add(Me.lblAccentColor)
        Me.grpBasicColors.Controls.Add(Me.pnlAccentColor)
        Me.grpBasicColors.Controls.Add(Me.btnBaseColor)
        Me.grpBasicColors.Controls.Add(Me.btnAccentColor)
        Me.grpBasicColors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBasicColors.Location = New System.Drawing.Point(0, 0)
        Me.grpBasicColors.Name = "grpBasicColors"
        Me.grpBasicColors.Size = New System.Drawing.Size(256, 140)
        Me.grpBasicColors.TabIndex = 7
        Me.grpBasicColors.TabStop = False
        Me.grpBasicColors.Text = "Preselect colors for new layers"
        '
        'lblThirdColorInfo
        '
        Me.lblThirdColorInfo.AutoSize = True
        Me.lblThirdColorInfo.Location = New System.Drawing.Point(82, 94)
        Me.lblThirdColorInfo.Name = "lblThirdColorInfo"
        Me.lblThirdColorInfo.Size = New System.Drawing.Size(152, 13)
        Me.lblThirdColorInfo.TabIndex = 13
        Me.lblThirdColorInfo.Text = "(used for new text and presets)"
        '
        'lblThirdColor
        '
        Me.lblThirdColor.AutoSize = True
        Me.lblThirdColor.Location = New System.Drawing.Point(7, 75)
        Me.lblThirdColor.Name = "lblThirdColor"
        Me.lblThirdColor.Size = New System.Drawing.Size(58, 13)
        Me.lblThirdColor.TabIndex = 10
        Me.lblThirdColor.Text = "Third Color"
        '
        'pnlThirdColor
        '
        Me.pnlThirdColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlThirdColor.BackColor = System.Drawing.Color.Black
        Me.pnlThirdColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlThirdColor.Location = New System.Drawing.Point(85, 71)
        Me.pnlThirdColor.Name = "pnlThirdColor"
        Me.pnlThirdColor.Size = New System.Drawing.Size(94, 20)
        Me.pnlThirdColor.TabIndex = 12
        '
        'btnThirdColor
        '
        Me.btnThirdColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThirdColor.Location = New System.Drawing.Point(185, 71)
        Me.btnThirdColor.Name = "btnThirdColor"
        Me.btnThirdColor.Size = New System.Drawing.Size(67, 20)
        Me.btnThirdColor.TabIndex = 11
        Me.btnThirdColor.Text = "Choose"
        Me.btnThirdColor.UseVisualStyleBackColor = True
        '
        'lblBaseColor
        '
        Me.lblBaseColor.AutoSize = True
        Me.lblBaseColor.Location = New System.Drawing.Point(7, 23)
        Me.lblBaseColor.Name = "lblBaseColor"
        Me.lblBaseColor.Size = New System.Drawing.Size(58, 13)
        Me.lblBaseColor.TabIndex = 0
        Me.lblBaseColor.Text = "Base Color"
        '
        'pnlBaseColor
        '
        Me.pnlBaseColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBaseColor.BackColor = System.Drawing.Color.White
        Me.pnlBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBaseColor.Location = New System.Drawing.Point(85, 19)
        Me.pnlBaseColor.Name = "pnlBaseColor"
        Me.pnlBaseColor.Size = New System.Drawing.Size(94, 20)
        Me.pnlBaseColor.TabIndex = 6
        '
        'lblAccentColor
        '
        Me.lblAccentColor.AutoSize = True
        Me.lblAccentColor.Location = New System.Drawing.Point(8, 49)
        Me.lblAccentColor.Name = "lblAccentColor"
        Me.lblAccentColor.Size = New System.Drawing.Size(68, 13)
        Me.lblAccentColor.TabIndex = 1
        Me.lblAccentColor.Text = "Accent Color"
        '
        'pnlAccentColor
        '
        Me.pnlAccentColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAccentColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pnlAccentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAccentColor.Location = New System.Drawing.Point(85, 45)
        Me.pnlAccentColor.Name = "pnlAccentColor"
        Me.pnlAccentColor.Size = New System.Drawing.Size(94, 20)
        Me.pnlAccentColor.TabIndex = 5
        '
        'btnBaseColor
        '
        Me.btnBaseColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBaseColor.Location = New System.Drawing.Point(185, 19)
        Me.btnBaseColor.Name = "btnBaseColor"
        Me.btnBaseColor.Size = New System.Drawing.Size(67, 20)
        Me.btnBaseColor.TabIndex = 2
        Me.btnBaseColor.Text = "Choose"
        Me.btnBaseColor.UseVisualStyleBackColor = True
        '
        'btnAccentColor
        '
        Me.btnAccentColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccentColor.Location = New System.Drawing.Point(185, 45)
        Me.btnAccentColor.Name = "btnAccentColor"
        Me.btnAccentColor.Size = New System.Drawing.Size(67, 20)
        Me.btnAccentColor.TabIndex = 3
        Me.btnAccentColor.Text = "Choose"
        Me.btnAccentColor.UseVisualStyleBackColor = True
        '
        'picLiveryBasicsPreview
        '
        Me.picLiveryBasicsPreview.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picLiveryBasicsPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLiveryBasicsPreview.Location = New System.Drawing.Point(200, 5)
        Me.picLiveryBasicsPreview.Name = "picLiveryBasicsPreview"
        Me.picLiveryBasicsPreview.Size = New System.Drawing.Size(370, 141)
        Me.picLiveryBasicsPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLiveryBasicsPreview.TabIndex = 1
        Me.picLiveryBasicsPreview.TabStop = False
        '
        'btnLiveryBasicsPreview
        '
        Me.btnLiveryBasicsPreview.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLiveryBasicsPreview.Image = Global.Simplivery.My.Resources.Resources.reload
        Me.btnLiveryBasicsPreview.Location = New System.Drawing.Point(342, 152)
        Me.btnLiveryBasicsPreview.Name = "btnLiveryBasicsPreview"
        Me.btnLiveryBasicsPreview.Size = New System.Drawing.Size(100, 32)
        Me.btnLiveryBasicsPreview.TabIndex = 0
        Me.btnLiveryBasicsPreview.Text = "Preview"
        Me.btnLiveryBasicsPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLiveryBasicsPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLiveryBasicsPreview.UseVisualStyleBackColor = True
        '
        'tbpChassis
        '
        Me.tbpChassis.Controls.Add(Me.spcChassis1)
        Me.tbpChassis.Location = New System.Drawing.Point(4, 36)
        Me.tbpChassis.Name = "tbpChassis"
        Me.tbpChassis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpChassis.Size = New System.Drawing.Size(776, 395)
        Me.tbpChassis.TabIndex = 1
        Me.tbpChassis.Text = "Chassis"
        Me.tbpChassis.UseVisualStyleBackColor = True
        '
        'spcChassis1
        '
        Me.spcChassis1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcChassis1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spcChassis1.IsSplitterFixed = True
        Me.spcChassis1.Location = New System.Drawing.Point(3, 3)
        Me.spcChassis1.Name = "spcChassis1"
        '
        'spcChassis1.Panel1
        '
        Me.spcChassis1.Panel1.Controls.Add(Me.grpChassisLayers)
        '
        'spcChassis1.Panel2
        '
        Me.spcChassis1.Panel2.Controls.Add(Me.spcChassis2)
        Me.spcChassis1.Size = New System.Drawing.Size(770, 389)
        Me.spcChassis1.SplitterDistance = 200
        Me.spcChassis1.SplitterWidth = 1
        Me.spcChassis1.TabIndex = 1
        Me.spcChassis1.TabStop = False
        '
        'grpChassisLayers
        '
        Me.grpChassisLayers.Controls.Add(Me.pnlChassisLayers)
        Me.grpChassisLayers.Controls.Add(Me.btnChassisAddShading)
        Me.grpChassisLayers.Controls.Add(Me.btnChassisAddParts)
        Me.grpChassisLayers.Controls.Add(Me.btnChassisAddNumberplate)
        Me.grpChassisLayers.Controls.Add(Me.btnChassisAddDetail)
        Me.grpChassisLayers.Controls.Add(Me.btnChassisAddColorableDecal)
        Me.grpChassisLayers.Controls.Add(Me.btnChassisAddDecal)
        Me.grpChassisLayers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpChassisLayers.Location = New System.Drawing.Point(0, 0)
        Me.grpChassisLayers.Name = "grpChassisLayers"
        Me.grpChassisLayers.Size = New System.Drawing.Size(200, 389)
        Me.grpChassisLayers.TabIndex = 0
        Me.grpChassisLayers.TabStop = False
        Me.grpChassisLayers.Text = "Layers"
        '
        'pnlChassisLayers
        '
        Me.pnlChassisLayers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlChassisLayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChassisLayers.Controls.Add(Me.lviChassisLayers)
        Me.pnlChassisLayers.Controls.Add(Me.tstChassisLayers)
        Me.pnlChassisLayers.Location = New System.Drawing.Point(6, 171)
        Me.pnlChassisLayers.Name = "pnlChassisLayers"
        Me.pnlChassisLayers.Size = New System.Drawing.Size(188, 212)
        Me.pnlChassisLayers.TabIndex = 7
        '
        'lviChassisLayers
        '
        Me.lviChassisLayers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lviChassisLayers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhGuid, Me.clhName})
        Me.lviChassisLayers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lviChassisLayers.FullRowSelect = True
        Me.lviChassisLayers.GridLines = True
        Me.lviChassisLayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lviChassisLayers.HideSelection = False
        Me.lviChassisLayers.Location = New System.Drawing.Point(0, 0)
        Me.lviChassisLayers.MultiSelect = False
        Me.lviChassisLayers.Name = "lviChassisLayers"
        Me.lviChassisLayers.Size = New System.Drawing.Size(186, 185)
        Me.lviChassisLayers.TabIndex = 1
        Me.lviChassisLayers.UseCompatibleStateImageBehavior = False
        Me.lviChassisLayers.View = System.Windows.Forms.View.Details
        '
        'clhGuid
        '
        Me.clhGuid.Text = ""
        Me.clhGuid.Width = 0
        '
        'clhName
        '
        Me.clhName.Text = ""
        Me.clhName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clhName.Width = 186
        '
        'tstChassisLayers
        '
        Me.tstChassisLayers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tstChassisLayers.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tstChassisLayers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChassisEditLayer, Me.btnChassisRemoveLayer, Me.btnChassisLayerDown, Me.btnChassisLayerUp})
        Me.tstChassisLayers.Location = New System.Drawing.Point(0, 185)
        Me.tstChassisLayers.Name = "tstChassisLayers"
        Me.tstChassisLayers.Size = New System.Drawing.Size(186, 25)
        Me.tstChassisLayers.TabIndex = 0
        Me.tstChassisLayers.Text = "ToolStrip1"
        '
        'btnChassisEditLayer
        '
        Me.btnChassisEditLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChassisEditLayer.Image = Global.Simplivery.My.Resources.Resources.edit
        Me.btnChassisEditLayer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChassisEditLayer.Name = "btnChassisEditLayer"
        Me.btnChassisEditLayer.Size = New System.Drawing.Size(23, 22)
        Me.btnChassisEditLayer.Text = "Edit Layer"
        '
        'btnChassisRemoveLayer
        '
        Me.btnChassisRemoveLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChassisRemoveLayer.Image = Global.Simplivery.My.Resources.Resources.delete
        Me.btnChassisRemoveLayer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChassisRemoveLayer.Name = "btnChassisRemoveLayer"
        Me.btnChassisRemoveLayer.Size = New System.Drawing.Size(23, 22)
        Me.btnChassisRemoveLayer.Text = "Remove Layer"
        '
        'btnChassisLayerDown
        '
        Me.btnChassisLayerDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnChassisLayerDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChassisLayerDown.Image = Global.Simplivery.My.Resources.Resources.down
        Me.btnChassisLayerDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChassisLayerDown.Name = "btnChassisLayerDown"
        Me.btnChassisLayerDown.Size = New System.Drawing.Size(23, 22)
        Me.btnChassisLayerDown.Text = "Move Down"
        '
        'btnChassisLayerUp
        '
        Me.btnChassisLayerUp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnChassisLayerUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChassisLayerUp.Image = Global.Simplivery.My.Resources.Resources.up
        Me.btnChassisLayerUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChassisLayerUp.Name = "btnChassisLayerUp"
        Me.btnChassisLayerUp.Size = New System.Drawing.Size(23, 22)
        Me.btnChassisLayerUp.Text = "Move Up"
        '
        'btnChassisAddShading
        '
        Me.btnChassisAddShading.Image = Global.Simplivery.My.Resources.Resources.shading
        Me.btnChassisAddShading.Location = New System.Drawing.Point(103, 133)
        Me.btnChassisAddShading.Name = "btnChassisAddShading"
        Me.btnChassisAddShading.Size = New System.Drawing.Size(91, 32)
        Me.btnChassisAddShading.TabIndex = 6
        Me.btnChassisAddShading.Text = "Shading"
        Me.btnChassisAddShading.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisAddShading.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisAddShading.UseVisualStyleBackColor = True
        '
        'btnChassisAddParts
        '
        Me.btnChassisAddParts.Image = Global.Simplivery.My.Resources.Resources.parts
        Me.btnChassisAddParts.Location = New System.Drawing.Point(6, 133)
        Me.btnChassisAddParts.Name = "btnChassisAddParts"
        Me.btnChassisAddParts.Size = New System.Drawing.Size(91, 32)
        Me.btnChassisAddParts.TabIndex = 5
        Me.btnChassisAddParts.Text = "Parts"
        Me.btnChassisAddParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisAddParts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisAddParts.UseVisualStyleBackColor = True
        '
        'btnChassisAddNumberplate
        '
        Me.btnChassisAddNumberplate.Image = Global.Simplivery.My.Resources.Resources.numberplate
        Me.btnChassisAddNumberplate.Location = New System.Drawing.Point(103, 95)
        Me.btnChassisAddNumberplate.Name = "btnChassisAddNumberplate"
        Me.btnChassisAddNumberplate.Size = New System.Drawing.Size(91, 32)
        Me.btnChassisAddNumberplate.TabIndex = 4
        Me.btnChassisAddNumberplate.Text = "No. Plate"
        Me.btnChassisAddNumberplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisAddNumberplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisAddNumberplate.UseVisualStyleBackColor = True
        '
        'btnChassisAddDetail
        '
        Me.btnChassisAddDetail.Image = Global.Simplivery.My.Resources.Resources.details
        Me.btnChassisAddDetail.Location = New System.Drawing.Point(6, 95)
        Me.btnChassisAddDetail.Name = "btnChassisAddDetail"
        Me.btnChassisAddDetail.Size = New System.Drawing.Size(91, 32)
        Me.btnChassisAddDetail.TabIndex = 2
        Me.btnChassisAddDetail.Text = "Detail"
        Me.btnChassisAddDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisAddDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisAddDetail.UseVisualStyleBackColor = True
        '
        'btnChassisAddColorableDecal
        '
        Me.btnChassisAddColorableDecal.Image = Global.Simplivery.My.Resources.Resources.colordecal
        Me.btnChassisAddColorableDecal.Location = New System.Drawing.Point(6, 57)
        Me.btnChassisAddColorableDecal.Name = "btnChassisAddColorableDecal"
        Me.btnChassisAddColorableDecal.Size = New System.Drawing.Size(188, 32)
        Me.btnChassisAddColorableDecal.TabIndex = 1
        Me.btnChassisAddColorableDecal.Text = "Colorable Decal"
        Me.btnChassisAddColorableDecal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisAddColorableDecal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisAddColorableDecal.UseVisualStyleBackColor = True
        '
        'btnChassisAddDecal
        '
        Me.btnChassisAddDecal.Image = Global.Simplivery.My.Resources.Resources.decal
        Me.btnChassisAddDecal.Location = New System.Drawing.Point(6, 19)
        Me.btnChassisAddDecal.Name = "btnChassisAddDecal"
        Me.btnChassisAddDecal.Size = New System.Drawing.Size(187, 32)
        Me.btnChassisAddDecal.TabIndex = 0
        Me.btnChassisAddDecal.Text = "Decal"
        Me.btnChassisAddDecal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisAddDecal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisAddDecal.UseVisualStyleBackColor = True
        '
        'spcChassis2
        '
        Me.spcChassis2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcChassis2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.spcChassis2.IsSplitterFixed = True
        Me.spcChassis2.Location = New System.Drawing.Point(0, 0)
        Me.spcChassis2.Name = "spcChassis2"
        '
        'spcChassis2.Panel1
        '
        Me.spcChassis2.Panel1.Controls.Add(Me.btnChassisPreview)
        Me.spcChassis2.Panel1.Controls.Add(Me.picChassisPreview)
        '
        'spcChassis2.Panel2
        '
        Me.spcChassis2.Panel2.Controls.Add(Me.grpChassisElements)
        Me.spcChassis2.Size = New System.Drawing.Size(569, 389)
        Me.spcChassis2.SplitterDistance = 371
        Me.spcChassis2.SplitterWidth = 1
        Me.spcChassis2.TabIndex = 0
        Me.spcChassis2.TabStop = False
        '
        'btnChassisPreview
        '
        Me.btnChassisPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnChassisPreview.Image = Global.Simplivery.My.Resources.Resources.reload
        Me.btnChassisPreview.Location = New System.Drawing.Point(137, 191)
        Me.btnChassisPreview.Name = "btnChassisPreview"
        Me.btnChassisPreview.Size = New System.Drawing.Size(100, 32)
        Me.btnChassisPreview.TabIndex = 1
        Me.btnChassisPreview.Text = "Preview"
        Me.btnChassisPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisPreview.UseVisualStyleBackColor = True
        '
        'picChassisPreview
        '
        Me.picChassisPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picChassisPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picChassisPreview.Location = New System.Drawing.Point(5, 3)
        Me.picChassisPreview.Name = "picChassisPreview"
        Me.picChassisPreview.Size = New System.Drawing.Size(361, 182)
        Me.picChassisPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChassisPreview.TabIndex = 0
        Me.picChassisPreview.TabStop = False
        '
        'grpChassisElements
        '
        Me.grpChassisElements.Controls.Add(Me.pnlChassisElements)
        Me.grpChassisElements.Controls.Add(Me.btnChassisAddSponsor)
        Me.grpChassisElements.Controls.Add(Me.btnChassisAddFreeText)
        Me.grpChassisElements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpChassisElements.Location = New System.Drawing.Point(0, 0)
        Me.grpChassisElements.Name = "grpChassisElements"
        Me.grpChassisElements.Size = New System.Drawing.Size(197, 389)
        Me.grpChassisElements.TabIndex = 1
        Me.grpChassisElements.TabStop = False
        Me.grpChassisElements.Text = "Elements"
        '
        'pnlChassisElements
        '
        Me.pnlChassisElements.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlChassisElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChassisElements.Controls.Add(Me.lviChassisElements)
        Me.pnlChassisElements.Controls.Add(Me.tstChassisElements)
        Me.pnlChassisElements.Location = New System.Drawing.Point(6, 172)
        Me.pnlChassisElements.Name = "pnlChassisElements"
        Me.pnlChassisElements.Size = New System.Drawing.Size(188, 212)
        Me.pnlChassisElements.TabIndex = 8
        '
        'lviChassisElements
        '
        Me.lviChassisElements.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lviChassisElements.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhElementGuid, Me.clhElementType})
        Me.lviChassisElements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lviChassisElements.FullRowSelect = True
        Me.lviChassisElements.GridLines = True
        Me.lviChassisElements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lviChassisElements.HideSelection = False
        Me.lviChassisElements.Location = New System.Drawing.Point(0, 0)
        Me.lviChassisElements.MultiSelect = False
        Me.lviChassisElements.Name = "lviChassisElements"
        Me.lviChassisElements.Size = New System.Drawing.Size(186, 185)
        Me.lviChassisElements.TabIndex = 1
        Me.lviChassisElements.UseCompatibleStateImageBehavior = False
        Me.lviChassisElements.View = System.Windows.Forms.View.Details
        '
        'clhElementGuid
        '
        Me.clhElementGuid.Text = ""
        Me.clhElementGuid.Width = 0
        '
        'clhElementType
        '
        Me.clhElementType.Text = ""
        Me.clhElementType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clhElementType.Width = 186
        '
        'tstChassisElements
        '
        Me.tstChassisElements.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tstChassisElements.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tstChassisElements.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnChassisEditElement, Me.btnChassisRemoveElement, Me.btnChassisElementDown, Me.btnChassisElementUp})
        Me.tstChassisElements.Location = New System.Drawing.Point(0, 185)
        Me.tstChassisElements.Name = "tstChassisElements"
        Me.tstChassisElements.Size = New System.Drawing.Size(186, 25)
        Me.tstChassisElements.TabIndex = 0
        Me.tstChassisElements.Text = "ToolStrip2"
        '
        'btnChassisEditElement
        '
        Me.btnChassisEditElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChassisEditElement.Image = Global.Simplivery.My.Resources.Resources.edit
        Me.btnChassisEditElement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChassisEditElement.Name = "btnChassisEditElement"
        Me.btnChassisEditElement.Size = New System.Drawing.Size(23, 22)
        Me.btnChassisEditElement.Text = "Edit Element"
        '
        'btnChassisRemoveElement
        '
        Me.btnChassisRemoveElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChassisRemoveElement.Image = Global.Simplivery.My.Resources.Resources.delete
        Me.btnChassisRemoveElement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChassisRemoveElement.Name = "btnChassisRemoveElement"
        Me.btnChassisRemoveElement.Size = New System.Drawing.Size(23, 22)
        Me.btnChassisRemoveElement.Text = "Remove Element"
        '
        'btnChassisElementDown
        '
        Me.btnChassisElementDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnChassisElementDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChassisElementDown.Image = Global.Simplivery.My.Resources.Resources.down
        Me.btnChassisElementDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChassisElementDown.Name = "btnChassisElementDown"
        Me.btnChassisElementDown.Size = New System.Drawing.Size(23, 22)
        Me.btnChassisElementDown.Text = "Move Down"
        '
        'btnChassisElementUp
        '
        Me.btnChassisElementUp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnChassisElementUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnChassisElementUp.Image = Global.Simplivery.My.Resources.Resources.up
        Me.btnChassisElementUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnChassisElementUp.Name = "btnChassisElementUp"
        Me.btnChassisElementUp.Size = New System.Drawing.Size(23, 22)
        Me.btnChassisElementUp.Text = "Move Up"
        '
        'btnChassisAddSponsor
        '
        Me.btnChassisAddSponsor.Image = Global.Simplivery.My.Resources.Resources.sponsor
        Me.btnChassisAddSponsor.Location = New System.Drawing.Point(6, 57)
        Me.btnChassisAddSponsor.Name = "btnChassisAddSponsor"
        Me.btnChassisAddSponsor.Size = New System.Drawing.Size(188, 32)
        Me.btnChassisAddSponsor.TabIndex = 2
        Me.btnChassisAddSponsor.Text = "Sponsor Label"
        Me.btnChassisAddSponsor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisAddSponsor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisAddSponsor.UseVisualStyleBackColor = True
        '
        'btnChassisAddFreeText
        '
        Me.btnChassisAddFreeText.Image = Global.Simplivery.My.Resources.Resources.text
        Me.btnChassisAddFreeText.Location = New System.Drawing.Point(6, 19)
        Me.btnChassisAddFreeText.Name = "btnChassisAddFreeText"
        Me.btnChassisAddFreeText.Size = New System.Drawing.Size(188, 32)
        Me.btnChassisAddFreeText.TabIndex = 1
        Me.btnChassisAddFreeText.Text = "Free Text"
        Me.btnChassisAddFreeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChassisAddFreeText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChassisAddFreeText.UseVisualStyleBackColor = True
        '
        'tbpWindows
        '
        Me.tbpWindows.Controls.Add(Me.lblWindowsWip)
        Me.tbpWindows.Location = New System.Drawing.Point(4, 36)
        Me.tbpWindows.Name = "tbpWindows"
        Me.tbpWindows.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpWindows.Size = New System.Drawing.Size(776, 395)
        Me.tbpWindows.TabIndex = 2
        Me.tbpWindows.Text = "Windows"
        Me.tbpWindows.UseVisualStyleBackColor = True
        '
        'lblWindowsWip
        '
        Me.lblWindowsWip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWindowsWip.Location = New System.Drawing.Point(3, 3)
        Me.lblWindowsWip.Name = "lblWindowsWip"
        Me.lblWindowsWip.Size = New System.Drawing.Size(770, 389)
        Me.lblWindowsWip.TabIndex = 0
        Me.lblWindowsWip.Text = "WIP"
        Me.lblWindowsWip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbpIntWindows
        '
        Me.tbpIntWindows.Controls.Add(Me.Label1)
        Me.tbpIntWindows.Location = New System.Drawing.Point(4, 36)
        Me.tbpIntWindows.Name = "tbpIntWindows"
        Me.tbpIntWindows.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpIntWindows.Size = New System.Drawing.Size(776, 395)
        Me.tbpIntWindows.TabIndex = 3
        Me.tbpIntWindows.Text = "Interior Windows"
        Me.tbpIntWindows.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(770, 389)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WIP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tstActions
        '
        Me.tstActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tstActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tstActions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tstActions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReset, Me.btnSave, Me.btnLoad, Me.btnExport})
        Me.tstActions.Location = New System.Drawing.Point(0, 466)
        Me.tstActions.Name = "tstActions"
        Me.tstActions.Size = New System.Drawing.Size(784, 31)
        Me.tstActions.TabIndex = 1
        Me.tstActions.Text = "Actions"
        '
        'btnReset
        '
        Me.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReset.Image = Global.Simplivery.My.Resources.Resources.reset
        Me.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(28, 28)
        Me.btnReset.Text = "Reset livery to default preset"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = Global.Simplivery.My.Resources.Resources.save
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(28, 28)
        Me.btnSave.Text = "Save this configuration"
        '
        'btnLoad
        '
        Me.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLoad.Image = Global.Simplivery.My.Resources.Resources.load
        Me.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(28, 28)
        Me.btnLoad.Text = "Load livery configuration"
        '
        'btnExport
        '
        Me.btnExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExport.Image = Global.Simplivery.My.Resources.Resources.export
        Me.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(102, 28)
        Me.btnExport.Text = "Export Livery"
        '
        'tstCarSelection
        '
        Me.tstCarSelection.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tstCarSelection.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tstCarSelection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCarSelection, Me.cmbCarSelection, Me.lblPresetSelection, Me.cmbPresetCollection, Me.btnCarImport, Me.btnCarEditor, Me.btnCarDelete, Me.btnSettings})
        Me.tstCarSelection.Location = New System.Drawing.Point(0, 0)
        Me.tstCarSelection.Name = "tstCarSelection"
        Me.tstCarSelection.Size = New System.Drawing.Size(784, 31)
        Me.tstCarSelection.TabIndex = 0
        Me.tstCarSelection.Text = "CarSelection"
        '
        'lblCarSelection
        '
        Me.lblCarSelection.Name = "lblCarSelection"
        Me.lblCarSelection.Size = New System.Drawing.Size(71, 28)
        Me.lblCarSelection.Text = "Select a Car:"
        '
        'cmbCarSelection
        '
        Me.cmbCarSelection.DropDownHeight = 100
        Me.cmbCarSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarSelection.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cmbCarSelection.IntegralHeight = False
        Me.cmbCarSelection.Name = "cmbCarSelection"
        Me.cmbCarSelection.Size = New System.Drawing.Size(240, 31)
        '
        'lblPresetSelection
        '
        Me.lblPresetSelection.Name = "lblPresetSelection"
        Me.lblPresetSelection.Size = New System.Drawing.Size(47, 28)
        Me.lblPresetSelection.Text = "Presets:"
        '
        'cmbPresetCollection
        '
        Me.cmbPresetCollection.DropDownHeight = 100
        Me.cmbPresetCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPresetCollection.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cmbPresetCollection.IntegralHeight = False
        Me.cmbPresetCollection.Name = "cmbPresetCollection"
        Me.cmbPresetCollection.Size = New System.Drawing.Size(180, 31)
        '
        'btnCarImport
        '
        Me.btnCarImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCarImport.Image = Global.Simplivery.My.Resources.Resources.importcar
        Me.btnCarImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCarImport.Name = "btnCarImport"
        Me.btnCarImport.Size = New System.Drawing.Size(28, 28)
        Me.btnCarImport.Text = "Import Car"
        '
        'btnCarEditor
        '
        Me.btnCarEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCarEditor.Image = Global.Simplivery.My.Resources.Resources.careditor
        Me.btnCarEditor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCarEditor.Name = "btnCarEditor"
        Me.btnCarEditor.Size = New System.Drawing.Size(28, 28)
        Me.btnCarEditor.Text = "Car Editor"
        '
        'btnCarDelete
        '
        Me.btnCarDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCarDelete.Image = Global.Simplivery.My.Resources.Resources.deletecar
        Me.btnCarDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCarDelete.Name = "btnCarDelete"
        Me.btnCarDelete.Size = New System.Drawing.Size(28, 28)
        Me.btnCarDelete.Text = "Delete Car"
        '
        'btnSettings
        '
        Me.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSettings.Image = Global.Simplivery.My.Resources.Resources.settings
        Me.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(28, 28)
        Me.btnSettings.Text = "Settings"
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.spcMain)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simplivery"
        Me.spcMain.Panel1.ResumeLayout(False)
        Me.spcMain.Panel2.ResumeLayout(False)
        Me.spcMain.Panel2.PerformLayout()
        CType(Me.spcMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcMain.ResumeLayout(False)
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcLiveryDesign.ResumeLayout(False)
        Me.tbpLiveryBasics.ResumeLayout(False)
        Me.spcLiveryBasics.Panel1.ResumeLayout(False)
        Me.spcLiveryBasics.Panel2.ResumeLayout(False)
        CType(Me.spcLiveryBasics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcLiveryBasics.ResumeLayout(False)
        Me.spcLiveryBasicsSettings1.Panel1.ResumeLayout(False)
        Me.spcLiveryBasicsSettings1.Panel2.ResumeLayout(False)
        CType(Me.spcLiveryBasicsSettings1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcLiveryBasicsSettings1.ResumeLayout(False)
        Me.grpBasicDriver.ResumeLayout(False)
        Me.grpBasicDriver.PerformLayout()
        CType(Me.nudDriverNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcLiveryBasicsSettings2.Panel1.ResumeLayout(False)
        Me.spcLiveryBasicsSettings2.Panel2.ResumeLayout(False)
        CType(Me.spcLiveryBasicsSettings2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcLiveryBasicsSettings2.ResumeLayout(False)
        Me.grpBasicFonts.ResumeLayout(False)
        Me.grpBasicFonts.PerformLayout()
        Me.grpBasicColors.ResumeLayout(False)
        Me.grpBasicColors.PerformLayout()
        CType(Me.picLiveryBasicsPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpChassis.ResumeLayout(False)
        Me.spcChassis1.Panel1.ResumeLayout(False)
        Me.spcChassis1.Panel2.ResumeLayout(False)
        CType(Me.spcChassis1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcChassis1.ResumeLayout(False)
        Me.grpChassisLayers.ResumeLayout(False)
        Me.pnlChassisLayers.ResumeLayout(False)
        Me.pnlChassisLayers.PerformLayout()
        Me.tstChassisLayers.ResumeLayout(False)
        Me.tstChassisLayers.PerformLayout()
        Me.spcChassis2.Panel1.ResumeLayout(False)
        Me.spcChassis2.Panel2.ResumeLayout(False)
        CType(Me.spcChassis2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcChassis2.ResumeLayout(False)
        CType(Me.picChassisPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpChassisElements.ResumeLayout(False)
        Me.pnlChassisElements.ResumeLayout(False)
        Me.pnlChassisElements.PerformLayout()
        Me.tstChassisElements.ResumeLayout(False)
        Me.tstChassisElements.PerformLayout()
        Me.tbpWindows.ResumeLayout(False)
        Me.tbpIntWindows.ResumeLayout(False)
        Me.tstActions.ResumeLayout(False)
        Me.tstActions.PerformLayout()
        Me.tstCarSelection.ResumeLayout(False)
        Me.tstCarSelection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spcMain As System.Windows.Forms.SplitContainer
    Friend WithEvents tstCarSelection As System.Windows.Forms.ToolStrip
    Friend WithEvents lblCarSelection As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbCarSelection As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents btnCarImport As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCarEditor As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCarDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstActions As System.Windows.Forms.ToolStrip
    Friend WithEvents btnReset As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLoad As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExport As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbcLiveryDesign As System.Windows.Forms.TabControl
    Friend WithEvents tbpLiveryBasics As System.Windows.Forms.TabPage
    Friend WithEvents tbpChassis As System.Windows.Forms.TabPage
    Friend WithEvents tbpWindows As System.Windows.Forms.TabPage
    Friend WithEvents tbpIntWindows As System.Windows.Forms.TabPage
    Friend WithEvents spcLiveryBasics As System.Windows.Forms.SplitContainer
    Friend WithEvents spcLiveryBasicsSettings1 As System.Windows.Forms.SplitContainer
    Friend WithEvents spcLiveryBasicsSettings2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblDriverNo As System.Windows.Forms.Label
    Friend WithEvents lblTeamName As System.Windows.Forms.Label
    Friend WithEvents nudDriverNo As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTeamName As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverName As System.Windows.Forms.TextBox
    Friend WithEvents lblDriverName As System.Windows.Forms.Label
    Friend WithEvents lblNameFont As System.Windows.Forms.Label
    Friend WithEvents lblNoFont As System.Windows.Forms.Label
    Friend WithEvents pnlBaseColor As System.Windows.Forms.Panel
    Friend WithEvents pnlAccentColor As System.Windows.Forms.Panel
    Friend WithEvents btnAccentColor As System.Windows.Forms.Button
    Friend WithEvents btnBaseColor As System.Windows.Forms.Button
    Friend WithEvents lblAccentColor As System.Windows.Forms.Label
    Friend WithEvents lblBaseColor As System.Windows.Forms.Label
    Friend WithEvents btnLiveryBasicsPreview As System.Windows.Forms.Button
    Friend WithEvents picLiveryBasicsPreview As System.Windows.Forms.PictureBox
    Friend WithEvents spcChassis1 As System.Windows.Forms.SplitContainer
    Friend WithEvents spcChassis2 As System.Windows.Forms.SplitContainer
    Friend WithEvents grpBasicDriver As System.Windows.Forms.GroupBox
    Friend WithEvents grpBasicFonts As System.Windows.Forms.GroupBox
    Friend WithEvents grpBasicColors As System.Windows.Forms.GroupBox
    Friend WithEvents grpChassisLayers As System.Windows.Forms.GroupBox
    Friend WithEvents picChassisPreview As System.Windows.Forms.PictureBox
    Friend WithEvents grpChassisElements As System.Windows.Forms.GroupBox
    Friend WithEvents btnChassisPreview As System.Windows.Forms.Button
    Friend WithEvents pnlChassisLayers As System.Windows.Forms.Panel
    Friend WithEvents btnChassisAddShading As System.Windows.Forms.Button
    Friend WithEvents btnChassisAddParts As System.Windows.Forms.Button
    Friend WithEvents btnChassisAddNumberplate As System.Windows.Forms.Button
    Friend WithEvents btnChassisAddDetail As System.Windows.Forms.Button
    Friend WithEvents btnChassisAddColorableDecal As System.Windows.Forms.Button
    Friend WithEvents btnChassisAddDecal As System.Windows.Forms.Button
    Friend WithEvents tstChassisLayers As System.Windows.Forms.ToolStrip
    Friend WithEvents btnChassisEditLayer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChassisRemoveLayer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChassisLayerDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents lviChassisLayers As System.Windows.Forms.ListView
    Friend WithEvents pnlChassisElements As System.Windows.Forms.Panel
    Friend WithEvents lviChassisElements As System.Windows.Forms.ListView
    Friend WithEvents tstChassisElements As System.Windows.Forms.ToolStrip
    Friend WithEvents btnChassisEditElement As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChassisRemoveElement As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChassisElementDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChassisAddSponsor As System.Windows.Forms.Button
    Friend WithEvents btnChassisAddFreeText As System.Windows.Forms.Button
    Friend WithEvents btnChassisLayerUp As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnChassisElementUp As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblWindowsWip As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picHeader As System.Windows.Forms.PictureBox
    Friend WithEvents cmbPresetCollection As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblThirdColor As System.Windows.Forms.Label
    Friend WithEvents pnlThirdColor As System.Windows.Forms.Panel
    Friend WithEvents btnThirdColor As System.Windows.Forms.Button
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents lblPresetSelection As System.Windows.Forms.ToolStripLabel
    Friend WithEvents clhGuid As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblThirdColorInfo As System.Windows.Forms.Label
    Friend WithEvents clhElementGuid As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhElementType As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtNameFont As System.Windows.Forms.TextBox
    Friend WithEvents btnNameFont As System.Windows.Forms.Button
    Friend WithEvents txtNoFont As System.Windows.Forms.TextBox
    Friend WithEvents btnNoFont As System.Windows.Forms.Button
    Friend WithEvents lblNameFontInfo As System.Windows.Forms.Label

End Class
