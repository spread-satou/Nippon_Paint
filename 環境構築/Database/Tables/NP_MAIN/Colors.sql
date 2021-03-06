USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 10/09/2021 09:12:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Colors_Id] [int] IDENTITY(1,1) NOT NULL,
	[RF_Display_Colors] [int] NULL,
	[RGB] [int] NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[Colors_Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
