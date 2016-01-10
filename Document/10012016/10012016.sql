USE [POSEZ2U]
GO
/****** Object:  UserDefinedTableType [dbo].[TableTemp]    Script Date: 01/10/2016 23:02:27 ******/
CREATE TYPE [dbo].[TableTemp] AS TABLE(
	[Value] [int] NULL
)
GO
/****** Object:  Table [dbo].[TableTemp]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[SUB_MENU]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[STAFF]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[SHIFT_HISTORY]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[PRODUCT_PRICE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[PRINTER]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[FLOOR]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[CLIENT]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[CATALOGUE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[Card]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  UserDefinedFunction [dbo].[Auto_Create_Code]    Script Date: 01/10/2016 23:02:27 ******/
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
/****** Object:  Table [dbo].[PERMISSION]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[PAYMENT_TYPE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[PAYMENT_INVOICE_HISTORY]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[ORDER_OPEN_ITEM]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE_DATE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[ORDER_DETAIL_DATE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[ORDER_DETAIL]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[ORDER_DATE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[ORDER]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[MODIFIRE_PRICE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[MODIFIRE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[MENU]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[MAP_PRODUCT_TO_CATEGORY]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[MAP_MODIFIRE_TO_PRODUCT]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[MAP_CATEGORY_TO_CATALOGUE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[INVOICE_DETAIL_MODIFIRE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[INVOICE_DETAIL]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[INVOICE_BY_CARD]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  Table [dbo].[INVOICE]    Script Date: 01/10/2016 23:02:26 ******/
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
/****** Object:  StoredProcedure [dbo].[getProductByCategory]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[getModifireByProduct]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetDataListShiftHistoryByUserID]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetDailySaleReport]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListProductByCategory]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListPermissionByDepartmentID]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListCategoryByCatalogue]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataPermissionByDepartmet]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapProductToCategory]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapModifireToProduct]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapCategoryToCatalogue]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetWeeklySaleReport]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifireToProduct]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifire]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetDetailWeeklyReport]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetDetailDailyReport]    Script Date: 01/10/2016 23:02:24 ******/
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
/****** Object:  Default [DF_CATALOGUE_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CATALOGUE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CATALOGUE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CATALOGUE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CATALOGUE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATALOGUE] ADD  CONSTRAINT [DF_CATALOGUE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_CATEGORY_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CATEGORY_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CATEGORY_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CATEGORY_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CATEGORY_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CATEGORY] ADD  CONSTRAINT [DF_CATEGORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_CLIENT_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_CLIENT_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_CLIENT_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_CLIENT_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_CLIENT_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[CLIENT] ADD  CONSTRAINT [DF_CLIENT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_DEPARMENT_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_DEPARMENT_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_DEPARMENT_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_DEPARMENT_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_DEPARMENT_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[DEPARTMENT] ADD  CONSTRAINT [DF_DEPARMENT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_FLOOR_Priority]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_FLOOR_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_FLOOR_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_FLOOR_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_FLOOR_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_FLOOR_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[FLOOR] ADD  CONSTRAINT [DF_FLOOR_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_Satust]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_INVOICE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_BY_CARD_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_BY_CARD] ADD  CONSTRAINT [DF_INVOICE_BY_CARD_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_OrderDetailID]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_OrderDetailID]  DEFAULT ((0)) FOR [OrderDetailID]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_Satust]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] ADD  CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] ADD  CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MAP_PRODUCT_TO_CATEGORY_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] ADD  CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MENU_Priority]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_MENU_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MENU_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MENU_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MENU_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MENU_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MENU] ADD  CONSTRAINT [DF_MENU_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MODIFIRE_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MODIFIRE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MODIFIRE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MODIFIRE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MODIFIRE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE] ADD  CONSTRAINT [DF_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_MODIFIRE_PRICE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] ADD  CONSTRAINT [DF_MODIFIRE_PRICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_ORDER_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDERDATE_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_ORDERDATE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDERDATE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDERDATE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDERDATE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_Satust]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_Satust]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_DATE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_Satust]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_Satust]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_Satust]  DEFAULT ((1)) FOR [Satust]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PAYMENT_TYPE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] ADD  CONSTRAINT [DF_PAYMENT_TYPE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PERMISSION_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PERMISSION_DeparmentID]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_DeparmentID]  DEFAULT ((0)) FOR [DepartmentID]
GO
/****** Object:  Default [DF_PERMISSION_SubMenuID]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_SubMenuID]  DEFAULT ((0)) FOR [SubMenuID]
GO
/****** Object:  Default [DF_PERMISSION_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PERMISSION_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PERMISSION_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PERMISSION_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PERMISSION] ADD  CONSTRAINT [DF_PERMISSION_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PRODUCT_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PRODUCT_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PRODUCT_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PRODUCT_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PRODUCT_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_PRODUCT_PRICE_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] ADD  CONSTRAINT [DF_PRODUCT_PRICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_StartShift]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_StartShift]  DEFAULT (getdate()) FOR [StartShift]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_Status]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CashStart]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CashStart]  DEFAULT ((0)) FOR [CashStart]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CashEnd]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CashEnd]  DEFAULT ((0)) FOR [CashEnd]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_SafeDrop]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_SafeDrop]  DEFAULT ((0)) FOR [SafeDrop]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_SHIFT_HISTORY_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] ADD  CONSTRAINT [DF_SHIFT_HISTORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_STAFF_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_STAFF_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_STAFF_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_STAFF_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_STAFF_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
/****** Object:  Default [DF_SUB_MENU_Priority]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_Priority]  DEFAULT ((0)) FOR [Priority]
GO
/****** Object:  Default [DF_SUB_MENU_Status]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_SUB_MENU_CreateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
/****** Object:  Default [DF_SUB_MENU_CreateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
/****** Object:  Default [DF_SUB_MENU_UpdateBy]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
/****** Object:  Default [DF_SUB_MENU_UpdateDate]    Script Date: 01/10/2016 23:02:26 ******/
ALTER TABLE [dbo].[SUB_MENU] ADD  CONSTRAINT [DF_SUB_MENU_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
