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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.picSource = New System.Windows.Forms.PictureBox()
		Me.btnLoadImage = New System.Windows.Forms.Button()
		Me.picPixelDraw = New System.Windows.Forms.PictureBox()
		Me.numSampling = New System.Windows.Forms.NumericUpDown()
		Me.numDetails = New System.Windows.Forms.NumericUpDown()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblPenColor = New System.Windows.Forms.Label()
		Me.lblFilename = New System.Windows.Forms.Label()
		Me.pnlSettings = New System.Windows.Forms.Panel()
		Me.chkAutoPick = New System.Windows.Forms.CheckBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.numLineSkip = New System.Windows.Forms.NumericUpDown()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.btnConvert = New System.Windows.Forms.Button()
		Me.lblProcessing = New System.Windows.Forms.Label()
		Me.lblImageInfo = New System.Windows.Forms.Label()
		Me.btnSaveImage = New System.Windows.Forms.Button()
		Me.btnExportTXG = New System.Windows.Forms.Button()
		Me.lblDebugInfo = New System.Windows.Forms.Label()
		Me.chkAutoResize = New System.Windows.Forms.CheckBox()
		Me.pnlMainPanel = New System.Windows.Forms.Panel()
		Me.btnPreviewSequence = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.rdbMonoTone = New System.Windows.Forms.RadioButton()
		Me.rdbFullColor = New System.Windows.Forms.RadioButton()
		Me.btnSaveSequence = New System.Windows.Forms.Button()
		Me.btnResetSequence = New System.Windows.Forms.Button()
		Me.btnEditSequence = New System.Windows.Forms.Button()
		Me.lblSEQ = New System.Windows.Forms.Label()
		Me.pnlProgress = New System.Windows.Forms.Panel()
		Me.lblProgressInfo = New System.Windows.Forms.Label()
		Me.cmbPattern = New System.Windows.Forms.ComboBox()
		CType(Me.picSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picPixelDraw, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numSampling, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlSettings.SuspendLayout()
		CType(Me.numLineSkip, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlMainPanel.SuspendLayout()
		Me.pnlProgress.SuspendLayout()
		Me.SuspendLayout()
		'
		'picSource
		'
		Me.picSource.BackColor = System.Drawing.Color.WhiteSmoke
		Me.picSource.Image = CType(resources.GetObject("picSource.Image"), System.Drawing.Image)
		Me.picSource.Location = New System.Drawing.Point(12, 27)
		Me.picSource.Name = "picSource"
		Me.picSource.Size = New System.Drawing.Size(187, 140)
		Me.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picSource.TabIndex = 0
		Me.picSource.TabStop = False
		'
		'btnLoadImage
		'
		Me.btnLoadImage.FlatAppearance.BorderSize = 0
		Me.btnLoadImage.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLoadImage.ForeColor = System.Drawing.Color.Goldenrod
		Me.btnLoadImage.Location = New System.Drawing.Point(115, 234)
		Me.btnLoadImage.Name = "btnLoadImage"
		Me.btnLoadImage.Size = New System.Drawing.Size(85, 24)
		Me.btnLoadImage.TabIndex = 2
		Me.btnLoadImage.Text = "Load Image"
		Me.btnLoadImage.UseVisualStyleBackColor = True
		'
		'picPixelDraw
		'
		Me.picPixelDraw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.picPixelDraw.BackColor = System.Drawing.Color.White
		Me.picPixelDraw.Location = New System.Drawing.Point(0, 0)
		Me.picPixelDraw.Name = "picPixelDraw"
		Me.picPixelDraw.Size = New System.Drawing.Size(825, 647)
		Me.picPixelDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.picPixelDraw.TabIndex = 4
		Me.picPixelDraw.TabStop = False
		'
		'numSampling
		'
		Me.numSampling.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numSampling.Location = New System.Drawing.Point(98, 77)
		Me.numSampling.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numSampling.Name = "numSampling"
		Me.numSampling.Size = New System.Drawing.Size(82, 22)
		Me.numSampling.TabIndex = 2
		Me.numSampling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numSampling.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'numDetails
		'
		Me.numDetails.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numDetails.Location = New System.Drawing.Point(98, 129)
		Me.numDetails.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numDetails.Name = "numDetails"
		Me.numDetails.Size = New System.Drawing.Size(82, 22)
		Me.numDetails.TabIndex = 4
		Me.numDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numDetails.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(9, 79)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(86, 13)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Sampling Width:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(51, 131)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(44, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Details:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(36, 30)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(56, 13)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Pen Color:"
		'
		'lblPenColor
		'
		Me.lblPenColor.BackColor = System.Drawing.Color.SkyBlue
		Me.lblPenColor.Location = New System.Drawing.Point(98, 26)
		Me.lblPenColor.Name = "lblPenColor"
		Me.lblPenColor.Size = New System.Drawing.Size(82, 22)
		Me.lblPenColor.TabIndex = 0
		'
		'lblFilename
		'
		Me.lblFilename.BackColor = System.Drawing.Color.DimGray
		Me.lblFilename.ForeColor = System.Drawing.Color.Bisque
		Me.lblFilename.Location = New System.Drawing.Point(12, 7)
		Me.lblFilename.Name = "lblFilename"
		Me.lblFilename.Size = New System.Drawing.Size(187, 18)
		Me.lblFilename.TabIndex = 12
		Me.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlSettings
		'
		Me.pnlSettings.BackColor = System.Drawing.Color.Gainsboro
		Me.pnlSettings.Controls.Add(Me.chkAutoPick)
		Me.pnlSettings.Controls.Add(Me.Label5)
		Me.pnlSettings.Controls.Add(Me.numLineSkip)
		Me.pnlSettings.Controls.Add(Me.Label4)
		Me.pnlSettings.Controls.Add(Me.Label3)
		Me.pnlSettings.Controls.Add(Me.numDetails)
		Me.pnlSettings.Controls.Add(Me.Label2)
		Me.pnlSettings.Controls.Add(Me.lblPenColor)
		Me.pnlSettings.Controls.Add(Me.numSampling)
		Me.pnlSettings.Controls.Add(Me.Label1)
		Me.pnlSettings.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pnlSettings.Location = New System.Drawing.Point(13, 273)
		Me.pnlSettings.Name = "pnlSettings"
		Me.pnlSettings.Size = New System.Drawing.Size(187, 158)
		Me.pnlSettings.TabIndex = 1
		'
		'chkAutoPick
		'
		Me.chkAutoPick.AutoSize = True
		Me.chkAutoPick.Checked = True
		Me.chkAutoPick.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAutoPick.Location = New System.Drawing.Point(98, 51)
		Me.chkAutoPick.Name = "chkAutoPick"
		Me.chkAutoPick.Size = New System.Drawing.Size(75, 18)
		Me.chkAutoPick.TabIndex = 1
		Me.chkAutoPick.Text = "Auto Pick"
		Me.chkAutoPick.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(3, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(58, 17)
		Me.Label5.TabIndex = 14
		Me.Label5.Text = "Settings"
		'
		'numLineSkip
		'
		Me.numLineSkip.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numLineSkip.Location = New System.Drawing.Point(98, 103)
		Me.numLineSkip.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numLineSkip.Name = "numLineSkip"
		Me.numLineSkip.Size = New System.Drawing.Size(82, 22)
		Me.numLineSkip.TabIndex = 3
		Me.numLineSkip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numLineSkip.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(43, 105)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(52, 13)
		Me.Label4.TabIndex = 13
		Me.Label4.Text = "Line Skip:"
		'
		'btnConvert
		'
		Me.btnConvert.FlatAppearance.BorderSize = 0
		Me.btnConvert.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnConvert.ForeColor = System.Drawing.Color.CornflowerBlue
		Me.btnConvert.Location = New System.Drawing.Point(13, 442)
		Me.btnConvert.Name = "btnConvert"
		Me.btnConvert.Size = New System.Drawing.Size(96, 24)
		Me.btnConvert.TabIndex = 5
		Me.btnConvert.Text = "Process"
		Me.btnConvert.UseVisualStyleBackColor = True
		'
		'lblProcessing
		'
		Me.lblProcessing.BackColor = System.Drawing.Color.Transparent
		Me.lblProcessing.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProcessing.Location = New System.Drawing.Point(60, 16)
		Me.lblProcessing.Name = "lblProcessing"
		Me.lblProcessing.Size = New System.Drawing.Size(200, 36)
		Me.lblProcessing.TabIndex = 15
		Me.lblProcessing.Text = "PROCESSING..."
		Me.lblProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblImageInfo
		'
		Me.lblImageInfo.BackColor = System.Drawing.Color.DimGray
		Me.lblImageInfo.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblImageInfo.ForeColor = System.Drawing.Color.LightCyan
		Me.lblImageInfo.Location = New System.Drawing.Point(12, 169)
		Me.lblImageInfo.Name = "lblImageInfo"
		Me.lblImageInfo.Size = New System.Drawing.Size(187, 19)
		Me.lblImageInfo.TabIndex = 16
		Me.lblImageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnSaveImage
		'
		Me.btnSaveImage.Enabled = False
		Me.btnSaveImage.FlatAppearance.BorderSize = 0
		Me.btnSaveImage.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveImage.ForeColor = System.Drawing.Color.Green
		Me.btnSaveImage.Location = New System.Drawing.Point(115, 442)
		Me.btnSaveImage.Name = "btnSaveImage"
		Me.btnSaveImage.Size = New System.Drawing.Size(85, 24)
		Me.btnSaveImage.TabIndex = 3
		Me.btnSaveImage.Text = "Save Image"
		Me.btnSaveImage.UseVisualStyleBackColor = True
		'
		'btnExportTXG
		'
		Me.btnExportTXG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnExportTXG.Enabled = False
		Me.btnExportTXG.FlatAppearance.BorderSize = 0
		Me.btnExportTXG.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExportTXG.ForeColor = System.Drawing.Color.MediumVioletRed
		Me.btnExportTXG.Location = New System.Drawing.Point(13, 616)
		Me.btnExportTXG.Name = "btnExportTXG"
		Me.btnExportTXG.Size = New System.Drawing.Size(186, 24)
		Me.btnExportTXG.TabIndex = 17
		Me.btnExportTXG.Text = "Export TXG"
		Me.btnExportTXG.UseVisualStyleBackColor = True
		'
		'lblDebugInfo
		'
		Me.lblDebugInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblDebugInfo.BackColor = System.Drawing.Color.WhiteSmoke
		Me.lblDebugInfo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDebugInfo.Location = New System.Drawing.Point(13, 472)
		Me.lblDebugInfo.Name = "lblDebugInfo"
		Me.lblDebugInfo.Size = New System.Drawing.Size(186, 33)
		Me.lblDebugInfo.TabIndex = 15
		'
		'chkAutoResize
		'
		Me.chkAutoResize.AutoSize = True
		Me.chkAutoResize.Checked = True
		Me.chkAutoResize.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAutoResize.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAutoResize.Location = New System.Drawing.Point(29, 239)
		Me.chkAutoResize.Name = "chkAutoResize"
		Me.chkAutoResize.Size = New System.Drawing.Size(80, 17)
		Me.chkAutoResize.TabIndex = 18
		Me.chkAutoResize.Text = "Auto Resize"
		Me.chkAutoResize.UseVisualStyleBackColor = True
		'
		'pnlMainPanel
		'
		Me.pnlMainPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlMainPanel.Controls.Add(Me.cmbPattern)
		Me.pnlMainPanel.Controls.Add(Me.btnPreviewSequence)
		Me.pnlMainPanel.Controls.Add(Me.Label7)
		Me.pnlMainPanel.Controls.Add(Me.btnConvert)
		Me.pnlMainPanel.Controls.Add(Me.rdbMonoTone)
		Me.pnlMainPanel.Controls.Add(Me.rdbFullColor)
		Me.pnlMainPanel.Controls.Add(Me.btnSaveSequence)
		Me.pnlMainPanel.Controls.Add(Me.btnResetSequence)
		Me.pnlMainPanel.Controls.Add(Me.btnEditSequence)
		Me.pnlMainPanel.Controls.Add(Me.lblDebugInfo)
		Me.pnlMainPanel.Controls.Add(Me.lblSEQ)
		Me.pnlMainPanel.Controls.Add(Me.picSource)
		Me.pnlMainPanel.Controls.Add(Me.btnExportTXG)
		Me.pnlMainPanel.Controls.Add(Me.lblFilename)
		Me.pnlMainPanel.Controls.Add(Me.chkAutoResize)
		Me.pnlMainPanel.Controls.Add(Me.lblImageInfo)
		Me.pnlMainPanel.Controls.Add(Me.pnlSettings)
		Me.pnlMainPanel.Controls.Add(Me.btnLoadImage)
		Me.pnlMainPanel.Controls.Add(Me.btnSaveImage)
		Me.pnlMainPanel.Location = New System.Drawing.Point(831, 0)
		Me.pnlMainPanel.Name = "pnlMainPanel"
		Me.pnlMainPanel.Size = New System.Drawing.Size(211, 647)
		Me.pnlMainPanel.TabIndex = 20
		'
		'btnPreviewSequence
		'
		Me.btnPreviewSequence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnPreviewSequence.FlatAppearance.BorderSize = 0
		Me.btnPreviewSequence.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPreviewSequence.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnPreviewSequence.Location = New System.Drawing.Point(13, 583)
		Me.btnPreviewSequence.Name = "btnPreviewSequence"
		Me.btnPreviewSequence.Size = New System.Drawing.Size(56, 20)
		Me.btnPreviewSequence.TabIndex = 26
		Me.btnPreviewSequence.Text = "Preview"
		Me.btnPreviewSequence.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(10, 193)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(71, 15)
		Me.Label7.TabIndex = 25
		Me.Label7.Text = "Color Mode"
		'
		'rdbMonoTone
		'
		Me.rdbMonoTone.AutoSize = True
		Me.rdbMonoTone.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdbMonoTone.Location = New System.Drawing.Point(112, 211)
		Me.rdbMonoTone.Name = "rdbMonoTone"
		Me.rdbMonoTone.Size = New System.Drawing.Size(85, 19)
		Me.rdbMonoTone.TabIndex = 24
		Me.rdbMonoTone.Text = "Mono Tone"
		Me.rdbMonoTone.UseVisualStyleBackColor = True
		'
		'rdbFullColor
		'
		Me.rdbFullColor.AutoSize = True
		Me.rdbFullColor.Checked = True
		Me.rdbFullColor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdbFullColor.Location = New System.Drawing.Point(29, 211)
		Me.rdbFullColor.Name = "rdbFullColor"
		Me.rdbFullColor.Size = New System.Drawing.Size(79, 19)
		Me.rdbFullColor.TabIndex = 23
		Me.rdbFullColor.TabStop = True
		Me.rdbFullColor.Text = "Full Color"
		Me.rdbFullColor.UseVisualStyleBackColor = True
		'
		'btnSaveSequence
		'
		Me.btnSaveSequence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnSaveSequence.Enabled = False
		Me.btnSaveSequence.FlatAppearance.BorderSize = 0
		Me.btnSaveSequence.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSaveSequence.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnSaveSequence.Location = New System.Drawing.Point(115, 583)
		Me.btnSaveSequence.Name = "btnSaveSequence"
		Me.btnSaveSequence.Size = New System.Drawing.Size(37, 20)
		Me.btnSaveSequence.TabIndex = 22
		Me.btnSaveSequence.Text = "Save"
		Me.btnSaveSequence.UseVisualStyleBackColor = True
		'
		'btnResetSequence
		'
		Me.btnResetSequence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnResetSequence.Enabled = False
		Me.btnResetSequence.FlatAppearance.BorderSize = 0
		Me.btnResetSequence.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnResetSequence.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnResetSequence.Location = New System.Drawing.Point(157, 583)
		Me.btnResetSequence.Name = "btnResetSequence"
		Me.btnResetSequence.Size = New System.Drawing.Size(43, 20)
		Me.btnResetSequence.TabIndex = 21
		Me.btnResetSequence.Text = "Reset"
		Me.btnResetSequence.UseVisualStyleBackColor = True
		'
		'btnEditSequence
		'
		Me.btnEditSequence.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.btnEditSequence.Enabled = False
		Me.btnEditSequence.FlatAppearance.BorderSize = 0
		Me.btnEditSequence.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEditSequence.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.btnEditSequence.Location = New System.Drawing.Point(75, 583)
		Me.btnEditSequence.Name = "btnEditSequence"
		Me.btnEditSequence.Size = New System.Drawing.Size(34, 20)
		Me.btnEditSequence.TabIndex = 20
		Me.btnEditSequence.Text = "Edit"
		Me.btnEditSequence.UseVisualStyleBackColor = True
		'
		'lblSEQ
		'
		Me.lblSEQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.lblSEQ.AutoSize = True
		Me.lblSEQ.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSEQ.Location = New System.Drawing.Point(9, 536)
		Me.lblSEQ.Name = "lblSEQ"
		Me.lblSEQ.Size = New System.Drawing.Size(60, 14)
		Me.lblSEQ.TabIndex = 15
		Me.lblSEQ.Text = "Sequence"
		'
		'pnlProgress
		'
		Me.pnlProgress.BackColor = System.Drawing.Color.Transparent
		Me.pnlProgress.Controls.Add(Me.lblProgressInfo)
		Me.pnlProgress.Controls.Add(Me.lblProcessing)
		Me.pnlProgress.Location = New System.Drawing.Point(258, 231)
		Me.pnlProgress.Name = "pnlProgress"
		Me.pnlProgress.Size = New System.Drawing.Size(320, 105)
		Me.pnlProgress.TabIndex = 21
		Me.pnlProgress.Visible = False
		'
		'lblProgressInfo
		'
		Me.lblProgressInfo.BackColor = System.Drawing.Color.Transparent
		Me.lblProgressInfo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProgressInfo.Location = New System.Drawing.Point(16, 63)
		Me.lblProgressInfo.Name = "lblProgressInfo"
		Me.lblProgressInfo.Size = New System.Drawing.Size(288, 21)
		Me.lblProgressInfo.TabIndex = 16
		Me.lblProgressInfo.Text = "Progress Info."
		Me.lblProgressInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'cmbPattern
		'
		Me.cmbPattern.FormattingEnabled = True
		Me.cmbPattern.Location = New System.Drawing.Point(13, 556)
		Me.cmbPattern.Name = "cmbPattern"
		Me.cmbPattern.Size = New System.Drawing.Size(186, 21)
		Me.cmbPattern.TabIndex = 27
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.WhiteSmoke
		Me.ClientSize = New System.Drawing.Size(1042, 647)
		Me.Controls.Add(Me.pnlProgress)
		Me.Controls.Add(Me.pnlMainPanel)
		Me.Controls.Add(Me.picPixelDraw)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Pic2PenDrawing"
		CType(Me.picSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picPixelDraw, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numSampling, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numDetails, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlSettings.ResumeLayout(False)
		Me.pnlSettings.PerformLayout()
		CType(Me.numLineSkip, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlMainPanel.ResumeLayout(False)
		Me.pnlMainPanel.PerformLayout()
		Me.pnlProgress.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents picSource As PictureBox
	Friend WithEvents btnLoadImage As Button
	Friend WithEvents picPixelDraw As PictureBox
	Friend WithEvents numSampling As NumericUpDown
	Friend WithEvents numDetails As NumericUpDown
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblPenColor As Label
	Friend WithEvents lblFilename As Label
	Friend WithEvents pnlSettings As Panel
	Friend WithEvents numLineSkip As NumericUpDown
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents lblProcessing As Label
	Friend WithEvents lblImageInfo As Label
	Friend WithEvents btnSaveImage As Button
	Friend WithEvents btnConvert As Button
	Friend WithEvents chkAutoPick As CheckBox
	Friend WithEvents btnExportTXG As Button
	Friend WithEvents lblDebugInfo As Label
	Friend WithEvents chkAutoResize As CheckBox
	Friend WithEvents pnlMainPanel As Panel
	Friend WithEvents pnlProgress As Panel
	Friend WithEvents lblProgressInfo As Label
	Friend WithEvents lblSEQ As Label
	Friend WithEvents btnResetSequence As Button
	Friend WithEvents btnEditSequence As Button
	Friend WithEvents btnSaveSequence As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents rdbMonoTone As RadioButton
	Friend WithEvents rdbFullColor As RadioButton
	Friend WithEvents btnPreviewSequence As Button
	Friend WithEvents cmbPattern As ComboBox
End Class
