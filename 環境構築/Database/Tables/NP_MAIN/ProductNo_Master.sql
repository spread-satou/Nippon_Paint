USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[ProductNo_Master]    Script Date: 10/09/2021 09:15:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductNo_Master](
	[PRD_ID] [int] IDENTITY(1,1) NOT NULL,
	[Product_No] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
