<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Insert.aspx.cs" Inherits="WebApplication1.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                
            <asp:Label ID="lblInsert" runat="server" Font-Bold="True" Font-Size="Larger"  Text="Insert data"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="blue"  Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Lblid" runat="server" Font-Bold="True" Text="ID :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox0" runat="server" required></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblName" runat="server" Font-Bold="True" Text="Name :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" required></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSem" runat="server" Font-Bold="True" Text="Sem :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" required>
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
            <asp:TextBox ID="TextBox2" runat="server" TextMode="number" required></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Font-Bold="True" Text="Email :" ></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Email" required></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInsert" runat="server" Font-Bold="True" OnClick="btnInsert_Click" Text="Insert" />
                
        &nbsp;&nbsp;&nbsp;
            
                
        </div>
    </form>
    
</body>
</html>
