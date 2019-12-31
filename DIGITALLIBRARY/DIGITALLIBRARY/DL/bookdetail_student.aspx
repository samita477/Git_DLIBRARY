<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DDL.Master" AutoEventWireup="true" CodeBehind="bookdetail_student.aspx.cs" Inherits="DIGITALLIBRARY.DL.bookdetail_student" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
     function previewSnap() {
         var preview = document.querySelector('#<%=ImgSnap.ClientID %>');
         var file = document.querySelector('#<%=FuSnap.ClientID %>').files[0];
         var reader = new FileReader();

         reader.onloadend = function () {
             preview.src = reader.result;
         }

         if (file) {
             reader.readAsDataURL(file);
             document.getElementById("<%=ImgSnap.ClientID%>").style.visibility = "visible";
         } else {
             preview.src = "";
             document.getElementById("<%=ImgSnap.ClientID%>").style.visibility = "hidden";
         }
     }

     function FuSnap_onclick() {

     }


     function FuSnap_onclick() {

     }

        </script>
    <style type="text/css">
        .style2
        {
            width: 819px;
        }
        .style3
        {
            width: 15px;
        }
        .style4
        {
            width: 16px;
        }
        .style5
        {
            width: 17px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
            <td class="style15" colspan="5" height="70" align="center" 
                bgcolor="#99CCFF">
                <asp:Label ID="lblBookDetailStudent" runat="server" Text="BOOK DETAILS"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ImageButton ID="imgBack" runat="server" Height="30px" 
                    ImageUrl="~/Images/back.png" onclick="imgBack_Click" Width="30px" />
            </td>
        </tr>
        <tr>
            <td class="style18">
                Book Name:</td>
            <td>
                <asp:TextBox ID="txtboxName" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                Quantity:</td>
            <td>
                <asp:TextBox ID="txtQuantity" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style17" rowspan="6">
                
              <%--  <asp:FileUpload ID="FileUpload1" runat="server" Width="287px" />
                <asp:Button ID="btnOkay" runat="server" onclick="btnOkay_Click" Text="Okay" />--%>
                 <%--<asp:Image ID="ImgSnap" runat="server" Width="200px" Height="200px" Visible="true" />
                <input id="FuSnap" type="file" name="file" onchange="previewSnap()" runat="server" />
                <asp:RegularExpressionValidator ID="rev_LedgerSnap" ControlToValidate="FuSnap" ValidationGroup="Submit"
                    onchange="return CheckFile(this);" ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"
                    Text=" ! Invalid image type" runat="server" />--%>
                </td>
            <td class="style5">
            </td>
            <td class="style3">
            </td>
        </tr>
        <tr>
            <td class="style18">
                Edition:</td>
            <td>
                <asp:TextBox ID="txtEdition" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                Date Of entry:</td>
            <td>
                <asp:TextBox ID="txtDate" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                Page No:</td>
            <td>
                <asp:TextBox ID="txtPageNo" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td class="style3">
            </td>
        </tr>
        <tr>
            <td class="style10">
                Price:</td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style16">
            </td>
            <td class="style3">
            </td>
        </tr>
        <tr>
            <td class="style18">
                Available Quantity:</td>
            <td>
                <asp:TextBox ID="txtAvlQty" runat="server" Width="200px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18" >
                Subject:</td>
            <td >
                <asp:DropDownList ID="ddbtnSubject" runat="server" Width="200px" Height="25px" >
                </asp:DropDownList>
            </td>
            <td>
            </td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                Author:</td>
            <td>
                <asp:DropDownList ID="ddbtnAuthor" runat="server" Width="200px" Height="25px">
                </asp:DropDownList>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                Publication:</td>
            <td>
                <asp:DropDownList ID="ddbtnPublication" runat="server" Width="200px" 
                    Height="25px">
                </asp:DropDownList>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                Supplier:</td>
            <td>
                <asp:DropDownList ID="ddbtnSupplier" runat="server" Width="200px" Height="25px">
                </asp:DropDownList>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style22">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style21" colspan="4">
                &nbsp;</td>
            <td class="style21">
       
                &nbsp; 
            </td>
        </tr>
        <tr>
            <td class="style19" colspan="4">
            <asp:Image ID="ImgSnap" runat="server" Width="227px" Height="127px" 
                     Visible="true" />
                &nbsp;<br />
                <input id="FuSnap" type="file" name="file" onchange="previewSnap()" 
                    runat="server" onclick="return FuSnap_onclick()" readonly="readonly" /><asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="FuSnap" ValidationGroup="Submit"
                    onchange="return CheckFile(this);" ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"
                    Text=" ! Invalid image type" runat="server" />
               </td>
            <td>
       
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style19" colspan="4">
                &nbsp;</td>
            <td>
       
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="5" class="style20">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
