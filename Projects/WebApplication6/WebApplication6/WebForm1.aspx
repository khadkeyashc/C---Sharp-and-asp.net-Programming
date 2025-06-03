<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 642px">
            <asp:Image ID="Image2" runat="server" Height="244px" ImageUrl="~/images/IMG_20220414_173526.jpg" style="margin-left: 455px" Width="324px" />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="177px" ImageUrl="~/images/IMG_20220414_174614.jpg" OnClick="ImageButton1_Click" Width="219px" />
        </div>
        <asp:Image ID="Image1" runat="server" />
    </form>
</body>
</html>
