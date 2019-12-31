<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="choose_for_issue.aspx.cs" Inherits="DIGITALLIBRARY.DL.choose_for_issue" EnableEventValidation="false" %>
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
            <asp:Label ID="lblAuthor" runat="server" Text="Issue Books For:"></asp:Label>
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
                <asp:ImageButton ID="imgStudent" runat="server" Height="100px" 
                    ImageUrl="~/Images/student.png" onclick="imgStudent_Click" Width="129px" />
                <br />
&nbsp;&nbsp; Students:</td>
            <td>
                <asp:ImageButton ID="imgTeacher" runat="server" Height="100px" 
                    ImageUrl="~/Images/teachers-icon.png" onclick="imgTeacher_Click" 
                    Width="129px" />
                <br />
&nbsp; Teachers:</td>
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
    </table>
</asp:Content>
