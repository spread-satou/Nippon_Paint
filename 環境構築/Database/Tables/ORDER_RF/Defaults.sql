USE [ORDER_RF1]
GO
/****** Object:  Table [dbo].[Defaults]    Script Date: 10/09/2021 08:44:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Defaults](
	[White_Code] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Can_Type] [int] NULL,
	[Cap_Type] [int] NULL,
	[Overfilling] [float] NULL,
	[Prefill_Amount] [int] NULL,
	[Mixing_Time] [int] NULL,
	[Mixing_Speed] [int] NULL
) ON [PRIMARY]
