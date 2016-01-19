USE [POSEZ2U_V1]
GO

/****** Object:  StoredProcedure [dbo].[pos_th_GetListProductPrice]    Script Date: 01/19/2016 11:24:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pos_th_GetListProductPrice] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT pp.ProductPriceID,p.ProductID,p.ProductNameDesc,pp.CurrentPrice, pp.Portions
	FROM PRODUCT as p Left Join PRODUCT_PRICE as pp ON p.ProductID = pp.ProductID
	Where p.Status = 1 and pp.Status = 1
END

GO

