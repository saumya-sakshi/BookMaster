USE [master]
GO
/****** Object:  Database [BookMaster]    Script Date: 28-09-2020 18:46:28 ******/
CREATE DATABASE [BookMaster]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookMaster', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BookMaster.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookMaster_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BookMaster_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookMaster] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookMaster].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookMaster] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookMaster] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookMaster] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookMaster] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookMaster] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookMaster] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookMaster] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookMaster] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookMaster] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookMaster] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookMaster] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookMaster] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookMaster] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookMaster] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookMaster] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookMaster] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookMaster] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookMaster] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookMaster] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookMaster] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookMaster] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookMaster] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookMaster] SET RECOVERY FULL 
GO
ALTER DATABASE [BookMaster] SET  MULTI_USER 
GO
ALTER DATABASE [BookMaster] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookMaster] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookMaster] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookMaster] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookMaster] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BookMaster', N'ON'
GO
ALTER DATABASE [BookMaster] SET QUERY_STORE = OFF
GO
USE [BookMaster]
GO
/****** Object:  Table [dbo].[authors]    Script Date: 28-09-2020 18:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[authors](
	[Key] [varchar](128) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Bio] [text] NULL,
	[BirthDate] [varchar](20) NULL,
	[DeathDate] [varchar](20) NULL,
	[wikipedia] [varchar](255) NULL,
 CONSTRAINT [PK_authors] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bookauthors]    Script Date: 28-09-2020 18:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bookauthors](
	[BookKey] [varchar](128) NOT NULL,
	[AuthorKey] [varchar](128) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookCovers]    Script Date: 28-09-2020 18:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookCovers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CoverFile] [int] NOT NULL,
	[Book_Key] [varchar](128) NOT NULL,
 CONSTRAINT [PK_BookCovers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[books]    Script Date: 28-09-2020 18:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[Key] [varchar](128) NOT NULL,
	[Title] [varchar](500) NOT NULL,
	[Subtitle] [varchar](500) NULL,
	[FirstPublishDate] [varchar](20) NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_books] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookSubjects]    Script Date: 28-09-2020 18:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookSubjects](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Subject] [varchar](400) NOT NULL,
	[Book_Key] [varchar](128) NOT NULL,
 CONSTRAINT [PK_BookSubjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 28-09-2020 18:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[ID] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Zip] [float] NULL,
	[City] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[issues]    Script Date: 28-09-2020 18:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[issues](
	[Book ID] [nvarchar](255) NULL,
	[Book] [nvarchar](255) NULL,
	[Customer ID] [nvarchar](255) NULL,
	[Customer] [nvarchar](255) NULL,
	[Date of issue] [datetime] NULL,
	[Return date] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bookauthors]  WITH CHECK ADD  CONSTRAINT [FK_bookauthors_authors] FOREIGN KEY([AuthorKey])
REFERENCES [dbo].[authors] ([Key])
GO
ALTER TABLE [dbo].[bookauthors] CHECK CONSTRAINT [FK_bookauthors_authors]
GO
ALTER TABLE [dbo].[bookauthors]  WITH CHECK ADD  CONSTRAINT [FK_bookauthors_books] FOREIGN KEY([BookKey])
REFERENCES [dbo].[books] ([Key])
GO
ALTER TABLE [dbo].[bookauthors] CHECK CONSTRAINT [FK_bookauthors_books]
GO
ALTER TABLE [dbo].[BookCovers]  WITH CHECK ADD  CONSTRAINT [FK_BookCovers_books] FOREIGN KEY([Book_Key])
REFERENCES [dbo].[books] ([Key])
GO
ALTER TABLE [dbo].[BookCovers] CHECK CONSTRAINT [FK_BookCovers_books]
GO
ALTER TABLE [dbo].[BookSubjects]  WITH CHECK ADD  CONSTRAINT [FK_BookSubjects_books] FOREIGN KEY([Book_Key])
REFERENCES [dbo].[books] ([Key])
GO
ALTER TABLE [dbo].[BookSubjects] CHECK CONSTRAINT [FK_BookSubjects_books]
GO
USE [master]
GO
ALTER DATABASE [BookMaster] SET  READ_WRITE 
GO
