using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class session_DLL
    {
        DBconnection dbcon = new DBconnection();
        DBcontainer db = new DBcontainer();

        public DataTable bindsession(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_session");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void save_session(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_session");          
            cmd.Parameters.AddWithValue("@Semester_Name", db.Semester_name);
            cmd.Parameters.AddWithValue("@Date_From", db.Date_from);
            cmd.Parameters.AddWithValue("@Date_To", db.Date_to);
            cmd.Parameters.AddWithValue("@Penalty", db.Penalty_rate);
            cmd.Parameters.AddWithValue("@book_student", db.Book_student);
            cmd.Parameters.AddWithValue("@book_teacher", db.Book_teacher);
            cmd.ExecuteNonQuery();
        }

        public DataTable edit_session(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "edit_session");
            cmd.Parameters.AddWithValue("@Semester_ID", db.Semester_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void update_session(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_session");
            cmd.Parameters.AddWithValue("@Semester_ID", db.Semester_id);
            cmd.Parameters.AddWithValue("@Semester_Name", db.Semester_name);
            cmd.Parameters.AddWithValue("@Date_From", db.Date_from);
            cmd.Parameters.AddWithValue("@Date_To", db.Date_to);
            cmd.Parameters.AddWithValue("@Penalty", db.Penalty_rate);
            cmd.Parameters.AddWithValue("@book_student", db.Book_student);
            cmd.Parameters.AddWithValue("@book_teacher", db.Book_teacher);
            cmd.ExecuteNonQuery();
        }

        public void delete_session(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_session");
            cmd.Parameters.AddWithValue("@Semester_ID", db.Semester_id);
            cmd.ExecuteNonQuery();
        }
        public DataTable bindthissession(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "edit_session");
            cmd.Parameters.AddWithValue("@Semester_ID", db.Semester_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public void update_session_returndate(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_session_returndate");
            cmd.Parameters.AddWithValue("@Semester_ID", db.Semester_id);
            cmd.Parameters.AddWithValue("@date_to", db.Date_to);
            cmd.ExecuteNonQuery();
           
        }
        public void update_session_Tbook(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_session_Tbook");
            cmd.Parameters.AddWithValue("@Semester_ID", db.Semester_id);
            cmd.Parameters.AddWithValue("@book_teacher", db.Book_teacher);
            cmd.ExecuteNonQuery();
          
        }
        public void update_session_Sbook(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_session_Sbook");
            cmd.Parameters.AddWithValue("@Semester_ID", db.Semester_id);
            cmd.Parameters.AddWithValue("@book_student", db.Book_student);
            cmd.ExecuteNonQuery();
           
        }
    }
}