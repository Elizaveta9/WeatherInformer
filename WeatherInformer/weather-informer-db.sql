USE [master]
GO
/****** Object:  Database [weather_informer] ******/
CREATE DATABASE [weather_informer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'weather_informer', FILENAME = N'D:\MSSQL\weather_informer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'weather_informer_log', FILENAME = N'D:\MSSQL\weather_informer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [weather_informer] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [weather_informer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [weather_informer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [weather_informer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [weather_informer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [weather_informer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [weather_informer] SET ARITHABORT OFF 
GO
ALTER DATABASE [weather_informer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [weather_informer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [weather_informer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [weather_informer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [weather_informer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [weather_informer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [weather_informer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [weather_informer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [weather_informer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [weather_informer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [weather_informer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [weather_informer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [weather_informer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [weather_informer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [weather_informer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [weather_informer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [weather_informer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [weather_informer] SET RECOVERY FULL 
GO
ALTER DATABASE [weather_informer] SET  MULTI_USER 
GO
ALTER DATABASE [weather_informer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [weather_informer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [weather_informer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [weather_informer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [weather_informer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [weather_informer] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'weather_informer', N'ON'
GO
ALTER DATABASE [weather_informer] SET QUERY_STORE = OFF
GO
USE [weather_informer]
GO
/****** Object:  Table [dbo].[city] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[city](
	[id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
	[nameTranslit] [varchar](100) NULL,
 CONSTRAINT [PK_city] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clothes] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clothes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[min_temperature] [int] NULL,
	[max_temperature] [int] NULL,
	[name] [varchar](50) NULL,
	[is_standart] [char](1) NULL,
 CONSTRAINT [PK_clothes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[last_logged_user] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[last_logged_user](
	[user_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[site] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[site](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[url] [text] NOT NULL,
	[temperature_regex] [text] NULL,
	[precipitation_regex] [text] NULL,
	[name] [varchar](50) NULL,
	[temperature_value_regex] [text] NULL,
	[precipitation_value_regex] [text] NULL,
 CONSTRAINT [PK_loader] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_clothes] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_clothes](
	[user_id] [int] NOT NULL,
	[clothes_id] [int] NOT NULL,
 CONSTRAINT [PK_user_clothes] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[clothes_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[city_id] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[weather] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[weather](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[temperature] [int] NULL,
	[precipitation] [varchar](10) NULL,
	[site_id] [int] NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_weather] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[weather_clothes] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[weather_clothes](
	[weather_id] [int] NOT NULL,
	[clothes_id] [int] NOT NULL,
 CONSTRAINT [PK_weather_clothes] PRIMARY KEY CLUSTERED 
(
	[weather_id] ASC,
	[clothes_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[clothes] ADD  CONSTRAINT [DF_clothes_is_standart]  DEFAULT ('N') FOR [is_standart]
GO
ALTER TABLE [dbo].[last_logged_user] ADD  CONSTRAINT [DF_Table_1_id_last_logged_user]  DEFAULT ((0)) FOR [user_id]
GO
ALTER TABLE [dbo].[user_clothes]  WITH CHECK ADD  CONSTRAINT [FK_user_clothes_clothes] FOREIGN KEY([clothes_id])
REFERENCES [dbo].[clothes] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_clothes] CHECK CONSTRAINT [FK_user_clothes_clothes]
GO
ALTER TABLE [dbo].[user_clothes]  WITH CHECK ADD  CONSTRAINT [FK_user_clothes_users] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_clothes] CHECK CONSTRAINT [FK_user_clothes_users]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_city] FOREIGN KEY([city_id])
REFERENCES [dbo].[city] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_city]
GO
ALTER TABLE [dbo].[weather]  WITH CHECK ADD  CONSTRAINT [FK_weather_site] FOREIGN KEY([site_id])
REFERENCES [dbo].[site] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[weather] CHECK CONSTRAINT [FK_weather_site]
GO
ALTER TABLE [dbo].[weather_clothes]  WITH CHECK ADD  CONSTRAINT [FK_weather_clothes_clothes] FOREIGN KEY([clothes_id])
REFERENCES [dbo].[clothes] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[weather_clothes] CHECK CONSTRAINT [FK_weather_clothes_clothes]
GO
ALTER TABLE [dbo].[weather_clothes]  WITH CHECK ADD  CONSTRAINT [FK_weather_clothes_weather] FOREIGN KEY([weather_id])
REFERENCES [dbo].[weather] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[weather_clothes] CHECK CONSTRAINT [FK_weather_clothes_weather]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [CK_users_id] CHECK  (([id]>(-1)))
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [CK_users_id]
GO
