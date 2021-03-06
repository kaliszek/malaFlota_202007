USE [db_malaFlota]
GO
/****** Object:  User [crXI]    Script Date: 2015-09-07 19:35:04 ******/
CREATE USER [crXI] FOR LOGIN [crXI] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [crXI]
GO
/****** Object:  Table [dbo].[KIEROWCA]    Script Date: 2015-09-07 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KIEROWCA](
	[ID_KIEROWCA] [int] IDENTITY(1,1) NOT NULL,
	[IMIE] [varchar](50) NULL,
	[NAZWISKO] [varchar](50) NULL,
	[PESEL] [varchar](11) NULL,
	[MIASTO] [varchar](50) NULL,
	[ULICA] [varchar](50) NULL,
	[KODP] [varchar](10) NULL,
	[POCZTA] [varchar](50) NULL,
	[NR_DOMU] [varchar](10) NULL,
	[NR_LOKALU] [varchar](5) NULL,
	[DATA_UR] [datetime] NULL,
	[DATA_BAD_LEK] [datetime] NULL,
	[TEL1] [varchar](15) NULL,
	[TEL2] [varchar](15) NULL,
	[KATA] [tinyint] NULL,
	[KATB] [tinyint] NULL,
	[KATC] [tinyint] NULL,
	[KATD] [tinyint] NULL,
	[UPRAWNIENIA] [varchar](50) NULL,
 CONSTRAINT [PK_KIEROWCA] PRIMARY KEY CLUSTERED 
(
	[ID_KIEROWCA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LICZNIK]    Script Date: 2015-09-07 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICZNIK](
	[ID_LICZNIK] [int] IDENTITY(1,1) NOT NULL,
	[ID_POJAZD_LICZNIK] [int] NULL,
	[WARTOSC_LICZNIK] [numeric](14, 2) NULL,
	[DATA_LICZNIK] [datetime] NULL,
 CONSTRAINT [PK_LICZNIK] PRIMARY KEY CLUSTERED 
(
	[ID_LICZNIK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MUzytkownik]    Script Date: 2015-09-07 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MUzytkownik](
	[MU_Id] [int] NULL,
	[MU_Nazwa] [varchar](50) NULL,
	[MU_Haslo] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PALIWO]    Script Date: 2015-09-07 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PALIWO](
	[ID_PALIWO] [int] IDENTITY(1,1) NOT NULL,
	[PALIWO_NAZWA] [varchar](20) NULL,
 CONSTRAINT [PK_PALIWO] PRIMARY KEY CLUSTERED 
(
	[ID_PALIWO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[POJAZD]    Script Date: 2015-09-07 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[POJAZD](
	[ID_POJAZD] [int] IDENTITY(1,1) NOT NULL,
	[NR_REJ] [varchar](10) NULL,
	[MARKA] [varchar](50) NULL,
	[MODEL] [varchar](50) NULL,
	[POJEMNOSC] [numeric](14, 2) NULL,
	[ROK_PROD] [varchar](50) NULL,
	[ID_RODZAJ_POJAZD] [int] NULL,
	[NR_SILNIK] [varchar](50) NULL,
	[NR_NADWOZIE] [varchar](50) NULL,
	[ID_PALIWO_POJAZD] [int] NULL,
	[ZBIORNIK] [numeric](14, 2) NULL,
	[STAN_LICZ_POCZ] [numeric](14, 2) NULL,
	[NUMER_OC] [varchar](50) NULL,
	[DATA_OC] [datetime] NULL,
	[POLISA_AC] [tinyint] NULL,
	[NUMER_AC] [varchar](50) NULL,
	[DATA_AC] [datetime] NULL,
	[DATA_BAD_TECH] [datetime] NULL,
	[LICZ_BAD_TECH] [numeric](14, 2) NULL,
	[GWARANCJA] [tinyint] NULL,
	[DATA_GWARANCJA] [datetime] NULL,
	[STAN_LICZ_GWAR] [numeric](14, 2) NULL,
 CONSTRAINT [IX_POJAZD] UNIQUE NONCLUSTERED 
(
	[ID_POJAZD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RODZAJ]    Script Date: 2015-09-07 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RODZAJ](
	[ID_RODZAJ] [int] IDENTITY(1,1) NOT NULL,
	[RODZAJ_NAZWA] [varchar](30) NULL,
 CONSTRAINT [PK_RODZAJ] PRIMARY KEY CLUSTERED 
(
	[ID_RODZAJ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TANK]    Script Date: 2015-09-07 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TANK](
	[ID_TANK] [int] IDENTITY(1,1) NOT NULL,
	[ID_TRASA_TANK] [int] NULL,
	[ID_POJAZD_TANK] [int] NULL,
	[DATA_TANK] [datetime] NULL,
	[ILOSC_TANK] [numeric](14, 2) NULL,
	[WARTOSC_TANK] [numeric](14, 2) NULL,
	[LICZNIK_TANK] [numeric](14, 0) NULL,
	[ID_RODZAJ_PALIWA_TANK] [int] NULL,
 CONSTRAINT [PK_TANK] PRIMARY KEY CLUSTERED 
(
	[ID_TANK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRASA]    Script Date: 2015-09-07 19:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRASA](
	[ID_TRASA] [int] IDENTITY(1,1) NOT NULL,
	[ID_KIEROWCA_TRASA] [int] NULL,
	[ID_POJAZD_TRASA] [int] NULL,
	[DATA_WYJAZD] [datetime] NULL,
	[DATA_PRZYJAZD] [datetime] NULL,
	[STAN_LICZ_POCZ] [decimal](12, 0) NULL,
	[STAN_LICZ_KONIEC] [decimal](12, 0) NULL,
	[ID_TANK_TRASA] [int] NULL,
	[KONIEC_TRASA] [tinyint] NULL,
 CONSTRAINT [PK_TRASA] PRIMARY KEY CLUSTERED 
(
	[ID_TRASA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[TANK]  WITH CHECK ADD  CONSTRAINT [FK_TRASA_KIEROWCA] FOREIGN KEY([ID_TRASA_TANK])
REFERENCES [dbo].[TRASA] ([ID_TRASA])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TANK] CHECK CONSTRAINT [FK_TRASA_KIEROWCA]
GO
ALTER TABLE [dbo].[TRASA]  WITH CHECK ADD  CONSTRAINT [FK_TRASA_TRASA] FOREIGN KEY([ID_TRASA])
REFERENCES [dbo].[TRASA] ([ID_TRASA])
GO
ALTER TABLE [dbo].[TRASA] CHECK CONSTRAINT [FK_TRASA_TRASA]
GO
