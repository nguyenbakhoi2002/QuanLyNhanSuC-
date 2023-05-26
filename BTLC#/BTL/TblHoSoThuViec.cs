namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblHoSoThuViec")]
    public partial class TblHoSoThuViec
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaNVTV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string TDHocVan { get; set; }

        [StringLength(50)]
        public string HocHam { get; set; }

        [StringLength(50)]
        public string ViTriThuViec { get; set; }

        public DateTime? NgayTV { get; set; }

        [StringLength(50)]
        public string ThangTV { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
