Module mdlComm

	Public refWidth As Integer = 1024

	Public Function ResizeImage(source As Image, reqWidth As Integer) As Image

		Dim scale As Single = reqWidth / source.Width

		If source.Width < refWidth Then Return source
		Return ResizeImage(source, scale)

	End Function

	Public Function ResizeImage(source As Image, scale As Single) As Bitmap

		If source.Width < refWidth Then Return source
		Dim bmp As New Bitmap(CInt(source.Width * scale), CInt(source.Height * scale))
		Dim g As Graphics = Graphics.FromImage(bmp)

		g.DrawImage(source, 0, 0, bmp.Width + 1, bmp.Height + 1)

		Return bmp

	End Function

End Module
