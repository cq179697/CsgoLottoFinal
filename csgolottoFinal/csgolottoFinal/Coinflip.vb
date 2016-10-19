Public Class frmCoinflip
    Public Sub ContinueInit(ByVal input As String)

        Me.lblBalance.Text = GlobalVariableClass.numBalance
    End Sub
    Private Sub Coinflip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBalance.Text = GlobalVariableClass.numBalance
        txtBet.Text = GlobalVariableClass.txtBet
        'lblBalance.Text = numBalance
    End Sub
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        picHeads.Visible = True
        picTails.Visible = True


    End Sub

    Private Sub picHeads_Click(sender As Object, e As EventArgs) Handles picHeads.Click
        lblBalance.Text = GlobalVariableClass.numBalance
        Dim numBet As Double
        Dim roll As Integer
        roll = roll + 1

        numBet = GlobalVariableClass.txtBet
        'numBalance = CDbl(lblBalance.Text)
        picHeads.Visible = False
        picTails.Visible = False

        Dim intSideUp As Integer ' To indicate which side is up 
        Dim rand As New Random ' Random number generator 

        ' Get a random number in the range of 0 and 1 
        ' 0 means tails up, and 1 means heads up 
        intSideUp = rand.Next(2)

        ' Display the side that is up 
        If intSideUp = 0 Then
            ' 0 means tails up, so display the tails 
            ' image and hide the tails image

            picTails.Visible = True
            picHeads.Visible = False

            lblBalance.Text = (GlobalVariableClass.numBalance - numBet)
            GlobalVariableClass.numBalance = lblBalance.Text
        Else
            ' 1 means heads up, so display the heads 
            ' image and hide the tails image

            picHeads.Visible = True
            picTails.Visible = False


            lblBalance.Text = (GlobalVariableClass.numBalance + numBet)
            GlobalVariableClass.numBalance = lblBalance.Text

        End If

        If GlobalVariableClass.numBalance < 0 Then
            'MessageBox.Show("Game over due to no money left")
            Application.Exit()


        End If

    End Sub

    Private Sub picTails_Click(sender As Object, e As EventArgs) Handles picTails.Click
        lblBalance.Text = GlobalVariableClass.numBalance
        Dim numBet As Double
        Dim roll As Integer
        roll = roll + 1

        numBet = GlobalVariableClass.txtBet
        'numBalance = CDbl(lblBalance.Text)
        picHeads.Visible = False
        picTails.Visible = False

        Dim intSideUp As Integer ' To indicate which side is up 
        Dim rand As New Random ' Random number generator 

        ' Get a random number in the range of 0 and 1 
        ' 0 means tails up, and 1 means heads up 
        intSideUp = rand.Next(2)

        ' Display the side that is up 
        If intSideUp = 0 Then
            ' 0 means tails up, so display the tails 
            ' image and hide the tails image

            picTails.Visible = False
            picHeads.Visible = True

            lblBalance.Text = (GlobalVariableClass.numBalance - numBet)
            GlobalVariableClass.numBalance = lblBalance.Text
        Else
            ' 1 means heads up, so display the heads 
            ' image and hide the tails image

            picHeads.Visible = False
            picTails.Visible = True


            lblBalance.Text = (GlobalVariableClass.numBalance + numBet)
            GlobalVariableClass.numBalance = lblBalance.Text

        End If

        If GlobalVariableClass.numBalance < 0 Then
            Application.Exit()

            'MessageBox.Show("Game over due to no money left")
        End If
        

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
        My.Forms.frmDuelArena.Close()
        'Display Duel arena form 
        Dim frmDuelArena As New frmDuelArena
        'Modal style 
        frmDuelArena.ShowDialog()
    End Sub
End Class