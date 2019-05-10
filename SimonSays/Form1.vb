Public Class Form1

    Dim intRand As New Random()
    Dim picIndex As Integer
    Dim intLevel As Integer
    Dim lstSimon As New List(Of Integer)
    Dim playerpick As New List(Of Integer)
    Dim intCount, Simon As Integer
    Dim strFail As Boolean = True
    Dim strButton As Boolean = False
    Dim intScore As Integer = 0

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        intLevel = 1
        intScore = 0
        lblRound.Text = intLevel.ToString()
        lblScore.Text = intScore.ToString()
        lstSimon.Clear()
        strFail = True
        btnStart.Enabled = False

        Do While strFail = True
            playerpick.Clear()
            lblRound.Text = intLevel.ToString()
            Application.DoEvents()
            picIndex = intRand.Next(0, 4)
            lstSimon.Add(picIndex)
            intLevel += 1
            intCount = 0
            Do Until intCount = lstSimon.Count
                Simon = lstSimon.Item(intCount)
                If Simon = 0 Then
                    My.Computer.Audio.Play(My.Resources.Test_Tone_1, AudioPlayMode.Background)
                    picRed.BackColor = Color.Black
                    Application.DoEvents()
                    Threading.Thread.Sleep(300)
                    picRed.BackColor = Color.Red
                End If
                If Simon = 1 Then
                    My.Computer.Audio.Play(My.Resources.Test_tone_2, AudioPlayMode.Background)
                    picYellow.BackColor = Color.Black
                    Application.DoEvents()
                    Threading.Thread.Sleep(300)
                    picYellow.BackColor = Color.Yellow
                End If
                If Simon = 2 Then
                    My.Computer.Audio.Play(My.Resources.test_tone_3, AudioPlayMode.Background)
                    picGreen.BackColor = Color.Black
                    Application.DoEvents()
                    Threading.Thread.Sleep(300)
                    picGreen.BackColor = Color.Green
                End If
                If Simon = 3 Then
                    My.Computer.Audio.Play(My.Resources.test_tone_4, AudioPlayMode.Background)
                    picBlue.BackColor = Color.Black
                    Application.DoEvents()
                    Threading.Thread.Sleep(300)
                    picBlue.BackColor = Color.Blue
                End If
                Application.DoEvents()
                Threading.Thread.Sleep(150)
                intCount += 1
            Loop

            For intCount = 0 To lstSimon.Count - 1
                Do Until strButton = True
                    Application.DoEvents()
                Loop
                strButton = False
                If lstSimon.Item(intCount) = playerpick.Item(intCount) Then
                    intScore += 1
                    lblScore.Text = intScore.ToString()
                    Application.DoEvents()
                Else
                    intCount = lstSimon.Count
                    My.Computer.Audio.Play(My.Resources.End_Game_Fail, AudioPlayMode.Background)
                    strFail = False
                    MessageBox.Show("Whoops! Try Again!")
                    btnStart.Enabled = True
                End If
            Next
        Loop

    End Sub


    Private Sub picRed_MouseDown(sender As Object, e As MouseEventArgs) Handles picRed.MouseDown
        My.Computer.Audio.Play(My.Resources.Test_Tone_1, AudioPlayMode.Background)
        picRed.BackColor = Color.Black
        Application.DoEvents()
    End Sub
    Private Sub picRed_MouseUp(sender As Object, e As MouseEventArgs) Handles picRed.MouseUp
        picRed.BackColor = Color.Red
        Application.DoEvents()
        Threading.Thread.Sleep(150)
        playerpick.Add(0)
        strButton = True
    End Sub
    Private Sub picYellow_MouseDown(sender As Object, e As MouseEventArgs) Handles picYellow.MouseDown
        My.Computer.Audio.Play(My.Resources.Test_tone_2, AudioPlayMode.Background)
        picYellow.BackColor = Color.Black
        Application.DoEvents()
    End Sub
    Private Sub picYellow_MouseUp(sender As Object, e As MouseEventArgs) Handles picYellow.MouseUp
        picYellow.BackColor = Color.Yellow
        Application.DoEvents()
        Threading.Thread.Sleep(150)
        playerpick.Add(1)
        strButton = True
    End Sub
    Private Sub picGreen_MouseDown(sender As Object, e As MouseEventArgs) Handles picGreen.MouseDown
        My.Computer.Audio.Play(My.Resources.test_tone_3, AudioPlayMode.Background)
        picGreen.BackColor = Color.Black
        Application.DoEvents()
    End Sub
    Private Sub picGreen_MouseUp(sender As Object, e As MouseEventArgs) Handles picGreen.MouseUp
        picGreen.BackColor = Color.Green
        Application.DoEvents()
        Threading.Thread.Sleep(150)
        playerpick.Add(2)
        strButton = True
    End Sub
    Private Sub picBlue_MouseDown(sender As Object, e As MouseEventArgs) Handles picBlue.MouseDown
        My.Computer.Audio.Play(My.Resources.test_tone_4, AudioPlayMode.Background)
        picBlue.BackColor = Color.Black
        Application.DoEvents()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub picBlue_MouseUp(sender As Object, e As MouseEventArgs) Handles picBlue.MouseUp
        picBlue.BackColor = Color.Blue
        Application.DoEvents()
        Threading.Thread.Sleep(150)
        playerpick.Add(3)
        strButton = True
    End Sub


End Class
