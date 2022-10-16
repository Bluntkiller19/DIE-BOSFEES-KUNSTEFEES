<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Project_2.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="sidebar.css" rel="stylesheet" />
</head>
<body>
     <form runat ="server">
    <div class = "loginbox">
        <asp:Label ID="lblGreeting" runat="server" style="font-size: xx-large; font-weight: 700">Make a booking</asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Fill in all fields" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="lblName" runat="server" CssClass='lblEmail' Text = "Name"></asp:Label>
        <br />
        <asp:TextBox ID = "txtName" runat ="server" CssClass="txtEmail" placeholder="Enter name"></asp:TextBox> 
        <br />
        <asp:Label ID="lblSurname" runat="server" CssClass='lblEmail' Text = "Surname"></asp:Label>
        <br />
        <asp:TextBox ID = "txtSurname" runat ="server" CssClass="txtEmail" placeholder="Enter surname"></asp:TextBox> 
        <br />
        <asp:Label ID="Label3" runat="server" CssClass="lblEmail" Text = "Number of children tickets"></asp:Label>
        <br />
        <asp:DropDownList ID="children" runat="server">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" CssClass="lblEmail" Text = "Number of adult tickets"></asp:Label>
        <br />
        <asp:DropDownList ID="Adult" runat="server">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" CssClass="lblEmail" Text = "payment"></asp:Label>
        <br />
        <asp:RadioButton ID="rbtnNow" runat="server" Text="Now" GroupName="rbtnTickets" />
&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rbtnLater" runat="server" Text="Later" GroupName="rbtnTickets" />
        <br />
        <asp:Button ID= "Btnbook" runat="server" CssClass="btnLogin" Text="Make booking" OnClick="Btnbook_Click" />
    </div>
    <div class='sidebar'>
            <br />
             <asp:Label ID="Label1" runat="server" class="text"></asp:Label>
            <br />
            <br />
            <asp:Button ID= "btnSettings" runat="server" CssClass="btnLogin" Text="Settings" OnClick="btnSettings_Click" />
         <asp:Button ID= "btnbookingsmade" runat="server" CssClass="btnLogin" Text="my bookings" OnClick="btnbookingsmade_Click" />
            <asp:Button ID= "btnLogout" runat="server" CssClass="myButton" Text="logout" OnClick="btnLogout_Click" />
            <br />
    </div>
    </form>
</body>
</html>
