<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication104.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                        <WizardSteps>
                            <asp:CreateUserWizardStep runat="server" />
                            <asp:CompleteWizardStep runat="server" />
                        </WizardSteps>
                    </asp:CreateUserWizard>
                </asp:View>

            </asp:MultiView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </form>
</body>
</html>
