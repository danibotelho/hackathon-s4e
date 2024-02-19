Public Class EmpresaDAO

    Public Sub Insert(empresa As EmpresaModel)
        Try
            Dim sql = $"insert into Empresa (NomeFantasia, RazaoSocial, CNPJ, InscricaoEstadual, DataAbertura, Email, Telefone) values ('{empresa.NomeFantasia} ,{empresa.RazaoSocial}, {empresa.CNPJ}, {empresa.InscricaoEstadual}, {empresa.DataAbertura}, {empresa.Email},  {empresa.Telefone} '), "
            Dim conexao As New Conexao
            conexao.ExecuteReader(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
