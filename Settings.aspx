<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="Project_2.Settings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="sidebar.css" rel="stylesheet" />
    <style type="text/css">
        .txtpwd {
            font-size: large;
        }
        .txtEmail {
            font-size: large;
        }
        .auto-style2 {
            font-size: large;
            color: #FF0066;
        }
        .lblpwd {
            font-size: large;
        }
        .lblEmail {
            font-size: large;
        }
    </style>
</head>
<body>
     <script type = "text/javascript">
         function Confirm() {
             var confirm_value = document.createElement("INPUT");

             confirm_value.type = "hidden";
             confirm_value.name = "confirm_value";

             if (confirm("Confirm")) {
                 confirm_value.value = "Yes";
             }
             else {
                 confirm_value.value = "No";
             }

             document.forms[0].appendChild(confirm_value);
         }
         </script>
    <form runat ="server">
    <div class = 'loginbox'>
        <asp:Label ID="lblGreeting" runat="server" style="font-size: xx-large; font-weight: 700">Settings</asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style2" Text="Passwords dont match" Visible="False"></asp:Label>
                <br />
                <asp:Label ID="lblpwd" Text="New password" CssClass='lblpwd' runat="server" />
                <br />
                <asp:TextBox ID="txtpwd" runat="server" CssClass='txtpwd' TextMode="password" placeholder="Enter new password" />
                <br />
                <asp:Label ID="lblCpwd" Text="Password" CssClass='lblpwd' runat="server" />
                <br />
                <asp:TextBox ID="txtCpwd" runat="server" CssClass='txtpwd' TextMode="password" placeholder="Confirm password" />
                <br />
                <br />                    
                <asp:Button ID="btnUpdate" runat="server" CssClass='btnUpdate' Text="update password" OnClientClick="Confirm()" OnClick="btnUpdate_Click" />
                <br />
    </div>
    <div class='sidebar'>
            <br />
                <asp:Label ID="Label1" runat="server" class="text"></asp:Label>
            <br />
            <br />
            <asp:Button ID= "btnMybookings" runat="server" CssClass="btnLogin" Text="Make booking" OnClick="btnMybookings_Click" />
            <asp:Button ID= "btnDelete" runat="server" CssClass='btnDelete' Text="Delete Account" OnClientClick="Confirm()" OnClick="btnDelete_Click1" />
            <br />
    </div>
     </form>
</body>
</html>
