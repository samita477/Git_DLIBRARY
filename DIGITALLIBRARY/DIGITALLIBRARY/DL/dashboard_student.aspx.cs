using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DIGITALLIBRARY.DL
{
    public partial class dashboard_student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void ImgBook_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("book_student.aspx");
        }

        protected void ImgSubject_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("subject_student.aspx");
        }

        
        protected void ImgSettings_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("settings_student.aspx");
        }

        protected void ImgAboutus_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("aboutus_student.aspx");
        }

        
        protected void ImgReturn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("issuebook_student.aspx");
        }

       
    }
}