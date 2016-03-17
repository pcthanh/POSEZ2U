USE [POSEZ2U]
GO

/****** Object:  StoredProcedure [dbo].[pos_th_GetSearchAllListProductByCategory]    Script Date: 03/12/2016 12:44:12 AM ******/
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



Create PROCEDURE [dbo].[pos_th_GetSearchAllListProductByCategory] @categoryid INT = 0, @txtSearch NVARCHAR(500)
AS
	SET @txtSearch = LTRIM(RTRIM(@txtSearch));
        SET NOCOUNT ON;
		IF (@txtSearch != '')
			BEGIN 
				SELECT  ProductID,ProductNameDesc,ProductNameSort 
				FROM    dbo.PRODUCT
				WHERE   Status = 1
						AND ProductNameDesc LIKE '%' + @txtSearch + '%'
						AND ProductID NOT IN ( SELECT  ProductID
												FROM    dbo.MAP_PRODUCT_TO_CATEGORY
												WHERE   CategoryID = @categoryid
														AND Status = 1 )
			END
		ELSE 
			BEGIN
				SELECT  ProductID,ProductNameDesc,ProductNameSort
				FROM    dbo.PRODUCT
				WHERE   Status = 1
						AND ProductID NOT IN ( SELECT  ProductID
												FROM    dbo.MAP_PRODUCT_TO_CATEGORY
												WHERE   CategoryID = @categoryid
														AND Status = 1 )
			END 


GO


CREATE PROCEDURE [dbo].[pos_th_GetSearchAllListCategoryByCatalogue] @catalogueid INT = 0, @txtSearch NVARCHAR(500)
AS
	SET @txtSearch = LTRIM(RTRIM(@txtSearch));
        SET NOCOUNT ON;
		IF (@txtSearch != '')
			BEGIN 
				SELECT  CategoryID,CategoryName,ISNULL(CategoryNameSort,'') AS CategoryNameSort 
				FROM    dbo.CATEGORY
				WHERE   Status = 1
						AND CategoryName LIKE '%' + @txtSearch + '%'
						AND CategoryID NOT IN ( SELECT  CategoryID
												FROM    dbo.MAP_CATEGORY_TO_CATALOGUE
												WHERE   CatalogueID = @catalogueid
														AND Status = 1 )
			END
		ELSE 
			BEGIN
				SELECT  CategoryID,CategoryName,ISNULL(CategoryNameSort,'') AS CategoryNameSort 
				FROM    dbo.CATEGORY
				WHERE   Status = 1 
						AND CategoryID NOT IN ( SELECT  CategoryID
												FROM    dbo.MAP_CATEGORY_TO_CATALOGUE
												WHERE   CatalogueID = @catalogueid
														AND Status = 1 )
			END 


GO

CREATE PROCEDURE [dbo].[pos_th_GetSearchListModifireToProduct] @productID INT = 0, @txtSearch NVARCHAR(500)
AS
	SET @txtSearch = LTRIM(RTRIM(@txtSearch));
        SET NOCOUNT ON;
		IF (@txtSearch != '')
			BEGIN 
				SELECT  * 
				FROM    dbo.MODIFIRE
				WHERE   Status = 1
						AND ModifireName LIKE '%' + @txtSearch + '%'
						AND MODIFIRE.ModifireID NOT IN (Select ModifireID
												  From dbo.MAP_MODIFIRE_TO_PRODUCT
												  Where ProductID = @productID
														and Status = 1)
			END
		ELSE 
			BEGIN
				SELECT *
				FROM dbo.MODIFIRE 
				Where Status = 1 and 
					  MODIFIRE.ModifireID NOT IN (Select ModifireID
												  From dbo.MAP_MODIFIRE_TO_PRODUCT
												  Where ProductID = @productID
														and Status = 1)
			END 


GO