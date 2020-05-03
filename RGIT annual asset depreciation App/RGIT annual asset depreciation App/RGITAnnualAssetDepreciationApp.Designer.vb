<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RGITAnnualAssetDepreciationApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAssetCost = New System.Windows.Forms.Label()
        Me.TxbAssetCost = New System.Windows.Forms.TextBox()
        Me.lblSalvageValue = New System.Windows.Forms.Label()
        Me.TxbSalvageValue = New System.Windows.Forms.TextBox()
        Me.lblUsefulLife = New System.Windows.Forms.Label()
        Me.BtnDisplayDepreciation = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GpbDepreciationSchedules = New System.Windows.Forms.GroupBox()
        Me.TxbSumOfTheYearsDigits = New System.Windows.Forms.TextBox()
        Me.TxbDoubleDecliningBal = New System.Windows.Forms.TextBox()
        Me.lblSumOfTheYearsDigits = New System.Windows.Forms.Label()
        Me.lblDoubleDecliningBal = New System.Windows.Forms.Label()
        Me.CmbUsefulLife = New System.Windows.Forms.ComboBox()
        Me.GpbDepreciationSchedules.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAssetCost
        '
        Me.lblAssetCost.AutoSize = True
        Me.lblAssetCost.Location = New System.Drawing.Point(13, 26)
        Me.lblAssetCost.Name = "lblAssetCost"
        Me.lblAssetCost.Size = New System.Drawing.Size(77, 17)
        Me.lblAssetCost.TabIndex = 6
        Me.lblAssetCost.Text = "Asset cost:"
        '
        'TxbAssetCost
        '
        Me.TxbAssetCost.Location = New System.Drawing.Point(190, 26)
        Me.TxbAssetCost.Name = "TxbAssetCost"
        Me.TxbAssetCost.Size = New System.Drawing.Size(153, 22)
        Me.TxbAssetCost.TabIndex = 1
        '
        'lblSalvageValue
        '
        Me.lblSalvageValue.AutoSize = True
        Me.lblSalvageValue.Location = New System.Drawing.Point(13, 72)
        Me.lblSalvageValue.Name = "lblSalvageValue"
        Me.lblSalvageValue.Size = New System.Drawing.Size(101, 17)
        Me.lblSalvageValue.TabIndex = 7
        Me.lblSalvageValue.Text = "Salvage value:"
        '
        'TxbSalvageValue
        '
        Me.TxbSalvageValue.Location = New System.Drawing.Point(190, 72)
        Me.TxbSalvageValue.Name = "TxbSalvageValue"
        Me.TxbSalvageValue.Size = New System.Drawing.Size(153, 22)
        Me.TxbSalvageValue.TabIndex = 2
        '
        'lblUsefulLife
        '
        Me.lblUsefulLife.AutoSize = True
        Me.lblUsefulLife.Location = New System.Drawing.Point(13, 117)
        Me.lblUsefulLife.Name = "lblUsefulLife"
        Me.lblUsefulLife.Size = New System.Drawing.Size(74, 17)
        Me.lblUsefulLife.TabIndex = 8
        Me.lblUsefulLife.Text = "Useful life:"
        '
        'BtnDisplayDepreciation
        '
        Me.BtnDisplayDepreciation.Location = New System.Drawing.Point(16, 211)
        Me.BtnDisplayDepreciation.Name = "BtnDisplayDepreciation"
        Me.BtnDisplayDepreciation.Size = New System.Drawing.Size(154, 84)
        Me.BtnDisplayDepreciation.TabIndex = 4
        Me.BtnDisplayDepreciation.Text = "Display depreciation schedules"
        Me.BtnDisplayDepreciation.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(233, 210)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(110, 85)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'GpbDepreciationSchedules
        '
        Me.GpbDepreciationSchedules.Controls.Add(Me.TxbSumOfTheYearsDigits)
        Me.GpbDepreciationSchedules.Controls.Add(Me.TxbDoubleDecliningBal)
        Me.GpbDepreciationSchedules.Controls.Add(Me.lblSumOfTheYearsDigits)
        Me.GpbDepreciationSchedules.Controls.Add(Me.lblDoubleDecliningBal)
        Me.GpbDepreciationSchedules.Location = New System.Drawing.Point(375, 26)
        Me.GpbDepreciationSchedules.Name = "GpbDepreciationSchedules"
        Me.GpbDepreciationSchedules.Size = New System.Drawing.Size(585, 394)
        Me.GpbDepreciationSchedules.TabIndex = 9
        Me.GpbDepreciationSchedules.TabStop = False
        Me.GpbDepreciationSchedules.Text = "Depreciation schedules"
        '
        'TxbSumOfTheYearsDigits
        '
        Me.TxbSumOfTheYearsDigits.Location = New System.Drawing.Point(305, 76)
        Me.TxbSumOfTheYearsDigits.Multiline = True
        Me.TxbSumOfTheYearsDigits.Name = "TxbSumOfTheYearsDigits"
        Me.TxbSumOfTheYearsDigits.Size = New System.Drawing.Size(263, 290)
        Me.TxbSumOfTheYearsDigits.TabIndex = 13
        '
        'TxbDoubleDecliningBal
        '
        Me.TxbDoubleDecliningBal.Location = New System.Drawing.Point(10, 76)
        Me.TxbDoubleDecliningBal.Multiline = True
        Me.TxbDoubleDecliningBal.Name = "TxbDoubleDecliningBal"
        Me.TxbDoubleDecliningBal.Size = New System.Drawing.Size(277, 290)
        Me.TxbDoubleDecliningBal.TabIndex = 12
        '
        'lblSumOfTheYearsDigits
        '
        Me.lblSumOfTheYearsDigits.AutoSize = True
        Me.lblSumOfTheYearsDigits.Location = New System.Drawing.Point(302, 45)
        Me.lblSumOfTheYearsDigits.Name = "lblSumOfTheYearsDigits"
        Me.lblSumOfTheYearsDigits.Size = New System.Drawing.Size(162, 17)
        Me.lblSumOfTheYearsDigits.TabIndex = 11
        Me.lblSumOfTheYearsDigits.Text = "Sum-of-the-year's digits:"
        '
        'lblDoubleDecliningBal
        '
        Me.lblDoubleDecliningBal.AutoSize = True
        Me.lblDoubleDecliningBal.Location = New System.Drawing.Point(7, 45)
        Me.lblDoubleDecliningBal.Name = "lblDoubleDecliningBal"
        Me.lblDoubleDecliningBal.Size = New System.Drawing.Size(179, 17)
        Me.lblDoubleDecliningBal.TabIndex = 10
        Me.lblDoubleDecliningBal.Text = "Double-declining balances:"
        '
        'CmbUsefulLife
        '
        Me.CmbUsefulLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsefulLife.FormattingEnabled = True
        Me.CmbUsefulLife.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.CmbUsefulLife.Location = New System.Drawing.Point(190, 117)
        Me.CmbUsefulLife.Name = "CmbUsefulLife"
        Me.CmbUsefulLife.Size = New System.Drawing.Size(153, 24)
        Me.CmbUsefulLife.TabIndex = 3
        '
        'RGITAnnualAssetDepreciationApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 457)
        Me.Controls.Add(Me.CmbUsefulLife)
        Me.Controls.Add(Me.GpbDepreciationSchedules)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDisplayDepreciation)
        Me.Controls.Add(Me.lblUsefulLife)
        Me.Controls.Add(Me.TxbSalvageValue)
        Me.Controls.Add(Me.lblSalvageValue)
        Me.Controls.Add(Me.TxbAssetCost)
        Me.Controls.Add(Me.lblAssetCost)
        Me.Name = "RGITAnnualAssetDepreciationApp"
        Me.Text = "RGIT annual asset depreciation App"
        Me.GpbDepreciationSchedules.ResumeLayout(False)
        Me.GpbDepreciationSchedules.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAssetCost As Label
    Friend WithEvents TxbAssetCost As TextBox
    Friend WithEvents lblSalvageValue As Label
    Friend WithEvents TxbSalvageValue As TextBox
    Friend WithEvents lblUsefulLife As Label
    Friend WithEvents BtnDisplayDepreciation As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents GpbDepreciationSchedules As GroupBox
    Friend WithEvents TxbSumOfTheYearsDigits As TextBox
    Friend WithEvents TxbDoubleDecliningBal As TextBox
    Friend WithEvents lblSumOfTheYearsDigits As Label
    Friend WithEvents lblDoubleDecliningBal As Label
    Friend WithEvents CmbUsefulLife As ComboBox
End Class
