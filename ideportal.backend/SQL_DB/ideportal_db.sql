USE [master]
GO
/****** Object:  Database [testDB]    Script Date: 2020-07-16 1:06:15 PM ******/
CREATE DATABASE [testDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'testDB', FILENAME = N'D:\mssql_server\MSSQL15.MSSQLSERVER\MSSQL\DATA\testDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'testDB_log', FILENAME = N'D:\mssql_server\MSSQL15.MSSQLSERVER\MSSQL\DATA\testDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [testDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [testDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [testDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [testDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [testDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [testDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [testDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [testDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [testDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [testDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [testDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [testDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [testDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [testDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [testDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [testDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [testDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [testDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [testDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [testDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [testDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [testDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [testDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [testDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [testDB] SET RECOVERY FULL 
GO
ALTER DATABASE [testDB] SET  MULTI_USER 
GO
ALTER DATABASE [testDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [testDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [testDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [testDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [testDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'testDB', N'ON'
GO
ALTER DATABASE [testDB] SET QUERY_STORE = OFF
GO
USE [testDB]
GO
/****** Object:  Table [dbo].[Administrators]    Script Date: 2020-07-16 1:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrators](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 2020-07-16 1:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](max) NOT NULL,
	[ProjectLink] [nvarchar](max) NOT NULL,
	[ProjectCategory] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubmittedProjects]    Script Date: 2020-07-16 1:06:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubmittedProjects](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[SubmitName] [nvarchar](max) NOT NULL,
	[SubmitLink] [nvarchar](max) NOT NULL,
	[SubmitCategory] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SubmittedProjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrators] ON 

INSERT [dbo].[Administrators] ([Id], [Name], [Password]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[Administrators] ([Id], [Name], [Password]) VALUES (2, N'swagger', N'swagger')
SET IDENTITY_INSERT [dbo].[Administrators] OFF
GO
SET IDENTITY_INSERT [dbo].[Projects] ON 

INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (1, N'FlappyTerje', N'http://www.vg.no', N'C#')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (2, N'Pomodoro App', N'https://waninko.github.io/GETeamWorking/Modul1_nov19/pomodoroApp/pomodoro.html', N'JavaScript')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (3, N'Orakel', N'https://waninko.github.io/GETeamWorking/Modul1_nov19/orakel/orakel.html', N'JavaScript')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (4, N'Wordchooser', N'https://waninko.github.io/GETeamWorking/Modul1_jan20/wordchooserStory_this.html', N'JavaScript')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (5, N'Hey Vue!', N'https://vuejs.org/', N'Vue')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (7, N'Hello C#!', N'http://www.vg.no', N'C#')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (8, N'Dummy React', N'http://www.vg.no', N'React')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (9, N'More Vue plx', N'http://www.vg.no', N'Vue')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (10, N'Third Sharpie', N'http://www.vg.no', N'C#')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (11, N'CleanPlate', N'http://www.vg.no', N'HTML/CSS')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (12, N'swaggaroonie', N'https://swagger.io/', N'swagger')
INSERT [dbo].[Projects] ([Id], [ProjectName], [ProjectLink], [ProjectCategory]) VALUES (10005, N'fromSwag', N'Swaggy.yo', N'swagger')
SET IDENTITY_INSERT [dbo].[Projects] OFF
GO
SET IDENTITY_INSERT [dbo].[SubmittedProjects] ON 

INSERT [dbo].[SubmittedProjects] ([Id], [SubmitName], [SubmitLink], [SubmitCategory]) VALUES (3, N'Et navn', N'en link', N'en kategori')
INSERT [dbo].[SubmittedProjects] ([Id], [SubmitName], [SubmitLink], [SubmitCategory]) VALUES (10002, N'tullball', N'tullelink', N'tull')
SET IDENTITY_INSERT [dbo].[SubmittedProjects] OFF
GO
USE [master]
GO
ALTER DATABASE [testDB] SET  READ_WRITE 
GO
