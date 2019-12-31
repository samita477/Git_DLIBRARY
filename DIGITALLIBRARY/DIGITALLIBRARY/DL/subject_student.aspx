<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DDL.Master" AutoEventWireup="true" 
CodeBehind="subject_student.aspx.cs" Inherits="DIGITALLIBRARY.DL.subject_student"  EnableEventValidation="false"%>
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
    <td class="style15" colspan="2" height="70" align="center" 
                bgcolor="#99CCFF">
                <asp:Label ID="lblAddbook" runat="server" Text="SUBJECTS"></asp:Label>
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
                <asp:GridView ID="gvSubject" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                    onselectedindexchanged="gvSubject_SelectedIndexChanged" Width="971px" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvSubject_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Subject_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Subject_Name" HeaderText="Name" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnViewDetails" runat="server" Text="View Details" BackColor="#336666"
                                    Width="152px" onclick="btnViewDetails_Click" />
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
                <asp:HiddenField id="btnSubject_Id" runat="server" />
                 </td>
        </tr>
    </table>
</asp:Content>
