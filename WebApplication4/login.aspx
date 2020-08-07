<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication4.login" Theme="TextBoxSkin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <label>Username:</label>
        <asp:TextBox ID="tbUsername" placeholder="please input username" runat="server" SkinID="textboxSkin"/><br />
        <asp:RequiredFieldValidator runat="server" ID="rfvUsername" ControlToValidate="tbUsername" style="color:red" ErrorMessage="Username is required" Display="Dynamic" /><br />
        <label>Password:</label>
        <asp:TextBox ID="tbPassword" placeholder="please input password" runat="server" BackColor="#ccff99"/><br />
        <asp:RequiredFieldValidator runat="server" ID="rfvPassword" ControlToValidate="tbPassword" style="color:red" ErrorMessage="Password is required" Display="Dynamic" /><br />
        <asp:Literal ID="lError" runat="server" /><br />
        <asp:Button ID="btSubmit" Text="Login" runat="server" OnClick="btSubmit_Click" />
       
    </div>
</asp:Content>
