namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblPhongBan")]
    public partial class TblPhongBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblPhongBan()
        {
            TblTTNVCoBans = new HashSet<TblTTNVCoBan>();
        }

        [Required]
        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [Key]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        public DateTime? NgayThanhLap { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual TblBoPhan TblBoPhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblTTNVCoBan> TblTTNVCoBans { get; set; }
    }
}
