USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spItemLogs_AddLog]    Script Date: 10/14/2022 9:35:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spItemLogs_AddLog]
	@ItemID int,
	@TransactionType nvarchar(50),
	@Previous nvarchar(50),
	@Present nvarchar(50),
	@TransactionDate datetime
as
begin
	set nocount on;
	insert into dbo.ItemLogs
	(ItemID,TransactionType,Previous,Present,TransactionDate)
		values (@ItemID,
				@TransactionType,
				@Previous,
				@Present,
				@TransactionDate)
end
GO

