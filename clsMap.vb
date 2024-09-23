Imports System.IO

Public Class clsMap

    Private ds_game As New DataSet
    Private MyGame As clsGame
    Public MyTacticalMap As frmTacticalMap
    Public MyWorkMap As frmGameField
    Public MyCountries() As clsMapPart


    Sub New(ByRef myform As frmGameField, ByRef game As clsGame)
        MyWorkMap = myform
        MyGame = game
        Me.initialize_form()

        'Color.OrangeRed
    End Sub


    Private Sub initialize_form()
        Dim i, j As Integer

        mapx = 120
        mapy = 75
        mapsize = 0
        LoadGameMap(GAME_MAP)
        Me.define_map()
        Me.initialize_countries()
        MyWorkMap.lbl1.Text = Environment.GetEnvironmentVariable("USERNAME", EnvironmentVariableTarget.Process)

        'LoadUnitMap(UNIT_MAP)
        curx = 0
        cury = 0
        switch = 0

    End Sub

    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long

        Randomize()
        Rand = Int((High - Low + 1) * Rnd()) + Low

    End Function


    Public Function CheckNeighbours(ByVal nbs As String, ByVal nb As String) As Boolean
        Dim rc As Integer

        rc = InStr(nbs, nb)
        If rc > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function CheckCountry(ByVal px As Integer, ByVal py As Integer) As Integer
        Dim cnr, i, x, y, w, h As Integer

        For i = 1 To MyCountries.GetUpperBound(0) - 1
            x = MyCountries(i).mx
            y = MyCountries(i).my
            w = MyCountries(i).mw
            h = MyCountries(i).mh
            If x < px And px < x + w And y < py And py < y + h Then
                cnr = i
                Return cnr
            End If

        Next

        Return cnr

    End Function

    Public Sub RefreshField()
        Dim Mypict As Bitmap

        Mypict = Bitmap.FromFile(CurDir() + "\map\WORLD0.JPG")
        MyWorkMap.PictureBox1.Image = Mypict
        DisplayUnits()
        MyWorkMap.PaintLabels()
        MyWorkMap.Refresh()

    End Sub

    Public Sub DisplayUnits()
        Dim i As Integer

        For i = 1 To MyCountries.GetUpperBound(0) - 1
            If MyCountries(i).mowner > 0 Then
                Me.PaintUnit(i)
                Me.PaintStrength(i, MyColors(MyCountries(i).mowner - 1))
            End If
        Next
        MyWorkMap.Refresh()

    End Sub

    Private Sub initialize_countries()
        Dim i As Integer
        Dim mcode As Integer
        Dim mname, mtype, mowner, nb As String
        Dim mx, my, mw, mh As Integer

        ds_game.ReadXml(CurDir() + "\countries.xml")
        'graphback = Graphics.FromImage(MyWorkMap.PictureBox1.Image)

        For i = 0 To ds_game.Tables(0).Rows.Count - 1
            mcode = ds_game.Tables(0).Rows(i).Item(0)
            mname = ds_game.Tables(0).Rows(i).Item(1)
            mowner = 0
            mtype = 1
            If ds_game.Tables(0).Rows(i).Item(2) <> "" Then
                mx = CInt(ds_game.Tables(0).Rows(i).Item(2))
                my = CInt(ds_game.Tables(0).Rows(i).Item(3))
                mw = CInt(ds_game.Tables(0).Rows(i).Item(4))
                mh = CInt(ds_game.Tables(0).Rows(i).Item(5))
            Else
                mx = 0
                my = 0
                mw = 0
                mh = 0
            End If
            nb = ds_game.Tables(0).Rows(i).Item(6)
            MyCountries(i + 1) = New clsMapPart(mcode, mname, mtype, mowner, mx, my, mw, mh, nb)

            'test interface
            'graphback.DrawRectangle(New Pen(Color.FromName("red")), mx, my, mw, mh)
            'circles
            'Me.PaintUnit(i + 1)
            'numbers
            'Me.PaintStrength(i + 1)

        Next

    End Sub

    Public Sub PaintBorder(ByVal unitnr As Integer, ByVal mycolor As String)
        Dim graphback As Graphics

        Dim px, py, w, h, posx, posy, armies As Integer
        Dim Mypict As Bitmap
        Dim backcolor As Color
        Dim mypen As New Pen(Color.FromName(mycolor))

        graphback = Graphics.FromImage(MyWorkMap.PictureBox1.Image)
        px = MyCountries(unitnr).mx
        py = MyCountries(unitnr).my
        w = MyCountries(unitnr).mw
        h = MyCountries(unitnr).mh

        mypen.Width = 3
        graphback.DrawRectangle(mypen, px, py, w, h)
        MyWorkMap.PictureBox1.Refresh()

    End Sub


    Public Sub PaintStrength(ByVal unitnr As Integer, ByVal mycolor As String)

        Dim px, py, w, h, posx, posy, armies As Integer
        Dim Mypict As Bitmap
        Dim backcolor As Color
        Dim graphback As Graphics

        graphback = Graphics.FromImage(MyWorkMap.PictureBox1.Image)
        px = MyCountries(unitnr).mx
        py = MyCountries(unitnr).my
        w = MyCountries(unitnr).mw
        h = MyCountries(unitnr).mh
        armies = MyCountries(unitnr).Armies

        posx = px + (w / 2) - deltax '- (CircleSize / 2)
        posy = py + (h / 2) - deltay '- (CircleSize / 2)
        'posx = px
        'posy = py
        graphback.DrawString(armies.ToString(), New Font("arial", 12, FontStyle.Bold), New SolidBrush(Color.FromName(mycolor)), posx, posy)

        'graphback.FillEllipse(New SolidBrush(Color.FromName("lightblue")), posx, posy, CircleSize, CircleSize)

    End Sub


    Public Sub PaintUnit(ByVal unitnr As Integer)

        Dim px, py, w, h, posx, posy As Integer
        Dim Mypict As Bitmap
        Dim backcolor As Color
        Dim graphback As Graphics

        graphback = Graphics.FromImage(MyWorkMap.PictureBox1.Image)
        px = MyCountries(unitnr).mx
        py = MyCountries(unitnr).my
        w = MyCountries(unitnr).mw
        h = MyCountries(unitnr).mh

        'posx = px + (w / 2) - (CircleSize / 2)
        'posy = py + (h / 2) - (CircleSize / 2)
        posx = px
        posy = py

        Mypict = Bitmap.FromFile(CurDir() + "\units\Unit1.GIF")
        backcolor = Mypict.GetPixel(0, 0)
        Mypict.MakeTransparent(backcolor)
        graphback.DrawImageUnscaled(Mypict, posx, posy)

        'graphback.FillEllipse(New SolidBrush(Color.FromName("lightblue")), posx, posy, CircleSize, CircleSize)



    End Sub

    Public Sub define_map()
        Select Case mapsize
            Case 0
                'large
                xd1 = 50   'tile breedte
                yd1 = 50 'tile hoogte
            Case 1
                'medium
                xd1 = 45   'tile breedte
                yd1 = 45 'tile hoogte
            Case 2
                'medium small
                xd1 = 40   'tile breedte
                yd1 = 40 'tile hoogte
            Case 3
                'medium smaller
                xd1 = 35   'tile breedte
                yd1 = 35 'tile hoogte
            Case 4
                'small
                xd1 = 30   'tile breedte
                yd1 = 30 'tile hoogte
        End Select


    End Sub

    Private Sub initialize_coordinates(ByVal onlyx As Integer)

        x1 = 0
        x2 = xd1
        If onlyx = 1 Then
            y1 = 0
            y2 = yd1
        End If
    End Sub

    Function LoadGameMap(ByVal strGameMapFileName As String) As Boolean

        LoadGameMap = True
        mapx = 120
        mapy = 75
        mapx = 94
        mapy = 60
        mapsize = 0
        NrCountries = 42

        ReDim MyCountries(NrCountries + 1)

    End Function

    Public Sub ShowMap()
        Dim i, j As Integer
        Dim mypoints(2) As PointF
        Dim mypen = New System.Drawing.Pen(Color.Black, 2)
        Dim graphback As Graphics
        graphback = Graphics.FromHwnd(MyWorkMap.PictureBox1.Handle)

        MyWorkMap.PictureBox1.Location = New Point((-1 * xd1) * curx, (-1 * yd1) * cury)
        MyWorkMap.Refresh()
        MyWorkMap.showgrid = True

        'show lines
        If MyWorkMap.showgrid = True Then
            For i = 1 To 15
                mypoints(0) = New PointF(0, (i * 250))
                mypoints(1) = New PointF(6000, (i * 250))
                graphback.DrawLine(mypen, mypoints(0), mypoints(1))
            Next
            For i = 1 To 30
                mypoints(0) = New PointF(i * 200, 0)
                mypoints(1) = New PointF(i * 200, 3750)
                graphback.DrawLine(mypen, mypoints(0), mypoints(1))
            Next
        End If

    End Sub

    Public Sub draw_border(ByVal px As Integer, ByVal py As Integer)
        Dim graph As Graphics

        MyWorkMap.Refresh()
        'ShowUnits()
        graph = Graphics.FromHwnd(MyWorkMap.PictureBox1.Handle)
        graph.DrawRectangle(New Pen(Color.Black, 2), New Rectangle(px, py, 50, 50))

    End Sub

    Public Function HandleAttack(ByVal c1 As Integer, ByVal c2 As Integer, ByVal player1 As Integer) As Integer
        Dim s1, s2 As Integer
        Dim r1, r2 As Integer
        Dim player2 As Integer

        If player1 = 1 Then
            player2 = 2
        Else
            player2 = 1
        End If

        If MyWorkMap.cbFight.Checked = False Then
            s1 = MyCountries(c1).Armies
            s2 = MyCountries(c2).Armies

            If s1 >= 2 Then
                r1 = Rand(1, s1)
                r2 = Rand(1, s2)
                If r1 > r2 Then
                    MyCountries(c2).Armies = s2 - 1
                    OwnedArmies(player2 - 1) = OwnedArmies(player2 - 1) - 1
                Else
                    MyCountries(c1).Armies = s1 - 1
                    OwnedArmies(player1 - 1) = OwnedArmies(player1 - 1) - 1
                End If
            End If
            Return MyCountries(c2).Armies

        Else 'Continuous fight 
            s1 = MyCountries(c1).Armies
            s2 = MyCountries(c2).Armies
            While s1 >= 2 And s2 >= 1
                If s2 > 0 Then
                    r1 = Rand(1, s1)
                    r2 = Rand(1, s2)
                    If r1 > r2 Then
                        MyCountries(c2).Armies = s2 - 1
                    Else
                        MyCountries(c1).Armies = s1 - 1
                    End If

                End If
                s1 = MyCountries(c1).Armies
                s2 = MyCountries(c2).Armies

            End While
            Return s2

        End If

    End Function

    Public Sub HandleSingleAttack(ByVal c1 As Integer, ByVal c2 As Integer)
        Dim s1, s2 As Integer
        Dim r1, r2 As Integer

        s1 = MyCountries(c1).Armies
        s2 = MyCountries(c2).Armies

        If s1 >= 3 Then
            r1 = Rand(1, s1)
            r2 = Rand(1, s2)
            If r1 > r2 Then
                MyCountries(c2).Armies = s2 - 1
            Else
                MyCountries(c1).Armies = s1 - 1
            End If
        End If

    End Sub



End Class

