<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication80.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Demonstrate of detailsview<br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="sId" DataSourceID="SqlDataSource1" DefaultMode="Insert" GridLines="Horizontal" Height="50px" OnItemInserted="DetailsView1_ItemInserted" Width="125px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <Fields>
                    <asp:BoundField DataField="sId" HeaderText="sId" ReadOnly="True" SortExpression="sId" />
                    <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" />
                    <asp:BoundField DataField="srollno" HeaderText="srollno" SortExpression="srollno" />
                    <asp:BoundField DataField="feee" HeaderText="feee" SortExpression="feee" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            </asp:DetailsView>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="sId" DataSourceID="SqlDataSource1" OnRowDeleted="GridView1_RowDeleted" OnRowUpdated="GridView1_RowUpdated">
                <Columns>
                    <asp:BoundField DataField="sId" HeaderText="sId" ReadOnly="True" SortExpression="sId" />
                    <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" />
                    <asp:BoundField DataField="srollno" HeaderText="srollno" SortExpression="srollno" />
                    <asp:BoundField DataField="feee" HeaderText="feee" SortExpression="feee" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [sId] = @sId" InsertCommand="INSERT INTO [Table] ([sId], [sname], [srollno], [feee]) VALUES (@sId, @sname, @srollno, @feee)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Table]" UpdateCommand="UPDATE [Table] SET [sname] = @sname, [srollno] = @srollno, [feee] = @feee WHERE [sId] = @sId">
                <DeleteParameters>
                    <asp:Parameter Name="sId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="sId" Type="Int32" />
                    <asp:Parameter Name="sname" Type="String" />
                    <asp:Parameter Name="srollno" Type="Int32" />
                    <asp:Parameter Name="feee" Type="Decimal" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="sname" Type="String" />
                    <asp:Parameter Name="srollno" Type="Int32" />
                    <asp:Parameter Name="feee" Type="Decimal" />
                    <asp:Parameter Name="sId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
