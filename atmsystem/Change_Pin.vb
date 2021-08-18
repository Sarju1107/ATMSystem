Imports System.Data.SqlClient
Public Class Change_Pin
    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\MAYANK PATEL\documents\visual studio 2010\Projects\atmsystem\atmsystem\Database.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim cnt As Integer
    Dim tbl As New DataTable
    Dim bal As String


    Public Function fetchdata(ByVal str As String) As DataSet
        If con.State = 1 Then con.Close()
        con.Open()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()
    End Function

    Public Function Insertdata(ByVal str As String) As String
        If con.State = 1 Then con.Close()
        con.Open()
        cmd = New SqlCommand(str, con)
        cnt = cmd.ExecuteNonQuery()
        If con.State = 1 Then con.Close()
        Return cnt
    End Function
    Private Sub btnchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchange.Click
        If con.State = 1 Then con.Close()
        If txtoldpin.Text = Module1.pin Then
            If txtnewpin.Text = txtcnew.Text Then
                Try
                    str = "update tbl_mst set pin='" & txtnewpin.Text & "'where fname='" & Module1.user & "'"
                    cnt = Insertdata(str)
                    If cnt >= 1 Then
                        MsgBox("Pin Changed Successfully")
                        txtcnew.Clear()
                        txtnewpin.Focus()
                        txtoldpin.Clear()
                        Module1.user = ""
                        Me.Close()
                        mainmenu.Show()
                    Else
                        MsgBox("Failed")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Old Pin Not Matched", MsgBoxStyle.Critical)
        End If
    End Sub
End Class