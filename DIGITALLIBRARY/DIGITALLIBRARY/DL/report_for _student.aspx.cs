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
    public partial class report_for__student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                Calendar2.Visible = false;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void ShowReport()
        {

            rptViewer.Reset();
            DataTable dt = getdata(DateTime.Parse(txtFrom.Text), DateTime.Parse(txtTo.Text));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptViewer.LocalReport.DataSources.Add(rds);
            rptViewer.LocalReport.ReportPath = "StudentReport.rdlc";
            ReportParameter[] rptParams = new ReportParameter[]{
                new ReportParameter("FromDate",txtFrom.Text),
                  new ReportParameter("ToDate",txtTo.Text)
        };
            rptViewer.LocalReport.SetParameters(rptParams);
            rptViewer.LocalReport.Refresh();
        }

        private DataTable getdata(DateTime FromDate, DateTime ToDate)
        {
            DataTable dt = new DataTable();
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["digital_libraryConnectionString"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("getreport_issue_student", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@From", SqlDbType.DateTime).Value = FromDate;
                cmd.Parameters.Add("@To", SqlDbType.DateTime).Value = ToDate;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            return dt;
        }

        protected void imgFrom_Click(object sender, ImageClickEventArgs e)
        {

            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }

        protected void imgTo_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar2.Visible)
            {
                Calendar2.Visible = false;
            }
            else
            {
                Calendar2.Visible = true;
            }
        }

        protected void txtTo_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate.ToShortDateString() != "")
            {
                txtFrom.Text = Calendar1.SelectedDate.ToShortDateString();
                Calendar1.Visible = false;
            }
        }

      

        protected void Calendar1_DayRender1(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.LightGray;
                e.Cell.ToolTip = "Booked";
            }
            else
                e.Cell.ToolTip = "Available";
        }

      

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.LightGray;
                e.Cell.ToolTip = "Booked";
            }
            else
                e.Cell.ToolTip = "Available";
            //if (txtFrom.Text != "")
            //{
             DateTime curr = Convert.ToDateTime(txtFrom.Text.ToString());

                if (e.Day.Date <= curr)
                {
                    e.Day.IsSelectable = false;

                
            }
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            if (Calendar2.SelectedDate.ToShortDateString() != "")
            {
                txtTo.Text = Calendar2.SelectedDate.ToShortDateString();
                Calendar2.Visible = false;
            }
        }

   
    }
}
