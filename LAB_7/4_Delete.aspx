﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_Delete.aspx.cs" Inherits="Lab7_4.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student&nbsp; ID:
            <asp:TextBox ID="id" runat="server" Width="50px"></asp:TextBox>
        </div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="DeleterRecord" runat="server" OnClick="DeleterRecord_Click" Text="Delete Record" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
    </form>
</body>
</html>
