<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="AllBook.aspx.cs" Inherits="WebApplication1.AllBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="BookID" DataSourceID="SqlDataSource1" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <td runat="server" style="background-color:#FFF8DC;">BookID:
                <asp:Label ID="BookIDLabel" runat="server" Text='<%# Eval("BookID") %>' />
                <br />BookName:
                <asp:Label ID="BookNameLabel" runat="server" Text='<%# Eval("BookName") %>' />
                <br />BookPrice:
                <asp:Label ID="BookPriceLabel" runat="server" Text='<%# Eval("BookPrice") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <td runat="server" style="background-color:#008A8C;color: #FFFFFF;">BookID:
                <asp:Label ID="BookIDLabel1" runat="server" Text='<%# Eval("BookID") %>' />
                <br />BookName:
                <asp:TextBox ID="BookNameTextBox" runat="server" Text='<%# Bind("BookName") %>' />
                <br />BookPrice:
                <asp:TextBox ID="BookPriceTextBox" runat="server" Text='<%# Bind("BookPrice") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">BookID:
                <asp:TextBox ID="BookIDTextBox" runat="server" Text='<%# Bind("BookID") %>' />
                <br />BookName:
                <asp:TextBox ID="BookNameTextBox" runat="server" Text='<%# Bind("BookName") %>' />
                <br />BookPrice:
                <asp:TextBox ID="BookPriceTextBox" runat="server" Text='<%# Bind("BookPrice") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="background-color:#DCDCDC;color: #000000;">BookID:
                <asp:Label ID="BookIDLabel" runat="server" Text='<%# Eval("BookID") %>' />
                <br />BookName:
                <asp:Label ID="BookNameLabel" runat="server" Text='<%# Eval("BookName") %>' />
                <br />BookPrice:
                <asp:Label ID="BookPriceLabel" runat="server" Text='<%# Eval("BookPrice") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </table>
            <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        <asp:NumericPagerField />
                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">BookID:
                <asp:Label ID="BookIDLabel" runat="server" Text='<%# Eval("BookID") %>' />
                <br />BookName:
                <asp:Label ID="BookNameLabel" runat="server" Text='<%# Eval("BookName") %>' />
                <br />BookPrice:
                <asp:Label ID="BookPriceLabel" runat="server" Text='<%# Eval("BookPrice") %>' />
                <br />
                <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
            </td>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" DeleteCommand="DELETE FROM [Books] WHERE [BookID] = @original_BookID AND (([BookName] = @original_BookName) OR ([BookName] IS NULL AND @original_BookName IS NULL)) AND (([BookPrice] = @original_BookPrice) OR ([BookPrice] IS NULL AND @original_BookPrice IS NULL))" InsertCommand="INSERT INTO [Books] ([BookID], [BookName], [BookPrice]) VALUES (@BookID, @BookName, @BookPrice)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Books]" UpdateCommand="UPDATE [Books] SET [BookName] = @BookName, [BookPrice] = @BookPrice WHERE [BookID] = @original_BookID AND (([BookName] = @original_BookName) OR ([BookName] IS NULL AND @original_BookName IS NULL)) AND (([BookPrice] = @original_BookPrice) OR ([BookPrice] IS NULL AND @original_BookPrice IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_BookID" Type="Int32" />
            <asp:Parameter Name="original_BookName" Type="String" />
            <asp:Parameter Name="original_BookPrice" Type="Double" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="BookID" Type="Int32" />
            <asp:Parameter Name="BookName" Type="String" />
            <asp:Parameter Name="BookPrice" Type="Double" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="BookName" Type="String" />
            <asp:Parameter Name="BookPrice" Type="Double" />
            <asp:Parameter Name="original_BookID" Type="Int32" />
            <asp:Parameter Name="original_BookName" Type="String" />
            <asp:Parameter Name="original_BookPrice" Type="Double" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
