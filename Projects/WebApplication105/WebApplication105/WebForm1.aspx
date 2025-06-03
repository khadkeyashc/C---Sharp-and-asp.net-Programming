<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication105.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" GroupingText="Controls" Height="310px" ScrollBars="Both">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
                <br />
                <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
                </asp:DetailsView>
                <asp:Login ID="Login1" runat="server">
                </asp:Login>
                <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                    <WizardSteps>
                        <asp:CreateUserWizardStep runat="server" />
                        <asp:CompleteWizardStep runat="server" />
                    </WizardSteps>
                </asp:CreateUserWizard>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
