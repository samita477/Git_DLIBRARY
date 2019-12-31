<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register_email.aspx.cs" Inherits="DIGITALLIBRARY.DL.register_email" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register New User</title>
 
    <link href="../temp/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../temp/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet"type="text/css" />

    <link href="../temp/css/sb-admin.css" rel="stylesheet" type="text/css" />
    <script src="../temp/vendor/jquery/jquery.min.js" type="text/javascript"></script>
    <script src="../temp/vendor/bootstrap/js/bootstrap.bundle.min.js" type="text/javascript"></script>
    <script src="../temp/vendor/jquery-easing/jquery.easing.min.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">

    </script>

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
        .style1
        {
            width: 168px;
        }
    </style>
    </head>
<body class="bg-dark">
    <div class="container">
        <div class="card card-login mx-auto mt-5">
            <div >
                Register</div>
            <div class="card-body">
                <form runat="server">
          <%--<div class="form-group">
            <label for="exampleInputEmail1">Email address</label>
            <input class="form-control" id="exampleInputEmail1" type="email" aria-describedby="emailHelp" placeholder="Enter email">
          </div>
          <div class="form-group">
            <label for="exampleInputPassword1">Password</label>
            <input class="form-control" id="exampleInputPassword1" type="password" placeholder="Password">
          </div>
          <div class="form-group">
            <div class="form-check">
              <label class="form-check-label">
                <input class="form-check-input" type="checkbox"> Remember Password</label>
            </div>
          </div>--%>
                <table class="style2">
       <%-- <tr style="page-break-inside: avoid">
            <td class="style4">
                Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style9">
                <asp:TextBox ID="txtboxName" runat="server" Width="160px" TabIndex="1" 
                   ></asp:TextBox>
            </td>
        </tr>--%>
                    <tr>
                        <td class="style1">
                            User Name:
                        </td>
                        <td class="style7">
                            <asp:TextBox ID="txtboxUserName" runat="server" TabIndex="2" Width="160px"  Height="22px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Password:
                        </td>
                        <td class="style8">
                            <asp:TextBox ID="txtboxPassword" runat="server" 
                                onkeyup="checkPasswordStrength()" TabIndex="3" TextMode="Password" 
                                Width="160px"  Height="22px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Confirm Password:
                        </td>
                        <td class="style7">
                            <asp:TextBox ID="txtboxConfirmPassword" runat="server" 
                                TabIndex="4" TextMode="Password" 
                                Width="160px"  Height="22px" AutoPostBack="True" 
                                ontextchanged="txtboxConfirmPassword_TextChanged1"></asp:TextBox>
                            <asp:Label ID="lblPassword" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Address:;
                        </td>
                        <td class="style8">
                            <asp:TextBox ID="txtboxAddress" runat="server" TabIndex="5" Width="160px"  Height="22px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Phone No:
                        </td>
                        <td class="style8">
                            <asp:TextBox ID="txtboxPhone" runat="server" TabIndex="6" Width="160px"  Height="22px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Email ID:
                        </td>
                        <td class="style7">
                            <asp:TextBox ID="txtboxEmail" runat="server" TabIndex="7" Width="160px"  Height="22px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Gender:
                        </td>
                        <td class="style7">
                            <asp:TextBox ID="txtboxGender" runat="server" TabIndex="8" Width="160px"  Height="22px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            Type:
                        </td>
                        <td class="style7">
                            <asp:TextBox ID="txtboxType" runat="server" TabIndex="9" Width="160px" Height="22px"></asp:TextBox>
                        </td>
                    </tr>
       <%-- <tr style="page-break-inside: avoid">
            <td class="style3">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>--%>
      <%--  </tr>--%>
                </table>
                <asp:Button ID="btnRegister" runat="server" 
                    href="http://localhost:2368/temp/index.html" onclick="btnRegister_Click" 
                    style="background-color: #3333CC" Text="Register" Width="341px" />
         <%-- <a class="btn btn-primary btn-block" href="../temp/index.html"   style="background-color: #3333CC" >Register</a>--%>
                </form>
            </div>
        </div>
    </div>
</body>
