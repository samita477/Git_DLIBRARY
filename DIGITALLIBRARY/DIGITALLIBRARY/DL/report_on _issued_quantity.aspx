﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="report_on _issued_quantity.aspx.cs" Inherits="DIGITALLIBRARY.DL.report_on__issued_quantity" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

        <br />
        Book Name:<asp:TextBox ID="txtBookName" runat="server"></asp:TextBox>
    <asp:Button ID="btnShow" runat="server" onclick="btnShow_Click" Text="Show" />
        <rsweb:ReportViewer ID="rptViewer" runat="server" Width="90%">
        </rsweb:ReportViewer>
        <br />

    </div>
    </form>
</body>
</html>
