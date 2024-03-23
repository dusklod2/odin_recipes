Public Class Form1
    Public Sub BMI()
        Dim BMI As Integer
        Dim weight As Double
        Dim height As Double
        txtWeight.Text = weight
        txtHeight.Text = height

        If weight = 0 Or height = 0 Then
            BMI = weight / height
        Else
            MsgBox("error")
        End If
        lblDisplay.Text = "your bmi is:" & BMI
    End Sub
    Public Sub CloseProgram()
        Me.Close()
    End Sub
    Public Sub Clearing()
        txtAge.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtGender.Text = ""
        lblDisplay.Text = ""
    End Sub
    Private Sub btnCalcBmi_Click(sender As Object, e As EventArgs) Handles btnCalcBmi.Click
        BMI()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clearing()
    End Sub

    Private Sub btnExtit_Click(sender As Object, e As EventArgs) Handles btnExtit.Click
        CloseProgram()
    End Sub
End Class
