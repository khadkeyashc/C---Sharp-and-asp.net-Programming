<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication17.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 194px">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            </asp:CheckBoxList>
        </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
