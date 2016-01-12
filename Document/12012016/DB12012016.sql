USE [POSEZ2U]
GO
/****** Object:  Table [dbo].[VOID_ITEM_HISTORY]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VOID_ITEM_HISTORY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[ModifireID] [int] NULL,
	[ShiftID] [int] NULL,
	[Total] [int] NULL,
	[StaffID] [int] NULL,
	[Qty] [int] NULL,
	[FloorID] [nvarchar](50) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [date] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [date] NULL,
 CONSTRAINT [PK_VOID_ITEM_HISTORY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VOID_ITEM_HISTORY] ON
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 3, 2, NULL, 0, 25000, NULL, 1, N'1', 0, CAST(0xE63A0B00 AS Date), 0, CAST(0xE63A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[VOID_ITEM_HISTORY] OFF
/****** Object:  UserDefinedTableType [dbo].[TableTemp]    Script Date: 01/12/2016 17:06:23 ******/
CREATE TYPE [dbo].[TableTemp] AS TABLE(
	[Value] [int] NULL
)
GO
/****** Object:  Table [dbo].[TableTemp]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableTemp](
	[ShiftHistoryID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[ShiftName] [nvarchar](500) NULL,
	[StartShift] [datetime] NULL,
	[EndShift] [datetime] NULL,
	[Status] [int] NULL,
	[CashStart] [float] NOT NULL,
	[CashEnd] [float] NOT NULL,
	[SafeDrop] [float] NOT NULL,
	[UserName] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[TableTemp] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [UserName]) VALUES (7, 5, N'3', CAST(0x0000A589010241FA AS DateTime), NULL, 1, 300, 0, 0, N'Thanh')
/****** Object:  Table [dbo].[SUB_MENU]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUB_MENU](
	[SubMenuID] [int] IDENTITY(1,1) NOT NULL,
	[SubMenuName] [nvarchar](500) NOT NULL,
	[MenuID] [int] NOT NULL,
	[Priority] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_SUB_MENU] PRIMARY KEY CLUSTERED 
(
	[SubMenuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SUB_MENU] ON
INSERT [dbo].[SUB_MENU] ([SubMenuID], [SubMenuName], [MenuID], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Eat In', 1, 1, 1, NULL, 0, CAST(0x0000A56D01296A91 AS DateTime), 0, CAST(0x0000A56D01296A91 AS DateTime))
INSERT [dbo].[SUB_MENU] ([SubMenuID], [SubMenuName], [MenuID], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Setting', 2, 1, 1, NULL, 0, CAST(0x0000A56D0129781D AS DateTime), 0, CAST(0x0000A56D0129781D AS DateTime))
SET IDENTITY_INSERT [dbo].[SUB_MENU] OFF
/****** Object:  Table [dbo].[STAFF]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFF](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Status] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[Fname] [nvarchar](500) NULL,
	[Lname] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Phone] [nvarchar](500) NULL,
	[Adress1] [nvarchar](500) NULL,
	[Adress2] [nvarchar](500) NULL,
	[Adress3] [nvarchar](500) NULL,
	[Country] [nvarchar](500) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_STAFF] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[STAFF] ON
INSERT [dbo].[STAFF] ([StaffID], [UserName], [Password], [Status], [DepartmentID], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Thien', N'c/sqqDQV2+7k55SNqqtpjQ==', 1, 2, N'Thien', N'Huynh', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, CAST(0x0000A56D0126DAE6 AS DateTime), 0, CAST(0x0000A56D0126DAE6 AS DateTime))
INSERT [dbo].[STAFF] ([StaffID], [UserName], [Password], [Status], [DepartmentID], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'Thanh', N'c/sqqDQV2+7k55SNqqtpjQ==', 1, 3, N'Thanh', N'Phan', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, CAST(0x0000A56D0127127B AS DateTime), 0, CAST(0x0000A56D0127127B AS DateTime))
INSERT [dbo].[STAFF] ([StaffID], [UserName], [Password], [Status], [DepartmentID], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, N'Hh', N'gMo3uRgQdKaHeFC7n2KDbA==', 1, 4, N'Ggg', N'Rrr', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, CAST(0x0000A56D0127A89E AS DateTime), 0, CAST(0x0000A56D0127A89E AS DateTime))
SET IDENTITY_INSERT [dbo].[STAFF] OFF
/****** Object:  Table [dbo].[SHIFT_HISTORY]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SHIFT_HISTORY](
	[ShiftHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NULL,
	[ShiftName] [nvarchar](500) NULL,
	[StartShift] [datetime] NULL,
	[EndShift] [datetime] NULL,
	[Status] [int] NULL,
	[CashStart] [float] NULL,
	[CashEnd] [float] NULL,
	[SafeDrop] [float] NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_SHIFT_HISTORY_1] PRIMARY KEY CLUSTERED 
(
	[ShiftHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SHIFT_HISTORY] ON
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 5, N'Hhh', CAST(0x0000A58300993F22 AS DateTime), CAST(0x0000A5830099665F AS DateTime), 2, 5000, 0, 0, NULL, 5, CAST(0x0000A58300993F23 AS DateTime), 5, CAST(0x0000A5830099665F AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 5, N'1', CAST(0x0000A583009B31B6 AS DateTime), CAST(0x0000A58501329B5D AS DateTime), 2, 500, 6000, 5, NULL, 5, CAST(0x0000A583009B31B7 AS DateTime), 5, CAST(0x0000A58501329B5D AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 5, N'1', CAST(0x0000A5850132CD0F AS DateTime), CAST(0x0000A58601147154 AS DateTime), 2, 100, 500, 0, NULL, 5, CAST(0x0000A5850132CD10 AS DateTime), 5, CAST(0x0000A58601147154 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 5, N'Jj', CAST(0x0000A58601148475 AS DateTime), CAST(0x0000A58900FFF0CF AS DateTime), 2, 100, 500, 0, NULL, 5, CAST(0x0000A58601148476 AS DateTime), 5, CAST(0x0000A58900FFF0CF AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, 5, N'1', CAST(0x0000A58900FFFCE3 AS DateTime), CAST(0x0000A58901010AD8 AS DateTime), 2, 100, 200, 0, NULL, 5, CAST(0x0000A58900FFFCE3 AS DateTime), 5, CAST(0x0000A58901010AD8 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, 5, N'2', CAST(0x0000A58901011824 AS DateTime), CAST(0x0000A58901023776 AS DateTime), 2, 200, 300, 0, NULL, 5, CAST(0x0000A58901011824 AS DateTime), 5, CAST(0x0000A58901023776 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 5, N'3', CAST(0x0000A589010241FA AS DateTime), NULL, 1, 300, NULL, NULL, NULL, 5, CAST(0x0000A589010241FA AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[SHIFT_HISTORY] OFF
/****** Object:  Table [dbo].[PRODUCT_PRICE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_PRICE](
	[ProductPriceID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[CurrentPrice] [float] NULL,
	[WasPrice] [float] NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Portions] [nvarchar](50) NULL,
 CONSTRAINT [PK_PRODUCT_PRICE] PRIMARY KEY CLUSTERED 
(
	[ProductPriceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PRODUCT_PRICE] ON
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (1, 1, 1, 210000, 210000, N'', 0, CAST(0x0000A56601664DB7 AS DateTime), 0, CAST(0x0000A56601664DB7 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (2, 2, 1, 25000, 0, N'', 0, CAST(0x0000A563016A0BEF AS DateTime), 0, CAST(0x0000A563016A0BEF AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (3, 3, 1, 32000, 32000, N'', 0, CAST(0x0000A563016A59C9 AS DateTime), 0, CAST(0x0000A563016A59C9 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (4, 4, 1, 15000, 0, N'', 0, CAST(0x0000A563016A7B57 AS DateTime), 0, CAST(0x0000A563016A7B57 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (5, 5, 1, 25000, 0, N'', 0, CAST(0x0000A563016A9989 AS DateTime), 0, CAST(0x0000A563016A9989 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (6, 6, 1, 20000, 0, N'', 0, CAST(0x0000A563016ADA39 AS DateTime), 0, CAST(0x0000A563016ADA39 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (7, 7, 1, 24000, 0, N'', 0, CAST(0x0000A563016AFD2D AS DateTime), 0, CAST(0x0000A563016AFD2D AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (8, 8, 1, 30000, 0, N'', 0, CAST(0x0000A563016B2B15 AS DateTime), 0, CAST(0x0000A563016B2B15 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (9, 9, 1, 34000, 0, N'', 0, CAST(0x0000A563016B73F2 AS DateTime), 0, CAST(0x0000A563016B73F2 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (10, 10, 1, 32000, 0, N'', 0, CAST(0x0000A563016C4F99 AS DateTime), 0, CAST(0x0000A563016C4F99 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (11, 11, 1, 30000, 0, N'', 0, CAST(0x0000A563016C709A AS DateTime), 0, CAST(0x0000A563016C709A AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (12, 12, 1, 25000, 0, N'', 0, CAST(0x0000A563016C8D6B AS DateTime), 0, CAST(0x0000A563016C8D6B AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (13, 13, 1, 40000, 0, N'', 0, CAST(0x0000A563016CCD00 AS DateTime), 0, CAST(0x0000A563016CCD00 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (14, 14, 1, 35000, 0, N'', 0, CAST(0x0000A563016DCEB2 AS DateTime), 0, CAST(0x0000A563016DCEB2 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (15, 15, 1, 25000, 0, N'', 0, CAST(0x0000A563016DF736 AS DateTime), 0, CAST(0x0000A563016DF736 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (16, 16, 1, 15000, 0, N'', 0, CAST(0x0000A563016E1B73 AS DateTime), 0, CAST(0x0000A563016E1B73 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (17, 17, 1, 25000, 0, N'', 0, CAST(0x0000A563016E4121 AS DateTime), 0, CAST(0x0000A563016E4121 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (18, 18, 1, 20000, 0, N'', 0, CAST(0x0000A563016F6990 AS DateTime), 0, CAST(0x0000A563016F6990 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (19, 19, 1, 20000, 0, N'', 0, CAST(0x0000A563016F818B AS DateTime), 0, CAST(0x0000A563016F818B AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (20, 20, 1, 25000, 0, N'', 0, CAST(0x0000A56500DD9375 AS DateTime), 0, CAST(0x0000A56500DD9375 AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (21, 21, 1, 45000, 0, N'', 0, CAST(0x0000A56500E10B5D AS DateTime), 0, CAST(0x0000A56500E10B5D AS DateTime), NULL)
INSERT [dbo].[PRODUCT_PRICE] ([ProductPriceID], [ProductID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Portions]) VALUES (22, 22, 1, 120000, 0, N'', 0, CAST(0x0000A56500E1E2C5 AS DateTime), 0, CAST(0x0000A56500E1E2C5 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[PRODUCT_PRICE] OFF
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductNameDesc] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[Color] [nvarchar](250) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[ProductNameSort] [nvarchar](500) NULL,
	[Portions] [nvarchar](50) NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PRODUCT] ON
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (1, N'Com suon', 1, N'Blue', N'', 0, CAST(0x0000A5630169E774 AS DateTime), 0, CAST(0x0000A56601664D91 AS DateTime), N'Com suon', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (2, N'Com cha', 1, N'Cyan', N'', 0, CAST(0x0000A563016A0BEE AS DateTime), 0, CAST(0x0000A563016A0BEE AS DateTime), N'Com cha', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (3, N'Com chien duong chau', 1, N'Green', N'', 0, CAST(0x0000A563016A3882 AS DateTime), 0, CAST(0x0000A563016A59B8 AS DateTime), N'Com chien duong chau', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (4, N'Com vit kho', 1, N'BurlyWood', N'', 0, CAST(0x0000A563016A7B55 AS DateTime), 0, CAST(0x0000A563016A7B55 AS DateTime), N'Com vit kho', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (5, N'Com bo xao', 1, N'Chartreuse', N'', 0, CAST(0x0000A563016A9987 AS DateTime), 0, CAST(0x0000A563016A9987 AS DateTime), N'Com bo xao', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (6, N'Com ga kho', 1, N'Green', N'', 0, CAST(0x0000A563016ADA37 AS DateTime), 0, CAST(0x0000A563016ADA37 AS DateTime), N'Com ga kho', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (7, N'Com chay', 1, N'DarkGreen', N'', 0, CAST(0x0000A563016AFD2B AS DateTime), 0, CAST(0x0000A563016AFD2B AS DateTime), N'Com chay', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (8, N'Com muc xao', 1, N'Crimson', N'', 0, CAST(0x0000A563016B2B13 AS DateTime), 0, CAST(0x0000A563016B2B13 AS DateTime), N'Com muc xao', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (9, N'Com chien ca man', 1, N'MidnightBlue', N'', 0, CAST(0x0000A563016B73EE AS DateTime), 0, CAST(0x0000A563016B73EE AS DateTime), N'Com chien ca man', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (10, N'Pho tai', 1, N'Brown', N'', 0, CAST(0x0000A563016C4F98 AS DateTime), 0, CAST(0x0000A563016C4F98 AS DateTime), N'Pho tai', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (11, N'Pho bo vien', 1, N'DeepPink', N'', 0, CAST(0x0000A563016C7093 AS DateTime), 0, CAST(0x0000A563016C7093 AS DateTime), N'Pho bo vien', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (12, N'Pho tai nam', 1, N'DarkViolet', N'', 0, CAST(0x0000A563016C8D6A AS DateTime), 0, CAST(0x0000A563016C8D6A AS DateTime), N'Pho tai nam', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (13, N'Pho ga', 1, N'Crimson', N'', 0, CAST(0x0000A563016CCCFF AS DateTime), 0, CAST(0x0000A563016CCCFF AS DateTime), N'Pho ga', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (14, N'Hu tiu gio heo', 1, N'Coral', N'', 0, CAST(0x0000A563016DCEA9 AS DateTime), 0, CAST(0x0000A563016DCEA9 AS DateTime), N'Hu tiu gio heo', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (15, N'Hu tieu thit bam', 1, N'Crimson', N'', 0, CAST(0x0000A563016DF734 AS DateTime), 0, CAST(0x0000A563016DF734 AS DateTime), N'Hu tiu thit bam', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (16, N'Hu tiu chay', 1, N'Chocolate', N'', 0, CAST(0x0000A563016E1B6E AS DateTime), 0, CAST(0x0000A563016E1B6E AS DateTime), N'Hu tiu chay', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (17, N'Hu tiu nam vang', 1, N'Crimson', N'', 0, CAST(0x0000A563016E4117 AS DateTime), 0, CAST(0x0000A563016E4117 AS DateTime), N'Hu tiu nam vang', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (18, N'Mi xao bo', 1, N'Chocolate', N'', 0, CAST(0x0000A563016F698E AS DateTime), 0, CAST(0x0000A563016F698E AS DateTime), N'Mo xao bo', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (19, N'Mi xao hai san', 1, N'Coral', N'', 0, CAST(0x0000A563016F8189 AS DateTime), 0, CAST(0x0000A563016F8189 AS DateTime), N'Mi xao hai san', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (20, N'Bun xao thit', 1, N'Chartreuse', N'', 0, CAST(0x0000A56500DD931A AS DateTime), 0, CAST(0x0000A56500DD931A AS DateTime), N'Bun xao thit', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (21, N'Com My Tu', 1, N'Red', N'', 0, CAST(0x0000A56500E10B25 AS DateTime), 0, CAST(0x0000A56500E10B25 AS DateTime), N'Com My Tu', NULL)
INSERT [dbo].[PRODUCT] ([ProductID], [ProductNameDesc], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [ProductNameSort], [Portions]) VALUES (22, N'Lau thai', 1, N'Navy', N'', 0, CAST(0x0000A56500E1E28E AS DateTime), 0, CAST(0x0000A56500E1E28E AS DateTime), N'Lau thai', NULL)
SET IDENTITY_INSERT [dbo].[PRODUCT] OFF
/****** Object:  Table [dbo].[PRINTER]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRINTER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PrintName] [nvarchar](50) NULL,
	[PrinterName] [nvarchar](50) NULL,
	[PrinterType] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [date] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [date] NULL,
 CONSTRAINT [PK_PRINTER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PRINTER] ON
INSERT [dbo].[PRINTER] ([ID], [PrintName], [PrinterName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Xx', N'Dataprint 80mm Series Printer', N'Ticket Printer', 0, 0, CAST(0xD73A0B00 AS Date), 0, CAST(0xD73A0B00 AS Date))
INSERT [dbo].[PRINTER] ([ID], [PrintName], [PrinterName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Aaa', N'Microsoft XPS Document Writer', N'Ticket Printer', 0, 0, CAST(0xD83A0B00 AS Date), 0, CAST(0xD83A0B00 AS Date))
INSERT [dbo].[PRINTER] ([ID], [PrintName], [PrinterName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Bb', N'Fax', N'Ticket Printer', 0, 0, CAST(0xD83A0B00 AS Date), 0, CAST(0xD83A0B00 AS Date))
INSERT [dbo].[PRINTER] ([ID], [PrintName], [PrinterName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Food ticket printer', N'80 Printer', N'Ticket Printer', 1, 0, CAST(0xD83A0B00 AS Date), 5, CAST(0xE03A0B00 AS Date))
INSERT [dbo].[PRINTER] ([ID], [PrintName], [PrinterName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'Invoice printer', N'Dataprint 80mm Series Printer', N'Ticket Printer', 1, 0, CAST(0xD83A0B00 AS Date), 0, CAST(0xD83A0B00 AS Date))
INSERT [dbo].[PRINTER] ([ID], [PrintName], [PrinterName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, N'Beverage Ticket Printer', N'Send To OneNote 2013', N'Ticket Printer', 1, 0, CAST(0xD83A0B00 AS Date), 5, CAST(0xE03A0B00 AS Date))
INSERT [dbo].[PRINTER] ([ID], [PrintName], [PrinterName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, N'Take away Ticket Printer', N'Dataprint 80mm Series Printer', N'Ticket Printer', 1, 0, CAST(0xD83A0B00 AS Date), 0, CAST(0xD83A0B00 AS Date))
INSERT [dbo].[PRINTER] ([ID], [PrintName], [PrinterName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, N'Thien', N'Fax', N'Ticket Printer', 0, 5, CAST(0xE03A0B00 AS Date), 5, CAST(0xE03A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[PRINTER] OFF
/****** Object:  Table [dbo].[FLOOR]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FLOOR](
	[FloorID] [int] IDENTITY(1,1) NOT NULL,
	[FloorName] [nvarchar](500) NOT NULL,
	[Priority] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_FLOOR] PRIMARY KEY CLUSTERED 
(
	[FloorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTMENT](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_DEPARMENT] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DEPARTMENT] ON
INSERT [dbo].[DEPARTMENT] ([DepartmentID], [DepartmentName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Admin', 1, NULL, 0, CAST(0x0000A56D01264F8F AS DateTime), 0, CAST(0x0000A56D01264F8F AS DateTime))
INSERT [dbo].[DEPARTMENT] ([DepartmentID], [DepartmentName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Manager', 1, NULL, 0, CAST(0x0000A56D01265996 AS DateTime), 0, CAST(0x0000A56D01265996 AS DateTime))
INSERT [dbo].[DEPARTMENT] ([DepartmentID], [DepartmentName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Staff', 1, NULL, 0, CAST(0x0000A56D01266EEE AS DateTime), 0, CAST(0x0000A56D01266EEE AS DateTime))
INSERT [dbo].[DEPARTMENT] ([DepartmentID], [DepartmentName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'Thien', 1, NULL, 4, CAST(0x0000A56E0135D01F AS DateTime), 4, CAST(0x0000A56E0135D0D8 AS DateTime))
SET IDENTITY_INSERT [dbo].[DEPARTMENT] OFF
/****** Object:  Table [dbo].[CLIENT]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENT](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [int] NOT NULL,
	[Fname] [nvarchar](500) NULL,
	[Lname] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Phone] [nvarchar](500) NULL,
	[Adress1] [nvarchar](500) NULL,
	[Adress2] [nvarchar](500) NULL,
	[Adress3] [nvarchar](500) NULL,
	[Country] [nvarchar](500) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_CLIENT] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CLIENT] ON
INSERT [dbo].[CLIENT] ([ClientID], [Status], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 1, N'Thanh', N'Phan Chi', N'pcthanh2408@gmail.com', N'0972641947', NULL, NULL, NULL, NULL, N'', 0, CAST(0x0000A581007A4506 AS DateTime), 0, CAST(0x0000A581007A4506 AS DateTime))
INSERT [dbo].[CLIENT] ([ClientID], [Status], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 1, N'Thanh.Phan', N'Chi', N'xxx@gmail.com', N'12345677', NULL, NULL, NULL, NULL, N'', 0, CAST(0x0000A581007B4FD3 AS DateTime), 0, CAST(0x0000A581007B4FD3 AS DateTime))
INSERT [dbo].[CLIENT] ([ClientID], [Status], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 1, N'Loc', N'Xxx', N'', N'5555', NULL, NULL, NULL, NULL, N'', 0, CAST(0x0000A58601804B7F AS DateTime), 0, CAST(0x0000A58601804B7F AS DateTime))
SET IDENTITY_INSERT [dbo].[CLIENT] OFF
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](500) NOT NULL,
	[CategoryNameSort] [nvarchar](500) NULL,
	[Status] [int] NOT NULL,
	[Color] [nvarchar](250) NULL,
	[ProductColor] [nvarchar](250) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_CATEGORY] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATEGORY] ON
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Com', N'Com', 1, N'Cyan', N'Blue', N'', 1, CAST(0x0000A5630168A5C3 AS DateTime), 0, CAST(0x0000A5630168A5C3 AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Pho', N'Pho', 1, N'BlueViolet', N'Crimson', N'', 1, CAST(0x0000A5630168BC12 AS DateTime), 0, CAST(0x0000A5630168BC12 AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Hu Tiu', N'Hu Tiu', 1, N'BlueViolet', N'Chartreuse', N'', 1, CAST(0x0000A5630168D990 AS DateTime), 0, CAST(0x0000A5630168D990 AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Mi', N'Mi', 1, N'Brown', N'Crimson', N'', 1, CAST(0x0000A5630168F7BE AS DateTime), 0, CAST(0x0000A5630168F7BE AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'Bun', N'Bun', 1, N'DarkGreen', N'Firebrick', N'', 1, CAST(0x0000A563016917FB AS DateTime), 0, CAST(0x0000A563016917FB AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, N'Chao', N'Chao', 1, N'DeepSkyBlue', N'LightSeaGreen', N'', 1, CAST(0x0000A5630169319D AS DateTime), 0, CAST(0x0000A5630169319D AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, N'Xao', N'Xao', 1, N'MediumPurple', N'Maroon', N'', 1, CAST(0x0000A5630169595F AS DateTime), 0, CAST(0x0000A5630169595F AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, N'Salad', N'Salab', 1, N'DarkMagenta', N'MidnightBlue', N'', 1, CAST(0x0000A563016978E4 AS DateTime), 0, CAST(0x0000A563016978E4 AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, N'Lau', N'Lau', 1, N'MidnightBlue', N'MediumSlateBlue', N'', 1, CAST(0x0000A56301699A50 AS DateTime), 0, CAST(0x0000A56301699A50 AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, N'Bun Nuoc', N'Bun Nuoc', 1, N'Chocolate', N'DarkGreen', N'', 1, CAST(0x0000A5630169BBAE AS DateTime), 0, CAST(0x0000A5630169BBAE AS DateTime))
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (11, N'Uuu', N'Jj', 0, N'Brown', N'Aqua', N'', 1, CAST(0x0000A56C009A62F6 AS DateTime), 0, CAST(0x0000A58601127A3D AS DateTime))
SET IDENTITY_INSERT [dbo].[CATEGORY] OFF
/****** Object:  Table [dbo].[CATALOGUE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATALOGUE](
	[CatalogueID] [int] IDENTITY(1,1) NOT NULL,
	[CatalogueName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[Color] [nvarchar](250) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_CATALOGUE] PRIMARY KEY CLUSTERED 
(
	[CatalogueID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATALOGUE] ON
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Breakfast', 1, N'Green', N'', 0, CAST(0x0000A563016842F6 AS DateTime), 0, CAST(0x0000A58601120A53 AS DateTime))
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Lunch', 1, N'Blue', N'', 0, CAST(0x0000A563016850D7 AS DateTime), 0, CAST(0x0000A563016850D7 AS DateTime))
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Beverage', 1, N'CornflowerBlue', N'', 0, CAST(0x0000A56301686632 AS DateTime), 0, CAST(0x0000A56301686632 AS DateTime))
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Dessert', 1, N'DarkMagenta', N'', 0, CAST(0x0000A56301687B5F AS DateTime), 0, CAST(0x0000A56301687B5F AS DateTime))
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'XXX', 1, N'Brown', N'', 0, CAST(0x0000A58601142E64 AS DateTime), 0, CAST(0x0000A58601142E64 AS DateTime))
SET IDENTITY_INSERT [dbo].[CATALOGUE] OFF
/****** Object:  Table [dbo].[Card]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card](
	[CardID] [int] IDENTITY(1,1) NOT NULL,
	[CardName] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[SurChart] [int] NULL,
 CONSTRAINT [PK_Card] PRIMARY KEY CLUSTERED 
(
	[CardID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Card] ON
INSERT [dbo].[Card] ([CardID], [CardName], [Status], [SurChart]) VALUES (1, N'MASTER-CARD', 0, 0)
INSERT [dbo].[Card] ([CardID], [CardName], [Status], [SurChart]) VALUES (2, N'VISA', 0, 0)
INSERT [dbo].[Card] ([CardID], [CardName], [Status], [SurChart]) VALUES (3, N'AMEX', 0, 0)
INSERT [dbo].[Card] ([CardID], [CardName], [Status], [SurChart]) VALUES (4, N'AMERICAN-EXPRESS', 0, 0)
SET IDENTITY_INSERT [dbo].[Card] OFF
/****** Object:  UserDefinedFunction [dbo].[Auto_Create_Code]    Script Date: 01/12/2016 17:06:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Thien Huynh>
-- Create date: <03/01/2016>
-- Description:	<Auto_Create_Code>
-- =============================================


-- SELECT [dbo].[Auto_Create_Code] ('P',1)


CREATE FUNCTION [dbo].[Auto_Create_Code]
(
	@StartCode NVARCHAR(1)='',
	@id int
)
RETURNS nvarchar(10)
AS
BEGIN	
	declare @length int
	declare @zeroes nvarchar(10)
	declare @zcount int -- the number of zeroes
	set @zcount = 0
	set @zeroes = ''
	set @length = len(cast(@id as nvarchar))
	while( @zcount + @length < 9 ) begin
		set @zeroes = @zeroes + '0'
		set @zcount = @zcount + 1
	end	
	return @StartCode + @zeroes + cast(@id as nvarchar)
	
END
GO
/****** Object:  Table [dbo].[PERMISSION]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISSION](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[SubMenuID] [int] NOT NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_PERMISSION] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PERMISSION] ON
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (1, N'Eat In', 1, 2, 1, 0, CAST(0x0000A56D0129C13D AS DateTime), 0, CAST(0x0000A56D0129C13D AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (2, N'Setting', 1, 2, 2, 0, CAST(0x0000A56D0129C13D AS DateTime), 0, CAST(0x0000A56D0129C13D AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (3, N'Eat In', 1, 3, 1, 0, CAST(0x0000A56E0130CD76 AS DateTime), 0, CAST(0x0000A56E0130CD76 AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[PERMISSION] OFF
/****** Object:  Table [dbo].[PAYMENT_TYPE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENT_TYPE](
	[PaymentTypeID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_PAYMENT_TYPE] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PAYMENT_TYPE] ON
INSERT [dbo].[PAYMENT_TYPE] ([PaymentTypeID], [PaymentTypeName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'CASH', 0, NULL, 0, CAST(0x0000A56F00E3F0EE AS DateTime), 0, CAST(0x0000A56F00E3F0EE AS DateTime))
INSERT [dbo].[PAYMENT_TYPE] ([PaymentTypeID], [PaymentTypeName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'CARD', 0, NULL, 0, CAST(0x0000A56F00E42BAA AS DateTime), 0, CAST(0x0000A56F00E42BAA AS DateTime))
INSERT [dbo].[PAYMENT_TYPE] ([PaymentTypeID], [PaymentTypeName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'CHEQUE', 1, NULL, 0, CAST(0x0000A56F00E43832 AS DateTime), 0, CAST(0x0000A56F00E43832 AS DateTime))
INSERT [dbo].[PAYMENT_TYPE] ([PaymentTypeID], [PaymentTypeName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'ACCOUNT', 1, NULL, 0, CAST(0x0000A56F00E43FFC AS DateTime), 0, CAST(0x0000A56F00E43FFC AS DateTime))
INSERT [dbo].[PAYMENT_TYPE] ([PaymentTypeID], [PaymentTypeName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'GIFT CARD', 1, NULL, 0, CAST(0x0000A56F00E4469B AS DateTime), 0, CAST(0x0000A56F00E4469B AS DateTime))
SET IDENTITY_INSERT [dbo].[PAYMENT_TYPE] OFF
/****** Object:  Table [dbo].[PAYMENT_INVOICE_HISTORY]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENT_INVOICE_HISTORY](
	[PaymentHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [nvarchar](50) NOT NULL,
	[PaymentTypeID] [int] NOT NULL,
	[Total] [float] NOT NULL,
	[Satust] [int] NOT NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_PAYMENT_INVOICE_HISTORY] PRIMARY KEY CLUSTERED 
(
	[PaymentHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ON
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (1, N'1', 1, 800, 1, 0, CAST(0x0000A5700165E9F7 AS DateTime), 0, CAST(0x0000A5700165E9F7 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (2, N'1', 2, 1560, 1, 0, CAST(0x0000A5700165E9F8 AS DateTime), 0, CAST(0x0000A5700165E9F8 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (3, N'1', 1, 1000, 1, 0, CAST(0x0000A57200AC0A49 AS DateTime), 0, CAST(0x0000A57200AC0A49 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (4, N'1', 2, 1000, 1, 0, CAST(0x0000A57200AC0A4A AS DateTime), 0, CAST(0x0000A57200AC0A4A AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (5, N'1', 1, 1000, 1, 0, CAST(0x0000A57200B428D3 AS DateTime), 0, CAST(0x0000A57200B428D3 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (6, N'1', 2, 500, 1, 0, CAST(0x0000A57200B428D3 AS DateTime), 0, CAST(0x0000A57200B428D3 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (7, N'1', 1, 1000, 1, 0, CAST(0x0000A57200B67F9D AS DateTime), 0, CAST(0x0000A57200B67F9D AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (8, N'1', 2, 1000, 1, 0, CAST(0x0000A57200B67F9D AS DateTime), 0, CAST(0x0000A57200B67F9D AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (10, N'1', 2, 1000, 1, 0, CAST(0x0000A57200E578C7 AS DateTime), 0, CAST(0x0000A57200E578C7 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (11, N'1', 1, 500, 1, 0, CAST(0x0000A57200E5BA59 AS DateTime), 0, CAST(0x0000A57200E5BA59 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (12, N'1', 2, 1200, 1, 0, CAST(0x0000A57200E5BA5A AS DateTime), 0, CAST(0x0000A57200E5BA5A AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (13, N'2', 1, 600, 1, 0, CAST(0x0000A57200E5FF83 AS DateTime), 0, CAST(0x0000A57200E5FF83 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (14, N'3', 1, 20, 1, 0, CAST(0x0000A572010CADAA AS DateTime), 0, CAST(0x0000A572010CADAA AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (15, N'3', 2, 53, 1, 0, CAST(0x0000A572010CADAB AS DateTime), 0, CAST(0x0000A572010CADAB AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (16, N'4', 1, 20, 1, 0, CAST(0x0000A572010CFCC6 AS DateTime), 0, CAST(0x0000A572010CFCC6 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (17, N'5', 1, 20, 1, 0, CAST(0x0000A572010D68AD AS DateTime), 0, CAST(0x0000A572010D68AD AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (18, N'6', 1, 61, 1, 0, CAST(0x0000A57201120E6B AS DateTime), 0, CAST(0x0000A57201120E6B AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (19, N'6', 2, 0, 1, 0, CAST(0x0000A57201120E6B AS DateTime), 0, CAST(0x0000A57201120E6B AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (20, N'7', 1, 61, 1, 0, CAST(0x0000A57201121C48 AS DateTime), 0, CAST(0x0000A57201121C48 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (21, N'7', 2, 0, 1, 0, CAST(0x0000A57201121C48 AS DateTime), 0, CAST(0x0000A57201121C48 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (22, N'8', 1, 61, 1, 0, CAST(0x0000A57201121D37 AS DateTime), 0, CAST(0x0000A57201121D37 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (23, N'8', 2, 0, 1, 0, CAST(0x0000A57201121D37 AS DateTime), 0, CAST(0x0000A57201121D37 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (24, N'9', 1, 70, 1, 0, CAST(0x0000A5720112604A AS DateTime), 0, CAST(0x0000A5720112604A AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (25, N'1', 2, 200, 1, 0, CAST(0x0000A576012A6CB0 AS DateTime), 0, CAST(0x0000A576012A6CB0 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (26, N'1', 1, 120, 1, 0, CAST(0x0000A576012A6CB0 AS DateTime), 0, CAST(0x0000A576012A6CB0 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (27, N'2', 2, 100, 1, 0, CAST(0x0000A576012B29DF AS DateTime), 0, CAST(0x0000A576012B29DF AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (28, N'3', 1, 100, 1, 0, CAST(0x0000A576012CAA92 AS DateTime), 0, CAST(0x0000A576012CAA92 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (29, N'4', 1, 100, 1, 0, CAST(0x0000A5760169D83C AS DateTime), 0, CAST(0x0000A5760169D83C AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (30, N'5', 2, 100, 1, 0, CAST(0x0000A576016A7A69 AS DateTime), 0, CAST(0x0000A576016A7A69 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (31, N'6', 1, 1000, 1, 0, CAST(0x0000A576016B48E7 AS DateTime), 0, CAST(0x0000A576016B48E7 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (32, N'7', 1, 100, 1, 0, CAST(0x0000A576016C796B AS DateTime), 0, CAST(0x0000A576016C796B AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (33, N'8', 1, 288, 1, 0, CAST(0x0000A576016D8605 AS DateTime), 0, CAST(0x0000A576016D8605 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (34, N'9', 1, 200, 1, 0, CAST(0x0000A576016F5C18 AS DateTime), 0, CAST(0x0000A576016F5C19 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (35, N'10', 1, 100, 1, 0, CAST(0x0000A576017030C5 AS DateTime), 0, CAST(0x0000A576017030C5 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (36, N'11', 2, 150, 1, 0, CAST(0x0000A5760173223F AS DateTime), 0, CAST(0x0000A5760173223F AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (37, N'11', 1, 240, 1, 0, CAST(0x0000A57601732240 AS DateTime), 0, CAST(0x0000A57601732240 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (38, N'12', 2, 100, 1, 0, CAST(0x0000A5760173AD15 AS DateTime), 0, CAST(0x0000A5760173AD15 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (39, N'13', 1, 100, 1, 0, CAST(0x0000A577011662E5 AS DateTime), 0, CAST(0x0000A577011662E5 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (40, N'13', 2, 80, 1, 0, CAST(0x0000A577011662E5 AS DateTime), 0, CAST(0x0000A577011662E5 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (41, N'14', 1, 300, 1, 0, CAST(0x0000A5770116F87A AS DateTime), 0, CAST(0x0000A5770116F87A AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (42, N'15', 1, 2000, 1, 0, CAST(0x0000A5770117916A AS DateTime), 0, CAST(0x0000A5770117916A AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (43, N'16', 1, 60, 1, 0, CAST(0x0000A5770118990C AS DateTime), 0, CAST(0x0000A5770118990C AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (44, N'17', 1, 400, 1, 0, CAST(0x0000A57701769463 AS DateTime), 0, CAST(0x0000A57701769463 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (45, N'18', 2, 100, 1, 0, CAST(0x0000A5770176DE0C AS DateTime), 0, CAST(0x0000A5770176DE0C AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (46, N'19', 2, 90, 1, 0, CAST(0x0000A57701783F6B AS DateTime), 0, CAST(0x0000A57701783F6B AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (47, N'20', 1, 60, 1, 0, CAST(0x0000A577017B9173 AS DateTime), 0, CAST(0x0000A577017B9173 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (48, N'21', 1, 70, 1, 0, CAST(0x0000A577017CF8B5 AS DateTime), 0, CAST(0x0000A577017CF8B5 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (49, N'22', 1, 250, 1, 0, CAST(0x0000A577017FA1BD AS DateTime), 0, CAST(0x0000A577017FA1BD AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (50, N'23', 1, 70, 1, 0, CAST(0x0000A57701848E39 AS DateTime), 0, CAST(0x0000A57701848E39 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (51, N'1', 1, 100, 1, 0, CAST(0x0000A57B016DC9C7 AS DateTime), 0, CAST(0x0000A57B016DC9C7 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (52, N'2', 1, 200, 1, 0, CAST(0x0000A57B016E57AA AS DateTime), 0, CAST(0x0000A57B016E57AA AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (53, N'2', 2, 250, 1, 0, CAST(0x0000A57B016E57AB AS DateTime), 0, CAST(0x0000A57B016E57AB AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (54, N'3', 1, 100, 1, 0, CAST(0x0000A57B016ED25F AS DateTime), 0, CAST(0x0000A57B016ED25F AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (55, N'3', 2, 100, 1, 0, CAST(0x0000A57B016ED25F AS DateTime), 0, CAST(0x0000A57B016ED25F AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (56, N'4', 1, 200, 1, 0, CAST(0x0000A57B016F133B AS DateTime), 0, CAST(0x0000A57B016F133B AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (57, N'4', 2, 50, 1, 0, CAST(0x0000A57B016F133C AS DateTime), 0, CAST(0x0000A57B016F133C AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (58, N'5', 1, 500, 1, 0, CAST(0x0000A57C00B92937 AS DateTime), 0, CAST(0x0000A57C00B92937 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (59, N'6', 1, 100, 1, 0, CAST(0x0000A57C00B9EC02 AS DateTime), 0, CAST(0x0000A57C00B9EC02 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (60, N'6', 2, 150, 1, 0, CAST(0x0000A57C00B9EC02 AS DateTime), 0, CAST(0x0000A57C00B9EC02 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (61, N'7', 1, 65, 1, 0, CAST(0x0000A57D00B0293A AS DateTime), 0, CAST(0x0000A57D00B0293A AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (62, N'8', 1, 82, 1, 0, CAST(0x0000A57D01065876 AS DateTime), 0, CAST(0x0000A57D01065876 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (63, N'9', 1, 30, 1, 0, CAST(0x0000A57D01070479 AS DateTime), 0, CAST(0x0000A57D01070479 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (64, N'10', 1, 20, 1, 0, CAST(0x0000A57D010727A0 AS DateTime), 0, CAST(0x0000A57D010727A0 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (65, N'11', 2, 300, 1, 0, CAST(0x0000A57D01075A11 AS DateTime), 0, CAST(0x0000A57D01075A11 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (66, N'12', 1, 200, 1, 0, CAST(0x0000A57D010F2863 AS DateTime), 0, CAST(0x0000A57D010F2863 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (67, N'12', 2, 100, 1, 0, CAST(0x0000A57D010F2863 AS DateTime), 0, CAST(0x0000A57D010F2863 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (68, N'13', 1, 110, 1, 0, CAST(0x0000A57D010FD191 AS DateTime), 0, CAST(0x0000A57D010FD191 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (69, N'13', 2, 160, 1, 0, CAST(0x0000A57D010FD191 AS DateTime), 0, CAST(0x0000A57D010FD191 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (70, N'14', 2, 80, 1, 0, CAST(0x0000A57D01101DF1 AS DateTime), 0, CAST(0x0000A57D01101DF1 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (71, N'15', 1, 200, 1, 0, CAST(0x0000A57D0144BC36 AS DateTime), 0, CAST(0x0000A57D0144BC36 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (72, N'15', 2, 70, 1, 0, CAST(0x0000A57D0144BC36 AS DateTime), 0, CAST(0x0000A57D0144BC36 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (73, N'16', 1, 90, 1, 0, CAST(0x0000A57E0152FEDA AS DateTime), 0, CAST(0x0000A57E0152FEDA AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (74, N'17', 2, 70, 1, 0, CAST(0x0000A57E01531596 AS DateTime), 0, CAST(0x0000A57E01531596 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (75, N'18', 1, 500, 1, 0, CAST(0x0000A57E015392DA AS DateTime), 0, CAST(0x0000A57E015392DA AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (76, N'19', 1, 200, 1, 0, CAST(0x0000A57E01540403 AS DateTime), 0, CAST(0x0000A57E01540403 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (77, N'19', 2, 70, 1, 0, CAST(0x0000A57E01540403 AS DateTime), 0, CAST(0x0000A57E01540403 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (78, N'20', 1, 70, 1, 0, CAST(0x0000A57E0154ABDD AS DateTime), 0, CAST(0x0000A57E0154ABDD AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (79, N'21', 2, 100, 1, 0, CAST(0x0000A57E015577CB AS DateTime), 0, CAST(0x0000A57E015577CB AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (80, N'22', 1, 50, 1, 0, CAST(0x0000A57E0155B860 AS DateTime), 0, CAST(0x0000A57E0155B860 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (81, N'23', 1, 100, 1, 0, CAST(0x0000A57E016B398A AS DateTime), 0, CAST(0x0000A57E016B398B AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (82, N'23', 2, 170, 1, 0, CAST(0x0000A57E016B398B AS DateTime), 0, CAST(0x0000A57E016B398B AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (83, N'24', 1, 300, 1, 0, CAST(0x0000A57E016EF55C AS DateTime), 0, CAST(0x0000A57E016EF55C AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (84, N'25', 2, 500, 1, 0, CAST(0x0000A57E01704F00 AS DateTime), 0, CAST(0x0000A57E01704F00 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (85, N'1', 1, 50, 1, 0, CAST(0x0000A5830099D96E AS DateTime), 0, CAST(0x0000A5830099D96E AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (86, N'1', 2, 100, 1, 0, CAST(0x0000A5830099D96E AS DateTime), 0, CAST(0x0000A5830099D96E AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (87, N'2', 1, 100, 1, 0, CAST(0x0000A583009CC098 AS DateTime), 0, CAST(0x0000A583009CC098 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (88, N'2', 2, 200, 1, 0, CAST(0x0000A583009CC098 AS DateTime), 0, CAST(0x0000A583009CC098 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (89, N'3', 1, 300, 1, 0, CAST(0x0000A583009CC8B8 AS DateTime), 0, CAST(0x0000A583009CC8B8 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (90, N'4', 1, 200, 1, 0, CAST(0x0000A585011D96EE AS DateTime), 0, CAST(0x0000A585011D96EE AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (91, N'5', 1, 150, 1, 0, CAST(0x0000A585011EE3E6 AS DateTime), 0, CAST(0x0000A585011EE3E6 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (92, N'6', 1, 10, 1, 0, CAST(0x0000A585012CA56F AS DateTime), 0, CAST(0x0000A585012CA56F AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (93, N'6', 2, 60, 1, 0, CAST(0x0000A585012CA56F AS DateTime), 0, CAST(0x0000A585012CA56F AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (94, N'7', 1, 200, 1, 0, CAST(0x0000A585012D53DA AS DateTime), 0, CAST(0x0000A585012D53DA AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (95, N'7', 2, 60, 1, 0, CAST(0x0000A585012D53DC AS DateTime), 0, CAST(0x0000A585012D53DC AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (96, N'8', 1, 120, 1, 0, CAST(0x0000A585012D7CE0 AS DateTime), 0, CAST(0x0000A585012D7CE0 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (97, N'9', 2, 100, 1, 0, CAST(0x0000A585012E4A54 AS DateTime), 0, CAST(0x0000A585012E4A54 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (98, N'10', 1, 66.3, 1, 0, CAST(0x0000A586009F3A36 AS DateTime), 0, CAST(0x0000A586009F3A36 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (99, N'1', 2, 40, 1, 0, CAST(0x0000A586017D64B1 AS DateTime), 0, CAST(0x0000A586017D64B1 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (100, N'1', 1, 110, 1, 0, CAST(0x0000A586017D64B2 AS DateTime), 0, CAST(0x0000A586017D64B2 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (101, N'2', 1, 310, 1, 0, CAST(0x0000A586017DDB41 AS DateTime), 0, CAST(0x0000A586017DDB41 AS DateTime), N'')
GO
print 'Processed 100 total records'
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (102, N'2', 2, 60, 1, 0, CAST(0x0000A586017DDB41 AS DateTime), 0, CAST(0x0000A586017DDB41 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (103, N'3', 2, 150, 1, 0, CAST(0x0000A586017EE48C AS DateTime), 0, CAST(0x0000A586017EE48C AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (104, N'3', 1, 120, 1, 0, CAST(0x0000A586017EE48C AS DateTime), 0, CAST(0x0000A586017EE48C AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (105, N'4', 1, 70, 1, 0, CAST(0x0000A586017F9450 AS DateTime), 0, CAST(0x0000A586017F9450 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (106, N'4', 2, 20, 1, 0, CAST(0x0000A586017F9451 AS DateTime), 0, CAST(0x0000A586017F9451 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (107, N'5', 1, 400, 1, 0, CAST(0x0000A58601800EBE AS DateTime), 0, CAST(0x0000A58601800EBE AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (108, N'5', 2, 100, 1, 0, CAST(0x0000A58601800EBF AS DateTime), 0, CAST(0x0000A58601800EBF AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (109, N'6', 1, 269, 1, 0, CAST(0x0000A58601806DC3 AS DateTime), 0, CAST(0x0000A58601806DC3 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (110, N'7', 1, 122, 1, 0, CAST(0x0000A587011B428B AS DateTime), 0, CAST(0x0000A587011B428B AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (111, N'8', 2, 265, 1, 0, CAST(0x0000A587011C96EA AS DateTime), 0, CAST(0x0000A587011C96EA AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (112, N'9', 1, 235, 1, 0, CAST(0x0000A587011ED8CD AS DateTime), 0, CAST(0x0000A587011ED8CE AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (113, N'10', 1, 32, 1, 0, CAST(0x0000A58900FAC7CB AS DateTime), 0, CAST(0x0000A58900FAC7CB AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (114, N'11', 1, 35, 1, 0, CAST(0x0000A58900FAD2F1 AS DateTime), 0, CAST(0x0000A58900FAD2F1 AS DateTime), N'')
INSERT [dbo].[PAYMENT_INVOICE_HISTORY] ([PaymentHistoryID], [InvoiceNumber], [PaymentTypeID], [Total], [Satust], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (115, N'12', 1, 265, 1, 0, CAST(0x0000A58900FAD89B AS DateTime), 0, CAST(0x0000A58900FAD89B AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[PAYMENT_INVOICE_HISTORY] OFF
/****** Object:  Table [dbo].[ORDER_OPEN_ITEM]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_OPEN_ITEM](
	[dynID] [int] NOT NULL,
	[ItemNameShort] [nvarchar](50) NULL,
	[ItemNameDesc] [nvarchar](50) NULL,
	[UnitPrice] [int] NULL,
	[PrintType] [nchar](10) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [date] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [date] NULL,
 CONSTRAINT [PK_Order_Open_Item] PRIMARY KEY CLUSTERED 
(
	[dynID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE_DATE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE](
	[OrderModifireID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDetailID] [int] NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[KeyModi] [int] NULL,
	[ModifireID] [int] NOT NULL,
	[Satust] [int] NOT NULL,
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[Seat] [int] NULL,
	[DynId] [int] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER_DETAIL_MODIFIRE_DATE] PRIMARY KEY CLUSTERED 
(
	[OrderModifireID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ON
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (7, 0, 2, 11, 2, 10, 0, 12000, 0, 30000, 1, 0, 0, CAST(0x0000A58B00C3911D AS DateTime), 0, CAST(0x0000A58B00C3911D AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (8, 0, 2, 1, 3, 1, 0, 10000, 0, 210000, 2, 0, 0, CAST(0x0000A58B00C3911D AS DateTime), 0, CAST(0x0000A58B00C3911D AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (10, 0, 3, 1, 1, 1, 0, 10000, 1, 210000, 0, 0, 0, CAST(0x0000A58B00EEDEB9 AS DateTime), 0, CAST(0x0000A58B00EEDEB9 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (11, 0, 3, 10, 3, 7, 0, 15000, 1, 32000, 0, 0, 0, CAST(0x0000A58B00EEDEB9 AS DateTime), 0, CAST(0x0000A58B00EEDEB9 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] OFF
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL_MODIFIRE](
	[OrderModifireID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDetailID] [int] NOT NULL,
	[ModifireID] [int] NOT NULL,
	[Satust] [int] NOT NULL,
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER_DETAIL_MODIFIRE] PRIMARY KEY CLUSTERED 
(
	[OrderModifireID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_DETAIL_DATE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL_DATE](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[KeyItem] [int] NULL,
	[Satust] [int] NOT NULL,
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[Seat] [int] NULL,
	[DynId] [int] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER_DETAIL_DATE] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_DATE] ON
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (10, 2, 14, 1, 0, 35000, 1, 35000, 1, 0, 0, CAST(0x0000A58B00C3911D AS DateTime), 0, CAST(0x0000A58B00C3911D AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (11, 2, 11, 2, 0, 30000, 1, 30000, 1, 0, 0, CAST(0x0000A58B00C3911D AS DateTime), 0, CAST(0x0000A58B00C3911D AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (12, 2, 1, 3, 0, 210000, 1, 210000, 2, 0, 0, CAST(0x0000A58B00C3911D AS DateTime), 0, CAST(0x0000A58B00C3911D AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (15, 3, 1, 1, 0, 210000, 1, 210000, 0, 0, 0, CAST(0x0000A58B00EEDEB9 AS DateTime), 0, CAST(0x0000A58B00EEDEB9 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (16, 3, 2, 2, 0, 25000, 1, 25000, 0, 0, 0, CAST(0x0000A58B00EEDEB9 AS DateTime), 0, CAST(0x0000A58B00EEDEB9 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (17, 3, 10, 3, 0, 32000, 1, 32000, 0, 0, 0, CAST(0x0000A58B00EEDEB9 AS DateTime), 0, CAST(0x0000A58B00EEDEB9 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_DATE] OFF
/****** Object:  Table [dbo].[ORDER_DETAIL]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Satust] [int] NOT NULL,
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER_DETAIL] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_DATE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DATE](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [nvarchar](50) NULL,
	[ClientID] [int] NULL,
	[FloorID] [nvarchar](50) NULL,
	[Status] [int] NOT NULL,
	[TotalAmount] [float] NULL,
	[Seat] [int] NULL,
	[ShiftID] [int] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDERDATE] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ORDER_DATE] ON
INSERT [dbo].[ORDER_DATE] ([OrderID], [OrderNumber], [ClientID], [FloorID], [Status], [TotalAmount], [Seat], [ShiftID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (2, N'1', 0, N'15', 0, 275000, 2, 0, 5, CAST(0x0000A58B00C36B73 AS DateTime), 5, CAST(0x0000A58B00C36B73 AS DateTime), N'')
INSERT [dbo].[ORDER_DATE] ([OrderID], [OrderNumber], [ClientID], [FloorID], [Status], [TotalAmount], [Seat], [ShiftID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (3, N'3', 0, N'1', 0, 292000, 0, 0, 5, CAST(0x0000A58B00EEB069 AS DateTime), 5, CAST(0x0000A58B00EEB069 AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[ORDER_DATE] OFF
/****** Object:  Table [dbo].[ORDER]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [nvarchar](50) NULL,
	[ClientID] [int] NULL,
	[FloorID] [int] NULL,
	[Status] [int] NOT NULL,
	[TotalAmount] [float] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MODIFIRE_PRICE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODIFIRE_PRICE](
	[ModifirePriceID] [int] IDENTITY(1,1) NOT NULL,
	[ModifireID] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[CurrentPrice] [float] NULL,
	[WasPrice] [float] NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_MODIFIRE_PRICE] PRIMARY KEY CLUSTERED 
(
	[ModifirePriceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MODIFIRE_PRICE] ON
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 1, 1, 10000, 0, N'', 0, CAST(0x0000A563016BB722 AS DateTime), 0, CAST(0x0000A563016BB722 AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 2, 1, 5000, 0, N'', 0, CAST(0x0000A563016BCC44 AS DateTime), 0, CAST(0x0000A563016BCC44 AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 3, 1, 3000, 0, N'', 0, CAST(0x0000A563016BE277 AS DateTime), 0, CAST(0x0000A563016BE277 AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 4, 1, 3000, 0, N'', 0, CAST(0x0000A563016BEF9B AS DateTime), 0, CAST(0x0000A563016BEF9B AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, 5, 1, 1000, 0, N'', 0, CAST(0x0000A563016C0EAD AS DateTime), 0, CAST(0x0000A563016C0EAD AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, 6, 1, 1000, 0, N'', 0, CAST(0x0000A563016C266D AS DateTime), 0, CAST(0x0000A563016C266D AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 7, 1, 15000, 0, N'', 0, CAST(0x0000A563016D0099 AS DateTime), 0, CAST(0x0000A563016D0099 AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, 8, 1, 20000, 0, N'', 0, CAST(0x0000A563016D123E AS DateTime), 0, CAST(0x0000A563016D123E AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, 9, 1, 12000, 0, N'', 0, CAST(0x0000A563016D34A2 AS DateTime), 0, CAST(0x0000A563016D34A2 AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 10, 1, 12000, 0, N'', 0, CAST(0x0000A563016D4AAE AS DateTime), 0, CAST(0x0000A563016D4AAE AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (11, 11, 1, 10000, 0, N'', 0, CAST(0x0000A563016E5965 AS DateTime), 0, CAST(0x0000A563016E5965 AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 12, 1, 3000, 0, N'', 0, CAST(0x0000A563016E6C34 AS DateTime), 0, CAST(0x0000A563016E6C34 AS DateTime))
INSERT [dbo].[MODIFIRE_PRICE] ([ModifirePriceID], [ModifireID], [Status], [CurrentPrice], [WasPrice], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (13, 13, 1, 15000, 0, N'', 0, CAST(0x0000A563016E81FF AS DateTime), 0, CAST(0x0000A563016E81FF AS DateTime))
SET IDENTITY_INSERT [dbo].[MODIFIRE_PRICE] OFF
/****** Object:  Table [dbo].[MODIFIRE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODIFIRE](
	[ModifireID] [int] IDENTITY(1,1) NOT NULL,
	[ModifireName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL,
	[Color] [nvarchar](250) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_MODIFIRE] PRIMARY KEY CLUSTERED 
(
	[ModifireID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MODIFIRE] ON
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Them thit suon', 1, N'Aqua', N'', 0, CAST(0x0000A563016BB71C AS DateTime), 0, CAST(0x0000A563016BB71D AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Them trung', 1, N'DarkMagenta', N'', 0, CAST(0x0000A563016BCC43 AS DateTime), 0, CAST(0x0000A563016BCC43 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Them cha', 1, N'DarkBlue', N'', 0, CAST(0x0000A563016BE276 AS DateTime), 0, CAST(0x0000A563016BE276 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Them bi', 1, N'BurlyWood', N'', 0, CAST(0x0000A563016BEF96 AS DateTime), 0, CAST(0x0000A563016BEF96 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'Them com', 1, N'BlueViolet', N'', 0, CAST(0x0000A563016C0EA5 AS DateTime), 0, CAST(0x0000A563016C0EA5 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, N'Them mo hanh', 1, N'Crimson', N'', 0, CAST(0x0000A563016C266B AS DateTime), 0, CAST(0x0000A563016C266B AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, N'Them bo', 1, N'Chartreuse', N'', 0, CAST(0x0000A563016D0093 AS DateTime), 0, CAST(0x0000A563016D0093 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, N'Them bo vien', 1, N'Chocolate', N'', 0, CAST(0x0000A563016D1233 AS DateTime), 0, CAST(0x0000A563016D1233 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, N'Them ga', 1, N'Chartreuse', N'', 0, CAST(0x0000A563016D34A0 AS DateTime), 0, CAST(0x0000A563016D34A0 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, N'Them banh pho', 1, N'Chocolate', N'', 0, CAST(0x0000A563016D4AAB AS DateTime), 0, CAST(0x0000A563016D4AAB AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (11, N'Them gio heo', 1, N'BurlyWood', N'', 0, CAST(0x0000A563016E5963 AS DateTime), 0, CAST(0x0000A563016E5963 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, N'Them rau', 1, N'Chartreuse', N'', 0, CAST(0x0000A563016E6C32 AS DateTime), 0, CAST(0x0000A563016E6C32 AS DateTime))
INSERT [dbo].[MODIFIRE] ([ModifireID], [ModifireName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (13, N'Them thit bam', 1, N'Chartreuse', N'', 0, CAST(0x0000A563016E81FE AS DateTime), 0, CAST(0x0000A563016E81FE AS DateTime))
SET IDENTITY_INSERT [dbo].[MODIFIRE] OFF
/****** Object:  Table [dbo].[MENU]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MENU](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](500) NOT NULL,
	[Priority] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_MENU] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MENU] ON
INSERT [dbo].[MENU] ([MenuID], [MenuName], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Eat In', 1, 1, NULL, 0, CAST(0x0000A56D0129260B AS DateTime), 0, CAST(0x0000A56D0129260B AS DateTime))
INSERT [dbo].[MENU] ([MenuID], [MenuName], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Setting', 1, 1, NULL, 0, CAST(0x0000A56D012930A2 AS DateTime), 0, CAST(0x0000A56D012930A2 AS DateTime))
SET IDENTITY_INSERT [dbo].[MENU] OFF
/****** Object:  Table [dbo].[MAP_PRODUCT_TO_CATEGORY]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY](
	[ProductID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_MAP_PRODUCT_TO_CATEGORY] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[CategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, 1, 1, N'', 0, CAST(0x0000A563017098F6 AS DateTime), 0, CAST(0x0000A563017098F6 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 2, 1, N'', 0, CAST(0x0000A5630170A190 AS DateTime), 0, CAST(0x0000A5630170A190 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (11, 2, 1, N'', 0, CAST(0x0000A5630170A190 AS DateTime), 0, CAST(0x0000A5630170A190 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 2, 1, N'', 0, CAST(0x0000A5630170A190 AS DateTime), 0, CAST(0x0000A5630170A190 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (13, 2, 1, N'', 0, CAST(0x0000A5630170A190 AS DateTime), 0, CAST(0x0000A5630170A190 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (14, 3, 1, N'', 0, CAST(0x0000A5630170AB97 AS DateTime), 0, CAST(0x0000A5630170AB97 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (15, 3, 1, N'', 0, CAST(0x0000A5630170AB97 AS DateTime), 0, CAST(0x0000A5630170AB97 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (16, 3, 1, N'', 0, CAST(0x0000A5630170AB97 AS DateTime), 0, CAST(0x0000A5630170AB97 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (17, 3, 1, N'', 0, CAST(0x0000A5630170AB97 AS DateTime), 0, CAST(0x0000A5630170AB97 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (18, 4, 1, N'', 0, CAST(0x0000A5630170B265 AS DateTime), 0, CAST(0x0000A5630170B265 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (19, 4, 1, N'', 0, CAST(0x0000A5630170B265 AS DateTime), 0, CAST(0x0000A5630170B265 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (20, 5, 1, N'', 0, CAST(0x0000A56500DD9D55 AS DateTime), 0, CAST(0x0000A56500DD9D55 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (21, 1, 1, N'', 0, CAST(0x0000A56500E13036 AS DateTime), 0, CAST(0x0000A56500E13036 AS DateTime))
INSERT [dbo].[MAP_PRODUCT_TO_CATEGORY] ([ProductID], [CategoryID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (22, 9, 1, N'', 0, CAST(0x0000A56500E1EB6C AS DateTime), 0, CAST(0x0000A56500E1EB6C AS DateTime))
/****** Object:  Table [dbo].[MAP_MODIFIRE_TO_PRODUCT]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT](
	[ModifireID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_MAP_MODIFIRE_TO_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[ModifireID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 1, 1, N'', 0, CAST(0x0000A56301713CE9 AS DateTime), 0, CAST(0x0000A56301713CE9 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 1, 1, N'', 0, CAST(0x0000A56301715CF9 AS DateTime), 0, CAST(0x0000A56301715CF9 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 1, 1, N'', 0, CAST(0x0000A56301715CF9 AS DateTime), 0, CAST(0x0000A56301715CF9 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 2, 1, N'', 0, CAST(0x0000A56301714327 AS DateTime), 0, CAST(0x0000A56301714327 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 1, 1, N'', 0, CAST(0x0000A56301715CF9 AS DateTime), 0, CAST(0x0000A56301715CF9 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 10, 1, N'', 0, CAST(0x0000A5630172285E AS DateTime), 0, CAST(0x0000A5630172285E AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 12, 1, N'', 0, CAST(0x0000A56301729103 AS DateTime), 0, CAST(0x0000A56301729103 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, 11, 1, N'', 0, CAST(0x0000A56301723849 AS DateTime), 0, CAST(0x0000A56301723849 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, 4, 1, N'', 0, CAST(0x0000A56E016D7034 AS DateTime), 0, CAST(0x0000A56E016D7034 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, 13, 1, N'', 0, CAST(0x0000A56301725417 AS DateTime), 0, CAST(0x0000A56301725417 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 10, 1, N'', 0, CAST(0x0000A56301721C52 AS DateTime), 0, CAST(0x0000A56301721C52 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 11, 1, N'', 0, CAST(0x0000A56301723849 AS DateTime), 0, CAST(0x0000A56301723849 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 12, 1, N'', 0, CAST(0x0000A56301728B92 AS DateTime), 0, CAST(0x0000A56301728B92 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 13, 1, N'', 0, CAST(0x0000A56301725417 AS DateTime), 0, CAST(0x0000A56301725417 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (11, 14, 1, N'', 0, CAST(0x0000A56301725FBE AS DateTime), 0, CAST(0x0000A56301725FBE AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 14, 1, N'', 0, CAST(0x0000A56301725FBE AS DateTime), 0, CAST(0x0000A56301725FBE AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 15, 1, N'', 0, CAST(0x0000A563017267CA AS DateTime), 0, CAST(0x0000A563017267CA AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 16, 1, N'', 0, CAST(0x0000A56301729CB6 AS DateTime), 0, CAST(0x0000A56301729CB6 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 17, 1, N'', 0, CAST(0x0000A56301727455 AS DateTime), 0, CAST(0x0000A56301727455 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 20, 1, N'', 0, CAST(0x0000A56500DEEDB0 AS DateTime), 0, CAST(0x0000A56500DEEDB0 AS DateTime))
INSERT [dbo].[MAP_MODIFIRE_TO_PRODUCT] ([ModifireID], [ProductID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (13, 15, 1, N'', 0, CAST(0x0000A563017267CA AS DateTime), 0, CAST(0x0000A563017267CA AS DateTime))
/****** Object:  Table [dbo].[MAP_CATEGORY_TO_CATALOGUE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE](
	[CategoryID] [int] NOT NULL,
	[CatalogueID] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_MAP_CATEGORY_TO_CATALOGUE] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC,
	[CatalogueID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 2, 1, N'', 0, CAST(0x0000A563016FC6A0 AS DateTime), 0, CAST(0x0000A563016FC6A0 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 2, 1, N'', 0, CAST(0x0000A56500DD210E AS DateTime), 0, CAST(0x0000A56500DD210E AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 3, 1, N'', 0, CAST(0x0000A56500DD509B AS DateTime), 0, CAST(0x0000A56500DD509B AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, 3, 1, N'', 0, CAST(0x0000A56500DD509B AS DateTime), 0, CAST(0x0000A56500DD509B AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 4, 1, N'', 0, CAST(0x0000A565011978ED AS DateTime), 0, CAST(0x0000A565011978ED AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, 4, 1, N'', 0, CAST(0x0000A565011978ED AS DateTime), 0, CAST(0x0000A565011978ED AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, 4, 1, N'', 0, CAST(0x0000A565011978ED AS DateTime), 0, CAST(0x0000A565011978ED AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 1, 1, N'', 0, CAST(0x0000A563016FB990 AS DateTime), 0, CAST(0x0000A563016FB990 AS DateTime))
INSERT [dbo].[MAP_CATEGORY_TO_CATALOGUE] ([CategoryID], [CatalogueID], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 4, 1, N'', 0, CAST(0x0000A5660166491E AS DateTime), 0, CAST(0x0000A5660166491E AS DateTime))
/****** Object:  Table [dbo].[INVOICE_DETAIL_MODIFIRE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL_MODIFIRE](
	[InvoiceModifireID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [nvarchar](50) NOT NULL,
	[OrderModifireID] [int] NULL,
	[Satust] [int] NOT NULL,
	[ProductID] [int] NULL,
	[KeyModi] [int] NULL,
	[ModifireID] [int] NULL,
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_INVOICE_DETAIL_MODIFIRE] PRIMARY KEY CLUSTERED 
(
	[InvoiceModifireID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVOICE_DETAIL]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL](
	[InvoiceDetailID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [nvarchar](50) NOT NULL,
	[OrderDetailID] [int] NULL,
	[KeyItem] [int] NULL,
	[Status] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_INVOICE_DETAIL] PRIMARY KEY CLUSTERED 
(
	[InvoiceDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVOICE_BY_CARD]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_BY_CARD](
	[InvoiceByCardID] [nvarchar](50) NOT NULL,
	[InvoiceNum] [nvarchar](50) NULL,
	[CardID] [int] NULL,
	[Total] [float] NULL,
	[Note] [nvarchar](max) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_INVOICE_BY_CARD] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[INVOICE_BY_CARD] ON
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015121801', N'1', 2, 1000, N'', 1, 0, CAST(0x0000A57200E5BA5B AS DateTime), 0, CAST(0x0000A57200E5BA5B AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015121801', N'1', 1, 200, N'', 2, 0, CAST(0x0000A57200E5BA5C AS DateTime), 0, CAST(0x0000A57200E5BA5C AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015121821', N'3', 2, 50, N'', 3, 0, CAST(0x0000A572010CADAC AS DateTime), 0, CAST(0x0000A572010CADAC AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015121821', N'3', 1, 20, N'', 4, 0, CAST(0x0000A572010CADAC AS DateTime), 0, CAST(0x0000A572010CADAC AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015121821', N'3', 3, 3, N'', 5, 0, CAST(0x0000A572010CADAC AS DateTime), 0, CAST(0x0000A572010CADAC AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015121851', N'6', 2, 30, N'', 6, 0, CAST(0x0000A57201120E6C AS DateTime), 0, CAST(0x0000A57201120E6C AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015121861', N'7', 2, 30, N'', 7, 0, CAST(0x0000A57201121C48 AS DateTime), 0, CAST(0x0000A57201121C48 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015121871', N'8', 2, 30, N'', 8, 0, CAST(0x0000A57201121D38 AS DateTime), 0, CAST(0x0000A57201121D38 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122201', N'1', 1, 200, N'', 9, 0, CAST(0x0000A576012A6CB1 AS DateTime), 0, CAST(0x0000A576012A6CB1 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122211', N'2', 2, 100, N'', 10, 0, CAST(0x0000A576012B29E1 AS DateTime), 0, CAST(0x0000A576012B29E1 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122241', N'5', 2, 100, N'', 11, 0, CAST(0x0000A576016A7A6A AS DateTime), 0, CAST(0x0000A576016A7A6A AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151222101', N'11', 1, 100, N'', 12, 0, CAST(0x0000A57601732241 AS DateTime), 0, CAST(0x0000A57601732241 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151222101', N'11', 2, 50, N'', 13, 0, CAST(0x0000A57601732242 AS DateTime), 0, CAST(0x0000A57601732242 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151222111', N'12', 2, 100000, N'', 14, 0, CAST(0x0000A5760173AD16 AS DateTime), 0, CAST(0x0000A5760173AD16 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151223121', N'13', 2, 80000, N'', 15, 0, CAST(0x0000A577011662E6 AS DateTime), 0, CAST(0x0000A577011662E6 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151223171', N'18', 2, 100000, N'', 16, 0, CAST(0x0000A5770176DE0F AS DateTime), 0, CAST(0x0000A5770176DE0F AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151223181', N'19', 1, 90000, N'', 17, 0, CAST(0x0000A57701783F6C AS DateTime), 0, CAST(0x0000A57701783F6C AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122711', N'2', 2, 100000, N'', 18, 0, CAST(0x0000A57B016E57AC AS DateTime), 0, CAST(0x0000A57B016E57AC AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122711', N'2', 1, 150000, N'', 19, 0, CAST(0x0000A57B016E57AD AS DateTime), 0, CAST(0x0000A57B016E57AD AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122721', N'3', 2, 100000, N'', 20, 0, CAST(0x0000A57B016ED261 AS DateTime), 0, CAST(0x0000A57B016ED261 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122731', N'4', 2, 50000, N'', 21, 0, CAST(0x0000A57B016F133E AS DateTime), 0, CAST(0x0000A57B016F133E AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122851', N'6', 4, 50000, N'', 22, 0, CAST(0x0000A57C00B9EC03 AS DateTime), 0, CAST(0x0000A57C00B9EC03 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'2015122851', N'6', 2, 100000, N'', 23, 0, CAST(0x0000A57C00B9EC03 AS DateTime), 0, CAST(0x0000A57C00B9EC03 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151229101', N'11', 1, 300000, N'', 24, 0, CAST(0x0000A57D01075A13 AS DateTime), 0, CAST(0x0000A57D01075A14 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151229111', N'12', 2, 100000, N'', 25, 0, CAST(0x0000A57D010F2864 AS DateTime), 0, CAST(0x0000A57D010F2865 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151229121', N'13', 2, 60000, N'', 26, 0, CAST(0x0000A57D010FD192 AS DateTime), 0, CAST(0x0000A57D010FD192 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151229121', N'13', 3, 100000, N'', 27, 0, CAST(0x0000A57D010FD192 AS DateTime), 0, CAST(0x0000A57D010FD192 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151229131', N'14', 2, 20000, N'', 28, 0, CAST(0x0000A57D01101DF2 AS DateTime), 0, CAST(0x0000A57D01101DF2 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151229131', N'14', 3, 60000, N'', 29, 0, CAST(0x0000A57D01101DF2 AS DateTime), 0, CAST(0x0000A57D01101DF2 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151229141', N'15', 1, 70000, N'', 30, 0, CAST(0x0000A57D0144BC37 AS DateTime), 0, CAST(0x0000A57D0144BC37 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151230161', N'17', 4, 70000, N'', 31, 0, CAST(0x0000A57E01531597 AS DateTime), 0, CAST(0x0000A57E01531598 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151230181', N'19', 2, 70000, N'', 32, 0, CAST(0x0000A57E01540404 AS DateTime), 0, CAST(0x0000A57E01540404 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151230201', N'21', 3, 100000, N'', 33, 0, CAST(0x0000A57E015577CC AS DateTime), 0, CAST(0x0000A57E015577CC AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151230221', N'23', 4, 150000, N'', 34, 0, CAST(0x0000A57E016B398D AS DateTime), 0, CAST(0x0000A57E016B398E AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151230221', N'23', 3, 20000, N'', 35, 0, CAST(0x0000A57E016B398F AS DateTime), 0, CAST(0x0000A57E016B398F AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20151230241', N'25', 2, 500000, N'', 36, 0, CAST(0x0000A57E01704F02 AS DateTime), 0, CAST(0x0000A57E01704F02 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161401', N'1', 4, 40000, N'', 37, 0, CAST(0x0000A5830099D971 AS DateTime), 0, CAST(0x0000A5830099D971 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161401', N'1', 3, 60000, N'', 38, 0, CAST(0x0000A5830099D971 AS DateTime), 0, CAST(0x0000A5830099D971 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161411', N'2', 2, 50000, N'', 39, 0, CAST(0x0000A583009CC099 AS DateTime), 0, CAST(0x0000A583009CC099 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161411', N'2', 3, 150000, N'', 40, 0, CAST(0x0000A583009CC099 AS DateTime), 0, CAST(0x0000A583009CC099 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161651', N'6', 2, 60000, N'', 41, 0, CAST(0x0000A585012CA571 AS DateTime), 0, CAST(0x0000A585012CA571 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161661', N'7', 4, 40000, N'', 42, 0, CAST(0x0000A585012D53DD AS DateTime), 0, CAST(0x0000A585012D53DD AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161661', N'7', 1, 60000, N'', 43, 0, CAST(0x0000A585012D53DD AS DateTime), 0, CAST(0x0000A585012D53DD AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161681', N'9', 2, 100000, N'', 44, 0, CAST(0x0000A585012E4A54 AS DateTime), 0, CAST(0x0000A585012E4A54 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161701', N'1', 3, 30000, N'', 45, 0, CAST(0x0000A586017D64B3 AS DateTime), 0, CAST(0x0000A586017D64B3 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161701', N'1', 4, 10000, N'', 46, 0, CAST(0x0000A586017D64B4 AS DateTime), 0, CAST(0x0000A586017D64B4 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161711', N'2', 2, 60000, N'', 47, 0, CAST(0x0000A586017DDB43 AS DateTime), 0, CAST(0x0000A586017DDB43 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161721', N'3', 2, 40000, N'', 48, 0, CAST(0x0000A586017EE48D AS DateTime), 0, CAST(0x0000A586017EE48D AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161721', N'3', 4, 110000, N'', 49, 0, CAST(0x0000A586017EE48E AS DateTime), 0, CAST(0x0000A586017EE48E AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161731', N'4', 4, 20000, N'', 50, 0, CAST(0x0000A586017F9453 AS DateTime), 0, CAST(0x0000A586017F9453 AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161741', N'5', 3, 100000, N'', 51, 0, CAST(0x0000A58601800EBF AS DateTime), 0, CAST(0x0000A58601800EBF AS DateTime))
INSERT [dbo].[INVOICE_BY_CARD] ([InvoiceByCardID], [InvoiceNum], [CardID], [Total], [Note], [ID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (N'20161871', N'8', 2, 265000, N'', 52, 0, CAST(0x0000A587011C96EB AS DateTime), 0, CAST(0x0000A587011C96EB AS DateTime))
SET IDENTITY_INSERT [dbo].[INVOICE_BY_CARD] OFF
/****** Object:  Table [dbo].[INVOICE]    Script Date: 01/12/2016 17:06:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [nvarchar](50) NULL,
	[OrderID] [int] NOT NULL,
	[Satust] [int] NOT NULL,
	[Total] [int] NULL,
	[Payment] [int] NULL,
	[Change] [int] NULL,
	[Discount] [int] NULL,
	[DiscountType] [int] NULL,
	[InvoiceByCardID] [nvarchar](50) NULL,
	[ShiftID] [int] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_INVOICE] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[getProductByCategory]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getProductByCategory] @categoryid INT = 0
AS
    BEGIN
	
        SET NOCOUNT ON;
	
       SELECT     dbo.PRODUCT.ProductID,dbo.PRODUCT.ProductNameDesc, dbo.PRODUCT.ProductNameSort, dbo.PRODUCT.Color, dbo.PRODUCT_PRICE.CurrentPrice, 
                      dbo.MAP_PRODUCT_TO_CATEGORY.CategoryID
FROM         dbo.MAP_PRODUCT_TO_CATEGORY INNER JOIN
                      dbo.PRODUCT ON dbo.MAP_PRODUCT_TO_CATEGORY.ProductID = dbo.PRODUCT.ProductID INNER JOIN
                      dbo.PRODUCT_PRICE ON dbo.MAP_PRODUCT_TO_CATEGORY.ProductID = dbo.PRODUCT_PRICE.ProductID
WHERE     (dbo.MAP_PRODUCT_TO_CATEGORY.CategoryID =@categoryid and dbo.PRODUCT.Status=1)

    END
GO
/****** Object:  StoredProcedure [dbo].[getModifireByProduct]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getModifireByProduct] @productid INT = 0
AS
    BEGIN
	
        SET NOCOUNT ON;
	
       SELECT     dbo.MAP_MODIFIRE_TO_PRODUCT.ProductID, dbo.MODIFIRE.ModifireID, dbo.MODIFIRE.ModifireName, dbo.MODIFIRE_PRICE.CurrentPrice, 
                      dbo.MODIFIRE.Color
FROM         dbo.MAP_MODIFIRE_TO_PRODUCT INNER JOIN
                      dbo.MODIFIRE ON dbo.MAP_MODIFIRE_TO_PRODUCT.ModifireID = dbo.MODIFIRE.ModifireID INNER JOIN
                      dbo.MODIFIRE_PRICE ON dbo.MAP_MODIFIRE_TO_PRODUCT.ModifireID = dbo.MODIFIRE_PRICE.ModifireID
WHERE     (dbo.MAP_MODIFIRE_TO_PRODUCT.ProductID = @productid and dbo.MODIFIRE.Status=1)

    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetDataListShiftHistoryByUserID]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pos_th_GetDataListShiftHistoryByUserID]
    @userid INT = 0 ,
    @type INT = 0
AS
    BEGIN
	
        SET NOCOUNT ON;

		  IF OBJECT_ID(N'dbo.TableTemp', N'U') IS NOT NULL
            BEGIN
                DROP TABLE TableTemp
            END

        --DECLARE @deparmentid INT= 0;

        --SELECT TOP 1
        --        @deparmentid = DepartmentID
        --FROM    dbo.STAFF
        --WHERE   StaffID = @userid

        IF ( @type = 0 )
            BEGIN

                SELECT  sh.ShiftHistoryID ,
                        s.StaffID ,
                        sh.ShiftName ,
                        sh.StartShift ,
                        sh.EndShift ,
                        sh.Status ,
                        ISNULL(sh.CashStart, 0) AS CashStart ,
                        ISNULL(sh.CashEnd, 0) AS CashEnd ,
                        ISNULL(sh.SafeDrop, 0) AS SafeDrop ,
                        ISNULL(s.UserName,'') AS UserName
                INTO    TableTemp
                FROM    dbo.SHIFT_HISTORY sh
                        INNER JOIN dbo.STAFF s ON s.StaffID = sh.StaffID
                WHERE   sh.Status = 1
				
				
      --          IF ( @deparmentid = 3 )
      --              BEGIN
      --                  SELECT  *
      --                  FROM    TableTemp
      --                  WHERE   StaffID = @userid
						--ORDER BY StartShift DESC
      --              END
      --          ELSE
      --              BEGIN
                        SELECT  *
                        FROM    TableTemp
						ORDER BY StartShift DESC
                   -- END

				

            END
        ELSE
            BEGIN

                SELECT  sh.ShiftHistoryID ,
                        s.StaffID ,
                        sh.ShiftName ,
                        sh.StartShift ,
                        sh.EndShift ,
                        sh.Status ,
                        ISNULL(sh.CashStart, 0) AS CashStart ,
                        ISNULL(sh.CashEnd, 0) AS CashEnd ,
                        ISNULL(sh.SafeDrop, 0) AS SafeDrop ,
                       ISNULL(s.UserName,'') AS UserName
						INTO   TableTemp
                FROM    dbo.SHIFT_HISTORY sh
                        INNER JOIN dbo.STAFF s ON s.StaffID = sh.StaffID
                WHERE   sh.Status = 2 AND CONVERT(NVARCHAR(10),sh.StartShift,103)=CONVERT(NVARCHAR(10),GETDATE(),103)
              


				  --IF ( @deparmentid = 3 )
      --              BEGIN
      --                  SELECT  *
      --                  FROM    TableTemp
      --                  --WHERE   StaffID = @userid
						--ORDER BY StartShift DESC
      --              END
      --          ELSE
      --              BEGIN
                        SELECT  *
                        FROM    TableTemp
						ORDER BY StartShift DESC
                    --END
            END
    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetDailySaleReport]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[pos_th_GetDailySaleReport]
AS
    BEGIN
	
        SET NOCOUNT ON;
	

        SELECT ISNULL(MAX(temp.TotalCash),0) AS CashTotal ,
               ISNULL(MAX(temp.TotalCard),0) AS CardTotal ,
			   ISNULL(MAX(temp.TotalCheque),0) AS ChequeTotal ,
               ISNULL(MAX(temp.TotalAccount),0) AS AccountTotal ,
			   ISNULL(MAX(temp.TotalGiftCard),0) AS GrifCardTotal ,
               ISNULL(MAX(temp.TotalCash) + MAX(temp.TotalCard)+MAX(temp.TotalCheque) + MAX(temp.TotalAccount)+MAX(temp.TotalGiftCard),0) AS SaleTotal
        FROM    ( SELECT    CASE WHEN PaymentTypeID = 1 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalCash ,
                            CASE WHEN PaymentTypeID = 2 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalCard ,
							  CASE WHEN PaymentTypeID = 3 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalCheque,
                            CASE WHEN PaymentTypeID = 4 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalAccount,
							 CASE WHEN PaymentTypeID = 5 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalGiftCard
                  FROM      dbo.PAYMENT_INVOICE_HISTORY
                  WHERE     Satust=1 AND CONVERT(NVARCHAR(10), GETDATE(), 103) = CONVERT(NVARCHAR(10), CreateDate, 103)
                  GROUP BY  PaymentTypeID
                ) AS temp


  
    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListProductByCategory]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<thien huynh>
-- Create date: <29/11/2015>
-- Description:	<Description,,>
-- =============================================
/*

		EXEC pos_th_GetAllListProductByCategory @categoryid=1

*/



CREATE PROCEDURE [dbo].[pos_th_GetAllListProductByCategory] @categoryid INT = 0
AS
    BEGIN
	
        SET NOCOUNT ON;
	
        SELECT  ProductID,ProductNameDesc,ProductNameSort
        FROM    dbo.PRODUCT
        WHERE   Status = 1
                AND ProductID NOT IN ( SELECT  ProductID
                                        FROM    dbo.MAP_PRODUCT_TO_CATEGORY
                                        WHERE   CategoryID = @categoryid
                                                AND Status = 1 )

    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListPermissionByDepartmentID]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<thien huynh>
-- Create date: <29/11/2015>
-- Description:	<Description,,>
-- =============================================

--EXEC pos_th_GetAllListPermissionByDepartmentID @departmentid=2

create PROCEDURE [dbo].[pos_th_GetAllListPermissionByDepartmentID] @departmentid INT
AS
    BEGIN

        SET NOCOUNT ON;
        SELECT  SubMenuID ,
                SubMenuName
        FROM    dbo.SUB_MENU
        WHERE   Status = 1
                AND SubMenuID NOT IN ( SELECT   SubMenuID
                                       FROM     dbo.PERMISSION
                                       WHERE    DepartmentID = @departmentid
                                                AND Status = 1 )
  
    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListCategoryByCatalogue]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<thien huynh>
-- Create date: <29/11/2015>
-- Description:	<Description,,>
-- =============================================
/*

		EXEC pos_th_GetAllListCategoryByCatalogue @catalogueid=3

*/



create PROCEDURE [dbo].[pos_th_GetAllListCategoryByCatalogue] @catalogueid INT = 0
AS
    BEGIN
	
        SET NOCOUNT ON;
	
        SELECT  CategoryID,CategoryName,ISNULL(CategoryNameSort,'') AS CategoryNameSort 
        FROM    dbo.CATEGORY
        WHERE   Status = 1
                AND CategoryID NOT IN ( SELECT  CategoryID
                                        FROM    dbo.MAP_CATEGORY_TO_CATALOGUE
                                        WHERE   CatalogueID = @catalogueid
                                                AND Status = 1 )

    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataPermissionByDepartmet]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

/*

DECLARE @tablecategory TableTemp
--INSERT INTO @tablecategory(Value) VALUES (1)
INSERT INTO @tablecategory(Value) VALUES (3)
INSERT INTO @tablecategory(Value) VALUES (4)

exec pos_th_SaveDataMapCategoryToCatalogue @catalogueid=9,@userid=0,@tablecategory=@tablecategory


*/



create PROCEDURE [dbo].[pos_th_SaveDataPermissionByDepartmet]
    @departmentid INT = 0 ,
    @userid INT = 0 ,
    @tablesubmenu TableTemp READONLY
AS
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON;


		--SELECT * FROM @tablecategory

        UPDATE  dbo.PERMISSION
        SET     Status = 1 ,
                UpdateBy = @userid ,
                UpdateDate = GETDATE()
        WHERE   DepartmentID = @departmentid
                AND Status = 0
                AND SubMenuID IN ( SELECT   Value
                                   FROM     @tablesubmenu )

        INSERT  INTO dbo.PERMISSION
                ( PermissionName ,
                  Status ,
                  DepartmentID ,
                  SubMenuID ,
                  CreateBy ,
                  CreateDate ,
                  UpdateBy ,
                  UpdateDate ,
                  Note
                )
                SELECT  b.SubMenuName ,
                        1 ,
                        @departmentid ,
                        a.Value ,
                        @userid ,
                        GETDATE() ,
                        @userid ,
                        GETDATE() ,
                        ''
                FROM    @tablesubmenu a
                        INNER JOIN dbo.SUB_MENU b ON a.Value = b.SubMenuID
                WHERE   Value NOT IN ( SELECT   SubMenuID
                                       FROM     dbo.PERMISSION
                                       WHERE    DepartmentID = @departmentid )


        UPDATE  dbo.PERMISSION
        SET     Status = 0 ,
                UpdateBy = @userid ,
                UpdateDate = GETDATE()
        WHERE   DepartmentID = @departmentid
                AND SubMenuID NOT IN ( SELECT  Value
                                        FROM    @tablesubmenu )

    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapProductToCategory]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

/*

DECLARE @tablecategory TableTemp
--INSERT INTO @tablecategory(Value) VALUES (1)
INSERT INTO @tablecategory(Value) VALUES (3)
INSERT INTO @tablecategory(Value) VALUES (4)

exec pos_th_SaveDataMapProductToCategory @catalogueid=9,@userid=0,@tablecategory=@tablecategory


*/



create PROCEDURE [dbo].[pos_th_SaveDataMapProductToCategory]
    @categoryid INT = 0 ,
    @userid INT = 0 ,
    @tableproduct TableTemp READONLY
AS
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON;


		--SELECT * FROM @tablecategory

		    UPDATE  dbo.MAP_PRODUCT_TO_CATEGORY
        SET     Status = 1 ,
                UpdateBy = @userid ,
                UpdateDate = GETDATE()
        WHERE   CategoryID = @categoryid AND Status=0
                AND ProductID IN ( SELECT  Value
                                        FROM   @tableproduct )

        INSERT  INTO dbo.MAP_PRODUCT_TO_CATEGORY
                ( ProductID ,
                  CategoryID ,
                  Status ,
                  Note ,
                  CreateBy ,
                  CreateDate ,
                  UpdateBy ,
                  UpdateDate
	            )
                SELECT  Value ,
                        @categoryid ,
                        1 ,
                        '' ,
                        @userid ,
                        GETDATE() ,
                        @userid ,
                        GETDATE()
                FROM    @tableproduct
                WHERE   Value NOT IN ( SELECT   ProductID
                                       FROM     dbo.MAP_PRODUCT_TO_CATEGORY
                                       WHERE    CategoryID = @categoryid
                                         )


        UPDATE  MAP_PRODUCT_TO_CATEGORY
        SET     Status = 0 ,
                UpdateBy = @userid ,
                UpdateDate = GETDATE()
        WHERE   CategoryID = @categoryid
                AND ProductID NOT IN ( SELECT  Value
                                        FROM    @tableproduct )

    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapModifireToProduct]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pos_th_SaveDataMapModifireToProduct]
	-- Add the parameters for the stored procedure here
   @productid INT = 0 ,
    @userid INT = 0 ,
    @tablemodifire TableTemp READONLY
AS
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON;


		--SELECT * FROM @tablecategory

		    UPDATE  MAP_MODIFIRE_TO_PRODUCT
        SET     Status = 1 ,
                UpdateBy = @userid ,
                UpdateDate = GETDATE()
        WHERE   ProductID = @productid AND Status=0
                AND ModifireID IN ( SELECT  Value
                                        FROM   @tablemodifire )

        INSERT  INTO dbo.MAP_MODIFIRE_TO_PRODUCT
                ( ModifireID ,
                  ProductID ,
                  Status ,
                  Note ,
                  CreateBy ,
                  CreateDate ,
                  UpdateBy ,
                  UpdateDate
	            )
                SELECT  Value ,
                        @productid ,
                        1 ,
                        '' ,
                        @userid ,
                        GETDATE() ,
                        @userid ,
                        GETDATE()
                FROM    @tablemodifire
                WHERE   Value NOT IN ( SELECT   ModifireID
                                       FROM     dbo.MAP_MODIFIRE_TO_PRODUCT
                                       WHERE    ProductID = @productid
                                         )


        UPDATE  MAP_MODIFIRE_TO_PRODUCT
        SET     Status = 0 ,
                UpdateBy = @userid ,
                UpdateDate = GETDATE()
        WHERE   ProductID = @productid
                AND ModifireID NOT IN ( SELECT  Value
                                        FROM    @tablemodifire )

    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapCategoryToCatalogue]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

/*

DECLARE @tablecategory TableTemp
--INSERT INTO @tablecategory(Value) VALUES (1)
INSERT INTO @tablecategory(Value) VALUES (3)
INSERT INTO @tablecategory(Value) VALUES (4)

exec pos_th_SaveDataMapCategoryToCatalogue @catalogueid=9,@userid=0,@tablecategory=@tablecategory


*/



create PROCEDURE [dbo].[pos_th_SaveDataMapCategoryToCatalogue]
    @catalogueid INT = 0 ,
    @userid INT = 0 ,
    @tablecategory TableTemp READONLY
AS
    BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
        SET NOCOUNT ON;


		--SELECT * FROM @tablecategory

		    UPDATE  MAP_CATEGORY_TO_CATALOGUE
        SET     Status = 1 ,
                UpdateBy = @userid ,
                UpdateDate = GETDATE()
        WHERE   CatalogueID = @catalogueid AND Status=0
                AND CategoryID IN ( SELECT  Value
                                        FROM   @tablecategory )

        INSERT  INTO dbo.MAP_CATEGORY_TO_CATALOGUE
                ( CategoryID ,
                  CatalogueID ,
                  Status ,
                  Note ,
                  CreateBy ,
                  CreateDate ,
                  UpdateBy ,
                  UpdateDate
	            )
                SELECT  Value ,
                        @catalogueid ,
                        1 ,
                        '' ,
                        @userid ,
                        GETDATE() ,
                        @userid ,
                        GETDATE()
                FROM    @tablecategory
                WHERE   Value NOT IN ( SELECT   categoryid
                                       FROM     dbo.MAP_CATEGORY_TO_CATALOGUE
                                       WHERE    CatalogueID = @catalogueid
                                         )


        UPDATE  MAP_CATEGORY_TO_CATALOGUE
        SET     Status = 0 ,
                UpdateBy = @userid ,
                UpdateDate = GETDATE()
        WHERE   CatalogueID = @catalogueid
                AND CategoryID NOT IN ( SELECT  Value
                                        FROM    @tablecategory )

    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetWeeklySaleReport]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[pos_th_GetWeeklySaleReport]
AS
    BEGIN
	
        SET NOCOUNT ON;

        DECLARE @StarDay DATETIME= GETDATE();

        DECLARE @flag INT = 0;

        SELECT  @flag = ( 1 + ( ( 6 + DATEPART(dw, GETDATE()) + @@DATEFIRST ) % 7 ) );


        SELECT  @StarDay = CASE WHEN @flag = 1 THEN GETDATE() - 6
                                WHEN @flag = 2 THEN GETDATE()
                                WHEN @flag = 3 THEN GETDATE() - 1
                                WHEN @flag = 4 THEN GETDATE() - 2
                                WHEN @flag = 5 THEN GETDATE() - 3
                                WHEN @flag = 6 THEN GETDATE() - 4
                                WHEN @flag = 7 THEN GETDATE() - 5
                                ELSE GETDATE()
                           END

		SET @StarDay='12-21-2015'

        SELECT  ISNULL(MAX(temp.TotalCash), 0) AS CashTotal ,
                ISNULL(MAX(temp.TotalCard), 0) AS CardTotal ,
                ISNULL(MAX(temp.TotalCheque), 0) AS ChequeTotal ,
                ISNULL(MAX(temp.TotalAccount), 0) AS AccountTotal ,
                ISNULL(MAX(temp.TotalGiftCard), 0) AS GrifCardTotal ,
                ISNULL(MAX(temp.TotalCash) + MAX(temp.TotalCard)
                       + MAX(temp.TotalCheque) + MAX(temp.TotalAccount)
                       + MAX(temp.TotalGiftCard), 0) AS SaleTotal
        FROM    ( SELECT    CASE WHEN PaymentTypeID = 1 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalCash ,
                            CASE WHEN PaymentTypeID = 2 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalCard ,
                            CASE WHEN PaymentTypeID = 3 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalCheque ,
                            CASE WHEN PaymentTypeID = 4 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalAccount ,
                            CASE WHEN PaymentTypeID = 5 THEN SUM(Total)
                                 ELSE 0
                            END AS TotalGiftCard
                  FROM      dbo.PAYMENT_INVOICE_HISTORY
                  WHERE     Satust = 1
                            AND CreateDate BETWEEN @StarDay AND GETDATE()
                  GROUP BY  PaymentTypeID
                ) AS temp
    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifireToProduct]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Vu Pham>
-- Create date: <01/12/2015>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[pos_th_GetListModifireToProduct]
	-- Add the parameters for the stored procedure here
	@productID INT = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.MODIFIRE 
	Where Status = 1 and 
		  MODIFIRE.ModifireID IN (Select ModifireID
									  From dbo.MAP_MODIFIRE_TO_PRODUCT
									  Where ProductID = @productID
											and Status = 1)
END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifire]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pos_th_GetListModifire]
	-- Add the parameters for the stored procedure here
	@productID INT = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.MODIFIRE 
	Where Status = 1 and 
		  MODIFIRE.ModifireID NOT IN (Select ModifireID
									  From dbo.MAP_MODIFIRE_TO_PRODUCT
									  Where ProductID = @productID
											and Status = 1)
END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetDetailWeeklyReport]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[pos_th_GetDetailWeeklyReport] 
	@paymenttypeid INT =0  
AS
    BEGIN

        SET NOCOUNT ON;


		DECLARE @StarDay DATETIME= GETDATE();

        DECLARE @flag INT = 0;

        SELECT  @flag = ( 1 + ( ( 6 + DATEPART(dw, GETDATE()) + @@DATEFIRST ) % 7 ) );


        SELECT  @StarDay = CASE WHEN @flag = 1 THEN GETDATE() - 6
                                WHEN @flag = 2 THEN GETDATE()
                                WHEN @flag = 3 THEN GETDATE() - 1
                                WHEN @flag = 4 THEN GETDATE() - 2
                                WHEN @flag = 5 THEN GETDATE() - 3
                                WHEN @flag = 6 THEN GETDATE() - 4
                                WHEN @flag = 7 THEN GETDATE() - 5
                                ELSE GETDATE()
                           END

		SET @StarDay='12-21-2015'
		
        SELECT  i.InvoiceID ,
                i.InvoiceNumber ,
                i.OrderID ,
                PT.PaymentTypeName ,
                PIH.Total ,
                PIH.CreateDate,
				CONVERT(NVARCHAR(10),PIH.CreateDate,103) AS CreateDateString
        FROM    dbo.PAYMENT_INVOICE_HISTORY PIH
                INNER JOIN dbo.PAYMENT_TYPE PT ON PT.PaymentTypeID = PIH.PaymentTypeID
                INNER JOIN dbo.INVOICE i ON i.InvoiceID = PIH.InvoiceNumber
        WHERE   PIH.Satust = 1 AND (ISNULL(@paymenttypeid,0)=0 OR @paymenttypeid=PIH.PaymentTypeID)
				AND PIH.CreateDate BETWEEN @StarDay AND GETDATE()
        ORDER BY PIH.CreateDate ,
                pt.PaymentTypeName

    END
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetDetailDailyReport]    Script Date: 01/12/2016 17:06:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[pos_th_GetDetailDailyReport] 
	@paymenttypeid INT =0  
AS
    BEGIN

        SET NOCOUNT ON;

	
        SELECT  i.InvoiceID ,
                i.InvoiceNumber ,
                i.OrderID ,
                PT.PaymentTypeName ,
                PIH.Total ,
                PIH.CreateDate,
				CONVERT(NVARCHAR(10),PIH.CreateDate,103) AS CreateDateString
        FROM    dbo.PAYMENT_INVOICE_HISTORY PIH
                INNER JOIN dbo.PAYMENT_TYPE PT ON PT.PaymentTypeID = PIH.PaymentTypeID
                INNER JOIN dbo.INVOICE i ON i.InvoiceID = PIH.InvoiceNumber
        WHERE   PIH.Satust = 1 AND (ISNULL(@paymenttypeid,0)=0 OR @paymenttypeid=PIH.PaymentTypeID)
		AND CONVERT(NVARCHAR(10), GETDATE(), 103) = CONVERT(NVARCHAR(10), PIH.CreateDate, 103)
        ORDER BY PIH.CreateDate ,
                pt.PaymentTypeName

    END
GO
/****** Object:  Default [DF_CATALOGUE_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CATALOGUE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CATALOGUE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CATALOGUE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CATALOGUE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_CATEGORY_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CATEGORY_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CATEGORY_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CATEGORY_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CATEGORY_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_CLIENT_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CLIENT_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CLIENT_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CLIENT_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CLIENT_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_DEPARMENT_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_DEPARMENT_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_DEPARMENT_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_DEPARMENT_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_DEPARMENT_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_FLOOR_Priority]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_FLOOR_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_FLOOR_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_FLOOR_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_FLOOR_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_FLOOR_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_Satust]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_INVOICE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_OrderDetailID]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_OrderDetailID]  DEFAULT ((0)) FOR [OrderDetailID]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_Satust]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MENU_Priority]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_MENU_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MENU_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MENU_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MENU_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MENU_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MODIFIRE_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MODIFIRE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MODIFIRE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MODIFIRE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MODIFIRE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_ORDER_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDERDATE_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_ORDERDATE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDERDATE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDERDATE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDERDATE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_Satust]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_Satust]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_Satust]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_Satust]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PERMISSION_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PERMISSION_DeparmentID]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_DeparmentID]  DEFAULT ((0)) FOR [DepartmentID]
GO
/****** Object:  Default [DF_PERMISSION_SubMenuID]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_SubMenuID]  DEFAULT ((0)) FOR [SubMenuID]
GO
/****** Object:  Default [DF_PERMISSION_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PERMISSION_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PERMISSION_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PERMISSION_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PRODUCT_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PRODUCT_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PRODUCT_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PRODUCT_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PRODUCT_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_StartShift]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_StartShift]  DEFAULT (getdate()) FOR [StartShift]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_Status]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CashStart]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CashStart]  DEFAULT ((0)) FOR [CashStart]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CashEnd]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CashEnd]  DEFAULT ((0)) FOR [CashEnd]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_SafeDrop]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_SafeDrop]  DEFAULT ((0)) FOR [SafeDrop]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_STAFF_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_STAFF_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_STAFF_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_STAFF_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_STAFF_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_SUB_MENU_Priority]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_SUB_MENU_Status]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_SUB_MENU_CreateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_SUB_MENU_CreateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SUB_MENU_UpdateBy]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_SUB_MENU_UpdateDate]    Script Date: 01/12/2016 17:06:22 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
