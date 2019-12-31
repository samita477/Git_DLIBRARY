<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="setting_other.aspx.cs" Inherits="DIGITALLIBRARY.DL.setting_other" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
             
             <td class="style15" colspan="3" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblBookIssued" runat="server" Text="Settings"></asp:Label>
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
                <asp:Label ID="lbldate" runat="server" Text="Return Date"></asp:Label>
                <asp:Label ID="lblSBook" runat="server" Text="No. of book for student"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtSBook" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:LinkButton ID="LbtnChangeRD" runat="server" onclick="LbtnChangeRD_Click">Change Return Date For This Semester</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTbook" runat="server" Text="No. of book for teacher"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTBook" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:LinkButton ID="lbtnChangeBS" runat="server" onclick="lbtnChangeBS_Click">Change Book Limitation</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Change Date" 
                    onclick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Change Book Number" 
                    Width="175px" onclick="Button2_Click" />
            </td>
            <td>
                &nbsp;</td>
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
    </table>
</asp:Content>
