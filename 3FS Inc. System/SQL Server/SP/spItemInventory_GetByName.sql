USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spItemInventory_GetByName]    Script Date: 10/14/2022 9:34:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[spItemInventory_GetByName]
	@ItemName nvarchar(50),
	@BrandName nvarchar(50)
as
begin
	set nocount on;

	select *
	from dbo.ItemInventory
	where ItemName like '%'+@ItemName+'%' and BrandName like '%'+@BrandName+'%';
end
GO

