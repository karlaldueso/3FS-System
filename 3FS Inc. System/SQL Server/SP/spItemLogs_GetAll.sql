USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spItemLogs_GetAll]    Script Date: 10/14/2022 9:35:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[spItemLogs_GetAll]
as
begin
	set nocount on;

	select II.ItemName,II.BrandName,IL.TransactionType,IL.Previous,IL.Present,IL.TransactionDate
	from ItemLogs IL
	inner join ItemInventory II on IL.ItemID=II.ItemID

end
GO

