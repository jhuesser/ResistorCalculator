Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '''''
        ' COLOR CODE CALCULATING
        '''''

        'Colors of first ring
        Dim color1(8) As String
        color1 = {"brown", "red", "orange", "yellow", "green", "blue", "purple", "grey", "white"}

        'Colors of second and third ring need to be generated
        Generate23()

        'Colors of fourth ring needs to be generated
        Generate4()

        'Colors of fifth ring
        Dim color5(2) As String
        color5 = {"brown", "red", "green", "gold", "silver", "white"}

        'Add colors for the first ring to the first dropdown
        For Each color As String In color1

            cmbRing1.Items.Add(color)

        Next

        'Add colors for the fith ring to the fith dropdown
        For Each color As String In color5

            cmbRing5.Items.Add(color)

        Next

        'Enables or Disables the 5th dropdown
        EnableDisable5()
        '                   '''''''
        ' COLOR CODE CALCULATING ''
        '                   '''''''





    End Sub

    '''''
    ' COLOR CODE CALCULATING
    '''''

    Private Sub chkRing5_CheckedChanged(sender As Object, e As EventArgs) Handles chkRing5.CheckedChanged

        'This is the switch for calculationg 4 or 5 rings.
        'Because the colors and values are diffrent beetween this modes, we need to regenerate colors.

        'Enables or disables the 5th dropdown
        EnableDisable5()
        'regenerate color 4 colors and values
        Generate4()
        'regenerates color 2 & 3 and values
        Generate23()

    End Sub

    Public Sub EnableDisable5()

        'TODO: merge with checkStatus()

        'If mode = calculate 5, enable color 5
        If chkRing5.Checked Then
            lblRing5.Enabled = True
            cmbRing5.Enabled = True
        Else
            'Else disable color 5
            lblRing5.Enabled = False
            cmbRing5.Enabled = False
        End If

    End Sub

    Private Sub btnCalcClr_Click(sender As Object, e As EventArgs) Handles btnCalcClr.Click
        'The button starts the validating and calculation proccess.
        valcolors()
    End Sub



    Private Sub Generate4()
        'Control value to check calc mode
        Dim FourRing As Boolean
        'Get the calc mode (4/5 rings)
        FourRing = checkStatus()
        'Mode is 4
        If FourRing = True Then
            'clear the dropdown, to avoid duplicates
            cmbRing4.Items.Clear()
            'colors for color4 in mode 4
            Dim color4(11) As String
            color4 = {"brown", "red", "green", "blue", "purple", "gold", "silver", "white"}
            For Each color In color4
                cmbRing4.Items.Add(color)
            Next
        Else
            'color 4 in mode 5
            cmbRing4.Items.Clear()
            Dim color4(11) As String
            color4 = {"silver", "gold", "black", "red", "orange", "yellow", "green", "blue", "purple", "grey", "white"}
            For Each Color In color4
                cmbRing4.Items.Add(Color)
            Next

        End If


    End Sub

    'Same sub like generate4(), but with 2 dropdowns
    Private Sub Generate23()
        Dim FourRing As Boolean

        FourRing = checkStatus()

        If FourRing = True Then
            'For calc mode 4, colors 2 and 3 need to be regenerated
            cmbRing2.Items.Clear()
            cmbRing3.Items.Clear()
            Dim color2(9) As String
            Dim color3(10) As String
            color2 = {"black", "red", "orange", "yellow", "green", "blue", "purple", "grey", "white"}
            color3 = {"black", "red", "orange", "yellow", "green", "blue", "purple", "grey"}
            For Each color In color2
                cmbRing2.Items.Add(color)
            Next
            For Each color In color3
                cmbRing3.Items.Add(color)
            Next
        Else
            'for calc mode 5, both colors have the same colors inside + the same value
            cmbRing2.Items.Clear()
            cmbRing3.Items.Clear()
            Dim color23(9) As String
            color23 = {"black", "red", "orange", "yellow", "green", "blue", "purple", "grey", "white"}
            For Each Color In color23
                cmbRing2.Items.Add(Color)
                cmbRing3.Items.Add(Color)
            Next

        End If


    End Sub

    Private Function checkStatus()

        'Checking the calc mode
        Dim FourRing As Boolean

        If chkRing5.Checked = True Then
            'Calc mode 5
            FourRing = False
        Else
            'Calc mode 4
            FourRing = True

        End If
        'return the calcmode
        Return FourRing

    End Function

    Public Sub valcolors()
        'Need to be double (?) numbers can be very high in calcmode 5
        'TODO: change ohm to kOhm, MOhm etc.
        Dim EndResult As Double
        Dim fourRings As Boolean
        'check calc mode
        fourRings = checkStatus()

        'calc mode 4
        If fourRings = False Then
            Dim val1 As Single
            Dim val2 As Single
            Dim val3 As Single
            Dim val4 As Single
            Dim val5 As String
            'need float comma numbers

            'get the values from color name
            val1 = valFirst(val1)
            val2 = valSecond(val2)
            val3 = valThird(val3)
            val4 = valFourth(val4)
            val5 = valFifth(val5)
            'get result
            EndResult = calculate5(val1, val2, val3, val4)
            'write result and tolerance
            txtResult.Text = EndResult & "Ω"
            txtTol.Text = val5

        ElseIf fourRings = True Then
            'Calc mode 5
            Dim val1 As Single
            Dim val2 As Single
            Dim val3 As Single
            Dim val4 As String

            'See comments above^^
            val1 = valFirst(val1)
            val2 = valSecond(val2)
            val3 = valThird2(val3)
            val4 = valFourth2(val4)

            EndResult = calculate4(val1, val2, val3)
            txtResult.Text = EndResult & "Ω"
            txtTol.Text = val4

        End If

    End Sub

    'Following are very easy. checking the string (color) in dropdown, and gives them a value.
    Private Function valFirst(val1 As Single)


        Select Case cmbRing1.Text
            Case "brown"
                val1 = 1
            Case "red"
                val1 = 2
            Case "orange"
                val1 = 3
            Case "yellow"
                val1 = 4
            Case "green"
                val1 = 5
            Case "blue"
                val1 = 6
            Case "purple"
                val1 = 7
            Case "grey"
                val1 = 8
            Case "white"
                val1 = 9


        End Select
        Return val1

    End Function

    Private Function valSecond(val2 As Single)

        Select Case cmbRing2.Text
            Case "black"
                val2 = 0
            Case "brown"
                val2 = 1
            Case "red"
                val2 = 2
            Case "orange"
                val2 = 3
            Case "yellow"
                val2 = 4
            Case "green"
                val2 = 5
            Case "blue"
                val2 = 6
            Case "purple"
                val2 = 8
            Case "white"
                val2 = 9
        End Select
        Return val2
    End Function

    Private Function valThird(val3 As Single)
        Select Case cmbRing3.Text
            Case "black"
                val3 = 0
            Case "brown"
                val3 = 1
            Case "red"
                val3 = 2
            Case "orange"
                val3 = 3
            Case "yellow"
                val3 = 4
            Case "green"
                val3 = 5
            Case "blue"
                val3 = 6
            Case "purple"
                val3 = 8
            Case "white"
                val3 = 9
        End Select
        Return val3
    End Function

    'Needed a second function from some of these, because colors are different (2,3,4)
    Private Function valThird2(val4 As Single)
        Select Case cmbRing3.Text
            Case "silver"
                val4 = 0.01
            Case "gold"
                val4 = 0.1
            Case "black"
                val4 = 1
            Case "brown"
                val4 = 10
            Case "red"
                val4 = 100
            Case "orange"
                val4 = 1000
            Case "yellow"
                val4 = 10000
            Case "green"
                val4 = 100000
            Case "blue"
                val4 = 1000000
            Case "purple"
                val4 = 10000000
            Case "grey"
                val4 = 100000000


        End Select
        Return val4
    End Function

    Private Function valFourth(val4 As Single)
        Select Case cmbRing4.Text
            Case "silver"
                val4 = 0.01
            Case "gold"
                val4 = 0.1
            Case "black"
                val4 = 1
            Case "brown"
                val4 = 10
            Case "red"
                val4 = 100
            Case "orange"
                val4 = 1000
            Case "yellow"
                val4 = 10000
            Case "green"
                val4 = 100000
            Case "blue"
                val4 = 1000000
            Case "purple"
                val4 = 10000000
            Case "grey"
                val4 = 100000000
            Case "white"
                val4 = 1000000000

        End Select
        Return val4
    End Function

    Private Function valFifth(val5 As String)
        Select Case cmbRing5.Text
            Case "brown"
                val5 = "1%"
            Case "red"
                val5 = "2%"
            Case "green"
                val5 = "0.5%"
            Case "blue"
                val5 = "0.25%"
            Case "purple"
                val5 = "0.1%"
            Case "gold"
                val5 = "5%"
            Case "silver"
                val5 = "10%"
            Case "white"
                val5 = "20%"

        End Select

        Return val5
    End Function

    Private Function valFourth2(val5 As String)
        Select Case cmbRing4.Text
            Case "brown"
                val5 = "1%"
            Case "red"
                val5 = "2%"
            Case "green"
                val5 = "0.5%"
            Case "blue"
                val5 = "0.25%"
            Case "purple"
                val5 = "0.1%"
            Case "gold"
                val5 = "5%"
            Case "silver"
                val5 = "10%"
            Case "white"
                val5 = "20%"

        End Select

        Return val5
    End Function

    Private Function calculate5(val1 As Single, val2 As Single, val3 As Single, val4 As Single)

        Dim EndResult5 As Double
        'Sets the first three digits of the result
        EndResult5 = val1 & val2 & val3
        'Multipiles the result
        EndResult5 = EndResult5 * val4
        'returns the result
        Return EndResult5


    End Function

    Private Function calculate4(val1 As Single, val2 As Single, val3 As Single)
        'See comments above
        Dim EndResult As Single
        EndResult = val1 & val2
        EndResult = EndResult * val3
        Return EndResult

    End Function



    '                   '''''''
    ' COLOR CODE CALCULATING ''
    '                   '''''''

    Private Sub btnDoubleCalc_Click(sender As Object, e As EventArgs) Handles btnDoubleCalc.Click
        Dim r As Single
        r = uri()
        getColorCode(r)

    End Sub

    Private Function uri()
        Dim u As Single = txtVolt.Text
        Dim i As Single = txtAmpere.Text
        Dim r As Single

        r = u / i
        txtOhmCalc.Text = r

        Return r

    End Function

    Private Function getColorCode(ohm As String)
        Dim ohmcalc() As Char = ohm.ToCharArray
        Dim ohmlength As Byte

        ohmlength = ohmcalc.Length

        For Each ohmnbr In ohmcalc
            ' Get numbers

        Next

        MsgBox(ohmlength
               )


    End Function

End Class
