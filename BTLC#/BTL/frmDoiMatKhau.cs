using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }


        private void btnHoanTat_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-TQ23O8D\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

            SqlDataAdapter check = new SqlDataAdapter("Select count (*) from tbuser where Username = N'" + txtTen.Text + "' and Pass = N'" + txtMKCu.Text + " '", sqlConnection);
            DataTable changpass = new DataTable();
            check.Fill(changpass);
            errorProvider1.Clear();
            if (changpass.Rows[0][0].ToString() == "1")
            {
                if (txtGoLaiMK.Text == txtMKMoi.Text)
                {
                    if (txtMKMoi.Text.Length >= 2 && txtMKMoi.Text != txtMKCu.Text)
                    {

                        SqlDataAdapter check1 = new SqlDataAdapter(" Update tbuser set Pass = N'" + txtMKMoi.Text + "' where  Username = N'" + txtTen.Text + "' and Pass = N'" + txtMKCu.Text + " '", sqlConnection);
                        DataTable changpass1 = new DataTable();
                        check1.Fill(changpass1);
                        MessageBox.Show("Đổi mật khẩu thành công ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        reset();
                    }
                    else
                        errorProvider1.SetError(txtMKMoi, "Độ dài mật khẩu phải lơn hơn 2 và khác mật khẩu cũ ");

                }

                else
                {
                    if (txtMKMoi.Text == "")
                    {
                        errorProvider1.SetError(txtMKMoi, "Bạn chưa điền mật khẩu mới");
                    }
                    if (txtMKMoi.Text != txtGoLaiMK.Text)
                    {
                        errorProvider1.SetError(txtGoLaiMK, "Mật khẩu nhập lại chưa đúng ");
                    }
                }

            }
            else
            {
                errorProvider1.SetError(txtTen, "Sai tên đăng nhập ");
                errorProvider1.SetError(txtMKCu, "Mật khẩu cũ không đúng ");
            }

        }
        void reset()
        {
            txtTen.Text = "";
            txtMKCu.Text = "";
            txtMKMoi.Text = "";
            txtGoLaiMK.Text = "";

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
