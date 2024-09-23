
Public Class clsSprite

    Public Const IMAGE_SIZE As Integer = 1
    Public IMAGE_PATH As String
    Public bmpsource As Bitmap
    Public myimagename As String

    Public direction As enDirection
    Public location As Point
    Public scale As enscale = enscale.sprite
    Public Enum enscale
        pixel = 1
        sprite = IMAGE_SIZE
    End Enum
    Public Enum enDirection
        north = 1
        northeast = 2
        east = 3
        souteast = 4
        south = 5
        southwest = 6
        west = 7
        northwest = 8
    End Enum

    Sub New()

    End Sub
    Sub New(ByVal strimagename As String)
        MyBase.New()
        bmpsource = load(strimagename)

    End Sub
    Sub New(ByVal strimagename As String, ByVal keycolor As Color)
        MyBase.New()
        bmpsource = load(strimagename, keycolor)

    End Sub
    Sub New(ByVal strimagename As String, ByVal ponlocation As Point)
        MyBase.New()
        bmpsource = load(strimagename)
        location = ponlocation

    End Sub

    Function load(ByVal strimagename As String) As Bitmap
        Dim backcolor As Color
        Try
            myimagename = strimagename
            load = Bitmap.FromFile(strimagename)
            backcolor = load.GetPixel(0, 0)
            load.MakeTransparent(backcolor)

        Catch
            MessageBox.Show("image file was not found", "Sprites", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            load = Nothing

        End Try
    End Function

    Function load(ByVal strimagename As String, ByVal keycolor As Color) As Bitmap
        Try
            'load = Bitmap.FromFile(Application.StartupPath & "\" & strimagename)
            load = Bitmap.FromFile(strimagename)
            load.MakeTransparent(keycolor)
        Catch
            MessageBox.Show("image file was not found", "Sprites", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            load = Nothing
        End Try

    End Function

    Sub draw(ByRef winhandle As System.IntPtr)

        Dim graphback As Graphics

        graphback = Graphics.FromHwnd(winhandle)

        graphback.DrawImageUnscaled(bmpsource, location.X * scale, location.Y * scale)

        'graphback.DrawImageUnscaled(bmpsource, 100, 100)
        graphback.Dispose()

    End Sub

    Sub undraw(ByRef winhandle As System.IntPtr)

        Dim graphback As Graphics

        graphback = Graphics.FromHwnd(winhandle)
        'graphback.DrawImage(backgroundimage, New Rectangle(location.X * scale, location.Y * scale, IMAGE_SIZE, IMAGE_SIZE), GraphicsUnit.Pixel)
        'graphback.DrawImage(backgroundimage, New Rectangle(location.X * scale, location.Y * scale, IMAGE_SIZE, IMAGE_SIZE))

        graphback.Dispose()

    End Sub

End Class





