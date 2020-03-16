Public Class Form1
    Dim x As DialogResult
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If turn.Text = "X" Then
            btn1.Text = "X"
            turn.Text = "0"
        Else
            btn1.Text = "0"
            turn.Text = "X"
        End If
        btn1.Enabled = False
        winx()
        win0()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If turn.Text = "X" Then
            btn2.Text = "X"
            turn.Text = "0"
        Else
            btn2.Text = "0"
            turn.Text = "X"
        End If
        btn2.Enabled = False
        winx()
        win0()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If turn.Text = "X" Then
            btn3.Text = "X"
            turn.Text = "0"
        Else
            btn3.Text = "0"
            turn.Text = "X"
        End If
        btn3.Enabled = False
        winx()
        win0()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If turn.Text = "X" Then
            btn4.Text = "X"
            turn.Text = "0"
        Else
            btn4.Text = "0"
            turn.Text = "X"
        End If
        btn4.Enabled = False
        winx()
        win0()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If turn.Text = "X" Then
            btn5.Text = "X"
            turn.Text = "0"
        Else
            btn5.Text = "0"
            turn.Text = "X"
        End If
        btn5.Enabled = False
        winx()
        win0()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If turn.Text = "X" Then
            btn6.Text = "X"
            turn.Text = "0"
        Else
            btn6.Text = "0"
            turn.Text = "X"
        End If
        btn6.Enabled = False
        winx()
        win0()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If turn.Text = "X" Then
            btn7.Text = "X"
            turn.Text = "0"
        Else
            btn7.Text = "0"
            turn.Text = "X"
        End If
        btn7.Enabled = False
        winx()
        win0()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If turn.Text = "X" Then
            btn8.Text = "X"
            turn.Text = "0"
        Else
            btn8.Text = "0"
            turn.Text = "X"
        End If
        btn8.Enabled = False
        winx()
        win0()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If turn.Text = "X" Then
            btn9.Text = "X"
            turn.Text = "0"
        Else
            btn9.Text = "0"
            turn.Text = "X"
        End If
        btn9.Enabled = False
        winx()
        win0()
    End Sub
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If btn1.Text <> "" And btn2.Text <> "" And btn3.Text <> "" And btn4.Text <> "" And btn5.Text <> "" And btn6.Text <> "" And btn7.Text <> "" And btn8.Text <> "" And btn9.Text <> "" Then
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            game_1.Enabled = True
        End If
    End Sub
    Private Sub game_1_Click(sender As Object, e As EventArgs) Handles game_1.Click
        btn1.BackColor = Color.White
        btn2.BackColor = Color.White
        btn3.BackColor = Color.White
        btn4.BackColor = Color.White
        btn5.BackColor = Color.White
        btn6.BackColor = Color.White
        btn7.BackColor = Color.White
        btn8.BackColor = Color.White
        btn9.BackColor = Color.White
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        game_1.Enabled = False
        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""
        turn.Show()
        Label1.Show()
        Label3.Show()
        game.Hide()
    End Sub

    Public Sub winx()
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then

            btn1.BackColor = Color.LightGreen
            btn2.BackColor = Color.LightGreen
            btn3.BackColor = Color.LightGreen
            x = MsgBox("Player X is Winner ", MsgBoxStyle.Information, "Win")
            scoreX.Text = Val(scoreX.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            btn4.BackColor = Color.LightGreen
            btn5.BackColor = Color.LightGreen
            btn6.BackColor = Color.LightGreen
            x = MsgBox("Player X is Winner ", MsgBoxStyle.Information, "Win")
            scoreX.Text = Val(scoreX.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            btn7.BackColor = Color.LightGreen
            btn8.BackColor = Color.LightGreen
            btn9.BackColor = Color.LightGreen
            x = MsgBox("Player X is Winner ", MsgBoxStyle.Information, "Win")
            scoreX.Text = Val(scoreX.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            btn1.BackColor = Color.LightGreen
            btn4.BackColor = Color.LightGreen
            btn7.BackColor = Color.LightGreen
            x = MsgBox("Player X is Winner ", MsgBoxStyle.Information, "Win")
            scoreX.Text = Val(scoreX.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            btn2.BackColor = Color.LightGreen
            btn5.BackColor = Color.LightGreen
            btn8.BackColor = Color.LightGreen
            x = MsgBox("Player X is Winner ", MsgBoxStyle.Information, "Win")
            scoreX.Text = Val(scoreX.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            btn3.BackColor = Color.LightGreen
            btn6.BackColor = Color.LightGreen
            btn9.BackColor = Color.LightGreen
            x = MsgBox("Player X is Winner ", MsgBoxStyle.Information, "Win")
            scoreX.Text = Val(scoreX.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            btn1.BackColor = Color.LightGreen
            btn5.BackColor = Color.LightGreen
            btn9.BackColor = Color.LightGreen
            x = MsgBox("Player X is Winner ", MsgBoxStyle.Information, "Win")
            scoreX.Text = Val(scoreX.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            btn3.BackColor = Color.LightGreen
            btn5.BackColor = Color.LightGreen
            btn7.BackColor = Color.LightGreen
            x = MsgBox("Player X is Winner ", MsgBoxStyle.Information, "Win")
            scoreX.Text = Val(scoreX.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
    End Sub
    Public Sub win0()
        If btn1.Text = "0" And btn2.Text = "0" And btn3.Text = "0" Then
            btn1.BackColor = Color.LightGreen
            btn2.BackColor = Color.LightGreen
            btn3.BackColor = Color.LightGreen

            x = MsgBox("Player 0 is Winner ", MsgBoxStyle.Information, "Win")
            score0.Text = Val(score0.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn4.Text = "0" And btn5.Text = "0" And btn6.Text = "0" Then
            btn4.BackColor = Color.LightGreen
            btn5.BackColor = Color.LightGreen
            btn6.BackColor = Color.LightGreen
            x = MsgBox("Player 0 is Winner ", MsgBoxStyle.Information, "Win")
            score0.Text = Val(score0.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn7.Text = "0" And btn8.Text = "0" And btn9.Text = "0" Then
            btn7.BackColor = Color.LightGreen
            btn8.BackColor = Color.LightGreen
            btn9.BackColor = Color.LightGreen
            x = MsgBox("Player 0 is Winner ", MsgBoxStyle.Information, "Win")
            score0.Text = Val(score0.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn1.Text = "0" And btn4.Text = "0" And btn7.Text = "0" Then
            btn1.BackColor = Color.LightGreen
            btn4.BackColor = Color.LightGreen
            btn7.BackColor = Color.LightGreen
            x = MsgBox("Player 0 is Winner ", MsgBoxStyle.Information, "Win")
            score0.Text = Val(score0.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn2.Text = "0" And btn5.Text = "0" And btn8.Text = "0" Then
            btn2.BackColor = Color.LightGreen
            btn5.BackColor = Color.LightGreen
            btn8.BackColor = Color.LightGreen
            x = MsgBox("Player 0 is Winner ", MsgBoxStyle.Information, "Win")
            score0.Text = Val(score0.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn3.Text = "0" And btn6.Text = "0" And btn9.Text = "0" Then
            btn3.BackColor = Color.LightGreen
            btn6.BackColor = Color.LightGreen
            btn9.BackColor = Color.LightGreen
            x = MsgBox("Player 0 is Winner ", MsgBoxStyle.Information, "Win")
            score0.Text = Val(score0.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn1.Text = "0" And btn5.Text = "0" And btn9.Text = "0" Then
            btn1.BackColor = Color.LightGreen
            btn5.BackColor = Color.LightGreen
            btn9.BackColor = Color.LightGreen
            x = MsgBox("Player 0 is Winner ", MsgBoxStyle.Information, "Win")
            score0.Text = Val(score0.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
        If btn3.Text = "0" And btn5.Text = "0" And btn7.Text = "0" Then
            btn3.BackColor = Color.LightGreen
            btn5.BackColor = Color.LightGreen
            btn7.BackColor = Color.LightGreen
            x = MsgBox("Player 0 is Winner ", MsgBoxStyle.Information, "Win")
            score0.Text = Val(score0.Text) + 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
            turn.Hide()
            Label1.Hide()
            Label3.Hide()
            game.Show()
            If x = Windows.Forms.DialogResult.OK Then
                game_1.Enabled = True
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
