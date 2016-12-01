<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CassieConnector.aspx.cs" Inherits="CassieConnector" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float:left; margin-right:100px;">
            <asp:Button ID="btnGetAll" Text="Get all users" runat="server" OnClick="btnGetAll_Click" />
            <asp:GridView ID="gvUsers" runat="server"></asp:GridView>
        </div>
        <!-- Regexit ehkäisemään injektiota-->
        <div style="float:left;">
            Lastname(PRIMARY KEY)<br /><asp:TextBox ID="txtLastname" runat="server"></asp:TextBox><br /> <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"     
                                    ErrorMessage="No special characters." 
                                    ControlToValidate="txtLastname"     
                                    ValidationExpression="^[\w{.,'}+ :;?®©-]+$" />
            Firstname<br /><asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox><br /> <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"     
                                    ErrorMessage="No special characters." 
                                    ControlToValidate="txtFirstname"     
                                    ValidationExpression="^[\w{.,'}+ :;?®©-]+$" />
            
            Age<br /><asp:TextBox ID="txtAge" runat="server"></asp:TextBox> <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"     
                                    ErrorMessage="No special characters." 
                                    ControlToValidate="txtAge"     
                                    ValidationExpression="^[\w{.,'}+ :;?®©-]+$" />

            <asp:Button ID="btnInsert" runat="server" Text="Insert into Cassandra" OnClick="btnInsert_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update user" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete (give lastname only)" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
