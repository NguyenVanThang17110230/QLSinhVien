USE [master]
GO
/****** Object:  Database [QLSinhVien]    Script Date: 5/1/2021 4:13:47 AM ******/
CREATE DATABASE [QLSinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSinhVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLSinhVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSinhVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLSinhVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLSinhVien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSinhVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [QLSinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSinhVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSinhVien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSinhVien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLSinhVien] SET QUERY_STORE = OFF
GO
USE [QLSinhVien]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 5/1/2021 4:13:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [nvarchar](50) NOT NULL,
	[TenGV] [nvarchar](50) NULL,
	[SDTGV] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[BoMon] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 5/1/2021 4:13:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nvarchar](50) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[HeDaoTao] [nvarchar](50) NULL,
	[MaGV] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LyLichSinhVien]    Script Date: 5/1/2021 4:13:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LyLichSinhVien](
	[MaSV] [nvarchar](50) NOT NULL,
	[TenSV] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[HoKhau] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[CancuocCD] [nvarchar](50) NULL,
	[NgayCap] [date] NULL,
	[NoiCap] [nvarchar](50) NULL,
	[DoiTuong] [nvarchar](50) NULL,
	[khuVuc] [nvarchar](50) NULL,
	[DanToc] [nvarchar](50) NULL,
	[TonGiao] [nvarchar](50) NULL,
	[NgayVaoDoan] [date] NULL,
	[NgayVaoDang] [date] NULL,
	[NgayVaoHoi] [date] NULL,
	[SoNamBoDoi] [int] NULL,
	[HoTenCha] [nvarchar](50) NULL,
	[NgheNghiepCha] [nvarchar](50) NULL,
	[HoTenMe] [nvarchar](50) NULL,
	[NgheNghiepMe] [nvarchar](50) NULL,
	[ThanhPhanGD] [nvarchar](50) NULL,
	[HoTenLienLac] [nvarchar](50) NULL,
	[DiaChiLienLac] [nvarchar](50) NULL,
	[DiaChiTamTru] [nvarchar](50) NULL,
	[PhongKTX] [nvarchar](50) NULL,
	[MaLop] [nvarchar](50) NULL,
 CONSTRAINT [PK_LyLichSinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/1/2021 4:13:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserName] [varchar](50) NOT NULL,
	[PassWord] [varchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SDTGV], [Email], [BoMon]) VALUES (N'gv1', N'ad', N'12', N'ng@gmail.com', N'v')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SDTGV], [Email], [BoMon]) VALUES (N'gv2', N'ad1', N'121', N'ng1@gmail.com', N'v1')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SDTGV], [Email], [BoMon]) VALUES (N'gv3', N'n', N'11', N'ng@gmail.com', N'a')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SDTGV], [Email], [BoMon]) VALUES (N'gv4', N'adđd', N'123', N'ngs@gmail.com', N'f')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [SDTGV], [Email], [BoMon]) VALUES (N'gv5', N'h', N'1266', N'ng@gmail.com', N'g')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [HeDaoTao], [MaGV]) VALUES (N'l1', N'test', N'test', N'gv1')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [HeDaoTao], [MaGV]) VALUES (N'l2', N'test2', N'a', N'gv2')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [HeDaoTao], [MaGV]) VALUES (N'l21', N'test3', N'a', N'gv1')
GO
INSERT [dbo].[LyLichSinhVien] ([MaSV], [TenSV], [SDT], [HoKhau], [Email], [Ngaysinh], [CancuocCD], [NgayCap], [NoiCap], [DoiTuong], [khuVuc], [DanToc], [TonGiao], [NgayVaoDoan], [NgayVaoDang], [NgayVaoHoi], [SoNamBoDoi], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [ThanhPhanGD], [HoTenLienLac], [DiaChiLienLac], [DiaChiTamTru], [PhongKTX], [MaLop]) VALUES (N'1', N'Thắng1', N'123', N'demo', N'a@gmail.com', CAST(N'2000-02-14' AS Date), N'12546', CAST(N'2017-12-23' AS Date), N'Gia Lai1', N'demo', N'demo', N'kinh', N'không', CAST(N'2017-02-05' AS Date), CAST(N'2017-02-21' AS Date), CAST(N'2017-03-26' AS Date), 1, N'a', N'b', N'c', N'd', N'f', N'g', N'h', N'y', N'k', N'l1')
INSERT [dbo].[LyLichSinhVien] ([MaSV], [TenSV], [SDT], [HoKhau], [Email], [Ngaysinh], [CancuocCD], [NgayCap], [NoiCap], [DoiTuong], [khuVuc], [DanToc], [TonGiao], [NgayVaoDoan], [NgayVaoDang], [NgayVaoHoi], [SoNamBoDoi], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [ThanhPhanGD], [HoTenLienLac], [DiaChiLienLac], [DiaChiTamTru], [PhongKTX], [MaLop]) VALUES (N'2', N'Thắng1', N'123', N'demo', N'a@gmail.com', CAST(N'2000-02-14' AS Date), N'12546', CAST(N'2017-12-23' AS Date), N'Gia Lai1', N'demo', N'demo', N'kinh', N'không', CAST(N'2017-02-05' AS Date), CAST(N'2017-02-21' AS Date), CAST(N'2017-03-26' AS Date), 1, N'a', N'b', N'c', N'd', N'f', N'g', N'h', N'y', N'k', N'l2')
INSERT [dbo].[LyLichSinhVien] ([MaSV], [TenSV], [SDT], [HoKhau], [Email], [Ngaysinh], [CancuocCD], [NgayCap], [NoiCap], [DoiTuong], [khuVuc], [DanToc], [TonGiao], [NgayVaoDoan], [NgayVaoDang], [NgayVaoHoi], [SoNamBoDoi], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [ThanhPhanGD], [HoTenLienLac], [DiaChiLienLac], [DiaChiTamTru], [PhongKTX], [MaLop]) VALUES (N'3', N'Thắng1', N'123', N'demo', N'a@gmail.com', CAST(N'2000-02-14' AS Date), N'12546', CAST(N'2017-12-23' AS Date), N'Gia Lai1', N'demo', N'demo', N'kinh', N'không', CAST(N'2017-02-05' AS Date), CAST(N'2017-02-21' AS Date), CAST(N'2017-03-26' AS Date), 1, N'a', N'b', N'c', N'd', N'f', N'g', N'h', N'y', N'k', N'l1')
INSERT [dbo].[LyLichSinhVien] ([MaSV], [TenSV], [SDT], [HoKhau], [Email], [Ngaysinh], [CancuocCD], [NgayCap], [NoiCap], [DoiTuong], [khuVuc], [DanToc], [TonGiao], [NgayVaoDoan], [NgayVaoDang], [NgayVaoHoi], [SoNamBoDoi], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [ThanhPhanGD], [HoTenLienLac], [DiaChiLienLac], [DiaChiTamTru], [PhongKTX], [MaLop]) VALUES (N'4', N'Thắng1', N'123', N'demo', N'a@gmail.com', CAST(N'2000-02-14' AS Date), N'12546', CAST(N'2017-12-23' AS Date), N'Gia Lai1', N'demo', N'demo', N'kinh', N'không', CAST(N'2017-02-05' AS Date), CAST(N'2017-02-21' AS Date), CAST(N'2017-03-26' AS Date), 1, N'a', N'b', N'c', N'd', N'f', N'g', N'h', N'y', N'k', N'l1')
INSERT [dbo].[LyLichSinhVien] ([MaSV], [TenSV], [SDT], [HoKhau], [Email], [Ngaysinh], [CancuocCD], [NgayCap], [NoiCap], [DoiTuong], [khuVuc], [DanToc], [TonGiao], [NgayVaoDoan], [NgayVaoDang], [NgayVaoHoi], [SoNamBoDoi], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [ThanhPhanGD], [HoTenLienLac], [DiaChiLienLac], [DiaChiTamTru], [PhongKTX], [MaLop]) VALUES (N'5', N'Thắng1', N'123', N'demo', N'ab@gmail.com', CAST(N'2000-02-14' AS Date), N'125467', CAST(N'2017-12-23' AS Date), N'Gia Lai1', N'demo', N'demo', N'kinh', N'không', CAST(N'2017-02-05' AS Date), CAST(N'2017-02-21' AS Date), CAST(N'2017-03-26' AS Date), 1, N'a', N'b', N'c', N'd', N'f', N'g', N'h', N'y', N'k', N'l1')
INSERT [dbo].[LyLichSinhVien] ([MaSV], [TenSV], [SDT], [HoKhau], [Email], [Ngaysinh], [CancuocCD], [NgayCap], [NoiCap], [DoiTuong], [khuVuc], [DanToc], [TonGiao], [NgayVaoDoan], [NgayVaoDang], [NgayVaoHoi], [SoNamBoDoi], [HoTenCha], [NgheNghiepCha], [HoTenMe], [NgheNghiepMe], [ThanhPhanGD], [HoTenLienLac], [DiaChiLienLac], [DiaChiTamTru], [PhongKTX], [MaLop]) VALUES (N'6', N'Thắng1', N'123', N'demo', N'a5@gmail.com', CAST(N'2000-02-14' AS Date), N'1254678', CAST(N'2017-12-23' AS Date), N'Gia Lai1', N'demo', N'demo', N'kinh', N'không', CAST(N'2017-02-05' AS Date), CAST(N'2017-02-21' AS Date), CAST(N'2017-03-26' AS Date), 2, N'a', N'b', N'c', N'd', N'f', N'g', N'h', N'y', N'k', N'l21')
GO
INSERT [dbo].[TaiKhoan] ([UserName], [PassWord]) VALUES (N'admin', N'123')
INSERT [dbo].[TaiKhoan] ([UserName], [PassWord]) VALUES (N'user', N'123')
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_GiaoVien]
GO
ALTER TABLE [dbo].[LyLichSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_LyLichSinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[LyLichSinhVien] CHECK CONSTRAINT [FK_LyLichSinhVien_Lop]
GO
USE [master]
GO
ALTER DATABASE [QLSinhVien] SET  READ_WRITE 
GO
