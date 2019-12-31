using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DIGITALLIBRARY.DL
{
    public partial class choose_for_issue : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgTeacher_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("issue_book_teacher.aspx");
        }

        protected void imgStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("issue_book.aspx");
        }
    }
}