USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[JISConv]    Script Date: 10/09/2021 09:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JISConv](
	[JISConv_Id] [int] IDENTITY(1,1) NOT NULL,
	[Hibyte] [int] NULL,
	[LoByte] [int] NULL,
	[HiJIS] [nvarchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoJIS] [nvarchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_JISConv] PRIMARY KEY CLUSTERED 
(
	[JISConv_Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
