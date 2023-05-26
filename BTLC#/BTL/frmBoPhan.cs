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
    public partial class frmBoPhan : Form
    {
        Classes.ConnectData data = new Classes.ConnectData();
        public frmBoPhan()
        {
            InitializeComponent();

        }
        void ResetValue()
        {
            txtMaBP.Text = "";
            txtTenBP.Text = "";
            dtpNgayThanhLap.Text = "";
            txtGhiChu.Text = "";
            btnSuaBP.Enabled = false;
            btnXoaBP.Enabled = false;
            btnLuuBP.Enabled = true;

            errThongTinBP.Clear();

            txtMaBP.Focus();
            txtMaBP.Enabled = true;
        }
        public void LoadData()
        {
            DataTable dt = data.DataReader("select * from TblBoPhan");
            dgvBoPhan.DataSource = dt;
            ResetValue();
        }
        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvBoPhan.Columns[0].HeaderText = "Mã hàng";
            dgvBoPhan.Columns[1].HeaderText = "Tên Bộ Phận";
            dgvBoPhan.Columns[2].HeaderText = "Ngày thành lập";
            dgvBoPhan.Columns[3].HeaderText = "Ghi chú";
        }

        private void dgvBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBP.Text = dgvBoPhan.CurrentRow.Cells[0].Value.ToString();
            txtTenBP.Text = dgvBoPhan.CurrentRow.Cells[1].Value.ToString();
            dtpNgayThanhLap.Value = (DateTime)dgvBoPhan.CurrentRow.Cells[2].Value;
            txtGhiChu.Text = dgvBoPhan.CurrentRow.Cells[3].Value.ToString();
            btnSuaBP.Enabled = true;
            btnXoaBP.Enabled = true;
            btnLuuBP.Enabled = false;
            txtMaBP.Enabled = false;
            errThongTinBP.Clear();
        }

        private void btnThoatBP_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMoiBP_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnMoiBP_MouseEnter(object sender, EventArgs e)
        {
            btnMoiBP.UseVisualStyleBackColor = false;
            btnMoiBP.BackColor = Color.Pink;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnMoiBP.UseVisualStyleBackColor = true;
        }

        private void btnLuuBP_Click(object sender, EventArgs e)
        {
            //kiểm tra tính hợp lệ và đầy đủ của dữ liệu
            //không để trống mã sản phẩm
            if (txtMaBP.Text.Trim() == "")
            {
                errThongTinBP.SetError(txtMaBP, "không được để trống mã bộ phận");
                return;
            }
            else
            {
                errThongTinBP.Clear();
            }
            //không để trống tên bộ phận
            if (txtTenBP.Text.Trim() == "")
            {
                errThongTinBP.SetError(txtTenBP, "không được để trống tên bộ phận");
                return;
            }
            else
            {
                errThongTinBP.Clear();
            }
            DataTable dtcheckma = data.DataReader("select * from TblBoPhan where MaBoPhan=N'" + txtMaBP.Text + "'");
            if (dtcheckma.Rows.Count > 0)
            {
                MessageBox.Show("Mã Bộ phận đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBP.Focus();
                return;
            }
            //thêm mới hàng vào database
            string sqlInsert = "insert into TblBoPhan values('" + txtMaBP.Text + "',N'" + txtTenBP.Text + "','" + dtpNgayThanhLap.Value.Date + "',N'" + txtGhiChu.Text + "')";
            data.DataChange(sqlInsert);
            LoadData();
            MessageBox.Show("thêm mới thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue();
        }

        private void btnXoaBP_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chăc chắn muốn xóa", "Lưu Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    data.DataChange("delete TblBoPhan where MaBoPhan='" + txtMaBP.Text + "'");
                    LoadData();
                    ResetValue();
                    MessageBox.Show("xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Dữ liệu này có ràng buộc , bạn không được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSuaBP_Click(object sender, EventArgs e)
        {
            //không được dể trống tên bộ phận
            if (txtTenBP.Text.Trim() == "")
            {
                errThongTinBP.SetError(txtTenBP, "không được để trống tên bộ phận");
                return;
            }
            else
            {
                errThongTinBP.Clear();
            }
            //MessageBox.Show(dtpNgayThanhLap.Text);
            string sql = "update TblBoPhan set ";
            sql += "TenBoPhan = N'" + txtTenBP.Text + "',";
            sql += "NgayThanhLap = '" + dtpNgayThanhLap.Value.Date + "',";
            sql += "GhiChu = '" + txtGhiChu.Text + "' ";
            sql += "where MaBoPhan = N'" + txtMaBP.Text + "'";
            //MessageBox.Show(sql);
            data.DataChange(sql);
            LoadData();
            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValue();
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
            exRange.Value = "CÔNG TY TNHH";

            Excel.Range dc = (Excel.Range)exSheet.Cells[2, 1];
            dc.Font.Size = 13;
            dc.Font.Color = Color.Blue;
            dc.Value = "Số 156 - Hai Bà Trưng - Hà Nội";
            //In chữ Hóa đơn được bán
            exSheet.Range["C4"].Font.Size = 20;
            exSheet.Range["C4"].Font.Bold = true;
            exSheet.Range["C4"].Font.Color = Color.Red;
            exSheet.Range["C4"].Value = "THÔNG TIN BỘ PHẬN";

            //in dòng tiêu đề
            exSheet.Range["A6:G6"].Font.Size = 12;
            exSheet.Range["A6:G6"].Font.Bold = true;
            exSheet.Range["A6"].Value = "Số TT";
            exSheet.Range["B6"].Value = "Mã bộ phận";
            exSheet.Range["C6"].Value = "Tên bộ phận";
            exSheet.Range["D6"].Value = "ngày thành lập";
            exSheet.Range["E6"].Value = "ghi chú";
            exSheet.Range["D6"].ColumnWidth = 18;

            //in danh sách các bộ phận
            int dong = 7;
            for (int i = 0; i < dgvBoPhan.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvBoPhan.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvBoPhan.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = DateTime.Parse(dgvBoPhan.Rows[i].Cells[2].Value.ToString());
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvBoPhan.Rows[i].Cells[3].Value.ToString();
            }
            

            exBook.Activate();
            //lưu file
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Workbook|*.xlsx|Excel 97-2002 workbook|*.xls|All files|*.*";
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
                MessageBox.Show("In thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
