<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DDL.Master" AutoEventWireup="true" 
CodeBehind="subjectdetail_student.aspx.cs" Inherits="DIGITALLIBRARY.DL.subjectdetail_student" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
            font-style: italic;
        }
        .style3
        {
            font-weight: 700;
        }
        .style4
        {
            font-weight: normal;
            font-style: normal;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
            <td class="style3" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblFileUpload" runat="server" Text="FILE UPLOAD"></asp:Label>
        </td>
        </table>
    <table class="style2">
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                <strong>Subject Name:</strong></td>
            <td>
                <asp:DropDownList ID="ddlSubject" runat="server" 
                    onselectedindexchanged="ddlSubject_SelectedIndexChanged" Width="200px" 
                    CssClass="font-italic">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="font-italic" />
                <asp:Button ID="btnSave" runat="server" BackColor="#343A40" ForeColor="White" 
                    onclick="btnSave_Click" Text="Upload" Width="80px" 
                    CssClass="font-italic" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" onrowcommand="GridView1_RowCommand" 
                    Width="749px" CssClass="style3">
                    <Columns>
                        <asp:TemplateField HeaderText="File">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" 
                                    CommandArgument='<%# Eval("File") %>' CommandName="Download" 
                                    Text='<%# Eval("File") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Size" HeaderText="Size in Bytes" />
                        <asp:BoundField DataField="Type" HeaderText="File Type" />
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
            <td colspan="3" class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
