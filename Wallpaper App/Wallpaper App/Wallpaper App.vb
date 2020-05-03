Public Class WallpaperApp
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ' close app when the exit button is clicked
        Me.Close()

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        ' define variables
        Dim numberOfRolls, rollCoverage As Double
        Dim length, height, width As Int16

        ' assign values to variables 
        numberOfRolls = 0
        length = CmbLength.Text
        height = CmbHeight.Text
        width = CmbWidth.Text
        rollCoverage = CmbRollCoverage.Text

        ' call sub routine to calculate number of rolls 
        CalculateNumberOfRoles(numberOfRolls, length, height, width, rollCoverage)

        ' set textbox value to number of rolls
        TxbSingleRoll.Text = numberOfRolls

    End Sub

    Private Sub CalculateNumberOfRoles(ByRef numberOfRolls As Double, ByVal length As Int16, ByVal height As Int16, ByVal width As Int16, ByVal rollCoverage As Double)
        ' calculate how many rolls are required 
        numberOfRolls = ((length * height * 2) + (width * height * 2)) / rollCoverage

        ' round up number of rolls required
        numberOfRolls = Math.Ceiling(numberOfRolls)

    End Sub



    Private Sub CmbLength_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLength.SelectedIndexChanged
        ' initialise single roll value when the length value changes (requirement 4)
        TxbSingleRoll.Text = ""

    End Sub

    Private Sub CmbWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbWidth.SelectedIndexChanged
        ' initialise single roll value when the width value changes (requirement 4)
        TxbSingleRoll.Text = ""

    End Sub

    Private Sub CmbHeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbHeight.SelectedIndexChanged
        ' initialise single roll value when the height value changes (requirement 4)
        TxbSingleRoll.Text = ""

    End Sub

    Private Sub CmbRollCoverage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRollCoverage.SelectedIndexChanged
        ' initialise single roll value when the roll coverage value changes (requirement 4)
        TxbSingleRoll.Text = ""

    End Sub
End Class
