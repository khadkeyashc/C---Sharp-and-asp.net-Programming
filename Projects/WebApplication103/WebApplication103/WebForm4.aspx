<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication103.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
                    </asp:DetailsView>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                        <WizardSteps>
                            <asp:CreateUserWizardStep runat="server" />
                            <asp:CompleteWizardStep runat="server" />
                        </WizardSteps>
                    </asp:CreateUserWizard>
                </asp:View>
            </asp:MultiView>

        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Previous" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 29px" Text="Next" />
    </form>
</body>
</html>
