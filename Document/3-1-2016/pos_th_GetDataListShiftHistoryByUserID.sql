USE [POSEZ2U_V1]
GO
/****** Object:  StoredProcedure [dbo].[pos_th_GetDataListShiftHistoryByUserID]    Script Date: 1/3/2016 8:29:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Thien Huynh>
-- Create date: <03/01/2016>
-- Description:	<get list Shift History>
-- =============================================

--  EXEC pos_th_GetDataListShiftHistoryByUserID @userid=4,@type=0

ALTER PROCEDURE [dbo].[pos_th_GetDataListShiftHistoryByUserID]
    @userid INT = 0 ,
    @type INT = 0
AS
    BEGIN
	
        SET NOCOUNT ON;

		  IF OBJECT_ID(N'dbo.TableTemp', N'U') IS NOT NULL
            BEGIN
                DROP TABLE TableTemp
            END

        DECLARE @deparmentid INT= 0;

        SELECT TOP 1
                @deparmentid = DepartmentID
        FROM    dbo.STAFF
        WHERE   StaffID = @userid

        IF ( @type = 0 )
            BEGIN

                SELECT  sh.ShiftHistoryID ,
                        s.StaffID ,
                        sh.ShiftName ,
                        sh.StartShift ,
                        sh.EndShift ,
                        sh.Status ,
                        ISNULL(sh.CashStart, 0) AS CashStart ,
                        ISNULL(sh.CashEnd, 0) AS CashEnd ,
                        ISNULL(sh.SafeDrop, 0) AS SafeDrop ,
                        ISNULL(s.UserName,'') AS UserName
                INTO    TableTemp
                FROM    dbo.SHIFT_HISTORY sh
                        INNER JOIN dbo.STAFF s ON s.StaffID = sh.StaffID
                WHERE   sh.Status = 1
				
				
                IF ( @deparmentid = 3 )
                    BEGIN
                        SELECT  *
                        FROM    TableTemp
                        WHERE   StaffID = @userid
						ORDER BY StartShift DESC
                    END
                ELSE
                    BEGIN
                        SELECT  *
                        FROM    TableTemp
						ORDER BY StartShift DESC
                    END

				

            END
        ELSE
            BEGIN

                SELECT TOP 10
                        sh.ShiftHistoryID ,
                        s.StaffID ,
                        sh.ShiftName ,
                        sh.StartShift ,
                        sh.EndShift ,
                        sh.Status ,
                        ISNULL(sh.CashStart, 0) AS CashStart ,
                        ISNULL(sh.CashEnd, 0) AS CashEnd ,
                        ISNULL(sh.SafeDrop, 0) AS SafeDrop ,
                       ISNULL(s.UserName,'') AS UserName
						INTO   TableTemp
                FROM    dbo.SHIFT_HISTORY sh
                        INNER JOIN dbo.STAFF s ON s.StaffID = sh.StaffID
                WHERE   sh.Status = 2 AND CONVERT(NVARCHAR(10),sh.StartShift,103)=CONVERT(NVARCHAR(10),GETDATE(),103)
              


				  IF ( @deparmentid = 3 )
                    BEGIN
                        SELECT  *
                        FROM    TableTemp
                        WHERE   StaffID = @userid
						ORDER BY StartShift DESC
                    END
                ELSE
                    BEGIN
                        SELECT  *
                        FROM    TableTemp
						ORDER BY StartShift DESC
                    END
            END
    END
