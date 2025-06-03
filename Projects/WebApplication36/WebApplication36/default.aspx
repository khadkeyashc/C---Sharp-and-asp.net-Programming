<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication36._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" Orientation="Horizontal" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#FFFBD6" />
                <DynamicSelectedStyle BackColor="#FFCC66" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/page1.aspx" Target="new" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/page2.aspx" Target="new" Text="About us" Value="About us">
                        <asp:MenuItem NavigateUrl="~/page3.aspx" Target="new" Text="Help" Value="Help"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#FFCC66" />

            </asp:Menu>
            <br />
            <br />
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList" ShowExpandCollapse="False" ShowLines="True">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode NavigateUrl="~/page1.aspx" Text="Home" Value="Home"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/page2.aspx" Text="About us" Value="About us">
                        <asp:TreeNode NavigateUrl="~/page3.aspx" Text="Help" Value="Help"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
