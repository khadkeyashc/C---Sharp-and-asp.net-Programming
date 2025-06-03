<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication48.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 495px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">

            Enter Username and password<br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            Username <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Password
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />

        </div>
    </form>
</body>
</html>
