USE [POSEZ2U_V1]
GO

/****** Object:  View [dbo].[view_report_invoice]    Script Date: 1/17/2016 4:29:01 PM ******/
DROP VIEW [dbo].[view_report_invoice]
GO

/****** Object:  View [dbo].[view_report_invoice]    Script Date: 1/17/2016 4:29:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_report_invoice]

AS

SELECT  cte.CategoryID ,
        cte.CategoryName ,
        inv.InvoiceID ,
        inv.InvoiceNumber ,
        inv.CreateDate ,
		inv.OrderID,
        invd.ProductID ,
		p.ProductNameDesc,
        invd.Qty ,
        invd.Price ,
        invd.Total
FROM    dbo.INVOICE inv
        INNER JOIN dbo.INVOICE_DETAIL invd ON invd.InvoiceNumber = inv.InvoiceID
		INNER JOIN dbo.PRODUCT p ON p.ProductID=invd.ProductID
        INNER JOIN dbo.MAP_PRODUCT_TO_CATEGORY mappc ON mappc.ProductID = invd.ProductID
        INNER JOIN dbo.CATEGORY cte ON cte.CategoryID = mappc.CategoryID
WHERE   inv.Satust = 1



		
GO


