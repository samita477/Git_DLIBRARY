using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;

namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class session_BLL
    {
        session_DLL obj = new session_DLL();
        DBcontainer db = new DBcontainer();

        public DataTable bindsession(DBcontainer db)
        {
            return obj.bindsession(db);
        }

        public void save_session(DBcontainer db)
        {
            obj.save_session(db);
        }          
     
        public DataTable edit_session(DBcontainer db)
        {
            return obj.edit_session(db);
        }

        public void update_session(DBcontainer db)
        {
            obj.update_session(db);
        }

        public void delete_session(DBcontainer db)
        {
            obj.delete_session(db);
        }
        public DataTable bindthissession(DBcontainer db)
        {
            return obj.bindthissession(db);
        }
        public void update_session_returndate(DBcontainer db)
        {
            obj.update_session_returndate(db);
        }
        public void update_session_Tbook(DBcontainer db)
        {
            obj.update_session_Tbook(db);
        }
        public void update_session_Sbook(DBcontainer db)
        {
            obj.update_session_Sbook(db);
        }
    }
}