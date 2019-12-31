using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class add_student_DLL
    {
        DBconnection dbcon = new DBconnection();
        DBcontainer db = new DBcontainer();

        public void save_student(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_student");
            cmd.Parameters.AddWithValue("@name", db.Student_name);
            cmd.Parameters.AddWithValue("@address", db.Student_address);
            cmd.Parameters.AddWithValue("@phone_no", db.Student_phnno);
            cmd.Parameters.AddWithValue("@gender", db.Student_gender);
            cmd.Parameters.AddWithValue("@email", db.Student_email);
            cmd.Parameters.AddWithValue("@crn", db.Crn);
            cmd.Parameters.AddWithValue("@Image", db.Citizenship);
            cmd.Parameters.AddWithValue("@bar_code", db.Barcode);
            cmd.Parameters.AddWithValue("@batch", db.Batch);
            cmd.Parameters.AddWithValue("@Department_ID", db.Department_id);
            cmd.Parameters.AddWithValue("@semester", db.Student_semester);
            //cmd.Parameters.AddWithValue("@active", db.Active);
            cmd.ExecuteNonQuery();
        }

     
        public DataTable bindstudent(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_student");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void delete_student(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_student");
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id  );
            cmd.ExecuteNonQuery();
        }

        public void update_student(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_student");
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.Parameters.AddWithValue("@name", db.Student_name);
            cmd.Parameters.AddWithValue("@address", db.Student_address);
            cmd.Parameters.AddWithValue("@phone_no", db.Student_phnno);
            cmd.Parameters.AddWithValue("@gender", db.Student_gender);
            cmd.Parameters.AddWithValue("@email", db.Student_email);
            cmd.Parameters.AddWithValue("@crn", db.Crn);
            cmd.Parameters.AddWithValue("@Image", db.Citizenship);
            cmd.Parameters.AddWithValue("@bar_code", db.Barcode);
            cmd.Parameters.AddWithValue("@Department_ID", db.Department_id);
            cmd.Parameters.AddWithValue("@batch", db.Batch);
            cmd.Parameters.AddWithValue("@semester", db.Student_semester);
            cmd.ExecuteNonQuery();
            
        }

     

        public DataTable edit_student(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_studentid");
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

      
        
        public DataTable get_lateststudent(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_lateststudent");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        

    }
}