CREATE DATABASE [QLNS]
USE [QLNS]
GO
/****** Object:  Table [dbo].[a]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[a](
	[Khoi] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_a] PRIMARY KEY CLUSTERED 
(
	[Khoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KTVSKL]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KTVSKL](
	[MaNV] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[MucKT] [int] NULL,
	[MucKL] [int] NULL,
	[LyDo] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblBangCongThuViec]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBangCongThuViec](
	[TenBoPhan] [nvarchar](255) NULL,
	[TenPhong] [nvarchar](255) NULL,
	[MaNVTV] [nvarchar](255) NOT NULL,
	[LuongTViec] [int] NULL,
	[Thang] [nvarchar](255) NULL,
	[Nam] [nvarchar](255) NULL,
	[SoNgayCong] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[SoGioLamThem] [int] NULL,
	[Luong] [float] NULL,
	[GhiChu] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblBangLuongCTy]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBangLuongCTy](
	[MaLuong] [nvarchar](255) NOT NULL,
	[LCB] [int] NULL,
	[PCChucVu] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[LCBMoi] [int] NULL,
	[NgaySua] [datetime] NULL,
	[LyDo] [nvarchar](255) NULL,
	[PCCVuMoi] [int] NULL,
	[NgaySuaPC] [datetime] NULL,
	[GhiChu] [nvarchar](255) NULL,
 CONSTRAINT [PK_TblBangLuongCTy] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblBoPhan]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBoPhan](
	[MaBoPhan] [nvarchar](255) NOT NULL,
	[TenBoPhan] [nvarchar](255) NULL,
	[NgayThanhLap] [datetime] NULL,
	[GhiChu] [nvarchar](255) NULL,
 CONSTRAINT [PK_TblBoPhan] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCongKhoiDieuHanh]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCongKhoiDieuHanh](
	[MaNV] [nvarchar](255) NOT NULL,
	[TenPhong] [nvarchar](255) NULL,
	[HoTen] [nvarchar](255) NULL,
	[MaLuong]  [nvarchar](255) NULL,
	[LCB] [int] NULL,
	[PCChucVu] [int] NULL,
	[PCapKhac] [int] NULL,
	[Thuong] [nvarchar](255) NULL,
	[KyLuat] [nvarchar](255) NULL,
	[Thang]  [nvarchar](255) NULL,
	[Nam]  [nvarchar](255) NULL,
	[SoNgayCongThang] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[SoGioLamThem] [int] NULL,
	[Luong] [int] NULL,
	[GhiChu] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCongKhoiVanChuyen]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCongKhoiVanChuyen](
	[MaNV] [nvarchar](255) NULL,
	[LCB] [int] NULL,
	[PhuCapCVu] [int] NULL,
	[PCapKhac] [int] NULL,
	[Thang]  [nvarchar](255) NULL,
	[Nam]  [nvarchar](255) NULL,
	[SoNgayCongThang] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[SOGioLamThem] [int] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCongKhoiVanPHong]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCongKhoiVanPHong](
	[MaNV] [nvarchar](255) NOT NULL,
	[LCB] [int] NULL,
	[PhuCapCVu]  [nvarchar](255) NULL,
	[PhuCapKhac] [int] NULL,
	[Thang]  [nvarchar](255) NULL,
	[Nam]  [nvarchar](255) NULL,
	[SoNgayCongThang] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[SoGioLamThem] [int] NULL,
	[GhiChu]  [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblHoSoThuViec]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHoSoThuViec](
	[MaPhong]  [nvarchar](255) NOT NULL,
	[MaNVTV]  [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[TDHocVan] [nvarchar](255) NULL,
	[HocHam] [nvarchar](255) NULL,
	[ViTriThuViec] [nvarchar](255) NULL,
	[NgayTV] [datetime] NULL,
	[ThangTV] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblNVThoiViec]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblNVThoiViec](
	[HoTen] [nvarchar](255) NULL,
	[CMTND] [nvarchar](255) NOT NULL,
	[NgayThoiViec] [datetime] NULL,
	[LyDo] [nvarchar](255) NULL,
 CONSTRAINT [PK_TblNVThoiViec] PRIMARY KEY CLUSTERED 
(
	[CMTND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPhongBan]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPhongBan](
	[MaBoPhan]  [nvarchar](255) NOT NULL,
	[MaPhong]  [nvarchar](255) NOT NULL,
	[TenPhong] [nvarchar](255) NULL,
	[NgayThanhLap] [datetime] NULL,
	[GhiChu] [nvarchar](255) NULL,
 CONSTRAINT [PK_TblPhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSoBH]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSoBH](
	[MaNV] [nvarchar](255) NOT NULL,
	[MaLuong]  [nvarchar](255) NOT NULL,
	[MaSoBH]  [nvarchar](255) NOT NULL,
	[NgayCapSo] [datetime] NULL,
	[NoiCapSo]  [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTangLuong]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTangLuong](
	[MaNV] [nvarchar](255) NULL,
	[HoTen] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](255) NULL,
	[ChucVu] [nvarchar](255) NULL,
	[MaLuongCu]  [nvarchar](255) NULL,
	[MaLuongMoi]  [nvarchar](255) NULL,
	[NgayTang] [datetime] NULL,
	[LyDo] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTTCaNhan]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTTCaNhan](
	[MaNV] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[NoiSinh] [nvarchar](255) NULL,
	[NguyenQuan] [nvarchar](255) NULL,
	[DCThuongChu] [nvarchar](255) NULL,
	[DCTamChu] [nvarchar](255) NULL,
	[SDT]  [nvarchar](255) NULL,
	[DanToc] [nvarchar](255) NULL,
	[TonGiao] [nvarchar](255) NULL,
	[QuocTich] [nvarchar](255) NULL,
	[HocVan] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTTNVCoBan]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTTNVCoBan](
	[MaBoPhan]  [nvarchar](255) NOT NULL,
	[MaPhong]  [nvarchar](255) NOT NULL,
	[MaNV] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[MaLuong] [nvarchar](255) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](255) NULL,
	[TTHonNhan] [nvarchar](255) NULL,
	[CMTND] [nvarchar](255) NULL,
	[NoiCap] [nvarchar](255) NULL,
	[ChucVu] [nvarchar](255) NULL,
	[LoaiHD] [nvarchar](255) NULL,
	[ThoiGian] [nvarchar](255) NULL,
	[NgayKy] [date] NULL,
	[NgayHetHan] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_TblTTNVCoBan] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblThaiSan]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblThaiSan](
	[MaBoPhan]  [nvarchar](255) NOT NULL,
	[MaPhong]  [nvarchar](255) NOT NULL,
	[MaNV] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[NgaySinh] [datetime] NULL,
	[NgayVeSom] [datetime] NULL,
	[NgayNghiSinh] [datetime] NULL,
	[NgayLamTroLai] [datetime] NULL,
	[TroCapCTY] [int] NULL,
	[GhiChu] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbuser]    Script Date: 11/1/2022 10:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbuser](
	[Username] [nvarchar](255) NOT NULL,
	[Pass] [nvarchar](255) NULL,
	[Quyen]  [nvarchar](255) NULL,
	[Ten] [nvarchar](255) NULL,
	[Ngaysinh] [date] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[a] ([Khoi]) VALUES (N'DieuHanh  ')
GO
INSERT [dbo].[a] ([Khoi]) VALUES (N'SanXuat   ')
GO
INSERT [dbo].[a] ([Khoi]) VALUES (N'VanPhong  ')
GO
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kế toán   ', N'Kế toán 2', N'001       ', 3000000, N'5         ', N'2019      ', 23, 3, 8, 2973832, N'')
GO
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kỹ thuật  ', N'Kỹ thuật 2', N'003       ', 3000000, N'5         ', N'2019      ', 26, 0, 12, 3479984, N'')
GO
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kế toán   ', N'Kế toán 2', N'008       ', 3000000, N'5         ', N'2019      ', 26, 0, 10, 3399984, N'')
GO
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kỹ thuật  ', N'Kỹ thuật 1', N'009       ', 3000000, N'5         ', N'2019      ', 25, 1, 10, 3284600, N'')
GO
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kỹ thuật  ', N'Kỹ thuật 2', N'010       ', 3000000, N'5         ', N'2019      ', 25, 1, 15, 3484600, N'')
GO
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kế toán   ', N'Kế toán 1', N'0011      ', 3000000, N'5         ', N'2019      ', 24, 2, 10, 3169216, N'')
GO
INSERT [dbo].[TblBangLuongCTy] ([MaLuong], [LCB], [PCChucVu], [NgayNhap], [LCBMoi], [NgaySua], [LyDo], [PCCVuMoi], [NgaySuaPC], [GhiChu]) VALUES (N'ml1       ', 3000000, 500000, CAST(N'2019-05-13T00:00:00.000' AS DateTime), 3000000, CAST(N'2019-05-13T00:00:00.000' AS DateTime), N'ht', 5000000, CAST(N'2019-05-13T00:00:00.000' AS DateTime), N'ht')
GO
INSERT [dbo].[TblBangLuongCTy] ([MaLuong], [LCB], [PCChucVu], [NgayNhap], [LCBMoi], [NgaySua], [LyDo], [PCCVuMoi], [NgaySuaPC], [GhiChu]) VALUES (N'ml2       ', 4000000, 600000, CAST(N'2019-05-29T00:00:00.000' AS DateTime), 4000000, CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'sửa', 600000, CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'ht')
GO
INSERT [dbo].[TblBangLuongCTy] ([MaLuong], [LCB], [PCChucVu], [NgayNhap], [LCBMoi], [NgaySua], [LyDo], [PCCVuMoi], [NgaySuaPC], [GhiChu]) VALUES (N'ml3       ', 5000000, 700000, CAST(N'2019-05-29T00:00:00.000' AS DateTime), 5000000, CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'', 7000000, CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[TblBoPhan] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'mb01      ', N'Kế toán   ', CAST(N'2019-12-05T00:00:00.000' AS DateTime), N'      d   ')
GO
INSERT [dbo].[TblBoPhan] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'mb02      ', N'Kỹ thuật  ', CAST(N'2019-05-12T00:00:00.000' AS DateTime), N'          ')
GO
INSERT [dbo].[TblBoPhan] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'mb03      ', N'Kế hoạch  ', CAST(N'2019-05-12T00:00:00.000' AS DateTime), N'          ')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'001', N'Kế toán 1', N'Lê Văn Bình ', N'ml3       ', 5000000, 700000, 500000, N'200000', N'0', N'5         ', N'2019               ', 26, 0, 12, 5779996, N'nv')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'002', N'Kế toán 1', N'Nguyễn Văn Dũng', N'ml2       ', 4000000, 600000, 300000, N'300000', N'200000', N'5         ', N'2019               ', 24, 2, 10, 5092304, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'003', N'Kế toán 1', N'Lê Thị Mai Lan', N'ml2       ', 4000000, 600000, 300000, N'300000', N'0', N'5         ', N'2019               ', 25, 1, 14, 5606150, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'004', N'Kế toán 2', N'Tôn Văn Hùng', N'ml3       ', 5000000, 700000, 200000, N'200000', N'0', N'5         ', N'2019               ', 24, 2, 10, 6115368, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'005', N'Kỹ thuật 1', N'Nguyễn Văn Chung', N'ml1       ', 3000000, 500000, 0, N'300000', N'0', N'5         ', N'2019               ', 24, 2, 15, 4169216, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'006', N'Kỹ thuật 2', N'Ngô Sách Hiệp', N'ml2       ', 4000000, 600000, 0, N'0', N'0', N'5         ', N'2019               ', 26, 0, 10, 4999996, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'007', N'Kỹ thuật 2', N'Lê Văn Đại', N'ml3       ', 5000000, 700000, 200000, N'0', N'200000', N'5         ', N'2019               ', 26, 0, 13, 6219982, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'008', N'Kế hoạch 1', N'Phạm Thành Chung', N'ml1       ', 3000000, 500000, 200000, N'0', N'0', N'5         ', N'2019               ', 24, 2, 5, 3669216, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'009', N'Kế hoạch 1', N'Lê Quốc Bình', N'ml2       ', 4000000, 600000, 0, N'300000', N'0', N'5         ', N'2019               ', 26, 0, 10, 5299996, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'010', N'Kế toán 2', N'Nguyễn Mai Anh', N'ml2       ', 4000000, 600000, 0, N'300000', N'200000', N'5         ', N'2019               ', 23, 3, 4, 4398458, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'011', N'Kế hoạch 2', N'Nguyễn Chí Cường', N'ml1       ', 3000000, 500000, 0, N'200000', N'0', N'5         ', N'2019               ', 25, 1, 12, 4064600, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'012', N'Kế hoạch 2', N'Nguyễn Quốc Bình', N'ml3       ', 5000000, 700000, 0, N'0', N'300000', N'5         ', N'2019               ', 26, 0, 10, 5799982, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'013', N'Kỹ thuật 2', N'Trần Đình Chiến', N'ml3       ', 5000000, 700000, 0, N'0', N'200000', N'5         ', N'2019               ', 26, 0, 18, 6219982, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'014', N'Kỹ thuật 2', N'Nguyễn Văn An', N'ml2       ', 4000000, 600000, 0, N'300000', N'0', N'5         ', N'2019               ', 25, 1, 14, 5306150, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'015', N'Kỹ thuật 1', N'Ngô Thị Lan Anh', N'ml1       ', 3000000, 500000, 200000, N'200000', N'200000', N'5         ', N'2019               ', 26, 0, 16, 4339984, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'016', N'Kế toán 2', N'Ngô Đình Hưng', N'ml2       ', 4000000, 600000, 300000, N'300000', N'0', N'5         ', N'2019               ', 25, 1, 10, 5446150, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'017', N'Kế hoạch 2', N'Ngô Thị Huyền', N'ml2       ', 4000000, 600000, 300000, N'200000', N'0', N'5         ', N'2019               ', 24, 2, 14, 5352304, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'018', N'Kế hoạch 2', N'Nguyễn Việt Anh', N'ml2       ', 4000000, 600000, 0, N'0', N'0', N'5         ', N'2019               ', 26, 2019, 0, 4599996, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'019', N'Kỹ thuật 1', N'Vũ Văn Mạnh', N'ml2       ', 4000000, 600000, 0, N'0', N'0', N'5         ', N'2019               ', 26, 0, 10, 4999996, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'020', N'Kế toán 2', N'Nguyễn Tiến Thắng', N'ml1       ', 3000000, 500000, 200000, N'0', N'0', N'5         ', N'2019               ', 26, 0, 12, 4179984, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'021', N'Kỹ thuật 1', N'Dương Danh Sáng', N'ml3       ', 5000000, 700000, 200000, N'200000', N'0', N'5         ', N'2019               ', 24, 2, 12, 6195368, N'')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'022', N'Kế toán 2', N'Dương Văn Ninh', N'ml2       ', 4000000, 600000, 200000, N'200000', N'0', N'5         ', N'2019               ', 24, 2, 7, 4972304, N'')
GO
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kt02      ', N'001       ', N'Lê Văn Đạt', CAST(N'1982-04-01T00:00:00.000' AS DateTime), N'Nam', N'Bắc Ninh', N'Đại học', N'Đại học', N'Nhân Viên', CAST(N'2008-05-03T00:00:00.000' AS DateTime), N'3', N'Thử việc')
GO
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kt01      ', N'0011      ', N'Nguyễn Lâm Trung', CAST(N'1982-04-01T00:00:00.000' AS DateTime), N'Nam', N'Bắc Ninh', N'Đại Học', N'Đại học', N'Nhân Viên', CAST(N'2008-05-03T00:00:00.000' AS DateTime), N'5', N'Thử việc')
GO
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kth01     ', N'002       ', N'Nguyễn Thị Vân', CAST(N'1996-05-01T00:00:00.000' AS DateTime), N'Nữ', N'Bắc Ninh', N'Cao Đẳng', N'Cao Đẳng', N'Nhân Viên', CAST(N'2019-05-23T00:00:00.000' AS DateTime), N'8/2008', N'')
GO
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kth02     ', N'003       ', N'Nguyễn Văn Hoàng', CAST(N'1989-04-06T00:00:00.000' AS DateTime), N'Nam', N'Bắc Ninh', N'Đại Học', N'Đại Học', N'Nhân viên', CAST(N'2019-05-01T00:00:00.000' AS DateTime), N'5/2019', N'')
GO
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kt02      ', N'008       ', N'Nguyễn Thị Quyên', CAST(N'1991-07-02T00:00:00.000' AS DateTime), N'Nữ', N'Bắc Ninh', N'Cao Đẳng', N'Cao Đẳng', N'Nhân Viên', CAST(N'2019-05-01T00:00:00.000' AS DateTime), N'5/2019', N'gsfbfd')
GO
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kth01     ', N'009       ', N'Nguyễn Thị Thúy', CAST(N'1990-08-04T00:00:00.000' AS DateTime), N'Nữ', N'Bắc Giang', N'Đại Học', N'Đại Học', N'Tổ trưởng', CAST(N'2019-05-01T00:00:00.000' AS DateTime), N'5/2019', N'hjhgffd')
GO
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kth02     ', N'010       ', N'Lê Chí Cường', CAST(N'1993-05-06T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'Đại Học', N'Đại Học', N'Nhân Viên', CAST(N'2019-05-01T00:00:00.000' AS DateTime), N'5/2019', N'hffgfd')
GO
INSERT [dbo].[TblNVThoiViec] ([HoTen], [CMTND], [NgayThoiViec], [LyDo]) VALUES (N'd', N'34246321', NULL, N'')
GO
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb01      ', N'kt01      ', N'Kế toán 1', CAST(N'2019-05-28T00:00:00.000' AS DateTime), N'CT')
GO
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb01      ', N'kt02      ', N'Kế toán 2', CAST(N'2019-05-13T00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb02      ', N'kth01     ', N'Kỹ thuật 1', CAST(N'2019-05-28T00:00:00.000' AS DateTime), N'CT')
GO
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb02      ', N'kth02     ', N'Kỹ thuật 2', CAST(N'2019-05-28T00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb03      ', N'kh01      ', N'Kế hoạch 1', CAST(N'2019-05-28T00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb03      ', N'kh02      ', N'Kế hoạch 2', CAST(N'2019-05-28T00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'001', N'ml2       ', N'bh1       ', CAST(N'2019-05-27T00:00:00.000' AS DateTime), N'Bắc Ninh', N'TT')
GO
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'002', N'ml2       ', N'bh1234    ', CAST(N'2019-05-27T00:00:00.000' AS DateTime), N'Bắc Ninh', N'TT')
GO
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'003', N'ml2       ', N'b1383902  ', CAST(N'2019-05-27T00:00:00.000' AS DateTime), N'Bắc Ninh', N'YT')
GO
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'004', N'ml3       ', N'b712124   ', CAST(N'2019-05-27T00:00:00.000' AS DateTime), N'Bắc Giang', N'YT')
GO
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'005', N'ml1       ', N'b124632   ', CAST(N'2019-05-27T00:00:00.000' AS DateTime), N'Bắc Giang', N'YT')
GO
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'006', N'ml2       ', N'bh12342   ', CAST(N'2019-05-27T00:00:00.000' AS DateTime), N'Bắc Giang', N'YT')
GO
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'001', N'Lê Văn Bình ', N'Nam', N'Nhân Viên', N'ml2       ', N'ml3       ', CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'hoàn thảnh tốt')
GO
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'002', N'Nguyễn Văn Dũng', N'Nam', N'Trưởng phòng', N'ml2       ', N'ml3       ', CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'ht')
GO
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'008', N'Phạm Thành Chung', N'Nam', N'Nhân Viên', N'ml1       ', N'ml2       ', CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'ht')
GO
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'016', N'Ngô Đình Hưng', N'Nam', N'Nhân Viên', N'ml2       ', N'ml2       ', CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'ht')
GO
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'017', N'Ngô Thị Huyền', N'Nữ', N'Nhân Viên', N'ml3       ', N'ml2       ', CAST(N'2019-06-15T00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'018', N'Nguyễn Việt Anh', N'Nam', N'Nhân Viên', N'ml2       ', N'ml3       ', CAST(N'2019-05-29T00:00:00.000' AS DateTime), N'hoàn thảnh tốt')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'001', N'Lê Văn Bình ', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'Từ Sơn - Bắc ninh', N'0398125856  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'Nhân viên')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'002', N'Nguyễn Văn Dũng', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'0937845928  ', N'Kinh', N'Không', N'Việt Nam', N'Cao Đẳng', N'nv')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'003', N'Lê Thị Mai Lan', N'Hà Nội', N'Hà Nội', N'Long Biên - Hà Nội', N'Từ Sơn - Bắc Ninh', N'0978436728  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'nv')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'004', N'Tôn Văn Hùng', N'Băc Ninh', N'Bắc Ninh', N'Yên Phong - Bắc Ninh', N'Yên Phong - Bắc Ninh', N'0928790473  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'005', N'Nguyễn Văn Chung', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'0345768927  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'006', N'Ngô Sách Hiệp', N'Bắc Ninh', N'Bắc Ninh', N'Long Biên - Hà Nội', N'Từ Sơn - Bắc Ninh', N'0985716788  ', N'Kinh', N'không', N'Việt Nam', N'Cao Đẳng', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'007', N'Lê Văn Đại', N'Bắc Giang', N'Bắc Giang', N'Từ Sơn - Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'092456749   ', N'Kinh', N'không', N'Việt nam', N'Cao Đẳng', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'008', N'Phạm Thành Chung', N'Bắc Ninh', N'Bắc Ninh', N'Yên Phong - Bắc Ninh', N'Yên Phong - Bắc Ninh', N'0368789899  ', N'Kinh', N' Không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'009', N'Lê Quốc Bình', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'0987678567  ', N'Kinh', N'Không', N'Việt Nam', N'Cao Đẳng', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'010', N'Nguyễn Mai Anh', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'0345298674  ', N'Kinh', N'Không', N'Việt Nam', N'Cao Đẳng', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'011', N'Nguyễn Chí Cường', N'Bắc Giang', N'Bắc Ninh', N'Tp Bắc Giang - Bắc Giang', N'Từ Sơn - Bắc Ninh', N'0967995774  ', N'Kinh', N'không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'012', N'Nguyễn Quốc Bình', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'Từ Sơn - Bắc Ninh', N'0932145677  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'013', N'Trần Đình Chiến', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'0347889365  ', N'Kinh', N'không', N'Việt Nam', N'Cao Đẳng', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'014', N'Nguyễn Văn An', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'0576893456  ', N'Kinh', N'Không', N'Việt Nam', N'Trung cấp', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'015', N'Ngô Thị Lan Anh', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'0398449975  ', N'Kinh', N'Không', N'Việt Nam', N'trung cấp', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'016', N'Ngô Đình Hưng', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'0946758862  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'017', N'Ngô Thị Huyền', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'0933251885  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'018', N'Nguyễn Việt Anh', N'Hà Nội', N'Hà Nội', N'Long Biên - Hà Nội', N'Từ Sơn - Bắc Ninh', N'0988756434  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'019', N'Vũ Văn Mạnh', N'Bắc Ninh', N'Bắc Ninh', N'Yên Phong - Bắc Ninh', N'Yên Phong - Bắc Ninh', N'0324556785  ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'020', N'Nguyễn Tiến Thắng', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'0387688856  ', N'Kinh', N'Không', N'Việt Nam', N'Cao Đẳng', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'021', N'Dương Danh Sáng', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'030907886   ', N'Kinh', N'Không', N'Việt Nam', N'Cao Đẳng', N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'022', N'Dương Văn Ninh', N'Bắc Ninh', N'Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'Từ Sơn -Bắc Ninh', N'0956778962  ', N'Kinh', N'Không', N'Việt Nam', N'Cao Đẳng', N'')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'kt01      ', N'001', N'Lê Văn Bình ', N'ml3', CAST(N'1989-05-22' AS Date), N'Nam', N'rồi', N'12323589', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'24 tháng', CAST(N'2018-10-18' AS Date), CAST(N'2020-10-18' AS Date), N'nhân viên')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'kt01      ', N'002', N'Nguyễn Văn Dũng', N'ml3       ', CAST(N'1990-06-12' AS Date), N'Nam', N'chưa', N'14355678', N'Bắc Ninh', N'Trưởng phòng', N'kinh tế', N'36 tháng', CAST(N'2018-11-21' AS Date), CAST(N'2021-11-21' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'kt01      ', N'003', N'Lê Thị Mai Lan', N'ml2       ', CAST(N'1990-10-12' AS Date), N'Nữ', N'chưa', N'14335678', N'Bắc Ninh', N'NV', N'kinh tế', N'36 tháng', CAST(N'2018-11-21' AS Date), CAST(N'2021-11-21' AS Date), N'')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'kt02      ', N'004', N'Tôn Văn Hùng', N'ml3       ', CAST(N'1988-10-10' AS Date), N'Nam', N'rồi', N'132352327', N'Hà Nội', N'Phó Phòng', N'kinh tế', N'36 tháng', CAST(N'2018-07-01' AS Date), CAST(N'2021-07-01' AS Date), N'phó phòng')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'kth01     ', N'005', N'Nguyễn Văn Chung', N'ml1       ', CAST(N'1988-10-10' AS Date), N'Nam', N'rồi', N'133473327', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'36 tháng', CAST(N'2018-07-01' AS Date), CAST(N'2021-07-01' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'kth02     ', N'006', N'Ngô Sách Hiệp', N'ml2       ', CAST(N'1989-03-03' AS Date), N'Nam', N'rồi', N'186574327', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'24 tháng', CAST(N'2018-07-01' AS Date), CAST(N'2020-07-01' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'kth02     ', N'007', N'Lê Văn Đại', N'ml3       ', CAST(N'1989-03-03' AS Date), N'Nam', N'chưa', N'134892053', N'Bắc Giang', N'Cán bộ', N'kinh tế', N'24 tháng', CAST(N'2018-07-01' AS Date), CAST(N'2020-07-01' AS Date), N'Cán bộ')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb03      ', N'kh01      ', N'008', N'Phạm Thành Chung', N'ml1       ', CAST(N'1990-12-21' AS Date), N'Nam', N'chưa', N'129340243', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'24 tháng', CAST(N'2018-07-01' AS Date), CAST(N'2020-07-01' AS Date), N'Nhân Viên')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb03      ', N'kh01      ', N'009', N'Lê Quốc Bình', N'ml2       ', CAST(N'1991-02-23' AS Date), N'Nam', N'rồi', N'129340249', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'36 tháng', CAST(N'2018-07-01' AS Date), CAST(N'2021-07-01' AS Date), N'')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'kt02      ', N'010', N'Nguyễn Mai Anh', N'ml2       ', CAST(N'1991-09-14' AS Date), N'Nữ', N'rồi', N'13092423', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'36 tháng', CAST(N'2018-07-01' AS Date), CAST(N'2021-07-01' AS Date), N'')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb03      ', N'kh02      ', N'011', N'Nguyễn Chí Cường', N'ml1       ', CAST(N'1992-06-25' AS Date), N'Nam', N'rồi', N'156754278', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'24 tháng', CAST(N'2019-03-20' AS Date), CAST(N'2021-03-20' AS Date), N'')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb03      ', N'kh02      ', N'012', N'Nguyễn Quốc Bình', N'ml3       ', CAST(N'1991-11-20' AS Date), N'Nam', N'chưa', N'124290245', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'24 tháng', CAST(N'2019-03-20' AS Date), CAST(N'2021-03-20' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'kth02     ', N'013', N'Trần Đình Chiến', N'ml3       ', CAST(N'1990-08-09' AS Date), N'Nam', N'rồi', N'156764343', N'Bắc Giang', N'Trưởng Phòng', N'kinh tế', N'24 tháng', CAST(N'2019-03-20' AS Date), CAST(N'2021-03-20' AS Date), N'trưởng phòng')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'kth02     ', N'014', N'Nguyễn Văn An', N'ml2       ', CAST(N'1993-02-13' AS Date), N'Nam', N'rồi', N'156124343', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'24 tháng', CAST(N'2019-03-20' AS Date), CAST(N'2021-03-20' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'kth01     ', N'015', N'Ngô Thị Lan Anh', N'ml1       ', CAST(N'1993-03-06' AS Date), N'Nữ', N'rồi', N'142124343', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'36 tháng', CAST(N'2018-11-22' AS Date), CAST(N'2021-11-22' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'kt02      ', N'016', N'Ngô Đình Hưng', N'ml2       ', CAST(N'1992-08-11' AS Date), N'Nam', N'rồi', N'134676443', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'36 tháng', CAST(N'2018-11-22' AS Date), CAST(N'2021-11-22' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb03      ', N'kh02      ', N'017', N'Ngô Thị Huyền', N'ml2       ', CAST(N'1994-09-01' AS Date), N'Nữ', N'chưa', N'164864953', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'24 tháng', CAST(N'2019-04-11' AS Date), CAST(N'2021-04-11' AS Date), N'nhân viên')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb03      ', N'kh02      ', N'018', N'Nguyễn Việt Anh', N'ml3       ', CAST(N'1993-09-08' AS Date), N'Nam', N'rồi', N'124564339', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'24 tháng', CAST(N'2019-04-11' AS Date), CAST(N'2021-04-11' AS Date), N'nhân viên')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'kth01     ', N'019', N'Vũ Văn Mạnh', N'ml2       ', CAST(N'1994-01-21' AS Date), N'Nam', N'rồi', N'134595386', N'Bắc Ninh', N'Trưởng Phòng', N'kinh tế', N'36 tháng', CAST(N'2018-07-18' AS Date), CAST(N'2021-07-18' AS Date), N'trưởng phòng')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'kt02      ', N'020', N'Nguyễn Tiến Thắng', N'ml1       ', CAST(N'1994-04-16' AS Date), N'Nam', N'rồi', N'143690764', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'36 tháng', CAST(N'2018-07-18' AS Date), CAST(N'2021-07-18' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'kth01     ', N'021', N'Dương Danh Sáng', N'ml3       ', CAST(N'1993-08-09' AS Date), N'Nam', N'rồi', N'143690765', N'Bắc Ninh', N'Nhân Viên', N'kinh tế', N'36 tháng', CAST(N'2018-06-20' AS Date), CAST(N'2021-06-20' AS Date), N'nv')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'kt02      ', N'022', N'Dương Văn Ninh', N'ml2       ', CAST(N'2019-05-29' AS Date), N'Nam', N'chưa', N'123217469', N'Băc ninh', N'Nhân viên', N'kinh tế', N'24 tháng', CAST(N'2019-05-29' AS Date), CAST(N'2019-05-29' AS Date), N'nv')
GO
INSERT [dbo].[TblThaiSan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [NgaySinh], [NgayVeSom], [NgayNghiSinh], [NgayLamTroLai], [TroCapCTY], [GhiChu]) VALUES (N'mb02      ', N'kth01     ', N'015', N'Ngô Thị Lan Anh', CAST(N'1995-06-14T00:00:00.000' AS DateTime), CAST(N'2019-06-14T00:00:00.000' AS DateTime), CAST(N'2019-06-14T00:00:00.000' AS DateTime), CAST(N'2020-02-01T00:00:00.000' AS DateTime), 1000000, N'')
GO
INSERT [dbo].[TblThaiSan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [NgaySinh], [NgayVeSom], [NgayNghiSinh], [NgayLamTroLai], [TroCapCTY], [GhiChu]) VALUES (N'mb03      ', N'kh02      ', N'017', N'Ngô Thị Huyền', CAST(N'1995-06-14T00:00:00.000' AS DateTime), CAST(N'2019-06-14T00:00:00.000' AS DateTime), CAST(N'2019-06-14T00:00:00.000' AS DateTime), CAST(N'2020-02-01T00:00:00.000' AS DateTime), 1000000, N'')
GO
INSERT [dbo].[tbuser] ([Username], [Pass], [Quyen], [Ten], [Ngaysinh]) VALUES (N'hien2', N'hien2', N'Admin     ', N'hien', CAST(N'1997-07-12' AS Date))
GO
INSERT [dbo].[tbuser] ([Username], [Pass], [Quyen], [Ten], [Ngaysinh]) VALUES (N'aa', N'aa', N'user      ', N'aaa', CAST(N'2019-06-15' AS Date))
GO
ALTER TABLE [dbo].[TblCongKhoiDieuHanh]  WITH CHECK ADD  CONSTRAINT [FK_TblCongKhoiDieuHanh_TblBangLuongCTy] FOREIGN KEY([MaLuong])
REFERENCES [dbo].[TblBangLuongCTy] ([MaLuong])
GO
ALTER TABLE [dbo].[TblCongKhoiDieuHanh] CHECK CONSTRAINT [FK_TblCongKhoiDieuHanh_TblBangLuongCTy]
GO
ALTER TABLE [dbo].[TblCongKhoiDieuHanh]  WITH CHECK ADD  CONSTRAINT [FK_TblCongKhoiDieuHanh_TblTTNVCoBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblCongKhoiDieuHanh] CHECK CONSTRAINT [FK_TblCongKhoiDieuHanh_TblTTNVCoBan]
GO
ALTER TABLE [dbo].[TblCongKhoiVanChuyen]  WITH NOCHECK ADD  CONSTRAINT [FK_TblCongKhoiVanChuyen_TblTTNVCoBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
GO
ALTER TABLE [dbo].[TblCongKhoiVanChuyen] CHECK CONSTRAINT [FK_TblCongKhoiVanChuyen_TblTTNVCoBan]
GO
ALTER TABLE [dbo].[TblCongKhoiVanPHong]  WITH NOCHECK ADD  CONSTRAINT [FK_TblCongKhoiVanPHong_TblTTNVCoBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
GO
ALTER TABLE [dbo].[TblCongKhoiVanPHong] CHECK CONSTRAINT [FK_TblCongKhoiVanPHong_TblTTNVCoBan]
GO
ALTER TABLE [dbo].[TblPhongBan]  WITH CHECK ADD  CONSTRAINT [FK_TblPhongBan_TblBoPhan] FOREIGN KEY([MaBoPhan])
REFERENCES [dbo].[TblBoPhan] ([MaBoPhan])
GO
ALTER TABLE [dbo].[TblPhongBan] CHECK CONSTRAINT [FK_TblPhongBan_TblBoPhan]
GO
ALTER TABLE [dbo].[TblSoBH]  WITH CHECK ADD  CONSTRAINT [FK_TblSoBH_TblBangLuongCTy] FOREIGN KEY([MaLuong])
REFERENCES [dbo].[TblBangLuongCTy] ([MaLuong])
GO
ALTER TABLE [dbo].[TblSoBH] CHECK CONSTRAINT [FK_TblSoBH_TblBangLuongCTy]
GO
ALTER TABLE [dbo].[TblTangLuong]  WITH NOCHECK ADD  CONSTRAINT [FK_TblTangLuong_TblTTNVCoBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
GO
ALTER TABLE [dbo].[TblTangLuong] CHECK CONSTRAINT [FK_TblTangLuong_TblTTNVCoBan]
GO
ALTER TABLE [dbo].[TblTangLuong]  WITH CHECK ADD  CONSTRAINT [tk_tl] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblTangLuong] CHECK CONSTRAINT [tk_tl]
GO
ALTER TABLE [dbo].[TblTTCaNhan]  WITH CHECK ADD  CONSTRAINT [tk_cn] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblTTCaNhan] CHECK CONSTRAINT [tk_cn]
GO
ALTER TABLE [dbo].[TblTTNVCoBan]  WITH CHECK ADD  CONSTRAINT [FK_TblTTNVCoBan_TblPhongBan] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[TblPhongBan] ([MaPhong])
GO
ALTER TABLE [dbo].[TblTTNVCoBan] CHECK CONSTRAINT [FK_TblTTNVCoBan_TblPhongBan]
GO
ALTER TABLE [dbo].[TblThaiSan]  WITH NOCHECK ADD  CONSTRAINT [FK_TblThaiSan_TblTTNVCoBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblThaiSan] CHECK CONSTRAINT [FK_TblThaiSan_TblTTNVCoBan]
GO

