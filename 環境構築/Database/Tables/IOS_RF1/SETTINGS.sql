USE [IOS_RF1]
GO
/****** Object:  Table [dbo].[SETTINGS]    Script Date: 10/09/2021 08:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SETTINGS](
	[Autostart] [bit] NULL,
	[Timer] [int] NULL,
	[CardNumber] [smallint] NOT NULL,
	[LogFileEnabled] [bit] NULL,
	[LogFileName] [nvarchar](128) COLLATE Latin1_General_CI_AS NULL,
	[LogFileClear] [bit] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SETTINGS_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
