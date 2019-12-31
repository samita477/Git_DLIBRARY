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
    public partial class change_no_of_issuedbook_teacher : System.Web.UI.Page
    {
        session_BLL obj = new session_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindthissession();
                
            }
        }
        public void bindthissession()
        {
            DataTable dt = new DataTable();
            db.Semester_id = Convert.ToInt32(Session["Semester_ID"].ToString());
            dt = obj.bindthissession(db);
            gvNewnumber.DataSource = dt;
            gvNewnumber.DataBind();

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            db.Semester_id = Convert.ToInt32(Session["Semester_ID"].ToString());
            db.Book_teacher = Convert.ToInt32(txtNewReturnDate.Text);
            obj.update_session_Tbook(db);
            bindthissession();
         }

        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("settings_admin.aspx");
        }

       
      
    }
}