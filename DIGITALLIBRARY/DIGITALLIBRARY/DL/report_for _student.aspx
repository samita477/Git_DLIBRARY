<%@ Page Language="C#" AutoEventWireup="true"CodeBehind="report_for _student.aspx.cs" Inherits="DIGITALLIBRARY.DL.report_for__student" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
*,::after,::before{text-shadow:none!important;box-shadow:none!important}*,::after,::before{box-sizing:border-box;
    font-size: medium;
    font-weight: 700;
    }th{text-align:inherit}</style>
    </head>
    <body>
    <form id="form1" runat="server">
<div>
      <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    From:<asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                <asp:ImageButton ID="imgFrom" runat="server" Height="16px" 
                    ImageUrl="~/Images/download.png" onclick="imgFrom_Click" 
          Width="16px" />
    To:<asp:TextBox ID="txtTo" runat="server" ontextchanged="txtTo_TextChanged"></asp:TextBox>
                <asp:ImageButton ID="imgTo" runat="server" Height="16px" 
                    ImageUrl="~/Images/download.png" onclick="imgTo_Click" 
          Width="16px" />
            &nbsp;<asp:Button ID="btnShow" runat="server" onclick="btnShow_Click" Text="Show" />
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                    BorderColor="White" BorderWidth="1px" DayNameFormat="FirstTwoLetters" 
                    Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" 
                    NextMonthText="&gt;&gt;" NextPrevFormat="ShortMonth" 
                    ondayrender="Calendar1_DayRender1" 
                    onselectionchanged="Calendar1_SelectionChanged1" Width="200px" 
                    CellPadding="1">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            <br />
      <asp:Calendar ID="Calendar2" runat="server" BackColor="White" 
                    BorderColor="White" BorderWidth="1px" DayNameFormat="FirstTwoLetters" 
                    Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" 
                    NextMonthText="&gt;&gt;" NextPrevFormat="ShortMonth" 
                    ondayrender="Calendar2_DayRender" 
                    onselectionchanged="Calendar2_SelectionChanged" Width="200px" 
                    CellPadding="1">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                        VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
    <rsweb:ReportViewer ID="rptViewer" runat="server" Width="100%">
    </rsweb:ReportViewer>
    <br />
    <br />
</div>

</form>
</body>
</html>
