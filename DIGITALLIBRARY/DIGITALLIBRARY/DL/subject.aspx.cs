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
    public partial class subject : System.Web.UI.Page
    {
        add_book_BLL obj = new add_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                btnUpdate.Visible = false;
                check_usertype();
                bindsubject();
                //binddepartment();
            }

        }
      
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Subject_id = Convert.ToInt32(row.Cells[0].Text);
            btnSubject_Id.Value = row.Cells[0].Text;
            db.Subject_name = row.Cells[1].Text;
            dt = obj.edit_subject(db);
            if (dt.Rows.Count > 0)
            {
                txtboxName.Text = dt.Rows[0]["Subject_Name"].ToString();
               

            }
            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Publication_id = Convert.ToInt32(row.Cells[0].Text);
            btnSubject_Id.Value = row.Cells[0].Text;
            DataTable dt1 = obj.get_book_by_subject(db);
            if (dt1.Rows.Count > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('you cant delete the data');", true);
            }
            else
            {
                obj.delete_subject(db);
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data is deleted successfully');", true);
            }                    
            bindsubject();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
           db.Subject_name = txtboxName.Text;
          // db.Department_id = Convert.ToInt32( ddlDepartment.SelectedValue);
           int a = check_null();
           if (a != 0)
           {
               obj.save_subject(db);
               txtboxName.Text = "";
               bindsubject();
               check_usertype();
               //binddepartment();
               ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);
           }

           else
           {
               ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter data in all field');", true);
           }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.Subject_id = Convert.ToInt32(btnSubject_Id.Value);
            db.Subject_name  = txtboxName.Text;
           // db.Department_id =Convert.ToInt32(ddlDepartment.SelectedValue);
             int a = check_null();
             if (a != 0)
             {
                 obj.update_subject(db);
                 txtboxName.Text = "";
                 //
                 bindsubject();
                 //binddepartment();
                 btnSave.Visible = true;
                 btnUpdate.Visible = false;
                 ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is Updated succesfully');", true);
             }

             else
             {
                 btnSave.Visible = false;
                 btnUpdate.Visible = true;
                 ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter data in all field');", true);
             }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtboxName.Text = "";
            if (gvSearchSubject.Visible == true)
            {
                gvSearchSubject.Visible = false;
                gvSubject.Visible = true;
                gvSubject_User.Visible = true;
            }
            check_usertype();
            //binddepartment();
        }
        public void bindsubject()
        {
            DataTable dt = new DataTable();
            dt = obj.bindsubject(db);
            gvSubject.DataSource = dt;
            gvSubject.DataBind();

            gvSubject_User.DataSource = dt;
            gvSubject_User.DataBind();
        }

        protected void gvSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int check_null()
        {
            if (txtboxName.Text != "")
            {
                return 1;
            }
            else
                return 0;
        }

        public void check_usertype()
        {
            db.Type = Session["User_Type"].ToString();
            if (db.Type == "user")
            {
                gvSubject_User.Visible = true;
                gvSubject.Visible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                gvSubject.Visible = true;
                gvSubject_User.Visible = false;
            }

        }

        protected void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            string connection = "data source=127.0.0.1; Initial catalog=modified; user=sa; password=015344;";

            SqlConnection con = new SqlConnection(connection);
            string query = "select * from subjects where Subject_Name LIKE '%" + txtSearchSubject.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                gvSearchSubject.DataSource = dt;
                gvSearchSubject.DataBind();
                gvSubject_User.Visible = false;
                gvSubject.Visible = false;
                gvSearchSubject.Visible = true;
                con.Close();
            }
        }

        protected void gvSubject_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSubject.PageIndex = e.NewPageIndex;
            bindsubject();
        }

        protected void gvSubject_User_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSubject_User.PageIndex = e.NewPageIndex;
            bindsubject();
        }
    }
}