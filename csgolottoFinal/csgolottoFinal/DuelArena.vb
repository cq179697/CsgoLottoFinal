Imports System.Net
Public Class frmDuelArena
    Dim pswaHeight As Object
    Dim pswaWidth As Object
    Dim pswaHeightInt As Integer
    Dim pswaWidthInt As Integer
    Dim wbWidth As Integer
    Dim wbHeight As Integer
    'WEB BROWSER


    Private Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
        'WEB BROWSER
    End Enum

    Private Enum execOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
        'WEB BROWSER 
    End Enum
    Dim numBalance = GlobalVariableClass.numBalance


    Public Sub ContinueInit(ByVal input As String)

        Me.lblBalance.Text = GlobalVariableClass.numBalance
    End Sub

    Private Sub DuelArena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBalance.Text = GlobalVariableClass.numBalance
        'lblBalance.Text = numBalance

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        If GlobalVariableClass.numBalance <= 100 Then
            lblRank.Text = "Silver 1"
        ElseIf GlobalVariableClass.numBalance <= 150 Then
            lblRank.Text = "Silver 2"
        ElseIf GlobalVariableClass.numBalance <= 200 Then
            lblRank.Text = "Silver 3"
        ElseIf GlobalVariableClass.numBalance <= 250 Then
            lblRank.Text = "Silver 4"
        ElseIf GlobalVariableClass.numBalance <= 300 Then
            lblRank.Text = "Silver Elite"
        ElseIf GlobalVariableClass.numBalance <= 350 Then
            lblRank.Text = "Silver Elite Master"
        ElseIf GlobalVariableClass.numBalance <= 400 Then
            lblRank.Text = "Gold Nova 1"
        ElseIf GlobalVariableClass.numBalance <= 450 Then
            lblRank.Text = "Gold Nova 2"
        ElseIf GlobalVariableClass.numBalance <= 500 Then
            lblRank.Text = "Gold Nova 3"
        ElseIf GlobalVariableClass.numBalance <= 550 Then
            lblRank.Text = "Gold Nova Master"
        ElseIf GlobalVariableClass.numBalance <= 600 Then
            lblRank.Text = "Master Guardian 1"
        ElseIf GlobalVariableClass.numBalance <= 650 Then
            lblRank.Text = "Master Guardian 2"
        ElseIf GlobalVariableClass.numBalance <= 700 Then
            lblRank.Text = "Master Guardian Elite"
        ElseIf GlobalVariableClass.numBalance <= 750 Then
            lblRank.Text = "Distinguished Master Guardian"
        ElseIf GlobalVariableClass.numBalance <= 800 Then
            lblRank.Text = "Legendary Eagle"
        ElseIf GlobalVariableClass.numBalance <= 850 Then
            lblRank.Text = "Legendary Eagle Master"
        ElseIf GlobalVariableClass.numBalance <= 900 Then
            lblRank.Text = "Supreme Master First Class"
        ElseIf GlobalVariableClass.numBalance <= 2000 Then
            lblRank.Text = "The Global Elite"
        End If

        pswaHeight = Screen.PrimaryScreen.WorkingArea.Height
        pswaWidth = Screen.PrimaryScreen.WorkingArea.Width
        pswaHeightInt = CInt(pswaHeight)
        pswaWidthInt = CInt(pswaWidth)

        btnExit.Navigate("https://twitter.com/WestCsgoLotto/with_replies")
        'Navigate to this website
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles btnExit.DocumentCompleted
        Timer1.Interval = 1
        Timer2.Interval = 1
        Timer1.Start()
        'Timer Counter for Web Browser
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If btnExit.Width > Math.Round(pswaWidthInt / 20.0) And btnExit.Width < Math.Round(pswaWidthInt / 7.76) Or btnExit.Height > Math.Round(pswaHeightInt / 20.0) And btnExit.Height < Math.Round(pswaHeightInt / 4.44) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 10, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 7.76) And btnExit.Width < Math.Round(pswaWidthInt / 5.42) Or btnExit.Height > Math.Round(pswaHeightInt / 4.44) And btnExit.Height < Math.Round(pswaHeightInt / 3.64) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 20, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 5.42) And btnExit.Width < Math.Round(pswaWidthInt / 3.87) Or btnExit.Height > Math.Round(pswaHeightInt / 3.64) And btnExit.Height < Math.Round(pswaHeightInt / 2.84) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 30, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 3.87) And btnExit.Width < Math.Round(pswaWidthInt / 2.97) Or btnExit.Height > Math.Round(pswaHeightInt / 2.84) And btnExit.Height < Math.Round(pswaHeightInt / 2.4) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 40, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 2.97) And btnExit.Width < Math.Round(pswaWidthInt / 2.58) Or btnExit.Height > Math.Round(pswaHeightInt / 2.4) And btnExit.Height < Math.Round(pswaHeightInt / 2.13) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 50, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 2.58) And btnExit.Width < Math.Round(pswaWidthInt / 2.23) Or btnExit.Height > Math.Round(pswaHeightInt / 2.13) And btnExit.Height < Math.Round(pswaHeightInt / 1.85) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 60, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 2.23) And btnExit.Width < Math.Round(pswaWidthInt / 1.89) Or btnExit.Height > Math.Round(pswaHeightInt / 1.85) And btnExit.Height < Math.Round(pswaHeightInt / 1.64) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 70, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 1.89) And btnExit.Width < Math.Round(pswaWidthInt / 1.6) Or btnExit.Height > Math.Round(pswaHeightInt / 1.64) And btnExit.Height < Math.Round(pswaHeightInt / 1.53) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 1.6) And btnExit.Width < Math.Round(pswaWidthInt / 1.2) Or btnExit.Height > Math.Round(pswaHeightInt / 1.53) And btnExit.Height < Math.Round(pswaHeightInt / 1.16) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 90, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If btnExit.Width > Math.Round(pswaWidthInt / 1.2) AndAlso btnExit.Height > Math.Round(pswaHeightInt / 1.16) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.btnExit.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 100, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = btnExit.Width
            wbHeight = btnExit.Height
            Timer2.Start()
            Timer1.Stop()
        End If
        'WEB BROWSER SIZING CODE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If btnExit.Height <> wbHeight AndAlso btnExit.Width <> wbWidth Then
            Timer1.Start()
            Timer2.Stop()
        End If
        'Timer systmem for WebBrowser
    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'Display Home2 form 
        Dim frmHome2 As New frmHome2
        'Modal style 
        frmHome2.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnRacecar_Click(sender As Object, e As EventArgs) Handles btnRacecar.Click
        'Display Racecar form 
        Dim frmRacecar As New frmRaceCar
        'Modal style 
        frmRacecar.ShowDialog()
    End Sub

    Private Sub btnHahn_Click(sender As Object, e As EventArgs) Handles btnHahn.Click
        GlobalVariableClass.txtBet = 13.37
        'Display Duel arena form 
        Dim frmCoinflip As New frmCoinflip
        'Modal style 
        frmCoinflip.ShowDialog()

    End Sub

    Private Sub btnDegeeter_Click(sender As Object, e As EventArgs) Handles btnDegeeter.Click
        GlobalVariableClass.txtBet = 17.38
        'Display Duel arena form 
        Dim frmCoinflip As New frmCoinflip
        'Modal style 
        frmCoinflip.ShowDialog()

    End Sub

    Private Sub btnWiepert_Click(sender As Object, e As EventArgs) Handles btnWiepert.Click
        GlobalVariableClass.txtBet = 2.12
        'Display Duel arena form 
        Dim frmCoinflip As New frmCoinflip
        'Modal style 
        frmCoinflip.ShowDialog()

    End Sub

    Private Sub btnBrosius_Click(sender As Object, e As EventArgs) Handles btnBrosius.Click
        GlobalVariableClass.txtBet = 14.86
        'Display Duel arena form 
        Dim frmCoinflip As New frmCoinflip
        'Modal style 
        frmCoinflip.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnHome2.Click
        My.Forms.frmHome.boxProfile.Visible = True

        'Display Duel arena form 
        Dim frmHome2 As New frmHome2
        'Modal style 
        frmHome2.ShowDialog()

    End Sub
End Class