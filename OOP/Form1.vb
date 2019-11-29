Public Class Form1
    Dim rec As ClsRectangle
    Dim cub As ClsCuboid
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Length Please")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter Width Please")
        Else
            rec = New ClsRectangle(TextBox1.Text, TextBox2.Text)
            rec.cal_area()
            DataGridView1.Rows().Add(rec.length, rec.width, " - ", rec._area, " - ", " - ", " - ")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Length Please")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter Width Please")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Enter Highet Please")
        Else
            cub = New ClsCuboid(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            cub.cal_area()
            cub.cal_area(1)
            DataGridView1.Rows().Add(cub.length, cub.width, cub.High, " - ", cub.Area1, cub._area, cub.cal_size())
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows().Clear()
    End Sub
End Class
