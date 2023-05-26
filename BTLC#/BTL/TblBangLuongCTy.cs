namespace BTL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblBangLuongCTy")]
    public partial class TblBangLuongCTy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblBangLuongCTy()
        {
            TblCongKhoiDieuHanhs = new HashSet<TblCongKhoiDieuHanh>();
        }

        [Key]
        [StringLength(10)]
        public string MaLuong { get; set; }

        public int? LCB { get; set; }

        public int? PCChucVu { get; set; }

        public DateTime? NgayNhap { get; set; }

        public int? LCBMoi { get; set; }

        public DateTime? NgaySua { get; set; }

        [StringLength(50)]
        public string LyDo { get; set; }

        public int? PCCVuMoi { get; set; }

        public DateTime? NgaySuaPC { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCongKhoiDieuHanh> TblCongKhoiDieuHanhs { get; set; }
    }
}
