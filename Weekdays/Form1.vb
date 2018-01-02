Option Strict On

Public Class Form1

    Dim dblHours(6) As Double
    Dim strDay As String
    Dim intMaximumDay As Integer
    Dim intMinimumDay As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strAmount As String
        Dim strInputDay As String

        Try

            For i = 0 To dblHours.Length - 1

                strInputDay = GetDay(i)
                strAmount = InputBox("Please enter hours worked on" & strInputDay)
                If Validation(strAmount, dblHours(i)) = True Then
                    lstResult.Items.Add("Hours for" & strInputDay & "are" & "" & dblHours(i))
                Else
                    i -= 1
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Function Validation(ByVal Hours As String, ByRef HoursNumeric As Double) As Boolean

        If IsNumeric(Hours) Then
            HoursNumeric = CDbl(Hours)
        Else
            MessageBox.Show("Please enter numbers only")
            Return False
        End If

        Return True

    End Function

    Private Function GetDay(ByVal Day As Integer) As String
        Select Case Day
            Case 0
                strDay = "Monday"
            Case 1
                strDay = "Tuesday"
            Case 2
                strDay = "Wednesday"
            Case 3
                strDay = "Thursday"
            Case 4
                strDay = "Friday"
            Case 5
                strDay = "Saturday"
            Case 6
                strDay = "Sunday"
        End Select

        Return strDay
    End Function

    Private Function GetTotal() As Double
        Dim dblTotal As Double

        For i = 0 To dblHours.Length - 1
            dblTotal += dblHours(i)
        Next


        Return dblTotal
    End Function



    Private Function GetMaximum() As Double
        Dim dblMaximum As Double



        Return dblMaximum


    End Function

    Private Function GetMinimum() As Double
        Dim dblMinimum As Double = 100



        Return dblMinimum


    End Function

    Private Function GetAverage() As Double
        Dim dblAverageTotal As Double
        Dim dblAverage As Double

        For i = 0 To dblHours.Length - 1
            dblAverage += dblHours(i)
        Next
        dblAverageTotal = dblAverage / dblHours.Length

        Return dblAverageTotal

    End Function


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim dblTotalDisplay As Double
        Dim dblMaximumDisplay As Double
        Dim strDayDisplay As String
        Dim dblMinimumDisplay As Double
        Dim dblAverageDisplay As Double

        dblTotalDisplay = GetTotal()

        dblMaximumDisplay = GetMaximum()

        strDayDisplay = GetDay(intMinimumDay)

        lblTotal.Text = "The total hours worked are " & dblTotalDisplay

        lblMaximum.Text = "The maximum daily hours was " & dblMaximumDisplay & " on " & strDayDisplay

        dblMinimumDisplay = GetMinimum()

        strDayDisplay = GetDay(intMinimumDay)

        lblMinimum.Text = "The minimum daily hours was " & dblMinimumDisplay & " on " & strDayDisplay

        dblAverageDisplay = GetAverage()

        lblAverage.Text = "The average hours worked is " & dblAverageDisplay.ToString("G3")


    End Sub

End Class

