﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication75.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Select Gender:<br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="vg" Text="Male" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="vg" Text="Female" />
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="vg" Text="Other" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
