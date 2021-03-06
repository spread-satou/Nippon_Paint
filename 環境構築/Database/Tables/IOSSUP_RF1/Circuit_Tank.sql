USE [IOSSUP_RF1]
GO
/****** Object:  Table [dbo].[Circuit_Tank]    Script Date: 10/09/2021 08:39:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Circuit_Tank](
	[Circuit_ID] [smallint] NOT NULL,
	[Tank_ID] [smallint] NOT NULL,
 CONSTRAINT [PK_Circuit_Tank] PRIMARY KEY CLUSTERED 
(
	[Circuit_ID] ASC,
	[Tank_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
