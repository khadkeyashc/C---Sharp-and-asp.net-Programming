<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication23.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 629px;
        }
        .auto-style2 {
            margin-left: 9px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            Choose The Date
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" CssClass="auto-style2" Height="82px" ImageUrl="~/img8.png" OnClick="ImageButton1_Click" Width="66px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Calendar ID="Calendar1" runat="server" Visible="False"></asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
        </div>
    </form>
</body>
</html>
