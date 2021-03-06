USE [master]
GO
/****** Object:  Database [QL_ST]    Script Date: 6/16/2021 9:52:05 AM ******/
CREATE DATABASE [QL_ST]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_ST', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_ST.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_ST_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QL_ST_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_ST] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_ST].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_ST] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_ST] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_ST] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_ST] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_ST] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_ST] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_ST] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_ST] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_ST] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_ST] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_ST] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_ST] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_ST] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_ST] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_ST] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_ST] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_ST] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_ST] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_ST] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_ST] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_ST] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_ST] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_ST] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_ST] SET  MULTI_USER 
GO
ALTER DATABASE [QL_ST] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_ST] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_ST] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_ST] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QL_ST] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_ST', N'ON'
GO
USE [QL_ST]
GO
/****** Object:  Table [dbo].[tb_CTHDB]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHDB](
	[mahdb] [nvarchar](10) NOT NULL,
	[masp] [nvarchar](10) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[thanhtien] [float] NULL,
 CONSTRAINT [PK_tb_CTHDB] PRIMARY KEY CLUSTERED 
(
	[mahdb] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_CTHDN]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHDN](
	[mahdn] [nvarchar](10) NOT NULL,
	[masp] [nvarchar](10) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[thanhtien] [float] NULL,
 CONSTRAINT [PK_tb_CTHDN] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_hang]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_hang](
	[mahang] [nvarchar](10) NOT NULL,
	[tenhang] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_hang] PRIMARY KEY CLUSTERED 
(
	[mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_HDB]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HDB](
	[mahdb] [nvarchar](10) NOT NULL,
	[ngayxuat] [date] NULL,
	[manv] [nvarchar](10) NOT NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK_tb_HDB] PRIMARY KEY CLUSTERED 
(
	[mahdb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_HDN]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HDN](
	[mahdn] [nvarchar](10) NOT NULL,
	[ngaynhap] [date] NULL,
	[manv] [nvarchar](10) NOT NULL,
	[tongtien] [float] NULL,
 CONSTRAINT [PK_tb_HDN] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Loaihang]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Loaihang](
	[maloai] [nvarchar](10) NOT NULL,
	[tenloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Loaihang] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_NCC]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NCC](
	[mancc] [nvarchar](10) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[sdt] [nvarchar](12) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_NCC] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Nhanvien]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Nhanvien](
	[manv] [nvarchar](10) NOT NULL,
	[tennv] [nvarchar](25) NULL,
	[ngaysinh] [date] NULL,
	[diachi] [nvarchar](max) NULL,
	[sdt] [nvarchar](12) NOT NULL,
 CONSTRAINT [PK_tb_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_Sanpham]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Sanpham](
	[masp] [nvarchar](10) NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[mancc] [nvarchar](10) NOT NULL,
	[maloai] [nvarchar](10) NOT NULL,
	[mahang] [nvarchar](10) NOT NULL,
	[gianhap] [float] NULL,
	[giaban] [float] NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_tb_Sanpham] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_User]    Script Date: 6/16/2021 9:52:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_User](
	[username] [nvarchar](10) NOT NULL,
	[password] [nvarchar](10) NOT NULL,
	[loaitaikhoan] [nvarchar](10) NOT NULL,
	[manv] [nvarchar](12) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[tb_CTHDB] ([mahdb], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'40001', N'50001', 2, 10000, 20000)
INSERT [dbo].[tb_CTHDN] ([mahdn], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'30001     ', N'50001     ', 7, 1000, 7000)
INSERT [dbo].[tb_hang] ([mahang], [tenhang]) VALUES (N'70001     ', N'Blue')
INSERT [dbo].[tb_HDB] ([mahdb], [ngayxuat], [manv], [tongtien]) VALUES (N'40001', CAST(N'2021-06-16' AS Date), N'10001', 20000)
INSERT [dbo].[tb_HDB] ([mahdb], [ngayxuat], [manv], [tongtien]) VALUES (N'40002', CAST(N'2021-06-16' AS Date), N'10001', 0)
INSERT [dbo].[tb_HDN] ([mahdn], [ngaynhap], [manv], [tongtien]) VALUES (N'30001     ', CAST(N'2021-06-15' AS Date), N'10001     ', 7000)
INSERT [dbo].[tb_HDN] ([mahdn], [ngaynhap], [manv], [tongtien]) VALUES (N'30002', CAST(N'2021-06-16' AS Date), N'10001', 0)
INSERT [dbo].[tb_Loaihang] ([maloai], [tenloai]) VALUES (N'60001     ', N'Bánh Kẹo')
INSERT [dbo].[tb_NCC] ([mancc], [tenncc], [sdt], [email], [diachi]) VALUES (N'40001     ', N'Blue', N'0983876105  ', N'taduydao2k@gmail.com                              ', N'Hà Nam')
INSERT [dbo].[tb_Nhanvien] ([manv], [tennv], [ngaysinh], [diachi], [sdt]) VALUES (N'10001', N'Tạ Duy Đạo', CAST(N'2021-06-16' AS Date), N'Hà Nam', N'0983876105  ')
INSERT [dbo].[tb_Sanpham] ([masp], [tensp], [mancc], [maloai], [mahang], [gianhap], [giaban], [soluong]) VALUES (N'50001', N'Bánh Blue', N'40001     ', N'60001     ', N'70001     ', 1000, 10000, 18)
INSERT [dbo].[tb_User] ([username], [password], [loaitaikhoan], [manv]) VALUES (N'admin     ', N'admin     ', N'Admin     ', N'10001     ')
ALTER TABLE [dbo].[tb_CTHDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDB_tb_HDB1] FOREIGN KEY([mahdb])
REFERENCES [dbo].[tb_HDB] ([mahdb])
GO
ALTER TABLE [dbo].[tb_CTHDB] CHECK CONSTRAINT [FK_tb_CTHDB_tb_HDB1]
GO
ALTER TABLE [dbo].[tb_CTHDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDB_tb_Sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[tb_Sanpham] ([masp])
GO
ALTER TABLE [dbo].[tb_CTHDB] CHECK CONSTRAINT [FK_tb_CTHDB_tb_Sanpham]
GO
ALTER TABLE [dbo].[tb_CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDN_tb_HDN] FOREIGN KEY([mahdn])
REFERENCES [dbo].[tb_HDN] ([mahdn])
GO
ALTER TABLE [dbo].[tb_CTHDN] CHECK CONSTRAINT [FK_tb_CTHDN_tb_HDN]
GO
ALTER TABLE [dbo].[tb_CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHDN_tb_Sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[tb_Sanpham] ([masp])
GO
ALTER TABLE [dbo].[tb_CTHDN] CHECK CONSTRAINT [FK_tb_CTHDN_tb_Sanpham]
GO
ALTER TABLE [dbo].[tb_HDB]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDB_tb_Nhanvien1] FOREIGN KEY([manv])
REFERENCES [dbo].[tb_Nhanvien] ([manv])
GO
ALTER TABLE [dbo].[tb_HDB] CHECK CONSTRAINT [FK_tb_HDB_tb_Nhanvien1]
GO
ALTER TABLE [dbo].[tb_HDN]  WITH CHECK ADD  CONSTRAINT [FK_tb_HDN_tb_Nhanvien] FOREIGN KEY([manv])
REFERENCES [dbo].[tb_Nhanvien] ([manv])
GO
ALTER TABLE [dbo].[tb_HDN] CHECK CONSTRAINT [FK_tb_HDN_tb_Nhanvien]
GO
ALTER TABLE [dbo].[tb_Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_tb_Sanpham_tb_hang] FOREIGN KEY([mahang])
REFERENCES [dbo].[tb_hang] ([mahang])
GO
ALTER TABLE [dbo].[tb_Sanpham] CHECK CONSTRAINT [FK_tb_Sanpham_tb_hang]
GO
ALTER TABLE [dbo].[tb_Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_tb_Sanpham_tb_Loaihang] FOREIGN KEY([maloai])
REFERENCES [dbo].[tb_Loaihang] ([maloai])
GO
ALTER TABLE [dbo].[tb_Sanpham] CHECK CONSTRAINT [FK_tb_Sanpham_tb_Loaihang]
GO
ALTER TABLE [dbo].[tb_Sanpham]  WITH CHECK ADD  CONSTRAINT [FK_tb_Sanpham_tb_NCC] FOREIGN KEY([mancc])
REFERENCES [dbo].[tb_NCC] ([mancc])
GO
ALTER TABLE [dbo].[tb_Sanpham] CHECK CONSTRAINT [FK_tb_Sanpham_tb_NCC]
GO
USE [master]
GO
ALTER DATABASE [QL_ST] SET  READ_WRITE 
GO
