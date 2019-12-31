<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" 
CodeBehind="viewteacher.aspx.cs" Inherits="DIGITALLIBRARY.DL.viewteacher" EnableEventValidation="false"%>
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
            <td class="style15" colspan="3" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblAddStudent" runat="server" Text="TEACHER DETAIL"></asp:Label>
        </td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgBack" runat="server" Height="30px" 
                    ImageUrl="~/Images/back.png" onclick="imgBack_Click" Width="30px" />
            </td>
            <td>
                &nbsp;</td>
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
            <td colspan="3">
                <asp:GridView ID="gvTeacher_User" runat="server" 
                        AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" 
                        BorderStyle="Double" BorderWidth="3px" CellPadding="3" GridLines="Horizontal" 
                        Width="962px">
                    <Columns>
                        <asp:BoundField DataField="Teacher_ID" HeaderText="Teacher ID" />
                        <asp:BoundField DataField="Teacher_Name" HeaderText="Teacher Name" />
                        <asp:BoundField DataField="_address" HeaderText="Address" />
                        <asp:BoundField DataField="email" HeaderText="Email ID" />
                        <asp:BoundField DataField="ph_no" HeaderText="Phone no" />
                        <asp:BoundField DataField="gender" HeaderText="Gender" />
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
