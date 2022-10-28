USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spReceipts_GetByCustomerID]    Script Date: 10/14/2022 9:36:13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spReceipts_GetByCustomerID]
	@CustomerID int 
as
begin
	set nocount on;

	select *
	from Receipts R
	where R.CustomerID = @CustomerID
	order by R.TransactionDate;
end
GO

