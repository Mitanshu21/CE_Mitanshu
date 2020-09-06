<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Order.aspx.cs" Inherits="WebApplication2.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True"  Font-Size="Large" Text="FINAL AMOUNT"></asp:Label>
            <br />
            <br />
  
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True"  Font-Size="Medium" Text="Total Amount :- "></asp:Label>
            <br />
            <asp:TextBox ID="txtCost" Style="text-align: right;" runat="server" Enabled="False" Font-Bold="True" Width="86px">0</asp:TextBox>
           <br />
            <br />
            <br />
            <asp:Button ID="btnFinish" runat="server" Font-Bold="True" Font-Size="Large" Text="Order" OnClick="btnOrder_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
