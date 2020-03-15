<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatternPreview
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatternPreview))
		Me.btnGenerate = New System.Windows.Forms.Button()
		Me.tbxMainCharacterStart = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.tbxSubCharacterStart = New System.Windows.Forms.TextBox()
		Me.tbxSubCharacterEnd = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.numReapaetWidth = New System.Windows.Forms.NumericUpDown()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.numRepeatRow = New System.Windows.Forms.NumericUpDown()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.pnlSequenceConfig = New System.Windows.Forms.Panel()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.tbxMainCharacterEnd = New System.Windows.Forms.TextBox()
		Me.tbxPattern = New System.Windows.Forms.TextBox()
		Me.rdbPattern = New System.Windows.Forms.RadioButton()
		Me.rdbSequence = New System.Windows.Forms.RadioButton()
		Me.lblProgressStatus = New System.Windows.Forms.Label()
		Me.btnTest = New System.Windows.Forms.Button()
		CType(Me.numReapaetWidth, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numRepeatRow, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.pnlSequenceConfig.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnGenerate
		'
		Me.btnGenerate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnGenerate.Location = New System.Drawing.Point(196, 250)
		Me.btnGenerate.Name = "btnGenerate"
		Me.btnGenerate.Size = New System.Drawing.Size(107, 25)
		Me.btnGenerate.TabIndex = 0
		Me.btnGenerate.Text = "Generate"
		Me.btnGenerate.UseVisualStyleBackColor = True
		'
		'tbxMainCharacterStart
		'
		Me.tbxMainCharacterStart.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxMainCharacterStart.Location = New System.Drawing.Point(106, 4)
		Me.tbxMainCharacterStart.Name = "tbxMainCharacterStart"
		Me.tbxMainCharacterStart.Size = New System.Drawing.Size(43, 23)
		Me.tbxMainCharacterStart.TabIndex = 1
		Me.tbxMainCharacterStart.Text = "A"
		Me.tbxMainCharacterStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(10, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(95, 14)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Main Character :"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(18, 37)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(87, 14)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Sub Character :"
		'
		'tbxSubCharacterStart
		'
		Me.tbxSubCharacterStart.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxSubCharacterStart.Location = New System.Drawing.Point(106, 33)
		Me.tbxSubCharacterStart.Name = "tbxSubCharacterStart"
		Me.tbxSubCharacterStart.Size = New System.Drawing.Size(43, 23)
		Me.tbxSubCharacterStart.TabIndex = 4
		Me.tbxSubCharacterStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tbxSubCharacterEnd
		'
		Me.tbxSubCharacterEnd.Enabled = False
		Me.tbxSubCharacterEnd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxSubCharacterEnd.Location = New System.Drawing.Point(177, 33)
		Me.tbxSubCharacterEnd.Name = "tbxSubCharacterEnd"
		Me.tbxSubCharacterEnd.Size = New System.Drawing.Size(43, 23)
		Me.tbxSubCharacterEnd.TabIndex = 5
		Me.tbxSubCharacterEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(154, 37)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(18, 14)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "to"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(66, 171)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(52, 14)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Repeat :"
		'
		'numReapaetWidth
		'
		Me.numReapaetWidth.Location = New System.Drawing.Point(119, 169)
		Me.numReapaetWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numReapaetWidth.Name = "numReapaetWidth"
		Me.numReapaetWidth.Size = New System.Drawing.Size(43, 22)
		Me.numReapaetWidth.TabIndex = 8
		Me.numReapaetWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numReapaetWidth.Value = New Decimal(New Integer() {15, 0, 0, 0})
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(167, 171)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(41, 14)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "row(s)"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(167, 199)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(61, 14)
		Me.Label6.TabIndex = 12
		Me.Label6.Text = "column(s)"
		'
		'numRepeatRow
		'
		Me.numRepeatRow.Location = New System.Drawing.Point(119, 197)
		Me.numRepeatRow.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numRepeatRow.Name = "numRepeatRow"
		Me.numRepeatRow.Size = New System.Drawing.Size(43, 22)
		Me.numRepeatRow.TabIndex = 11
		Me.numRepeatRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numRepeatRow.Value = New Decimal(New Integer() {20, 0, 0, 0})
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
		Me.Panel1.Controls.Add(Me.pnlSequenceConfig)
		Me.Panel1.Controls.Add(Me.tbxPattern)
		Me.Panel1.Controls.Add(Me.rdbPattern)
		Me.Panel1.Controls.Add(Me.rdbSequence)
		Me.Panel1.Controls.Add(Me.Label6)
		Me.Panel1.Controls.Add(Me.numRepeatRow)
		Me.Panel1.Controls.Add(Me.Label5)
		Me.Panel1.Controls.Add(Me.numReapaetWidth)
		Me.Panel1.Controls.Add(Me.Label4)
		Me.Panel1.Location = New System.Drawing.Point(12, 12)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(291, 232)
		Me.Panel1.TabIndex = 13
		'
		'pnlSequenceConfig
		'
		Me.pnlSequenceConfig.Controls.Add(Me.tbxSubCharacterEnd)
		Me.pnlSequenceConfig.Controls.Add(Me.Label3)
		Me.pnlSequenceConfig.Controls.Add(Me.tbxSubCharacterStart)
		Me.pnlSequenceConfig.Controls.Add(Me.Label8)
		Me.pnlSequenceConfig.Controls.Add(Me.Label2)
		Me.pnlSequenceConfig.Controls.Add(Me.tbxMainCharacterEnd)
		Me.pnlSequenceConfig.Controls.Add(Me.Label1)
		Me.pnlSequenceConfig.Controls.Add(Me.tbxMainCharacterStart)
		Me.pnlSequenceConfig.Location = New System.Drawing.Point(13, 30)
		Me.pnlSequenceConfig.Name = "pnlSequenceConfig"
		Me.pnlSequenceConfig.Size = New System.Drawing.Size(264, 61)
		Me.pnlSequenceConfig.TabIndex = 15
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(154, 8)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(18, 14)
		Me.Label8.TabIndex = 14
		Me.Label8.Text = "to"
		'
		'tbxMainCharacterEnd
		'
		Me.tbxMainCharacterEnd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxMainCharacterEnd.Location = New System.Drawing.Point(177, 4)
		Me.tbxMainCharacterEnd.Name = "tbxMainCharacterEnd"
		Me.tbxMainCharacterEnd.Size = New System.Drawing.Size(43, 23)
		Me.tbxMainCharacterEnd.TabIndex = 13
		Me.tbxMainCharacterEnd.Text = "Z"
		Me.tbxMainCharacterEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'tbxPattern
		'
		Me.tbxPattern.Enabled = False
		Me.tbxPattern.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbxPattern.Location = New System.Drawing.Point(26, 121)
		Me.tbxPattern.Name = "tbxPattern"
		Me.tbxPattern.Size = New System.Drawing.Size(251, 23)
		Me.tbxPattern.TabIndex = 17
		Me.tbxPattern.Text = "ABCDEFG/*-+"
		Me.tbxPattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'rdbPattern
		'
		Me.rdbPattern.AutoSize = True
		Me.rdbPattern.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdbPattern.Location = New System.Drawing.Point(13, 97)
		Me.rdbPattern.Name = "rdbPattern"
		Me.rdbPattern.Size = New System.Drawing.Size(61, 18)
		Me.rdbPattern.TabIndex = 16
		Me.rdbPattern.Text = "Pattern"
		Me.rdbPattern.UseVisualStyleBackColor = True
		'
		'rdbSequence
		'
		Me.rdbSequence.AutoSize = True
		Me.rdbSequence.Checked = True
		Me.rdbSequence.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdbSequence.Location = New System.Drawing.Point(13, 6)
		Me.rdbSequence.Name = "rdbSequence"
		Me.rdbSequence.Size = New System.Drawing.Size(72, 18)
		Me.rdbSequence.TabIndex = 15
		Me.rdbSequence.TabStop = True
		Me.rdbSequence.Text = "Sequence"
		Me.rdbSequence.UseVisualStyleBackColor = True
		'
		'lblProgressStatus
		'
		Me.lblProgressStatus.AutoSize = True
		Me.lblProgressStatus.Location = New System.Drawing.Point(12, 255)
		Me.lblProgressStatus.Name = "lblProgressStatus"
		Me.lblProgressStatus.Size = New System.Drawing.Size(19, 14)
		Me.lblProgressStatus.TabIndex = 14
		Me.lblProgressStatus.Text = "**"
		'
		'btnTest
		'
		Me.btnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnTest.Location = New System.Drawing.Point(146, 250)
		Me.btnTest.Name = "btnTest"
		Me.btnTest.Size = New System.Drawing.Size(44, 25)
		Me.btnTest.TabIndex = 15
		Me.btnTest.Text = "Test"
		Me.btnTest.UseVisualStyleBackColor = True
		'
		'frmPatternPreview
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(314, 285)
		Me.Controls.Add(Me.btnTest)
		Me.Controls.Add(Me.lblProgressStatus)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.btnGenerate)
		Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmPatternPreview"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Pattern Preview"
		CType(Me.numReapaetWidth, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numRepeatRow, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.pnlSequenceConfig.ResumeLayout(False)
		Me.pnlSequenceConfig.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnGenerate As Button
	Friend WithEvents tbxMainCharacterStart As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents tbxSubCharacterStart As TextBox
	Friend WithEvents tbxSubCharacterEnd As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents numReapaetWidth As NumericUpDown
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents numRepeatRow As NumericUpDown
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label8 As Label
	Friend WithEvents tbxMainCharacterEnd As TextBox
	Friend WithEvents lblProgressStatus As Label
	Friend WithEvents tbxPattern As TextBox
	Friend WithEvents rdbPattern As RadioButton
	Friend WithEvents rdbSequence As RadioButton
	Friend WithEvents pnlSequenceConfig As Panel
	Friend WithEvents btnTest As Button
End Class
