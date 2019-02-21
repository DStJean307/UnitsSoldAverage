<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUnitsAverage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAverageOutput = New System.Windows.Forms.TextBox()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lvlUnits = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtDisplayInputs = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 273)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(91, 26)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Click this button to enter the units sold")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(154, 273)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(91, 26)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click this button to reset the program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(296, 273)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 26)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click this button to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAverageOutput
        '
        Me.txtAverageOutput.Location = New System.Drawing.Point(9, 230)
        Me.txtAverageOutput.Name = "txtAverageOutput"
        Me.txtAverageOutput.ReadOnly = True
        Me.txtAverageOutput.Size = New System.Drawing.Size(377, 22)
        Me.txtAverageOutput.TabIndex = 5
        Me.txtAverageOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtAverageOutput, "This text box outputs the average units sold")
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(142, 12)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(103, 22)
        Me.txtUserInput.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtUserInput, "Input units sold here")
        '
        'lvlUnits
        '
        Me.lvlUnits.AutoSize = True
        Me.lvlUnits.Location = New System.Drawing.Point(60, 15)
        Me.lvlUnits.Name = "lvlUnits"
        Me.lvlUnits.Size = New System.Drawing.Size(44, 17)
        Me.lvlUnits.TabIndex = 6
        Me.lvlUnits.Text = "Units:"
        Me.lvlUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDays
        '
        Me.lblDays.Location = New System.Drawing.Point(283, 15)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(45, 17)
        Me.lblDays.TabIndex = 7
        Me.lblDays.Text = "Day 1"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDisplayInputs
        '
        Me.txtDisplayInputs.Location = New System.Drawing.Point(9, 54)
        Me.txtDisplayInputs.Multiline = True
        Me.txtDisplayInputs.Name = "txtDisplayInputs"
        Me.txtDisplayInputs.ReadOnly = True
        Me.txtDisplayInputs.Size = New System.Drawing.Size(376, 165)
        Me.txtDisplayInputs.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtDisplayInputs, "This tex box displays units sold for each day")
        '
        'ToolTip1
        '
        '
        'frmUnitsAverage
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(399, 311)
        Me.Controls.Add(Me.txtDisplayInputs)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lvlUnits)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.txtAverageOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(417, 358)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(417, 358)
        Me.Name = "frmUnitsAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAverageOutput As TextBox
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lvlUnits As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents txtDisplayInputs As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
