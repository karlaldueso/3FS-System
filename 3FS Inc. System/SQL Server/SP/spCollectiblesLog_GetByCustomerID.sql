USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spCollectiblesLog_GetByCustomerID]    Script Date: 10/14/2022 9:32:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[spCollectiblesLog_GetByCustomerID]
	@CustomerID int 
as
begin
	set nocount on;

	select *
	from CollectiblesLog CL
	where CL.CustomerID = @CustomerID
end
GO

