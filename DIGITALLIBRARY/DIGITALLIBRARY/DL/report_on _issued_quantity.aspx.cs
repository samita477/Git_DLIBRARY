using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

namespace DIGITALLIBRARY.DL
{
    public partial class report_on__issued_quantity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void ShowReport()
        {

            rptViewer.Reset();
            DataTable dt = getdata(txtBookName.Text);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptViewer.LocalReport.DataSources.Add(rds);
            rptViewer.LocalReport.ReportPath = "Issued_quantityReport.rdlc";
            ReportParameter[] rptParams = new ReportParameter[]{
                new ReportParameter("Book_Name",txtBookName.Text)
              
        };
            rptViewer.LocalReport.SetParameters(rptParams);
            rptViewer.LocalReport.Refresh();
        }

        private DataTable getdata(string Book_Name)
        {
            DataTable dt = new DataTable();
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["digital_libraryConnectionString"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("get_issuedquantity", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Book_Name", SqlDbType.Text).Value = Book_Name;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            return dt;
        }
    }
}