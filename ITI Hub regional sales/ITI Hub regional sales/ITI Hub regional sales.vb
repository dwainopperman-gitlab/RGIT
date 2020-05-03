Imports System.IO

Public Class ITIHubRegionalSales

    Private Sub BtnKZNSales_Click(sender As Object, e As EventArgs) Handles BtnKZNSales.Click

        ' set properties for OpenFileDialog before showing the dialog box
        OfdKZNSales.Title = "Select the KwaZulu-Natal Sales file"
        OfdKZNSales.InitialDirectory = "%USERPROFILE%\My Documents"
        OfdKZNSales.Filter = "CSV Files | *.csv| Text Files | *.txt"

        ' set the textbox to the filename selected
        If OfdKZNSales.ShowDialog = DialogResult.OK Then
            TxbKZNSalesFile.Text = OfdKZNSales.FileName
        End If


    End Sub

    Private Sub BtnGPSales_Click(sender As Object, e As EventArgs) Handles BtnGPSales.Click

        ' set properties for OpenFileDialog before showing the dialog box
        OfdGPSales.Title = "Select the Gauteng Sales file"
        OfdGPSales.Filter = "CSV Files | *.csv| Text Files | *.txt"

        ' set the textbox to the filename selected
        If OfdGPSales.ShowDialog = DialogResult.OK Then
            TxbGPSalesFile.Text = OfdGPSales.FileName
        End If

    End Sub

    Private Sub BtnWCSales_Click(sender As Object, e As EventArgs) Handles BtnWCSales.Click

        ' set properties for OpenFileDialog before showing the dialog box
        OfdWCSales.Title = "Select the Western Cape Sales file"
        OfdWCSales.Filter = "CSV Files | *.csv| Text Files | *.txt"

        ' set the textbox to the filename selected
        If OfdWCSales.ShowDialog = DialogResult.OK Then
            TxbWCSalesFile.Text = OfdWCSales.FileName
        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        ' close app when exit is clicked
        Me.Close()

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        ' define variables
        Dim sales(2, 5) As String
        Dim numericKZNSalesM1, numericKZNSalesM2, numericKZNSalesM3, numericKZNSalesM4, numericKZNSalesM5, numericKZNSalesM6, numericKZNSalesTot As Int64
        Dim numericGPSalesM1, numericGPSalesM2, numericGPSalesM3, numericGPSalesM4, numericGPSalesM5, numericGPSalesM6, numericGPSalesTot As Int64
        Dim numericWCSalesM1, numericWCSalesM2, numericWCSalesM3, numericWCSalesM4, numericWCSalesM5, numericWCSalesM6, numericWCSalesTot As Int64
        Dim numericTotSalesM1, numericTotSalesM2, numericTotSalesM3, numericTotSalesM4, numericTotSalesM5, numericTotSalesM6, numericTotSalesTot As Int64
        Dim numericKZNPercM1, numericKZNPercM2, numericKZNPercM3, numericKZNPercM4, numericKZNPercM5, numericKZNPercM6, numericKZNPercTot As Int64
        Dim numericGPPercM1, numericGPPercM2, numericGPPercM3, numericGPPercM4, numericGPPercM5, numericGPPercM6, numericGPPercTot As Int64
        Dim numericWCPercM1, numericWCPercM2, numericWCPercM3, numericWCPercM4, numericWCPercM5, numericWCPercM6, numericWCPercTot As Int64

        ' check if file names are valid - KZN file
        If Not IO.File.Exists(TxbKZNSalesFile.Text) Then
            MsgBox("Invalid KwaZulu-Natal Sales file", vbCritical, "Invalid KwaZulu-Natal Sales file")
        End If

        ' check if file names are valid - GP file
        If Not IO.File.Exists(TxbGPSalesFile.Text) Then
            MsgBox("Invalid Gauteng Sales file", vbCritical, "Invalid Gauteng Sales file")
        End If

        ' check if file names are valid - WC file
        If Not IO.File.Exists(TxbWCSalesFile.Text) Then
            MsgBox("Invalid Western Cape Sales file", vbCritical, "Invalid Western Cape Sales file")
        End If

        ' read file contents into array - KZN file
        ReadCSVFileToArray(TxbKZNSalesFile.Text, sales, 0)

        ' populate sales values - KZN 
        numericKZNSalesM1 = Convert.ToInt32(sales(0, 0))
        numericKZNSalesM2 = Convert.ToInt32(sales(0, 1))
        numericKZNSalesM3 = Convert.ToInt32(sales(0, 2))
        numericKZNSalesM4 = Convert.ToInt32(sales(0, 3))
        numericKZNSalesM5 = Convert.ToInt32(sales(0, 4))
        numericKZNSalesM6 = Convert.ToInt32(sales(0, 5))

        TxbKZNSalesM1.AppendText("R" & numericKZNSalesM1.ToString("N0"))
        TxbKZNSalesM2.AppendText("R" & numericKZNSalesM2.ToString("N0"))
        TxbKZNSalesM3.AppendText("R" & numericKZNSalesM3.ToString("N0"))
        TxbKZNSalesM4.AppendText("R" & numericKZNSalesM4.ToString("N0"))
        TxbKZNSalesM5.AppendText("R" & numericKZNSalesM5.ToString("N0"))
        TxbKZNSalesM6.AppendText("R" & numericKZNSalesM6.ToString("N0"))

        numericKZNSalesTot = numericKZNSalesM1 + numericKZNSalesM2 + numericKZNSalesM3 + numericKZNSalesM4 + numericKZNSalesM5 + numericKZNSalesM6
        TxbKZNSalesTot.AppendText("R" & numericKZNSalesTot.ToString("N0"))


        ' read file contents into array - GP file
        ReadCSVFileToArray(TxbGPSalesFile.Text, sales, 1)

        ' populate sales values - GP
        numericGPSalesM1 = Convert.ToInt32(sales(1, 0))
        numericGPSalesM2 = Convert.ToInt32(sales(1, 1))
        numericGPSalesM3 = Convert.ToInt32(sales(1, 2))
        numericGPSalesM4 = Convert.ToInt32(sales(1, 3))
        numericGPSalesM5 = Convert.ToInt32(sales(1, 4))
        numericGPSalesM6 = Convert.ToInt32(sales(1, 5))

        TxbGPSalesM1.AppendText("R" & numericGPSalesM1.ToString("N0"))
        TxbGPSalesM2.AppendText("R" & numericGPSalesM2.ToString("N0"))
        TxbGPSalesM3.AppendText("R" & numericGPSalesM3.ToString("N0"))
        TxbGPSalesM4.AppendText("R" & numericGPSalesM4.ToString("N0"))
        TxbGPSalesM5.AppendText("R" & numericGPSalesM5.ToString("N0"))
        TxbGPSalesM6.AppendText("R" & numericGPSalesM6.ToString("N0"))

        numericGPSalesTot = numericGPSalesM1 + numericGPSalesM2 + numericGPSalesM3 + numericGPSalesM4 + numericGPSalesM5 + numericGPSalesM6
        TxbGPSalesTot.AppendText("R" & numericGPSalesTot.ToString("N0"))

        ' read file contents into array - WC file
        ReadCSVFileToArray(TxbWCSalesFile.Text, sales, 2)

        ' populate sales values - WC
        numericWCSalesM1 = Convert.ToInt32(sales(2, 0))
        numericWCSalesM2 = Convert.ToInt32(sales(2, 1))
        numericWCSalesM3 = Convert.ToInt32(sales(2, 2))
        numericWCSalesM4 = Convert.ToInt32(sales(2, 3))
        numericWCSalesM5 = Convert.ToInt32(sales(2, 4))
        numericWCSalesM6 = Convert.ToInt32(sales(2, 5))

        TxbWCSalesM1.AppendText("R" & numericWCSalesM1.ToString("N0"))
        TxbWCSalesM2.AppendText("R" & numericWCSalesM2.ToString("N0"))
        TxbWCSalesM3.AppendText("R" & numericWCSalesM3.ToString("N0"))
        TxbWCSalesM4.AppendText("R" & numericWCSalesM4.ToString("N0"))
        TxbWCSalesM5.AppendText("R" & numericWCSalesM5.ToString("N0"))
        TxbWCSalesM6.AppendText("R" & numericWCSalesM6.ToString("N0"))

        numericWCSalesTot = numericWCSalesM1 + numericWCSalesM2 + numericWCSalesM3 + numericWCSalesM4 + numericWCSalesM5 + numericWCSalesM6
        TxbWCSalesTot.AppendText("R" & numericWCSalesTot.ToString("N0"))

        ' calculate total sales values 
        numericTotSalesM1 = numericKZNSalesM1 + numericGPSalesM1 + numericWCSalesM1
        numericTotSalesM2 = numericKZNSalesM2 + numericGPSalesM2 + numericWCSalesM2
        numericTotSalesM3 = numericKZNSalesM3 + numericGPSalesM3 + numericWCSalesM3
        numericTotSalesM4 = numericKZNSalesM4 + numericGPSalesM4 + numericWCSalesM4
        numericTotSalesM5 = numericKZNSalesM5 + numericGPSalesM5 + numericWCSalesM5
        numericTotSalesM6 = numericKZNSalesM6 + numericGPSalesM6 + numericWCSalesM6

        TxbTotSalesM1.AppendText("R" & numericTotSalesM1.ToString("N0"))
        TxbTotSalesM2.AppendText("R" & numericTotSalesM2.ToString("N0"))
        TxbTotSalesM3.AppendText("R" & numericTotSalesM3.ToString("N0"))
        TxbTotSalesM4.AppendText("R" & numericTotSalesM4.ToString("N0"))
        TxbTotSalesM5.AppendText("R" & numericTotSalesM5.ToString("N0"))
        TxbTotSalesM6.AppendText("R" & numericTotSalesM6.ToString("N0"))

        numericTotSalesTot = numericKZNSalesTot + numericGPSalesTot + numericWCSalesTot
        TxbTotSalesTot.AppendText("R" & numericTotSalesTot.ToString("N0"))

        ' calculate percentages - KZN
        numericKZNPercM1 = numericKZNSalesM1 / numericTotSalesM1 * 100
        numericKZNPercM2 = numericKZNSalesM2 / numericTotSalesM2 * 100
        numericKZNPercM3 = numericKZNSalesM3 / numericTotSalesM3 * 100
        numericKZNPercM4 = numericKZNSalesM4 / numericTotSalesM4 * 100
        numericKZNPercM5 = numericKZNSalesM5 / numericTotSalesM5 * 100
        numericKZNPercM6 = numericKZNSalesM6 / numericTotSalesM6 * 100

        TxbKZNPercM1.AppendText(numericKZNPercM1.ToString("N0") & "%")
        TxbKZNPercM2.AppendText(numericKZNPercM2.ToString("N0") & "%")
        TxbKZNPercM3.AppendText(numericKZNPercM3.ToString("N0") & "%")
        TxbKZNPercM4.AppendText(numericKZNPercM4.ToString("N0") & "%")
        TxbKZNPercM5.AppendText(numericKZNPercM5.ToString("N0") & "%")
        TxbKZNPercM6.AppendText(numericKZNPercM6.ToString("N0") & "%")

        numericKZNPercTot = numericKZNSalesTot / numericTotSalesTot * 100
        TxbKZNPercTot.AppendText(numericKZNPercTot.ToString("N0") & "%")

        ' calculate percentages - GP
        numericGPPercM1 = numericGPSalesM1 / numericTotSalesM1 * 100
        numericGPPercM2 = numericGPSalesM2 / numericTotSalesM2 * 100
        numericGPPercM3 = numericGPSalesM3 / numericTotSalesM3 * 100
        numericGPPercM4 = numericGPSalesM4 / numericTotSalesM4 * 100
        numericGPPercM5 = numericGPSalesM5 / numericTotSalesM5 * 100
        numericGPPercM6 = numericGPSalesM6 / numericTotSalesM6 * 100

        TxbGPPercM1.AppendText(numericGPPercM1.ToString("N0") & "%")
        TxbGPPercM2.AppendText(numericGPPercM2.ToString("N0") & "%")
        TxbGPPercM3.AppendText(numericGPPercM3.ToString("N0") & "%")
        TxbGPPercM4.AppendText(numericGPPercM4.ToString("N0") & "%")
        TxbGPPercM5.AppendText(numericGPPercM5.ToString("N0") & "%")
        TxbGPPercM6.AppendText(numericGPPercM6.ToString("N0") & "%")

        numericGPPercTot = numericGPSalesTot / numericTotSalesTot * 100
        TxbGPPercTot.AppendText(numericGPPercTot.ToString("N0") & "%")

        ' calculate percentages - WC
        numericWCPercM1 = numericWCSalesM1 / numericTotSalesM1 * 100
        numericWCPercM2 = numericWCSalesM2 / numericTotSalesM2 * 100
        numericWCPercM3 = numericWCSalesM3 / numericTotSalesM3 * 100
        numericWCPercM4 = numericWCSalesM4 / numericTotSalesM4 * 100
        numericWCPercM5 = numericWCSalesM5 / numericTotSalesM5 * 100
        numericWCPercM6 = numericWCSalesM6 / numericTotSalesM6 * 100

        TxbWCPercM1.AppendText(numericWCPercM1.ToString("N0") & "%")
        TxbWCPercM2.AppendText(numericWCPercM2.ToString("N0") & "%")
        TxbWCPercM3.AppendText(numericWCPercM3.ToString("N0") & "%")
        TxbWCPercM4.AppendText(numericWCPercM4.ToString("N0") & "%")
        TxbWCPercM5.AppendText(numericWCPercM5.ToString("N0") & "%")
        TxbWCPercM6.AppendText(numericWCPercM6.ToString("N0") & "%")

        numericWCPercTot = numericWCSalesTot / numericTotSalesTot * 100
        TxbWCPercTot.AppendText(numericWCPercTot.ToString("N0") & "%")

    End Sub

    Private Sub ReadCSVFileToArray(ByVal fileName As String, ByRef strarray(,) As String, regionIndex As Int16)

        ' define varibales 
        Dim monthIndex As Integer = 0

        ' only continue if file exists
        If File.Exists(fileName) Then

            ' open file 
            Dim fStream As New System.IO.FileStream(fileName, IO.FileMode.Open)
            Dim sReader As New System.IO.StreamReader(fStream)

            Do While sReader.Peek >= 0
                strarray(regionIndex, monthIndex) = sReader.ReadLine
                monthIndex += 1
            Loop

            fStream.Close()
            sReader.Close()
        End If


    End Sub
End Class
