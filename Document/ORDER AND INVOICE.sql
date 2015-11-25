USE [POSEZ2U]
GO
/****** Object:  Table [dbo].[INVOICE]    Script Date: 11/25/2015 9:09:18 PM ******/
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
	[CreateBy] [int] NULL,
	[CreateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_INVOICE] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVOICE_DETAIL]    Script Date: 11/25/2015 9:09:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL](
	[InvoiceDetailID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[OrderDetailID] [int] NULL,
	[Status] [int] NOT NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[INVOICE_DETAIL_MODIFIRE]    Script Date: 11/25/2015 9:09:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL_MODIFIRE](
	[InvoiceModifireID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceDetailID] [int] NOT NULL,
	[OrderModifireID] [int] NULL,
	[Satust] [int] NOT NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDER]    Script Date: 11/25/2015 9:09:18 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDER_DATE]    Script Date: 11/25/2015 9:09:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DATE](
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
 CONSTRAINT [PK_ORDERDATE] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDER_DETAIL]    Script Date: 11/25/2015 9:09:18 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDER_DETAIL_DATE]    Script Date: 11/25/2015 9:09:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL_DATE](
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
 CONSTRAINT [PK_ORDER_DETAIL_DATE] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE]    Script Date: 11/25/2015 9:09:18 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE_DATE]    Script Date: 11/25/2015 9:09:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE](
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
 CONSTRAINT [PK_ORDER_DETAIL_MODIFIRE_DATE] PRIMARY KEY CLUSTERED 
(
	[OrderModifireID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PAYMENT_INVOICE_HISTORY]    Script Date: 11/25/2015 9:09:18 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[INVOICE] ADD  CONSTRAINT [DF_INVOICE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_OrderDetailID]  DEFAULT ((0)) FOR [OrderDetailID]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] ADD  CONSTRAINT [DF_INVOICE_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[ORDER] ADD  CONSTRAINT [DF_ORDER_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DATE] ADD  CONSTRAINT [DF_ORDERDATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_Satust]  DEFAULT ((1)) FOR [Satust]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] ADD  CONSTRAINT [DF_ORDER_DETAIL_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]  DEFAULT ((1)) FOR [Satust]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ADD  CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_Satust]  DEFAULT ((1)) FOR [Satust]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] ADD  CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
