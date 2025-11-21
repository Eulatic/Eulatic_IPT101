CREATE PROCEDURE [dbo].[SelectPalay]
	@PalayId NVARCHAR (40) = NULL
AS
BEGIN
    SELECT * FROM [dbo].[Palay] AS a WHERE a.[PalayId] = @PalayId
END
