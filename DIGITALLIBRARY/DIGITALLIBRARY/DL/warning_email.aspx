<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" 
CodeBehind="warning_email.aspx.cs" Inherits="DIGITALLIBRARY.DL.warning_email" EnableEventValidation="false"%>
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
            <asp:Label ID="lblSendWarning" runat="server" Text="Student with nearer Return date"></asp:Label>
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
            <td colspan="3">
                <asp:GridView ID="gvEmail" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" AllowPaging="True" 
                        PageSize="4">
                    <Columns>
                        <asp:BoundField DataField="IM_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Student_Name" HeaderText="Student Name" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnSend" runat="server" onclick="btnSend_Click" 
                                    Text="Send Email" BackColor="#336666" Font-Bold="True" ForeColor="White" />
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
                  <asp:HiddenField id="btnIM_Id" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
