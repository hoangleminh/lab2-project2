using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._2_QuanLyHocSinh
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(globalParemeter.connectionString);
        }
        //ham kiem tra ket noi
        public DataTable checkLog(string user, string pass)
        {
            string sql = "select * from tblDangNhap where TaiKhoan= '" + user + "'and MatKhau = '" + pass + "'";
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
            //ket qua truy van tra ve 1 bang
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtTaiKhoan.TextLength == 0 || this.txtMatKhau.TextLength == 0)
            {
                MessageBox.Show("Vui long dien tai khan va mat khau");
            }
            else

            {
                DataTable dt = new DataTable();
                dt = checkLog(txtTaiKhoan.Text, txtMatKhau.Text);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Dang nhap khong thanh cong");
                    this.txtTaiKhoan.Clear();
                    this.txtMatKhau.Clear();
                    this.txtTaiKhoan.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
    }
}
