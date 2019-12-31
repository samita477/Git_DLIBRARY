<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstudent.aspx.cs" 
EnableEventValidation="false"Inherits="DIGITALLIBRARY.DL.viewstudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
*,::after,::before{text-shadow:none!important;box-shadow:none!important}*,::after,::before{box-sizing:border-box;
    font-size: medium;
    font-weight: 700;
    font-style: italic;
    text-align: left;
}table{border-collapse:collapse;
    margin-right: 578px;
    margin-top: 55px;
}th{text-align:inherit}[type=reset],[type=submit],button,html [type=button]{-webkit-appearance:button;
    text-align: center;
    margin-bottom: 0px;
}button,input{overflow:visible;
    text-align: left;
    margin-left: 0px;
    margin-top: 0px;
    margin-bottom: 0px;
}button,input,optgroup,select,textarea{font-family:inherit;font-size:inherit;line-height:inherit;
    margin-right: 0;
    }
        .style3
        {
            width: 100%;
        }
        .style4
        {
            font-style: normal;
        }
    </style>

  </head>
<body>
   
               
    <form id="form1" runat="server">
    <div>
    <table class="style2">
            <td class="style15" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblViewStudent" runat="server" Text="VIEW STUDENT"></asp:Label>
        </td>
            <tr>
            <td>
                <asp:ImageButton ID="imgBack" runat="server" Height="30px" 
                    ImageUrl="~/Images/back.png" onclick="imgBack_Click" Width="30px" />
                </td>
            </tr>
        <tr>
            <td>
                    <asp:GridView ID="gvViewStudent" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                        CellPadding="4" GridLines="Horizontal" Width="962px" 
                    onselectedindexchanged="gvViewStudent_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField HeaderText="Student ID" DataField="Student_ID" />
                            <asp:BoundField HeaderText="Student Name" DataField="Student_Name" />
                            <asp:BoundField HeaderText="Address" DataField="_address" />
                            <asp:BoundField HeaderText="Email ID" DataField="email" />
                            <asp:BoundField HeaderText="Phone no" DataField="ph_no" />
                            <asp:BoundField HeaderText="Gender" DataField="gender" />
                            <asp:BoundField DataField="crn" HeaderText="CRN" />                           
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                    </asp:GridView>
                     </td>
        </tr>
    </table>
    </div>
    </form>
   
               
    </body>
</html>
