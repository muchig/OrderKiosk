Public Class Form1

    Public dblTotal As Double = 0

    Public dblTotalChamp As Double = 0
    Public intQtyChamp As Integer = 1

    Public dblTotalYum As Double = 0
    Public intQtyYum As Integer = 1

    Public dblTotalYumC As Double = 0
    Public intQtyYumC As Integer = 1

    Public dblTotalYumTLC As Double = 0
    Public intQtyYumTLC As Integer = 1

    Public dblTotalYumB As Double = 0
    Public intQtyYumB As Integer = 1

    Public dblTotalDog As Double = 0
    Public intQtyDog As Integer = 1

    Public intQtyCoke As Integer = 1
    Public dblTotalCoke As Double = 0

    Public intQtyFloat As Integer = 1
    Public dblTotalFloat As Double = 0

    Public intQtySundae As Integer = 1
    Public dblTotalSundae As Double = 0

    Public intQtyCJ1 As Integer = 1
    Public dblTotalCJ1 As Double = 0

    Public intQtyCJ2 As Integer = 1
    Public dblTotalCJ2 As Double = 0

    Public intQtyCJSpag As Integer = 1
    Public dblTotalCJSpag As Double = 0

    Public intQtyCJPal As Integer = 1
    Public dblTotalCJPal As Double = 0

    Public dblTotalRice As Double = 0
    Public intQtyRice As Integer = 1

    Public dblTotalPie As Double = 0
    Public intQtyPie As Integer = 1

    Public boolSpicy As Boolean = False

    Public dblTotalSoup As Double = 0
    Public intQtySoup As Integer = 1

    Public dblTotalCorn As Double = 0
    Public intQtyCorn As Integer = 1

    Public dblTotalFries As Double = 0
    Public intQtyFries As Integer = 1

    Public intValueMealsDrinks As Integer = 0
    Public intValueMealsSides As Integer = 0
    Public intValueMealsFries As Integer = 0



    Public dateAndTime As Date


    Private Sub Button4_Click_3(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.HorizontalScroll.Enabled = False
        Me.HorizontalScroll.Visible = False
        'Me.VerticalScroll.Visible = False
        Me.AutoScroll = True



        tab00.ItemSize = New Size(0, 1)
        tab00.SizeMode = TabSizeMode.Fixed

        AutoScroll = True

        'FAKE ID GENERATOR
        dateAndTime = Now
        lblID.Text = Format(dateAndTime, "HHmmss").ToString

        'TRANSPARENCY
        lblCokeReg.Location = picCoke.PointToClient(lblCokeReg.Parent.PointToScreen(lblCokeReg.Location))
        lblCokeReg.Parent = picCoke
        lblCokeReg.BackColor = Color.Transparent
        lblCokeRegP.Location = picCoke.PointToClient(lblCokeRegP.Parent.PointToScreen(lblCokeRegP.Location))
        lblCokeRegP.Parent = picCoke
        lblCokeRegP.BackColor = Color.Transparent

        lblCokeLarge.Location = picCoke.PointToClient(lblCokeLarge.Parent.PointToScreen(lblCokeLarge.Location))
        lblCokeLarge.Parent = picCoke
        lblCokeLarge.BackColor = Color.Transparent
        lblCokeLargeP.Location = picCoke.PointToClient(lblCokeLargeP.Parent.PointToScreen(lblCokeLargeP.Location))
        lblCokeLargeP.Parent = picCoke
        lblCokeLargeP.BackColor = Color.Transparent

        lblCokeLargeU.Location = picCoke.PointToClient(lblCokeLargeU.Parent.PointToScreen(lblCokeLargeU.Location))
        lblCokeLargeU.Parent = picCoke
        lblCokeLargeU.BackColor = Color.Transparent
        lblCokeLargeUP.Location = picCoke.PointToClient(lblCokeLargeUP.Parent.PointToScreen(lblCokeLargeUP.Location))
        lblCokeLargeUP.Parent = picCoke
        lblCokeLargeUP.BackColor = Color.Transparent

        lblCokeRegSize.Location = picCoke.PointToClient(lblCokeRegSize.Parent.PointToScreen(lblCokeRegSize.Location))
        lblCokeRegSize.Parent = picCoke
        lblCokeRegSize.BackColor = Color.Transparent

        lblSoftDrinks.Location = picCoke.PointToClient(lblSoftDrinks.Parent.PointToScreen(lblSoftDrinks.Location))
        lblSoftDrinks.Parent = picCoke
        lblSoftDrinks.BackColor = Color.Transparent

        lblFloatReg.Location = picFloat.PointToClient(lblFloatReg.Parent.PointToScreen(lblFloatReg.Location))
        lblFloatReg.Parent = picFloat
        lblFloatReg.BackColor = Color.Transparent
        lblFloatRegP.Location = picFloat.PointToClient(lblFloatRegP.Parent.PointToScreen(lblFloatRegP.Location))
        lblFloatRegP.Parent = picFloat
        lblFloatRegP.BackColor = Color.Transparent

        cbxFloat.Location = picFloat.PointToClient(cbxFloat.Parent.PointToScreen(cbxFloat.Location))
        cbxFloat.Parent = picFloat

        lblFloat.Location = picFloat.PointToClient(lblFloat.Parent.PointToScreen(lblFloat.Location))
        lblFloat.Parent = picFloat
        lblFloat.BackColor = Color.Transparent

        lblFloatRegU.Location = picFloat.PointToClient(lblFloatRegU.Parent.PointToScreen(lblFloatRegU.Location))
        lblFloatRegU.Parent = picFloat
        lblFloatRegU.BackColor = Color.Transparent
        lblFloatRegUP.Location = picFloat.PointToClient(lblFloatRegUP.Parent.PointToScreen(lblFloatRegUP.Location))
        lblFloatRegUP.Parent = picFloat
        lblFloatRegUP.BackColor = Color.Transparent

        lblFloatLarge.Location = picFloat.PointToClient(lblFloatLarge.Parent.PointToScreen(lblFloatLarge.Location))
        lblFloatLarge.Parent = picFloat
        lblFloatLarge.BackColor = Color.Transparent
        lblFloatLargeP.Location = picFloat.PointToClient(lblFloatLargeP.Parent.PointToScreen(lblFloatLargeP.Location))
        lblFloatLargeP.Parent = picFloat
        lblFloatLargeP.BackColor = Color.Transparent

        lblFloatLargeU.Location = picFloat.PointToClient(lblFloatLargeU.Parent.PointToScreen(lblFloatLargeU.Location))
        lblFloatLargeU.Parent = picFloat
        lblFloatLargeU.BackColor = Color.Transparent
        lblFloatLargeUP.Location = picFloat.PointToClient(lblFloatLargeUP.Parent.PointToScreen(lblFloatLargeUP.Location))
        lblFloatLargeUP.Parent = picFloat
        lblFloatLargeUP.BackColor = Color.Transparent

        chkFloatReg.Location = picFloat.PointToClient(chkFloatReg.Parent.PointToScreen(chkFloatReg.Location))
        chkFloatReg.Parent = picFloat
        chkFloatReg.BackColor = Color.Transparent

        chkFloatLarge.Location = picFloat.PointToClient(chkFloatLarge.Parent.PointToScreen(chkFloatLarge.Location))
        chkFloatLarge.Parent = picFloat
        chkFloatLarge.BackColor = Color.Transparent

        chkFloatLargeU.Location = picFloat.PointToClient(chkFloatLargeU.Parent.PointToScreen(chkFloatLargeU.Location))
        chkFloatLargeU.Parent = picFloat
        chkFloatLargeU.BackColor = Color.Transparent

        chkFloatRegU.Location = picFloat.PointToClient(chkFloatRegU.Parent.PointToScreen(chkFloatRegU.Location))
        chkFloatRegU.Parent = picFloat
        chkFloatRegU.BackColor = Color.Transparent


        lblSundaes.Location = picSundaes.PointToClient(lblSundaes.Parent.PointToScreen(lblSundaes.Location))
        lblSundaes.Parent = picSundaes
        lblSundaes.BackColor = Color.Transparent

        lblTwirls.Location = picSundaes.PointToClient(lblTwirls.Parent.PointToScreen(lblTwirls.Location))
        lblTwirls.Parent = picSundaes
        lblTwirls.BackColor = Color.Transparent

        lblSundaeChoco.Location = picSundaes.PointToClient(lblSundaeChoco.Parent.PointToScreen(lblSundaeChoco.Location))
        lblSundaeChoco.Parent = picSundaes
        lblSundaeChoco.BackColor = Color.Transparent
        lblSundaeChocoP.Location = picSundaes.PointToClient(lblSundaeChocoP.Parent.PointToScreen(lblSundaeChocoP.Location))
        lblSundaeChocoP.Parent = picSundaes
        lblSundaeChocoP.BackColor = Color.Transparent

        lblSundaeSB.Location = picSundaes.PointToClient(lblSundaeSB.Parent.PointToScreen(lblSundaeSB.Location))
        lblSundaeSB.Parent = picSundaes
        lblSundaeSB.BackColor = Color.Transparent
        lblSundaeSBP.Location = picSundaes.PointToClient(lblSundaeSBP.Parent.PointToScreen(lblSundaeSBP.Location))
        lblSundaeSBP.Parent = picSundaes
        lblSundaeSBP.BackColor = Color.Transparent

        lblTwirlV.Location = picSundaes.PointToClient(lblTwirlV.Parent.PointToScreen(lblTwirlV.Location))
        lblTwirlV.Parent = picSundaes
        lblTwirlV.BackColor = Color.Transparent
        lblTwirlVP.Location = picSundaes.PointToClient(lblTwirlVP.Parent.PointToScreen(lblTwirlVP.Location))
        lblTwirlVP.Parent = picSundaes
        lblTwirlVP.BackColor = Color.Transparent

        lblTwirlChoco.Location = picSundaes.PointToClient(lblTwirlChoco.Parent.PointToScreen(lblTwirlChoco.Location))
        lblTwirlChoco.Parent = picSundaes
        lblTwirlChoco.BackColor = Color.Transparent
        lblTwirlChocoP.Location = picSundaes.PointToClient(lblTwirlChocoP.Parent.PointToScreen(lblTwirlChocoP.Location))
        lblTwirlChocoP.Parent = picSundaes
        lblTwirlChocoP.BackColor = Color.Transparent


        chkSundaeChoco.Location = picSundaes.PointToClient(chkSundaeChoco.Parent.PointToScreen(chkSundaeChoco.Location))
        chkSundaeChoco.Parent = picSundaes
        chkSundaeChoco.BackColor = Color.Transparent

        chkSundaeSB.Location = picSundaes.PointToClient(chkSundaeSB.Parent.PointToScreen(chkSundaeSB.Location))
        chkSundaeSB.Parent = picSundaes
        chkSundaeSB.BackColor = Color.Transparent

        chkTwirlV.Location = picSundaes.PointToClient(chkTwirlV.Parent.PointToScreen(chkTwirlV.Location))
        chkTwirlV.Parent = picSundaes
        chkTwirlV.BackColor = Color.Transparent

        chkTwirlChoco.Location = picSundaes.PointToClient(chkTwirlChoco.Parent.PointToScreen(chkTwirlChoco.Location))
        chkTwirlChoco.Parent = picSundaes
        chkTwirlChoco.BackColor = Color.Transparent

        lblSM.Location = picSuper.PointToClient(lblSM.Parent.PointToScreen(lblSM.Location))
        lblSM.Parent = picSuper
        lblSM.BackColor = Color.Transparent

        lblA.Location = picSuper.PointToClient(lblA.Parent.PointToScreen(lblA.Location))
        lblA.Parent = picSuper
        lblA.BackColor = Color.Transparent

        lblB.Location = picSuper.PointToClient(lblB.Parent.PointToScreen(lblB.Location))
        lblB.Parent = picSuper
        lblB.BackColor = Color.Transparent

        lblA11.Location = picSuper.PointToClient(lblA11.Parent.PointToScreen(lblA11.Location))
        lblA11.Parent = picSuper
        lblA11.BackColor = Color.Transparent

        lblA12.Location = picSuper.PointToClient(lblA12.Parent.PointToScreen(lblA12.Location))
        lblA12.Parent = picSuper
        lblA12.BackColor = Color.Transparent

        lblA13.Location = picSuper.PointToClient(lblA13.Parent.PointToScreen(lblA13.Location))
        lblA13.Parent = picSuper
        lblA13.BackColor = Color.Transparent

        lblB11.Location = picSuper.PointToClient(lblB11.Parent.PointToScreen(lblB11.Location))
        lblB11.Parent = picSuper
        lblB11.BackColor = Color.Transparent

        lblB12.Location = picSuper.PointToClient(lblB12.Parent.PointToScreen(lblB12.Location))
        lblB12.Parent = picSuper
        lblB12.BackColor = Color.Transparent

        lblB13.Location = picSuper.PointToClient(lblB13.Parent.PointToScreen(lblB13.Location))
        lblB13.Parent = picSuper
        lblB13.BackColor = Color.Transparent

        lblB21.Location = picSuper.PointToClient(lblB21.Parent.PointToScreen(lblB21.Location))
        lblB21.Parent = picSuper
        lblB21.BackColor = Color.Transparent

        lblB22.Location = picSuper.PointToClient(lblB22.Parent.PointToScreen(lblB22.Location))
        lblB22.Parent = picSuper
        lblB22.BackColor = Color.Transparent

        lblB23.Location = picSuper.PointToClient(lblB23.Parent.PointToScreen(lblB23.Location))
        lblB23.Parent = picSuper
        lblB23.BackColor = Color.Transparent

        chkSuperA1.Location = picSuper.PointToClient(chkSuperA1.Parent.PointToScreen(chkSuperA1.Location))
        chkSuperA1.Parent = picSuper
        chkSuperA1.BackColor = Color.Transparent
        chkSuperA2.Location = picSuper.PointToClient(chkSuperA2.Parent.PointToScreen(chkSuperA2.Location))
        chkSuperA2.Parent = picSuper
        chkSuperA2.BackColor = Color.Transparent

        chkSuperB1.Location = picSuper.PointToClient(chkSuperB1.Parent.PointToScreen(chkSuperB1.Location))
        chkSuperB1.Parent = picSuper
        chkSuperB1.BackColor = Color.Transparent
        chkSuperB2.Location = picSuper.PointToClient(chkSuperB2.Parent.PointToScreen(chkSuperB2.Location))
        chkSuperB2.Parent = picSuper
        chkSuperB2.BackColor = Color.Transparent

        lblFriesReg.Location = picFries.PointToClient(lblFriesReg.Parent.PointToScreen(lblFriesReg.Location))
        lblFriesReg.Parent = picFries
        lblFriesReg.BackColor = Color.Transparent
        lblFriesRegP.Location = picFries.PointToClient(lblFriesRegP.Parent.PointToScreen(lblFriesRegP.Location))
        lblFriesRegP.Parent = picFries
        lblFriesRegP.BackColor = Color.Transparent

        lblFriesLarge.Location = picFries.PointToClient(lblFriesLarge.Parent.PointToScreen(lblFriesLarge.Location))
        lblFriesLarge.Parent = picFries
        lblFriesLarge.BackColor = Color.Transparent
        lblFriesLargeP.Location = picFries.PointToClient(lblFriesLargeP.Parent.PointToScreen(lblFriesLargeP.Location))
        lblFriesLargeP.Parent = picFries
        lblFriesLargeP.BackColor = Color.Transparent

        lblFriesLargeU.Location = picFries.PointToClient(lblFriesLargeU.Parent.PointToScreen(lblFriesLargeU.Location))
        lblFriesLargeU.Parent = picFries
        lblFriesLargeU.BackColor = Color.Transparent
        lblFriesLargeUP.Location = picFries.PointToClient(lblFriesLargeUP.Parent.PointToScreen(lblFriesLargeUP.Location))
        lblFriesLargeUP.Parent = picFries
        lblFriesLargeUP.BackColor = Color.Transparent


        'champ
        dblTotalChamp = 120
        lblChampSolo.Text = dblTotalChamp
        dblTotalChamp = 155
        lblChampValue.Text = dblTotalChamp


        'coke
        dblTotalCoke = 28
        lblCokeReg.Text = dblTotalCoke
        dblTotalCoke = 50
        lblCokeLarge.Text = dblTotalCoke
        dblTotalCoke = 20
        lblCokeLargeU.Text = dblTotalCoke

        'yum
        dblTotalYum = 30
        lblYumSolo.Text = dblTotalYum
        dblTotalYum = 72
        lblYumValue.Text = dblTotalYum

        'yumc
        dblTotalYumC = 40
        lblYumSoloC.Text = dblTotalYumC
        dblTotalYumC = 82
        lblYumValueC.Text = dblTotalYumC

        'yumtlc
        dblTotalYumTLC = 62
        lblYumSoloTLC.Text = dblTotalYumTLC
        dblTotalYumTLC = 97
        lblYumValueTLC.Text = dblTotalYumTLC

        'yumb
        dblTotalYumB = 72
        lblYumSoloB.Text = dblTotalYumB
        dblTotalYumB = 99
        lblYumValueB.Text = dblTotalYumB

        'dog
        dblTotalDog = 50
        lblDogSolo.Text = dblTotalDog
        dblTotalDog = 87
        lblDogValue.Text = dblTotalDog


        lblTotal.Text = 0.ToString("C2")
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            Form2.tbl1OR.Rows.Add(tbl2Order.Rows(i).Cells(0).Value, tbl2Order.Rows(i).Cells(1).Value, tbl2Order.Rows(i).Cells(2).Value)

        Next
        Form2.ShowDialog()
        btnCancel.PerformClick()
        tab00.SelectedTab = tabBS
    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles btnRemove.Click

        For Each Row As DataGridViewRow In tbl2Order.SelectedRows
            tbl2Order.Rows.Remove(Row)

            Dim sum As Double = 0
            For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
                sum += tbl2Order.Rows(i).Cells(2).Value
            Next

            dblTotal = sum
            lblTotal.Text = dblTotal.ToString("C2")

        Next
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click

        tbl2Order.Rows.Clear()

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")

        'btnResetXX.PerformClick() does not reset the other tabs  ???

        chkChampSolo.Checked = False
        chkChampValue.Checked = False
        intQtyChamp = 1
        lblQtyChamp.Text = intQtyChamp
        dblTotalChamp = 120
        lblChampSolo.Text = dblTotalChamp
        dblTotalChamp = 155
        lblChampValue.Text = dblTotalChamp
        btnAddChamp.Enabled = True

        chkYumSolo.Checked = False
        chkYumValue.Checked = False
        btnAddYum.Enabled = True
        intQtyYum = 1
        lblQtyYum.Text = intQtyYum
        dblTotalYum = 30
        lblYumSolo.Text = dblTotalYum
        dblTotalYum = 72
        lblYumValue.Text = dblTotalYum

        chkYumSoloC.Checked = False
        chkYumValueC.Checked = False
        btnAddYumC.Enabled = True
        intQtyYumC = 1
        lblQtyYumC.Text = intQtyYumC
        dblTotalYumC = 40
        lblYumSoloC.Text = dblTotalYumC
        dblTotalYumC = 82
        lblYumValueC.Text = dblTotalYumC

        chkYumSoloTLC.Checked = False
        chkYumValueTLC.Checked = False
        btnAddYumTLC.Enabled = True
        intQtyYumTLC = 1
        lblQtyYumTLC.Text = intQtyYumTLC
        dblTotalYumTLC = 62
        lblYumSoloTLC.Text = dblTotalYumTLC
        dblTotalYumTLC = 97
        lblYumValueTLC.Text = dblTotalYumTLC

        chkYumSoloB.Checked = False
        chkYumValueB.Checked = False
        btnAddYumB.Enabled = True
        intQtyYumB = 1
        lblQtyYumB.Text = intQtyYumB
        dblTotalYumB = 72
        lblYumSoloB.Text = dblTotalYumB
        dblTotalYumB = 99
        lblYumValueB.Text = dblTotalYumB

        chkDogSolo.Checked = False
        chkDogValue.Checked = False
        btnAddDog.Enabled = True
        intQtyDog = 1
        lblQtyDog.Text = intQtyDog
        dblTotalDog = 50
        lblDogSolo.Text = dblTotalDog
        dblTotalDog = 87
        lblDogValue.Text = dblTotalDog

        cbxCoke.SelectedIndex = -1
        chkCokeReg.Checked = False
        chkCokeLarge.Checked = False
        chkCokeLargeU.Checked = False
        btnAddCoke.Enabled = True
        intQtyCoke = 1
        lblQtyCoke.Text = intQtyCoke
        dblTotalCoke = 28
        lblCokeReg.Text = dblTotalCoke
        dblTotalCoke = 50
        lblCokeLarge.Text = dblTotalCoke
        dblTotalCoke = 20
        lblCokeLargeU.Text = dblTotalCoke

        cbxFloat.SelectedIndex = -1
        chkFloatReg.Checked = False
        chkFloatLarge.Checked = False
        chkFloatLargeU.Checked = False
        chkFloatRegU.Checked = False
        btnAddFloat.Enabled = True
        intQtyFloat = 1
        lblQtyFloat.Text = intQtyFloat
        dblTotalFloat = 35
        lblFloatReg.Text = dblTotalFloat
        dblTotalFloat = 62
        lblFloatLarge.Text = dblTotalFloat
        dblTotalFloat = 15
        lblFloatRegU.Text = dblTotalFloat
        dblTotalFloat = 25
        lblFloatLargeU.Text = dblTotalFloat

        chkSundaeChoco.Checked = False
        chkSundaeSB.Checked = False
        chkTwirlChoco.Checked = False
        chkTwirlV.Checked = False
        btnAddSundae.Enabled = True
        intQtySundae = 1
        lblQtySundae.Text = intQtySundae
        dblTotalSundae = 28
        lblSundaeChoco.Text = dblTotalSundae
        dblTotalSundae = 28
        lblSundaeSB.Text = dblTotalSundae
        dblTotalSundae = 13
        lblTwirlV.Text = dblTotalSundae
        dblTotalSundae = 18
        lblTwirlChoco.Text = dblTotalSundae

        chkCJ1Solo.Checked = False
        chkCJ1Value.Checked = False
        boolSpicy = False
        picCJ1S.Visible = False
        intQtyCJ1 = 1
        lblQtyCJ1.Text = intQtyCJ1
        dblTotalCJ1 = 82
        lblCJ1Solo.Text = dblTotalCJ1
        dblTotalCJ1 = 85
        lblCJ1Value.Text = dblTotalCJ1
        btnAddCJ1.Enabled = True


        chkCJ2Solo.Checked = False
        chkCJ2Value.Checked = False
        boolSpicy = False
        picCJ2S.Visible = False
        intQtyCJ1 = 1
        lblQtyCJ2.Text = intQtyCJ1
        dblTotalCJ1 = 142
        lblCJ2Solo.Text = dblTotalCJ1
        dblTotalCJ1 = 145
        lblCJ2Value.Text = dblTotalCJ1
        btnAddCJ2.Enabled = True

        chkCJSpagSolo.Checked = False
        chkCJSpagValue.Checked = False
        boolSpicy = False
        picCJSpagS.Visible = False
        intQtyCJ1 = 1
        lblQtyCJSpag.Text = intQtyCJ1
        dblTotalCJ1 = 142
        lblCJSpagSolo.Text = dblTotalCJ1
        dblTotalCJ1 = 145
        lblCJSpagValue.Text = dblTotalCJ1
        btnAddCJSpag.Enabled = True

        chkCJPalSolo.Checked = False
        chkCJPalValue.Checked = False
        boolSpicy = False
        picCJPalS.Visible = False
        intQtyCJ1 = 1
        lblQtyCJPal.Text = intQtyCJ1
        dblTotalCJ1 = 137
        lblCJPalSolo.Text = dblTotalCJ1
        dblTotalCJ1 = 140
        lblCJSpagValue.Text = dblTotalCJ1
        btnAddCJSpag.Enabled = True

        intQtyRice = 1
        lblQtyRice.Text = intQtyRice

        dblTotalRice = 33
        lblRice.Text = dblTotalRice
        btnAddRice.Enabled = True

        chkPieSolo.Checked = False
        chkPieValue.Checked = False
        intQtyPie = 1
        lblQtyPie.Text = intQtyPie
        dblTotalPie = 27
        lblPieSolo.Text = dblTotalPie
        dblTotalPie = 78
        lblPieValue.Text = dblTotalPie
        btnAddPie.Enabled = True

        chkSoupSolo.Checked = False
        chkSoupU.Checked = False
        btnAddSoup.Enabled = True
        intQtySoup = 1
        lblQtySoup.Text = intQtySoup
        dblTotalSoup = 39
        lblSoupSolo.Text = dblTotalSoup
        dblTotalSoup = 35
        lblSoupU.Text = dblTotalSoup

        chkCornSolo.Checked = False
        chkCornU.Checked = False
        btnAddCorn.Enabled = True
        intQtyCorn = 1
        lblQtyCorn.Text = intQtyCorn
        dblTotalCorn = 29
        lblCornSolo.Text = dblTotalCorn
        dblTotalCorn = 25
        lblCornU.Text = dblTotalCorn

        chkFriesReg.Checked = False
        chkFriesLarge.Checked = False
        chkFriesLargeU.Checked = False
        btnAddFries.Enabled = True
        intQtyFries = 1
        lblQtyFries.Text = intQtyFries
        dblTotalFries = 37
        lblFriesReg.Text = dblTotalFries
        dblTotalFries = 62
        lblFriesLarge.Text = dblTotalFries
        dblTotalFries = 42
        lblFriesLargeU.Text = dblTotalFries

        intValueMealsDrinks = 0
        intValueMealsSides = 0
        intValueMealsFries = 0

    End Sub

    '=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ
    'Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====
    '=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ
    'Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====Champ=====


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkChampSolo.CheckedChanged
        If chkChampSolo.Checked = True Then
            chkChampSolo.Checked = True

            If chkChampValue.Checked = True Then
                chkChampValue.Checked = False
            End If

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkChampValue.CheckedChanged
        If chkChampValue.Checked = True Then
            chkChampValue.Checked = True

            If chkChampSolo.Checked = True Then
                chkChampSolo.Checked = False
            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnUpChamp.Click
        intQtyChamp += 1

        dblTotalChamp = 120 * intQtyChamp

        lblQtyChamp.Text = intQtyChamp

        lblChampSolo.Text = dblTotalChamp

        dblTotalChamp = 0
        dblTotalChamp = 155 * intQtyChamp

        lblQtyChamp.Text = intQtyChamp


        lblChampValue.Text = dblTotalChamp


        If dblTotalChamp >= 1 Then
            btnAddChamp.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDownChamp.Click

        intQtyChamp -= 1
        dblTotalChamp = 120 * intQtyChamp

        If dblTotalChamp <= 0 Then
            dblTotalChamp = 0

        End If

        lblChampSolo.Text = dblTotalChamp

        dblTotalChamp = 0
        dblTotalChamp = 155 * intQtyChamp

        If dblTotalChamp <= 0 Then
            dblTotalChamp = 0

        End If

        lblQtyChamp.Text = intQtyChamp

        lblChampValue.Text = dblTotalChamp


        lblChampValue.Text = dblTotalChamp

        If intQtyChamp <= 0 Then

            intQtyChamp = 0

        End If
        If dblTotalChamp <= 0 Then
            dblTotalChamp = 0

        End If
        lblQtyChamp.Text = intQtyChamp


        If intQtyChamp <= 0 Then
            intQtyChamp = 0
            btnAddChamp.Enabled = False
        End If

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnAddChamp.Click



        If chkChampSolo.Checked Then
            tbl2Order.Rows.Add(intQtyChamp, lblChamp.Text + " Solo Meal", lblChampSolo.Text)
            btnResetChamp.PerformClick()

        End If

        If chkChampValue.Checked Then
            intValueMealsDrinks += 1 * intQtyChamp
            intValueMealsSides += 1 * intQtyChamp
            intValueMealsFries += 1 * intQtyChamp
            tbl2Order.Rows.Add(intQtyChamp, lblChamp.Text + " Value Meal", lblChampValue.Text)
            btnResetChamp.PerformClick()
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnResetChamp.Click
        chkChampSolo.Checked = False
        chkChampValue.Checked = False
        intQtyChamp = 1
        lblQtyChamp.Text = intQtyChamp
        dblTotalChamp = 120
        lblChampSolo.Text = dblTotalChamp
        dblTotalChamp = 155
        lblChampValue.Text = dblTotalChamp
        btnAddChamp.Enabled = True
    End Sub



    '====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke
    'Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====
    '====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke
    'Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====Coke====



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCoke.SelectedIndexChanged
        If cbxCoke.SelectedIndex = 0 Then


        ElseIf cbxCoke.SelectedIndex = 1 Then


        ElseIf cbxCoke.SelectedIndex = 2 Then


        ElseIf cbxCoke.SelectedIndex = 3 Then


        End If

        picCoke.Focus()
    End Sub

    Private Sub chkCokeReg_CheckedChanged(sender As Object, e As EventArgs) Handles chkCokeReg.CheckedChanged
        If chkCokeReg.Checked = True Then
            chkCokeReg.Checked = True

            If chkCokeLarge.Checked = True Then
                chkCokeLarge.Checked = False
            End If

            If chkCokeLargeU.Checked = True Then
                chkCokeLargeU.Checked = False
            End If

        End If
    End Sub

    Private Sub chkCokeLarge_CheckedChanged(sender As Object, e As EventArgs) Handles chkCokeLarge.CheckedChanged
        If chkCokeLarge.Checked = True Then
            chkCokeLarge.Checked = True

            If chkCokeReg.Checked = True Then
                chkCokeReg.Checked = False
            End If

            If chkCokeLargeU.Checked = True Then
                chkCokeLargeU.Checked = False
            End If

        End If
    End Sub

    Private Sub chkCokeLargeU_CheckedChanged(sender As Object, e As EventArgs) Handles chkCokeLargeU.CheckedChanged
        intQtyCoke = 0
        lblQtyCoke.Text = intQtyCoke

        If chkCokeLargeU.Checked = True Then
            chkCokeLargeU.Checked = True

            If chkCokeReg.Checked = True Then
                chkCokeReg.Checked = False
            End If

            If chkCokeLarge.Checked = True Then
                chkCokeLarge.Checked = False
            End If

            If intQtyCoke <= 0 Then
                intQtyCoke = 0
                btnAddCoke.Enabled = False
            End If

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnCokeUp.Click
        intQtyCoke += 1


        If chkCokeLargeU.Checked And intValueMealsDrinks < intQtyCoke Then
            intQtyCoke = intValueMealsDrinks
        End If

        dblTotalCoke = 28 * intQtyCoke

        lblQtyCoke.Text = intQtyCoke

        lblCokeReg.Text = dblTotalCoke

        dblTotalCoke = 0
        dblTotalCoke = 50 * intQtyCoke

        lblQtyCoke.Text = intQtyCoke


        lblCokeLarge.Text = dblTotalCoke

        dblTotalCoke = 0
        dblTotalCoke = 20 * intQtyCoke

        lblQtyCoke.Text = intQtyCoke


        lblCokeLargeU.Text = dblTotalCoke


        If dblTotalCoke >= 1 Then
            btnAddCoke.Enabled = True
        End If

    End Sub

    Private Sub btnCokeDown_Click(sender As Object, e As EventArgs) Handles btnCokeDown.Click
        intQtyCoke -= 1
        dblTotalCoke = 28 * intQtyCoke

        If dblTotalCoke <= 0 Then
            dblTotalCoke = 0

        End If

        lblCokeReg.Text = dblTotalCoke

        dblTotalCoke = 0
        dblTotalCoke = 50 * intQtyCoke

        If dblTotalCoke <= 0 Then
            dblTotalCoke = 0

        End If

        lblQtyCoke.Text = intQtyCoke

        lblCokeLarge.Text = dblTotalCoke


        lblCokeLarge.Text = dblTotalCoke

        If intQtyCoke <= 0 Then
            intQtyCoke = 0

        End If
        If dblTotalCoke <= 0 Then
            dblTotalCoke = 0

        End If

        dblTotalCoke = 0
        dblTotalCoke = 20 * intQtyCoke

        If dblTotalCoke <= 0 Then
            dblTotalCoke = 0

        End If

        lblQtyCoke.Text = intQtyCoke

        lblCokeLargeU.Text = dblTotalCoke


        lblCokeLargeU.Text = dblTotalCoke

        If intQtyCoke <= 0 Then

            intQtyCoke = 0

        End If
        If dblTotalCoke <= 0 Then
            dblTotalCoke = 0

        End If

        If intQtyCoke <= 0 Then
            intQtyCoke = 0
            btnAddCoke.Enabled = False
        End If

        If intValueMealsDrinks >= lblQtyCoke.Text Then
            btnAddCoke.Enabled = True
        End If

        lblQtyCoke.Text = intQtyCoke
    End Sub

    Private Sub btnAddCoke_Click(sender As Object, e As EventArgs) Handles btnAddCoke.Click
        'Coke
        If cbxCoke.SelectedIndex = 0 Then
            If chkCokeReg.Checked Then
                tbl2Order.Rows.Add(intQtyCoke, "Coke Regular", lblCokeReg.Text)
                'chkCokeReg.Checked = False

            End If

            If chkCokeLarge.Checked Then
                tbl2Order.Rows.Add(intQtyCoke, "Coke Large", lblCokeLarge.Text)
                'chkCokeLarge.Checked = False

            End If

            If chkCokeLargeU.Checked Then
                intValueMealsDrinks -= intQtyCoke
                If intValueMealsDrinks <= 0 Then
                    btnAddCoke.Enabled = False
                End If
                tbl2Order.Rows.Add(intQtyCoke, "Coke Large (Upgrade)", lblCokeLargeU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyCoke.Text Then
                    btnAddCoke.Enabled = False
                End If

            End If

            'Sarsi
        ElseIf cbxCoke.SelectedIndex = 1 Then
            If chkCokeReg.Checked Then
                tbl2Order.Rows.Add(intQtyCoke, "Sarsi Regular", lblCokeReg.Text)
                'chkCokeReg.Checked = False

            End If

            If chkCokeLarge.Checked Then
                tbl2Order.Rows.Add(intQtyCoke, "Sarsi Large", lblCokeLarge.Text)
                'chkCokeLarge.Checked = False

            End If

            If chkCokeLargeU.Checked Then
                intValueMealsDrinks -= intQtyCoke
                If intValueMealsDrinks <= 0 Then
                    btnAddCoke.Enabled = False
                End If
                tbl2Order.Rows.Add(intQtyCoke, "Sarsi Large (Upgrade)", lblCokeLargeU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyCoke.Text Then
                    btnAddCoke.Enabled = False
                End If

            End If

            'Royal
        ElseIf cbxCoke.SelectedIndex = 2 Then
            If chkCokeReg.Checked Then
                tbl2Order.Rows.Add(intQtyCoke, "Royal Regular", lblCokeReg.Text)
                'chkCokeReg.Checked = False

            End If

            If chkCokeLarge.Checked Then
                tbl2Order.Rows.Add(intQtyCoke, "Royal Large", lblCokeLarge.Text)
                'chkCokeLarge.Checked = False

            End If

            If chkCokeLargeU.Checked Then
                intValueMealsDrinks -= intQtyCoke
                If intValueMealsDrinks <= 0 Then
                    btnAddCoke.Enabled = False
                End If
                tbl2Order.Rows.Add(intQtyCoke, "Royal Large (Upgrade)", lblCokeLargeU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyCoke.Text Then
                    btnAddCoke.Enabled = False
                End If

            End If

            'Sprite
        ElseIf cbxCoke.SelectedIndex = 3 Then
            If chkCokeReg.Checked Then
                tbl2Order.Rows.Add(intQtyCoke, "Sprite Regular", lblCokeReg.Text)
                'chkCokeReg.Checked = False

            End If

            If chkCokeLarge.Checked Then
                tbl2Order.Rows.Add(intQtyCoke, "Sprite Large", lblCokeLarge.Text)
                'chkCokeLarge.Checked = False

            End If

            If chkCokeLargeU.Checked Then
                intValueMealsDrinks -= intQtyCoke
                If intValueMealsDrinks <= 0 Then
                    btnAddCoke.Enabled = False
                End If
                tbl2Order.Rows.Add(intQtyCoke, "Sprite Large (Upgrade)", lblCokeLargeU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyCoke.Text Then
                    btnAddCoke.Enabled = False
                End If

            End If

        End If




        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetCoke_Click(sender As Object, e As EventArgs) Handles btnResetCoke.Click
        cbxCoke.SelectedIndex = -1
        chkCokeReg.Checked = False
        chkCokeLarge.Checked = False
        chkCokeLargeU.Checked = False
        btnAddCoke.Enabled = True
        intQtyCoke = 1
        lblQtyCoke.Text = intQtyCoke
        dblTotalCoke = 28
        lblCokeReg.Text = dblTotalCoke
        dblTotalCoke = 50
        lblCokeLarge.Text = dblTotalCoke
        dblTotalCoke = 20
        lblCokeLargeU.Text = dblTotalCoke
    End Sub



    '===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM
    'YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===
    '===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM
    'YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===

    Private Sub chkYumSolo_CheckedChanged(sender As Object, e As EventArgs) Handles chkYumSolo.CheckedChanged
        If chkYumSolo.Checked = True Then
            chkYumSolo.Checked = True

            If chkYumValue.Checked = True Then
                chkYumValue.Checked = False
            End If

        End If
    End Sub

    Private Sub chkYumValue_CheckedChanged(sender As Object, e As EventArgs) Handles chkYumValue.CheckedChanged
        If chkYumValue.Checked = True Then
            chkYumValue.Checked = True

            If chkYumSolo.Checked = True Then
                chkYumSolo.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpYum_Click(sender As Object, e As EventArgs) Handles btnUpYum.Click
        intQtyYum += 1

        dblTotalYum = 30 * intQtyYum

        lblQtyYum.Text = intQtyYum

        lblYumSolo.Text = dblTotalYum

        dblTotalYum = 0
        dblTotalYum = 72 * intQtyYum

        lblQtyYum.Text = intQtyYum


        lblYumValue.Text = dblTotalYum

        If dblTotalYum >= 1 Then
            btnAddYum.Enabled = True
        End If

    End Sub
    Private Sub btnDownYum_Click(sender As Object, e As EventArgs) Handles btnDownYum.Click
        intQtyYum -= 1
        dblTotalYum = 30 * intQtyYum

        If dblTotalYum <= 0 Then
            dblTotalYum = 0

        End If

        lblYumSolo.Text = dblTotalYum

        dblTotalYum = 0
        dblTotalYum = 72 * intQtyYum

        If dblTotalYum <= 0 Then
            dblTotalYum = 0

        End If

        lblQtyYum.Text = intQtyYum

        lblYumValue.Text = dblTotalYum


        lblYumValue.Text = dblTotalYum

        If intQtyYum <= 0 Then

            intQtyYum = 0

        End If
        If dblTotalYum <= 0 Then
            dblTotalYum = 0

        End If

        If intQtyYum <= 0 Then
            intQtyYum = 0
            btnAddYum.Enabled = False
        End If

        lblQtyYum.Text = intQtyYum
    End Sub

    Private Sub btnAddYum_Click(sender As Object, e As EventArgs) Handles btnAddYum.Click
        If chkYumSolo.Checked Then
            tbl2Order.Rows.Add(intQtyYum, lblYum.Text + " Solo Meal", lblYumSolo.Text)
            btnResetYum.PerformClick()

        End If

        If chkYumValue.Checked Then
            intValueMealsDrinks += 1 * intQtyYum
            intValueMealsSides += 1 * intQtyYum
            intValueMealsFries += 1 * intQtyYum
            tbl2Order.Rows.Add(intQtyYum, lblYum.Text + " Value Meal", lblYumValue.Text)
            btnResetYum.PerformClick()
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetYum_Click(sender As Object, e As EventArgs) Handles btnResetYum.Click
        chkYumSolo.Checked = False
        chkYumValue.Checked = False
        btnAddYum.Enabled = True
        intQtyYum = 1
        lblQtyYum.Text = intQtyYum
        dblTotalYum = 30
        lblYumSolo.Text = dblTotalYum
        dblTotalYum = 72
        lblYumValue.Text = dblTotalYum
    End Sub


    '===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM
    'YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===

    Private Sub chkYumSoloC_CheckedChanged(sender As Object, e As EventArgs) Handles chkYumSoloC.CheckedChanged
        If chkYumSoloC.Checked = True Then
            chkYumSoloC.Checked = True

            If chkYumValueC.Checked = True Then
                chkYumValueC.Checked = False
            End If

        End If
    End Sub

    Private Sub chkYumValueC_CheckedChanged(sender As Object, e As EventArgs) Handles chkYumValueC.CheckedChanged
        If chkYumValueC.Checked = True Then
            chkYumValueC.Checked = True

            If chkYumSoloC.Checked = True Then
                chkYumSoloC.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpYumC_Click(sender As Object, e As EventArgs) Handles btnUpYumC.Click
        intQtyYumC += 1

        dblTotalYumC = 40 * intQtyYumC

        lblQtyYumC.Text = intQtyYumC

        lblYumSoloC.Text = dblTotalYumC

        dblTotalYumC = 0
        dblTotalYumC = 82 * intQtyYumC

        lblQtyYumC.Text = intQtyYumC

        lblYumValueC.Text = dblTotalYumC

        If dblTotalYumC >= 1 Then
            btnAddYumC.Enabled = True
        End If

    End Sub

    Private Sub btnDownYumC_Click(sender As Object, e As EventArgs) Handles btnDownYumC.Click
        intQtyYumC -= 1
        dblTotalYumC = 40 * intQtyYumC

        If dblTotalYumC <= 0 Then
            dblTotalYumC = 0

        End If

        lblYumSoloC.Text = dblTotalYumC

        dblTotalYumC = 0
        dblTotalYumC = 82 * intQtyYumC

        If dblTotalYumC <= 0 Then
            dblTotalYumC = 0

        End If

        lblQtyYumC.Text = intQtyYumC

        lblYumValueC.Text = dblTotalYumC


        lblYumValueC.Text = dblTotalYumC

        If intQtyYumC <= 0 Then

            intQtyYumC = 0

        End If
        If dblTotalYumC <= 0 Then
            dblTotalYumC = 0

        End If

        If intQtyYumC <= 0 Then
            intQtyYumC = 0
            btnAddYumC.Enabled = False
        End If

        lblQtyYumC.Text = intQtyYumC
    End Sub

    Private Sub btnAddYumC_Click(sender As Object, e As EventArgs) Handles btnAddYumC.Click
        If chkYumSoloC.Checked Then
            tbl2Order.Rows.Add(intQtyYumC, lblYumC.Text + " Solo Meal", lblYumSoloC.Text)
            btnResetYumC.PerformClick()

        End If

        If chkYumValueC.Checked Then
            intValueMealsDrinks += 1 * intQtyYumC
            intValueMealsSides += 1 * intQtyYumC
            intValueMealsFries += 1 * intQtyYumC
            tbl2Order.Rows.Add(intQtyYumC, lblYumC.Text + " Value Meal", lblYumValueC.Text)
            btnResetYumC.PerformClick()
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetYumC_Click(sender As Object, e As EventArgs) Handles btnResetYumC.Click
        chkYumSoloC.Checked = False
        chkYumValueC.Checked = False
        btnAddYumC.Enabled = True
        intQtyYumC = 1
        lblQtyYumC.Text = intQtyYumC
        dblTotalYumC = 40
        lblYumSoloC.Text = dblTotalYumC
        dblTotalYumC = 82
        lblYumValueC.Text = dblTotalYumC
    End Sub

    '===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM
    'YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===

    Private Sub chkYumSoloTLC_CheckedChanged(sender As Object, e As EventArgs) Handles chkYumSoloTLC.CheckedChanged
        If chkYumSoloTLC.Checked = True Then
            chkYumSoloTLC.Checked = True

            If chkYumValueTLC.Checked = True Then
                chkYumValueTLC.Checked = False
            End If

        End If
    End Sub

    Private Sub chkYumValueTLC_CheckedChanged(sender As Object, e As EventArgs) Handles chkYumValueTLC.CheckedChanged
        If chkYumValueTLC.Checked = True Then
            chkYumValueTLC.Checked = True

            If chkYumSoloTLC.Checked = True Then
                chkYumSoloTLC.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpYumTLC_Click(sender As Object, e As EventArgs) Handles btnUpYumTLC.Click
        intQtyYumTLC += 1

        dblTotalYumTLC = 62 * intQtyYumTLC

        lblQtyYumTLC.Text = intQtyYumTLC

        lblYumSoloTLC.Text = dblTotalYumTLC

        dblTotalYumTLC = 0
        dblTotalYumTLC = 97 * intQtyYumTLC

        lblQtyYumTLC.Text = intQtyYumTLC


        lblYumValueTLC.Text = dblTotalYumTLC

        If dblTotalYumTLC >= 1 Then
            btnAddYumTLC.Enabled = True
        End If

    End Sub

    Private Sub btnDownYumTLC_Click(sender As Object, e As EventArgs) Handles btnDownYumTLC.Click
        intQtyYumTLC -= 1
        dblTotalYumTLC = 62 * intQtyYumTLC

        If dblTotalYumTLC <= 0 Then
            dblTotalYumTLC = 0

        End If

        lblYumSoloTLC.Text = dblTotalYumTLC

        dblTotalYumTLC = 0
        dblTotalYumTLC = 97 * intQtyYumTLC

        If dblTotalYumTLC <= 0 Then
            dblTotalYumTLC = 0

        End If

        lblQtyYumTLC.Text = intQtyYumTLC

        lblYumValueTLC.Text = dblTotalYumTLC


        lblYumValueTLC.Text = dblTotalYumTLC

        If intQtyYumTLC <= 0 Then

            intQtyYumTLC = 0

        End If
        If dblTotalYumTLC <= 0 Then
            dblTotalYumTLC = 0

        End If


        If intQtyYumTLC <= 0 Then
            intQtyYumTLC = 0
            btnAddYumTLC.Enabled = False
        End If


        lblQtyYumTLC.Text = intQtyYumTLC
    End Sub

    Private Sub btnAddYumTLC_Click(sender As Object, e As EventArgs) Handles btnAddYumTLC.Click
        If chkYumSoloTLC.Checked Then
            tbl2Order.Rows.Add(intQtyYumTLC, lblYumTLC.Text + " Solo Meal", lblYumSoloTLC.Text)
            btnResetYumTLC.PerformClick()
        End If

        If chkYumValueTLC.Checked Then
            intValueMealsDrinks += 1 * intQtyYumTLC
            intValueMealsSides += 1 * intQtyYumTLC
            intValueMealsFries += 1 * intQtyYumTLC
            tbl2Order.Rows.Add(intQtyYumTLC, lblYumTLC.Text + " Value Meal", lblYumValueTLC.Text)
            btnResetYumTLC.PerformClick()
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetYumTLC_Click(sender As Object, e As EventArgs) Handles btnResetYumTLC.Click
        chkYumSoloTLC.Checked = False
        chkYumValueTLC.Checked = False
        btnAddYumTLC.Enabled = True
        intQtyYumTLC = 1
        lblQtyYumTLC.Text = intQtyYumTLC
        dblTotalYumTLC = 62
        lblYumSoloTLC.Text = dblTotalYumTLC
        dblTotalYumTLC = 97
        lblYumValueTLC.Text = dblTotalYumTLC
    End Sub

    '===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM
    'YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===

    Private Sub chkYumSoloB_CheckedChanged(sender As Object, e As EventArgs) Handles chkYumSoloB.CheckedChanged
        If chkYumSoloB.Checked = True Then
            chkYumSoloB.Checked = True

            If chkYumValueB.Checked = True Then
                chkYumValueB.Checked = False
            End If

        End If
    End Sub

    Private Sub chkYumValueB_CheckedChanged(sender As Object, e As EventArgs) Handles chkYumValueB.CheckedChanged
        If chkYumValueB.Checked = True Then
            chkYumValueB.Checked = True

            If chkYumSoloB.Checked = True Then
                chkYumSoloB.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpYumB_Click(sender As Object, e As EventArgs) Handles btnUpYumB.Click
        intQtyYumB += 1

        dblTotalYumB = 72 * intQtyYumB

        lblQtyYumB.Text = intQtyYumB

        lblYumSoloB.Text = dblTotalYumB

        dblTotalYumB = 0
        dblTotalYumB = 99 * intQtyYumB

        lblQtyYumB.Text = intQtyYumB


        lblYumValueB.Text = dblTotalYumB

        If dblTotalYumB >= 1 Then
            btnAddYumB.Enabled = True
        End If

    End Sub

    Private Sub btnDownYumB_Click(sender As Object, e As EventArgs) Handles btnDownYumB.Click
        intQtyYumB -= 1
        dblTotalYumB = 72 * intQtyYumB

        If dblTotalYumB <= 0 Then
            dblTotalYumB = 0

        End If

        lblYumSoloB.Text = dblTotalYumB

        dblTotalYumB = 0
        dblTotalYumB = 99 * intQtyYumB

        If dblTotalYumB <= 0 Then
            dblTotalYumB = 0

        End If

        lblQtyYumB.Text = intQtyYumB

        lblYumValueB.Text = dblTotalYumB


        lblYumValueB.Text = dblTotalYumB

        If intQtyYumB <= 0 Then

            intQtyYumB = 0

        End If
        If dblTotalYumB <= 0 Then
            dblTotalYumB = 0

        End If

        If intQtyYumB <= 0 Then
            intQtyYumB = 0
            btnAddYumB.Enabled = False
        End If

        lblQtyYumB.Text = intQtyYumB
    End Sub

    Private Sub btnAddYumB_Click(sender As Object, e As EventArgs) Handles btnAddYumB.Click
        If chkYumSoloB.Checked Then
            tbl2Order.Rows.Add(intQtyYumB, "CBM Yum Solo Meal", lblYumSoloB.Text)
            btnResetYumB.PerformClick()

        End If

        If chkYumValueB.Checked Then
            intValueMealsDrinks += 1 * intQtyYumB
            intValueMealsSides += 1 * intQtyYumB
            intValueMealsFries += 1 * intQtyYumB
            tbl2Order.Rows.Add(intQtyYumB, "CBM Yum Value Meal", lblYumValueB.Text)
            btnResetYumB.PerformClick()
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetYumB_Click(sender As Object, e As EventArgs) Handles btnResetYumB.Click
        chkYumSoloB.Checked = False
        chkYumValueB.Checked = False
        btnAddYumB.Enabled = True
        intQtyYumB = 1
        lblQtyYumB.Text = intQtyYumB
        dblTotalYumB = 72
        lblYumSoloB.Text = dblTotalYumB
        dblTotalYumB = 99
        lblYumValueB.Text = dblTotalYumB
    End Sub

    '===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM
    'YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===YUM===

    Private Sub chkDogSolo_CheckedChanged(sender As Object, e As EventArgs) Handles chkDogSolo.CheckedChanged
        If chkDogSolo.Checked = True Then
            chkDogSolo.Checked = True

            If chkDogValue.Checked = True Then
                chkDogValue.Checked = False
            End If

        End If
    End Sub

    Private Sub chkDogValue_CheckedChanged(sender As Object, e As EventArgs) Handles chkDogValue.CheckedChanged
        If chkDogValue.Checked = True Then
            chkDogValue.Checked = True

            If chkDogSolo.Checked = True Then
                chkDogSolo.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpDog_Click(sender As Object, e As EventArgs) Handles btnUpDog.Click
        intQtyDog += 1

        dblTotalDog = 50 * intQtyDog

        lblQtyDog.Text = intQtyDog

        lblDogSolo.Text = dblTotalDog

        dblTotalDog = 0
        dblTotalDog = 87 * intQtyDog

        lblQtyDog.Text = intQtyDog


        lblDogValue.Text = dblTotalDog

        If dblTotalDog >= 1 Then
            btnAddDog.Enabled = True
        End If
    End Sub

    Private Sub btnDownDog_Click(sender As Object, e As EventArgs) Handles btnDownDog.Click
        intQtyDog -= 1
        dblTotalDog = 50 * intQtyDog

        If dblTotalDog <= 0 Then
            dblTotalDog = 0

        End If

        lblDogSolo.Text = dblTotalDog

        dblTotalDog = 0
        dblTotalDog = 87 * intQtyDog

        If dblTotalDog <= 0 Then
            dblTotalDog = 0

        End If

        lblQtyDog.Text = intQtyDog

        lblDogValue.Text = dblTotalDog


        lblDogValue.Text = dblTotalDog

        If intQtyDog <= 0 Then

            intQtyDog = 0

        End If
        If dblTotalDog <= 0 Then
            dblTotalDog = 0

        End If

        If intQtyDog <= 0 Then
            intQtyDog = 0
            btnAddDog.Enabled = False
        End If

        lblQtyDog.Text = intQtyDog
    End Sub

    Private Sub btnAddDog_Click(sender As Object, e As EventArgs) Handles btnAddDog.Click
        If chkDogSolo.Checked Then
            tbl2Order.Rows.Add(intQtyDog, "Jolly Hotdog C Solo Meal", lblDogSolo.Text)
            btnResetDog.PerformClick()

        End If

        If chkDogValue.Checked Then
            intValueMealsDrinks += 1 * intQtyDog
            intValueMealsSides += 1 * intQtyDog
            intValueMealsFries += 1 * intQtyDog
            tbl2Order.Rows.Add(intQtyDog, "Jolly Hotdog C Value Meal", lblDogValue.Text)
            btnResetDog.PerformClick()
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetDog_Click(sender As Object, e As EventArgs) Handles btnResetDog.Click
        chkDogSolo.Checked = False
        chkDogValue.Checked = False
        btnAddDog.Enabled = True
        intQtyDog = 1
        lblQtyDog.Text = intQtyDog
        dblTotalDog = 50
        lblDogSolo.Text = dblTotalDog
        dblTotalDog = 87
        lblDogValue.Text = dblTotalDog
    End Sub

    '=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float
    'Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====
    '=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float
    'Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====Float=====

    Private Sub cbxFloat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFloat.SelectedIndexChanged
        If cbxFloat.SelectedIndex = 0 Then


        ElseIf cbxFloat.SelectedIndex = 1 Then


        ElseIf cbxFloat.SelectedIndex = 2 Then


        ElseIf cbxFloat.SelectedIndex = 3 Then


        End If

        picFloat.Focus()
    End Sub


    Private Sub chkFloatReg_CheckedChanged(sender As Object, e As EventArgs) Handles chkFloatReg.CheckedChanged
        If chkFloatReg.Checked = True Then
            chkFloatReg.Checked = True

            If chkFloatLarge.Checked = True Then
                chkFloatLarge.Checked = False
            End If

            If chkFloatLargeU.Checked = True Then
                chkFloatLargeU.Checked = False
            End If

            If chkFloatRegU.Checked = True Then
                chkFloatRegU.Checked = False
            End If


        End If
    End Sub

    Private Sub chkFloatLarge_CheckedChanged(sender As Object, e As EventArgs) Handles chkFloatLarge.CheckedChanged
        If chkFloatLarge.Checked = True Then
            chkFloatLarge.Checked = True

            If chkFloatReg.Checked = True Then
                chkFloatReg.Checked = False
            End If

            If chkFloatLargeU.Checked = True Then
                chkFloatLargeU.Checked = False
            End If

            If chkFloatRegU.Checked = True Then
                chkFloatRegU.Checked = False
            End If


        End If
    End Sub

    Private Sub chkFloatRegU_CheckedChanged(sender As Object, e As EventArgs) Handles chkFloatRegU.CheckedChanged
        intQtyFloat = 0
        lblQtyFloat.Text = intQtyFloat

        If chkFloatRegU.Checked = True Then
            chkFloatRegU.Checked = True

            If chkFloatLarge.Checked = True Then
                chkFloatLarge.Checked = False
            End If

            If chkFloatLargeU.Checked = True Then
                chkFloatLargeU.Checked = False
            End If

            If chkFloatReg.Checked = True Then
                chkFloatReg.Checked = False
            End If

            If intQtyFloat <= 0 Then
                intQtyFloat = 0
                btnAddFloat.Enabled = False
            End If

        End If
    End Sub

    Private Sub chkFloatLargeU_CheckedChanged(sender As Object, e As EventArgs) Handles chkFloatLargeU.CheckedChanged
        intQtyFloat = 0
        lblQtyFloat.Text = intQtyFloat

        If chkFloatLargeU.Checked = True Then
            chkFloatLargeU.Checked = True

            If chkFloatReg.Checked = True Then
                chkFloatReg.Checked = False
            End If

            If chkFloatLarge.Checked = True Then
                chkFloatLarge.Checked = False
            End If

            If chkFloatRegU.Checked = True Then
                chkFloatRegU.Checked = False
            End If

            If intQtyFloat <= 0 Then
                intQtyFloat = 0
                btnAddFloat.Enabled = False
            End If

        End If
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles btnFloatUp.Click
        intQtyFloat += 1


        If chkFloatLargeU.Checked And intValueMealsDrinks < intQtyFloat Then
            intQtyFloat = intValueMealsDrinks
        End If

        If chkFloatRegU.Checked And intValueMealsDrinks < intQtyFloat Then
            intQtyFloat = intValueMealsDrinks
        End If

        dblTotalFloat = 35 * intQtyFloat

        lblQtyFloat.Text = intQtyFloat

        lblFloatReg.Text = dblTotalFloat

        dblTotalFloat = 0
        dblTotalFloat = 62 * intQtyFloat

        lblQtyFloat.Text = intQtyFloat


        lblFloatLarge.Text = dblTotalFloat

        dblTotalFloat = 0
        dblTotalFloat = 15 * intQtyFloat

        lblQtyFloat.Text = intQtyFloat


        lblFloatRegU.Text = dblTotalFloat

        dblTotalFloat = 0
        dblTotalFloat = 25 * intQtyFloat

        lblQtyFloat.Text = intQtyFloat


        lblFloatLargeU.Text = dblTotalFloat


        If dblTotalFloat >= 1 Then
            btnAddFloat.Enabled = True
        End If
    End Sub

    Private Sub btnFloatDown_Click(sender As Object, e As EventArgs) Handles btnFloatDown.Click
        intQtyFloat -= 1
        dblTotalFloat = 35 * intQtyFloat

        If dblTotalFloat <= 0 Then
            dblTotalFloat = 0
            btnAddFloat.Enabled = False
        End If

        lblFloatReg.Text = dblTotalFloat

        dblTotalFloat = 0
        dblTotalFloat = 62 * intQtyFloat

        If dblTotalFloat <= 0 Then
            dblTotalFloat = 0

        End If

        lblQtyFloat.Text = intQtyFloat

        lblFloatLarge.Text = dblTotalFloat


        lblFloatLarge.Text = dblTotalFloat

        If intQtyFloat <= 0 Then
            intQtyFloat = 0

        End If
        If dblTotalFloat <= 0 Then
            dblTotalFloat = 0
            btnAddFloat.Enabled = False
        End If

        dblTotalFloat = 0
        dblTotalFloat = 15 * intQtyFloat

        If dblTotalFloat <= 0 Then
            dblTotalFloat = 0
            btnAddFloat.Enabled = False
        End If

        lblQtyFloat.Text = intQtyFloat

        lblFloatRegU.Text = dblTotalFloat


        lblFloatRegU.Text = dblTotalFloat

        dblTotalFloat = 0
        dblTotalFloat = 25 * intQtyFloat

        If dblTotalFloat <= 0 Then
            dblTotalFloat = 0
            btnAddFloat.Enabled = False
        End If

        lblQtyFloat.Text = intQtyFloat

        lblFloatLargeU.Text = dblTotalFloat

        lblFloatLargeU.Text = dblTotalFloat

        If intQtyFloat <= 0 Then

            intQtyFloat = 0
            btnAddFloat.Enabled = False
        End If
        If dblTotalFloat <= 0 Then
            dblTotalFloat = 0
            btnAddFloat.Enabled = False
        End If

        If intQtyFloat <= 0 Then
            intQtyFloat = 0
            btnAddFloat.Enabled = False
        End If

        If intValueMealsDrinks >= lblQtyFloat.Text Then
            btnAddFloat.Enabled = True
        End If


        lblQtyFloat.Text = intQtyFloat
    End Sub

    Private Sub btnAddFloat_Click(sender As Object, e As EventArgs) Handles btnAddFloat.Click
        'Coke
        If cbxFloat.SelectedIndex = 0 Then
            If chkFloatReg.Checked Then
                tbl2Order.Rows.Add(intQtyFloat, "Coke Float Regular", lblFloatReg.Text)
                'chkCokeReg.Checked = False

            End If

            If chkFloatLarge.Checked Then
                tbl2Order.Rows.Add(intQtyFloat, "Coke Float Large", lblFloatLarge.Text)
                'chkCokeLarge.Checked = False

            End If

            If chkFloatLargeU.Checked Then
                intValueMealsDrinks -= intQtyFloat
                If intValueMealsDrinks <= 0 Then
                    btnAddFloat.Enabled = False
                End If

                tbl2Order.Rows.Add(intQtyFloat, "Coke Float Large (Upgrade)", lblFloatLargeU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyFloat.Text Then
                    btnAddFloat.Enabled = False
                End If

            End If

            If chkFloatRegU.Checked Then
                intValueMealsDrinks -= intQtyFloat
                If intValueMealsDrinks <= 0 Then
                    btnAddFloat.Enabled = False
                End If

                tbl2Order.Rows.Add(intQtyFloat, "Coke Float Regular (Upgrade)", lblFloatRegU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyFloat.Text Then
                    btnAddFloat.Enabled = False
                End If

            End If

            'Sarsi
        ElseIf cbxFloat.SelectedIndex = 1 Then
            If chkFloatReg.Checked Then
                tbl2Order.Rows.Add(intQtyFloat, "Sarsi Float Regular", lblFloatReg.Text)
                'chkCokeReg.Checked = False

            End If

            If chkFloatLarge.Checked Then
                tbl2Order.Rows.Add(intQtyFloat, "Sarsi Float Large", lblFloatLarge.Text)
                'chkCokeLarge.Checked = False

            End If

            If chkFloatLargeU.Checked Then
                intValueMealsDrinks -= intQtyFloat
                If intValueMealsDrinks <= 0 Then
                    btnAddFloat.Enabled = False
                End If

                tbl2Order.Rows.Add(intQtyFloat, "Sarsi Float Large (Upgrade)", lblFloatLargeU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyFloat.Text Then
                    btnAddFloat.Enabled = False
                End If

            End If

            If chkFloatRegU.Checked Then
                intValueMealsDrinks -= intQtyFloat
                If intValueMealsDrinks <= 0 Then
                    btnAddFloat.Enabled = False
                End If

                tbl2Order.Rows.Add(intQtyFloat, "Sarsi Float Regular (Upgrade)", lblFloatRegU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyFloat.Text Then
                    btnAddFloat.Enabled = False
                End If

            End If

            'Royal
        ElseIf cbxFloat.SelectedIndex = 2 Then
            If chkFloatReg.Checked Then
                tbl2Order.Rows.Add(intQtyFloat, "Royal Float Regular", lblFloatReg.Text)
                'chkCokeReg.Checked = False

            End If

            If chkFloatLarge.Checked Then
                tbl2Order.Rows.Add(intQtyFloat, "Royal Float Large", lblFloatLarge.Text)
                'chkCokeLarge.Checked = False

            End If

            If chkFloatLargeU.Checked Then
                intValueMealsDrinks -= intQtyFloat
                If intValueMealsDrinks <= 0 Then
                    btnAddFloat.Enabled = False
                End If

                tbl2Order.Rows.Add(intQtyFloat, "Royal Float Large (Upgrade)", lblFloatLargeU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyFloat.Text Then
                    btnAddFloat.Enabled = False
                End If

            End If

            If chkFloatRegU.Checked Then
                intValueMealsDrinks -= intQtyFloat
                If intValueMealsDrinks <= 0 Then
                    btnAddFloat.Enabled = False
                End If

                tbl2Order.Rows.Add(intQtyFloat, "Royal Float Regular (Upgrade)", lblFloatRegU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyFloat.Text Then
                    btnAddFloat.Enabled = False
                End If

            End If

            'Caramel
        ElseIf cbxFloat.SelectedIndex = 3 Then
            If chkFloatReg.Checked Then
                tbl2Order.Rows.Add(intQtyFloat, "Caramel Float Regular", lblFloatReg.Text)
                'chkCokeReg.Checked = False

            End If

            If chkFloatLarge.Checked Then
                tbl2Order.Rows.Add(intQtyFloat, "Caramel Float Large", lblFloatLarge.Text)
                'chkCokeLarge.Checked = False

            End If

            If chkFloatLargeU.Checked Then
                intValueMealsDrinks -= intQtyFloat
                If intValueMealsDrinks <= 0 Then
                    btnAddFloat.Enabled = False
                End If

                tbl2Order.Rows.Add(intQtyFloat, "Caramel Float Large (Upgrade)", lblFloatLargeU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyFloat.Text Then
                    btnAddFloat.Enabled = False
                End If

            End If

            If chkFloatRegU.Checked Then
                intValueMealsDrinks -= intQtyFloat
                If intValueMealsDrinks <= 0 Then
                    btnAddFloat.Enabled = False
                End If

                tbl2Order.Rows.Add(intQtyFloat, "Caramel Float Regular (Upgrade)", lblFloatRegU.Text)
                'chkCokeLargeU.Checked = False

                If intValueMealsDrinks < lblQtyFloat.Text Then
                    btnAddFloat.Enabled = False

                End If
            End If

        End If



        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnDownFloat_Click(sender As Object, e As EventArgs) Handles btnResetFloat.Click
        cbxFloat.SelectedIndex = -1
        chkFloatReg.Checked = False
        chkFloatLarge.Checked = False
        chkFloatLargeU.Checked = False
        chkFloatRegU.Checked = False
        btnAddFloat.Enabled = True
        intQtyFloat = 1
        lblQtyFloat.Text = intQtyFloat
        dblTotalFloat = 35
        lblFloatReg.Text = dblTotalFloat
        dblTotalFloat = 62
        lblFloatLarge.Text = dblTotalFloat
        dblTotalFloat = 15
        lblFloatRegU.Text = dblTotalFloat
        dblTotalFloat = 25
        lblFloatLargeU.Text = dblTotalFloat
    End Sub


    'SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======
    '======SUNDAE======TWIRL=======SUNDAE======SUNDAE======TWIRL=======SUNDAE======SUNDAE======TWIRL=======SUNDAE======SUNDAE======TWIRL=======SUNDAE======SUNDAE======TWIRL=======SUNDAE
    'SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======SUNDAE======TWIRL======
    '======SUNDAE======TWIRL=======SUNDAE======SUNDAE======TWIRL=======SUNDAE======SUNDAE======TWIRL=======SUNDAE======SUNDAE======TWIRL=======SUNDAE======SUNDAE======TWIRL=======SUNDAE


    Private Sub chkSundaeChoco_CheckedChanged(sender As Object, e As EventArgs) Handles chkSundaeChoco.CheckedChanged
        If chkSundaeChoco.Checked = True Then
            chkSundaeChoco.Checked = True

            If chkSundaeSB.Checked = True Then
                chkSundaeSB.Checked = False
            End If

            If chkTwirlChoco.Checked = True Then
                chkTwirlChoco.Checked = False
            End If

            If chkTwirlV.Checked = True Then
                chkTwirlV.Checked = False
            End If

        End If
    End Sub

    Private Sub chkSundaeSB_CheckedChanged(sender As Object, e As EventArgs) Handles chkSundaeSB.CheckedChanged
        If chkSundaeSB.Checked = True Then
            chkSundaeSB.Checked = True

            If chkSundaeChoco.Checked = True Then
                chkSundaeChoco.Checked = False
            End If

            If chkTwirlChoco.Checked = True Then
                chkTwirlChoco.Checked = False
            End If

            If chkTwirlV.Checked = True Then
                chkTwirlV.Checked = False
            End If

        End If
    End Sub

    Private Sub chkTwirlV_CheckedChanged(sender As Object, e As EventArgs) Handles chkTwirlV.CheckedChanged
        If chkTwirlV.Checked = True Then
            chkTwirlV.Checked = True

            If chkTwirlChoco.Checked = True Then
                chkTwirlChoco.Checked = True
            End If
            If chkSundaeSB.Checked = True Then
                chkSundaeSB.Checked = False
            End If

            If chkSundaeChoco.Checked = True Then
                chkSundaeChoco.Checked = False
            End If

            If chkTwirlChoco.Checked = True Then
                chkTwirlChoco.Checked = False
            End If

        End If
    End Sub

    Private Sub chkTwirlChoco_CheckedChanged(sender As Object, e As EventArgs) Handles chkTwirlChoco.CheckedChanged
        If chkTwirlChoco.Checked = True Then
            chkTwirlChoco.Checked = True


            If chkSundaeSB.Checked = True Then
                chkSundaeSB.Checked = False
            End If

            If chkSundaeChoco.Checked = True Then
                chkSundaeChoco.Checked = False
            End If

            If chkTwirlV.Checked = True Then
                chkTwirlV.Checked = False
            End If

        End If
    End Sub

    Private Sub Button5_Click_3(sender As Object, e As EventArgs) Handles btnSundaeUp.Click
        intQtySundae += 1

        dblTotalSundae = 28 * intQtySundae

        lblQtySundae.Text = intQtySundae

        lblSundaeChoco.Text = dblTotalSundae

        dblTotalSundae = 0
        dblTotalSundae = 28 * intQtySundae

        lblQtySundae.Text = intQtySundae


        lblSundaeSB.Text = dblTotalSundae

        dblTotalSundae = 0
        dblTotalSundae = 13 * intQtySundae

        lblQtySundae.Text = intQtySundae


        lblTwirlV.Text = dblTotalSundae

        dblTotalSundae = 0
        dblTotalSundae = 18 * intQtySundae

        lblQtySundae.Text = intQtySundae


        lblTwirlChoco.Text = dblTotalSundae

        If dblTotalSundae >= 1 Then
            btnAddSundae.Enabled = True
        End If

    End Sub

    Private Sub btnSundaeDown_Click(sender As Object, e As EventArgs) Handles btnSundaeDown.Click
        intQtySundae -= 1
        dblTotalSundae = 28 * intQtySundae

        If dblTotalSundae <= 0 Then
            dblTotalSundae = 0

        End If

        lblSundaeChoco.Text = dblTotalSundae

        dblTotalSundae = 0
        dblTotalSundae = 28 * intQtySundae

        If dblTotalSundae <= 0 Then
            dblTotalSundae = 0

        End If

        lblQtySundae.Text = intQtySundae

        lblSundaeSB.Text = dblTotalSundae


        lblSundaeSB.Text = dblTotalSundae

        If intQtySundae <= 0 Then
            intQtySundae = 0

        End If
        If dblTotalSundae <= 0 Then
            dblTotalSundae = 0

        End If

        dblTotalSundae = 0
        dblTotalSundae = 13 * intQtySundae

        If dblTotalSundae <= 0 Then
            dblTotalSundae = 0

        End If

        lblQtySundae.Text = intQtySundae

        lblTwirlV.Text = dblTotalSundae


        lblTwirlV.Text = dblTotalSundae

        dblTotalSundae = 0
        dblTotalSundae = 18 * intQtySundae

        If dblTotalSundae <= 0 Then
            dblTotalSundae = 0

        End If

        lblQtySundae.Text = intQtySundae

        lblTwirlChoco.Text = dblTotalSundae


        lblTwirlChoco.Text = dblTotalSundae

        If intQtySundae <= 0 Then

            intQtySundae = 0

        End If
        If dblTotalSundae <= 0 Then
            dblTotalSundae = 0

        End If

        If intQtySundae <= 0 Then
            intQtySundae = 0
            btnAddSundae.Enabled = False
        End If


        lblQtySundae.Text = intQtySundae

    End Sub

    Private Sub btnAddSundae_Click(sender As Object, e As EventArgs) Handles btnAddSundae.Click

        If chkSundaeChoco.Checked Then
            tbl2Order.Rows.Add(intQtySundae, "Chocolate Sundae", lblSundaeChoco.Text)
            btnResetSundae.PerformClick()

        End If

        If chkSundaeSB.Checked Then
            tbl2Order.Rows.Add(intQtySundae, "Strawberry Sundae", lblSundaeSB.Text)
            btnResetSundae.PerformClick()
        End If

        If chkTwirlV.Checked Then
            tbl2Order.Rows.Add(intQtySundae, "Vanilla Twirl", lblTwirlV.Text)
            btnResetSundae.PerformClick()
        End If

        If chkTwirlChoco.Checked Then
            tbl2Order.Rows.Add(intQtySundae, "Chocolate Twirl", lblTwirlChoco.Text)
            btnResetSundae.PerformClick()
        End If


        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")


    End Sub

    Private Sub btnResetSundae_Click(sender As Object, e As EventArgs) Handles btnResetSundae.Click
        chkSundaeChoco.Checked = False
        chkSundaeSB.Checked = False
        chkTwirlChoco.Checked = False
        chkTwirlV.Checked = False
        btnAddSundae.Enabled = True
        intQtySundae = 1
        lblQtySundae.Text = intQtySundae
        dblTotalSundae = 28
        lblSundaeChoco.Text = dblTotalSundae
        dblTotalSundae = 28
        lblSundaeSB.Text = dblTotalSundae
        dblTotalSundae = 13
        lblTwirlV.Text = dblTotalSundae
        dblTotalSundae = 18
        lblTwirlChoco.Text = dblTotalSundae

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCJ.Click
        tab00.SelectedTab = tabCJ
    End Sub

    Private Sub btnBS_Click(sender As Object, e As EventArgs) Handles btnBS.Click
        tab00.SelectedTab = tabBS
    End Sub

    Private Sub btnDD_Click(sender As Object, e As EventArgs) Handles btnDD.Click
        tab00.SelectedTab = tabDD
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSS.Click
        tab00.SelectedTab = tabSS
    End Sub

    'CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==
    '==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ
    'CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==
    '==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ


    Private Sub lblCJ1S_Click(sender As Object, e As EventArgs) Handles lblCJ1S.Click
        picCJ1S.Visible = True
        boolSpicy = True
    End Sub

    Private Sub lblCJ1O_Click(sender As Object, e As EventArgs) Handles lblCJ1O.Click
        picCJ1S.Visible = False
        boolSpicy = False
    End Sub

    Private Sub lblCJ2S_Click(sender As Object, e As EventArgs) Handles lblCJ2S.Click
        picCJ2S.Visible = True
        boolSpicy = True
    End Sub

    Private Sub lblCJ2O_Click(sender As Object, e As EventArgs) Handles lblCJ2O.Click
        picCJ2S.Visible = False
        boolSpicy = False
    End Sub

    Private Sub lblCJSpagS_Click(sender As Object, e As EventArgs) Handles lblCJSpagS.Click
        picCJSpagS.Visible = True
        boolSpicy = True
    End Sub

    Private Sub lblCJSpagO_Click(sender As Object, e As EventArgs) Handles lblCJSpagO.Click
        picCJSpagS.Visible = False
        boolSpicy = False
    End Sub

    Private Sub lblCJPalS_Click(sender As Object, e As EventArgs) Handles lblCJPalS.Click
        picCJPalS.Visible = True
        boolSpicy = True
    End Sub

    Private Sub lblCJPalO_Click(sender As Object, e As EventArgs) Handles lblCJPalO.Click
        picCJPalS.Visible = False
        boolSpicy = False
    End Sub

    'CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==
    '==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ


    Private Sub chkCJ1Solo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCJ1Solo.CheckedChanged
        If chkCJ1Solo.Checked = True Then
            chkCJ1Solo.Checked = True

            If chkCJ1Value.Checked = True Then
                chkCJ1Value.Checked = False
            End If

        End If
    End Sub

    Private Sub chkCJ1Value_CheckedChanged(sender As Object, e As EventArgs) Handles chkCJ1Value.CheckedChanged
        If chkCJ1Value.Checked = True Then
            chkCJ1Value.Checked = True

            If chkCJ1Solo.Checked = True Then
                chkCJ1Solo.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpCJ1_Click(sender As Object, e As EventArgs) Handles btnUpCJ1.Click
        intQtyCJ1 += 1

        dblTotalCJ1 = 82 * intQtyCJ1

        lblQtyCJ1.Text = intQtyCJ1

        lblCJ1Solo.Text = dblTotalCJ1

        dblTotalCJ1 = 0
        dblTotalCJ1 = 85 * intQtyCJ1

        lblQtyCJ1.Text = intQtyCJ1


        lblCJ1Value.Text = dblTotalCJ1


        If dblTotalCJ1 >= 1 Then
            btnAddCJ1.Enabled = True
        End If

    End Sub

    Private Sub btnDownCJ1_Click(sender As Object, e As EventArgs) Handles btnDownCJ1.Click
        intQtyCJ1 -= 1
        dblTotalCJ1 = 82 * intQtyCJ1

        If dblTotalCJ1 <= 0 Then
            dblTotalCJ1 = 0

        End If

        lblCJ1Solo.Text = dblTotalCJ1

        dblTotalCJ1 = 0
        dblTotalCJ1 = 85 * intQtyCJ1

        If dblTotalCJ1 <= 0 Then
            dblTotalCJ1 = 0

        End If

        lblQtyCJ1.Text = intQtyCJ1

        lblCJ1Value.Text = dblTotalCJ1


        lblCJ1Value.Text = dblTotalCJ1

        If intQtyCJ1 <= 0 Then

            intQtyCJ1 = 0

        End If
        If dblTotalCJ1 <= 0 Then
            dblTotalCJ1 = 0

        End If
        lblQtyCJ1.Text = intQtyCJ1


        If intQtyCJ1 <= 0 Then
            intQtyCJ1 = 0
            btnAddCJ1.Enabled = False
        End If
    End Sub

    Private Sub btnAddCJ1_Click(sender As Object, e As EventArgs) Handles btnAddCJ1.Click

        If chkCJ1Solo.Checked Then

            If boolSpicy = False Then

                tbl2Order.Rows.Add(intQtyCJ1, "1-pc CJ Solo Meal", lblCJ1Solo.Text)
                btnResetCJ1.PerformClick()
            End If

            If boolSpicy = True Then

                tbl2Order.Rows.Add(intQtyCJ1, "1-pc SPC CJ Solo Meal", lblCJ1Solo.Text)
                btnResetCJ1.PerformClick()
            End If


        End If

        If chkCJ1Value.Checked Then

            If boolSpicy = False Then

                intValueMealsDrinks += 1 * intQtyCJ1
                intValueMealsSides += 1 * intQtyCJ1
                tbl2Order.Rows.Add(intQtyCJ1, "1-pc CJ Value Meal", lblCJ1Value.Text)
                btnResetCJ1.PerformClick()
            End If

            If boolSpicy = True Then

                intValueMealsDrinks += 1 * intQtyCJ1
                intValueMealsSides += 1 * intQtyCJ1
                tbl2Order.Rows.Add(intQtyCJ1, "1-pc SPC CJ Value Meal", lblCJ1Value.Text)
                btnResetCJ1.PerformClick()

            End If

        End If
        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")

    End Sub

    Private Sub btnResetCJ1_Click(sender As Object, e As EventArgs) Handles btnResetCJ1.Click
        chkCJ1Solo.Checked = False
        chkCJ1Value.Checked = False
        boolSpicy = False
        picCJ1S.Visible = False
        intQtyCJ1 = 1
        lblQtyCJ1.Text = intQtyCJ1
        dblTotalCJ1 = 82
        lblCJ1Solo.Text = dblTotalCJ1
        dblTotalCJ1 = 85
        lblCJ1Value.Text = dblTotalCJ1
        btnAddCJ1.Enabled = True
    End Sub

    'CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==
    '==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ

    Private Sub chkCJ2Solo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCJ2Solo.CheckedChanged
        If chkCJ2Solo.Checked = True Then
            chkCJ2Solo.Checked = True

            If chkCJ2Value.Checked = True Then
                chkCJ2Value.Checked = False
            End If

        End If
    End Sub

    Private Sub chkCJ2Value_CheckedChanged(sender As Object, e As EventArgs) Handles chkCJ2Value.CheckedChanged
        If chkCJ2Value.Checked = True Then
            chkCJ2Value.Checked = True

            If chkCJ2Solo.Checked = True Then
                chkCJ2Solo.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpCJ2_Click(sender As Object, e As EventArgs) Handles btnUpCJ2.Click
        intQtyCJ2 += 1

        dblTotalCJ2 = 142 * intQtyCJ2

        lblQtyCJ2.Text = intQtyCJ2

        lblCJ2Solo.Text = dblTotalCJ2

        dblTotalCJ2 = 0
        dblTotalCJ2 = 145 * intQtyCJ2

        lblQtyCJ2.Text = intQtyCJ2


        lblCJ2Value.Text = dblTotalCJ2


        If dblTotalCJ2 >= 1 Then
            btnAddCJ2.Enabled = True
        End If
    End Sub

    Private Sub btnDownCJ2_Click(sender As Object, e As EventArgs) Handles btnDownCJ2.Click
        intQtyCJ2 -= 1
        dblTotalCJ2 = 142 * intQtyCJ2

        If dblTotalCJ2 <= 0 Then
            dblTotalCJ2 = 0

        End If

        lblCJ2Solo.Text = dblTotalCJ2

        dblTotalCJ2 = 0
        dblTotalCJ2 = 145 * intQtyCJ2

        If dblTotalCJ2 <= 0 Then
            dblTotalCJ2 = 0

        End If

        lblQtyCJ2.Text = intQtyCJ2

        lblCJ2Value.Text = dblTotalCJ2


        lblCJ2Value.Text = dblTotalCJ2

        If intQtyCJ2 <= 0 Then

            intQtyCJ2 = 0

        End If
        If dblTotalCJ2 <= 0 Then
            dblTotalCJ2 = 0

        End If
        lblQtyCJ2.Text = intQtyCJ2

        If intQtyCJ2 <= 0 Then
            intQtyCJ2 = 0
            btnAddCJ2.Enabled = False
        End If
    End Sub

    Private Sub btnAddCJ2_Click(sender As Object, e As EventArgs) Handles btnAddCJ2.Click
        If chkCJ2Solo.Checked Then

            If boolSpicy = False Then

                tbl2Order.Rows.Add(intQtyCJ2, "2-pc CJ Solo Meal", lblCJ2Solo.Text)
                btnResetCJ2.PerformClick()
            End If

            If boolSpicy = True Then

                tbl2Order.Rows.Add(intQtyCJ2, "2-pc SPC CJ Solo Meal", lblCJ2Solo.Text)
                btnResetCJ2.PerformClick()
            End If


        End If

        If chkCJ2Value.Checked Then

            If boolSpicy = False Then

                intValueMealsDrinks += 1 * intQtyCJ2
                intValueMealsSides += 1 * intQtyCJ2
                tbl2Order.Rows.Add(intQtyCJ2, "2-pc CJ Value Meal", lblCJ2Value.Text)
                btnResetCJ2.PerformClick()
            End If

            If boolSpicy = True Then

                intValueMealsDrinks += 1 * intQtyCJ2
                intValueMealsSides += 1 * intQtyCJ2
                tbl2Order.Rows.Add(intQtyCJ2, "2-pc SPC CJ Value Meal", lblCJ2Value.Text)
                btnResetCJ2.PerformClick()
            End If

        End If
        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetCJ2_Click(sender As Object, e As EventArgs) Handles btnResetCJ2.Click

        chkCJ2Solo.Checked = False
        chkCJ2Value.Checked = False
        boolSpicy = False
        picCJ2S.Visible = False
        intQtyCJ2 = 1
        lblQtyCJ2.Text = intQtyCJ2
        dblTotalCJ2 = 142
        lblCJ2Solo.Text = dblTotalCJ2
        dblTotalCJ2 = 145
        lblCJ2Value.Text = dblTotalCJ2
        btnAddCJ2.Enabled = True
    End Sub

    'CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==
    '==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ

    Private Sub chkCJSpagSolo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCJSpagSolo.CheckedChanged
        If chkCJSpagSolo.Checked = True Then
            chkCJSpagSolo.Checked = True

            If chkCJSpagValue.Checked = True Then
                chkCJSpagValue.Checked = False
            End If

        End If
    End Sub

    Private Sub chkCJSpagValue_CheckedChanged(sender As Object, e As EventArgs) Handles chkCJSpagValue.CheckedChanged
        If chkCJSpagValue.Checked = True Then
            chkCJSpagValue.Checked = True

            If chkCJSpagSolo.Checked = True Then
                chkCJSpagSolo.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpCJSpag_Click(sender As Object, e As EventArgs) Handles btnUpCJSpag.Click
        intQtyCJSpag += 1

        dblTotalCJSpag = 117 * intQtyCJSpag

        lblQtyCJSpag.Text = intQtyCJSpag

        lblCJSpagSolo.Text = dblTotalCJSpag

        dblTotalCJSpag = 0
        dblTotalCJSpag = 120 * intQtyCJSpag

        lblQtyCJSpag.Text = intQtyCJSpag


        lblCJSpagValue.Text = dblTotalCJSpag


        If dblTotalCJSpag >= 1 Then
            btnAddCJSpag.Enabled = True
        End If
    End Sub

    Private Sub btnDownCJSpag_Click(sender As Object, e As EventArgs) Handles btnDownCJSpag.Click
        intQtyCJSpag -= 1
        dblTotalCJSpag = 117 * intQtyCJSpag

        If dblTotalCJSpag <= 0 Then
            dblTotalCJSpag = 0

        End If

        lblCJSpagSolo.Text = dblTotalCJSpag

        dblTotalCJSpag = 0
        dblTotalCJSpag = 120 * intQtyCJSpag

        If dblTotalCJSpag <= 0 Then
            dblTotalCJSpag = 0

        End If

        lblQtyCJSpag.Text = intQtyCJSpag

        lblCJSpagValue.Text = dblTotalCJSpag


        lblCJSpagValue.Text = dblTotalCJSpag

        If intQtyCJSpag <= 0 Then

            intQtyCJSpag = 0

        End If
        If dblTotalCJSpag <= 0 Then
            dblTotalCJSpag = 0

        End If
        lblQtyCJSpag.Text = intQtyCJSpag


        If intQtyCJSpag <= 0 Then
            intQtyCJSpag = 0
            btnAddCJSpag.Enabled = False
        End If
    End Sub

    Private Sub btnAddCJSpag_Click(sender As Object, e As EventArgs) Handles btnAddCJSpag.Click
        If chkCJSpagSolo.Checked Then

            If boolSpicy = False Then

                tbl2Order.Rows.Add(intQtyCJSpag, "CJ w/ Spag Solo Meal", lblCJSpagSolo.Text)
                btnResetCJSpag.PerformClick()
            End If

            If boolSpicy = True Then

                tbl2Order.Rows.Add(intQtyCJSpag, "SPC CJ w/ Spag Solo Meal", lblCJSpagSolo.Text)
                btnResetCJSpag.PerformClick()
            End If


        End If

        If chkCJSpagValue.Checked Then

            If boolSpicy = False Then

                intValueMealsDrinks += 1 * intQtyCJSpag
                intValueMealsSides += 1 * intQtyCJSpag
                tbl2Order.Rows.Add(intQtyCJSpag, "CJ w/ Spag Value Meal", lblCJSpagValue.Text)
                btnResetCJSpag.PerformClick()
            End If

            If boolSpicy = True Then

                intValueMealsDrinks += 1 * intQtyCJSpag
                intValueMealsSides += 1 * intQtyCJSpag
                tbl2Order.Rows.Add(intQtyCJSpag, "SPC CJ w/ Spag Value Meal", lblCJSpagValue.Text)
                btnResetCJSpag.PerformClick()
            End If

        End If
        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetCJSpag_Click(sender As Object, e As EventArgs) Handles btnResetCJSpag.Click

        chkCJSpagSolo.Checked = False
        chkCJSpagValue.Checked = False
        boolSpicy = False
        picCJSpagS.Visible = False
        intQtyCJSpag = 1
        lblQtyCJSpag.Text = intQtyCJSpag
        dblTotalCJSpag = 117
        lblCJSpagSolo.Text = dblTotalCJSpag
        dblTotalCJSpag = 120
        lblCJSpagValue.Text = dblTotalCJSpag
        btnAddCJSpag.Enabled = True
    End Sub


    'CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==
    '==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ

    Private Sub chkCJPalSolo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCJPalSolo.CheckedChanged
        If chkCJPalSolo.Checked = True Then
            chkCJPalSolo.Checked = True

            If chkCJPalValue.Checked = True Then
                chkCJPalValue.Checked = False
            End If

        End If
    End Sub

    Private Sub chkCJPalValue_CheckedChanged(sender As Object, e As EventArgs) Handles chkCJPalValue.CheckedChanged
        If chkCJPalValue.Checked = True Then
            chkCJPalValue.Checked = True

            If chkCJPalSolo.Checked = True Then
                chkCJPalSolo.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpCJPal_Click(sender As Object, e As EventArgs) Handles btnUpCJPal.Click
        intQtyCJPal += 1

        dblTotalCJPal = 137 * intQtyCJPal

        lblQtyCJPal.Text = intQtyCJPal

        lblCJPalSolo.Text = dblTotalCJPal

        dblTotalCJPal = 0
        dblTotalCJPal = 140 * intQtyCJPal

        lblQtyCJPal.Text = intQtyCJPal


        lblCJPalValue.Text = dblTotalCJPal


        If dblTotalCJPal >= 1 Then
            btnAddCJPal.Enabled = True
        End If
    End Sub

    Private Sub btnDownCJPal_Click(sender As Object, e As EventArgs) Handles btnDownCJPal.Click
        intQtyCJPal -= 1
        dblTotalCJPal = 137 * intQtyCJPal

        If dblTotalCJPal <= 0 Then
            dblTotalCJPal = 0

        End If

        lblCJPalSolo.Text = dblTotalCJPal

        dblTotalCJPal = 0
        dblTotalCJPal = 140 * intQtyCJPal

        If dblTotalCJPal <= 0 Then
            dblTotalCJPal = 0

        End If

        lblQtyCJPal.Text = intQtyCJPal

        lblCJPalValue.Text = dblTotalCJPal


        lblCJPalValue.Text = dblTotalCJPal

        If intQtyCJPal <= 0 Then

            intQtyCJPal = 0

        End If
        If dblTotalCJPal <= 0 Then
            dblTotalCJPal = 0

        End If
        lblQtyCJPal.Text = intQtyCJPal


        If intQtyCJPal <= 0 Then
            intQtyCJPal = 0
            btnAddCJPal.Enabled = False
        End If
    End Sub

    Private Sub btnAddCJPal_Click(sender As Object, e As EventArgs) Handles btnAddCJPal.Click
        If chkCJPalSolo.Checked Then

            If boolSpicy = False Then

                tbl2Order.Rows.Add(intQtyCJPal, "CJ w/ Palabok Solo Meal", lblCJPalSolo.Text)
                btnResetCJPal.PerformClick()
            End If

            If boolSpicy = True Then

                tbl2Order.Rows.Add(intQtyCJPal, "SPC CJ w/ Palabok Solo Meal", lblCJPalSolo.Text)
                btnResetCJPal.PerformClick()
            End If


        End If

        If chkCJPalValue.Checked Then

            If boolSpicy = False Then

                intValueMealsDrinks += 1 * intQtyCJPal
                intValueMealsSides += 1 * intQtyCJPal
                tbl2Order.Rows.Add(intQtyCJPal, "CJ w/ Palabok Value Meal", lblCJPalValue.Text)
                btnResetCJPal.PerformClick()
            End If

            If boolSpicy = True Then

                intValueMealsDrinks += 1 * intQtyCJPal
                intValueMealsSides += 1 * intQtyCJPal
                tbl2Order.Rows.Add(intQtyCJPal, "SPC CJ w/ Palabok Value Meal", lblCJPalValue.Text)
                btnResetCJPal.PerformClick()
            End If

        End If
        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetCJPal_Click(sender As Object, e As EventArgs) Handles btnResetCJPal.Click

        chkCJPalSolo.Checked = False
        chkCJPalValue.Checked = False
        boolSpicy = False
        picCJPalS.Visible = False
        intQtyCJPal = 1
        lblQtyCJPal.Text = intQtyCJPal
        dblTotalCJPal = 137
        lblCJPalSolo.Text = dblTotalCJPal
        dblTotalCJPal = 140
        lblCJPalValue.Text = dblTotalCJPal
        btnAddCJPal.Enabled = True
    End Sub

    'CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==
    '==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ==CJ

    Private Sub chkSuperA1_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuperA1.CheckedChanged
        If chkSuperA1.Checked = True Then
            chkSuperA1.Checked = True

            If chkSuperA2.Checked = True Then
                chkSuperA2.Checked = False
            End If

            If chkSuperB1.Checked = True Then
                chkSuperB1.Checked = False
            End If

            If chkSuperB2.Checked = True Then
                chkSuperB2.Checked = False
            End If


        End If
    End Sub

    Private Sub chkSuperA2_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuperA2.CheckedChanged
        If chkSuperA2.Checked = True Then
            chkSuperA2.Checked = True

            If chkSuperA1.Checked = True Then
                chkSuperA1.Checked = False
            End If

            If chkSuperB1.Checked = True Then
                chkSuperB1.Checked = False
            End If

            If chkSuperB2.Checked = True Then
                chkSuperB2.Checked = False
            End If


        End If
    End Sub

    Private Sub chkSuperB1_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuperB1.CheckedChanged
        If chkSuperB1.Checked = True Then
            chkSuperB1.Checked = True

            If chkSuperA1.Checked = True Then
                chkSuperA1.Checked = False
            End If

            If chkSuperB2.Checked = True Then
                chkSuperB2.Checked = False
            End If

            If chkSuperA2.Checked = True Then
                chkSuperA2.Checked = False
            End If


        End If
    End Sub

    Private Sub chkSuperB2_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuperB2.CheckedChanged
        If chkSuperB2.Checked = True Then
            chkSuperB2.Checked = True

            If chkSuperA1.Checked = True Then
                chkSuperA1.Checked = False
            End If

            If chkSuperB1.Checked = True Then
                chkSuperB1.Checked = False
            End If

            If chkSuperA2.Checked = True Then
                chkSuperA2.Checked = False
            End If


        End If

    End Sub

    Private Sub btnAddSuper_Click(sender As Object, e As EventArgs) Handles btnAddSuper.Click
        If chkSuperA1.Checked Then
            tbl2Order.Rows.Add(1, "Super A1 Meal", 550)
            chkSuperA1.Checked = False
        End If

        If chkSuperA2.Checked Then
            tbl2Order.Rows.Add(1, "Super A2 Meal", 799)
            chkSuperA2.Checked = False
        End If

        If chkSuperB1.Checked Then
            tbl2Order.Rows.Add(1, "Super B1 Meal", 550)
            chkSuperB1.Checked = False
        End If

        If chkSuperB2.Checked Then
            tbl2Order.Rows.Add(1, "Super B2 Meal", 799)
            chkSuperB2.Checked = False
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    'PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===
    '===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE

    Private Sub btnUpRice_Click(sender As Object, e As EventArgs) Handles btnUpRice.Click
        intQtyRice += 1

        dblTotalRice = 33 * intQtyRice

        lblRice.Text = dblTotalRice

        lblQtyRice.Text = intQtyRice

        lblRice.Text = dblTotalRice


        If dblTotalRice >= 1 Then
            btnAddRice.Enabled = True
        End If
    End Sub

    Private Sub btnDownRice_Click(sender As Object, e As EventArgs) Handles btnDownRice.Click
        intQtyRice -= 1
        dblTotalRice = 33 * intQtyRice

        If dblTotalRice <= 0 Then
            dblTotalRice = 0

        End If

        lblRice.Text = dblTotalRice

        lblQtyRice.Text = intQtyRice

        If intQtyRice <= 0 Then

            intQtyRice = 0

        End If
        If dblTotalRice <= 0 Then
            dblTotalRice = 0

        End If
        lblQtyRice.Text = intQtyRice

        If intQtyChamp <= 0 Then
            intQtyChamp = 0
            btnAddRice.Enabled = False
        End If
    End Sub

    Private Sub btnAddRice_Click(sender As Object, e As EventArgs) Handles btnAddRice.Click
        tbl2Order.Rows.Add(intQtyRice, "Rice", lblRice.Text)
        btnResetRice.PerformClick()

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")

    End Sub

    Private Sub btnResetRice_Click(sender As Object, e As EventArgs) Handles btnResetRice.Click

        intQtyRice = 1
        lblQtyRice.Text = intQtyRice

        dblTotalRice = 33
        lblRice.Text = dblTotalRice
        btnAddRice.Enabled = True
    End Sub

    'PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===
    '===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE===PIE
    Private Sub chkPieSolo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPieSolo.CheckedChanged
        If chkPieSolo.Checked = True Then
            chkPieSolo.Checked = True

            If chkPieValue.Checked = True Then
                chkPieValue.Checked = False
            End If

        End If
    End Sub

    Private Sub chkPieValue_CheckedChanged(sender As Object, e As EventArgs) Handles chkPieValue.CheckedChanged
        If chkPieValue.Checked = True Then
            chkPieValue.Checked = True

            If chkPieSolo.Checked = True Then
                chkPieSolo.Checked = False
            End If

        End If
    End Sub

    Private Sub btnUpPie_Click(sender As Object, e As EventArgs) Handles btnUpPie.Click
        intQtyPie += 1

        dblTotalPie = 27 * intQtyPie

        lblQtyPie.Text = intQtyPie

        lblPieSolo.Text = dblTotalPie

        dblTotalPie = 0
        dblTotalPie = 78 * intQtyPie

        lblQtyPie.Text = intQtyPie


        lblPieValue.Text = dblTotalPie


        If dblTotalPie >= 1 Then
            btnAddPie.Enabled = True
        End If
    End Sub

    Private Sub btnDownPie_Click(sender As Object, e As EventArgs) Handles btnDownPie.Click

        intQtyPie -= 1
        dblTotalPie = 27 * intQtyPie

        If dblTotalPie <= 0 Then
            dblTotalPie = 0

        End If

        lblPieSolo.Text = dblTotalPie

        dblTotalPie = 0
        dblTotalPie = 78 * intQtyChamp

        If dblTotalPie <= 0 Then
            dblTotalPie = 0

        End If

        lblQtyPie.Text = intQtyPie

        lblPieValue.Text = dblTotalPie


        lblPieValue.Text = dblTotalPie

        If intQtyPie <= 0 Then

            intQtyPie = 0

        End If
        If dblTotalPie <= 0 Then
            dblTotalPie = 0

        End If
        lblQtyPie.Text = intQtyPie


        If intQtyPie <= 0 Then
            intQtyPie = 0
            btnAddPie.Enabled = False
        End If

    End Sub

    Private Sub btnAddPie_Click(sender As Object, e As EventArgs) Handles btnAddPie.Click
        If chkPieSolo.Checked Then
            tbl2Order.Rows.Add(intQtyPie, "1-pc. Peach Mango Pie", lblPieSolo.Text)
            btnResetPie.PerformClick()

        End If

        If chkPieValue.Checked Then
            tbl2Order.Rows.Add(intQtyPie, "3-pc. Peach Mango Pie", lblPieValue.Text)
            btnResetPie.PerformClick()
        End If


        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetPie_Click(sender As Object, e As EventArgs) Handles btnResetPie.Click
        chkPieSolo.Checked = False
        chkPieValue.Checked = False
        intQtyPie = 1
        lblQtyPie.Text = intQtyPie
        dblTotalPie = 27
        lblPieSolo.Text = dblTotalPie
        dblTotalPie = 78
        lblPieValue.Text = dblTotalPie
        btnAddPie.Enabled = True
    End Sub

    'SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====
    '====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP====SOUP


    Private Sub chkSoupSolo_CheckedChanged(sender As Object, e As EventArgs) Handles chkSoupSolo.CheckedChanged
        If chkSoupSolo.Checked = True Then
            chkSoupSolo.Checked = True

            If chkSoupU.Checked = True Then
                chkSoupU.Checked = False
            End If

        End If
    End Sub

    Private Sub chkSoupValue_CheckedChanged(sender As Object, e As EventArgs) Handles chkSoupU.CheckedChanged
        intQtySoup = 0
        lblQtySoup.Text = intQtySoup

        If chkSoupU.Checked = True Then
            chkSoupU.Checked = True

            If chkSoupSolo.Checked = True Then
                chkSoupSolo.Checked = False
            End If

            If intQtySoup <= 0 Then
                intQtySoup = 0
                btnAddSoup.Enabled = False
            End If

        End If
    End Sub

    Private Sub btnUpSoup_Click(sender As Object, e As EventArgs) Handles btnUpSoup.Click
        intQtySoup += 1

        If chkSoupU.Checked And intValueMealsSides < intQtySoup Then
            intQtySoup = intValueMealsSides
        End If


        dblTotalSoup = 39 * intQtySoup

        lblQtySoup.Text = intQtySoup

        lblSoupSolo.Text = dblTotalSoup

        dblTotalSoup = 0
        dblTotalSoup = 35 * intQtySoup

        lblQtySoup.Text = intQtySoup


        lblSoupU.Text = dblTotalSoup


        If dblTotalSoup >= 1 Then
            btnAddSoup.Enabled = True
        End If
    End Sub

    Private Sub btnDownSoup_Click(sender As Object, e As EventArgs) Handles btnDownSoup.Click
        intQtySoup -= 1
        dblTotalSoup = 39 * intQtySoup

        If dblTotalSoup <= 0 Then
            dblTotalSoup = 0

        End If

        lblSoupSolo.Text = dblTotalSoup

        dblTotalSoup = 0
        dblTotalSoup = 35 * intQtySoup

        If dblTotalSoup <= 0 Then
            dblTotalSoup = 0

        End If

        lblQtySoup.Text = intQtySoup

        lblSoupU.Text = dblTotalSoup


        lblSoupU.Text = dblTotalSoup

        If intQtySoup <= 0 Then

            intQtySoup = 0

        End If
        If dblTotalSoup <= 0 Then
            dblTotalSoup = 0

        End If

        If intQtySoup <= 0 Then
            intQtySoup = 0
            btnAddSoup.Enabled = False
        End If

        If intValueMealsSides >= lblQtySoup.Text Then
            btnAddSoup.Enabled = True
        End If

        lblQtySoup.Text = intQtySoup
    End Sub

    Private Sub btnAddSoup_Click(sender As Object, e As EventArgs) Handles btnAddSoup.Click

        If chkSoupSolo.Checked Then
            tbl2Order.Rows.Add(intQtySoup, "CMS Solo", lblSoupSolo.Text)
            btnResetSoup.PerformClick()

        End If


        If chkSoupU.Checked Then
            intValueMealsSides -= intQtySoup
            If intValueMealsSides <= 0 Then
                btnAddSoup.Enabled = False
            End If

            tbl2Order.Rows.Add(intQtySoup, "CMS add on to VM", lblSoupU.Text)
            btnResetSoup.PerformClick()

        End If


        If intValueMealsSides < lblQtySoup.Text Then
            btnAddSoup.Enabled = False
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
        btnResetSoup.PerformClick()
    End Sub

    Private Sub btnResetSoup_Click(sender As Object, e As EventArgs) Handles btnResetSoup.Click
        chkSoupSolo.Checked = False
        chkSoupU.Checked = False
        btnAddSoup.Enabled = True
        intQtySoup = 1
        lblQtySoup.Text = intQtySoup
        dblTotalSoup = 39
        lblSoupSolo.Text = dblTotalSoup
        dblTotalSoup = 35
        lblSoupU.Text = dblTotalSoup
    End Sub

    'CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====
    '====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN====CORN

    Private Sub chkCornSolo_CheckedChanged(sender As Object, e As EventArgs) Handles chkCornSolo.CheckedChanged
        If chkCornSolo.Checked = True Then
            chkCornSolo.Checked = True

            If chkCornU.Checked = True Then
                chkCornU.Checked = False
            End If

        End If
    End Sub

    Private Sub chkCornU_CheckedChanged(sender As Object, e As EventArgs) Handles chkCornU.CheckedChanged
        intQtyCorn = 0
        lblQtyCorn.Text = intQtyCorn

        If chkCornU.Checked = True Then
            chkCornU.Checked = True

            If chkCornSolo.Checked = True Then
                chkCornSolo.Checked = False
            End If

            If intQtyCorn <= 0 Then
                intQtyCorn = 0
                btnAddCorn.Enabled = False
            End If

        End If
    End Sub

    Private Sub btnUpCorn_Click(sender As Object, e As EventArgs) Handles btnUpCorn.Click
        intQtyCorn += 1

        If chkCornU.Checked And intValueMealsSides < intQtyCorn Then
            intQtyCorn = intValueMealsSides
        End If


        dblTotalCorn = 29 * intQtyCorn

        lblQtyCorn.Text = intQtyCorn

        lblCornSolo.Text = dblTotalCorn

        dblTotalCorn = 0
        dblTotalCorn = 25 * intQtyCorn

        lblQtyCorn.Text = intQtyCorn


        lblCornU.Text = dblTotalCorn


        If dblTotalCorn >= 1 Then
            btnAddCorn.Enabled = True
        End If
    End Sub

    Private Sub btnDownCorn_Click(sender As Object, e As EventArgs) Handles btnDownCorn.Click
        intQtyCorn -= 1
        dblTotalCorn = 29 * intQtyCorn

        If dblTotalCorn <= 0 Then
            dblTotalCorn = 0

        End If

        lblCornSolo.Text = dblTotalCorn

        dblTotalCorn = 0
        dblTotalCorn = 25 * intQtyCorn

        If dblTotalCorn <= 0 Then
            dblTotalCorn = 0

        End If

        lblQtyCorn.Text = intQtyCorn

        lblCornU.Text = dblTotalCorn


        lblCornU.Text = dblTotalCorn

        If intQtyCorn <= 0 Then

            intQtyCorn = 0

        End If
        If dblTotalCorn <= 0 Then
            dblTotalCorn = 0

        End If

        If intQtyCorn <= 0 Then
            intQtyCorn = 0
            btnAddCorn.Enabled = False
        End If

        If intValueMealsSides >= lblQtyCorn.Text Then
            btnAddCorn.Enabled = True
        End If

        lblQtyCorn.Text = intQtyCorn
    End Sub

    Private Sub btnAddCorn_Click(sender As Object, e As EventArgs) Handles btnAddCorn.Click
        If chkCornSolo.Checked Then
            tbl2Order.Rows.Add(intQtyCorn, "Corn Solo", lblCornSolo.Text)
            btnResetCorn.PerformClick()

        End If


        If chkCornU.Checked Then
            intValueMealsSides -= intQtyCorn
            If intValueMealsSides <= 0 Then
                btnAddCorn.Enabled = False
            End If

            tbl2Order.Rows.Add(intQtyCorn, "Corn add on to VM", lblCornU.Text)
            btnResetCorn.PerformClick()

        End If


        If intValueMealsSides < lblQtyCorn.Text Then
            btnAddCorn.Enabled = False
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
        btnResetCorn.PerformClick()
    End Sub

    Private Sub btnResetCorn_Click(sender As Object, e As EventArgs) Handles btnResetCorn.Click
        chkCornSolo.Checked = False
        chkCornU.Checked = False
        btnAddCorn.Enabled = True
        intQtyCorn = 1
        lblQtyCorn.Text = intQtyCorn
        dblTotalCorn = 29
        lblCornSolo.Text = dblTotalCorn
        dblTotalCorn = 25
        lblCornU.Text = dblTotalCorn
    End Sub

    Private Sub chkFriesReg_CheckedChanged(sender As Object, e As EventArgs) Handles chkFriesReg.CheckedChanged
        If chkFriesReg.Checked = True Then
            chkFriesReg.Checked = True

            If chkFriesLarge.Checked = True Then
                chkFriesLarge.Checked = False
            End If

            If chkFriesLargeU.Checked = True Then
                chkFriesLargeU.Checked = False
            End If

        End If
    End Sub

    Private Sub chkFriesLarge_CheckedChanged(sender As Object, e As EventArgs) Handles chkFriesLarge.CheckedChanged
        If chkFriesLarge.Checked = True Then
            chkFriesLarge.Checked = True

            If chkFriesReg.Checked = True Then
                chkFriesReg.Checked = False
            End If

            If chkFriesLargeU.Checked = True Then
                chkFriesLargeU.Checked = False
            End If

        End If
    End Sub

    Private Sub chkFriesLargeU_CheckedChanged(sender As Object, e As EventArgs) Handles chkFriesLargeU.CheckedChanged
        intQtyFries = 0
        lblQtyFries.Text = intQtyFries

        If chkFriesLargeU.Checked = True Then
            chkFriesLargeU.Checked = True

            If chkFriesReg.Checked = True Then
                chkFriesReg.Checked = False
            End If

            If chkFriesLarge.Checked = True Then
                chkFriesLarge.Checked = False
            End If

            If intQtyFries <= 0 Then
                intQtyFries = 0
                btnAddFries.Enabled = False
            End If

        End If
    End Sub

    Private Sub btnUpFries_Click(sender As Object, e As EventArgs) Handles btnUpFries.Click
        intQtyFries += 1


        If chkFriesLargeU.Checked And intValueMealsFries < intQtyFries Then
            intQtyFries = intValueMealsFries
        End If

        dblTotalFries = 37 * intQtyFries

        lblQtyFries.Text = intQtyFries

        lblFriesReg.Text = dblTotalFries

        dblTotalFries = 0
        dblTotalFries = 62 * intQtyFries

        lblQtyFries.Text = intQtyFries


        lblFriesLarge.Text = dblTotalFries

        dblTotalFries = 0
        dblTotalFries = 42 * intQtyFries

        lblQtyFries.Text = intQtyFries


        lblFriesLargeU.Text = dblTotalFries


        If dblTotalFries >= 1 Then
            btnAddFries.Enabled = True
        End If
    End Sub

    Private Sub btnDownFries_Click(sender As Object, e As EventArgs) Handles btnDownFries.Click
        intQtyFries -= 1
        dblTotalFries = 28 * intQtyFries

        If dblTotalFries <= 0 Then
            dblTotalFries = 0

        End If

        lblFriesReg.Text = dblTotalFries

        dblTotalFries = 0
        dblTotalFries = 50 * intQtyFries

        If dblTotalFries <= 0 Then
            dblTotalFries = 0

        End If

        lblQtyFries.Text = intQtyFries

        lblFriesLarge.Text = dblTotalFries


        lblFriesLarge.Text = dblTotalFries

        If intQtyFries <= 0 Then
            intQtyFries = 0

        End If
        If dblTotalFries <= 0 Then
            dblTotalFries = 0

        End If

        dblTotalFries = 0
        dblTotalFries = 20 * intQtyFries

        If dblTotalFries <= 0 Then
            dblTotalFries = 0

        End If

        lblQtyFries.Text = intQtyFries

        lblFriesLargeU.Text = dblTotalFries


        lblFriesLargeU.Text = dblTotalFries

        If intQtyFries <= 0 Then

            intQtyFries = 0

        End If
        If dblTotalFries <= 0 Then
            dblTotalFries = 0

        End If

        If intQtyFries <= 0 Then
            intQtyFries = 0
            btnAddFries.Enabled = False
        End If

        If intValueMealsFries >= lblQtyFries.Text Then
            btnAddFries.Enabled = True
        End If

        lblQtyFries.Text = intQtyFries
    End Sub

    Private Sub btnAddFries_Click(sender As Object, e As EventArgs) Handles btnAddFries.Click

        If chkFriesReg.Checked Then
            tbl2Order.Rows.Add(intQtyFries, "Fries Regular", lblFriesReg.Text)
            chkFriesReg.Checked = False

        End If

        If chkFriesLarge.Checked Then
            tbl2Order.Rows.Add(intQtyFries, "Fries Large", lblFriesLarge.Text)
            chkFriesLarge.Checked = False

        End If

        If chkFriesLargeU.Checked Then
            intValueMealsFries -= intQtyFries
            If intValueMealsFries <= 0 Then
                btnAddFries.Enabled = False
            End If

            tbl2Order.Rows.Add(intQtyFries, "Fries Large (Upgrade)", lblFriesLargeU.Text)
            chkFriesLargeU.Checked = False

            If intValueMealsFries < lblQtyFries.Text Then
                btnAddFries.Enabled = False
            End If

        End If


        If intValueMealsFries < lblQtyFries.Text Then
            btnAddFries.Enabled = False
        End If

        Dim sum As Double = 0
        For i As Integer = 0 To tbl2Order.Rows.Count() - 1 Step +1
            sum += tbl2Order.Rows(i).Cells(2).Value
        Next

        dblTotal = sum
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnResetFries_Click(sender As Object, e As EventArgs) Handles btnResetFries.Click
        chkFriesReg.Checked = False
        chkFriesLarge.Checked = False
        chkFriesLargeU.Checked = False
        btnAddFries.Enabled = True
        intQtyFries = 1
        lblQtyFries.Text = intQtyFries
        dblTotalFries = 37
        lblFriesReg.Text = dblTotalFries
        dblTotalFries = 62
        lblFriesLarge.Text = dblTotalFries
        dblTotalFries = 42
        lblFriesLargeU.Text = dblTotalFries
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        tab00.SelectedTab = tabBS
    End Sub


End Class
