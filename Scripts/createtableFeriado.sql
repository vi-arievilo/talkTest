USE [feriado]
GO

/****** Object:  Table [dbo].[feriado]    Script Date: 14/05/2021 14:36:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[feriado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [varchar](45)  NOT NULL,
	[title] [varchar](45) NOT NULL,
	[description] [varchar](255) NULL,
	[legislation] [varchar](255) NULL,
	[type] [varchar](45) NOT NULL,
	[startTime] [varchar](30) NULL,
	[endTime] [varchar](30) NULL,
	[variables] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[feriado] ADD  DEFAULT (NULL) FOR [legislation]
GO

ALTER TABLE [dbo].[feriado] ADD  DEFAULT (NULL) FOR [variables]
GO


