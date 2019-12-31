using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;

namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class add_student_BLL
    {
        add_student_DLL obj = new add_student_DLL();
        DBcontainer db = new DBcontainer();

        public void save_student(DBcontainer db)
        {
            obj.save_student(db);
        }

        public DataTable bindstudent(DBcontainer db)
        {
            return obj.bindstudent(db);
        }

        public DataTable edit_student(DBcontainer db)
        {
            return obj.edit_student(db);
        }

      
        public void update_student(DBcontainer db)
        {
            obj.update_student(db);
        }

        public void delete_student(DBcontainer db)
        {
            obj.delete_student(db);
        }

        public DataTable get_lateststudent(DBcontainer db)
        {
            return obj.get_lateststudent(db);
        }


    }

}