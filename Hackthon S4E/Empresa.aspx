<%@ Page Title="Empresa" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empresa.aspx.vb" Inherits="Hackthon_S4E.Empresa"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Style/styles.css" rel="stylesheet" />
    
    
 

    <h1 style="margin-bottom: 2rem"> Cadastro de Empresa </h1>
        
    <div class="forms">
               
        <asp:Label ID="LBL_NomeFantasia" runat="server" Text="Nome Fantasia" CssClass="aligned-label"></asp:Label>
        <asp:TextBox ID="TXT_NomeFantasia" runat="server" MaxLength="60" CssClass="aligned-textbox"></asp:TextBox>
       
        <asp:Label ID="Label2" runat="server" Text="Razão Social" CssClass="aligned-label"></asp:Label>
        <asp:TextBox ID="TXT_RazaoSocial" runat="server" MaxLength="60" CssClass="aligned-textbox"></asp:TextBox>
        
        <asp:Label ID="Label8" runat="server" Text="CNPJ" CssClass="aligned-label"></asp:Label>
        <asp:TextBox ID="TXT_CNPJ" runat="server" MaxLength="14" TextMode="Number" CssClass="aligned-textbox"></asp:TextBox>
        
        <asp:Label ID="Label3" runat="server" Text="Inscrição Estadual" CssClass="aligned-label">  </asp:Label>
        <asp:TextBox ID="TXT_InscricaoEstadual" runat="server" MaxLength="15" TextMode="number" CssClass="aligned-textbox"></asp:TextBox>
       
        <asp:Label ID="Label4" runat="server" Text="Data de Abertura" CssClass="aligned-label">  </asp:Label>
        <asp:TextBox ID="TXT_DataAbertura" runat="server" TextMode="DateTime" CssClass="aligned-textbox"></asp:TextBox>
       
        <asp:Label ID="Label5" runat="server" Text="Email" CssClass="aligned-label">  </asp:Label>
        <asp:TextBox ID="TXT_Email" runat="server" MaxLength="60"  TextMode="Email" CssClass="aligned-textbox"></asp:TextBox>
        
        <asp:Label ID="Label6" runat="server" Text="Telefone" CssClass="aligned-label">  </asp:Label>
        <asp:TextBox ID="TXT_Telefone" runat="server" MaxLength="11" TextMode="Phone" CssClass="aligned-textbox"></asp:TextBox>    
        
    
            <br />
        <asp:Button CssClass="btn btn-primary" ID="BTN_Salvar" runat="server" Text="Salvar"/>
        </div>
  
    
</asp:Content>
