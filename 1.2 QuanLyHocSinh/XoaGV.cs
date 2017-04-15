using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_QuanLyHocSinh
{
    class XoaGV
    {
        public void action_XoaGV(frmMain frm)
        {
        try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();
                string sql = @"update tblLopMonHoc set MaGiaoVien=null where MaGiaoVien= " + frm.txtMaGVGV.Text+
                "delete tblGiaoVien where MaGiaovien=" + frm.txtMaGVGV.Text;
                try
                {
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối");
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chưa xóa được");
            }
            frm.getData("");
        }
    }
}
