USE [ItemCore]
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 18/09/2012 17:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[ItemId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_ItemCategory_1] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ItemCategory]  WITH CHECK ADD  CONSTRAINT [FK_ItemCategory_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[ItemCategory] CHECK CONSTRAINT [FK_ItemCategory_Category]
GO
ALTER TABLE [dbo].[ItemCategory]  WITH CHECK ADD  CONSTRAINT [FK_ItemCategory_Item] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Item] ([ItemId])
GO
ALTER TABLE [dbo].[ItemCategory] CHECK CONSTRAINT [FK_ItemCategory_Item]
GO
