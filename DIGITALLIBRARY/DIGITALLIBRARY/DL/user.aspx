<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DLL.Master" AutoEventWireup="true" 
CodeBehind="user.aspx.cs" Inherits="DIGITALLIBRARY.DL.user" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <script type="text/javascript">
      function checkPasswordStrength() {
          var passwordTextBox = document.getElementById("txtboxPassword");
          var password = passwordTextBox.value;
          var specialCharacters = "!£$%^&*_@#~?";
          var passwordScore = 0;

          passwordTextBox.style.color = "white";

          // Contains special characters
          for (var i = 0; i < password.length; i++) {
              if (specialCharacters.indexOf(password.charAt(i)) > -1) {
                  passwordScore += 20;
                  break;
              }
          }

          // Contains numbers
          if (/\d/.test(password))
              passwordScore += 20;

          // Contains lower case letter
          if (/[a-z]/.test(password))
              passwordScore += 20;

          // Contains upper case letter
          if (/[A-Z]/.test(password))
              passwordScore += 20;

          if (password.length >= 8)
              passwordScore += 20;

          var strength = "";
          var backgroundColor = "red";

          if (passwordScore >= 100) {
              strength = "Strong";
              backgroundColor = "green";
          }
          else if (passwordScore >= 80) {
              strength = "Medium";
              backgroundColor = "gray";
          }
          else if (passwordScore >= 60) {
              strength = "Weak";
              backgroundColor = "maroon";
          }
          else {
              strength = "Very Weak";
              backgroundColor = "red";
          }

          document.getElementById("lblPassword").innerHTML = strength;
          passwordTextBox.style.backgroundColor = backgroundColor;
      }
    </script>
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
        }
        .style4
        {
            width: 208px;
            height: 31px;
        }
        .style5
        {
            height: 31px;
        }
        .style6
        {
            width: 393px;
        }
        .style7
        {
            height: 31px;
            width: 393px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="style2">
     <td class="style1" colspan="4" width="200" height="70" align="center" 
                bgcolor="#99CCFF">
                <asp:Label ID="lblUser" runat="server" Text="USER"></asp:Label>
            </td>
        <tr>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Name:</td>
            <td class="style6">
                <asp:TextBox ID="txtboxName" runat="server" Width="219px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Address:</td>
            <td class="style6">
                <asp:TextBox ID="txtboxAddress" runat="server" Width="219px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Phone No:</td>
            <td class="style6">
                <asp:TextBox ID="txtboxPhone" runat="server" Width="219px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Email ID:</td>
            <td class="style6">
                <asp:TextBox ID="txtboxEmail" runat="server" Width="219px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Gender:</td>
            <td class="style6">
                <asp:TextBox ID="txtboxGender" runat="server" Width="219px"></asp:TextBox>
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
                <asp:TextBox ID="txtboxPassword" runat="server" Width="219px" 
                    TextMode="Password"  onkeyup=" return checkPasswordStrength();" 
                      ></asp:TextBox>
          <%--  <asp:TextBox ID="txtboxPassword" runat="server" Width="219px" TextMode="Password"  ></asp:TextBox>--%>
                <asp:Label ID="lblPassword" runat="server"></asp:Label>
          
                
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Type:</td>
            <td class="style6">
                <asp:TextBox ID="txtboxType" runat="server" Width="219px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Authority:</td>
            <td class="style7">
                <asp:CheckBox ID="ckboxAuthority" runat="server"/>
            </td>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
            <td class="style6">
                <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="SAVE"
                BackColor="#343A40" ForeColor="White" 
                    Width="80px" />
                <asp:Button ID="btnUpdate" runat="server"  Text="UPDATE" BackColor="#343A40" ForeColor="White"
                    Width="80px" onclick="btnUpdate_Click" />
                <asp:Button ID="btnCancel" runat="server"  Text="CANCEL" BackColor="#343A40" ForeColor="White"
                    Width="80px" onclick="btnCancel_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3" colspan="4">
                <asp:GridView ID="gvUser" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                    CellPadding="4" GridLines="Horizontal" 
                    onselectedindexchanged="gvUser_SelectedIndexChanged" AllowPaging="True" 
                        PageSize="4" onpageindexchanging="gvUser_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="_User_ID" HeaderText="ID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="_address" HeaderText="Address" />
                        <asp:BoundField DataField="ph_no" HeaderText="Phone No" />
                        <asp:BoundField DataField="email" HeaderText="Email" />
                        <asp:BoundField DataField="gender" HeaderText="Gender" />
                        <asp:BoundField DataField="_type" HeaderText="Type" />
                        <asp:BoundField DataField="authority" HeaderText="Authority" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnEdit" runat="server" onclick="btnEdit_Click" Text="Edit" 
                                BackColor="#343A40" ForeColor="White"
                                    Width="80px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
                                BackColor="Maroon" ForeColor="White"
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
                <asp:HiddenField id="btnUsers_Id" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
