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
    public partial class dashboard : System.Web.UI.Page
    {
        DBcontainer db = new DBcontainer();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

    

 

        protected void imgStudent_Click1(object sender, ImageClickEventArgs e)
        {
              Response.Redirect("add_student.aspx");
        }

        protected void imgTeacher_Click1(object sender, ImageClickEventArgs e)
        {
         Response.Redirect("teacher.aspx");
        }

        protected void imgBook_Click(object sender, ImageClickEventArgs e)
        {
          Response.Redirect("add_book.aspx");
        }

        protected void imgIssueBook_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("choose_for_issue.aspx");
        }

        protected void imgReturnBook_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("choose_for_return.aspx");
        }

        protected void imgSession_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("new_session.aspx");
        }

        protected void imgSettings_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("setting_others.aspx");
        }

        protected void imgWarning_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("warning_email.aspx");
        }

        protected void imgReport_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("allreport.aspx");
        }

        protected void imgAboutUs_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("aboutUs.aspx");
        }

        protected void imgPersonal_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("settings_admin.aspx");
        }

        protected void imgReport0_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("user.aspx");
        }
        

    }
}