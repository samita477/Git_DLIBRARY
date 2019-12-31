using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;


namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class settings_BLL
    {

        settings_DLL obj = new settings_DLL();
        DBcontainer db = new DBcontainer();

        public DataTable bindThisUser(DBcontainer db)
        {

            return obj.bindThisUser(db);
        }

        public void update_user(DBcontainer db)
        {
            obj.update_user(db);
        }

        public void update_otheruser(DBcontainer db)
        {
            obj.update_otheruser(db);
        }

        public DataTable bindOtherUser(DBcontainer db)
        {
            return obj.bindOtherUser(db);
        }

        public void pwchange_request(DBcontainer db)
        {
            obj.pwchange_request(db);
        }

        public void update_userpassword(DBcontainer db)
        {
            obj.update_userpassword(db);
        }

        public void update_otheruserpassword(DBcontainer db)
        {
            obj.update_otheruserpassword(db);
        }

        public DataTable get_userbyid(DBcontainer db)
        {
            return obj.get_userbyid(db);
        }

        public DataTable get_otheruserbyid(DBcontainer db)
        {
            return obj.get_otheruserbyid(db);
        }
    }

    
}