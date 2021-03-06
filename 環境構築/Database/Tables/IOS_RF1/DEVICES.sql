USE [IOS_RF1]
GO
/****** Object:  Table [dbo].[DEVICES]    Script Date: 10/09/2021 08:36:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEVICES](
	[Device] [smallint] NOT NULL,
	[Description] [nvarchar](20) COLLATE Latin1_General_CI_AS NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_DEVICES] PRIMARY KEY CLUSTERED 
(
	[Device] ASC,
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
