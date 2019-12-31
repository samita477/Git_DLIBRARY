using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.IO;
using DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;


namespace DIGITALLIBRARY.DL
{
    public partial class warning_email : System.Web.UI.Page
    {
        DBcontainer db = new DBcontainer();
        return_book_BLL obj = new return_book_BLL();
           DateTime tnow;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                db.Tnow = DateTime.Now;
                bindwarning();
                
            }
        }

        public void bindwarning()
        {
            DataTable dt = new DataTable();
            dt = obj.getwarningmail(db);
            gvEmail.DataSource = dt;
            gvEmail.DataBind();
        }


        private void SendRegistrationAlert(string Mail_receiver)
        {
            string body = PopulateMailBody(Mail_receiver);
            email_engine.SendMail(Mail_receiver, "Welcome to Digital Library", body);
        }

        private string PopulateMailBody(string Mail_receiver)
        {
            string body = String.Empty;
            //string verificationcode = 1;
            using (StreamReader reader = new StreamReader(Server.MapPath("~/Forget_password.htm")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("[newusername]",db.Student_name);
            body = body.Replace("[code]", Session["Penalty_Rate"].ToString());
            return body;
           
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            btnIM_Id.Value = row.Cells[0].Text;
            db.Im_ID = Convert.ToInt32(row.Cells[0].Text);
            db.Student_name = row.Cells[1].Text;

            DataTable dt1 = obj.get_student_byname(db);
            db.Student_id = Convert.ToInt32(dt1.Rows[0]["Student_ID"].ToString());
            db.Student_email = dt1.Rows[0]["email"].ToString();
            SendRegistrationAlert(db.Student_email);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email have been send');", true);
            
            

        }

        
       
    }
}