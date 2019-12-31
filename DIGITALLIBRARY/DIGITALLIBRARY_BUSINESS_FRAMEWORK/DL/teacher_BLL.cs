using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;


namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class teacher_BLL
    {
        tescher_DLL obj = new tescher_DLL();
        DBcontainer db = new DBcontainer();
        public void save_teacher(DBcontainer db)
        {
            obj.save_teacher(db);
        }

        public DataTable  binddepartment(DBcontainer db)
        {
            return obj.binddepartment(db);
        }
        public DataTable bindteacher(DBcontainer db)
        {
            return obj.bindteacher(db);
        }

        public DataTable edit_teacher(DBcontainer db)
        {
            return obj.edit_teacher(db);
        }
        
        public void update_teacher(DBcontainer db)
        {
            obj.update_teacher(db);
        }

        public void delete_teacher(DBcontainer db)
        {
            obj.delete_teacher(db);
        }
        
        public DataTable get_latestteacher(DBcontainer db)
        {
            return obj.get_latestteacher(db);
        }
      
    }
}