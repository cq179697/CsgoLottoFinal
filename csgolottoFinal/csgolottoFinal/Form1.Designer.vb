<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.btnSignInWithSteam = New System.Windows.Forms.Button()
        Me.btnDuelArena = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRaceCar = New System.Windows.Forms.Button()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.boxProfile = New System.Windows.Forms.GroupBox()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.boxSignIn = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Tweet = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.boxProfile.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxSignIn.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSignInWithSteam
        '
        Me.btnSignInWithSteam.BackColor = System.Drawing.Color.Transparent
        Me.btnSignInWithSteam.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.SignInThroughSteam
        Me.btnSignInWithSteam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignInWithSteam.FlatAppearance.BorderSize = 0
        Me.btnSignInWithSteam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignInWithSteam.Location = New System.Drawing.Point(225, 113)
        Me.btnSignInWithSteam.Name = "btnSignInWithSteam"
        Me.btnSignInWithSteam.Size = New System.Drawing.Size(158, 28)
        Me.btnSignInWithSteam.TabIndex = 0
        Me.btnSignInWithSteam.UseVisualStyleBackColor = False
        '
        'btnDuelArena
        '
        Me.btnDuelArena.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.DUEL_ARENA_BUTTON3
        Me.btnDuelArena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDuelArena.FlatAppearance.BorderSize = 0
        Me.btnDuelArena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuelArena.ForeColor = System.Drawing.Color.Transparent
        Me.btnDuelArena.Location = New System.Drawing.Point(223, 92)
        Me.btnDuelArena.Name = "btnDuelArena"
        Me.btnDuelArena.Size = New System.Drawing.Size(102, 41)
        Me.btnDuelArena.TabIndex = 1
        Me.btnDuelArena.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(12, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(226, 62)
        Me.btnHome.TabIndex = 2
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.xit
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(1409, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(35, 17)
        Me.btnExit.TabIndex = 5
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRaceCar
        '
        Me.btnRaceCar.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.RACECARBUTTON2
        Me.btnRaceCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRaceCar.FlatAppearance.BorderSize = 0
        Me.btnRaceCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRaceCar.Location = New System.Drawing.Point(133, 94)
        Me.btnRaceCar.Name = "btnRaceCar"
        Me.btnRaceCar.Size = New System.Drawing.Size(94, 39)
        Me.btnRaceCar.TabIndex = 6
        Me.btnRaceCar.UseVisualStyleBackColor = True
        '
        'lblBalance
        '
        Me.lblBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.White
        Me.lblBalance.Location = New System.Drawing.Point(287, 20)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(86, 24)
        Me.lblBalance.TabIndex = 28
        Me.lblBalance.Text = "100"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(265, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 24)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "$"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(178, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 24)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Balance:"
        '
        'boxProfile
        '
        Me.boxProfile.BackgroundImage = CType(resources.GetObject("boxProfile.BackgroundImage"), System.Drawing.Image)
        Me.boxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxProfile.Controls.Add(Me.lblRank)
        Me.boxProfile.Controls.Add(Me.Label2)
        Me.boxProfile.Controls.Add(Me.Label1)
        Me.boxProfile.Controls.Add(Me.Label19)
        Me.boxProfile.Controls.Add(Me.lblBalance)
        Me.boxProfile.Controls.Add(Me.PictureBox1)
        Me.boxProfile.Controls.Add(Me.Label18)
        Me.boxProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boxProfile.Location = New System.Drawing.Point(614, 153)
        Me.boxProfile.Name = "boxProfile"
        Me.boxProfile.Size = New System.Drawing.Size(537, 189)
        Me.boxProfile.TabIndex = 29
        Me.boxProfile.TabStop = False
        Me.boxProfile.Visible = False
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.BackColor = System.Drawing.Color.Transparent
        Me.lblRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.White
        Me.lblRank.Location = New System.Drawing.Point(238, 81)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(79, 24)
        Me.lblRank.TabIndex = 30
        Me.lblRank.Text = "Silver 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(178, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Rank:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "TmarTn"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'boxSignIn
        '
        Me.boxSignIn.BackColor = System.Drawing.Color.Transparent
        Me.boxSignIn.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.signintwithsteamo
        Me.boxSignIn.Controls.Add(Me.btnSignInWithSteam)
        Me.boxSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boxSignIn.Location = New System.Drawing.Point(594, 136)
        Me.boxSignIn.Name = "boxSignIn"
        Me.boxSignIn.Size = New System.Drawing.Size(557, 206)
        Me.boxSignIn.TabIndex = 31
        Me.boxSignIn.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1223, 622)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Tweet us @WestCsgoLotto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(1157, 73)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(274, 469)
        Me.WebBrowser1.TabIndex = 34
        Me.WebBrowser1.Url = New System.Uri("http://whstoday.com/wp-content/uploads/2016/10/csgolotto.html", System.UriKind.Absolute)
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(1224, 651)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(196, 20)
        Me.Username.TabIndex = 35
        Me.Username.Text = "Username"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(1223, 677)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(197, 20)
        Me.Password.TabIndex = 36
        '
        'Tweet
        '
        Me.Tweet.Location = New System.Drawing.Point(1223, 596)
        Me.Tweet.Name = "Tweet"
        Me.Tweet.Size = New System.Drawing.Size(197, 20)
        Me.Tweet.TabIndex = 37
        Me.Tweet.Text = "What's Up?"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'PictureBox16
        '
        Me.PictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(1224, 693)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(130, 125)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 79
        Me.PictureBox16.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1301, 693)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 125)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1223, 548)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(197, 251)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 81
        Me.PictureBox3.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.csgoLottoFullPage1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1443, 799)
        Me.Controls.Add(Me.Tweet)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.boxSignIn)
        Me.Controls.Add(Me.boxProfile)
        Me.Controls.Add(Me.btnRaceCar)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnDuelArena)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.DoubleBuffered = True
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.boxProfile.ResumeLayout(False)
        Me.boxProfile.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxSignIn.ResumeLayout(False)
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSignInWithSteam As System.Windows.Forms.Button
    Friend WithEvents btnDuelArena As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRaceCar As System.Windows.Forms.Button
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents boxProfile As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxSignIn As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Tweet As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
