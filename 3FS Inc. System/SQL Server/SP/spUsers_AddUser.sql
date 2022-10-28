USE [3FS Database]
GO

/****** Object:  StoredProcedure [dbo].[spUsers_AddUser]    Script Date: 10/14/2022 9:36:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



--exec dbo.spItemInventory_GetAll

--exec dbo.spItemInventory_GetByName 'Test'
/*
exec dbo.spItemInventory_AddItem 'Cement','Holcim',1,3,'Bags',250,200,'Bodega A'

select *
from dbo.ItemInventory
*/

CREATE PROCEDURE [dbo].[spUsers_AddUser]
    @UserName NVARCHAR(50), 
    @PW NVARCHAR(50), 
	@UserType int,
    @FirstName NVARCHAR(40) = NULL, 
    @LastName NVARCHAR(40) = NULL,
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON

    BEGIN TRY

        INSERT INTO dbo.[Users] (UserName, PW, UserType, FirstName, LastName)
        VALUES(@UserName, HASHBYTES('SHA2_512', @PW), @UserType, @FirstName, @LastName)

        SET @responseMessage='Success'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END
GO

