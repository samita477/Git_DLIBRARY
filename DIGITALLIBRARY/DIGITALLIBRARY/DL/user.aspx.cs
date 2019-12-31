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
    public partial class user : System.Web.UI.Page
    {
        user_BLL obj = new user_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            if (!IsPostBack)
            {
                binduser();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            db.User_name = txtboxName.Text;
            db.User_address = txtboxAddress.Text;
            db.User_phno = txtboxPhone.Text;
            db.User_email = txtboxEmail.Text;
            db.Password = txtboxPassword.Text;
            db.Type = txtboxType.Text;
            db.Authority = ckboxAuthority.Checked;
            db.User_gender = txtboxGender.Text;
            int a = check_empty();
            if (txtboxPassword.Text != "")
            {
                if (a != 0)
                {
                    dt = obj.get_user(db);
                    if (dt.Rows.Count > 0)
                    {
                        lblmsg.Text = "user of this name already exists";
                    }
                    else
                    {
                        obj.save_user(db);
                        binduser();
                        cleartext();
                    }
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill up all textbox');", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill up all textbox');", true);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            cleartext();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.User_id = Convert.ToInt32(row.Cells[0].Text);
            btnUsers_Id.Value = row.Cells[0].Text;
            db.User_name = row.Cells[1].Text;
            db.User_address = row.Cells[2].Text;
            db.User_phno = row.Cells[3].Text;
            db.User_email = row.Cells[4].Text;
            db.User_gender=row.Cells[5].Text;
            db.Type= row.Cells[6].Text;
            db.Authority= Convert.ToBoolean(row.Cells[7].Text);

            dt = obj.edit_user(db);
            if (dt.Rows.Count > 0)
            {
                txtboxName.Text = dt.Rows[0]["Name"].ToString();
                txtboxAddress.Text = dt.Rows[0]["_address"].ToString();
                txtboxEmail.Text = dt.Rows[0]["email"].ToString();
                txtboxPhone.Text = dt.Rows[0]["ph_no"].ToString();
                txtboxGender.Text = dt.Rows[0]["gender"].ToString();
                txtboxType.Text = dt.Rows[0]["_type"].ToString();
                DataTable dt1 = obj.edit_user(db);
                txtboxPassword.Attributes.Add("value", dt1.Rows[0]["_password"].ToString());
               // txtboxPassword.Text = dt.Rows[0]["_password"].ToString();
                ckboxAuthority.Checked=Convert.ToBoolean(dt.Rows[0]["authority"].ToString());

            }
            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.User_id = Convert.ToInt32(row.Cells[0].Text);
            btnUsers_Id.Value = row.Cells[0].Text;
            obj.delete_user(db);
            binduser();
            cleartext();
        }


        public void cleartext()
        {
            txtboxAddress.Text = "";
            txtboxEmail.Text = "";
            txtboxName.Text = "";
            txtboxPassword.Text = "";
            txtboxPhone.Text = "";
            txtboxType.Text = "";
            txtboxGender.Text = "";
            ckboxAuthority.Checked = false;
            txtboxPassword.Attributes.Add("value", "");
            
        }

        public void binduser()
        {
            DataTable dt = new DataTable();
            dt = obj.binduser(db);
            gvUser.DataSource = dt;
            gvUser.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.User_id = Convert.ToInt32(btnUsers_Id.Value);
            db.User_name = txtboxName.Text;
            db.User_address = txtboxAddress.Text;
            db.User_email = txtboxEmail.Text;
            db.User_phno = txtboxPhone.Text;
            db.User_gender = txtboxGender.Text;
            db.Password = txtboxPassword.Text;
            db.Type = txtboxType.Text;
            db.Authority = ckboxAuthority.Checked;
            int a = check_empty();
            if (a != 0)
            {
                obj.update_user(db);
                cleartext();
                binduser();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data is updated successfully');", true);
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill up all textbox');", true);
               
            }

        }

        protected void gvUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int check_empty()
        {
            if (txtboxName.Text != "")
            {
                if (txtboxAddress.Text != "")
                {
                    if (txtboxPhone.Text != "")
                    {
                        if (txtboxEmail.Text != "")
                        {
                            if (txtboxGender.Text!= "")
                            {
                                if (txtboxType.Text != "")
                                {
                                    return 1;
                                }

                                else
                                    return 0;

                            }
                            else
                                return 0;

                        }

                        else
                            return 0;


                    }

                    else
                        return 0;

                }

                else
                    return 0;

            }
            else
                return 0;
        }

        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUser.PageIndex = e.NewPageIndex;
            binduser();
        }

       
      
    }
}