Public Class Form1
    'Lab 3
    '2015 Fall Semester
    'Daniel Teel
    'I fully understand the following statement. 
    'OU PLAGIARISM POLICY 
    'All members of the academic community at Oakland are expected to practice and uphold ‘standards of academic integrity and honesty. An instructor is expected to inform and instruct ‘students about the procedures and standards of research and documentation required of students ‘in fulfilling course work. A student is expected to follow such instructions and be sure the rules ‘and procedures are understood in order to avoid inadvertent misrepresentation of his work. ‘Students must assume that individual (unaided) work on exams and lab reports and documentation ‘of sources is expected unless the instructor specifically says that is not necessary. 
    'The following definitions are some examples of academic dishonesty: 
    'Plagiarizing from work of others. Plagiarism is using someone else's work or ideas without ‘giving the other person credit; by doing this, a student is, in effect, claiming credit for ‘someone else's thinking. Whether the student has read or heard the information he uses, ‘the student must document the source of information. When dealing with written sources, ‘a clear distinction would be made between quotations (which reproduce information from ‘the source word-for-word within quotation marks) and paraphrases (which digest the ‘source information and produce it in the student's own words). Both direct quotations and ‘paraphrases must be documented. Just because a student rephrases, condenses or selects ‘from another person's work, the ideas are still the other person's, and failure to give ‘credit constitutes misrepresentation of the student's actual work and plagiarism of ‘another's ideas. Naturally, buying a paper and handing it in as one's own work is ‘plagiarism. 
    'Cheating on lab reports falsifying data or submitting data not based on student's own work.

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub grpMale_Enter(sender As Object, e As EventArgs) Handles grpMale.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtWaistM_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdMale.CheckedChanged
        If rdMale.Checked Then
            grpFemale.Visible = False
            grpMale.Visible = True

        End If
    End Sub

    Private Sub rdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdFemale.CheckedChanged
        If rdFemale.Checked Then
            grpFemale.Visible = True
            grpMale.Visible = False

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        rdMale.Checked = True
        rdFemale.Checked = False
        rdYoung.Checked = True
        rdOld.Checked = False

        txtInputWeight.Text = ""
        txtWaistM.Text = ""
        txtHipsM.Text = ""
        txtForearmsM.Text = ""
        txtWristM.Text = ""

        txtHipsF.Text = ""
        txtCalfF.Text = ""
        txtThighF.Text = ""
        txtWristF.Text = ""

        lblOutput.Text = ""
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim leanbw As Double
        Dim fatmass As Double
        Dim perbf As Double
        Dim idealweight As Double
        Dim weight As Double

        Dim male_wrist As Double
        Dim male_forearm As Double
        Dim male_hips As Double
        Dim male_waist As Double

        Dim female_hips As Double
        Dim female_thigh As Double
        Dim female_calf As Double
        Dim female_wrist As Double

        male_wrist = Val(txtWristM.Text)
        male_forearm = Val(txtForearmsM.Text)
        male_hips = Val(txtHipsM.Text)
        male_waist = Val(txtWaistM.Text)

        female_hips = Val(txtHipsF.Text)
        female_thigh = Val(txtThighF.Text)
        female_calf = Val(txtCalfF.Text)
        female_wrist = Val(txtWristF.Text)

        leanbw.ToString("p")
        fatmass.ToString("p")
        perbf.ToString("p")
        idealweight.ToString("p")
        weight = Val(txtInputWeight.Text)
        Try

            If rdMale.Checked And rdOld.Checked Then
                perbf = male_waist + ((1 / 2) * male_hips) - (3 * male_forearm) - male_wrist
                fatmass = perbf * (weight / 100)
                leanbw = weight - fatmass
                idealweight = leanbw / (0.85)
            End If

            If rdMale.Checked And rdYoung.Checked Then
                perbf = male_waist + ((1 / 2) * male_hips) - (2.7 * male_forearm) - male_wrist
                fatmass = perbf * (weight / 100)
                leanbw = weight - fatmass
                idealweight = leanbw / (0.85)
            End If

            If rdFemale.Checked And rdOld.Checked Then
                perbf = female_hips + ((0.8) * female_thigh) - (2 * female_calf) - female_wrist
                fatmass = perbf * (weight / 100)
                leanbw = weight - fatmass
                idealweight = leanbw / (0.78)
            End If

            If rdFemale.Checked And rdYoung.Checked Then
                perbf = female_hips + female_thigh - (2 * female_calf) - female_wrist
                fatmass = perbf * (weight / 100)
                leanbw = weight - fatmass
                idealweight = leanbw / (0.78)
            End If

            If rdMale.Checked Then
                lblOutput.Text = "You have about " & Val(leanbw) & " pounds of lean bodyweight with " & Val(fatmass) & " pounds of fat at " & Val(perbf) & "% bodyfat. You should weigh no more than " & Val(idealweight) & " pounds(15%)."
            End If

            If rdFemale.Checked Then
                lblOutput.Text = "You have about " & Val(leanbw) & " pounds of lean bodyweight with " & Val(fatmass) & " pounds of fat at " & Val(perbf) & "% bodyfat. You should weigh no more than " & Val(idealweight) & " pounds(22%)."
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter a numerical value.")
        End Try
    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblForearmsM.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtCalfF_TextChanged(sender As Object, e As EventArgs) Handles txtCalfF.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtInputWeight_TextChanged(sender As Object, e As EventArgs) Handles txtInputWeight.TextChanged

    End Sub
End Class
