<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication94.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 759px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="Sid" DataSourceID="SqlDataSource1" DefaultMode="Insert" Height="50px" OnItemInserted="DetailsView1_ItemInserted" Width="125px">
                <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <Fields>
                    <asp:BoundField DataField="Sid" HeaderText="Sid" ReadOnly="True" SortExpression="Sid" />
                    <asp:BoundField DataField="Sname" HeaderText="Sname" SortExpression="Sname" />
                    <asp:BoundField DataField="SRollno" HeaderText="SRollno" SortExpression="SRollno" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            </asp:DetailsView>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Sid" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleted="GridView1_RowDeleted" OnRowUpdated="GridView1_RowUpdated">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="Sid" HeaderText="Sid" ReadOnly="True" SortExpression="Sid" />
                    <asp:BoundField DataField="Sname" HeaderText="Sname" SortExpression="Sname" />
                    <asp:BoundField DataField="SRollno" HeaderText="SRollno" SortExpression="SRollno" />
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
&nbsp;
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [Sid] = @Sid" InsertCommand="INSERT INTO [Table] ([Sid], [Sname], [SRollno]) VALUES (@Sid, @Sname, @SRollno)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Table]" UpdateCommand="UPDATE [Table] SET [Sname] = @Sname, [SRollno] = @SRollno WHERE [Sid] = @Sid">
                <DeleteParameters>
                    <asp:Parameter Name="Sid" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Sid" Type="Int32" />
                    <asp:Parameter Name="Sname" Type="String" />
                    <asp:Parameter Name="SRollno" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Sname" Type="String" />
                    <asp:Parameter Name="SRollno" Type="Int32" />
                    <asp:Parameter Name="Sid" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
