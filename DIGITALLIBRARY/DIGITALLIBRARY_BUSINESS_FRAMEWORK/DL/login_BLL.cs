using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;

namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class login_BLL
    {
        login_DLL obj = new login_DLL();
        DBcontainer db = new DBcontainer();

        public DataTable getuserid(DBcontainer db)
        {
            return obj.getuserid(db);
        }

       

        public DataTable check_verified_user(DBcontainer db)
        {
            return obj.check_verified_user(db);
        }

        public DataTable get_otheruser_byname(DBcontainer db)
        {
            return obj.get_otheruser_byname(db);
        }

        public DataTable getuser_withstudentname(DBcontainer db)
        {
            return obj.getuser_withstudentname(db);
        }

        public DataTable getuser_withteachername(DBcontainer db)
        {
            return obj.getuser_withteachername(db);
        }

        public void update_userverified(DBcontainer db)
        {
            obj.update_userverified(db);
        }
    }
}