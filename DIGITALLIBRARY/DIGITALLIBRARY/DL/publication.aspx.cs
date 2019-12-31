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
    public partial class publication : System.Web.UI.Page
    {
        add_book_BLL obj = new add_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
           
                check_usertype();
                bindpublication();
                if (!IsPostBack)
                {
                }
            

        }

        public void bindpublication()
        {
            DataTable dt = new DataTable();
            dt = obj.bindpublication(db);
            gvPublication.DataSource = dt;
            gvPublication.DataBind();
            gvPublication_User.DataSource = dt;
            gvPublication_User.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            db.Publication_name = txtName.Text;
            if (txtName.Text != "")
            {
                obj.save_publication(db);
                txtName.Text = "";
                btnUpdate.Visible = false;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);
                bindpublication();
                check_usertype();
                
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill up all textbox');", true);
                
            }

            
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            if (gvSearchPublication.Visible == true)
            {
                gvSearchPublication.Visible = false;
                gvPublication.Visible = true;
                gvPublication_User.Visible = true;
            }
            check_usertype();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Publication_id = Convert.ToInt32(row.Cells[0].Text);
            btnPublication_Id.Value = row.Cells[0].Text;
            db.Publication_name = row.Cells[1].Text;
            dt = obj.edit_publication(db);
            if (dt.Rows.Count > 0)
            {

                txtName.Text = dt.Rows[0]["Publication_Name"].ToString();

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
            btnPublication_Id.Value = row.Cells[0].Text;
            DataTable dt1 = obj.get_book_by_publication(db);
            if (dt1.Rows.Count > 0)
            {
                bindpublication();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('you cant delete the data');", true);
            }
            else
            {
                obj.delete_publication(db);
                bindpublication();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data is deleted successfully');", true);
            }          
           
            bindpublication();       
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.Publication_id = Convert.ToInt32(btnPublication_Id.Value);
            db.Publication_name = txtName.Text;
            if (txtName.Text != "")
            {
                obj.update_publication(db);
                txtName.Text = "";
                bindpublication();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is updated succesfully');", true);
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please fill up all data');", true);
            }
        }

        protected void gvPublication_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void check_usertype()
        {
            db.Type = Session["User_Type"].ToString();
            if (db.Type == "user")
            {
                gvPublication_User.Visible = true;
                gvPublication.Visible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                gvPublication.Visible = true;
                gvPublication_User.Visible = false;
            }

        }

        protected void txtSearchPublication_TextChanged(object sender, EventArgs e)
        {
            string connection = "data source=127.0.0.1; Initial catalog=modified; user=sa; password=015344;";

            SqlConnection con = new SqlConnection(connection);
            string query = "select * from publication where Publication_Name LIKE '%" + txtSearchPublication.Text + "%'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                gvSearchPublication.DataSource = dt;
                gvSearchPublication.DataBind();
                gvPublication_User.Visible = false;
                gvPublication.Visible = false;
                gvSearchPublication.Visible = true;
                con.Close();
            }
        }

        protected void gvPublication_User_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPublication_User.PageIndex = e.NewPageIndex;
            bindpublication();

        }

        protected void gvPublication_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPublication.PageIndex = e.NewPageIndex;
            bindpublication();

        }
      
       
    }
}