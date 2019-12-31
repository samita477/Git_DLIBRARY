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
    public partial class add_student : System.Web.UI.Page
    {
        add_student_BLL obj = new add_student_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {

        
            if (!IsPostBack)
            {
                btnUpdate.Visible = false;
                bindstudent();
                check_usertype();   
                

            }

        }
        public void bindstudent()
        {
            DataTable dt = new DataTable();
            dt = obj.bindstudent(db);
            gvViewStudent.DataSource = dt;
            gvViewStudent.DataBind();
            gvViewStudent_User.DataSource = dt;
            gvViewStudent_User.DataBind(); 
        }

        protected void lbtnViewStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewstudent.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            db.Barcode = txtboxCode.Text;
            db.Student_name = txtboxName.Text;
            db.Student_address = txtboxAddress.Text;
            db.Student_phnno = txtboxPhn.Text;
            db.Student_gender = ddlGender.SelectedValue;
            db.Student_email = txtEmail.Text;
            if (!string.IsNullOrEmpty(FuSnap.Value))
                db.Citizenship = ReadImageFile_Image(FuSnap);

            string code = txtboxCode.Text;
            int len = code.Length;
            db.Batch = code.Substring(0, 3);
            db.Department_id = Convert.ToInt32(code.Substring(3, 1));
            db.Crn= code.Substring(4, 2);
            db.Student_semester = Convert.ToInt32(txtBoxSem.Text);
            db.Active = true;
            obj.save_student(db);
            bindstudent();
            check_usertype();
            cleartext();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);
        }

        public void cleartext()
        {
            txtboxName.Text = "";
            txtboxAddress.Text = "";
            ImgSnap.ImageUrl = "";
            txtboxPhn.Text = "";
            txtEmail.Text = "";
            txtboxCode.Text = "";
            txtSearchAddStudent.Text = "";
            txtBoxSem.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            cleartext();
            if (gvSearchStudent.Visible == true)
            {
                gvSearchStudent.Visible = false;
                gvViewStudent.Visible = true;
                gvViewStudent_User.Visible = true;
            }
            check_usertype();
        }

        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Student_id = Convert.ToInt32(row.Cells[0].Text);
            btnStudent_Id.Value = row.Cells[0].Text;

            obj.delete_student(db);
         
            bindstudent();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data have been deleted');", true);

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            db.Barcode = txtboxCode.Text;
            db.Student_id = Convert.ToInt32(btnStudent_Id.Value);
            db.Student_name = txtboxName.Text;
            db.Student_address = txtboxAddress.Text;
            db.Student_email = txtEmail.Text;
            db.Student_gender = ddlGender.SelectedValue;
            db.Student_phnno = txtboxPhn.Text;
            string code = txtboxCode.Text;
            int len = code.Length;
            db.Batch = code.Substring(0, 3);
            db.Department_id = Convert.ToInt32(code.Substring(3, 1));
            db.Crn = code.Substring(4, 2);
            db.Student_semester = Convert.ToInt32(txtBoxSem.Text);
            if (!string.IsNullOrEmpty(FuSnap.Value))
                db.Citizenship = ReadImageFile_Image(FuSnap);
            obj.update_student(db);
                
            bindstudent();
            btnSave.Visible = true;
            cleartext();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is updated succesfully');", true);
        }

        protected void gvViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Student_id = Convert.ToInt32(row.Cells[0].Text);
            btnStudent_Id.Value = row.Cells[0].Text;
            db.Student_name = row.Cells[1].Text;
            db.Student_address = row.Cells[2].Text;
            db.Student_email = row.Cells[3].Text;
            db.Student_phnno = row.Cells[4].Text;
            db.Student_gender = row.Cells[5].Text;
            db.Crn = row.Cells[7].Text;
            db.Citizenship = ReadImageFile_Image(FuSnap);
            //db.Sbarcode = row.Cells[].Text;
            db.Batch = row.Cells[6].Text;
            //db.Department_id = Convert.ToInt32(row.Cells[10].Text);
            db.Student_semester=Convert.ToInt32(row.Cells[8].Text);
            dt = obj.edit_student(db);
            if (dt.Rows.Count > 0)
            {

                txtboxCode.Text = dt.Rows[0]["bar_code"].ToString();
                txtboxName.Text = dt.Rows[0]["Student_Name"].ToString();
                txtboxAddress.Text = dt.Rows[0]["_address"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtboxPhn.Text = dt.Rows[0]["ph_no"].ToString();
                ddlGender.SelectedValue = dt.Rows[0]["gender"].ToString();

                txtBoxSem.Text = dt.Rows[0]["semster"].ToString();
                try
                {
                    ImgSnap.ImageUrl = String.Format("../Handler/StudentImage.ashx?Student_ID={0}", db.Student_id);
                    ImgSnap.Visible = true;
                    if (ImgSnap.ImageUrl.ToString() != null && ImgSnap.ImageUrl.ToString() != "")
                    {
                        ImgSnap.Visible = true;
                        ImgSnap.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                        // ImgSnap.ImageUrl = "";
                    }
                    else
                    {
                        ImgSnap.ImageUrl = "";
                    }
                }
                catch { }
            }
           
            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Student_id = Convert.ToInt32(row.Cells[0].Text);
            btnStudent_Id.Value = row.Cells[0].Text;
            obj.delete_student(db);
            bindstudent();
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

        public void check_usertype()
        {
            db.Type = Session["User_Type"].ToString();
            if (db.Type == "user")
            {
                gvViewStudent_User.Visible = true;
                gvViewStudent.Visible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                gvViewStudent.Visible = true;
                gvViewStudent_User.Visible = false;
            }

        }

        protected void txtSearchAddStudent_TextChanged(object sender, EventArgs e)
        {
            string connection = "data source=127.0.0.1; Initial catalog=modified; user=sa; password=015344;";

            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "select * from student where Student_Name LIKE '%" + txtSearchAddStudent.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvSearchStudent.DataSource = dt;
                    gvSearchStudent.DataBind();
                    gvViewStudent_User.Visible = false;
                    gvViewStudent.Visible = false;
                    gvSearchStudent.Visible = true;
                    con.Close();
                }
            }
            catch { }

            try
            {
                string query = "select * from student where Barcode LIKE '%" + txtSearchAddStudent.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvSearchStudent.DataSource = dt;
                    gvSearchStudent.DataBind();
                    gvViewStudent_User.Visible = false;
                    gvViewStudent.Visible = false;
                    gvSearchStudent.Visible = true;
                    con.Close();
                }
            }
            catch { }
        }

        protected void gvSearchStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSearchStudent.PageIndex = e.NewPageIndex;
            bindstudent();
        }

        protected void gvViewStudent_User_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvViewStudent_User.PageIndex = e.NewPageIndex;
            bindstudent();
        }

        protected void gvViewStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvViewStudent.PageIndex = e.NewPageIndex;
            bindstudent();
        }
    }
}