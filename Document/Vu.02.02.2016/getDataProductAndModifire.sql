USE [POSEZ2U]
GO

/****** Object:  StoredProcedure [dbo].[pos_th_GetDataProductAndModifire]    Script Date: 02/02/2016 11:11:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pos_th_GetDataProductAndModifire]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT P.ProductID as ID, P.ProductNameDesc AS NameDesc, P.ProductNameSort as NameSort, P.Color as Color, PP.CurrentPrice as CurrentPrice, PP.Portions as Portions, PP.ProductPriceID as PriceID, 'PRODUCT' as Type
	FROM PRODUCT as P LEFT JOIN PRODUCT_PRICE as PP ON P.ProductID = PP.ProductID
	WHERE P.Status = 1

	UNION

	SELECT M.ModifireID as ID, M.ModifireName AS NameDesc, M.ModifireName as NameSort, M.Color as Color, MP.CurrentPrice as CurrentPrice, '' as Portions, MP.ModifirePriceID as PriceID, 'MODIFIRE' as Type
	FROM MODIFIRE as M LEFT JOIN MODIFIRE_PRICE as MP ON M.ModifireID = MP.ModifireID
	WHERE M.Status = 1
END

GO

