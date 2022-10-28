USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spReceipts_AddReceipt]    Script Date: 10/14/2022 9:35:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[spReceipts_AddReceipt]
	@ReceiptNum nvarchar(50),
	@CustomerID int,
	@AmountPaid float,
	@GrandTotal float,
	@TransactionDate datetime
as
begin
	set nocount on;

	insert into dbo.Receipts
	(ReceiptNum,CustomerID,AmountPaid,GrandTotal,TransactionDate)
	values(@ReceiptNum, @CustomerID, @AmountPaid, @GrandTotal, @TransactionDate)
end
GO

