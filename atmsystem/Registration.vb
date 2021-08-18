Imports System.Data.SqlClient

Public Class Registration
    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\MAYANK PATEL\documents\visual studio 2010\Projects\atmsystem\atmsystem\Database.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim cnt As Integer
    Dim dt As New DataTable

    Public Function Insertdata(ByVal str As String) As Integer
        If con.State = 1 Then con.Close()
        con.Open()
        cmd = New SqlCommand(str, con)
        cnt = cmd.ExecuteNonQuery()
        da.Fill(ds)
        If con.State = 1 Then con.Close()
        Return cnt
    End Function


    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtAcctNo.Text = "" And txtPincode.Text = "" And txtcontact.Text = "" And txtfname.Text = "" And txtlname.Text = "" And txtaddr.Text = "" And txtcontact.Text = "" And cbGender.Text = "" And txtdob.Text = "" And txtbalance.Text = "" Then
            MsgBox("Enter All Fields")

        ElseIf txtAcctNo.Text = "" Or txtPincode.Text = "" Or txtcontact.Text = "" Or txtfname.Text = "" Or txtlname.Text = "" Or txtaddr.Text = "" Or txtcontact.Text = "" Or cbGender.Text = "" Or txtdob.Text = "" Or txtbalance.Text = "" Then
            MsgBox("Pls Complete all Fields")
        End If
        Try
            str = "insert into tbl_mst (acc_no,pin,fname,lname,addr,ph_no,gender,bdate,bal,type) values('" & txtAcctNo.Text & "','" & txtPincode.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtaddr.Text & "','" & txtcontact.Text & "','" & cbGender.Text & "','" & txtdob.Text & "','" & txtbalance.Text & "','" & cmbtype.Text & "')"

            cnt = Insertdata(str)
            If (cnt > 0) Then
                MsgBox("Registration Successfully..", MsgBoxStyle.Information)
                Me.Hide()
                Adminform.Show()
            Else
                MsgBox("Registration Failed..", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbldate.Text = Date.Now

        'con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\MAYANK PATEL\documents\visual studio 2010\Projects\atmsystem\atmsystem\Database.mdf;Integrated Security=True;User Instance=True"

        str = "select * from tbl_mst"
        cmd = New SqlCommand(str, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)

    End Sub
End Class