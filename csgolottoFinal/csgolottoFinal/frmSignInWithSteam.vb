Public Class frmSignInWithSteam
    

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        Me.Close()
        If txtSteamUsername.Text = "John Brosius" Then
            GlobalVariableClass.numBalance = 1000
        End If
        'Display Home form 
        Dim frmHome2 As New frmHome2
        'Modal style 
        frmHome2.ShowDialog()

        'Display Home form 
        'Dim frmHome As New frmHome
        'Modal style 
        'frmHome.ShowDialog()
        'My.Forms.frmHome.boxProfile.Visible = True
        ' My.Forms.frmHome.btnDuelArena.Visible = True
        '  My.Forms.frmHome.boxSignIn.Visible = False
        '  My.Forms.frmHome.btnSignInWithSteam.Visible = False
        '  My.Forms.frmHome.btnRaceCar.Visible = True

       
       
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        
    End Sub

    Private Sub frmSignInWithSteam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set to no text.
        TextBox1.Text = ""
        ' The password character is an asterisk.
        TextBox1.PasswordChar = "*"
        ' The control will allow no more than 14 characters.
        TextBox1.MaxLength = 14
    End Sub
End Class