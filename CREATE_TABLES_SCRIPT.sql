CREATE DATABASE UniversityTutoringWebsiteDatabase
USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[CoordinatorRequests]    Script Date: 4/29/2024 1:20:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CoordinatorRequests](
	[UserName] [varchar](30) NULL,
	[UserType] [varchar](30) NULL,
	[UserMessage] [varchar](max) NULL,
	[MessageStatus] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Cordinator_Login]    Script Date: 4/29/2024 1:20:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cordinator_Login](
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Professor _Login]    Script Date: 4/29/2024 1:21:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Professor _Login](
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Professor _Registration]    Script Date: 4/29/2024 1:21:37 AM ******/
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


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Professor_Availability]    Script Date: 4/29/2024 1:21:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Professor_Availability](
	[Available_Date] [date] NULL,
	[Available_Time] [time](7) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Professor_Profile]    Script Date: 4/29/2024 1:22:07 AM ******/
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


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Request_From_Student]    Script Date: 4/29/2024 1:22:27 AM ******/
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


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Student_Login]    Script Date: 4/29/2024 1:22:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student_Login](
	[User_Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Student_Profile]    Script Date: 4/29/2024 1:22:56 AM ******/
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


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[Student_Registration]    Script Date: 4/29/2024 1:23:11 AM ******/
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


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[StudentProfile]    Script Date: 4/29/2024 1:23:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentProfile](
	[UserName] [varchar](30) NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](30) NULL,
	[Phone] [bigint] NULL,
	[Major] [varchar](50) NULL,
	[Level] [varchar](50) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[StudentRequest]    Script Date: 4/29/2024 1:23:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentRequest](
	[SlotDate] [datetime] NULL,
	[timeslot] [varchar](40) NULL,
	[professorname] [varchar](40) NULL,
	[studentusername] [varchar](40) NULL,
	[appointmentstatus] [varchar](40) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[StudentRequestwithstatus]    Script Date: 4/29/2024 1:23:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentRequestwithstatus](
	[SlotDate] [datetime] NULL,
	[timeslot] [varchar](40) NULL,
	[professorname] [varchar](40) NULL,
	[studentusername] [varchar](40) NULL,
	[appointmentstatus] [varchar](40) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[TimeSlots]    Script Date: 4/29/2024 1:24:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TimeSlots](
	[dateselected] [datetime] NOT NULL,
	[time_slot] [varchar](30) NOT NULL,
	[Tutor_Name] [varchar](30) NOT NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[tutorRequests]    Script Date: 4/29/2024 1:24:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tutorRequests](
	[RequestId] [varchar](30) NULL,
	[StudentId] [varchar](30) NULL,
	[RequestedSlot] [varchar](30) NULL,
	[RequestStatus] [varchar](20) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[TutorRequestsStatus]    Script Date: 4/29/2024 1:25:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TutorRequestsStatus](
	[slotdate] [datetime] NULL,
	[timeslots] [varchar](40) NULL,
	[studentusername] [varchar](40) NULL,
	[requeststatus] [varchar](40) NULL,
	[tutorusername] [varchar](40) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[UserCredentials]    Script Date: 4/29/2024 1:25:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserCredentials](
	[username] [varchar](25) NULL,
	[pwd] [varchar](25) NULL
) ON [PRIMARY]
GO


USE [UniversityTutoringWebsiteDatabase]
GO

/****** Object:  Table [dbo].[UserRegistration]    Script Date: 4/29/2024 1:25:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserRegistration](
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Phone] [bigint] NULL,
	[Pwd] [varchar](50) NULL,
	[DOB] [date] NULL,
	[EmailId] [varchar](50) NULL,
	[UserType] [varchar](20) NULL,
	[Course] [varchar](30) NULL,
	[Level] [varchar](30) NULL,
	[rating] [decimal](2, 1) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserRegistration] ADD  DEFAULT ((0.0)) FOR [rating]
GO


