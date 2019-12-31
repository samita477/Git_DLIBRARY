<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true"
 CodeBehind="return_books_teacher.aspx.cs" Inherits="DIGITALLIBRARY.DL.return_books_teacher" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
    <tr>
        <td class="style1" colspan="2" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblReturnBooks" runat="server" Text="RETURN BOOKS" ></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="imgbtnRefresh" runat="server" Height="35px" 
                    ImageUrl="~/Images/refresh-512.png"  
                    Width="47px" onclick="imgbtnRefresh_Click1" />
        </td>
    </tr>
    <tr>
        <td class="style4">
            BarCode:</td>
        <td class="style3">
            <asp:TextBox ID="txtCode" runat="server" Width="200px" AutoPostBack="True" 
                ontextchanged="txtCode_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Teacher Name</td>
        <td class="style3">
            <asp:DropDownList ID="ddlStudent" runat="server" 
                  Width="200px" onselectedindexchanged="ddlStudent_SelectedIndexChanged" 
                    AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style4">
                Address:</td>
        <td class="style3">
            <asp:TextBox ID="txtAddress" runat="server" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
                Email:</td>
        <td class="style3">
            <asp:TextBox ID="txtEmail" runat="server" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
                Gender:</td>
        <td class="style3">
            <asp:TextBox ID="txtGender" runat="server" Width="200px" 
                   ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
                Phone No:</td>
        <td class="style3">
            <asp:TextBox ID="txtPhone" runat="server" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
                &nbsp;</td>
        <td class="style3">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style3">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" 
                    BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                    GridLines="Horizontal" Width="939px">
                <Columns>
                    <asp:BoundField DataField="IMT_ID" HeaderText="Master ID" />
                    <asp:BoundField DataField="IDT_ID" HeaderText="Detail ID" />
                    <asp:BoundField DataField="Book_Name" HeaderText="Book Name" />
                    <asp:BoundField DataField="Author_Name" HeaderText="Author" />
                    <asp:BoundField DataField="Publication_Name" HeaderText="Publication" />
                    <asp:BoundField DataField="issue_date" HeaderText="Issue Date" />
                    <asp:BoundField DataField="Return_Date" HeaderText="Return Date" />
                    <asp:TemplateField HeaderText="Return">
                        <ItemTemplate>
                            <asp:Button ID="btn_Return" runat="server" onclick="btn_Return_Click" BackColor="#336666"
                                 ForeColor="White" Text="Return" Width="80px" />
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
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:HiddenField id="btnReturn_Id" runat="server" />
        </td>
    </tr>
</table>
</asp:Content>
