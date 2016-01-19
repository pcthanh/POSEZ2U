USE [POSEZ2U_V1]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetQTYItemSaleReport]    Script Date: 1/17/2016 4:07:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Thien Huynh>
-- Create date: <16/1/2016>
-- Description:	<get Data summary report>
-- =============================================

--  EXEC pos_th_GetQTYItemSaleReport @dateselect='2015-12-27',@type=1

ALTER PROCEDURE [dbo].[pos_th_GetQTYItemSaleReport]
    @dateselect NVARCHAR(20) = '' ,
    @type INT = 0
AS
    BEGIN
	
        SET NOCOUNT ON;

        DECLARE @startdate DATETIME= CONVERT(DATETIME, @dateselect
            + ' 00:00:00');
        DECLARE @enddate DATETIME= CONVERT(DATETIME, @dateselect + ' 23:59:59');

        IF ( @type = 1 )
            BEGIN
                SELECT  @startdate = [dbo].[GetStartDate](@startdate)

                SELECT  @enddate = [dbo].[GetEndDate](@enddate)
            END

		--SELECT @startdate,@enddate

        SELECT  ProductID ,
				ProductNameDesc ,
				SUM(qty) AS TotalQty
        FROM    view_report_invoice
        WHERE   CreateDate BETWEEN @startdate AND @enddate
		GROUP BY ProductID ,
				ProductNameDesc 
    END
