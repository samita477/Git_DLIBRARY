<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="allreport.aspx.cs" Inherits="DIGITALLIBRARY.DL.allreport" %>
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
            <td class="style15" colspan="2" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblreport" runat="server" Text="REPORTS"></asp:Label>
        </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Report on the basis of issued book(book name)</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Report on the basis of issued date(time)</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="linkbutton3" runat="server" onclick="linkbutton3_Click">Report on the basis of issued quantity</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
