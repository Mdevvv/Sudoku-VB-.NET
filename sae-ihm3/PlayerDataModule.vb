Imports System.IO

Module PlayerDataModule

    Structure Player
        Dim Name As String
        Dim BestTime As Integer
        Dim GamesPlayed As Integer
        Dim TotalPlayTime As Integer

    End Structure


    Dim playerList As New List(Of Player)
    Dim idCurrPlayer As Integer = -1

    Function getPlayerNames() As List(Of String)
        Dim res As New List(Of String)
        For Each player As Player In playerList
            res.Add(player.Name)
        Next
        Return res
    End Function

    Sub addNewPlayer(playerName As String)
        Dim np As Player

        np.Name = playerName
        np.BestTime = getNoBestTime()
        np.GamesPlayed = 0
        np.TotalPlayTime = 0

        playerList.Add(np)
        idCurrPlayer = playerList.Count - 1
        SavePlayerData()
    End Sub

    Sub selectPlayer(playerName As String)
        For i As Integer = playerList.Count - 1 To 0 Step -1
            If (playerName = playerList(i).Name) Then
                idCurrPlayer = i
                i = 0
            End If
        Next
    End Sub

    Sub addTimeCurrPlayer(seconds As Integer)
        Dim np As Player
        np = playerList(idCurrPlayer)

        np.TotalPlayTime = playerList(idCurrPlayer).TotalPlayTime + seconds

        playerList(idCurrPlayer) = np

        'playerList(idCurrPlayer).TotalPlayTime += TimeSpan.FromSeconds(seconds)
    End Sub

    Public Sub addAGameCurrPlayer()

        Dim np As Player
        np = playerList(idCurrPlayer)
        np.GamesPlayed = playerList(idCurrPlayer).GamesPlayed + 1

        playerList(idCurrPlayer) = np

        'playerList(idCurrPlayer).GamesPlayed += 1
    End Sub

    ' Chargement des données des joueurs depuis un fichier
    Sub LoadPlayerData()
        playerList.Clear()
        playerList = LoadPlayer()
    End Sub

    Private Function LoadPlayer() As List(Of Player)
        Dim pl As New List(Of Player)
        If File.Exists("player_data.txt") Then
            Using sr As New StreamReader("player_data.txt")
                While Not sr.EndOfStream
                    Dim line As String = sr.ReadLine()
                    Dim parts() As String = line.Split(","c)
                    Dim player As New Player With {
                        .Name = parts(0),
                        .BestTime = Integer.Parse(parts(1)),
                        .GamesPlayed = Integer.Parse(parts(2)),
                        .TotalPlayTime = Integer.Parse(parts(3))
                    }

                    pl.Add(player)
                End While
            End Using
        End If

        Return pl
    End Function

    ' Enregistrement des données des joueurs dans un fichier
    Sub SavePlayerData()
        Using sw As New StreamWriter("player_data.txt")
            For Each player As Player In playerList
                sw.WriteLine($"{player.Name},{player.BestTime},{player.GamesPlayed},{player.TotalPlayTime}")
            Next
        End Using
    End Sub

    Sub updatePlayerBestTime(timespan As Integer)

        If timespan < getCurrentPlayer().BestTime Then
            Dim np As Player
            np = playerList(idCurrPlayer)
            np.BestTime = timespan

            playerList(idCurrPlayer) = np
        End If
    End Sub

    Function getCurrentPlayer() As Player
        If idCurrPlayer > -1 Then
            Return playerList(idCurrPlayer)
        Else
            Return Nothing
        End If

    End Function

    Function getCurrentPlayerId() As Integer
        Return idCurrPlayer
    End Function



    Function getPlayerList() As List(Of Player)
        Return playerList
    End Function

End Module
