USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spCustomerProfile_UpdateCredit]    Script Date: 10/14/2022 9:33:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spCustomerProfile_UpdateCredit]
	@CustomerID int,
	@Amount int
as
begin
	set nocount on;
	update dbo.CustomerProfile
	set Credit = Credit+@Amount
	where CustomerID = @CustomerID
end
GO

