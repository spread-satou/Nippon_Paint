USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[HG_Log_Archive]    Script Date: 10/09/2021 09:12:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HG_Log_Archive](
	[HG_Log_Id] [int] NOT NULL,
	[Notify_Msg] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Receive_Time] [datetime] NULL,
	[Contents_1] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Contents_2] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Contents_3] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Contents_4] [nvarchar](67) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[File_Length] [int] NULL,
	[Errors] [nvarchar](55) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Rejected] [bit] NULL,
	[Acknowledged] [bit] NULL
) ON [PRIMARY]
