<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmbRing1 = New System.Windows.Forms.ComboBox()
        Me.lblring1 = New System.Windows.Forms.Label()
        Me.lblring2 = New System.Windows.Forms.Label()
        Me.cmbRing2 = New System.Windows.Forms.ComboBox()
        Me.lblRing3 = New System.Windows.Forms.Label()
        Me.cmbRing3 = New System.Windows.Forms.ComboBox()
        Me.lblRing4 = New System.Windows.Forms.Label()
        Me.cmbRing4 = New System.Windows.Forms.ComboBox()
        Me.chkRing5 = New System.Windows.Forms.CheckBox()
        Me.lblRing5 = New System.Windows.Forms.Label()
        Me.cmbRing5 = New System.Windows.Forms.ComboBox()
        Me.btnCalcClr = New System.Windows.Forms.Button()
        Me.lblResultString = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTol = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbRing1
        '
        Me.cmbRing1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbRing1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRing1.FormattingEnabled = True
        Me.cmbRing1.Location = New System.Drawing.Point(54, 34)
        Me.cmbRing1.Name = "cmbRing1"
        Me.cmbRing1.Size = New System.Drawing.Size(81, 21)
        Me.cmbRing1.TabIndex = 0
        '
        'lblring1
        '
        Me.lblring1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblring1.AutoSize = True
        Me.lblring1.Location = New System.Drawing.Point(12, 42)
        Me.lblring1.Name = "lblring1"
        Me.lblring1.Size = New System.Drawing.Size(36, 13)
        Me.lblring1.TabIndex = 1
        Me.lblring1.Text = "1. ring"
        '
        'lblring2
        '
        Me.lblring2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblring2.AutoSize = True
        Me.lblring2.Location = New System.Drawing.Point(12, 81)
        Me.lblring2.MinimumSize = New System.Drawing.Size(36, 13)
        Me.lblring2.Name = "lblring2"
        Me.lblring2.Size = New System.Drawing.Size(36, 13)
        Me.lblring2.TabIndex = 2
        Me.lblring2.Text = "2. ring"
        '
        'cmbRing2
        '
        Me.cmbRing2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbRing2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRing2.FormattingEnabled = True
        Me.cmbRing2.Location = New System.Drawing.Point(54, 73)
        Me.cmbRing2.Name = "cmbRing2"
        Me.cmbRing2.Size = New System.Drawing.Size(81, 21)
        Me.cmbRing2.TabIndex = 3
        '
        'lblRing3
        '
        Me.lblRing3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRing3.AutoSize = True
        Me.lblRing3.Location = New System.Drawing.Point(12, 117)
        Me.lblRing3.Name = "lblRing3"
        Me.lblRing3.Size = New System.Drawing.Size(36, 13)
        Me.lblRing3.TabIndex = 4
        Me.lblRing3.Text = "3. ring"
        '
        'cmbRing3
        '
        Me.cmbRing3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbRing3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRing3.FormattingEnabled = True
        Me.cmbRing3.Location = New System.Drawing.Point(54, 109)
        Me.cmbRing3.Name = "cmbRing3"
        Me.cmbRing3.Size = New System.Drawing.Size(81, 21)
        Me.cmbRing3.TabIndex = 5
        '
        'lblRing4
        '
        Me.lblRing4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRing4.AutoSize = True
        Me.lblRing4.Location = New System.Drawing.Point(164, 42)
        Me.lblRing4.Name = "lblRing4"
        Me.lblRing4.Size = New System.Drawing.Size(36, 13)
        Me.lblRing4.TabIndex = 6
        Me.lblRing4.Text = "4. ring"
        '
        'cmbRing4
        '
        Me.cmbRing4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRing4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRing4.FormattingEnabled = True
        Me.cmbRing4.Location = New System.Drawing.Point(206, 34)
        Me.cmbRing4.Name = "cmbRing4"
        Me.cmbRing4.Size = New System.Drawing.Size(81, 21)
        Me.cmbRing4.TabIndex = 7
        '
        'chkRing5
        '
        Me.chkRing5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkRing5.AutoSize = True
        Me.chkRing5.Location = New System.Drawing.Point(167, 86)
        Me.chkRing5.Name = "chkRing5"
        Me.chkRing5.Size = New System.Drawing.Size(57, 17)
        Me.chkRing5.TabIndex = 8
        Me.chkRing5.Text = "5 rings"
        Me.chkRing5.UseVisualStyleBackColor = True
        '
        'lblRing5
        '
        Me.lblRing5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRing5.AutoSize = True
        Me.lblRing5.Location = New System.Drawing.Point(164, 117)
        Me.lblRing5.Name = "lblRing5"
        Me.lblRing5.Size = New System.Drawing.Size(36, 13)
        Me.lblRing5.TabIndex = 9
        Me.lblRing5.Text = "5. ring"
        '
        'cmbRing5
        '
        Me.cmbRing5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRing5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRing5.FormattingEnabled = True
        Me.cmbRing5.Location = New System.Drawing.Point(206, 109)
        Me.cmbRing5.Name = "cmbRing5"
        Me.cmbRing5.Size = New System.Drawing.Size(81, 21)
        Me.cmbRing5.TabIndex = 10
        '
        'btnCalcClr
        '
        Me.btnCalcClr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcClr.Location = New System.Drawing.Point(212, 236)
        Me.btnCalcClr.Name = "btnCalcClr"
        Me.btnCalcClr.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcClr.TabIndex = 11
        Me.btnCalcClr.Text = "Calculate"
        Me.btnCalcClr.UseVisualStyleBackColor = True
        '
        'lblResultString
        '
        Me.lblResultString.AutoSize = True
        Me.lblResultString.Location = New System.Drawing.Point(13, 162)
        Me.lblResultString.Name = "lblResultString"
        Me.lblResultString.Size = New System.Drawing.Size(85, 13)
        Me.lblResultString.TabIndex = 12
        Me.lblResultString.Text = "Your resistor has"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtResult.Location = New System.Drawing.Point(123, 162)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(164, 20)
        Me.txtResult.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "with a tolerance of"
        '
        'txtTol
        '
        Me.txtTol.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtTol.Location = New System.Drawing.Point(123, 190)
        Me.txtTol.Name = "txtTol"
        Me.txtTol.ReadOnly = True
        Me.txtTol.Size = New System.Drawing.Size(164, 20)
        Me.txtTol.TabIndex = 15
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 274)
        Me.Controls.Add(Me.txtTol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblResultString)
        Me.Controls.Add(Me.btnCalcClr)
        Me.Controls.Add(Me.cmbRing5)
        Me.Controls.Add(Me.lblRing5)
        Me.Controls.Add(Me.chkRing5)
        Me.Controls.Add(Me.cmbRing4)
        Me.Controls.Add(Me.lblRing4)
        Me.Controls.Add(Me.cmbRing3)
        Me.Controls.Add(Me.lblRing3)
        Me.Controls.Add(Me.cmbRing2)
        Me.Controls.Add(Me.lblring2)
        Me.Controls.Add(Me.lblring1)
        Me.Controls.Add(Me.cmbRing1)
        Me.MinimumSize = New System.Drawing.Size(321, 274)
        Me.Name = "frmMain"
        Me.Text = "Resistor Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbRing1 As ComboBox
    Friend WithEvents lblring1 As Label
    Friend WithEvents lblring2 As Label
    Friend WithEvents cmbRing2 As ComboBox
    Friend WithEvents lblRing3 As Label
    Friend WithEvents cmbRing3 As ComboBox
    Friend WithEvents lblRing4 As Label
    Friend WithEvents cmbRing4 As ComboBox
    Friend WithEvents chkRing5 As CheckBox
    Friend WithEvents lblRing5 As Label
    Friend WithEvents cmbRing5 As ComboBox
    Friend WithEvents btnCalcClr As Button
    Friend WithEvents lblResultString As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTol As TextBox
End Class
