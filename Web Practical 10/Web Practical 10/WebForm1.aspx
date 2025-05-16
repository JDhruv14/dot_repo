<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web_Practical_10.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <style>
        .form-row {
            margin-bottom: 10px;
        }

        .form-label {
            display: inline-block;
            width: 150px;
        }

        .error {
            color: red;
            font-size: small;
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 600px; margin: auto;">
            <h2 style="font-family: Verdana, Geneva, Tahoma, sans-serif; font-weight: bold;">Registration Form</h2>

            <div class="form-row">
                <span class="form-label">ID:</span>
                <asp:TextBox ID="TextBox1" runat="server" />
            </div>

            <div class="form-row">
                <span class="form-label">Name:</span>
                <asp:TextBox ID="TextBox2" runat="server" />
            </div>

            <div class="form-row">
                <span class="form-label">Password:</span>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" />
                <asp:Label ID="lblPassword" runat="server" CssClass="error" />
            </div>

            <div class="form-row">
                <span class="form-label">Confirm Password:</span>
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" />
                <asp:Label ID="lblConfirmPassword" runat="server" CssClass="error" />
            </div>

            <div class="form-row">
                <span class="form-label">Email Address:</span>
                <asp:TextBox ID="TextBox6" runat="server" />
                <asp:Label ID="lblEmail" runat="server" CssClass="error" />
            </div>

            <div class="form-row">
                <span class="form-label">Phone Number:</span>
                <asp:TextBox ID="TextBox3" runat="server" />
                <asp:Label ID="lblPhone" runat="server" CssClass="error" />
            </div>

            <div class="form-row">
                <span class="form-label">Branch:</span>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="--Select Branch--" Value="--Select Branch--" />
                    <asp:ListItem Text="Computer Engineering" />
                    <asp:ListItem Text="Mechanical Engineering" />
                    <asp:ListItem Text="IoT" />
                    <asp:ListItem Text="CSD" />
                </asp:DropDownList>
                <asp:Label ID="lblBranch" runat="server" CssClass="error" />
            </div>

            <div class="form-row">
                <span class="form-label">Hobbies:</span>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Sport" />
                &nbsp;
                <asp:CheckBox ID="CheckBox2" runat="server" Text="Indoor" />
                <asp:Label ID="lblHobby" runat="server" CssClass="error" />
            </div>

            <div class="form-row">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </div>
        </div>
    </form>
</body>
</html>
