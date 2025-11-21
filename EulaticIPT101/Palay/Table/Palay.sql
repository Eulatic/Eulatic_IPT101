CREATE TABLE palay (
  PalayId INT PRIMARY KEY,
  Variety VARCHAR(100) NOT NULL,
  Quantity DECIMAL(10, 2) NOT NULL,
  WeightUnit VARCHAR(10) NOT NULL,
  MoistureContent DECIMAL(5, 2),
  PricePerUnit DECIMAL(10, 2) NOT NULL,
  HarvestDate DATE,
  FarmerName VARCHAR(255)
);