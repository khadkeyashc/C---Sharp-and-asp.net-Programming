<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication79.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 650px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Demonstrate of Gridview<br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="sid" DataSourceID="SqlDataSource1" DefaultMode="Insert" Height="50px" OnItemInserted="DetailsView1_ItemInserted" Width="125px">
                <Fields>
                    <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" />
                    <asp:BoundField DataField="srollno" HeaderText="srollno" SortExpression="srollno" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="sid" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleted="GridView1_RowDeleted" OnRowUpdated="GridView1_RowUpdated">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" />
                    <asp:BoundField DataField="srollno" HeaderText="srollno" SortExpression="srollno" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [sid] = @sid" InsertCommand="INSERT INTO [Table] ([sid], [sname], [srollno]) VALUES (@sid, @sname, @srollno)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Table]" UpdateCommand="UPDATE [Table] SET [sname] = @sname, [srollno] = @srollno WHERE [sid] = @sid">
                <DeleteParameters>
                    <asp:Parameter Name="sid" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="sid" Type="Int32" />
                    <asp:Parameter Name="sname" Type="String" />
                    <asp:Parameter Name="srollno" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="sname" Type="String" />
                    <asp:Parameter Name="srollno" Type="String" />
                    <asp:Parameter Name="sid" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
