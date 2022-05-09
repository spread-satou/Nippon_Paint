USE [ORDER_RF1]
GO
/****** Object:  Table [dbo].[JISConv]    Script Date: 10/09/2021 08:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JISConv](
	[Hibyte] [int] NULL,
	[LoByte] [int] NULL,
	[HiJIS] [nvarchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoJIS] [nvarchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
