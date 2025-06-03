<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication63.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 34px;
        }
        .auto-style3 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Age&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age Must Be Between 18 to 95" BorderStyle="None" ControlToValidate="TextBox1" ForeColor="Red" MaximumValue="95" MinimumValue="18" SetFocusOnError="True" Display="Dynamic"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Age Must Be Filled" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="#CC0000" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
