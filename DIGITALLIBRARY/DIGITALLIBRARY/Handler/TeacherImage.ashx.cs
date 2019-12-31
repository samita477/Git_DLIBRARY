using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DIGITALLIBRARY.Handler
{
    /// <summary>
    /// Summary description for TeacherImage
    /// </summary>
    public class TeacherImage : IHttpHandler
    {
        Int64 Teacher_ID;
        public void ProcessRequest(HttpContext context)
        {

            //if (context.Request.QueryString["Branch_Id"] != null)
            //    Branch_Id = Convert.ToInt64((context.Request.QueryString["Branch_Id"]).ToString());
            if (context.Request.QueryString["Teacher_ID"] != null)
                Teacher_ID = Convert.ToInt64((context.Request.QueryString["Teacher_ID"]).ToString());
            else
                throw new ArgumentException("No parameter specified");
            Stream strm = ShowNepaliCitizens(Teacher_ID);
            if (strm != null)
            {
                byte[] buffer = new byte[4096];
                int byteSeq = strm.Read(buffer, 0, 4096);

                while (byteSeq > 0)
                {
                    context.Response.OutputStream.Write(buffer, 0, byteSeq);
                    byteSeq = strm.Read(buffer, 0, 4096);
                }
            }
        }
        public Stream ShowNepaliCitizens(Int64 Teacher_ID)
        {
            SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ToString());
            string SqlQuery = " SELECT image_URL FROM teacher where Teacher_ID= @Teacher_ID";
            SqlCommand cmd = new SqlCommand(SqlQuery, Con);
            cmd.CommandType = CommandType.Text;
            // cmd.Parameters.AddWithValue("@Branch_Id", Branch_Id);
            cmd.Parameters.AddWithValue("@Teacher_ID", Teacher_ID);
            Con.Open();
            object img = cmd.ExecuteScalar();

            try
            {
                if (img != "")
                    return new MemoryStream((byte[])img);
                else
                    return null;
            }
            catch
            {
                return null;
            }
            finally
            {
                Con.Close();
            }
        }
     

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}