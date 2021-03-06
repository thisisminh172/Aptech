USE [master]
GO
/****** Object:  Database [Thi_ADF2]    Script Date: 6/2/2020 11:55:57 AM ******/
CREATE DATABASE [Thi_ADF2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Thi_ADF2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Thi_ADF2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Thi_ADF2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Thi_ADF2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Thi_ADF2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Thi_ADF2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Thi_ADF2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Thi_ADF2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Thi_ADF2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Thi_ADF2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Thi_ADF2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Thi_ADF2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Thi_ADF2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Thi_ADF2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Thi_ADF2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Thi_ADF2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Thi_ADF2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Thi_ADF2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Thi_ADF2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Thi_ADF2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Thi_ADF2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Thi_ADF2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Thi_ADF2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Thi_ADF2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Thi_ADF2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Thi_ADF2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Thi_ADF2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Thi_ADF2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Thi_ADF2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Thi_ADF2] SET  MULTI_USER 
GO
ALTER DATABASE [Thi_ADF2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Thi_ADF2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Thi_ADF2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Thi_ADF2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Thi_ADF2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Thi_ADF2] SET QUERY_STORE = OFF
GO
USE [Thi_ADF2]
GO
/****** Object:  Table [dbo].[tb_MonHoc]    Script Date: 6/2/2020 11:55:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_MonHoc](
	[MaMonHoc] [int] IDENTITY(1,1) NOT NULL,
	[TenNgan] [varchar](5) NOT NULL,
	[TenDai] [varchar](50) NOT NULL,
	[SoTiet] [tinyint] NOT NULL,
 CONSTRAINT [PK_tb_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_MonHoc] ON 

INSERT [dbo].[tb_MonHoc] ([MaMonHoc], [TenNgan], [TenDai], [SoTiet]) VALUES (1, N'C', N'Lap Trinh C', 40)
INSERT [dbo].[tb_MonHoc] ([MaMonHoc], [TenNgan], [TenDai], [SoTiet]) VALUES (2, N'HTML', N'Lap trinh web -html/css/js', 40)
INSERT [dbo].[tb_MonHoc] ([MaMonHoc], [TenNgan], [TenDai], [SoTiet]) VALUES (3, N'DM', N'co so du lieu', 50)
INSERT [dbo].[tb_MonHoc] ([MaMonHoc], [TenNgan], [TenDai], [SoTiet]) VALUES (4, N'PRJ1', N'eProject hoc ky 1', 30)
INSERT [dbo].[tb_MonHoc] ([MaMonHoc], [TenNgan], [TenDai], [SoTiet]) VALUES (5, N'BSJ', N'bootstrap', 20)
SET IDENTITY_INSERT [dbo].[tb_MonHoc] OFF
GO
USE [master]
GO
ALTER DATABASE [Thi_ADF2] SET  READ_WRITE 
GO
