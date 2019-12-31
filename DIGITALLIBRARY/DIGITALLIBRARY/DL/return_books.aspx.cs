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
    public partial class return_books : System.Web.UI.Page
    {
        return_book_BLL obj = new return_book_BLL();
        DBcontainer db = new DBcontainer();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            txtPenatlty.Visible = false;
            chkboxPaid.Visible = false;
            if (!IsPostBack)
            {
                bindstudent();
                
            }
        }

        public void bindstudent()
        {
            DataTable dt = obj.bindstudent(db);
            ddlStudent.DataSource = dt;
            ddlStudent.DataValueField = "Student_ID";
            ddlStudent.DataTextField = "Student_Name";
            ddlStudent.DataBind();
            ddlStudent.Items.Insert(0, new ListItem("--Select--", "-1"));

        }
        int issued_id = 0;
        int book_id = 0;
        int return_id = 0;
        protected void btn_Return_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.User_id = Convert.ToInt32(Session["User_Id"].ToString());
            db.Student_id = Convert.ToInt32(ddlStudent.SelectedValue);
            DataTable dt = obj.get_returnmasterid(db);
            if (dt.Rows.Count > 0)
            {
                db.Rm_id = Convert.ToInt32(dt.Rows[0]["RMH_ID"].ToString());
                return_id = Convert.ToInt32(dt.Rows[0]["RMH_ID"].ToString());

            }
            else
            {
                obj.save_returnmaster(db);
                DataTable d = obj.get_latest_returnmasterid(db);
                db.Rm_id = Convert.ToInt32(d.Rows[0]["RMH_ID"].ToString());
                return_id = Convert.ToInt32(d.Rows[0]["RMH_ID"].ToString());
            }
            db.Im_ID = Convert.ToInt32(row.Cells[0].Text);
            issued_id=Convert.ToInt32(row.Cells[0].Text);
            btnReturn_Id.Value = row.Cells[1].Text;
            db.Id_ID = Convert.ToInt32(row.Cells[1].Text);
            DataTable dt1 = obj.get_issuedetail_idid(db);
            db.Book_id = Convert.ToInt32(dt1.Rows[0]["Book_ID"].ToString());
            book_id = Convert.ToInt32(dt1.Rows[0]["Book_ID"].ToString());
            db.Issue_date = Convert.ToDateTime(dt1.Rows[0]["issue_date"].ToString());
            db.Return_date = Convert.ToDateTime(dt1.Rows[0]["return_date"].ToString());
            db.Returned_date = DateTime.Now;
            //obj.save_returndetail(db);
            double days = (Convert.ToDateTime(db.Returned_date) - Convert.ToDateTime(db.Return_date)).TotalDays;


            if (days > 0)
            {
                double rate = 5.0;
                double penalty = days * rate;
                lblMsg.Visible = true;
                txtPenatlty.Visible = true;
                chkboxPaid.Visible = true;
                chkboxPaid.Checked = false;
                txtPenatlty.Text = penalty.ToString();
                db.Penalty = penalty;
            }

            else
                db.Penalty = 0.0;

            
                //update book quantity
                DataTable d1 = obj.get_bookdetails(db);
                int Available_qty = Convert.ToInt32(d1.Rows[0]["avl_quantity"].ToString());
                db.Available_qt = Available_qty + 1;
                obj.update_bookquantity(db);

                //save in return details                
                obj.save_returndetail(db);

                //delete from issue detail              
                obj.delete_issuedetail_byid(db);

                //bind for gridview
                DataTable dt3 = obj.get_issuemaster_byid(db);
                db.Im_ID = Convert.ToInt32(dt3.Rows[0]["IM_ID"].ToString());
                DataTable dt4 = obj.get_issuedetail_byid(db);
                GridView1.DataSource = dt4;
                GridView1.DataBind();
            

        }

      

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Student_id = Convert.ToInt32(ddlStudent.SelectedValue);
            DataTable dt = obj.get_studentdetails(db);
            txtCode.Text = dt.Rows[0]["bar_code"].ToString(); 
            txtCrn.Text = dt.Rows[0]["crn"].ToString();            
            txtAddress.Text = dt.Rows[0]["_address"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtPhone.Text = dt.Rows[0]["ph_no"].ToString();
            txtGender.Text = dt.Rows[0]["gender"].ToString();
            DataTable dt1 = obj.get_issuemaster_byid(db);
            db.Im_ID = Convert.ToInt32(dt1.Rows[0]["IM_ID"].ToString());
            DataTable dt2 = obj.get_issuedetail_byid(db);
            GridView1.DataSource = dt2;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void imgbtnRefresh_Click(object sender, ImageClickEventArgs e)
        {
            clear_all();
            GridView1.DataSource = null;
            GridView1.DataBind();
        }

        public void clear_all()
        {
            txtAddress.Text = "";
            txtCrn.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtPhone.Text = "";
            txtCode.Text = "";
            
        }

        protected void chkboxPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxPaid.Checked == true)
            {
                lblMsg.Visible = false;
                txtPenatlty.Visible = false;
                chkboxPaid.Visible = false;
                //quantity update
                db.Book_id=book_id;
                DataTable dt1 = obj.get_bookdetails(db);
                int Available_qty = Convert.ToInt32(dt1.Rows[0]["avl_quantity"].ToString());
                db.Available_qt = Available_qty + 1;
                obj.update_bookquantity(db);
                //save in return details
                db.Id_ID = issued_id;
                db.Rm_id = return_id;
                DataTable dt2 = obj.get_issuedetail_idid(db);
                db.Book_id = Convert.ToInt32(dt2.Rows[0]["Book_ID"].ToString());
                db.Issue_date = Convert.ToDateTime(dt2.Rows[0]["issue_date"].ToString());
                db.Return_date = Convert.ToDateTime(dt2.Rows[0]["return_date"].ToString());
                db.Returned_date = DateTime.Now;
                obj.save_returndetail(db);
              
                //delete from issue detail
                db.Id_ID = issued_id;
                obj.delete_issuedetail_byid(db);

                //bind for gridview
                DataTable dt3 = obj.get_issuemaster_byid(db);
                db.Im_ID = Convert.ToInt32(dt3.Rows[0]["IM_ID"].ToString());
                DataTable dt4 = obj.get_issuedetail_byid(db);
                GridView1.DataSource = dt4;
                GridView1.DataBind();
            }
        }

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {
            db.Sbarcode = txtCode.Text;
            DataTable dt = obj.get_studentdetails_bybarcode(db);
            db.Student_id = Convert.ToInt32(dt.Rows[0]["Student_ID"].ToString());
            ddlStudent.SelectedValue = dt.Rows[0]["Student_ID"].ToString();
            txtAddress.Text = dt.Rows[0]["_address"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtPhone.Text = dt.Rows[0]["ph_no"].ToString();
            txtGender.Text = dt.Rows[0]["gender"].ToString();
            txtCrn.Text = dt.Rows[0]["crn"].ToString();
            DataTable dt1 = obj.get_issuemaster_byid(db);
            db.Im_ID = Convert.ToInt32(dt1.Rows[0]["IM_ID"].ToString());
            DataTable dt2 = obj.get_issuedetail_byid(db);
            if (dt2.Rows.Count > 0)
            {
                GridView1.DataSource = dt2;
                GridView1.DataBind();
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('you cant delete the data');", true);
            }
        }
     

     
    }
}