<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ConsultaAlunos.aspx.cs" Inherits="UIApplication.ConsultaAlunos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h4>Consulta de Alunos</h4>

    <asp:GridView ID="dtgAlunos" runat="server"></asp:GridView>
</asp:Content>
