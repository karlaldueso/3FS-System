USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spItemInventory_UpdateItem]    Script Date: 10/14/2022 9:34:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spItemInventory_UpdateItem]
	
	@ItemID int,

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

	update dbo.ItemInventory

	set	ItemName = @ItemName,
		BrandName = @BrandName,
		CategoryID = @CategoryID,
		Quantity = @Quantity,
		Unit = @Unit,
		SRP = @SRP,
		Capital =  @Capital,
		Storage = @Storage

	where ItemID = @ItemID

end
GO

