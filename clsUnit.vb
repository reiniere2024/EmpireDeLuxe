Public Class clsUnit
    Public code As Integer
    Public amount As Integer
    Public name As String
    Public movement As Integer
    Public attack As Integer
    Public defense As Integer
    Public picname As String

    Sub New(ByVal c As Integer, ByVal g As Integer, ByVal n As String, _
    ByVal m As Integer, ByVal a As Integer, ByVal d As Integer, ByVal pn As String)

        code = c
        amount = g
        name = n
        movement = m
        attack = a
        defense = d
        picname = pn

    End Sub

End Class
