<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignInWithSteam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignInWithSteam))
        Me.txtSteamUsername = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSteamUsername
        '
        Me.txtSteamUsername.BackColor = System.Drawing.Color.Gray
        Me.txtSteamUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSteamUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSteamUsername.ForeColor = System.Drawing.Color.White
        Me.txtSteamUsername.Location = New System.Drawing.Point(18, 147)
        Me.txtSteamUsername.Multiline = True
        Me.txtSteamUsername.Name = "txtSteamUsername"
        Me.txtSteamUsername.Size = New System.Drawing.Size(214, 28)
        Me.txtSteamUsername.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(18, 206)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 28)
        Me.TextBox1.TabIndex = 1
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.Transparent
        Me.btnSignIn.FlatAppearance.BorderSize = 0
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Location = New System.Drawing.Point(16, 244)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(109, 41)
        Me.btnSignIn.TabIndex = 2
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'frmSignInWithSteam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(952, 401)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtSteamUsername)
        Me.Name = "frmSignInWithSteam"
        Me.Text = "frmSignInWithSteam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSteamUsername As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSignIn As System.Windows.Forms.Button
End Class
