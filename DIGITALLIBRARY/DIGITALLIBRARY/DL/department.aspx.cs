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
    public partial class department : System.Web.UI.Page
    {
        add_book_BLL obj = new add_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                btnUpdate.Visible = false;
                check_usertype();
                binddepartment();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Department_id= Convert.ToInt32(row.Cells[0].Text);
            btnDepartment_Id.Value = row.Cells[0].Text;
            db.Department_name = row.Cells[1].Text;
            dt = obj.edit_department(db);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["Department_Name"].ToString();

            }
            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Department_id = Convert.ToInt32(row.Cells[0].Text);
            btnDepartment_Id.Value = row.Cells[0].Text;
            obj.delete_department(db);
            binddepartment();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            db.Department_name = txtName.Text;
            if (txtName.Text != "")
            {
                obj.save_department(db);
                txtName.Text = "";
                check_usertype();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);
                binddepartment();
            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill up textbox');", true);
            }
        }
       
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.Department_id = Convert.ToInt32(btnDepartment_Id.Value);
            db.Department_name = txtName.Text;
            if (txtName.Text != "")
            {
                obj.update_department(db);
                txtName.Text = "";
                binddepartment();
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            if (gvSearchDepartment.Visible == true)
            {
                gvSearchDepartment.Visible = false;
                gvDepartment.Visible = true;
                gvDepartment_User.Visible = true;
            }
            check_usertype();
        }
        public void binddepartment()
        {
            DataTable dt = new DataTable();
            dt = obj.binddepartment(db);
            gvDepartment.DataSource = dt;
            gvDepartment.DataBind();
            gvDepartment_User.DataSource = dt;
            gvDepartment_User.DataBind();
        }

        public void check_usertype()
        {
            db.Type = Session["User_Type"].ToString();
            if (db.Type == "user")
            {
                gvDepartment_User.Visible = true;
                gvDepartment.Visible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                gvDepartment.Visible = true;
                gvDepartment_User.Visible = false;
            }

        }

        protected void txtSearchDepartment_TextChanged(object sender, EventArgs e)
        {
            string connection = "data source=127.0.0.1; Initial catalog=modified; user=sa; password=015344;";

            SqlConnection con = new SqlConnection(connection);

            try
            {
                string query = "select * from department where Department_Name LIKE '%" + txtSearchDepartment.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvSearchDepartment.DataSource = dt;
                    gvSearchDepartment.DataBind();
                    gvDepartment_User.Visible = false;
                    gvDepartment.Visible = false;
                    gvSearchDepartment.Visible = true;
                    con.Close();
                }
            }
            catch { }

           
        }

       

        protected void gvDepartment_User_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDepartment_User.PageIndex = e.NewPageIndex;
            binddepartment();

        }

        protected void gvDepartment_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDepartment.PageIndex = e.NewPageIndex;
            binddepartment();
        }
    }
}