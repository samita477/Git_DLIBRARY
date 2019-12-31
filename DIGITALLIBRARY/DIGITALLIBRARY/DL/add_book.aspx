<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" CodeBehind="add_book.aspx.cs" Inherits="DIGITALLIBRARY.DL.add_book" EnableEventValidation="false" %>
 <%--  <%@ Register Src="~/DL/view_book.ascx" TagPrefix="uc1" TagName="ContactUC" %> --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            height: 26px;
        }
        .style4
        {
            width: 950px;
        }
        .style5
        {
            width: 950px;
        }
        .style10
        {
            height: 26px;
            width: 911px;
            text-align: left;
        }
        .style12
        {
            width: 339px;
            text-align: left;
        }
        .style15
        {
            height: 50px;
            text-align: left;
        }
        .style16
        {
            width: 950px;
            height: 26px;
        }
        .style18
        {
            width: 911px;
            text-align: left;
        }
        .style19
        {
            width: 911px;
        }
        </style>
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
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <tr>
         <td class="style15" colspan="5" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblAddbook" runat="server" Text="ADD BOOKS"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             Search:<asp:TextBox ID="txtSearchBook" runat="server" AutoPostBack="True" 
                 ontextchanged="txtSearchBook_TextChanged" Width="289px"></asp:TextBox>
        </td>
            <td class="style1">
                </td>
            <td class="style1">
                </td>
            <td class="style1">
                </td>
            <td class="style1">
                </td>
        </tr>
        <tr>
            <td class="style18">
                Accession No:</td>
            <td class="style12">
                <asp:TextBox ID="txtCode" runat="server" Width="200px" 
                    ontextchanged="txtCode_TextChanged"></asp:TextBox>
            </td>
            <td class="style4">
                <asp:LinkButton ID="lbtnViewBooks" runat="server" onclick="lbtnViewBooks_Click">View Books</asp:LinkButton>
                &nbsp;&nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                Book Name:</td>
            <td class="style12">
                <asp:TextBox ID="txtboxName" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="style4" rowspan="7">
                 <asp:Image ID="ImgSnap" runat="server" Width="227px" Height="127px" 
                     Visible="true" />
                &nbsp;<br />
                <input id="FuSnap" type="file" name="file" onchange="previewSnap()" runat="server" onclick="return FuSnap_onclick()" /><asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="FuSnap" ValidationGroup="Submit"
                    onchange="return CheckFile(this);" ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"
                    Text=" ! Invalid image type" runat="server" />
              <%--  <asp:FileUpload ID="FileUpload1" runat="server" Width="287px" />
                <asp:Button ID="btnOkay" runat="server" onclick="btnOkay_Click" Text="Okay" />--%>
                 <%--<asp:Image ID="ImgSnap" runat="server" Width="200px" Height="200px" Visible="true" />
                <input id="FuSnap" type="file" name="file" onchange="previewSnap()" runat="server" />
                <asp:RegularExpressionValidator ID="rev_LedgerSnap" ControlToValidate="FuSnap" ValidationGroup="Submit"
                    onchange="return CheckFile(this);" ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"
                    Text=" ! Invalid image type" runat="server" />--%>
                </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                Quantity:</td>
            <td class="style12">
                <asp:TextBox ID="txtQuantity" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="style5">
                </td>
            <td class="style3">
                </td>
        </tr>
        <tr>
            <td class="style18">
                Edition:</td>
            <td class="style12">
                <asp:TextBox ID="txtEdition" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                Category:</td>
            <td class="style12">
                <asp:DropDownList ID="ddlCategory" runat="server" Width="200px">
                 <asp:ListItem>
                General Book
                </asp:ListItem>
                <asp:ListItem>
                Reference Book
                </asp:ListItem>
                
                </asp:DropDownList>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                Date Of entry:</td>
            <td class="style12">
                <asp:TextBox ID="txtDate" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                Page No:</td>
            <td class="style12">
                <asp:TextBox ID="txtPageNo" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
            <td class="style3">
                </td>
        </tr>
        <tr>
            <td class="style10">
                Price:</td>
            <td class="style12">
                <asp:TextBox ID="txtPrice" runat="server" Width="200px"></asp:TextBox>
                </td>
            <td class="style16">
                </td>
            <td class="style3">
                </td>
        </tr>
        <tr>
            <td class="style18" >
                Subject:</td>
            <td class="style12" >
                <asp:DropDownList ID="ddbtnSubject" runat="server" Width="200px" Height="20px" 
                    AutoPostBack="True">
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
            <td class="style12">
                <asp:DropDownList ID="ddbtnAuthor" runat="server" Width="200px" 
                    AutoPostBack="True">
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
            <td class="style12">
                <asp:DropDownList ID="ddbtnPublication" runat="server" Width="200px" 
                    AutoPostBack="True">
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
                Semester:</td>
            <td class="style12">
                <asp:DropDownList ID="ddlSemester" runat="server" Width="200px">
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
            <td class="style19">
                &nbsp;</td>
            <td class="style12">
                <asp:Button ID="btnSave" runat="server" Text="SAVE" Width="80px"  BackColor="#343A40" ForeColor="White"
                    onclick="btnSave_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" Width="80px"  BackColor="#343A40" ForeColor="White"
                    onclick="btnUpdate_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Width="80px"  BackColor="#343A40" ForeColor="White"
                    onclick="btnCancel_Click" />
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:GridView ID="gvSearchBook" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4"  GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="Book_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Book_Name" HeaderText="Name" />
                        <asp:BoundField DataField="Page" HeaderText="Page no" />
                        <asp:BoundField DataField="price" HeaderText="Price" />
                        <asp:BoundField DataField="edition" HeaderText="Edition" />
                        <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="avl_quantity" HeaderText="Available Quantity" />
                        <asp:BoundField DataField="date_of_entry" HeaderText="Entry Date" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" BorderColor="Black" 
                        BorderStyle="Solid" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:GridView ID="gvBookUser" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" 
                    BorderWidth="3px" AllowPaging="True"
                    PageSize="4" CellPadding="4" GridLines="Horizontal" 
                    onpageindexchanging="gvBookUser_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Book_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Book_Name" HeaderText="Name" />
                        <asp:BoundField DataField="Page" HeaderText="Page no" />
                        <asp:BoundField DataField="price" HeaderText="Price" />
                        <asp:BoundField DataField="edition" HeaderText="Edition" />
                        <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="avl_quantity" HeaderText="Available Quantity" />
                        <asp:BoundField DataField="date_of_entry" HeaderText="Entry Date" />
                        <asp:BoundField DataField="Subject_Name" HeaderText="Subject Name" />
                        <asp:BoundField DataField="Author_Name" HeaderText="Author" />
                        <asp:BoundField DataField="Publication_Name" HeaderText="Publication Name" />
                        <asp:BoundField DataField="category" HeaderText="Category" />
                        <asp:TemplateField></asp:TemplateField>
                        <asp:TemplateField></asp:TemplateField>
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
                <asp:GridView ID="gvBook" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                    onselectedindexchanged="gvBook_SelectedIndexChanged" AllowPaging="True" 
                    onpageindexchanging="gvBook_PageIndexChanging" PageSize="4">
                    <Columns>
                        <asp:BoundField DataField="Book_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Book_Name" HeaderText="Name" />
                        <asp:BoundField DataField="Page" HeaderText="Page no" />
                        <asp:BoundField DataField="price" HeaderText="Price" />
                        <asp:BoundField DataField="edition" HeaderText="Edition" />
                        <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="avl_quantity" HeaderText="Available Quantity" />
                        <asp:BoundField DataField="date_of_entry" HeaderText="Entry Date" />
                        <asp:BoundField DataField="Subject_Name" HeaderText="Subject Name" />
                        <asp:BoundField DataField="Author_Name" HeaderText="Author" />
                        <asp:BoundField DataField="Publication_Name" HeaderText="Publication Name" />
                        <asp:BoundField DataField="category" HeaderText="Category" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server"  Text="Edit" 
                                    Width="80px" BackColor="#343A40" ForeColor="White" onclick="btnEdit_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" BackColor="Maroon" ForeColor="White"
                                    Text="Delete" Width="80px" />
                            </ItemTemplate>
                        </asp:TemplateField>
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
                  <asp:HiddenField id="btnBook_Id" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
