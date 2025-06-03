<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication96.WebForm1" %>

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
                    <asp:Login ID="Login1" runat="server">
                    </asp:Login>
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
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Preview" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 29px" Text="Next" />
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="0">View1</asp:ListItem>
                <asp:ListItem Value="1">View2</asp:ListItem>
                <asp:ListItem Value="2">View3</asp:ListItem>
            </asp:DropDownList>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
