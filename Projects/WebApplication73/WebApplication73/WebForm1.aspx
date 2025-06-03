<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication73.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                 <asp:ListItem Value="0">Calender</asp:ListItem>
                 <asp:ListItem Value="1">FileUpload</asp:ListItem>
                 <asp:ListItem Value="2">Login</asp:ListItem>
            </asp:DropDownList>
            <asp:MultiView ID="MultiView1" runat="server">
                
                <asp:View ID="View1" runat="server">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Login ID="Login1" runat="server"></asp:Login>
                </asp:View>
            </asp:MultiView>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Prev" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Next" />
           
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
