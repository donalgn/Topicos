
create schema Production;

drop table [Production].[ProductSubcategory]

CREATE TABLE [Production].[ProductSubcategory](
	[ProductSubcategoryID] [int] ,
	[ProductCategoryID] [int] ,
	[Name] varchar (100),
	[rowguid] [uniqueidentifier] ROWGUIDCOL   DEFAULT (newid()),
	[ModifiedDate] [datetime]   DEFAULT (getdate()),
 ) 

GO

CREATE TABLE [Production].[ProductReview](
	[ProductReviewID] [int],
	[ProductID] [int],
	[ReviewerName] varchar (100),
	[ReviewDate] [datetime]   DEFAULT (getdate()),
	[EmailAddress] [nvarchar](50) NOT NULL,
	[Rating] [int],
	[Comments] [nvarchar](3850) NULL,
	[ModifiedDate] [datetime] 
) 

GO


CREATE TABLE [Production].[ProductModel](
	[ProductModelID] [int],
	[Name] varchar (100),
	[CatalogDescription] [xml] NULL,
	[Instructions] [xml] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL   DEFAULT (newid()),
	[ModifiedDate] [datetime]  DEFAULT (getdate()),
) 

GO

CREATE TABLE [Production].[Product](
	[ProductID] [int] NULL,
	[Name] varchar (100),
	[ProductNumber] [nvarchar](25)  NULL,
	[MakeFlag] bit DEFAULT ((1)),
	[FinishedGoodsFlag] bit  DEFAULT ((1)),
	[Color] [nvarchar](15) NULL,
	[SafetyStockLevel] [smallint]  NULL,
	[ReorderPoint] [smallint]  NULL,
	[StandardCost] [money]  NULL,
	[ListPrice] [money]  NULL,
	[Size] [nvarchar](5) NULL,
	[SizeUnitMeasureCode] [nchar](3) NULL,
	[WeightUnitMeasureCode] [nchar](3) NULL,
	[Weight] [decimal](8, 2) NULL,
	[DaysToManufacture] [int]  NULL,
	[ProductLine] [nchar](2) NULL,
	[Class] [nchar](2) NULL,
	[Style] [nchar](2) NULL,
	[ProductSubcategoryID] [int] NULL,
	[ProductModelID] [int] NULL,
	[SellStartDate] [datetime]  NULL,
	[SellEndDate] [datetime] NULL,
	[DiscontinuedDate] [datetime] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  DEFAULT (newid()),
	[ModifiedDate] [datetime] 
)

GO