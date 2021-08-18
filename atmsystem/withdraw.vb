Imports System.Data.SqlClient
Public Class withdraw
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

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If con.State = 1 Then con.Close()
        Str = "select * from tbl_mst where acc_no='" & txtacc.Text & "'"
        ds = fetchdata(Str)

        If ds.Tables(0).Rows.Count Then
            Dim num1, num2, tot As Integer
            num1 = ds.Tables(0).Rows(0).Item("bal")
            num2 = txtamount.Text

            If num2 > 25000 Then
                MsgBox("You can Only Withdraw Php 25,000")
            ElseIf num2 < 200 Then
                MsgBox(" Mininum withdrawal is 200")
            ElseIf num1 < num2 Then
                MsgBox(" Insuffiecient balance")
            Else
                MsgBox("Your Current Balance is " & num1 & " ", MsgBoxStyle.Information)
                tot = num1 - num2
                str = "Update tbl_mst set bal=" & tot & " where acc_no='" & txtacc.Text & "'"
                cnt = Insertdata(str)
                MsgBox("Withdraw " & num2 & " Successfully ", MsgBoxStyle.Information)
                MsgBox("Your Balance is " & tot & " ", MsgBoxStyle.Information)
                txtamount.Clear()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        mainmenu.Show()
    End Sub
End Class