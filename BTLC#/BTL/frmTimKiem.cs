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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        BTL.Classes.ConnectData data = new BTL.Classes.ConnectData();
        int i = 0;

        private void rdMaNV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void rdCMTND_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNhap.Text == "") || (txtNhap.Text == "Nhập từ khóa tim kiếm"))
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (rdCMTND.Checked == false && rdHoTen.Checked == false && rdMaNV.Checked == false)
                    {
                        MessageBox.Show("Vui lòng chọn chủ đề bạn muốn tìm kiếm");
                    }
                    else
                    {
                        if (i == 1)
                        {
                            dgvTimKiem.DataSource = data.DataReader("select * from TblTTNVCoBan where MaNV=N'" + txtNhap.Text + "'");

                        }
                        if (i == 2)
                        {
                            dgvTimKiem.DataSource = data.DataReader("select * from TblTTNVCoBan where HoTen like N'%" + txtNhap.Text + "%'");
                        }
                        if (i == 3)
                        {
                            dgvTimKiem.DataSource = data.DataReader("select * from TblTTNVCoBan where CMTND=N'" + txtNhap.Text + "'");
                        }
                    }
                    
                }
            }
                
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "Nhập từ khóa tim kiếm")
            {
                txtNhap.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        
    }
}
