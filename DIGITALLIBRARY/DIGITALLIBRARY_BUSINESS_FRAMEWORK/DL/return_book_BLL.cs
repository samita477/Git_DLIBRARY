using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;

namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class return_book_BLL
    {
        return_book_DLL obj = new return_book_DLL();
        DBcontainer db = new DBcontainer();

        public DataTable get_studentdetails(DBcontainer db)
        {
            return obj.get_studentdetails(db);
        }

        public DataTable get_studentdetails_bybarcode(DBcontainer db)
        {
            return obj.get_studentdetails_bybarcode(db);
        }

        public DataTable get_teacherdetails(DBcontainer db)
        {
            return obj.get_teacherdetails(db);
        }

        public DataTable get_teacherdetails_bybarcode(DBcontainer db)
        {
            return obj.get_teacherdetails_bybarcode(db);
        }

        public DataTable get_issuemaster_byid(DBcontainer db)
        {
            return obj.get_issuemaster_id(db);
        }


        public DataTable get_issuemaster_byid_teacher(DBcontainer db)
        {
            return obj.get_issuemaster_id_teacher(db);
        }
        public DataTable bindstudent(DBcontainer DB)
        {
            return obj.bindstudent(db);
        }

        public DataTable bindteacher(DBcontainer DB)
        {
            return obj.bindteacher(db);
        }

        public void delete_issuedetail_byid(DBcontainer db)
        {
            obj.delete_issuedetail_byid(db);
        }

        public void delete_issuedetail_byid_teacher(DBcontainer db)
        {
            obj.delete_issuedetail_byid_teacher(db);
        }

        public DataTable get_issuedetail_byid(DBcontainer db)
        {
            return obj.get_issuedetail_byid(db);
        }

        public DataTable get_returnmasterid(DBcontainer db)
        {
            return obj.get_returnmasterid(db);
        }

        public void save_returnmaster(DBcontainer db)
        {
            obj.save_returnmaster(db);
        }

        public DataTable get_latest_returnmasterid(DBcontainer db)
        {
            return obj.get_latest_returnmasterid(db);
        }

        public void save_returndetail(DBcontainer db)
        {
            obj.save_returndetail(db);
        }

        public DataTable get_issuedetail_idid(DBcontainer db)
        {
            return obj.get_issuedetail_idid(db);
        }

        public DataTable get_issuedetail_idid_teacher(DBcontainer db)
        {
            return obj.get_issuedetail_idid_teacher(db);
        }

        public DataTable get_bookdetails(DBcontainer db)
        {
            return obj.get_bookdetails(db);
        }

        public void update_bookquantity(DBcontainer db)
        {
            obj.update_bookquantity(db);
        }
        public DataTable get_returnmasterid_teacher(DBcontainer db)
        {
            return  obj.get_returnmasterid_teacher(db);
        }

            public void save_returnmaster_teacher(DBcontainer db)
        {
            obj.save_returnmaster_teacher(db);
        }
            public void save_returndetail_teacher(DBcontainer db)
        {
            obj.save_returndetail_teacher(db);
        }
        
                
            public DataTable get_latest_returnmasterid_teacher(DBcontainer db)
        {
            return  obj.get_latest_returnmasterid_teacher(db);
        }

        

            public DataTable get_issuedetail_byid_teacher(DBcontainer db)
        {
            return obj.get_issuedetail_byid_teacher(db);
        }

            public DataTable getwarningmail(DBcontainer db)
            {
                return obj.getwarningmail(db);
            }

            public DataTable get_student_byname(DBcontainer db)
            {
                return obj.get_student_byname(db);
            }
    }

}