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
    public partial class choose_session : System.Web.UI.Page
    {
        session_BLL obj = new session_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            bindsession();
            if (!IsPostBack)
            {
                bindsession();
            }
        }

        public void bindsession()
        {
            DataTable dt = new DataTable();
            dt = obj.bindsession(db);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            Session["Semester_ID"] = row.Cells[0].Text;
            Session["Semester_Name"] = row.Cells[1].Text;
            Session["Date_From"] = row.Cells[3].Text;
            Session["Penalty_Rate"] = row.Cells[4].Text;
            Session["book_student"] = row.Cells[5].Text;
            Session["book_teacher"] = row.Cells[6].Text;
             db.Type = Session["User_Type"].ToString();
             if (db.Type == "user")
                 Response.Redirect("homepage.aspx");
             else
                 Response.Redirect("dashboard.aspx");
        
        }
    }
}