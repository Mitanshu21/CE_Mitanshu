<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_Update.aspx.cs" Inherits="Lab7_4.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
  
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Student&nbsp; ID:
            <asp:TextBox ID="student_id" runat="server" Width="47px"></asp:TextBox>
        </div>
        <br />
        &nbsp;<asp:Button ID="FetchRecord" runat="server"  Text="Fetch_Record" OnClick="FetchRecord_Click" />
&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style9">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">Name :</td>
                    <td>
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Semester :</td>
                    <td>
                        <asp:TextBox ID="sem" runat="server" CssClass="auto-style3"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Cpi:</td>
                    <td>
                        <asp:TextBox ID="cpi" runat="server" CssClass="auto-style3"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Contact No : </td>
                    <td>
                        <asp:TextBox ID="mob" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email :</td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <div>
            <br />
        </div>
        <div>
            <asp:Button ID="RecordUpdated" runat="server" Text="Update Record" OnClick="RecordUpdated_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
