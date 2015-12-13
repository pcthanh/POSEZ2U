USE [POSEZ2U]
GO
/****** Object:  StoredProcedure [dbo].[getModifireByProduct]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[getModifireByProduct]
GO
/****** Object:  StoredProcedure [dbo].[getProductByCategory]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[getProductByCategory]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListCategoryByCatalogue]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_GetAllListCategoryByCatalogue]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListPermissionByDepartmentID]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_GetAllListPermissionByDepartmentID]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListProductByCategory]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_GetAllListProductByCategory]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifire]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_GetListModifire]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifireToProduct]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_GetListModifireToProduct]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapCategoryToCatalogue]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_SaveDataMapCategoryToCatalogue]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapModifireToProduct]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_SaveDataMapModifireToProduct]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapProductToCategory]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_SaveDataMapProductToCategory]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataPermissionByDepartmet]    Script Date: 12/13/2015 22:57:31 ******/
DROP PROCEDURE [dbo].[pos_th_SaveDataPermissionByDepartmet]
GO
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 12/13/2015 22:57:35 ******/
ALTER TABLE [dbo].[PRODUCT] DROP CONSTRAINT [DF_PRODUCT_Status]
GO
ALTER TABLE [dbo].[PRODUCT] DROP CONSTRAINT [DF_PRODUCT_CreateBy]
GO
ALTER TABLE [dbo].[PRODUCT] DROP CONSTRAINT [DF_PRODUCT_CreateDate]
GO
ALTER TABLE [dbo].[PRODUCT] DROP CONSTRAINT [DF_PRODUCT_UpdateBy]
GO
ALTER TABLE [dbo].[PRODUCT] DROP CONSTRAINT [DF_PRODUCT_UpdateDate]
GO
DROP TABLE [dbo].[PRODUCT]
GO
/****** Object:  Table [dbo].[PRODUCT_PRICE]    Script Date: 12/13/2015 22:57:35 ******/
ALTER TABLE [dbo].[PRODUCT_PRICE] DROP CONSTRAINT [DF_PRODUCT_PRICE_Status]
GO
ALTER TABLE [dbo].[PRODUCT_PRICE] DROP CONSTRAINT [DF_PRODUCT_PRICE_CreateBy]
GO
ALTER TABLE [dbo].[PRODUCT_PRICE] DROP CONSTRAINT [DF_PRODUCT_PRICE_CreateDate]
GO
ALTER TABLE [dbo].[PRODUCT_PRICE] DROP CONSTRAINT [DF_PRODUCT_PRICE_UpdateBy]
GO
ALTER TABLE [dbo].[PRODUCT_PRICE] DROP CONSTRAINT [DF_PRODUCT_PRICE_UpdateDate]
GO
DROP TABLE [dbo].[PRODUCT_PRICE]
GO
/****** Object:  Table [dbo].[SHIFT_HISTORY]    Script Date: 12/13/2015 22:57:35 ******/
ALTER TABLE [dbo].[SHIFT_HISTORY] DROP CONSTRAINT [DF_SHIFT_HISTORY_StartShift]
GO
ALTER TABLE [dbo].[SHIFT_HISTORY] DROP CONSTRAINT [DF_SHIFT_HISTORY_Status]
GO
ALTER TABLE [dbo].[SHIFT_HISTORY] DROP CONSTRAINT [DF_SHIFT_HISTORY_Total]
GO
ALTER TABLE [dbo].[SHIFT_HISTORY] DROP CONSTRAINT [DF_SHIFT_HISTORY_CreateBy]
GO
ALTER TABLE [dbo].[SHIFT_HISTORY] DROP CONSTRAINT [DF_SHIFT_HISTORY_CreateDate]
GO
ALTER TABLE [dbo].[SHIFT_HISTORY] DROP CONSTRAINT [DF_SHIFT_HISTORY_UpdateBy]
GO
ALTER TABLE [dbo].[SHIFT_HISTORY] DROP CONSTRAINT [DF_SHIFT_HISTORY_UpdateDate]
GO
DROP TABLE [dbo].[SHIFT_HISTORY]
GO
/****** Object:  Table [dbo].[STAFF]    Script Date: 12/13/2015 22:57:35 ******/
ALTER TABLE [dbo].[STAFF] DROP CONSTRAINT [DF_STAFF_Status]
GO
ALTER TABLE [dbo].[STAFF] DROP CONSTRAINT [DF_STAFF_CreateBy]
GO
ALTER TABLE [dbo].[STAFF] DROP CONSTRAINT [DF_STAFF_CreateDate]
GO
ALTER TABLE [dbo].[STAFF] DROP CONSTRAINT [DF_STAFF_UpdateBy]
GO
ALTER TABLE [dbo].[STAFF] DROP CONSTRAINT [DF_STAFF_UpdateDate]
GO
DROP TABLE [dbo].[STAFF]
GO
/****** Object:  Table [dbo].[SUB_MENU]    Script Date: 12/13/2015 22:57:35 ******/
ALTER TABLE [dbo].[SUB_MENU] DROP CONSTRAINT [DF_SUB_MENU_Priority]
GO
ALTER TABLE [dbo].[SUB_MENU] DROP CONSTRAINT [DF_SUB_MENU_Status]
GO
ALTER TABLE [dbo].[SUB_MENU] DROP CONSTRAINT [DF_SUB_MENU_CreateBy]
GO
ALTER TABLE [dbo].[SUB_MENU] DROP CONSTRAINT [DF_SUB_MENU_CreateDate]
GO
ALTER TABLE [dbo].[SUB_MENU] DROP CONSTRAINT [DF_SUB_MENU_UpdateBy]
GO
ALTER TABLE [dbo].[SUB_MENU] DROP CONSTRAINT [DF_SUB_MENU_UpdateDate]
GO
DROP TABLE [dbo].[SUB_MENU]
GO
/****** Object:  UserDefinedTableType [dbo].[TableTemp]    Script Date: 12/13/2015 22:57:35 ******/
DROP TYPE [dbo].[TableTemp]
GO
/****** Object:  Table [dbo].[CATALOGUE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[CATALOGUE] DROP CONSTRAINT [DF_CATALOGUE_Status]
GO
ALTER TABLE [dbo].[CATALOGUE] DROP CONSTRAINT [DF_CATALOGUE_CreateBy]
GO
ALTER TABLE [dbo].[CATALOGUE] DROP CONSTRAINT [DF_CATALOGUE_CreateDate]
GO
ALTER TABLE [dbo].[CATALOGUE] DROP CONSTRAINT [DF_CATALOGUE_UpdateBy]
GO
ALTER TABLE [dbo].[CATALOGUE] DROP CONSTRAINT [DF_CATALOGUE_UpdateDate]
GO
DROP TABLE [dbo].[CATALOGUE]
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[CATEGORY] DROP CONSTRAINT [DF_CATEGORY_Status]
GO
ALTER TABLE [dbo].[CATEGORY] DROP CONSTRAINT [DF_CATEGORY_CreateBy]
GO
ALTER TABLE [dbo].[CATEGORY] DROP CONSTRAINT [DF_CATEGORY_CreateDate]
GO
ALTER TABLE [dbo].[CATEGORY] DROP CONSTRAINT [DF_CATEGORY_UpdateBy]
GO
ALTER TABLE [dbo].[CATEGORY] DROP CONSTRAINT [DF_CATEGORY_UpdateDate]
GO
DROP TABLE [dbo].[CATEGORY]
GO
/****** Object:  Table [dbo].[CLIENT]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[CLIENT] DROP CONSTRAINT [DF_CLIENT_Status]
GO
ALTER TABLE [dbo].[CLIENT] DROP CONSTRAINT [DF_CLIENT_CreateBy]
GO
ALTER TABLE [dbo].[CLIENT] DROP CONSTRAINT [DF_CLIENT_CreateDate]
GO
ALTER TABLE [dbo].[CLIENT] DROP CONSTRAINT [DF_CLIENT_UpdateBy]
GO
ALTER TABLE [dbo].[CLIENT] DROP CONSTRAINT [DF_CLIENT_UpdateDate]
GO
DROP TABLE [dbo].[CLIENT]
GO
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[DEPARTMENT] DROP CONSTRAINT [DF_DEPARMENT_Status]
GO
ALTER TABLE [dbo].[DEPARTMENT] DROP CONSTRAINT [DF_DEPARMENT_CreateBy]
GO
ALTER TABLE [dbo].[DEPARTMENT] DROP CONSTRAINT [DF_DEPARMENT_CreateDate]
GO
ALTER TABLE [dbo].[DEPARTMENT] DROP CONSTRAINT [DF_DEPARMENT_UpdateBy]
GO
ALTER TABLE [dbo].[DEPARTMENT] DROP CONSTRAINT [DF_DEPARMENT_UpdateDate]
GO
DROP TABLE [dbo].[DEPARTMENT]
GO
/****** Object:  Table [dbo].[FLOOR]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[FLOOR] DROP CONSTRAINT [DF_FLOOR_Priority]
GO
ALTER TABLE [dbo].[FLOOR] DROP CONSTRAINT [DF_FLOOR_Status]
GO
ALTER TABLE [dbo].[FLOOR] DROP CONSTRAINT [DF_FLOOR_CreateBy]
GO
ALTER TABLE [dbo].[FLOOR] DROP CONSTRAINT [DF_FLOOR_CreateDate]
GO
ALTER TABLE [dbo].[FLOOR] DROP CONSTRAINT [DF_FLOOR_UpdateBy]
GO
ALTER TABLE [dbo].[FLOOR] DROP CONSTRAINT [DF_FLOOR_UpdateDate]
GO
DROP TABLE [dbo].[FLOOR]
GO
/****** Object:  Table [dbo].[INVOICE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[INVOICE] DROP CONSTRAINT [DF_INVOICE_Satust]
GO
ALTER TABLE [dbo].[INVOICE] DROP CONSTRAINT [DF_INVOICE_CreateBy]
GO
ALTER TABLE [dbo].[INVOICE] DROP CONSTRAINT [DF_INVOICE_CreateDate]
GO
ALTER TABLE [dbo].[INVOICE] DROP CONSTRAINT [DF_INVOICE_UpdateBy]
GO
ALTER TABLE [dbo].[INVOICE] DROP CONSTRAINT [DF_INVOICE_UpdateDate]
GO
DROP TABLE [dbo].[INVOICE]
GO
/****** Object:  Table [dbo].[INVOICE_DETAIL]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL] DROP CONSTRAINT [DF_INVOICE_DETAIL_OrderDetailID]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] DROP CONSTRAINT [DF_INVOICE_DETAIL_Status]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] DROP CONSTRAINT [DF_INVOICE_DETAIL_CreateBy]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] DROP CONSTRAINT [DF_INVOICE_DETAIL_CreateDate]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] DROP CONSTRAINT [DF_INVOICE_DETAIL_UpdateBy]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL] DROP CONSTRAINT [DF_INVOICE_DETAIL_UpdateDate]
GO
DROP TABLE [dbo].[INVOICE_DETAIL]
GO
/****** Object:  Table [dbo].[INVOICE_DETAIL_MODIFIRE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_Satust]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]
GO
ALTER TABLE [dbo].[INVOICE_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]
GO
DROP TABLE [dbo].[INVOICE_DETAIL_MODIFIRE]
GO
/****** Object:  Table [dbo].[MAP_CATEGORY_TO_CATALOGUE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] DROP CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_Status]
GO
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] DROP CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateBy]
GO
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] DROP CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateDate]
GO
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] DROP CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateBy]
GO
ALTER TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE] DROP CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateDate]
GO
DROP TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE]
GO
/****** Object:  Table [dbo].[MAP_MODIFIRE_TO_PRODUCT]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] DROP CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_Status]
GO
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] DROP CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateBy]
GO
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] DROP CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateDate]
GO
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] DROP CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateBy]
GO
ALTER TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT] DROP CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateDate]
GO
DROP TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT]
GO
/****** Object:  Table [dbo].[MAP_PRODUCT_TO_CATEGORY]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] DROP CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_Status]
GO
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] DROP CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateBy]
GO
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] DROP CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateDate]
GO
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] DROP CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateBy]
GO
ALTER TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY] DROP CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateDate]
GO
DROP TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY]
GO
/****** Object:  Table [dbo].[MENU]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[MENU] DROP CONSTRAINT [DF_MENU_Priority]
GO
ALTER TABLE [dbo].[MENU] DROP CONSTRAINT [DF_MENU_Status]
GO
ALTER TABLE [dbo].[MENU] DROP CONSTRAINT [DF_MENU_CreateBy]
GO
ALTER TABLE [dbo].[MENU] DROP CONSTRAINT [DF_MENU_CreateDate]
GO
ALTER TABLE [dbo].[MENU] DROP CONSTRAINT [DF_MENU_UpdateBy]
GO
ALTER TABLE [dbo].[MENU] DROP CONSTRAINT [DF_MENU_UpdateDate]
GO
DROP TABLE [dbo].[MENU]
GO
/****** Object:  Table [dbo].[MODIFIRE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[MODIFIRE] DROP CONSTRAINT [DF_MODIFIRE_Status]
GO
ALTER TABLE [dbo].[MODIFIRE] DROP CONSTRAINT [DF_MODIFIRE_CreateBy]
GO
ALTER TABLE [dbo].[MODIFIRE] DROP CONSTRAINT [DF_MODIFIRE_CreateDate]
GO
ALTER TABLE [dbo].[MODIFIRE] DROP CONSTRAINT [DF_MODIFIRE_UpdateBy]
GO
ALTER TABLE [dbo].[MODIFIRE] DROP CONSTRAINT [DF_MODIFIRE_UpdateDate]
GO
DROP TABLE [dbo].[MODIFIRE]
GO
/****** Object:  Table [dbo].[MODIFIRE_PRICE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[MODIFIRE_PRICE] DROP CONSTRAINT [DF_MODIFIRE_PRICE_Status]
GO
ALTER TABLE [dbo].[MODIFIRE_PRICE] DROP CONSTRAINT [DF_MODIFIRE_PRICE_CreateBy]
GO
ALTER TABLE [dbo].[MODIFIRE_PRICE] DROP CONSTRAINT [DF_MODIFIRE_PRICE_CreateDate]
GO
ALTER TABLE [dbo].[MODIFIRE_PRICE] DROP CONSTRAINT [DF_MODIFIRE_PRICE_UpdateBy]
GO
ALTER TABLE [dbo].[MODIFIRE_PRICE] DROP CONSTRAINT [DF_MODIFIRE_PRICE_UpdateDate]
GO
DROP TABLE [dbo].[MODIFIRE_PRICE]
GO
/****** Object:  Table [dbo].[ORDER]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[ORDER] DROP CONSTRAINT [DF_ORDER_Status]
GO
ALTER TABLE [dbo].[ORDER] DROP CONSTRAINT [DF_ORDER_CreateBy]
GO
ALTER TABLE [dbo].[ORDER] DROP CONSTRAINT [DF_ORDER_CreateDate]
GO
ALTER TABLE [dbo].[ORDER] DROP CONSTRAINT [DF_ORDER_UpdateBy]
GO
ALTER TABLE [dbo].[ORDER] DROP CONSTRAINT [DF_ORDER_UpdateDate]
GO
DROP TABLE [dbo].[ORDER]
GO
/****** Object:  Table [dbo].[ORDER_DATE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[ORDER_DATE] DROP CONSTRAINT [DF_ORDERDATE_Status]
GO
ALTER TABLE [dbo].[ORDER_DATE] DROP CONSTRAINT [DF_ORDERDATE_CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DATE] DROP CONSTRAINT [DF_ORDERDATE_CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DATE] DROP CONSTRAINT [DF_ORDERDATE_UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DATE] DROP CONSTRAINT [DF_ORDERDATE_UpdateDate]
GO
DROP TABLE [dbo].[ORDER_DATE]
GO
/****** Object:  Table [dbo].[ORDER_DETAIL]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[ORDER_DETAIL] DROP CONSTRAINT [DF_ORDER_DETAIL_Satust]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] DROP CONSTRAINT [DF_ORDER_DETAIL_CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] DROP CONSTRAINT [DF_ORDER_DETAIL_CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] DROP CONSTRAINT [DF_ORDER_DETAIL_UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL] DROP CONSTRAINT [DF_ORDER_DETAIL_UpdateDate]
GO
DROP TABLE [dbo].[ORDER_DETAIL]
GO
/****** Object:  Table [dbo].[ORDER_DETAIL_DATE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_DATE_Satust]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateDate]
GO
DROP TABLE [dbo].[ORDER_DETAIL_DATE]
GO
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_Satust]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]
GO
DROP TABLE [dbo].[ORDER_DETAIL_MODIFIRE]
GO
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE_DATE]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]
GO
ALTER TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE] DROP CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]
GO
DROP TABLE [dbo].[ORDER_DETAIL_MODIFIRE_DATE]
GO
/****** Object:  Table [dbo].[PAYMENT_INVOICE_HISTORY]    Script Date: 12/13/2015 22:57:34 ******/
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] DROP CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_Satust]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] DROP CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateBy]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] DROP CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateDate]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] DROP CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]
GO
ALTER TABLE [dbo].[PAYMENT_INVOICE_HISTORY] DROP CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]
GO
DROP TABLE [dbo].[PAYMENT_INVOICE_HISTORY]
GO
/****** Object:  Table [dbo].[PAYMENT_TYPE]    Script Date: 12/13/2015 22:57:35 ******/
ALTER TABLE [dbo].[PAYMENT_TYPE] DROP CONSTRAINT [DF_PAYMENT_TYPE_Status]
GO
ALTER TABLE [dbo].[PAYMENT_TYPE] DROP CONSTRAINT [DF_PAYMENT_TYPE_CreateBy]
GO
ALTER TABLE [dbo].[PAYMENT_TYPE] DROP CONSTRAINT [DF_PAYMENT_TYPE_CreateDate]
GO
ALTER TABLE [dbo].[PAYMENT_TYPE] DROP CONSTRAINT [DF_PAYMENT_TYPE_UpdateBy]
GO
ALTER TABLE [dbo].[PAYMENT_TYPE] DROP CONSTRAINT [DF_PAYMENT_TYPE_UpdateDate]
GO
DROP TABLE [dbo].[PAYMENT_TYPE]
GO
/****** Object:  Table [dbo].[PERMISSION]    Script Date: 12/13/2015 22:57:35 ******/
ALTER TABLE [dbo].[PERMISSION] DROP CONSTRAINT [DF_PERMISSION_Status]
GO
ALTER TABLE [dbo].[PERMISSION] DROP CONSTRAINT [DF_PERMISSION_DeparmentID]
GO
ALTER TABLE [dbo].[PERMISSION] DROP CONSTRAINT [DF_PERMISSION_SubMenuID]
GO
ALTER TABLE [dbo].[PERMISSION] DROP CONSTRAINT [DF_PERMISSION_CreateBy]
GO
ALTER TABLE [dbo].[PERMISSION] DROP CONSTRAINT [DF_PERMISSION_CreateDate]
GO
ALTER TABLE [dbo].[PERMISSION] DROP CONSTRAINT [DF_PERMISSION_UpdateBy]
GO
ALTER TABLE [dbo].[PERMISSION] DROP CONSTRAINT [DF_PERMISSION_UpdateDate]
GO
DROP TABLE [dbo].[PERMISSION]
GO
/****** Object:  Table [dbo].[PERMISSION]    Script Date: 12/13/2015 22:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISSION](
	[PermissionID] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_PERMISSION_Status]  DEFAULT ((1)),
	[DepartmentID] [int] NOT NULL CONSTRAINT [DF_PERMISSION_DeparmentID]  DEFAULT ((0)),
	[SubMenuID] [int] NOT NULL CONSTRAINT [DF_PERMISSION_SubMenuID]  DEFAULT ((0)),
	[CreateBy] [int] NULL CONSTRAINT [DF_PERMISSION_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_PERMISSION_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_PERMISSION_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_PERMISSION_UpdateDate]  DEFAULT (getdate()),
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
SET IDENTITY_INSERT [dbo].[PERMISSION] OFF
/****** Object:  Table [dbo].[PAYMENT_TYPE]    Script Date: 12/13/2015 22:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENT_TYPE](
	[PaymentTypeID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_PAYMENT_TYPE_Status]  DEFAULT ((1)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_PAYMENT_TYPE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_PAYMENT_TYPE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_PAYMENT_TYPE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_PAYMENT_TYPE_UpdateDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_PAYMENT_TYPE] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAYMENT_INVOICE_HISTORY]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAYMENT_INVOICE_HISTORY](
	[PaymentHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[PaymentTypeID] [int] NOT NULL,
	[Total] [float] NOT NULL,
	[Satust] [int] NOT NULL CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_Satust]  DEFAULT ((1)),
	[CreateBy] [int] NULL CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_PAYMENT_INVOICE_HISTORY_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_PAYMENT_INVOICE_HISTORY] PRIMARY KEY CLUSTERED 
(
	[PaymentHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE_DATE]    Script Date: 12/13/2015 22:57:34 ******/
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
	[Satust] [int] NOT NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_Satust]  DEFAULT ((1)),
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[Seat] [int] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_DATE_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER_DETAIL_MODIFIRE_DATE] PRIMARY KEY CLUSTERED 
(
	[OrderModifireID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ON
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (78, 0, 2, 1, 1, 2, 0, 5000, 0, 0, 1, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (79, 0, 2, 1, 1, 1, 0, 10000, 0, 0, 1, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (80, 0, 2, 2, 2, 3, 0, 3000, 0, 0, 1, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (81, 0, 2, 15, 6, 13, 0, 15000, 0, 0, 2, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (92, 0, 3, 15, 3, 13, 0, 15000, 0, 0, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (93, 0, 3, 14, 4, 11, 0, 10000, 0, 0, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (94, 0, 3, 15, 6, 13, 0, 15000, 0, 0, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (95, 0, 3, 15, 6, 12, 0, 3000, 0, 0, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (103, 0, 1, 11, 1, 10, 0, 12000, 0, 0, 0, 0, CAST(0x0000A56C01024008 AS DateTime), 0, CAST(0x0000A56C01024008 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (104, 0, 1, 15, 3, 13, 0, 15000, 0, 0, 0, 0, CAST(0x0000A56C01024008 AS DateTime), 0, CAST(0x0000A56C01024008 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] ([OrderModifireID], [OrderDetailID], [OrderID], [ProductID], [KeyModi], [ModifireID], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (105, 0, 1, 16, 4, 12, 0, 3000, 0, 0, 0, 0, CAST(0x0000A56C01024008 AS DateTime), 0, CAST(0x0000A56C01024008 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_MODIFIRE_DATE] OFF
/****** Object:  Table [dbo].[ORDER_DETAIL_MODIFIRE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL_MODIFIRE](
	[OrderModifireID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDetailID] [int] NOT NULL,
	[ModifireID] [int] NOT NULL,
	[Satust] [int] NOT NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)),
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_ORDER_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER_DETAIL_MODIFIRE] PRIMARY KEY CLUSTERED 
(
	[OrderModifireID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_DETAIL_DATE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL_DATE](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[KeyItem] [int] NULL,
	[Satust] [int] NOT NULL CONSTRAINT [DF_ORDER_DETAIL_DATE_Satust]  DEFAULT ((1)),
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[Seat] [int] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_ORDER_DETAIL_DATE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_ORDER_DETAIL_DATE_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER_DETAIL_DATE] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_DATE] ON
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (122, 2, 1, 1, 0, 210000, 1, 210000, 1, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (123, 2, 2, 2, 0, 25000, 1, 25000, 1, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (124, 2, 8, 3, 0, 30000, 1, 30000, 1, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (125, 2, 15, 4, 0, 25000, 1, 25000, 2, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (126, 2, 15, 5, 0, 25000, 1, 25000, 2, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (127, 2, 15, 6, 0, 25000, 1, 25000, 2, 0, CAST(0x0000A56C00A91C90 AS DateTime), 0, CAST(0x0000A56C00A91C90 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (140, 3, 18, 1, 0, 20000, 1, 20000, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (141, 3, 22, 2, 0, 120000, 1, 120000, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (142, 3, 15, 3, 0, 25000, 1, 25000, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (143, 3, 14, 4, 0, 35000, 1, 35000, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (144, 3, 15, 5, 0, 25000, 1, 25000, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (145, 3, 15, 6, 0, 25000, 1, 25000, 0, 0, CAST(0x0000A56C00AD96B0 AS DateTime), 0, CAST(0x0000A56C00AD96B0 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (189, 4, 15, 1, 0, 25000, 1, 25000, 0, 0, CAST(0x0000A56C01020875 AS DateTime), 0, CAST(0x0000A56C01020875 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (190, 4, 16, 2, 0, 15000, 1, 15000, 0, 0, CAST(0x0000A56C01020875 AS DateTime), 0, CAST(0x0000A56C01020875 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (191, 1, 11, 1, 0, 30000, 1, 30000, 0, 0, CAST(0x0000A56C01023FFF AS DateTime), 0, CAST(0x0000A56C01023FFF AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (192, 1, 12, 2, 0, 25000, 1, 25000, 0, 0, CAST(0x0000A56C01023FFF AS DateTime), 0, CAST(0x0000A56C01023FFF AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (193, 1, 15, 3, 0, 25000, 1, 25000, 0, 0, CAST(0x0000A56C01023FFF AS DateTime), 0, CAST(0x0000A56C01023FFF AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (194, 1, 16, 4, 0, 15000, 1, 15000, 0, 0, CAST(0x0000A56C01023FFF AS DateTime), 0, CAST(0x0000A56C01023FFF AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (195, 1, 16, 5, 0, 15000, 1, 15000, 0, 0, CAST(0x0000A56C01023FFF AS DateTime), 0, CAST(0x0000A56C01023FFF AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (196, 1, 11, 6, 0, 30000, 1, 30000, 0, 0, CAST(0x0000A56C01023FFF AS DateTime), 0, CAST(0x0000A56C01023FFF AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (197, 1, 16, 7, 0, 15000, 1, 15000, 0, 0, CAST(0x0000A56C01024004 AS DateTime), 0, CAST(0x0000A56C01024004 AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (198, 5, 10, 1, 0, 32000, 1, NULL, 0, 0, CAST(0x0000A56C010ED97A AS DateTime), 0, CAST(0x0000A56C010ED97A AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (199, 5, 11, 2, 0, 30000, 1, NULL, 0, 0, CAST(0x0000A56C010ED97A AS DateTime), 0, CAST(0x0000A56C010ED97A AS DateTime), NULL)
INSERT [dbo].[ORDER_DETAIL_DATE] ([OrderDetailID], [OrderID], [ProductID], [KeyItem], [Satust], [Price], [Qty], [Total], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (200, 5, 12, 3, 0, 25000, 1, NULL, 0, 0, CAST(0x0000A56C010ED97A AS DateTime), 0, CAST(0x0000A56C010ED97A AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ORDER_DETAIL_DATE] OFF
/****** Object:  Table [dbo].[ORDER_DETAIL]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DETAIL](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Satust] [int] NOT NULL CONSTRAINT [DF_ORDER_DETAIL_Satust]  DEFAULT ((1)),
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_ORDER_DETAIL_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_ORDER_DETAIL_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_ORDER_DETAIL_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_ORDER_DETAIL_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER_DETAIL] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDER_DATE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER_DATE](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [nvarchar](50) NULL,
	[ClientID] [int] NULL,
	[FloorID] [nvarchar](50) NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_ORDERDATE_Status]  DEFAULT ((1)),
	[TotalAmount] [float] NULL,
	[Seat] [int] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_ORDERDATE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_ORDERDATE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_ORDERDATE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_ORDERDATE_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDERDATE] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ORDER_DATE] ON
INSERT [dbo].[ORDER_DATE] ([OrderID], [OrderNumber], [ClientID], [FloorID], [Status], [TotalAmount], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (1, N'1', 0, N'1', 0, 155000, 0, 0, CAST(0x0000A56B016CF8AE AS DateTime), 0, CAST(0x0000A56B016CF8AE AS DateTime), N'')
INSERT [dbo].[ORDER_DATE] ([OrderID], [OrderNumber], [ClientID], [FloorID], [Status], [TotalAmount], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (2, N'2', 0, N'3', 0, 340000, 2, 0, CAST(0x0000A56B016D4616 AS DateTime), 0, CAST(0x0000A56B016D4616 AS DateTime), N'')
INSERT [dbo].[ORDER_DATE] ([OrderID], [OrderNumber], [ClientID], [FloorID], [Status], [TotalAmount], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (3, N'3', 0, N'17', 0, 250000, 0, 0, CAST(0x0000A56B016D6DDE AS DateTime), 0, CAST(0x0000A56B016D6DDE AS DateTime), N'')
INSERT [dbo].[ORDER_DATE] ([OrderID], [OrderNumber], [ClientID], [FloorID], [Status], [TotalAmount], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (4, N'4', 0, N'5', 0, 55000, 0, 0, CAST(0x0000A56C00FE4AD7 AS DateTime), 0, CAST(0x0000A56C00FE4AD7 AS DateTime), N'')
INSERT [dbo].[ORDER_DATE] ([OrderID], [OrderNumber], [ClientID], [FloorID], [Status], [TotalAmount], [Seat], [CreateBy], [CreateDate], [UpdateBy], [UpdateDate], [Note]) VALUES (5, N'5', 0, N'8', 0, 87000, 0, 0, CAST(0x0000A56C010ED96A AS DateTime), 0, CAST(0x0000A56C010ED96B AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[ORDER_DATE] OFF
/****** Object:  Table [dbo].[ORDER]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderNumber] [nvarchar](50) NULL,
	[ClientID] [int] NULL,
	[FloorID] [int] NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_ORDER_Status]  DEFAULT ((1)),
	[TotalAmount] [float] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_ORDER_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_ORDER_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_ORDER_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_ORDER_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MODIFIRE_PRICE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODIFIRE_PRICE](
	[ModifirePriceID] [int] IDENTITY(1,1) NOT NULL,
	[ModifireID] [int] NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_MODIFIRE_PRICE_Status]  DEFAULT ((1)),
	[CurrentPrice] [float] NULL,
	[WasPrice] [float] NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_MODIFIRE_PRICE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_MODIFIRE_PRICE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_MODIFIRE_PRICE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_MODIFIRE_PRICE_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[MODIFIRE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MODIFIRE](
	[ModifireID] [int] IDENTITY(1,1) NOT NULL,
	[ModifireName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_MODIFIRE_Status]  DEFAULT ((1)),
	[Color] [nvarchar](250) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_MODIFIRE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_MODIFIRE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_MODIFIRE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_MODIFIRE_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[MENU]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MENU](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](500) NOT NULL,
	[Priority] [int] NOT NULL CONSTRAINT [DF_MENU_Priority]  DEFAULT ((0)),
	[Status] [int] NOT NULL CONSTRAINT [DF_MENU_Status]  DEFAULT ((1)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_MENU_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_MENU_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_MENU_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_MENU_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[MAP_PRODUCT_TO_CATEGORY]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAP_PRODUCT_TO_CATEGORY](
	[ProductID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_Status]  DEFAULT ((1)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_MAP_PRODUCT_TO_CATEGORY_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[MAP_MODIFIRE_TO_PRODUCT]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAP_MODIFIRE_TO_PRODUCT](
	[ModifireID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_Status]  DEFAULT ((1)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_MAP_MODIFIRE_TO_PRODUCT_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[MAP_CATEGORY_TO_CATALOGUE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAP_CATEGORY_TO_CATALOGUE](
	[CategoryID] [int] NOT NULL,
	[CatalogueID] [int] NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_Status]  DEFAULT ((1)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_MAP_CATEGORY_TO_CATALOGUE_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[INVOICE_DETAIL_MODIFIRE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL_MODIFIRE](
	[InvoiceModifireID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceDetailID] [int] NOT NULL,
	[OrderModifireID] [int] NULL,
	[Satust] [int] NOT NULL CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_Satust]  DEFAULT ((1)),
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_INVOICE_DETAIL_MODIFIRE_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_INVOICE_DETAIL_MODIFIRE] PRIMARY KEY CLUSTERED 
(
	[InvoiceModifireID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVOICE_DETAIL]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_DETAIL](
	[InvoiceDetailID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[OrderDetailID] [int] NULL CONSTRAINT [DF_INVOICE_DETAIL_OrderDetailID]  DEFAULT ((0)),
	[Status] [int] NOT NULL CONSTRAINT [DF_INVOICE_DETAIL_Status]  DEFAULT ((1)),
	[Price] [float] NULL,
	[Qty] [float] NULL,
	[Total] [float] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_INVOICE_DETAIL_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_INVOICE_DETAIL_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_INVOICE_DETAIL_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_INVOICE_DETAIL_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_INVOICE_DETAIL] PRIMARY KEY CLUSTERED 
(
	[InvoiceDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVOICE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNumber] [nvarchar](50) NULL,
	[OrderID] [int] NOT NULL,
	[Satust] [int] NOT NULL CONSTRAINT [DF_INVOICE_Satust]  DEFAULT ((1)),
	[Total] [int] NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_INVOICE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_INVOICE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_INVOICE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_INVOICE_UpdateDate]  DEFAULT (getdate()),
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_INVOICE] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FLOOR]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FLOOR](
	[FloorID] [int] IDENTITY(1,1) NOT NULL,
	[FloorName] [nvarchar](500) NOT NULL,
	[Priority] [int] NOT NULL CONSTRAINT [DF_FLOOR_Priority]  DEFAULT ((0)),
	[Status] [int] NOT NULL CONSTRAINT [DF_FLOOR_Status]  DEFAULT ((1)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_FLOOR_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_FLOOR_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_FLOOR_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_FLOOR_UpdateDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_FLOOR] PRIMARY KEY CLUSTERED 
(
	[FloorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEPARTMENT]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEPARTMENT](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_DEPARMENT_Status]  DEFAULT ((1)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_DEPARMENT_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_DEPARMENT_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_DEPARMENT_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_DEPARMENT_UpdateDate]  DEFAULT (getdate()),
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
SET IDENTITY_INSERT [dbo].[DEPARTMENT] OFF
/****** Object:  Table [dbo].[CLIENT]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENT](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_CLIENT_Status]  DEFAULT ((1)),
	[Fname] [nvarchar](500) NULL,
	[Lname] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Phone] [nvarchar](500) NULL,
	[Adress1] [nvarchar](500) NULL,
	[Adress2] [nvarchar](500) NULL,
	[Adress3] [nvarchar](500) NULL,
	[Country] [nvarchar](500) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_CLIENT_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_CLIENT_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_CLIENT_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_CLIENT_UpdateDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_CLIENT] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](500) NOT NULL,
	[CategoryNameSort] [nvarchar](500) NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_CATEGORY_Status]  DEFAULT ((1)),
	[Color] [nvarchar](250) NULL,
	[ProductColor] [nvarchar](250) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_CATEGORY_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_CATEGORY_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_CATEGORY_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_CATEGORY_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[CATALOGUE]    Script Date: 12/13/2015 22:57:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATALOGUE](
	[CatalogueID] [int] IDENTITY(1,1) NOT NULL,
	[CatalogueName] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_CATALOGUE_Status]  DEFAULT ((1)),
	[Color] [nvarchar](250) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_CATALOGUE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_CATALOGUE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_CATALOGUE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_CATALOGUE_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  UserDefinedTableType [dbo].[TableTemp]    Script Date: 12/13/2015 22:57:35 ******/
CREATE TYPE [dbo].[TableTemp] AS TABLE(
	[Value] [int] NULL
)
GO
/****** Object:  Table [dbo].[SUB_MENU]    Script Date: 12/13/2015 22:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUB_MENU](
	[SubMenuID] [int] IDENTITY(1,1) NOT NULL,
	[SubMenuName] [nvarchar](500) NOT NULL,
	[MenuID] [int] NOT NULL,
	[Priority] [int] NOT NULL CONSTRAINT [DF_SUB_MENU_Priority]  DEFAULT ((0)),
	[Status] [int] NOT NULL CONSTRAINT [DF_SUB_MENU_Status]  DEFAULT ((1)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_SUB_MENU_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_SUB_MENU_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_SUB_MENU_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_SUB_MENU_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[STAFF]    Script Date: 12/13/2015 22:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFF](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_STAFF_Status]  DEFAULT ((1)),
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
	[CreateBy] [int] NULL CONSTRAINT [DF_STAFF_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_STAFF_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_STAFF_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_STAFF_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[SHIFT_HISTORY]    Script Date: 12/13/2015 22:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SHIFT_HISTORY](
	[ShiftHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NOT NULL,
	[StartShift] [datetime] NOT NULL CONSTRAINT [DF_SHIFT_HISTORY_StartShift]  DEFAULT (getdate()),
	[EndShift] [datetime] NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_SHIFT_HISTORY_Status]  DEFAULT ((0)),
	[Total] [float] NULL CONSTRAINT [DF_SHIFT_HISTORY_Total]  DEFAULT ((0)),
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_SHIFT_HISTORY_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_SHIFT_HISTORY_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_SHIFT_HISTORY_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_SHIFT_HISTORY_UpdateDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_SHIFT_HISTORY] PRIMARY KEY CLUSTERED 
(
	[ShiftHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT_PRICE]    Script Date: 12/13/2015 22:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT_PRICE](
	[ProductPriceID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_PRODUCT_PRICE_Status]  DEFAULT ((1)),
	[CurrentPrice] [float] NULL,
	[WasPrice] [float] NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_PRODUCT_PRICE_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_PRODUCT_PRICE_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_PRODUCT_PRICE_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_PRODUCT_PRICE_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 12/13/2015 22:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductNameDesc] [nvarchar](500) NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_PRODUCT_Status]  DEFAULT ((1)),
	[Color] [nvarchar](250) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateBy] [int] NULL CONSTRAINT [DF_PRODUCT_CreateBy]  DEFAULT ((0)),
	[CreateDate] [datetime] NULL CONSTRAINT [DF_PRODUCT_CreateDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL CONSTRAINT [DF_PRODUCT_UpdateBy]  DEFAULT ((0)),
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_PRODUCT_UpdateDate]  DEFAULT (getdate()),
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataPermissionByDepartmet]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapProductToCategory]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapModifireToProduct]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_SaveDataMapCategoryToCatalogue]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifireToProduct]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetListModifire]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListProductByCategory]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListPermissionByDepartmentID]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[pos_th_GetAllListCategoryByCatalogue]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[getProductByCategory]    Script Date: 12/13/2015 22:57:31 ******/
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
/****** Object:  StoredProcedure [dbo].[getModifireByProduct]    Script Date: 12/13/2015 22:57:31 ******/
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
