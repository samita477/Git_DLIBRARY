<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master"
 AutoEventWireup="true" CodeBehind="subject.aspx.cs" Inherits="DIGITALLIBRARY.DL.subject" EnableEventValidation="false" %>
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
            <asp:Label ID="lblAddsubject" runat="server" Text="SUBJECT"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             Search:<asp:TextBox ID="txtSearchSubject" runat="server" AutoPostBack="True" 
                 ontextchanged="txtSearchSubject_TextChanged" Width="289px"></asp:TextBox>
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
                <asp:TextBox ID="txtboxName" runat="server"></asp:TextBox>
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
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="Save"  BackColor="#343A40" ForeColor="White"
                    Width="80px" />
                <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" BackColor="#343A40" ForeColor="White" 
                    Text="Update" Width="80px" />
                <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click"  BackColor="#343A40" ForeColor="White"
                    Text="Cancel" Width="80px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gvSearchSubject" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                    onselectedindexchanged="gvSubject_SelectedIndexChanged" Width="407px">
                    <Columns>
                        <asp:BoundField DataField="Subject_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Subject_Name" HeaderText="Name" />
                        
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
                <asp:GridView ID="gvSubject_User" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                    onselectedindexchanged="gvSubject_SelectedIndexChanged" Width="410px" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvSubject_User_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Subject_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Subject_Name" HeaderText="Name" />
                        
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
                <asp:GridView ID="gvSubject" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                    onselectedindexchanged="gvSubject_SelectedIndexChanged" Width="651px"
                    AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvSubject_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Subject_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Subject_Name" HeaderText="Name" />
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
                 <asp:HiddenField id="btnSubject_Id" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
