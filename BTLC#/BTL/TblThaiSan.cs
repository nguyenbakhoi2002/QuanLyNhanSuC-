namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblThaiSan")]
    public partial class TblThaiSan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        public DateTime? NgayVeSom { get; set; }

        public DateTime? NgayNghiSinh { get; set; }

        public DateTime? NgayLamTroLai { get; set; }

        public int? TroCapCTY { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual TblTTNVCoBan TblTTNVCoBan { get; set; }
    }
}
