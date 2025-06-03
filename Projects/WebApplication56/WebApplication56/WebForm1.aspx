<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication56.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://code.jquery.com/jquery-3.6.4.min.js" integrity="sha256-oP6HI/t1qEz8N9rZl+cbz2i2Y1tM3+XvbK9d6u5lOzw=" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Login ID="Login1" runat="server"></asp:Login>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </asp:View>


            </asp:MultiView>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="previous" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="next" />
        </p>
    </form>
</body>
</html>
