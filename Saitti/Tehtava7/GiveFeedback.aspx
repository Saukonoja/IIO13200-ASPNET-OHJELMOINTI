<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GiveFeedback.aspx.cs" Inherits="Tehtava7_GiveFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="float: left;  margin-right:40px;">
                <h1>Anna palaute</h1>
                Pvm: <br /> <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>  <br /> <asp:RegularExpressionValidator ID="RegularExpressionValidator7" BackColor="Red" runat="server" ErrorMessage="Dont try anything funny now." ControlToValidate="txtDate" ValidationExpression="^[\w{.,'}+ :?®©-]+$" /><br />                            
                Nimi: <br /> <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><asp:RegularExpressionValidator ID="regexpName" BackColor="Red" runat="server" ErrorMessage="Dont try anything funny now." ControlToValidate="txtName" ValidationExpression="^[\w{.,'}+ :?®©-]+$" /><br />               
                Opintojakson nimi ja koodi: <br />
                <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox><br /><asp:RegularExpressionValidator ID="RegularExpressionValidator1" BackColor="Red" runat="server" ErrorMessage="Dont try anything funny now." ControlToValidate="txtCourse" ValidationExpression="^[\w{.,'}+ :?®©-]+$" /><br />           
                Olen oppinut:<br />
                <asp:TextBox ID="txtLearned" runat="server"></asp:TextBox><br /><asp:RegularExpressionValidator ID="RegularExpressionValidator2" BackColor="Red" runat="server" ErrorMessage="Dont try anything funny now." ControlToValidate="txtLearned" ValidationExpression="^[\w{.,'}+ :?®©-]+$" /><br />           
                Haluan oppia:     <br />
                <asp:TextBox ID="txtWant" runat="server"></asp:TextBox><br /> <asp:RegularExpressionValidator ID="RegularExpressionValidator3" BackColor="Red" runat="server" ErrorMessage="Dont try anything funny now." ControlToValidate="txtWant" ValidationExpression="^[\w{.,'}+ :?®©-]+$" /><br />           
                <asp:Label ID="lblMessages" Text="empty" runat="server"></asp:Label>
            </div>
            <div style="float:left;">
                <br /><br /><br /><br />
                Hyvää: <br /><asp:TextBox ID="txtGood" runat="server"></asp:TextBox><br /><asp:RegularExpressionValidator ID="RegularExpressionValidator4" BackColor="Red" runat="server" ErrorMessage="Dont try anything funny now." ControlToValidate="txtGood" ValidationExpression="^[\w{.,'}+ :?®©-]+$" /><br />           
                Parannettavaa: <br />  <asp:TextBox ID="txtImprove" runat="server"></asp:TextBox><br /><asp:RegularExpressionValidator ID="RegularExpressionValidator5" BackColor="Red" runat="server" ErrorMessage="Dont try anything funny now." ControlToValidate="txtImprove" ValidationExpression="^[\w{.,'}+ :?®©-]+$" /><br />           
                Muuta: <br /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" BackColor="Red" ErrorMessage="Dont try anything funny now." ControlToValidate="Textbox1" ValidationExpression="^[\w{.,'}+ :?®©-]+$" /><br />           
                <asp:Button ID="btnSendXml" Text="Lähetä(Xml)" runat="server" OnClick="btnSendXml_Click" /><br />
                <asp:Button ID="btnSendMysql" Text="Lähetä(Mysql)" runat="server" OnClick="btnSendMysql_Click" /><br />
                <asp:Button ID="btnFeedbacks" Text="Katso palautteet" runat="server" OnClick="btnFeedbacks_Click" /><br />
                <asp:CustomValidator ID="Validator1" runat="server" ErrorMessage="CustomValidator" OnServerValidate="Validator1_ServerValidate"></asp:CustomValidator>
            </div>

        </div>
    </form>
</body>
</html>
