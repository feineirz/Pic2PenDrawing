Public Class frmMain

	Private pix As Bitmap
	Private comG As Graphics

	Dim initSEQ As String = "{0.}0.+0.C0.^0.D0.P0.J0.%0.f0.N0.b0.O0.Z0.l0.r0.a0.|0.w0.00"
	Dim seq As String

	Dim exPI() As String
	Dim successThread As Integer = 0

	Sub initEnv()

		For Each item In My.Settings.PatternList
			cmbPattern.Items.Add(item)
		Next
		cmbPattern.Text = cmbPattern.Items(0)

		picPixelDraw.AllowDrop = True

	End Sub

	Sub LoadImage(Filename As String)

		If IO.File.Exists(Filename) Then

			picPixelDraw.Image = Nothing
			btnSaveImage.Enabled = False

			If chkAutoResize.Checked Then
				picSource.Image = ResizeImage(Image.FromFile(Filename), refWidth)
			Else
				picSource.Image = Image.FromFile(Filename)
			End If

			Dim fi As New IO.FileInfo(Filename)
			Dim bmp As New Bitmap(Filename)
			Dim di As String = ""

			lblImageInfo.Text = bmp.Width & " x " & bmp.Height & " px"
			di += "hexW: " & bmp.Width.ToString("X4") & vbCrLf
			di += "hexH: " & bmp.Height.ToString("X4") & vbCrLf

			'pick pen color
			If chkAutoPick.Checked Then
				Dim sumR = 0, sumG = 0, sumB = 0
				Dim sampling = 4000
				For i = 0 To sampling
					Application.DoEvents()
					Randomize()
					Dim c As Color = bmp.GetPixel(Rnd() * (bmp.Width - 1), Rnd() * (bmp.Height - 1))
					sumR += CInt(c.R)
					sumG += CInt(c.G)
					sumB += CInt(c.B)
				Next
				lblPenColor.BackColor = Color.FromArgb(sumR / sampling, sumG / sampling, sumB / sampling)
			End If
			di += "hexC: " & lblPenColor.BackColor.R.ToString("X2") & lblPenColor.BackColor.G.ToString("X2") & lblPenColor.BackColor.B.ToString("X2")

			lblFilename.Text = fi.Name.Replace(fi.Extension, "")
			lblDebugInfo.Text = di

			btnSaveImage.Enabled = True
			btnEditSequence.Enabled = True
			btnExportTXG.Enabled = True

		End If

	End Sub

	Sub LoadImage()

		Dim dlg As New OpenFileDialog With {.Filter = "Image File|*.jpg;*.bmp;*.png;*.jpeg"}

		If dlg.ShowDialog = DialogResult.OK Then

			LoadImage(dlg.FileName)

		End If

	End Sub

	Sub SaveImage()

		If picPixelDraw.Image Is Nothing Then Exit Sub
		Dim dlg As New SaveFileDialog With {.Filter = "JPG Image File|*.jpg", .FileName = lblFilename.Text & "-PixelDraw.jpg"}
		If dlg.ShowDialog = DialogResult.OK Then
			picPixelDraw.Image.Save(dlg.FileName)
		End If

	End Sub

	Private Delegate Sub exportTXGThreadDelegate(startY As Integer, endY As Integer, resIndex As Integer)

	Sub exportTXGThread(startY As Integer, endY As Integer, resIndex As Integer)

		If Me.InvokeRequired Then
			Me.Invoke(New exportTXGThreadDelegate(AddressOf exportTXGThread), startY, endY, resIndex)

		Else
			Dim buffer As String = ""

			Dim bmp As Bitmap = ResizeImage(picSource.Image, refWidth)
			Dim cSEQ As Char() = seq.ToArray
			'Dim cSEQ As String() = seq.Split(".")

			For y = startY To endY
				For x = 0 To bmp.Width - 1

					If x Mod (bmp.Width) = 0 And y > 0 Then buffer &= vbCrLf
					Application.DoEvents()
					If y < bmp.Height Then
						Dim c As Color = bmp.GetPixel(x, y)
						Dim cv As Integer = (CInt(c.R) + CInt(c.G) + CInt(c.B)) / 3
						Dim idx As Integer = CInt(Math.Floor((cv / 255) * (cSEQ.Length - 1)))
						buffer += cSEQ(idx)
					End If

				Next
			Next

			exPI(resIndex) = buffer

			successThread += 1
			lblProgressInfo.Text = successThread & " of " & exPI.Length & " Thread(s) completed."

		End If

	End Sub

	Sub ExportTXG()

		If picPixelDraw.Image Is Nothing Then Exit Sub

		pnlMainPanel.Enabled = False

		Dim hdr As String = "TXG"
		Dim di As String = ""
		Dim c As Color = lblPenColor.BackColor

		Dim dt1 As DateTime
		Dim ts As TimeSpan

		Dim bmp As Bitmap = New Bitmap(picPixelDraw.Image)

		hdr += bmp.Width.ToString("X4")
		hdr += bmp.Height.ToString("X4")
		hdr += lblPenColor.BackColor.R.ToString("X2") & lblPenColor.BackColor.G.ToString("X2") & lblPenColor.BackColor.B.ToString("X2")
		hdr += "." + cmbPattern.Text

		If cmbPattern.Text.Length < 8 Then
			cmbPattern.Text = cmbPattern.Items(0)
		End If

		seq = cmbPattern.Text

		pnlProgress.Show()
		dt1 = Now

		'Multi Thread
		Dim t(31) As Threading.Thread
		ReDim exPI(t.Length - 1)
		For i = 0 To t.Length - 1
			Dim idx = i
			Dim startY = i * Math.Ceiling(bmp.Height / t.Length)
			Dim endY = ((i + 1) * Math.Ceiling(bmp.Height / t.Length)) - 1
			t(i) = New Threading.Thread(Sub() exportTXGThread(startY, endY, idx))
			t(i).Start()
		Next

		While successThread < t.Length
			Application.DoEvents()
		End While

		successThread = 0

		For i = 0 To exPI.Length - 1
			di &= exPI(i)
		Next

		'End Multi Thread

		ts = Now - dt1
		lblDebugInfo.Text = "Processing time: " & ts.TotalSeconds.ToString("0.000") & " sec."

		'export
		Dim dlg As New SaveFileDialog With {.Filter = "TXG File|*.txg", .FileName = lblFilename.Text}
		If dlg.ShowDialog = DialogResult.OK Then
			IO.File.WriteAllText(dlg.FileName, hdr & vbCrLf & di)

			Dim p As New Process()
			p.StartInfo = New ProcessStartInfo("notepad.exe", dlg.FileName)
			p.Start()
		End If
		pnlProgress.Hide()
		lblProgressInfo.Text = ""
		lblDebugInfo.Text = "Header: " & hdr
		pnlMainPanel.Enabled = True

	End Sub

	Sub ConvertToGreyscale()

		If picSource.Image Is Nothing Then Exit Sub
		Dim pic = New Bitmap(picSource.Image)
		Dim gray = New Bitmap(pic.Width, pic.Height)
		For x As Integer = 0 To (pic.Width) - 1
			For y As Integer = 0 To (pic.Height) - 1
				Application.DoEvents()
				Dim c As Color = pic.GetPixel(x, y)
				Dim d As Integer = (CInt(c.R) + CInt(c.G) + CInt(c.B)) \ 3
				gray.SetPixel(x, y, Color.FromArgb(d, d, d))
			Next
		Next

		'picGreyScale.Image = gray

	End Sub

	Sub ConvertToPixelDraw()

		If picSource.Image Is Nothing Then Exit Sub

		pnlMainPanel.Enabled = False

		pnlProgress.Show()
		Me.Refresh()

		Dim dt As DateTime
		Dim ts As TimeSpan

		Dim pic = New Bitmap(picSource.Image)
		pix = New Bitmap(pic.Width, pic.Height)
		comG = Graphics.FromImage(pix)

		dt = Now

		'Single Thread
		Dim sampling As Single = numSampling.Value
		Dim scanLine = numLineSkip.Value
		Dim factor = numDetails.Value
		Dim progress As Single

		For y = 0 To pic.Height - 1 Step scanLine
			For x = 0 To pic.Width - 1 Step sampling
				Application.DoEvents()
				Dim b As New SolidBrush(lblPenColor.BackColor)
				Dim d As Integer = 0
				For j = y To y + scanLine - 1
					For i = x To x + sampling - 1
						If i < pic.Width And j < pic.Height Then
							Dim c As Color = pic.GetPixel(i, j)
							d += (CInt(c.R) + CInt(c.G) + CInt(c.B)) / 3
						End If
					Next
				Next
				d = 255 - d / (scanLine * sampling)
				Dim scale As Single = (d / 255) * factor
				Dim tpoint As Point = New Point(0, 0)
				For j = 0 To CInt(scale)
					For i = 0 To CInt(scale)
						If scale > 0 Then
							tpoint.X = x + CInt(i * sampling / scale)
							tpoint.Y = y + CInt(j * scanLine / scale)
						End If
						If tpoint.X < 0 Then tpoint.X = 0 Else If tpoint.X > pic.Width Then tpoint.X = pic.Width
						If tpoint.Y < 0 Then tpoint.Y = 0 Else If tpoint.Y > pic.Height Then tpoint.Y = pic.Height
						If tpoint.X < pic.Width And tpoint.Y < pic.Height And rdbFullColor.Checked Then b.Color = pic.GetPixel(tpoint.X, tpoint.Y)
						comG.FillRectangle(b, tpoint.X, tpoint.Y, CSng(1.0), CSng(1.0))
					Next
				Next
			Next
			progress = y / (pic.Height - 1) * 100
			lblProgressInfo.Text = progress.ToString("0.00") + "% completed."
		Next
		'End Single Thread

		ts = Now - dt
		lblDebugInfo.Text = "Processing time: " & ts.TotalSeconds.ToString("0.000") & " sec."

		pnlProgress.Hide()
		lblProgressInfo.Text = ""
		picPixelDraw.Image = pix

		btnSaveImage.Enabled = True
		pnlMainPanel.Enabled = True

	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

		initEnv()

	End Sub

	Private Sub btnLoadImage_Click(sender As Object, e As EventArgs) Handles btnLoadImage.Click

		LoadImage()
		ConvertToPixelDraw()

	End Sub

	Private Sub lblPenColor_Click(sender As Object, e As EventArgs) Handles lblPenColor.Click

		Dim dlg As New ColorDialog
		If dlg.ShowDialog = DialogResult.OK Then

			lblPenColor.BackColor = dlg.Color

		End If

	End Sub

	Private Sub picSource_Click(sender As Object, e As EventArgs) Handles picSource.Click

		LoadImage()
		ConvertToPixelDraw()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveImage.Click

		SaveImage()

	End Sub

	Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

		ConvertToPixelDraw()

	End Sub

	Private Sub picPixelDraw_SizeChanged(sender As Object, e As EventArgs) Handles picPixelDraw.SizeChanged

		pnlProgress.Location = New Point((picPixelDraw.Width - pnlProgress.Width) / 2, (picPixelDraw.Height - pnlProgress.Height) / 2)

	End Sub

	Private Sub num_GotFocus(sender As Object, e As EventArgs) Handles numSampling.GotFocus, numLineSkip.GotFocus, numDetails.GotFocus

		Dim num As NumericUpDown = sender
		num.Select(0, 10)

	End Sub

	Private Sub btnExportTXG_Click(sender As Object, e As EventArgs) Handles btnExportTXG.Click

		ExportTXG()

	End Sub

	Private Sub btnEditSequence_Click(sender As Object, e As EventArgs) Handles btnEditSequence.Click

		If btnEditSequence.Text = "Edit" Then
			btnSaveSequence.Enabled = True
			btnResetSequence.Enabled = True
			cmbPattern.Enabled = True
			btnEditSequence.Text = "Lock"

		Else
			btnSaveSequence.Enabled = False
			btnResetSequence.Enabled = False
			cmbPattern.Enabled = False
			btnEditSequence.Text = "Edit"
		End If

	End Sub

	Private Sub btnResetSequence_Click(sender As Object, e As EventArgs) Handles btnResetSequence.Click

		cmbPattern.Text = cmbPattern.Items(0)

	End Sub

	Private Sub btnSaveSequence_Click(sender As Object, e As EventArgs) Handles btnSaveSequence.Click

		If cmbPattern.Text.Length > 8 Then
			cmbPattern.Items.Add(cmbPattern.Text)
			My.Settings.PatternList.Add(cmbPattern.Text)
		End If

	End Sub

	Private Sub btnPreviewSequence_Click(sender As Object, e As EventArgs) Handles btnPreviewSequence.Click

		With frmPatternPreview
			.tbxPattern.Text = cmbPattern.Text
			.ShowDialog()
		End With

	End Sub

	Private Sub picPixelDraw_DragEnter(sender As Object, e As DragEventArgs) Handles picPixelDraw.DragEnter

		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			Dim f As New IO.FileInfo(e.Data.GetData(DataFormats.FileDrop)(0))
			If f.Extension = ".jpg" Or f.Extension = ".jpeg" Or f.Extension = ".png" Or f.Extension = ".bmp" Then
				e.Effect = DragDropEffects.Copy
			Else
				e.Effect = DragDropEffects.None
			End If
		End If

	End Sub

	Private Sub picPixelDraw_DragDrop(sender As Object, e As DragEventArgs) Handles picPixelDraw.DragDrop

		LoadImage(e.Data.GetData(DataFormats.FileDrop)(0))
		ConvertToPixelDraw()

	End Sub
End Class
