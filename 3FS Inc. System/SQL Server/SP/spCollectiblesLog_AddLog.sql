USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spCollectiblesLog_AddLog]    Script Date: 10/14/2022 9:32:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spCollectiblesLog_AddLog]
	@CustomerID int,
	@Amount float,
	@TransactionDate datetime
as
begin
	set nocount on;
	insert into dbo.CollectiblesLog
	(CustomerID,Amount,TransactionDate)
		values (@CustomerID,
				@Amount,
				@TransactionDate)
end
GO

