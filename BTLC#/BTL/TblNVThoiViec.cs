namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblNVThoiViec")]
    public partial class TblNVThoiViec
    {
        [StringLength(50)]
        public string HoTen { get; set; }

        [Key]
        [StringLength(50)]
        public string CMTND { get; set; }

        public DateTime? NgayThoiViec { get; set; }

        [StringLength(50)]
        public string LyDo { get; set; }
    }
}
