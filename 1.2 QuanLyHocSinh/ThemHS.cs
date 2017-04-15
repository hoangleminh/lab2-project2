using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1._2_QuanLyHocSinh
{
    class ThemHS
    {
         public void action_ThemHS(frmMain frm)
        {
            if (frm.txtMaHSHS.Text == "" || frm.txtTenHSHS.Text == "" || frm.txtDanTocHS.Text == "" || frm.txtQueQuanHS.Text == "" || (frm.rbtnNamHS.Checked == false && frm.rbtnNuHS.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();
                string gt = "";
                string ml = "null";
                string ns = "";
                if (frm.cbGioiTinhHS.Checked == true)
                {
                    if (frm.rbtnNamHS.Checked) gt = "Nam";
                    else if (frm.rbtnNuHS.Checked) gt = "Nu";
                }
                if (frm.cbMaLopHS.Checked == true)
                {
                    ml = frm.cbbMaLopHS.SelectedValue.ToString();
                }
                if (frm.cbNgaySinhHS.Checked == true)
                {
                    ns = frm.dtpNgaySinhHS.Value.ToString("MM/dd/yyyy");
                }

                string sql = @"insert into tblHocSinh(MaHocSinh,TenHocSinh,GT,NgaySinh,QueQuan,DanToc,MaLop) values ('" + frm.txtMaHSHS.Text + "','" + frm.txtTenHSHS.Text + "','" + gt + "','" + ns + "','" + frm.txtQueQuanHS.Text + "','" + frm.txtDanTocHS.Text + "','" + ml + "')";
                    
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
