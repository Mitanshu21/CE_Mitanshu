
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Edit.aspx.cs" Inherits="WebApplication1.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                
            <asp:Label ID="lblInsert" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Blue" Text="Update Data"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="DATA edit" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Id :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblName" runat="server" Font-Bold="True" Text="Name :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" required Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSem" runat="server" Font-Bold="True" Text="Sem :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" required Enabled="False">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblMob" runat="server" Font-Bold="True" Text="Mobile No :" ></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="number" required Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Font-Bold="True" Text="Email :" ></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Email" required Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEdit" runat="server" Font-Bold="True" OnClick="btnEdit_Click" Text="Search" />
                
        &nbsp;&nbsp;
                
        </div>
    </form>
</body>
</html>
