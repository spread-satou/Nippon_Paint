USE [ORDER_RF1]
GO
/****** Object:  Table [dbo].[Cap_types]    Script Date: 10/09/2021 08:44:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cap_types](
	[Cap_Type] [int] IDENTITY(1,1) NOT NULL,
	[Cap_Description] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Hole_Size] [int] NULL,
	[Cap_Weight] [int] NULL,
	[Capping_Machine] [int] NULL
) ON [PRIMARY]
