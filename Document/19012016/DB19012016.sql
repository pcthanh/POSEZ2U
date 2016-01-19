USE [POSEZ2U]
GO
/****** Object:  Table [dbo].[FLOOR]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[DEPARTMENT] ([DepartmentID], [DepartmentName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Admin', 1, NULL, 0, CAST(0x0000A57B017D1BDC AS DateTime), 0, CAST(0x0000A57B017D1BDC AS DateTime))
INSERT [dbo].[DEPARTMENT] ([DepartmentID], [DepartmentName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Manager', 1, NULL, 0, CAST(0x0000A57B017D20B3 AS DateTime), 0, CAST(0x0000A57B017D20B3 AS DateTime))
INSERT [dbo].[DEPARTMENT] ([DepartmentID], [DepartmentName], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Staff', 1, NULL, 0, CAST(0x0000A57B017D2522 AS DateTime), 0, CAST(0x0000A57B017D2522 AS DateTime))
SET IDENTITY_INSERT [dbo].[DEPARTMENT] OFF
/****** Object:  Table [dbo].[CLIENT]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[CATEGORY] ([CategoryID], [CategoryName], [CategoryNameSort], [Status], [Color], [ProductColor], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (11, N'Uuu', N'Jj', 1, N'Brown', N'Aqua', N'', 1, CAST(0x0000A56C009A62F6 AS DateTime), 0, CAST(0x0000A56C009A62F6 AS DateTime))
SET IDENTITY_INSERT [dbo].[CATEGORY] OFF
/****** Object:  Table [dbo].[CATALOGUE]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Breakfast', 1, N'Green', N'', 0, CAST(0x0000A563016842F6 AS DateTime), 0, CAST(0x0000A563016842F6 AS DateTime))
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Lunch', 1, N'Blue', N'', 0, CAST(0x0000A563016850D7 AS DateTime), 0, CAST(0x0000A563016850D7 AS DateTime))
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Beverage', 1, N'CornflowerBlue', N'', 0, CAST(0x0000A56301686632 AS DateTime), 0, CAST(0x0000A56301686632 AS DateTime))
INSERT [dbo].[CATALOGUE] ([CatalogueID], [CatalogueName], [Status], [Color], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Dessert', 1, N'DarkMagenta', N'', 0, CAST(0x0000A56301687B5F AS DateTime), 0, CAST(0x0000A56301687B5F AS DateTime))
SET IDENTITY_INSERT [dbo].[CATALOGUE] OFF
/****** Object:  Table [dbo].[Card]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  UserDefinedFunction [dbo].[Auto_Create_Code]    Script Date: 01/19/2016 09:49:12 ******/
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
/****** Object:  Table [dbo].[PERMISSION]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (1, N'EAT IN', 1, 1, 1, 4, CAST(0x0000A57B0180DB4E AS DateTime), 4, CAST(0x0000A57B0180DB4E AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (2, N'TAKEAWAY', 1, 1, 2, 4, CAST(0x0000A57B0180DB4E AS DateTime), 4, CAST(0x0000A57B0180DB4E AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (3, N'STORE', 1, 1, 3, 4, CAST(0x0000A57B0180DB4E AS DateTime), 4, CAST(0x0000A57B0180DB4E AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (4, N'WORKING PERIOD', 1, 1, 4, 4, CAST(0x0000A57B0180DB4E AS DateTime), 4, CAST(0x0000A57B0180DB4E AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (5, N'REPORT', 1, 1, 5, 4, CAST(0x0000A57B0180DB4E AS DateTime), 4, CAST(0x0000A57B0180DB4E AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (6, N'SETTING', 1, 1, 6, 4, CAST(0x0000A57B0180DB4E AS DateTime), 4, CAST(0x0000A57B0180DB4E AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (7, N'EAT IN', 1, 2, 1, 4, CAST(0x0000A57B0180FE4A AS DateTime), 4, CAST(0x0000A57B0180FE4A AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (8, N'TAKEAWAY', 1, 2, 2, 4, CAST(0x0000A57B0180FE4A AS DateTime), 4, CAST(0x0000A57B0180FE4A AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (9, N'WORKING PERIOD', 1, 2, 4, 4, CAST(0x0000A57B0180FE4A AS DateTime), 4, CAST(0x0000A57B0180FE4A AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (10, N'REPORT', 1, 2, 5, 4, CAST(0x0000A57B0180FE4A AS DateTime), 4, CAST(0x0000A57B0180FE4A AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (11, N'EAT IN', 1, 3, 1, 4, CAST(0x0000A57B01811072 AS DateTime), 4, CAST(0x0000A57B01811072 AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (12, N'WORKING PERIOD', 1, 3, 4, 4, CAST(0x0000A57B01811072 AS DateTime), 4, CAST(0x0000A57B01811072 AS DateTime), N'')
INSERT [dbo].[PERMISSION] ([PermissionID], [PermissionName], [Status], [DepartmentID], [SubMenuID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (13, N'TAKEAWAY', 1, 3, 2, 4, CAST(0x0000A57B01811072 AS DateTime), 4, CAST(0x0000A57B01811072 AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[PERMISSION] OFF
/****** Object:  Table [dbo].[PAYMENT_TYPE]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[PAYMENT_INVOICE_HISTORY]    Script Date: 01/19/2016 09:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENT_INVOICE_HISTORY](
	[PaymentHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
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
/****** Object:  Table [dbo].[ORDER_OPEN_ITEM]    Script Date: 01/19/2016 09:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_OPEN_ITEM](
	[dynID] [int] IDENTITY(1,1) NOT NULL,
	[ItemNameShort] [nvarchar](50) NULL,
	[ItemNameDesc] [nvarchar](50) NULL,
	[UnitPrice] [int] NULL,
	[PrintType] [int] NULL,
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
SET IDENTITY_INSERT [dbo].[ORDER_OPEN_ITEM] ON
INSERT [dbo].[ORDER_OPEN_ITEM] ([dynID], [ItemNameShort], [ItemNameDesc], [UnitPrice], [PrintType], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'T', N'T', 10000, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[ORDER_OPEN_ITEM] ([dynID], [ItemNameShort], [ItemNameDesc], [UnitPrice], [PrintType], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Rr', N'Rr', 2000, 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ORDER_OPEN_ITEM] OFF
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE_DATE]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (1, 0, 1, 1, 1, 0, 0, 2000, NULL, 210000, 0, 2, 0, CAST(0x0000A592009E5588 AS DateTime), 0, CAST(0x0000A592009E5588 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] OFF
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[ORDER_DETAIL_DATE]    Script Date: 01/19/2016 09:49:11 ******/
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
	[PrintType] [int] NULL,
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
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [PrintType], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (1, 1, 1, 1, 0, 210000, 1, 210000, 0, 0, 2, 0, CAST(0x0000A592009E5586 AS DateTime), 0, CAST(0x0000A592009E5586 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [PrintType], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (2, 1, 0, 2, 0, 10000, 1, 10000, 0, 1, 1, 0, CAST(0x0000A592009E5586 AS DateTime), 0, CAST(0x0000A592009E5586 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [DynId], [PrintType], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (3, 1, 3, 3, 0, 32000, 1, 32000, 0, 0, 2, 0, CAST(0x0000A592009E5586 AS DateTime), 0, CAST(0x0000A592009E5586 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_DATE] OFF
/****** Object:  Table [dbo].[ORDER_DETAIL]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[ORDER_DATE]    Script Date: 01/19/2016 09:49:11 ******/
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
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
	[ShiftID] [int] NULL,
 CONSTRAINT [PK_ORDERDATE] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ORDER_DATE] ON
INSERT [dbo].[ORDER_DATE] ([OrderID], [OrderNumber], [ClientID], [FloorID], [Status], [TotalAmount], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note], [ShiftID]) VALUES (1, N'2', 0, N'16', 0, 252000, 0, 5, CAST(0x0000A592009E557C AS DateTime), 5, CAST(0x0000A592009E557D AS DateTime), N'', 14)
SET IDENTITY_INSERT [dbo].[ORDER_DATE] OFF
/****** Object:  Table [dbo].[ORDER]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[MODIFIRE_PRICE]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[MODIFIRE]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[MENU]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[MENU] ([MenuID], [MenuName], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'EAT IN', 1, 1, NULL, 0, CAST(0x0000A56D0129260B AS DateTime), 0, CAST(0x0000A56D0129260B AS DateTime))
INSERT [dbo].[MENU] ([MenuID], [MenuName], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'TAKEAWAY', 1, 1, NULL, 0, CAST(0x0000A56D012930A2 AS DateTime), 0, CAST(0x0000A56D012930A2 AS DateTime))
INSERT [dbo].[MENU] ([MenuID], [MenuName], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'STORE', 1, 1, NULL, 0, CAST(0x0000A56F0179E2D5 AS DateTime), 0, CAST(0x0000A56F0179E2D5 AS DateTime))
INSERT [dbo].[MENU] ([MenuID], [MenuName], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'WORKING PERIOD', 1, 1, NULL, 0, CAST(0x0000A56F017A02C4 AS DateTime), 0, CAST(0x0000A56F017A02C4 AS DateTime))
INSERT [dbo].[MENU] ([MenuID], [MenuName], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'REPORT', 1, 1, NULL, 0, CAST(0x0000A56F017A1232 AS DateTime), 0, CAST(0x0000A56F017A1232 AS DateTime))
INSERT [dbo].[MENU] ([MenuID], [MenuName], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, N'SETTING', 1, 1, NULL, 0, CAST(0x0000A56F017A1C50 AS DateTime), 0, CAST(0x0000A56F017A1C50 AS DateTime))
SET IDENTITY_INSERT [dbo].[MENU] OFF
/****** Object:  Table [dbo].[MAP_PRODUCT_TO_CATEGORY]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[MAP_MODIFIRE_TO_PRODUCT]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[MAP_CATEGORY_TO_CATALOGUE]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[INVOICE_DETAIL_MODIFIRE]    Script Date: 01/19/2016 09:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL_MODIFIRE](
	[InvoiceModifireID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[OrderModifireID] [int] NULL,
	[Satust] [int] NOT NULL,
	[ProductID] [int] NULL,
	[KeyModi] [int] NULL,
	[ModifireID] [int] NULL,
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
 CONSTRAINT [PK_INVOICE_DETAIL_MODIFIRE] PRIMARY KEY CLUSTERED 
(
	[InvoiceModifireID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVOICE_DETAIL]    Script Date: 01/19/2016 09:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL](
	[InvoiceDetailID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[OrderDetailID] [int] NULL,
	[KeyItem] [int] NULL,
	[Status] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[Seat] [int] NULL,
	[DynId] [int] NULL,
	[PrintType] [int] NULL,
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
/****** Object:  Table [dbo].[INVOICE_BY_CARD]    Script Date: 01/19/2016 09:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_BY_CARD](
	[InvoiceByCardID] [nvarchar](50) NOT NULL,
	[InvoiceID] [int] NULL,
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
/****** Object:  Table [dbo].[INVOICE]    Script Date: 01/19/2016 09:49:11 ******/
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
	[CashOut] [int] NULL,
	[Seat] [int] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
	[ShiftID] [int] NULL,
 CONSTRAINT [PK_INVOICE] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VOID_ITEM_HISTORY]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 4, 17, NULL, 14, 25000, NULL, 1, N'17', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 2, 15, NULL, 14, 25000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 2, 2, NULL, 14, 25000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 2, 21, NULL, 14, 45000, NULL, 1, N'15', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, 1, 9, NULL, 14, 34000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, 1, 8, NULL, 14, 30000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 3, 2, NULL, 14, 25000, NULL, 1, N'18', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, 2, 14, NULL, 14, 35000, NULL, 1, N'15', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, 1, 2, NULL, 14, 25000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 1, 1, NULL, 14, 210000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (11, 1, 3, NULL, 14, 32000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 1, 16, NULL, 14, 15000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (13, 1, 15, NULL, 14, 25000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (14, 4, 2, NULL, 14, 25000, NULL, 1, N'2', 0, CAST(0xEA3A0B00 AS Date), 0, CAST(0xEA3A0B00 AS Date))
INSERT [dbo].[VOID_ITEM_HISTORY] ([ID], [OrderID], [ProductID], [ModifireID], [ShiftID], [Total], [StaffID], [Qty], [FloorID], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (15, 11, 2, NULL, 14, 20000, NULL, 1, N'4', 0, CAST(0xEC3A0B00 AS Date), 0, CAST(0xEC3A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[VOID_ITEM_HISTORY] OFF
/****** Object:  UserDefinedTableType [dbo].[TableTemp]    Script Date: 01/19/2016 09:49:12 ******/
CREATE TYPE [dbo].[TableTemp] AS TABLE(
	[Value] [int] NULL
)
GO
/****** Object:  Table [dbo].[TableTemp]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[TableTemp] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [UserName]) VALUES (14, 5, N'Yyy', CAST(0x0000A58E00AAB406 AS DateTime), NULL, 1, 400, 0, 0, N'Thanh')
/****** Object:  Table [dbo].[SUB_MENU]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[SUB_MENU] ([SubMenuID], [SubMenuName], [MenuID], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'EAT IN', 1, 1, 1, NULL, 1, CAST(0x0000A56F01815C87 AS DateTime), 1, CAST(0x0000A56F01815C87 AS DateTime))
INSERT [dbo].[SUB_MENU] ([SubMenuID], [SubMenuName], [MenuID], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'TAKEAWAY', 2, 1, 1, NULL, 1, CAST(0x0000A56F01815C87 AS DateTime), 1, CAST(0x0000A56F01815C87 AS DateTime))
INSERT [dbo].[SUB_MENU] ([SubMenuID], [SubMenuName], [MenuID], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'STORE', 3, 1, 1, NULL, 1, CAST(0x0000A56F01815C87 AS DateTime), 1, CAST(0x0000A56F01815C87 AS DateTime))
INSERT [dbo].[SUB_MENU] ([SubMenuID], [SubMenuName], [MenuID], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'WORKING PERIOD', 4, 1, 1, NULL, 1, CAST(0x0000A56F01815C87 AS DateTime), 1, CAST(0x0000A56F01815C87 AS DateTime))
INSERT [dbo].[SUB_MENU] ([SubMenuID], [SubMenuName], [MenuID], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'REPORT', 5, 1, 1, NULL, 1, CAST(0x0000A56F01815C87 AS DateTime), 1, CAST(0x0000A56F01815C87 AS DateTime))
INSERT [dbo].[SUB_MENU] ([SubMenuID], [SubMenuName], [MenuID], [Priority], [Status], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, N'SETTING', 6, 1, 1, NULL, 1, CAST(0x0000A56F01815C87 AS DateTime), 1, CAST(0x0000A56F01815C87 AS DateTime))
SET IDENTITY_INSERT [dbo].[SUB_MENU] OFF
/****** Object:  Table [dbo].[STAFF]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[STAFF] ([StaffID], [UserName], [Password], [Status], [DepartmentID], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'Thien', N'c/sqqDQV2+7k55SNqqtpjQ==', 1, 1, N'Thien', N'Huynh', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, CAST(0x0000A56D0126DAE6 AS DateTime), 0, CAST(0x0000A56D0126DAE6 AS DateTime))
INSERT [dbo].[STAFF] ([StaffID], [UserName], [Password], [Status], [DepartmentID], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, N'Thanh', N'c/sqqDQV2+7k55SNqqtpjQ==', 1, 1, N'Thanh', N'Phan', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, CAST(0x0000A56D0127127B AS DateTime), 0, CAST(0x0000A56D0127127B AS DateTime))
INSERT [dbo].[STAFF] ([StaffID], [UserName], [Password], [Status], [DepartmentID], [Fname], [Lname], [Email], [Phone], [Adress1], [Adress2], [Adress3], [Country], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, N'Vu', N'gMo3uRgQdKaHeFC7n2KDbA==', 1, 3, N'Vu', N'Pham', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, CAST(0x0000A56D0127A89E AS DateTime), 0, CAST(0x0000A56D0127A89E AS DateTime))
SET IDENTITY_INSERT [dbo].[STAFF] OFF
/****** Object:  Table [dbo].[SHIFT_HISTORY]    Script Date: 01/19/2016 09:49:11 ******/
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
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 4, N'#1', CAST(0x0000A582012D027F AS DateTime), NULL, 2, 100.05, NULL, NULL, NULL, 4, CAST(0x0000A582012D027F AS DateTime), NULL, NULL)
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 5, N'#2', CAST(0x0000A582012FD5C5 AS DateTime), NULL, 2, 200, NULL, NULL, NULL, 4, CAST(0x0000A582012FD5C5 AS DateTime), NULL, NULL)
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 6, N'#3', CAST(0x0000A582012FF1D3 AS DateTime), NULL, 2, 300, NULL, NULL, NULL, 4, CAST(0x0000A582012FF1D3 AS DateTime), NULL, NULL)
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 4, N'#4', CAST(0x0000A58201451F7E AS DateTime), NULL, 2, 500, NULL, NULL, NULL, 4, CAST(0x0000A58201451F7E AS DateTime), NULL, NULL)
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, 4, N'5', CAST(0x0000A58201652FED AS DateTime), CAST(0x0000A5820175C3B0 AS DateTime), 2, 800.12, 800, 800, NULL, 4, CAST(0x0000A58201652FED AS DateTime), 4, CAST(0x0000A5820175C3B0 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, 4, N'6', CAST(0x0000A582016549DD AS DateTime), CAST(0x0000A582016FDBD0 AS DateTime), 2, 900, 123, 123, NULL, 4, CAST(0x0000A582016549DD AS DateTime), 4, CAST(0x0000A582016FDBD0 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 4, N'8', CAST(0x0000A58201760563 AS DateTime), CAST(0x0000A5830176802C AS DateTime), 2, 800, 800, 800, NULL, 4, CAST(0x0000A58201760563 AS DateTime), 4, CAST(0x0000A58301768031 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (8, 4, N'71', CAST(0x0000A582017641AC AS DateTime), CAST(0x0000A58301769C64 AS DateTime), 2, 812, 812, 0, NULL, 4, CAST(0x0000A582017641AC AS DateTime), 4, CAST(0x0000A58301769C64 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (9, 4, N'Shift_1', CAST(0x0000A58301730C4A AS DateTime), CAST(0x0000A583017591EF AS DateTime), 2, 100, 100, 100, NULL, 4, CAST(0x0000A58301730C4A AS DateTime), 4, CAST(0x0000A583017591EF AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (10, 4, N'1', CAST(0x0000A58701501653 AS DateTime), CAST(0x0000A587015061BE AS DateTime), 2, 100, 200, 0, NULL, 4, CAST(0x0000A58701501653 AS DateTime), 4, CAST(0x0000A587015061BE AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (11, 4, N'2', CAST(0x0000A5870150B31E AS DateTime), CAST(0x0000A5870154A601 AS DateTime), 2, 200, 300, 200, NULL, 4, CAST(0x0000A5870150B31E AS DateTime), 4, CAST(0x0000A5870154A601 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (12, 4, N'3', CAST(0x0000A5870156F0F0 AS DateTime), CAST(0x0000A58701576778 AS DateTime), 2, 300, 500, 200, NULL, 4, CAST(0x0000A5870156F0F0 AS DateTime), 4, CAST(0x0000A58701576778 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (13, 4, N'4', CAST(0x0000A58701581418 AS DateTime), CAST(0x0000A58E00931C57 AS DateTime), 2, 300, 500, 0, NULL, 4, CAST(0x0000A58701581418 AS DateTime), 5, CAST(0x0000A58E00931C57 AS DateTime))
INSERT [dbo].[SHIFT_HISTORY] ([ShiftHistoryID], [StaffID], [ShiftName], [StartShift], [EndShift], [Status], [CashStart], [CashEnd], [SafeDrop], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (14, 5, N'Yyy', CAST(0x0000A58E00AAB406 AS DateTime), NULL, 1, 400, NULL, NULL, NULL, 5, CAST(0x0000A58E00AAB407 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[SHIFT_HISTORY] OFF
/****** Object:  Table [dbo].[PRODUCT_PRICE]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 01/19/2016 09:49:11 ******/
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
/****** Object:  Table [dbo].[PRINTER]    Script Date: 01/19/2016 09:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRINTER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PrinterName] [nvarchar](250) NULL,
	[PrintName] [nvarchar](50) NULL,
	[PrinterType] [int] NULL,
	[Status] [int] NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_PRINTER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PRINTER] ON
INSERT [dbo].[PRINTER] ([ID], [PrinterName], [PrintName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, N'Microsoft XPS Document Writer', N'Payment', 1, 1, 5, CAST(0x0000A58F016F89A5 AS DateTime), 5, CAST(0x0000A5920092599C AS DateTime))
INSERT [dbo].[PRINTER] ([ID], [PrinterName], [PrintName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, N'Microsoft XPS Document Writer', N'Food Printer', 0, 1, 5, CAST(0x0000A58F0172675E AS DateTime), 5, CAST(0x0000A58F0173A3A9 AS DateTime))
INSERT [dbo].[PRINTER] ([ID], [PrinterName], [PrintName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, N'Send To OneNote 2013', N'Food Printer', 0, 0, 5, CAST(0x0000A58F01726C2E AS DateTime), 5, CAST(0x0000A58F0172BCE7 AS DateTime))
INSERT [dbo].[PRINTER] ([ID], [PrinterName], [PrintName], [PrinterType], [Status], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, N'80 Printer', N'Beverage Printer', 0, 1, 5, CAST(0x0000A58F0172EE02 AS DateTime), 0, CAST(0x0000A58F0172EE02 AS DateTime))
SET IDENTITY_INSERT [dbo].[PRINTER] OFF
/****** Object:  Table [dbo].[PRINTE_JOB_DETAIL]    Script Date: 01/19/2016 09:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRINTE_JOB_DETAIL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PrinteJobID] [int] NOT NULL,
	[CategoryID] [int] NULL,
	[ProductID] [int] NULL,
	[PrinterID] [int] NULL,
	[TemplatesID] [int] NULL,
	[Status] [int] NULL,
	[Notes] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_PRINTE_JOB_DETAIL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PRINTE_JOB_DETAIL] ON
INSERT [dbo].[PRINTE_JOB_DETAIL] ([ID], [PrinteJobID], [CategoryID], [ProductID], [PrinterID], [TemplatesID], [Status], [Notes], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (1, 1, 1, 0, 2, 1, 1, N'', 5, CAST(0x0000A58F017322F5 AS DateTime), NULL, NULL)
INSERT [dbo].[PRINTE_JOB_DETAIL] ([ID], [PrinteJobID], [CategoryID], [ProductID], [PrinterID], [TemplatesID], [Status], [Notes], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (2, 1, 2, 0, 2, 1, 1, N'', 5, CAST(0x0000A58F017322F9 AS DateTime), NULL, NULL)
INSERT [dbo].[PRINTE_JOB_DETAIL] ([ID], [PrinteJobID], [CategoryID], [ProductID], [PrinterID], [TemplatesID], [Status], [Notes], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (3, 1, 3, 0, 2, 1, 1, N'', 5, CAST(0x0000A58F017322F9 AS DateTime), NULL, NULL)
INSERT [dbo].[PRINTE_JOB_DETAIL] ([ID], [PrinteJobID], [CategoryID], [ProductID], [PrinterID], [TemplatesID], [Status], [Notes], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (4, 2, 4, 18, 4, 1, 1, N'', 5, CAST(0x0000A58F01735D3C AS DateTime), 5, CAST(0x0000A58F01759E64 AS DateTime))
INSERT [dbo].[PRINTE_JOB_DETAIL] ([ID], [PrinteJobID], [CategoryID], [ProductID], [PrinterID], [TemplatesID], [Status], [Notes], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (5, 2, 5, 0, 4, 1, 1, N'', 5, CAST(0x0000A58F01735D3D AS DateTime), 5, CAST(0x0000A58F01759E66 AS DateTime))
INSERT [dbo].[PRINTE_JOB_DETAIL] ([ID], [PrinteJobID], [CategoryID], [ProductID], [PrinterID], [TemplatesID], [Status], [Notes], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (6, 2, 4, 19, 2, 1, 1, N'', 5, CAST(0x0000A58F01735D3E AS DateTime), 5, CAST(0x0000A58F01759E67 AS DateTime))
INSERT [dbo].[PRINTE_JOB_DETAIL] ([ID], [PrinteJobID], [CategoryID], [ProductID], [PrinterID], [TemplatesID], [Status], [Notes], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate]) VALUES (7, 2, 4, 19, 4, 1, 1, N'', 5, CAST(0x0000A58F01759E67 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[PRINTE_JOB_DETAIL] OFF
/****** Object:  Table [dbo].[PRINT_JOB]    Script Date: 01/19/2016 09:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRINT_JOB](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PrintJobName] [nvarchar](500) NULL,
	[PrintContent] [nvarchar](500) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_PRINT_JOB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PRINT_JOB] ON
INSERT [dbo].[PRINT_JOB] ([ID], [PrintJobName], [PrintContent], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Status]) VALUES (1, N'Bar', N'All Lines', NULL, 5, CAST(0x0000A58F017322E9 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[PRINT_JOB] ([ID], [PrintJobName], [PrintContent], [Note], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Status]) VALUES (2, N'Kitchen', N'All Lines', NULL, 5, CAST(0x0000A58F01735D3A AS DateTime), 5, CAST(0x0000A58F01759E36 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[PRINT_JOB] OFF
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataPermissionByDepartmet]    Script Date: 01/19/2016 09:49:10 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapProductToCategory]    Script Date: 01/19/2016 09:49:10 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapModifireToProduct]    Script Date: 01/19/2016 09:49:10 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapCategoryToCatalogue]    Script Date: 01/19/2016 09:49:09 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetWeeklySaleReport]    Script Date: 01/19/2016 09:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<thien huynh>
-- Create date: <27/12/2015>
-- Description:	<Weekly Sale Report>
-- =============================================


--  EXEC pos_th_GetWeeklySaleReport


CREATE PROCEDURE [dbo].[pos_th_GetWeeklySaleReport]
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifireToProduct]    Script Date: 01/19/2016 09:49:09 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifire]    Script Date: 01/19/2016 09:49:09 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetDetailWeeklyReport]    Script Date: 01/19/2016 09:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Thien Huynh>
-- Create date: <27/12/2015>
-- Description:	<Get Detail  Weekly Report>
-- =============================================


--  EXEC pos_th_GetDetailWeeklyReport @paymenttypeid=1

CREATE PROCEDURE [dbo].[pos_th_GetDetailWeeklyReport] 
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetDetailDailyReport]    Script Date: 01/19/2016 09:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Thien Huynh>
-- Create date: <27/12/2015>
-- Description:	<Get Detail  Daily Report>
-- =============================================


--  EXEC pos_th_GetDetailDailyReport @paymenttypeid=3

CREATE PROCEDURE [dbo].[pos_th_GetDetailDailyReport] 
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetDataListShiftHistoryByUserID]    Script Date: 01/19/2016 09:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Thien Huynh>
-- Create date: <03/01/2016>
-- Description:	<get list Shift History>
-- =============================================

--  EXEC pos_th_GetDataListShiftHistoryByUserID @userid=4,@type=1

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
/****** Object:  StoredProcedure [dbo].[pos_th_GetDailySaleReport]    Script Date: 01/19/2016 09:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<thien huynh>
-- Create date: <27/12/2015>
-- Description:	<Daily Sale Report>
-- =============================================

-- EXEC pos_th_GetDailySaleReport


CREATE PROCEDURE [dbo].[pos_th_GetDailySaleReport]
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListProductByCategory]    Script Date: 01/19/2016 09:49:09 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListPermissionByDepartmentID]    Script Date: 01/19/2016 09:49:09 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListCategoryByCatalogue]    Script Date: 01/19/2016 09:49:09 ******/
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
/****** Object:  StoredProcedure [dbo].[getProductByCategory]    Script Date: 01/19/2016 09:49:09 ******/
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
/****** Object:  StoredProcedure [dbo].[getModifireByProduct]    Script Date: 01/19/2016 09:49:09 ******/
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
/****** Object:  Default [DF_CATALOGUE_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CATALOGUE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CATALOGUE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CATALOGUE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CATALOGUE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_CATEGORY_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CATEGORY_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CATEGORY_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CATEGORY_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CATEGORY_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_CLIENT_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CLIENT_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CLIENT_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CLIENT_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CLIENT_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_DEPARMENT_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_DEPARMENT_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_DEPARMENT_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_DEPARMENT_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_DEPARMENT_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_FLOOR_Priority]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_FLOOR_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_FLOOR_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_FLOOR_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_FLOOR_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_FLOOR_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_Satust]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_INVOICE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_OrderDetailID]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_OrderDetailID]  DEFAULT ((0)) FOR [OrderDetailID]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_Satust]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MENU_Priority]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_MENU_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MENU_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MENU_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MENU_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MENU_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MODIFIRE_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MODIFIRE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MODIFIRE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MODIFIRE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MODIFIRE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_ORDER_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDERDATE_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_ORDERDATE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDERDATE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDERDATE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDERDATE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_Satust]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_Satust]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_Satust]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_Satust]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PERMISSION_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PERMISSION_DeparmentID]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_DeparmentID]  DEFAULT ((0)) FOR [DepartmentID]
GO
/****** Object:  Default [DF_PERMISSION_SubMenuID]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_SubMenuID]  DEFAULT ((0)) FOR [SubMenuID]
GO
/****** Object:  Default [DF_PERMISSION_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PERMISSION_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PERMISSION_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PERMISSION_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_PrinteJobID]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_PrinteJobID]  DEFAULT ((0)) FOR [PrinteJobID]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_CategoryID]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_CategoryID]  DEFAULT ((0)) FOR [CategoryID]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_ProductID]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_ProductID]  DEFAULT ((0)) FOR [ProductID]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_PrinterID]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_PrinterID]  DEFAULT ((0)) FOR [PrinterID]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_TemplatesID]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_TemplatesID]  DEFAULT ((0)) FOR [TemplatesID]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_Status]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PRINTE_JOB_DETAIL_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTE_JOB_DETAIL] ADD  CONSTRAINT [DF_PRINTE_JOB_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PRINTER_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTER] ADD  CONSTRAINT [DF_PRINTER_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PRINTER_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTER] ADD  CONSTRAINT [DF_PRINTER_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PRINTER_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTER] ADD  CONSTRAINT [DF_PRINTER_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PRINTER_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRINTER] ADD  CONSTRAINT [DF_PRINTER_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PRODUCT_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PRODUCT_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PRODUCT_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PRODUCT_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PRODUCT_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_StartShift]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_StartShift]  DEFAULT (getdate()) FOR [StartShift]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_Status]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CashStart]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CashStart]  DEFAULT ((0)) FOR [CashStart]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CashEnd]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CashEnd]  DEFAULT ((0)) FOR [CashEnd]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_SafeDrop]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_SafeDrop]  DEFAULT ((0)) FOR [SafeDrop]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_STAFF_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_STAFF_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_STAFF_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_STAFF_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_STAFF_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_SUB_MENU_Priority]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_SUB_MENU_Status]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_SUB_MENU_CreateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_SUB_MENU_CreateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SUB_MENU_UpdateBy]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_SUB_MENU_UpdateDate]    Script Date: 01/19/2016 09:49:11 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
