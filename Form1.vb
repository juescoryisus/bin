Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Guardar
        Dim fs As New FileStream("datos.bin", FileMode.Create)
        Dim bw As New BinaryWriter(fs)
        bw.Write("hola")
        bw.Write(123)
        bw.Close()
        bw.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Cargar
        Dim fs As New FileStream("datos.bin", FileMode.Open)
        Dim br As New BinaryReader(fs)
        Dim texto As String = br.ReadString()
        Dim numero As Integer = br.ReadInt32()
        br.Close()
        fs.Close()
        MsgBox(texto & " " & numero)

    End Sub
End Class
