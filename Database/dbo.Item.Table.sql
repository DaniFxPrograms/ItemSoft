USE [ItemCore]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 18/09/2012 17:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[Zupid] [nvarchar](max) NULL,
	[MerchantProductNumber] [nvarchar](max) NULL,
	[ProductName] [nvarchar](max) NULL,
	[ProductPrice] [nvarchar](max) NULL,
	[CurrencySymbolOfPrice] [nvarchar](max) NULL,
	[ValidFromDate] [nvarchar](max) NULL,
	[ValidToDate] [nvarchar](max) NULL,
	[ProductShortDescription] [nvarchar](max) NULL,
	[ProductLongDescription] [nvarchar](max) NULL,
	[MerhantProductCategory] [nvarchar](max) NULL,
	[ZanoxCategoryIds] [nvarchar](max) NULL,
	[ImageSmallUrl] [nvarchar](max) NULL,
	[ImageMediumUrl] [nvarchar](max) NULL,
	[ImageLargeUrl] [nvarchar](max) NULL,
	[ProductManufacturerBran] [nvarchar](max) NULL,
	[ZanoxProductLink] [nvarchar](max) NULL,
	[MerchantProductCategoryNumber] [nvarchar](max) NULL,
	[DeliveryTime] [nvarchar](max) NULL,
	[TermsOfContract] [nvarchar](max) NULL,
	[ProductEAN] [nvarchar](max) NULL,
	[ISBN] [nvarchar](max) NULL,
	[ShippingAndHandling] [nvarchar](max) NULL,
	[ShippingAndHandlingCost] [nvarchar](max) NULL,
	[ExtraTextOne] [nvarchar](max) NULL,
	[ExtraTextTwo] [nvarchar](max) NULL,
	[ExtraTextTree] [nvarchar](max) NULL,
	[Culture] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedOn] [datetime] NULL,
	[ProgramId] [nchar](10) NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
