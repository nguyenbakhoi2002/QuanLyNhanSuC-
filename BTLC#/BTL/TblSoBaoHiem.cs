namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblSoBaoHiem")]
    public partial class TblSoBaoHiem
    {
        [Key]
        [StringLength(50)]
        public string MaSoBH { get; set; }

        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string MaLuong { get; set; }

        public DateTime? NgayCapSo { get; set; }

        [StringLength(50)]
        public string NoiCapSo { get; set; }

        public string GhiChu { get; set; }
    }
}
