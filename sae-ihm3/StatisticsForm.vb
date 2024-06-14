Public Class StatisticsForm

    Private nameShorted As Boolean = True

    Private Sub StatisticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False

        FillListBoxesByName()
        If cmbPlayerNames.Items.Count < Accueil.cmbPlayerNames.Items.Count Then
            For Each player As Player In getPlayerList()
                cmbPlayerNames.Items.Add(player.Name)
            Next
        End If

        cmbPlayerNames.SelectedItem = getCurrentPlayer().Name
        cmbPlayerNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbPlayerNames.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub FillListBoxesByName()
        Dim sortedPlayersByName = getPlayerList().OrderBy(Function(player) player.Name)
        PlayerListBox.Items.Clear()
        TimeListBox.Items.Clear()

        For Each player As Player In sortedPlayersByName
            PlayerListBox.Items.Add(player.Name)
            If player.BestTime = getNoBestTime() Then
                TimeListBox.Items.Add("Non établie")
            Else
                TimeListBox.Items.Add($"{player.BestTime \ 60:00}:{player.BestTime Mod 60:00}")
            End If

        Next
    End Sub

    Private Sub FillListBoxesByTime()
        Dim sortedPlayersByTime = getPlayerList().OrderBy(Function(player) player.BestTime)
        PlayerListBox.Items.Clear()
        TimeListBox.Items.Clear()

        For Each player As Player In sortedPlayersByTime
            PlayerListBox.Items.Add(player.Name)
            If player.BestTime = getNoBestTime() Then
                TimeListBox.Items.Add("Non établie")
            Else
                TimeListBox.Items.Add($"{player.BestTime \ 60:00}:{player.BestTime Mod 60:00}")
            End If
        Next
    End Sub

    Private Sub btnShowStats_Click(sender As Object, e As EventArgs) Handles btnShowStats.Click
        If cmbPlayerNames.SelectedItem IsNot Nothing Then
            Dim playerName As String = cmbPlayerNames.SelectedItem.ToString()

            Dim selectedPlayer As Player = getPlayerList().Find(Function(player) player.Name = playerName)

            Dim bestTime As String
            If selectedPlayer.BestTime = getNoBestTime() Then
                bestTime = "Non établie"
            Else
                bestTime = $"{selectedPlayer.BestTime \ 60:00}:{selectedPlayer.BestTime Mod 60:00}"
            End If

            Dim hours As Integer = selectedPlayer.TotalPlayTime \ 3600
            Dim minu As Integer = selectedPlayer.TotalPlayTime \ 60 - hours * 60
            Dim sec As Integer = selectedPlayer.TotalPlayTime Mod 60

            Dim message As String = $"Statistiques de {selectedPlayer.Name} :" & Environment.NewLine &
                                    $"Meilleur temps : {bestTime}" & Environment.NewLine &
                                    $"Nombre de parties jouées : {selectedPlayer.GamesPlayed}" & Environment.NewLine &
                                    $"Temps de jeu total : {hours:00}:{minu:00}:{sec:00}"


            MsgBox(message, MsgBoxStyle.Information, "Statistiques du joueur")
        Else
            MsgBox("Veuillez sélectionner un joueur.", MsgBoxStyle.Exclamation, "Erreur")
        End If
    End Sub

    Private Sub btnSortByName_Click(sender As Object, e As EventArgs) Handles btnSortByName.Click
        If Not nameShorted Then
            FillListBoxesByName()
            nameShorted = True
        End If
    End Sub


    Private Sub btnSortByTime_Click(sender As Object, e As EventArgs) Handles btnSortByTime.Click
        If nameShorted Then
            FillListBoxesByTime()
            nameShorted = False
        End If
    End Sub

    Private Sub PlayerListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayerListBox.SelectedIndexChanged
        If PlayerListBox.SelectedIndex <> -1 Then
            Dim playerName As String = PlayerListBox.SelectedItem.ToString()
            TimeListBox.SelectedIndex = PlayerListBox.SelectedIndex
            cmbPlayerNames.SelectedItem = playerName
        End If

    End Sub

    Private Sub TimeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimeListBox.SelectedIndexChanged
        If TimeListBox.SelectedIndex <> -1 Then
            PlayerListBox.SelectedIndex = TimeListBox.SelectedIndex
            PlayerListBox.Select()
        End If
    End Sub

    Private Sub StatisticsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Accueil.Show()
    End Sub

    Private Sub cmbPlayerNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerNames.SelectedIndexChanged
        Dim playerName As String = cmbPlayerNames.SelectedItem.ToString()

        PlayerListBox.SelectedItem = playerName
        TimeListBox.SelectedIndex = PlayerListBox.SelectedIndex

    End Sub



    Private Sub cmbPlayerNames_TextChanged(sender As Object, e As KeyPressEventArgs) Handles cmbPlayerNames.KeyPress
        If Not e.KeyChar = ChrW(Keys.Return) Then
            Return
        End If

        Dim playerName As String = cmbPlayerNames.Text.Trim()

        If getPlayerList().Any(Function(player) player.Name = playerName) Then
            PlayerListBox.SelectedItem = playerName
            PlayerListBox.Select()
        End If
    End Sub
End Class
