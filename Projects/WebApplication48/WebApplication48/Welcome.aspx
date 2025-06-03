<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="WebApplication48.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 477px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Welcome<asp:Label ID="Label1" runat="server"></asp:Label>
            !<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Protected" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="logout" />
        </div>
    </form>
</body>
</html>
