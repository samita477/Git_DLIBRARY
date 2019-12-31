<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="DIGITALLIBRARY.DL.dashboard" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>
                <asp:ImageButton ID="imgStudent" runat="server" Height="79px" 
                    ImageUrl="~/Images/student.png" onclick="imgStudent_Click1" Width="83px" />
                <br /><strong>&nbsp;&nbsp; 
                Student</strong></td>
            <td>
                <asp:ImageButton ID="imgTeacher" runat="server" Height="79px" 
                    ImageUrl="~/Images/teachers-icon.png" onclick="imgTeacher_Click1" 
                    Width="83px" />
                <br />&nbsp; Teacher</td>
            <td>
                <asp:ImageButton ID="imgBook" runat="server" Height="79px" 
                    ImageUrl="~/Images/book.png" onclick="imgBook_Click" Width="83px" />
                <br />&nbsp; Books</td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgIssueBook" runat="server" Height="79px" 
                    ImageUrl="~/Images/issue_book.png" onclick="imgIssueBook_Click" Width="83px" />
                <br />
&nbsp;Issue Books</td>
            <td>
                <br />
                <asp:ImageButton ID="imgReturnBook" runat="server" Height="79px" 
                    ImageUrl="~/Images/return_book.png" onclick="imgReturnBook_Click" 
                    Width="83px" />
                <br />
&nbsp; Return Books<br />
                <br />
                &nbsp; </td>
            <td>
                <asp:ImageButton ID="imgSession" runat="server" Height="79px" 
                    ImageUrl="~/Images/first_day_school_calendar_back_back_to_school_student-512.png" 
                    onclick="imgSession_Click" Width="83px" />
                &nbsp;<br />
                <br />
&nbsp;Semesters</td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgSettings" runat="server" Height="79px" 
                    ImageUrl="~/Images/settings.png" onclick="imgSettings_Click1" Width="83px" />
                <br />
&nbsp;&nbsp; Settings</td>
            <td>
                <asp:ImageButton ID="imgWarning" runat="server" Height="79px" 
                    ImageUrl="~/Images/warning mail.jpg" onclick="imgWarning_Click1" Width="83px" />
                <br />
                Warning Email</td>
            <td>
                <asp:ImageButton ID="imgReport" runat="server" Height="79px" 
                    ImageUrl="~/Images/Report.png" onclick="imgReport_Click1" Width="83px" />
                <br />
                Report</td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="imgAboutUs" runat="server" Height="79px" 
                    ImageUrl="~/Images/contactus.png" onclick="imgAboutUs_Click1" Width="83px" />
                <br />
&nbsp;
&nbsp; About Us<br />
            </td>
            <td>
                <asp:ImageButton ID="imgPersonal" runat="server" Height="79px" 
                    ImageUrl="~/Images/personal info.jpg" onclick="imgPersonal_Click" 
                    Width="83px" />
                <br />
                Personal Settings</td>
            <td>
                <asp:ImageButton ID="imgReport0" runat="server" Height="79px" 
                    ImageUrl="~/Images/user1.png" onclick="imgReport0_Click" Width="83px" />
                <br />
                User</td>
        </tr>
    </table>
</asp:Content>
