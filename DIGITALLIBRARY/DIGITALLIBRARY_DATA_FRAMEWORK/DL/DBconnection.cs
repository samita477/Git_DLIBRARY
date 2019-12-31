using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class DBconnection
    {

        string connection = "data source=127.0.0.1; Initial catalog=modified; user=sa; password=015344;";
        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connection);
            return con;
        }

        public SqlCommand GetQueryString(SqlConnection con, string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            return cmd;

        }

        public SqlCommand GetProcedure(SqlConnection con, string procedure)
        {
            SqlCommand cmd = new SqlCommand(procedure, con);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public DataTable GetDataTable(SqlCommand cmd)
        {
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public DataSet GetDataSet(SqlCommand cmd)
        {
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

      
    }
}