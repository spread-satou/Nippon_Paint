USE [ORDER_RF1]
GO
/****** Object:  Table [dbo].[Can_types]    Script Date: 10/09/2021 08:43:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Can_types](
	[Can_Type] [int] IDENTITY(1,1) NOT NULL,
	[Can_Description] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Hole_Size] [int] NULL,
	[Available_Volume] [int] NULL,
	[Can_Weight] [int] NULL,
	[Nominal_Volume] [int] NULL
) ON [PRIMARY]
