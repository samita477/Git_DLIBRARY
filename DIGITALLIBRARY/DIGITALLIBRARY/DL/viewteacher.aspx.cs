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
    public partial class viewteacher : System.Web.UI.Page
    {
        teacher_BLL obj = new teacher_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            bindteacher();
        }

        public void bindteacher()
        {
            DataTable dt = new DataTable();
            dt = obj.bindteacher(db);
            gvTeacher_User.DataSource = dt;
            gvTeacher_User.DataBind();
        }

        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("teacher.aspx");
        }
    }
}