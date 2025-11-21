CREATE PROCEDURE [dbo].[UpdatePalay]
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
     UPDATE [dbo].[palay]
     SET [Variety] = @Variety,
         [Quantity] = @Quantity,
         [WeightUnit] = @WeightUnit,
         [MoistureContent] = @MoistureContent,
         [PricePerUnit] = @PricePerUnit,
         [HarvestDate] = @HarvestDate,
         [FarmerName] = @FarmerName
    WHERE
      [PalayId] = @PalayId
END
