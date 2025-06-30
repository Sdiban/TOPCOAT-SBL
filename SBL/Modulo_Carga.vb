Imports System.Data.SqlClient
Module Modulo_Carga
    Dim ArVentanas(40) As Object
    Dim icnt As Integer
    Public Sub cargaComuna(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Optional Llave As String = "", Optional Llave1 As String = "", Optional szFiltro As String = "")
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "SELECT id_comuna,comuna "
        sql += "FROM comuna "
        sql += "WHERE id_ciudad = '" & Llave & "' "
        If Llave1 <> "" Then
            sql += "AND id_comuna = '" & Llave1 & "' "
        End If
        Dim dr As SqlDataReader = execQuery(sql, csql)
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        While dr.Read
            cbox.Items.Add(dr("comuna"))
            cbox.Items(i).Key = dr("id_comuna")
            If szFiltro = dr(0) Then
                Posicion = i
            End If
            i += 1
        End While
        dr.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub
    Public Sub CargaFamilias(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Optional Llave As String = "", Optional Llave1 As String = "", Optional szFiltro As String = "")
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "SELECT id_familia,descripcion "
        sql += "FROM familias "
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cbox.Items.Add(dR("descripcion"))
            cbox.Items(i).Key = dR("id_familia")
            If szFiltro = Trim(CStr(dR(0))) Then
                Posicion = i
            End If
            i += 1
        End While
        dR.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub
    Public Sub CargaUnidadMedida(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Optional Llave As String = "", Optional Llave1 As String = "", Optional szFiltro As String = "")
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "SELECT id_unidadmedida,desc_unidadmedida "
        sql += "FROM unidad_medida "
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cbox.Items.Add(dR("desc_unidadmedida"))
            cbox.Items(i).Key = dR("id_unidadmedida")
            If szFiltro = dR(0) Then
                Posicion = i
            End If
            i += 1
        End While
        dR.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub
    Public Sub CargaEcommerce(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Optional szFiltro As Integer = 0)
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "SELECT id_ecommerce"
        sql += ",ecommerce "
        sql += "FROM ecommerce"
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cbox.Items.Add(dR("ecommerce"))
            cbox.Items(i).Key = dR("id_ecommerce")
            If szFiltro = dR("id_ecommerce") Then
                Posicion = i
            End If
            i += 1
        End While
        dR.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub
    Public Sub CargaEstados(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Optional Llave As String = "", Optional Llave1 As String = "", Optional szFiltro As String = "")
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "SELECT id_estado,desc_estado "
        sql += "FROM estados "
        If Llave <> "" Then
            sql += "WHERE id_tabla = '" & Llave & "' "
            If Llave1 <> "" Then
                sql += "AND id_estado = '" & Llave1 & "' "
            End If
        End If
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            If Llave <> "SE" Then
                cbox.Items.Add(dR("desc_estado"))
                cbox.Items(i).Key = dR("id_estado")
                If szFiltro = dR("id_estado") Then
                    Posicion = i
                End If
                i += 1
            Else
                If dR("id_estado") <> "DES" Then
                    cbox.Items.Add(dR("desc_estado"))
                    cbox.Items(i).Key = dR("id_estado")
                    If szFiltro = dR("id_estado") Then
                        Posicion = i
                    End If
                    i += 1
                End If
            End If
        End While
        dR.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub
    Public Sub CargaUsaSerie(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox)
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        cbox.Items.Add("SI")
        cbox.Items.Add("NO")
    End Sub
    Public Sub CargaUsuarios(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Optional Llave As String = "", Optional szFiltro As String = "")
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "SELECT id_usuario, nombre_usuario "
        sql += "FROM usuarios_pc "
        sql += "WHERE estado_usuario = 'ACT' "
        If Llave <> "" Then
            sql += "AND id_usuario = '" & Llave & "' "
        End If
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cbox.Items.Add(dR("nombre_usuario"))
            cbox.Items(i).Key = dR("id_usuario")
            If szFiltro = dR("id_usuario") Then
                Posicion = i
            End If
            i += 1
        End While
        dR.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub
    Public Sub CargaDctoTipo(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Optional Llave As String = "", Optional szFiltro As String = "")
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "SELECT tipo,descripcion "
        sql += "FROM documentos_tipo "
        If Llave <> "" Then
            sql += "WHERE tipo = '" & Llave & "' "
        End If
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cbox.Items.Add(dR("descripcion"))
            cbox.Items(i).Key = dR("tipo")
            If szFiltro = dR("tipo") Then
                Posicion = i
            End If
            i += 1
        End While
        dR.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub
    Public Sub CargaTipoCompra(ByVal cbox As Klik.Windows.Forms.v1.EntryLib.ELComboBox, Optional Llave As String = "", Optional szFiltro As String = "")
        Dim i As Integer = 1
        Dim Posicion As Integer = 0
        cbox.Items.Clear()
        cbox.Items.Add("")
        cbox.Items(0).Key = -1
        sql = "SELECT tipo,descripcion "
        sql += "FROM tipo_compra "
        If Llave <> "" Then
            sql += "WHERE tipo = '" & Llave & "' "
        End If
        Dim dR As SqlDataReader = execQuery(sql, csql)
        While dR.Read
            cbox.Items.Add(dR("descripcion"))
            cbox.Items(i).Key = dR("tipo")
            If szFiltro = dR("tipo") Then
                Posicion = i
            End If
            i += 1
        End While
        dR.Close()
        If Posicion > 0 Then
            cbox.SelectedIndex = Posicion
        End If
    End Sub
End Module
