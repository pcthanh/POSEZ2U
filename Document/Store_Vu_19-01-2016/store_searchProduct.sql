USE [POSEZ2U_V1]
GO

/****** Object:  StoredProcedure [dbo].[pos_th_SearchProduct]    Script Date: 01/19/2016 11:22:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pos_th_SearchProduct]
	@txtsearch NVARCHAR(500),
	@type INT = 5
AS 
	-- Add the parameters for the stored procedure here
SET @txtsearch = LTRIM(RTRIM(@txtsearch));
IF ( @type = 1 )
	IF (@txtsearch != '')
		BEGIN
			SELECT  CatalogueID,
					CatalogueName
			FROM    dbo.CATALOGUE
			WHERE   CatalogueName LIKE '%' + @txtsearch + '%'
		END
	ELSE 
		BEGIN
			SELECT  CatalogueID,
					CatalogueName
			FROM    dbo.CATALOGUE
		END

 IF ( @type = 2 )
	IF (@txtsearch != '')
		BEGIN
			SELECT  CategoryID,
					CategoryName, CategoryNameSort, Color, ProductColor
			FROM    dbo.CATEGORY
			WHERE   CategoryName LIKE '%' + @txtsearch + '%'
		END
	ELSE 
		BEGIN
			SELECT  CategoryID,
					CategoryName, CategoryNameSort, Color, ProductColor
			FROM    dbo.CATEGORY
		END

 IF ( @type = 3)
	IF (@txtsearch != '')
		BEGIN
			SELECT  p.ProductID,
					ProductNameDesc, ProductNameSort, Color, pp.CurrentPrice
			FROM    dbo.PRODUCT p left join dbo.PRODUCT_PRICE as pp on p.ProductID = pp.ProductID
			WHERE   ProductNameDesc LIKE '%' + @txtsearch + '%'
		END
	ELSE 
		BEGIN
			SELECT  p.ProductID,
					ProductNameDesc, ProductNameSort, Color, pp.CurrentPrice
			FROM    dbo.PRODUCT p left join dbo.PRODUCT_PRICE as pp on p.ProductID = pp.ProductID
		END
IF (@type = 4)
	IF (@txtsearch != '')
		BEGIN 
			SELECT m.ModifireID,
					ModifireName, Color, mf.CurrentPrice
			FROM dbo.MODIFIRE as m left join dbo.MODIFIRE_PRICE as mf on m.ModifireID = mf.ModifireID
			WHERE ModifireName LIKE '%' + @txtsearch + '%'
		END
	ELSE 
		BEGIN 
			SELECT m.ModifireID,
					ModifireName, Color, mf.CurrentPrice
			FROM dbo.MODIFIRE as m left join dbo.MODIFIRE_PRICE as mf on m.ModifireID = mf.ModifireID
		END
GO


