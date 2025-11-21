CREATE PROCEDURE [dbo].[CreatePalay]
	@PalayId INT,
    @Variety VARCHAR(100) = NULL,
    @Quantity DECIMAL(10, 2) = NULL,
    @WeightUnit VARCHAR(10) = NULL,
    @MoistureContent DECIMAL(5, 2) = NULL,
    @PricePerUnit DECIMAL(10, 2) = NULL,
    @HarvestDate DATE = NULL,
    @FarmerName VARCHAR(255) = NULL
AS
BEGIN
     INSERT INTO [dbo].[palay] ([PalayId], [Variety], [Quantity], [WeightUnit], [MoistureContent], [PricePerUnit], [HarvestDate], [FarmerName])
     VALUES (@PalayId, @Variety, @Quantity, @WeightUnit, @MoistureContent, @PricePerUnit, @HarvestDate, @FarmerName)
END
