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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-TQ23O8D\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");
            try
            {
                string q;
                sqlConnection.Open();
                string tk = txtusername.Text.Trim();
                string mk = txtpassword.Text.Trim();
                string sql = "select * from tbuser where Username= '" + tk + "' and Pass= '" + mk + "'";
                
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader data = cmd.ExecuteReader();
                frmMain.userName = txtusername.Text;




                if (data.Read() == true)
                {
                    q = data[2].ToString();
                    q=q.Trim();
                    this.Hide();
                    //frmCoBan.Username = txtusername.Text;
                    frmMain Main = new frmMain(q);
                    Main.Show();


                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác !!!!!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtusername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Kết nối lỗi","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Tên đăng nhập")
            {
                txtusername.Text = "";
            }
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            hide.Enabled = true;
            if (txtpassword.Text == "Mật khẩu")
            {
                txtpassword.Text = "";
                txtpassword.PasswordChar = '*';
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            show.Hide();

            if (txtpassword.PasswordChar == '*')
            {
                txtpassword.PasswordChar = '\0';
            }
            
            hide.Show();
            show.Hide();
        }

        private void hide_Click(object sender, EventArgs e)
        {

            if (txtpassword.PasswordChar == '\0')
            {
                txtpassword.PasswordChar = '*';
            }
            hide.Hide();
            show.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
