<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="WebApplication1.Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="imageshow" Text="show image" OnClick="Showbtn" runat="server"></asp:Button>
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" Visible="false" runat="server" ImageUrl="~\image\temp.jpg" Height="300px" Width="420px" />
        </div>
    </form>
</body>
</html>
