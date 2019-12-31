<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" 
CodeBehind="settings_admin.aspx.cs" Inherits="DIGITALLIBRARY.DL.settings_admin" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="style2">
            <td class="style15" colspan="4" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblSettingAdmin" runat="server" Text="GENERAL INFORMATION"></asp:Label>
        </td>
        <tr>
            <td class="style3">
                Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="215px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Password:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="215px" 
                    ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Address:</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" Width="215px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Phone No:</td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server" Width="215px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Email ID:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="215px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Gender:</td>
            <td>
                <asp:TextBox ID="txtGender" runat="server" Width="215px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Type:</td>
            <td>
                <asp:TextBox ID="txtType" runat="server" Width="215px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="101px" BackColor="#343A40" ForeColor="White"
                    onclick="btnUpdate_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                <asp:LinkButton ID="lbtnReset" runat="server" onclick="lbtnReset_Click">Reset Password</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
