Imports System

Module Program
    Dim lastLine As String '= "BB3ZR0D"
    Dim result As Integer

    Function find_index()
        ' Tim index cua ký tự chuỗi lastLine  đang nằm ở index thứ mấy trong file tổng --> sau đó lấy "result index" ra để cộng thêm 80 con tiếp theo
        Dim text() As String = System.IO.File.ReadAllLines("test_generate_serial.txt")
        'Dim Findstring = IO.File.ReadAllText("test_generate_serial.txt")
        result = Array.FindIndex(text, Function(s) s = lastLine)
        result = result + 1
        If result >= 0 Then
            Console.WriteLine(result)
        Else
            Console.WriteLine("Cannot find the index for this serial in file")
        End If
    End Function

    Function Read_final_serial_from_txt()
        'Đọc chuỗi string cuối cùng trong file temp.txt
        Dim lines() As String = IO.File.ReadAllLines("temp.txt")
        lastLine = lines(lines.Length - 1)
        Console.WriteLine(lastLine)

    End Function




    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Read_final_serial_from_txt()
        find_index()

    End Sub

End Module
