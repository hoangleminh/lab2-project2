using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_QuanLyHocSinh
{
    class TimKiemGV
    {
        public void action_TimKiemGV(frmMain frm)
        {
            string sl = "";
            try
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();

                if (frm.txtMaGVGV.Text != "")
                {
                    sl = sl + " and gv.MaGiaoVien = " + frm.txtMaGVGV.Text;
                }

                if (frm.txtTenGVGV.Text != "")
                {
                    sl = sl + " and gv.TenGiaovien = '" + frm.txtTenGVGV.Text + "'";
                }
                if (frm.txtSoDTGV.Text != "")
                {
                    sl = sl + " and gv.SoDienthoai = '" + frm.txtSoDTGV.Text + "'";
                }
                if (frm.txtEmailGV.Text != "")
                {
                    sl = sl + " and gv.DiaChiEmail = '" + frm.txtEmailGV.Text + "'";
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
