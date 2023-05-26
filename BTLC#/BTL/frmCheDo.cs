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

namespace BTL
{
    public partial class frmCheDo : Form
    {
        Classes.ConnectData data = new BTL.Classes.ConnectData();
        Classes.CommonFunctions functions = new Classes.CommonFunctions();
        public frmCheDo()
        {
            InitializeComponent();
        }

        // Chế độ bảo hiểm
        void LoadData()
        {
            DataTable dtBH = data.DataReader("Select * from TblSoBaoHiem");
            dgvBH.DataSource = dtBH;

            //Lấy thông tin mã nhân viên
            DataTable dtNV = data.DataReader("Select * from TblTTNVCoBan");
            functions.FillComboBox(cbbMaNVBH, dtNV, "MaNV", "MaNV");

        }

        private void btnMoiBH_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        void ResetValue()
        {
            txtGhiChuBH.Text = "";
            txtMaBH.Text = "";
            cbbMaNVBH.Text = "";
            txtMaLuongBH.Text = "";
            txtNoiCap.Text = "";
            txtGhiChuBH.Text = "";
            dtNgayCap.Value = DateTime.Today;
            cbbMaNVBH.Focus();
            btnMoiBH.Enabled = true;
            btnLuuBH.Enabled = true;
            btnSuaBH.Enabled = false;
            btnBoQua.Enabled = false;
            btnXoaBH.Enabled = false;
            errBH.Clear();
        }

        private void frmCheDo_Load(object sender, EventArgs e)
        {
            dtNgayCap.CustomFormat = " MM / dd / yyyy ";
            dtNgaySinh.CustomFormat = " MM / dd / yyyy ";
            dtNgayTroLai.CustomFormat = " MM / dd / yyyy ";
            dtNgayVeSinh.CustomFormat = " MM / dd / yyyy ";
            dtNgayVeSom.CustomFormat = " MM / dd / yyyy ";
            LoadData();
            LoadData1();
        }

        private void dgvBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBH.Text = dgvBH.CurrentRow.Cells[0].Value.ToString();
            cbbMaNVBH.Text = dgvBH.CurrentRow.Cells[1].Value.ToString();
            txtMaLuongBH.Text = dgvBH.CurrentRow.Cells[2].Value.ToString();
            dtNgayCap.Text = dgvBH.CurrentRow.Cells[3].Value.ToString();
            txtNoiCap.Text = dgvBH.CurrentRow.Cells[4].Value.ToString();
            txtGhiChuBH.Text = dgvBH.CurrentRow.Cells[5].Value.ToString();
            btnMoiBH.Enabled = false;
            btnLuuBH.Enabled = false;
            btnSuaBH.Enabled = true;
            btnXoaBH.Enabled = true;
            btnBoQua.Enabled = true;
            btnThoatBH.Enabled = true;
        }

        private void btnLuuBH_Click(object sender, EventArgs e)
        {
            if (txtMaBH.Text.Trim() == "")
            {
                errBH.SetError(txtMaBH, "Bạn phải nhập mã bảo hiểm!");
                MessageBox.Show("Bạn phải nhập mã bảo hiểm!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMaBH.Focus();
                return;
            }
            else
            {
                errBH.Clear();
            }

            if (cbbMaNVBH.Text.Trim() == "")
            {
                errBH.SetError(cbbMaNVBH, "Bạn phải chọn mã nhân viên!");
                MessageBox.Show("Bạn phải chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaNVBH.Focus();
                return;
            }
            else
            {
                errBH.Clear();
            }

            if (txtMaLuongBH.Text.Trim() == "")
            {
                errBH.SetError(txtMaLuongBH, "Bạn phải nhập mã lương!");
                MessageBox.Show("Bạn phải nhập mã lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLuongBH.Focus();
                return;
            }
            else
            {
                errBH.Clear();
            }

            //Kiểm tra xem có trùng mã bảo hiểm ko
            DataTable dtBH = data.DataReader("Select * from TblSoBaoHiem where MaSoBH='" + txtMaBH.Text + "'");
            if (dtBH.Rows.Count > 0)
            {
                MessageBox.Show("Mã số bảo hiểm đã có, mời bạn nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBH.Focus();
                return;
            }
            //Thêm mới hàng vào DataBase 
            string sqlInsert = "insert into TblSoBaoHiem values('" + txtMaBH.Text + "','" + cbbMaNVBH.SelectedValue + "','" + txtMaLuongBH.Text
                + "',N'" + dtNgayCap.Text + "',N'" + txtNoiCap.Text + "',N'" +
                txtGhiChuBH.Text + "')";
            data.DataChange(sqlInsert);
            LoadData();
            MessageBox.Show("Thêm mới thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue();
        }


        private void btnSuaBH_Click(object sender, EventArgs e)
        {
            data.DataChange("update TblSoBaoHiem set MaNV='" + cbbMaNVBH.Text + "',MaLuong='" + txtMaLuongBH.Text
                + "',NgayCapSo=N'" + dtNgayCap.Text + "',NoiCapSo=N'" + txtNoiCap.Text + "',GhiChu=N'" +
                txtGhiChuBH.Text + "' where MaSoBH='" + txtMaBH.Text + "'");
            LoadData();
            MessageBox.Show("Bạn đã sửa thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue();
        }

        private void btnXoaBH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                data.DataChange("delete from TblSoBaoHiem where MaSoBH='" + txtMaBH.Text + "'");
                LoadData();
                MessageBox.Show("Bạn đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValue();
            }
        }
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnThoatBH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        // Chế độ thai sản
        void LoadData1()
        {
            DataTable dtTS = data.DataReader("Select * from TblCDThaiSan");
            dgvTS.DataSource = dtTS;

            //Lấy thông tin mã nhân viên
            DataTable dtNV = data.DataReader("Select * from TblTTNVCoBan");
            functions.FillComboBox(cbbMaNVTS, dtNV, "MaNV", "MaNV");

        }
        void ResetValue1()
        {
            cbbMaNVTS.Text = "";
            txtMaBP.Text = "";
            txtMaPhong.Text = "";
            txtHoTen.Text = "";
            txtGhiChuTS.Text = "";
            txtTroCap.Text = "";
            dtNgaySinh.Value = DateTime.Today;
            dtNgayTroLai.Value = DateTime.Today;
            dtNgayVeSinh.Value = DateTime.Today;
            dtNgayVeSom.Value = DateTime.Today;
            cbbMaNVTS.Focus();
            btnMoiTS.Enabled = true;
            btnLuuTS.Enabled = true;
            btnSuaTS.Enabled = false;
            btnBoQuaTS.Enabled = false;
            btnXoaTS.Enabled = false;
        }


        private void btnMoiTS_Click(object sender, EventArgs e)
        {
            ResetValue1();
        }

        private void btnLuuTS_Click(object sender, EventArgs e)
        {
            if (cbbMaNVTS.Text.Trim() == "")
            {
                errTS.SetError(cbbMaNVTS, "Bạn phải chọn mã nhân viên!");
                MessageBox.Show("Bạn phải chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaNVTS.Focus();
                return;
            }
            else
            {
                errTS.Clear();
            }

            if (txtMaBP.Text.Trim() == "")
            {
                errTS.SetError(txtMaBP, "Bạn phải nhập mã bộ phận!");
                MessageBox.Show("Bạn phải nhập mã bộ phận!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBP.Focus();
                return;
            }
            else
            {
                errTS.Clear();
            }

            if (txtMaPhong.Text.Trim() == "")
            {
                errTS.SetError(txtMaPhong, "Bạn phải nhập mã phòng!");
                MessageBox.Show("Bạn phải nhập mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }
            else
            {
                errTS.Clear();
            }

            if (txtHoTen.Text.Trim() == "")
            {
                errTS.SetError(txtHoTen, "Bạn phải nhập họ tên nhân viên!");
                MessageBox.Show("Bạn phải nhập họ tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            else
            {
                errTS.Clear();
            }
            if (txtTroCap.Text.Trim() == "")
            {
                errTS.SetError(txtTroCap, "Bạn phải nhập trợ cấp của công ty!");
                MessageBox.Show("Bạn phải nhập trợ cấp của công ty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            else
            {
                errTS.Clear();
            }

            // Kiểm tra có trùng mã nhân viên ko
            DataTable dtTS = data.DataReader("Select * from TblCDThaiSan where MaNV='" + cbbMaNVTS.SelectedValue + "'");
            if (dtTS.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã có, mời bạn nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaNVTS.Focus();
                return;
            }
            //Thêm mới hàng vào DataBase 
            string sqlInsert1 = "insert into TblCDThaiSan values('" + cbbMaNVTS.SelectedValue + "','" + txtMaBP.Text + "','" + txtMaPhong.Text
                + "',N'" + txtHoTen.Text + "',N'" + dtNgaySinh.Text + "',N'" + dtNgayVeSom.Text + "',N'" + dtNgayVeSinh.Text
                + "',N'" + dtNgayTroLai.Text + "'," + int.Parse(txtTroCap.Text) + ",N'" + txtGhiChuTS.Text + "')";
            data.DataChange(sqlInsert1);
            LoadData1();
            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue1();
        }

        private void btnSuaTS_Click(object sender, EventArgs e)
        {
            data.DataChange("update TblCDThaiSan set MaBP='" + txtMaBP.Text + "',MaPhong='" + txtMaPhong.Text +
                  "',HoTen=N'" + txtHoTen.Text + "',NgaySinh=N'" + dtNgaySinh.Text + "',NgayVeSom=N'" +
                dtNgayVeSom.Text + "',NgayNghiSinh=N'" + dtNgayVeSinh.Text + "',NgayLamTroLai=N'" + dtNgayTroLai.Text +
                "',TroCapCTy=" + int.Parse(txtTroCap.Text) + ",GhiChu=N'" + txtGhiChuBH.Text + "' where MaNV='" + cbbMaNVTS.Text + "'");
            LoadData1();
            MessageBox.Show("Bạn đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue1();
        }

        private void btnBoQuaTS_Click(object sender, EventArgs e)
        {
            ResetValue1();
        }

        private void dgvTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaNVTS.Text = dgvTS.CurrentRow.Cells[0].Value.ToString();
            txtMaBP.Text = dgvTS.CurrentRow.Cells[1].Value.ToString();
            txtMaPhong.Text = dgvTS.CurrentRow.Cells[2].Value.ToString();
            txtHoTen.Text = dgvTS.CurrentRow.Cells[3].Value.ToString();
            dtNgaySinh.Text = dgvTS.CurrentRow.Cells[4].Value.ToString();
            dtNgayVeSom.Text = dgvTS.CurrentRow.Cells[5].Value.ToString();
            dtNgayVeSinh.Text = dgvTS.CurrentRow.Cells[6].Value.ToString();
            dtNgayTroLai.Text = dgvTS.CurrentRow.Cells[7].Value.ToString();
            txtTroCap.Text = dgvTS.CurrentRow.Cells[8].Value.ToString();
            txtGhiChuTS.Text = dgvTS.CurrentRow.Cells[9].Value.ToString();
            btnMoiTS.Enabled = false;
            btnLuuTS.Enabled = false;
            btnSuaTS.Enabled = true;
            btnXoaTS.Enabled = true;
            btnBoQuaTS.Enabled = true;
            btnThoatTS.Enabled = true;
        }

        private void btnXoaTS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                data.DataChange("delete from TblCDThaiSan where MaNV='" + cbbMaNVTS.Text + "'");
                LoadData1();
                MessageBox.Show("Bạn đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValue1();
            }
        }

        private void btnThoatTS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}