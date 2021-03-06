USE [master]
GO
/****** Object:  Database [ItemCore]    Script Date: 18/09/2012 17:44:42 ******/
CREATE DATABASE [ItemCore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ItemCore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ItemCore.mdf' , SIZE = 92160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ItemCore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ItemCore_log.ldf' , SIZE = 136064KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ItemCore] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ItemCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ItemCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ItemCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ItemCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ItemCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ItemCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ItemCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ItemCore] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ItemCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ItemCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ItemCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ItemCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ItemCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ItemCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ItemCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ItemCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ItemCore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ItemCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ItemCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ItemCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ItemCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ItemCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ItemCore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ItemCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ItemCore] SET RECOVERY FULL 
GO
ALTER DATABASE [ItemCore] SET  MULTI_USER 
GO
ALTER DATABASE [ItemCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ItemCore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ItemCore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ItemCore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ItemCore] SET  READ_WRITE 
GO
