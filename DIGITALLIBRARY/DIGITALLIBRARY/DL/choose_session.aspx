<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choose_session.aspx.cs" Inherits="DIGITALLIBRARY.DL.choose_session" enableEventValidation="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
       <table class="style2">
        <tr>
               <td class="style15" colspan="3" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblSelectSession" runat="server" Text="SELECT SEMESTER"></asp:Label>
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
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" Width="868px" AllowPaging="True" 
                        PageSize="4">
                    <Columns>
                        <asp:BoundField DataField="Semester_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Semester_Name" HeaderText="Name" />
                        <asp:BoundField DataField="date_from" HeaderText="Starts From" />
                        <asp:BoundField DataField="date_to" HeaderText="Ends At" />
                        <asp:BoundField DataField="penlty_rate" HeaderText="Penalty per day" />
                        <asp:BoundField DataField="book_student" HeaderText="Book for student" />
                        <asp:BoundField DataField="book_teacher" HeaderText="Book for teacher" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnSelect" runat="server" BackColor="#336666" ForeColor="White" 
                                    onclick="btnSelect_Click" Text="Select This Session" />
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
                 <asp:HiddenField id="btnSession_Id" runat="server" />
            </td>
        </tr>
    </table>
  </div>
  </form>
  </body>
  </html>

