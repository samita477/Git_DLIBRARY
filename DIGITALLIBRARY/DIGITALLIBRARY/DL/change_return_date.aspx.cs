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
    public partial class change_return_date : System.Web.UI.Page
    {
        session_BLL obj = new session_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                bindthissession();
            }
        }

        public void bindthissession()
        {
            db.Semester_id = Convert.ToInt32(Session["Semester_ID"].ToString());
            DataTable dt = new DataTable();
            dt = obj.bindthissession(db);
            gvNewReturn.DataSource = dt;
            gvNewReturn.DataBind();

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            db.Semester_id = Convert.ToInt32(Session["Semester_ID"].ToString());
            db.Date_to =Convert.ToDateTime(txtNewReturnDate.Text);
            obj.update_session_returndate(db);
            bindthissession();
        }

        protected void imgFrom_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            txtNewReturnDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Calendar1_DayRender1(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.LightGray;
                e.Cell.ToolTip = "Booked";
            }
            else
                e.Cell.ToolTip = "Available";
        }

        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("settings_admin.aspx");
        }

    }
}