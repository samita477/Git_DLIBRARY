using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class tescher_DLL
    {
        DBconnection dbcon = new DBconnection();
        DBcontainer db = new DBcontainer();

        public void save_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_teacher");
            cmd.Parameters.AddWithValue("@name", db.Teacher_name);
            cmd.Parameters.AddWithValue("@address", db.Teacher_address);
            cmd.Parameters.AddWithValue("@phone_no", db.Teacher_phnno);
            cmd.Parameters.AddWithValue("@gender", db.Teacher_gender);
            cmd.Parameters.AddWithValue("@email", db.Teacher_email);
            cmd.Parameters.AddWithValue("@image_URL", db.Citizenship);
            cmd.Parameters.AddWithValue("@bar_code", db.Barcode);
            cmd.Parameters.AddWithValue("@Department_ID", db.Department_id);
            cmd.Parameters.AddWithValue("@subject_assigned", db.Subject_assigned);
            //cmd.Parameters.AddWithValue("@active", true);
            cmd.ExecuteNonQuery();
        }

        public DataTable bindteacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_teacher");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable binddepartment(DBcontainer db)
        {
             DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_department");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }
        public void delete_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_teacher");
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.ExecuteNonQuery();
        }



        public void update_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_teacher");
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.Parameters.AddWithValue("@Teacher_Name", db.Teacher_name);
            cmd.Parameters.AddWithValue("@_address", db.Teacher_address);
            cmd.Parameters.AddWithValue("@ph_no", db.Teacher_phnno);
            cmd.Parameters.AddWithValue("@gender", db.Teacher_gender);
            cmd.Parameters.AddWithValue("@email", db.Teacher_email);
            cmd.Parameters.AddWithValue("@image_URL", db.Citizenship);
            cmd.Parameters.AddWithValue("@bar_code", db.Barcode);
            cmd.Parameters.AddWithValue("@Department_ID", db.Department_id);
            cmd.Parameters.AddWithValue("@subject_assigned", db.Subject_assigned);
            cmd.ExecuteNonQuery();

        }
        public DataTable edit_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "edit_teacher");
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_latestteacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latestteacher");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
    }
}