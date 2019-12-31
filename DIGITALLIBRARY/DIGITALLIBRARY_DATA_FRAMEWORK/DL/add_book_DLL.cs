using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class add_book_DLL
    {
        DBconnection dbcon = new DBconnection();
        DBcontainer db = new DBcontainer();
     

        public DataTable bindauthor(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_author");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable bindsubject(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_subject");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable bindsemester(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_semestermaster");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable bindpublication(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_publication");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable bindSM(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_SM");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void save_author(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_author");
            cmd.Parameters.AddWithValue("@Author_Name", db.Author_name);
            cmd.ExecuteNonQuery();

        }

        public void save_publication(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_publication");
            cmd.Parameters.AddWithValue("@Publication_Name", db.Publication_name);
            cmd.ExecuteNonQuery();
        }
        public void save_department(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_department");
            cmd.Parameters.AddWithValue("@Department_Name", db.Department_name);
            cmd.ExecuteNonQuery();
        }
        public void save_subject(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_subject");
            cmd.Parameters.AddWithValue("@Subject_Name", db.Subject_name);
            cmd.ExecuteNonQuery();
        }
      

        public void save_book(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_book");
            cmd.Parameters.AddWithValue("@name", db.Book_name);
            cmd.Parameters.AddWithValue("@page", db.Page_no);
            cmd.Parameters.AddWithValue("@price", db.Price);
            cmd.Parameters.AddWithValue("@edition", db.Edition);
            cmd.Parameters.AddWithValue("@quantity", db.Quantity);
            cmd.Parameters.AddWithValue("@avl_quantity", db.Available_qt);
            cmd.Parameters.AddWithValue("@date_of_entry", db.Entry_date);
            cmd.Parameters.AddWithValue("@status", db.Book_status);
            cmd.Parameters.AddWithValue("@image_url", db.Citizenship);
            cmd.Parameters.AddWithValue("@category", db.Category);
            cmd.Parameters.AddWithValue("@subject_id", db.Subject_id);
            cmd.Parameters.AddWithValue("@author_id", db.Author_id);
            cmd.Parameters.AddWithValue("@publication_id", db.Publication_id);
            cmd.Parameters.AddWithValue("@bar_code", db.Barcode);
            cmd.Parameters.AddWithValue("@SM_ID", db.SM_ID1);
            cmd.ExecuteNonQuery();
        
        }
        public DataTable edit_author(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_authorid");
            cmd.Parameters.AddWithValue("@Author_ID", db.Author_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable edit_publication(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_publicationid");
            cmd.Parameters.AddWithValue("@Publication_ID", db.Publication_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable edit_department(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "edit_department");
            cmd.Parameters.AddWithValue("@Department_ID", db.Department_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
     
        public DataTable edit_book(DBcontainer db)
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

   
        public DataTable edit_subject(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_subjectid");
            cmd.Parameters.AddWithValue("@Subject_ID", db.Subject_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public void update_author(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_author");
            cmd.Parameters.AddWithValue("@Author_ID", db.Author_id);
            cmd.Parameters.AddWithValue("@Author_Name", db.Author_name);
            cmd.ExecuteNonQuery();

        }

        public void update_publication(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_publication");
            cmd.Parameters.AddWithValue("@Publication_ID", db.Publication_id);
            cmd.Parameters.AddWithValue("@Publication_Name", db.Publication_name);
            cmd.ExecuteNonQuery();

        }
        public void update_department(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_department");
            cmd.Parameters.AddWithValue("@Department_ID", db.Department_id);
            cmd.Parameters.AddWithValue("@Department_Name", db.Department_name);
            cmd.ExecuteNonQuery();

        }
      
        public void update_subject(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_subject");
            cmd.Parameters.AddWithValue("@Subject_ID", db.Subject_id);
            cmd.Parameters.AddWithValue("@Subject_Name", db.Subject_name);
            cmd.ExecuteNonQuery();

        }

        public void update_book(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_book");
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.Parameters.AddWithValue("@Book_Name", db.Book_name);
            cmd.Parameters.AddWithValue("@Page", db.Page_no);
            cmd.Parameters.AddWithValue("@Price", db.Price);
            cmd.Parameters.AddWithValue("@Edition", db.Edition);
            cmd.Parameters.AddWithValue("@Quantity", db.Quantity);
            cmd.Parameters.AddWithValue("@Avl_qty", db.Available_qt);
            cmd.Parameters.AddWithValue("@Entry_Date", db.Entry_date);
            cmd.Parameters.AddWithValue("@status", db.Book_status);
            cmd.Parameters.AddWithValue("@image_url", db.Citizenship);
            cmd.Parameters.AddWithValue("@category", db.Category);
            cmd.Parameters.AddWithValue("@Subject_ID",db.Subject_id);
            cmd.Parameters.AddWithValue("@Author_ID", db.Author_id);
            cmd.Parameters.AddWithValue("@Publication_ID", db.Publication_id);
            cmd.Parameters.AddWithValue("@bar_code", db.Barcode);
            cmd.Parameters.AddWithValue("@SM_ID", db.SM_ID1);
            cmd.ExecuteNonQuery();
        }

      
        public void delete_author(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_author");
            cmd.Parameters.AddWithValue("@Author_ID", db.Author_id);
            cmd.ExecuteNonQuery();
        }

        public void delete_publication(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_publication");
            cmd.Parameters.AddWithValue("@Publication_ID", db.Publication_id);
            cmd.ExecuteNonQuery();
        }
        public void delete_department(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_department");
            cmd.Parameters.AddWithValue("@Department_ID", db.Department_id);
            cmd.ExecuteNonQuery();
        }
     
        public void delete_subject(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_subject");
            cmd.Parameters.AddWithValue("@Subject_ID", db.Subject_id );
            cmd.ExecuteNonQuery();
        }
        public void delete_book(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_book");
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.ExecuteNonQuery();
        }

        public DataTable bindbook(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_book_details");
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

      
        public DataTable get_latestbookid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latestbookid");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable bindgridview(DBcontainer db)
        {

            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latestbookid");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable bind_Avlbook(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_Avlbook");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable get_book_by_author(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_book_by_author");
            cmd.Parameters.AddWithValue("@Author_ID", db.Author_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable get_book_by_subject(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_book_by_subject");
            cmd.Parameters.AddWithValue("@Subject_ID", db.Subject_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable get_book_by_publication(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_book_by_publication");
            cmd.Parameters.AddWithValue("@Publication_ID", db.Publication_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
      
        public DataTable check_ifalreadybooked(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "check_ifalreadybooked");
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void save_book_booked(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_book_booked");
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.Parameters.AddWithValue("@booked", true);
            cmd.ExecuteNonQuery();
        }

        public DataTable spStudDetail(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "spStudDetail");
            cmd.Parameters.AddWithValue("@sid", db.Student_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable spSubRet(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "spSubRet");
            cmd.Parameters.AddWithValue("@sem", db.Semester_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable spSuggestBid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "spSuggestBid");
            cmd.Parameters.AddWithValue("@sub", db.Subject_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }
        public DataTable spBookDetail(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "spBookDetail");
            cmd.Parameters.AddWithValue("@B1", db.User_id);
            cmd.Parameters.AddWithValue("@B2", db.Bb_id);
            cmd.Parameters.AddWithValue("@B3", db.Verification_id);
            cmd.Parameters.AddWithValue("@B4", db.Student_id);
            cmd.Parameters.AddWithValue("@B5", db.Subject_id);
            cmd.Parameters.AddWithValue("@B6", db.Semester_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        } 

             
    }
}