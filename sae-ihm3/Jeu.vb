Public Class Jeu
    Dim gridSize As Integer = 9
    Dim gridTextBox(gridSize - 1, gridSize - 1) As TextBox
    Dim timerSpan As Integer

    Dim timerString As String = "Temps restant : "
    Dim Timer1 As New Timer With {
            .Interval = 1000
            }

    Dim hideBox As GroupBox = New GroupBox With {
            .Width = 460,
            .Height = 460,
            .BackColor = Color.Tomato,
            .Location = New Point(20, 50),
            .Visible = False
        }
    Dim win As Boolean = False

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerSpan = getTotalTime()

        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False

        sudoku(gridSize, gridSize)


        For row As Integer = 0 To gridSize - 1
            For column As Integer = 0 To gridSize - 1
                Dim cases As New TextBox With {
                    .Width = 50,
                    .Height = 50,
                    .Location = New Point(20 + (row * 50), 50 + (column * 50)),
                    .TextAlign = HorizontalAlignment.Center,
                    .Tag = New Point(row, column)
                }

                If (row \ 3 + column \ 3) Mod 2 = 0 Then
                    cases.BackColor = Color.LightGray
                Else
                    cases.BackColor = Color.White
                End If

                If EstCaseInitiale(row, column) Then
                    cases.Text = ObtenirValeurInitiale(row, column).ToString()
                    cases.ReadOnly = True
                    cases.BackColor = Color.LightBlue
                End If

                AddHandler cases.TextChanged, AddressOf TextBox_TextChanged

                gridTextBox(row, column) = cases
                Me.Controls.Add(cases)
            Next
        Next

        lblJoueur.Text = "Joueur: " & getCurrentPlayer().Name
        UpdateTimerString()
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

        addAGameCurrPlayer()

        Me.Controls.Add(hideBox)
        hideBox.BringToFront()
        Timer1.Start()
    End Sub

    Private Sub UpdateTimerString()
        lblTempsRestant.Text = $"{timerString} {timerSpan \ 60:00}:{timerSpan Mod 60:00}"
    End Sub

    Private Function EstCaseInitiale(row As Integer, column As Integer) As Boolean
        Return ObtenirValeurInitiale(row, column) > 0
    End Function

    Private Function ObtenirValeurInitiale(row As Integer, column As Integer) As Integer
        Return getGrid()(row, column)
    End Function

    Private Sub btnAbandonner_Click_1(sender As Object, e As EventArgs) Handles btnAbandonner.Click
        If MsgBox("Voulez-vous vraiment quitter l'application ?", MsgBoxStyle.YesNo, "Abandonner ?") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Jeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        SavePlayerData()

        If win Then
            StatisticsForm.Show()
        Else
            Accueil.Show()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        timerSpan -= 1
        addTimeCurrPlayer(1)
        UpdateTimerString()
        If timerSpan = 0 Then
            Timer1.Stop()
            MsgBox("Dommage, vous y êtiez presque mais vous n'avez pas eu le temps de finir !", MsgBoxStyle.Critical, "Vous avez perdu !")
            Me.Close()
        End If
    End Sub


    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim currCase As TextBox = CType(sender, TextBox)
        Dim coordinates As Point = CType(currCase.Tag, Point)
        Dim row As Integer = coordinates.X
        Dim column As Integer = coordinates.Y

        If Not isValid(row, column, currCase.Text) Then
            currCase.BackColor = Color.Red
        Else
            If (row \ 3 + column \ 3) Mod 2 = 0 Then
                currCase.BackColor = Color.LightGray
            Else
                currCase.BackColor = Color.White
            End If

            If isSolved() Then
                Timer1.Stop()
                Dim time As Integer = getTotalTime() - timerSpan
                updatePlayerBestTime(time)
                MsgBox($"Vous avez réussi en {time \ 60:00} minute(s) {time Mod 60:00} seconde(s)", MsgBoxStyle.Information, "Félicitation !")
                win = True
                Me.Close()
            End If
        End If


    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        Timer1.Stop()
        hideBox.Visible = True
        btnPause.Visible = False


        If MsgBox("Voulez-vous reprendre votre partie ?", MsgBoxStyle.YesNo, "Pause") = MsgBoxResult.Yes Then
            Timer1.Start()
            hideBox.Visible = False
            btnPause.Visible = True
        Else
            Me.Close()
        End If
    End Sub
End Class
