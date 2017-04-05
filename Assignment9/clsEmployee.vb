Public Class clsEmployee
    Public strName As String
    Public intId As Integer
    Public dblPay As Double
    Public intHours(7) As Integer

    Public Sub New(_Name As String, _Id As Integer, _Pay As Double, _Hours() As Integer)
        strName = _Name
        intId = _Id
        dblPay = _Pay
        Array.Copy(_Hours, intHours, 7)
    End Sub

    Public Function Hours()
        Dim dblTotal As Integer = 0

        For intI As Integer = 0 To 6
            dblTotal += intHours(intI)
        Next

        Return dblTotal
    End Function

End Class
