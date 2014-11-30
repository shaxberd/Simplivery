<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLayerEditDialog
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
        Me.lblLayerName = New System.Windows.Forms.Label()
        Me.lblLayerColor = New System.Windows.Forms.Label()
        Me.pnlLayerColor = New System.Windows.Forms.Panel()
        Me.btnLayerColor = New System.Windows.Forms.Button()
        Me.txtLayerName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.picLayer = New System.Windows.Forms.PictureBox()
        CType(Me.picLayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLayerName
        '
        Me.lblLayerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLayerName.AutoSize = True
        Me.lblLayerName.Location = New System.Drawing.Point(12, 302)
        Me.lblLayerName.Name = "lblLayerName"
        Me.lblLayerName.Size = New System.Drawing.Size(67, 13)
        Me.lblLayerName.TabIndex = 20
        Me.lblLayerName.Text = "Layer Name:"
        '
        'lblLayerColor
        '
        Me.lblLayerColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLayerColor.AutoSize = True
        Me.lblLayerColor.Location = New System.Drawing.Point(336, 302)
        Me.lblLayerColor.Name = "lblLayerColor"
        Me.lblLayerColor.Size = New System.Drawing.Size(63, 13)
        Me.lblLayerColor.TabIndex = 19
        Me.lblLayerColor.Text = "Layer Color:"
        '
        'pnlLayerColor
        '
        Me.pnlLayerColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLayerColor.BackColor = System.Drawing.Color.White
        Me.pnlLayerColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLayerColor.Location = New System.Drawing.Point(405, 298)
        Me.pnlLayerColor.Name = "pnlLayerColor"
        Me.pnlLayerColor.Size = New System.Drawing.Size(94, 20)
        Me.pnlLayerColor.TabIndex = 18
        '
        'btnLayerColor
        '
        Me.btnLayerColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLayerColor.Location = New System.Drawing.Point(505, 298)
        Me.btnLayerColor.Name = "btnLayerColor"
        Me.btnLayerColor.Size = New System.Drawing.Size(67, 20)
        Me.btnLayerColor.TabIndex = 17
        Me.btnLayerColor.Text = "Choose"
        Me.btnLayerColor.UseVisualStyleBackColor = True
        '
        'txtLayerName
        '
        Me.txtLayerName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLayerName.Location = New System.Drawing.Point(85, 298)
        Me.txtLayerName.Name = "txtLayerName"
        Me.txtLayerName.ReadOnly = True
        Me.txtLayerName.Size = New System.Drawing.Size(245, 20)
        Me.txtLayerName.TabIndex = 15
        Me.txtLayerName.Text = "Layer Name"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(366, 324)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(472, 324)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(100, 32)
        Me.btnApply.TabIndex = 13
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'picLayer
        '
        Me.picLayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLayer.BackColor = System.Drawing.Color.White
        Me.picLayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLayer.Location = New System.Drawing.Point(12, 12)
        Me.picLayer.Name = "picLayer"
        Me.picLayer.Size = New System.Drawing.Size(560, 280)
        Me.picLayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLayer.TabIndex = 21
        Me.picLayer.TabStop = False
        '
        'frmLayerEditDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(584, 368)
        Me.Controls.Add(Me.picLayer)
        Me.Controls.Add(Me.lblLayerName)
        Me.Controls.Add(Me.lblLayerColor)
        Me.Controls.Add(Me.pnlLayerColor)
        Me.Controls.Add(Me.btnLayerColor)
        Me.Controls.Add(Me.txtLayerName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 407)
        Me.Name = "frmLayerEditDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit layer:"
        CType(Me.picLayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLayerName As System.Windows.Forms.Label
    Friend WithEvents lblLayerColor As System.Windows.Forms.Label
    Friend WithEvents pnlLayerColor As System.Windows.Forms.Panel
    Friend WithEvents btnLayerColor As System.Windows.Forms.Button
    Friend WithEvents txtLayerName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents picLayer As System.Windows.Forms.PictureBox
End Class
