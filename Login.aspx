<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project_2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style2 {
            color: #66CCFF;
        }
    </style>
</head>
    <body>
        <div class = "loginbox">
            <img src="kruger.jpg" alt = "login logo"  class="user" />
            <h2>Die Bosfees kunstefees booking</h2>
            <h2>User login</h2>
            <form runat ="server">
                <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Incorrect email or password" Visible="False"></asp:Label>
                <br />
                <asp:Label ID="lblEmail" Text="Email" CssClass="lblEmail" runat="server" />
                <br />
                <asp:TextBox ID="txtEmail" runat="server" CssClass="txtEmail" placeholder="Enter Email" />
                <br />
                <asp:Label ID="lblpwd" Text="Password" CssClass="lblpwd" runat="server" />
                <br />
                <asp:TextBox ID="txtpwd" runat="server" CssClass="txtpwd" TextMode="password" placeholder="Enter password" />
                <br />
                <asp:Button ID="btnlogin" runat="server" CssClass="btnLogin" Text="Login" OnClick="btnlogin_Click" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lbtnCreate" CssClass="lbtnCreate" Text="Create User" runat="server" style="color: #FFFF99" OnClick="lbtnCreate_Click" />
            </form>
        </div>
    </body>
</html>
