<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnlineImageDialog
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lviImageList = New System.Windows.Forms.ListView()
        Me.clhName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSearchTerm = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSearchTerm = New System.Windows.Forms.Label()
        Me.lblPoweredBy = New System.Windows.Forms.Label()
        Me.lblCurrentPage = New System.Windows.Forms.Label()
        Me.btnPrevPage = New System.Windows.Forms.Button()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(366, 317)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 32)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(472, 317)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 32)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lviImageList
        '
        Me.lviImageList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lviImageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lviImageList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhName, Me.clhDesc})
        Me.lviImageList.FullRowSelect = True
        Me.lviImageList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lviImageList.HideSelection = False
        Me.lviImageList.Location = New System.Drawing.Point(12, 38)
        Me.lviImageList.MultiSelect = False
        Me.lviImageList.Name = "lviImageList"
        Me.lviImageList.Size = New System.Drawing.Size(560, 273)
        Me.lviImageList.TabIndex = 26
        Me.lviImageList.TileSize = New System.Drawing.Size(265, 65)
        Me.lviImageList.UseCompatibleStateImageBehavior = False
        Me.lviImageList.View = System.Windows.Forms.View.Tile
        '
        'clhName
        '
        Me.clhName.Text = ""
        '
        'clhDesc
        '
        Me.clhDesc.Text = ""
        '
        'txtSearchTerm
        '
        Me.txtSearchTerm.Location = New System.Drawing.Point(82, 12)
        Me.txtSearchTerm.Name = "txtSearchTerm"
        Me.txtSearchTerm.Size = New System.Drawing.Size(295, 20)
        Me.txtSearchTerm.TabIndex = 27
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(383, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(67, 20)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "Go"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSearchTerm
        '
        Me.lblSearchTerm.AutoSize = True
        Me.lblSearchTerm.Location = New System.Drawing.Point(12, 16)
        Me.lblSearchTerm.Name = "lblSearchTerm"
        Me.lblSearchTerm.Size = New System.Drawing.Size(64, 13)
        Me.lblSearchTerm.TabIndex = 29
        Me.lblSearchTerm.Text = "Search term"
        '
        'lblPoweredBy
        '
        Me.lblPoweredBy.AutoSize = True
        Me.lblPoweredBy.Location = New System.Drawing.Point(9, 317)
        Me.lblPoweredBy.Name = "lblPoweredBy"
        Me.lblPoweredBy.Size = New System.Drawing.Size(109, 13)
        Me.lblPoweredBy.TabIndex = 30
        Me.lblPoweredBy.Text = "Powered by Google™"
        '
        'lblCurrentPage
        '
        Me.lblCurrentPage.Enabled = False
        Me.lblCurrentPage.Location = New System.Drawing.Point(489, 12)
        Me.lblCurrentPage.Name = "lblCurrentPage"
        Me.lblCurrentPage.Size = New System.Drawing.Size(50, 20)
        Me.lblCurrentPage.TabIndex = 31
        Me.lblCurrentPage.Text = "Page"
        Me.lblCurrentPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrevPage
        '
        Me.btnPrevPage.Enabled = False
        Me.btnPrevPage.Location = New System.Drawing.Point(456, 12)
        Me.btnPrevPage.Name = "btnPrevPage"
        Me.btnPrevPage.Size = New System.Drawing.Size(27, 20)
        Me.btnPrevPage.TabIndex = 32
        Me.btnPrevPage.Text = "<"
        Me.btnPrevPage.UseVisualStyleBackColor = True
        '
        'btnNextPage
        '
        Me.btnNextPage.Enabled = False
        Me.btnNextPage.Location = New System.Drawing.Point(545, 12)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(27, 20)
        Me.btnNextPage.TabIndex = 33
        Me.btnNextPage.Text = ">"
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Image sizes will not be displayed correctly until added"
        '
        'frmOnlineImageDialog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNextPage)
        Me.Controls.Add(Me.btnPrevPage)
        Me.Controls.Add(Me.lblCurrentPage)
        Me.Controls.Add(Me.lblPoweredBy)
        Me.Controls.Add(Me.lblSearchTerm)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchTerm)
        Me.Controls.Add(Me.lviImageList)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "frmOnlineImageDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online Image Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lviImageList As System.Windows.Forms.ListView
    Friend WithEvents clhName As System.Windows.Forms.ColumnHeader
    Friend WithEvents clhDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSearchTerm As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearchTerm As System.Windows.Forms.Label
    Friend WithEvents lblPoweredBy As System.Windows.Forms.Label
    Friend WithEvents lblCurrentPage As System.Windows.Forms.Label
    Friend WithEvents btnPrevPage As System.Windows.Forms.Button
    Friend WithEvents btnNextPage As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
