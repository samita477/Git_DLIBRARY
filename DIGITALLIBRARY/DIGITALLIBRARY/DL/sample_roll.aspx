<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sample_roll.aspx.cs" Inherits="DIGITALLIBRARY.DL.sample_roll" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        
        .main
        {
            width: 1000px;
            height: 300px;
            border: solid 1px Green;
            margin: 0 auto;
        }
        
        .foot
        {
            width: 1000px;
            height: 200px;
            border: solid 1px Black;
            margin: 0 auto;
            background: #fff;
            color: #000;
            text-align: center;
            vertical-align: middle;
        }
    </style>
    <script type="text/javascript">
        $(window).bind("load", function () {
            var footer = $("#footer");
            var pos = footer.position();
            var height = $(window).height();
            height = height - pos.top;
            height = height - footer.height();
            if (height > 0) {
                footer.css({
                    'margin-top': height + 'px'
                });
            }
        });  
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <table class="style1">
            <tr>
                <td>
                    Enter 6 digit number:
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
            </tr>
            <tr>
                <td>
                    Batch=<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    &nbsp;&nbsp; Faculty=<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    &nbsp;Roll:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
    <div class="foot">
        Your footer content
        <asp:DataList ID="DataList1"  RepeatColumns="6" runat="server" Width="875px">
        <ItemTemplate>
        <table>
        <tr>
        <td>
        <asp:Image ID="ImgBook" runat="server" Width="100" Height="100" />
        </td>
        </tr>
          <tr>
        <td>
            <asp:Label ID="lblBookName" runat="server" Text="Label"></asp:Label>
        </td>
        </tr>
          <tr>
        <td>
        <asp:Button ID="btnReserve" runat="server" Text="Button" />
        </td>
        </tr>
        </table>
        </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
