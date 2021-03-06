USE [IOS_RF1]
GO
/****** Object:  Table [dbo].[RSTALMS]    Script Date: 10/09/2021 08:37:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RSTALMS](
	[Tagname] [nvarchar](40) COLLATE Latin1_General_CI_AS NOT NULL,
	[Bit] [smallint] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_RSTALMS] PRIMARY KEY CLUSTERED 
(
	[Tagname] ASC,
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
