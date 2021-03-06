USE [IOSSUP_RF1]
GO
/****** Object:  Table [dbo].[Tank_Stirring_Motor]    Script Date: 10/09/2021 08:42:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tank_Stirring_Motor](
	[Tank_ID] [smallint] NOT NULL,
	[Stirring_Motor_ID] [smallint] NOT NULL,
 CONSTRAINT [PK_Tank_Stirring_Motor] PRIMARY KEY CLUSTERED 
(
	[Tank_ID] ASC,
	[Stirring_Motor_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
