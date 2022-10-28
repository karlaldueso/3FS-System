USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spUsers_GetAll]    Script Date: 10/14/2022 9:36:56 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spUsers_GetAll]
as
begin
	set nocount on;
	
	select *
	from dbo.Users
end
GO

