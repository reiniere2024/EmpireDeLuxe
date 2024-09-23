Public Class clsGameEngine
    Public width As Integer = 25
    Public height As Integer = 25
    Public Shared backgroundimage As Image
    Private screenwinhandle As System.IntPtr

    Private objMushrooms() As clsSprite
    Private mushroomnumber As Integer = 75
    Public gameover As Boolean

    Sub New()

    End Sub

    Sub New(ByVal winhandle As System.IntPtr)

        Dim i As Integer
        Dim x, y As Integer

        ReDim objMushrooms(mushroomnumber)

        screenwinhandle = winhandle
        Randomize()
        For i = 0 To mushroomnumber - 1
            objMushrooms(i) = New clsSprite("D:\projects\games\gdi+\adventure\bin\mushroom.gif")
            x = Int(Rnd(1) * (Me.width - 2) + 1)
            y = Int(Rnd(1) * (Me.height - 2) + 1)
            objMushrooms(i).location = New Point(x, y)
            objMushrooms(i).draw(screenwinhandle)
        Next
    End Sub

    Sub render()
        redraw()

    End Sub


    Sub redraw()
        Dim i As Integer

        For i = 0 To mushroomnumber - 1
            objMushrooms(i).draw(screenwinhandle)
        Next

    End Sub

End Class
