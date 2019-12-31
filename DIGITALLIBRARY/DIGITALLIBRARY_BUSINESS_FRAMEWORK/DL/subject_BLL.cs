using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_DATA_FRAMEWORK.DL;


namespace DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL
{

   public class subject_BLL
    {
       DBcontainer db = new DBcontainer();
       subject_DLL obj = new subject_DLL();

       public DataTable bindsubject(DBcontainer db)
       {
           return obj.bindsubject(db);
       }

       public DataTable get_fileuploaded(DBcontainer db)
       {
           return obj.get_fileuploaded(db);
       }

       public DataTable bind_subjectfile(DBcontainer db)
       {
           return obj.bind_subjectfile(db);
       }

       public DataTable bindsubjectonly(DBcontainer db)
       {
           return obj.bindsubjectonly(db);
       }

       public DataTable edit_subject(DBcontainer db)
       {
           return obj.edit_subject(db);
       }

       public void save_subject_url(DBcontainer db)
       {
           obj.save_subject_url(db);
       }

    }
}