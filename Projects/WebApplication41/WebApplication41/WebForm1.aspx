<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication41.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Basic Server Controls Demo</title>
</head>
<body>
<form id="form1" runat="server">
<h1>Basic Server Controls Demo</h1>
<asp:Label ID="lblMessage" runat="server" Text="Enter your name:" />
<br />
<asp:TextBox ID="txtName" runat="server" />
<br />
<!-- Button Control -->
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
<br />
<asp:DropDownList ID="ddlOptions" runat="server">
<asp:ListItem Text="Option 1" Value="1" />
<asp:ListItem Text="Option 2" Value="2" />
<asp:ListItem Text="Option 3" Value="3" />
</asp:DropDownList>
<br />
<asp:Label ID="lblResult" runat="server" Text="" />
</form>
</body>
</html>


