USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spSales_AddSales]    Script Date: 10/14/2022 9:36:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spSales_AddSales]
	@ReceiptNum nvarchar(50),
	@Qty float,
	@Unit nvarchar(50),
	@ItemID int,
	@UnitPrice float,
	@SubTotal float,
	@TransactionDate datetime
as
begin
	set nocount on;

	insert into dbo.Sales
	(ReceiptNum,Qty,Unit,ItemID,UnitPrice,SubTotal,TransactionDate)
	values (@ReceiptNum,
			@Qty,
			@Unit,
			@ItemID,
			@UnitPrice,
			@SubTotal,
			@TransactionDate)
end
GO

