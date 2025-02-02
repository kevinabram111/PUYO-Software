USE [master]
GO
/****** Object:  Database [PUYO_CASHIER]    Script Date: 2/2/2019 9:48:02 PM ******/
CREATE DATABASE [PUYO_CASHIER]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PUYO_CASHIER', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PUYO_CASHIER.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PUYO_CASHIER_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\PUYO_CASHIER_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PUYO_CASHIER] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PUYO_CASHIER].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PUYO_CASHIER] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET ARITHABORT OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PUYO_CASHIER] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PUYO_CASHIER] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PUYO_CASHIER] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PUYO_CASHIER] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PUYO_CASHIER] SET  MULTI_USER 
GO
ALTER DATABASE [PUYO_CASHIER] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PUYO_CASHIER] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PUYO_CASHIER] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PUYO_CASHIER] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PUYO_CASHIER] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PUYO_CASHIER] SET QUERY_STORE = OFF
GO
USE [PUYO_CASHIER]
GO
/****** Object:  Table [dbo].[Master_Transaction]    Script Date: 2/2/2019 9:48:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Master_Transaction](
	[Master_Transaction_ID] [varchar](50) NOT NULL,
	[Master_Transaction_Date] [date] NOT NULL,
 CONSTRAINT [PK_Master_Transaction] PRIMARY KEY CLUSTERED 
(
	[Master_Transaction_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2/2/2019 9:48:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_ID] [varchar](50) NOT NULL,
	[Product_Type_ID] [varchar](50) NOT NULL,
	[Product_Name] [varchar](50) NOT NULL,
	[Product_Price] [decimal](18, 0) NOT NULL,
	[Product_Stock] [int] NOT NULL,
	[Barcode_Number] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Type]    Script Date: 2/2/2019 9:48:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Type](
	[Product_Type_ID] [varchar](50) NOT NULL,
	[Product_Type_Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Product_Type] PRIMARY KEY CLUSTERED 
(
	[Product_Type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 2/2/2019 9:48:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Transaction_ID] [varchar](50) NOT NULL,
	[Master_Transaction_ID] [varchar](50) NOT NULL,
	[Product_ID] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Total_Price] [decimal](18, 0) NOT NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Transaction_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Product_Type] FOREIGN KEY([Product_Type_ID])
REFERENCES [dbo].[Product_Type] ([Product_Type_ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Product_Type]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Master_Transaction] FOREIGN KEY([Master_Transaction_ID])
REFERENCES [dbo].[Master_Transaction] ([Master_Transaction_ID])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Master_Transaction]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Product1] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([Product_ID])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Product1]
GO
USE [master]
GO
ALTER DATABASE [PUYO_CASHIER] SET  READ_WRITE 
GO
