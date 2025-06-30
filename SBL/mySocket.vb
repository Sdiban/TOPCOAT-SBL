Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO.Ports
Imports System.Net.Sockets

Public Class MySocket

    Public Cliente As TcpClient
    Public Stream As NetworkStream

    Public Function Conectar(ByVal Puerto As Integer, ByVal Ip As String) As Boolean
        Try
            Cliente = New TcpClient(Ip, Puerto)
            Stream = Cliente.GetStream()
            Conectar = True
        Catch ex As Exception
            Conectar = False
        End Try
    End Function


    Public Sub Desconectar()
        Try
            cliente.Client.Close()
            cliente.Close()
            stream.Close()
            stream.Dispose()
            stream = Nothing
            Cliente = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Transmitir(ByVal Datos As String)
        Try
            stream = cliente.GetStream()
            Dim Data() As Byte = System.Text.Encoding.ASCII.GetBytes(Datos)
            Stream.Write(Data, 0, Data.Length)
        Catch ex As Exception
        End Try
    End Sub


End Class

