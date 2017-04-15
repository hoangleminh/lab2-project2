using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1._2_QuanLyHocSinh
{
    class ThemLMH
    {
        public void action_ThemLMH(frmMain frm)
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

                string sql = @"insert into tblLopMonHoc(MaLopMH,TenLopMH,LichHoc,MaMonHoc,MaLop,MaGiaoVien) values ('" + frm.txtMaLopHocLH.Text + "','" + frm.txtTenNVLH.Text + "','" + frm.txtLichHocLH.Text + "','" + mon + "','" + lop + "','" + gv + "')";
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

