USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spItemInventory_GetAll]    Script Date: 10/14/2022 9:33:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spItemInventory_GetAll]
as
begin
	set nocount on;

	select *
	from dbo.ItemInventory;
end
GO

