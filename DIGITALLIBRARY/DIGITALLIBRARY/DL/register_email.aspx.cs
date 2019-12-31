using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//System.Net  
using System.Net;

//System.Net.Mail namespace required to send mail.  
using System.Net.Mail;

using System.Configuration;
using System.IO;
using DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;

namespace DIGITALLIBRARY.DL
{
    public partial class register_email : System.Web.UI.Page
    {
        DBcontainer db = new DBcontainer();
        user_BLL obj = new user_BLL();
        protected void Page_Load(object sender, EventArgs e)
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
            body = body.Replace("[userName]", txtboxUserName.Text);
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


        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == txtboxConfirmPassword.Text)
            {
                db.Name = txtboxUserName.Text;
                db.User_name = txtboxUserName.Text;
                db.Password = txtboxPassword.Text;
                db.User_address = txtboxAddress.Text;
                db.User_phno = txtboxPhone.Text;
                db.User_email = txtboxEmail.Text;
                db.User_gender = txtboxGender.Text;
                db.Type = txtboxType.Text;
                db.Verification_code = GenerateNewRandom();
                db.Authority = false;
                if (txtboxType.Text == "student")
                {
                    DataTable dt1 = obj.getuser_withstudentname(db);
                    if (dt1.Rows.Count > 0)
                    {
                        Session["Issue_User_ID"] = dt1.Rows[0]["Student_ID"].ToString();
                    }

                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You cannot Register to this System');", true);
                        Response.Redirect("choose_for_login.aspx");
                    }
                }

                else
                {
                    DataTable dt1 = obj.getuser_withteachername(db);
                    if (dt1.Rows.Count > 0)
                    {
                        Session["Issue_User_ID"] = dt1.Rows[0]["Teacher_ID"].ToString();
                    }

                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You cannot Register to this System');", true);
                        Response.Redirect("choose_for_login.aspx");
                    }

                }
                obj.save_otheruser(db);
                DataTable dt = new DataTable();
                dt = obj.get_otheruser_id(db);
                db.User_id = Convert.ToInt32(dt.Rows[0]["_User_ID"].ToString());
                obj.save_userverified(db);
                try
                {
                    SendRegistrationAlert(txtboxEmail.Text);
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have been Register. Please Login to use the system');", true);
                    Response.Redirect("choose_for_login.aspx");
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Mail cannot be sent');", true);
                    Response.Redirect("choose_for_login.aspx");
                }

            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please Enter the same password');", true);
            }
        }

       

        protected void txtboxConfirmPassword_TextChanged1(object sender, EventArgs e)
        {
            db.Password = txtboxPassword.Text;
            if (txtboxConfirmPassword.Text != txtboxPassword.Text)
            {
                txtboxPassword.Attributes.Add("value", txtboxPassword.Text);
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please Enter the same password');", true);
            }

            else
            {
                txtboxPassword.Attributes.Add("value", txtboxPassword.Text);
                txtboxConfirmPassword.Attributes.Add("value", txtboxConfirmPassword.Text);

            }

        }

    

       
    }
}