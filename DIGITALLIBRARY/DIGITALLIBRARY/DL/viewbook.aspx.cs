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
    public partial class viewbook : System.Web.UI.Page
    {
        add_book_BLL obj = new add_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            bindgrid();
        }

        public void bindgrid()
        {
            DataTable dt = new DataTable();
            dt = obj.bindbook(db);
            gvViewbook.DataSource = dt;
            gvViewbook.DataBind();
        }

        protected void gvViewbook_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("add_book.aspx");

        }


    }
}