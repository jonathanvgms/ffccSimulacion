USE [ffcc]
GO
/****** Object:  Table [dbo].[Coche]    Script Date: 03/08/2015 20:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Coche](
	[idCoche] [int] NOT NULL,
	[cantidadPasajeros] [int] NOT NULL,
	[cantidadExtra] [int] NOT NULL,
	[tipoConsumo] [int] NOT NULL,
	[cantidadConsumo] [int] NOT NULL,
	[modelo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Vagon] PRIMARY KEY CLUSTERED 
(
	[idCoche] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CochePorFormacion]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CochePorFormacion](
	[idFormacion] [int] NOT NULL,
	[idVagon] [int] NOT NULL,
 CONSTRAINT [PK_VagonPorFormacion] PRIMARY KEY CLUSTERED 
(
	[idFormacion] ASC,
	[idVagon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estacion]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estacion](
	[idEstacion] [int] NOT NULL,
	[nombreEstacion] [varchar](50) NOT NULL,
	[distanciaRecorrido] [decimal](18, 0) NOT NULL,
	[tiempoRecorrido] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Estacion] PRIMARY KEY CLUSTERED 
(
	[idEstacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstacionPorTraza]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstacionPorTraza](
	[idEstacion] [int] NOT NULL,
	[idTraza] [int] NOT NULL,
 CONSTRAINT [PK_EstacionPorTraza] PRIMARY KEY CLUSTERED 
(
	[idEstacion] ASC,
	[idTraza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Formacion]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formacion](
	[idFormacion] [int] NOT NULL,
	[totalConsumo] [int] NOT NULL,
 CONSTRAINT [PK_Formacion] PRIMARY KEY CLUSTERED 
(
	[idFormacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FormacionPorSimulacion]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormacionPorSimulacion](
	[idFormacion] [int] NOT NULL,
	[idSimulacion] [int] NOT NULL,
 CONSTRAINT [PK_FormacionPorSimulacion] PRIMARY KEY CLUSTERED 
(
	[idFormacion] ASC,
	[idSimulacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Incidente]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Incidente](
	[idIncidente] [int] NOT NULL,
	[tipoIncidente] [varchar](50) NOT NULL,
	[cantidadDemora] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Incidente] PRIMARY KEY CLUSTERED 
(
	[idIncidente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[idServicio] [int] NOT NULL,
	[idFormacion] [int] NOT NULL,
	[deIdEstacion] [int] NOT NULL,
	[haciaIdEstacion] [int] NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Simulacion]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Simulacion](
	[idSimulacion] [int] NOT NULL,
	[idFormacion] [int] NOT NULL,
	[idTraza] [int] NOT NULL,
	[fechaSimulacion] [date] NOT NULL,
 CONSTRAINT [PK_Simulacion] PRIMARY KEY CLUSTERED 
(
	[idSimulacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Traza]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Traza](
	[idTraza] [int] NOT NULL,
	[nombreTraza] [varchar](50) NOT NULL,
	[idIncidente] [int] NOT NULL,
 CONSTRAINT [PK_Traza] PRIMARY KEY CLUSTERED 
(
	[idTraza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrazaPorSimulacion]    Script Date: 03/08/2015 20:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrazaPorSimulacion](
	[idTraza] [int] NOT NULL,
	[idSimulacion] [int] NOT NULL,
 CONSTRAINT [PK_TrazaPorSimulacion] PRIMARY KEY CLUSTERED 
(
	[idTraza] ASC,
	[idSimulacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CochePorFormacion]  WITH CHECK ADD  CONSTRAINT [FK_VagonPorFormacion_Formacion] FOREIGN KEY([idFormacion])
REFERENCES [dbo].[Formacion] ([idFormacion])
GO
ALTER TABLE [dbo].[CochePorFormacion] CHECK CONSTRAINT [FK_VagonPorFormacion_Formacion]
GO
ALTER TABLE [dbo].[CochePorFormacion]  WITH CHECK ADD  CONSTRAINT [FK_VagonPorFormacion_Vagon] FOREIGN KEY([idVagon])
REFERENCES [dbo].[Coche] ([idCoche])
GO
ALTER TABLE [dbo].[CochePorFormacion] CHECK CONSTRAINT [FK_VagonPorFormacion_Vagon]
GO
ALTER TABLE [dbo].[EstacionPorTraza]  WITH CHECK ADD  CONSTRAINT [FK_EstacionPorTraza_Estacion] FOREIGN KEY([idEstacion])
REFERENCES [dbo].[Estacion] ([idEstacion])
GO
ALTER TABLE [dbo].[EstacionPorTraza] CHECK CONSTRAINT [FK_EstacionPorTraza_Estacion]
GO
ALTER TABLE [dbo].[EstacionPorTraza]  WITH CHECK ADD  CONSTRAINT [FK_EstacionPorTraza_Traza] FOREIGN KEY([idTraza])
REFERENCES [dbo].[Traza] ([idTraza])
GO
ALTER TABLE [dbo].[EstacionPorTraza] CHECK CONSTRAINT [FK_EstacionPorTraza_Traza]
GO
ALTER TABLE [dbo].[FormacionPorSimulacion]  WITH CHECK ADD  CONSTRAINT [FK_FormacionPorSimulacion_Formacion] FOREIGN KEY([idFormacion])
REFERENCES [dbo].[Formacion] ([idFormacion])
GO
ALTER TABLE [dbo].[FormacionPorSimulacion] CHECK CONSTRAINT [FK_FormacionPorSimulacion_Formacion]
GO
ALTER TABLE [dbo].[FormacionPorSimulacion]  WITH CHECK ADD  CONSTRAINT [FK_FormacionPorSimulacion_Simulacion] FOREIGN KEY([idSimulacion])
REFERENCES [dbo].[Simulacion] ([idSimulacion])
GO
ALTER TABLE [dbo].[FormacionPorSimulacion] CHECK CONSTRAINT [FK_FormacionPorSimulacion_Simulacion]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Estacion] FOREIGN KEY([deIdEstacion])
REFERENCES [dbo].[Estacion] ([idEstacion])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Estacion]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Estacion1] FOREIGN KEY([haciaIdEstacion])
REFERENCES [dbo].[Estacion] ([idEstacion])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Estacion1]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Formacion] FOREIGN KEY([idFormacion])
REFERENCES [dbo].[Formacion] ([idFormacion])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Formacion]
GO
ALTER TABLE [dbo].[Traza]  WITH CHECK ADD  CONSTRAINT [FK_Traza_Incidente] FOREIGN KEY([idIncidente])
REFERENCES [dbo].[Incidente] ([idIncidente])
GO
ALTER TABLE [dbo].[Traza] CHECK CONSTRAINT [FK_Traza_Incidente]
GO
ALTER TABLE [dbo].[TrazaPorSimulacion]  WITH CHECK ADD  CONSTRAINT [FK_TrazaPorSimulacion_Simulacion] FOREIGN KEY([idSimulacion])
REFERENCES [dbo].[Simulacion] ([idSimulacion])
GO
ALTER TABLE [dbo].[TrazaPorSimulacion] CHECK CONSTRAINT [FK_TrazaPorSimulacion_Simulacion]
GO
ALTER TABLE [dbo].[TrazaPorSimulacion]  WITH CHECK ADD  CONSTRAINT [FK_TrazaPorSimulacion_Traza] FOREIGN KEY([idTraza])
REFERENCES [dbo].[Traza] ([idTraza])
GO
ALTER TABLE [dbo].[TrazaPorSimulacion] CHECK CONSTRAINT [FK_TrazaPorSimulacion_Traza]
GO
