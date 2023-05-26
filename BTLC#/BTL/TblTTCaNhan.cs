namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblTTCaNhan")]
    public partial class TblTTCaNhan
    {
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string NoiSinh { get; set; }

        [StringLength(50)]
        public string NguyenQuan { get; set; }

        [StringLength(100)]
        public string DCThuongChu { get; set; }

        [StringLength(100)]
        public string DCTamChu { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string DanToc { get; set; }

        [StringLength(20)]
        public string TonGiao { get; set; }

        [StringLength(20)]
        public string QuocTich { get; set; }

        [StringLength(30)]
        public string HocVan { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual TblTTNVCoBan TblTTNVCoBan { get; set; }
    }
}
