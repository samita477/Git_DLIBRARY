using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;

namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class user_BLL
    {
        user_DLL obj = new user_DLL();
        DBcontainer db = new DBcontainer();

        public void save_user(DBcontainer db)
        {
            obj.save_user(db);
        }

        public DataTable edit_user(DBcontainer db)
        {
            return obj.edit_user(db);
        }

        public void update_user(DBcontainer db)
        {
            obj.update_user(db);
        }

        public void delete_user(DBcontainer db)
        {
            obj.delete_user(db);
        }

        public DataTable binduser(DBcontainer db)
        {
            return obj.binduser(db);
        }
        public DataTable get_user(DBcontainer db)
        {
            return obj.get_user(db);
        }

        public void save_otheruser(DBcontainer db)
        {
            obj.save_otheruser(db);
        }

        public void save_userverified(DBcontainer db)
        {
            obj.save_userverified(db);
        }

        public DataTable get_otheruser_id(DBcontainer db)
        {
            return obj.get_otheruser_id(db);
        }

        public DataTable getuser_withstudentname(DBcontainer db)
        {
            return obj.getuser_withstudentname(db);
        }


        public DataTable getuser_withteachername(DBcontainer db)
        {
            return obj.getuser_withteachername(db);
        }
    }
}