Public Class clsMapPart

    Public mcode As Integer
    Public mname As String
    Public mtype As String
    Public mowner As Integer
    Public mx As Integer
    Public my As Integer
    Public mw As Integer
    Public mh As Integer
    Public Armies As Integer
    Public MapBase As Point
    Public Neighbours As String

    Sub New(ByVal cc As Integer, ByVal cn As String, ByVal ct As Integer, _
            ByVal co As Integer, ByVal x As Integer, ByVal y As Integer, ByVal w As Integer, ByVal h As Integer, _
            ByVal nb As String)
        Dim i As Integer

        mcode = cc
        mname = cn
        mtype = ct
        mowner = co
        mx = x
        my = y
        mw = w
        mh = h
        Neighbours = nb

        MapBase = New Point(x + (w / 2), y + (h / 2))

        'ReDim Neighbours(nb.GetUpperBound(0) + 2)
        'For i = 1 To nb.GetUpperBound(0) + 1
        'Neighbours(i) = nb(i - 1)
        'Next

        Armies = 0


    End Sub



End Class
