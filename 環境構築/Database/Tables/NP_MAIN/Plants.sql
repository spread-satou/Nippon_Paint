USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[Plants]    Script Date: 10/09/2021 09:14:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plants](
	[Plant_ID] [int] IDENTITY(1,1) NOT NULL,
	[Plant_Description] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Latest_Used] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Daily_Capability] [int] NULL,
	[Daily_Working_Time] [int] NULL,
	[Start_Working_Time] [datetime] NULL,
	[CSV_Printing_Location] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Last_CSV_Code] [int] NULL,
	[SS_Code] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Water_Borne] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Barcode_prefix] [nvarchar](1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SS_Code_Simulator] [nvarchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Solvent_Borne] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Plants] PRIMARY KEY CLUSTERED 
(
	[Plant_ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
