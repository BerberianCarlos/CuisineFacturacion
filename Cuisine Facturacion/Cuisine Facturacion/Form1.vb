Imports System.Data.Odbc
Public Class FormRecibo
    Dim pregunta As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar()

        x = 0
        sql = "Select nombre from proveedor"
        Call Proc(sql)
        While rs.Read() = True
            CBprovedor.Items.Add(rs(0))
        End While

        x = 0
        sql = "Select nombre from pedidos"
        Call Proc(sql)
        While rs.Read() = True
            ListPedidos.Items.Add(rs(0))
        End While

        x = 0
        sql = "Select tipo from forma_pago"
        Call Proc(sql)
        While rs.Read() = True
            CBFdp.Items.Add(rs(0))
        End While


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idpedido As Integer
        Dim idProveedor As Integer
        Dim idFormaPago As Integer

        x = 0
        sql = "Select idPedidos from pedidos where nombre ='" & ListPedidos.SelectedItem & "'"
        Call Proc(sql)
        While rs.Read() = True
            idpedido = rs(0)
        End While
        x = 0
        sql = "Select idProveedor from proveedor where nombre ='" & CBprovedor.SelectedItem & "'"
        Call Proc(sql)
        While rs.Read() = True
            idProveedor = rs(0)
        End While
        x = 0
        sql = "Select idForma_pago from forma_pago where tipo ='" & CBFdp.SelectedItem & "'"
        Call Proc(sql)
        While rs.Read() = True
            idFormaPago = rs(0)
        End While

        sql = "INSERT INTO `recibo` (`idrecibo`, `fecha_recibo`, `idForma_pago`, `total`, `idPedido`, `proveedor_idproveedor`) VALUES (NULL, NOW(), '" & idFormaPago & "', '" & TxtbTotal.Text & "', '" & idpedido & "', '" & idProveedor & "')"
        Call Proc(sql)
        pregunta = MsgBox("El recibo se generó correctamente, desea enviar el remito al proveedor?", vbYesNo)
        If pregunta = vbNo Then
            MsgBox("No se enviara el remito")
        ElseIf pregunta = vbYes Then

            x = 0
            sql = "INSERT INTO remito VALUES (NULL, (SELECT MAX(idRecibo) FROM recibo))"
            Call Proc(sql)
            MsgBox("Se envió el remito al proveedor. Muchas gracias")
        End If


        x = 0

    End Sub

    Private Sub ListPedidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPedidos.SelectedIndexChanged
        x = 0
        sql = "Select precio from pedidos where nombre= '" & ListPedidos.SelectedItem & "'"
        Call Proc(sql)
        While rs.Read() = True
            TxtbTotal.Text = rs(0)
        End While

    End Sub
End Class
