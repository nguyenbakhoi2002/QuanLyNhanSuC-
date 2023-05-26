using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace BTL
{
    public partial class frmBangCong : Form
    {
        Classes.ConnectData dt = new Classes.ConnectData();
        Classes.CommonFunctions functions = new Classes.CommonFunctions();

        public frmBangCong()
        {
            InitializeComponent();
        }

        private void frmBangCong_Load(object sender, EventArgs e)
        {

            //dgv.Columns[0].HeaderText = "Tên bộ phận";
            //dgv.Columns[1].HeaderText = "Tên phòng";
            //dgv.Columns[2].HeaderText = "Mã NVTV";
            //dgv.Columns[3].HeaderText = "Lương TV";
            //dgv.Columns[4].HeaderText = "Tháng";
            //dgv.Columns[5].HeaderText = "Năm";
            //dgv.Columns[6].HeaderText = "Số Ngày công";
            //dgv.Columns[7].HeaderText = "Số ngày nghỉ";
            //dgv.Columns[8].HeaderText = "Số giờ làm thêm";
            //dgv.Columns[9].HeaderText = "Lương";
            //dgv.Columns[10].HeaderText = "Ghi chú";

            dgv.DataSource = dt.DataReader(" select * from TblBangCongThuViec ");
            // Load cbbMaNV ở bảng thử việc
            System.Data.DataTable tblBangCongTV = dt.DataReader("select * from TblHoSoThuViec");
            functions.FillComboBox(cbbMaNV, tblBangCongTV, "MaNVTV", "MaNVTV");

            // Load cbbMaNV ở bảng NVCT
            System.Data.DataTable tblBangCongNVCT = dt.DataReader("select * from TblCongKhoiDieuHanh");
            functions.FillComboBox(cbbMaNVCT, tblBangCongNVCT, "MaNV", "MaNV");

            // load cbbTenPhong ở bảng NVCT
            System.Data.DataTable tblBangCongTPNVCT = dt.DataReader("select DISTINCT (TenPhong) from TblCongKhoiDieuHanh");
            functions.FillComboBox(cbbTenPhong, tblBangCongTPNVCT, "TenPhong", "TenPhong");

            // load dữ liệu dgv1
            dgv1.DataSource = dt.DataReader(" select * from  TblCongKhoiDieuHanh ");

            // ẩn nút sửa và xóa
            btnSuaNVCT.Enabled = false;
            btnXoaNVCT.Enabled = false;
        }

        private void btnThoatTV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không ạ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMoiTV_Click(object sender, EventArgs e)
        {
            txtTenBP.Text = "";
            txtTenPhong.Text = "";
            cbbMaNV.Text = "";
            txtThang.Text = "";
            txtNam.Text = "";
            txtLuongTV.Text = "";
            txtGioLamThem.Text = "";
            txtNgayCong.Text = "";
            txtNgayNghi.Text = "";
            txtLuong.Text = "";
            txtGhiChu.Text = "";
            btnMoiTV.Enabled = true;
            btnXoaTV.Enabled = false;
            btnSuaTV.Enabled = false;
            btnThemTV.Enabled = true;
        }

        private void btnThemTV_Click(object sender, EventArgs e)
        {
            // kiểm tra tên bộ phận có để trống không
            if (txtTenBP.Text.Trim() == "")
            {
                er.SetError(txtTenBP, "Vui lòng không để tên bộ phận trống !");
                MessageBox.Show("Vui lòng không để tên bộ phận trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBP.Focus();
                return;
            }
            else
            {
                er.Clear();
            }
            // Kiểm tra tên phòng có để trống không
            if (txtTenPhong.Text.Trim() == "")
            {
                er.SetError(txtTenPhong, "Vui lòng không để tên phòng trống !");
                txtTenPhong.Focus();
                MessageBox.Show("Vui lòng không để tên phòng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                er.Clear();
            }

            // Kiểm tra tháng có để trống không
            if (txtThang.Text.Trim() == "")
            {
                er.SetError(txtThang, "Vui lòng không để tháng trống !");
                MessageBox.Show("Vui lòng không để tháng trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThang.Focus();
                return;
            }
            else
            {
                er.Clear();
            }
            // Kiểm tra năm có để trống không
            if (txtNam.Text.Trim() == "")
            {
                er.SetError(txtNam, "Vui lòng không để năm trống !");
                MessageBox.Show("Vui lòng không để năm trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNam.Focus();
                return;
            }
            else
            {
                er.Clear();
            }
            // Kiểm tra lương thử việc có để trống không
            if (txtLuongTV.Text.Trim() == "")
            {
                er.SetError(txtLuongTV, "Vui lòng không để lương thử việc trống !");
                MessageBox.Show("Vui lòng không để lương thử việc trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongTV.Focus();
                return;
            }
            else
            {
                er.Clear();
            }
            // Kiểm tra số giờ làm thêm có để trống không
            if (txtGioLamThem.Text.Trim() == "")
            {
                er.SetError(txtGioLamThem, "Vui lòng không để số giờ làm thêm trống !");
                MessageBox.Show("Vui lòng không để số giờ làm thêm trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioLamThem.Focus();
                return;
            }
            else
            {
                er.Clear();
            }
            // Kiểm tra số số ngày công có để trống không
            if (txtNgayCong.Text.Trim() == "")
            {
                er.SetError(txtGioLamThem, "Vui lòng không để số ngày công trống !");
                MessageBox.Show("Vui lòng không để  số ngày công trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayCong.Focus();
                return;
            }
            else
            {
                er.Clear();
            }
            // Kiểm tra số số ngày nghỉ có để trống không
            if (txtNgayNghi.Text.Trim() == "")
            {
                er.SetError(txtNgayNghi, "Vui lòng không để số ngày nghỉ trống !");
                MessageBox.Show("Vui lòng không để  số ngày nghỉ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayNghi.Focus();
                return;
            }
            else
            {
                er.Clear();
            }
            // Kiểm tra lương có để trống không
            if (txtLuong.Text.Trim() == "")
            {
                er.SetError(txtLuong, "Vui lòng không để số ngày nghỉ trống !");
                MessageBox.Show("Vui lòng không để  số ngày nghỉ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuong.Focus();
                return;
            }
            else
            {
                er.Clear();
            }
            // kiểm tra tên nhân viên có bị trùng trước đó không
            System.Data.DataTable dtCheckMaNV = dt.DataReader("select * from TblBangCongThuViec where MaNVTV = '" + cbbMaNV.SelectedValue + "'");
            if (dtCheckMaNV.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã có , bạn vui lòng chọn mã nhân viên khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Thêm thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaNV.Focus();
                return;
            }

            // Thêm mới thử việc
            string sqlInsert = "insert into TblBangCongThuViec values(N'" + txtTenBP.Text + "' , N'" + txtTenPhong.Text + "', N'" + cbbMaNV.SelectedValue + "', N'" + txtLuongTV.Text + "', N'" + txtThang.Text + "', N'" + txtNam.Text + "' , N'" + txtNgayCong.Text + "' , N'" + txtNgayNghi.Text + "' , N'" + txtGioLamThem.Text + "' ,   N'" + txtLuong.Text + "' , N'" + txtGhiChu.Text + "' )";

            dt.DataChange(sqlInsert);
            dgv.DataSource = dt.DataReader("select * from TblBangCongThuViec");
            MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSuaTV.Enabled = true;
            btnXoaTV.Enabled = true;

        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLuongTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGioLamThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNgayCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNgayNghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTenBP.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txtTenPhong.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                cbbMaNV.SelectedValue = dgv.CurrentRow.Cells[2].Value.ToString();
                txtLuongTV.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txtThang.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                txtNam.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                txtNgayCong.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                txtNgayNghi.Text = dgv.CurrentRow.Cells[7].Value.ToString();
                txtGioLamThem.Text = dgv.CurrentRow.Cells[8].Value.ToString();
                txtLuong.Text = dgv.CurrentRow.Cells[9].Value.ToString();
                txtGhiChu.Text = dgv.CurrentRow.Cells[10].Value.ToString();
                btnSuaTV.Enabled = true;
                btnThemTV.Enabled = false;
                btnXoaTV.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
                
        private void btnSuaTV_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblBangCongThuViec set TenBoPhan=N'" + txtTenBP.Text + "',TenPhong=N'" + txtTenPhong.Text + "',LuongTViec=N'" + txtLuongTV.Text + "',Thang=N'" + txtThang.Text + "',Nam='" + txtThang.Text + "',SoNgayCong=N'" + txtNgayCong.Text + "',SoNgayNghi=N'" + txtNgayNghi.Text + "',SoGioLamThem=N'" + txtGioLamThem.Text + "',Luong=N'" + txtLuong.Text + "',GhiChu='" + txtGhiChu.Text + "' where MaNVTV=N'" + cbbMaNV.Text + "'";
                dt.DataReader(update);
                dgv.DataSource = dt.DataReader("select * from TblBangCongThuViec");
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaTV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không ?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    dt.DataChange("delete TblBangCongThuViec where MaNVTV=N'" + cbbMaNV.Text + "'");
                    dgv.DataSource = dt.DataReader("select * from TblBangCongThuViec");

                }
                catch
                {
                    MessageBox.Show("Bạn không được xóa vì nó liên quan đến các hóa đơn !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btnMoiNVCT_Click(object sender, EventArgs e)
        {
            cbbMaNVCT.SelectedIndex = -1;
            cbbMaNVCT.Text = "";
            txtMaLuong.Text = "";
            txtHoTen.Text = "";
            cbbTenPhong.SelectedIndex = 0;
            cbbTenPhong.Text = "";
            txtLuongCB.Text = "";
            txtPhuCap.Text = "";
            txtPhuCap2.Text = "";
            txtThuong.Text = "";
            txtKyLuat.Text = "";
            txtThangNVCT.Text = "";
            txtNgayNghiNVCT.Text = "";
            txtGioLamThemNVCT.Text = "";
            txtGhiChuNVCT.Text = "";
            txtNamNVCT.Text = "";
            txtNgayCongNVCT.Text = "";
            txtTongLuong.Text = "";
            btnSuaNVCT.Enabled = false;
            btnXoaNVCT.Enabled = false;
        }

       

        private void btnThoatNVCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không ạ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSuaNVCT.Enabled = true;
                btnXoaNVCT.Enabled = true;
                cbbMaNVCT.SelectedValue = dgv1.CurrentRow.Cells[0].Value.ToString();
                cbbTenPhong.SelectedValue = dgv1.CurrentRow.Cells[1].Value.ToString();
                txtHoTen.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                txtMaLuong.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                txtLuongCB.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                txtPhuCap.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                txtPhuCap2.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
                txtThuong.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
                txtKyLuat.Text = dgv1.CurrentRow.Cells[8].Value.ToString();
                txtThangNVCT.Text = dgv1.CurrentRow.Cells[9].Value.ToString();
                txtNamNVCT.Text = dgv1.CurrentRow.Cells[10].Value.ToString();
                txtNgayCongNVCT.Text = dgv1.CurrentRow.Cells[11].Value.ToString();
                txtNgayNghiNVCT.Text = dgv1.CurrentRow.Cells[12].Value.ToString();
                txtGioLamThemNVCT.Text = dgv1.CurrentRow.Cells[13].Value.ToString();
                txtTongLuong.Text = dgv1.CurrentRow.Cells[14].Value.ToString();
                txtGhiChu.Text = dgv1.CurrentRow.Cells[15].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không ấn linh tinh trên bảng ! because " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLuongTV.Text = "";
            dt.loadtextbox(txtTenPhong, "select * from TblPhongBan b,TblHoSoThuViec a where a.MaPhong=b.MaPhong and MaNVTV='" + cbbMaNV.Text + "'", 2);
            dt.loadtextbox(txtTenBP, "select * from TblBoPhan,TblPhongBan where TblPhongBan.MaBoPhan=TblBoPhan.MaBoPhan and TenPhong=N'" + txtTenPhong.Text + "'", 1);
            dt.loadtextbox(txtLuongTV, "select * from TblBangCongThuViec where MaNVTV='" + cbbMaNV.Text + "'", 3);
        }

        private void cbbMaNVCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.loadtextbox(txtMaLuong, "select * from TblTTNVCoBan where MaNV='" + cbbMaNVCT.Text + "'", 4);
            dt.loadtextbox(txtLuongCB, "select * from TblBangLuongCTy where MaLuong='" + txtMaLuong.Text + "'", 1);
            dt.loadtextbox(txtPhuCap, "select * from TblBangLuongCTy where MaLuong='" + txtMaLuong.Text + "'", 2);
            dt.loadtextbox(txtHoTen, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 2); 
            dt.loadtextbox(txtPhuCap2, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 6);
            dt.loadtextbox(txtThuong, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 7);
            dt.loadtextbox(txtKyLuat, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 8);
            dt.loadtextbox(txtThangNVCT, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 9);
            dt.loadtextbox(txtNamNVCT, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 10);
            dt.loadtextbox(txtNgayCongNVCT, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 11);
            dt.loadtextbox(txtNgayNghiNVCT, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 12);
            dt.loadtextbox(txtGioLamThemNVCT, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 13);
            dt.loadtextbox(txtTongLuong, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 14);
            dt.loadtextbox(txtGhiChuNVCT, "select * from TblCongKhoiDieuHanh where MaNV='" + cbbMaNVCT.Text + "'", 15);
            
        }

        private void btnSuaNVCT_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblCongKhoiDieuHanh set MaNV='" + cbbMaNVCT.Text + "', MaLuong=N'" + txtMaLuong.Text + "',TenPhong=N'" + txtTenPhong.Text + "', HoTen=N'" + txtHoTen.Text + "',LCB=N'" + txtLuongCB.Text + "',PCChucVu=N'" + txtPhuCap.Text + "',PCapKhac=N'" + txtPhuCap2.Text + "',Thuong=N'" + txtThuong.Text + "',KyLuat='" + txtKyLuat.Text + "',Thang=N'" + txtThangNVCT.Text + "',Nam='" + txtNamNVCT.Text + "',SoNgayCongThang=N'" + txtNgayCongNVCT.Text + "',SoNgayNghi=N'" + txtNgayNghiNVCT.Text + "',SoGioLamThem=N'" + txtGioLamThemNVCT.Text + "',Luong=N'" + txtTongLuong.Text + "',GhiChu='" + txtGhiChuNVCT.Text + "' where MaNV=N'" + cbbMaNVCT.Text + "'";
                dt.DataChange(update);
                dgv1.DataSource = dt.DataReader(" select * from  TblCongKhoiDieuHanh ");
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaNVCT_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblCongKhoiDieuHanh where MaNV=N'" + cbbMaNVCT.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dt.DataChange(delete); ;
                    dgv1.DataSource = dt.DataReader(" select * from  TblCongKhoiDieuHanh ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void txtLuongTV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int lg, nc, lt;
                double tongluong;
                if (txtGioLamThem.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThem.Text);
                }
                if (txtLuongTV.Text.Trim() == "")
                {
                    lg = 0;
                }
                else
                {
                    lg = int.Parse(txtLuongTV.Text);
                }
                nc = int.Parse(txtNgayCong.Text);
                tongluong = (lg / 26) * (nc) + (lt * 40000);
                txtLuong.Text = tongluong.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void txtGioLamThem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int lg, nc, lt;
                double tongluong;
                if (txtGioLamThem.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThem.Text);
                }
                if (txtLuongTV.Text.Trim() == "")
                {
                    lg = 0;
                }
                else
                {
                    lg = int.Parse(txtLuongTV.Text);
                }
                nc = int.Parse(txtNgayCong.Text);
                tongluong = (lg / 26) * (nc) + (lt * 40000);
                txtLuong.Text = tongluong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNgayCong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int lg, nc, lt;
                double tongluong;
                if (txtGioLamThem.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThem.Text);
                }
                if (txtLuongTV.Text.Trim() == "")
                {
                    lg = 0;
                }
                else
                {
                    lg = int.Parse(txtLuongTV.Text);
                }
                nc = int.Parse(txtNgayCong.Text);
                tongluong = (lg / 26) * (nc) + (lt * 40000);
                txtLuong.Text = tongluong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            functions.FillComboBox("select MaNV from TblCongKhoiDieuHanh where TenPhong=(select top(1) TenPhong from TblPhongBan a, " +
                "TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.TenPhong=N'" + cbbTenPhong.SelectedValue + "' group by TenPhong)",
                cbbMaNVCT, "MaNV", "MaNV");
            cbbMaNVCT.DisplayMember = "MaNV";
            cbbMaNVCT.ValueMember = "MaNV";
            dgv1.DataSource = dt.DataReader("select * from TblCongKhoiDieuHanh b " +
                "where b.TenPhong=N'" + cbbTenPhong.SelectedValue + "'");
        }

        private void txtLuongCB_TextChanged(object sender, EventArgs e)
        {
            int lcb, pc, pck, nc, lt, th, kl;
            try
            {
                if (txtLuongCB.Text.Trim() == "")
                {
                    lcb = 0;
                }
                else
                {
                    lcb = int.Parse(txtLuongCB.Text);
                }

                if (txtPhuCap.Text.Trim() == "")
                {
                    pc = 0;
                }
                else
                {
                    pc = int.Parse(txtPhuCap.Text);
                }

                if (txtPhuCap2.Text.Trim() == "")
                {
                    pck = 0;
                }
                else
                {
                    pck = int.Parse(txtPhuCap2.Text);
                }

                if (txtNgayCongNVCT.Text.Trim() == "")
                {
                    nc = 0;
                }
                else
                {
                    nc = int.Parse(txtNgayCongNVCT.Text);
                }

                if (txtGioLamThemNVCT.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThemNVCT.Text);
                }

                if (txtThuong.Text.Trim() == "")
                {
                    th = 0;
                }
                else
                {
                    th = int.Parse(txtThuong.Text);
                }

                if (txtKyLuat.Text.Trim() == "")
                {
                    kl = 0;
                }
                else
                {
                    kl = int.Parse(txtKyLuat.Text);
                }
                float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
                txtTongLuong.Text = luong.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPhuCap_TextChanged(object sender, EventArgs e)
        {
            int lcb, pc, pck, nc, lt, th, kl;
            try
            {
                if (txtLuongCB.Text.Trim() == "")
                {
                    lcb = 0;
                }
                else
                {
                    lcb = int.Parse(txtLuongCB.Text);
                }

                if (txtPhuCap.Text.Trim() == "")
                {
                    pc = 0;
                }
                else
                {
                    pc = int.Parse(txtPhuCap.Text);
                }

                if (txtPhuCap2.Text.Trim() == "")
                {
                    pck = 0;
                }
                else
                {
                    pck = int.Parse(txtPhuCap2.Text);
                }

                if (txtNgayCongNVCT.Text.Trim() == "")
                {
                    nc = 0;
                }
                else
                {
                    nc = int.Parse(txtNgayCongNVCT.Text);
                }

                if (txtGioLamThemNVCT.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThemNVCT.Text);
                }

                if (txtThuong.Text.Trim() == "")
                {
                    th = 0;
                }
                else
                {
                    th = int.Parse(txtThuong.Text);
                }

                if (txtKyLuat.Text.Trim() == "")
                {
                    kl = 0;
                }
                else
                {
                    kl = int.Parse(txtKyLuat.Text);
                }
                float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
                txtTongLuong.Text = luong.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPhuCap2_TextChanged(object sender, EventArgs e)
        {
            int lcb, pc, pck, nc, lt, th, kl;
            try
            {
                if (txtLuongCB.Text.Trim() == "")
                {
                    lcb = 0;
                }
                else
                {
                    lcb = int.Parse(txtLuongCB.Text);
                }

                if (txtPhuCap.Text.Trim() == "")
                {
                    pc = 0;
                }
                else
                {
                    pc = int.Parse(txtPhuCap.Text);
                }

                if (txtPhuCap2.Text.Trim() == "")
                {
                    pck = 0;
                }
                else
                {
                    pck = int.Parse(txtPhuCap2.Text);
                }

                if (txtNgayCongNVCT.Text.Trim() == "")
                {
                    nc = 0;
                }
                else
                {
                    nc = int.Parse(txtNgayCongNVCT.Text);
                }

                if (txtGioLamThemNVCT.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThemNVCT.Text);
                }

                if (txtThuong.Text.Trim() == "")
                {
                    th = 0;
                }
                else
                {
                    th = int.Parse(txtThuong.Text);
                }

                if (txtKyLuat.Text.Trim() == "")
                {
                    kl = 0;
                }
                else
                {
                    kl = int.Parse(txtKyLuat.Text);
                }
                float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
                txtTongLuong.Text = luong.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtThuong_TextChanged(object sender, EventArgs e)
        {
            int lcb, pc, pck, nc, lt, th, kl;
            try
            {
                if (txtLuongCB.Text.Trim() == "")
                {
                    lcb = 0;
                }
                else
                {
                    lcb = int.Parse(txtLuongCB.Text);
                }

                if (txtPhuCap.Text.Trim() == "")
                {
                    pc = 0;
                }
                else
                {
                    pc = int.Parse(txtPhuCap.Text);
                }

                if (txtPhuCap2.Text.Trim() == "")
                {
                    pck = 0;
                }
                else
                {
                    pck = int.Parse(txtPhuCap2.Text);
                }

                if (txtNgayCongNVCT.Text.Trim() == "")
                {
                    nc = 0;
                }
                else
                {
                    nc = int.Parse(txtNgayCongNVCT.Text);
                }

                if (txtGioLamThemNVCT.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThemNVCT.Text);
                }

                if (txtThuong.Text.Trim() == "")
                {
                    th = 0;
                }
                else
                {
                    th = int.Parse(txtThuong.Text);
                }

                if (txtKyLuat.Text.Trim() == "")
                {
                    kl = 0;
                }
                else
                {
                    kl = int.Parse(txtKyLuat.Text);
                }
                float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
                txtTongLuong.Text = luong.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtKyLuat_TextChanged(object sender, EventArgs e)
        {
            int lcb, pc, pck, nc, lt, th, kl;
            try
            {
                if (txtLuongCB.Text.Trim() == "")
                {
                    lcb = 0;
                }
                else
                {
                    lcb = int.Parse(txtLuongCB.Text);
                }

                if (txtPhuCap.Text.Trim() == "")
                {
                    pc = 0;
                }
                else
                {
                    pc = int.Parse(txtPhuCap.Text);
                }

                if (txtPhuCap2.Text.Trim() == "")
                {
                    pck = 0;
                }
                else
                {
                    pck = int.Parse(txtPhuCap2.Text);
                }

                if (txtNgayCongNVCT.Text.Trim() == "")
                {
                    nc = 0;
                }
                else
                {
                    nc = int.Parse(txtNgayCongNVCT.Text);
                }

                if (txtGioLamThemNVCT.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThemNVCT.Text);
                }

                if (txtThuong.Text.Trim() == "")
                {
                    th = 0;
                }
                else
                {
                    th = int.Parse(txtThuong.Text);
                }

                if (txtKyLuat.Text.Trim() == "")
                {
                    kl = 0;
                }
                else
                {
                    kl = int.Parse(txtKyLuat.Text);
                }
                float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
                txtTongLuong.Text = luong.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNgayCongNVCT_TextChanged(object sender, EventArgs e)
        {
            int lcb, pc, pck, nc, lt, th, kl;
            try
            {
                if (txtLuongCB.Text.Trim() == "")
                {
                    lcb = 0;
                }
                else
                {
                    lcb = int.Parse(txtLuongCB.Text);
                }

                if (txtPhuCap.Text.Trim() == "")
                {
                    pc = 0;
                }
                else
                {
                    pc = int.Parse(txtPhuCap.Text);
                }

                if (txtPhuCap2.Text.Trim() == "")
                {
                    pck = 0;
                }
                else
                {
                    pck = int.Parse(txtPhuCap2.Text);
                }

                if (txtNgayCongNVCT.Text.Trim() == "")
                {
                    nc = 0;
                }
                else
                {
                    nc = int.Parse(txtNgayCongNVCT.Text);
                }

                if (txtGioLamThemNVCT.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThemNVCT.Text);
                }

                if (txtThuong.Text.Trim() == "")
                {
                    th = 0;
                }
                else
                {
                    th = int.Parse(txtThuong.Text);
                }

                if (txtKyLuat.Text.Trim() == "")
                {
                    kl = 0;
                }
                else
                {
                    kl = int.Parse(txtKyLuat.Text);
                }
                float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
                txtTongLuong.Text = luong.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtGioLamThemNVCT_TextChanged(object sender, EventArgs e)
        {
            int lcb, pc, pck, nc, lt, th, kl;
            try
            {
                if (txtLuongCB.Text.Trim() == "")
                {
                    lcb = 0;
                }
                else
                {
                    lcb = int.Parse(txtLuongCB.Text);
                }

                if (txtPhuCap.Text.Trim() == "")
                {
                    pc = 0;
                }
                else
                {
                    pc = int.Parse(txtPhuCap.Text);
                }

                if (txtPhuCap2.Text.Trim() == "")
                {
                    pck = 0;
                }
                else
                {
                    pck = int.Parse(txtPhuCap2.Text);
                }

                if (txtNgayCongNVCT.Text.Trim() == "")
                {
                    nc = 0;
                }
                else
                {
                    nc = int.Parse(txtNgayCongNVCT.Text);
                }

                if (txtGioLamThemNVCT.Text.Trim() == "")
                {
                    lt = 0;
                }
                else
                {
                    lt = int.Parse(txtGioLamThemNVCT.Text);
                }

                if (txtThuong.Text.Trim() == "")
                {
                    th = 0;
                }
                else
                {
                    th = int.Parse(txtThuong.Text);
                }

                if (txtKyLuat.Text.Trim() == "")
                {
                    kl = 0;
                }
                else
                {
                    kl = int.Parse(txtKyLuat.Text);
                }
                float luong = ((lcb / 26) * nc + (lt * 40000) + pc + pck + th - kl);
                txtTongLuong.Text = luong.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //Khai báo và khởi tạo các đối tượng
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            //Định dạng chung
            Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
            tenCuaHang.Font.Size = 12;
            tenCuaHang.Font.Bold = true;
            tenCuaHang.Font.Color = Color.Blue;
            tenCuaHang.Value = "CÔNG TY TNHH NĂM THÀNH VIÊN";
            Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
            dcCuaHang.Font.Size = 12;
            dcCuaHang.Font.Bold = true;
            dcCuaHang.Font.Color = Color.Blue;
            dcCuaHang.Value = "Địa chỉ: Cầu Giấy - Hà Nội";
            Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
            dtCuaHang.Font.Size = 12;
            dtCuaHang.Font.Bold = true;
            dtCuaHang.Font.Color = Color.Blue;
            dtCuaHang.Value = "Điện thoại: 0333444555";
            Excel.Range header = (Excel.Range)exSheet.Cells[5, 3];

            header.Font.Size = 13;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "DANH SÁCH NHÂN VIÊN THỬ VIỆC";

            //Định dạng tiêu đề bảng
            exSheet.get_Range("A7:K7").Font.Bold = true;
            exSheet.get_Range("A7:K7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A7").Value = "Tên bộ phận";
            exSheet.get_Range("B7").Value = "Tên phòng";
            exSheet.get_Range("C7").Value = "Mã NVTV";
            exSheet.get_Range("D7").Value = "Lương TV";
            exSheet.get_Range("E7").Value = "Tháng";
            exSheet.get_Range("F7").Value = "Năm";
            exSheet.get_Range("G7").Value = "Số Ngày công";
            exSheet.get_Range("H7").Value = "Số ngày nghỉ";
            exSheet.get_Range("I7").Value = "Số giờ làm thêm";
            exSheet.get_Range("j7").Value = "Lương";
            exSheet.get_Range("K7").Value = "Ghi Chú";
            exSheet.get_Range("A7").ColumnWidth = 12;
            exSheet.get_Range("B7").ColumnWidth = 12;
            exSheet.get_Range("C7").ColumnWidth = 12;
            exSheet.get_Range("D7").ColumnWidth = 12;
            exSheet.get_Range("E7").ColumnWidth = 12;
            exSheet.get_Range("F7").ColumnWidth = 12;
            exSheet.get_Range("G7").ColumnWidth = 12;
            exSheet.get_Range("H7").ColumnWidth = 12;
            exSheet.get_Range("I7").ColumnWidth = 12;
            exSheet.get_Range("J7").ColumnWidth = 12;
            exSheet.get_Range("K7").ColumnWidth = 12;
            int dong = 8;
            //In dữ liệu
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {

                exSheet.get_Range("A" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[0].Value.ToString();
                exSheet.get_Range("B" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[1].Value.ToString();
                exSheet.get_Range("C" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[2].Value.ToString();
                exSheet.get_Range("D" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[3].Value.ToString();
                exSheet.get_Range("E" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[4].Value.ToString();
                exSheet.get_Range("F" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[5].Value.ToString();
                exSheet.get_Range("G" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[6].Value.ToString();
                exSheet.get_Range("H" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[7].Value.ToString();
                exSheet.get_Range("I" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[8].Value.ToString();
                exSheet.get_Range("J" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[9].Value.ToString();
                exSheet.get_Range("K" + (i + dong).ToString()).Value = dgv.Rows[i].Cells[10].Value.ToString();
            }
           
            exBook.Activate();
            //lưu file
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Workbook|*.xlsx|Excel 97-2002 workbook|*.xls|All files|*.*";
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
                MessageBox.Show("in thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInExcel_Click(object sender, EventArgs e)
        {
            //Khai báo và khởi tạo các đối tượng
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            //Định dạng chung
            Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
            tenCuaHang.Font.Size = 12;
            tenCuaHang.Font.Bold = true;
            tenCuaHang.Font.Color = Color.Blue;
            tenCuaHang.Value = "CÔNG TY NĂM THÀNH VIÊN";
            Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
            dcCuaHang.Font.Size = 12;
            dcCuaHang.Font.Bold = true;
            dcCuaHang.Font.Color = Color.Blue;
            dcCuaHang.Value = "Địa chỉ: Cầu Giấy - Hà Nội";
            Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
            dtCuaHang.Font.Size = 12;
            dtCuaHang.Font.Bold = true;
            dtCuaHang.Font.Color = Color.Blue;
            dtCuaHang.Value = "Điện thoại: 0333444555";
            Excel.Range header = (Excel.Range)exSheet.Cells[5, 3];

            header.Font.Size = 13;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "DANH SÁCH NHÂN VIÊN CHÍNH THỨC";

            //Định dạng tiêu đề bảng
            exSheet.get_Range("A7:K7").Font.Bold = true;
            exSheet.get_Range("A7:K7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A7").Value = "Mã Nhân Viên";
            exSheet.get_Range("B7").Value = "Tên phòng";
            exSheet.get_Range("C7").Value = "Họ Tên";
            exSheet.get_Range("D7").Value = "Mã lương";
            exSheet.get_Range("E7").Value = "Lương CB";
            exSheet.get_Range("F7").Value = "Phụ Cấp Chức Vụ";
            exSheet.get_Range("G7").Value = "Phụ Cấp Khác";
            exSheet.get_Range("H7").Value = "Thưởng";
            exSheet.get_Range("I7").Value = "Kỷ luật";
            exSheet.get_Range("J7").Value = "Tháng";
            exSheet.get_Range("K7").Value = "Năm";
            exSheet.get_Range("L7").Value = "Số Ngày Công Tháng";
            exSheet.get_Range("M7").Value = "Số Ngày Nghỉ";
            exSheet.get_Range("N7").Value = "Số giờ làm thêm";
            exSheet.get_Range("O7").Value = "Lương";
            exSheet.get_Range("P7").Value = "Ghi Chú";
            exSheet.get_Range("A7").ColumnWidth = 12;
            exSheet.get_Range("B7").ColumnWidth = 12;
            exSheet.get_Range("C7").ColumnWidth = 12;
            exSheet.get_Range("D7").ColumnWidth = 12;
            exSheet.get_Range("E7").ColumnWidth = 12;
            exSheet.get_Range("F7").ColumnWidth = 18;
            exSheet.get_Range("G7").ColumnWidth = 12;
            exSheet.get_Range("H7").ColumnWidth = 12;
            exSheet.get_Range("J7").ColumnWidth = 12;
            exSheet.get_Range("K7").ColumnWidth = 12;
            exSheet.get_Range("L7").ColumnWidth = 18;
            exSheet.get_Range("M7").ColumnWidth = 12;
            exSheet.get_Range("N7").ColumnWidth = 18;
            exSheet.get_Range("O7").ColumnWidth = 12;
            exSheet.get_Range("P7").ColumnWidth = 12;



            int dong = 8;
            //In dữ liệu
            for (int i = 0; i < dgv.Rows.Count + 15; i++)
            {

                exSheet.get_Range("A" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[0].Value.ToString();
                exSheet.get_Range("B" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[1].Value.ToString();
                exSheet.get_Range("C" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[2].Value.ToString();
                exSheet.get_Range("D" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[3].Value.ToString();
                exSheet.get_Range("E" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[4].Value.ToString();
                exSheet.get_Range("F" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[5].Value.ToString();
                exSheet.get_Range("G" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[6].Value.ToString();
                exSheet.get_Range("H" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[7].Value.ToString();
                exSheet.get_Range("I" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[8].Value.ToString();
                exSheet.get_Range("J" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[9].Value.ToString();
                exSheet.get_Range("K" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[10].Value.ToString();
                exSheet.get_Range("L" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[11].Value.ToString();
                exSheet.get_Range("M" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[12].Value.ToString();
                exSheet.get_Range("N" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[13].Value.ToString();
                exSheet.get_Range("O" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[14].Value.ToString();
                exSheet.get_Range("P" + (i + dong).ToString()).Value = dgv1.Rows[i].Cells[15].Value.ToString();

            }
            
            exBook.Activate();
            //lưu file
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Workbook|*.xlsx|Excel 97-2002 workbook|*.xls|All files|*.*";
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
                MessageBox.Show("in thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}


