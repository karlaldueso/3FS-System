USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spItemInventory_GetID_ByNameNBrandName]    Script Date: 10/14/2022 9:34:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[spItemInventory_GetID_ByNameNBrandName]
	@ItemName nvarchar(50),
	@BrandName nvarchar(50)
as
begin
	set nocount on;

	select ItemID
	from dbo.ItemInventory
	where (ItemName = @ItemName and
		  BrandName = @BrandName)
end
GO

