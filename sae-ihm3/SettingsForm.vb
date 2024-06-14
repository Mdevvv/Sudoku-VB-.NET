Public Class SettingsForm
    Dim inMovement As Boolean = False
    Dim loadFinished As Boolean = False
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Désactiver le redimensionnement de la fenêtre et l'agrandissement
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False

        HScrollBarDiff.Minimum = getMinDiff()
        HScrollBarDiff.Maximum = getMaxDiff()
        HScrollBarDiff.Value = getDiff()
        TextBoxCurrentValue.Text = getDiff().ToString()

        HScrollBarDiff.SmallChange = 1
        HScrollBarDiff.LargeChange = 5
        NumericUpDown1.Value = getTotalTime() \ 60
        loadFinished = True
    End Sub

    Private Sub updateDifficulty(value As Integer)
        setDiff(value)

        HScrollBarDiff.Value = value
        TextBoxCurrentValue.Text = value.ToString()
        inMovement = True
        If value > getMaxDiff() - HScrollBarDiff.LargeChange * 2 Then
            radioHard.Checked = True
        ElseIf value >= getNormalDiff() Then
            radioNormal.Checked = True
        Else
            radioEasy.Checked = True
        End If
        inMovement = False
    End Sub

    Private Sub StatisticsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Fermer le formulaire et revenir au formulaire d'accueil
        Dim mainForm As New Accueil()
        mainForm.Show()
    End Sub

    Private Sub HScrollBarDiff_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarDiff.Scroll
        updateDifficulty(HScrollBarDiff.Value)
    End Sub

    Private Sub LabelCurrentValue_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCurrentValue.TextChanged


        Dim value As Integer
        If Integer.TryParse(TextBoxCurrentValue.Text, value) And value <= getMaxDiff() And value >= getMinDiff() Then
            updateDifficulty(value)
            TextBoxCurrentValue.BackColor = Color.White
        Else
            TextBoxCurrentValue.BackColor = Color.Red
        End If
    End Sub

    Private Sub radioEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radioEasy.CheckedChanged
        If Not inMovement Then
            updateDifficulty(getMinDiff())
        End If

    End Sub

    Private Sub radioNormal_CheckedChanged(sender As Object, e As EventArgs) Handles radioNormal.CheckedChanged
        If Not inMovement Then
            updateDifficulty(getNormalDiff())
        End If
    End Sub

    Private Sub radioHard_CheckedChanged(sender As Object, e As EventArgs) Handles radioHard.CheckedChanged
        If Not inMovement Then
            updateDifficulty(getMaxDiff())
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If loadFinished Then
            If NumericUpDown1.Value > getMaxTimeMinute() Then
                NumericUpDown1.Value = getMaxTimeMinute()
            ElseIf NumericUpDown1.Value < getMinTimeMinute() Then
                NumericUpDown1.Value = getMinTimeMinute()
            Else
                setTime(NumericUpDown1.Value)
            End If
        End If

    End Sub

    Private Sub NumericUpDown1_Text(sender As Object, e As EventArgs) Handles NumericUpDown1.TextChanged
        If NumericUpDown1.Value > getMaxTimeMinute() Then
            NumericUpDown1.Value = getMaxTimeMinute()
        ElseIf NumericUpDown1.Value < getMinTimeMinute() Then
            NumericUpDown1.Value = getMinTimeMinute()
        End If
    End Sub
End Class