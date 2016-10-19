Imports System.Net
Public Class frmHome
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

        lblBalance.Text = GlobalVariableClass.numBalance
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDuelArena.Click
        'Display Duel arena form 
        Dim frmDuelArena As New frmDuelArena
        'Modal style 
        frmDuelArena.ShowDialog()



        Me.Close()

    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'Display Home form 
        Dim frmHome As New frmHome
        'Modal style 
        frmHome.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSignInWithSteam_Click(sender As Object, e As EventArgs) Handles btnSignInWithSteam.Click

        My.Forms.frmDuelArena.Close()
        'Display SignInWithSteam form 
        Dim frmSignInWithSteam As New frmSignInWithSteam
        'Modal style 
        frmSignInWithSteam.ShowDialog()

    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRaceCar_Click(sender As Object, e As EventArgs) Handles btnRaceCar.Click
        'Display Racecar form 
        'Dim frmRaceCar As New frmRaceCar
        'Modal style 
        'frmRaceCar.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblBalance.Text = GlobalVariableClass.numBalance
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        'Fullscreen Mode
        btnDuelArena.Visible = False

        If numBalance <= 100 Then
            lblRank.Text = "Silver 1"
        ElseIf numBalance <= 150 Then
            lblRank.Text = "Silver 2"
        ElseIf numBalance <= 200 Then
            lblRank.Text = "Silver 3"
        ElseIf numBalance <= 250 Then
            lblRank.Text = "Silver 4"
        ElseIf numBalance <= 300 Then
            lblRank.Text = "Silver Elite"
        ElseIf numBalance <= 350 Then
            lblRank.Text = "Silver Elite Master"
        ElseIf numBalance <= 400 Then
            lblRank.Text = "Gold Nova 1"
        ElseIf numBalance <= 450 Then
            lblRank.Text = "Gold Nova 2"
        ElseIf numBalance <= 500 Then
            lblRank.Text = "Gold Nova 3"
        ElseIf numBalance <= 550 Then
            lblRank.Text = "Gold Nova Master"
        ElseIf numBalance <= 600 Then
            lblRank.Text = "Master Guardian 1"
        ElseIf numBalance <= 650 Then
            lblRank.Text = "Master Guardian 2"
        ElseIf numBalance <= 700 Then
            lblRank.Text = "Master Guardian Elite"
        ElseIf numBalance <= 750 Then
            lblRank.Text = "Distinguished Master Guardian"
        ElseIf numBalance <= 800 Then
            lblRank.Text = "Legendary Eagle"
        ElseIf numBalance <= 850 Then
            lblRank.Text = "Legendary Eagle Master"
        ElseIf numBalance <= 900 Then
            lblRank.Text = "Supreme Master First Class"
        ElseIf numBalance <= 2000 Then
            lblRank.Text = "The Global Elite"
        End If

        'RANKING SYSTEM 

        pswaHeight = Screen.PrimaryScreen.WorkingArea.Height
        pswaWidth = Screen.PrimaryScreen.WorkingArea.Width
        pswaHeightInt = CInt(pswaHeight)
        pswaWidthInt = CInt(pswaWidth)

        WebBrowser1.Navigate("https://twitter.com/WestCsgoLotto/with_replies")
        'Navigate to this website
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Timer1.Interval = 1
        Timer2.Interval = 1
        Timer1.Start()
        'Timer Counter for Web Browser
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 20.0) And WebBrowser1.Width < Math.Round(pswaWidthInt / 7.76) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 20.0) And WebBrowser1.Height < Math.Round(pswaHeightInt / 4.44) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 10, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 7.76) And WebBrowser1.Width < Math.Round(pswaWidthInt / 5.42) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 4.44) And WebBrowser1.Height < Math.Round(pswaHeightInt / 3.64) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 20, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 5.42) And WebBrowser1.Width < Math.Round(pswaWidthInt / 3.87) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 3.64) And WebBrowser1.Height < Math.Round(pswaHeightInt / 2.84) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 30, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 3.87) And WebBrowser1.Width < Math.Round(pswaWidthInt / 2.97) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 2.84) And WebBrowser1.Height < Math.Round(pswaHeightInt / 2.4) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 40, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 2.97) And WebBrowser1.Width < Math.Round(pswaWidthInt / 2.58) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 2.4) And WebBrowser1.Height < Math.Round(pswaHeightInt / 2.13) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 50, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 2.58) And WebBrowser1.Width < Math.Round(pswaWidthInt / 2.23) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 2.13) And WebBrowser1.Height < Math.Round(pswaHeightInt / 1.85) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 60, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 2.23) And WebBrowser1.Width < Math.Round(pswaWidthInt / 1.89) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 1.85) And WebBrowser1.Height < Math.Round(pswaHeightInt / 1.64) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 70, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 1.89) And WebBrowser1.Width < Math.Round(pswaWidthInt / 1.6) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 1.64) And WebBrowser1.Height < Math.Round(pswaHeightInt / 1.53) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 80, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 1.6) And WebBrowser1.Width < Math.Round(pswaWidthInt / 1.2) Or WebBrowser1.Height > Math.Round(pswaHeightInt / 1.53) And WebBrowser1.Height < Math.Round(pswaHeightInt / 1.16) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 90, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If

        If WebBrowser1.Width > Math.Round(pswaWidthInt / 1.2) AndAlso WebBrowser1.Height > Math.Round(pswaHeightInt / 1.16) Then
            Try
                Dim Res As Object = Nothing
                Dim MyWeb As Object
                MyWeb = Me.WebBrowser1.ActiveXInstance
                MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, execOpt.OLECMDEXECOPT_PROMPTUSER, 100, IntPtr.Zero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            wbWidth = WebBrowser1.Width
            wbHeight = WebBrowser1.Height
            Timer2.Start()
            Timer1.Stop()
        End If
        'WEB BROWSER SIZING CODE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If WebBrowser1.Height <> wbHeight AndAlso WebBrowser1.Width <> wbWidth Then
            Timer1.Start()
            Timer2.Stop()
        End If
        'Timer systmem for WebBrowser
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Using Twitter As New WebClient
            Twitter.Credentials = New NetworkCredential(Username.Text, Password.Text)
            ServicePointManager.Expect100Continue = False
            Dim MyTweet = System.Text.Encoding.UTF8.GetBytes("status=" & Tweet.Text)
            Try
                MsgBox("Your message has been posted")
                Twitter.UploadData("http://twitter.com/statuses/update.xml", MyTweet)
            Catch ex As Exception
                MsgBox("The message can't be updated, check your username/password.")

            End Try
        End Using
        'Send Twitter tweets. 
    End Sub


    Private Function FetchTwitterFeed(ByVal FeedUrl As String) As Xml.XmlNodeList
        Dim client As New System.Net.WebClient
        'get twitter feed in xml format
        Dim source As String = client.DownloadString(FeedUrl)

        'Check contents format if for reference
        'RichTextBox1.Text = source

        Dim doc As New System.Xml.XmlDocument()
        doc.LoadXml(source)
        'Select all the Items in node list

        Return doc.SelectNodes("//channel/item")

    End Function

End Class
