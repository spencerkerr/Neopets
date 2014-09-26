Public Class Form1


    Dim HABI_FILE As String = "C:\Users\user\Documents\Home\Neopets\HabiEggs.txt"
    Dim CODE_FILE As String = "C:\Users\user\Documents\Home\Neopets\Codestones.txt"
    Dim eggsString() As String
    Dim eggs(9) As Integer
    Dim codestones(12) As Integer



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEggs()
        LoadCodes()

    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SaveCodes()
        SaveEggs()

    End Sub

    Private Sub LoadEggs()
        Dim objReader As New System.IO.StreamReader(HABI_FILE)
        Dim eggsWithCommas = objReader.ReadToEnd

        Dim i As Integer
        Dim eggsArray() As String


        eggsArray = eggsWithCommas.Split(",")

        For i = 0 To UBound(eggsArray)
            eggs(i) = eggsArray(i)
        Next i
        objReader.Close()
        updateHabiTextBoxes()


    End Sub

    Private Sub SaveEggs()
        Dim text As String = ""
        For i = 0 To UBound(eggs)
            If i <> 0 Then
                text = text & ","
            End If
            text = text & eggs(i)

        Next i
        If System.IO.File.Exists(HABI_FILE) = True Then
            Dim objWriter As New System.IO.StreamWriter(HABI_FILE)
            objWriter.Write(text)
            objWriter.Close()
            'MsgBox("Eggs Saved")

        Else

            MsgBox("File Does Not Exist")

        End If

    End Sub

    Private Sub updateHabiTextBoxes()
        MW.Value() = eggs(0)
        MS.Value() = eggs(1)
        MN.Value() = eggs(2)
        LW.Value() = eggs(3)
        LS.Value() = eggs(4)
        LN.Value() = eggs(5)
        PW.Value() = eggs(6)
        PS.Value() = eggs(7)
        PN.Value() = eggs(8)
        Total.Text() = (eggs(0) + eggs(1) + eggs(2) + eggs(3) + eggs(4) + eggs(5) + eggs(6) + eggs(7) + eggs(8))
        Pages.Text() = ((eggs(0) + eggs(1) + eggs(2) + eggs(3) + eggs(4) + eggs(5) + eggs(6) + eggs(7) + eggs(8)) / 15.0)
        SaveEggs()


    End Sub

    Private Sub SaveCodes()
        Dim text As String = ""
        For i = 0 To UBound(codestones)
            If i <> 0 Then
                text = text & ","
            End If
            text = text & codestones(i)

        Next i
        If System.IO.File.Exists(CODE_FILE) = True Then
            Dim objWriter As New System.IO.StreamWriter(CODE_FILE)
            objWriter.Write(text)
            objWriter.Close()
            'MsgBox("Codestones Saved")

        Else

            MsgBox("File Does Not Exist")

        End If

    End Sub

    Private Sub LoadCodes()
        Dim objReader As New System.IO.StreamReader(CODE_FILE)
        Dim stonesWithCommas = objReader.ReadToEnd

        Dim i As Integer
        Dim stonesArray() As String


        stonesArray = stonesWithCommas.Split(",")

        For i = 0 To UBound(stonesArray)
            codestones(i) = stonesArray(i)
        Next i
        objReader.Close()
        updateCodeTextBoxes()

    End Sub
    Private Sub updateCodeTextBoxes()
        Mag.Text() = codestones(0)
        Vux.Text() = codestones(1)
        Cui.Text() = codestones(2)
        Kew.Text() = codestones(3)
        Sho.Text() = codestones(4)
        Zed.Text() = codestones(5)
        MagC.Text() = codestones(6)
        VuxC.Text() = codestones(7)
        CuiC.Text() = codestones(8)
        KewC.Text() = codestones(9)
        ShoC.Text() = codestones(10)
        ZedC.Text() = codestones(11)
        TotalCount.Text() = (codestones(0) + codestones(1) + codestones(2) + codestones(3) + codestones(4) + codestones(5))
        TotalCost.Text() = (codestones(0) * codestones(6) + codestones(1) * codestones(7) + codestones(2) * codestones(8) + codestones(3) * codestones(9) + codestones(4) * codestones(10) + codestones(5) * codestones(11))
        SaveCodes()
    End Sub

    Private Sub MW_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MW.ValueChanged
        eggs(0) = MW.Value
        updateHabiTextBoxes()
    End Sub
    Private Sub MS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MS.ValueChanged
        eggs(1) = MS.Value
        updateHabiTextBoxes()
    End Sub
    Private Sub MN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MN.ValueChanged
        eggs(2) = MN.Value
        updateHabiTextBoxes()
    End Sub

    Private Sub LW_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LW.ValueChanged
        eggs(3) = LW.Value
        updateHabiTextBoxes()
    End Sub
    Private Sub LS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LS.ValueChanged
        eggs(4) = LS.Value
        updateHabiTextBoxes()
    End Sub
    Private Sub LN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LN.ValueChanged
        eggs(5) = LN.Value
        updateHabiTextBoxes()
    End Sub

    Private Sub PW_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PW.ValueChanged
        eggs(6) = PW.Value
        updateHabiTextBoxes()
    End Sub
    Private Sub PS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PS.ValueChanged
        eggs(7) = PS.Value
        updateHabiTextBoxes()
    End Sub
    Private Sub PN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PN.ValueChanged
        eggs(8) = PN.Value
        updateHabiTextBoxes()
    End Sub

    Private Sub Mag_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mag.ValueChanged
        codestones(0) = Mag.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub Vux_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vux.ValueChanged
        codestones(1) = Vux.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub Cui_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cui.ValueChanged
        codestones(2) = Cui.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub Kew_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kew.ValueChanged
        codestones(3) = Kew.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub Sho_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sho.ValueChanged
        codestones(4) = Sho.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub Zed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zed.ValueChanged
        codestones(5) = Zed.Value
        updateCodeTextBoxes()
    End Sub


    Private Sub Nests_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nests.ValueChanged
        updateNests()
    End Sub

    Private Sub Level_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Level.SelectedIndexChanged
        updateNests()
    End Sub

    Private Sub updateNests()
        If Level.Text() = "Level One" Then
            Wood.Text() = 800 * Nests.Value()
            Mud.Text() = 950 * Nests.Value()
            Stone.Text() = 650 * Nests.Value()

        ElseIf Level.Text() = "Level Two" Then
            Wood.Text() = 1600 * Nests.Value()
            Mud.Text() = 1800 * Nests.Value()
            Stone.Text() = 1700 * Nests.Value()

        ElseIf Level.Text() = "Level Three" Then
            Wood.Text() = 2500 * Nests.Value()
            Mud.Text() = 2750 * Nests.Value()
            Stone.Text() = 3000 * Nests.Value()
        End If

    End Sub

    Private Sub MagC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagC.ValueChanged
        codestones(6) = MagC.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub VuxC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VuxC.ValueChanged
        codestones(7) = VuxC.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub CuiC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuiC.ValueChanged
        codestones(8) = CuiC.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub KewC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KewC.ValueChanged
        codestones(9) = KewC.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub ShoC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShoC.ValueChanged
        codestones(10) = ShoC.Value
        updateCodeTextBoxes()
    End Sub

    Private Sub ZedC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZedC.ValueChanged
        codestones(11) = ZedC.Value
        updateCodeTextBoxes()
    End Sub
End Class
