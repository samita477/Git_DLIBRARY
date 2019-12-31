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
    public partial class issue_book : System.Web.UI.Page
    {
        issue_book_BLL obj = new issue_book_BLL();
        DBcontainer db = new DBcontainer();
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                db.Return_date = Convert.ToDateTime(Session["Date_From"].ToString());
               
                FirstGridViewRow();
                bindstudent();
                bindbook();
                bindauthor();
                bindpublication();
                
            }
        }
        int count = 0;
        public void btnAdd_Click(object sender, EventArgs e)
        {
            count = gvIssueBook.Rows.Count;
         int limitedbook=getlimitedbookvalue();
         for (int i = 0; i < count; i++)
         {
             TextBox txtCode = (TextBox)gvIssueBook.Rows[i].Cells[1].FindControl("txtCode");
             if (txtCode.Text == "")
             {
                 return;
             }
             else
             {
                 if (count < limitedbook)
                 {
                     if(i==count-1)
                     AddNewRow();
                 }

                 else
                 {
                     ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Cannot Issue More Books');", true);
                 }
             }
         }
        
           
        }

        protected void gvIssueBook_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        public void bindstudent()
        {
            try
            {
                DataTable dt = obj.bindStudent(db);
                ddlStudent.DataSource = dt;
                ddlStudent.DataValueField = "Student_ID";
                ddlStudent.DataTextField = "Student_Name";
                ddlStudent.DataBind();
                ddlStudent.Items.Insert(0, new ListItem("--Select--", "-1"));

              }
            catch (Exception ex)
            {
            }
        }

       

        public void bindbook()
        {
            try
            {
                DataTable dt = new DataTable();
                DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[0].Cells[2].FindControl("ddlBook");
                //db.Student_id = Convert.ToInt32(Session["Student_ID"].ToString());
                dt = obj.bindBook(db);
                ddlBook.DataSource = dt;
                ddlBook.DataValueField = "Book_ID";
                ddlBook.DataTextField = "Book_Name";
                ddlBook.DataBind();
                ddlBook.Items.Insert(0, new ListItem("--Select--", "-1"));
            }
            catch (Exception e)
            {
            }
        }

        public void bindauthor()
        {
            //try
            //{
            DataTable dt = new DataTable();
            DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[0].Cells[2].FindControl("ddlAuthor");
            //db.Student_id = Convert.ToInt32(Session["Student_ID"].ToString());
             dt = obj.bindAuthor(db);
            ddlAuthor.DataSource = dt;
            ddlAuthor.DataValueField = "Author_ID";
            ddlAuthor.DataTextField = "Author_Name";
            ddlAuthor.DataBind();
            ddlAuthor.Items.Insert(0, new ListItem("--Select--", "-1"));

           
        }

        public void bindpublication()
        {
            try
            {
                DataTable dt = new DataTable();
                DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[0].Cells[3].FindControl("ddlPublication");
               // db.Student_id = Convert.ToInt32(Session["Student_ID"].ToString());
                dt = obj.bindPublication(db);
                ddlPublication.DataSource = dt;
                ddlPublication.DataValueField = "Publication_ID";
                ddlPublication.DataTextField = "Publication_Name";
                ddlPublication.DataBind();
                ddlPublication.Items.Insert(0, new ListItem("--Select--", "-1"));
            }

            catch (Exception e)
            {
            }
           
        }
        
       
        private void FirstGridViewRow()
        {
            try
            {
               
                DataTable dt = new DataTable();
                DataRow dr = null;
                dt.Columns.Add(new DataColumn("SN", typeof(string)));
                dt.Columns.Add(new DataColumn("Barcode", typeof(string)));
                dt.Columns.Add(new DataColumn("Book Name", typeof(string)));
                dt.Columns.Add(new DataColumn("Author", typeof(string)));
                dt.Columns.Add(new DataColumn("Publication", typeof(string)));
                dt.Columns.Add(new DataColumn("Edition", typeof(string)));
                dt.Columns.Add(new DataColumn("Issue Date", typeof(string)));
                dt.Columns.Add(new DataColumn("Return Date", typeof(string)));
                dr = dt.NewRow();
                dr["SN"] = 1;
                dr["Barcode"] = string.Empty;
                dr["Book Name"] = string.Empty;
                dr["Author"] = string.Empty;
                dr["Publication"] = string.Empty;
                dr["Edition"] = string.Empty;
                dr["Issue Date"] = string.Empty;
                dr["Return Date"] = string.Empty;
                dt.Rows.Add(dr);
                ViewState["CurrentTable"] = dt;
                gvIssueBook.DataSource = dt;
                gvIssueBook.DataBind();
            }
            catch (Exception ex)
            {
            }

            bindbook();
            bindauthor();
            bindpublication();
        }
        private void AddNewRow()
        {
            try
            {    int rowIndex = 0;
                if (ViewState["CurrentTable"] != null)
                {
                    DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                    DataRow drCurrentRow = null;
                   
                        if (dtCurrentTable.Rows.Count > 0)
                        {
                            for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                            {
                                TextBox txtCode = (TextBox)gvIssueBook.Rows[rowIndex].Cells[1].FindControl("txtCode");
                                DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[rowIndex].Cells[2].FindControl("ddlBook");
                                DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[rowIndex].Cells[3].FindControl("ddlAuthor");
                                DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[rowIndex].Cells[4].FindControl("ddlPublication");
                                TextBox txtEdition = (TextBox)gvIssueBook.Rows[rowIndex].Cells[5].FindControl("txtEdition");
                                TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[rowIndex].Cells[6].FindControl("txtIssuedate");
                                TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[rowIndex].Cells[7].FindControl("txtReturnDate");
                                drCurrentRow = dtCurrentTable.NewRow();
                                drCurrentRow["SN"] = i + 1;
                                dtCurrentTable.Rows[i - 1]["Barcode"] = txtCode.Text;
                                dtCurrentTable.Rows[i - 1]["Book Name"] = ddlBook.Text;
                                dtCurrentTable.Rows[i - 1]["Author"] = ddlAuthor.Text;
                                dtCurrentTable.Rows[i - 1]["Publication"] = ddlPublication.Text;
                                dtCurrentTable.Rows[i - 1]["Edition"] = txtEdition.Text;
                                dtCurrentTable.Rows[i - 1]["Issue Date"] = txtIssuedate.Text;
                                dtCurrentTable.Rows[i - 1]["Return Date"] = txtReturnDate.Text;
                                rowIndex++;
                            }
                            dtCurrentTable.Rows.Add(drCurrentRow);
                            ViewState["CurrentTable"] = dtCurrentTable;
                            gvIssueBook.DataSource = dtCurrentTable;
                            gvIssueBook.DataBind();

                        }
                    }
                   
                    SetPreviousData();
                }
            catch { }
        
        }
        
            void SetPreviousData()
                {
                    try
                    {
                        int rowIndex = 0;
                        if (ViewState["CurrentTable"] != null)
                        {
                            DataTable dt = (DataTable)ViewState["CurrentTable"];
                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    db.User_id = Convert.ToInt32(Session["User_ID"].ToString());
                                    TextBox txtCode = (TextBox)gvIssueBook.Rows[i].Cells[1].FindControl("txtCode");
                                    DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[i].Cells[2].FindControl("ddlBook");
                                    DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[i].Cells[3].FindControl("ddlAuthor");
                                    DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[i].Cells[4].FindControl("ddlPublication");
                                    TextBox txtEdition = (TextBox)gvIssueBook.Rows[i].Cells[5].FindControl("txtEdition");
                                    TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[i].Cells[6].FindControl("txtIssuedate");
                                    TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[i].Cells[7].FindControl("txtReturnDate");
                                    int xy = dt.Rows[i]["Book Name"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i]["Book Name"]);
                            if (xy != 0)
                            {
                                int type = dt.Rows[i]["Book Name"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i]["Book Name"].ToString());
                                db.User_id = Convert.ToInt32(Session["User_ID"].ToString());
                                db.Type = Convert.ToString(type);

                                DataTable dt1 = obj.bindBook(db);
                                ddlBook.DataSource = dt1;
                                ddlBook.DataValueField = "Book_ID";
                                ddlBook.DataTextField = "Book_Name";
                                ddlBook.DataBind();
                                ddlBook.Items.Insert(0, new ListItem("--Select--", "-1"));

                                DataTable dt2 = obj.bindAuthor(db);
                                ddlAuthor.DataSource = dt2;
                                ddlAuthor.DataValueField = "Author_ID";
                                ddlAuthor.DataTextField = "Author_Name";
                                ddlAuthor.DataBind();
                                ddlAuthor.Items.Insert(0, new ListItem("--Select--", "-1"));

                                DataTable dt3 = obj.bindPublication(db);
                                ddlPublication.DataSource = dt3;
                                ddlPublication.DataValueField = "Publication_ID";
                                ddlPublication.DataTextField = "Publication_Name";
                                ddlPublication.DataBind();
                                ddlPublication.Items.Insert(0, new ListItem("--Select--", "-1"));

                                txtCode.Text = dt.Rows[i]["Barcode"].ToString();
                                ddlBook.SelectedValue = dt.Rows[i]["Book Name"].ToString();
                                ddlAuthor.SelectedValue = dt.Rows[i]["Author"] == DBNull.Value ? "0" : dt.Rows[i]["Author"].ToString();
                                ddlPublication.SelectedValue = dt.Rows[i]["Publication"] == DBNull.Value ? "0" : dt.Rows[i]["Publication"].ToString();
                                txtEdition.Text = dt.Rows[i]["Edition"].ToString();
                                txtIssuedate.Text = dt.Rows[i]["Issue Date"].ToString();
                                txtReturnDate.Text = dt.Rows[i]["Return Date"].ToString();

                                rowIndex++;
                            }
                            else
                            {
                                DataTable dt1 = obj.bindBook(db);
                                ddlBook.DataSource = dt1;
                                ddlBook.DataValueField = "Book_ID";
                                ddlBook.DataTextField = "Book_Name";
                                ddlBook.DataBind();
                                ddlBook.Items.Insert(0, new ListItem("--Select--", "-1"));

                                DataTable dt2 = obj.bindAuthor(db);
                                ddlAuthor.DataSource = dt2;
                                ddlAuthor.DataValueField = "Author_ID";
                                ddlAuthor.DataTextField = "Author_Name";
                                ddlAuthor.DataBind();
                                ddlAuthor.Items.Insert(0, new ListItem("--Select--", "-1"));

                                DataTable dt3 = obj.bindPublication(db);
                                ddlPublication.DataSource = dt3;
                                ddlPublication.DataValueField = "Publication_ID";
                                ddlPublication.DataTextField = "Publication_Name";
                                ddlPublication.DataBind();
                                ddlPublication.Items.Insert(0, new ListItem("--Select--", "-1"));
                            }
                        }
                    }
                }
            }
            catch { }


        }
          
        private void SetRowData()
        {
            try
            {
                int rowIndex = 0;
                if (ViewState["CurrentTable"] != null)
                {
                    DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                    DataRow drCurrentRow = null;
                    if (dtCurrentTable.Rows.Count > 0)
                    {
                        for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                        {
                            TextBox txtCode = (TextBox)gvIssueBook.Rows[i].Cells[1].FindControl("txtCode");
                            DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[i].Cells[2].FindControl("ddlBook");
                            DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[i].Cells[3].FindControl("ddlAuthor");
                            DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[i].Cells[4].FindControl("ddlPublication");
                            TextBox txtEdition = (TextBox)gvIssueBook.Rows[i].Cells[5].FindControl("txtEdition");
                            TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[i].Cells[6].FindControl("txtIssuedate");
                            TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[i].Cells[7].FindControl("txtReturnDate");
                            drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["SN"] = i + 1;
                            dtCurrentTable.Rows[i - 1]["Barcode"] = txtCode.Text;
                            dtCurrentTable.Rows[i - 1]["Book Name"] = ddlBook.Text;
                            dtCurrentTable.Rows[i - 1]["Author"] = ddlAuthor.Text;
                            dtCurrentTable.Rows[i - 1]["Publication"] = ddlPublication.Text;
                            dtCurrentTable.Rows[i - 1]["Edition"] = txtEdition.Text;
                            dtCurrentTable.Rows[i - 1]["Issue Date"] = txtIssuedate.Text;
                            dtCurrentTable.Rows[i - 1]["Return Date"] = txtReturnDate.Text;
                            rowIndex++;


                        }
                        ViewState["CurrentTable"] = dtCurrentTable;
                    }
                }
                else
                {
                    Response.Write("ViewState is null");
                }
            }

            catch (Exception ex)
            { }
        }

        public void clear_all_data()
        {
            txtAddress.Text = "";
            txtCrn.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtPhone.Text = "";
            txtSCode.Text = "";
           
            for (int i = 0; i < gvIssueBook.Rows.Count; i++)
            {
              
                    TextBox txtCode = (TextBox)gvIssueBook.Rows[i].Cells[1].FindControl("txtCode");
                    DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[i].Cells[2].FindControl("ddlBook");
                    DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[i].Cells[3].FindControl("ddlAuthor");
                    DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[i].Cells[4].FindControl("ddlPublication");
                    TextBox txtEdition = (TextBox)gvIssueBook.Rows[i].Cells[5].FindControl("txtEdition");
                    TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[i].Cells[6].FindControl("txtIssuedate");
                    TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[i].Cells[7].FindControl("txtReturnDate");
                    txtEdition.Text = "";
                    txtIssuedate.Text = "";
                    txtReturnDate.Text = "";
                    txtCode.Text = "";
               
            }
            bindstudent();
            //bindteacher();
            bindauthor();
            bindbook();
            bindpublication();
            FirstGridViewRow();


        }

        protected void btnIssue_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            db.Return_date = Convert.ToDateTime(Session["date_From"].ToString());
            db.User_id = Convert.ToInt32(Session["User_Id"].ToString());
            db.Student_id = Convert.ToInt32(ddlStudent.SelectedValue);
            DataTable dt5 = obj.get_issuemaster_by_studentid(db);
            if (dt5.Rows.Count > 0)
            {
                db.Im_ID = Convert.ToInt32(dt5.Rows[0]["IM_ID"].ToString());
                dt = obj.get_issuemasterdetail(db);
                db.Imh_id = Convert.ToInt32(dt.Rows[0]["IMH_ID"].ToString());

            }

            else
            {

                obj.save_issuemaster(db);
                dt = obj.get_latestissuemasterid(db);
                db.Im_ID = Convert.ToInt32(dt.Rows[0]["IM_ID"].ToString());
                obj.save_issuemasterhistory(db);
                DataTable dt1 = obj.get_latestissuehistoryid(db);
                db.Imh_id = Convert.ToInt32(dt1.Rows[0]["IMH_ID"].ToString());
            }


            for (int i = 0; i < gvIssueBook.Rows.Count; i++)
            {
                TextBox txtCode = (TextBox)gvIssueBook.Rows[i].Cells[1].FindControl("txtCode");
                DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[i].Cells[2].FindControl("ddlBook");
                DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[i].Cells[3].FindControl("ddlAuthor");
                DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[i].Cells[4].FindControl("ddlPublication");
                TextBox txtEdition = (TextBox)gvIssueBook.Rows[i].Cells[5].FindControl("txtEdition");
                TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[i].Cells[6].FindControl("txtIssuedate");
                TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[i].Cells[7].FindControl("txtReturnDate");
                db.Barcode = txtCode.Text;
                db.Book_id = Convert.ToInt32(ddlBook.SelectedValue);
                db.Author_id = Convert.ToInt32(ddlAuthor.SelectedValue);
                db.Publication_id = Convert.ToInt32(ddlPublication.SelectedValue);
                db.Edition = txtEdition.Text;
                DataTable dt2 = obj.get_bookdetails(db);
                //db.Supplier_id = Convert.ToInt32(dt2.Rows[0]["Supplier_ID"].ToString());
                db.Issue_date = Convert.ToDateTime(txtIssuedate.Text);
                db.Return_date = Convert.ToDateTime(txtReturnDate.Text);
                obj.save_issuedetail(db);
                obj.save_issuedetailhistory(db);
                int Available_qty = Convert.ToInt32(dt2.Rows[0]["avl_quantity"].ToString());
                db.Available_qt = Available_qty - 1;
                if (db.Available_qt == 0)
                {
                    db.Book_status = "not available";
                    obj.update_bookstatus(db);
                }
                obj.update_bookquantity(db);
                DataTable dt6 = obj.get_bookedbook_bystudentid(db);
                if (dt6.Rows.Count > 0)
                {
                    int bookid = Convert.ToInt32(dt6.Rows[i]["Book_ID"].ToString());
                    db.Bb_id = Convert.ToInt32(dt6.Rows[i]["BB_ID"].ToString());
                    if (db.Book_id == bookid)
                    {
                        obj.delete_bookedbook(db);
                    }

                }
            }

                clear_all_data();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data is saved succesfully');", true);


           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear_all_data();

        }

        protected void ddlBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int s = ((GridViewRow)((DropDownList)sender).NamingContainer).RowIndex;
            TextBox txtCode = (TextBox)gvIssueBook.Rows[s].Cells[1].FindControl("txtCode");
            DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[s].Cells[2].FindControl("ddlBook");
            DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[s].Cells[3].FindControl("ddlAuthor");
            DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[s].Cells[4].FindControl("ddlPublication");
            TextBox txtEdition = (TextBox)gvIssueBook.Rows[s].Cells[5].FindControl("txtEdition");
            TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[s].Cells[6].FindControl("txtIssuedate");
            TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[s].Cells[7].FindControl("txtReturnDate");
            db.Book_id = Convert.ToInt32(ddlBook.SelectedValue);

            try
            {
                db.Student_id = Convert.ToInt32(ddlStudent.SelectedValue);
                DataTable dtt1 = obj.get_issuemaster_by_studentid(db);
                db.Im_ID = Convert.ToInt32(dtt1.Rows[0]["IM_ID"].ToString());
                DataTable dtt2 = obj.get_issuedetail_byimid(db);
                int code1 = db.Book_id;
                for (int i = 0; i < gvIssueBook.Rows.Count; i++)
                {

                    for (int j = 0; j < dtt2.Rows.Count; j++)
                    {
                        int code = Convert.ToInt32(dtt2.Rows[j]["Book_ID"].ToString());
                        if (code == code1)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have already issued this book');", true);
                            return;
                        }
                    }

                }
            }

            catch { }
            try
            {
               
                int code1 = db.Book_id;
                for (int i = 0; i < gvIssueBook.Rows.Count-1; i++)
                {
                      DropDownList ddlBook1 = (DropDownList)gvIssueBook.Rows[i].Cells[2].FindControl("ddlBook");
                   // if(gvIssueBook.Rows[i].Cells[2].ToString()!="")
                      int code =Convert.ToInt32( ddlBook1.SelectedValue);
                      if (code == code1)
                      {
                          ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('cannot issue same book twice');", true);
                          return;
                      }

                }
            }
            catch{}

                    dt = obj.get_bookdetails(db);
                    db.Author_id = Convert.ToInt32(dt.Rows[0]["Author_ID"].ToString());
                    db.Publication_id = Convert.ToInt32(dt.Rows[0]["Publication_ID"].ToString());
                    txtEdition.Text = dt.Rows[0]["Edition"].ToString();
                    string date = System.DateTime.Today.ToShortDateString();
                    txtIssuedate.Text = date;
                    int a = check_category(dt.Rows[0]["category"].ToString());
                    if (a == 0)
                    {
                        DateTime date2 = Convert.ToDateTime(Session["Date_From"].ToString());
                        txtReturnDate.Text = date2.ToShortDateString();
                    }
                    else
                    {
                        DateTime date2 = DateTime.Now.AddDays(7);
                        txtReturnDate.Text = date2.ToShortDateString();
                    }
          
                    //txtReturnDate.Text = Session["Date_From"].ToString();
                    ddlAuthor.SelectedValue = dt.Rows[0]["Author_ID"].ToString();
                    ddlPublication.SelectedValue = dt.Rows[0]["Publication_ID"].ToString();
                    txtCode.Text = dt.Rows[0]["bar_code"].ToString();
            //    }

            //    else
            //    {
            //        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('cannot issue same book twice');", true);

            //    }
            //}
            //catch { }
            
        }

        protected void lbtnIssueDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("issuebook_details.aspx");
        }



        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Student_id = Convert.ToInt32(ddlStudent.SelectedValue);
            DataTable dt = obj.get_studentdetails(db);
            txtCrn.Text = dt.Rows[0]["crn"].ToString();
            txtAddress.Text = dt.Rows[0]["_address"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtPhone.Text = dt.Rows[0]["ph_no"].ToString();
            txtGender.Text = dt.Rows[0]["gender"].ToString();
            txtSCode.Text = dt.Rows[0]["bar_code"].ToString();
            DataTable dt1 = obj.get_bookedbook_bystudentid(db);
            if (dt1.Rows.Count > 0)
            {

                if (dt1.Rows.Count > 1)
                {
                    for (int i = 1; i <= dt1.Rows.Count; i++)
                    {
                        int book_id = Convert.ToInt32(dt1.Rows[i - 1]["Book_ID"].ToString());
                        if (i == 1)
                            fillfirstrow(dt1, 0, book_id);

                        else
                            fillotherrow(dt1, i-1, book_id);
                    }
                }

                else
                {
                    int book_id = Convert.ToInt32(dt1.Rows[0]["Book_ID"].ToString());
                    fillfirstrow(dt1, 0, book_id);
                }
            }
        }

       

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            int s = ((GridViewRow)((TextBox)sender).NamingContainer).RowIndex;
            TextBox txtCode = (TextBox)gvIssueBook.Rows[s].Cells[1].FindControl("txtCode");
            DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[s].Cells[2].FindControl("ddlBook");
            DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[s].Cells[3].FindControl("ddlAuthor");
            DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[s].Cells[4].FindControl("ddlPublication");
            TextBox txtEdition = (TextBox)gvIssueBook.Rows[s].Cells[5].FindControl("txtEdition");
            TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[s].Cells[6].FindControl("txtIssuedate");
            TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[s].Cells[7].FindControl("txtReturnDate");
            db.Barcode = txtCode.Text;
            dt = obj.get_bookdetails_bybarcode(db);
            db.Book_id = Convert.ToInt32(dt.Rows[0]["Book_ID"].ToString());

            try
            {
                db.Student_id = Convert.ToInt32(ddlStudent.SelectedValue);
                DataTable dtt1 = obj.get_issuemaster_by_studentid(db);
                db.Im_ID = Convert.ToInt32(dtt1.Rows[0]["IM_ID"].ToString());
                DataTable dtt2 = obj.get_issuedetail_byimid(db);
                int code1 = db.Book_id;
                for (int i = 0; i < gvIssueBook.Rows.Count; i++)
                {

                    for (int j = 0; j < dtt2.Rows.Count; j++)
                    {
                        int code =Convert.ToInt32(dtt2.Rows[j]["Book_ID"].ToString());
                        if (code == code1)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have already issued this book');", true);
                            txtCode.Text = "";
                            return;
                        }
                    }

                }
            }
            catch { }
       
            try
            {

                string code1 = db.Barcode;
                for (int i = 0; i < gvIssueBook.Rows.Count - 1; i++)
                {
                    TextBox txtCode1 = (TextBox)gvIssueBook.Rows[s].Cells[1].FindControl("txtCode");
                    // if(gvIssueBook.Rows[i].Cells[2].ToString()!="")
                    string code = txtCode1.Text;
                    if (code == code1)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('cannot issue same book twice');", true);
                        return;
                    }

                }
            }
            catch { }

            
              
                //db.Book_id = Convert.ToInt32(ddlBook.SelectedValue);
                dt = obj.get_bookdetails_bybarcode(db);
                db.Book_id = Convert.ToInt32(dt.Rows[0]["Book_ID"].ToString());
                db.Author_id = Convert.ToInt32(dt.Rows[0]["Author_ID"].ToString());
                db.Publication_id = Convert.ToInt32(dt.Rows[0]["Publication_ID"].ToString());
                txtEdition.Text = dt.Rows[0]["Edition"].ToString();
                string date = System.DateTime.Today.ToShortDateString();
                ddlBook.SelectedValue = dt.Rows[0]["Book_ID"].ToString();
                txtIssuedate.Text = date;
                int a = check_category(dt.Rows[0]["category"].ToString());
                if (a == 0)
                {
                    DateTime date2 = Convert.ToDateTime(Session["Date_From"].ToString());
                    txtReturnDate.Text = date2.ToShortDateString();
                }
                else
                {
                    DateTime date2 = DateTime.Now.AddDays(7);
                    txtReturnDate.Text = date2.ToShortDateString();
                }
          
                //txtReturnDate.Text = Session["Date_From"].ToString();
                ddlAuthor.SelectedValue = dt.Rows[0]["Author_ID"].ToString();
                ddlPublication.SelectedValue = dt.Rows[0]["Publication_ID"].ToString();
            //    txtCode.Text = dt.Rows[0]["bar_code"].ToString();
            //}

            //else
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('cannot issue same book twice');", true);

            //}
        }

        protected void txtSCode_TextChanged(object sender, EventArgs e)
        {
            db.Sbarcode = txtSCode.Text;
            DataTable dt = obj.get_studentdetails_bybarcode(db);
            if (dt.Rows.Count > 0)
            {
                db.Student_id = Convert.ToInt32(dt.Rows[0]["Student_ID"].ToString());
                ddlStudent.SelectedValue = dt.Rows[0]["Student_ID"].ToString();
                txtAddress.Text = dt.Rows[0]["_address"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtPhone.Text = dt.Rows[0]["ph_no"].ToString();
                txtGender.Text = dt.Rows[0]["gender"].ToString();
                txtCrn.Text = dt.Rows[0]["crn"].ToString();
                DataTable dt1 = obj.get_bookedbook_bystudentid(db);
                if (dt1.Rows.Count > 0)
                {

                    if (dt1.Rows.Count > 1)
                    {
                        for (int i = 1; i <= dt1.Rows.Count; i++)
                        {
                            int book_id = Convert.ToInt32(dt1.Rows[i - 1]["Book_ID"].ToString());
                            if (i == 1)
                                fillfirstrow(dt1, 0, book_id);

                            else
                                fillotherrow(dt1, i-1, book_id);
                        }
                    }

                    else
                    {
                        int book_id = Convert.ToInt32(dt1.Rows[0]["Book_ID"].ToString());
                        fillfirstrow(dt1, 0, book_id);
                    }
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No Data');", true);
            }


        }

        public void fillfirstrow(DataTable dt1, int i, int book_id)
        {
            DataTable dt2 = new DataTable();
            TextBox txtCode = (TextBox)gvIssueBook.Rows[i].Cells[1].FindControl("txtCode");
            DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[i].Cells[2].FindControl("ddlBook");
            DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[i].Cells[3].FindControl("ddlAuthor");
            DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[i].Cells[4].FindControl("ddlPublication");
            TextBox txtEdition = (TextBox)gvIssueBook.Rows[i].Cells[5].FindControl("txtEdition");
            TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[i].Cells[6].FindControl("txtIssuedate");
            TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[i].Cells[7].FindControl("txtReturnDate");
            db.Book_id = book_id;
            dt2 = obj.get_bookdetails(db);
            txtCode.Text = dt2.Rows[0]["bar_code"].ToString();
            db.Author_id = Convert.ToInt32(dt2.Rows[0]["Author_ID"].ToString());
            db.Publication_id = Convert.ToInt32(dt2.Rows[0]["Publication_ID"].ToString());
            //txtCode.Text = db.Barcode;
            txtEdition.Text = dt2.Rows[0]["Edition"].ToString();
            string date = System.DateTime.Today.ToShortDateString();
            txtIssuedate.Text = date;
            int a = check_category(dt2.Rows[0]["category"].ToString());
            if (a == 0)
            {
                DateTime date2 = Convert.ToDateTime(Session["Date_From"].ToString());
                txtReturnDate.Text = date2.ToShortDateString();
            }
            else
            {
                DateTime date2 = DateTime.Now.AddDays(7);
                txtReturnDate.Text = date2.ToShortDateString();
            }
          
            //txtReturnDate.Text = Session["Date_From"].ToString();
            ddlAuthor.SelectedValue = dt2.Rows[0]["Author_ID"].ToString();
            ddlPublication.SelectedValue = dt2.Rows[0]["Publication_ID"].ToString();
            
            ddlBook.SelectedValue = dt2.Rows[0]["Book_ID"].ToString();

        }

        public void fillotherrow(DataTable dt1, int i, int book_id)
        {
            AddNewRow();
            DataTable dt2 = new DataTable();
            TextBox txtCode = (TextBox)gvIssueBook.Rows[i].Cells[1].FindControl("txtCode");
            DropDownList ddlBook = (DropDownList)gvIssueBook.Rows[i].Cells[2].FindControl("ddlBook");
            DropDownList ddlAuthor = (DropDownList)gvIssueBook.Rows[i].Cells[3].FindControl("ddlAuthor");
            DropDownList ddlPublication = (DropDownList)gvIssueBook.Rows[i].Cells[4].FindControl("ddlPublication");
            TextBox txtEdition = (TextBox)gvIssueBook.Rows[i].Cells[5].FindControl("txtEdition");
            TextBox txtIssuedate = (TextBox)gvIssueBook.Rows[i].Cells[6].FindControl("txtIssuedate");
            TextBox txtReturnDate = (TextBox)gvIssueBook.Rows[i].Cells[7].FindControl("txtReturnDate");
            db.Book_id = book_id;
            dt2 = obj.get_bookdetails(db);
            db.Barcode = dt2.Rows[0]["bar_code"].ToString();
            db.Author_id = Convert.ToInt32(dt2.Rows[0]["Author_ID"].ToString());
            db.Publication_id = Convert.ToInt32(dt2.Rows[0]["Publication_ID"].ToString());
            txtEdition.Text = dt2.Rows[0]["Edition"].ToString();
            string date = System.DateTime.Today.ToShortDateString();
            txtIssuedate.Text = date;
            int a = check_category(dt2.Rows[0]["category"].ToString());
            if (a == 0)
            {
                DateTime date2=Convert.ToDateTime( Session["Date_From"].ToString());
                txtReturnDate.Text = date2.ToShortDateString();
            }
            else
            {
                DateTime date2 = DateTime.Now.AddDays(7);
                txtReturnDate.Text = date2.ToShortDateString();
            }
          
            ddlAuthor.SelectedValue = dt2.Rows[0]["Author_ID"].ToString();
            ddlPublication.SelectedValue = dt2.Rows[0]["Publication_ID"].ToString();
            txtCode.Text = db.Barcode;
            ddlBook.SelectedValue = dt2.Rows[0]["Book_ID"].ToString();

        }


      public int getlimitedbookvalue()
      {
              int limitedbook=Convert.ToInt32(Session["book_student"].ToString());
              return limitedbook;

      }

      public int check_category(string category)
      {
           if (category == "General Book")
          {
              return 0;
          }

          else
          {
              return 1;
          }
      }

   }
}