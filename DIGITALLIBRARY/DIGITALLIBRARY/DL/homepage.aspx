<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="DIGITALLIBRARY.DL.homepage" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>
                <asp:ImageButton ID="ImgStudent" runat="server" Width="80px" allign="centre" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/student.png" 
                    onclick="ImgStudent_Click" />
                <br />
                <strong>&nbsp;&nbsp; 
                Student</strong></td>
            <td>
                <asp:ImageButton ID="ImgTeacher" runat="server" Width="80px" allign="centre" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/teachers-icon.png" 
                    onclick="ImgTeacher_Click" />
                <br />
                &nbsp; Teacher</td>
            <td>
                <asp:ImageButton ID="ImgBooks" runat="server" Width="80px" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/book.png" 
                    onclick="ImgBooks_Click" />
                <br />
                &nbsp; Books</td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="ImgIssue" runat="server" Width="80px" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/issue_book.png" 
                    onclick="ImgIssue_Click" />
                <br />
                &nbsp;&nbsp; Issue Books</td>
            <td>
                <asp:ImageButton ID="ImgReturn" runat="server" Width="80px" allign="centre" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/return_book.png" 
                    onclick="ImgReturn_Click" />
                <br />
&nbsp; Return Books</td>
            <td>
                <asp:ImageButton ID="ImgSettings" runat="server" Width="80px" allign="centre" 
                    ImageAlign="AbsMiddle" onclick="ImgPenatly_Click" 
                    ImageUrl="~/Images/settings.png" />
                <br />
&nbsp;Settings</td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="ImgWarning" runat="server" Width="80px" allign="centre" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/warning mail.jpg" 
                    onclick="ImgWarning_Click" />
                <br />
                Warning Email</td>
            <td>
                <asp:ImageButton ID="ImgReport" runat="server" Width="80px" allign="centre" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/Report.png" 
                    onclick="ImgReport_Click" />
                <br />
                Report</td>
            <td>
                <asp:ImageButton ID="ImgAboutus" runat="server" Width="80px" allign="centre" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/contactus.png" 
                    onclick="ImgAboutus_Click" />
                <br />
&nbsp;About Us</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
