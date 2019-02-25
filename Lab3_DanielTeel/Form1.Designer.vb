<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdOld = New System.Windows.Forms.RadioButton()
        Me.rdYoung = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtInputWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.grpMale = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblForearmsM = New System.Windows.Forms.Label()
        Me.lblHipsM = New System.Windows.Forms.Label()
        Me.txtHipsM = New System.Windows.Forms.TextBox()
        Me.txtForearmsM = New System.Windows.Forms.TextBox()
        Me.txtWristM = New System.Windows.Forms.TextBox()
        Me.lblWaistM = New System.Windows.Forms.Label()
        Me.txtWaistM = New System.Windows.Forms.TextBox()
        Me.grpFemale = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtThighF = New System.Windows.Forms.TextBox()
        Me.txtCalfF = New System.Windows.Forms.TextBox()
        Me.txtWristF = New System.Windows.Forms.TextBox()
        Me.txtHipsF = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpMale.SuspendLayout()
        Me.grpFemale.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdFemale)
        Me.GroupBox1.Controls.Add(Me.rdMale)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender:"
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Location = New System.Drawing.Point(161, 37)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(147, 36)
        Me.rdFemale.TabIndex = 1
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Checked = True
        Me.rdMale.Location = New System.Drawing.Point(6, 37)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(114, 36)
        Me.rdMale.TabIndex = 1
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdOld)
        Me.GroupBox2.Controls.Add(Me.rdYoung)
        Me.GroupBox2.Location = New System.Drawing.Point(435, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 130)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Age:"
        '
        'rdOld
        '
        Me.rdOld.AutoSize = True
        Me.rdOld.Location = New System.Drawing.Point(270, 37)
        Me.rdOld.Name = "rdOld"
        Me.rdOld.Size = New System.Drawing.Size(168, 36)
        Me.rdOld.TabIndex = 1
        Me.rdOld.TabStop = True
        Me.rdOld.Text = "Under 30"
        Me.rdOld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdOld.UseVisualStyleBackColor = True
        '
        'rdYoung
        '
        Me.rdYoung.AutoSize = True
        Me.rdYoung.Checked = True
        Me.rdYoung.Location = New System.Drawing.Point(6, 37)
        Me.rdYoung.Name = "rdYoung"
        Me.rdYoung.Size = New System.Drawing.Size(223, 36)
        Me.rdYoung.TabIndex = 1
        Me.rdYoung.TabStop = True
        Me.rdYoung.Text = "30 and Under"
        Me.rdYoung.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtInputWeight)
        Me.GroupBox3.Controls.Add(Me.lblWeight)
        Me.GroupBox3.Location = New System.Drawing.Point(1001, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(497, 130)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Weight:"
        '
        'txtInputWeight
        '
        Me.txtInputWeight.Location = New System.Drawing.Point(6, 37)
        Me.txtInputWeight.Multiline = True
        Me.txtInputWeight.Name = "txtInputWeight"
        Me.txtInputWeight.Size = New System.Drawing.Size(134, 59)
        Me.txtInputWeight.TabIndex = 9
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(146, 41)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(112, 32)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Pounds"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(69, 763)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(180, 72)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(69, 953)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(180, 72)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(69, 858)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(180, 72)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblOutput)
        Me.GroupBox4.Location = New System.Drawing.Point(354, 763)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1043, 262)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Results:"
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(0, 34)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(1043, 225)
        Me.lblOutput.TabIndex = 0
        '
        'grpMale
        '
        Me.grpMale.Controls.Add(Me.Label1)
        Me.grpMale.Controls.Add(Me.lblForearmsM)
        Me.grpMale.Controls.Add(Me.lblHipsM)
        Me.grpMale.Controls.Add(Me.txtHipsM)
        Me.grpMale.Controls.Add(Me.txtForearmsM)
        Me.grpMale.Controls.Add(Me.txtWristM)
        Me.grpMale.Controls.Add(Me.lblWaistM)
        Me.grpMale.Controls.Add(Me.txtWaistM)
        Me.grpMale.Location = New System.Drawing.Point(22, 171)
        Me.grpMale.Name = "grpMale"
        Me.grpMale.Size = New System.Drawing.Size(1338, 493)
        Me.grpMale.TabIndex = 7
        Me.grpMale.TabStop = False
        Me.grpMale.Text = "Measurements in Inches (Male):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(842, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "WRIST: Measure just above bony protuberance towards the hand."
        '
        'lblForearmsM
        '
        Me.lblForearmsM.AutoSize = True
        Me.lblForearmsM.Location = New System.Drawing.Point(307, 231)
        Me.lblForearmsM.Name = "lblForearmsM"
        Me.lblForearmsM.Size = New System.Drawing.Size(897, 32)
        Me.lblForearmsM.TabIndex = 19
        Me.lblForearmsM.Text = "FOREARM: Clench fist; measure widest part between wrist and elbow."
        '
        'lblHipsM
        '
        Me.lblHipsM.AutoSize = True
        Me.lblHipsM.Location = New System.Drawing.Point(307, 141)
        Me.lblHipsM.Name = "lblHipsM"
        Me.lblHipsM.Size = New System.Drawing.Size(1031, 32)
        Me.lblHipsM.TabIndex = 18
        Me.lblHipsM.Text = "HIPS: Feet 4 inches apart; measure greatest circumference around hips and butt."
        '
        'txtHipsM
        '
        Me.txtHipsM.Location = New System.Drawing.Point(41, 138)
        Me.txtHipsM.Multiline = True
        Me.txtHipsM.Name = "txtHipsM"
        Me.txtHipsM.Size = New System.Drawing.Size(203, 66)
        Me.txtHipsM.TabIndex = 16
        '
        'txtForearmsM
        '
        Me.txtForearmsM.Location = New System.Drawing.Point(41, 228)
        Me.txtForearmsM.Multiline = True
        Me.txtForearmsM.Name = "txtForearmsM"
        Me.txtForearmsM.Size = New System.Drawing.Size(203, 66)
        Me.txtForearmsM.TabIndex = 15
        '
        'txtWristM
        '
        Me.txtWristM.Location = New System.Drawing.Point(41, 323)
        Me.txtWristM.Multiline = True
        Me.txtWristM.Name = "txtWristM"
        Me.txtWristM.Size = New System.Drawing.Size(203, 66)
        Me.txtWristM.TabIndex = 14
        '
        'lblWaistM
        '
        Me.lblWaistM.AutoSize = True
        Me.lblWaistM.Location = New System.Drawing.Point(307, 55)
        Me.lblWaistM.Name = "lblWaistM"
        Me.lblWaistM.Size = New System.Drawing.Size(882, 32)
        Me.lblWaistM.TabIndex = 9
        Me.lblWaistM.Text = "WAIST: Measure at greatest circumference; relaxed and comfortable."
        '
        'txtWaistM
        '
        Me.txtWaistM.Location = New System.Drawing.Point(41, 52)
        Me.txtWaistM.Multiline = True
        Me.txtWaistM.Name = "txtWaistM"
        Me.txtWaistM.Size = New System.Drawing.Size(203, 66)
        Me.txtWaistM.TabIndex = 8
        '
        'grpFemale
        '
        Me.grpFemale.Controls.Add(Me.Label4)
        Me.grpFemale.Controls.Add(Me.Label6)
        Me.grpFemale.Controls.Add(Me.Label5)
        Me.grpFemale.Controls.Add(Me.Label7)
        Me.grpFemale.Controls.Add(Me.txtThighF)
        Me.grpFemale.Controls.Add(Me.txtCalfF)
        Me.grpFemale.Controls.Add(Me.txtWristF)
        Me.grpFemale.Controls.Add(Me.txtHipsF)
        Me.grpFemale.Location = New System.Drawing.Point(22, 171)
        Me.grpFemale.Name = "grpFemale"
        Me.grpFemale.Size = New System.Drawing.Size(1369, 493)
        Me.grpFemale.TabIndex = 8
        Me.grpFemale.TabStop = False
        Me.grpFemale.Text = "Measurements in Inches (Female):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(842, 32)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "WRIST: Measure just above bony protuberance towards the hand."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1031, 32)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "HIPS: Feet 4 inches apart; measure greatest circumference around hips and butt."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1060, 32)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "CALF: Stand with weight on both feet, widest part midway between knee and ankle."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(288, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(963, 32)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "THIGH: Stand with feet 12 inches apart: measure widest part of upper thigh."
        '
        'txtThighF
        '
        Me.txtThighF.Location = New System.Drawing.Point(41, 138)
        Me.txtThighF.Multiline = True
        Me.txtThighF.Name = "txtThighF"
        Me.txtThighF.Size = New System.Drawing.Size(203, 66)
        Me.txtThighF.TabIndex = 12
        '
        'txtCalfF
        '
        Me.txtCalfF.Location = New System.Drawing.Point(41, 231)
        Me.txtCalfF.Multiline = True
        Me.txtCalfF.Name = "txtCalfF"
        Me.txtCalfF.Size = New System.Drawing.Size(203, 66)
        Me.txtCalfF.TabIndex = 11
        '
        'txtWristF
        '
        Me.txtWristF.Location = New System.Drawing.Point(41, 323)
        Me.txtWristF.Multiline = True
        Me.txtWristF.Name = "txtWristF"
        Me.txtWristF.Size = New System.Drawing.Size(203, 66)
        Me.txtWristF.TabIndex = 10
        '
        'txtHipsF
        '
        Me.txtHipsF.Location = New System.Drawing.Point(41, 55)
        Me.txtHipsF.Multiline = True
        Me.txtHipsF.Name = "txtHipsF"
        Me.txtHipsF.Size = New System.Drawing.Size(203, 66)
        Me.txtHipsF.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1516, 1063)
        Me.Controls.Add(Me.grpFemale)
        Me.Controls.Add(Me.grpMale)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.grpMale.ResumeLayout(False)
        Me.grpMale.PerformLayout()
        Me.grpFemale.ResumeLayout(False)
        Me.grpFemale.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdOld As RadioButton
    Friend WithEvents rdYoung As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents grpMale As GroupBox
    Friend WithEvents grpFemale As GroupBox
    Friend WithEvents txtWaistM As TextBox
    Friend WithEvents lblWaistM As Label
    Friend WithEvents lblHipsM As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHipsM As TextBox
    Friend WithEvents txtForearmsM As TextBox
    Friend WithEvents txtWristM As TextBox
    Friend WithEvents txtHipsF As TextBox
    Friend WithEvents txtThighF As TextBox
    Friend WithEvents txtCalfF As TextBox
    Friend WithEvents txtWristF As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblForearmsM As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInputWeight As TextBox
End Class
