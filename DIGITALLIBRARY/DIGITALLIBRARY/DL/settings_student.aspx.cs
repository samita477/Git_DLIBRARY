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
    public partial class settings_student : System.Web.UI.Page
    {

        settings_BLL obj = new settings_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            db.User_id = Convert.ToInt32(Session["UserID"].ToString());
            bindOtherUser();
        }

        public void bindOtherUser()
        {
            DataTable dt = new DataTable();
            dt = obj.bindOtherUser(db);
            txtName.Text = dt.Rows[0]["_Name"].ToString();
            txtPassword.Attributes.Add("value", dt.Rows[0]["_Password"].ToString());
            txtAddress.Text = dt.Rows[0]["_Address"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone_no"].ToString();
            txtEmail.Text = dt.Rows[0]["Email_ID"].ToString();
            txtGender.Text = dt.Rows[0]["Gender"].ToString();
            txtType.Text = dt.Rows[0]["_Type"].ToString();
            //db.Authority = Convert.ToBoolean(dt.Rows[0]["authority"].ToString());
            Session["OtherUser_Email"] = dt.Rows[0]["Email_ID"].ToString();
            Session["OtherUser_Password"] = dt.Rows[0]["_password"].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.User_id = Convert.ToInt32(Session["UserID"].ToString());
            db.User_name = txtName.Text;
            db.Name = txtName.Text;
            db.Password = txtPassword.Text;
            db.User_address = txtAddress.Text;
            db.User_phno = txtPhone.Text;
            db.User_email = txtEmail.Text;
            db.Type = txtType.Text;
            db.User_gender = txtGender.Text;
            obj.update_otheruser(db); ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Your information have been updated.');", true);
            bindOtherUser();
        }

        protected void lbtnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("forget_password.aspx");
        }
    }
}