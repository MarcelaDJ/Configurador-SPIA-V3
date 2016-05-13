'Imports System
Imports System.IO.Ports
Imports System.Configuration
Public Class Form1

    Dim Strbufferout As String
    Dim Strbufferin As String
    Dim claro As String
    Dim operador As String
    Dim apagado As String
    Dim panico, led As String
    Dim tiempo, distancia As String
    Dim i, j, k As Integer
    Dim TestLen As Integer
    Dim tramaspia, apatxt, pantxt, timetxt, disttxt As String

    Delegate Sub SetTextCallback(ByVal text As String)
    Dim DataIn As String = String.Empty

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Strbufferout = ""
        Strbufferin = ""
        conectar.Enabled = False
        enviardato.Enabled = False
        bufferout.Visible = False
        txttramarecibida.Visible = True

    End Sub

    Private Sub enviardato_Click(sender As Object, e As EventArgs) Handles enviardato.Click
        Strbufferout = union_datos()
        sppuertos.Write(Strbufferout)
        btnclaro.Enabled = True
        btntigo.Enabled = True
        btnmovistar.Enabled = True
        btnfinalizarpanico.Enabled = True
        btnapnmanual.Enabled = True
        btnapagado.Enabled = True
        btnencender.Enabled = True
        sppuertos.DiscardOutBuffer()
        txtapnmanual.Text = Nothing
        txtlinea.Text = Nothing
        txtclave.Text = Nothing
        btnonled.Enabled = True
        btnoffled.Enabled = True
        Form2.Show()
        Timer2.Start()
        bufferin.Clear()

    End Sub

    Private Sub determinarconecxion_Click(sender As Object, e As EventArgs) Handles determinarconecxion.Click
        puertos.Items.Clear()

        For Each PuertoDisponible As String In My.Computer.Ports.SerialPortNames

            puertos.Items.Add(PuertoDisponible)
        Next

        If puertos.Items.Count > 0 Then
            puertos.Text = puertos.Items(0)
            MsgBox("Seleccione el puerto", MsgBoxStyle.Information)
            conectar.Enabled = True
        Else
            MessageBox.Show("Ningun puerto encontrado")
            conectar.Enabled = False
            enviardato.Enabled = False
            puertos.Items.Clear()
            puertos.Text = ("                             ")
        End If

    End Sub

    Private Sub conectar_Click(sender As Object, e As EventArgs) Handles conectar.Click
        If conectar.Text = "Conectar" Then
            sppuertos.PortName = puertos.Text
            conectar.Text = "Desconectar"
            enviardato.Enabled = True
            sppuertos.Open()
            Timer1.Enabled = True
        ElseIf conectar.Text = "Desconectar" Then
            conectar.Text = "Conectar"
            enviardato.Enabled = False
            sppuertos.Close()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Strbufferin = Me.sppuertos.ReadExisting
        '  If Strbufferin <> "" Then
        ' tramaspia = Strbufferin
        stringdesdespia()
        '  End If

    End Sub
    Private Sub PtoSerial_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles sppuertos.DataReceived

        DataIn = Me.sppuertos.ReadExisting
        'If DataIn <> String.Empty Then
        If DataIn <> "" Then
            SetText(DataIn)
        End If

    End Sub

    ' Recepcion del dato del puerto serie
    Private Sub SetText(ByVal text As String)
        If Me.txttramarecibida.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {text})
        Else
            Me.txttramarecibida.Text = txttramarecibida.Text + text
        End If
    End Sub


    Private Sub btnclaro_Click(sender As Object, e As EventArgs) Handles btnclaro.Click
        btnclaro.Enabled = False
        claro = "claro"
    End Sub

    Private Sub txtpin_TextChanged(sender As Object, e As EventArgs) Handles txtpin.TextChanged
    End Sub

    Private Sub btntigo_Click(sender As Object, e As EventArgs) Handles btntigo.Click
        btntigo.Enabled = False
    End Sub

    Private Sub btnmovistar_Click(sender As Object, e As EventArgs) Handles btnmovistar.Click
        btnmovistar.Enabled = False
    End Sub

    Private Sub btnapagado_Click(sender As Object, e As EventArgs) Handles btnapagado.Click

        If btnapagado.Text = "Apagar" Then
            btnapagado.Enabled = False
            ' btnapagado.Text = "Encender"
            apagado = "1"
            ' ElseIf btnapagado.Text = "Encender" Then
            '   btnapagado.Text = "Apagar"
            '     apagado = "0"
        End If
    End Sub

    Private Sub btnfinalizarpanico_Click(sender As Object, e As EventArgs) Handles btnfinalizarpanico.Click
        btnfinalizarpanico.Enabled = False
        If btnfinalizarpanico.Enabled = False Then
            panico = "1"
        End If
    End Sub


    Public Function seleccionar_operador() As String
        If btnclaro.Enabled = False Then
            If btnmovistar.Enabled = True Then
                If btntigo.Enabled = True Then
                    If btnapnmanual.Enabled = True Then
                        operador = "claro                     "
                        txtlinea.Text = "%"
                        txtclave.Text = "%"
                    End If
                End If
            End If

        ElseIf btntigo.Enabled = False Then
            If btnclaro.Enabled = True Then
                If btnmovistar.Enabled = True Then
                    If btnapnmanual.Enabled = True Then
                        operador = "tigo                      "
                        txtlinea.Text = "%"
                        txtclave.Text = "%"
                    End If
                End If
            End If

        ElseIf btnapnmanual.Enabled = False Then
            If btnclaro.Enabled = True Then
                If btnmovistar.Enabled = True Then
                    If btntigo.Enabled = True Then
                        operador = espacios_apn() 'apn variable con 26 digitos
                        txtlinea.Text = "%"
                        txtclave.Text = "%"
                    End If
                End If
            End If
        ElseIf btnclaro.Enabled = True Then
            If btnmovistar.Enabled = False Then
                If btntigo.Enabled = True Then
                    If btnapnmanual.Enabled = True Then
                        operador = "movistar                  " 'linea es una variable de 13 digitos clave 4 digitos
                        If (txtlinea.Text = "") And (txtclave.Text = "") Then
                            MsgBox("Introduzca linea y clave", MsgBoxStyle.Critical)
                        End If
                        txtlinea.Text = "TL_" + txtlinea.Text
                    End If
                End If
            End If
        End If
        Return operador
    End Function

    Private Sub cmbdistancia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdistancia.SelectedIndexChanged
        If cmbdistancia.Text = "500" Then
            distancia = "1"
        ElseIf cmbdistancia.Text = "1000" Then
            distancia = "2"
        ElseIf cmbdistancia.Text = "1500" Then
            distancia = "3"
        ElseIf cmbdistancia.Text = "2000" Then
            distancia = "4"
        End If
    End Sub

    Private Sub bufferout_TextChanged(sender As Object, e As EventArgs) Handles bufferout.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txttramarecibida.TextChanged
        txttramarecibida.SelectionStart = Len(txttramarecibida.Text)
        txttramarecibida.ScrollToCaret()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnencender.Click
        btnencender.Enabled = False
        If btnencender.Enabled = False Then
            apagado = "0"
        End If
    End Sub

    Private Sub txtlinea_TextChanged(sender As Object, e As EventArgs) Handles txtlinea.TextChanged

    End Sub

    Private Sub btnoffled_Click(sender As Object, e As EventArgs) Handles btnoffled.Click
        btnoffled.Enabled = False
        If btnoffled.Enabled = False Then
            led = "1"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Form2.Visible = True Then
            Form2.Hide()
            Timer2.Stop()
            MsgBox("Se ha producido un error por favor intente de nuevo", MsgBoxStyle.Critical)
        Else
            Timer2.Stop()
        End If
    End Sub

    Private Sub btnlimpiarlog_Click(sender As Object, e As EventArgs) Handles btnlimpiarlog.Click
        btnlimpiarlog.Enabled = False
        If btnlimpiarlog.Enabled = False Then
            txttramarecibida.Clear()
        End If
        btnlimpiarlog.Enabled = True
    End Sub

    Private Sub btnonled_Click(sender As Object, e As EventArgs) Handles btnonled.Click
        btnonled.Enabled = False
        If btnonled.Enabled = False Then
            led = "0"
        End If
    End Sub

    Private Sub bufferin_TextChanged(sender As Object, e As EventArgs) Handles bufferin.TextChanged

    End Sub

    Private Sub btnapnmanual_Click(sender As Object, e As EventArgs) Handles btnapnmanual.Click
        btnapnmanual.Enabled = False
    End Sub

    Private Sub cmbtiempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtiempo.SelectedIndexChanged
        If cmbtiempo.Text = "30" Then
            tiempo = "1"
        ElseIf cmbtiempo.Text = "60" Then
            tiempo = "2"
        ElseIf cmbtiempo.Text = "120" Then
            tiempo = "3"
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Function espacios_apn() As String
        TestLen = Len(txtapnmanual.Text)
        If TestLen < 26 Then
            j = TestLen
            For j = TestLen To 25
                txtapnmanual.Text = txtapnmanual.Text + " "
            Next
        ElseIf TestLen = 26 Then
            Return txtapnmanual.Text
        End If
        Return txtapnmanual.Text
    End Function
    Public Function union_datos() As String
        If (txtpin.Text = "") Then
            txtpin.Text = "%"
        End If
        If (cmbdistancia.Text = "") Then
            distancia = "%"
        End If
        If (cmbtiempo.Text = "") Then
            tiempo = "%"
        End If
        If (btnfinalizarpanico.Enabled = True) Then
            panico = "%"
        End If
        If (btnapagado.Enabled = True) And (btnencender.Enabled = True) Then
            apagado = "%"
        End If
        If (btnapagado.Enabled = False) And (btnencender.Enabled = False) Then
            apagado = "%"
        End If
        If btnapnmanual.Enabled = True Then
            If btnclaro.Enabled = True Then
                If btnmovistar.Enabled = True Then
                    If btntigo.Enabled = True Then
                        operador = "%"
                        txtlinea.Text = "%"
                        txtclave.Text = "%"
                    End If
                End If
            End If
        End If
        If (btnonled.Enabled = False) And (btnoffled.Enabled = False) Then
            led = "%"
        End If
        If (btnonled.Enabled = True) And (btnoffled.Enabled = True) Then
            led = "%"
        End If
        bufferout.Text = "&," + txtpin.Text + "," + seleccionar_operador() + "," + distancia + "," + tiempo + "," + apagado + "," + panico + "," + txtlinea.Text + "," + txtclave.Text + "," + led + ",#" + sppuertos.NewLine 'led + sppuertos.NewLine

        Return bufferout.Text
    End Function

    Public Function stringdesdespia() As String
        Dim trozos() As String
        'trozos = tramaspia.Split(",")  ' original 
        'trozos = txttramarecibida.Text.Split(",")
        'trozos = DataIn.Split(",")
        trozos = Split(DataIn, ",")
        If trozos(0) = "&" Then
            If trozos(3) = "1" Then
                disttxt = "500"
            ElseIf trozos(3) = "2" Then
                disttxt = "1000"
            ElseIf trozos(3) = "3" Then
                disttxt = "1500"
            ElseIf trozos(3) = "4" Then
                disttxt = "2000"
            ElseIf trozos(3) = "?" Then
                disttxt = "No datos"
            End If
            If trozos(4) = "1" Then
                timetxt = "30"
            ElseIf trozos(4) = "2" Then
                timetxt = "60"
            ElseIf trozos(4) = "3" Then
                timetxt = "120"
            Else
            End If
            If trozos(6) = "0" Then
                trozos(6) = "Panico finalizado"
            ElseIf trozos(6) = "1" Then
                trozos(6) = "En panico"
            ElseIf trozos(6) = "" Then
                trozos(6) = "Panico no pulsado"
            ElseIf trozos(6) = "?" Then
                trozos(6) = "Funcion no implementada"
            End If
            If trozos(9) = "1" Then
                trozos(9) = "Led deshabilitado"
            ElseIf trozos(9) = "0" Then
                trozos(9) = "Led habilitado"
            End If
            If trozos(11) = "00" Then
                trozos(11) = "Sin GPS"
            End If
            Form2.Hide()
            bufferin.Text = trozos(1) + vbNewLine + trozos(2) + vbNewLine + disttxt + vbNewLine + timetxt + vbNewLine + trozos(6) + vbNewLine + trozos(7) + vbNewLine + trozos(8) + vbNewLine + trozos(9) + vbNewLine + trozos(10) + vbNewLine + trozos(11)
        Else
            'Exit Function
        End If
        Return Nothing
    End Function
End Class

