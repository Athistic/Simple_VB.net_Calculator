Public Class frmCalculator
    Dim firstNum As Double
    Dim secondNum As Double
    Dim operations As Integer
    Dim operator_selector As Boolean
    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "1"
        Else
            txtDisplay.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "2"
        Else
            txtDisplay.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "3"
        Else
            txtDisplay.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "4"
        Else
            txtDisplay.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "5"
        Else
            txtDisplay.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "6"
        Else
            txtDisplay.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "7"
        Else
            txtDisplay.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "8"
        Else
            txtDisplay.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "9"
        Else
            txtDisplay.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtDisplay.Text <> "0" Then
            txtDisplay.Text += "0"


        End If
    End Sub

    Private Sub btnDecPoint_Click(sender As Object, e As EventArgs) Handles btnDecPoint.Click
        If Not (txtDisplay.Text.Contains(",")) Then
            txtDisplay.Text += ","
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        firstNum = CDbl(txtDisplay.Text)
        txtDisplay.Text = "0"
        txtDisplay2.Text = firstNum & "+"
        operations = 1
        operator_selector = True

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        firstNum = CDbl(txtDisplay.Text)
        txtDisplay.Text = "0"
        txtDisplay2.Text = firstNum & "-"
        operations = 2
        operator_selector = True
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        firstNum = CDbl(txtDisplay.Text)
        txtDisplay.Text = "0"
        txtDisplay2.Text = firstNum & "X"
        operations = 3
        operator_selector = True
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        firstNum = CDbl(txtDisplay.Text)
        txtDisplay.Text = "0"
        txtDisplay2.Text = firstNum & "/"
        operations = 4
        operator_selector = True
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        If operator_selector = True Then
            secondNum = CDbl(txtDisplay.Text)


        End If

        If operations = 1 Then
            txtDisplay.Text = firstNum + secondNum
            txtDisplay2.Text = firstNum & "+" & secondNum & "="
        End If


        If operations = 2 Then
            secondNum = txtDisplay.Text
            txtDisplay.Text = firstNum - secondNum
            txtDisplay2.Text = firstNum & "-" & secondNum & "="
        End If

        If operations = 3 Then
            secondNum = txtDisplay.Text
            txtDisplay.Text = firstNum * secondNum
            txtDisplay2.Text = firstNum & "X" & secondNum & "="
        End If

        If operations = 4 Then
            If secondNum = 0 Then
                txtDisplay.Text = "ERROR!"

            Else
                secondNum = txtDisplay.Text
                txtDisplay.Text = firstNum / secondNum
                txtDisplay2.Text = firstNum & "/" & secondNum & "="
            End If
        End If
        operator_selector = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
        txtDisplay2.Text = "0"
    End Sub
End Class
