﻿Option Explicit On
Option Strict On
Option Infer Off

Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Namespace ntPrint
    Public Class tPrint

#Region "DLLImports"

        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function OpenPrinter(ByVal printerName As String, ByRef printerHandle As IntPtr, ByVal printerDefault As Integer) As Long
        End Function

        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=False, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function

        <DllImport("winspool.Drv", EntryPoint:="WritePrinter", SetLastError:=True, CharSet:=CharSet.Unicode, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Private Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
        End Function

#End Region


        Private Function SendBytesToPrinter(ByVal printerName As String, ByVal bytesPointer As IntPtr, ByVal bufferSize As Int32) As Boolean
            Dim printerHandle As IntPtr             ' The printer handle
            Dim printerError As Int32               ' Last Error
            Dim di As New DOCINFOW                  ' Describes your document (name, port, data type)
            Dim bytesWritten As Int32               ' The number of bytes written by WritePrinter()
            Dim success As Boolean = False          ' success if true

            ' Set up the DOCINFO structure
            di.DocumentName = System.Reflection.Assembly.GetCallingAssembly.GetName.Name
            di.PrinterDataType = "RAW"

            If OpenPrinter(printerName, printerHandle, 0) > 0 Then
                If StartDocPrinter(printerHandle, 1, di) Then
                    If StartPagePrinter(printerHandle) Then
                        ' Write your printer-specific bytes to the printer.
                        success = WritePrinter(printerHandle, bytesPointer, bufferSize, bytesWritten)
                        EndPagePrinter(printerHandle)
                    End If
                    EndDocPrinter(printerHandle)
                End If
                ClosePrinter(printerHandle)
            End If

            If Not success Then
                printerError = Marshal.GetLastWin32Error()
            End If

            Return success
        End Function

        Public Function SendFileToPrinter(ByVal printerName As String, ByVal filePath As String) As Boolean
            Try
                ' Open the file.
                Dim fs As New FileStream(filePath, FileMode.Open)
                Dim br As New BinaryReader(fs)
                Dim bufferSize As Int32 = 0

                Try
                    bufferSize = Convert.ToInt32(fs.Length)
                Catch ex As Exception
                    Throw New System.Exception("The file size is too big to be processed by this engine")
                End Try

                ' Dim an array of bytes large enough to hold the file’s contents.
                Dim fileData(bufferSize) As Byte
                Dim success As Boolean = False

                ' Your unmanaged pointer.
                Dim memoryPointer As IntPtr

                ' Read the contents of the file into the array.
                fileData = br.ReadBytes(bufferSize)

                ' Allocate some unmanaged memory for those bytes.
                memoryPointer = Marshal.AllocCoTaskMem(bufferSize)

                ' Copy the managed byte array into the unmanaged array.
                Marshal.Copy(fileData, 0, memoryPointer, bufferSize)

                ' Send the unmanaged bytes to the printer.
                success = SendBytesToPrinter(printerName, memoryPointer, bufferSize)

                ' Free the unmanaged memory that you allocated earlier.
                Marshal.FreeCoTaskMem(memoryPointer)

                Return success
            Catch ex As Exception
                Throw
            End Try

        End Function


        Public Function SendStringToPrinter(ByVal printerName As String, ByVal stringToPrint As String) As Boolean
            Try
                Dim memoryPointer As IntPtr
                Dim bufferSize As Int32
                Dim success As Boolean = False

                bufferSize = stringToPrint.Length()
                ' Assume that the printer is expecting ANSI text, and then convert
                ' the string to ANSI text.
                memoryPointer = Marshal.StringToCoTaskMemAnsi(stringToPrint)

                ' Send the converted ANSI string to the printer.
                success = SendBytesToPrinter(printerName, memoryPointer, bufferSize)
                Marshal.FreeCoTaskMem(memoryPointer)

                Return success
            Catch ex As Exception
                Throw
            End Try
        End Function

    End Class

    Friend Structure DOCINFOW
        <MarshalAs(UnmanagedType.LPWStr)> Public DocumentName As String
        <MarshalAs(UnmanagedType.LPWStr)> Public OutputFile As String
        <MarshalAs(UnmanagedType.LPWStr)> Public PrinterDataType As String
    End Structure

End Namespace
