/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2022/6/4 下午 08:42:12 ******/
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Camping_Area_Pictures]    Script Date: 2022/6/4 下午 08:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camping_Area_Pictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Camping_AreaId] [int] NOT NULL,
	[Path] [nvarchar](max) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Camping_Area_Pictures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Camping_Areas]    Script Date: 2022/6/4 下午 08:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camping_Areas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SellerId] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Region] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IsAudit] [bit] NOT NULL,
	[AuditDescription] [nvarchar](max) NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Camping_Areas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 2022/6/4 下午 08:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[RoomId] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[CancelDate] [datetime2](7) NULL,
	[Status] [int] NOT NULL,
	[RefundDate] [datetime2](7) NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room_Pictures]    Script Date: 2022/6/4 下午 08:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_Pictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoomId] [int] NOT NULL,
	[Path] [nvarchar](max) NOT NULL,
	[UpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Room_Pictures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 2022/6/4 下午 08:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Camping_AreaId] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Count] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[RoomType] [int] NOT NULL,
	[Price_Of_Weekdays] [decimal](18, 2) NOT NULL,
	[Price_Of_Weekends] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sellers]    Script Date: 2022/6/4 下午 08:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sellers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsMailConfirm] [bit] NOT NULL,
	[Salt] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sellers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 2022/6/4 下午 08:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Camping_AreaId] [int] NOT NULL,
	[Breakfast] [bit] NOT NULL,
	[Lunch] [bit] NOT NULL,
	[Dinner] [bit] NOT NULL,
	[Public_Refrigerator] [bit] NOT NULL,
	[Tent_Equipment] [bit] NOT NULL,
	[Kitchen_Utensils] [bit] NOT NULL,
	[Canopy] [bit] NOT NULL,
	[Wifi] [bit] NOT NULL,
	[Night_Lighting] [bit] NOT NULL,
	[Power_Supply] [bit] NOT NULL,
	[Outdoor_Tables_Chairs] [bit] NOT NULL,
	[Canteen] [bit] NOT NULL,
	[Mattress] [bit] NOT NULL,
	[No_Equipment] [bit] NOT NULL,
	[IsCancel] [bit] NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2022/6/4 下午 08:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[IsMailConfirm] [bit] NOT NULL,
	[Salt] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428100446_azure initial', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428121800_add camping_area json', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428130826_add camping_area_picture json', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428145958_add room json', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428153403_add room picture json', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428163955_add service json', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428184917_delete salt required', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428190621_add data to catable', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428193117_delete user salt', N'5.0.16')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220429203927_add capicture', N'5.0.16')
GO
SET IDENTITY_INSERT [dbo].[Camping_Area_Pictures] ON 

INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (1, 1, N'campingarea1.jpg', CAST(N'2022-04-13T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (2, 1, N'campingarea2.jpg', CAST(N'2022-04-14T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (3, 1, N'campingarea3.jpg', CAST(N'2022-04-15T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (4, 1, N'campingarea4.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (5, 1, N'campingarea39.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (6, 2, N'campingarea5.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (7, 2, N'campingarea6.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (8, 2, N'campingarea7.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (9, 3, N'campingarea15.jpg', CAST(N'2022-04-15T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (10, 3, N'campingarea16.jpg', CAST(N'2022-04-15T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (11, 3, N'campingarea18.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (12, 4, N'campingarea48.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (13, 4, N'campingarea49.jpg', CAST(N'2022-04-21T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (14, 4, N'campingarea50.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (15, 5, N'campingarea31.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (16, 5, N'campingarea32.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (17, 5, N'campingarea35.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (23, 7, N'campingarea42.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (24, 7, N'campingarea46.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (25, 7, N'campingarea47.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (26, 8, N'campingarea32.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (27, 8, N'campingarea33.jpg', CAST(N'2022-04-21T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (28, 8, N'campingarea34.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (29, 9, N'campingarea12.jpg', CAST(N'2022-04-23T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (30, 9, N'campingarea13.jpg', CAST(N'2022-04-23T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (31, 9, N'campingarea21.jpg', CAST(N'2022-04-24T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (32, 10, N'campingarea32.jpg', CAST(N'2022-04-25T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (33, 10, N'campingarea38.jpg', CAST(N'2022-04-25T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (34, 10, N'campingarea39.jpg', CAST(N'2022-04-26T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (35, 11, N'campingarea11.jpg', CAST(N'2022-04-16T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (36, 11, N'campingarea13.jpg', CAST(N'2022-04-17T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (37, 11, N'campingarea28.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (38, 21, N'20220428180613湖 露營.jfif', CAST(N'2022-04-28T18:06:13.2842959' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (39, 21, N'20220428180613下載.jfif', CAST(N'2022-04-28T18:06:13.2943377' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (40, 21, N'20220428180613a1000008_parts_5b1487c8d641b.jpg', CAST(N'2022-04-28T18:06:13.3033971' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (41, 12, N'campingarea28.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (42, 12, N'campingarea27.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (43, 12, N'campingarea29.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (56, 12, N'campingarea50.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (57, 12, N'campingarea45.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (58, 12, N'campingarea46.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (59, 13, N'campingarea35.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (60, 13, N'campingarea31.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (61, 13, N'campingarea32.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (62, 14, N'campingarea28.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (63, 14, N'campingarea29.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (64, 14, N'campingarea30.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (65, 15, N'campingarea3.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (66, 15, N'campingarea2.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (67, 15, N'campingarea1.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (68, 16, N'campingarea12.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (69, 16, N'campingarea14.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (70, 16, N'campingarea13.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (71, 17, N'campingarea34.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (72, 17, N'campingarea31.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (73, 17, N'campingarea32.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (74, 18, N'campingarea43.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (75, 18, N'campingarea44.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (76, 18, N'campingarea5.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (77, 19, N'campingarea46.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (78, 19, N'campingarea45.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (79, 19, N'campingarea48.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (80, 20, N'campingarea42.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (81, 20, N'campingarea49.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (82, 20, N'campingarea47.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (83, 23, N'20220430141204jonathan-forage-1azAjl8FTnU-unsplash.jpg', CAST(N'2022-04-30T14:12:04.7515172' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (84, 23, N'20220430141204scott-goodwill-y8Ngwq34_Ak-unsplash.jpg', CAST(N'2022-04-30T14:12:04.7905939' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (85, 23, N'20220430141204denys-nevozhai-63Znf38gnXk-unsplash.jpg', CAST(N'2022-04-30T14:12:04.8671248' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (111, 35, N'20220502114119campingarea6.jpg', CAST(N'2022-05-02T11:41:19.8958910' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (112, 35, N'20220502114119campingarea15.jpg', CAST(N'2022-05-02T11:41:19.9203766' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (113, 35, N'20220502114119campingarea23.jpg', CAST(N'2022-05-02T11:41:19.9234886' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (117, 37, N'20220502122902campingarea1.jpg', CAST(N'2022-05-02T12:29:02.5852873' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (118, 37, N'20220502122902campingarea2.jpg', CAST(N'2022-05-02T12:29:02.5923320' AS DateTime2))
INSERT [dbo].[Camping_Area_Pictures] ([Id], [Camping_AreaId], [Path], [UpdateTime]) VALUES (119, 37, N'20220502122902campingarea5.jpg', CAST(N'2022-05-02T12:29:02.5992966' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Camping_Area_Pictures] OFF
GO
SET IDENTITY_INSERT [dbo].[Camping_Areas] ON 

INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (1, 1, N'大海露營區', N'0315-045-844', N'新竹縣五峰鄉花園村6鄰121之5號', 5, N'大圓山露營區位於靠海的營位，有許多樹可以遮蔽陽光，右手邊則有搭建遮雨棚以及水泥屋和竹屋(位於水泥屋後方)，提供不同的住宿選擇，設備基本上也是以簡單為主。 往左邊望去就可以看到墾丁的知名景點之一的船帆石，最右邊便是鵝鑾鼻公園，晚上可以明顯看到鵝鑾鼻燈塔的燈光', 1, NULL, CAST(N'2022-04-13T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (2, 1, N'翠林農場', N'0945-140-341', N'南投縣魚池鄉投69-3鄉道555號', 8, N'翠林農場海拔750多公尺，得天獨厚的天然環境，兩面環山，還有青翠的綠地、豐富有趣生態導覽，來露營的朋友還可以規劃螢火蟲導覽、野溪導覽，行程好豐富。', 1, NULL, CAST(N'2022-04-14T11:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (3, 1, N'六龜陽光綠地水世界露營區', N'0963-459-755', N'高雄市六龜區新發里和平路305-2號', 12, N'位於高雄六龜的「陽光綠地水世界露營區」在一望無盡的山水自然環境中，遠離都市的塵囂紛擾在寧靜的大自然氣氛中，感受那最純粹的露營區風景！', 1, N'照片太模糊,敘述請在詳盡一些。', CAST(N'2022-04-17T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (4, 1, N'夢露露營空間', N'0927-858-657', N'屏東縣萬巒鄉光明路42-10號', 13, N'夢露露營空間位於屏東萬巒鄉，鄰近萬金聖母聖堂，營區不僅可以自搭帳篷，還提供了免裝備服務，讓露營新手能輕鬆體驗露營，設有戲水池、沙坑、大草地讓孩子有很棒的活動空間，大人放鬆小孩放電，很適合親朋好友一同享樂。', 1, NULL, CAST(N'2022-04-23T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (5, 1, N'起初休閒露營區', N'0965-312-713', N'新竹縣尖石鄉梅花村9鄰242-6號', 4, N'起初休閒露營區開箱體驗！位在新竹尖石深山林間，營區內還有茂密的杉木林，漫步於林間的步道享受芬多精和蓊鬱美景，山坡邊的營地更能 180 度遠眺層巒疊嶂，值得前往紮營體驗。', 1, NULL, CAST(N'2022-04-15T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (7, 2, N'戈巴侖森林露營區', N'0975-595-131', N'311新竹縣五峰鄉和平部落', 4, N'駛入蜿蜒的鄉間小徑，遠離塵囂與感受寧靜的自然美景。 森林步道感受杉林芬多精的滋潤、蟲鳴鳥叫的交響樂，體驗山林的奇妙旅程。', 1, NULL, CAST(N'2022-04-16T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (8, 2, N'山晴野舍', N'0923-345-123', N'365苗栗縣泰安鄉泰安士林國小後依天晴指標走', 5, N'位於苗栗泰安山上的天晴野舍，是一處具有特色的露營區，整個營地座落的位置寧靜、舒適，且面向大安溪遼闊景緻，坐在營位上可以感受放空的心境。 若有機會可以遇見太陽霞光、琉璃光、雲海等漂亮景色。', 1, NULL, CAST(N'2022-04-20T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (9, 2, N'山野星空親子露營區', N'0968-605-609', N'南投縣埔里鎮福長路260號', 8, N'位於南投縣埔里鎮，周邊即是福興溫泉，更是在能高瀑布的下方，絕佳的地理位置讓您充分感受到大自然最純粹的洗禮，無光害的環境在入夜後便可望見點點繁星佈滿天際，璀璨浪漫的景緻總令人心醉，而夏季時光亦可看見成群的螢火蟲在草叢間嬉戲。', 1, NULL, CAST(N'2022-04-21T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (10, 2, N'十分自然露營區', N'0936-175-763', N'新北市平溪區靜安路三段391號-7', 1, N'是個適合親子露營、親近大自然的好地方。近市郊卻能遠離塵囂，可以靜靜聆聽潺潺的流水聲，亦可呼吸森林的清新。給孩子們一個最自然的玩耍空間，也給自己一個最放鬆的休息地方。', 0, N'照片不清楚，露營區搭建好才能通過。', CAST(N'2022-04-22T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (11, 2, N'松野農園露營區', N'0963-123-251', N'桃園市復興區高義里7鄰色霧鬧10-16號', 3, N'松野農園露營區每到5、6月份繡球花季，營地有漂亮的繡球花可以觀賞，白天雲海雲瀑，夜晚微風陣陣看著絕美夜景是件多浪漫的事。', 1, NULL, CAST(N'2022-04-24T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (12, 3, N'蜻蜓露營區-嘎色鬧', N'0939-523-829', N'桃園市復興區奎輝里嘎色鬧7鄰2號', 3, N'嘎色鬧意指「最角落的地方」，是神給遷徙時的泰雅族人恩典之地,如「蜻蜓」逐水繁延其後代佇築於此，與大地共存。 兩年前的一場風雨摧不斷族人堅守家園與攜手重建的心，「蜻蜓營區」就是營主一家用雙手見證他們堅守家園再造神所賜的新天新地。', 0, NULL, CAST(N'2022-04-28T19:08:33.1244193' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (13, 3, N'木河谷', N'0925-312-956', N'桃園市復興區義盛里6鄰62號和平橋後左轉約400公尺處', 3, N'位於小烏來風景區，以森林和瀑布為景點的義盛部落，隱身於部落裡的宇內溪谷旁，木河谷，二十年櫸樹，五十年老田，心靈沉靜的小溪谷，​歡迎您親自蒞臨感受。', 1, NULL, CAST(N'2022-04-14T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (14, 3, N'山豬王露營區', N'0915-012-889', N'桃園市復興區12號1', 3, N'露營區草地大約是500坪的空間, 整個園區大概是1500坪空間, 區內大樹林立, 四面青山環繞, 優美僻靜, 後臨北勢溪可以戲水玩樂, 園內景觀視野遼闊, 適合三五好友群聚, 享受悠閒、寧靜的露營時光。', 1, NULL, CAST(N'2022-04-15T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (15, 4, N'巴棍杉林', N'0910-170-544', N'新竹縣五峰鄉茅圃產業道路', 4, N'【巴棍杉林】擁有超美獨特山陵線環繞、雲海 堪稱白蘭之最的景色，秋冬雲海旺季可賞大景、營區的草皮柔軟、營區廣闊 原生大樹遮陰 適合新手露友、三代同行！', 1, NULL, CAST(N'2022-04-17T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (16, 4, N'大東田露營區', N'0921-612-597', N'屏東縣恆春鎮鵝鑾里船帆路999-1號', 13, N'沒有華麗人工美，而執意走自己步調自然風，四面環山，好似被山林擁抱著的幸福，享受大自然，小而美歡迎光臨大東田', 1, NULL, CAST(N'2022-04-19T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (17, 4, N'遊牧民族露營區', N'0912-850-330', N'苗栗縣泰安鄉大興村５鄰47之6號', 5, N'游老闆的經營理念：親切服務，不超收！在這裡大家都是遊牧民族，我們為露客打造露營該有的環境；帳貼帳、夜市情景不在這裡。', 1, NULL, CAST(N'2022-04-20T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (18, 5, N'戀戀南橫2071露營區', N'0912-693-503', N'高雄市六龜區(台20線71K處)', 12, N'南橫2071農場，位於荖濃往甲仙南橫公路直瀨溪旁，群山環繞，氣候宜人，空氣清新，環境清幽，最適合整天忙錄於工作與想遠離塵囂及愛好露營活動朋友的最佳場地。', 1, NULL, CAST(N'2022-04-21T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (19, 5, N'希望之丘露營區', N'0965-257-713', N'宜蘭縣冬山鄉小埤五路331號', 14, N'希望之丘休閒農場，可以採果和體驗療育香草及花卉帶來的放鬆心靈，也可以嘗試農業體驗及生態之旅，來感受大自然裡的生態與奧妙。還可以露營、夜間觀星及享受宜蘭在地的美食饗宴。', 1, NULL, CAST(N'2022-04-23T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (20, 5, N'沐野露營區', N'0922-157-971', N'宜蘭縣大同鄉泰雅路二段92巷99-1號', 14, N'關於營區【營業時間】進場時間：當日上午10：00以後/退場時間：次日中午12：00以前預訂(星期五)二天一夜露營，請於星期六上午11:00前離場，以提供星期六訂位者使用，造成不便敬請見諒。 連續假日營地紮營時間為下午1點至隔日中午12點，以供下位紮營者使用。 週五(或前一晚) 提前進場 (限隔日續住者) 18:00~22:00 可入營，酌收每帳500元(現場收費) ，18:00前到場，以整日收費計算，請於23:00前搭營完成，避免打擾已就寢露友。請於露營日2天前電話聯絡0922-157971營主確認是否有營位。連續假日期間、星期六晚上不提供夜衝服務', 1, NULL, CAST(N'2022-04-24T23:14:33.8620673' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (21, 6, N'TibaMe露營區', N'0123-456-789', N'南京復興', 2, N'很美ㄛ！！', 0, N'不相關', CAST(N'2022-04-28T18:06:13.0721126' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (23, 26, N'魔法森林', N'0423-445-678', N'台中市南區國光路250號', 6, N'森林中有著奇幻的魔法，讓來到此處的旅客都流連忘返，得到身心的休息', 0, N'多的是你不知道的事', CAST(N'2022-04-30T14:12:04.2610202' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (35, 2, N'四季露營區', N'0945-112-340', N'五峰鄉新竹縣311', 4, N'四季露營區右邊是白蘭部落，全台最高的樂山基地及雪霸國家公園; 面向中央山脈遠眺雪山北峰等三千公尺以上百岳，正下方是清泉風景區', 1, NULL, CAST(N'2022-05-02T12:44:40.3803929' AS DateTime2))
INSERT [dbo].[Camping_Areas] ([Id], [SellerId], [Name], [Phone], [Address], [Region], [Description], [IsAudit], [AuditDescription], [UpdateTime]) VALUES (37, 28, N'雲海露營區', N'0939-523-829', N'高雄市六龜區新發里和平路305-2號', 12, N'因雲海著名。', 0, NULL, CAST(N'2022-05-02T12:29:02.3863802' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Camping_Areas] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (16, 3, N'Lynn', N'0912345678', 7, CAST(N'2022-04-28T18:01:36.3896601' AS DateTime2), CAST(N'2022-04-29T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-04T00:00:00.0000000' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (20, 3, N'Lynn', N'0915332211', 17, CAST(N'2022-04-28T18:31:57.3343698' AS DateTime2), CAST(N'2022-04-29T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-04T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (24, 4, N'欣儀', N'0912345678', 9, CAST(N'2022-04-28T18:34:03.4533561' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-04-30T10:07:34.7317948' AS DateTime2), 3, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (26, 5, N'羅德曼', N'0988456789', 19, CAST(N'2022-04-28T19:20:28.7742172' AS DateTime2), CAST(N'2022-05-12T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-19T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (29, 7, N'FackName', N'FackPhone', 3, CAST(N'2022-04-28T21:50:42.3955429' AS DateTime2), CAST(N'2022-04-28T21:50:42.3955463' AS DateTime2), CAST(N'2022-04-28T21:50:42.3955467' AS DateTime2), NULL, 4, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (36, 8, N'qweqwe', N'FackPhone', 21, CAST(N'2022-04-29T05:16:42.0549518' AS DateTime2), CAST(N'2022-04-29T05:16:42.0549537' AS DateTime2), CAST(N'2022-04-29T05:16:42.0549653' AS DateTime2), NULL, 4, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (38, 2, N'增而', N'0934212212', 9, CAST(N'2022-04-29T11:22:34.5670285' AS DateTime2), CAST(N'2022-05-06T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-09T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (39, 7, N'Lillian2', N'0988888888', 5, CAST(N'2022-05-01T10:29:38.9558952' AS DateTime2), CAST(N'2022-05-18T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-20T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (40, 7, N'Lillian', N'0999999999', 4, CAST(N'2022-05-01T18:22:18.8555347' AS DateTime2), CAST(N'2022-05-04T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-12T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (41, 2, N'TOM', N'0987654321', 1, CAST(N'2022-04-29T12:15:36.5128975' AS DateTime2), CAST(N'2022-05-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-09T00:00:00.0000000' AS DateTime2), CAST(N'2022-04-30T10:27:46.3459095' AS DateTime2), 3, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (57, 2, N'陳志嘉', N'0999999999', 7, CAST(N'2022-04-30T06:20:34.9868697' AS DateTime2), CAST(N'2022-05-01T00:00:00.0000000' AS DateTime2), CAST(N'2023-03-10T00:00:00.0000000' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (72, 18, N'LCC', N'0983123321', 19, CAST(N'2022-04-30T13:20:04.1881462' AS DateTime2), CAST(N'2022-05-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (73, 18, N'LCC', N'0983123321', 1, CAST(N'2022-04-30T13:36:59.3660923' AS DateTime2), CAST(N'2022-05-08T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-10T00:00:00.0000000' AS DateTime2), NULL, 2, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (74, 18, N'LCC', N'0983123321', 7, CAST(N'2022-04-30T13:41:15.7195473' AS DateTime2), CAST(N'2022-05-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-02T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (76, 18, N'FackName', N'FackPhone', 9, CAST(N'2022-04-30T13:42:32.0632805' AS DateTime2), CAST(N'2022-04-30T13:42:32.0632825' AS DateTime2), CAST(N'2022-04-30T13:42:32.0632826' AS DateTime2), NULL, 4, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (77, 3, N'Lynn', N'0912345678', 6, CAST(N'2022-04-30T18:48:23.8417542' AS DateTime2), CAST(N'2022-05-12T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-26T00:00:00.0000000' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (78, 3, N'Lynn', N'0912345678', 6, CAST(N'2022-04-30T18:48:49.4009484' AS DateTime2), CAST(N'2022-05-10T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-18T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (83, 8, N'123', N'0987654321', 1, CAST(N'2022-05-01T09:08:35.3565956' AS DateTime2), CAST(N'2022-05-02T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-04T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-01T17:36:29.3462015' AS DateTime2), 3, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (85, 7, N'Lillian3', N'0977777777', 4, CAST(N'2022-05-01T10:32:29.7809239' AS DateTime2), CAST(N'2022-05-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-10T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (86, 7, N'Lillian4', N'0966666666', 4, CAST(N'2022-05-01T10:35:11.0097356' AS DateTime2), CAST(N'2022-05-19T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-25T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (87, 7, N'Lillian5', N'0922222222', 4, CAST(N'2022-05-01T10:48:59.7695304' AS DateTime2), CAST(N'2022-05-22T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-25T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (88, 8, N'王明智', N'0945678912', 1, CAST(N'2022-05-01T12:45:26.6307111' AS DateTime2), CAST(N'2022-09-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-09-21T00:00:00.0000000' AS DateTime2), NULL, 0, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (98, 2, N'Wendy', N'0912837212', 16, CAST(N'2022-05-02T08:27:35.7395777' AS DateTime2), CAST(N'2022-05-12T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-16T00:00:00.0000000' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (128, 19, N'FackName', N'FackPhone', 1, CAST(N'2022-05-02T11:08:50.1242633' AS DateTime2), CAST(N'2022-05-02T11:08:50.1242642' AS DateTime2), CAST(N'2022-05-02T11:08:50.1242643' AS DateTime2), NULL, 4, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (134, 19, N'許凱', N'0999999999', 4, CAST(N'2022-05-02T11:35:36.5287574' AS DateTime2), CAST(N'2022-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-18T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-02T11:36:12.4528157' AS DateTime2), 2, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (141, 19, N'FackName', N'FackPhone', 6, CAST(N'2022-05-02T11:44:49.1447075' AS DateTime2), CAST(N'2022-05-02T11:44:49.1447096' AS DateTime2), CAST(N'2022-05-02T11:44:49.1447102' AS DateTime2), NULL, 4, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (142, 19, N'FackName', N'FackPhone', 7, CAST(N'2022-05-02T11:44:50.4048177' AS DateTime2), CAST(N'2022-05-02T11:44:50.4048185' AS DateTime2), CAST(N'2022-05-02T11:44:50.4048187' AS DateTime2), NULL, 4, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (144, 19, N'FackName', N'FackPhone', 3, CAST(N'2022-05-02T11:48:20.4242479' AS DateTime2), CAST(N'2022-05-02T11:48:20.4242488' AS DateTime2), CAST(N'2022-05-02T11:48:20.4242489' AS DateTime2), NULL, 4, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (145, 19, N'FackName', N'FackPhone', 4, CAST(N'2022-05-02T11:48:22.2667088' AS DateTime2), CAST(N'2022-05-02T11:48:22.2667110' AS DateTime2), CAST(N'2022-05-02T11:48:22.2667115' AS DateTime2), NULL, 4, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (150, 2, N'Wendy', N'0923123111', 31, CAST(N'2022-05-01T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-03T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-05T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (152, 2, N'Emily', N'0934765234', 31, CAST(N'2022-05-01T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-08T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-10T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (154, 2, N'Andrea', N'0981234625', 31, CAST(N'2022-04-29T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-09T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-11T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (155, 2, N'Sam', N'0912321328', 31, CAST(N'2022-05-01T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-09T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-11T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (156, 2, N'Ron', N'0906731213', 31, CAST(N'2022-05-01T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-19T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-20T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (157, 2, N'Tom', N'0923832843', 31, CAST(N'2022-05-01T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-30T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-31T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (158, 2, N'Yoyo', N'0916342524', 32, CAST(N'2022-04-01T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-08T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-13T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (159, 2, N'Daniel', N'0932635243', 32, CAST(N'2022-04-01T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-13T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (160, 2, N'Gray', N'0912876321', 32, CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-13T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (161, 2, N'Queen', N'0962723827', 32, CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-13T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (162, 2, N'Leo', N'0912834732', 32, CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-04-13T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (163, 2, N'Taylor', N'0912834723', 32, CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-08T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-13T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (164, 2, N'Oliver', N'0937843723', 32, CAST(N'2022-05-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-06-05T23:14:33.8620673' AS DateTime2), CAST(N'2022-06-08T23:14:33.8620673' AS DateTime2), NULL, 2, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (165, 2, N'Alina', N'0928374734', 33, CAST(N'2022-05-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-21T23:14:33.8620673' AS DateTime2), NULL, 2, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (166, 2, N'Vivian', N'0912834734', 34, CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-02T23:14:33.8620673' AS DateTime2), CAST(N'2022-05-10T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (167, 2, N'Penny', N'0918234213', 35, CAST(N'2022-04-12T23:14:33.8620673' AS DateTime2), CAST(N'2022-06-02T23:14:33.8620673' AS DateTime2), CAST(N'2022-06-10T23:14:33.8620673' AS DateTime2), NULL, 1, NULL)
INSERT [dbo].[OrderDetails] ([Id], [UserId], [Name], [Phone], [RoomId], [CreateDate], [StartDate], [EndDate], [CancelDate], [Status], [RefundDate]) VALUES (168, 20, N'FackName', N'FackPhone', 1, CAST(N'2022-05-12T16:45:57.2899722' AS DateTime2), CAST(N'2022-05-12T16:45:57.2901114' AS DateTime2), CAST(N'2022-05-12T16:45:57.2901271' AS DateTime2), NULL, 4, NULL)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Room_Pictures] ON 

INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (1, 1, N'room26.jpg', CAST(N'2022-04-13T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (2, 1, N'room27.jpg', CAST(N'2022-04-14T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (3, 1, N'room28.jpg', CAST(N'2022-04-15T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (4, 2, N'room37.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (5, 2, N'room38.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (6, 2, N'room39.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (7, 3, N'room72.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (8, 3, N'room73.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (9, 3, N'room74.jpg', CAST(N'2022-04-15T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (10, 4, N'room1.jpg', CAST(N'2022-04-15T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (11, 4, N'room2.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (12, 4, N'room3.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (13, 5, N'room20.jpg', CAST(N'2022-04-21T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (14, 5, N'room21.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (15, 5, N'room23.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (16, 6, N'room94.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (17, 6, N'room95.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (18, 6, N'room96.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (19, 7, N'room63.jpg', CAST(N'2022-04-21T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (20, 7, N'room65.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (21, 7, N'room66.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (22, 8, N'room89.jpg', CAST(N'2022-04-23T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (23, 8, N'room90.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (24, 8, N'room91.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (25, 9, N'room97.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (26, 9, N'room98.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (27, 9, N'room99.jpg', CAST(N'2022-04-21T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (28, 10, N'room27.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (29, 10, N'room28.jpg', CAST(N'2022-04-23T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (30, 10, N'room30.jpg', CAST(N'2022-04-23T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (46, 16, N'room82.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (47, 16, N'room74.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (48, 16, N'room83.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (49, 17, N'room14.jpg', CAST(N'2022-04-21T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (50, 17, N'room12.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (51, 17, N'room13.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (52, 18, N'room7.jpg', CAST(N'2022-04-23T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (53, 18, N'room6.jpg', CAST(N'2022-04-18T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (54, 18, N'room5.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (55, 19, N'room17.jpg', CAST(N'2022-04-19T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (56, 19, N'room19.jpg', CAST(N'2022-04-20T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (57, 19, N'room20.jpg', CAST(N'2022-04-21T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (58, 20, N'room51.jpg', CAST(N'2022-04-22T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (59, 20, N'room52.jpg', CAST(N'2022-04-23T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (60, 20, N'room53.jpg', CAST(N'2022-04-23T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (61, 21, N'room6.jpg', CAST(N'2022-04-24T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (62, 21, N'room4.jpg', CAST(N'2022-04-25T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (63, 21, N'room5.jpg', CAST(N'2022-04-25T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (64, 22, N'room2.jpg', CAST(N'2022-04-26T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (65, 22, N'room3.jpg', CAST(N'2022-04-16T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (66, 22, N'room4.jpg', CAST(N'2022-04-17T08:14:33.8620673' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (67, 23, N'637867660865591865下載 (1).jfif', CAST(N'2022-04-28T18:08:06.5653057' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (68, 23, N'637867660865808990images.jfif', CAST(N'2022-04-28T18:08:06.5938535' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (69, 23, N'637867660865939296下載 (2).jfif', CAST(N'2022-04-28T18:08:06.6971106' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (70, 24, N'637869249934384000denys-nevozhai-63Znf38gnXk-unsplash.jpg', CAST(N'2022-04-30T14:16:33.5304855' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (71, 24, N'637869249935424881scott-goodwill-y8Ngwq34_Ak-unsplash.jpg', CAST(N'2022-04-30T14:16:33.5688623' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (72, 24, N'637869249935689517jonathan-forage-1azAjl8FTnU-unsplash.jpg', CAST(N'2022-04-30T14:16:33.6163379' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (92, 31, N'637870885622761508room51.jpg', CAST(N'2022-05-02T11:42:42.2878612' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (93, 31, N'637870885622879529room52.jpg', CAST(N'2022-05-02T11:42:42.2973839' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (94, 31, N'637870885622975020room53.jpg', CAST(N'2022-05-02T11:42:42.3074156' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (95, 32, N'637870886131376731room72.jpg', CAST(N'2022-05-02T11:43:33.1445520' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (96, 32, N'637870886131446419room73.jpg', CAST(N'2022-05-02T11:43:33.1477648' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (97, 32, N'637870886131478292room74.jpg', CAST(N'2022-05-02T11:43:33.1503274' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (98, 33, N'637870886721537590room28.jpg', CAST(N'2022-05-02T11:44:32.1666321' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (99, 33, N'637870886721667197room41.jpg', CAST(N'2022-05-02T11:44:32.1765641' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (100, 33, N'637870886721766268room42.jpg', CAST(N'2022-05-02T11:44:32.1872171' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (101, 34, N'637870887242467907room87.jpg', CAST(N'2022-05-02T11:45:24.2542706' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (102, 34, N'637870887242543588room88.jpg', CAST(N'2022-05-02T11:45:24.2570107' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (103, 34, N'637870887242570636room89.jpg', CAST(N'2022-05-02T11:45:24.2632900' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (104, 35, N'637870888066188070room25.jpg', CAST(N'2022-05-02T11:46:46.6308959' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (105, 35, N'637870888066310153room26.jpg', CAST(N'2022-05-02T11:46:46.6342853' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (106, 35, N'637870888066343413room27.jpg', CAST(N'2022-05-02T11:46:46.6382321' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (107, 36, N'637870913971648575room1.jpg', CAST(N'2022-05-02T12:29:57.1879637' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (108, 36, N'637870913971881227room2.jpg', CAST(N'2022-05-02T12:29:57.2088477' AS DateTime2))
INSERT [dbo].[Room_Pictures] ([Id], [RoomId], [Path], [UpdateTime]) VALUES (109, 36, N'637870913972089088room3.jpg', CAST(N'2022-05-02T12:29:57.2193013' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Room_Pictures] OFF
GO
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (1, 1, N'溫暖小木屋', 5, N'含衛浴(共 1 間),可加至6人,屋頂專屬露台可搭帳野餐,附冷暖空調,需自備床墊、枕頭、棉被,需自備盥洗用具等個人用品(牙膏、牙刷、浴巾、毛巾)。', 2, CAST(1000.00 AS Decimal(18, 2)), CAST(1100.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (2, 1, N'森與夢', 6, N'室內含衛浴(共2間),提供冷氣,提供洗髪精/沐浴乳、棉被、枕頭、免洗牙刷/牙膏', 4, CAST(1000.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (3, 1, N'八人雅房', 3, N'本園區禁止攜帶寵物入場', 8, CAST(1250.00 AS Decimal(18, 2)), CAST(1800.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (4, 1, N'異國風情奢華帳', 2, N'室內附冷氣，獨立衛浴', 14, CAST(800.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (5, 1, N'普羅旺斯', 3, N'為響應環保，鼓勵您自備牙刷。', 2, CAST(1100.00 AS Decimal(18, 2)), CAST(1750.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (6, 2, N'異國風情奢華帳', 8, N'館內全面禁菸，違反者視情節輕重，將有可能請您退宿(住宿費用將不退還)，感謝您共同維護住宿品質。', 13, CAST(1350.00 AS Decimal(18, 2)), CAST(1800.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (7, 2, N'天鷹座', 5, N'鑰匙遺失賠償費用: TWD 500。', 7, CAST(800.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (8, 3, N'牡羊座', 7, N'飯店不提供加床。', 9, CAST(1200.00 AS Decimal(18, 2)), CAST(1600.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (9, 4, N'鯨魚座', 5, N'為維護住宿品質，夜間請保持輕聲細語。', 10, CAST(1450.00 AS Decimal(18, 2)), CAST(2200.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (10, 5, N'北冕座', 5, N'為維護環境安寧及其他住客權益，請勿在園區或房間內大聲喧嘩。', 3, CAST(2000.00 AS Decimal(18, 2)), CAST(2500.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (16, 7, N'普羅米修斯', 3, N'室內營位不含衛浴,附枕頭、棉被、冷氣,不含早餐,需自備個人盥洗用品,園區禁止攜帶寵物,園區禁止吸菸 包場可容納28人,多1位加收清潔費300元(現場收費)', 7, CAST(1500.00 AS Decimal(18, 2)), CAST(1800.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (17, 7, N'阿洛伊代', 8, N'館內全面禁菸，違反者視情節輕重，將有可能請您退宿(住宿費用將不退還)，感謝您共同維護住宿品質。', 5, CAST(1700.00 AS Decimal(18, 2)), CAST(1800.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (18, 7, N'海斯堤亞', 6, N'農場自搭帳每帳一車一帳，每帳人數 4 人。不含早餐。可於現場加購。', 9, CAST(780.00 AS Decimal(18, 2)), CAST(1380.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (19, 8, N'亞瑞士', 9, N'室內附冷氣，獨立衛浴', 4, CAST(2000.00 AS Decimal(18, 2)), CAST(2500.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (20, 9, N'狄俄尼索斯', 6, N'本園區禁止攜帶寵物入場', 3, CAST(1289.00 AS Decimal(18, 2)), CAST(1450.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (21, 10, N'赫爾墨斯', 6, N'室內含衛浴(共2間),提供冷氣,提供洗髪精/沐浴乳、棉被、枕頭、免洗牙刷/牙膏', 13, CAST(900.00 AS Decimal(18, 2)), CAST(1550.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (22, 11, N'異國風情奢華帳', 3, N'為維護環境安寧及其他住客權益，請勿在園區或房間內大聲喧嘩。', 14, CAST(890.00 AS Decimal(18, 2)), CAST(1290.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (23, 21, N'A506', 2, N'很窄很窄', 5, CAST(1200.00 AS Decimal(18, 2)), CAST(2500.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (24, 23, N'營火晚會', 10, N'可以圍繞著營火享受寧靜的夜晚', 4, CAST(1200.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (31, 35, N'維納斯', 3, N'附冷暖氣、床墊、棉被、枕頭、共用大客廳。一棟限14位，超過一人加收600元。(現場收費)。進場時間:當日下午14:00以後退場時間：次日上午11:00以前。下午兩點以前為餐飲營業時間，提早入園加收1000元。 夜衝時間：18：00～22：00之間，不接受提早或延遲，如攜帶寵物入場，酌收清潔費300元隻。', 2, CAST(600.00 AS Decimal(18, 2)), CAST(1250.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (32, 35, N'雅典娜', 5, N'為維護環境安寧及其他住客權益，請勿在園區或房間內大聲喧嘩。', 8, CAST(800.00 AS Decimal(18, 2)), CAST(1350.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (33, 35, N'阿波羅', 3, N'此區開放車邊帳、車頂帳及睡車上的營友預訂', 4, CAST(750.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (34, 35, N'波塞頓', 6, N'室內(共有6間) 無衛浴 提供冷暖氣 不可攜帶寵物入住 附沐浴乳、洗髮乳，寢具 進場時間：當日下午3：00後離場時間：次日上午11：00以前', 11, CAST(900.00 AS Decimal(18, 2)), CAST(1250.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (35, 35, N'宙斯', 6, N'飯店不提供加床。', 1, CAST(800.00 AS Decimal(18, 2)), CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[Rooms] ([Id], [Camping_AreaId], [Name], [Count], [Description], [RoomType], [Price_Of_Weekdays], [Price_Of_Weekends]) VALUES (36, 37, N'卷雲房', 5, N'為四人帳，不可加床。', 10, CAST(1200.00 AS Decimal(18, 2)), CAST(1300.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Rooms] OFF
GO
SET IDENTITY_INSERT [dbo].[Sellers] ON 

INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (1, N'405290199zzz@gmail.com', N'D5BMVKUswNyoznSETCCcoxp4f3c5IEuQEtCe+4QiPvs=', N'Lillian', N'0999-999-999', CAST(N'2022-04-28T19:31:54.6482865' AS DateTime2), 1, N'8a3e6f26-67ca-44df-9bc0-6b8bbdf46ccf')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (2, N'an990218@gmail.com', N'7yr/5IJUmwY54TZjCOPsofjZVUuWE/0LgMICXf7oug8=', N'Chinger Chang', N'0888-666-888', CAST(N'2022-04-28T19:36:51.9612532' AS DateTime2), 1, N'f107c02a-fcf9-4c38-baf9-ba640ac02fb4')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (3, N'abc@gmail.com', N'ITBEeXkRSpPp7+VVreUY4VfMZbQ0R5Z4Q5WFvNW1HkY=', N'Wendy', N'0555-222-111', CAST(N'2022-04-28T19:38:23.0528429' AS DateTime2), 1, N'517f7f65-67c3-4109-b5ba-15287a70e2d2')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (4, N'def@gmail.com', N'U1BW9mNPWR/VzB8RhxEYRcDombV0NQRJE9/G8WfeQbI=', N'Tom', N'0576-453-167', CAST(N'2022-04-28T19:38:48.8542766' AS DateTime2), 1, N'd65a08c0-1da9-411f-92b0-c82229482a7c')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (5, N'ghi@gmail.com', N'ZBKFcb4K8QDfzreu1EtgCMH6FcLkOdAefNmNn59oDY8=', N'Emily', N'0534-123-156', CAST(N'2022-04-28T19:39:19.0822193' AS DateTime2), 1, N'6ea7e09a-66da-4612-8734-9a852e5e6596')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (6, N'lynnmaxwell0706@gmail.com', N'LsFyulNp1Dv6frHmDCTj+e5EDPPbUyLQfy0qQI5fvP8=', N'Lynn', N'0123-456-789', CAST(N'2022-04-28T18:03:24.3809612' AS DateTime2), 1, N'96b7bd37-6e82-4630-8587-ba0ac9746128')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (7, N'edc54216161@gmail.com', N'JQbGSiYe+508hdH7nIGeiiuLEgQ+YSEx4v1qCb8ngZE=', N'哈哈是我啦', N'0912-345-678', CAST(N'2022-04-28T18:23:42.9444248' AS DateTime2), 1, N'4ab45a33-273d-4601-b7ff-00ec66362244')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (16, N'an990218@yahoo.com.tw', NULL, NULL, NULL, CAST(N'2022-04-28T18:50:30.2295474' AS DateTime2), 1, NULL)
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (17, N'tfm10405@gmail.com', N'02cNUvBkQh4KVSdH/zLPbdNDnIAH2hWh6aT4FvQdjLs=', N'Lillian', N'0999-999-999', CAST(N'2022-04-29T05:01:14.6525243' AS DateTime2), 1, N'c6f3bad6-4d5e-4035-a2fe-00d123e5b88b')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (18, N'andy@tfm104t05.myvnc.com', N'4bNrvYtbOc9jSk2F1fuE86YQAz4UehtRd4NG+GbH/cA=', N'123', N'0000-000-000', CAST(N'2022-04-29T05:13:02.2209854' AS DateTime2), 1, N'82637740-1a26-48ec-9b5d-db9cf37d7db3')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (19, N'tfm104manager@gmail.com', N'VmvrOknbgQVLceY/3EQ8bcjphl8c9cCZln5qstKr/Js=', N'Chinger', N'0987-234-345', CAST(N'2022-04-29T11:11:54.6153080' AS DateTime2), 1, N'b9921cdc-288d-4a18-ab64-94d2180efd88')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (20, N'stu888004@gmail.com', N'VgNaWxTgjVlSdZ2p84J2jzXZRboBAa5uEVr1ws3Ni6k=', N'阿旭', N'0900-000-000', CAST(N'2022-04-29T14:43:02.4050002' AS DateTime2), 1, N'dd16523d-4ee2-44d9-bbcc-f24235d5031a')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (24, N'jkl@gamil.com', N'9pcP2B1Un0yZomkTifx0ECkKTE8dG1wvbjhW1bn9BEs=', N'Eason', N'0912-321-321', CAST(N'2022-04-30T13:54:16.6281406' AS DateTime2), 1, N'8d212679-9efa-4192-88d6-ace38fd4f462')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (25, N'tfm104camping@gmail.com', N'aaQ7m15kSQWqUkAvzvgTmEyHG+KbdGeVPVc7B+v5W3E=', NULL, NULL, CAST(N'2022-04-30T06:07:57.9349770' AS DateTime2), 1, NULL)
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (26, N'8899kk77l@gmail.com', N'ozKkKWfIsnqdZIeQeArhhDcPwwLXrFTy6lJ2wW0dfB4=', N'LCC', N'0983-123-321', CAST(N'2022-04-30T13:48:43.1059176' AS DateTime2), 1, N'3942c2bc-b7d4-40b8-bebe-40431d5e837e')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (27, N'stu888003@gmail.com', N'HwEEqmviCvGsd2yFTZgkzi11Jlqa+WDiMScFYidxjSw=', N'阿旭', N'0900-000-000', CAST(N'2022-05-01T08:31:55.3945834' AS DateTime2), 1, N'b604373a-0c27-4b9a-aa8b-9df2b975e584')
INSERT [dbo].[Sellers] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (28, N'tfm104@gmail.com', N'eGOg7d+pgX935x2X7hrq4QakK4vXxE1NWf0v7Hhq6sQ=', N'Chinger', N'0987-234-345', CAST(N'2022-05-02T07:22:42.0208248' AS DateTime2), 1, N'd900d536-3df9-45af-b4ed-daf429972a7c')
SET IDENTITY_INSERT [dbo].[Sellers] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (2, 2, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (3, 3, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (4, 4, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (5, 5, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (7, 7, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (8, 8, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (9, 9, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (10, 10, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (11, 11, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (12, 12, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (13, 13, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (14, 14, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (15, 15, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (16, 16, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (17, 17, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (18, 18, 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (19, 19, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (20, 20, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (21, 21, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (23, 23, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (31, 35, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0)
INSERT [dbo].[Services] ([Id], [Camping_AreaId], [Breakfast], [Lunch], [Dinner], [Public_Refrigerator], [Tent_Equipment], [Kitchen_Utensils], [Canopy], [Wifi], [Night_Lighting], [Power_Supply], [Outdoor_Tables_Chairs], [Canteen], [Mattress], [No_Equipment], [IsCancel]) VALUES (33, 37, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (1, N'123@Gmail.com', N'NZmZQbeAwjgawmDvhszwifeBeHdjg8tvRDqRQsqv3fM=', N'123', N'09123456', CAST(N'2022-04-28T17:54:57.0000000' AS DateTime2), 0, N'8a36cc7e-3c63-4a27-a1ea-4562c8516a38')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (2, N'an990218@gmail.com', N'sdoTwohV9+8siD8IY7MlCp9/QGrECmG36PY6HV6+uRs=', N'Chinger', N'0987234345', CAST(N'2022-04-28T17:58:25.0000000' AS DateTime2), 1, N'cbeb8575-968b-48ca-87e5-54472e60b6c0')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (3, N'lynnmaxwell0706@gmail.com', N'57LPCrngKZeiiLVJQB0CbgiyAFVGUQNr53Gatyl2/dw=', N'Lynn', N'2641035759', CAST(N'2022-04-28T17:59:01.0000000' AS DateTime2), 1, N'b480be56-e20d-40aa-ac9c-463126ddb2ad')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (4, N'edc54216161@gmail.com', N'4HHa2vVFZJDOgp9T9V1woYfqrwFjukKMSfGiWcJ3xNc=', N'哈哈是我啦', N'0912-345-678', CAST(N'2022-04-28T18:26:42.0000000' AS DateTime2), 0, N'4b8d2d7e-b568-49d2-a359-273f1f71d7b2')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (5, N'awesley9888@gmail.com', N'GSqQuL5DBVbjesCYvVeSQQvX5Rxirkfdk7RLBo+VF3s=', N'流浪旅人', N'0981994657', CAST(N'2022-04-28T19:17:37.0000000' AS DateTime2), 0, N'74deff9a-a474-4bad-9770-b24b9955d95d')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (6, N'an990218@yahoo.com.tw', NULL, NULL, NULL, CAST(N'2022-04-28T19:45:51.1311316' AS DateTime2), 1, NULL)
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (7, N'405290199zzz@gmail.com', N'vQ9u4KxZWoV7ZGCgDxsQfOrrvKAc2SavO4fMLEcllkQ=', N'Lillian', N'0988888888', CAST(N'2022-04-29T04:29:27.0000000' AS DateTime2), 1, N'709afd7f-e8a6-413c-b64a-bcdc67ac814b')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (8, N'andy@tfm104t05.myvnc.com', N'PI9JU8nE53ClKlbpuC4Tkix2jG9LP+2wTVqbzIbkfac=', N'321', N'0999999999', CAST(N'2022-04-29T05:05:00.0000000' AS DateTime2), 1, N'3e2b99a2-8b7b-4554-bc91-e18b8431e49b')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (9, N'andy@tfm104t05.myvnc.com', N'Bc5zg6o5Vhchz1mEZKDhemTraM9joO8cvkWe/2TnK8Q=', N'123', N'000000000', CAST(N'2022-04-29T05:05:00.0000000' AS DateTime2), 0, N'0b23244b-3655-44f8-bb39-827b44f79297')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (10, N'stu888004@gmail.com', N'5EmiZmUf4KDNzoOVjT7L+qubNI+s5qghtMRqHEG8cF8=', N'阿', N'0900000000', CAST(N'2022-04-29T14:51:00.0000000' AS DateTime2), 1, N'99a9137f-3b5c-42a3-a691-6ab57f1fa4b3')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (11, N'abcda@gmail.com', N'SDXtbEp/BwExRLf4uUwaD2h6FXYJAqHt1QgGdHP0sYI=', N'Chang', N'0988123423', CAST(N'2022-04-29T20:27:33.0000000' AS DateTime2), 1, N'b904cbab-1468-4c31-aac2-8f34f0ccc10b')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (12, N'a123@gmail.com', N'9/GIns33lkky20uFfgRyJc5rmtt0YObef9zqhDAflh0=', N'aaa', N'0983123321', CAST(N'2022-04-30T04:39:31.0000000' AS DateTime2), 0, N'cd77b149-d233-485a-8038-d07503f3ccd7')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (17, N'tfm104camping@gmail.com', N'yJBrmgFYp5hFoPyI/197zjQN4oDxy3FZmn6dr+/5Rxo=', N'Chinger', N'0987234345', CAST(N'2022-04-30T09:15:26.0000000' AS DateTime2), 1, N'9ab88ad1-a5e8-4109-b81f-4c4fe66872ad')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (18, N'8899kk77l@gmail.com', N'ofI+aT9Uaoj/ma5v2TEIANKzO0bfq3UGam2Rng0NOEQ=', N'LCC', N'0983123321', CAST(N'2022-04-30T13:13:41.0000000' AS DateTime2), 1, N'b3d9eed4-ddb8-4440-b6be-94d32f570e97')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (19, N'tfm10405@gmail.com', N'O8V6zICXYz67nUv3x01NJK0WQZTKhLL98IqOrkuyusQ=', N'Lillian', N'0999999999', CAST(N'2022-05-01T10:54:10.0000000' AS DateTime2), 1, N'89211e0d-c944-4ba1-831e-59b7702c7e08')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (20, N'eric@tfm104t05.myvnc.com', N'LBqhYiWPmmzbU7lrXtuyYFIRwFAA4OfEWsLSpQP//CY=', N'123', N'0999999999', CAST(N'2022-05-01T10:54:15.0000000' AS DateTime2), 1, N'f1600faf-5445-4a54-90e8-70163de2be25')
INSERT [dbo].[Users] ([Id], [Email], [Password], [Name], [Phone], [CreateDate], [IsMailConfirm], [Salt]) VALUES (21, N'987@gmail.com', N'wNVRXDs3a/86m5gpn90CiBBCvQnjUDHptwgFQlG4biU=', N'qww', N'0987654321', CAST(N'2022-05-01T13:00:56.0000000' AS DateTime2), 0, N'40263467-5e41-4f52-ba3a-ea33a4b16940')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Camping_Area_Pictures]  WITH CHECK ADD  CONSTRAINT [FK_Camping_Area_Pictures_Camping_Areas_Camping_AreaId] FOREIGN KEY([Camping_AreaId])
REFERENCES [dbo].[Camping_Areas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Camping_Area_Pictures] CHECK CONSTRAINT [FK_Camping_Area_Pictures_Camping_Areas_Camping_AreaId]
GO
ALTER TABLE [dbo].[Camping_Areas]  WITH CHECK ADD  CONSTRAINT [FK_Camping_Areas_Sellers_SellerId] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Sellers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Camping_Areas] CHECK CONSTRAINT [FK_Camping_Areas_Sellers_SellerId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Rooms_RoomId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Users_UserId]
GO
ALTER TABLE [dbo].[Room_Pictures]  WITH CHECK ADD  CONSTRAINT [FK_Room_Pictures_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room_Pictures] CHECK CONSTRAINT [FK_Room_Pictures_Rooms_RoomId]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_Camping_Areas_Camping_AreaId] FOREIGN KEY([Camping_AreaId])
REFERENCES [dbo].[Camping_Areas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_Camping_Areas_Camping_AreaId]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_Services_Camping_Areas_Camping_AreaId] FOREIGN KEY([Camping_AreaId])
REFERENCES [dbo].[Camping_Areas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_Services_Camping_Areas_Camping_AreaId]
GO
