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
    public partial class setting_other : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            db.Semester_id = Convert.ToInt32(Session["Semester_ID"].ToString());
            db.Date_to = Convert.ToDateTime(txtDate.Text);
            obj.update_session_returndate(db);
            bindthissession();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            db.Semester_id = Convert.ToInt32(Session["Semester_ID"].ToString());
            db.Book_teacher = Convert.ToInt32(txtTBook.Text);
            obj.update_session_Tbook(db);
            db.Book_teacher = Convert.ToInt32(txtSBook.Text);
            obj.update_session_Sbook(db);
            bindthissession();
        
        }

        protected void LbtnChangeRD_Click(object sender, EventArgs e)
        {
            fillvalue();
            lblTbook.Visible = false;
            lblSBook.Visible = false;
            txtSBook.Visible = false;
            txtTBook.Visible = false;
            lbldate.Visible = true;
            txtDate.Visible = true;
          }

        protected void lbtnChangeBS_Click(object sender, EventArgs e)
        {
            fillvalue();
            lblTbook.Visible = true;
            lblSBook.Visible = true;
            txtSBook.Visible = true;
            txtTBook.Visible = true;
            lbldate.Visible = false;
            txtDate.Visible = false;
        }

        private void fillvalue()
        {
            db.Semester_id = Convert.ToInt32(Session["Semester_ID"].ToString());
            DataTable dt = obj.bindthissession(db);
            txtDate.Text = dt.Rows[0]["date_to"].ToString();
            txtSBook.Text = dt.Rows[0]["book_student"].ToString();
            txtTBook.Text = dt.Rows[0]["book_teacher"].ToString();
        }
     }
}