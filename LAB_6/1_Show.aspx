<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Show.aspx.cs" Inherits="WebApplication1.Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                
            <asp:Label ID="lblInsert" runat="server" Font-Bold="True" Font-Size="Larger"  Text="Show all data"></asp:Label>
            <br />
                                  
            <asp:GridView ID="GridView1" runat="server">
                <FooterStyle BackColor="green" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="navy" Font-Bold="True" ForeColor="White" />
                
            </asp:GridView>
                
        &nbsp;&nbsp;
                
        </div>
    </form>
</body>
</html>
