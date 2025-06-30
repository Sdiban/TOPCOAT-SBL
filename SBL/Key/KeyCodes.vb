Option Strict Off
Option Explicit On
Imports System.Security.Cryptography
Imports System.Text

Module KeyCode

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function


    Public Function GenKeyString(ByVal UserName As Object, ByRef ProdName As String, ByRef F_Code As Integer) As String
        Dim StubStr As Object
        Dim RC2 As Object
        Dim RC1 As Object
        Dim RawChk As Object
        Dim ChrV2 As Object
        Dim ChrV1 As Object
        Dim KeyLow2 As Object
        Dim KeyLow1 As Object

        Dim TempStr As String
        Dim KeyStr As String
        Dim KeyVal As String
        Dim CodeVal As Integer
        Dim CodeLow As Byte
        Dim CodeHigh As Byte
        Dim KeyLowV1 As Byte
        Dim KeyLowV2 As Byte

        ' Make sure we're not case-sensitive since that is a pain for end users

        TempStr = LCase(UserName) & LCase(ProdName)
        KeyStr = DigestStrToHexStr(TempStr)
        KeyVal = HexStrToBinStr(KeyStr)

        ' Mask off low order 16 bits FROM F_Code
        CodeVal = F_Code And &HFFFF
        CodeLow = CodeVal And &HFF
        CodeHigh = ((CLng(CodeVal And &HFF00) / 256) And &HFF)

        KeyLow1 = Mid(KeyVal, Len(KeyVal), 1)
        KeyLow2 = Mid(KeyVal, Len(KeyVal) - 1, 1)

        KeyLowV1 = Asc(KeyLow1)
        KeyLowV2 = Asc(KeyLow2)

        KeyLowV1 = (KeyLowV1 Xor CodeLow)
        KeyLowV2 = (KeyLowV2 Xor CodeHigh)

        ChrV1 = Chr(KeyLowV1)
        ChrV2 = Chr(KeyLowV2)

        ' Cut original first 2 bytes FROM KeyVal string
        KeyVal = Mid(KeyVal, 1, Len(KeyVal) - 2)

        KeyVal = KeyVal & ChrV2 & ChrV1
        'KeyVal = KeyVal & ChrV1

        ' Now we get sneaky and modify the KeyVal by replacing the first 2 bytes
        ' of KeyVal with the first and last bytes of the MD5 of KeyVal minus first 2 bytes

        KeyVal = Mid(KeyVal, 3, Len(KeyVal) - 2)

        RawChk = DigestStrToHexStr(KeyVal)

        RC1 = Mid(RawChk, 1, 2)
        RC2 = Mid(RawChk, Len(RawChk) - 1, 2)

        StubStr = BinStrToHexStr(KeyVal)

        GenKeyString = RC1 & RC2 & StubStr

    End Function

    ' ValidateKeyCode() validates that a keycode is valid.
    ' Basically it is the inverse of GenKeyString()

    Public Function ValidateKeyCode(ByVal KeyCode As Object, ByRef UserName As Object, ByRef ProjName As String) As Boolean
        Dim ValidSig As Object
        Dim BinKeyCode As Object
        Dim ActiveBytes As String
        Dim LUNameHash As String
        Dim LUName As String
        Dim ValidKey As Boolean
        Dim KeyMD5 As String
        Dim KeySig As String

        ValidKey = False

        ' Key must be 32 bytes long - otherwise reject immediately

        If Len(KeyCode) = 32 Then
            BinKeyCode = HexStrToBinStr(KeyCode)
            ActiveBytes = Right(BinKeyCode, 14)
            KeyMD5 = DigestStrToHexStr(ActiveBytes)
            ValidSig = Left(KeyMD5, 2) & Right(KeyMD5, 2)
            KeySig = Left(KeyCode, 4)

            If KeySig = ValidSig Then
                ValidKey = True
            Else
                ValidKey = False
            End If

            If ValidKey Then
                LUName = LCase(UserName) & LCase(ProjName)
                LUNameHash = DigestStrToHexStr(LUName)

                ActiveBytes = Mid(KeyCode, 5, 24)
                LUNameHash = Mid(LUNameHash, 5, 24)

                If ActiveBytes = LUNameHash Then
                    ValidKey = True
                Else
                    ValidKey = False
                End If
            End If

        Else
            ValidKey = False
        End If

        ValidateKeyCode = ValidKey

    End Function


    ' ExtractKeyFBits() returns the bitmap originally passed as F_Code
    ' when a key is created with GenKeyString()
    ' Note: it will return zero (0) if an invalid keycode is passed or if
    '       username or projectname are not a match.

    Public Function ExtractKeyFBits(ByVal KeyCode As Object, ByRef UserName As Object, ByRef ProjName As String) As Object
        Dim LoCodePerm As Object
        Dim UHashPerm As Object
        Dim KCodedPerm As Object
        Dim UserHash As Object
        Dim PermVal As Integer
        Dim LUser As String
        Dim BinCodePerm As String
        Dim BinUHashPerm As String
        Dim HiCodePerm As Byte
        Dim HIUMask As Byte
        Dim LoUMask As Byte
        Dim HiPerm As Integer
        Dim LoPerm As Integer

        PermVal = 0

        If ValidateKeyCode(KeyCode, UserName, ProjName) Then

            'UPGRADE_WARNING: Couldn't resolve default property of object UserName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LUser = LCase(UserName) & LCase(ProjName)
            'UPGRADE_WARNING: Couldn't resolve default property of object UserHash. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            UserHash = DigestStrToHexStr(LUser)
            'UPGRADE_WARNING: Couldn't resolve default property of object KeyCode. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object KCodedPerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            KCodedPerm = Right(KeyCode, 4)
            'UPGRADE_WARNING: Couldn't resolve default property of object UserHash. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object UHashPerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            UHashPerm = Right(UserHash, 4)

            'UPGRADE_WARNING: Couldn't resolve default property of object KCodedPerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            BinCodePerm = HexStrToBinStr(KCodedPerm)
            'UPGRADE_WARNING: Couldn't resolve default property of object UHashPerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            BinUHashPerm = HexStrToBinStr(UHashPerm)

            HiCodePerm = Asc(Mid(BinCodePerm, 1, 1))
            'UPGRADE_WARNING: Couldn't resolve default property of object LoCodePerm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LoCodePerm = Asc(Mid(BinCodePerm, 2, 1))

            HIUMask = Asc(Mid(BinUHashPerm, 1, 1))
            LoUMask = Asc(Mid(BinUHashPerm, 2, 1))

            HiPerm = HiCodePerm Xor HIUMask
            LoPerm = LoCodePerm Xor LoUMask
            PermVal = (HiPerm * 256) Or LoPerm

        Else
            PermVal = 0
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object ExtractKeyFBits. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ExtractKeyFBits = PermVal

    End Function

    Public Function FormatKeyCode(ByVal StrIn As String, ByVal GrpLen As Integer) As String
        Dim StrLeftOver As Object
        Dim StrGroups As Object
        Dim StrLen As Integer
        Dim CurGrp As Integer
        Dim OutStr As String
        Dim GrpStr As String
        Dim GrpStart As Integer

        StrLen = Len(StrIn)

        'UPGRADE_WARNING: Couldn't resolve default property of object StrGroups. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrGroups = Int(StrLen / GrpLen)
        'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrLeftOver = StrLen Mod GrpLen

        OutStr = ""
        For CurGrp = 0 To (StrGroups - 1)
            GrpStart = (CurGrp * GrpLen) + 1
            GrpStr = Mid(StrIn, GrpStart, GrpLen)

            If CurGrp > 0 Then
                OutStr = OutStr & "-" & GrpStr
            Else
                OutStr = OutStr & GrpStr
            End If

        Next CurGrp

        ' Append a final group if any leftover charaters
        ' exist in StrIn

        'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If StrLeftOver > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object StrLeftOver. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            OutStr = OutStr & "-" & Right(StrIn, StrLeftOver)
        End If

        FormatKeyCode = OutStr
    End Function

    Public Function pcInfo() As String
        Dim szRet As String

        '        szRet = "computer name: " & System.Windows.Forms.SystemInformation.ComputerName & vbCrLf & _
        '                "Serial: " & SystemSerialNumber() & vbCrLf & "Os: " & My.Computer.Info.OSFullName & vbCrLf & "Plataform: " & _
        '                My.Computer.Info.OSPlatform & vbCrLf & "CpuId: " & CpuId()

        szRet = System.Windows.Forms.SystemInformation.ComputerName & My.Computer.Info.OSFullName & My.Computer.Info.OSPlatform & CpuId() & SystemSerialNumber()

        Return szRet
    End Function

    Private Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object =
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers =
            serial_numbers.Substring(2)

        Return serial_numbers
    End Function

    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" &
            "{impersonationLevel=impersonate}!\\" &
            computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("SELECT * FROM " &
            "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids =
            cpu_ids.Substring(2)

        Return cpu_ids
    End Function


    ' Helper for Base32 numbers
    Const B32Map As String = "0123456789ABCDEFGHJKLMNPRSTVWXYZ"


    ' General String Functions

    ' RemoveDashes() - Trivial function to DELETE "-" character FROM a string

    Public Function RemoveDashes(ByVal StrIn As String) As String
        RemoveDashes = Replace(StrIn, "-", "")
    End Function


    ' ShiftStrLeft() - Shift a string left by a number of bits

    Public Function ShiftStrLeft(ByVal StrIn As String, ByVal Bits As Integer) As String
        Dim StrBits As Object
        Dim StrLen As Object
        Dim CurPos As Integer = 0
        Dim WorkStr As String
        Dim RetStr As String = ""
        Dim CurByteVal As Byte
        Dim BitMask As Byte
        Dim InvMask As Byte
        Dim ShiftBits As Byte
        Dim WholeBytes As Integer
        Dim LeftPart As Byte
        Dim RightPart As Byte
        Dim PrevChar As Byte
        Dim TrimMask As Byte

        ' Figure out some metrics on our input string

        WholeBytes = Int(Bits / 8)
        ShiftBits = Bits Mod 8

        BitMask = 255 - (2 ^ (8 - ShiftBits) - 1)
        InvMask = Not (BitMask)
        TrimMask = (2 ^ ShiftBits) - 1

        CurPos = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object StrLen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrLen = Len(StrIn)
        'UPGRADE_WARNING: Couldn't resolve default property of object StrLen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object StrBits. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrBits = StrLen * 8
        WorkStr = StrIn

        ' Check we're not trying to shift more bits than
        ' we have in the string.

        'UPGRADE_WARNING: Couldn't resolve default property of object StrBits. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If (StrBits > Bits) Then
            ' First, shift string by whole bytes
            If (WholeBytes > 0) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object StrLen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                WorkStr = Right(WorkStr, StrLen - WholeBytes)

                ' Pad zero bytes to end of WorkStr to make length match

                For CurPos = 1 To WholeBytes
                    WorkStr = WorkStr & Chr(0)
                Next CurPos

                ' Ensure RetStr contains shifted string in case no other
                ' bitwise shifting is performed later

                RetStr = WorkStr
            End If

            ' Now handle the bitwise shift
            If (ShiftBits > 0) Then

                For CurPos = 1 To Len(WorkStr)
                    ' Read next character of input and mask it appropriately
                    CurByteVal = Asc(Mid(WorkStr, CurPos, 1))
                    LeftPart = (CurByteVal And BitMask) And &HFF
                    RightPart = (CurByteVal And InvMask) And &HFF

                    ' Shift the masked portions
                    LeftPart = Int(LeftPart / (2 ^ (8 - ShiftBits)))
                    RightPart = (RightPart * (2 ^ ShiftBits))

                    If CurPos = 1 Then
                        ' Put the non-discarded part into PrevChar for later use
                        PrevChar = (RightPart)
                        RetStr = ""
                    Else
                        ' Put carryover part into PrevChar and combine
                        ' the other bits with the carry FROM previous step
                        PrevChar = PrevChar Or LeftPart
                        RetStr = RetStr & Chr(PrevChar)
                        PrevChar = RightPart
                    End If

                Next CurPos

                ' Combine our final carry with last char of string and mask off
                PrevChar = (PrevChar Or (LeftPart And Not (TrimMask)))
                RetStr = RetStr & Chr(PrevChar)

            End If

        Else
            ' If we're trying to shift by more bits than
            ' input string, return an equal length string
            ' full of zeroes (null characters).

            'UPGRADE_WARNING: Couldn't resolve default property of object StrLen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            For CurPos = 1 To StrLen
                RetStr = RetStr & Chr(0)
            Next CurPos
        End If

        ShiftStrLeft = RetStr

    End Function

    ' ShiftStringRight() - Shift a string right a number of bits

    Public Function ShiftStrRight(ByVal StrIn As String, ByVal Bits As Integer) As String
        Dim StrBits As Object
        Dim StrLen As Object
        Dim CurPos As Integer
        Dim WorkStr As String
        Dim RetStr As String
        Dim CurByteVal As Byte
        Dim BitMask As Byte
        Dim InvMask As Byte
        Dim ShiftBits As Byte
        Dim WholeBytes As Integer
        Dim LeftPart As Byte
        Dim RightPart As Byte
        Dim Carry As Byte
        Dim TrimMask As Byte

        ' Calculate metrics on input

        WholeBytes = Int(Bits / 8)
        ShiftBits = Bits Mod 8

        BitMask = 255 - ((2 ^ ShiftBits) - 1)
        InvMask = Not (BitMask)
        TrimMask = (2 ^ ShiftBits) - 1

        CurPos = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object StrLen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrLen = Len(StrIn)
        'UPGRADE_WARNING: Couldn't resolve default property of object StrLen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object StrBits. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrBits = StrLen * 8

        ' Check we're not trying to shift more bits than
        ' we have in the string.
        WorkStr = StrIn

        RetStr = ""
        If (StrBits > Bits) Then

            ' First, shift string by whole bytes

            If (WholeBytes > 0) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object StrLen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                WorkStr = Left(WorkStr, StrLen - WholeBytes)

                ' Pad zero bytes to end of WorkStr

                For CurPos = 1 To WholeBytes
                    WorkStr = Chr(0) & WorkStr
                Next CurPos

                ' Ensure RetStr contains shifted string in case no other
                ' bitwise shifting later

                RetStr = WorkStr
            End If

            ' Now handle the bitwise shift
            If (ShiftBits > 0) Then

                RetStr = ""

                For CurPos = Len(WorkStr) To 1 Step -1

                    CurByteVal = Asc(Mid(WorkStr, CurPos, 1))

                    LeftPart = CurByteVal And BitMask
                    LeftPart = LeftPart / (2 ^ ShiftBits)

                    RightPart = CurByteVal And InvMask
                    RightPart = RightPart * (2 ^ (8 - ShiftBits))

                    If CurPos = Len(WorkStr) Then
                        Carry = LeftPart
                    Else
                        CurByteVal = RightPart Or Carry
                        Carry = LeftPart
                        RetStr = Chr(CurByteVal) & RetStr
                    End If

                Next CurPos

                RetStr = Chr(Carry) & RetStr

            End If

        Else
            ' If we're trying to shift by more bits than
            ' input string, return an equal length string
            ' full of zeroes.

            For CurPos = 1 To StrLen
                RetStr = RetStr & Chr(0)
            Next CurPos
        End If

        ShiftStrRight = RetStr

    End Function

    ' Base32Enc() - Takes a "binary" string and represents as a Base32 number
    ' Net result is an encoding WHERE each "character" represents 5 bits

    Public Function Base32Enc(ByVal StrIn As String) As String
        Dim StrChar As Object
        Dim StrGroups As Object
        Dim Mask32 As Byte
        Dim CurPos As Integer
        Dim CurVal As Byte
        Dim StrBits As Integer
        Dim BitsProc As Integer
        Dim WorkStr As String
        Dim RetStr As String
        Dim CurConv As String

        RetStr = ""
        WorkStr = StrIn
        StrBits = Len(StrIn) * 8
        'UPGRADE_WARNING: Couldn't resolve default property of object StrGroups. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrGroups = Int(StrBits / 5)

        'UPGRADE_WARNING: Couldn't resolve default property of object StrGroups. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If (StrBits Mod 5) <> 0 Then StrGroups = StrGroups + 1

        'UPGRADE_WARNING: Couldn't resolve default property of object StrChar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        StrChar = Len(StrIn)
        BitsProc = 0
        Mask32 = &H1F

        ' Work FROM back of string to front.
        ' and output the character representing each 5-bit group

        'UPGRADE_WARNING: Couldn't resolve default property of object StrGroups. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        For CurPos = 1 To StrGroups
            CurVal = Asc(Mid(WorkStr, Len(WorkStr), 1))
            CurVal = CLng(CurVal And Mask32) + 1
            CurConv = Mid(B32Map, CurVal, 1)
            WorkStr = ShiftStrRight(WorkStr, 5)
            RetStr = CurConv & RetStr
        Next CurPos

        Base32Enc = RetStr

    End Function

    ' Base32Dec() - Takes a string encoded with Base32Enc() and returns the
    ' original "binary" string it represents.

    Public Function Base32Dec(ByVal StrIn As String) As String
        Dim BaseMask As Object
        Dim BitsProc As Object
        Dim CurPos As Integer
        Dim CurVal As Byte
        Dim CurChr As String
        Dim RetStr As String
        Dim WorkStr As String
        Dim Carry As Byte
        Dim ThisVal As Byte
        Dim ThisChar As String
        Dim OutBytes As Integer
        Dim InBits As Integer

        ' Calculate metrics

        'UPGRADE_WARNING: Couldn't resolve default property of object BitsProc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        BitsProc = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object BaseMask. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        BaseMask = &H1F
        Carry = 0
        WorkStr = StrIn

        InBits = Len(StrIn) * 5
        OutBytes = Int(InBits / 8)

        ' Setup a string of zero bytes to push VALUES into later

        RetStr = ""
        For CurPos = 1 To OutBytes
            RetStr = RetStr & Chr(0)
        Next CurPos

        ' Convert input string into binary representation

        For CurPos = 1 To Len(StrIn)

            ' Derive 5-bit value of current char in StrIn
            CurChr = Mid(WorkStr, CurPos, 1)
            CurVal = InStr(1, B32Map, CurChr)
            CurVal = CurVal - 1

            ' Now, shift RetStr left 5 bits and pop last char off
            RetStr = ShiftStrLeft(RetStr, 5)
            ThisChar = Mid(RetStr, Len(RetStr), 1)
            RetStr = Left(RetStr, Len(RetStr) - 1)

            ' Now, OR our CurChr with the popped value
            ' and push result back to end of string
            ThisVal = Asc(ThisChar)
            ThisVal = ThisVal Or CurVal
            ThisChar = Chr(ThisVal)
            RetStr = RetStr & ThisChar
        Next CurPos

        Base32Dec = RetStr

    End Function

    ' HexStrToBinStr() - Convert a hexadecimal string into a binary representation

    Public Function HexStrToBinStr(ByVal StrIn As String) As String
        Dim StrOut As String
        Dim Ch As Integer
        Dim HexByte As String
        Dim ByteVal As Integer
        Dim ByteCh As String

        StrOut = ""

        For Ch = 1 To Len(StrIn) Step 2
            HexByte = Mid(StrIn, Ch, 2)
            ByteVal = Val("&H" & HexByte)
            ByteCh = Chr(ByteVal)
            StrOut = StrOut & ByteCh
        Next Ch

        HexStrToBinStr = StrOut

    End Function

    ' BinStrToHexStr() - Convert a binary string to a hexadecimal representation

    Public Function BinStrToHexStr(ByVal StrIn As String) As String
        Dim StrOut As String
        Dim Ch As Integer
        Dim HexByte As String
        Dim HexChr As String

        StrOut = ""

        For Ch = 1 To Len(StrIn)
            HexByte = Mid(StrIn, Ch, 1)
            HexChr = Hex(Asc(HexByte))
            If Len(HexChr) = 1 Then HexChr = "0" & HexChr
            StrOut = StrOut & HexChr
        Next Ch

        BinStrToHexStr = StrOut

    End Function
End Module