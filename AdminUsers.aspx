<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminUsers.aspx.cs" Inherits="Project_2.AdminUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="sidebar.css" rel="stylesheet" />
</head>
<body>
        <form runat ="server">
            <div class = "loginbox">
                <asp:Label ID="label1" text="Current registered users" runat="server" style="font-size: x-large; font-weight: 700; color: #00FFFF;"></asp:Label>
                <br />
                <br />
                <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="222px" Width="627px">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
	                    <asp:BoundField  DataField="Naam" HeaderText="User Name" />
	                    <asp:BoundField  DataField="Van" HeaderText="User Surname" />
                        <asp:BoundField  DataField="Email" HeaderText="User Email" />
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
            <asp:Button ID= "btnDates" runat="server" CssClass="btnLogin" Text="Bookings" OnClick="btnDates_Click" />
        </div>

          </form>
</body>
</html>
