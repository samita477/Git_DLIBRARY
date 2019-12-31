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
    public partial class bookdetail_student : System.Web.UI.Page
    {
        add_book_BLL obj = new add_book_BLL();
        DBcontainer db = new DBcontainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            bindbookdetails();
            if (!IsPostBack)
            {
            }
        }

        public void bindbookdetails()
        {
            db.Book_id = Convert.ToInt32(Session["Book_ID"].ToString());
            DataTable dt = obj.edit_book(db);           
            txtboxName.Text = dt.Rows[0]["Book_Name"].ToString();
            txtPageNo.Text = dt.Rows[0]["Page"].ToString();
            txtPrice.Text = dt.Rows[0]["price"].ToString();
            txtEdition.Text = dt.Rows[0]["edition"].ToString();
            txtQuantity.Text = dt.Rows[0]["quantity"].ToString();
            txtAvlQty.Text = dt.Rows[0]["avl_quantity"].ToString();
            DateTime d = Convert.ToDateTime(dt.Rows[0]["date_of_entry"].ToString());
            txtDate.Text = d.ToShortDateString();
            try
            {
                ImgSnap.ImageUrl = String.Format("../Handler/ShowNepaliCitizen.ashx?Book_id={0}", db.Book_id);
                ImgSnap.Visible = true;
                if (ImgSnap.ImageUrl.ToString() != null && ImgSnap.ImageUrl.ToString() != "")
                {
                    ImgSnap.Visible = true;
                    ImgSnap.Attributes.CssStyle[HtmlTextWriterStyle.Visibility] = "visible";
                }
            }
            catch { }
            ddbtnAuthor.SelectedIndex =Convert.ToInt32( dt.Rows[0]["Author_ID"].ToString());
            ddbtnSubject.Text = dt.Rows[0]["Subject_ID"].ToString(); ;
            ddbtnPublication.Text = dt.Rows[0]["Publication_ID"].ToString();
            ddbtnSupplier.Text = dt.Rows[0]["Supplier_ID"].ToString();
        }

        protected void imgBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("book_student.aspx");
        }
    }
}