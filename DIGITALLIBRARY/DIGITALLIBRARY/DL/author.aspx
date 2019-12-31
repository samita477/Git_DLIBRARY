<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true"
    CodeBehind="author.aspx.cs" Inherits="DIGITALLIBRARY.DL.author" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
            <td class="style15" colspan="3" height="70" align="center" bgcolor="#99CCFF">
                <asp:Label ID="lblAuthor" runat="server" Text="AUTHOR"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Search:<asp:TextBox ID="txtSearchAuthor" runat="server" AutoPostBack="True" OnTextChanged="txtSearchAuthor_TextChanged"
                    Width="289px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;
            </td>
        </tr>
        </tr>
        <tr>
            <td>
                Name:
            </td>
            <td>
                <asp:TextBox ID="txtboxName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="SAVE" Width="80px" OnClick="btnSave_Click"
                    BackColor="#343A40" ForeColor="White" />
                <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" Width="80px" OnClick="btnUpdate_Click"
                    BackColor="#343A40" ForeColor="White" />
                <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Width="80px" OnClick="btnCancel_Click"
                    BackColor="#343A40" ForeColor="White" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gvSearchAuthor" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4"
                    GridLines="Horizontal" Width="569px">
                    <Columns>
                        <asp:BoundField DataField="Author_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Author_name" HeaderText="Name" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gvAuthor_User" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4"
                    GridLines="Horizontal" Width="569px" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvAuthor_User_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Author_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Author_name" HeaderText="Name" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
                <asp:GridView ID="gvAuthor" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4"
                    GridLines="Horizontal" 
                    OnSelectedIndexChanged="gvAuthor_SelectedIndexChanged" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvAuthor_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Author_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Author_name" HeaderText="Name" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="80px"
                                    BackColor="#343A40" ForeColor="White" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete"
                                    Width="80px" BackColor="Maroon" ForeColor="White" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
                <asp:HiddenField ID="btnAuthor_Id" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
