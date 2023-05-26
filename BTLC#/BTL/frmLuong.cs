using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmLuong : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();
        Classes.ConnectData datatl = new Classes.ConnectData();
        Classes.CommonFunctions function = new Classes.CommonFunctions();
        public frmLuong()
        {
            InitializeComponent();
            DataTable dtMaNV = data.DataReader("select MaNV from tblttcanhan");
            function.FillComboBox(cboMaNV, dtMaNV, "MaNV", "MaNV");
        }
        public void loadData()
        {
            DataTable dt = data.DataReader("select * from tblBangLuongCTy");
            dgvLuongCongTy.DataSource = dt;
        }
        public void loadDataTL()
        {
            DataTable dttl = datatl.DataReader("select * from tbltangluong");
            dgvVDTL.DataSource = dttl;
        }
        void ResetValue()
        {
            txtMaLuong.Text = "";
            txtLuongCB.Text = "";
            txtPCChucVu.Text = "";
            dtpNgayNhap.Text = "";
            txtLuongCBMoi.Text = "";
            dtpNgaySua.Text = "";
            txtPCChucVuMoi.Text = "";
            dtpNgaySuaPC.Text = "";
            txtLyDo.Text = "";
            txtGhiChu.Text = "";



            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaLuong.Enabled = true;

            errLuongCT.Clear();

            txtMaLuong.Focus();
        }
        void ResetValueTL()
        {
            cboMaNV.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtChucVu.Text = "";
            txtMaLuongCu.Text = "";
            txtMaLuongMoi.Text = "";
            dtpNgayTang.Text = "";
            txtLyDoTang.Text = "";

            btnSuaTL.Enabled = false;
            btnXoaTL.Enabled = false;
            btnLuuTL.Enabled = true;
            cboMaNV.Enabled = true;
            txtHoTen.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtChucVu.Enabled = false;
            txtMaLuongCu.Enabled = false;

            errVDTL.Clear();


        }
        private void frmLuong_Load(object sender, EventArgs e)
        {
            loadData();
            dgvLuongCongTy.Columns[0].HeaderText = "Mã lương";
            dgvLuongCongTy.Columns[1].HeaderText = "Lương cơ bản";
            dgvLuongCongTy.Columns[2].HeaderText = "PC Chức vụ";
            dgvLuongCongTy.Columns[3].HeaderText = "Ngày nhập";
            dgvLuongCongTy.Columns[4].HeaderText = "LCB mới";
            dgvLuongCongTy.Columns[5].HeaderText = "Ngày sửa";
            dgvLuongCongTy.Columns[6].HeaderText = "Lý do";
            dgvLuongCongTy.Columns[7].HeaderText = "PCCV mới";
            dgvLuongCongTy.Columns[8].HeaderText = "Ngày sửa PC";
            dgvLuongCongTy.Columns[9].HeaderText = "Ghi chú";
            ResetValue();
            //tap 2
            loadDataTL();
            dgvVDTL.Columns[0].HeaderText = "Mã NV";
            dgvVDTL.Columns[1].HeaderText = "Họ tên";
            dgvVDTL.Columns[2].HeaderText = "Giới tính";
            dgvVDTL.Columns[3].HeaderText = "Chức vụ";
            dgvVDTL.Columns[4].HeaderText = "Mã lương cũ";
            dgvVDTL.Columns[5].HeaderText = "Mã lương mới";
            dgvVDTL.Columns[6].HeaderText = "Ngày tăng";
            dgvVDTL.Columns[7].HeaderText = "Lý do";
            ResetValueTL();
        }
        private void btnMoiTL_Click(object sender, EventArgs e)
        {
            ResetValueTL();
        }

        private void btnThoatTL_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dgvLuongCongTy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaLuong.Text = dgvLuongCongTy.CurrentRow.Cells[0].Value.ToString();
                txtLuongCB.Text = dgvLuongCongTy.CurrentRow.Cells[1].Value.ToString();
                txtPCChucVu.Text = dgvLuongCongTy.CurrentRow.Cells[2].Value.ToString();
                dtpNgayNhap.Value = (DateTime)dgvLuongCongTy.CurrentRow.Cells[3].Value;
                txtLuongCBMoi.Text = dgvLuongCongTy.CurrentRow.Cells[4].Value.ToString();
                dtpNgaySua.Value = (DateTime)dgvLuongCongTy.CurrentRow.Cells[5].Value;
                txtLyDo.Text = dgvLuongCongTy.CurrentRow.Cells[6].Value.ToString();
                txtPCChucVuMoi.Text = dgvLuongCongTy.CurrentRow.Cells[7].Value.ToString();
                dtpNgaySuaPC.Value = (DateTime)dgvLuongCongTy.CurrentRow.Cells[8].Value;
                txtGhiChu.Text = dgvLuongCongTy.CurrentRow.Cells[9].Value.ToString();
            }
            catch
            {
                txtMaLuong.Text = "";
                txtLuongCB.Text = "";
                txtPCChucVu.Text = "";
                dtpNgayNhap.Text = "";
                txtLuongCBMoi.Text = "";
                dtpNgaySua.Text = "";
                txtPCChucVuMoi.Text = "";
                dtpNgaySuaPC.Text = "";
                txtLyDo.Text = "";
                txtGhiChu.Text = "";
            }
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaLuong.Enabled = false;
            errLuongCT.Clear();
        }

        private void dgvVDTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cboMaNV.Text = dgvVDTL.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvVDTL.CurrentRow.Cells[1].Value.ToString();
                txtGioiTinh.Text = dgvVDTL.CurrentRow.Cells[2].Value.ToString();
                txtChucVu.Text = dgvVDTL.CurrentRow.Cells[3].Value.ToString();
                txtMaLuongCu.Text = dgvVDTL.CurrentRow.Cells[4].Value.ToString();
                txtMaLuongMoi.Text = dgvVDTL.CurrentRow.Cells[5].Value.ToString();
                dtpNgayTang.Value = (DateTime)dgvVDTL.CurrentRow.Cells[6].Value;
                txtLyDoTang.Text = dgvVDTL.CurrentRow.Cells[7].Value.ToString();
            }
            catch
            {
                cboMaNV.Text = "";
                txtHoTen.Text = "";
                txtGioiTinh.Text = "";
                txtChucVu.Text = "";
                txtMaLuongCu.Text = "";
                txtMaLuongMoi.Text = "";
                dtpNgayTang.Text = "";
                txtLyDoTang.Text = "";
            }
            btnLuuTL.Enabled = false;
            btnSuaTL.Enabled = true;
            btnXoaTL.Enabled = true;
            cboMaNV.Enabled = false;
            errVDTL.Clear();
        }

        private void btnLuuTL_Click(object sender, EventArgs e)
        {
            //không cho để trống thông tin
            if (txtHoTen.Text.Trim() == "")
            {
                errVDTL.SetError(txtHoTen, "không được để trống họ tên");
                return;
            }
            else
            {
                errVDTL.Clear();
            }
            //
            if (txtGioiTinh.Text.Trim() == "")
            {
                errVDTL.SetError(txtGioiTinh, "không được để trống giới tính ");
                return;
            }
            else
            {
                errVDTL.Clear();
            }
            //
            if (txtChucVu.Text.Trim() == "")
            {
                errVDTL.SetError(txtChucVu, "không được để trống chức vụ ");
                return;
            }
            else
            {
                errVDTL.Clear();
            }
            //
            if (txtMaLuongCu.Text.Trim() == "")
            {
                errVDTL.SetError(txtMaLuongCu, "không được để trống mã lương cũ ");
                return;
            }
            else
            {
                errVDTL.Clear();
            }
            if (txtMaLuongMoi.Text.Trim() == "")
            {
                errVDTL.SetError(txtMaLuongMoi, "không được để trống mã lương m ");
                return;
            }
            else
            {
                errVDTL.Clear();
            }
            //
            DataTable dtcheckma = data.DataReader("select * from TblTangLuong where MaNV=N'" + cboMaNV.SelectedValue + "'");
            if (dtcheckma.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //thêm mới hàng vào database
            string sqlInsert = "insert into TblTangLuong values(N'" + cboMaNV.SelectedValue + "',N'" + txtHoTen.Text + "',N'" + txtGioiTinh.Text + "',N'" + txtChucVu.Text + "', N'" + txtMaLuongCu.Text + "', N'" + txtMaLuongMoi.Text + "', N'" + dtpNgayTang.Value.Date + "', N'" + txtLyDo.Text + "')";
            //MessageBox.Show(sqlInsert);
            string sqlupdateTTNVCoBan = "update tblttnvcoban set ";
            sqlupdateTTNVCoBan += "MaLuong=N'" + txtMaLuongMoi.Text + "'";
            sqlupdateTTNVCoBan += "where MaNV = N'" + cboMaNV.SelectedValue + "'";
            datatl.DataChange(sqlInsert);
            datatl.DataChange(sqlupdateTTNVCoBan);
            loadDataTL();
            MessageBox.Show("thêm mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValueTL();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //không cho bỏ trống thông tin
            if (txtMaLuong.Text.Trim() == "")
            {
                errLuongCT.SetError(txtMaLuong, "không được để trống mã lương");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            if (txtLuongCB.Text.Trim() == "")
            {
                errLuongCT.SetError(txtLuongCB, "không được để trống lương cơ bản");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            if (txtPCChucVu.Text.Trim() == "")
            {
                errLuongCT.SetError(txtPCChucVu, "không được để trống phụ cấp chức vụ");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            if (txtLuongCBMoi.Text.Trim() == "")
            {
                errLuongCT.SetError(txtLuongCBMoi, "không được để trống lương cơ bản mới");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            if (txtPCChucVuMoi.Text.Trim() == "")
            {
                errLuongCT.SetError(txtPCChucVuMoi, "không được để trống phụ cấp chức vụ mới");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            DataTable dtcheckma = data.DataReader("select * from Tblbangluongcty where Maluong=N'" + txtMaLuong.Text + "'");
            if (dtcheckma.Rows.Count > 0)
            {
                MessageBox.Show("Mã lương đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLuong.Focus();
                return;
            }
            //thêm mới hàng vào database
            string sqlInsert = "insert into Tblbangluongcty values(N'" + txtMaLuong.Text + "',N'" + int.Parse(txtLuongCB.Text) + "','" + int.Parse(txtPCChucVu.Text) + "',N'" + dtpNgayNhap.Value.Date + "', N'" + int.Parse(txtLuongCBMoi.Text) + "', N'" + dtpNgaySua.Value.Date + "', N'" + txtLyDo.Text + "', N'" + int.Parse(txtPCChucVuMoi.Text) + "', '" + dtpNgaySuaPC.Value.Date + "', N'" + txtGhiChu.Text + "')";
            //MessageBox.Show(sqlInsert);
            data.DataChange(sqlInsert);
            loadData();
            MessageBox.Show("thêm mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //không cho bỏ trống thông tin
            //
            if (txtLuongCB.Text.Trim() == "")
            {
                errLuongCT.SetError(txtLuongCB, "không được để trống lương cơ bản");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            if (txtPCChucVu.Text.Trim() == "")
            {
                errLuongCT.SetError(txtPCChucVu, "không được để trống phụ cấp chức vụ");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            if (txtLuongCBMoi.Text.Trim() == "")
            {
                errLuongCT.SetError(txtLuongCBMoi, "không được để trống lương cơ bản mới");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            if (txtPCChucVuMoi.Text.Trim() == "")
            {
                errLuongCT.SetError(txtPCChucVuMoi, "không được để trống phụ cấp chức vụ mới");
                return;
            }
            else
            {
                errLuongCT.Clear();
            }
            //
            string sql = "update tblbangluongcty set ";
            sql += "LCB = N'" + txtLuongCB.Text + "',";
            sql += "PCChucVu = '" + txtPCChucVu.Text + "',";
            sql += "NgayNhap = '" + dtpNgayNhap.Value.Date + "',";
            sql += "LCBMoi = '" + txtLuongCBMoi.Text + "',";
            sql += "NgaySua = '" + dtpNgaySua.Value.Date + "',";
            sql += "LyDo = '" + txtLyDo.Text + "',";
            sql += "PCCVuMoi = '" + txtPCChucVuMoi.Text + "',";
            sql += "NgaySuaPC = '" + dtpNgaySuaPC.Value.Date + "',";
            sql += "GhiChu = '" + txtGhiChu.Text + "'";
            sql += "where Maluong = N'" + txtMaLuong.Text + "'";

            //MessageBox.Show(sql);
            data.DataChange(sql);
            loadData();
            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue();
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {

            string sql = "update tbltangluong set ";

            sql += "HoTen = N'" + txtHoTen.Text + "',";
            sql += "GioiTinh = '" + txtGioiTinh.Text + "',";
            sql += "ChucVu = '" + txtChucVu.Text + "',";
            sql += "MaLuongCu = '" + txtMaLuongCu.Text + "',";
            sql += "MaLuongMoi = '" + txtMaLuongMoi.Text + "',";
            sql += "NgayTang = '" + dtpNgayTang.Value.Date + "',";
            sql += "LyDo = '" + txtLyDoTang.Text + "'";

            sql += "where MaNV = N'" + cboMaNV.SelectedValue + "'";

            string sqlupdateTTNVCoBan = "update tblttnvcoban set ";
            sqlupdateTTNVCoBan += "MaLuong=N'" + txtMaLuongMoi.Text + "'";
            sqlupdateTTNVCoBan += "where MaNV = N'" + cboMaNV.SelectedValue + "'";
            //MessageBox.Show(sql);
            datatl.DataChange(sql);
            datatl.DataChange(sqlupdateTTNVCoBan);
            loadDataTL();
            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValueTL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chăc chắn muốn xóa", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    data.DataChange("delete tblbangluongcty where MaLuong='" + txtMaLuong.Text + "'");
                    loadData();
                    ResetValue();
                    MessageBox.Show("xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("dữ liệu này có ràng buộc , bạn không được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chăc chắn muốn xóa", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    data.DataChange("delete tbltangluong where MaNV='" + cboMaNV.SelectedValue + "'");
                    loadDataTL();
                    ResetValueTL();
                    MessageBox.Show("xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("dữ liệu này có ràng buộc , bạn không được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtnv = datatl.DataReader("Select * from tblttnvcoban where MaNV='" + cboMaNV.SelectedValue + "'");
                txtHoTen.Text = dtnv.Rows[0]["HoTen"].ToString();
                txtGioiTinh.Text = dtnv.Rows[0]["GioiTinh"].ToString();
                txtChucVu.Text = dtnv.Rows[0]["ChucVu"].ToString();
                txtMaLuongCu.Text = dtnv.Rows[0]["MaLuong"].ToString();
            }
            catch { }
        }
    }
}
