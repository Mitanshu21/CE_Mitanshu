<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Product.aspx.cs" Inherits="WebApplication2.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label3" runat="server" Font-Bold="True"  Font-Size="Large" ForeColor="Blue" Text="Product details"></asp:Label>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            
            <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="5" DataKeyNames="pid" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="pid" HeaderText="pid" ReadOnly="True" SortExpression="pid" />
                    <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
                    <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                    <asp:BoundField DataField="cost" HeaderText="cost" SortExpression="cost" />
                </Columns>
                
                <HeaderStyle BackColor="white" Font-Bold="True" ForeColor="White" />
          
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Product] WHERE [pid] = @original_pid AND [pname] = @original_pname AND [description] = @original_description AND [cost] = @original_cost" InsertCommand="INSERT INTO [Product] ([pid], [pname], [description], [cost]) VALUES (@pid, @pname, @description, @cost)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Product]" UpdateCommand="UPDATE [Product] SET [pname] = @pname, [description] = @description, [cost] = @cost WHERE [pid] = @original_pid AND [pname] = @original_pname AND [description] = @original_description AND [cost] = @original_cost">
                <DeleteParameters>
                    <asp:Parameter Name="original_pid" Type="String" />
                    <asp:Parameter Name="original_pname" Type="String" />
                    <asp:Parameter Name="original_description" Type="String" />
                    <asp:Parameter Name="original_cost" Type="Decimal" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="pid" Type="String" />
                    <asp:Parameter Name="pname" Type="String" />
                    <asp:Parameter Name="description" Type="String" />
                    <asp:Parameter Name="cost" Type="Decimal" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="pname" Type="String" />
                    <asp:Parameter Name="description" Type="String" />
                    <asp:Parameter Name="cost" Type="Decimal" />
                    <asp:Parameter Name="original_pid" Type="String" />
                    <asp:Parameter Name="original_pname" Type="String" />
                    <asp:Parameter Name="original_description" Type="String" />
                    <asp:Parameter Name="original_cost" Type="Decimal" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:ListBox ID="ListBox2" runat="server" Visible="False"></asp:ListBox>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Enabled="False" Visible="False"></asp:ListBox>
            <br />
            <br />
            <br />
              <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Total amount :"></asp:Label>
            <asp:TextBox ID="txtCost" style="text-align: right;" runat="server" Enabled="False" Font-Bold="True" Width="86px">0</asp:TextBox>
          
            <br />
            <br />
            <br />
            <asp:Button ID="btnOrder" runat="server" Font-Bold="True" Font-Size="Medium" Text=" Order " OnClick="btnOrder_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
