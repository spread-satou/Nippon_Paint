USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[HG_Log]    Script Date: 10/09/2021 09:12:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HG_Log](
	[HG_Log_Id] [int] IDENTITY(1,1) NOT NULL,
	[Notify_Msg] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Receive_Time] [datetime] NULL,
	[Contents_1] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Contents_2] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Contents_3] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Contents_4] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[File_Length] [int] NULL,
	[Errors] [nvarchar](57) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Rejected] [bit] NULL,
	[Acknowledged] [bit] NULL,
 CONSTRAINT [PK_HG_Log] PRIMARY KEY CLUSTERED 
(
	[HG_Log_Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
