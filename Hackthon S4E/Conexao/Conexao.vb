﻿Imports System.Data.SqlClient

Public Class Conexao
    Public Function Executa(sql As String) As DataView

        Dim conexao = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
        Dim connection = New SqlConnection(conexao)
        Dim command = New SqlCommand(sql, connection)
        Dim dataAdapter = New SqlDataAdapter(command)
        Dim dataSet = New DataSet
        Try
            connection.Open()

            dataAdapter.Fill(dataSet)

            Return dataSet.Tables(0).DefaultView

        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try

    End Function

    Public Sub ExecuteReader(sql As String)
        Dim conexao = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
        Dim connection = New SqlConnection(conexao)
        Dim command = New SqlCommand(sql, connection)
        Try
            connection.Open()
            command.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
    End Sub
End Class

