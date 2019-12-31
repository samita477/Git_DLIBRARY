<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choose_for_login.aspx.cs" Inherits="DIGITALLIBRARY.DL.choose_for_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <link rel="stylesheet" type="text/css" href="../login.css" >
  <%--<style type="text/css">
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
   <form id="form1" runat="server">    
   <div class="login-box">
      <h1>Login As:</h1>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImgAdmin" runat="server" Height="90px" 
           ImageUrl="~/Images/avatar.png" onclick="ImgAdmin_Click" Width="95px" />
           <br />
            
    
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbtnAdmin" runat="server" onclick="lbtnAdmin_Click">Admin/Staff</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />

      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:ImageButton ID="ImgStudent" runat="server" Height="90px" 
           ImageUrl="~/Images/avatar.png" onclick="ImgStudent_Click" Width="95px" />
           <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
       <asp:LinkButton ID="lbtnStudent" runat="server" onclick="lbtnStudent_Click">Student/Teachers</asp:LinkButton>

      
     
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
      
       </div>   
    
   </form>
</body>
</html>
