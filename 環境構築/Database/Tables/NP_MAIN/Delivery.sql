USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 10/09/2021 09:12:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery](
	[HG_Delivery_Code] [int] NULL,
	[Sort_Order] [int] NULL,
	[HG_Delivery_Kanji] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Must_Notify] [bit] NULL,
	[Default_Delivery_Time] [datetime] NULL,
	[Time_CanChange] [bit] NULL
) ON [PRIMARY]
