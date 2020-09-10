<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_home.aspx.cs" Inherits="Task1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" Text="Enter Product Id in below Textbox"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="250px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True"  Height="35px" OnClick="Button1_Click" Text="Next" Width="100px" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Font-Bold="True"  Height="35px" OnClick="Button2_Click" Text="All Products" Width="100px" />
        </div>
    </form>
</body>
</html>
