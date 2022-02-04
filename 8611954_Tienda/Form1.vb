Imports System.Math
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim parroz As Double
        Dim pfrijol As Double
        Dim pazucar As Double
        Dim pparcial As Double
        Dim piva As Double
        Dim pantesiva As Double
        Dim descuento As Double
        Dim final As Double

        parroz = TextBox1.Text * 2
        pfrijol = TextBox2.Text * 1.75
        pazucar = TextBox3.Text * 2.5
        pantesiva = parroz + pfrijol + pazucar

        piva = pantesiva * 0.12
        pparcial = piva + pantesiva
        descuento = pparcial * 0.025
        final = pparcial - descuento

        TextBox4.Text = Str(Round(pantesiva, 2))
        TextBox5.Text = Str(Round(piva, 2))
        TextBox6.Text = Str(Round(pparcial, 2))
        TextBox7.Text = Str(Round(descuento, 2))
        TextBox8.Text = Str(Round(final, 2))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()

        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
