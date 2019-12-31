using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;

namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class issue_book_BLL
    {
        issue_book_DLL obj = new issue_book_DLL();
        DBcontainer db = new DBcontainer();

        public DataTable bindStudent(DBcontainer db)
        {
            return obj.bindStudent(db);

        }

        public DataTable bindteacher(DBcontainer db)
        {
            return obj.bindteacher(db);
        }

        public DataTable bindBook(DBcontainer db)
        {
            return obj.bindBook(db);

        }

        public DataTable bindAuthor(DBcontainer db)
        {
            return obj.bindAuthor(db);

        }

        public DataTable bindPublication(DBcontainer db)
        {
            return obj.bindPublication(db);

        }

        public DataTable get_studentdetails(DBcontainer db)
        {
            return obj.get_studentdetail(db);
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

        public DataTable get_bookdetails(DBcontainer db)
        {
            return obj.get_bookdetails(db);
        }

        public DataTable get_bookdetails_bybarcode(DBcontainer db)
        {
            return obj.get_bookdetails_bybarcode(db);
        }
        public void save_issuemaster(DBcontainer db)
        {
            obj.save_issuemaster(db);
        }

        public void save_issuemaster_teacher(DBcontainer db)
        {
            obj.save_issuemaster_teacher(db);
        }

        public void save_issuemasterhistory(DBcontainer db)
        {
            obj.save_issuemasterhistory(db);
        }

        public void save_issuemasterhistory_teacher(DBcontainer db)
        {
            obj.save_issuemasterhistory_teacher(db);
        }

        public DataTable get_latestissuemasterid(DBcontainer db)
        {
            return obj.get_latestissuemasterid(db);
        }

        public DataTable get_latestissuemasterid_teacher(DBcontainer db)
        {
            return obj.get_latestissuemasterid_teacher(db);
        }

        public DataTable get_latestissuehistoryid(DBcontainer db)
        {
            return obj.get_latestissuehistoryid(db);
        }

        public DataTable get_latestissuehistoryid_teacher(DBcontainer db)
        {
            return obj.get_latestissuehistoryid_teacher(db);
        }

        public void save_issuedetail(DBcontainer db)
        {
            obj.save_issuedetail(db);
        }

        public void save_issuedetail_teacher(DBcontainer db)
        {
            obj.save_issuedetail_teacher(db);
        }

        public void save_issuedetailhistory(DBcontainer db)
        {
            obj.save_issuedetailhistory(db);
        }

        public void save_issuedetailhistory_teacher(DBcontainer db)
        {
            obj.save_issuedetailhistory_teacher(db);
        }

        public void update_bookquantity(DBcontainer db)
        {
            obj.update_bookquantity(db);
        }

        public void update_bookstatus(DBcontainer db)
        {
            obj.update_bookstatus(db);
        }

        public DataTable bindissuedetails(DBcontainer db)
        {
            return obj.bindissuedetails(db);
        }

        public DataTable bindissuedetails_teacher(DBcontainer db)
        {
            return obj.bindissuedetails_teacher(db);
        }

        public DataTable bindgridview(DBcontainer db)
        {
            return obj.bindgridview(db);
        }

        public DataTable bindgridview_teacher(DBcontainer db)
        {
            return obj.bindgridview_teacher(db);
        }

        public DataTable get_issuemaster_by_studentid(DBcontainer db)
        {
            return obj.get_issuemaster_by_studentid(db);
        }

        public DataTable get_issuedetailid(DBcontainer db)
        {
            return obj.get_issuedetailid(db);
        }

        public DataTable get_issuemaster_by_teacherid(DBcontainer db)
        {
            return obj.get_issuemaster_by_teacherid(db);
        }

        public DataTable get_issuedetailteacherid(DBcontainer db)
        {
            return obj.get_issuedetailteacherid(db);
        }

        public DataTable get_issuemasterdetail_teacherid(DBcontainer db)
        {
            return obj.get_issuemasterdetail_teacherid(db);
        }

        public DataTable get_issuemasterdetail(DBcontainer db)
        {
            return obj.get_issuemasterdetail(db);
        }

        public DataTable get_bookedbook_bystudentid(DBcontainer db)
        {
            return obj.get_bookedbook_bystudentid(db);
        }

        public void delete_bookedbook(DBcontainer db)
        {
            obj.delete_bookedbook(db);
        }

        public DataTable get_issuedetail_byimid(DBcontainer db)
        {
            return obj.get_issuedetail_byimid(db);
        }

        public DataTable get_issuedetail_byimid_teacher(DBcontainer db)
        {
            return obj.get_issuedetail_byimid_teacher(db);
        }
    }
    
}