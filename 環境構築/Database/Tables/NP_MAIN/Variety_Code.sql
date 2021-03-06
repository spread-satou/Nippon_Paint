USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[Variety_Code]    Script Date: 10/09/2021 09:16:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Variety_Code](
	[VAR_ID] [int] IDENTITY(1,1) NOT NULL,
	[Variety_Code_OLD] [nvarchar](8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Package_OLD] [nvarchar](8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Variety_Code_NEW] [nvarchar](8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Package_NEW] [nvarchar](8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
