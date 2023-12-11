using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinhvien
{
    class LopDungChung
    {
        string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Ktra\Sinhvien\Sinhvien\Sinhvien\sinhvien.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(ketnoi);
        }
        public void Noquery(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1) MessageBox.Show(" Thành công");
                else MessageBox.Show("Lỗi try");

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi catch...");
            }
            conn.Close();
        }

       public object Scalar (string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
        public DataTable loadData(string sqlloadData)
        {
           
            SqlDataAdapter da = new SqlDataAdapter(sqlloadData, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;  
        }
    }
}
