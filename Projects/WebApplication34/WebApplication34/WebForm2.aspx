<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication34.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            

            <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList" ShowExpandCollapse="False" ShowLines="True">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode NavigateUrl="~/page1.aspx" Target="new" Text="ho" Value="ho"></asp:TreeNode>
                    <asp:TreeNode NavigateUrl="~/page2.aspx" Target="new" Text="about" Value="about">
                        <asp:TreeNode NavigateUrl="~/page3.aspx" Text="help" Value="help"></asp:TreeNode>
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
