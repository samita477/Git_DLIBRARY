using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class issue_book_DLL
    {
        DBconnection dbcon = new DBconnection();
        DBcontainer db = new DBcontainer();

        public DataTable bindStudent(DBcontainer db)
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

        public DataTable bindBook(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_book");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable bindAuthor(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_author");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable bindPublication(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "show_publication");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_studentdetail(DBcontainer db)
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
            SqlCommand cmd = dbcon.GetProcedure(con, "get_teacherdetail");
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

        public DataTable get_bookdetails(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_bookdetail");
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


        public void save_issuemaster(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_issuemaster");
            cmd.Parameters.AddWithValue("@User_ID", db.User_id);
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
         }

        public void save_issuemaster_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_issuemaster_teacher");
            cmd.Parameters.AddWithValue("@User_ID", db.User_id);
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.ExecuteNonQuery();
        }


        public void save_issuemasterhistory(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_issuemasterhistory");
            cmd.Parameters.AddWithValue("@IM_ID", db.Im_ID);
            cmd.Parameters.AddWithValue("@User_ID", db.User_id);
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
        }

        public void save_issuemasterhistory_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_issuemasterhistory_teacher");
            cmd.Parameters.AddWithValue("@IMT_ID", db.Imt_id);
            cmd.Parameters.AddWithValue("@User_ID", db.User_id);
            cmd.Parameters.AddWithValue("@Teacher_ID", db.Teacher_id);
            cmd.ExecuteNonQuery();
        }

       

        public void save_issuedetail(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_issuedetail");
            cmd.Parameters.AddWithValue("@IM_ID", db.Im_ID);
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);            
            cmd.Parameters.AddWithValue("@Issue_date", db.Issue_date);
            cmd.Parameters.AddWithValue("@Return_date", db.Return_date);
            cmd.ExecuteNonQuery();
           
        }

        public void save_issuedetail_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "save_issuedetail_teacher");
            cmd.Parameters.AddWithValue("@IMT_ID", db.Imt_id);
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.Parameters.AddWithValue("@Issue_date", db.Issue_date);
            cmd.Parameters.AddWithValue("@Return_date", db.Return_date);
            cmd.ExecuteNonQuery();

        }

        public void save_issuedetailhistory(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd1 = dbcon.GetProcedure(con, "save_issuedetailhistory");
            cmd1.Parameters.AddWithValue("@IMH_ID", db.Imh_id);
            cmd1.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd1.Parameters.AddWithValue("@Issue_date", db.Issue_date);
            cmd1.Parameters.AddWithValue("@Return_date", db.Return_date);
            cmd1.ExecuteNonQuery();

        }

        public void save_issuedetailhistory_teacher(DBcontainer db)
        {
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd1 = dbcon.GetProcedure(con, "save_issuedetailhistory_teacher");
            cmd1.Parameters.AddWithValue("@IMHT_ID", db.Imht_id);
            cmd1.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd1.Parameters.AddWithValue("@Issue_date", db.Issue_date);
            cmd1.Parameters.AddWithValue("@Return_date", db.Return_date);
            cmd1.ExecuteNonQuery();

        }

        public DataTable get_latestissuemasterid(DBcontainer db)
        {
             DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latestissuemasterid");           
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        
        }

        public DataTable get_latestissuemasterid_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latestissuemasterid_teacher");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }

        public DataTable get_latestissuehistoryid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latestissuedetailid");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }

        public DataTable get_latestissuehistoryid_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_latestissuehistoryid_teacher");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }

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

        public void update_bookstatus(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "update_bookstatus");
            cmd.Parameters.AddWithValue("@Book_ID", db.Book_id);
            cmd.Parameters.AddWithValue("@status", db.Book_status);
            cmd.ExecuteNonQuery();
        }


        public DataTable bindissuedetails(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuemasterdetails");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        
        }

        public DataTable bindissuedetails_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuemasterdetails_teacher");
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }

        public DataTable bindgridview(DBcontainer db)
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

        public DataTable bindgridview_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuedetails_teacher");
            cmd.Parameters.AddWithValue("@IMT_ID", db.Imt_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public DataTable get_issuemaster_by_studentid(DBcontainer db)
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

        public DataTable get_issuedetailid(DBcontainer db)
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

        public DataTable get_issuemaster_by_teacherid(DBcontainer db)
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

        public DataTable get_issuedetailteacherid(DBcontainer db)
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

        public DataTable get_issuemasterdetail_teacherid(DBcontainer db)
        {
             DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuemasterdetail_teacherid");
            cmd.Parameters.AddWithValue("@IMT_ID", db.Imt_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }


        public DataTable get_issuemasterdetail(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuemasterdetail");
            cmd.Parameters.AddWithValue("@IM_ID", db.Im_ID);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }


        public DataTable get_bookedbook_bystudentid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_bookedbook_bystudentid");
            cmd.Parameters.AddWithValue("@Student_ID", db.Student_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;
        }

        public void delete_bookedbook(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "delete_bookedbook");
            cmd.Parameters.AddWithValue("@BB_ID", db.Bb_id);
            cmd.ExecuteNonQuery();
        }

        public DataTable get_issuedetail_byimid(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuedetails_byimid");
            cmd.Parameters.AddWithValue("@IM_ID", db.Im_ID);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }

        public DataTable get_issuedetail_byimid_teacher(DBcontainer db)
        {
            DataTable dt = new DataTable();
            SqlConnection con = dbcon.GetConnection();
            con.Open();
            SqlCommand cmd = dbcon.GetProcedure(con, "get_issuedetails_byimid_teacher");
            cmd.Parameters.AddWithValue("@IMT_ID", db.Imt_id);
            cmd.ExecuteNonQuery();
            dt = dbcon.GetDataTable(cmd);
            return dt;

        }

    }
}