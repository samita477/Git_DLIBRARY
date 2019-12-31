using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DIGITALLIBRARY.DL
{
    public partial class choose_for_return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("return_books.aspx");
        }

        protected void imgTeacher_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("return_books_teacher.aspx");
        }
    }
}