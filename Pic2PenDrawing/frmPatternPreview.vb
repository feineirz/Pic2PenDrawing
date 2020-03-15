Public Class frmPatternPreview
	Private Sub tbxMainCharacter_TextChanged(sender As Object, e As EventArgs) Handles tbxMainCharacterStart.TextChanged

		If tbxMainCharacterStart.Text.Trim = "" Then tbxMainCharacterStart.Text = "A"

	End Sub

	Private Sub tbxSubCharacterStart_TextChanged(sender As Object, e As EventArgs) Handles tbxSubCharacterStart.TextChanged

		If tbxSubCharacterStart.Text.Trim = "" Then
			tbxSubCharacterEnd.Text = ""
			tbxSubCharacterEnd.Enabled = False
		Else
			tbxSubCharacterEnd.Enabled = True
		End If

	End Sub

	Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

		Dim repCol As Integer = numReapaetWidth.Value
		Dim repRow As Integer = numRepeatRow.Value

		Dim buff As String = ""
		Dim cMainChrStart As Char = tbxMainCharacterStart.Text
		Dim cMainChrEnd As Char = tbxMainCharacterEnd.Text
		Dim cSubChrStart As Char = tbxSubCharacterStart.Text
		Dim cSubChrEnd As Char = tbxSubCharacterEnd.Text
		Dim iMainChrStart As Integer = 0
		Dim iMainChrEnd As Integer = 0
		Dim iSubChrStart As Integer = 0
		Dim iSubChrEnd As Integer = 0

		If Not tbxMainCharacterStart.Text.Trim = "" Then iMainChrStart = AscW(cMainChrStart)
		If Not tbxMainCharacterEnd.Text.Trim = "" Then iMainChrEnd = AscW(cMainChrEnd)
		If Not tbxSubCharacterStart.Text.Trim = "" Then iSubChrStart = AscW(cSubChrStart)
		If Not tbxSubCharacterEnd.Text.Trim = "" Then iSubChrEnd = AscW(cSubChrEnd)

		If rdbSequence.Checked Then
			If iMainChrEnd = 0 Then
				'MainStart
				If iSubChrEnd = 0 Then
					''SubStart
					lblProgressStatus.Text = "Start process [Method A]"
					For row = 1 To repRow
						For col = 1 To repCol
							Application.DoEvents()
							buff += cMainChrStart + cSubChrStart
						Next
						buff += vbCrLf
					Next

				Else
					''SubStart+SubEnd
					lblProgressStatus.Text = "Start process [Method B]"
					If iSubChrEnd < iSubChrStart Then
						Dim tmp As Integer
						tmp = iSubChrStart
						iSubChrStart = iSubChrEnd
						iSubChrEnd = tmp
					End If

					For row = 1 To repRow
						For i = iSubChrStart To iSubChrEnd
							For col = 1 To repCol
								Application.DoEvents()
								buff += cMainChrStart + ChrW(i)
							Next
						Next
						buff += vbCrLf
					Next
				End If

			Else
				'MainStart+MainEnd
				If iMainChrEnd < iMainChrStart Then
					Dim tmp As Integer
					tmp = iMainChrStart
					iMainChrStart = iMainChrEnd
					iMainChrEnd = tmp
				End If
				If iSubChrStart = 0 And iSubChrEnd = 0 Then
					''No Sub
					lblProgressStatus.Text = "Start process [Method C]"
					For row = 1 To repRow
						For i = iMainChrStart To iMainChrEnd
							For col = 1 To repCol
								Application.DoEvents()
								buff += ChrW(i)
							Next
						Next
						buff += vbCrLf
					Next

				ElseIf iSubChrEnd = 0 Then
					''SubStart
					lblProgressStatus.Text = "Start process [Method D]"
					For i = iMainChrStart To iMainChrEnd
						For row = 1 To repRow
							For col = 1 To repCol
								Application.DoEvents()
								buff += ChrW(i) + cSubChrStart
							Next
							buff += vbCrLf
						Next
					Next

				Else
					If iSubChrEnd < iSubChrStart Then
						Dim tmp As Integer
						tmp = iSubChrStart
						iSubChrStart = iSubChrEnd
						iSubChrEnd = tmp
					End If

					''SubStart+SubEnd
					lblProgressStatus.Text = "Start process [Method E]"
					For j = iMainChrStart To iMainChrEnd
						For row = 1 To repRow
							For i = iSubChrStart To iSubChrEnd
								For col = 1 To repCol
									Application.DoEvents()
									buff += ChrW(j) + ChrW(i)
								Next
							Next
							buff += vbCrLf
						Next
					Next

				End If
			End If

		Else
			''Pattern
			lblProgressStatus.Text = "Start process [Method F]"
			If tbxPattern.Text.Trim = "" Then Exit Sub

			Dim pattern As String = tbxPattern.Text
			Dim cPattern As Char() = pattern.ToArray

			For row = 1 To repRow
				For i = 0 To cPattern.Length - 1
					For col = 1 To repCol
						Application.DoEvents()
						buff += cPattern(i)
					Next
				Next
				buff += vbCrLf
			Next

		End If

		Dim tmpFile As String = IO.Path.GetTempFileName
		IO.File.WriteAllText(tmpFile, buff)
		Clipboard.SetText(buff.ToString)
		lblProgressStatus.Text = "Successful."

		Dim p As New Process()
		p.StartInfo = New ProcessStartInfo("notepad.exe", tmpFile)
		p.Start()

	End Sub

	Private Sub frmPatternPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub rdbSequence_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSequence.CheckedChanged

		If rdbSequence.Checked Then
			pnlSequenceConfig.Enabled = True
			tbxPattern.Enabled = False
			btnTest.Enabled = False
		Else
			pnlSequenceConfig.Enabled = False
			tbxPattern.Enabled = True
			btnTest.Enabled = True
		End If

	End Sub

	Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

		frmMain.cmbPattern.Text = tbxPattern.Text
		Me.Hide()

	End Sub
End Class