Imports System.Data.SqlClient
Public Class mainmenu
    'Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\MAYANK PATEL\documents\visual studio 2010\Projects\atmsystem\atmsystem\Database.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim cnt As Integer
    Dim tbl As New DataTable
    Dim bal As String
    Dim n1, n2, tot As Integer

    Public Function fetchdata(ByVal str As String) As DataSet
        If con.State = 1 Then con.Close()
        con.Open()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()
    End Function
    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Me.Hide()
        login.Show()


    End Sub


    Private Sub btndep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndep.Click

        str = "select * from tbl_mst where acc_no = '" & lblaccno.Text & "'"
        ds = fetchdata(str)


        If ds.Tables(0).Rows.Count > 0 Then

            Dim accno As String

            accno = ds.Tables(0).Rows(0).Item("acc_no")
            Deposite1.TextBox2.Text = accno
            Deposite1.lbldate.Text = Date.Today
            Deposite1.Show()

        End If


    End Sub

    Private Sub lblaccno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblaccno.Click

    End Sub

    Private Sub mainmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub btnwith_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwith.Click
        str = "select * from tbl_mst where acc_no = '" & lblaccno.Text & "'"
        ds = fetchdata(str)


        If ds.Tables(0).Rows.Count > 0 Then

            Dim accno As String

            accno = ds.Tables(0).Rows(0).Item("acc_no")
            withdraw.txtacc.Text = accno
            withdraw.lbldate.Text = Date.Today

            withdraw.Show()

        End If

    End Sub

    Private Sub btntra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntra.Click
        Me.Hide()
        Change_Pin.Show()
    End Sub

    Private Sub btnbal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbal.Click
        If con.State = 1 Then con.Close()
        str = "select * from tbl_mst where acc_no='" & lblaccno.Text & "'"
        ds = fetchdata(str)

        If ds.Tables(0).Rows.Count Then
            Dim bal As Integer
            bal = ds.Tables(0).Rows(0).Item("bal")
            MsgBox("Your Balance is " & bal & " ", MsgBoxStyle.Information)
        End If
    End Sub
End Class