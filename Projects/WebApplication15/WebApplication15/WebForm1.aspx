<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication15.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 783px">
    <form id="form1" runat="server">
        <div>
            <h1>Enter Your Gender</h1>
            <p>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
            </p>
            <p>
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </p>
            <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
