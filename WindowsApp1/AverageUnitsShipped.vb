Option Strict On
'Darcy St Jean 100722175
'This program takes the amount of units shipped from the user over 7 days,
'calculates a sales average and outputs it to the user
Public Class frmUnitsAverage
    Dim userInputInteger As Integer
    Dim inputCounter As Integer = 0
    Dim unitsPerDay(6) As Integer
    Dim unitsTotal As Integer
    Dim unitAverage As Double
    Dim userInputDouble As Double
    Dim displayInputs As String







    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ''' <summary>
    ''' recieved user input, performs input validation and processes the input
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        txtAverageOutput.Clear()
        'Checks if user input is a double
        If (Double.TryParse(txtUserInput.Text, userInputDouble)) Then
            'Checks if user input is an integer
            If (Integer.TryParse(txtUserInput.Text, userInputInteger)) Then




                'Checks if userInput is between 0 and 1000
                If (userInputInteger > 1000 OrElse userInputInteger < 0) Then
                    txtAverageOutput.Text = "Input must be between 0 to 1000 inclusive"
                    txtUserInput.Clear()

                    'Increments inputCounter
                ElseIf (inputCounter < unitsPerDay.Length - 1) Then
                    unitsPerDay(inputCounter) = userInputInteger
                    inputCounter += 1
                    lblDays.Text = "Day " + (inputCounter + 1).ToString
                    txtUserInput.Clear()
                    displayInputs += userInputInteger.ToString + Environment.NewLine
                    txtDisplayInputs.Text = displayInputs

                Else
                    btnEnter.Enabled = False
                    displayInputs += userInputInteger.ToString
                    txtDisplayInputs.Text = displayInputs
                    unitsPerDay(inputCounter) = userInputInteger
                    For arrayCounter = 0 To unitsPerDay.Length - 1
                        unitsTotal += unitsPerDay(arrayCounter)
                    Next
                    txtUserInput.Clear()
                    txtUserInput.ReadOnly = True
                    unitAverage = unitsTotal / unitsPerDay.Length
                    txtAverageOutput.Text = " Average per day: " + unitAverage.ToString("####.##")
                End If
            Else
                txtAverageOutput.Text = "Input must be a whole number"
                txtUserInput.Clear()
            End If
        Else
            txtAverageOutput.Text = "Input must be numeric"
            txtUserInput.Clear()

        End If


    End Sub

    ''' <summary>
    '''  Clears all text boxes, resets day count to 1, input counter to 0 , clears the array,
    '''  re enables enter and resets the day label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserInput.Clear()
        txtAverageOutput.Clear()
        txtUserInput.ReadOnly = False
        inputCounter = 0
        lblDays.Text = "Day " + (inputCounter + 1).ToString
        btnEnter.Enabled = True
        txtDisplayInputs.Clear()
        displayInputs = ""
        For arrayCounter = 0 To unitsPerDay.Length - 1
            unitsPerDay(arrayCounter) = 0

        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub txtAverageOutput_TextChanged(sender As Object, e As EventArgs) Handles txtAverageOutput.TextChanged

    End Sub
End Class
