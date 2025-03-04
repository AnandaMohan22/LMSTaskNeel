USE [LMS]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28-02-2025 02:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LeaveApplications]    Script Date: 28-02-2025 02:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeaveApplications](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[LeaveTypeId] [int] NOT NULL,
	[LeavePeriodId] [int] NOT NULL,
	[RequestedDays] [int] NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LeaveApplications] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LeavePeriods]    Script Date: 28-02-2025 02:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeavePeriods](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LeavePeriods] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LeaveTypes]    Script Date: 28-02-2025 02:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeaveTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LeaveTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLeaveBalances]    Script Date: 28-02-2025 02:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLeaveBalances](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[LeaveTypeID] [int] NOT NULL,
	[AllocatedDays] [int] NOT NULL,
	[UsedDays] [int] NOT NULL,
	[LeavePeriodId] [int] NOT NULL,
 CONSTRAINT [PK_UserLeaveBalances] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28-02-2025 02:09:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250227035707_createleaveperoid', N'9.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250227041639_tablecreation', N'9.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250227195646_leavetypechanges', N'9.0.2')
GO
SET IDENTITY_INSERT [dbo].[LeavePeriods] ON 

INSERT [dbo].[LeavePeriods] ([ID], [Name], [StartDate], [EndDate], [CreatedDate]) VALUES (1, N'Annual Leave 2025', CAST(N'2025-01-01' AS Date), CAST(N'2025-12-31' AS Date), CAST(N'2025-02-27T16:57:11.2110442' AS DateTime2))
SET IDENTITY_INSERT [dbo].[LeavePeriods] OFF
GO
SET IDENTITY_INSERT [dbo].[LeaveTypes] ON 

INSERT [dbo].[LeaveTypes] ([Id], [Name]) VALUES (1, N'RH')
INSERT [dbo].[LeaveTypes] ([Id], [Name]) VALUES (2, N'CL')
INSERT [dbo].[LeaveTypes] ([Id], [Name]) VALUES (3, N'BL')
INSERT [dbo].[LeaveTypes] ([Id], [Name]) VALUES (4, N'AL')
SET IDENTITY_INSERT [dbo].[LeaveTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[UserLeaveBalances] ON 

INSERT [dbo].[UserLeaveBalances] ([ID], [UserID], [LeaveTypeID], [AllocatedDays], [UsedDays], [LeavePeriodId]) VALUES (1, 1, 1, 12, 0, 1)
SET IDENTITY_INSERT [dbo].[UserLeaveBalances] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [FullName], [Email], [CreatedAt]) VALUES (1, N'Mohan', N'mohan@gmail.com', CAST(N'2025-02-27T16:57:11.2110442' AS DateTime2))
INSERT [dbo].[Users] ([ID], [FullName], [Email], [CreatedAt]) VALUES (2, N'Test', N'test@gmail.com', CAST(N'2025-02-28T01:51:35.9278297' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
