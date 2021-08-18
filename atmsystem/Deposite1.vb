Imports System.Data.SqlClient
Public Class Deposite1
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
   

   

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Hide()
        mainmenu.Show()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If con.State = 1 Then con.Close()
        str = "select * from tbl_mst where acc_no='" & TextBox2.Text & "'"
        ds = fetchdata(str)

        If ds.Tables(0).Rows.Count Then
            Dim num1, num2, tot As Integer
            num1 = ds.Tables(0).Rows(0).Item("bal")
            num2 = TextBox1.Text

            If num2 > 25000 Then
                MsgBox("You can Only Deposit 25,000!")
            ElseIf num2 < 200 Then
                MsgBox(" Mininum Deposit is 200")
            Else
                MsgBox("Your Current Balance is " & num1 & " ", MsgBoxStyle.Information)
                tot = num1 + num2
                str = "Update tbl_mst set bal=" & tot & " where acc_no='" & TextBox2.Text & "'"
                cnt = Insertdata(str)
                MsgBox("Deposite " & num2 & " Successfully ", MsgBoxStyle.Information)
                MsgBox("New Balance is " & tot & " ", MsgBoxStyle.Information)
                TextBox1.Clear()
            End If
        End If
    End Sub
End Class