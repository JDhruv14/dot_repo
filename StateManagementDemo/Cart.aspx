<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="StateManagementDemo.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
    body {
        font-family: 'Segoe UI', sans-serif;
        background-color: #f8f9fa;
        margin: 50px;
        color: #333;
    }

    h2 {
        color: #0077cc;
    }

    select, input[type=submit], a {
        font-size: 16px;
        padding: 10px;
        margin-top: 10px;
        border: 1px solid #ccc;
        border-radius: 8px;
        background-color: #fff;
    }

    input[type=submit] {
        background-color: #28a745;
        color: white;
        cursor: pointer;
        border: none;
        transition: 0.3s;
    }

    input[type=submit]:hover {
        background-color: #218838;
    }

    a {
        display: inline-block;
        text-decoration: none;
        background-color: #007bff;
        color: white;
        margin-top: 15px;
        transition: 0.3s;
    }

    a:hover {
        background-color: #0056b3;
    }

    .message {
        font-weight: bold;
        margin-top: 10px;
    }

    .cart-list {
        padding-left: 20px;
        font-size: 18px;
    }

    .note {
        color: gray;
        font-style: italic;
    }
</style>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>🛒 Your Shopping Cart</h2>

            <asp:BulletedList ID="bltCart" runat="server" /><br />

            <asp:Label ID="lblLastItem" runat="server" ForeColor="Gray" /><br /><br />

            <asp:HyperLink ID="lnkBack" runat="server" NavigateUrl="Shop.aspx" Text="Continue Shopping" />

        </div>
    </form>
</body>
</html>
