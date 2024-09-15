using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
    public class SQLConnectionData
    {
        // tạo singleton parttern 
        private static SQLConnectionData instance;
        public static SQLConnectionData Instance
        {
            get { if (instance == null)
                {
                    instance = new SQLConnectionData();
                }    
                return instance; }
        }
        public SQLConnectionData() { }

        // tạo chuỗi kết nói 
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=LAPTOP-JRRAO9EA\\DOHUY;Initial Catalog=Animal;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(strcon); // khởi tạo kết nối 
            return con;
        }

        // Hàm ExecuteQuery trả về số lượng dòng bị ảnh hưởng (kiểu int)
        public int ExecuteQuery(string query)
        {
            using (SqlConnection con = Connect())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int result = cmd.ExecuteNonQuery(); // Số dòng bị ảnh hưởng
                con.Close();
                return result;
            }
        }

        // Hàm thực hiện truy vấn thêm dữ liệu vào cơ sở dữ liệu
        public int InsertData(string query)
        {
            try
            {
                return ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1; // Trả về -1 nếu có lỗi
            }
        }

        // Hàm thực hiện truy vấn xóa dữ liệu trong cơ sở dữ liệu
        public int DeleteData(string query)
        {
            try
            {
                return ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1; // Trả về -1 nếu có lỗi
            }
        }
    }

}
