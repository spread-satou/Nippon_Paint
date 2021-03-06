USE [ORDER_RF1]
GO
/****** Object:  Table [dbo].[Label_Items]    Script Date: 10/09/2021 08:44:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Label_Items](
	[Label_Type] [int] NULL,
	[Field_Name] [nvarchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Font_Name] [nvarchar](80) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Font_Size] [int] NULL,
	[Font_Bold] [bit] NULL,
	[Position_X] [int] NULL,
	[Position_Y] [int] NULL,
	[Left_Aligned] [bit] NULL,
	[Center_Aligned] [bit] NULL,
	[Caption] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
