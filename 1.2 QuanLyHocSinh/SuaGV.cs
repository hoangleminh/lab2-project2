using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_QuanLyHocSinh
{
    class SuaGV
    {
        public void action_SuaGV(frmMain frm)
        {
            if (frm.txtMaGVGV.Text == "" || frm.txtTenGVGV.Text == "" || frm.txtEmailGV.Text == "" || frm.txtSoDTGV.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();

                string sql = @"update tblGiaoVien set TenGiaovien='" + frm.txtTenGVGV.Text + "',SoDienthoai='" + frm.txtSoDTGV.Text + "',DiaChiEmail='" + frm.txtEmailGV.Text + "' where MaGiaovien=" + frm.txtMaGVGV.Text;

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
                MessageBox.Show("Lỗi chưa sửa được");
            }
            frm.getData("");
        }
    }
}
