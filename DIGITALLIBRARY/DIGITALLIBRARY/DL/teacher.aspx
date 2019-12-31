<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true"
 CodeBehind="teacher.aspx.cs" Inherits="DIGITALLIBRARY.DL.teacher" EnableEventValidation="false"%>
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

        </script>
    <style type="text/css">
        .style2
        {
            height: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
        <td class="style15" colspan="3" height="70" align="center" 
                bgcolor="#99CCFF">
            <asp:Label ID="lblAddStudent" runat="server" Text="ADD TEACHERS"></asp:Label>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             Search:<asp:TextBox ID="txtSearchTeacher" runat="server" AutoPostBack="True" 
                 ontextchanged="txtSearchTeacher_TextChanged" Width="289px"></asp:TextBox>
        </td>
        <tr>
            <td>
                Barcode:</td>
            <td class="style2">
                <asp:TextBox ID="txtCode" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Name:</td>
            <td class="style2">
                <asp:TextBox ID="txtboxName" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:LinkButton ID="lbtnViewStudent" runat="server" 
                    onclick="lbtnViewStudent_Click" Visible="False" >View Teachers</asp:LinkButton>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                Address:</td>
            <td class="style2">
                <asp:TextBox ID="txtboxAddress" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="style5" rowspan="6">
                <asp:Image ID="ImgSnap" runat="server" Width="227px" Height="127px" 
                     Visible="true" />
                &nbsp;<br />
                <input id="FuSnap" type="file" name="file" onchange="previewSnap()" runat="server" onclick="return FuSnap_onclick()" /><asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="FuSnap" ValidationGroup="Submit"
                    onchange="return CheckFile(this);" ValidationExpression="^.*\.((j|J)(p|P)(e|E)?(g|G)|(g|G)(i|I)(f|F)|(p|P)(n|N)(g|G))$"
                    Text=" ! Invalid image type" runat="server" />
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                Phone No:</td>
            <td class="style2">
                <asp:TextBox ID="txtboxPhn" runat="server" Width="200px" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Email :</td>
            <td class="style2">
                <asp:TextBox ID="txtEmail" runat="server" Width="200px" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Gender:</td>
            <td class="style2">
                <asp:DropDownList ID="ddlGender" runat="server" Width="200px">
                <asp:ListItem>Male</asp:ListItem>
                 <asp:ListItem>Female</asp:ListItem>
                  <asp:ListItem>Others</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Subject assigned:</td>
            <td class="style2">
                <asp:TextBox ID="txtSubject" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Department:</td>
            <td class="style2">
                <asp:DropDownList ID="ddlDepartment" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style2">
                <asp:Button ID="btnSave" runat="server" Text="SAVE" Width="80px" BackColor="#343A40" ForeColor="White"
                    onclick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Width="80px" BackColor="#343A40" ForeColor="White"
                    onclick="btnCancel_Click" />
                <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" BackColor="#343A40" ForeColor="White"
                    Text="UPDATE" Width="80px" />
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" colspan="3">
                <asp:GridView ID="gvSearchTeacher" runat="server" 
                        AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" 
                        BorderStyle="Double" BorderWidth="3px" CellPadding="3" GridLines="Horizontal" 
                        Width="962px">
                   
                    <Columns>
                        <asp:BoundField DataField="Teacher_ID" HeaderText="Teacher ID" />
                        <asp:BoundField DataField="Teacher_Name" HeaderText="Teacher Name" />
                        <asp:BoundField DataField="_address" HeaderText="Address" />
                        <asp:BoundField DataField="email" HeaderText="Email ID" />
                        <asp:BoundField DataField="ph_no" HeaderText="Phone no" />
                        <asp:BoundField DataField="gender" HeaderText="Gender" />
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
        <tr>
            <td class="style3" colspan="3">
                <asp:GridView ID="gvTeacher_User" runat="server" 
                        AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" 
                        BorderStyle="Double" BorderWidth="3px" CellPadding="3" GridLines="Horizontal" 
                        Width="962px" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvTeacher_User_PageIndexChanging">
                   
                    <Columns>
                        <asp:BoundField DataField="Teacher_ID" HeaderText="Teacher ID" />
                        <asp:BoundField DataField="Teacher_Name" HeaderText="Teacher Name" />
                        <asp:BoundField DataField="_address" HeaderText="Address" />
                        <asp:BoundField DataField="email" HeaderText="Email ID" />
                        <asp:BoundField DataField="ph_no" HeaderText="Phone no" />
                        <asp:BoundField DataField="gender" HeaderText="Gender" />
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
                <asp:GridView ID="gvViewTeacher" runat="server" AutoGenerateColumns="False" 
                        BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                        CellPadding="4" GridLines="Horizontal" Width="962px" 
                    onpageindexchanging="gvViewTeacher_PageIndexChanging" >

                    <Columns>
                        <asp:BoundField HeaderText="Teacher ID" DataField="Teacher_ID" />
                        <asp:BoundField HeaderText="Teacher Name" DataField="Teacher_Name" />
                        <asp:BoundField HeaderText="Address" DataField="_address" />
                        <asp:BoundField HeaderText="Email ID" DataField="email" />
                        <asp:BoundField HeaderText="Phone no" DataField="ph_no" />
                        <asp:BoundField HeaderText="Gender" DataField="gender" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" onclick="btnEdit_Click1" Text="EDIT"
                                     BackColor="#343A40" ForeColor="White" Width="80px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click1" Width="80px"
                                    BackColor="Maroon" ForeColor="White" Text="DELETE" />
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
            </td>
        </tr>
        <tr>
            <td class="style6" colspan="3">
                <asp:HiddenField id="btnTeacher_Id" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
