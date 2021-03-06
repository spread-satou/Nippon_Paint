USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[Translations]    Script Date: 10/09/2021 09:16:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Translations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NATIVE] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FOREIGN_1] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FOREIGN_2] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_Translations] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
