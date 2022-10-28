USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spCustomerProfile_GetByName]    Script Date: 10/14/2022 9:32:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spCustomerProfile_GetByName]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
as
begin
	set nocount on;

	select *
	from dbo.CustomerProfile
	where FirstName like '%'+@FirstName+'%' or LastName like '%'+@LastName+'%';
end
GO

