USE [master]
GO
/****** Object:  Database [DBPETSHOP]    Script Date: 5/24/2024 12:10:57 AM ******/
CREATE DATABASE [DBPETSHOP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBPETSHOP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\DBPETSHOP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBPETSHOP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\DBPETSHOP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBPETSHOP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBPETSHOP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBPETSHOP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBPETSHOP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBPETSHOP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBPETSHOP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBPETSHOP] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBPETSHOP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBPETSHOP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBPETSHOP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBPETSHOP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBPETSHOP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBPETSHOP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBPETSHOP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBPETSHOP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBPETSHOP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBPETSHOP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBPETSHOP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBPETSHOP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBPETSHOP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBPETSHOP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBPETSHOP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBPETSHOP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBPETSHOP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBPETSHOP] SET RECOVERY FULL 
GO
ALTER DATABASE [DBPETSHOP] SET  MULTI_USER 
GO
ALTER DATABASE [DBPETSHOP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBPETSHOP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBPETSHOP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBPETSHOP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBPETSHOP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBPETSHOP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBPETSHOP', N'ON'
GO
ALTER DATABASE [DBPETSHOP] SET QUERY_STORE = OFF
GO
USE [DBPETSHOP]
GO
/****** Object:  Table [dbo].[tbCash]    Script Date: 5/24/2024 12:10:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCash](
	[cashid] [int] IDENTITY(1,1) NOT NULL,
	[transno] [varchar](15) NULL,
	[pcode] [varchar](10) NOT NULL,
	[pname] [varchar](50) NULL,
	[qty] [int] NULL,
	[price] [decimal](18, 2) NOT NULL,
	[total] [decimal](18, 2) NULL,
	[cid] [varchar](10) NULL,
	[cashier] [varchar](20) NULL,
 CONSTRAINT [PK_tbCash] PRIMARY KEY CLUSTERED 
(
	[cashid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCus]    Script Date: 5/24/2024 12:10:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NULL,
	[address] [varchar](100) NULL,
	[phone] [varchar](520) NULL,
 CONSTRAINT [PK_tbCus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProduct]    Script Date: 5/24/2024 12:10:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProduct](
	[pcode] [int] IDENTITY(1,1) NOT NULL,
	[pname] [varchar](50) NOT NULL,
	[ptype] [varchar](50) NOT NULL,
	[pcategory] [varchar](50) NOT NULL,
	[pqty] [int] NOT NULL,
	[pprice] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tbProduct] PRIMARY KEY CLUSTERED 
(
	[pcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUser]    Script Date: 5/24/2024 12:10:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[role] [varchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_tbUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbCash] ON 

INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (42, N'202405231001', N'4', N'Dog', 1, CAST(1000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, N'Ngoc')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (43, N'202405231002', N'5', N'Cat', 1, CAST(123000.00 AS Decimal(18, 2)), CAST(123000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (44, N'202405231003', N'5', N'Cat', 1, CAST(123000.00 AS Decimal(18, 2)), CAST(123000.00 AS Decimal(18, 2)), N'10', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (45, N'202405231004', N'4', N'Dog', 1, CAST(1000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), N'10', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (46, N'202405231005', N'4', N'Dog', 3, CAST(1000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (47, N'202405231005', N'5', N'Cat', 2, CAST(123000.00 AS Decimal(18, 2)), CAST(246000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (48, N'202405231006', N'4', N'Meo Meo', 1, CAST(1000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (49, N'202405231006', N'5', N'Mickey', 1, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (50, N'202405231007', N'4', N'Meo Meo', 3, CAST(1000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (51, N'202405231007', N'5', N'Mickey', 1, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (52, N'202405231008', N'4', N'Meo Meo', 3, CAST(1000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (53, N'202405231008', N'5', N'Mickey', 3, CAST(2000.00 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (54, N'202405231009', N'4', N'Meo Meo', 2, CAST(1000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (55, N'202405231009', N'5', N'Mickey', 3, CAST(2000.00 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)), NULL, N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (56, N'202405231010', N'4', N'Mickey', 2, CAST(1000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), N'13', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (57, N'202405231010', N'5', N'Doraemon', 4, CAST(2000.00 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)), N'13', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (58, N'202405231011', N'4', N'Meo Meo', 3, CAST(1000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), N'14', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (59, N'202405231011', N'5', N'Jerry', 2, CAST(2000.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), N'14', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (65, N'202405231012', N'4', N'Meo Meo', 1, CAST(1000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), N'14', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (66, N'202405231012', N'5', N'Jerry', 1, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), N'14', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (67, N'202405231013', N'4', N'Meo Meo', 1, CAST(1000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), N'14', N'Nghia')
INSERT [dbo].[tbCash] ([cashid], [transno], [pcode], [pname], [qty], [price], [total], [cid], [cashier]) VALUES (68, N'202405231013', N'5', N'Jerry', 1, CAST(2000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), N'14', N'Nghia')
SET IDENTITY_INSERT [dbo].[tbCash] OFF
GO
SET IDENTITY_INSERT [dbo].[tbCus] ON 

INSERT [dbo].[tbCus] ([id], [name], [address], [phone]) VALUES (14, N'Anh Khoa', N'280 An Duong Vuong', N'0819634787')
INSERT [dbo].[tbCus] ([id], [name], [address], [phone]) VALUES (15, N'Minh Ngoc', N'557 Nguyen Van Khoi, phuong 8', N'0988107179')
SET IDENTITY_INSERT [dbo].[tbCus] OFF
GO
SET IDENTITY_INSERT [dbo].[tbProduct] ON 

INSERT [dbo].[tbProduct] ([pcode], [pname], [ptype], [pcategory], [pqty], [pprice]) VALUES (4, N'Meo Meo', N'Bull', N'Dog', 2, CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[tbProduct] ([pcode], [pname], [ptype], [pcategory], [pqty], [pprice]) VALUES (5, N'Jerry', N'Cat', N'Cat', 1, CAST(2000.00 AS Decimal(18, 2)))
INSERT [dbo].[tbProduct] ([pcode], [pname], [ptype], [pcategory], [pqty], [pprice]) VALUES (7, N'Hamster', N'Hamster', N'Hamster', 8, CAST(123000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[tbProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[tbUser] ON 

INSERT [dbo].[tbUser] ([id], [name], [address], [phone], [role], [dob], [password]) VALUES (3, N'Nghia', N'Nguyen Van Khoi', N'787', N'Administrator', CAST(N'2004-07-08' AS Date), N'123')
INSERT [dbo].[tbUser] ([id], [name], [address], [phone], [role], [dob], [password]) VALUES (5, N'Ngoc', N'An Duong Vuong', N'123', N'Administrator', CAST(N'2004-06-08' AS Date), N'123')
INSERT [dbo].[tbUser] ([id], [name], [address], [phone], [role], [dob], [password]) VALUES (6, N'nghia123', N'123', N'123', N'Employee', CAST(N'2004-07-13' AS Date), N'')
SET IDENTITY_INSERT [dbo].[tbUser] OFF
GO
USE [master]
GO
ALTER DATABASE [DBPETSHOP] SET  READ_WRITE 
GO
