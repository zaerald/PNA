<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pan = New System.Windows.Forms.Panel()
        Me.btnEye = New System.Windows.Forms.PictureBox()
        Me.panWelcome = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnManagePNA = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnManageUsers = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrAnim = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWelcome = New System.Windows.Forms.Timer(Me.components)
        Me.pan.SuspendLayout()
        CType(Me.btnEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panWelcome.SuspendLayout()
        CType(Me.btnManagePNA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnManageUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.Silver
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(39, 256)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUser.MaxLength = 20
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(257, 33)
        Me.txtUser.TabIndex = 1
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Silver
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(39, 347)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(257, 33)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(39, 415)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(257, 38)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(39, 466)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(257, 38)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pan
        '
        Me.pan.Controls.Add(Me.btnEye)
        Me.pan.Controls.Add(Me.panWelcome)
        Me.pan.Controls.Add(Me.Label4)
        Me.pan.Controls.Add(Me.btnManagePNA)
        Me.pan.Controls.Add(Me.Label5)
        Me.pan.Controls.Add(Me.btnManageUsers)
        Me.pan.Controls.Add(Me.Label3)
        Me.pan.Controls.Add(Me.btnBack)
        Me.pan.Controls.Add(Me.PictureBox1)
        Me.pan.Controls.Add(Me.btnCancel)
        Me.pan.Controls.Add(Me.btnLogin)
        Me.pan.Controls.Add(Me.Label2)
        Me.pan.Controls.Add(Me.txtUser)
        Me.pan.Controls.Add(Me.txtPassword)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Location = New System.Drawing.Point(0, 0)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(684, 520)
        Me.pan.TabIndex = 6
        '
        'btnEye
        '
        Me.btnEye.BackColor = System.Drawing.Color.Silver
        Me.btnEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEye.Image = Global.PNA.My.Resources.Resources.eye
        Me.btnEye.Location = New System.Drawing.Point(259, 351)
        Me.btnEye.Name = "btnEye"
        Me.btnEye.Size = New System.Drawing.Size(33, 27)
        Me.btnEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEye.TabIndex = 12
        Me.btnEye.TabStop = False
        Me.btnEye.Visible = False
        '
        'panWelcome
        '
        Me.panWelcome.Controls.Add(Me.Label6)
        Me.panWelcome.Location = New System.Drawing.Point(350, 0)
        Me.panWelcome.Name = "panWelcome"
        Me.panWelcome.Size = New System.Drawing.Size(331, 520)
        Me.panWelcome.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Niagara Engraved", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(236, 103)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Welcome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(453, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Manage Pn'A"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnManagePNA
        '
        Me.btnManagePNA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManagePNA.Image = CType(resources.GetObject("btnManagePNA.Image"), System.Drawing.Image)
        Me.btnManagePNA.Location = New System.Drawing.Point(456, 298)
        Me.btnManagePNA.Name = "btnManagePNA"
        Me.btnManagePNA.Size = New System.Drawing.Size(125, 125)
        Me.btnManagePNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnManagePNA.TabIndex = 8
        Me.btnManagePNA.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(445, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Manage Users"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManageUsers.Image = Global.PNA.My.Resources.Resources.usermgmt
        Me.btnManageUsers.Location = New System.Drawing.Point(451, 124)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(125, 125)
        Me.btnManageUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnManageUsers.TabIndex = 8
        Me.btnManageUsers.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Niagara Engraved", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 56)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Phonebook n' Address"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = Global.PNA.My.Resources.Resources.btnBackDefault
        Me.btnBack.Location = New System.Drawing.Point(360, 24)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 50)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 6
        Me.btnBack.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PNA.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(92, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'tmrAnim
        '
        Me.tmrAnim.Interval = 3
        '
        'tmrWelcome
        '
        Me.tmrWelcome.Interval = 500
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(334, 521)
        Me.Controls.Add(Me.pan)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        CType(Me.btnEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panWelcome.ResumeLayout(False)
        Me.panWelcome.PerformLayout()
        CType(Me.btnManagePNA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnManageUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents pan As Panel
    Friend WithEvents tmrAnim As Timer
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnManageUsers As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnManagePNA As PictureBox
    Friend WithEvents panWelcome As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tmrWelcome As Timer
    Friend WithEvents btnEye As PictureBox
End Class
