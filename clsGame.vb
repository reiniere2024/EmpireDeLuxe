Imports System.IO

Public Class clsGame
    Private player1 As clsPlayer
    Private player2 As clsPlayer
    Public MyMap As clsMap
    Private MyGameForm As frmGameField
    Public HumanPlayer As Boolean = True

    Private AgressiveMode As Boolean = False
    Public vp_occupied As Boolean = False


    Sub New(ByRef myform As frmGameField)
        Dim i, j As Integer

        MyGameForm = myform
        player1 = New clsPlayer("axis", Color.Red)
        player2 = New clsPlayer("allies", Color.Blue)
        MyMap = New clsMap(MyGameForm, Me)
        'Me.InitializeCountryMoves(1)
        'Me.InitializeCountryMoves(2)
        'Me.InitializeCountriesOwned(1)
        'Me.InitializeCountriesOwned(2)


    End Sub

    Public Function Process_Keys(ByVal mykeys As Keys) As Boolean

        Select Case (mykeys)
            Case Keys.Down

                If cury < mapy Then
                    'cury += 1
                    'MyMap.ShowMap()
                    'MyMap.ShowUnits()
                End If

            Case Keys.Up
                If cury > 0 Then
                    'cury -= 1
                    'MyMap.ShowMap()
                    'MyMap.ShowUnits()

                End If

            Case Keys.Left
                If curx > 0 Then
                    'curx -= 1
                    'MyMap.ShowMap()
                    'MyMap.ShowUnits()
                End If

            Case Keys.Right
                If curx < mapx Then
                    'curx += 1
                    'MyMap.ShowMap()
                    'MyMap.ShowUnits()
                End If

        End Select

    End Function

    Public Sub Start_Game(ByVal p1 As Boolean, ByVal p2 As Boolean, ByVal p3 As Boolean, ByVal p4 As Boolean, ByVal p5 As Boolean, ByVal p6 As Boolean)
        Dim i, myrand As Integer

        'player settings
        Myplayers(0) = p1
        Myplayers(1) = p2
        Myplayers(2) = p3
        Myplayers(3) = p4
        Myplayers(4) = p5
        Myplayers(5) = p6
        'bepaal het te spelen continent
        myrand = Rand(1, 6)
        For i = 0 To 1 '5
            Select Case myrand
                Case 1
                    StartPosition(i) = StartPosition1(i)
                Case 2
                    StartPosition(i) = StartPosition2(i)
                Case 3
                    StartPosition(i) = StartPosition3(i)
                Case 4
                    StartPosition(i) = StartPosition4(i)
                Case 5
                    StartPosition(i) = StartPosition5(i)
                Case 6
                    StartPosition(i) = StartPosition6(i)

            End Select
        Next
        'set up the board
        For i = 0 To 1 '5
            If Myplayers(i) = True Then 'player active ?
                MyMap.MyCountries(StartPosition(i)).mowner = i + 1
                MyMap.MyCountries(StartPosition(i)).Armies = StartUnits
            End If
        Next
        HomeCountries(0) = StartPosition(0)
        HomeCountries(1) = StartPosition(1)
        MoveCountries(0) = StartPosition(0)
        MoveCountries(1) = StartPosition(1)


        If MyGameForm.pb2.Tag = "pc" Then
            HumanPlayer = False
        End If
        MyMap.DisplayUnits()

        curplayer = 1


    End Sub

    Public Function Rand(ByVal Low As Long, ByVal High As Long) As Long

        Randomize()
        Rand = Int((High - Low + 1) * Rnd()) + Low

    End Function



    Public Sub InitializeCountryMoves(ByVal player As Integer)
        Dim i As Integer

        'For i = 0 To NrCountries - 1
        '    CountryMoves(player - 1, i) = 0
        'Next

    End Sub

    Public Sub InitializeCountriesOwned(ByVal player As Integer)
        Dim i As Integer

        'For i = 0 To NrCountries - 1
        '    CountriesOwned(player - 1, i) = 0
        'Next

    End Sub


    Public Sub ProcessToolbar(ByVal ToolbarItem As Integer)
        Select Case (ToolbarItem)
            Case 1
                MyMap.ShowMap()
                'MyMap.ShowUnits()

            Case 2

                If MyMap.MyTacticalMap Is Nothing Then
                    MyMap.MyTacticalMap = New frmTacticalMap(MyMap)
                End If
                MyMap.MyTacticalMap.Show()
                MyMap.MyTacticalMap.Focus()


            Case 3
                If curplayer = 1 Then
                    curplayer = 2
                    If HumanPlayer = False Then
                        MyGameForm.Enabled = False
                        MyGameForm.Text = "Machine Player is playing his move. Please wait ...."
                        'Me.machine_turn()
                        MyGameForm.Text = ""
                        MyGameForm.Enabled = True
                        curplayer = 1
                        CurMove += 1
                    End If
                Else
                    If Me.check_victory() = False Then
                        curplayer = 1
                        CurMove += 1
                    Else
                        Me.stopgame()
                    End If
                End If

            Case 4
                If mapsize > 0 Then
                    mapsize -= 1
                End If
                MyMap.define_map()
                MyMap.ShowMap()

            Case 5
                If mapsize < 4 Then
                    mapsize += 1
                End If
                MyMap.define_map()
                MyMap.ShowMap()

        End Select

    End Sub

    Public Sub DetermineCurrentArmies()
        Dim i, a1, a2 As Integer


        For i = 1 To NrCountries
            If MyMap.MyCountries(i).mowner = 1 Then
                a1 = a1 + MyMap.MyCountries(i).Armies
            ElseIf MyMap.MyCountries(i).mowner = 2 Then
                a2 = a2 + MyMap.MyCountries(i).Armies
            End If
        Next

        TotalArmies(0) = a1
        TotalArmies(1) = a2

    End Sub


    Public Sub ProcessMovement(ByVal px As Integer, ByVal py As Integer, ByVal Mouse As String)
        Dim cnr As Integer = 0
        Dim NrArmies, cid As Integer
        Dim MyNeigbours As String

        Me.DetermineCurrentArmies()
        If curcountry = 0 Then 'new click
            StartMove = True
            cnr = MyMap.CheckCountry(px, py)
            If cnr > 0 Then
                'check current player
                If MyMap.MyCountries(cnr).mowner = curplayer Then
                    'mark current country
                    curcountry = cnr
                    MyMap.PaintBorder(cnr, MyColors(curplayer - 1))
                    'check max nr of players
                    If MyMap.MyCountries(cnr).Armies > MinUnits Then
                        MyMap.MyWorkMap.tbUnits.Text = MyMap.MyCountries(cnr).Armies - 1 'MinUnits
                    End If
                End If
            End If
        Else
            cnr = MyMap.CheckCountry(px, py)
            If cnr > 0 Then
                If Mouse = "Right" Then
                    If MyMap.MyCountries(cnr).mowner = curplayer Then 'change field
                        curcountry = cnr
                        MyMap.RefreshField()
                        MyMap.PaintBorder(cnr, MyColors(curplayer - 1))
                        If MyMap.MyCountries(curcountry).Armies > MinUnits Then
                            MyMap.MyWorkMap.tbUnits.Text = MyMap.MyCountries(cnr).Armies - 1 'MinUnits
                        Else
                            MyMap.MyWorkMap.tbUnits.Text = 0
                        End If

                    End If
                Else
                    'check on neighbours
                    MyNeigbours = MyMap.MyCountries(curcountry).Neighbours
                    'check current player
                    If MyMap.MyCountries(cnr).mowner = curplayer Or MyMap.MyCountries(cnr).mowner = 0 Then 'Change field or reinforcement
                        If MyMap.CheckNeighbours(MyNeigbours, cnr.ToString()) = True Then 'adjacent country
                            If CInt(MyMap.MyWorkMap.tbUnits.Text) > 0 And MyMap.MyCountries(curcountry).Armies > CInt(MyMap.MyWorkMap.tbUnits.Text) And CurUnits + CInt(MyMap.MyWorkMap.tbUnits.Text) < MaxUnits And CurCountries < MaxCountries Then
                                'Empty adjacent country. you can enter
                                If MyMap.MyCountries(cnr).mowner = 0 Then
                                    MyMap.MyCountries(cnr).mowner = curplayer
                                    MyMap.MyCountries(cnr).Armies = MyMap.MyCountries(cnr).Armies + CInt(MyMap.MyWorkMap.tbUnits.Text) + BonusCountry
                                    MyMap.MyCountries(curcountry).Armies = MyMap.MyCountries(curcountry).Armies - CInt(MyMap.MyWorkMap.tbUnits.Text)
                                    'CurArmies(curplayer - 1) = CurArmies(curplayer - 1) + CInt(MyMap.MyWorkMap.tbUnits.Text) + BonusCountry
                                    CurCountries = CurCountries + 1
                                    OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + 1
                                    MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
                                    MyGameForm.tbA02.Text = OwnedArmies(1).ToString()

                                    OwnedCountries(curplayer - 1) = OwnedCountries(curplayer - 1) + 1
                                    MyGameForm.tbC01.Text = OwnedCountries(0).ToString()
                                    MyGameForm.tbC02.Text = OwnedCountries(1).ToString()

                                    If CurCountries = MaxCountries Then 'Or CurUnits = MaxUnits - 1 Then
                                        Me.Switch_Player()
                                    End If
                                Else
                                    MyMap.MyCountries(cnr).Armies = MyMap.MyCountries(cnr).Armies + CInt(MyMap.MyWorkMap.tbUnits.Text)
                                    MyMap.MyCountries(curcountry).Armies = MyMap.MyCountries(curcountry).Armies - CInt(MyMap.MyWorkMap.tbUnits.Text)
                                    'CurArmies(curplayer - 1) = CurArmies(curplayer - 1) + CInt(MyMap.MyWorkMap.tbUnits.Text)
                                End If

                            End If
                        End If
                    Else 'attack country
                        If MyMap.CheckNeighbours(MyNeigbours, cnr.ToString()) = True Then 'adjacent country for attack
                            If MyMap.MyCountries(curcountry).Armies <= CInt(MyMap.MyWorkMap.tbUnits.Text) Then
                                MyMap.MyWorkMap.tbUnits.Text = MinUnits.ToString()
                            End If

                            If CInt(MyMap.MyWorkMap.tbUnits.Text) > 0 And MyMap.MyCountries(curcountry).Armies > CInt(MyMap.MyWorkMap.tbUnits.Text) And CurCountries < MaxCountries Then
                                NrArmiesNow = MyMap.MyCountries(curcountry).Armies
                                NrArmies = MyMap.HandleAttack(curcountry, cnr, curplayer)
                                MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
                                MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
                                If NrArmies = 0 Then 'conquered
                                    MyMap.MyCountries(cnr).mowner = curplayer
                                    If MyMap.MyCountries(curcountry).Armies > CInt(MyMap.MyWorkMap.tbUnits.Text) Then
                                        MyMap.MyCountries(cnr).Armies = CInt(MyMap.MyWorkMap.tbUnits.Text) '+ BonusCountry
                                        CurArmies(curplayer - 1) = CurArmies(curplayer - 1) + CInt(MyMap.MyWorkMap.tbUnits.Text) '+ BonusCountry
                                        MyMap.MyCountries(curcountry).Armies = MyMap.MyCountries(curcountry).Armies - CInt(MyMap.MyWorkMap.tbUnits.Text)
                                        CurUnits = CurUnits + CInt(MyMap.MyWorkMap.tbUnits.Text)
                                    Else
                                        MyMap.MyCountries(cnr).Armies = MyMap.MyCountries(curcountry).Armies - 1 + BonusCountry
                                        CurArmies(curplayer - 1) = CurArmies(curplayer - 1) + MyMap.MyCountries(curcountry).Armies - 1 '+ BonusCountry
                                        MyMap.MyCountries(curcountry).Armies = 1
                                        CurUnits = CurUnits + MyMap.MyCountries(cnr).Armies
                                    End If
                                    If MyMap.MyCountries(curcountry).Armies >= MinUnits Then
                                        MyMap.MyWorkMap.tbUnits.Text = Math.Min(MyMap.MyCountries(curcountry).Armies - 1, MaxUnits - CurUnits - 1)
                                    Else
                                        MyMap.MyWorkMap.tbUnits.Text = 0
                                    End If

                                    CurCountries = CurCountries + 1
                                    OwnedCountries(curplayer - 1) = OwnedCountries(curplayer - 1) + 1
                                    MyGameForm.tbC01.Text = OwnedCountries(0).ToString()
                                    MyGameForm.tbC02.Text = OwnedCountries(1).ToString()

                                    If CurCountries = MaxCountries Then 'Or CurUnits = MaxUnits - 1 Then
                                        Me.Switch_Player()
                                    End If

                                End If

                            End If


                        End If
                    End If
                End If 'cnr > 0
            End If 'curcountry = 0
        End If

        MyMap.DisplayUnits()


    End Sub


    Public Function CheckContinentNA(ByVal player As Integer) As Integer
        Dim rc, cid As Integer
        Dim bonus As Integer = 0
        Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Integer

        cid = HomeCountries(player - 1)

        'Check NA
        b1 = MyMap.MyCountries(1).mowner
        b2 = MyMap.MyCountries(2).mowner
        b3 = MyMap.MyCountries(3).mowner
        b4 = MyMap.MyCountries(4).mowner
        b5 = MyMap.MyCountries(5).mowner
        b6 = MyMap.MyCountries(6).mowner
        b7 = MyMap.MyCountries(7).mowner
        b8 = MyMap.MyCountries(8).mowner
        b9 = MyMap.MyCountries(9).mowner
        If b1 = player And b2 = player And b3 = player And b4 = player And b5 = player And b6 = player And b7 = player And b8 = player And b9 = player Then
            rc = 1
        Else
            rc = 0
        End If

        Return rc


    End Function

    Public Function CheckContinentSA(ByVal player As Integer) As Integer
        Dim rc, cid As Integer
        Dim bonus As Integer = 0
        Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Integer

        b1 = MyMap.MyCountries(10).mowner
        b2 = MyMap.MyCountries(11).mowner
        b3 = MyMap.MyCountries(12).mowner
        b4 = MyMap.MyCountries(13).mowner
        b5 = 0
        b6 = 0
        b7 = 0
        b8 = 0
        b9 = 0
        If b1 = curplayer And b2 = curplayer And b3 = curplayer And b4 = curplayer Then
            rc = 1
        Else
            rc = 0
        End If

        Return rc
    End Function

    Public Function CheckContinentEUR(ByVal player As Integer) As Integer
        Dim rc, cid As Integer
        Dim bonus As Integer = 0
        Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Integer

        b1 = MyMap.MyCountries(14).mowner
        b2 = MyMap.MyCountries(15).mowner
        b3 = MyMap.MyCountries(16).mowner
        b4 = MyMap.MyCountries(17).mowner
        b5 = MyMap.MyCountries(18).mowner
        b6 = MyMap.MyCountries(19).mowner
        b7 = MyMap.MyCountries(20).mowner
        b8 = 0
        b9 = 0
        If b1 = curplayer And b2 = curplayer And b3 = curplayer And b4 = curplayer And b5 = curplayer And b6 = curplayer And b7 = curplayer Then
            rc = 1
        Else
            rc = 0
        End If

        Return rc
    End Function

    Public Function CheckContinentAFR(ByVal player As Integer) As Integer
        Dim rc, cid As Integer
        Dim bonus As Integer = 0
        Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Integer

        b1 = MyMap.MyCountries(21).mowner
        b2 = MyMap.MyCountries(22).mowner
        b3 = MyMap.MyCountries(23).mowner
        b4 = MyMap.MyCountries(24).mowner
        b5 = MyMap.MyCountries(25).mowner
        b6 = MyMap.MyCountries(26).mowner
        b7 = 0
        b8 = 0
        b9 = 0
        If b1 = curplayer And b2 = curplayer And b3 = curplayer And b4 = curplayer And b5 = curplayer And b6 = curplayer Then
            rc = 1
        Else
            rc = 0
        End If

        Return rc

    End Function

    Public Function CheckContinentAS(ByVal player As Integer) As Integer
        Dim rc, cid As Integer
        Dim bonus As Integer = 0
        Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Integer

        b1 = MyMap.MyCountries(27).mowner
        b2 = MyMap.MyCountries(28).mowner
        b3 = MyMap.MyCountries(29).mowner
        b4 = MyMap.MyCountries(30).mowner
        b5 = MyMap.MyCountries(31).mowner
        b6 = MyMap.MyCountries(32).mowner
        b7 = MyMap.MyCountries(33).mowner
        b8 = MyMap.MyCountries(34).mowner
        b9 = MyMap.MyCountries(35).mowner
        b10 = MyMap.MyCountries(36).mowner
        b11 = MyMap.MyCountries(37).mowner
        b12 = MyMap.MyCountries(38).mowner

        If b1 = curplayer And b2 = curplayer And b3 = curplayer And b4 = curplayer And b5 = curplayer And b6 = curplayer And b7 = curplayer And b8 = curplayer And b9 = curplayer And b10 = curplayer And b11 = curplayer And b12 = curplayer Then
            rc = 1
        Else
            rc = 0
        End If

        Return rc

    End Function

    Public Function CheckContinentAUS(ByVal player As Integer) As Integer
        Dim rc, cid As Integer
        Dim bonus As Integer = 0
        Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Integer

        b1 = MyMap.MyCountries(39).mowner
        b2 = MyMap.MyCountries(40).mowner
        b3 = MyMap.MyCountries(41).mowner
        b4 = MyMap.MyCountries(42).mowner

        If b1 = curplayer And b2 = curplayer And b3 = curplayer And b4 = curplayer Then
            rc = 1
        Else
            rc = 0
        End If

        Return rc

    End Function

    Public Sub CheckContinents()
        Dim bonus As Integer = 0
        Dim cid As Integer
        Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Integer

        cid = HomeCountries(curplayer - 1)

        'Check NA
        If Me.CheckContinentNA(curplayer) = 1 Then
            MyMap.MyCountries(cid).Armies += BonusNA
            OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusNA
            MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
            MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
        End If
        'Check SA
        If Me.CheckContinentSA(curplayer) = 1 Then
            MyMap.MyCountries(cid).Armies += BonusSA
            OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusSA
            MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
            MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
        End If
        'Check EUR
        If Me.CheckContinentEUR(curplayer) = 1 Then
            MyMap.MyCountries(cid).Armies += BonusEUR
            OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusEUR
            MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
            MyGameForm.tbA02.Text = OwnedArmies(1).ToString()

        End If
        'Check AFR
        If Me.CheckContinentAFR(curplayer) = 1 Then
            MyMap.MyCountries(cid).Armies += BonusAFR
            OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusAFR
            MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
            MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
        End If
        'Check AS
        If Me.CheckContinentAS(curplayer) = 1 Then
            MyMap.MyCountries(cid).Armies += BonusAS
            OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusAS
            MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
            MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
        End If
        'Check AUS
        If Me.CheckContinentAUS(curplayer) = 1 Then
            MyMap.MyCountries(cid).Armies += BonusAUS
            OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusAUS
            MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
            MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
        End If

    End Sub

    Public Sub CheckCurrentCountry()
        Dim i, cid, newid As Integer

        cid = HomeCountries(curplayer - 1)

        If MyMap.MyCountries(cid).mowner = curplayer Then
            'MsgBox("ok")
        Else 'find new home country

            For i = 1 To MaxCountries - 1
                If MyMap.MyCountries(i).mowner = curplayer Then
                    HomeCountries(curplayer - 1) = i
                    'MsgBox(MyMap.MyCountries(i).mname)

                    Return
                End If
            Next

        End If


    End Sub

    Public Function Check4Continents(ByVal player1 As Integer) As String
        Dim check As String = ""
        Dim counter, rc As Integer

        Me.MyGameForm.Refresh()

        rc = Me.CheckContinentNA(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentSA(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentEUR(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentAFR(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentAS(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentAUS(player1)
        If rc = 1 Then
            counter = counter + 1
        End If

        If counter >= 4 Then
            check = "You own 4 Continents! You have won the game!"
        Else
            check = ""
        End If

        Return check

    End Function

    Public Function Check5Continents(ByVal player1 As Integer) As String
        Dim check As String = ""
        Dim counter, rc As Integer

        rc = Me.CheckContinentNA(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentSA(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentEUR(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentAFR(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentAS(player1)
        If rc = 1 Then
            counter = counter + 1
        End If
        rc = Me.CheckContinentAUS(player1)
        If rc = 1 Then
            counter = counter + 1
        End If

        If counter >= 5 Then
            check = "You own 5 Continents! You have won the game!"
        Else
            check = ""
        End If

        Return check

    End Function

    Public Function Check30Countries(ByVal player1 As Integer) As String
        Dim check As String = ""
        Dim i, numcountries, player2 As Integer

        If player1 = 1 Then
            player2 = 2
        Else
            player2 = 1
        End If

        If OwnedCountries(player1 - 1) >= 30 Then
            check = "You have occupied 30 countries! You have won the game!"
        Else
            check = ""
        End If

        Return check

    End Function

    Public Function CheckTotalVictory(ByVal player1 As Integer) As String
        Dim check As String = ""
        Dim i, numcountries, player2 As Integer

        If player1 = 1 Then
            player2 = 2
        Else
            player2 = 1
        End If
        For i = 1 To NrCountries
            If MyMap.MyCountries(i).mowner = player2 Then
                numcountries = numcountries + 1
            End If
        Next

        If numcountries = 0 Then
            check = "The enemy has been defeated! You have won the game!"
        Else
            check = ""
        End If


        Return check

    End Function


    Public Function CheckVictory(ByVal player1 As Integer) As String

        Dim rc As String = ""

        If MyGameForm.cb01.Checked = True Then
            rc = Me.Check4Continents(player1)

        ElseIf MyGameForm.cb02.Checked = True Then
            rc = Me.Check5Continents(player1)

        ElseIf MyGameForm.cb03.Checked = True Then
            rc = Me.Check30Countries(player1)

        ElseIf MyGameForm.cb04.Checked = True Then
            rc = Me.CheckTotalVictory(player1)

        End If

        Return rc

    End Function

    Public Sub Switch_Player()
        Dim cid As Integer
        Dim msg As String

        If curplayer = 1 Then '6 Then
            'check switching player at end
            cid = HomeCountries(curplayer - 1)
            If StartMove = False Then 'Player has not moved or attacked, bonus
                MyMap.MyCountries(cid).Armies += BonusRest
                OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusRest
                MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
                MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
            End If
            msg = Me.CheckVictory(curplayer)
            If msg <> "" Then
                MsgBox(msg)
                MyGameForm.Close()
                Return
            End If

            'check new player at start
            curplayer = 2
            CurCountries = 0

            Me.CheckCurrentCountry()
            cid = HomeCountries(curplayer - 1)
            MyGameForm.tbHome.Text = MyMap.MyCountries(cid).mname
            Me.CheckContinents()

            MyGameForm.P02.Visible = True
            MyGameForm.P01.Visible = False

            If HumanPlayer = False Then
                Me.ComputerMove()
            End If

            'CurArmies(0) = 0
        Else

            'check switching player at end
            cid = HomeCountries(curplayer - 1)
            If StartMove = False Then 'Player has not moved or attacked, bonus
                MyMap.MyCountries(cid).Armies += BonusRest
                OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusRest
                MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
                MyGameForm.tbA02.Text = OwnedArmies(1).ToString()

            End If
            msg = Me.CheckVictory(curplayer)
            If msg <> "" Then
                MyMap.RefreshField()
                MsgBox(msg)
                MyGameForm.Close()
                Return
            End If

            'check new player at start
            curplayer = 1
            CurCountries = 0
            Me.CheckCurrentCountry()
            cid = HomeCountries(curplayer - 1)
            MyGameForm.tbHome.Text = MyMap.MyCountries(cid).mname
            Me.CheckContinents()

            MyGameForm.P02.Visible = False
            MyGameForm.P01.Visible = True

        End If
        MyMap.RefreshField()
        StartMove = False
        curcountry = 0
        CurUnits = 0
        CurCountries = 0


    End Sub

    Public Sub GetNeigbours(ByVal cnr As Integer)
        Dim i, rc, ind, pos1, pos2 As Integer
        Dim MyNeigbours As String
        Dim myquote, mystring, sDatum As String

        For i = 0 To 5
            Neigbours(i) = 0
        Next
        MyNeigbours = MyMap.MyCountries(cnr).Neighbours


        myquote = ","
        ind = 1
        pos1 = InStr(ind, MyNeigbours, myquote)
        'pos2 = InStr(pos1 + 1, MyNeigbours, myquote)
        If pos1 > 0 Then
            mystring = MyNeigbours.Substring(0, pos1 - 1)
            Neigbours(0) = CInt(mystring)
            ind = pos1 + 1
            pos2 = InStr(ind, MyNeigbours, myquote)
            If pos2 > 0 Then
                mystring = MyNeigbours.Substring(pos1, pos2 - pos1 - 1)
                Neigbours(1) = CInt(mystring)
                pos1 = pos2
                ind = pos2 + 1
                pos2 = InStr(ind, MyNeigbours, myquote)
                If pos2 > 0 Then
                    mystring = MyNeigbours.Substring(pos1, pos2 - pos1 - 1)
                    Neigbours(2) = CInt(mystring)
                    pos1 = pos2
                    ind = pos2 + 1
                    pos2 = InStr(ind, MyNeigbours, myquote)
                    If pos2 > 0 Then
                        mystring = MyNeigbours.Substring(pos1, pos2 - pos1 - 1)
                        Neigbours(3) = CInt(mystring)
                        pos1 = pos2
                        ind = pos2 + 1
                        pos2 = InStr(ind, MyNeigbours, myquote)
                        If pos2 > 0 Then
                            mystring = MyNeigbours.Substring(pos1, pos2 - pos1 - 1)
                            Neigbours(4) = CInt(mystring)
                            pos1 = pos2
                            ind = pos2 + 1
                            pos2 = InStr(ind, MyNeigbours, myquote)
                            If pos2 > 0 Then
                                mystring = MyNeigbours.Substring(pos1, pos2 - pos1 - 1)
                                Neigbours(5) = CInt(mystring)
                            Else
                                mystring = MyNeigbours.Substring(pos1, MyNeigbours.Length - pos1)
                                Neigbours(5) = CInt(mystring)
                            End If
                        Else
                            mystring = MyNeigbours.Substring(pos1, MyNeigbours.Length - pos1)
                            Neigbours(4) = CInt(mystring)
                        End If
                    Else
                        mystring = MyNeigbours.Substring(pos1, MyNeigbours.Length - pos1)
                        Neigbours(3) = CInt(mystring)
                    End If
                Else
                    mystring = MyNeigbours.Substring(pos1, MyNeigbours.Length - pos1)
                    Neigbours(2) = CInt(mystring)

                End If
            Else

                mystring = MyNeigbours.Substring(pos1, MyNeigbours.Length - pos1)
                Neigbours(1) = CInt(mystring)
            End If
        Else
            mystring = MyNeigbours.Substring(pos1, MyNeigbours.Length - pos1)
            Neigbours(0) = CInt(mystring)
        End If


    End Sub

    Public Sub DetermineMostArmies()

        Dim i, bestcountry, myarmies As Integer


        For i = 1 To NrCountries

            If MyMap.MyCountries(i).mowner = 2 And MyMap.MyCountries(i).Armies > myarmies Then

                bestcountry = i
                myarmies = MyMap.MyCountries(i).Armies

            End If

        Next

        MoveCountries(1) = bestcountry

    End Sub

    Public Function DetermineMoveCountry() As Integer

        Dim i, bestcountry, bestcountry2, myneighbours, curneighbours As Integer
        Dim n1, n2, n3, n4, n5, n6 As Integer

        For i = 1 To NrCountries
            myneighbours = 0
            If MyMap.MyCountries(i).mowner = 2 And MyMap.MyCountries(i).Armies >= 2 Then
                'get neigbours
                Me.GetNeigbours(i)
                n1 = Neigbours(0)
                n2 = Neigbours(1)
                n3 = Neigbours(2)
                n4 = Neigbours(3)
                n5 = Neigbours(4)
                n6 = Neigbours(5)
                If n1 > 0 Then
                    If MyMap.MyCountries(n1).mowner = 0 Then
                        myneighbours = myneighbours + 1
                    End If
                End If
                If n2 > 0 Then
                    If MyMap.MyCountries(n2).mowner = 0 Then
                        myneighbours = myneighbours + 1
                    End If
                End If
                If n3 > 0 Then
                    If MyMap.MyCountries(n3).mowner = 0 Then
                        myneighbours = myneighbours + 1
                    End If
                End If
                If n4 > 0 Then
                    If MyMap.MyCountries(n4).mowner = 0 Then
                        myneighbours = myneighbours + 1
                    End If
                End If
                If n5 > 0 Then
                    If MyMap.MyCountries(n5).mowner = 0 Then
                        myneighbours = myneighbours + 1
                    End If
                End If
                If n6 > 0 Then
                    If MyMap.MyCountries(n6).mowner = 0 Then
                        myneighbours = myneighbours + 1
                    End If
                End If

                If myneighbours > curneighbours Then
                    bestcountry = i
                    curneighbours = myneighbours
                End If

            End If

        Next
        If bestcountry > 0 Then
            MoveCountries(1) = bestcountry
        Else 'bepaal beste plek voor extra legers (daarna verder)
            curneighbours = 0
            For i = 1 To NrCountries
                myneighbours = 0
                If MyMap.MyCountries(i).mowner = 2 And MyMap.MyCountries(i).Armies = 1 Then
                    Me.GetNeigbours(i)
                    n1 = Neigbours(0)
                    n2 = Neigbours(1)
                    n3 = Neigbours(2)
                    n4 = Neigbours(3)
                    n5 = Neigbours(4)
                    n6 = Neigbours(5)
                    If n1 > 0 Then
                        If MyMap.MyCountries(n1).mowner = 0 Then
                            myneighbours = myneighbours + 1
                        End If
                    End If
                    If n2 > 0 Then
                        If MyMap.MyCountries(n2).mowner = 0 Then
                            myneighbours = myneighbours + 1
                        End If
                    End If
                    If n3 > 0 Then
                        If MyMap.MyCountries(n3).mowner = 0 Then
                            myneighbours = myneighbours + 1
                        End If
                    End If
                    If n4 > 0 Then
                        If MyMap.MyCountries(n4).mowner = 0 Then
                            myneighbours = myneighbours + 1
                        End If
                    End If
                    If n5 > 0 Then
                        If MyMap.MyCountries(n5).mowner = 0 Then
                            myneighbours = myneighbours + 1
                        End If
                    End If
                    If n6 > 0 Then
                        If MyMap.MyCountries(n6).mowner = 0 Then
                            myneighbours = myneighbours + 1
                        End If
                    End If

                    If myneighbours > curneighbours Then
                        bestcountry2 = i
                        curneighbours = myneighbours
                    End If
                    'bestcountry2 = i

                End If
            Next

            MoveCountries(1) = bestcountry2

        End If

        Return bestcountry


    End Function

    Public Sub DetermineCountries()
        Dim cnr As Integer
        Dim n1, n2, n3, n4, n5, n6 As Integer 'for new countries
        Dim a1, a2, a3, a4, a5, a6 As Integer 'for new countries
        Dim o1, o2, o3, o4, o5, o6 As Integer 'for new countries

        cnr = MoveCountries(1)
        Me.GetNeigbours(cnr)
        n1 = Neigbours(0)
        n2 = Neigbours(1)
        n3 = Neigbours(2)
        n4 = Neigbours(3)
        n5 = Neigbours(4)
        n6 = Neigbours(5)
        If n1 > 0 Then
            o1 = MyMap.MyCountries(n1).mowner
        End If
        If n2 > 0 Then
            o2 = MyMap.MyCountries(n2).mowner
        End If
        If n3 > 0 Then
            o3 = MyMap.MyCountries(n3).mowner
        End If
        If n4 > 0 Then
            o4 = MyMap.MyCountries(n4).mowner
        End If
        If n5 > 0 Then
            o5 = MyMap.MyCountries(n5).mowner
        End If
        If n6 > 0 Then
            o6 = MyMap.MyCountries(n6).mowner
        End If

        If n1 > 0 And o1 = 0 Then
            m1 = n1
            If n2 > 0 And o2 = 0 Then
                m2 = n2
                If n3 > 0 And o3 = 0 Then
                    m3 = n1
                    m1 = n2
                    m2 = n3
                Else
                    If n4 > 0 And o4 = 0 Then
                        m3 = n1
                        m1 = n2
                        m2 = n4
                    Else
                        If n5 > 0 And o5 = 0 Then
                            m3 = n1
                            m1 = n2
                            m2 = n5
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m3 = n1
                                m1 = n2
                                m2 = n6
                            Else 'goed
                                m1 = n1
                                m2 = n2
                                If o3 <> 1 Then
                                    m3 = n3
                                ElseIf o4 <> 1 Then
                                    m3 = n4
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                If n3 > 0 And o3 = 0 Then
                    m2 = n3
                    If n4 > 0 And o4 = 0 Then
                        m3 = n1
                        m1 = n3
                        m2 = n4
                    Else
                        If n5 > 0 And o5 = 0 Then
                            m3 = n1
                            m1 = n3
                            m2 = n5
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m3 = n1
                                m1 = n3
                                m2 = n6
                            Else 'goed
                                m1 = n1
                                m2 = n3
                                If o2 <> 1 Then
                                    m3 = n2
                                ElseIf o4 <> 1 Then
                                    m3 = n4
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If
                            End If
                        End If
                    End If
                Else
                    If n4 > 0 And o4 = 0 Then
                        m2 = n4
                        If n5 > 0 And o5 = 0 Then
                            m3 = n1
                            m1 = n4
                            m2 = n5
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m3 = n1
                                m1 = n4
                                m2 = n6
                            Else 'goed
                                m1 = n1
                                m2 = n4
                                If o2 <> 1 Then
                                    m3 = n2
                                ElseIf o3 <> 1 Then
                                    m3 = n3
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If

                            End If
                        End If
                    Else
                        If n5 > 0 And o5 = 0 Then
                            m2 = n5
                            If n6 > 0 And o6 = 0 Then
                                m3 = n1
                                m1 = n5
                                m2 = n6
                            Else 'goed
                                m1 = n1
                                m2 = n5
                                If o2 <> 1 Then
                                    m3 = n2
                                ElseIf o3 <> 1 Then
                                    m3 = n3
                                ElseIf o4 <> 1 Then
                                    m3 = n4
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If

                            End If
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m3 = n1
                                m1 = n2
                                m2 = n6
                            Else
                                m1 = n1
                                m2 = n2
                                If o3 <> 1 Then
                                    m3 = n3
                                ElseIf o4 <> 1 Then
                                    m3 = n4
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If

                            End If
                        End If
                    End If
                End If
            End If
        Else
            If n2 > 0 And o2 = 0 Then
                m1 = n2
                If n3 > 0 And o3 = 0 Then
                    m2 = n3
                    If n4 > 0 And o4 = 0 Then
                        m3 = n2
                        m1 = n3
                        m2 = n4
                    Else
                        If n5 > 0 And o5 = 0 Then
                            m3 = n2
                            m1 = n3
                            m2 = n5
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m3 = n2
                                m1 = n3
                                m2 = n6
                            Else
                                m1 = n2
                                m2 = n3
                                If o1 <> 1 Then
                                    m3 = n1
                                ElseIf o4 <> 1 Then
                                    m3 = n4
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If
                            End If
                        End If
                    End If
                Else
                    If n4 > 0 And o4 = 0 Then
                        m2 = n4
                        If n5 > 0 And o5 = 0 Then
                            m3 = n2
                            m1 = n4
                            m2 = n5
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m3 = n2
                                m1 = n4
                                m2 = n6
                            Else
                                m1 = n2
                                m2 = n4
                                If o1 <> 1 Then
                                    m3 = n1
                                ElseIf o3 <> 1 Then
                                    m3 = n3
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If

                            End If
                        End If
                    Else
                        If n5 > 0 And o5 = 0 Then
                            m2 = n5
                            If n6 > 0 And o6 = 0 Then
                                m3 = n2
                                m1 = n5
                                m2 = n6
                            Else
                                m1 = n2
                                m2 = n5
                                If o1 <> 1 Then
                                    m3 = n1
                                ElseIf o3 <> 1 Then
                                    m3 = n3
                                ElseIf o4 <> 1 Then
                                    m3 = n4
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If

                            End If
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m3 = n2
                                m1 = n6
                                m2 = n1
                            Else
                                m1 = n2
                                If o1 <> 1 Then
                                    m2 = n1
                                    If o3 <> 1 Then
                                        m3 = n3
                                    ElseIf o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o3 <> 1 Then
                                    m2 = n3
                                    If o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o4 <> 1 Then
                                    m2 = n4
                                    If o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o5 <> 1 Then
                                    m2 = n5
                                    If o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o6 <> 1 Then
                                    m2 = n6
                                    m3 = 0
                                Else
                                    m2 = 0
                                    m3 = 0
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                If n3 > 0 And o3 = 0 Then
                    m1 = n3
                    If n4 > 0 And o4 = 0 Then
                        m2 = n4
                        If n5 > 0 And o5 = 0 Then
                            m3 = n3
                            m1 = n4
                            m2 = n5
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m3 = n3
                                m1 = n4
                                m2 = n6
                            Else
                                m1 = n3
                                m2 = n4
                                If o1 <> 1 Then
                                    m3 = n1
                                ElseIf o2 <> 1 Then
                                    m3 = n2
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If

                            End If
                        End If
                    Else
                        If n5 > 0 And o5 = 0 Then
                            m2 = n5
                            If n6 > 0 And o6 = 0 Then
                                m3 = n3
                                m1 = n5
                                m2 = n6
                            Else
                                m1 = n3
                                m2 = n5
                                If o1 <> 1 Then
                                    m3 = n1
                                ElseIf o2 <> 1 Then
                                    m3 = n2
                                ElseIf o4 <> 1 Then
                                    m3 = n4
                                ElseIf o6 <> 1 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If
                            End If
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m1 = n3
                                m2 = n6
                                If o1 <> 1 Then
                                    m3 = n1
                                ElseIf o2 <> 1 Then
                                    m3 = n2
                                ElseIf o4 <> 1 Then
                                    m3 = n4
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                Else
                                    m3 = 0
                                End If
                            Else
                                m1 = n3
                                If o1 <> 1 Then
                                    m2 = n1
                                    If o2 <> 1 Then
                                        m3 = n2
                                    ElseIf o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o2 <> 1 Then
                                    m2 = n2
                                    If o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o4 <> 1 Then
                                    m2 = n4
                                    If o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o5 <> 1 Then
                                    m2 = n5
                                    If o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o6 <> 1 Then
                                    m2 = n6
                                    m3 = 0
                                Else
                                    m2 = 0
                                    m3 = 0
                                End If
                            End If
                        End If

                    End If
                Else
                    If n4 > 0 And o4 = 0 Then
                        m1 = n4
                        If n5 > 0 And o5 = 0 Then
                            m2 = n5
                            If n6 > 0 And o6 = 0 Then
                                m3 = n4
                                m1 = n5
                                m2 = n6
                            Else
                                m1 = n4
                                m2 = n5
                                If o1 <> 1 Then
                                    m3 = n1
                                ElseIf o1 <> 2 Then
                                    m3 = n2
                                ElseIf o1 <> 3 Then
                                    m3 = n3
                                ElseIf o1 <> 6 Then
                                    m3 = n6
                                Else
                                    m3 = 0
                                End If
                            End If
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m1 = n4
                                m2 = n6
                                If o1 <> 1 Then
                                    m3 = n1
                                ElseIf o2 <> 1 Then
                                    m3 = n2
                                ElseIf o3 <> 1 Then
                                    m3 = n3
                                ElseIf o5 <> 1 Then
                                    m3 = n5
                                Else
                                    m3 = 0
                                End If
                            Else
                                m1 = n4
                                If o1 <> 1 Then
                                    m2 = n1
                                    If o2 <> 1 Then
                                        m3 = n2
                                    ElseIf o3 <> 1 Then
                                        m3 = n3
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o2 <> 1 Then
                                    m2 = n2
                                    If o3 <> 1 Then
                                        m3 = n3
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o3 <> 1 Then
                                    m2 = n3
                                    If o5 <> 1 Then
                                        m3 = n5
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o5 <> 1 Then
                                    m2 = n5
                                    If o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o6 <> 1 Then
                                    m2 = n5
                                    m3 = 0
                                Else
                                    m2 = 0
                                    m3 = 0
                                End If
                            End If
                        End If
                    Else
                        If n5 > 0 And o5 = 0 Then
                            m1 = n5
                            If n6 > 0 And o6 = 0 Then
                                m3 = n5
                                m1 = n6
                                m2 = n1
                            Else
                                m1 = n5
                                If o1 <> 1 Then
                                    m2 = n1
                                    If o2 <> 1 Then
                                        m3 = n2
                                    ElseIf o3 <> 1 Then
                                        m3 = n3
                                    ElseIf o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o2 <> 1 Then
                                    m2 = n2
                                    If o3 <> 1 Then
                                        m3 = n3
                                    ElseIf o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o3 <> 1 Then
                                    m2 = n3
                                    If o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o4 <> 1 Then
                                    m2 = n4
                                    If o6 <> 1 Then
                                        m3 = n6
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o6 <> 1 Then
                                    m2 = n4
                                    m3 = 0
                                Else
                                    m2 = 0
                                    m3 = 0
                                End If
                            End If
                        Else
                            If n6 > 0 And o6 = 0 Then
                                m1 = n6
                                If o1 <> 1 Then
                                    m2 = n1
                                    If o2 <> 1 Then
                                        m3 = n2
                                    ElseIf o3 <> 1 Then
                                        m3 = n3
                                    ElseIf o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o2 <> 1 Then
                                    m2 = n2
                                    If o3 <> 1 Then
                                        m3 = n3
                                    ElseIf o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o3 <> 1 Then
                                    m2 = n3
                                    If o4 <> 1 Then
                                        m3 = n4
                                    ElseIf o5 <> 1 Then
                                        m3 = n5
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o4 <> 1 Then
                                    m2 = n4
                                    If o5 <> 1 Then
                                        m3 = n5
                                    Else
                                        m3 = 0
                                    End If
                                ElseIf o5 <> 1 Then
                                    m2 = n5
                                    m3 = 0
                                Else
                                    m2 = 0
                                    m3 = 0
                                End If

                            Else
                                If o1 <> 1 Then
                                    m1 = n1
                                    If o2 <> 1 Then
                                        m2 = n2
                                        If o3 <> 1 Then
                                            m3 = n3
                                        ElseIf o4 <> 1 Then
                                            m3 = n4
                                        ElseIf o5 <> 1 Then
                                            m3 = n5
                                        ElseIf o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o3 <> 1 Then
                                        m2 = n3
                                        If o4 <> 1 Then
                                            m3 = n4
                                        ElseIf o5 <> 1 Then
                                            m3 = n5
                                        ElseIf o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o4 <> 1 Then
                                        m2 = n4
                                        If o5 <> 1 Then
                                            m3 = n5
                                        ElseIf o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o5 <> 1 Then
                                        m2 = n5
                                        If o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o6 <> 1 Then
                                        m2 = n6
                                        m3 = 0
                                    End If

                                ElseIf o2 <> 1 Then
                                    m1 = n2
                                    If o3 <> 1 Then
                                        m2 = n3
                                        If o4 <> 1 Then
                                            m3 = n4
                                        ElseIf o5 <> 1 Then
                                            m3 = n5
                                        ElseIf o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o4 <> 1 Then
                                        m2 = n4
                                        If o5 <> 1 Then
                                            m3 = n5
                                        ElseIf o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o5 <> 1 Then
                                        m2 = n5
                                        If o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o6 <> 1 Then
                                        m2 = n5
                                        m3 = 0
                                    Else
                                        m2 = 0
                                        m3 = 0
                                    End If

                                ElseIf o3 <> 1 Then
                                    m1 = n3
                                    If o4 <> 1 Then
                                        m2 = n4
                                        If o5 <> 1 Then
                                            m3 = n5
                                        ElseIf o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o5 <> 1 Then
                                        m2 = n5
                                        If o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o6 <> 1 Then
                                        m2 = n6
                                        m3 = 0
                                    Else
                                        m2 = 0
                                        m3 = 0
                                    End If
                                ElseIf o4 <> 1 Then
                                    m1 = n4
                                    If o5 <> 1 Then
                                        m2 = n5
                                        If o6 <> 1 Then
                                            m3 = n6
                                        Else
                                            m3 = 0
                                        End If
                                    ElseIf o6 <> 1 Then
                                        m2 = n6
                                        m3 = 0
                                    Else
                                        m2 = 0
                                        m3 = 0
                                    End If

                                ElseIf o5 <> 1 Then
                                    m1 = n5
                                    If o6 <> 1 Then
                                        m2 = n6
                                        m3 = 0
                                    Else
                                        m2 = 0
                                        m3 = 0
                                    End If
                                ElseIf o6 <> 1 Then
                                    m1 = n6
                                    m2 = 0
                                    m3 = 0
                                Else
                                    m1 = 0
                                    m2 = 0
                                    m3 = 0
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Public Sub DetermineFirstCountries()

        Select Case TargetDirection

            Case "N"

                m1 = TN1Country1st
                m2 = TN1Country2th
                m3 = TN1Country3th
                MoveCountries(1) = m1

            Case "E"

                m1 = TE1Country1st
                m2 = TE1Country2th
                m3 = TE1Country3th
                MoveCountries(1) = m3

            Case "S"

                m1 = TS1Country1st
                m2 = TS1Country2th
                m3 = TS1Country3th
                MoveCountries(1) = m3

            Case "W"

                m1 = TW1Country1st
                m2 = TW1Country2th
                m3 = TW1Country3th
                MoveCountries(1) = m2



        End Select
    End Sub

    Public Function ComputerMove()
        Dim cnr, NrOfArmies As Integer
        Dim n1, n2, n3, n4, n5, n6 As Integer 'for new countries
        Dim a1, a2, a3, a4, a5, a6 As Integer 'for new countries
        Dim o1, o2, o3, o4, o5, o6 As Integer 'for new countries

        Dim rc As Integer

        FirstComputerMove = False
        If FirstComputerMove = True Then
            cnr = MoveCountries(1)
            ArmiesToMove = MyMap.MyCountries(cnr).Armies - 1
            Me.DetermineFirstCountries()
            FirstComputerMove = False
        Else
            'Determine New Country to move from
            rc = Me.DetermineMoveCountry()
            cnr = MoveCountries(1)
            If rc = 0 Then 'rest this turn
                MyMap.MyCountries(cnr).Armies += BonusRest
                OwnedArmies(1) = OwnedArmies(1) + BonusRest
                MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
                Return 0
            End If
            ArmiesToMove = MyMap.MyCountries(cnr).Armies - 1
            If ArmiesToMove <= 2 Then 'rest this turn
                MyMap.MyCountries(cnr).Armies += BonusRest
                OwnedArmies(1) = OwnedArmies(1) + BonusRest
                MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
                Return 0
            End If
            Me.DetermineCountries()
            If m1 = 0 And m2 = 0 And m3 = 0 Then
                MyMap.MyCountries(cnr).Armies += BonusRest
                OwnedArmies(1) = OwnedArmies(1) + BonusRest
                MyGameForm.tbA02.Text = OwnedArmies(1).ToString()
                Return 0
            End If


        End If

        If m1 > 0 Then
            If MyMap.MyCountries(m1).mowner <> 1 Then
                If MyMap.MyCountries(m1).mowner = 0 Then 'empty country
                    MyMap.MyCountries(m1).mowner = 2
                    MyMap.MyCountries(m1).Armies = ArmiesToMove + BonusCountry

                    OwnedCountries(curplayer - 1) = OwnedCountries(curplayer - 1) + 1
                    MyGameForm.tbC01.Text = OwnedCountries(0).ToString()
                    MyGameForm.tbC02.Text = OwnedCountries(1).ToString()
                    OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusCountry
                    MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
                    MyGameForm.tbA02.Text = OwnedArmies(1).ToString()

                ElseIf MyMap.MyCountries(m1).mowner = 2 Then 'own country
                    MyMap.MyCountries(m1).Armies = MyMap.MyCountries(m1).Armies + 1
                    ArmiesToMove = ArmiesToMove - 1
                End If
            End If
            If m2 > 0 Then
                If MyMap.MyCountries(m2).mowner <> 1 Then
                    If MyMap.MyCountries(m2).mowner = 0 Then 'empty country
                        MyMap.MyCountries(m2).mowner = 2
                        MyMap.MyCountries(m2).Armies = 1

                        OwnedCountries(curplayer - 1) = OwnedCountries(curplayer - 1) + 1
                        MyGameForm.tbC01.Text = OwnedCountries(0).ToString()
                        MyGameForm.tbC02.Text = OwnedCountries(1).ToString()
                        OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusCountry
                        MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
                        MyGameForm.tbA02.Text = OwnedArmies(1).ToString()

                    ElseIf MyMap.MyCountries(m2).mowner = 2 Then 'own country
                        MyMap.MyCountries(m2).Armies = MyMap.MyCountries(m2).Armies + 1
                        ArmiesToMove = ArmiesToMove - 1
                    End If
                Else 'attack
                End If
                If m3 > 0 Then
                    If MyMap.MyCountries(m3).mowner <> 1 Then
                        If MyMap.MyCountries(m3).mowner = 0 Then 'empty country
                            MyMap.MyCountries(m3).mowner = 2
                            MyMap.MyCountries(m3).Armies = 1
                            'If MyMap.MyCountries(m3).Armies = 0 Then
                            '    MsgBox("0 dus")
                            'End If
                            OwnedCountries(curplayer - 1) = OwnedCountries(curplayer - 1) + 1
                            MyGameForm.tbC01.Text = OwnedCountries(0).ToString()
                            MyGameForm.tbC02.Text = OwnedCountries(1).ToString()
                            OwnedArmies(curplayer - 1) = OwnedArmies(curplayer - 1) + BonusCountry
                            MyGameForm.tbA01.Text = OwnedArmies(0).ToString()
                            MyGameForm.tbA02.Text = OwnedArmies(1).ToString()

                        ElseIf MyMap.MyCountries(m3).mowner = 2 Then 'own country
                            'MyMap.MyCountries(n3).Armies = MyMap.MyCountries(n3).Armies + 1
                            MyMap.MyCountries(m3).Armies = MyMap.MyCountries(m3).Armies + ArmiesToMove
                        End If
                    Else 'attack
                    End If
                Else

                End If

            Else

            End If

        Else

        End If

        MyMap.MyCountries(cnr).mowner = 2
        MyMap.MyCountries(cnr).Armies = 1

        'If m3 > 0 Then
        '    MoveCountries(1) = m3
        'ElseIf m2 > 0 Then
        '    MoveCountries(1) = m2
        'ElseIf m1 > 0 Then
        '    MoveCountries(1) = m1
        'Else
        '    MoveCountries(1) = cnr
        'End If
        StartMove = True
        Me.MyGameForm.Refresh()

        'Determine the first new position.

        'Determine second movement position

        'Determine the second new position.


        'Determine the number of armies there

        'Determine Reorganized armies



        Me.Switch_Player()

        Return 0


    End Function


    Public Function check_victory() As Boolean
        Return False

    End Function

    Public Sub stopgame()
        MyGameForm.Close()

    End Sub


End Class
