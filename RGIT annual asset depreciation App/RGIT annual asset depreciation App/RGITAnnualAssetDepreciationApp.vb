Public Class RGITAnnualAssetDepreciationApp
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ' close app when clicking on Exit button
        Me.Close()

    End Sub

    Private Sub BtnDisplayDepreciation_Click(sender As Object, e As EventArgs) Handles BtnDisplayDepreciation.Click
        ' define variables 
        Dim assetCost As Double
        Dim salvageValue As Double
        Dim usefulLife As Double
        Dim doubleDecliningBal As Double
        Dim sumOfTheYearsDigits As Double

        ' convert input text to numeric because input has already been validated
        assetCost = CDbl(TxbAssetCost.Text)
        salvageValue = CDbl(TxbSalvageValue.Text)
        usefulLife = CDbl(CmbUsefulLife.Text)

        ' write headings in textboxes
        TxbDoubleDecliningBal.AppendText("Year" & vbTab & "Depreciation" & vbCrLf)
        TxbSumOfTheYearsDigits.AppendText("Year" & vbTab & "Depreciation" & vbCrLf)


        ' loop for number of useful years 
        For counter As Int16 = 1 To usefulLife
            ' calculate SYD 
            sumOfTheYearsDigits = SYD(assetCost, salvageValue, usefulLife, counter)

            ' calculate DDB 
            doubleDecliningBal = DDB(assetCost, salvageValue, usefulLife, counter)

            ' write values to textbox 
            TxbDoubleDecliningBal.AppendText(counter & vbTab & doubleDecliningBal.ToString("N2") & vbCrLf)
            TxbSumOfTheYearsDigits.AppendText(counter & vbTab & sumOfTheYearsDigits.ToString("N2") & vbCrLf)

        Next


    End Sub

    Private Sub TxbAssetCost_TextChanged(sender As Object, e As EventArgs) Handles TxbAssetCost.TextChanged
        ' check if value can be converted to double 
        Dim dblAssetCost As Double

        Try
            dblAssetCost = CDbl(TxbAssetCost.Text)
        Catch ex As Exception
            MsgBox("Please enter a valid number", vbObjectError, "Validation Error")

        End Try
    End Sub

    Private Sub TxbSalvageValue_TextChanged(sender As Object, e As EventArgs) Handles TxbSalvageValue.TextChanged
        ' check if value can be converted to double 
        Dim dblSalvageValue As Double

        Try
            dblSalvageValue = CDbl(TxbSalvageValue.Text)
        Catch ex As Exception
            MsgBox("Please enter a valid number", vbObjectError, "Validation Error")

        End Try

    End Sub
End Class
