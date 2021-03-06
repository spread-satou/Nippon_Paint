USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[Fonts]    Script Date: 10/09/2021 09:12:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fonts](
	[Fonts_Id] [int] IDENTITY(1,1) NOT NULL,
	[Font_1] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Font_2] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Font_3] [nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Fonts] PRIMARY KEY CLUSTERED 
(
	[Fonts_Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
