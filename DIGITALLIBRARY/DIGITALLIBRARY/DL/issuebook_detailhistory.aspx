<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" 
CodeBehind="issuebook_detailhistory.aspx.cs" Inherits="DIGITALLIBRARY.DL.issuebook_detailhistory" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
            height: 73px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
            <td>
     <table class="style2">
            <td class="style15" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblIssueDetailHistory" runat="server" Text="View Issue Detail History"></asp:Label>
        </td>
        <tr>
            <td>
                <asp:ImageButton ID="imgBack" runat="server" Height="30px" 
                    ImageUrl="~/Images/back.png" onclick="imgBack_Click" Width="30px" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvIssuedetails" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" Width="940px">
                    <Columns>
                        <asp:BoundField DataField="ID_ID" HeaderText="Id" />
                        <asp:BoundField DataField="Book_Name" HeaderText="Book Name" />
                        <asp:BoundField DataField="Author_Name" HeaderText="Author" />
                        <asp:BoundField DataField="Publication_Name" HeaderText="Publication" />
                        <asp:BoundField DataField="issue_date" HeaderText="Issue Date" />
                        <asp:BoundField DataField="return_date" HeaderText="Return Date" />
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
            </td>
        </tr>
     </asp:Content>
