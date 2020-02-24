Public Class jogo
    Public l As Boolean = True
    Public f, fd, fa, fo, np, po As Integer
    Public df(6), pobtn(71) As Object

    Private Sub txtpo_TextChanged(sender As Object, e As EventArgs) Handles txtpo.TextChanged

        po = Int(txtpo.Text)
        lblt.Text = po
        For v = 0 To 71
            pobtn(v).Enabled = False
            pobtn(v).Visible = False
        Next


    End Sub

    Sub Inicio()
        For v = 0 To 5
            pobtn(6 * f - v).Visible = True
            pobtn(6 * f - v).Enabled = True

        Next
        f = 0
    End Sub

    Private Sub txtf_TextChanged(sender As Object, e As EventArgs) Handles txtf.TextChanged
        Dim f As Integer
        f = txtf.Text

    End Sub

    Sub Stops()
        pobtn(po + 6 * f).Visible = True
        pobtn(po + 6 * f).Enabled = True
        'Proximos da origem'
        Dim poa As Integer
        poa = po - 6 * f
        If poa < 0 Then
            poa = 0
        End If
        pobtn(poa).Visible = True
        pobtn(poa).Enabled = True
        'Para traz'
        pobtn((po - 1 + 6 * 6) - 6 * (f - 1)).Visible = True
        pobtn((po - 1 + 6 * 6) - 6 * (f - 1)).Enabled = True
        f = 0
    End Sub

    Sub norm()
        Dim stps As Boolean = False
        Dim poa, pod, vv, v As Integer
        While stps = False Or vv <> f
            lblt.Text = "pod"
            For vv = 0 To f
                If pod = 0 Then
                    stps = True

                ElseIf (30 < pod & pod < 37) = True Then
                    stps = True

                Else
                    pod = po + 6
                End If

            Next

        End While
        If stps = False Then
            pobtn(pod).Enabled = True
            pobtn(pod).Visible = True
        End If
        stps = False
        While stps = False Or v <> f
            For v = 0 To f
                If poa = 0 Then
                    stps = True

                ElseIf poa < 37 And poa > 30 Then
                    stps = True

                Else
                    poa = po - 6
                End If

            Next
        End While
        If stps = False Then
            pobtn(poa).Enabled = True
            pobtn(poa).Visible = True
        End If


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrpos.Tick

    End Sub


    'DADO'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnd.Click
        If l = True Then
            tmrd.Enabled = True
            l = False
        ElseIf l = False Then

            tmrd.Enabled = False
            l = True
            If po = 0 Then
                lblt.Text = "inicio"
                Inicio()

            ElseIf 30 < po And po < 37 Then 'alguma merda errada aqui
                lblt.Text = "stops"
                Stops()
            Else
                lblt.Text = "norm"
                norm()
            End If


        End If
    End Sub

    'DADO'
    Private Sub tmrd_Tick(sender As Object, e As EventArgs) Handles tmrd.Tick
        f = Int(Rnd() * 6) + 1
        btnd.BackgroundImage = df(f)


    End Sub



    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'IMAGENS'
        df(1) = tpt1.My.Resources.Resources.d1
        df(2) = tpt1.My.Resources.Resources.d2
        df(3) = tpt1.My.Resources.Resources.d3
        df(4) = tpt1.My.Resources.Resources.d4
        df(5) = tpt1.My.Resources.Resources.d5
        df(6) = tpt1.My.Resources.Resources.d6
        'POSIÇÕES'
        pobtn(0) = btn0 'Stops'
        pobtn(1) = btn1
        pobtn(2) = btn2
        pobtn(3) = btn3
        pobtn(4) = btn4
        pobtn(5) = btn5
        pobtn(6) = btn6 '0´s po'
        pobtn(7) = btn7
        pobtn(8) = btn8
        pobtn(9) = btn9
        pobtn(10) = btn10
        pobtn(11) = btn11
        pobtn(12) = btn12 '0´s po'
        pobtn(13) = btn13
        pobtn(14) = btn14
        pobtn(15) = btn15
        pobtn(16) = btn16
        pobtn(17) = btn17
        pobtn(18) = btn18 '0´s po'
        pobtn(19) = btn19
        pobtn(20) = btn20
        pobtn(21) = btn21
        pobtn(22) = btn22
        pobtn(23) = btn23
        pobtn(24) = btn24 '0´s po'
        pobtn(25) = btn25
        pobtn(26) = btn26
        pobtn(27) = btn27
        pobtn(28) = btn28
        pobtn(29) = btn29
        pobtn(30) = btn30 '0´s po'
        pobtn(31) = btn31
        pobtn(32) = btn32
        pobtn(33) = btn33
        pobtn(34) = btn34
        pobtn(35) = btn35
        pobtn(36) = btn36
        pobtn(37) = btn37
        pobtn(38) = btn38
        pobtn(39) = btn39
        pobtn(40) = btn40
        pobtn(41) = btn41
        pobtn(42) = btn42
        pobtn(43) = btn43
        pobtn(44) = btn44
        pobtn(45) = btn45
        pobtn(46) = btn46
        pobtn(47) = btn47
        pobtn(48) = btn48
        pobtn(49) = btn49
        pobtn(50) = btn50
        pobtn(51) = btn51
        pobtn(52) = btn52
        pobtn(53) = btn53
        pobtn(54) = btn54
        pobtn(55) = btn55
        pobtn(56) = btn56
        pobtn(57) = btn57
        pobtn(58) = btn58
        pobtn(59) = btn59
        pobtn(60) = btn60
        pobtn(61) = btn61
        pobtn(62) = btn62
        pobtn(63) = btn63
        pobtn(64) = btn64
        pobtn(65) = btn65
        pobtn(66) = btn66
        pobtn(67) = btn67
        pobtn(68) = btn68
        pobtn(69) = btn69
        pobtn(70) = btn70
        pobtn(71) = btn71

        For v = 0 To 71
            pobtn(v).Enabled = False
            pobtn(v).Visible = False
        Next




    End Sub
End Class

