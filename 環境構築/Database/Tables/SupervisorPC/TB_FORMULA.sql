CREATE TABLE [dbo].[TB_FORMULA](
[PRD_BARCODE] [nvarchar](50) NOT NULL,
[PROCESS_CODE] [nvarchar](12) NOT NULL,
[PRD_TIME_INSERTED] [datetime] NULL,
[PRD_STATUS] [int] NULL,
[PRD_CODE] [nvarchar](100) NOT NULL,
[PRD_DESC] [nvarchar](255) NULL,
[UM] [int] NULL,
[PRD_SPECIFIC_GRAVITY] [int] NULL,
[PRD_QTY_REQ] [float] NULL,
[PRD_QTY_DISP] [float] NOT NULL,
[PRD_START_DISP] [datetime] NULL,
[PRD_END_DISP] [datetime] NULL,
[PRD_PRIORITY] [int] NULL,
[PRD_NUM] [int] NULL,
[PRD_ISPREFILLED] [int] NULL,
[PRD_PREFILLED_QTY] [float] NULL,
CONSTRAINT [PK_TB_FORMULA] PRIMARY KEY CLUSTERED
(
[PRD_BARCODE] ASC,
[PROCESS_CODE] ASC,
[PRD_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS
= ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]