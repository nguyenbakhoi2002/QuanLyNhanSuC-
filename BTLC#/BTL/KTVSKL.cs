namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KTVSKL")]
    public partial class KTVSKL
    {
        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public int? Thang { get; set; }

        public int? Nam { get; set; }

        public int? MucKT { get; set; }

        public int? MucKL { get; set; }

        public string LyDo { get; set; }
    }
}
