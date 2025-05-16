<%@ Page Title="Contact" MasterPageFile="~/Site.master" Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ThemeMasterSiteMapDemo.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Contact Us</h2>

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" />

    <asp:TextBox ID="txtName" runat="server" Placeholder="Your Name" /><br />
    <asp:RequiredFieldValidator ControlToValidate="txtName" ErrorMessage="Name is required" runat="server" CssClass="error" /><br />

    <asp:TextBox ID="txtEmail" runat="server" Placeholder="Your Email" /><br />
    <asp:RequiredFieldValidator ControlToValidate="txtEmail" ErrorMessage="Email is required" runat="server" CssClass="error" /><br />

    <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" /><br />
    <asp:Label ID="lblMsg" runat="server" ForeColor="Green" />
</asp:Content>
