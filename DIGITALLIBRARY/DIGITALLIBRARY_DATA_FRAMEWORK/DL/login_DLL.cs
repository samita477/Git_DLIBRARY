using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class login_DLL
    {
        DBconnection dbcon = new DBconnection();
        DBcontainer db = new DBcontainer();
        public DataTable getuserid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "getuserid");
            //SqlCommand cmd = dbcon.GetProcedure(con, "get_user_byname");
            cmd.Parameters.AddWithValue("@Name", db.User_name);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

     

        public DataTable check_verified_user(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "check_verified_user");
            cmd.Parameters.AddWithValue("@User_ID", db.User_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_otheruser_byname(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_otheruser_byname");
            cmd.Parameters.AddWithValue("@_User_Name", db.User_name);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable getuser_withteachername(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "getuser_withteachername");
            cmd.Parameters.AddWithValue("@Teacher_Name", db.User_name);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable getuser_withstudentname(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "getuser_withstudentname");
            cmd.Parameters.AddWithValue("@Student_Name", db.User_name);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void update_userverified(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_userverified");
            cmd.Parameters.AddWithValue("@UV_ID", db.Verification_id);
            cmd.Parameters.AddWithValue("@verified", db.Authority);
            cmd.ExecuteNonQuery();
        }
    }
}