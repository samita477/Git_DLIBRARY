using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DIGITALLIBRARY_BUSINESS_FRAMEWORK.DL;


namespace DIGITALLIBRARY.DL
{
    public partial class sample_roll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
//        string roll;
//        int roll1;
//        int batch;
//        int faculty;
//        int rollno;

       
//        string roll2;
//        string batch2;
//        string faculty2;
//        string rollno2;
//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            roll = TextBox1.Text;
//            int len = roll.Length;
//            batch2 = roll.Substring(0,3);
//            faculty2 = roll.Substring(3,1);
//            rollno2 = roll.Substring(4, 2);

//            TextBox3.Text = batch2;
//            TextBox4.Text = faculty2;
//            TextBox5.Text = rollno2;
            
//        }

//        public void flag()
//        {
//            roll = TextBox1.Text;
//            roll1 = Convert.ToInt32(roll);
//            int b = roll1.ToString().Length;
//            int flag = 0;
//            int a = roll1;
//            for (int i = b - 1; i > 0; i--)
//            {
//                double c = roll1 / (Math.Pow(10, i - 1));
//                int cc = Convert.ToInt32(c);
//                if (cc > c)
//                    cc = cc - 1;

//                flag = flag * 10 + cc;
//                if (i == 1)
//                {
//                    rollno = flag % 100;

//                }

//                else if (i == 3)
//                    faculty = flag % 10;
//                else if (i == 4)
//                    batch = flag;

//                double aa = roll1 % (Math.Pow(10, i - 1));
//                roll1 = Convert.ToInt32(aa);
//                if (roll1 > aa)
//                    roll1 = roll1 - 1;


//            }

//            TextBox3.Text = batch.ToString();
//            TextBox4.Text = faculty.ToString();
//            TextBox5.Text = rollno.ToString();
//        }

    }
}