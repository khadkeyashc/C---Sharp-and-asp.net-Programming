<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication77.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" StaticSubMenuIndent="10px">
                <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#FFFBD6" />
                <DynamicSelectedStyle BackColor="#FFCC66" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/Home.aspx" Target="new" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/About us.aspx" Target="new" Text="AboutUs" Value="AboutUs">
                        <asp:MenuItem NavigateUrl="~/Contact.aspx" Target="new" Text="New Contact" Value="New Contact"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#FFCC66" />
            </asp:Menu>
            <br />
            <br />
            <br />
            <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" ShowLines="True">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode NavigateUrl="~/Home.aspx" Text="Home" Value="Home"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/About us.aspx" Text="AboutUs" Value="AboutUs">
                        <asp:TreeNode NavigateUrl="~/Contact.aspx" Text="Contact" Value="Contact"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
