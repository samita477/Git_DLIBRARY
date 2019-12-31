using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;
using DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL;
using System.Data;
using System.Data.SqlClient;

namespace DIGITALLIBRARY.DL
{
    public partial class add_book : System.Web.UI.Page
    {
        add_book_BLL obj = new add_book_BLL();
        DBcontainer db = new DBcontainer();

        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            txtDate.Text = d.ToShortDateString();
            if (!IsPostBack)
            {
                bindbook();
                bindauthor();
                bindpublication();
                bindsubject();
                bindsemester();
                check_usertype();               
                txtDate.Text = d.ToShortDateString();
                btnUpdate.Visible = false;
                if (btnSave.Enabled == false)
                {
                    btnUpdate.Visible = true;
                }
                else
                {
                    btnUpdate.Visible = false;
                }
            }

            

        }

        public void bindbook()
        {
            DataTable dt = new DataTable();
            dt = obj.bindbook(db);
            gvBook.DataSource = dt;
            gvBook.DataBind();
            gvBookUser.DataSource = dt;
            gvBookUser.DataBind();

        }
        public void cleartext()
        {
            txtCode.Text = "";
            txtSearchBook.Text = "";
            txtboxName.Text = "";
            txtDate.Text = "";
            txtEdition.Text = "";
            txtQuantity.Text = "";
            txtPageNo.Text = "";
            txtPrice.Text = "";
            ImgSnap.ImageUrl = "";
            bindauthor();
            bindbook();
            bindpublication();
            bindsubject();
         }

        protected void bindauthor()
        {
            DataTable dt = obj.bindauthor(db);
            ddbtnAuthor.DataSource = dt;
            ddbtnAuthor.DataValueField = "Author_ID";
            ddbtnAuthor.DataTextField = "Author_Name";
            ddbtnAuthor.DataBind();
            ddbtnAuthor.Items.Insert(0, new ListItem("--Select--", "-1"));
        }
        protected void bindpublication()
        {
            DataTable dt = obj.bindpublication(db);
            ddbtnPublication.DataSource = dt;
            ddbtnPublication.DataValueField = "Publication_ID";
            ddbtnPublication.DataTextField = "Publication_Name";
            ddbtnPublication.DataBind();
            ddbtnPublication.Items.Insert(0, new ListItem("--Select--", "-1"));
        }

        protected void bindsubject()
        {
            DataTable dt = obj.bindsubject(db);
            ddbtnSubject.DataSource = dt;
            ddbtnSubject.DataValueField = "Subject_ID";
            ddbtnSubject.DataTextField = "Subject_Name";
            ddbtnSubject.DataBind();
            ddbtnSubject.Items.Insert(0, new ListItem("--Select--", "-1"));
        }


        protected void bindsemester()
        {
            DataTable dt = obj.bindsemester(db);
            ddlSemester.DataSource = dt;
            ddlSemester.DataValueField = "SM_ID";
            ddlSemester.DataTextField = "Semester_Name";
            ddlSemester.DataBind();
            ddlSemester.Items.Insert(0, new ListItem("--Select--", "-1"));
        }

        protected void lbtnViewBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbook.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            db.Barcode =txtCode.Text;
            db.Book_name = txtboxName.Text;
            db.Quantity = Convert.ToInt16(txtQuantity.Text);
            db.Edition = txtEdition.Text;
            db.Available_qt = db.Quantity;
            db.Page_no = Convert.ToInt32(txtPageNo.Text);
            db.Price = Convert.ToDouble(txtPrice.Text);
            db.Entry_date = Convert.ToDateTime(txtDate.Text);
            db.Book_status = "available";
             if (!string.IsNullOrEmpty(FuSnap.Value))
                db.Citizenship = ReadImageFile_Image(FuSnap);

            db.Category = ddlCategory.SelectedItem.ToString();
            db.Author_id = Convert.ToInt32(ddbtnAuthor.SelectedValue);
            db.Subject_id = Convert.ToInt32(ddbtnSubject.SelectedValue);
            db.Publication_id = Convert.ToInt32(ddbtnPublication.SelectedValue);
            db.SM_ID1= Convert.ToInt32(ddlSemester.SelectedValue);
            obj.save_book(db);       
            check_usertype();
            bindbook();
            bindsemester();
            cleartext();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);
            DateTime d = DateTime.Now;
            txtDate.Text = d.ToShortDateString();

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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            cleartext();
            if (gvSearchBook.Visible == true)
            {
                gvSearchBook.Visible = false;
                gvBook.Visible = true;
                gvBookUser.Visible = true;
            }
            check_usertype();
            bindauthor();
            bindpublication();
            //bindsupplier();
            bindsubject();
            bindsemester();
            DateTime d = DateTime.Now;
            txtDate.Text = d.ToShortDateString();

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Book_id = Convert.ToInt32(row.Cells[0].Text);
            btnBook_Id.Value = row.Cells[0].Text;
            db.Book_name = row.Cells[1].Text;
            db.Page_no = Convert.ToInt32(row.Cells[2].Text);
            db.Price = Convert.ToDouble(row.Cells[3].Text);
            db.Edition = row.Cells[4].Text;
            db.Quantity = Convert.ToInt32(row.Cells[5].Text);
            db.Available_qt = Convert.ToInt32(row.Cells[6].Text);
            db.Entry_date = Convert.ToDateTime(row.Cells[7].Text);
            db.Citizenship = ReadImageFile_Image(FuSnap);
            db.Category = row.Cells[11].Text;
            dt = obj.edit_book(db);
            if (dt.Rows.Count > 0)
            {
                txtCode.Text = dt.Rows[0]["bar_code"].ToString();
                txtboxName.Text = dt.Rows[0]["Book_Name"].ToString();
                txtPageNo.Text = dt.Rows[0]["Page"].ToString();
                txtPrice.Text = dt.Rows[0]["price"].ToString();
                txtEdition.Text = dt.Rows[0]["edition"].ToString();
                txtQuantity.Text = dt.Rows[0]["quantity"].ToString();
                ddlCategory.Text = dt.Rows[0]["category"].ToString();
                DateTime d = Convert.ToDateTime(dt.Rows[0]["date_of_entry"].ToString());
                txtDate.Text = d.ToShortDateString();
                 ddbtnSubject.Text =dt.Rows[0]["Subject_ID"].ToString();
                ddbtnAuthor.Text = dt.Rows[0]["Author_ID"].ToString();
                ddbtnPublication.Text = dt.Rows[0]["Publication_ID"].ToString();
                ddlSemester.Text = dt.Rows[0]["SM_ID"].ToString();
                try{
                 ImgSnap.ImageUrl = String.Format("../Handler/ShowNepaliCitizen.ashx?Book_id={0}", db.Book_id);
                    ImgSnap.Visible = true;
                    if (ImgSnap.ImageUrl.ToString() != null && ImgSnap.ImageUrl.ToString() != "")
                    {
                        ImgSnap.Visible = true;
                        ImgSnap.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                    }

                    else
                    {
                        ImgSnap.ImageUrl = "";
                    }
                }
                catch{}
            }
          
            btnSave.Visible = false;
            btnUpdate.Visible = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            db.Book_id = Convert.ToInt32(row.Cells[0].Text);
            btnBook_Id.Value = row.Cells[0].Text;
            obj.delete_book(db);
            bindbook();
            bindauthor();
            bindpublication();
            bindsubject();
            bindsemester();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data have been deleted');", true);
            DateTime d = DateTime.Now;
            txtDate.Text = d.ToShortDateString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //DataTable dt = obj.edit_book(db);
            //int qty =Convert.ToInt32(dt.Rows[0]["avl_"].ToString());
            db.Barcode = txtCode.Text;
            db.Book_id = Convert.ToInt32(btnBook_Id.Value);
            db.Book_name = txtboxName.Text;
            db.Page_no = Convert.ToInt32(txtPageNo.Text);
            db.Price = Convert.ToDouble(txtPrice.Text);
            db.Edition = txtEdition.Text;
            db.Quantity = Convert.ToInt32(txtQuantity.Text);
            db.Available_qt = Convert.ToInt32(txtQuantity.Text);
            db.Entry_date = Convert.ToDateTime(txtDate.Text);
            db.Book_status = "available";
            try
            {
                if (!string.IsNullOrEmpty(FuSnap.Value))
                    db.Citizenship = ReadImageFile_Image(FuSnap);
             
            }
            catch { }
            //int id = Convert.ToInt32(ddbtnSubject.SelectedValue);
            db.Category = ddlCategory.SelectedValue;
            db.Subject_id = Convert.ToInt32(ddbtnSubject.SelectedValue);
             db.Author_id = Convert.ToInt32(ddbtnAuthor.SelectedValue);
            db.Publication_id = Convert.ToInt32(ddbtnPublication.SelectedValue);
            db.SM_ID1 = Convert.ToInt32(ddlSemester.SelectedValue);
            obj.update_book(db);
            bindbook();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            bindsemester();
            cleartext();
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is updated succesfully');", true);
            DateTime d = DateTime.Now;
            txtDate.Text = d.ToShortDateString();
        }

        protected void gvBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

           

        public void check_usertype()
        {
            db.Type = Session["User_Type"].ToString();
            if (db.Type == "user")
            {
                gvBookUser.Visible = true;
                gvBook.Visible = false;

                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                gvBook.Visible = true;
                gvBookUser.Visible = false;

            }
        }

        protected void txtSearchBook_TextChanged(object sender, EventArgs e)
        {

            string connection = "data source=127.0.0.1; Initial catalog=modified; user=sa; password=015344;";

            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "select * from book where Book_Name LIKE '%" + txtSearchBook.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvSearchBook.DataSource = dt;
                    gvSearchBook.DataBind();
                    gvBookUser.Visible = false;
                    gvBook.Visible = false;
                    gvSearchBook.Visible = true;
                    con.Close();
                }
            }
            catch { }

            try
            {
                string query = "select * from book where barcode LIKE '%" + txtSearchBook.Text + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    gvSearchBook.DataSource = dt;
                    gvSearchBook.DataBind();
                    gvBookUser.Visible = false;
                    gvBook.Visible = false;
                    gvSearchBook.Visible = true;
                    con.Close();
                }
            }
            catch { }
        
        }

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void gvBook_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
            gvBook.PageIndex = e.NewPageIndex;
            bindbook();
        }

        protected void gvBook_PageIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void gvBookUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBookUser.PageIndex = e.NewPageIndex;
            bindbook();
        }

        protected void gvSearchBook_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}
