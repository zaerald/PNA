<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSearchPNA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboSearch
        '
        Me.cboSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"ID", "Last Name", "First Name", "Phone Number", "Street", "City", "Last Name Like", "First Name Like", "Phone Number Like"})
        Me.cboSearch.Location = New System.Drawing.Point(16, 61)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(161, 29)
        Me.cboSearch.TabIndex = 15
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.White
        Me.txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.ForeColor = System.Drawing.Color.Black
        Me.txt.Location = New System.Drawing.Point(185, 61)
        Me.txt.Margin = New System.Windows.Forms.Padding(5)
        Me.txt.MaxLength = 20
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(257, 29)
        Me.txt.TabIndex = 14
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.ForeColor = System.Drawing.Color.White
        Me.lblAdd.Location = New System.Drawing.Point(12, 20)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(100, 25)
        Me.lblAdd.TabIndex = 13
        Me.lblAdd.Text = "Search By:"
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(357, 109)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 38)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(266, 109)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 38)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dlgSearchPNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(456, 172)
        Me.Controls.Add(Me.cboSearch)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "dlgSearchPNA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search PNA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents txt As TextBox
    Friend WithEvents lblAdd As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSearch As Button
End Class
