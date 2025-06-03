<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication103.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 694px;
        }
        .auto-style2 {
            height: 633px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div class="auto-style2">
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Sid" DataSourceID="SqlDataSource1" DefaultMode="Insert" GridLines="Horizontal" Height="50px" OnItemInserted="DetailsView1_ItemInserted" Width="125px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <Fields>
                    <asp:BoundField DataField="Sid" HeaderText="Sid" ReadOnly="True" SortExpression="Sid" />
                    <asp:BoundField DataField="Sname" HeaderText="Sname" SortExpression="Sname" />
                    <asp:BoundField DataField="SRollno" HeaderText="SRollno" SortExpression="SRollno" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            </asp:DetailsView>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Sid" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleted="GridView1_RowDeleted" OnRowUpdated="GridView1_RowUpdated">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Sid" HeaderText="Sid" ReadOnly="True" SortExpression="Sid" />
                    <asp:BoundField DataField="Sname" HeaderText="Sname" SortExpression="Sname" />
                    <asp:BoundField DataField="SRollno" HeaderText="SRollno" SortExpression="SRollno" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [Sid] = @Sid" InsertCommand="INSERT INTO [Table] ([Sid], [Sname], [SRollno]) VALUES (@Sid, @Sname, @SRollno)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Table]" UpdateCommand="UPDATE [Table] SET [Sname] = @Sname, [SRollno] = @SRollno WHERE [Sid] = @Sid">
                <DeleteParameters>
                    <asp:Parameter Name="Sid" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Sid" Type="Int32" />
                    <asp:Parameter Name="Sname" Type="String" />
                    <asp:Parameter Name="SRollno" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Sname" Type="String" />
                    <asp:Parameter Name="SRollno" Type="String" />
                    <asp:Parameter Name="Sid" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
