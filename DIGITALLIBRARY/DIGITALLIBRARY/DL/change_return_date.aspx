<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="change_return_date.aspx.cs" Inherits="DIGITALLIBRARY.DL.change_return_date" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
        }
        .style4
        {
        }
        .style7
        {
            width: 92px;
            height: 29px;
        }
        .style8
        {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
    <td class="style15" colspan="3" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblChangeReturnDate" runat="server" Text="CHANGE RETURN DATE"></asp:Label>
        </td>
        <tr>
            <td class="style7">
                <strong>
                <asp:ImageButton ID="imgBack" runat="server" Height="30px" 
                    ImageUrl="~/Images/back.png" onclick="imgBack_Click" Width="30px" />
                </strong>
            </td>
            <td class="style8">
                &nbsp;</td>
            <td class="style4" rowspan="6">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                    BorderColor="White" BorderWidth="1px" DayNameFormat="FirstTwoLetters" 
                    Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" 
                    NextMonthText="&gt;&gt;" NextPrevFormat="ShortMonth" 
                    ondayrender="Calendar1_DayRender1" 
                    onselectionchanged="Calendar1_SelectionChanged1" Width="210px" >
                  
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
        </tr>
        <tr>
            <td class="style7">
                New Return Date</td>
            <td class="style8">
                <asp:TextBox ID="txtNewReturnDate" runat="server"></asp:TextBox>
                <asp:ImageButton ID="imgFrom" runat="server" Height="16px" 
                    ImageUrl="~/Images/icons8-color-50.png" onclick="imgFrom_Click" Width="16px" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style8">
                <asp:Button ID="btnChange" runat="server" Text="Change" 
                    onclick="btnChange_Click" />
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" colspan="3">
                <asp:GridView ID="gvNewReturn" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" Width="868px">
                    <Columns>
                        <asp:BoundField DataField="Semester_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Semester_Name" HeaderText="Name" />
                        <asp:BoundField DataField="date_from" HeaderText="Starts From" />
                        <asp:BoundField DataField="date_to" HeaderText="Ends At" />
                        <asp:BoundField DataField="penlty_rate" HeaderText="Penalty per day" />
                        <asp:BoundField DataField="book_student" HeaderText="Book for student" />
                        <asp:BoundField DataField="book_teacher" HeaderText="Book for teacher" />
                        <asp:TemplateField>
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
            <td class="style3" colspan="3">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
