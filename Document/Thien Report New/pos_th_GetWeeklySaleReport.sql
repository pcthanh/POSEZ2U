-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<thien huynh>
-- Create date: <27/12/2015>
-- Description:	<Weekly Sale Report>
-- =============================================


--  EXEC pos_th_GetWeeklySaleReport


ALTER PROCEDURE pos_th_GetWeeklySaleReport
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
