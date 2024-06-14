Module Main
    Sub main()
        LoadPlayerData()
        Application.EnableVisualStyles()
        For Each player As Player In getPlayerList()
            Accueil.cmbPlayerNames.Items.Add(player.Name)
        Next
        Application.Run(Accueil)
        SavePlayerData()
        Application.Exit()
    End Sub

End Module
