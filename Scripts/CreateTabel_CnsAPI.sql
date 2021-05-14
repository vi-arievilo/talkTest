USE [feriado]
GO

/****** Object:  Table [dbo].[consultaApi]    Script Date: 14/05/2021 15:18:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[consultaApi](
	[id] [int] NULL,
	[name] [varchar](50) NULL,
	[url] [varchar](300) NULL,
	[isActive] [char](10) NULL
) ON [PRIMARY]
GO


insert into consultaApi values(1,'API Teste','http://dadosbr.github.io/feriados/nacionais.json', 1)