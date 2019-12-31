<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DDL.Master" AutoEventWireup="true"
 CodeBehind="issuebook_student.aspx.cs" Inherits="DIGITALLIBRARY.DL.issuebook_student" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 97%;
            height: 0px;
        }
        .style3
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
             <td class="style15" colspan="6" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblBookIssued" runat="server" Text="BOOK ISSUED"></asp:Label>
        </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gvIssuedetails" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" Width="940px" 
                    onselectedindexchanged="gvIssuedetails_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Id_ID" HeaderText="Id" />
                        <asp:BoundField DataField="Book_name" HeaderText="Book Name" />
                         <asp:BoundField DataField="Issue_date" HeaderText="Issue Date" />
                        <asp:BoundField DataField="Return_date" HeaderText="Return Date" />
                        <asp:BoundField DataField="Penalty" HeaderText="Penalty" />
                        <%--<asp:TemplateField HeaderText="Penalty">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbtnPenalty" runat="server" Text='<%Eval("Penalty")%>'></asp:LinkButton>
                        </ItemTemplate>
                        </asp:TemplateField>--%>
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
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" Width="940px" 
                    onselectedindexchanged="gvIssuedetails_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Id_ID" HeaderText="Id" />
                        <asp:BoundField DataField="Book_name" HeaderText="Book Name" />
                        <asp:BoundField DataField="Issue_date" HeaderText="Issue Date" />
                        <asp:BoundField DataField="Return_date" HeaderText="Return Date" />
                       <%-- <asp:BoundField DataField="Penalty" HeaderText="Penalty" />--%>
                        <%--<asp:TemplateField HeaderText="Penalty">
                        <ItemTemplate>
                            <asp:LinkButton ID="lbtnPenalty" runat="server" Text='<%Eval("Penalty")%>'></asp:LinkButton>
                        </ItemTemplate>
                        </asp:TemplateField>--%>
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
