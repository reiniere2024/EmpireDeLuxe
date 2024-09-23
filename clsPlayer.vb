Public Class clsPlayer
    Private myname As String
    Private mycolor As Color
    Private score As Integer
    Private myturn As Boolean

    Sub New(ByVal nm As String, ByVal clr As color)
        Me.myname = nm
        Me.mycolor = clr

    End Sub

    ReadOnly Property name() As String
        Get
            Return myname
        End Get
    End Property

    ReadOnly Property color() As color
        Get
            Return mycolor

        End Get
    End Property

    Overridable Property turn() As Boolean
        Get
            Return myturn
        End Get
        Set(ByVal Value As Boolean)
            myturn = Value

        End Set
    End Property

End Class
