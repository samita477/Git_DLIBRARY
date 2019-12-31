<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="viewbook.aspx.cs" Inherits="DIGITALLIBRARY.DL.viewbook" %>
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
           <td class="style15" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblViewbook" runat="server" Text="VIEW BOOK"></asp:Label>
        </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgBack" runat="server" Height="30px" 
                    ImageUrl="~/Images/back.png" onclick="imgBack_Click" Width="30px" />
            </td>
            <td>
            </td>
            <td>
            </td>
            </tr>
            <tr>
                <td>
                <asp:GridView ID="gvViewbook" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                        onselectedindexchanged="gvViewbook_SelectedIndexChanged1">
                    <Columns>
                        <asp:BoundField DataField="Book_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Book_Name" HeaderText="Name" />
                        <asp:BoundField DataField="Page" HeaderText="Page no" />
                        <asp:BoundField DataField="price" HeaderText="Price" />
                        <asp:BoundField DataField="edition" HeaderText="Edition" />
                        <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="avl_quantity" HeaderText="Available Quantity" />
                        <asp:BoundField DataField="date_of_entry" HeaderText="Entry Date" />
                        <asp:BoundField DataField="Subject_Name" HeaderText="Subject Name" />
                        <asp:BoundField DataField="Author_Name" HeaderText="Author" />
                        <asp:BoundField DataField="Publication_Name" HeaderText="Publication " />
                        <asp:BoundField DataField="Supplier_Name" HeaderText="Supplier" />
                        <asp:TemplateField>
                        </asp:TemplateField>
                        <asp:TemplateField>
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
                </td>
            </tr>
    </table>
</asp:Content>
