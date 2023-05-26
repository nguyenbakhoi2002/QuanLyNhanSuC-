using Microsoft.Reporting.WinForms;
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
    public partial class BCNhanVien : Form
    {
        public BCNhanVien()
        {
            InitializeComponent();
        }

        private void BCNhanVien_Load(object sender, EventArgs e)
        {
            Model1 context=new Model1();
            List<TblTTNVCoBan> listNhanVien = context.TblTTNVCoBans.ToList();
            List<NhanVienReport> listReport = new List<NhanVienReport>();
            foreach(TblTTNVCoBan nv in listNhanVien)
            {
                //gán temp = dữ liệu trong listnv
                NhanVienReport temp = new NhanVienReport();
                temp.MaBP = nv.MaBoPhan;
                temp.MaPhong = nv.MaPhong;
                temp.MaNV = nv.MaNV;
                temp.HoTen = nv.HoTen;
                temp.MaLuong = nv.MaLuong;
                temp.NgaySinh = nv.NgaySinh.Value.Date.ToString();
                temp.GioiTinh= nv.GioiTinh;
                temp.TTHN = nv.TTHonNhan;
                temp.CMTND = nv.CMTND;
                temp.NoiCap = nv.NoiCap;
                temp.ChucVu = nv.ChucVu;
                temp.LoaiHD = nv.LoaiHD;
                temp.ThoiGian = nv.ThoiGian;
                temp.NgayKy = nv.NgayKy.Value.Date.ToString();
                temp.NgayHH = nv.NgayHetHan.Value.Date.ToString();
                temp.GhiChu = nv.GhiChu;

                //add dữ liệu vào listreport
                listReport.Add(temp);
            }
            //gán dữ liệu vào reportviewer1
            reportViewer1.LocalReport.ReportPath = "rptNhanVien.rdlc";
            //add toàn bộ giá trị trong listreprt cho dataset
            var source = new ReportDataSource("DataSet1", listReport);
            //
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            //
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
