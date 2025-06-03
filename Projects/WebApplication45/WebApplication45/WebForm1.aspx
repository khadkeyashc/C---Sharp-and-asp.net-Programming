<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication45.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 575px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            DataBase Program<br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="rollno" DataSourceID="SqlDataSource1" DefaultMode="Insert" Height="50px" OnItemInserted="DetailsView1_ItemInserted" Width="125px">
                <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <Fields>
                    <asp:BoundField DataField="rollno" HeaderText="rollno" ReadOnly="True" SortExpression="rollno" />
                    <asp:BoundField DataField="sname" HeaderText="sname" SortExpression="sname" />
                    <asp:BoundField DataField="saddress" HeaderText="saddress" SortExpression="saddress" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            </asp:DetailsView>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="rollno" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleted="GridView1_RowDeleted" OnRowUpdated="GridView1_RowUpdated">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="rollno" HeaderText="Rollno" ReadOnly="True" SortExpression="rollno" />
                    <asp:BoundField DataField="sname" HeaderText="SName" SortExpression="sname" />
                    <asp:BoundField DataField="saddress" HeaderText="SAddress" SortExpression="saddress" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [rollno] = @rollno" InsertCommand="INSERT INTO [Table] ([rollno], [sname], [saddress]) VALUES (@rollno, @sname, @saddress)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Table]" UpdateCommand="UPDATE [Table] SET [sname] = @sname, [saddress] = @saddress WHERE [rollno] = @rollno">
                <DeleteParameters>
                    <asp:Parameter Name="rollno" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="rollno" Type="Int32" />
                    <asp:Parameter Name="sname" Type="String" />
                    <asp:Parameter Name="saddress" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="sname" Type="String" />
                    <asp:Parameter Name="saddress" Type="String" />
                    <asp:Parameter Name="rollno" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
