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
    public partial class return_books_teacher : System.Web.UI.Page
    {
        return_book_BLL obj = new return_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                bindteacher();
            }
        }

        public void bindteacher()
        {
            try
            {
                DataTable dt = obj.bindteacher(db);
                ddlStudent.DataSource = dt;
                ddlStudent.DataValueField = "Teacher_ID";
                ddlStudent.DataTextField = "Teacher_Name";
                ddlStudent.DataBind();
                ddlStudent.Items.Insert(0, new ListItem("--Select--", "-1"));

            }
            catch (Exception ex)
            {
            }
        }

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Teacher_id = Convert.ToInt32(ddlStudent.SelectedValue);
            DataTable dt = obj.get_teacherdetails(db);
            txtCode.Text = dt.Rows[0]["bar_code"].ToString();
            txtAddress.Text = dt.Rows[0]["_address"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtPhone.Text = dt.Rows[0]["ph_no"].ToString();
            txtGender.Text = dt.Rows[0]["gender"].ToString();
            DataTable dt1 = obj.get_issuemaster_byid_teacher(db);
            db.Imt_id = Convert.ToInt32(dt1.Rows[0]["IMT_ID"].ToString());
            DataTable dt2 = obj.get_issuedetail_byid_teacher(db);
            GridView1.DataSource = dt2;
            GridView1.DataBind();
        }
        int issued_id = 0;
        int book_id = 0;
        int return_id = 0;

        protected void btn_Return_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.User_id = Convert.ToInt32(Session["User_Id"].ToString());
            db.Teacher_id = Convert.ToInt32(ddlStudent.SelectedValue);
            DataTable dt = obj.get_returnmasterid_teacher(db);
            if (dt.Rows.Count > 0)
            {
                db.Rmt_id = Convert.ToInt32(dt.Rows[0]["RMHT_ID"].ToString());
                return_id = Convert.ToInt32(dt.Rows[0]["RMHT_ID"].ToString());

            }
            else
            {
                obj.save_returnmaster_teacher(db);
                DataTable d = obj.get_latest_returnmasterid_teacher(db);
                db.Rmt_id = Convert.ToInt32(d.Rows[0]["RMHT_ID"].ToString());
                return_id = Convert.ToInt32(d.Rows[0]["RMHT_ID"].ToString());
            }
            db.Imt_id = Convert.ToInt32(row.Cells[0].Text);
            issued_id = Convert.ToInt32(row.Cells[0].Text);
            btnReturn_Id.Value = row.Cells[1].Text;
            db.Idt_id = Convert.ToInt32(row.Cells[1].Text);
            DataTable dt1 = obj.get_issuedetail_idid_teacher(db);
            db.Book_id = Convert.ToInt32(dt1.Rows[0]["Book_ID"].ToString());
            book_id = Convert.ToInt32(dt1.Rows[0]["Book_ID"].ToString());
            db.Issue_date = Convert.ToDateTime(dt1.Rows[0]["issue_date"].ToString());
            db.Return_date = Convert.ToDateTime(dt1.Rows[0]["return_date"].ToString());
            db.Returned_date = DateTime.Now;
           // obj.save_returndetail(db);          

            //update book quantity
            DataTable dt2 = obj.get_bookdetails(db);
            int Available_qty = Convert.ToInt32(dt2.Rows[0]["avl_quantity"].ToString());
            db.Available_qt = Available_qty + 1;
            obj.update_bookquantity(db);

            //save in return details                
            obj.save_returndetail_teacher(db);

            //delete from issue detail              
           obj.delete_issuedetail_byid_teacher(db);

            //bind for gridview
            DataTable dt3 = obj.get_issuemaster_byid_teacher(db);
            db.Imt_id = Convert.ToInt32(dt3.Rows[0]["IMT_ID"].ToString());
            DataTable dt4 = obj.get_issuedetail_byid_teacher(db);
            GridView1.DataSource = dt4;
            GridView1.DataBind();
        }

      

        protected void imgbtnRefresh_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("return_books_teacher.aspx");
        }

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {
            db.Tbarcode = txtCode.Text;
            DataTable dt = obj.get_teacherdetails_bybarcode(db);
            ddlStudent.SelectedValue = dt.Rows[0]["Teacher_ID"].ToString();
            txtAddress.Text = dt.Rows[0]["_address"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtPhone.Text = dt.Rows[0]["ph_no"].ToString();
            txtGender.Text = dt.Rows[0]["gender"].ToString();
        }
    }
}