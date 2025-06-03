<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication102.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" Orientation="Horizontal" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#F7F6F3" />
                <DynamicSelectedStyle BackColor="#5D7B9D" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/Home.aspx" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/About us.aspx" Text="About us" Value="About us">
                        <asp:MenuItem NavigateUrl="~/Contact.aspx" Text="contact" Value="contact"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#5D7B9D" />
            </asp:Menu>
            <br />
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" ShowLines="True">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
                    <asp:TreeNode Text="New Node" Value="New Node">
                        <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
