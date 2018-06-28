<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script runat="server">

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <%--Password<input id="Password1" type="password" />--%>
            Password<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
