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
    public partial class issuebook_details : System.Web.UI.Page
    {
        issue_book_BLL obj = new issue_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            //bindissuedetails();
            //rbtnStudent.Checked = true;
            //rbtnTeacher.Checked = false;
            if (!IsPostBack)
            {
                gvIssueMaster.Visible = true;
                bindissuedetails();
                             
            }


        }

        public void bindissuedetails()
        {
            DataTable dt = new DataTable();
       
             dt = obj.bindissuedetails(db);
                     gvIssueMaster.DataSource =dt;
                     gvIssueMaster.DataBind();
             
           
        }

       
        protected void btnview_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Im_ID = Convert.ToInt32(row.Cells[0].Text);
            btnIssueMaster_ID.Value = row.Cells[0].Text;
         
            Session["IM_ID"] = row.Cells[0].Text;
            Response.Redirect("issuebook_detailhistory.aspx");
        }

        protected void gvIssueMaster_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("issue_book.aspx");
        }

    }
}