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
using System.IO;


namespace DIGITALLIBRARY.DL
{
    public partial class subjectdetail_student : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        subject_BLL obj = new subject_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindsubject();
               //int id =Convert.ToInt32(Session["Subject_ID"].ToString());
               ddlSubject.SelectedValue = Session["Subject_ID"].ToString();
               save_project();

               
            }
        }
        public void bindsubject()
        {
            DataTable dt = obj.bindsubjectonly(db);
            ddlSubject.DataSource = dt;
            ddlSubject.DataValueField = "Subject_ID";
            ddlSubject.DataTextField = "Subject_Name";
            ddlSubject.DataBind();
            ddlSubject.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Subject_id = Convert.ToInt32(Session["Subject_ID"].ToString());
            DataTable dt1 = obj.get_fileuploaded(db);
            if (dt1.Rows.Count > 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("File");
                dt.Columns.Add("Size");
                dt.Columns.Add("Type");
                DataTable dt2 = obj.edit_subject(db);
                db.Subject_name = dt2.Rows[0]["Subject_Name"].ToString();
                string sub = get_datapath(db.Subject_name);
                string path = Server.MapPath("~/Data/" + sub + "/");

                foreach (string strfile in Directory.GetFiles(path))
                {
                    FileInfo fi = new FileInfo(strfile);
                    dt.Rows.Add(fi.Name, fi.Length.ToString(),
                        GetFileTypeByExtension(fi.Extension));
                }

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        
        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=127.0.0.1; Initial catalog=Library; user=sa; password=015344;");
            db.Subject_id = Convert.ToInt32(Session["Subject_ID"].ToString());
            DataTable d = obj.edit_subject(db);
            string folder = d.Rows[0]["Subject_Name"].ToString();
            string sub = get_datapath(folder);
            string path = Server.MapPath("~/Data/" + sub + "/");
            if (FileUpload1.HasFile)
            {
                string ext = Path.GetExtension(FileUpload1.FileName);
                if (ext == ".doc" || ext == ".pdf" || ext == ".docx")
                {
                    FileUpload1.SaveAs(path + FileUpload1.FileName);
                    db.Subject_id = Convert.ToInt32(ddlSubject.SelectedValue);
                    string name = get_tosavepath(folder, FileUpload1.FileName);
                    db.Book_image_url = name;
                    obj.save_subject_url(db);
                    lblmsg.Text = "your images have been uploaded";
                    lblmsg.ForeColor = System.Drawing.Color.Green;
                    //string name = "~/Data/"+ sub + "/" + FileUpload1.FileName;                   
                    //string ss = "insert into images(Image_URL,Subject_ID) values(" + name + "," + ddlSubject.SelectedValue + ")";
                    //SqlCommand cmd = new SqlCommand(ss, con);
                    //con.Open();
                    //cmd.ExecuteNonQuery();
                    //con.Close();
                }

                else
                {
                    lblmsg.Text = "you have to upload pdf file only";
                }

            }

            else
            {
                lblmsg.Text = "please select file:";

            }
            save_project();
        }

        public string get_datapath(string name)
        {
            switch (name)
            {
                case "Chemistry":
                    return "Chemistry";
                case "Programming in C":
                    return "C";
                case "Basic Electrical Engineering":
                    return "Basic Electrical";
                case "Object Oriented Programming in C++":
                    return "oopc";
                case "Physics":
                    return "Physics";
                case "Thermal Science":
                    return "Thermal";
                default:
                    return "";

                    
            }

        }

        public string get_tosavepath(string name, string file)
        {
            switch (name)
            {
                case "Chemistry":
                    return "~/Data/Chemistry/" + file;
                case "Programming in C":
                    return "~/Data/C/" + file;
                case "Basic Electrical Engineering":
                    return "~/Data/Basic Electrical/" + file;
                case "Object Oriented Programming in C++":
                    return "~/Data/oopc/" + file;
                case "Physics":
                    return "~/Data/Physics/" + file;
                case "Thermal Science":
                    return "~/Data/Thermal/" + file;
                default:
                    return "~/Data/" + file;
            }

        }

        private string GetFileTypeByExtension(string fileExtension)
        {
            switch (fileExtension.ToLower())
            {
                case ".docx":
                    return "Microsoft Word Document";
                case ".doc":
                    return "Microsoft Word Document";

                case ".pdf":
                    return "PDF";

                default:
                    return "Unknown";
            }
        }


        public void save_project()
        {
            db.Subject_id = Convert.ToInt32(Session["Subject_ID"].ToString());
            DataTable dt2 = obj.edit_subject(db);
            db.Subject_name = dt2.Rows[0]["Subject_Name"].ToString();
            string sub = get_datapath(db.Subject_name);
            string path = Server.MapPath("~/Data/" + sub + "/");
            if (FileUpload1.HasFile)
            {
                //string name = get_tosavepath(folder, FileUpload1.FileName);
                FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("File");
            dt.Columns.Add("Size");
            dt.Columns.Add("Type");
             foreach (string strfile in Directory.GetFiles(path))
            {
                FileInfo fi = new FileInfo(strfile);
                dt.Rows.Add(fi.Name, fi.Length.ToString(),
                    GetFileTypeByExtension(fi.Extension));
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }



        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Download")
            {
                Response.Clear();
                Response.ContentType = "application/octect-stream";
                Response.AppendHeader("content-disposition", "filename=" + e.CommandArgument);
                Response.TransmitFile(Server.MapPath("~/Data/") + e.CommandArgument);
                Response.End();
            }

        }
    }
}


       

