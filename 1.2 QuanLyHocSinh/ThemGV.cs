using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1._2_QuanLyHocSinh
{
    class ThemGV
    {
        public void action_ThemGV(frmMain frm)
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

                string sql = @"insert into tblGiaoVien(MaGiaovien,TenGiaovien,SoDienthoai,DiaChiEmail) values ('" + frm.txtMaGVGV.Text + "','" + frm.txtTenGVGV.Text + "','" + frm.txtSoDTGV.Text + "','" + frm.txtEmailGV.Text + "')";
                   
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
                MessageBox.Show("Lỗi chưa Thêm được");
            }
            frm.getData("");
        }

    }

}
