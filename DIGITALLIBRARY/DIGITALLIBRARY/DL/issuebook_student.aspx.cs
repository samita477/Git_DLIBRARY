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
    public partial class issuebook_student : System.Web.UI.Page
    {
        DBcontainer db = new DBcontainer();
        issue_book_BLL obj = new issue_book_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindissuebook();
                getuser_type();
            }
        }

        public void bindissuebook()
        {
                string type = Session["_User_Type"].ToString();
                if (type == "student")
                {
                    db.Student_id = Convert.ToInt32(Session["SID"].ToString());
                    DataTable dt1 = obj.get_issuemaster_by_studentid(db);
                    if (dt1.Rows.Count > 0)
                    {
                        db.Im_ID = Convert.ToInt32(dt1.Rows[0]["IM_ID"].ToString());
                        DataTable dt2 = obj.get_issuedetailid(db);
                        //gvIssuedetails.DataSource = dt2;
                        //gvIssuedetails.DataBind();
                        if (dt2.Rows.Count > 0)
                        {
                            getdataforbind(dt2);
                        }
                        else
                        {
                            Response.Redirect("dashboard_student.aspx");
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Book Issued');", true);
                           
                        }

                    }

                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Book Issued');", true);
                        Response.Redirect("dashboard_student.aspx");
                    }
                }

                else
                {
                    db.Teacher_id = Convert.ToInt32(Session["TID"].ToString());
                    DataTable dt1 = obj.get_issuemaster_by_teacherid(db);
                    if (dt1.Rows.Count > 0)
                    {
                        db.Imt_id = Convert.ToInt32(dt1.Rows[0]["IMT_ID"].ToString());
                        DataTable dt2 = obj.get_issuedetailteacherid(db);
                        if (dt2.Rows.Count > 0)
                        {
                            GridView1.DataSource = dt2;
                            GridView1.DataBind();
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Book Issued');", true);
                            Response.Redirect("dashboard_student.aspx");
                        }
                        
                    }

                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Book Issued');", true);
                        Response.Redirect("dashboard_teacher.aspx");
                    }
                }
        }

        protected void gvIssuedetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void getdataforbind(DataTable dt)
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Id_ID");
            dt1.Columns.Add("Book_name");
            dt1.Columns.Add("Issue_date");
            dt1.Columns.Add("Return_date");
            dt1.Columns.Add("Penalty");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
                DateTime d1 = Convert.ToDateTime(dt.Rows[i]["return_date"].ToString());
                DateTime d2 = Convert.ToDateTime(System.DateTime.Now.ToString());
                double days = (Convert.ToDateTime(d2) - Convert.ToDateTime(d1)).TotalDays;
                double rate = 5.0;
                double penaltyvalue;
                if (days <= 0)
                {
                    penaltyvalue = 0;
                }
                else
                {
                    penaltyvalue = rate * days;
                }
                db.Id_ID = Convert.ToInt32(dt.Rows[i]["ID_ID"].ToString());
                db.Book_name = dt.Rows[i]["Book_Name"].ToString();
                db.Issue_date =Convert.ToDateTime( dt.Rows[i]["issue_date"].ToString());
                db.Return_date = Convert.ToDateTime(dt.Rows[i]["return_date"].ToString());
                dt1.Rows.Add(db.Id_ID,db.Book_name,db.Issue_date,db.Return_date,penaltyvalue);
                
            }
            gvIssuedetails.DataSource = dt1;
            gvIssuedetails.DataBind();

        }

        public void getuser_type()
        {
              string type = Session["_User_Type"].ToString();
              if (type == "student")
              {
                  gvIssuedetails.Visible = true;
                  GridView1.Visible = false;
              }
              else
              {
                  gvIssuedetails.Visible = false;
                  GridView1.Visible = true;
              }
        }
    }
}