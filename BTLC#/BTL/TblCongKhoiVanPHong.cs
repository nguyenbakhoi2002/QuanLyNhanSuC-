namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblCongKhoiVanPHong")]
    public partial class TblCongKhoiVanPHong
    {
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }

        public int? LCB { get; set; }

        [StringLength(4)]
        public string PhuCapCVu { get; set; }

        public int? PhuCapKhac { get; set; }

        [StringLength(10)]
        public string Thang { get; set; }

        [StringLength(19)]
        public string Nam { get; set; }

        public int? SoNgayCongThang { get; set; }

        public int? SoNgayNghi { get; set; }

        public int? SoGioLamThem { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual TblTTNVCoBan TblTTNVCoBan { get; set; }
    }
}
