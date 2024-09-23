Public Class clsClass
    Private player1 As clsPlayer
    Private player2 As clsPlayer
    Private MyGameForm As System.windows.forms.Form

    Sub New(ByRef myform As System.Windows.Forms.Form)

        player1 = New clsPlayer("axis", Color.Red)
        player2 = New clsPlayer("allies", Color.Blue)
        MyGameForm = myform


    End Sub







End Class
