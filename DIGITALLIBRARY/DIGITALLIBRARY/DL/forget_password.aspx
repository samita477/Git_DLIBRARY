<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forget_password.aspx.cs" Inherits="DIGITALLIBRARY.DL.forget_password" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Password</title>
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
              var passwordTextBox = document.getElementById("txtPw");
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
        .style9
        {
            margin-bottom: 0;
            background-color: rgba(0,0,0,.03);
            text-align: center;
            text-decoration: underline;
            color: #3333CC;
        }
        .style10
        {
            -webkit-box-flex: 1;
            -ms-flex: 1 1 auto;
            flex: 1 1 auto;
            text-align: center;
        }
    </style>
</head>
<body class="bg-dark">
  <div class="container">
    <div class="card card-login mx-auto mt-5">
      <div class="style9" 
            style="background-color: #FFFFFF; height: 23px; position: relative;" >Reset Password<br />
        </div>
      <div class="style10">
        <form id="Form1"  runat="server">
         
        <asp:ImageButton ID="ImgBtnBack" runat="server" Height="31px" 
            ImageUrl="~/Images/back.png" onclick="ImgBtnBack_Click" Width="39px" />
         
        <br />
        Current Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtCurrentPw" runat="server" Width="160px" 
            ontextchanged="txtCurrentPw_TextChanged" ViewStateMode="Enabled"  
            AutoPostBack="True" TextMode="Password" 
                  ></asp:TextBox>
            <br />
         
        <br />
        New Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; </td>
            <td class="style7">
                <asp:TextBox ID="txtPw" runat="server" Width="160px" 
            onkeyup="return checkPasswordStrength();" TextMode="Password" AutoPostBack="True" 
                  ></asp:TextBox>
            <br />
        <br />
        Confirm Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:TextBox ID="txtConfirmPw" runat="server" Width="159px" 
             ontextchanged="txtConfirmPw_TextChanged" TextMode="Password" AutoPostBack="True" 
                  ></asp:TextBox>
            <asp:Label ID="lblPasssword" runat="server"></asp:Label>
            <br />
            <br />
            </td>
       
        </tr>
        
          
       
    
    </table>
        <asp:Button ID="btnChange" runat="server" href="../temp/index.html"  
              Text="Change Password"  style="background-color: #3333CC" Width="341px" 
            onclick="btnChange_Click"/>
        <%-- <a class="btn btn-primary btn-block" href="../temp/index.html"   style="background-color: #3333CC" >Register</a>--%>
        <br />
        <br />
        <asp:Button ID="btnCancel" runat="server" href="../temp/index.html"  
              Text="Cancel"  style="background-color: #3333CC" Width="341px" 
            onclick="btnCancel_Click"/>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</form>
       
      </div>
    </div>
  </div>
</body>
</html>
