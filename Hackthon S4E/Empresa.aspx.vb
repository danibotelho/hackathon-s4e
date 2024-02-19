Public Class Empresa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub BTN_Salvar_Click(sender As Object, e As EventArgs) Handles BTN_Salvar.Click

        Dim EmpresaService As New EmpresaService
        Dim Empresa As New EmpresaModel With {
    .NomeFantasia = TXT_Nome.Text,
    .RazaoSocial = Label2.Text,
    .CNPJ = Label8.Text,
    .InscricaoEstadual = Label3.Text,
    .DataAbertura = Label4.Text,
    .Email = Label5.Text,
    .Telefone = Label6.Text}
        EmpresaService.Cadastrar(Empresa)


    End Sub


    'ScriptManager.RegisterClientScriptBlock(Me, GetType(Page), "", "<script language=""javascript"">alert('Falha ao carregar empresas.');</script>", False)



End Class