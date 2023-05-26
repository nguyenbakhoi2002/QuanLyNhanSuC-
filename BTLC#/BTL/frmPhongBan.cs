using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace BTL
{
    public partial class frmPhongBan : Form
    {
        Classes.ConnectData dt = new Classes.ConnectData();
        Classes.CommonFunctions functions = new Classes.CommonFunctions();
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {

            dgv.DataSource = dt.DataReader("select * from tblphongban");
            DataTable tblphongban = dt.DataReader("select * from tblBoPhan");
            functions.FillComboBox(cbbMaBP, tblphongban, "TenBoPhan", "MaBoPhan");
            dgv.Columns[0].HeaderText = "Mã bộ phận";
            dgv.Columns[1].HeaderText = "Mã phòng";
            dgv.Columns[2].HeaderText = "Tên phòng";
            dgv.Columns[3].HeaderText = "Ngày Thành lập";
            dgv.Columns[4].HeaderText = "Ghi chú";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbbMaBP.SelectedValue = dgv.CurrentRow.Cells[0].Value.ToString();
                txtMaPhong.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txtTenPhong.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                dtNgayThanhLap.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txtGhiChu.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Hien thi nut sua
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {

            cbbMaBP.Text = "";
            txtTenPhong.Text = "";
            txtMaPhong.Text = "";
            dtNgayThanhLap.Text = "";
            txtGhiChu.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbbMaBP.Text.Trim() == "")
            {
                er.SetError(cbbMaBP, "Vui lòng không để mã bộ phận trống !");
                cbbMaBP.Focus();
                return;
            }
            else
            {
                er.Clear();
            }

            if (txtTenPhong.Text == "")
            {
                er.SetError(txtTenPhong, "Vui lòng không để tên phòng bị trống");
                txtTenPhong.Focus();
                MessageBox.Show("Vui lòng không để tên phòng bị trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                er.Clear();
            }

            if (txtMaPhong.Text.Trim() == "")
            {
                er.SetError(txtMaPhong, "Vui lòng không để mã phòng bị trống");
                txtMaPhong.Focus();
                MessageBox.Show("Vui lòng không để mã phòng bị trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                er.Clear();
            }

            if (dtNgayThanhLap.Text.Trim() == "")
            {
                er.SetError(dtNgayThanhLap, "Vui lòng không để ngày thành lập bị trống");
                dtNgayThanhLap.Focus();
                MessageBox.Show("Vui lòng không để ngày thành lập bị trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                er.Clear();
            }

            if (dtNgayThanhLap.Value > DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập ngày thành lập nhỏ hơn ngày hiện tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }
            else
            {
                er.Clear();
            }



            // Kiểm tra mã phòng có bị trùng không
            DataTable dtCheckMaPhong = dt.DataReader("select * from tblphongban where Maphong = '" + txtMaPhong.Text + "'");
            if (dtCheckMaPhong.Rows.Count > 0)
            {
                MessageBox.Show("Mã phòng đã có , bạn vui lòng nhập mã hàng khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }
            // thêm mới phòng ban
            string sqlInsert = "insert into tblphongban values('" + cbbMaBP.SelectedValue + "','" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "',N'" + dtNgayThanhLap.Text + "',N'" + txtGhiChu.Text + "')";

            dt.DataChange(sqlInsert);

            dgv.DataSource = dt.DataReader("select * from tblphongban");
            MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbbMaBP.Text = "";
            txtTenPhong.Text = "";
            txtMaPhong.Text = "";
            dtNgayThanhLap.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update tblphongban set Mabophan = '" + cbbMaBP.SelectedValue + "',TenPhong = N'" + txtTenPhong.Text + "',NgayThanhLap = N'" + dtNgayThanhLap.Text + "',GhiChu = N'" + txtGhiChu.Text + "' where MaPhong = N'" + txtMaPhong.Text + "'";
                dt.DataReader(update);
                dgv.DataSource = dt.DataReader("select * from tblphongban");
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không ?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    dt.DataChange("delete tblphongban where MaPhong = '" + txtMaPhong.Text + "'");
                    dgv.DataSource = dt.DataReader("select * from tblphongban");
                    cbbMaBP.Text = "";
                    txtTenPhong.Text = "";
                    txtMaPhong.Text = "";
                    dtNgayThanhLap.Text = "";
                    txtGhiChu.Text = "";

                }
                catch
                {
                    MessageBox.Show("Bạn không được xóa vì nó liên quan đến các hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không ạ?", " Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];// đưa con trỏ vào ô A1
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "CÔNG TY TNHH NĂM Thành Viên";

            Excel.Range dc = (Excel.Range)exSheet.Cells[2, 1];
            dc.Font.Size = 13;
            dc.Font.Color = Color.Blue;
            dc.Value = "Số 156 - Hai Bà Trưng - Hà Nội";
            //In chữ Hóa đơn được bán
            exSheet.Range["C4"].Font.Size = 20;
            exSheet.Range["C4"].Font.Bold = true;
            exSheet.Range["C4"].Font.Color = Color.Red;
            exSheet.Range["C4"].Value = "THÔNG TIN PHÒNG BAN";

            //in dòng tiêu đề
            exSheet.Range["A6:G6"].Font.Size = 12;
            exSheet.Range["A6:G6"].Font.Bold = true;
            exSheet.Range["A6"].Value = "Mã Bộ Phận";
            exSheet.Range["B6"].Value = "Mã Phòng";
            exSheet.Range["C6"].Value = "Tên Phòng";
            exSheet.Range["D6"].Value = "Ngày Thành lập";
            exSheet.Range["E6"].Value = "Ghi chú";
            exSheet.get_Range("A6").ColumnWidth = 15;
            exSheet.get_Range("B6").ColumnWidth = 12;
            exSheet.get_Range("C6").ColumnWidth = 12;
            exSheet.get_Range("D6").ColumnWidth = 15;
            exSheet.get_Range("E6").ColumnWidth = 12;

            //in danh sách các bộ phận
            int dong = 7;
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = dgv.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgv.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgv.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = DateTime.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                exSheet.Range["E" + (dong + i).ToString()].Value = dgv.Rows[i].Cells[4].Value.ToString();
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
