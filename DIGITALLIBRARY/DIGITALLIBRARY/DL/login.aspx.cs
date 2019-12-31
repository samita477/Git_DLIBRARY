using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;
using DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL;

namespace DIGITALLIBRARY.DL
{
    public partial class login : System.Web.UI.Page
    {
        login_BLL obj = new login_BLL();
        DBcontainer db= new DBcontainer();
     
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            db.User_name = txtUserName.Text;
            db.Password = txtPassword.Text;
            DataTable dt = new DataTable();
            dt = obj.getuserid(db);
            if (dt.Rows.Count > 0)
            {

                db.Authority = Convert.ToBoolean(dt.Rows[0]["authority"].ToString());
                db.Check_password = dt.Rows[0]["_password"].ToString();
                if (db.Check_password == txtPassword.Text)
                {
                    if (db.Authority == true)
                    {
                       Session["User_Id"] = dt.Rows[0]["_User_ID"].ToString();
                       Session["User_Type"] = dt.Rows[0]["_type"].ToString();
                       Response.Redirect("choose_session.aspx");
                       //Response.Redirect("homepage.aspx");
                                                  
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('the user is not authorized to acess the system');", true);
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

        public void cleartext()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}