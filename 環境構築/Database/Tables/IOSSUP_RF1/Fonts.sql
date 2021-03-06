USE [IOSSUP_RF1]
GO
/****** Object:  Table [dbo].[Fonts]    Script Date: 10/09/2021 08:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fonts](
	[Font_1] [nvarchar](30) COLLATE Latin1_General_CI_AS NULL,
	[Font_2] [nvarchar](30) COLLATE Latin1_General_CI_AS NULL,
	[Font_3] [nvarchar](30) COLLATE Latin1_General_CI_AS NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Fonts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
