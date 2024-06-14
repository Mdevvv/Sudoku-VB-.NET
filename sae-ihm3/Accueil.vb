Public Class Accueil


    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        If getCurrentPlayerId() > -1 Then
            cmbPlayerNames.Text = getCurrentPlayer().Name
        End If

        cmbPlayerNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbPlayerNames.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub cmbPlayerNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerNames.SelectedIndexChanged
        selectPlayer(cmbPlayerNames.SelectedItem.ToString)
    End Sub


    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Dim playerName As String = cmbPlayerNames.Text.Trim()
        If playerName <> "" Then
            If Not getPlayerNames().Contains(playerName) Then
                addNewPlayer(playerName)
                cmbPlayerNames.Items.Add(playerName)
            Else
                selectPlayer(playerName)
            End If


            Jeu.Show()

            Me.Hide()
        Else
            MsgBox("Veuillez sélectionner ou saisir un nom de joueur.", MsgBoxStyle.Critical, "Erreur")
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        If MsgBox("Voulez-vous vraiment quitter l'application ?", MsgBoxStyle.YesNo, "Quitter ?") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click

        Me.Hide()
        StatisticsForm.cmbPlayerNames.Text = cmbPlayerNames.Text
        StatisticsForm.Show()


    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        SettingsForm.Show()

        Me.Hide()
    End Sub
End Class
