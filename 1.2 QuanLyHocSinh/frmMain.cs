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
    public partial class frmMain : Form
    {
        private int action;
        public frmMain()
        {
            InitializeComponent();
        }

        public void getData(string select)
        {
            string sql = "";
            try
            {
                SqlConnection kn = new SqlConnection(globalParemeter.connectionString);
                kn.Open();
                SqlCommand command = new SqlCommand();
                SqlDataAdapter com = new SqlDataAdapter();
                if (action == 1)
                {
                    sql = @"select MaHocSinh,TenHocSinh,GT,NgaySinh,QueQuan,DanToc,TenLop,l.MaLop 
                                from tblHocSinh hs left join tblLop l on hs.MaLop = l.MaLop where hs.MaHocSinh=hs.MaHocSinh";
                    sql = sql + select;
                    dgvThongTin.Columns.Clear();
                    dgvThongTin.AutoGenerateColumns = false;
                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "MaHocSinh";
                    column.HeaderText = "Mã HS";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenHocSinh";
                    column.HeaderText = "Tên HS";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "GT";
                    column.HeaderText = "Giới Tính";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "NgaySinh";
                    column.HeaderText = "Ngày Sinh";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "QueQuan";
                    column.HeaderText = "Quê Quán";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "DanToc";
                    column.HeaderText = "Dân Tộc";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenLop";
                    column.HeaderText = "Tên Lớp";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();
                }
                else if (action == 2)
                {
                    sql = @"select gv.MaGiaovien,TenGiaovien,SoDienthoai,DiaChiEmail,TenLop,MaLop 
                                from tblGiaoVien gv left join tblLop l on gv.MaGiaovien = l.MaGiaoVien where gv.MaGiaoVien=gv.MaGiaoVien";
                    sql = sql + select;
                    dgvThongTin.Columns.Clear();
                    dgvThongTin.AutoGenerateColumns = false;
                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "MaGiaovien";
                    column.HeaderText = "Mã GV";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenGiaovien";
                    column.HeaderText = "Tên GV";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "SoDienthoai";
                    column.HeaderText = "Số ĐT";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "DiaChiEmail";
                    column.HeaderText = "Email";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenLop";
                    column.HeaderText = "Lớp Chủ Nhiệm";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();
                }
                else if (action == 3)
                {
                    sql = @"select MaLopMH,TenLopMH,LichHoc,TenMonHoc,TenLop,TenGiaoVien 
                                from tblLopMonHoc lmh left join  tblMonHoc mh on lmh.MaMonHoc = mh.MaMonhoc 
                                    left join tblLop l on lmh.MaLop = l.MaLop 
                                        left join tblGiaoVien gv on lmh.MaGiaoVien = gv.MaGiaovien where lmh.MaMonHoc=lmh.MaMonHoc";
                    sql = sql + select;
                    dgvThongTin.Columns.Clear();
                    dgvThongTin.AutoGenerateColumns = false;
                    DataGridViewColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "MaLopMH";
                    column.HeaderText = "Mã Lớp MH";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenLopMH";
                    column.HeaderText = "Tên LMH";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "LichHoc";
                    column.HeaderText = "Lịch Học";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenMonHoc";
                    column.HeaderText = "Tên MH";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenLop";
                    column.HeaderText = "Tên Lớp";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();

                    column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = "TenGiaoVien";
                    column.HeaderText = "Giáo Viên";
                    dgvThongTin.Columns.Add(column);
                    column = new DataGridViewColumn();
                }
                command = new SqlCommand(sql, kn);
                com = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                com.Fill(dt);
                dgvThongTin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu");
                MessageBox.Show(sql);
            }
            finally
            {
                SqlConnection con = new SqlConnection();
                con.Close();
            }
        }
        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            action = 1;
            action_HocSinh();
            getData("");
            try
            {

                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();

                string sql = "select MaLop,TenLop from tblLop";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter com = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                com.Fill(dt);
                cbbMaLopHS.DataSource = dt;
                cbbMaLopHS.DisplayMember = dt.Columns["TenLop"].ToString();
                cbbMaLopHS.ValueMember = dt.Columns["MaLop"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu");
            }
            finally
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Close();
            }
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            action = 2;
            action_GiaoVien();
            getData("");
        }

        private void btnLichHoc_Click(object sender, EventArgs e)
        {
            action = 3;
            action_LichHoc();
            getData("");
            try
            {

                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Open();

                string sql = "select MaLop,TenLop from tblLop";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataAdapter com = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                com.Fill(dt);
                cbbLopLH.DataSource = dt;
                cbbLopLH.DisplayMember = dt.Columns["TenLop"].ToString();
                cbbLopLH.ValueMember = dt.Columns["MaLop"].ToString();

                sql = "select MaGiaovien,TenGiaovien from tblGiaoVien";
                command = new SqlCommand(sql, con);
                com = new SqlDataAdapter(command);
                dt = new DataTable();
                com.Fill(dt);
                cbbGiaoVienLH.DataSource = dt;
                cbbGiaoVienLH.DisplayMember = dt.Columns["TenGiaovien"].ToString();
                cbbGiaoVienLH.ValueMember = dt.Columns["MaGiaovien"].ToString();

                sql = "select MaMonhoc,TenMonhoc from tblMonHoc";
                command = new SqlCommand(sql, con);
                com = new SqlDataAdapter(command);
                dt = new DataTable();
                com.Fill(dt);
                cbbMon.DataSource = dt;
                cbbMon.DisplayMember = dt.Columns["TenMonHoc"].ToString();
                cbbMon.ValueMember = dt.Columns["MaMonhoc"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu");
            }
            finally
            {
                SqlConnection con = new SqlConnection(globalParemeter.connectionString);
                con.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (action == 1)
            {
                ThemHS hs = new ThemHS();
                hs.action_ThemHS(this);
            }
            else if (action == 2)
            {
                ThemGV gv = new ThemGV();
                gv.action_ThemGV(this);
            }
            else if (action == 3)
            {
                ThemLMH lhp = new ThemLMH();
                lhp.action_ThemLMH(this);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (action == 1)
            {
                SuaHS hs = new SuaHS();
                hs.action_SuaHS(this);
            }
            else if (action == 2)
            {
                SuaGV gv = new SuaGV();
                gv.action_SuaGV(this);
            }
            else if (action == 3)
            {
                SuaLMH lhp = new SuaLMH();
                lhp.action_SuaLMH(this);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (action == 1)
            {
                XoaHS hs = new XoaHS();
                hs.action_XoaHS(this);
            }
            else if (action == 2)
            {
                XoaGV gv = new XoaGV();
                gv.action_XoaGV(this);
            }
            else if (action == 3)
            {
                XoaLMH lhp = new XoaLMH();
                lhp.action_XoaHS(this);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (action == 1)
            {
                TimKiemHS hs = new TimKiemHS();
                hs.action_TimKiemHS(this);
            }
            else if (action == 2)
            {
                TimKiemGV gv = new TimKiemGV();
                gv.action_TimKiemGV(this);
            }
            else if (action == 3)
            {
                TimKiemLMH lhp = new TimKiemLMH();
                lhp.action_TimKiemLHP(this);
            }
        }
        private void action_XoaThietLap()
        {

            txtEmailGV.Text = "";
            txtTenGVGV.Text = "";
            txtSoDTGV.Text = "";
            txtMaGVGV.Text = "";
            cbMonHoc.Checked = false;
            cbGV.Checked = false;
            txtLichHocLH.Text = "";
            cbLop.Checked = false;
            txtTenNVLH.Text = "";
            txtMaLopHocLH.Text = "";
            cbMaLopHS.Checked = false;
            cbGioiTinhHS.Checked = false;
            cbNgaySinhHS.Checked = false;
            txtTenHSHS.Text = "";
            txtDanTocHS.Text = "";
            txtQueQuanHS.Text = "";
            txtMaHSHS.Text = "";
            rbtnNuHS.Checked = false;
            rbtnNamHS.Checked = true;
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (action == 1)
            {
                txtMaHSHS.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
                txtTenHSHS.Text = dgvThongTin.CurrentRow.Cells[1].Value.ToString();
                if (dgvThongTin.CurrentRow.Cells[2].Value.ToString() == "Nam")
                {
                    cbGioiTinhHS.Checked = true;
                    rbtnNamHS.Checked = true;
                }
                else if (dgvThongTin.CurrentRow.Cells[2].Value.ToString() == "Nu")
                {
                    cbGioiTinhHS.Checked = true;
                    rbtnNuHS.Checked = true;
                }
                else
                {
                    cbGioiTinhHS.Checked = false;
                }
                
                if (dgvThongTin.CurrentRow.Cells[3].Value.ToString()!="")
                {
                    cbNgaySinhHS.Checked = true;
                    dtpNgaySinhHS.Text = dgvThongTin.CurrentRow.Cells[3].Value.ToString();
                    
                }
                else
                {
                    cbNgaySinhHS.Checked = false;
                }
                txtQueQuanHS.Text = dgvThongTin.CurrentRow.Cells[4].Value.ToString();
                txtDanTocHS.Text = dgvThongTin.CurrentRow.Cells[5].Value.ToString();
                if (dgvThongTin.CurrentRow.Cells[6].Value.ToString() != "")
                {
                    cbMaLopHS.Checked = true;
                    cbbMaLopHS.Text = dgvThongTin.CurrentRow.Cells[6].Value.ToString();
                }
                else
                {
                    cbMaLopHS.Checked = false;
                }
            }
            else if(action==2)
            {
                txtMaGVGV.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
                txtTenGVGV.Text= dgvThongTin.CurrentRow.Cells[1].Value.ToString();
                txtSoDTGV.Text= dgvThongTin.CurrentRow.Cells[2].Value.ToString();
                txtEmailGV.Text = dgvThongTin.CurrentRow.Cells[3].Value.ToString();
            }
            else if(action==3)
            {
                txtMaLopHocLH.Text = dgvThongTin.CurrentRow.Cells[0].Value.ToString();
                txtTenNVLH.Text = dgvThongTin.CurrentRow.Cells[1].Value.ToString();
                txtLichHocLH.Text = dgvThongTin.CurrentRow.Cells[2].Value.ToString();
                cbbLopLH.Text = dgvThongTin.CurrentRow.Cells[3].Value.ToString();
                cbbMon.Text = dgvThongTin.CurrentRow.Cells[4].Value.ToString();
                cbbGiaoVienLH.Text = dgvThongTin.CurrentRow.Cells[5].Value.ToString();
            }

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnHocSinh_Click(this, e);
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
