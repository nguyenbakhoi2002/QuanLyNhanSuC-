using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<a> a { get; set; }
        public virtual DbSet<TblBangLuongCTy> TblBangLuongCTies { get; set; }
        public virtual DbSet<TblBoPhan> TblBoPhans { get; set; }
        public virtual DbSet<TblNVThoiViec> TblNVThoiViecs { get; set; }
        public virtual DbSet<TblPhongBan> TblPhongBans { get; set; }
        public virtual DbSet<TblSoBaoHiem> TblSoBaoHiems { get; set; }
        public virtual DbSet<TblTTNVCoBan> TblTTNVCoBans { get; set; }
        public virtual DbSet<KTVSKL> KTVSKLs { get; set; }
        public virtual DbSet<TblBangCongThuViec> TblBangCongThuViecs { get; set; }
        public virtual DbSet<TblCongKhoiDieuHanh> TblCongKhoiDieuHanhs { get; set; }
        public virtual DbSet<TblCongKhoiVanPHong> TblCongKhoiVanPHongs { get; set; }
        public virtual DbSet<TblHoSoThuViec> TblHoSoThuViecs { get; set; }
        public virtual DbSet<TblThaiSan> TblThaiSans { get; set; }
        public virtual DbSet<TblTTCaNhan> TblTTCaNhans { get; set; }
        public virtual DbSet<tbuser> tbusers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<a>()
                .Property(e => e.Khoi)
                .IsFixedLength();

            modelBuilder.Entity<TblBangLuongCTy>()
                .Property(e => e.MaLuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblBoPhan>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblBoPhan>()
                .Property(e => e.TenBoPhan)
                .IsFixedLength();

            modelBuilder.Entity<TblBoPhan>()
                .Property(e => e.GhiChu)
                .IsFixedLength();

            modelBuilder.Entity<TblBoPhan>()
                .HasMany(e => e.TblPhongBans)
                .WithRequired(e => e.TblBoPhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TblPhongBan>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblPhongBan>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblPhongBan>()
                .HasMany(e => e.TblTTNVCoBans)
                .WithRequired(e => e.TblPhongBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TblTTNVCoBan>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTNVCoBan>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTNVCoBan>()
                .HasOptional(e => e.TblCongKhoiDieuHanh)
                .WithRequired(e => e.TblTTNVCoBan)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TblTTNVCoBan>()
                .HasOptional(e => e.TblCongKhoiVanPHong)
                .WithRequired(e => e.TblTTNVCoBan);

            modelBuilder.Entity<TblTTNVCoBan>()
                .HasOptional(e => e.TblTTCaNhan)
                .WithRequired(e => e.TblTTNVCoBan)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TblBangCongThuViec>()
                .Property(e => e.MaNVTV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblBangCongThuViec>()
                .Property(e => e.Thang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblBangCongThuViec>()
                .Property(e => e.Nam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblCongKhoiDieuHanh>()
                .Property(e => e.MaLuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblCongKhoiDieuHanh>()
                .Property(e => e.Thang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblCongKhoiDieuHanh>()
                .Property(e => e.Nam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblCongKhoiVanPHong>()
                .Property(e => e.PhuCapCVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblCongKhoiVanPHong>()
                .Property(e => e.Thang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblCongKhoiVanPHong>()
                .Property(e => e.Nam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblHoSoThuViec>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblHoSoThuViec>()
                .Property(e => e.MaNVTV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblThaiSan>()
                .Property(e => e.MaBoPhan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblThaiSan>()
                .Property(e => e.MaPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblTTCaNhan>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbuser>()
                .Property(e => e.Quyen)
                .IsFixedLength();
        }
    }
}
