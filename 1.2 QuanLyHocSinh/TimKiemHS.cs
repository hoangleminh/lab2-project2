using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_QuanLyHocSinh
{
    class TimKiemHS
    {
        public void action_TimKiemHS(frmMain frm)
        {
            string sl = "";
            try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();
                string gt = "";
                if (frm.txtMaHSHS.Text != "")
                {
                    sl = sl + " and hs.MaHocSinh = " + frm.txtMaHSHS.Text;
                }
                if (frm.cbGioiTinhHS.Checked == true)
                {
                    if (frm.rbtnNamHS.Checked) gt = "Nam";
                    else if (frm.rbtnNuHS.Checked) gt = "Nu";
                    sl = sl + " and GT = '" + gt + "'";
                }
                if (frm.cbMaLopHS.Checked == true)
                {
                    sl = sl + " and l.MaLop=" + frm.cbbMaLopHS.SelectedValue.ToString();
                }
                if (frm.cbNgaySinhHS.Checked == true)
                {
                    sl = sl + " and hs.NgaySinh= '" + frm.dtpNgaySinhHS.Value.ToString("MM/dd/yyyy") + "'";
                }

                if (frm.txtTenHSHS.Text != "")
                {
                    sl = sl + " and hs.TenHocSinh = '" + frm.txtTenHSHS.Text + "'";
                }
                if (frm.txtQueQuanHS.Text != "")
                {
                    sl = sl + " and hs.QueQuan = '" + frm.txtQueQuanHS.Text + "'";
                }
                if (frm.txtDanTocHS.Text != "")
                {
                    sl = sl + " and hs.DanToc = '" + frm.txtDanTocHS.Text + "'";
                }
                frm.getData(sl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chưa tìm được!!!");
            }
            finally
            {

                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Close();
            }
        }
    }
}
