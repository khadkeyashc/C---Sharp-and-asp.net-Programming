<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication16.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 654px">
            <asp:CheckBox ID="CheckBox2" runat="server" Text="java" />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="python" />
            <br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="asp" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Show Coueses"></asp:Label>
        </div>
        <asp:CheckBox ID="CheckBox1" runat="server" />
    </form>
</body>
</html>
