<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WallpaperApp
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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.CmbLength = New System.Windows.Forms.ComboBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.CmbWidth = New System.Windows.Forms.ComboBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.CmbHeight = New System.Windows.Forms.ComboBox()
        Me.lblRollCoverage = New System.Windows.Forms.Label()
        Me.CmbRollCoverage = New System.Windows.Forms.ComboBox()
        Me.TxbSingleRoll = New System.Windows.Forms.TextBox()
        Me.lblSingleRoll = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(12, 29)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(94, 17)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Length (feet):"
        '
        'CmbLength
        '
        Me.CmbLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLength.FormattingEnabled = True
        Me.CmbLength.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.CmbLength.Location = New System.Drawing.Point(163, 26)
        Me.CmbLength.Name = "CmbLength"
        Me.CmbLength.Size = New System.Drawing.Size(174, 24)
        Me.CmbLength.TabIndex = 1
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(12, 84)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(86, 17)
        Me.lblWidth.TabIndex = 2
        Me.lblWidth.Text = "Width (feet):"
        '
        'CmbWidth
        '
        Me.CmbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbWidth.FormattingEnabled = True
        Me.CmbWidth.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.CmbWidth.Location = New System.Drawing.Point(163, 83)
        Me.CmbWidth.Name = "CmbWidth"
        Me.CmbWidth.Size = New System.Drawing.Size(174, 24)
        Me.CmbWidth.TabIndex = 3
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(12, 140)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(91, 17)
        Me.lblHeight.TabIndex = 4
        Me.lblHeight.Text = "Height (feet):"
        '
        'CmbHeight
        '
        Me.CmbHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbHeight.FormattingEnabled = True
        Me.CmbHeight.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.CmbHeight.Location = New System.Drawing.Point(163, 137)
        Me.CmbHeight.Name = "CmbHeight"
        Me.CmbHeight.Size = New System.Drawing.Size(174, 24)
        Me.CmbHeight.TabIndex = 5
        '
        'lblRollCoverage
        '
        Me.lblRollCoverage.AutoSize = True
        Me.lblRollCoverage.Location = New System.Drawing.Point(12, 194)
        Me.lblRollCoverage.Name = "lblRollCoverage"
        Me.lblRollCoverage.Size = New System.Drawing.Size(145, 17)
        Me.lblRollCoverage.TabIndex = 6
        Me.lblRollCoverage.Text = "Roll coverage (sqrFt):"
        '
        'CmbRollCoverage
        '
        Me.CmbRollCoverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRollCoverage.FormattingEnabled = True
        Me.CmbRollCoverage.Items.AddRange(New Object() {"40", "40.5", "41", "41.5", "42", "42.5", "43", "43.5", "44", "44.5", "45", "45.5", "46", "46.5", "47", "47.5", "48", "48.5", "49", "49.5", "50"})
        Me.CmbRollCoverage.Location = New System.Drawing.Point(163, 191)
        Me.CmbRollCoverage.Name = "CmbRollCoverage"
        Me.CmbRollCoverage.Size = New System.Drawing.Size(174, 24)
        Me.CmbRollCoverage.TabIndex = 7
        '
        'TxbSingleRoll
        '
        Me.TxbSingleRoll.Location = New System.Drawing.Point(437, 85)
        Me.TxbSingleRoll.Name = "TxbSingleRoll"
        Me.TxbSingleRoll.Size = New System.Drawing.Size(187, 22)
        Me.TxbSingleRoll.TabIndex = 8
        '
        'lblSingleRoll
        '
        Me.lblSingleRoll.AutoSize = True
        Me.lblSingleRoll.Location = New System.Drawing.Point(434, 65)
        Me.lblSingleRoll.Name = "lblSingleRoll"
        Me.lblSingleRoll.Size = New System.Drawing.Size(74, 17)
        Me.lblSingleRoll.TabIndex = 9
        Me.lblSingleRoll.Text = "Single roll:"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(433, 140)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 10
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(549, 140)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'WallpaperApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 307)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.lblSingleRoll)
        Me.Controls.Add(Me.TxbSingleRoll)
        Me.Controls.Add(Me.CmbRollCoverage)
        Me.Controls.Add(Me.lblRollCoverage)
        Me.Controls.Add(Me.CmbHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.CmbWidth)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.CmbLength)
        Me.Controls.Add(Me.lblLength)
        Me.Name = "WallpaperApp"
        Me.Text = "Wallpaper App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLength As Label
    Friend WithEvents CmbLength As ComboBox
    Friend WithEvents lblWidth As Label
    Friend WithEvents CmbWidth As ComboBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents CmbHeight As ComboBox
    Friend WithEvents lblRollCoverage As Label
    Friend WithEvents CmbRollCoverage As ComboBox
    Friend WithEvents TxbSingleRoll As TextBox
    Friend WithEvents lblSingleRoll As Label
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnExit As Button
End Class
