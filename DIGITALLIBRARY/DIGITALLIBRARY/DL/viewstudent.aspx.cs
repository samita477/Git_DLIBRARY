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
    public partial class viewstudent : System.Web.UI.Page
    {

        add_student_BLL obj = new add_student_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            bindgrid();
        }

        public void bindgrid()
        {
            
            DataTable dt = new DataTable();
            dt = obj.bindstudent(db); 
            gvViewStudent.DataSource = dt;
            gvViewStudent.DataBind();
        }

        protected void gvViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("add_student.aspx");
        }
    }
}