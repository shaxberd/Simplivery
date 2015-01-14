<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayerAddDialog
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
        Me.lblAddLayerInfo = New System.Windows.Forms.Label()
        Me.lviLayerList = New System.Windows.Forms.ListView()
        Me.clhName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtLayerName = New System.Windows.Forms.TextBox()
        Me.txtLayerDescription = New System.Windows.Forms.TextBox()
        Me.pnlLayerColor = New System.Windows.Forms.Panel()
        Me.btnLayerColor = New System.Windows.Forms.Button()
        Me.lblLayerName = New System.Windows.Forms.Label()
        Me.cmbColorStyle = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblAddLayerInfo
        '
        Me.lblAddLayerInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddLayerInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblAddLayerInfo.Name = "lblAddLayerInfo"
        Me.lblAddLayerInfo.Size = New System.Drawing.Size(560, 23)
        Me.lblAddLayerInfo.TabIndex = 0
        Me.lblAddLayerInfo.Text = "Please select a layer to add to your livery:"
        Me.lblAddLayerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lviLayerList
        '
        Me.lviLayerList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lviLayerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lviLayerList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhName, Me.clhDesc})
        Me.lviLayerList.FullRowSelect = True
        Me.lviLayerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lviLayerList.HideSelection = False
        Me.lviLayerList.Location = New System.Drawing.Point(12, 35)
        Me.lviLayerList.MultiSelect = False
        Me.lviLayerList.Name = "lviLayerList"
        Me.lviLayerList.Size = New System.Drawing.Size(560, 351)
        Me.lviLayerList.TabIndex = 1
        Me.lviLayerList.TileSize = New System.Drawing.Size(265, 65)
        Me.lviLayerList.UseCompatibleStateImageBehavior = False
        Me.lviLayerList.View = System.Windows.Forms.View.Tile
        '
        'clhName
        '
        Me.clhName.Text = ""
        '
        'clhDesc
        '
        Me.clhDesc.Text = ""
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(472, 517)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 32)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(366, 517)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtLayerName
        '
        Me.txtLayerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLayerName.Location = New System.Drawing.Point(85, 392)
        Me.txtLayerName.Name = "txtLayerName"
        Me.txtLayerName.ReadOnly = True
        Me.txtLayerName.Size = New System.Drawing.Size(170, 20)
        Me.txtLayerName.TabIndex = 4
        Me.txtLayerName.Text = "Layer Name"
        '
        'txtLayerDescription
        '
        Me.txtLayerDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLayerDescription.Location = New System.Drawing.Point(12, 418)
        Me.txtLayerDescription.Multiline = True
        Me.txtLayerDescription.Name = "txtLayerDescription"
        Me.txtLayerDescription.ReadOnly = True
        Me.txtLayerDescription.Size = New System.Drawing.Size(560, 93)
        Me.txtLayerDescription.TabIndex = 5
        Me.txtLayerDescription.Text = "Layer Name"
        '
        'pnlLayerColor
        '
        Me.pnlLayerColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLayerColor.BackColor = System.Drawing.Color.White
        Me.pnlLayerColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLayerColor.Location = New System.Drawing.Point(405, 392)
        Me.pnlLayerColor.Name = "pnlLayerColor"
        Me.pnlLayerColor.Size = New System.Drawing.Size(94, 20)
        Me.pnlLayerColor.TabIndex = 8
        '
        'btnLayerColor
        '
        Me.btnLayerColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLayerColor.Location = New System.Drawing.Point(505, 392)
        Me.btnLayerColor.Name = "btnLayerColor"
        Me.btnLayerColor.Size = New System.Drawing.Size(67, 20)
        Me.btnLayerColor.TabIndex = 7
        Me.btnLayerColor.Text = "Choose"
        Me.btnLayerColor.UseVisualStyleBackColor = True
        '
        'lblLayerName
        '
        Me.lblLayerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLayerName.AutoSize = True
        Me.lblLayerName.Location = New System.Drawing.Point(12, 396)
        Me.lblLayerName.Name = "lblLayerName"
        Me.lblLayerName.Size = New System.Drawing.Size(67, 13)
        Me.lblLayerName.TabIndex = 10
        Me.lblLayerName.Text = "Layer Name:"
        '
        'cmbColorStyle
        '
        Me.cmbColorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColorStyle.FormattingEnabled = True
        Me.cmbColorStyle.Items.AddRange(New Object() {"use base color", "use accent color", "use third color", "use custom color:"})
        Me.cmbColorStyle.Location = New System.Drawing.Point(261, 392)
        Me.cmbColorStyle.Name = "cmbColorStyle"
        Me.cmbColorStyle.Size = New System.Drawing.Size(138, 21)
        Me.cmbColorStyle.TabIndex = 11
        '
        'frmLayerAddDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.cmbColorStyle)
        Me.Controls.Add(Me.lblLayerName)
        Me.Controls.Add(Me.pnlLayerColor)
        Me.Controls.Add(Me.btnLayerColor)
        Me.Controls.Add(Me.txtLayerDescription)
        Me.Controls.Add(Me.txtLayerName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lviLayerList)
        Me.Controls.Add(Me.lblAddLayerInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "frmLayerAddDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New layer: "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddLayerInfo As System.Windows.Forms.Label
    Friend WithEvents lviLayerList As System.Windows.Forms.ListView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtLayerName As System.Windows.Forms.TextBox
    Friend WithEvents txtLayerDescription As System.Windows.Forms.TextBox
    Friend WithEvents pnlLayerColor As System.Windows.Forms.Panel
    Friend WithEvents btnLayerColor As System.Windows.Forms.Button
    Friend WithEvents lblLayerName As System.Windows.Forms.Label
    Friend WithEvents clhName As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbColorStyle As System.Windows.Forms.ComboBox
End Class
