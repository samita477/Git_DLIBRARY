using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class user_DLL
    {
        DBconnection dbcon = new DBconnection();
        DBcontainer db = new DBcontainer();

        public void save_user(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_user");
            cmd.Parameters.AddWithValue("@Name", db.User_name);
            cmd.Parameters.AddWithValue("@_address", db.User_address);
            cmd.Parameters.AddWithValue("@ph_no", db.User_phno);
            cmd.Parameters.AddWithValue("@email", db.User_email);
            cmd.Parameters.AddWithValue("@gender", db.User_gender);
            cmd.Parameters.AddWithValue("@_password", db.Password);
            cmd.Parameters.AddWithValue("@_type", db.Type);
            cmd.Parameters.AddWithValue("@authority", db.Authority);
            cmd.ExecuteNonQuery();    
        }

        public void delete_user(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_user");
            cmd.Parameters.AddWithValue("@user_id", db.User_id);
            cmd.ExecuteNonQuery();
        }

        public DataTable edit_user(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "edit_user");
            cmd.Parameters.AddWithValue("@_User_ID", db.User_id);
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void update_user(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_user");
            cmd.Parameters.AddWithValue("@_User_ID", db.User_id);
            cmd.Parameters.AddWithValue("@Name", db.User_name);
            cmd.Parameters.AddWithValue("@_address", db.User_address);
            cmd.Parameters.AddWithValue("@ph_no", db.User_phno);
            cmd.Parameters.AddWithValue("@email", db.User_email);
            cmd.Parameters.AddWithValue("@_password", db.Password);
            cmd.Parameters.AddWithValue("@_type", db.Type);
            cmd.Parameters.AddWithValue("@authority", db.Authority);
            cmd.Parameters.AddWithValue("@gender", db.User_gender);
            cmd.ExecuteNonQuery(); 
        }

        public DataTable binduser(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbcon.GetConnection();
            connection.Open();
            SqlCommand cmd = dbcon.GetProcedure(connection, "show_user");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_user(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbcon.GetConnection();
            connection.Open();
            SqlCommand cmd = dbcon.GetProcedure(connection, "get_user");
            cmd.Parameters.AddWithValue("@user_id", db.User_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void save_otheruser(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_otheruser");
            cmd.Parameters.AddWithValue("@Name", db.Name);
            cmd.Parameters.AddWithValue("@User_Name", db.User_name);
            cmd.Parameters.AddWithValue("@Password", db.Password);
            cmd.Parameters.AddWithValue("@Address", db.User_address);
            cmd.Parameters.AddWithValue("@Phone_No", db.User_phno);
            cmd.Parameters.AddWithValue("@Email_ID", db.User_email);
            cmd.Parameters.AddWithValue("@Gender", db.User_gender);
            cmd.Parameters.AddWithValue("@Type", db.Type);
            cmd.ExecuteNonQuery();   

        }

        public void save_userverified(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_userverified");
            cmd.Parameters.AddWithValue("@User_ID", db.User_id);
            cmd.Parameters.AddWithValue("@Code", db.Verification_code);
            cmd.Parameters.AddWithValue("@Verified", db.Authority);
            cmd.ExecuteNonQuery(); 
        }

        public DataTable get_otheruser_id(DBcontainer db)
        {
            DataTable dt= new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_otheruser_id");
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
            cmd.Parameters.AddWithValue("@Teacher_Name", db.Name);
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
            cmd.Parameters.AddWithValue("@Student_Name", db.Name);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

    }
}