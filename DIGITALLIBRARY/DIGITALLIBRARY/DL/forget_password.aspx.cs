using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

//System.Net.Mail namespace required to send mail.  
using System.Net.Mail;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;

namespace DIGITALLIBRARY.DL
{
    public partial class forget_password : System.Web.UI.Page
    {
        settings_BLL obj = new settings_BLL();
        DBcontainer db = new DBcontainer();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            
            txtConfirmPw.Enabled = false;
            txtPw.Enabled = false;
            btnChange.Enabled = false;
            get_usertype();
            }

        }

        protected void lbtnSendCode_Click(object sender, EventArgs e)
        {

            //SendRegistrationAlert(txtUserName.Text);
         
        }

        private void SendRegistrationAlert(string Mail_receiver)
        {
            string body = PopulateMailBody(Mail_receiver);
            email_engine.SendMail(Mail_receiver, "Welcome to Digital Library", body);
        }

        private string PopulateMailBody(string Mail_receiver)
        {
            string body = String.Empty;
            string verificationcode = GenerateNewRandom();
            db.Verification_code = verificationcode;
            obj.pwchange_request(db);
            using (StreamReader reader = new StreamReader(Server.MapPath("~/Forget_password.htm")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("[userName]", Session["User_Name"].ToString());
            body = body.Replace("[code]", verificationcode);
            return body;
        }

        private static string GenerateNewRandom()
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateNewRandom();
            }
            return r;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            get_usertype();
             if (db.Type == "admin" || db.Type == "user")
            {
                Response.Redirect("settings_admin.aspx");
            }
            else
            {
                Response.Redirect("settings_student.aspx");
            }
           
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
             
                string pw1 = txtPw.Text;
                string cpw = txtConfirmPw.Text;
                if (pw1 != cpw)
                {
                    lblPasssword.Text = "Password doesnot match";
                }

                else
                {
                    get_usertype();
                    if (db.Type == "admin" || db.Type == "user")
                    {
                       
                        db.Password = txtConfirmPw.Text;
                        obj.update_userpassword(db);
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Password have been updated');", true);
                    }
                    else
                    {
                       
                        db.Password = txtConfirmPw.Text;
                        obj.update_otheruserpassword(db);
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Password have been updated');", true);
                    }

                    //string User_email = Session["User_Email"].ToString();
                    //SendRegistrationAlert(User_email);
                    //Response.Redirect("choose_for_login.aspx");
                }
           

            
        }

        protected void txtConfirmPw_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        protected void txtCurrentPw_TextChanged(object sender, EventArgs e)
        {

            get_usertype();
            string pw = txtCurrentPw.Text;
            if (pw == db.Password)
            {
                txtPw.Enabled = true;
                txtConfirmPw.Enabled = true;
                btnChange.Enabled = true;

            }
            else
            {
                lblPasssword.Text = "Please enter the correct CURRENT Password";
            }
            txtCurrentPw.Attributes.Add("value", pw);
        }

        protected void txtPw_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ImgBtnBack_Click(object sender, ImageClickEventArgs e)
        {
            string type = Session["User_Type"].ToString();
            if (type == "admin" || type == "user")
            {
                Response.Redirect("settings_admin.aspx");
            }
            else
            {
                Response.Redirect("settings_student.aspx");
            }

          }

        public void get_usertype()
        {
            try
            {
                db.User_id = Convert.ToInt32(Session["User_Id"].ToString());
                db.Type = Session["User_Type"].ToString();
                DataTable dt = obj.get_userbyid(db);
                db.Password = dt.Rows[0]["_password"].ToString();
               
            }


            catch(Exception e)
            {
                
            }

            try
            {

                db.User_id = Convert.ToInt32(Session["UserID"].ToString());
                db.Type = Session["_User_Type"].ToString();
                DataTable dt = obj.get_otheruserbyid(db);
                db.Password = dt.Rows[0]["_Password"].ToString();

            }

            catch { }
        }


      
    }
}