<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome2))
        Me.boxProfile = New System.Windows.Forms.GroupBox()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnRaceCar = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnDuelArena = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Tweet = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.picTie = New System.Windows.Forms.PictureBox()
        Me.picLose = New System.Windows.Forms.PictureBox()
        Me.picWin = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBet = New System.Windows.Forms.TextBox()
        Me.btnPaper = New System.Windows.Forms.Button()
        Me.btnRock = New System.Windows.Forms.Button()
        Me.btnScissors = New System.Windows.Forms.Button()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.boxProfile.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxProfile
        '
        Me.boxProfile.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.Racecar_background
        Me.boxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boxProfile.Controls.Add(Me.lblRank)
        Me.boxProfile.Controls.Add(Me.Label2)
        Me.boxProfile.Controls.Add(Me.Label1)
        Me.boxProfile.Controls.Add(Me.Label19)
        Me.boxProfile.Controls.Add(Me.lblBalance)
        Me.boxProfile.Controls.Add(Me.PictureBox1)
        Me.boxProfile.Controls.Add(Me.Label18)
        Me.boxProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boxProfile.Location = New System.Drawing.Point(614, 149)
        Me.boxProfile.Name = "boxProfile"
        Me.boxProfile.Size = New System.Drawing.Size(561, 204)
        Me.boxProfile.TabIndex = 35
        Me.boxProfile.TabStop = False
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.csgolottoFinal.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(25, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'btnRaceCar
        '
        Me.btnRaceCar.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.RACECARBUTTON2
        Me.btnRaceCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRaceCar.FlatAppearance.BorderSize = 0
        Me.btnRaceCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRaceCar.Location = New System.Drawing.Point(133, 90)
        Me.btnRaceCar.Name = "btnRaceCar"
        Me.btnRaceCar.Size = New System.Drawing.Size(94, 39)
        Me.btnRaceCar.TabIndex = 34
        Me.btnRaceCar.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(12, -1)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(226, 62)
        Me.btnHome.TabIndex = 33
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnDuelArena
        '
        Me.btnDuelArena.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.DUEL_ARENA_BUTTON3
        Me.btnDuelArena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDuelArena.FlatAppearance.BorderSize = 0
        Me.btnDuelArena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuelArena.ForeColor = System.Drawing.Color.Transparent
        Me.btnDuelArena.Location = New System.Drawing.Point(223, 88)
        Me.btnDuelArena.Name = "btnDuelArena"
        Me.btnDuelArena.Size = New System.Drawing.Size(102, 41)
        Me.btnDuelArena.TabIndex = 32
        Me.btnDuelArena.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.xit
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(1406, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 17)
        Me.btnClose.TabIndex = 36
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Tweet
        '
        Me.Tweet.Location = New System.Drawing.Point(1181, 583)
        Me.Tweet.Name = "Tweet"
        Me.Tweet.Size = New System.Drawing.Size(263, 20)
        Me.Tweet.TabIndex = 42
        Me.Tweet.Text = "What's Up?"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(1181, 664)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(263, 20)
        Me.Password.TabIndex = 41
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(1181, 638)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(263, 20)
        Me.Username.TabIndex = 40
        Me.Username.Text = "Username"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1181, 60)
        Me.btnExit.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.ScriptErrorsSuppressed = True
        Me.btnExit.Size = New System.Drawing.Size(274, 469)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Url = New System.Uri("http://whstoday.com/wp-content/uploads/2016/10/csgolotto.html", System.UriKind.Absolute)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1181, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(263, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Tweet us @WestCsgoLotto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'picTie
        '
        Me.picTie.Image = Global.csgolottoFinal.My.Resources.Resources._81bc6d8e8bf24da541a84ef64044d0b0
        Me.picTie.Location = New System.Drawing.Point(650, 623)
        Me.picTie.Name = "picTie"
        Me.picTie.Size = New System.Drawing.Size(155, 74)
        Me.picTie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTie.TabIndex = 54
        Me.picTie.TabStop = False
        Me.picTie.Visible = False
        '
        'picLose
        '
        Me.picLose.Image = CType(resources.GetObject("picLose.Image"), System.Drawing.Image)
        Me.picLose.Location = New System.Drawing.Point(650, 623)
        Me.picLose.Name = "picLose"
        Me.picLose.Size = New System.Drawing.Size(155, 74)
        Me.picLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLose.TabIndex = 53
        Me.picLose.TabStop = False
        Me.picLose.Visible = False
        '
        'picWin
        '
        Me.picWin.Image = CType(resources.GetObject("picWin.Image"), System.Drawing.Image)
        Me.picWin.Location = New System.Drawing.Point(650, 623)
        Me.picWin.Name = "picWin"
        Me.picWin.Size = New System.Drawing.Size(155, 74)
        Me.picWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWin.TabIndex = 52
        Me.picWin.TabStop = False
        Me.picWin.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(643, 570)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Enter Bet:"
        '
        'txtBet
        '
        Me.txtBet.Location = New System.Drawing.Point(732, 574)
        Me.txtBet.Name = "txtBet"
        Me.txtBet.Size = New System.Drawing.Size(73, 20)
        Me.txtBet.TabIndex = 50
        '
        'btnPaper
        '
        Me.btnPaper.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources._37665874_cartoon_cash
        Me.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPaper.Location = New System.Drawing.Point(811, 553)
        Me.btnPaper.Name = "btnPaper"
        Me.btnPaper.Size = New System.Drawing.Size(158, 144)
        Me.btnPaper.TabIndex = 49
        Me.btnPaper.UseVisualStyleBackColor = True
        '
        'btnRock
        '
        Me.btnRock.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.H8SqWsh
        Me.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRock.Location = New System.Drawing.Point(811, 404)
        Me.btnRock.Name = "btnRock"
        Me.btnRock.Size = New System.Drawing.Size(158, 143)
        Me.btnRock.TabIndex = 48
        Me.btnRock.UseVisualStyleBackColor = True
        '
        'btnScissors
        '
        Me.btnScissors.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.scissors
        Me.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScissors.Location = New System.Drawing.Point(647, 404)
        Me.btnScissors.Name = "btnScissors"
        Me.btnScissors.Size = New System.Drawing.Size(158, 143)
        Me.btnScissors.TabIndex = 47
        Me.btnScissors.UseVisualStyleBackColor = True
        '
        'PictureBox16
        '
        Me.PictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(1225, 690)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(130, 125)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 81
        Me.PictureBox16.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1308, 690)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 125)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 82
        Me.PictureBox2.TabStop = False
        '
        'frmHome2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.csgolottoFinal.My.Resources.Resources.csgoLottoFullPage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1453, 801)
        Me.Controls.Add(Me.picTie)
        Me.Controls.Add(Me.picLose)
        Me.Controls.Add(Me.picWin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBet)
        Me.Controls.Add(Me.btnPaper)
        Me.Controls.Add(Me.btnRock)
        Me.Controls.Add(Me.btnScissors)
        Me.Controls.Add(Me.Tweet)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.boxProfile)
        Me.Controls.Add(Me.btnRaceCar)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnDuelArena)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.Name = "frmHome2"
        Me.Text = "frmHome2"
        Me.boxProfile.ResumeLayout(False)
        Me.boxProfile.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boxProfile As System.Windows.Forms.GroupBox
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnRaceCar As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnDuelArena As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Tweet As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.WebBrowser
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents picTie As System.Windows.Forms.PictureBox
    Friend WithEvents picLose As System.Windows.Forms.PictureBox
    Friend WithEvents picWin As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBet As System.Windows.Forms.TextBox
    Friend WithEvents btnPaper As System.Windows.Forms.Button
    Friend WithEvents btnRock As System.Windows.Forms.Button
    Friend WithEvents btnScissors As System.Windows.Forms.Button
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
