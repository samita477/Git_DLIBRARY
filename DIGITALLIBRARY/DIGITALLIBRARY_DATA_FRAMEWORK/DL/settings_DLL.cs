using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class settings_DLL
    {
          DBconnection dbcon = new DBconnection();
          DBcontainer db = new DBcontainer();

          public DataTable bindThisUser(DBcontainer db)
          {
              DataTable dt = new DataTable();
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "bindThisUser");
              cmd.Parameters.AddWithValue("@User_ID", db.User_id);
              cmd.ExecuteNonQuery();
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

        
          public DataTable bindOtherUser(DBcontainer db)
          {
              DataTable dt = new DataTable();
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "bindOtherUser");
              cmd.Parameters.AddWithValue("@User_ID", db.User_id);
              cmd.ExecuteNonQuery();
              dt = dbcon.GetDataTable(cmd);
              return dt;
          }

          public void update_otheruser(DBcontainer db)
          {
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "update_otheruser");
              cmd.Parameters.AddWithValue("@User_ID", db.User_id);
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

          public void pwchange_request(DBcontainer db)
          {
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "save_pw_reset");
              cmd.Parameters.AddWithValue("@User_ID", db.User_id);
              cmd.Parameters.AddWithValue("@Code", db.Verification_code);
              cmd.Parameters.AddWithValue("@Verified", false);
              cmd.ExecuteNonQuery();
          }

          public void update_userpassword(DBcontainer db)
          {
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "update_userpassword");
              cmd.Parameters.AddWithValue("@User_ID", db.User_id);
              cmd.Parameters.AddWithValue("@Password", db.Password);              
              cmd.ExecuteNonQuery();
          }

          public void update_otheruserpassword(DBcontainer db)
          {
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "update_otheruserpassword");
              cmd.Parameters.AddWithValue("@User_ID", db.User_id);
              cmd.Parameters.AddWithValue("@Password", db.Password);
              cmd.ExecuteNonQuery();
          }

          public DataTable get_userbyid(DBcontainer db)
          {
              DataTable dt = new DataTable();
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "edit_user");
              cmd.Parameters.AddWithValue("@_User_ID", db.User_id);
              cmd.ExecuteNonQuery();
              dt = dbcon.GetDataTable(cmd);
              return dt;
          }

          public DataTable get_otheruserbyid(DBcontainer db)
          {
              DataTable dt = new DataTable();
              SqlConnection con = dbcon.GetConnection();
              con.Open();
              SqlCommand cmd = dbcon.GetProcedure(con, "edit_otheruser");
              cmd.Parameters.AddWithValue("@User_ID", db.User_id);
              cmd.ExecuteNonQuery();
              dt = dbcon.GetDataTable(cmd);
              return dt;
          }
    }
}