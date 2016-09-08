<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPNA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNA))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.PictureBox()
        Me.btnEdit = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(126, 48)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 10
        Me.dgv.Size = New System.Drawing.Size(551, 483)
        Me.dgv.TabIndex = 1
        '
        'lblAdd
        '
        Me.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.ForeColor = System.Drawing.Color.White
        Me.lblAdd.Location = New System.Drawing.Point(22, 130)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(81, 23)
        Me.lblAdd.TabIndex = 8
        Me.lblAdd.Text = "Add"
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEdit
        '
        Me.lblEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.White
        Me.lblEdit.Location = New System.Drawing.Point(22, 245)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(81, 23)
        Me.lblEdit.TabIndex = 8
        Me.lblEdit.Text = "Edit"
        Me.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDelete
        '
        Me.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.ForeColor = System.Drawing.Color.White
        Me.lblDelete.Location = New System.Drawing.Point(22, 359)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(81, 23)
        Me.lblDelete.TabIndex = 8
        Me.lblDelete.Text = "Delete"
        Me.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearch
        '
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.White
        Me.lblSearch.Location = New System.Drawing.Point(22, 470)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(81, 23)
        Me.lblSearch.TabIndex = 8
        Me.lblSearch.Text = "Search"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Image = Global.PNA.My.Resources.Resources.searchcontact
        Me.btnSearch.Location = New System.Drawing.Point(32, 402)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(65, 65)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Image = Global.PNA.My.Resources.Resources.deletecontact
        Me.btnDelete.Location = New System.Drawing.Point(27, 281)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 75)
        Me.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Image = Global.PNA.My.Resources.Resources.editcontact
        Me.btnEdit.Location = New System.Drawing.Point(27, 167)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 75)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Image = Global.PNA.My.Resources.Resources.addcontact
        Me.btnAdd.Location = New System.Drawing.Point(23, 48)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 80)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Image = Global.PNA.My.Resources.Resources.refresh
        Me.btnRefresh.Location = New System.Drawing.Point(637, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(40, 40)
        Me.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.TabStop = False
        '
        'frmPNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(689, 556)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgv)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPNA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Phonebook n' Address"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnRefresh As PictureBox
    Friend WithEvents lblAdd As Label
    Friend WithEvents btnAdd As PictureBox
    Friend WithEvents lblEdit As Label
    Friend WithEvents btnEdit As PictureBox
    Friend WithEvents lblDelete As Label
    Friend WithEvents btnDelete As PictureBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnSearch As PictureBox
End Class
