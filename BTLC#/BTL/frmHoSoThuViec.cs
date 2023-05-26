using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL
{
    public partial class frmHoSoThuViec : Form
    {
        BTL.Classes.ConnectData dtbase = new BTL.Classes.ConnectData();
        BTL.Classes.CommonFunctions cf = new BTL.Classes.CommonFunctions();
        public frmHoSoThuViec()
        {
            InitializeComponent();
        }

        private void frmHoSoThuViec_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtbase.DataReader("select * from TblHoSoThuViec");

            cf.FillComboBox("SELECT MaPhong FROM Tblphongban", cbbMaPhong, "MaPhong", "MaPhong");

            this.New();
        }
        private void New()
        {
            cbbMaPhong.Text = "";
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dtNgaySinh.Value = DateTime.Today;
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtTrinhDo.Text = "";
            txtHocHam.Text = "";
            txtViTriTV.Text = "";
            dtNgayTV.Value = DateTime.Today;
            txtThangTV.Text = "";
            txtGhiChu.Text = "";


            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            cbbMaPhong.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbMaPhong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMaNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtHoTen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                txtGioiTinh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtTrinhDo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtHocHam.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtViTriTV.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                dtNgayTV.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value);
                txtThangTV.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtGhiChu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            cbbMaPhong.Enabled = false;
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            this.New();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbbMaPhong.Text.Trim() == "")
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
            if (txtGioiTinh.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtGioiTinh, "Bạn không để trống giới tính!");
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
            if (txtDiaChi.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtDiaChi, "Bạn không để trống địa chỉ!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtThangTV.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtThangTV, "Bạn không để trống tháng thử việc!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtViTriTV.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtViTriTV, "Bạn không để trống vị trí thử việc!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtTrinhDo.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtTrinhDo, "Bạn không để trống trình độ!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtHocHam.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtHocHam, "Bạn không để trống học hàm!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }

            string sql = "select * from TblHoSoThuViec Where MaNVTV = " + txtMaNV.Text;
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
            try
            {
                sql = "insert into TblHoSoThuViec(MaPhong, MaNVTV, HoTen, NgaySinh, GioiTinh, DiaChi, TDHocVan, HocHam, ViTriThuViec, NgayTV, ThangTV, GhiChu) values" +
                    "('" + cbbMaPhong.Text + "',N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + "','" + dtNgaySinh.Value.ToString("yyyy-MM-dd") + "',N'" + txtGioiTinh.Text + "',N'" + txtDiaChi.Text + "',N'" + txtTrinhDo.Text + "',N'" + txtHocHam.Text + "',N'" + txtViTriTV.Text + "','" + dtNgayTV.Value.ToString("yyyy-MM-dd") + "',N'" + txtThangTV.Text + "',N'" + txtGhiChu.Text + "')";

                dtbase.DataChange(sql);

                sql = "Select * from TblHoSoThuViec";
                dataGridView1.DataSource = dtbase.DataReader(sql);


                MessageBox.Show("Thêm thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.New();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update TblHoSoThuViec set MaPhong=N'" + cbbMaPhong.Text + "',HoTen=N'" + txtHoTen.Text + "',NgaySinh='" + dtNgaySinh.Value.ToString("yyyy-MM-dd") + "',GioiTinh=N'" + txtGioiTinh.Text + "',DiaChi=N'" + txtDiaChi.Text + "',TDHocVan=N'" + txtTrinhDo.Text + "',HocHam=N'" + txtHocHam.Text + "',ViTriThuViec=N'" + txtViTriTV.Text + "',NgayTV='" + dtNgayTV.Value.ToString("yyyy-MM-dd") + "',ThangTV=N'" + txtThangTV.Text + "',GhiChu=N'" + txtGhiChu.Text +
                    "' where MaNVTV='" + txtMaNV.Text + "'";

                dtbase.DataChange(sql);

                sql = "Select * from TblHoSoThuViec";
                dataGridView1.DataSource = dtbase.DataReader(sql);

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            cbbMaPhong.Enabled = true;
            cbbMaPhong.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa mã nhân viên " +
                txtMaNV.Text + " không ? Nếu có ấn nút Yes, không thì ấn nút No",
                "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = "Delete From TblHoSoThuViec where MaNVTV =N'" + txtMaNV.Text + "'";
                    dtbase.DataChange(sql);
                    sql = "select * from TblHoSoThuViec";
                    dataGridView1.DataSource = dtbase.DataReader(sql);

                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;

                    cbbMaPhong.Enabled = true;
                    cbbMaPhong.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
