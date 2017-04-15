using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_QuanLyHocSinh
{
    class TimKiemLMH
    {
        public void action_TimKiemLHP(frmMain frm)
        {
            string sl = "";
            try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();

                if (frm.txtMaLopHocLH.Text != "")
                {
                    sl = sl + " and lmh.MaLopMH = " + frm.txtMaLopHocLH.Text;
                }
                if (frm.cbLop.Checked == true)
                {
                    sl = sl + " and l.TenLop=" + frm.cbbLopLH.SelectedValue.ToString();
                }
                if (frm.cbMonHoc.Checked == true)
                {
                    sl = sl + " and mh.TenMonHoc= " + frm.cbbMon.SelectedValue.ToString();
                }

                if (frm.cbGV.Checked == true)
                {
                    sl = sl + " and gv.TenGiaovien = " + frm.cbbGiaoVienLH.SelectedValue.ToString();
                }
                if (frm.txtLichHocLH.Text != "")
                {
                    sl = sl + " and lmh.LichHoc = '" + frm.txtLichHocLH.Text + "'";
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
