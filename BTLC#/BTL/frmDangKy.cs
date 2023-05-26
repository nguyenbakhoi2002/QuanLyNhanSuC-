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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        BTL.Classes.ConnectData dtbase = new BTL.Classes.ConnectData();
        void Loaddata()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-TQ23O8D\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

            DataTable dtuser = dtbase.DataReader("Select * from tbuser");
            dataGridView1.DataSource = dtuser;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-TQ23O8D\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

            dataGridView1.DataSource = dtbase.DataReader("Select * from tbuser");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTieuDe.Text = "QUẢN LÝ TÀI KHOẢN ";

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            try
            {
                //Hien thi nut sua
                //btnSua.Enabled = true;
                //btnXoa.Enabled = true;
                //btnThem.Enabled = false;
                txtTenDN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMatKhau.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtQuyen.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTenThat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dtNgaySinh.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = " ";
            txtMatKhau.Text = "";
            txtQuyen.Text = " ";
            txtTenThat.Text = " ";
            dtNgaySinh.Value = DateTime.Today;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //  DataTable dtcheckdn = dtbase.DataReader("Select * from tbuser where Username ='" + txtTenDN.Text + "'");
            txtTenDN.Enabled = true;
            lblTieuDe.Text = "THÊM TÀI KHOẢN ";
            errorProvider1.Clear();


        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "SỬA TÀI KHOẢN ";

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtTenDN.Enabled = false;
            errorProvider1.SetError(txtTenDN, " Khong duoc thay doi du lieu cho truong nay");


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "XÓA TÀI KHOẢN ";

            btnThem.Enabled = false;
            btnSua.Enabled = false;

            txtTenDN.Enabled = false;
            errorProvider1.Clear();



        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            //Chúng ta sử dụng control ErrorProvider để hiển thị lỗi
            //Kiểm tra tên DN có bị để trống không
            if (txtTenDN.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenDN, "Bạn không để trống tên DN!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            //Kiểm tra pass có bị để trống không
            if (txtMatKhau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMatKhau, "Bạn không để trống MK!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            //Kiểm tra tên that có bị để trống không
            if (txtTenThat.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTenThat, "Bạn không để trống tên that!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            //Kiểm tra quyen có bị để trống không
            if (txtQuyen.Text.Trim() == "")
            {
                errorProvider1.SetError(txtQuyen, "Bạn không để trống tên sản phẩm!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            //Kiểm tra ngày sinh, lỗi nếu người sử dụng nhập vào ngày sản xuất lớn hơn ngày hiện tại
            if (dtNgaySinh.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtNgaySinh, "Ngày sinh không hợp lệ!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }


            //Nếu nút Thêm enable thì thực hiện thêm mới
            //Dùng ký tự N' trước mỗi giá trị kiểu text để insert giá trị có dấu tiếng việt vào CSDL được đúng
            if (btnThem.Enabled == true)
            { //Kiểm tra xem ô nhập MaSP có bị trống không if

                if (txtTenDN.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtTenDN, "Bạn không để trống trường này!");
                    return;
                }
                else
                { //Kiểm tra xem mã sản phẩm đã tồn tại chưa đẻ tránh việc insert mới bị lỗi
                    sql = "Select * From tbuser Where Username ='" + txtTenDN.Text +
                   "'";
                    DataTable dtSP = dtbase.DataReader(sql);
                    if (dtSP.Rows.Count > 0)
                    {
                        errorProvider1.SetError(txtTenDN, "Ten DN trùng trong cơ sở dữ liệu");
                        return;
                    }
                    errorProvider1.Clear();
                }
                //Insert vao CSDL
                // them moi vao data
                if (MessageBox.Show("Bạn có muốn thêm tài khoản với user là " + txtTenDN.Text + " không ? ", "TB", MessageBoxButtons.YesNo,
    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "INSERT INTO tbuser ( Username, Pass, Quyen, Ten, Ngaysinh ) VALUES(";
                    sql += "N'" + txtTenDN.Text + "',N'" + txtMatKhau.Text + "',N'" + txtQuyen.Text + "','" +
                      txtTenThat.Text + "','" + dtNgaySinh.Value.ToShortDateString().ToString() + "')";

                    dtbase.DataChange(sql);
                    Loaddata();
                    MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

            //Nếu nút Sửa enable thì thực hiện cập nhật dữ liệu
            if (btnSua.Enabled == true)
            {
                if (MessageBox.Show("Bạn có muốn sửa tài khoản với user là " + txtTenDN.Text + " không ? ", "TB", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "Update tbuser SET ";
                    //  sql += "Username = N'" + txtTenDN.Text + "',";
                    sql += "Pass = N'" + txtMatKhau.Text + "',";
                    sql += "Quyen = N'" + txtQuyen.Text + "',";
                    sql += "Ten = N'" + txtTenThat.Text + "', ";
                    sql += "Ngaysinh = '" + dtNgaySinh.Value.Date + "'";
                    sql += "Where Username = N'" + txtTenDN.Text + "'";

                    dtbase.DataChange(sql);
                    Loaddata();
                    MessageBox.Show("Sửa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

            //Nếu nút Xóa enable thì thực hiện xóa dữ liệu
            if (btnXoa.Enabled == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa tài khoản với user là " + txtTenDN.Text + " không?", "TB", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "Delete From tbuser Where Username =N'" + txtTenDN.Text + "'";
                    dtbase.DataChange(sql);
                    Loaddata();
                    MessageBox.Show("Xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            lblTieuDe.Text = "QUẢN LÝ TÀI KHOẢN ";
        }
        private void frmDangKy_Load_1(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
