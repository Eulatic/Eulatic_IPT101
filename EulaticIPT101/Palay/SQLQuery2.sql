DECLARE @PalayId INT = N'123'
EXEC
dbo.DeletePalay @PalayId;
GO
SELECT * FROM dbo.Palay
GO
