USE [ItemCore]
GO
/****** Object:  Table [dbo].[Pricing]    Script Date: 18/09/2012 15:26:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pricing](
	[PricingId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Path] [nvarchar](max) NULL,
	[Culture] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pricing] PRIMARY KEY CLUSTERED 
(
	[PricingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Pricing] ON 

INSERT [dbo].[Pricing] ([PricingId], [Name], [Path], [Culture]) VALUES (1, N'PixmaniaTest', N'http://productdata.zanox.com/exportservice/v1/rest/19747679C1252883186.csv?ticket=D10891472561713F1128A466542E92402F691BBF3BE93D4032CC8207B55FC142&columnDelimiter=TAB&textQualifier=none&nullOutputFormat=NullValue&dateFormat=dd/MM/yyyy HH:mm:ss&decimalSeparator=period&gZipCompress=yes&id&nb&na&pp&cy&df&ds&dl&mc&zi&ia&im&il&mn&lk&td&tm&is&sh&sn&po&ea', N'it-IT')
SET IDENTITY_INSERT [dbo].[Pricing] OFF
