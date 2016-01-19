USE [POSEZ2U_V1]
GO
/****** Object:  UserDefinedFunction [dbo].[GetEndDate]    Script Date: 1/17/2016 4:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[GetEndDate]
(
	@enddate DATETIME
)
RETURNS DATETIME
AS
BEGIN	
	
	DECLARE @result DATETIME

	 DECLARE @flag INT = 0;

                SELECT  @flag = ( 1 + ( ( 6 + DATEPART(dw, @enddate)
                                          + @@DATEFIRST ) % 7 ) );

                SELECT  @result = CASE WHEN @flag = 1
                                             AND @enddate < GETDATE()
                                        THEN @enddate
                                        WHEN @flag = 2
                                             AND @enddate < GETDATE()
                                        THEN @enddate
                                        WHEN @flag = 3
                                             AND @enddate < GETDATE()
                                        THEN @enddate + 5
                                        WHEN @flag = 4
                                             AND @enddate < GETDATE()
                                        THEN @enddate + 4
                                        WHEN @flag = 5
                                             AND @enddate < GETDATE()
                                        THEN @enddate + 3
                                        WHEN @flag = 6
                                             AND @enddate < GETDATE()
                                        THEN @enddate + 2
                                        WHEN @flag = 7
                                             AND @enddate < GETDATE()
                                        THEN @enddate + 1
                                        ELSE @enddate
                                   END

	return @result
	
END
