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
    public partial class teacher : System.Web.UI.Page
    {
        teacher_BLL obj = new teacher_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                bindteacher();
                btnUpdate.Visible = false;
                check_usertype();
                binddepartment();
            }
        }
        public void bindteacher()
        {
            DataTable dt = new DataTable();
            dt = obj.bindteacher(db);
            gvViewTeacher.DataSource = dt;
            gvViewTeacher.DataBind();
            gvTeacher_User.DataSource = dt;
            gvTeacher_User.DataBind();
        }

        public void binddepartment()
        {
            DataTable dt = new DataTable();
            dt = obj.binddepartment(db);
            ddlDepartment.DataSource = dt;
            ddlDepartment.DataValueField = "Department_ID";
            ddlDepartment.DataTextField = "Department_Name";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "-1"));
          
        }
        public void cleartext()
        {
            txtCode.Text = "";
            txtboxName.Text = "";
            txtboxAddress.Text = "";
            txtboxPhn.Text = "";
            txtEmail.Text = "";
            ImgSnap.ImageUrl = "";
            txtSubject.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            db.Barcode = txtCode.Text;
            db.Teacher_name = txtboxName.Text;
            db.Teacher_address = txtboxAddress.Text;
            db.Teacher_phnno = txtboxPhn.Text;
            db.Teacher_gender = ddlGender.SelectedValue;
            db.Teacher_email = txtEmail.Text;
            db.Citizenship = ReadImageFile_Image(FuSnap);
            db.Subject_assigned =Convert.ToInt32(txtSubject.Text);
            db.Department_id = Convert.ToInt32(ddlDepartment.SelectedValue);
            db.Active = true;
            obj.save_teacher(db);
            cleartext();
             bindteacher();
            binddepartment();
            check_usertype();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            cleartext();
            if (gvSearchTeacher.Visible == true)
            {
                gvSearchTeacher.Visible = false;
               gvViewTeacher.Visible = true;
               gvTeacher_User.Visible = true;
            }
            check_usertype();
            bindteacher();
            binddepartment();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.Barcode = txtCode.Text;
            db.Teacher_id = Convert.ToInt32(btnTeacher_Id.Value);
            db.Teacher_name = txtboxName.Text;
            db.Teacher_address = txtboxAddress.Text;
            db.Teacher_phnno = txtboxPhn.Text;
            db.Teacher_gender = ddlGender.SelectedValue;
            db.Teacher_email = txtEmail.Text;
            db.Citizenship = ReadImageFile_Image(FuSnap);
            db.Department_id = Convert.ToInt32(ddlDepartment.SelectedValue);
            db.Subject_assigned = Convert.ToInt32(txtSubject.Text);
            obj.update_teacher(db);
            cleartext();
            bindteacher();
            binddepartment();
            btnSave.Visible = true;
           
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is updated succesfully');", true);
        }

        protected void btnEdit_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Teacher_id = Convert.ToInt32(row.Cells[0].Text);
            btnTeacher_Id.Value = row.Cells[0].Text;
            db.Teacher_name = row.Cells[1].Text;
            db.Teacher_address = row.Cells[2].Text;
            db.Teacher_phnno = row.Cells[3].Text;
            db.Teacher_gender = row.Cells[4].Text;
            db.Teacher_email = row.Cells[5].Text;
            db.Citizenship = ReadImageFile_Image(FuSnap);
            db.Tbarcode=(row.Cells[7].Text);
            //db.Department_id = Convert.ToInt32(row.Cells[8].Text);
            //db.Subject_assigned =Convert.ToInt32(row.Cells[9].Text);
            dt = obj.edit_teacher(db);
            if (dt.Rows.Count > 0)
            {
                txtCode.Text=dt.Rows[0]["bar_code"].ToString();
                txtboxName.Text = dt.Rows[0]["Teacher_Name"].ToString();
                txtboxAddress.Text = dt.Rows[0]["_address"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtboxPhn.Text = dt.Rows[0]["ph_no"].ToString();
                ddlGender.SelectedValue = dt.Rows[0]["gender"].ToString();
                ImgSnap.ImageUrl = String.Format("../Handler/TeacherImage.ashx?Teacher_ID={0}", db.Teacher_id);
                ImgSnap.Visible = true;
                if (ImgSnap.ImageUrl.ToString() != null && ImgSnap.ImageUrl.ToString() != "")
                {
                    ImgSnap.Visible = true;
                    ImgSnap.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                }
                txtSubject.Text=dt.Rows[0]["subject_assigned"].ToString();
                ddlDepartment.SelectedValue = dt.Rows[0]["Department_ID"].ToString();
            }

            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Teacher_id = Convert.ToInt32(row.Cells[0].Text);
            btnTeacher_Id.Value = row.Cells[0].Text;
            obj.delete_teacher(db);
            cleartext();
            bindteacher();
            binddepartment();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data have been deleted');", true);
        }

        public static byte[] ReadImageFile_Image(System.Web.UI.HtmlControls.HtmlInputFile fl_Image)
        {
            System.Web.UI.HtmlControls.HtmlInputFile img = (System.Web.UI.HtmlControls.HtmlInputFile)fl_Image;
            Byte[] imgByte = null;
            try
            {
                if (img.PostedFile != null)
                {
                    //To create a PostedFile
                    HttpPostedFile File = fl_Image.PostedFile;
                    //Create byte Array with file len
                    imgByte = new Byte[File.ContentLength];
                    //force the control to load data in array
                    File.InputStream.Read(imgByte, 0, File.ContentLength);
                }
                else
                {
                    HttpPostedFile File = fl_Image.PostedFile;
                    imgByte = new Byte[Convert.ToInt32(File.ContentLength)];
                    //imgByte = new Byte[File.ContentLength];
                    File.InputStream.Read(imgByte, 0, File.ContentLength);
                }
            }
            catch (Exception ex)
            {

            }

            return imgByte;
        }

        protected void lbtnViewStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewteacher.aspx");
        }

        protected void txtSearchTeacher_TextChanged(object sender, EventArgs e)
        {
            string connection = "data source=127.0.0.1; Initial catalog=modified; user=sa; password=015344;";

            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "select * from teacher where Teacher_Name LIKE '%" + txtSearchTeacher.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvSearchTeacher.DataSource = dt;
                    gvSearchTeacher.DataBind();
                    gvTeacher_User.Visible = false;
                    gvViewTeacher.Visible = false;
                    gvSearchTeacher.Visible = true;
                    con.Close();
                }
            }

            catch { }

            try
            {
                string query = "select * from teacher where barcode LIKE '%" + txtSearchTeacher.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvSearchTeacher.DataSource = dt;
                    gvSearchTeacher.DataBind();
                    gvTeacher_User.Visible = false;
                    gvViewTeacher.Visible = false;
                    gvSearchTeacher.Visible = true;
                    con.Close();
                }
            }

            catch { }
        }

        public void check_usertype()
        {
            db.Type = Session["User_Type"].ToString();
            if (db.Type == "user")
            {
                gvTeacher_User.Visible = true;
                gvViewTeacher.Visible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                gvViewTeacher.Visible = true;
                gvTeacher_User.Visible = false;
            }

        }

        protected void gvSearchTeacher_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSearchTeacher.PageIndex = e.NewPageIndex;
            bindteacher();
        }

        protected void gvTeacher_User_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTeacher_User.PageIndex = e.NewPageIndex;
            bindteacher();
        }

        protected void gvViewTeacher_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvViewTeacher.PageIndex = e.NewPageIndex;
            bindteacher();
        }

      
    }
}