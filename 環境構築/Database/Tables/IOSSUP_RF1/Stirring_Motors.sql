USE [IOSSUP_RF1]
GO
/****** Object:  Table [dbo].[Stirring_Motors]    Script Date: 10/09/2021 08:42:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stirring_Motors](
	[ID] [smallint] NOT NULL,
	[STIRRING_DURATION] [smallint] NULL,
	[STIRRING_PERIOD] [smallint] NULL,
 CONSTRAINT [PK_Stirring_Motors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
