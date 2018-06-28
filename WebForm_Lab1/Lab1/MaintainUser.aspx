<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaintainUser.aspx.cs" Inherits="Lab1.MaintainUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="BirthDate"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnRefresh" runat="server" Text="Refresh" OnClick="btnRefresh_Click" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
        <asp:GridView ID="grUserInfoList" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanging="grUserInfoList_SelectedIndexChanging">
        </asp:GridView>
    </form>
</body>
</html>
