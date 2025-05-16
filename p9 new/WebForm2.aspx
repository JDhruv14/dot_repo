<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="p9_new.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserConnectionString %>" SelectCommand="SELECT [Id], [Name], [Sem], [Subject] FROM [Student]"></asp:SqlDataSource>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                  <HeaderTemplate>        <table cellspacing="0" rules="all" border="1">            <tr>                <th scope="col" style="width: 80px">                   Id                </th>                <th scope="col" style="width: 120px">                    Name                </th>                <th scope="col" style="width: 80px">                   Sem                </th>                <th scope="col" style="width: 120px">                    Subject                </th>            </tr>    </HeaderTemplate>                <ItemTemplate>        <tr>            <td>                <asp:Label ID="lblId" runat="server" Text='<%# Eval("Id") %>' />            </td>            <td>                <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>' />            </td>            <td>                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Sem") %>' />            </td>            <td>                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Subject") %>' />            </td>        </tr>    </ItemTemplate>    <FooterTemplate>        </table>    </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
