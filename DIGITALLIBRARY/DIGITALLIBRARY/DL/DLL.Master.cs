using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DIGITALLIBRARY.DL
{
    public partial class DLL : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnTeacherR_Click(object sender, EventArgs e)
        {
            Response.Redirect("return_books_teacher.aspx");
        }

        protected void lbtnStudentR_Click(object sender, EventArgs e)
        {
            Response.Redirect("return_books.aspx");
        }

        protected void lbtnTeacher_Click(object sender, EventArgs e)
        {
            Response.Redirect("issue_book_teacher.aspx");
        }

        protected void lbtnStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("issue_book.aspx");
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_book.aspx");
        }

        protected void btnSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("supplier.aspx");
        }

        protected void btnPublication_Click(object sender, EventArgs e)
        {
            Response.Redirect("publication.aspx");
        }

        protected void btnAuthor_Click(object sender, EventArgs e)
        {
            Response.Redirect("author.aspx");
        }
    }
}