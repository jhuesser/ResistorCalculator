Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Colors of first ring
        Dim color1(8) As String
        color1 = {"brown", "red", "orange", "yellow", "green", "blue", "purple", "grey", "white"}

        'Colors of second and third ring
        Generate23()


        'Colors of fourth ring
        Generate4()


        'Colors of fifth ring
        Dim color5(2) As String
        color5 = {"brown", "red", "green", "gold", "silver", "white"}





        'Add colors for the first ring to the first dropdown
        For Each color As String In color1
            cmbRing1.Items.Add(color)


        Next









        'Add colors for the fith ring to the fourth dropdown
        For Each color As String In color5
            cmbRing5.Items.Add(color)


        Next


        EnableDisable5()








    End Sub

    Private Sub chkRing5_CheckedChanged(sender As Object, e As EventArgs) Handles chkRing5.CheckedChanged


        EnableDisable5()
        Generate4()
        Generate23()




    End Sub

    Public Function EnableDisable5()



        If chkRing5.Checked Then
            lblRing5.Enabled = True
            cmbRing5.Enabled = True




        Else
            lblRing5.Enabled = False
            cmbRing5.Enabled = False



        End If

    End Function

    Private Sub btnCalcClr_Click(sender As Object, e As EventArgs) Handles btnCalcClr.Click
        valcolors()

    End Sub



    Private Function Generate4()
        Dim FourRing As Boolean

        FourRing = checkStatus()

        If FourRing = True Then
            cmbRing4.Items.Clear()
            Dim color4(11) As String
            color4 = {"brown", "red", "green", "blue", "purple", "gold", "silver", "white"}
            For Each color In color4
                cmbRing4.Items.Add(color)
            Next
        Else
            cmbRing4.Items.Clear()
            Dim color4(11) As String
            color4 = {"silver", "gold", "black", "red", "orange", "yellow", "green", "blue", "purple", "grey", "white"}
            For Each Color In color4
                cmbRing4.Items.Add(Color)
            Next

        End If
        Return FourRing

    End Function


    Private Function Generate23()
        Dim FourRing As Boolean

        FourRing = checkStatus()

        If FourRing = True Then
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
            cmbRing2.Items.Clear()
            cmbRing3.Items.Clear()
            Dim color23(9) As String
            color23 = {"black", "red", "orange", "yellow", "green", "blue", "purple", "grey", "white"}
            For Each Color In color23
                cmbRing2.Items.Add(Color)
                cmbRing3.Items.Add(Color)
            Next

        End If
        Return FourRing

    End Function

    Private Function checkStatus()
        Dim FourRing As Boolean

        If chkRing5.Checked = True Then
            FourRing = False
        Else
            FourRing = True

        End If
        Return FourRing

    End Function

    Public Sub valcolors()

        Dim EndResult As Double
        Dim fourRings As Boolean

        fourRings = checkStatus()
        ''TODO

        If fourRings = False Then
            Dim val1 As Single
            Dim val2 As Single
            Dim val3 As Single
            Dim val4 As Single
            Dim val5 As String

            val1 = valFirst(val1)
            val2 = valSecond(val2)
            val3 = valThird(val3)
            val4 = valFourth(val4)
            val5 = valFifth(val5)
            EndResult = calculate5(val1, val2, val3, val4)

            txtResult.Text = EndResult & "Ω"
            txtTol.Text = val5

        ElseIf fourRings = True Then
            Dim val1 As Single
            Dim val2 As Single
            Dim val3 As Single
            Dim val4 As String


            val1 = valFirst(val1)
            val2 = valSecond(val2)
            val3 = valThird2(val3)
            val4 = valFourth2(val4)

            EndResult = calculate4(val1, val2, val3)
            txtResult.Text = EndResult & "Ω"
            txtTol.Text = val4


        End If




    End Sub


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


        EndResult5 = val1 & val2 & val3
        EndResult5 = EndResult5 * val4



        Return EndResult5


    End Function

    Private Function calculate4(val1 As Single, val2 As Single, val3 As Single)

        Dim EndResult As Single
        EndResult = val1 & val2
        EndResult = EndResult * val3
        Return EndResult

    End Function


End Class
