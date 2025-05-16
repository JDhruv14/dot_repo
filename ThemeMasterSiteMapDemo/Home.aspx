<%@ Page Title="Home" MasterPageFile="~/Site.master" Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ThemeMasterSiteMapDemo.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome Home Page!</h2>

    <asp:Label ID="lblDate" runat="server" Font-Bold="true" />
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" />
</asp:Content>
