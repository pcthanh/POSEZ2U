USE [POSEZ2U_V1]
GO
/****** Object:  UserDefinedFunction [dbo].[Auto_Create_Code]    Script Date: 1/3/2016 11:00:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Thien Huynh>
-- Create date: <03/01/2016>
-- Description:	<Auto_Create_Code>
-- =============================================


-- SELECT [dbo].[Auto_Create_Code] ('P',1)


ALTER FUNCTION [dbo].[Auto_Create_Code]
(
	@StartCode NVARCHAR(1)='',
	@id int
)
RETURNS nvarchar(10)
AS
BEGIN	
	declare @length int
	declare @zeroes nvarchar(10)
	declare @zcount int -- the number of zeroes
	set @zcount = 0
	set @zeroes = ''
	set @length = len(cast(@id as nvarchar))
	while( @zcount + @length < 9 ) begin
		set @zeroes = @zeroes + '0'
		set @zcount = @zcount + 1
	end	
	return @StartCode + @zeroes + cast(@id as nvarchar)
	
END


