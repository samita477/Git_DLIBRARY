using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIGITALLIBRARY_DATA_FRAMEWORK.DL
{
    public class DBcontainer
    {

        private int bb_id;

        public int Bb_id
        {
            get { return bb_id; }
            set { bb_id = value; }
        }

        private bool active;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        private int user_id;

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        private string user_name;

        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }

        private string check_password;

        public string Check_password
        {
            get { return check_password; }
            set { check_password = value; }
        }
        private string user_address;

        public string User_address
        {
            get { return user_address; }
            set { user_address = value; }
        }
        private string user_phno;

        public string User_phno
        {
            get { return user_phno; }
            set { user_phno = value; }
        }
        private string user_email;

        public string User_email
        {
            get { return user_email; }
            set { user_email = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private bool authority;

        public bool Authority
        {
            get { return authority; }
            set { authority = value; }
        }
        private string user_gender;

        public string User_gender
        {
            get { return user_gender; }
            set { user_gender = value; }
        }

        private string verification_code;

        public string Verification_code
        {
            get { return verification_code; }
            set { verification_code = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int verification_id;

        public int Verification_id
        {
            get { return verification_id; }
            set { verification_id = value; }
        }
        private int department_id;

        public int Department_id
        {
            get { return department_id; }
            set { department_id = value; }
        }
        private string department_name;

        public string Department_name
        {
            get { return department_name; }
            set { department_name = value; }
        }
        private int subject_id;

        public int Subject_id
        {
            get { return subject_id; }
            set { subject_id = value; }
        }
        private string subject_name;

        public string Subject_name
        {
            get { return subject_name; }
            set { subject_name = value; }
        }
        private int supplier_id;

        public int Supplier_id
        {
            get { return supplier_id; }
            set { supplier_id = value; }
        }
        public byte[] Citizenship { get; set; }
        private string supplier_name;

        public string Supplier_name
        {
            get { return supplier_name; }
            set { supplier_name = value; }
        }
        private string supplier_address;

        public string Supplier_address
        {
            get { return supplier_address; }
            set { supplier_address = value; }
        }
        private string supplier_phno;

        public string Supplier_phno
        {
            get { return supplier_phno; }
            set { supplier_phno = value; }
        }
        private string supplier_email;

        public string Supplier_email
        {
            get { return supplier_email; }
            set { supplier_email = value; }
        }
        private int author_id;

        public int Author_id
        {
            get { return author_id; }
            set { author_id = value; }
        }
        private string author_name;

        public string Author_name
        {
            get { return author_name; }
            set { author_name = value; }
        }
        private int publication_id;

        public int Publication_id
        {
            get { return publication_id; }
            set { publication_id = value; }
        }
        private string publication_name;

        public string Publication_name
        {
            get { return publication_name; }
            set { publication_name = value; }
        }
        private int book_id;

        public int Book_id
        {
            get { return book_id; }
            set { book_id = value; }
        }
        private string book_name;

        public string Book_name
        {
            get { return book_name; }
            set { book_name = value; }
        }
        private int page_no;

        public int Page_no
        {
            get { return page_no; }
            set { page_no = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private string edition;

        public string Edition
        {
            get { return edition; }
            set { edition = value; }
        }
        private int available_qt;

        public int Available_qt
        {
            get { return available_qt; }
            set { available_qt = value; }
        }
        private int remaining_qty;

        public int Remaining_qty
        {
            get { return remaining_qty; }
            set { remaining_qty = value; }
        }


        private DateTime entry_date;

        public DateTime Entry_date
        {
            get { return entry_date; }
            set { entry_date = value; }
        }

        private int student_id;

        public int Student_id
        {
            get { return student_id; }
            set { student_id = value; }
        }
        private string student_name;

        public string Student_name
        {
            get { return student_name; }
            set { student_name = value; }
        }
        private string student_address;

        public string Student_address
        {
            get { return student_address; }
            set { student_address = value; }
        }
        private string student_email;

        public string Student_email
        {
            get { return student_email; }
            set { student_email = value; }
        }
        private string student_phnno;

        public string Student_phnno
        {
            get { return student_phnno; }
            set { student_phnno = value; }
        }
        private string crn;

        public string Crn
        {
            get { return crn; }
            set { crn = value; }
        }
        private string student_gender;

        public string Student_gender
        {
            get { return student_gender; }
            set { student_gender = value; }
        }

        private int im_ID;

        public int Im_ID
        {
            get { return im_ID; }
            set { im_ID = value; }
        }

        private int imh_id;

        public int Imh_id
        {
            get { return imh_id; }
            set { imh_id = value; }
        }
        private int id_ID;

        public int Id_ID
        {
            get { return id_ID; }
            set { id_ID = value; }
        }
        private DateTime issue_date;

        public DateTime Issue_date
        {
            get { return issue_date; }
            set { issue_date = value; }
        }
        private DateTime return_date;

        public DateTime Return_date
        {
            get { return return_date; }
            set { return_date = value; }
        }
        private int issue_sn;

        public int Issue_sn
        {
            get { return issue_sn; }
            set { issue_sn = value; }
        }
        private int return_sn;

        public int Return_sn
        {
            get { return return_sn; }
            set { return_sn = value; }
        }
        private int return_date_for_this_session;

        public int Return_date_for_this_session
        {
            get { return return_date_for_this_session; }
            set { return_date_for_this_session = value; }
        }

        private string book_status;

        public string Book_status
        {
            get { return book_status; }
            set { book_status = value; }
        }
        private string book_image_url;

        public string Book_image_url
        {
            get { return book_image_url; }
            set { book_image_url = value; }
        }

        private int book_imageid;

        public int Book_imageid
        {
            get { return book_imageid; }
            set { book_imageid = value; }
        }

        private int rm_id;

        public int Rm_id
        {
            get { return rm_id; }
            set { rm_id = value; }
        }
        private int rmt_id;

        public int Rmt_id
           {
         get { return rmt_id; }
         set { rmt_id = value; }
        }
        private int idt_id;

public int Idt_id
{
  get { return idt_id; }
  set { idt_id = value; }
}
        private int rd_id;

        public int Rd_id
        {
            get { return rd_id; }
            set { rd_id = value; }
        }
        private DateTime returned_date;

        public DateTime Returned_date
        {
            get { return returned_date; }
            set { returned_date = value; }
        }

        private int semester_id;

        public int Semester_id
        {
            get { return semester_id; }
            set { semester_id = value; }
        }
        private string semester_name;

        public string Semester_name
        {
            get { return semester_name; }
            set { semester_name = value; }
        }
        private DateTime date_from;

        public DateTime Date_from
        {
            get { return date_from; }
            set { date_from = value; }
        }
        private DateTime date_to;

        public DateTime Date_to
        {
            get { return date_to; }
            set { date_to = value; }
        }
        private decimal penalty_rate;

        public decimal Penalty_rate
        {
            get { return penalty_rate; }
            set { penalty_rate = value; }
        }


        private int teacher_id;

        public int Teacher_id
        {
            get { return teacher_id; }
            set { teacher_id = value; }
        }
        private string teacher_name;

        public string Teacher_name
        {
            get { return teacher_name; }
            set { teacher_name = value; }
        }
        private string teacher_address;

        public string Teacher_address
        {
            get { return teacher_address; }
            set { teacher_address = value; }
        }
        private string teacher_email;

        public string Teacher_email
        {
            get { return teacher_email; }
            set { teacher_email = value; }
        }
        private string teacher_phnno;

        public string Teacher_phnno
        {
            get { return teacher_phnno; }
            set { teacher_phnno = value; }
        }
        private string teacher_gender;

        public string Teacher_gender
        {
            get { return teacher_gender; }
            set { teacher_gender = value; }
        }

        private int imt_id;

        public int Imt_id
        {
            get { return imt_id; }
            set { imt_id = value; }
        }
        private int imdt_id;

        public int Imdt_id
        {
            get { return imdt_id; }
            set { imdt_id = value; }
        }
        private int imht_id;

        public int Imht_id
        {
            get { return imht_id; }
            set { imht_id = value; }
        }
        private int imhdt_id;

        public int Imhdt_id
        {
            get { return imhdt_id; }
            set { imhdt_id = value; }
        }

        private DateTime tnow;

        public DateTime Tnow
        {
            get { return tnow; }
            set { tnow = value; }
        }

        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private string tbarcode;

        public string Tbarcode
        {
            get { return tbarcode; }
            set { tbarcode = value; }
        }
        private string sbarcode;

        public string Sbarcode
        {
            get { return sbarcode; }
            set { sbarcode = value; }
        }

        private double penalty;

        public double Penalty
        {
            get { return penalty; }
            set { penalty = value; }
        }
        private int book_student;

        public int Book_student
        {
            get { return book_student; }
            set { book_student = value; }
        }
        private int book_teacher;

        public int Book_teacher
        {
            get { return book_teacher; }
            set { book_teacher = value; }
        }


        private int subject_assigned;

        public int Subject_assigned
        {
            get { return subject_assigned; }
            set { subject_assigned = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string batch;

        public string Batch
        {
            get { return batch; }
            set { batch = value; }
        }
        private int student_semester;

        public int Student_semester
        {
            get { return student_semester; }
            set { student_semester = value; }
        }
        private int SM_ID;

        public int SM_ID1
        {
            get { return SM_ID; }
            set { SM_ID = value; }
        }
        private int SD_ID;

        public int SD_ID1
        {
            get { return SD_ID; }
            set { SD_ID = value; }
        }

        private int from_month;

        public int From_month
        {
            get { return from_month; }
            set { from_month = value; }
        }
        private int to_month;

        public int To_month
        {
            get { return to_month; }
            set { to_month = value; }
        }
       
    }
}