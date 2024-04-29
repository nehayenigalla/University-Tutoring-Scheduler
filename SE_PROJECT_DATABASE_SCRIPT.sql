CREATE DATABASE SE_PROJECT_DB

/****************************STUDENT LOGIN ***********************/

USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Student_Login]    Script Date: 19-03-2023 17:05:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student_Login](
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO

/****************************************STUDENT REGISTRATION****************/

USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Student_Registration]    Script Date: 19-03-2023 17:06:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student_Registration](
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Confirm_Password] [varchar](50) NULL,
	[Date_of_Birth] [varchar](50) NULL,
	[Email_Id] [varchar](50) NULL,
	[User_Type] [varchar](50) NULL,
	[Major] [varchar](50) NULL,
	[User_Name] [varchar](50) NULL
) ON [PRIMARY]
GO

/******************************************STUDENT PROFILE****************************/

USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Student_Profile]    Script Date: 19-03-2023 17:08:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student_Profile](
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Date_of_Birth] [varchar](50) NULL,
	[Email_Id] [varchar](50) NULL,
	[User_Name] [varchar](50) NULL,
	[Major] [varchar](50) NULL
) ON [PRIMARY]
GO

/************************************PROFESSOR lOGIN*************************/

USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Professor _Login]    Script Date: 19-03-2023 17:10:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Professor _Login](
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO

/************************PROFESSOR REGISTRATION*****************************/
USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Professor _Registration]    Script Date: 19-03-2023 17:10:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Professor _Registration](
	[User_Name] [varchar](50) NULL,
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Confirm_Password] [varchar](50) NULL,
	[Date_of_Birth] [varchar](50) NULL,
	[Email_Id] [varchar](50) NULL,
	[User_Type] [varchar](50) NULL,
	[Department_Name] [varchar](50) NULL,
	[Course] [varchar](50) NULL
) ON [PRIMARY]
GO

/***************************************PROFESSOR PROFILE********************/
USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Professor_Profile]    Script Date: 19-03-2023 17:11:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Professor_Profile](
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Date_of_Birth] [varchar](50) NULL,
	[Email_Id] [varchar](50) NULL,
	[Department_Name] [varchar](50) NULL,
	[Course] [varchar](50) NULL
) ON [PRIMARY]
GO

/*****************************CORDINATOR LOGIN********************/

USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Cordinator_Login]    Script Date: 19-03-2023 17:13:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cordinator_Login](
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO

/*************************************PROFESSOR AVAILABILITY********************/
USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Professor_Availability]    Script Date: 19-03-2023 17:13:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Professor_Availability](
	[Available_Date] [date] NULL,
	[Available_Time] [time](7) NULL
) ON [PRIMARY]
GO

/**********************************REQUEST FROM STUDENT*******************/

USE [SE_PROJECT_DB]
GO

/****** Object:  Table [dbo].[Request_From_Student]    Script Date: 19-03-2023 17:14:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Request_From_Student](
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Course] [varchar](50) NULL,
	[Req_Date] [date] NULL,
	[Timing] [time](7) NULL,
	[Status] [varchar](50) NULL
) ON [PRIMARY]
GO

