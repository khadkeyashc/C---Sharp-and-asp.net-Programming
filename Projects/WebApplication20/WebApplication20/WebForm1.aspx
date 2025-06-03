<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication20.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 338px;
        }
        .auto-style2 {
            width: 338px;
            height: 29px;
        }
        .auto-style3 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
                        
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </td>
                    <td class="auto-style3">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="password not"> jhbj</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
