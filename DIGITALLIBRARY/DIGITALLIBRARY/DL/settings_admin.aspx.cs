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

namespace DIGITALLIBRARY.DL
{
    public partial class settings_admin : System.Web.UI.Page
    {
        settings_BLL obj = new settings_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                db.User_id = Convert.ToInt32(Session["User_Id"].ToString());
                bindThisUser();
                //check_usertype();
            }
           
        }

        public void bindThisUser()
        {
            DataTable dt = new DataTable();
            dt = obj.bindThisUser(db);
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtPassword.Attributes.Add("value", dt.Rows[0]["_password"].ToString());
            txtAddress.Text = dt.Rows[0]["_address"].ToString();
            txtPhone.Text = dt.Rows[0]["ph_no"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtGender.Text = dt.Rows[0]["gender"].ToString();
            txtType.Text = dt.Rows[0]["_type"].ToString();
            db.Authority = Convert.ToBoolean(dt.Rows[0]["authority"].ToString());
            Session["User_Name"] = dt.Rows[0]["Name"].ToString();
            Session["User_Email"] = dt.Rows[0]["email"].ToString();
            Session["User_Password"] = dt.Rows[0]["_password"].ToString();
              
        }

        protected void lbtnReset_Click(object sender, EventArgs e)
        {

            Response.Redirect("forget_password.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.User_id = Convert.ToInt32(Session["User_Id"].ToString());
            db.User_name = txtName.Text;
            db.Password = txtPassword.Text;
            db.User_address = txtAddress.Text;
            db.User_phno = txtPhone.Text;
            db.User_email = txtEmail.Text;           
            db.Type = txtType.Text;
            db.User_gender = txtGender.Text;
            obj.update_user(db);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Your information have been updated.');", true);
            bindThisUser();
        }
      
    }
}