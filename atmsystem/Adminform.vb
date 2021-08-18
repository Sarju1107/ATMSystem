Imports System.Data.SqlClient

Public Class Adminform
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim cnt As Integer
    Dim dt As New DataTable

    Public Function fetchdata(ByVal str As String) As DataSet
        If con.State = 1 Then con.Close()
        con.Open()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()
    End Function

    Public Function Insertdata(ByVal str As String) As Integer
        If con.State = 1 Then con.Close()
        con.Open()
        cmd = New SqlCommand(str, con)
        cnt = cmd.ExecuteNonQuery()
        da.Fill(ds)
        If con.State = 1 Then con.Close()
        Return cnt
    End Function




    Private Sub btnserch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnserch.Click
        If txtfname.Text = "" And txtlname.Text = "" Then
            MsgBox("Enter Name", MsgBoxStyle.Critical)


        Else
            loaddataingrid()
            str = "select * from tbl_mst with (nolock)"
            str &= "where fname LIKE'%' + '" & txtfname.Text & "'+'%'"
            ds = fetchdata(str)
            If (DataGridView1.Rows.Count > 0) Then
                clr()
                DataGridView1.DataSource = ds.Tables(0)
            Else
                clr()
                MsgBox("Record not Found ....try again", MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub

  

    Public Sub loaddataingrid()
        If con.State = 1 Then con.Close()
        str = "Select * from tbl_mst with(nolock)"
        ds = fetchdata(str)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox(" no record found...", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If (e.RowIndex >= 0) Then
            Try
                cnt = DataGridView1.CurrentRow.Index
                Me.txtAcctNo.Text = DataGridView1.Item(0, cnt).Value
                Me.txtPincode.Text = DataGridView1.Item(1, cnt).Value
                Me.txtfnme.Text = DataGridView1.Item(2, cnt).Value
                Me.txtlnme.Text = DataGridView1.Item(3, cnt).Value
                Me.txtaddr.Text = DataGridView1.Item(4, cnt).Value
                Me.txtcontact.Text = DataGridView1.Item(5, cnt).Value
                Me.cbGender.Text = DataGridView1.Item(6, cnt).Value
                Me.txtbday.Text = DataGridView1.Item(7, cnt).Value
                Me.txtbal.Text = DataGridView1.Item(8, cnt).Value

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtAcctNo.Text = "" Then txtAcctNo.Focus() : Exit Sub
        If txtPincode.Text = "" Then txtPincode.Focus() : Exit Sub
        If txtfnme.Text = "" Then txtfname.Focus() : Exit Sub
        If txtlnme.Text = "" Then txtlnme.Focus() : Exit Sub
        If txtaddr.Text = "" Then txtaddr.Focus() : Exit Sub
        If txtcontact.Text = "" Then txtcontact.Focus() : Exit Sub
        If cbGender.Text = "" Then cbGender.Focus() : Exit Sub
        If txtbday.Text = "" Then txtbday.Focus() : Exit Sub
        If txtbal.Text = "" Then txtbal.Focus() : Exit Sub
        'Update Record
        Try
            str = "Update tbl_mst set  pin='" & txtPincode.Text & "',fname='" & txtfnme.Text & "',lname='" & txtlnme.Text & "',addr='" & txtaddr.Text & "',ph_no='" & txtcontact.Text & "',gender='" & cbGender.Text & "',bdate='" & txtbday.Text & "',bal='" & txtbal.Text & "' where acc_no=" & txtAcctNo.Text & ""
            cnt = Insertdata(str)
            If (cnt > 0) Then
                MsgBox("Updated Successfully", MsgBoxStyle.Information)
                loaddataingrid()
                clr()
            Else
                MsgBox("Updated Failed", MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub clr()
        txtAcctNo.Clear()
        txtPincode.Clear()
        txtfnme.Clear()
        txtlnme.Clear()
        txtaddr.Clear()
        txtcontact.Clear()
        cbGender.Items.Clear()
        txtbday.Clear()
        txtbal.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim res As Integer = MsgBox("Do you want to Delete Account?", MsgBoxStyle.YesNo)
        If res = DialogResult.Yes Then
            Try
                str = "Delete from tbl_mst where pin='" + txtPincode.Text + "'"
                cnt = Insertdata(str)
                If (cnt > 0) Then
                    MsgBox("Deleted Successfully", MsgBoxStyle.Information)
                    loaddataingrid()
                    clr()
                Else
                    MsgBox("Deleted cmd Failed", MsgBoxStyle.Critical)
                End If

            Catch ex As Exception

            End Try
        End If
    End Sub

   
    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnload.Click
        loaddataingrid()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Hide()
        login.Show()


    End Sub

    Private Sub Adminform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class