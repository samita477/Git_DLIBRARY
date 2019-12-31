using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DIGITALLIBRARY.DL
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImgBooks_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("add_book.aspx");
        }

        protected void ImgStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("add_student.aspx");
        }

        protected void ImgIssue_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("choose_for_issue.aspx");
        }

        protected void ImgReturn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("choose_for_return.aspx");
        }

        protected void ImgUser_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("user.aspx");
        }

        protected void ImgPenatly_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("settings_admin.aspx");
        }

        protected void ImgAboutus_Click(object sender, ImageClickEventArgs e)
        {
          // Response.Redirect("aboutUs.aspx");
           Response.Redirect("warning_email.aspx");
        }

        protected void ImgTeacher_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("teacher.aspx");
        }

        protected void ImgSemester_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("new_session.aspx");
        }

        protected void ImgWarning_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("warning_email.aspx");
        }

        protected void ImgReport_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("allreport.aspx");
        }
    }
}