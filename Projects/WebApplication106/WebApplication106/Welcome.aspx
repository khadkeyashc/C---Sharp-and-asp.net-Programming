﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="WebApplication106.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Welcome
            <asp:Label ID="Label1" runat="server"></asp:Label>
            !<br />
            Contents Of This Page<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Protected Page" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Logout" />

        </div>
    </form>
</body>
</html>
