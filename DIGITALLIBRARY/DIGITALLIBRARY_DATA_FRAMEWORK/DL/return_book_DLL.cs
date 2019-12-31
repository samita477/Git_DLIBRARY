using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class return_book_DLL
    {
        DBconnection dbcon = new DBconnection();
        DBcontainer db = new DBcontainer();

        public DataTable get_studentdetails(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_studentdetail");
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable get_studentdetails_bybarcode(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_studentdetails_bybarcode");
            cmd.Parameters.AddWithValue("@bar_code", db.Sbarcode);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable get_teacherdetails(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_teacherdetails");
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_teacherdetails_bybarcode(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_teacherdetails_bybarcode");
            cmd.Parameters.AddWithValue("@bar_code", db.Tbarcode);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_issuemaster_id(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuemaster_by_studentid");
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }


        public DataTable get_issuemaster_id_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuemaster_by_teacherid");
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }
        public DataTable get_issuedetail_byid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuedetailid");
            cmd.Parameters.AddWithValue("@IM_ID", db.Im_ID);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
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

        public void delete_issuedetail_byid(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_issuedetail_byid");
            cmd.Parameters.AddWithValue("@ID_ID", db.Id_ID);
           // cmd.Parameters.AddWithValue("@IM_ID", db.Im_ID);
            cmd.ExecuteNonQuery();
        }

        public DataTable get_returnmasterid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_returnmasterid");
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void save_returnmaster(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_returnmaster");
            cmd.Parameters.AddWithValue("@_User_ID", db.User_id);
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
        }

        public DataTable get_latest_returnmasterid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latest_returnmasterid");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void save_returndetail(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_returndetail");
            cmd.Parameters.AddWithValue("@RMH_ID", db.Rm_id);
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.Parameters.AddWithValue("@issue_date", db.Issue_date);
            cmd.Parameters.AddWithValue("@return_date", db.Return_date);
            cmd.Parameters.AddWithValue("@returned_date", db.Returned_date);
            cmd.Parameters.AddWithValue("@penalty", db.Penalty);
            cmd.ExecuteNonQuery();
        }


        public DataTable get_issuedetail_idid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuedetail_idid");
            cmd.Parameters.AddWithValue("@ID_ID", db.Id_ID);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_issuedetail_idid_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuedetail_idid_teacher");
            cmd.Parameters.AddWithValue("@IDT_ID", db.Idt_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }


        public DataTable get_bookdetails(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_bookid");
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_bookdetails_bybarcode(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_bookdetail_bybarcode");
            cmd.Parameters.AddWithValue("@bar_code", db.Barcode);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
          
       
           
            //get_issuedetail_byid_teacher

        public void update_bookquantity(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_bookquantity");
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.Parameters.AddWithValue("@quantity", db.Available_qt);
            cmd.ExecuteNonQuery();

        }
                public DataTable get_returnmasterid_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_returnmasterid_teacher");
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
         public void save_returnmaster_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_returnmaster_teacher");
            cmd.Parameters.AddWithValue("@_User_ID", db.User_id);
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.ExecuteNonQuery();
        }
                public void save_returndetail_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_returndetail_teacher");
            cmd.Parameters.AddWithValue("@RMHT_ID", db.Rmt_id);
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.Parameters.AddWithValue("@issue_date", db.Issue_date);
            cmd.Parameters.AddWithValue("@return_date", db.Return_date);
            cmd.Parameters.AddWithValue("@returned_date", db.Returned_date);
            cmd.ExecuteNonQuery();
        }
        
        public void delete_issuedetail_byid_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_issuedetail_byid_teacher");
            cmd.Parameters.AddWithValue("@IDT_ID", db.Idt_id);
            //cmd.Parameters.AddWithValue("@IMT_ID", db.Imt_id);
            cmd.ExecuteNonQuery();
        }
            public DataTable get_latest_returnmasterid_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latest_returnmasterid_teacher");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
          public DataTable get_issuedetail_byid_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuedetailid_teacher");
            cmd.Parameters.AddWithValue("@IMT_ID", db.Imt_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

          public DataTable getwarningmail(DBcontainer db)
          {
              DataTable dt = new DataTable();
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "getwarningemail");
              cmd.Parameters.AddWithValue("@date_now", db.Tnow);
              cmd.ExecuteNonQuery();
              dt = dbcon.GetDataTable(cmd);
              return dt;
          }

          public DataTable get_student_byname(DBcontainer db)
          {
              DataTable dt = new DataTable();
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "get_student_byname");
              cmd.Parameters.AddWithValue("@Student_Name", db.Student_name);
              cmd.ExecuteNonQuery();
              dt = dbcon.GetDataTable(cmd);
              return dt;
          }
    }
}