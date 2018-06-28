<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBook.aspx.cs" Inherits="WebApplication1.ViewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
            </Columns>
        </asp:GridView>
    </form>
    <p>
        &nbsp;</p>
    <p>
        <input id="Submit1" type="submit" value="submit" /></p>
    <p>
        &nbsp;</p>
</body>
</html>
