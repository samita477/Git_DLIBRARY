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
    public partial class subject_student : System.Web.UI.Page
    {
        subject_BLL obj = new subject_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            }
            bindsubject();
        }

        public void bindsubject()
        {
             DataTable dt = new DataTable();
            dt = obj.bindsubject(db);
            gvSubject.DataSource = dt;
            gvSubject.DataBind();
        }

        protected void gvSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnViewDetails_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Book_id = Convert.ToInt32(row.Cells[0].Text);
            btnSubject_Id.Value = row.Cells[0].Text;
            Session["Subject_ID"] = row.Cells[0].Text;
            Response.Redirect("subjectdetail_student.aspx");
        }

        protected void gvSubject_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSubject.PageIndex = e.NewPageIndex;
            bindsubject();
        }
    }
}