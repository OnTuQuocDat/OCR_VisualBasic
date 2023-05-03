Imports System

Module Program
    Const Fixture_Rows = 8
    Const Fixture_Column = 10
    Dim lastLine As String '= "BB3ZR0D"
    Dim result_index As Integer
    Dim save_serial_fornext As String
    Dim generate() As String = IO.File.ReadAllLines("test_generate_serial.txt")

    Function find_index()
        ' Tim index cua ký tự chuỗi lastLine  đang nằm ở index thứ mấy trong file tổng --> sau đó lấy "result index" ra để cộng thêm 80 con tiếp theo
        Dim text() As String = System.IO.File.ReadAllLines("test_generate_serial.txt")
        'Dim Findstring = IO.File.ReadAllText("test_generate_serial.txt")
        result_index = Array.FindIndex(text, Function(s) s = lastLine)
        result_index = result_index + 1
        If result_index >= 0 Then
            Console.WriteLine(result_index)
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

    Function Generate_serial()
        For i As Integer = result_index To result_index + 81
            Console.WriteLine("i value: {0}", i)
        Next
        ''''''''''''''''''''''''''Note chỗ này vô nè
        'If result_index < 81 Then
        'result_index = result_index + 1
        'End If
        ''''''''''''''''''''
    End Function

    Function Save_lastserial()
        save_serial_fornext = generate(result_index + 80)
        'save_serial_fornext = "6W3NV4W"

        Dim file_save_name As String = "temp.txt"
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter("temp.txt", 1)
            writer.WriteLine(save_serial_fornext)

        End Using
        'Dim objWriter As New System.IO.StreamWriter(file_save_name)
        'objWriter.Write(save_serial_fornext)
        'objWriter.Close()

        Console.WriteLine("Write done")

    End Function




    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Read_final_serial_from_txt()
        find_index()
        'Start loop for i for j ngay đây
        Generate_serial()

        'Save serial for next start
        Save_lastserial()

    End Sub

End Module