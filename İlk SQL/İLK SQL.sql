USE [master]
GO
/****** Object:  Database [TrafficFinesDB]    Script Date: 2025-03-19 14:16:02 ******/
CREATE DATABASE [TrafficFinesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TrafficFinesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TrafficFinesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TrafficFinesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TrafficFinesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TrafficFinesDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TrafficFinesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TrafficFinesDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TrafficFinesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TrafficFinesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TrafficFinesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TrafficFinesDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET RECOVERY FULL 
GO
ALTER DATABASE [TrafficFinesDB] SET  MULTI_USER 
GO
ALTER DATABASE [TrafficFinesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TrafficFinesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TrafficFinesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TrafficFinesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TrafficFinesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TrafficFinesDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TrafficFinesDB', N'ON'
GO
ALTER DATABASE [TrafficFinesDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [TrafficFinesDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TrafficFinesDB]
GO
/****** Object:  Table [dbo].[CARS]    Script Date: 2025-03-19 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARS](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[Model] [nvarchar](100) NOT NULL,
	[YearOfRelease] [int] NOT NULL,
	[LicensePlate] [nvarchar](20) NOT NULL,
	[InsurableValue] [decimal](18, 2) NOT NULL,
	[OwnerFullName] [nvarchar](255) NOT NULL,
	[OwnerPassportData] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[LicensePlate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTS_OF_VIOLATIONS]    Script Date: 2025-03-19 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTS_OF_VIOLATIONS](
	[ViolationFactID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NULL,
	[ViolationID] [int] NULL,
	[ViolationDate] [datetime] NOT NULL,
	[DriverFullName] [nvarchar](255) NOT NULL,
	[RightOfManagement] [nvarchar](50) NOT NULL,
	[FineAmount] [decimal](18, 2) NULL,
	[ViolationPaymentDate] [datetime] NULL,
	[is_paid] [bit] NULL,
	[PaymentAmount] [decimal](18, 2) NULL,
	[ReceiptNumber] [nchar](100) NULL,
	[PaymentMethod] [nchar](50) NULL,
	[DiscountOrPenaltyReason] [nvarchar](max) NULL,
 CONSTRAINT [PK__FACTS_OF__76F639484BA9DCE5] PRIMARY KEY CLUSTERED 
(
	[ViolationFactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TYPES_OF_VIOLATIONS]    Script Date: 2025-03-19 14:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYPES_OF_VIOLATIONS](
	[ViolationID] [int] IDENTITY(1,1) NOT NULL,
	[ViolationType] [nvarchar](255) NOT NULL,
	[FineAmount] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ViolationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FACTS_OF_VIOLATIONS]  WITH CHECK ADD  CONSTRAINT [FK__FACTS_OF___CarID__3C69FB99] FOREIGN KEY([CarID])
REFERENCES [dbo].[CARS] ([CarID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FACTS_OF_VIOLATIONS] CHECK CONSTRAINT [FK__FACTS_OF___CarID__3C69FB99]
GO
ALTER TABLE [dbo].[FACTS_OF_VIOLATIONS]  WITH CHECK ADD  CONSTRAINT [FK__FACTS_OF___Viola__3D5E1FD2] FOREIGN KEY([ViolationID])
REFERENCES [dbo].[TYPES_OF_VIOLATIONS] ([ViolationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FACTS_OF_VIOLATIONS] CHECK CONSTRAINT [FK__FACTS_OF___Viola__3D5E1FD2]
GO
ALTER TABLE [dbo].[FACTS_OF_VIOLATIONS]  WITH CHECK ADD  CONSTRAINT [CK__FACTS_OF___Right__3E52440B] CHECK  (([RightOfManagement]='Proxy' OR [RightOfManagement]='Owner'))
GO
ALTER TABLE [dbo].[FACTS_OF_VIOLATIONS] CHECK CONSTRAINT [CK__FACTS_OF___Right__3E52440B]
GO
USE [master]
GO
ALTER DATABASE [TrafficFinesDB] SET  READ_WRITE 
GO
