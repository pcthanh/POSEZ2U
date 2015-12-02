USE [POSEZ2U]
GO

/****** Object:  Table [dbo].[PRODUCT]    Script Date: 12/02/2015 10:39:59 PM ******/
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
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_Status]  DEFAULT ((1)) FOR [Status]
GO

ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_CreateBy]  DEFAULT ((0)) FOR [CreateBy]
GO

ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO

ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_UpdateBy]  DEFAULT ((0)) FOR [UpdateBy]
GO

ALTER TABLE [dbo].[PRODUCT] ADD  CONSTRAINT [DF_PRODUCT_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO


