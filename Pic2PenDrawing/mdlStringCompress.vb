Imports System.Text

Module mdlStringCompress

	Public Function BitsToHex(source As String) As String

		For i = 0 To source.Length Mod 8
			source &= 0
		Next

		Dim sb As StringBuilder = New StringBuilder()
		For pos As Integer = 0 To source.Length - 8 Step 8
			sb.Append(Convert.ToByte(source.Substring(pos, 8), 2).ToString("X2"))
		Next

		Return sb.ToString()

	End Function


End Module
