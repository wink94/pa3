Imports System.IO
Public Class Form1

    Shared gradeArray(5) As data
    Shared count As Integer = 0
    Structure data
        Public index As String
        Public modCode As String
        Public mark As Double
        Public attndnce As Double
        Public grade As String
    End Structure


    Private Sub btnCalcGrade_Click(sender As Object, e As EventArgs) Handles btnCalcGrade.Click

        Dim grade, index, modCode As String
        Dim mark, attendance As Double

        If txtRegNum.Text = "" Or txtModCode.Text = "" Or txtMarks.Text = "" Or txtAttendance.Text = "" Then
            MessageBox.Show("All fiels are required")
        ElseIf indexCheck(txtRegNum.Text) = False Or checkModCode(txtModCode.Text) = False Or IsNumeric(txtMarks.Text) = False Or IsNumeric(txtAttendance.Text) = False Then
            MessageBox.Show("Invalid values are enterd")
        Else
            index = txtRegNum.Text
            modCode = txtModCode.Text
            mark = txtMarks.Text
            attendance = txtAttendance.Text
            grade = attendanceGrader(mark, attendance)
            lblGradeDisplay.Text = grade

            If count <= gradeArray.GetUpperBound(0) Then
                gradeArray(count).index = index
                gradeArray(count).modCode = modCode
                gradeArray(count).mark = mark
                gradeArray(count).attndnce = attendance
                gradeArray(count).grade = grade

                count += 1
            Else
                ReDim Preserve gradeArray(gradeArray.Length + 2)
                gradeArray(count).index = index
                gradeArray(count).modCode = modCode
                gradeArray(count).mark = mark
                gradeArray(count).attndnce = attendance
                gradeArray(count).grade = grade

                count += 1
            End If

        End If

    End Sub

    Function getGrade(mark As Double) As String

        If mark >= 90 Then
            Return "A+"
        ElseIf mark >= 80 Then
            Return "A"
        ElseIf mark >= 65 Then
            Return "B"
        ElseIf mark >= 50 Then
            Return "C"
        ElseIf mark >= 40 Then
            Return "C-"
        ElseIf mark >= 0 Then
            Return "F"
        Else
            Return vbNull
        End If

    End Function

    Function attendanceGrader(mark As Double, attendance As Double) As String

        If attendance >= 80 Then
            Return getGrade(mark)

        ElseIf attendance >= 60 Then
            If mark >= 65 Then
                Return "C"
            Else
                Return getGrade(mark)
            End If
        Else
            Return "F"
        End If

    End Function

    Function checkModCode(code As String) As Boolean

        If code.Length = 4 Then

            If Char.IsLetter(code.Chars(0)) And Char.IsLetter(code.Chars(1)) And Char.IsNumber(code.Chars(2)) And Char.IsNumber(code.Chars(3)) Then
                Return True
            Else
                Return False
            End If

        Else
            Return False

        End If
    End Function


    Function indexCheck(indxNum As String) As String

        If indxNum.Length = 6 And IsNumeric(indxNum) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btnWritetoFile_Click(sender As Object, e As EventArgs) Handles btnWritetoFile.Click

        Dim sw As StreamWriter = File.AppendText("myfile.txt")
        Dim temp As String

        For Each item As data In gradeArray

            If item.index <> Nothing Then
                temp = item.index + " " + item.modCode + " " + item.mark.ToString() + " " + item.attndnce.ToString() + " " + item.grade
                sw.WriteLine(temp)

            End If
        Next

        sw.Close()

    End Sub

    Private Sub btnNewStudent_Click(sender As Object, e As EventArgs) Handles btnNewStudent.Click

        Array.Clear(gradeArray, 0, gradeArray.Length)

    End Sub
End Class
