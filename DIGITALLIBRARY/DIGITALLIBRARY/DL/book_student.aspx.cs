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
    public partial class book_student : System.Web.UI.Page
    {
        add_book_BLL obj = new add_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind_Avlbook();
                check_usertype();
                suggestbook();
            }
        }
        public void bind_Avlbook()
        {
            DataTable dt = new DataTable();
            dt = obj.bind_Avlbook(db);
            gvSearchBook.DataSource = dt;
            gvSearchBook.DataBind();
            gvSearchTeacher.DataSource = dt;
            gvSearchTeacher.DataBind();
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Book_id = Convert.ToInt32(row.Cells[0].Text);
            btnBook_Id.Value = row.Cells[0].Text;
            Session["Book_ID"] = row.Cells[0].Text;
            Response.Redirect("bookdetail_student.aspx");
        }

        protected void gvBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Book_id = Convert.ToInt32(row.Cells[0].Text);
            db.Student_id = Convert.ToInt32(Session["SID"].ToString());
            btnBook_Id.Value = row.Cells[1].Text;
            DataTable dt1 = obj.check_ifalreadybooked(db);
            if (dt1.Rows.Count > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have already booked this book');", true);
            }
            else
            {
                obj.save_book_booked(db);
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Booked');", true);
            }
            bind_Avlbook();

            
        }

        public void check_usertype()
        {
           db.Type = Session["_User_Type"].ToString();
            if (db.Type == "student")
            {
                db.Student_id = Convert.ToInt32(Session["SID"].ToString());
                gvSearchBook.Visible = true;
                gvSearchTeacher.Visible = false;
              
            }
            else
            {
                gvSearchTeacher.Visible = true;
                gvSearchBook.Visible = false;
            }

        }

        protected void gvSearchBook_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSearchBook.PageIndex = e.NewPageIndex;
            bind_Avlbook();
        }

        public void suggestbook()
        {
            try
            {
                db.Student_id = Convert.ToInt32(Session["SID"].ToString());
                DataTable dt2 = obj.spStudDetail(db);
                db.Semester_id = Convert.ToInt32(dt2.Rows[0]["semster"].ToString());
                DataTable dt = obj.spSubRet(db);
                int[] cn = new int[6];

                // DataTable dt1=new DataTable();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    db.Subject_id = Convert.ToInt32(dt.Rows[i][0]);
                    DataTable dt1 = obj.spSuggestBid(db);
                    cn[i] = Convert.ToInt32(dt1.Rows[0][0].ToString());
                }
                DataList1.DataSource = null;
                db.Semester_id = cn[0];
                db.User_id = cn[1];
                db.Verification_id = cn[2];
                db.Bb_id = cn[3];
                db.Student_id = cn[4];
                db.Semester_id = cn[5];

                //DataTable dt3 = obj.spBookDetail(db);
                //dt3.Columns.Add("Book_ID");
                //dt3.Columns.Add("Book_Name");
                //dt3.Columns.Add("Image_URL");
                //int a;
                //string b;
                //string c;
                //for (int i = 0; i < dt3.Rows.Count; i++)
                //{
                //    a=Convert.ToInt32( dt3.Rows[i]["Book_ID"].ToString());
                //    db.Book_id = a;
                //    DataTable dt4 = obj.edit_book(db);
                //    b = dt4.Rows[0]["Book_Name"].ToString();
                //    c = dt4.Rows[0]["image_URL"].ToString();
                //    dt3.Rows.Add(a, b, c);

                //}
                DataList1.DataSource = obj.spBookDetail(db);
                DataList1.DataBind();
            }
            catch { }
        }

        protected void BtnReserve0_Click(object sender, EventArgs e)
        {
            db.Book_id = Convert.ToInt32(((Button)sender).CommandArgument);
            db.Student_id = Convert.ToInt32(Session["SID"].ToString());
            DataTable dt1 = obj.check_ifalreadybooked(db);
            if (dt1.Rows.Count > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have already booked this book');", true);
            }
            else
            {
                obj.save_book_booked(db);
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Booked');", true);
            }

        }
           
    }
}