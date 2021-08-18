Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Smit\atmsystem\atmsystem\Database.mdf;Integrated Security=True;User Instance=True")
    Public pin As String
    Public user As String
End Module
