<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" 
CodeBehind="publication.aspx.cs" Inherits="DIGITALLIBRARY.DL.publication" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
    .style5
    {
        height: 39px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style4">
        <tr>
            <td class="style1" colspan="3" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblAddPublication" runat="server" Text="PUBLICATION"></asp:Label>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             Search:<asp:TextBox ID="txtSearchPublication" runat="server" AutoPostBack="True" 
                 ontextchanged="txtSearchPublication_TextChanged" Width="289px"></asp:TextBox>
        </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                </td>
            <td class="style5">
            <asp:Button ID="btnSave" runat="server" Text="SAVE" Width="80px" BackColor="#343A40" ForeColor="White"
                    onclick="btnSave_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" Width="80px" BackColor="#343A40" ForeColor="White" 
                onclick="btnUpdate_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Width="80px" BackColor="#343A40" ForeColor="White"
                    onclick="btnCancel_Click"  />
            </td>
            <td class="style5">
                </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gvSearchPublication" runat="server" 
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" 
                    BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                    GridLines="Horizontal" >
                    <Columns>
                        <asp:BoundField DataField="Publication_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Publication_Name" HeaderText="Name" />
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
                <asp:GridView ID="gvPublication_User" runat="server" 
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" 
                    BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                    GridLines="Horizontal" AllowPaging="True" 
                        PageSize="4" 
                    onpageindexchanging="gvPublication_User_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Publication_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Publication_Name" HeaderText="Name" />
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
                <asp:GridView ID="gvPublication" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                    onselectedindexchanged="gvPublication_SelectedIndexChanged" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvPublication_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Publication_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Publication_Name" HeaderText="Name" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" onclick="btnEdit_Click" Text="Edit" 
                                BackColor="#343A40" ForeColor="White"
                                    Width="80px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click"
                                BackColor="Maroon" ForeColor="White" 
                                    Text="Delete" Width="80px" />
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
                  <asp:HiddenField id="btnPublication_Id" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
