Public Class clsBranch
    Inherits clsSprite

    Private bmpBranchTop As Bitmap
    Private bmpBranchMiddle() As Bitmap
    Private bmpBranchBack As Bitmap
    Public size As Integer
    ' new and draw

    Sub New(ByVal branchDirection As enDirection, ByVal intsize As Integer)

        MyBase.New()
        ReDim bmpBranchMiddle(intsize - 3)
        Dim i As Integer
        Dim strImagePrefix As String

        strImagePrefix = "hor"
        If branchDirection = enDirection.north Or branchDirection = enDirection.south Then   'noord of zuid
            strImagePrefix = "vert"
        End If
        bmpBranchTop = load(Application.StartupPath & "\" & IMAGE_PATH & "\" & strImagePrefix & "BranchStart.gif", Color.FromArgb(255, 255, 0, 204))
        For i = 0 To intsize - 3
            bmpBranchMiddle(i) = load(Application.StartupPath & "\" & IMAGE_PATH & "\" & strImagePrefix & "BranchMiddle.gif", Color.FromArgb(255, 255, 0, 204))
        Next
        bmpBranchBack = load(Application.StartupPath & "\" & IMAGE_PATH & "\" & strImagePrefix & "BranchEnd.gif", Color.FromArgb(255, 255, 0, 204))
    End Sub

    Shadows Sub draw(ByVal winhandle As System.IntPtr, ByVal x As Integer, ByVal y As Integer)
        Dim i As Integer

        location = New Point(x, y)

        'MyBase.draw(bmpBranchTop, winhandle)
        If direction = clsSprite.enDirection.north Or direction = clsSprite.enDirection.south Then
            For i = 0 To size - 3
                y += 1
                location = New Point(x, y)
                'MyBase.draw(bmpBranchMiddle(i), winhandle)
            Next
        Else
            For i = 0 To size - 3
                x += 1
                location = New Point(x, y)
                'MyBase.draw(bmpBranchMiddle(i), winhandle)
            Next
        End If
        location = New Point(x, y)
        'MyBase.draw(bmpBranchBack, winhandle)

    End Sub


End Class
