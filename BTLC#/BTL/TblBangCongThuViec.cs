namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblBangCongThuViec")]
    public partial class TblBangCongThuViec
    {
        [StringLength(10)]
        public string TenBoPhan { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        [Key]
        [StringLength(10)]
        public string MaNVTV { get; set; }

        public int? LuongTViec { get; set; }

        [StringLength(10)]
        public string Thang { get; set; }

        [StringLength(10)]
        public string Nam { get; set; }

        public int? SoNgayCong { get; set; }

        public int? SoNgayNghi { get; set; }

        public int? SoGioLamThem { get; set; }

        public double? Luong { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
