Module Settings
    Dim totalTime As Integer = 7 * 60
    Dim difficulty As Integer = 50

    Dim minDiff As Integer = 40
    Dim maxDiff As Integer = 75
    Dim normalDiff As Integer = 55

    Dim maxTimeMinute As Integer = 59
    Dim minTimeMinute As Integer = 1

    Function getTotalTime() As Integer
        Return totalTime
    End Function

    Function getDiff() As Integer
        Return difficulty
    End Function

    Function getMinDiff() As Integer
        Return minDiff
    End Function

    Function getNormalDiff() As Integer
        Return normalDiff
    End Function

    Function getMaxDiff() As Integer
        Return maxDiff
    End Function

    Sub setDiff(diff As Integer)
        difficulty = diff
    End Sub

    Sub setTime(m As Integer)
        totalTime = m * 60
    End Sub

    Function getMaxTimeMinute() As Integer
        Return maxTimeMinute
    End Function

    Function getMinTimeMinute() As Integer
        Return minTimeMinute
    End Function

    Function getNoBestTime() As Integer
        Return (maxTimeMinute + 1) * 60
    End Function

End Module
