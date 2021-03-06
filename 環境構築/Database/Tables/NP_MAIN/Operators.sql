USE [NP_MAIN]
GO
/****** Object:  Table [dbo].[Operators]    Script Date: 10/09/2021 09:13:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operators](
	[Operators_Id] [int] IDENTITY(1,1) NOT NULL,
	[Operator_Code] [nvarchar](2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Operator_Name] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Operators] PRIMARY KEY CLUSTERED 
(
	[Operators_Id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
