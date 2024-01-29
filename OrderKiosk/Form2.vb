Public Class Form2
    Public dbl1Total As Double = 0
    Public dblPayment As Double = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dateAndTime2 As Date
        dateAndTime2 = Now
        lblDate.Text = Format(dateAndTime2, "yyy-MM-dd").ToString
        lblTime.Text = Format(dateAndTime2, "HH:mm").ToString

        lblORID.Text = Form1.lblID.Text

        Dim sum As Double = 0
        For i As Integer = 0 To tbl1OR.Rows.Count() - 1 Step +1
            sum += tbl1OR.Rows(i).Cells(2).Value
        Next

        dbl1Total = sum
        lbl1Total.Text = dbl1Total.ToString("C2")

        If dbl1Total <= 0 Then
            Me.Close()
        End If

        txtPayment.Select()
        btnPay.Enabled = False
        btnExit.Enabled = False
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        tbl1OR.Rows.Clear()

        Dim sum As Double = 0
        For i As Integer = 0 To tbl1OR.Rows.Count() - 1 Step +1
            sum += tbl1OR.Rows(i).Cells(2).Value
        Next

        dbl1Total = sum
        lbl1Total.Text = dbl1Total.ToString("C2")
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        Dim change As Double

        Double.TryParse(txtPayment.Text, dblPayment)

        change = dblPayment - dbl1Total

        lblChange.Text = change.ToString("C2")

        btnExit.Enabled = True
        btnExit.Focus()
    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged

        Double.TryParse(txtPayment.Text, dblPayment)

        If dblPayment < dbl1Total Then
            btnPay.Enabled = False
        Else
            btnPay.Enabled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub
End Class