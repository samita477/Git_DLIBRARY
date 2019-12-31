<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="aboutUs.aspx.cs" Inherits="DIGITALLIBRARY.DL.aboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 738px;
        }
        .style4
        {
            width: 738px;
            text-align: justify;
        }
        .style5
        {
            width: 738px;
            text-align: center;
        }
        .style6
        {
            width: 738px;
            font-size: x-large;
            text-align: center;
        }
        .style7
        {
            width: 738px;
            height: 102px;
        }
        .style8
        {
            height: 102px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
            <td class="style5" style="font-size: x-large">
                &nbsp;ABOUT US</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Digital Library is the best solution for the problem faced in manual system 
                libraries where librarians are flooded with various kind of work. It aims to 
                simplify the system to handle issuing of books, its return, penatly 
                calculationss and make record keeping easier.</td>
            <td>
                <asp:Image ID="ImgLibrary" runat="server" Height="290px" 
                    ImageUrl="~/Images/background.jpg" Width="325px" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                CONTACT US</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Email ID :&nbsp; dlibrary019@gmail.com</td>
            <td>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Contact&nbsp; :&nbsp; 016634666, 015090766</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
