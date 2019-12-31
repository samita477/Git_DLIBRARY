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
    public partial class login_for_students : System.Web.UI.Page
    {
        DBcontainer db = new DBcontainer();
        login_BLL obj = new login_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            db.User_name = txtUserName.Text;
            db.Password = txtPassword.Text;
            DataTable dt = new DataTable();
            dt = obj.get_otheruser_byname(db);
            if (dt.Rows.Count > 0)
            {
                db.Check_password = dt.Rows[0]["_Password"].ToString();
                if (db.Check_password == txtPassword.Text)
                {
                    db.User_id = Convert.ToInt32(dt.Rows[0]["_User_ID"].ToString());
                    DataTable dt1 = new DataTable();
                    dt1 = obj.check_verified_user(db);
                    db.Authority = Convert.ToBoolean(dt1.Rows[0]["verified"].ToString());
                    db.Verification_code = dt1.Rows[0]["code"].ToString();
                    if (db.Authority == true)
                    {
                        string type = dt.Rows[0]["_Type"].ToString();
                        if (type == "student")
                        {
                            pass_id(dt);
                            Session["UserID"] = dt.Rows[0]["_User_ID"].ToString();
                            Session["_User_Type"] = dt.Rows[0]["_Type"].ToString();
                            Response.Redirect("dashboard_student.aspx");
                        }
                        else
                        {
                            pass_id(dt);
                            Session["UserID"] = dt.Rows[0]["_User_ID"].ToString();
                            Session["_User_Type"] = dt.Rows[0]["_Type"].ToString();
                            Response.Redirect("dashboard_teacher.aspx");
                        }
                    }
                    else
                    {
                        //verifiedcodefunction
                        Session["_UserID"] = dt.Rows[0]["_User_ID"].ToString();
                        Session["UV_ID"] = dt1.Rows[0]["UV_ID"].ToString();
                        Session["User_Type"] = dt.Rows[0]["_Type"].ToString();
                        Session["Code"] = dt1.Rows[0]["code"].ToString();
                        Response.Redirect("Verification.aspx");
                        //ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('the user is not authorized to acess the system');", true);
                    }


                }

                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('Invalid Password.  Please enter correct password');", true);
                }

            }

            else
            {
                cleartext();
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('the user of this name doesnot exist');", true);
            }


        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("register_email.aspx");
        }

        public void cleartext()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        public void pass_id(DataTable dt)
        {
            string type = dt.Rows[0]["_type"].ToString();
            if (type == "student")
            {
                DataTable dt1 = obj.getuser_withstudentname(db);
                if (dt1.Rows.Count > 0)
                {
                    Session["SID"] = dt1.Rows[0]["Student_ID"].ToString();
                }

                else
                {

                }
            }

            else
            {
                db.Teacher_name = txtUserName.Text;
                DataTable dt1 = obj.getuser_withteachername(db);
                if (dt1.Rows.Count > 0)
                {
                    Session["TID"] = dt1.Rows[0]["Teacher_ID"].ToString();
                }

                else
                {
                }
            }
        }
    }
}