USE [master]
GO
/****** Object:  Database [QL_VLXD]    Script Date: 6/25/2021 4:29:13 PM ******/
CREATE DATABASE [QL_VLXD]
GO
ALTER DATABASE [QL_VLXD] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_VLXD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_VLXD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_VLXD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_VLXD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_VLXD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_VLXD] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_VLXD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_VLXD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_VLXD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_VLXD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_VLXD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_VLXD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_VLXD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_VLXD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_VLXD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_VLXD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_VLXD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_VLXD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_VLXD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_VLXD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_VLXD] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_VLXD] SET  MULTI_USER 
GO
ALTER DATABASE [QL_VLXD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_VLXD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_VLXD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_VLXD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QL_VLXD] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_VLXD', N'ON'
GO
USE [QL_VLXD]
GO
/****** Object:  Table [dbo].[tblChiTietHDN]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDN](
	[MaHD] [nvarchar](20) NOT NULL,
	[MaMatH] [nvarchar](20) NOT NULL,
	[SoLuong] [float] NOT NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[DonGia] [float] NOT NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_tblChiTietHDN] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblChiTietHDX]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDX](
	[MaHD] [nvarchar](20) NOT NULL,
	[MaMH] [nvarchar](20) NOT NULL,
	[SoLuong] [float] NOT NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[DonGia] [float] NOT NULL,
	[ThanhTien] [float] NOT NULL,
 CONSTRAINT [PK_tblChiTietHDX] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[Loaitk] [nvarchar](200) NOT NULL,
	[Manv] [varchar](15) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDatHang]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDatHang](
	[MaPhieu] [nvarchar](20) NOT NULL,
	[TenKhachH] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](15) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblDatHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDatHangCT]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDatHangCT](
	[MaPhieu] [nvarchar](20) NULL,
	[MaMatH] [nvarchar](20) NULL,
	[SoLuong] [float] NULL,
	[NgayDat] [datetime] NULL,
	[NgayNhan] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoaDonNhap]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonNhap](
	[MaHD] [nvarchar](20) NOT NULL,
	[MaNCC] [nvarchar](20) NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[TongTien] [float] NULL,
	[GhiChu] [nvarchar](255) NULL,
 CONSTRAINT [PK__tblHoaDonNhap__023D5A04] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoaDonXuat]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonXuat](
	[MaHD] [nvarchar](20) NOT NULL,
	[MaNhanVien] [nvarchar](20) NOT NULL,
	[NgayXuat] [datetime] NOT NULL CONSTRAINT [DF_tblHoaDonXuat_NgayXuat]  DEFAULT (NULL),
	[TongTien] [float] NULL CONSTRAINT [DF_tblHoaDonXuat_TongTien]  DEFAULT (NULL),
	[GhiChu] [nvarchar](255) NULL,
 CONSTRAINT [PK__tblHoaDonXuat__09DE7BCC] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMatHang]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMatHang](
	[MaMatH] [nvarchar](20) NOT NULL,
	[TenMatH] [nvarchar](50) NOT NULL,
	[SoLuong] [float] NOT NULL,
	[GiaNhap] [float] NOT NULL,
	[GiaBan] [float] NULL,
 CONSTRAINT [PK__tblMatHang__78B3EFCA] PRIMARY KEY CLUSTERED 
(
	[MaMatH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNCC] [nvarchar](20) NOT NULL,
	[MaMatH] [nvarchar](20) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](300) NULL,
 CONSTRAINT [PK__tblNhaCungCap__7E6CC920] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNhanVien] [nvarchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](15) NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vInPhieu]    Script Date: 6/25/2021 4:29:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vInPhieu]
AS
	select tblDatHangCT.MaPhieu,tblDatHangCT.MaMatH,TenMatH,TenKhachH,tblDatHangCT.SoLuong,NgayDat,NgayNhan,DienThoai,GhiChu from tblDatHangCT inner join tblMatHang on tblDatHangCT.MaMatH=tblMatHang.MaMatH
                INNER JOIN tblDatHang ON tblDatHang.MaPhieu=tblDatHangCT.MaPhieu






GO
INSERT [dbo].[tblChiTietHDN] ([MaHD], [MaMatH], [SoLuong], [DonViTinh], [DonGia], [ThanhTien]) VALUES (N'4001', N'3000', 4, N'đồng', 200000, 800000)
INSERT [dbo].[tblChiTietHDN] ([MaHD], [MaMatH], [SoLuong], [DonViTinh], [DonGia], [ThanhTien]) VALUES (N'4004', N'3004', 1, N'đ', 500000, 500000)
INSERT [dbo].[tblDangNhap] ([TaiKhoan], [MatKhau], [Loaitk], [Manv]) VALUES (N'admin', N'admin', N'Admin', N'1000')
INSERT [dbo].[tblDangNhap] ([TaiKhoan], [MatKhau], [Loaitk], [Manv]) VALUES (N'admin1', N'admin', N'User', N'1001')
INSERT [dbo].[tblDangNhap] ([TaiKhoan], [MatKhau], [Loaitk], [Manv]) VALUES (N'admin2', N'admin', N'User', N'1002')
INSERT [dbo].[tblDatHang] ([MaPhieu], [TenKhachH], [DienThoai], [GhiChu]) VALUES (N'6001', N'Nguyễn Văn A', N'113', N'hi')
INSERT [dbo].[tblDatHangCT] ([MaPhieu], [MaMatH], [SoLuong], [NgayDat], [NgayNhan]) VALUES (N'6001', N'3001', 4, CAST(N'2021-04-03 00:00:00.000' AS DateTime), CAST(N'2021-04-03 00:00:00.000' AS DateTime))
INSERT [dbo].[tblDatHangCT] ([MaPhieu], [MaMatH], [SoLuong], [NgayDat], [NgayNhan]) VALUES (N'6001', N'3003', 3, CAST(N'2021-06-19 00:00:00.000' AS DateTime), CAST(N'2021-06-19 00:00:00.000' AS DateTime))
INSERT [dbo].[tblHoaDonNhap] ([MaHD], [MaNCC], [NgayNhap], [TongTien], [GhiChu]) VALUES (N'4001', N'2000', CAST(N'2021-03-31 00:00:00.000' AS DateTime), 800000, N'hi
')
INSERT [dbo].[tblHoaDonNhap] ([MaHD], [MaNCC], [NgayNhap], [TongTien], [GhiChu]) VALUES (N'4004', N'2005', CAST(N'2021-06-19 00:00:00.000' AS DateTime), 500000, N'')
INSERT [dbo].[tblHoaDonXuat] ([MaHD], [MaNhanVien], [NgayXuat], [TongTien], [GhiChu]) VALUES (N'5001', N'1000', CAST(N'2021-04-01 00:00:00.000' AS DateTime), 2300000, N'hi')
INSERT [dbo].[tblHoaDonXuat] ([MaHD], [MaNhanVien], [NgayXuat], [TongTien], [GhiChu]) VALUES (N'5002', N'1000', CAST(N'2021-06-09 00:00:00.000' AS DateTime), 2700000, N'hihhi')
INSERT [dbo].[tblHoaDonXuat] ([MaHD], [MaNhanVien], [NgayXuat], [TongTien], [GhiChu]) VALUES (N'5003', N'1000', CAST(N'2021-06-09 00:00:00.000' AS DateTime), 5300000, N'hihi
')
INSERT [dbo].[tblHoaDonXuat] ([MaHD], [MaNhanVien], [NgayXuat], [TongTien], [GhiChu]) VALUES (N'5004', N'1004', CAST(N'2021-06-09 00:00:00.000' AS DateTime), 600000, N'hihihih')
INSERT [dbo].[tblHoaDonXuat] ([MaHD], [MaNhanVien], [NgayXuat], [TongTien], [GhiChu]) VALUES (N'5005', N'1003', CAST(N'2021-06-09 00:00:00.000' AS DateTime), 7100000, N'hihhi')
INSERT [dbo].[tblHoaDonXuat] ([MaHD], [MaNhanVien], [NgayXuat], [TongTien], [GhiChu]) VALUES (N'5006', N'1004', CAST(N'2021-06-09 00:00:00.000' AS DateTime), 1200000, N'hihi')
INSERT [dbo].[tblHoaDonXuat] ([MaHD], [MaNhanVien], [NgayXuat], [TongTien], [GhiChu]) VALUES (N'5007', N'1005', CAST(N'2021-06-19 00:00:00.000' AS DateTime), 5000000, N'')
INSERT [dbo].[tblHoaDonXuat] ([MaHD], [MaNhanVien], [NgayXuat], [TongTien], [GhiChu]) VALUES (N'5008', N'1005', CAST(N'2021-06-19 00:00:00.000' AS DateTime), 1800000, N'')
INSERT [dbo].[tblMatHang] ([MaMatH], [TenMatH], [SoLuong], [GiaNhap], [GiaBan]) VALUES (N'3000', N'gạch men', 985, 200000, 300000)
INSERT [dbo].[tblMatHang] ([MaMatH], [TenMatH], [SoLuong], [GiaNhap], [GiaBan]) VALUES (N'3001', N'xi măng', 996, 300000, 400000)
INSERT [dbo].[tblMatHang] ([MaMatH], [TenMatH], [SoLuong], [GiaNhap], [GiaBan]) VALUES (N'3002', N'sắt', 996, 400000, 500000)
INSERT [dbo].[tblMatHang] ([MaMatH], [TenMatH], [SoLuong], [GiaNhap], [GiaBan]) VALUES (N'3003', N'ống nước', 987, 200000, 300000)
INSERT [dbo].[tblMatHang] ([MaMatH], [TenMatH], [SoLuong], [GiaNhap], [GiaBan]) VALUES (N'3004', N'tôn', 981, 500000, 600000)
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [MaMatH], [TenNCC], [DienThoai], [Email], [DiaChi], [GhiChu]) VALUES (N'2000', N'3000', N'Gạch men', N'0911111111', N'gachmen@gmail.com', N'Hà Nội', N'không')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [MaMatH], [TenNCC], [DienThoai], [Email], [DiaChi], [GhiChu]) VALUES (N'2001', N'3001', N'xi măng', N'0922222222', N'ximang@gmail.com', N'Thanh Hóa', N'không')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [MaMatH], [TenNCC], [DienThoai], [Email], [DiaChi], [GhiChu]) VALUES (N'2002', N'3002', N'sắt ', N'0933333333', N'sat@gmail.com', N'Hà Nội', N'không')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [MaMatH], [TenNCC], [DienThoai], [Email], [DiaChi], [GhiChu]) VALUES (N'2003', N'3003', N'ống nước', N'0944444444', N'ongnuoc@gmai.com', N'Hà Nội', N'không')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [MaMatH], [TenNCC], [DienThoai], [Email], [DiaChi], [GhiChu]) VALUES (N'2004', N'3004', N'tôn', N'0977769014', N'ton@gmail.com', N'Thái Nguyên', N'không')
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [MaMatH], [TenNCC], [DienThoai], [Email], [DiaChi], [GhiChu]) VALUES (N'2005', N'3000', N'Thảo Vũ', N'113', N'Thaovu2k5@gmail.com', N'Hạ Long', N'Hạ Long')
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'1000', N'Nguyễn Văn Thuận', N'Thái Bình', N'0969282650')
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'1001', N'Nguyễn Bình Định ', N'Thái Bình', N'0969111111')
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'1002', N'Tạ Duy Đạo', N'Hà Nam', N'0969222222')
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'1003', N'Phạm Minh Tiến ', N'Lai Châu', N'0969333333')
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'1004', N'Bùi Đức Bình', N'Thái Bình ', N'0969444444')
INSERT [dbo].[tblNhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [DienThoai]) VALUES (N'1005', N'Thảo Vũ', N'Hạ Long', N'113')
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDN_tblHoaDonNhap_MaHD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tblHoaDonNhap] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [FK_tblChiTietHDN_tblHoaDonNhap_MaHD]
GO
ALTER TABLE [dbo].[tblChiTietHDX]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDX_tblHoaDonXuat1] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tblHoaDonXuat] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHDX] CHECK CONSTRAINT [FK_tblChiTietHDX_tblHoaDonXuat1]
GO
ALTER TABLE [dbo].[tblDatHangCT]  WITH CHECK ADD  CONSTRAINT [FK_tblDatHangCT_tblDatHang_MaPhieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[tblDatHang] ([MaPhieu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblDatHangCT] CHECK CONSTRAINT [FK_tblDatHangCT_tblDatHang_MaPhieu]
GO
ALTER TABLE [dbo].[tblDatHangCT]  WITH CHECK ADD  CONSTRAINT [FK_tblDatHangCT_tblMatHang_MaMatH] FOREIGN KEY([MaMatH])
REFERENCES [dbo].[tblMatHang] ([MaMatH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tblDatHangCT] CHECK CONSTRAINT [FK_tblDatHangCT_tblMatHang_MaMatH]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNCC_MaNCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNCC_MaNCC]
GO
ALTER TABLE [dbo].[tblHoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonXuat_tblNhanVien_MaNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[tblNhanVien] ([MaNhanVien])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tblHoaDonXuat] CHECK CONSTRAINT [FK_tblHoaDonXuat_tblNhanVien_MaNhanVien]
GO
ALTER TABLE [dbo].[tblNhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_tblMatHang_tblNhaCungCap_MaMatH] FOREIGN KEY([MaMatH])
REFERENCES [dbo].[tblMatHang] ([MaMatH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tblNhaCungCap] CHECK CONSTRAINT [FK_tblMatHang_tblNhaCungCap_MaMatH]
GO
ALTER TABLE [dbo].[tblChiTietHDN]  WITH CHECK ADD  CONSTRAINT [CK__tblChiTie__SoLuo__07F6335A] CHECK  (([SoLuong]>(0)))
GO
ALTER TABLE [dbo].[tblChiTietHDN] CHECK CONSTRAINT [CK__tblChiTie__SoLuo__07F6335A]
GO
USE [master]
GO
ALTER DATABASE [QL_VLXD] SET  READ_WRITE 
GO
