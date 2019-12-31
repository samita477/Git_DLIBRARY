<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="change_no_of_issuedbook.aspx.cs" Inherits="DIGITALLIBRARY.DL.change_no_of_issuedbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 598px;
        }
        .style3
        {
            width: 587px;
        }
        .style4
        {
            width: 498px;
        }
        .style5
        {
            width: 464px;
        }
        .style6
        {
            width: 299px;
        }
        .style7
        {
            height: 74px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <td class="style7" colspan="3" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblChangeReturnDate" runat="server" Text="SET NEW NUMBER OF BOOKS FOR STUDENT"></asp:Label>
        </td>
        <tr>
            <td class="style4">
                <strong>
                <asp:ImageButton ID="imgBack" runat="server" Height="30px" 
                    ImageUrl="~/Images/back.png" onclick="imgBack_Click" Width="30px" />
                </strong>
            </td>
            <td class="style6">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                New number of book:</td>
            <td class="style6">
                <asp:TextBox ID="txtNewReturnDate" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style6">
                <asp:Button ID="btnChange" runat="server" Text="Change" 
                    onclick="btnChange_Click" />
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" colspan="3">
                <asp:GridView ID="gvNewnumber" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" Width="868px">
                    <Columns>
                        <asp:BoundField DataField="Semester_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Semester_Name" HeaderText="Name" />
                        <asp:BoundField DataField="date_from" HeaderText="Starts From" />
                        <asp:BoundField DataField="date_to" HeaderText="Ends At" />
                        <asp:BoundField DataField="penlty_rate" HeaderText="Penalty per day" />
                        <asp:BoundField DataField="book_student" HeaderText="Book for student" />
                        <asp:BoundField DataField="book_teacher" HeaderText="Book for teacher" />
                        <asp:TemplateField></asp:TemplateField>
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
            <td class="style3" colspan="3">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
