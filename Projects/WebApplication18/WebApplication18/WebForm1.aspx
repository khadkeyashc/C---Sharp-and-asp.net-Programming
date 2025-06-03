<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication18.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="209px" ScrollBars="Both">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <br />
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                </asp:CheckBoxList>
                <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                </asp:CheckBoxList>
                <asp:CheckBoxList ID="CheckBoxList3" runat="server">
                </asp:CheckBoxList>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
