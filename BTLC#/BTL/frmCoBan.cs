using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL
{
    public partial class frmCoBan : Form
    {
        BTL.Classes.ConnectData dtbase = new BTL.Classes.ConnectData();
        BTL.Classes.CommonFunctions cf = new BTL.Classes.CommonFunctions();
        public frmCoBan()
        {
            InitializeComponent();
        }

        private void frmCoBan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtbase.DataReader("select * from TblTTNVCoBan");

            cf.FillComboBox("SELECT MaBoPhan FROM TblBoPhan", cbbMaBP, "MaBoPhan", "MaBoPhan");
            cbbMaBP.SelectedIndex = -1;

            cf.FillComboBox("select MaLuong from TblBangLuongCTy", cbbMaLuong, "MaLuong", "MaLuong");
            cbbMaLuong.SelectedIndex = -1;

            this.New();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                cbbMaBP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbbMaPhong.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtMaNV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtHoTen.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cbbMaLuong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                cbbGioiTinh.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtTTHonNhan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtCMTND.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtNoiCap.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtChucVu.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtLoaiHD.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                txtThoiGian.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                dtNgayKy.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[13].Value);
                dtNgayHetHan.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[14].Value);
                txtGhiChu.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void New()
        {
            cbbMaBP.Text = "";
            cbbMaPhong.Text = "";
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            cbbMaLuong.Text = "";
            dtNgaySinh.Value = DateTime.Today;
            cbbGioiTinh.Text = "";
            txtTTHonNhan.Text = "";
            txtCMTND.Text = "";
            txtNoiCap.Text = "";
            txtChucVu.Text = "";
            txtLoaiHD.Text = "";
            txtThoiGian.Text = "";
            dtNgayKy.Value = DateTime.Today;
            dtNgayHetHan.Value = DateTime.Today;
            txtGhiChu.Text = "";

            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            cbbMaBP.Enabled = true;
            cbbMaPhong.Enabled = true;
            cbbMaLuong.Enabled = true;

        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            this.New();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa mã nhân viên " +
                txtMaNV.Text + " không ? Nếu có ấn nút Yes, không thì ấn nút No",
                "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string insert = "insert into TblNVThoiViec(HoTen,CMTND,LyDo) select HoTen,CMTND,GhiChu from TblTTNVCoBan where MaNV='" + txtMaNV.Text + "'";
                {
                    dtbase.DataChange(insert);
                }
                MessageBox.Show("Thêm thành công dữ liệu vào bảng NVThoiViec", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string sql = "Delete From TblTTNVCoBan Where MaNV =N'" + txtMaNV.Text + "'";
                dtbase.DataChange(sql);

                string delete = "Delete From TblCongKhoiDieuHanh Where MaNV =N'" + txtMaNV.Text + "'";
                dtbase.DataChange(delete);

                sql = "select * from TblTTNVCoBan";
                dataGridView1.DataSource = dtbase.DataReader(sql);
            }

            this.New();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbbMaBP.SelectedIndex < 0)
            {
                errorDanhmuc.SetError(cbbMaBP, "Bạn không để trống mã bộ phận!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (cbbMaPhong.SelectedIndex < 0)
            {
                errorDanhmuc.SetError(cbbMaPhong, "Bạn không để trống mã phòng!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtMaNV.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtMaNV, "Bạn không để trống mã nhân viên!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtHoTen.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtHoTen, "Bạn không để trống họ tên!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (cbbMaLuong.SelectedIndex < 0)
            {
                errorDanhmuc.SetError(cbbMaLuong, "Bạn không để trống mã lương!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (cbbGioiTinh.SelectedIndex < 0)
            {
                errorDanhmuc.SetError(cbbGioiTinh, "Bạn không để trống giới tính!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtTTHonNhan.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtTTHonNhan, "Bạn không để trống tình trạng hôn nhân!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtCMTND.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtCMTND, "Bạn không để trống CMTND!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtNoiCap.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtNoiCap, "Bạn không để trống nơi cấp!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtChucVu.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtChucVu, "Bạn không để trống chức vụ!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtLoaiHD.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtLoaiHD, "Bạn không để trống loại hợp đồng!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtThoiGian.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtThoiGian, "Bạn không để trống thời gian!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (dtNgayKy.Value > dtNgayHetHan.Value)
            {
                errorDanhmuc.SetError(dtNgayKy, "Ngày ký phải trước ngày hết hạn!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }

            string sql = "Select * From TblTTNVCoBan Where MaNV = " + txtMaNV.Text;
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                errorDanhmuc.SetError(txtMaNV, "Mã nhân viên trùng trong cơ sở dữ liệu!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }

            string insert = "INSERT into TblTTNVCoBan (MaBoPhan,MaPhong,MaNV,HoTen,MaLuong, NgaySinh, GioiTinh, TTHonNhan, CMTND, NoiCap, ChucVu, LoaiHD, ThoiGian, NgayKy, NgayHetHan, GhiChu) VALUES " +
                "('" + cbbMaBP.Text + "', '" + cbbMaPhong.Text + "', N'" + txtMaNV.Text + "', N'" + txtHoTen.Text + "', N'" + cbbMaLuong.Text + "','"
                + dtNgaySinh.Value.ToString("yyyy-MM-dd") + "', N'" + cbbGioiTinh.SelectedItem.ToString() + "',N'" + txtTTHonNhan.Text +
                "', N'" + txtCMTND.Text + "', N'" + txtNoiCap.Text + "', N'" + txtChucVu.Text + "', N'" + txtLoaiHD.Text +
                "', N'" + txtThoiGian.Text + "','" + dtNgayKy.Value.ToString("yyyy-MM-dd") + "','" + dtNgayHetHan.Value.ToString("yyyy-MM-dd") + "', N'" + txtGhiChu.Text + "')";

            //Kiểm tra tồn tại 
            if ((!cf.checkkeysexists(txtMaNV.Text, "select MaNV from TblTTNVCoBan")) && (!cf.checkkeysexists(txtCMTND.Text, "select CMTND from TblNVThoiViec")))
            {
                dtbase.DataChange(insert);
                MessageBox.Show("Thêm thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if ((!cf.checkkeysexists(txtMaNV.Text, "select MaNV from TblTTNVCoBan")) && (cf.checkkeysexists(txtCMTND.Text, "select CMTND from TblNVThoiViec")))
            {
                if (MessageBox.Show("Nhân viên này đã từng làm ở công ty, bạn có chắc muốn thêm?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dtbase.DataChange(insert);
                    MessageBox.Show("Thêm thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string delete = "delete from TblNVThoiViec where CMTND=N'" + txtCMTND.Text + "'";
                    dtbase.DataChange(delete);
                }
            }

            //Them du lieu vao bang Tblttcanhan 
            string ine = "insert into TblTTCaNhan(MaNV,HoTen) select MaNV,HoTen from TblTTNVCoBan where MaNV=N'" + txtMaNV.Text + "'";

            if ((!cf.checkkeysexists(txtMaNV.Text, "select MaNV from TblTTCaNhan")))
            {
                dtbase.DataChange(ine);
            }
            else
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Them du lieu vao bang Tblttcongkhoidieuhanh
            string ins = "insert into TblCongKhoiDieuhanh(MaNV,HoTen,MaLuong) select MaNV,HoTen,MaLuong from TblTTNVCoBan where MaNV='" + txtMaNV.Text + "'";
            if ((!cf.checkkeysexists(txtMaNV.Text, "select MaNV from TblCongKhoiDieuHanh")))
            {
                dtbase.DataChange(ins);
            }
            else
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string updata = " update TblCongKhoiDieuHanh set TenPhong = (select TenPhong from TblPhongBan where MaPhong=N'" + cbbMaPhong.Text + "') where MaNV='" + txtMaNV.Text + "'";
            dtbase.DataChange(updata);
            dataGridView1.DataSource = dtbase.DataReader("select * from TblTTNVCoBan");

            this.New();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update TblTTNVCoBan set ";
            sql += "MaBoPhan = '" + cbbMaBP.Text + "',";
            sql += "MaPhong = '" + cbbMaPhong.Text + "',";
            sql += "HoTen = N'" + txtHoTen.Text + "',";
            sql += "MaLuong = N'" + cbbMaLuong.Text + "',";
            sql += "NgaySinh = '" + dtNgaySinh.Value.ToString("yyyy-MM-dd") + "',";
            sql += "GioiTinh = N'" + cbbGioiTinh.Text + "',";
            sql += "TTHonNhan = N'" + txtTTHonNhan.Text + "',";
            sql += "CMTND = N'" + txtCMTND.Text + "',";
            sql += "NoiCap = N'" + txtNoiCap.Text + "',";
            sql += "ChucVu = N'" + txtChucVu.Text + "',";
            sql += "LoaiHD = N'" + txtLoaiHD.Text + "',";
            sql += "ThoiGian = N'" + txtThoiGian.Text + "',";
            sql += "NgayKy = '" + dtNgayKy.Value.ToString("yyyy-MM-dd") + "',";
            sql += "NgayHetHan = '" + dtNgayHetHan.Value.ToString("yyyy-MM-dd") + "',";
            sql += "GhiChu = N'" + txtGhiChu.Text + "' ";
            sql += "Where MaNV = N'" + txtMaNV.Text + "'";
            try
            {
                dtbase.DataChange(sql);

                string upd = "update TblCongKhoiDieuHanh set HoTen=N'" + txtHoTen.Text + "',MaLuong=N'" + cbbMaLuong.Text + "' where MaNV=N'" + txtMaNV.Text + "'";
                dtbase.DataChange(upd);

                string ds = "update TblCongKhoiDieuHanh set TenPhong = (select TenPhong from TblPhongBan where MaPhong=N'" + cbbMaPhong.Text + "') where MaNV='" + txtMaNV.Text + "'";
                dtbase.DataChange(ds);

                sql = "Select * from TblTTNVCoBan";
                dataGridView1.DataSource = dtbase.DataReader(sql);

                MessageBox.Show("Sửa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.New();
            }
            catch
            {
                MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cf.FillComboBox("select p.MaPhong from TblBoPhan b,TblPhongBan p where b.MaBoPhan=p.MaBoPhan and p.MaBoPhan=N'" + cbbMaBP.SelectedValue + "'", cbbMaPhong, "MaPhong", "MaPhong");
        }
    }
}
