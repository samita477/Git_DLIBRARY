using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;


namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{
    public class add_book_BLL
    {
        add_book_DLL obj = new add_book_DLL();
        DBcontainer db = new DBcontainer();

        public DataTable bindauthor(DBcontainer db)
        {
            return obj.bindauthor(db);
        }

        public DataTable bindpublication(DBcontainer db)
        {
            return obj.bindpublication(db);
        }

      
        public DataTable bindsubject(DBcontainer db)
        {
            return obj.bindsubject(db);
        }

        public DataTable bindsemester(DBcontainer db)
        {
            return obj.bindsemester(db);
        }
        public DataTable binddepartment(DBcontainer db)
        {
            return obj.binddepartment(db);
        }
        public void save_book(DBcontainer db)
        {
            obj.save_book(db);
        }

       
        public DataTable get_latestbookid(DBcontainer db)
        {
            return obj.get_latestbookid(db);
        }

        public void save_author(DBcontainer db)
        {
            obj.save_author(db);
        }
        public void save_department(DBcontainer db)
        {
            obj.save_department(db);
        }
        public DataTable edit_author(DBcontainer db)
        {
            return obj.edit_author(db);
        }
        public DataTable edit_department(DBcontainer db)
        {
            return obj.edit_department(db);
        }
        public void update_author(DBcontainer db)
        {
            obj.update_author(db);
        }

        public void delete_author(DBcontainer db)
        {
            obj.delete_author(db);
        }
        public void delete_department(DBcontainer db)
        {
            obj.delete_department(db);
        }
        public void delete_publication(DBcontainer db)
        {
            obj.delete_publication(db);
        }
        
        public void delete_subject(DBcontainer db)
        {
            obj.delete_subject(db);
        }
        public void delete_book(DBcontainer db)
        {
            obj.delete_book(db);
        }

        public void save_publication(DBcontainer db)
        {
            obj.save_publication(db);
        }

       public void save_subject(DBcontainer db)
        {
            obj.save_subject(db);
        }

      
        public DataTable edit_publication(DBcontainer db)
        {
            return obj.edit_publication(db);
        }
        public DataTable edit_subject(DBcontainer db)
        {
            return obj.edit_subject(db);
        }
     
        public DataTable edit_book(DBcontainer db)
        {
            return obj.edit_book(db);
        }


        public void update_publication(DBcontainer db)
        {
            obj.update_publication(db);
        }
        public void update_department(DBcontainer db)
        {
            obj.update_department(db);
        }
       
        public void update_subject(DBcontainer db)
        {
            obj.update_subject(db);
        }

        public void update_book(DBcontainer db)
        {
            obj.update_book(db);
        }

        public DataTable bindbook(DBcontainer db)
        {
            return obj.bindbook(db);
        }

        public DataTable bind_Avlbook(DBcontainer db)
        {
            return obj.bind_Avlbook(db);
        }
        public DataTable get_book_by_author(DBcontainer db)
        {
            return obj.get_book_by_author(db);
        }
        public DataTable get_book_by_publication(DBcontainer db)
        {
            return obj.get_book_by_publication(db);
        }
       
        public DataTable get_book_by_subject(DBcontainer db)
        {
            return obj.get_book_by_subject(db);
        }

        public DataTable check_ifalreadybooked(DBcontainer db)
        {
            return obj.check_ifalreadybooked(db);
        }

        public void save_book_booked(DBcontainer db)
        {
            obj.save_book_booked(db);
        }

        public DataTable spSuggestBid(DBcontainer db)
        {
            return obj.spSuggestBid(db);
        }

        public DataTable spSubRet(DBcontainer db)
        {
            return obj.spSubRet(db);
        }
        public DataTable spStudDetail(DBcontainer db)
        {
            return obj.spStudDetail(db);
        }

        public DataTable spBookDetail(DBcontainer db)
        {
            return obj.spBookDetail(db);
        }
    }

}
