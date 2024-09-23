Module modGlobals

    Public MinUnits As Integer = 3
    Public BonusCountry As Integer = 1
    Public BonusRest As Integer = 1
    Public BonusNA As Integer
    Public BonusSA As Integer
    Public BonusEUR As Integer
    Public BonusAFR As Integer
    Public BonusAS As Integer
    Public BonusAUS As Integer
    Public curplayer As Integer = 1
    Public curcountry As Integer = 0

    Public MaxUnits As Integer = 30
    Public CurUnits As Integer = 0
    Public CurMove As Integer = 1
    Public curx, cury As Integer
    Public mapx, mapy As Integer
    Public deltax As Integer = 10
    Public deltay As Integer = 5
    Public mapsize As Integer = 0
    Public CircleSize As Integer = 30
    Public MyColors() As String = {"LimeGreen", "OrangeRed", "lightblue", "yellow", "gold", "purple"}
    Public switch As Integer
    Public Myplayers() As Boolean = {False, False, False, False, False, False}

    Public StartPosition() As Integer = {0, 0, 0, 0, 0, 0}
    Public StartPosition1() As Integer = {5, 31, 18, 23, 32, 42}
    Public StartPosition2() As Integer = {31, 5, 11, 18, 23, 32}
    Public StartPosition3() As Integer = {9, 32, 5, 11, 18, 23}
    Public StartPosition4() As Integer = {32, 9, 42, 5, 11, 18}
    Public StartPosition5() As Integer = {11, 39, 32, 42, 5, 11}
    Public StartPosition6() As Integer = {39, 11, 23, 32, 42, 5}


    'Public StartPosition1() As Integer = {5, 31, 18, 23, 32, 42}
    'Public StartPosition2() As Integer = {5, 31, 11, 18, 23, 32}
    'Public StartPosition3() As Integer = {5, 31, 5, 11, 18, 23}
    'Public StartPosition4() As Integer = {5, 31, 42, 5, 11, 18}
    'Public StartPosition5() As Integer = {5, 31, 32, 42, 5, 11}
    'Public StartPosition6() As Integer = {5, 31, 23, 32, 42, 5}
    Public Neigbours() As Integer = {0, 0, 0, 0, 0, 0}

    Public TargetDirection As String = "W" 'N,E,S,W
    Public TS1Country1st As Integer = 32
    Public TS1Country2th As Integer = 36
    Public TS1Country3th As Integer = 37

    Public TN1Country1st As Integer = 16
    Public TN1Country2th As Integer = 27
    Public TN1Country3th As Integer = 28

    Public TE1Country1st As Integer = 27
    Public TE1Country2th As Integer = 28
    Public TE1Country3th As Integer = 32

    Public TW1Country1st As Integer = 16
    Public TW1Country2th As Integer = 20
    Public TW1Country3th As Integer = 36

    Public m1 As Integer
    Public m2 As Integer
    Public m3 As Integer
    Public ArmiesToMove As Integer

    Public FirstComputerMove As Boolean = True


    Public StartUnits As Integer = 10
    Public GameStarted As Boolean = False
    Public Const GAME_MAP As String = "GameMap.txt"
    Public Const UNIT_MAP As String = "GameUnits.txt"

    Public NrCountries As Integer = 42
    Public OwnedCountries() As Integer = {0, 0}
    Public OwnedArmies() As Integer = {0, 0}
    Public NrArmiesNow As Integer
    Public xd1, yd1 As Integer
    Public x1, y1, x2, y2 As Integer


    'Public CountryMoves(2, 42) As Integer
    'Public CountriesOwned(2, 42) As Integer

    Public TotalArmies() As Integer = {StartUnits, StartUnits}
    Public CurArmies() As Integer = {0, 0}

    Public HomeCountries() As Integer = {0, 0}
    Public MoveCountries() As Integer = {0, 0}

    Public MaxCountries As Integer = 3
    Public CurCountries As Integer = 0
    Public StartMove As Boolean = False





End Module
