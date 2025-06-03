<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication92.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 520px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#FFFBD6" />
                <DynamicSelectedStyle BackColor="#FFCC66" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/Home.aspx" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/About  Us.aspx" Text="About Us" Value="About Us">
                        <asp:MenuItem NavigateUrl="~/Contactaspx.aspx" Text="Contact Info" Value="Contact Info"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#FFCC66" />
            </asp:Menu>
            <br />
            <br />
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList2" ShowExpandCollapse="False" ShowLines="True">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode NavigateUrl="~/Home.aspx" Text="Home" Value="Home"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/About  Us.aspx" Text="About Us" Value="About Us">
                        <asp:TreeNode NavigateUrl="~/Contactaspx.aspx" Text="Contact" Value="Contact"></asp:TreeNode>
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
