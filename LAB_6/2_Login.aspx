<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Login.aspx.cs" Inherits="WebApplication2.Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>

    <form id="form1" runat="server">
        <table >
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label3"  runat="server" Font-Bold="True"  Text=" LOGIN"></asp:Label>
                </td>
            </tr>
        
            <tr >
                <td colspan="2">
                    <asp:Label ID="Err_Label" runat="server" Font-Bold="True" ForeColor="Red" Text="Username or Password is wrong."></asp:Label>
                </td>
            </tr>
            
            <tr>
                <td >
                    <asp:Label ID="Label1" runat="server" Text="User Name :-" ToolTip="Enter UserName"></asp:Label>
                </td>
                <td >
                    <asp:TextBox ID="txtUsername" runat="server" required> </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="Label2" runat="server" Text="Password :-" ToolTip="Enter Password"></asp:Label>
                </td>
                <td >
                    <asp:TextBox ID="txtPassword"  TextMode="Password"  runat="server"  required></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                </td>
            </tr>

            <br />
            <br />
            


        </table>
    </form>
</body>
</html>
