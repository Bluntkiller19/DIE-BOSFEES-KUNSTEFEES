<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user bookings.aspx.cs" Inherits="Project_2.user_bookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="sidebar.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            color: #00FFFF;
        }
    </style>
</head>
<body>
    <form runat ="server">
    <div class = "loginbox">
        <asp:Label ID="Label1" runat="server" Text ="Your bookings" style="font-size: x-large; font-weight: 700" CssClass="auto-style1"></asp:Label>
        <br />
        <br />
                <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="176px" Width="627px">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
	                    <asp:BoundField  DataField="Name" HeaderText="User Name" />
	                    <asp:BoundField  DataField="Surname" HeaderText="User Surname" />
                        <asp:BoundField  DataField="Email" HeaderText="User Email" />
                         <asp:BoundField  DataField="Children ticets" HeaderText="Children ticets" />
                         <asp:BoundField  DataField="Adult tickets" HeaderText="Adult tickets" />
                         <asp:BoundField  DataField="payed" HeaderText="payed" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
    </div>
    <div class='sidebar'>
            <br />
            <asp:Button ID= "btnMybookings" runat="server" CssClass="btnLogin" Text="Make booking" OnClick="btnMybookings_Click" />
            <br />
        </div> 
    </form>
   
</body>
</html>
