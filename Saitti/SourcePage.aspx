<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SourcePage.aspx.cs" Inherits="StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data transfer demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Source Page</h1>
        Message to send: <asp:TextBox ID="txtMessage" runat="server"/> <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="TExsti on pakollinen" ControlToValidate="txtMessage"/>
        <asp:DropDownList ID="ddlMessages" runat="server" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged" AutoPostBack="True" /> <br />
        <asp:Button ID="btnQuery" runat="server" Text="Case1: Query String" OnClick="btnQuery_Click" /><br />
        <asp:Button ID="btnSession" runat="server" Text="Case2: Session" OnClick="btnSession_Click" /><br />
        <asp:Button ID="btnCookie" runat="server" Text="Case3: Cookie" OnClick="btnCookie_Click" /><br />
        <asp:Button ID="btnPublicProperty" runat="server" Text="Case4: Property" OnClick="btnPublicProperty_Click" /><br />

    </div>
    </form>
</body>
</html>
