<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="Project_2.NewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="NewUser.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            color: #66FFFF;
            font-weight: bold;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class =" loginbox">
            <h2>Create new user</h2>
                <asp:Label ID="lblName" Text="Name" CssClass="lblName" runat="server" />
                <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" CssClass="auto-style1" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtName" runat="server" CssClass="txtName" placeholder="Enter Name" />
                <br />
                <asp:Label ID="lblVan" Text="Surname" CssClass="lblVan" runat="server" />
                <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtVan" CssClass="auto-style1" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtVan" runat="server" CssClass="txtVan" placeholder="Enter Surname" />
                <br />
                <asp:Label ID="lblEmail" Text="Email" CssClass="lblEmail" runat="server" />
                <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" CssClass="auto-style1" ErrorMessage="please enter a valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
            <asp:Label ID="Label2" runat="server" CssClass="auto-style1" Text="user already exists" Visible="False"></asp:Label>
                <br />
                <asp:TextBox ID="txtEmail" runat="server" CssClass="txtEmail" placeholder="Enter Email" />
                <br />
                <asp:Label ID="lblpwd" Text="Password" CssClass="lblpwd" runat="server" />
                <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtpwd" CssClass="auto-style1" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtpwd" runat="server" CssClass="txtpwd" TextMode="password" placeholder="Enter password" />
                <br />
                <asp:Label ID="lblPwdConfirm" Text="Confirm Password" CssClass="lblPwdConfirm" runat="server" />
                <br />
            <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Text="Passwords does not match" Visible="False"></asp:Label>
                <br />
                <asp:TextBox ID="txtpwdConfirm" runat="server" CssClass="txtpwdConfirm" TextMode="password" placeholder="Confirm Password" />
                <br />
                <asp:Button ID="btnCreate" runat="server" CssClass="btnCreate" Text="Create User" OnClick="btnCreate_Click" />
                <br />
        </div>
    </form>
</body>
</html>
