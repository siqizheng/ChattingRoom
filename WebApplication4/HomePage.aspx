<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication4.HomePage" %>
<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lbPage" runat="server" /><br />
        <asp:TextBox ID="tbMessage" runat="server" BackColor="#ff3399"/>
        <asp:Button ID="btSubmit" Text="send" runat="server" OnClick="btSubmit_Click" />
    </div>
</asp:Content>
