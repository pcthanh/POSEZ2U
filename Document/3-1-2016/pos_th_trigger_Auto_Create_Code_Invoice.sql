USE [POSEZ2U_V1]
GO
/****** Object:  Trigger [dbo].[pos_th_trigger_Auto_Create_Code_Invoice]    Script Date: 1/3/2016 11:00:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Thien Huynh>
-- Create date: <03/01/2016>
-- Description:	<pos_th_trigger_Auto_Create_Code_Invoice>
-- =============================================
ALTER TRIGGER [dbo].[pos_th_trigger_Auto_Create_Code_Invoice] ON [dbo].[INVOICE]
    AFTER INSERT
AS
    BEGIN
	
        SET NOCOUNT ON;
	
        DECLARE @invoiceid INT= 0;

       
        SELECT TOP 1
                @invoiceid = ins.InvoiceID
        FROM    inserted ins


        UPDATE  dbo.INVOICE
        SET     InvoiceNumber = [dbo].[Auto_Create_Code]('6', InvoiceID)
        WHERE   InvoiceID = @invoiceid


    END
