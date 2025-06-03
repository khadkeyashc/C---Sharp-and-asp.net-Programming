<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication67.WebForm1.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 391px">
    <form id="form1" runat="server">
        <div>
               <asp:LoginView ID="LoginView1" runat="server">
                <AnonymousTemplate>
                    <p>You are not logged in. Please log in to access the content.</p>
                    <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/Default.aspx"
                        OnAuthenticate="Login1_Authenticate">
                    </asp:Login>
                </AnonymousTemplate>
                <LoggedInTemplate>
                    <p>Welcome, <asp:LoginName ID="LoginName1" runat="server" /></p>
                    <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutAction="Redirect" LogoutText="Logout"
                        LogoutPageUrl="~/Default.aspx" />
                </LoggedInTemplate>
            </asp:LoginView>
        </div>
    </form>
</body>
</html>
