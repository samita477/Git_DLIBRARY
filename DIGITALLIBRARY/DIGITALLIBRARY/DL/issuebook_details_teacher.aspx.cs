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
    public partial class issuebook_details_teacher : System.Web.UI.Page
    {
        issue_book_BLL obj = new issue_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindissuedetails();
            }

        }


        public void bindissuedetails()
        {
           
            DataTable dt1 = new DataTable();           
            dt1 = obj.bindissuedetails_teacher(db);
            gvIssueMaster_Teacher.DataSource = dt1;
            gvIssueMaster_Teacher.DataBind();
        }


        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("issue_book_teacher.aspx");
        }

        protected void btnview1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Imt_id = Convert.ToInt32(row.Cells[0].Text);
            btnIssueMaster_ID_Teacher.Value = row.Cells[0].Text;
            Session["IMT_ID"] = row.Cells[0].Text;
            Response.Redirect("issebook_detailhistory_teacher.aspx");
        }

        protected void gvIssueMaster_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}