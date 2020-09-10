<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_Insert.aspx.cs" Inherits="Lab7_4.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Semester:</td>
                    <td>
                        <asp:TextBox ID="sem" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Cpi:</td>
                    <td>
                        <asp:TextBox ID="cpi" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Contact No:</td>
                    <td>
                        <asp:TextBox ID="cno" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <br />
&nbsp;<asp:Button ID="Insert_Record" runat="server" OnClick="Insert_Record_Click" Text="Insert" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
