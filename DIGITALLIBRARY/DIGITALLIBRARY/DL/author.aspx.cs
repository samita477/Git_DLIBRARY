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
    public partial class author : System.Web.UI.Page
    {
        add_book_BLL obj = new add_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            check_usertype();
            bindauthor();
            check_usertype();
          if (!IsPostBack)
          {
              
              bindauthor();
          }
        }
        public void bindauthor()
        {
            DataTable dt = new DataTable();
            dt = obj.bindauthor(db);
            gvAuthor.DataSource = dt;
            gvAuthor.DataBind();
            gvAuthor_User.DataSource = dt;
            gvAuthor_User.DataBind();
            
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Author_id = Convert.ToInt32(row.Cells[0].Text);
            btnAuthor_Id.Value = row.Cells[0].Text;
            db.Author_name = row.Cells[1].Text;
            dt= obj.edit_author(db);
            if (dt.Rows.Count > 0)
            {
                txtboxName.Text = dt.Rows[0]["Author_Name"].ToString();
 
            }
            btnSave.Visible = false;
            btnUpdate.Visible = true;
         }
        

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Author_id = Convert.ToInt32(row.Cells[0].Text);
            btnAuthor_Id.Value = row.Cells[0].Text;
            DataTable dt1 = obj.get_book_by_author(db);
            if (dt1.Rows.Count > 0)
            {
                bindauthor();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('you cant delete the data');", true);
            }
            else
            {
                obj.delete_author(db);
                bindauthor();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data is deleted successfully');", true);
            }
           
            bindauthor();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            db.Author_name = txtboxName.Text;
            if (txtboxName.Text != "")
            {
                obj.save_author(db);
                txtboxName.Text = "";
                btnUpdate.Visible = false;
                check_usertype();
                bindauthor();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill up textbox');", true);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtboxName.Text = "";
            if (gvSearchAuthor.Visible == true)
            {
                gvSearchAuthor.Visible = false;
                gvAuthor.Visible = true;
                gvAuthor_User.Visible = true;
            }
            check_usertype();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.Author_id = Convert.ToInt32(btnAuthor_Id.Value);
            db.Author_name = txtboxName.Text;
            if (txtboxName.Text != "")
            {
                obj.update_author(db);
                txtboxName.Text = "";
                bindauthor();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is updated succesfully');", true);
            }

            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill up textbox');", true);
            }
        }

        protected void gvAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void check_usertype()
        {
            db.Type = Session["User_Type"].ToString();
            if (db.Type == "user")
            {
                gvAuthor_User.Visible = true;
                gvAuthor.Visible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                gvAuthor.Visible = true;
                gvAuthor_User.Visible = false;
            }

        }

        protected void txtSearchAuthor_TextChanged(object sender, EventArgs e)
        {
            string connection = "data source=127.0.0.1; Initial catalog=modified; user=sa; password=015344;";

            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "select * from author where Author_Name LIKE '%" + txtSearchAuthor.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvSearchAuthor.DataSource = dt;
                    gvSearchAuthor.DataBind();
                    gvAuthor_User.Visible = false;
                    gvAuthor.Visible = false;
                    gvSearchAuthor.Visible = true;
                    con.Close();
                }

            }
            catch { }


          

        }

        protected void gvSearchAuthor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSearchAuthor.PageIndex = e.NewPageIndex;
            bindauthor();
        }

        protected void gvAuthor_User_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAuthor_User.PageIndex = e.NewPageIndex;
            bindauthor();
        }

        protected void gvAuthor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAuthor.PageIndex = e.NewPageIndex;
            bindauthor();
        }
    }
}