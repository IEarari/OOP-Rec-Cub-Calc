Public Class ClsCuboid
    Inherits ClsRectangle

    Public High As Integer
    Public Area1 As Integer
    Private Size As Integer
    Public Property _size As Integer
        Get
            Return Size
        End Get
        Set(Val As Integer)
            Size = Val
        End Set
    End Property
    Public Sub New(Length1 As Integer, Width1 As Integer, High1 As Integer)
        MyBase.New(Length1, Width1)
        High = High1
        Area1 = 0
        size = 0
    End Sub
    Public Overrides Sub cal_area()
        Area = length * width * 6
    End Sub
    Public Overloads Sub cal_area(x As Integer)
        Area1 = length * width * 4
    End Sub
    Public Function cal_size() As Integer
        Size = length * width * High
        Return Size
    End Function
End Class
