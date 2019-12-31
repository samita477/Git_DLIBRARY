<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DDL.Master" AutoEventWireup="true" CodeBehind="dashboard_teacher.aspx.cs" Inherits="DIGITALLIBRARY.DL.dashboard_teacher" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 921px;
        }
        .style3
        {
            width: 329px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
            <td>
                <asp:ImageButton ID="ImgBook" runat="server" Height="96px" ImageAlign="Middle" 
                    ImageUrl="~/Images/book.png" onclick="ImgBook_Click" Width="110px" />
                <br />
&nbsp;Books</td>
            <td>
                <asp:ImageButton ID="ImgSubject" runat="server" Height="96px" 
                    ImageAlign="Middle" ImageUrl="~/Images/subject.png" 
                    Width="110px" onclick="ImgSubject_Click" />
                <br />
                Subjects</td>
            <td class="style3">
                <asp:ImageButton ID="ImgReturn" runat="server" Width="80px" allign="centre" 
                    ImageAlign="AbsMiddle" ImageUrl="~/Images/return_book.png" 
                    onclick="ImgReturn_Click" />
                <br />
                Books Issued</td>
        </tr>
        <tr>
            <td class="text-center">
                &nbsp;
                <asp:ImageButton ID="ImgSettings" runat="server" Height="96px" 
                    ImageAlign="Middle" ImageUrl="~/Images/settings.png" 
                     Width="110px" onclick="ImgSettings_Click" />
                <br />
                Settings</td>
            <td>
                &nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImgAboutus" runat="server" Height="96px" 
                    ImageAlign="Middle" ImageUrl="~/Images/contactus.png" 
                     Width="110px" onclick="ImgAboutus_Click" />
                <br />
                About Us</td>
            <td class="style3">
                &nbsp; </td>
        </tr>
        <tr>
            <td class="text-center">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>
