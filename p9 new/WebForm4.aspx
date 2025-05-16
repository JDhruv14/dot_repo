<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="p9_new.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DetailsView Filter Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:UserConnectionString %>" 
                SelectCommand="SELECT [Id], [Name], [Sem], [Subject] FROM [Student] WHERE Id = @Id">
            <SelectParameters>
                <asp:ControlParameter Name="Id" ControlID="DropDownList1" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:UserConnectionString %>" 
                SelectCommand="SELECT [Id], [Name] FROM [Student]">
            </asp:SqlDataSource>

            <asp:DetailsView ID="DetailsView1" runat="server" 
                AutoGenerateRows="False" 
                DataKeyNames="Id" 
                DataSourceID="SqlDataSource2" 
                Height="50px" Width="300px">
                <Fields>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Sem" HeaderText="Sem" />
                    <asp:BoundField DataField="Subject" HeaderText="Subject" />
                </Fields>
            </asp:DetailsView>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                  DataSourceID="SqlDataSource1" 
                  DataTextField="Id" 
                  DataValueField="Id" 
                  AutoPostBack="true">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
