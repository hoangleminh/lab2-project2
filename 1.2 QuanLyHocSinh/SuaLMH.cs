using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_QuanLyHocSinh
{
    class SuaLMH
    {
        public void action_SuaLMH(frmMain frm)
        {
            if (frm.txtMaLopHocLH.Text == "" || frm.txtLichHocLH.Text == "" || frm.txtTenNVLH.Text == "" || frm.cbbGiaoVienLH.Text == "" || frm.cbbLopLH.Text == "" || frm.cbbMon.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();
                string lop = "";
                string mon = "";
                string gv = "";
                if (frm.cbLop.Checked == true)
                {
                    lop = frm.cbbLopLH.SelectedValue.ToString();
                }
                if (frm.cbMonHoc.Checked == true)
                {
                    mon = frm.cbbMon.SelectedValue.ToString();
                }
                if (frm.cbGV.Checked == true)
                {
                    gv = frm.cbbGiaoVienLH.SelectedValue.ToString();
                }

                string sql = @"update tblLopMonHoc set TenLopMH='" + frm.txtTenNVLH.Text + "',LichHoc='" + frm.txtLichHocLH.Text + "',MaMonHoc='" + mon + "',MaLop='" + lop + "',MaGiaoVien='" + gv + "' where MaLopMH=" + frm.txtMaLopHocLH.Text;
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
