USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spItemInventory_AddItem]    Script Date: 10/14/2022 9:33:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spItemInventory_AddItem]
	@ItemName nvarchar(50),
	@BrandName nvarchar(50),
	@CategoryID float,
	@Quantity float,
	@Unit nvarchar(50),
	@SRP float,
	@Capital float,
	@Storage nvarchar(50)
as
begin
	set nocount on;

	insert into dbo.ItemInventory
	(ItemName,BrandName,CategoryID,Quantity,Unit,SRP,Capital,Storage)
		values (@ItemName,
				@BrandName,
				@CategoryID,
				@Quantity,
				@Unit,
				@SRP,
				@Capital,
				@Storage);
end
GO

