<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" 
CodeBehind="issue_book_teacher.aspx.cs" Inherits="DIGITALLIBRARY.DL.issue_book_teacher" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
            <td class="style1" colspan="5" width="200" height="70" align="center" 
                bgcolor="#99CCFF">
                <asp:Label ID="lblIssueBook" runat="server" Text="ISSUE BOOK"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Barcode:</td>
            <td class="style5">
                <asp:TextBox ID="txtTCode" runat="server" Width="200px" 
                    ontextchanged="txtTCode_TextChanged" AutoPostBack="True"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td rowspan="7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Teacher Name:</td>
            <td class="style5">
                <asp:DropDownList ID="ddlTeacher" runat="server" 
                    onselectedindexchanged="ddlTeacher_SelectedIndexChanged" Width="200px" 
                    AutoPostBack="True" TabIndex="1" Height="30px">
                </asp:DropDownList>
                <asp:LinkButton ID="lbtnIssueDetails" runat="server" 
                    onclick="lbtnIssueDetails_Click">View Issue Details</asp:LinkButton>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Address:</td>
            <td class="style5">
                <asp:TextBox ID="txtAddress" runat="server" Width="200px" Height="30px"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Email:</td>
            <td class="style5">
                <asp:TextBox ID="txtEmail" runat="server" Width="200px" Height="30px"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Phone No:</td>
            <td class="style5">
                <asp:TextBox ID="txtPhone" runat="server" Width="200px" Height="30px"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Gender</td>
            <td class="style5">
                <asp:TextBox ID="txtGender" runat="server" Width="200px" Height="30px" ontextchanged="txtGender_TextChanged" 
                   ></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:GridView ID="gvIssueBook" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" ShowFooter="True" 
                     Width="1019px" >
                    <Columns>
                        <asp:BoundField HeaderText="SN" DataField="SN" />
                        <asp:TemplateField HeaderText="Barcode">
                            <ItemTemplate>
                                <asp:TextBox ID="txtCode" runat="server" AutoPostBack="True" 
                                    ontextchanged="txtCode_TextChanged" Width="80px"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Book Name">
                            <ItemTemplate>
                                <asp:DropDownList ID="ddlBook" runat="server" Width="200px" AutoPostBack="True" 
                                    onselectedindexchanged="ddlBook_SelectedIndexChanged" >
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Author">
                            <ItemTemplate>
                                <asp:DropDownList ID="ddlAuthor" runat="server" Width="120px" >
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Publication">
                            <ItemTemplate>
                                <asp:DropDownList ID="ddlPublication" runat="server" Width="120px" >
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Edition">
                            <ItemTemplate>
                                <asp:TextBox ID="txtEdition" runat="server" Width="80px"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Issue Date">
                            <ItemTemplate>
                                <asp:TextBox ID="txtIssueDate" runat="server" Width="120px"></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Return Date">
                            <ItemTemplate>
                                <asp:TextBox ID="txtReturnDate" runat="server" Width="120px"></asp:TextBox>
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Right" />
                            <FooterStyle HorizontalAlign="Right" />
                            <FooterTemplate>
                                <%--<asp:Button ID="btnAddBooks" runat="server" Text="ADD BOOK" BackColor="#336666"/>--%>
                                <asp:Button ID="btnAdd" runat="server" Text="Add" Width="120px"  OnClick="btnAdd_Click" BackColor="#336666" />
                            </FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <FooterStyle BackColor="#102040" CssClass="mGrid" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
                <asp:HiddenField id="btnIssue_Id" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style6">
                <asp:Button ID="btnIssue" runat="server" onclick="btnIssue_Click" 
                    Text="Issue Book" Width="135px" />
                <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" 
                    Text="Cancel" Width="135px" />
            </td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
