namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblTTNVCoBan")]
    public partial class TblTTNVCoBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblTTNVCoBan()
        {
            TblThaiSans = new HashSet<TblThaiSan>();
        }

        [Required]
        [StringLength(10)]
        public string MaBoPhan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Key]
        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string MaLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string TTHonNhan { get; set; }

        [StringLength(50)]
        public string CMTND { get; set; }

        [StringLength(50)]
        public string NoiCap { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [StringLength(50)]
        public string LoaiHD { get; set; }

        [StringLength(10)]
        public string ThoiGian { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public virtual TblPhongBan TblPhongBan { get; set; }

        public virtual TblCongKhoiDieuHanh TblCongKhoiDieuHanh { get; set; }

        public virtual TblCongKhoiVanPHong TblCongKhoiVanPHong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblThaiSan> TblThaiSans { get; set; }

        public virtual TblTTCaNhan TblTTCaNhan { get; set; }
    }
}
