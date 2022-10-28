USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spItemInventory_UpdateQtyByID]    Script Date: 10/14/2022 9:34:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[spItemInventory_UpdateQtyByID]
	@ItemID int,
	@Qty float,
	@TransactionType int
as
begin
	set nocount on;
	update dbo.ItemInventory
	set Quantity = case 
					when (@TransactionType=1) --Sales(deduct)
						then (Quantity-@Qty) 
					when (@TransactionType=2) --Added Supply(add)
						then (Quantity+@Qty)
					else 
						(Quantity) 
					end
	where ItemID = @ItemID
end
GO

