<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgContact
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(348, 240)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 38)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(257, 240)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(85, 38)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtLast
        '
        Me.txtLast.BackColor = System.Drawing.Color.White
        Me.txtLast.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.ForeColor = System.Drawing.Color.Black
        Me.txtLast.Location = New System.Drawing.Point(128, 32)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLast.MaxLength = 20
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(305, 29)
        Me.txtLast.TabIndex = 7
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.ForeColor = System.Drawing.Color.White
        Me.lblAdd.Location = New System.Drawing.Point(13, 35)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(108, 25)
        Me.lblAdd.TabIndex = 6
        Me.lblAdd.Text = "Last Name:"
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFirst
        '
        Me.txtFirst.BackColor = System.Drawing.Color.White
        Me.txtFirst.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.ForeColor = System.Drawing.Color.Black
        Me.txtFirst.Location = New System.Drawing.Point(128, 71)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFirst.MaxLength = 20
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(305, 29)
        Me.txtFirst.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Phone Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPn
        '
        Me.txtPn.BackColor = System.Drawing.Color.White
        Me.txtPn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPn.ForeColor = System.Drawing.Color.Black
        Me.txtPn.Location = New System.Drawing.Point(169, 110)
        Me.txtPn.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPn.MaxLength = 15
        Me.txtPn.Name = "txtPn"
        Me.txtPn.Size = New System.Drawing.Size(264, 29)
        Me.txtPn.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Street:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSt
        '
        Me.txtSt.BackColor = System.Drawing.Color.White
        Me.txtSt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSt.ForeColor = System.Drawing.Color.Black
        Me.txtSt.Location = New System.Drawing.Point(83, 149)
        Me.txtSt.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSt.MaxLength = 30
        Me.txtSt.Name = "txtSt"
        Me.txtSt.Size = New System.Drawing.Size(350, 29)
        Me.txtSt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "City:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.Color.Black
        Me.txtCity.Location = New System.Drawing.Point(83, 188)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCity.MaxLength = 30
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(350, 29)
        Me.txtCity.TabIndex = 7
        '
        'dlgContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(458, 298)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtSt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "dlgContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents txtLast As TextBox
    Friend WithEvents lblAdd As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCity As TextBox
End Class
