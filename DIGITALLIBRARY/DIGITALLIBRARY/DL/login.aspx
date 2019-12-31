<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="DIGITALLIBRARY.DL.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../login.css" />
    <%-- <style type="text/css">
        .login-box{
    width: 319px;
    height: 462px;
    color: #fff;
    top: 44%;
    left: 50%;
    position: absolute;
    transform: translate(-50%,-50%);
    box-sizing: border-box;
    padding: 70px 30px;
            margin-top: 0px;
        }
h1{
    margin: 0;
    padding: 0 0 20px;
    text-align: center;
    font-size: 22px;
}
.login-box p{
    margin: 0;
    padding: 0;
    font-weight: bold;
}
.login-box input[type="text"], input[type="password"]
{
    border-bottom: 1px solid #fff;
    background: transparent;
    outline: none;
    color: #fff;
    font-size: 16px;
    border-left-style: none;
    border-left-color: inherit;
    border-left-width: medium;
    border-right-style: none;
    border-right-color: inherit;
    border-right-width: medium;
    border-top-style: none;
    border-top-color: inherit;
    border-top-width: medium;
}
.login-box input{
    width: 100%;
    margin-bottom: 20px;
}
.login-box input[type="submit"]
{
    border: none;
    outline: none;
    height: 40px;
    background: #1c8adb;
    color: #fff;
    font-size: 18px;
    border-radius: 20px;
}

.login-box a{
    text-decoration: none;
    font-size: 14px;
    color: #fff;
}
    </style>--%>
</head>
 

<body>
  
   <div class="login-box">
       <img src="../Images/avatar.png" alt="image" class="avatar" />
                 <form id="form1" runat="server">
                 <h1>Login</h1>
       <p>Username</p>
    <p>
        <asp:TextBox ID="txtUserName" runat="server" Width="282px"></asp:TextBox>
    </p>
       &nbsp;<p>Password</p>
       &nbsp;<asp:TextBox ID="txtPassword" runat="server" 
           TextMode="Password" Width="277px"></asp:TextBox>
&nbsp;
    <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="btnLogin_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 <%Session["User_Name"] = txtUserName.Text;%>
       <a href="forget_password.aspx">Forget Password</a>        
       <p>&nbsp;</p>
        </form>
       </div>
     
  
  
        
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
  
  
        
</body>
</html>