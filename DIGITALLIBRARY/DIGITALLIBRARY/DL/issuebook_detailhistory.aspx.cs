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
    
    public partial class issuebook_detailhistory : System.Web.UI.Page
    {
        issue_book_BLL obj= new issue_book_BLL();
        DBcontainer db= new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            //bindgridview();
            if (!IsPostBack)
            {
                bindgridview();
            }

        }
        public void bindgridview()
        {
          
             DataTable dt = new DataTable();
             db.Im_ID = Convert.ToInt32(Session["IM_ID"].ToString());
                 dt = obj.bindgridview(db);
                 if (dt.Rows.Count > 0)
                 {
                     gvIssuedetails.DataSource = dt;
                     gvIssuedetails.DataBind();
                 }

                 else
                 {
                     Response.Redirect("issuebook_details.aspx");
                     ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Books Not Issued');", true);
                     
                 }
        }

        
        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("issuebook_details.aspx");
        }
    }
}