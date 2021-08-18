Imports System.Data.SqlClient

Public Class login
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Smit\atmsystem\atmsystem\Database.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim str As String
    Dim cnt As Integer


    Public Function fetchdata(ByVal str As String) As DataSet
        If con.State = 1 Then con.Close()
        con.Open()
        da = New SqlDataAdapter(str, con)
        ds = New DataSet
        da.Fill(ds)

        Return ds
        con.Close()
    End Function
    Private Sub llblreg_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblreg.LinkClicked
        Me.Hide()
        Registration.Show()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtpin.Text = "" Then txtpin.Focus() : Exit Sub
        If txtpin.Text = "" Then
            MsgBox("Pls Enter pin numbers")
        Else

            str = "select * from tbl_mst with (nolock)"
            str &= "where pin LIKE'%' + '" & txtpin.Text & "' +'%'"
            ds = fetchdata(str)


            If ds.Tables(0).Rows.Count > 0 Then
                Dim type, Fullname, accno, lastname As String
                user = ds.Tables(0).Rows(0).Item("fname")
                pin = ds.Tables(0).Rows(0).Item("pin")
                type = ds.Tables(0).Rows(0).Item("type")
                Fullname = ds.Tables(0).Rows(0).Item("fname")
                lastname = ds.Tables(0).Rows(0).Item("lname")
                accno = ds.Tables(0).Rows(0).Item("acc_no")
                If type = "Admin" Then
                    MsgBox("Welcome " & Fullname & " you login as Administrator ")
                    Adminform.Show()
                    Me.Hide()

                Else
                    MsgBox("Welcome " & Fullname)
                    mainmenu.Show()
                    mainmenu.lblname.Text = Fullname
                    mainmenu.lblaccno.Text = accno

                    Me.Hide()

                End If
            End If
        End If


    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        Exit Sub
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class