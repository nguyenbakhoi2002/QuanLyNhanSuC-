namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblCongKhoiDieuHanh")]
    public partial class TblCongKhoiDieuHanh
    {
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string MaLuong { get; set; }

        public int? LCB { get; set; }

        public int? PCChucVu { get; set; }

        public int? PCapKhac { get; set; }

        [StringLength(50)]
        public string Thuong { get; set; }

        [StringLength(50)]
        public string KyLuat { get; set; }

        [StringLength(10)]
        public string Thang { get; set; }

        [StringLength(19)]
        public string Nam { get; set; }

        public int? SoNgayCongThang { get; set; }

        public int? SoNgayNghi { get; set; }

        public int? SoGioLamThem { get; set; }

        public int? Luong { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual TblBangLuongCTy TblBangLuongCTy { get; set; }

        public virtual TblTTNVCoBan TblTTNVCoBan { get; set; }
    }
}
