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
    public partial class new_session : System.Web.UI.Page
    {
        session_BLL obj = new session_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
           
          
            if (!IsPostBack)
            {
                 bindsession();
                btnUpdate.Visible=false;
                Calendar1.Visible = false;
                Calendar2.Visible = false;
            }
        }

        public void bindsession()
        {
            DataTable dt = new DataTable();
            dt = obj.bindsession(db);
            gvSession.DataSource = dt;
            gvSession.DataBind();
        }

        //protected void btnEdit_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    Button btn = (Button)sender;
        //    GridViewRow row = (GridViewRow)btn.NamingContainer;
        //    db.Semester_id = Convert.ToInt32(row.Cells[0].Text);
        //    btnSession_Id.Value = row.Cells[0].Text;
        //    dt = obj.edit_session(db);
        //    if (dt.Rows.Count > 0)
        //    {
        //        txtName.Text = dt.Rows[0]["Semester_Name"].ToString();
        //        DateTime d=Convert.ToDateTime( dt.Rows[0]["date_from"].ToString());
        //        txtFrom.Text = d.ToShortDateString();
        //        DateTime d1 = Convert.ToDateTime(dt.Rows[0]["date_to"].ToString());
        //        txtTo.Text = d1.ToShortDateString();
        //        txtPenalty.Text =dt.Rows[0]["penlty_rate"].ToString();
        //    }

        //    btnCreate.Visible = false;
        //    btnUpdate.Visible = true;

        //}

        protected void btnCreate_Click(object sender, EventArgs e)
        {       
           db.Semester_name=txtName.Text;
            db.Date_from=Convert.ToDateTime(txtFrom.Text);
            db.Date_to=Convert.ToDateTime(txtTo.Text);
            db.Penalty_rate=Convert.ToDecimal(txtPenalty.Text);
            db.Book_student = Convert.ToInt32(txtbookStudent.Text);
            db.Book_teacher = Convert.ToInt32(txtbookteacher.Text);
            obj.save_session(db);
            cleartext();
            bindsession();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.Semester_id = Convert.ToInt32(btnSession_Id.Value);
            db.Semester_name = txtName.Text;
            db.Date_from=Convert.ToDateTime(txtFrom.Text);
            db.Date_to=Convert.ToDateTime(txtTo.Text);
            db.Penalty_rate= Convert.ToDecimal(txtPenalty.Text);
            db.Book_student = Convert.ToInt32(txtbookStudent.Text);
            db.Book_teacher = Convert.ToInt32(txtbookteacher.Text);
                obj.update_session(db);
                cleartext();
                bindsession();
                btnCreate.Visible = true;
                btnUpdate.Visible = false;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is updated succesfully');", true);
            }            
        //    {
        //        btnSave.Visible = false;
        //        btnUpdate.Visible = true;
        //        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill up textbox');", true);
        //    }
        //}

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            cleartext();
            btnCreate.Visible = true;
            btnUpdate.Visible = false;
        }

        public void cleartext()
        {
            txtName.Text="";
            txtFrom.Text="";
            txtTo.Text = "";
            txtPenalty.Text = "";
            bindsession();
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

        protected void imgTo_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar2.Visible)
            {
                Calendar2.Visible = false;
            }
            else
            {
                Calendar2.Visible = true;
            }

        }

        protected void gvSession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click2(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Semester_id = Convert.ToInt32(row.Cells[0].Text);
            btnSession_Id.Value = row.Cells[0].Text;
            dt = obj.edit_session(db);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["Semester_Name"].ToString();
                DateTime d = Convert.ToDateTime(dt.Rows[0]["date_from"].ToString());
                txtFrom.Text = d.ToShortDateString();
                DateTime d1 = Convert.ToDateTime(dt.Rows[0]["date_to"].ToString());
                txtTo.Text = d1.ToShortDateString();
                txtPenalty.Text = dt.Rows[0]["penlty_rate"].ToString();
                txtbookStudent.Text =dt.Rows[0]["book_student"].ToString();
                txtbookteacher.Text = dt.Rows[0]["book_teacher"].ToString();
            }

            btnCreate.Visible = false;
            btnUpdate.Visible = true;

        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Semester_id = Convert.ToInt32(row.Cells[0].Text);
            btnSession_Id.Value = row.Cells[0].Text;
            obj.delete_session(db);
            cleartext();
            bindsession();
        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate.ToShortDateString() !="")
            {
                txtFrom.Text = Calendar1.SelectedDate.ToShortDateString();
                Calendar1.Visible = false;
            }
           
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

        protected void Calendar2_SelectionChanged1(object sender, EventArgs e)
        {
            txtTo.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;
        }

        protected void Calendar2_DayRender1(object sender, DayRenderEventArgs e)
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

        protected void gvSession_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSession.PageIndex = e.NewPageIndex;
            bindsession();
        }
    }
}