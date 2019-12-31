<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" 
CodeBehind="new_session.aspx.cs" Inherits="DIGITALLIBRARY.DL.new_session" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            height: 39px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
                 <td class="style15" colspan="4" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblSelectSession" runat="server" Text="SEMESTER"></asp:Label>
        </td>
        </tr>
        <tr>
            <td>
                Session Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                    BorderColor="White" BorderWidth="1px" DayNameFormat="FirstTwoLetters" 
                    Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" 
                    NextMonthText="&gt;&gt;" NextPrevFormat="ShortMonth" 
                    ondayrender="Calendar1_DayRender1" 
                    onselectionchanged="Calendar1_SelectionChanged1" Width="200px" 
                    CellPadding="1">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Starts 
                From:</td>
            <td>
                <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                <asp:ImageButton ID="imgFrom" runat="server" Height="16px" 
                    ImageUrl="~/Images/download.png" onclick="imgFrom_Click" Width="16px" />
            </td>
            <td rowspan="7">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                &nbsp;<asp:Calendar ID="Calendar2" runat="server" BackColor="White" 
                    BorderColor="White" BorderWidth="1px" DayNameFormat="FirstTwoLetters" 
                    Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" 
                    NextMonthText="&gt;&gt;" NextPrevFormat="ShortMonth" 
                    ondayrender="Calendar2_DayRender1" 
                    onselectionchanged="Calendar2_SelectionChanged1" Width="200px" 
                    CellPadding="1">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Ends At:</td>
            <td>
                <asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
                <asp:ImageButton ID="imgTo" runat="server" Height="16px" 
                    ImageUrl="~/Images/download.png" onclick="imgTo_Click" Width="16px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Penalty Rate(per day) RS:</td>
            <td>
                <asp:TextBox ID="txtPenalty" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Book Numbers&nbsp;(Per 
                Student)</td>
            <td>
                <asp:TextBox ID="txtbookStudent" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Book Numbers(Per Teacher)</td>
            <td>
                <asp:TextBox ID="txtbookteacher" runat="server"></asp:TextBox>
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
            <td class="style3">
                </td>
            <td class="style3">
                <asp:Button ID="btnCreate" runat="server" onclick="btnCreate_Click" 
                    Text="Create Session" Width="120px" BackColor="#343A40" ForeColor="White" />
                <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
                    Text="Update" Width="120px" BackColor="#343A40" ForeColor="White"/>
                <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" 
                    Text="Cancel" Width="120px" BackColor="#343A40" ForeColor="White" />
            </td>
            <td class="style3">
                </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="gvSession" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                    onselectedindexchanged="gvSession_SelectedIndexChanged" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvSession_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Semester_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Semester_Name" HeaderText="Name" />
                        <asp:BoundField DataField="date_from" HeaderText="From" />
                        <asp:BoundField DataField="date_to" HeaderText="To" />
                        <asp:BoundField DataField="penlty_rate" HeaderText="Penaltly Rate" />
                        <asp:BoundField DataField="book_student" HeaderText="Book for student" />
                        <asp:BoundField DataField="book_teacher" HeaderText="Book for teacher" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" BackColor="#336666" ForeColor="White" 
                                    onclick="btnEdit_Click2" Text="Edit" Width="120px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" BackColor="Maroon" ForeColor="White" 
                                    onclick="btnDelete_Click1" Text="Delete" Width="120px" />
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
</asp:Content>
