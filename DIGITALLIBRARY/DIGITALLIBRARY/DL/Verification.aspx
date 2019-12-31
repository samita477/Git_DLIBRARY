<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verification.aspx.cs" 
Inherits="DIGITALLIBRARY.DL.Verification" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Verification</title>
     <link href="../temp/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../temp/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet"type="text/css" />

    <link href="../temp/css/sb-admin.css" rel="stylesheet" type="text/css" />
    <script src="../temp/vendor/jquery/jquery.min.js" type="text/javascript"></script>
    <script src="../temp/vendor/bootstrap/js/bootstrap.bundle.min.js" type="text/javascript"></script>
    <script src="../temp/vendor/jquery-easing/jquery.easing.min.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">

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
             font-weight: normal;
         }
    </style>
</head>
<body class="bg-dark">
  <div class="container">
    <div class="card card-login mx-auto mt-5">
      <div class="style9" 
           style="background-color: #FFFFFF; height: 23px; position: relative;" >Verify Account<br />
        </div>
      <div class="card-body">
        <form id="Form1"  runat="server">
         
        <tr style="page-break-inside: avoid">
            <td class="style3">
                <br />
        <br />
        <br />
                Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style7">
                <asp:TextBox ID="txtboxCode" runat="server" Width="160px" TabIndex="2" TextMode="Number" 
                  ></asp:TextBox>
            <br />
        <br />
            <span class="style10">&nbsp;The code is 6 digit long</span><br />
        <br />
            </td>
       
        </tr>
        
          
       
    
    </table>
        <asp:Button ID="btnVerify" runat="server" href="../temp/index.html"  
              Text="Verify"  style="background-color: #3333CC" Width="341px" 
            onclick="btnVerify_Click"/>
         <%-- <a class="btn btn-primary btn-block" href="../temp/index.html"   style="background-color: #3333CC" >Register</a>--%>
        <br />
        <br />
        Didnt get a code?
        <asp:LinkButton ID="lbtnSendCode" runat="server" onclick="lbtnSendCode_Click">Send Code</asp:LinkButton>
        </form>
       
      </div>
    </div>
  </div>
</body>
</html>
