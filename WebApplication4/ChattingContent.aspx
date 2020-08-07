<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChattingContent.aspx.cs" Inherits="WebApplication4.ChattingContent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <label>Chatting Room</label><br />
    <div> 
        <asp:TextBox ID="tbContent" runat="server" /><br />
    </div>
   <div>
       <asp:Label ID="lList" runat="server" />
   </div>   
</asp:Content>
