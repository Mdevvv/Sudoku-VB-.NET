Imports System.Runtime.InteropServices.WindowsRuntime

Module SudokuGrid
    Dim grid(,) As Integer
    Dim solveGrid(,) As Integer
    Dim sx As Integer
    Dim sy As Integer
    Dim nbZero As Integer
    Dim rand As Random
    Dim A As Integer(,) = {{3, 6, 7, 9, 4, 1, 2, 8, 5},
                            {1, 5, 2, 6, 8, 3, 4, 9, 7},
                            {4, 9, 8, 7, 5, 2, 1, 6, 3},
                            {7, 4, 6, 1, 9, 5, 8, 3, 2},
                            {8, 1, 9, 2, 3, 7, 6, 5, 4},
                            {2, 3, 5, 8, 6, 4, 7, 1, 9},
                            {9, 2, 1, 5, 7, 8, 3, 4, 6},
                            {5, 8, 4, 3, 2, 6, 9, 7, 1},
                            {6, 7, 3, 4, 1, 9, 5, 2, 8}
                          }

    Dim B As Integer(,) = {{4, 2, 7, 9, 5, 1, 6, 8, 3},
                            {6, 3, 9, 2, 8, 4, 7, 5, 1},
                            {8, 5, 1, 7, 6, 3, 9, 2, 4},
                            {5, 1, 4, 8, 9, 6, 3, 7, 2},
                            {9, 7, 6, 4, 3, 2, 8, 1, 5},
                            {2, 8, 3, 1, 7, 5, 4, 9, 6},
                            {3, 9, 2, 6, 1, 8, 5, 4, 7},
                            {7, 4, 5, 3, 2, 9, 1, 6, 8},
                            {1, 6, 8, 5, 4, 7, 2, 3, 9}
                          }

    Dim C As Integer(,) = {{9, 8, 5, 1, 3, 2, 4, 7, 6},
                            {2, 7, 3, 9, 4, 6, 5, 1, 8},
                            {4, 1, 6, 5, 7, 8, 9, 2, 3},
                            {1, 6, 7, 4, 8, 9, 2, 3, 5},
                            {8, 5, 2, 6, 1, 3, 7, 9, 4},
                            {3, 9, 4, 2, 5, 7, 8, 6, 1},
                            {7, 4, 1, 3, 9, 5, 6, 8, 2},
                            {5, 2, 9, 8, 6, 1, 3, 4, 7},
                            {6, 3, 8, 7, 2, 4, 1, 5, 9}
                          }

    ' Constructeur pour initialiser la grille avec un grid complet et valide
    Sub sudoku(sizeX As Integer, sizeY As Integer)
        sx = sizeX - 1
        sy = sizeY - 1
        ReDim grid(sx, sy)
        rand = New Random(DateTime.Now.GetHashCode())
        ' Générer une grille grid complète et valide
        Generategrid()
        solveGrid = grid.Clone()
        ReplaceWithZeros(getDiff())
        nbZero = getDiff()
    End Sub

    Sub Generategrid()
        Dim grids As New List(Of Integer(,))
        grids.Add(A)
        grids.Add(B)
        grids.Add(C)

        RandomSudoku(grids)

    End Sub

    Private Sub RandomSudoku(gridOptions As List(Of Integer(,)))
        Dim chosenGrid As Integer(,) = gridOptions(rand.Next(0, gridOptions.Count))

        Dim rotations As Integer = rand.Next(0, 4)
        For i As Integer = 0 To rotations - 1
            chosenGrid = RotateGrid(chosenGrid)
        Next

        grid = chosenGrid
    End Sub


    Private Function RotateGrid(grid As Integer(,)) As Integer(,)
        Dim n As Integer = grid.GetLength(0)
        Dim rotatedGrid(n - 1, n - 1) As Integer

        For i As Integer = 0 To n - 1
            For j As Integer = 0 To n - 1
                rotatedGrid(i, j) = grid(n - j - 1, i)
            Next
        Next

        Return rotatedGrid
    End Function

    Private Sub ReplaceWithZeros(count As Integer)
        While count > 0
            Dim posX As Integer = rand.Next(0, sx + 1)
            Dim posY As Integer = rand.Next(0, sy + 1)
            If Not grid(posX, posY) = 0 Then
                grid(posX, posY) = 0
                count -= 1
            End If
        End While
    End Sub

    Function getGrid() As Integer(,)
        Return grid
    End Function

    Function isValid(x As Integer, y As Integer, text As String) As Boolean
        Dim validBefore As Boolean = Not grid(x, y) = 0
        Dim validAfter As Boolean = trimValid(x, y, text)


        ' Mise à jour du compteur si la validité a changé
        If validBefore AndAlso Not validAfter Then
            nbZero += 1 ' Incrémenter le compteur si la valeur devient invalide
            grid(x, y) = 0
        ElseIf Not validBefore AndAlso validAfter Then
            nbZero -= 1 ' Décrémenter le compteur si la valeur devient valide
        End If

        ' Retourner true si la nouvelle valeur est valide
        Return validAfter

    End Function

    Private Function trimValid(x As Integer, y As Integer, text As String) As Boolean
        text = text.Trim()

        If text = "" Then
            grid(x, y) = 0
            Return True
        End If

        Dim value As Integer

        If Not Integer.TryParse(text, value) Then
            Return False
        End If

        ' Vérifier si la valeur est dans la plage de 1 à 9
        If value < 1 OrElse value > 9 Then
            Return False
        End If

        Return testValid(x, y, value)
    End Function

    Private Function testValid(x As Integer, y As Integer, value As Integer) As Boolean

        ' Vérifier si la valeur n'est pas déjà présente dans la même colonne
        For j As Integer = 0 To sx
            If grid(x, j) = value Then
                Return False
            End If
        Next

        ' Vérifier si la valeur n'est pas déjà présente dans la même ligne
        For i As Integer = 0 To sy
            If grid(i, y) = value Then
                Return False
            End If
        Next

        ' Vérifier si la valeur n'est pas déjà présente dans la même région 3x3
        Dim startX As Integer = (x \ 3) * 3
        Dim startY As Integer = (y \ 3) * 3


        For i As Integer = startX To startX + 2
            For j As Integer = startY To startY + 2
                If grid(i, j) = value Then
                    Return False
                End If
            Next
        Next

        ' Si la valeur passe toutes les vérifications, elle est valide
        grid(x, y) = value
        Return True
    End Function

    Function isSolved() As Boolean
        If nbZero > 0 Then
            Return False
        End If

        For i As Integer = 0 To sx
            For j As Integer = 0 To sy
                ' Si les éléments correspondants ne sont pas égaux, les grilles ne sont pas identiques
                If solveGrid(i, j) <> grid(i, j) Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function
End Module
