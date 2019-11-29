Public Class ClsRectangle
    Public length As Integer
    Public width As Integer
    Protected Area As Integer

    Public ReadOnly Property _area() As Integer
        Get
            Return Area
        End Get
    End Property
    Public Sub New(Length1 As Integer, Width1 As Integer)
        length = Length1
        width = Width1
        Area = 0
    End Sub
    Public Overridable Sub cal_area()
        Area = length * width
    End Sub
    Public Function cal_area1()
        Area = length * width
        Return Area
    End Function
End Class
