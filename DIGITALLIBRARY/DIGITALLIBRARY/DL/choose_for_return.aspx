<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="choose_for_return.aspx.cs" Inherits="DIGITALLIBRARY.DL.choose_for_return" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 538px;
        }
        .style3
        {
            width: 202px;
        }
        .style4
        {
            width: 243px;
        }
        .style5
        {
            width: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
            <td class="style15" colspan="3" height="70" align="center" 
                bgcolor="#99CCFF">
                <asp:Label ID="lblAuthor" runat="server" Text="Return Books For:"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                <asp:ImageButton ID="imgStudent" runat="server" Height="100px" 
                    ImageUrl="~/Images/student.png" onclick="imgStudent_Click" Width="129px" />
                <br />&nbsp;&nbsp; Students:</td>
            <td class="style4">
                <asp:ImageButton ID="imgTeacher" runat="server" Height="100px" 
                    ImageUrl="~/Images/teachers-icon.png" onclick="imgTeacher_Click" 
                    Width="170px" />
                <br />&nbsp; Teachers:</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
