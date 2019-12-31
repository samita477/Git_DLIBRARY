using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DIGITALLIBRARY.DL
{
    public partial class choose_for_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImgAdmin_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void ImgStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("login_for_students.aspx");
        }

        protected void lbtnStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("login_for_students.aspx");
        }

        protected void lbtnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

      
    }
}