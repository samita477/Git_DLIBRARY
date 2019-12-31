using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization.Charting;

namespace DIGITALLIBRARY.DL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(@"data source=127.0.0.1; Initial catalog=digital library; user=sa; password=015344;"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Name,sum(quantity) as TotalQuantity from sample group by Name", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }

            string[] x= new string[dt.Rows.Count];
            int[] y= new int[dt.Rows.Count];


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(dt.Rows[i][1].ToString());

            }
            Chart1.Series[0].Points.DataBindXY(x,y);
            Chart1.Series[0].ChartType=SeriesChartType.Bar;
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D=true;
            //Chart1.Legends[0].Enabled=true;
        }
    }
}