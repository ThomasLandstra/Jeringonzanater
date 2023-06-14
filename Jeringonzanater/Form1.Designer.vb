<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tpgModule1 = New System.Windows.Forms.TabPage()
        Me.btnMod1Convert = New System.Windows.Forms.Button()
        Me.rbtnMod1Unjeri = New System.Windows.Forms.RadioButton()
        Me.rbtnMod1Jeri = New System.Windows.Forms.RadioButton()
        Me.tbxMod1Input = New System.Windows.Forms.TextBox()
        Me.tpgModule2 = New System.Windows.Forms.TabPage()
        Me.btnMod2Check = New System.Windows.Forms.Button()
        Me.tbxMod2Input = New System.Windows.Forms.TextBox()
        Me.tpgModule3 = New System.Windows.Forms.TabPage()
        Me.btnMod3Verify = New System.Windows.Forms.Button()
        Me.tbxMod3Input = New System.Windows.Forms.TextBox()
        Me.tpgModule4 = New System.Windows.Forms.TabPage()
        Me.btnMod4Convert = New System.Windows.Forms.Button()
        Me.tbxMod4Input = New System.Windows.Forms.TextBox()
        Me.tabControl.SuspendLayout()
        Me.tpgModule1.SuspendLayout()
        Me.tpgModule2.SuspendLayout()
        Me.tpgModule3.SuspendLayout()
        Me.tpgModule4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Snap ITC", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(322, 50)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Jeringonzanater"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tpgModule1)
        Me.tabControl.Controls.Add(Me.tpgModule2)
        Me.tabControl.Controls.Add(Me.tpgModule3)
        Me.tabControl.Controls.Add(Me.tpgModule4)
        Me.tabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(10, 60)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(322, 443)
        Me.tabControl.TabIndex = 1
        '
        'tpgModule1
        '
        Me.tpgModule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpgModule1.Controls.Add(Me.btnMod1Convert)
        Me.tpgModule1.Controls.Add(Me.rbtnMod1Unjeri)
        Me.tpgModule1.Controls.Add(Me.rbtnMod1Jeri)
        Me.tpgModule1.Controls.Add(Me.tbxMod1Input)
        Me.tpgModule1.Location = New System.Drawing.Point(4, 27)
        Me.tpgModule1.Margin = New System.Windows.Forms.Padding(2)
        Me.tpgModule1.Name = "tpgModule1"
        Me.tpgModule1.Padding = New System.Windows.Forms.Padding(2)
        Me.tpgModule1.Size = New System.Drawing.Size(314, 412)
        Me.tpgModule1.TabIndex = 0
        Me.tpgModule1.Text = "Module 1"
        Me.tpgModule1.UseVisualStyleBackColor = True
        '
        'btnMod1Convert
        '
        Me.btnMod1Convert.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod1Convert.Location = New System.Drawing.Point(97, 358)
        Me.btnMod1Convert.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMod1Convert.Name = "btnMod1Convert"
        Me.btnMod1Convert.Size = New System.Drawing.Size(120, 49)
        Me.btnMod1Convert.TabIndex = 5
        Me.btnMod1Convert.Text = "Convert"
        Me.btnMod1Convert.UseVisualStyleBackColor = True
        '
        'rbtnMod1Unjeri
        '
        Me.rbtnMod1Unjeri.AutoSize = True
        Me.rbtnMod1Unjeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMod1Unjeri.Location = New System.Drawing.Point(39, 316)
        Me.rbtnMod1Unjeri.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnMod1Unjeri.Name = "rbtnMod1Unjeri"
        Me.rbtnMod1Unjeri.Size = New System.Drawing.Size(200, 30)
        Me.rbtnMod1Unjeri.TabIndex = 2
        Me.rbtnMod1Unjeri.Text = "Unjeringonzanate"
        Me.rbtnMod1Unjeri.UseVisualStyleBackColor = True
        '
        'rbtnMod1Jeri
        '
        Me.rbtnMod1Jeri.AutoSize = True
        Me.rbtnMod1Jeri.Checked = True
        Me.rbtnMod1Jeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMod1Jeri.Location = New System.Drawing.Point(39, 282)
        Me.rbtnMod1Jeri.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnMod1Jeri.Name = "rbtnMod1Jeri"
        Me.rbtnMod1Jeri.Size = New System.Drawing.Size(178, 30)
        Me.rbtnMod1Jeri.TabIndex = 1
        Me.rbtnMod1Jeri.TabStop = True
        Me.rbtnMod1Jeri.Text = "Jeringonzanate"
        Me.rbtnMod1Jeri.UseVisualStyleBackColor = True
        '
        'tbxMod1Input
        '
        Me.tbxMod1Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxMod1Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMod1Input.Location = New System.Drawing.Point(20, 20)
        Me.tbxMod1Input.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbxMod1Input.Multiline = True
        Me.tbxMod1Input.Name = "tbxMod1Input"
        Me.tbxMod1Input.Size = New System.Drawing.Size(274, 258)
        Me.tbxMod1Input.TabIndex = 0
        '
        'tpgModule2
        '
        Me.tpgModule2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpgModule2.Controls.Add(Me.btnMod2Check)
        Me.tpgModule2.Controls.Add(Me.tbxMod2Input)
        Me.tpgModule2.Location = New System.Drawing.Point(4, 27)
        Me.tpgModule2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpgModule2.Name = "tpgModule2"
        Me.tpgModule2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpgModule2.Size = New System.Drawing.Size(314, 412)
        Me.tpgModule2.TabIndex = 1
        Me.tpgModule2.Text = "Module 2"
        Me.tpgModule2.UseVisualStyleBackColor = True
        '
        'btnMod2Check
        '
        Me.btnMod2Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod2Check.Location = New System.Drawing.Point(97, 223)
        Me.btnMod2Check.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMod2Check.Name = "btnMod2Check"
        Me.btnMod2Check.Size = New System.Drawing.Size(120, 49)
        Me.btnMod2Check.TabIndex = 4
        Me.btnMod2Check.Text = "Check"
        Me.btnMod2Check.UseVisualStyleBackColor = True
        '
        'tbxMod2Input
        '
        Me.tbxMod2Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxMod2Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMod2Input.Location = New System.Drawing.Point(20, 81)
        Me.tbxMod2Input.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbxMod2Input.Name = "tbxMod2Input"
        Me.tbxMod2Input.Size = New System.Drawing.Size(274, 38)
        Me.tbxMod2Input.TabIndex = 0
        '
        'tpgModule3
        '
        Me.tpgModule3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpgModule3.Controls.Add(Me.btnMod3Verify)
        Me.tpgModule3.Controls.Add(Me.tbxMod3Input)
        Me.tpgModule3.Location = New System.Drawing.Point(4, 27)
        Me.tpgModule3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpgModule3.Name = "tpgModule3"
        Me.tpgModule3.Size = New System.Drawing.Size(314, 412)
        Me.tpgModule3.TabIndex = 2
        Me.tpgModule3.Text = "Module 3"
        Me.tpgModule3.UseVisualStyleBackColor = True
        '
        'btnMod3Verify
        '
        Me.btnMod3Verify.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod3Verify.Location = New System.Drawing.Point(89, 323)
        Me.btnMod3Verify.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMod3Verify.Name = "btnMod3Verify"
        Me.btnMod3Verify.Size = New System.Drawing.Size(136, 65)
        Me.btnMod3Verify.TabIndex = 5
        Me.btnMod3Verify.Text = "Verify Candidacy"
        Me.btnMod3Verify.UseVisualStyleBackColor = True
        '
        'tbxMod3Input
        '
        Me.tbxMod3Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxMod3Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMod3Input.Location = New System.Drawing.Point(20, 20)
        Me.tbxMod3Input.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbxMod3Input.Multiline = True
        Me.tbxMod3Input.Name = "tbxMod3Input"
        Me.tbxMod3Input.Size = New System.Drawing.Size(274, 298)
        Me.tbxMod3Input.TabIndex = 4
        '
        'tpgModule4
        '
        Me.tpgModule4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpgModule4.Controls.Add(Me.btnMod4Convert)
        Me.tpgModule4.Controls.Add(Me.tbxMod4Input)
        Me.tpgModule4.Location = New System.Drawing.Point(4, 27)
        Me.tpgModule4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpgModule4.Name = "tpgModule4"
        Me.tpgModule4.Size = New System.Drawing.Size(314, 412)
        Me.tpgModule4.TabIndex = 3
        Me.tpgModule4.Text = "Module 4"
        Me.tpgModule4.UseVisualStyleBackColor = True
        '
        'btnMod4Convert
        '
        Me.btnMod4Convert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod4Convert.Location = New System.Drawing.Point(89, 323)
        Me.btnMod4Convert.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMod4Convert.Name = "btnMod4Convert"
        Me.btnMod4Convert.Size = New System.Drawing.Size(136, 47)
        Me.btnMod4Convert.TabIndex = 7
        Me.btnMod4Convert.Text = "Convert"
        Me.btnMod4Convert.UseVisualStyleBackColor = True
        '
        'tbxMod4Input
        '
        Me.tbxMod4Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxMod4Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMod4Input.Location = New System.Drawing.Point(20, 20)
        Me.tbxMod4Input.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbxMod4Input.Multiline = True
        Me.tbxMod4Input.Name = "tbxMod4Input"
        Me.tbxMod4Input.Size = New System.Drawing.Size(274, 298)
        Me.tbxMod4Input.TabIndex = 6
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 513)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "formMain"
        Me.Text = "Jeringonzanater"
        Me.tabControl.ResumeLayout(False)
        Me.tpgModule1.ResumeLayout(False)
        Me.tpgModule1.PerformLayout()
        Me.tpgModule2.ResumeLayout(False)
        Me.tpgModule2.PerformLayout()
        Me.tpgModule3.ResumeLayout(False)
        Me.tpgModule3.PerformLayout()
        Me.tpgModule4.ResumeLayout(False)
        Me.tpgModule4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tpgModule1 As TabPage
    Friend WithEvents tpgModule2 As TabPage
    Friend WithEvents tpgModule3 As TabPage
    Friend WithEvents tpgModule4 As TabPage
    Friend WithEvents tbxMod1Input As TextBox
    Friend WithEvents rbtnMod1Unjeri As RadioButton
    Friend WithEvents rbtnMod1Jeri As RadioButton
    Friend WithEvents btnMod2Check As Button
    Friend WithEvents tbxMod2Input As TextBox
    Friend WithEvents btnMod1Convert As Button
    Friend WithEvents btnMod3Verify As Button
    Friend WithEvents tbxMod3Input As TextBox
    Friend WithEvents btnMod4Convert As Button
    Friend WithEvents tbxMod4Input As TextBox
End Class
