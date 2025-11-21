CREATE PROCEDURE [dbo].[DeletePalay]
	@PalayId NVARCHAR (40) = NULL
AS
BEGIN
     DELETE FROM [dbo].[palay] WHERE PalayId = @PalayId 
END