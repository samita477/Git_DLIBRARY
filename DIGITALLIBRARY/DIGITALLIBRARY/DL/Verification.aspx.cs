using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.IO;  


namespace DIGITALLIBRARY.DL
{
    public partial class Verification : System.Web.UI.Page
    {
        DBcontainer db = new DBcontainer();
        login_BLL obj = new login_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            db.Verification_code = Session["Code"].ToString();
            db.Type = Session["User_Type"].ToString();
            db.User_id = Convert.ToInt32(Session["_UserID"].ToString());
            db.Verification_id = Convert.ToInt32(Session["UV_ID"].ToString());
            if (db.Verification_code == txtboxCode.Text)
            {
                db.Authority = true;
                obj.update_userverified(db);

                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Account Verified');", true);
                //hold here and on click 
                if (db.Type == "student")
                {
                    
                    Response.Redirect("dashboard_student.aspx");
                }

                else
                {
                    Response.Redirect("dashboard_teacher.aspx");
                }

               
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Enter the correct verifion code');", true);
            }
           
         }

        protected void lbtnSendCode_Click(object sender, EventArgs e)
        {

        }
        private void SendRegistrationAlert(string Mail_receiver)
        {
            string body = PopulateMailBody(Mail_receiver);
            email_engine.SendMail(Mail_receiver, "Welcome to Digital Library", body);
        }

        private string PopulateMailBody(string Mail_receiver)
        {
            string body = String.Empty;
            string verificationcode = db.Verification_code;
            using (StreamReader reader = new StreamReader(Server.MapPath("~/SignUp.htm")))
            {
                body = reader.ReadToEnd();
            }
            //body = body.Replace("[userName]", txtboxUserName.Text);
            body = body.Replace("[code]", verificationcode);
            return body;
        }

    }
}