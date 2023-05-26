using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmMain : Form
    {
        public static string userName = "";
        private string quyen;
        public frmMain(string q)
        {
            quyen = q;
            InitializeComponent();
        }
        public frmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            TrangChu aa = new TrangChu();
            addPanel(aa);
            label1.Text = "xin chào " + userName + ", bạn đang đăng nhập với tư cách " + quyen;
            if (quyen == "Admin")
            {
                resetAd();
            }
            else
            {
                resetND();
            }
        }
        private void resetND()
        {
            menuItem5.Enabled = false;//Quản lý tài khoản
            menuItem7.Enabled = false;//nhân sự
            menuItem8.Enabled = false;//thông tin cn
            menuItem9.Enabled = false;//chế độ
            menuItem10.Enabled = false;//hồ sơ thử việc
            menuItem12.Enabled = false;//Báo cáo

            menuItem15.Enabled = false;//Phòng ban
            menuItem16.Enabled = false;//Bộ phận
            menuItem17.Enabled = false;//Lương nhân viên
            menuItem18.Enabled = false;//Bảng lương
        }
        private void resetAd()
        {
            menuItem5.Enabled = true;//Quản lý tài khoản
            menuItem7.Enabled = true;//nhân sự
            menuItem8.Enabled = true;//thông tin cn
            menuItem9.Enabled = true;//chế độ
            menuItem10.Enabled = true;//hồ sơ thử việc
            menuItem12.Enabled = true;//Báo cáo

            menuItem15.Enabled = true;//Phòng ban
            menuItem16.Enabled = true;//Bộ phận
            menuItem17.Enabled = true;//Lương nhân viên
            menuItem18.Enabled = true;//Bảng lương
        }
        private void menuItemdmk_Click_1(object sender, EventArgs e)
        {
            frmDoiMatKhau fdm = new frmDoiMatKhau();
            addPanel(fdm);

        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            frmCoBan fc = new frmCoBan();
            addPanel(fc);

        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan ft = new frmThongTinCaNhan();

            addPanel(ft);
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            frmDangKy b = new frmDangKy();
            addPanel(b);
        }



        private void menuItemdmk_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau b = new frmDoiMatKhau();
            addPanel(b);
        }

        private void menuItem9_Click_1(object sender, EventArgs e)
        {
            frmCheDo fcd = new frmCheDo();
            addPanel(fcd);
        }

        private void menuItem10_Click_1(object sender, EventArgs e)
        {
            frmHoSoThuViec bag = new frmHoSoThuViec();
            addPanel(bag);
        }
        private void menuItem11_Click_1(object sender, EventArgs e)
        {
            frmTimKiem ftk = new frmTimKiem();
            addPanel(ftk);
        }
        private void menuItem13_Click_1(object sender, EventArgs e)
        {
            frmTroGiup x = new frmTroGiup();
            addPanel(x);
        }

        private void menuItem15_Click_1(object sender, EventArgs e)
        {
            frmPhongBan fpb = new frmPhongBan();
            addPanel(fpb);
        }

        private void menuItem16_Click_1(object sender, EventArgs e)
        {
            frmBoPhan frb = new frmBoPhan();
            addPanel(frb);
        }

        private void menuItem17_Click_1(object sender, EventArgs e)
        {
            frmBangCong fhtv = new frmBangCong();
            addPanel(fhtv);


        }

        private void menuItem18_Click_1(object sender, EventArgs e)
        {
            frmLuong aa = new frmLuong();
            addPanel(aa);
        }
        public void addPanel(Form aa)
        {
            panel_show.Show();
            panel_show.Controls.Clear();
            aa.TopLevel = false;
            aa.Dock = DockStyle.Fill;
            aa.FormBorderStyle = FormBorderStyle.None;
            aa.AutoScroll = true;
            panel_show.Controls.Add(aa);
            aa.Show();

        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            BCNhanVien aa = new BCNhanVien();
            addPanel(aa);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất không ? ", "TB", MessageBoxButtons.YesNo,
   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmDangNhap dn = new frmDangNhap();
                this.Hide();
                dn.ShowDialog();
            }
        }


        private void tcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TrangChu aa = new TrangChu();
            addPanel(aa);
        }
    }
}
