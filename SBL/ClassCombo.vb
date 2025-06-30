Class clCombo2
    Public Sub New(ByVal text As String, ByVal value As Integer)
        t = text
        v = value
    End Sub

    Private t As String
    Private v As Integer
    Public Property Text() As String
        Get
            Return t
        End Get
        Set(ByVal value As String)
            t = value
        End Set
    End Property
    Public Property Value() As Integer
        Get
            Return v
        End Get
        Set(ByVal value As Integer)
            v = value
        End Set
    End Property
End Class