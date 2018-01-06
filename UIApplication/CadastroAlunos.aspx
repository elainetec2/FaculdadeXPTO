<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroAlunos.aspx.cs" Inherits="UIApplication.CadastroAlunos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
<h4>Cadastro de Alunos</h4>
    Informe o nome do Aluno <br />
    <asp:TextBox ID="txtNome" runat="server" />
    <br /><br />

    Matrícula <br />
    <asp:TextBox ID="txtMatricula" runat="server" />
    <br /><br />

    Turma <br />
    <asp:DropDownList ID="ddlTurma" runat="server"/>   
    <br /><br />

     CPF <br />
    <asp:TextBox ID="txtCpf" runat="server" />
    <br /><br />

    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" OnClick="CadastrarAluno"/>

    <p>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </p>
</asp:Content>
