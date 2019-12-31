<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="DIGITALLIBRARY.DL.department" EnableEventValidation="false"%>
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
            <td class="style1" colspan="3" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblAdddepartment" runat="server" Text="DEPARTMENT"></asp:Label>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               &nbsp;&nbsp;&nbsp;
              
              
             Search:<asp:TextBox ID="txtSearchDepartment" runat="server" AutoPostBack="True" 
                 ontextchanged="txtSearchDepartment_TextChanged" Width="200px"></asp:TextBox>
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
                Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
            <asp:Button ID="btnSave" runat="server" Text="SAVE" Width="80px"  BackColor="#343A40" ForeColor="White"
                    onclick="btnSave_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" Width="80px"  BackColor="#343A40" ForeColor="White"
                onclick="btnUpdate_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Width="80px"  BackColor="#343A40" ForeColor="White"
                    onclick="btnCancel_Click"  />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gvSearchDepartment" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="3" GridLines="Horizontal" Width="501px" >
                    <Columns>
                        <asp:BoundField DataField="Department_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Department_Name" HeaderText="Name" />
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
            <td colspan="3">
                <asp:GridView ID="gvDepartment_User" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="3" GridLines="Horizontal" Width="497px" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvDepartment_User_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Department_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Department_Name" HeaderText="Name" />
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
                <asp:GridView ID="gvDepartment" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="3" GridLines="Horizontal" Width="572px" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvDepartment_PageIndexChanging" >
                    <Columns>
                        <asp:BoundField DataField="Department_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Department_Name" HeaderText="Name" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" onclick="btnEdit_Click" Text="Edit"  BackColor="#343A40" ForeColor="White"
                                    Width="80px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" BackColor="Maroon" ForeColor="White" 
                                    Text="Delete" Width="80px" />
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
                <asp:HiddenField id="btnDepartment_Id" runat="server" />
                  </td>
        </tr>
    </table>
</asp:Content>
