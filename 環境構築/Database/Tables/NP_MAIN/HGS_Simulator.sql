USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[HGS_Simulator]    Script Date: 10/09/2021 09:13:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HGS_Simulator](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderFile] [nvarchar](832) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FileName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Processed] [bit] NOT NULL CONSTRAINT [DF_HGS_Simulator_Processed]  DEFAULT ((0)),
 CONSTRAINT [PK_HGS_Simulator] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
