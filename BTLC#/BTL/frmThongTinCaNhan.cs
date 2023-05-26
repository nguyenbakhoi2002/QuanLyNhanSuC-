using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL
{
    public partial class frmThongTinCaNhan : Form
    {
        BTL.Classes.ConnectData dtbase = new BTL.Classes.ConnectData();
        BTL.Classes.CommonFunctions cf = new BTL.Classes.CommonFunctions();
        private string tenAnh;

        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }
        private void New()
        {
            cbbMaNV.Text = "";
            txtHoTen.Text = "";
            txtNoiSinh.Text = "";
            txtDanToc.Text = "";
            txtTonGiao.Text = "";
            txtThuongTru.Text = "";
            txtTamTru.Text = "";
            txtNguyenQuan.Text = "";
            txtQuocTich.Text = "";
            txtHocVan.Text = "";
            txtSDT.Text = "";
            txtGhiChu.Text = "";
            ptbAnh.Image = null;

            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            cbbMaNV.Enabled = true;
        }
        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtbase.DataReader("select * from TblTTCaNhan");

            cf.FillComboBox("SELECT MaNV FROM TblTTNVCoBan", cbbMaNV, "MaNV", "MaNV");
            
            this.New();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            this.New();
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cf.loadtextboxchiso(txtHoTen, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 1);
            cf.loadtextboxchiso(txtNoiSinh, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 2);
            cf.loadtextboxchiso(txtDanToc, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 7);
            cf.loadtextboxchiso(txtTonGiao, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 8);
            cf.loadtextboxchiso(txtThuongTru, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 4);
            cf.loadtextboxchiso(txtTamTru, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 5);
            cf.loadtextboxchiso(txtNguyenQuan, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 3);
            cf.loadtextboxchiso(txtQuocTich, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 9);
            cf.loadtextboxchiso(txtHocVan, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 10);
            cf.loadtextboxchiso(txtSDT, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 6);
            cf.loadtextboxchiso(txtGhiChu, "select * from TblTTCaNhan where MaNV='" + cbbMaNV.Text + "'", 11);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                for (int i = 0; i < cbbMaNV.Items.Count; i++)
                {
                    cbbMaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtHoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtNoiSinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtDanToc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtTonGiao.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txtThuongTru.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txtTamTru.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    txtNguyenQuan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    txtQuocTich.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    txtHocVan.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    txtSDT.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    txtGhiChu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

                    try
                    {   
                        tenAnh = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                        var path = Path.GetFullPath("Image\\" + tenAnh);
                        ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                        ptbAnh.Image = Image.FromFile(path);
                        
            }
                    catch
                    {
                        ptbAnh.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            cbbMaNV.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbbMaNV.Text.Trim() == "")
            {
                errorDanhmuc.SetError(cbbMaNV, "Bạn không để trống mã nhân viên!");
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
            if (txtNoiSinh.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtNoiSinh, "Bạn không để trống nơi sinh!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtDanToc.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtDanToc, "Bạn không để trống dân tộc!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtTonGiao.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtTonGiao, "Bạn không để trống tôn giáo!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtThuongTru.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtThuongTru, "Bạn không để trống địa chỉ thường trú!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtTamTru.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtTamTru, "Bạn không để trống địa chỉ tạm trú!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtNguyenQuan.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtNguyenQuan, "Bạn không để trống nguyên quán!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtQuocTich.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtQuocTich, "Bạn không để trống quốc tịch!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtHocVan.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtHocVan, "Bạn không để trống học vấn!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            if (txtSDT.Text.Trim() == "")
            {
                errorDanhmuc.SetError(txtSDT, "Bạn không để trống số điện thoại!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }

            string sql = "Select * From TblTTCaNhan Where MaNV = " + cbbMaNV.Text;
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                errorDanhmuc.SetError(cbbMaNV, "Mã nhân viên trùng trong cơ sở dữ liệu!");
                return;
            }
            else
            {
                errorDanhmuc.Clear();
            }
            try
            {
                bool k = false;

                var path = Path.GetFullPath("Image");
                path += "\\" + tenAnh;

                if (ptbAnh.Image != null && !File.Exists(path))
                {
                    ptbAnh.Image.Save(path, ImageFormat.Jpeg);
                    k = true;

                }
                else
                {
                    k = true;
                }

                if(ptbAnh.Image == null) k = false;

                sql = "insert into TblTTCaNhan(MaNV, HoTen, NoiSinh, DanToc, TonGiao, DCThuongChu, DCTamChu, NguyenQuan, QuocTich, HocVan, SDT, GhiChu, Anh) values" +
                "(N'" + cbbMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + txtNoiSinh.Text + "',N'" + txtDanToc.Text + "',N'" + txtTonGiao.Text + "',N'" + txtThuongTru.Text +
                "',N'" + txtTamTru.Text + "',N'" + txtNguyenQuan.Text + "',N'" + txtQuocTich.Text + "',N'" + txtHocVan.Text + "',N'" +
                txtSDT.Text + "',N'" + txtGhiChu.Text + "',N'" + (k ? tenAnh : "NULL.jpg") + "')";

                dtbase.DataChange(sql);

                sql = "Select * from TblTTCaNhan";
                dataGridView1.DataSource = dtbase.DataReader(sql);


                MessageBox.Show("Thêm thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không chính xác","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            this.New();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string k = "";
                var path = Path.GetFullPath("Image");
                    path += "\\" + tenAnh;

                if (ptbAnh.Image != null && !File.Exists(path))
                {
                    ptbAnh.Image.Save(path, ImageFormat.Jpeg);
                }
                else
                {
                    k = tenAnh;
                }

                string sql = "update TblTTCaNhan set HoTen=N'" + txtHoTen.Text + "',Noisinh=N'" + txtNoiSinh.Text + "',NguyenQuan=N'" + txtNguyenQuan.Text + "',DCThuongChu=N'" + txtThuongTru.Text + "',DCTamChu=N'" + txtTamTru.Text + "',SDT=N'" + txtSDT.Text + "',DanToc=N'" + txtDanToc.Text + "',TonGiao=N'" + txtTonGiao.Text + "',QuocTich=N'" + txtQuocTich.Text + "',HocVan=N'" + txtHocVan.Text + "',GhiChu=N'" + txtGhiChu.Text
                    + "',Anh=N'" + k + "' where MaNV=N'" + cbbMaNV.Text + "'";

                dtbase.DataChange(sql);
                sql = "Select * from TblTTCaNhan";
                dataGridView1.DataSource = dtbase.DataReader(sql);

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;

            cbbMaNV.Enabled = true;
            cbbMaNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa mã nhân viên " +
                cbbMaNV.Text + " không ? Nếu có ấn nút Yes, không thì ấn nút No",
                "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = "Delete From TblTTCaNhan Where MaNV =N'" + cbbMaNV.Text + "'";
                    dtbase.DataChange(sql);
                    sql = "select * from TblTTCaNhan";
                    dataGridView1.DataSource = dtbase.DataReader(sql);
                    
                    this.New();

                    btnLuu.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;

                    cbbMaNV.Enabled = true;
                    cbbMaNV.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            string[] image;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Images|*.jpg|PNG Images|*.png|All files(*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Title = "Chọn ảnh để hiển thị";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbAnh.Image = Image.FromFile(openFileDialog.FileName);
                image = openFileDialog.FileName.ToString().Split('\\');
                tenAnh = image[image.Length - 1];
            }
            else
            {
                MessageBox.Show("Ban đã chọn hủy", "Open Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
