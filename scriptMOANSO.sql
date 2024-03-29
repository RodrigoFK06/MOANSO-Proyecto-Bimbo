USE [bdProyectoBimbo]
GO
/****** Object:  Table [dbo].[Actividad]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actividad](
	[idActividad] [int] IDENTITY(1,1) NOT NULL,
	[NombreActividad] [varchar](50) NULL,
	[Descripcion] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idActividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[idArea] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cronograma]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cronograma](
	[idCronograma] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](max) NULL,
	[Descripcion] [varchar](max) NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[idResolucionEncuesta] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[idActividad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCronograma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEvaluacionDesempeño](
	[idDetalleEvaluacionDesempeño] [int] IDENTITY(1,1) NOT NULL,
	[Nota] [int] NOT NULL,
	[idPreguntasEvaluacionDesempeño] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetalleEvaluacionDesempeño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[NombreEmpleado] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[FechaContratacion] [date] NULL,
	[Puesto] [varchar](50) NULL,
	[Area] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Encuesta]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Encuesta](
	[idEncuesta] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[FechaCierre] [date] NULL,
	[Titulo] [varchar](50) NULL,
	[idArea] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEncuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstandarCompetencia]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstandarCompetencia](
	[idEstandarCompetencia] [int] IDENTITY(1,1) NOT NULL,
	[NivelRequerido] [int] NULL,
	[Descripcion] [varchar](max) NULL,
	[idArea] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEstandarCompetencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EvaluacionDesempeño]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EvaluacionDesempeño](
	[idEvaluacionDesempeño] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[FechaCierre] [date] NOT NULL,
	[Titulo] [varchar](50) NULL,
	[Descripcion] [varchar](max) NULL,
	[idArea] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEvaluacionDesempeño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NecesidadesFormativas]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NecesidadesFormativas](
	[idNecesidadesFormativas] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[FechaImplementacion] [date] NOT NULL,
	[Necesidades] [varchar](max) NULL,
	[idEstandarCompetencia] [int] NOT NULL,
	[idResolucionEvaluacionDesempeño] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNecesidadesFormativas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanDesarrolloFormativo]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanDesarrolloFormativo](
	[idPlanDesarrolloFormativo] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[Objetivos] [varchar](max) NULL,
	[idCronograma] [int] NOT NULL,
	[idNecesidadesFormativas] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPlanDesarrolloFormativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreguntasEncuesta]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntasEncuesta](
	[idPreguntasEncuesta] [int] IDENTITY(1,1) NOT NULL,
	[Pregunta] [varchar](max) NULL,
	[Opcion1] [varchar](max) NULL,
	[Opcion2] [varchar](max) NULL,
	[Opcion3] [varchar](max) NULL,
	[Opcion4] [varchar](max) NULL,
	[idEncuesta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPreguntasEncuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreguntasEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntasEvaluacionDesempeño](
	[idPreguntasEvaluacionDesempeño] [int] IDENTITY(1,1) NOT NULL,
	[Pregunta] [varchar](max) NULL,
	[Opcion1] [varchar](max) NULL,
	[Opcion2] [varchar](max) NULL,
	[Opcion3] [varchar](max) NULL,
	[Opcion4] [varchar](max) NULL,
	[Respuesta] [varchar](max) NULL,
	[idEvaluacionDesempeño] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPreguntasEvaluacionDesempeño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResolucionEncuesta]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResolucionEncuesta](
	[idResolucionEncuesta] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[idPreguntasEncuesta] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idResolucionEncuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResolucionEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResolucionEvaluacionDesempeño](
	[idResolucionEvaluacionDesempeño] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[NotaTotal] [int] NOT NULL,
	[Comentarios] [varchar](max) NULL,
	[idDetalleEvaluacionDesempeño] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idResolucionEvaluacionDesempeño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cronograma]  WITH CHECK ADD FOREIGN KEY([idActividad])
REFERENCES [dbo].[Actividad] ([idActividad])
GO
ALTER TABLE [dbo].[Cronograma]  WITH CHECK ADD FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Cronograma]  WITH CHECK ADD FOREIGN KEY([idResolucionEncuesta])
REFERENCES [dbo].[ResolucionEncuesta] ([idResolucionEncuesta])
GO
ALTER TABLE [dbo].[DetalleEvaluacionDesempeño]  WITH CHECK ADD FOREIGN KEY([idPreguntasEvaluacionDesempeño])
REFERENCES [dbo].[PreguntasEvaluacionDesempeño] ([idPreguntasEvaluacionDesempeño])
GO
ALTER TABLE [dbo].[Encuesta]  WITH CHECK ADD FOREIGN KEY([idArea])
REFERENCES [dbo].[Area] ([idArea])
GO
ALTER TABLE [dbo].[Encuesta]  WITH CHECK ADD FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[EstandarCompetencia]  WITH CHECK ADD FOREIGN KEY([idArea])
REFERENCES [dbo].[Area] ([idArea])
GO
ALTER TABLE [dbo].[EvaluacionDesempeño]  WITH CHECK ADD FOREIGN KEY([idArea])
REFERENCES [dbo].[Area] ([idArea])
GO
ALTER TABLE [dbo].[NecesidadesFormativas]  WITH CHECK ADD FOREIGN KEY([idEstandarCompetencia])
REFERENCES [dbo].[EstandarCompetencia] ([idEstandarCompetencia])
GO
ALTER TABLE [dbo].[NecesidadesFormativas]  WITH CHECK ADD FOREIGN KEY([idResolucionEvaluacionDesempeño])
REFERENCES [dbo].[ResolucionEvaluacionDesempeño] ([idResolucionEvaluacionDesempeño])
GO
ALTER TABLE [dbo].[PlanDesarrolloFormativo]  WITH CHECK ADD FOREIGN KEY([idCronograma])
REFERENCES [dbo].[Cronograma] ([idCronograma])
GO
ALTER TABLE [dbo].[PlanDesarrolloFormativo]  WITH CHECK ADD FOREIGN KEY([idNecesidadesFormativas])
REFERENCES [dbo].[NecesidadesFormativas] ([idNecesidadesFormativas])
GO
ALTER TABLE [dbo].[PreguntasEncuesta]  WITH CHECK ADD FOREIGN KEY([idEncuesta])
REFERENCES [dbo].[Encuesta] ([idEncuesta])
GO
ALTER TABLE [dbo].[PreguntasEvaluacionDesempeño]  WITH CHECK ADD FOREIGN KEY([idEvaluacionDesempeño])
REFERENCES [dbo].[EvaluacionDesempeño] ([idEvaluacionDesempeño])
GO
ALTER TABLE [dbo].[ResolucionEncuesta]  WITH CHECK ADD FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[ResolucionEncuesta]  WITH CHECK ADD FOREIGN KEY([idPreguntasEncuesta])
REFERENCES [dbo].[PreguntasEncuesta] ([idPreguntasEncuesta])
GO
ALTER TABLE [dbo].[ResolucionEvaluacionDesempeño]  WITH CHECK ADD FOREIGN KEY([idDetalleEvaluacionDesempeño])
REFERENCES [dbo].[DetalleEvaluacionDesempeño] ([idDetalleEvaluacionDesempeño])
GO
ALTER TABLE [dbo].[ResolucionEvaluacionDesempeño]  WITH CHECK ADD FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
/****** Object:  StoredProcedure [dbo].[DeleteActividad]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from Actividad
CREATE PROCEDURE [dbo].[DeleteActividad]
    @idActividad INT
AS
BEGIN
    DELETE FROM dbo.Actividad
    WHERE idActividad = @idActividad;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteArea]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from Area
CREATE PROCEDURE [dbo].[DeleteArea]
    @idArea INT
AS
BEGIN
    DELETE FROM dbo.Area
    WHERE idArea = @idArea;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteCronograma]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from Cronograma
CREATE PROCEDURE [dbo].[DeleteCronograma]
    @idCronograma INT
AS
BEGIN
    DELETE FROM dbo.Cronograma
    WHERE idCronograma = @idCronograma;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteDetalleEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDetalleEvaluacionDesempeño]
    @idDetalleEvaluacionDesempeño INT
AS
BEGIN
    DELETE FROM dbo.DetalleEvaluacionDesempeño
    WHERE idDetalleEvaluacionDesempeño = @idDetalleEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmpleado]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteEmpleado]
    @idEmpleado INT
AS
BEGIN
    DELETE FROM dbo.Empleado
    WHERE idEmpleado = @idEmpleado;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from Encuesta
CREATE PROCEDURE [dbo].[DeleteEncuesta]
    @idEncuesta INT
AS
BEGIN
    DELETE FROM dbo.Encuesta
    WHERE idEncuesta = @idEncuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from EstandarCompetencia
CREATE PROCEDURE [dbo].[DeleteEstandarCompetencia]
    @idEstandarCompetencia INT
AS
BEGIN
    DELETE FROM dbo.EstandarCompetencia
    WHERE idEstandarCompetencia = @idEstandarCompetencia;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteEvaluacionDesempeño]
    @idEvaluacionDesempeño INT
AS
BEGIN
    DELETE FROM dbo.EvaluacionDesempeño
    WHERE idEvaluacionDesempeño = @idEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteNecesidadesFormativas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from NecesidadesFormativas
CREATE PROCEDURE [dbo].[DeleteNecesidadesFormativas]
    @idNecesidadesFormativas INT
AS
BEGIN
    DELETE FROM dbo.NecesidadesFormativas
    WHERE idNecesidadesFormativas = @idNecesidadesFormativas;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeletePlanDesarrolloFormativo]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from PlanDesarrolloFormativo
CREATE PROCEDURE [dbo].[DeletePlanDesarrolloFormativo]
    @idPlanDesarrolloFormativo INT
AS
BEGIN
    DELETE FROM dbo.PlanDesarrolloFormativo
    WHERE idPlanDesarrolloFormativo = @idPlanDesarrolloFormativo;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeletePreguntasEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from PreguntasEncuesta
CREATE PROCEDURE [dbo].[DeletePreguntasEncuesta]
    @idPreguntasEncuesta INT
AS
BEGIN
    DELETE FROM dbo.PreguntasEncuesta
    WHERE idPreguntasEncuesta = @idPreguntasEncuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeletePreguntasEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePreguntasEvaluacionDesempeño]
    @idPreguntasEvaluacionDesempeño INT
AS
BEGIN
    DELETE FROM dbo.PreguntasEvaluacionDesempeño
    WHERE idPreguntasEvaluacionDesempeño = @idPreguntasEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteResolucionEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete a record from ResolucionEncuesta
CREATE PROCEDURE [dbo].[DeleteResolucionEncuesta]
    @idResolucionEncuesta INT
AS
BEGIN
    DELETE FROM dbo.ResolucionEncuesta
    WHERE idResolucionEncuesta = @idResolucionEncuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteResolucionEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteResolucionEvaluacionDesempeño]
    @idResolucionEvaluacionDesempeño INT
AS
BEGIN
    DELETE FROM dbo.ResolucionEvaluacionDesempeño
    WHERE idResolucionEvaluacionDesempeño = @idResolucionEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetActividades]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from Actividad
CREATE PROCEDURE [dbo].[GetActividades]
AS
BEGIN
    SELECT * FROM dbo.Actividad;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAreas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from Area
CREATE PROCEDURE [dbo].[GetAreas]
AS
BEGIN
    SELECT * FROM dbo.Area;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetCronogramas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from Cronograma
CREATE PROCEDURE [dbo].[GetCronogramas]
AS
BEGIN
    SELECT * FROM dbo.Cronograma;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetDetallesEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDetallesEvaluacionDesempeño]
AS
BEGIN
    SELECT * FROM dbo.DetalleEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetEmpleados]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Display all records from Empleado
CREATE PROCEDURE [dbo].[GetEmpleados]
AS
BEGIN
    SELECT * FROM dbo.Empleado;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetEncuestas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from Encuesta
CREATE PROCEDURE [dbo].[GetEncuestas]
AS
BEGIN
    SELECT * FROM dbo.Encuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetEstandaresCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from EstandarCompetencia
CREATE PROCEDURE [dbo].[GetEstandaresCompetencia]
AS
BEGIN
    SELECT * FROM dbo.EstandarCompetencia;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetEvaluacionesDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEvaluacionesDesempeño]
AS
BEGIN
    SELECT * FROM dbo.EvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetNecesidadesFormativas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from NecesidadesFormativas
CREATE PROCEDURE [dbo].[GetNecesidadesFormativas]
AS
BEGIN
    SELECT * FROM dbo.NecesidadesFormativas;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetPlanesDesarrolloFormativo]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from PlanDesarrolloFormativo
CREATE PROCEDURE [dbo].[GetPlanesDesarrolloFormativo]
AS
BEGIN
    SELECT * FROM dbo.PlanDesarrolloFormativo;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetPreguntasEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from PreguntasEncuesta
CREATE PROCEDURE [dbo].[GetPreguntasEncuesta]
AS
BEGIN
    SELECT * FROM dbo.PreguntasEncuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetPreguntasEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPreguntasEvaluacionDesempeño]
AS
BEGIN
    SELECT * FROM dbo.PreguntasEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetResolucionesEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Display all records from ResolucionEncuesta
CREATE PROCEDURE [dbo].[GetResolucionesEncuesta]
AS
BEGIN
    SELECT * FROM dbo.ResolucionEncuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetResolucionesEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetResolucionesEvaluacionDesempeño]
AS
BEGIN
    SELECT * FROM dbo.ResolucionEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertActividad]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Insert a new record into Actividad
CREATE PROCEDURE [dbo].[InsertActividad]
    @NombreActividad VARCHAR(50),
    @Descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Actividad (NombreActividad, Descripcion)
    VALUES (@NombreActividad, @Descripcion);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertArea]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert a new record into Area
CREATE PROCEDURE [dbo].[InsertArea]
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Area (Nombre, Descripcion)
    VALUES (@Nombre, @Descripcion);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertCronograma]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert a new record into Cronograma
CREATE PROCEDURE [dbo].[InsertCronograma]
    @Titulo VARCHAR(50),
    @Descripcion VARCHAR(50),
    @FechaInicio DATE,
    @FechaFin DATE,
    @idResolucionEncuesta INT,
    @idEmpleado INT,
    @idActividad INT
AS
BEGIN
    INSERT INTO dbo.Cronograma (Titulo, Descripcion, FechaInicio, FechaFin, idResolucionEncuesta, idEmpleado, idActividad)
    VALUES (@Titulo, @Descripcion, @FechaInicio, @FechaFin, @idResolucionEncuesta, @idEmpleado, @idActividad);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertDetalleEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDetalleEvaluacionDesempeño]
    @Nota INT,
    @idPreguntasEvaluacionDesempeño INT
AS
BEGIN
    INSERT INTO dbo.DetalleEvaluacionDesempeño (Nota, idPreguntasEvaluacionDesempeño)
    VALUES (@Nota, @idPreguntasEvaluacionDesempeño);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertEmpleado]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertEmpleado]
    @NombreEmpleado VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaContratacion DATE,
    @Puesto VARCHAR(50),
    @Area VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Empleado (NombreEmpleado, Apellido, FechaContratacion, Puesto, Area)
    VALUES (@NombreEmpleado, @Apellido, @FechaContratacion, @Puesto, @Area);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert a new record into Encuesta
CREATE PROCEDURE [dbo].[InsertEncuesta]
    @FechaCreacion DATE,
    @FechaCierre DATE,
    @Titulo VARCHAR(50),
    @idArea INT,
    @idEmpleado INT
AS
BEGIN
    INSERT INTO dbo.Encuesta (FechaCreacion, FechaCierre, Titulo, idArea, idEmpleado)
    VALUES (@FechaCreacion, @FechaCierre, @Titulo, @idArea, @idEmpleado);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert a new record into EstandarCompetencia
CREATE PROCEDURE [dbo].[InsertEstandarCompetencia]
    @NivelRequerido INT,
    @Descripcion VARCHAR(50),
    @idArea INT
AS
BEGIN
    INSERT INTO dbo.EstandarCompetencia (NivelRequerido, Descripcion, idArea)
    VALUES (@NivelRequerido, @Descripcion, @idArea);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Insert a new record into EvaluacionDesempeño
CREATE PROCEDURE [dbo].[InsertEvaluacionDesempeño]
    @FechaCreacion DATE,
    @FechaCierre DATE,
    @Titulo VARCHAR(50),
    @Descripcion VARCHAR(50),
    @idArea INT
AS
BEGIN
    INSERT INTO dbo.EvaluacionDesempeño (FechaCreacion, FechaCierre, Titulo, Descripcion, idArea)
    VALUES (@FechaCreacion, @FechaCierre, @Titulo, @Descripcion, @idArea);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertNecesidadesFormativas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNecesidadesFormativas]
    @FechaCreacion DATE,
    @FechaImplementacion DATE,
    @Necesidades VARCHAR(50),
    @idEstandarCompetencia INT,
    @idResolucionEvaluacionDesempeno INT
AS
BEGIN
    INSERT INTO dbo.NecesidadesFormativas (FechaCreacion, FechaImplementacion, Necesidades, idEstandarCompetencia, idResolucionEvaluacionDesempeño)
    VALUES (@FechaCreacion, @FechaImplementacion, @Necesidades, @idEstandarCompetencia, @idResolucionEvaluacionDesempeno);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertPlanDesarrolloFormativo]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert a new record into PlanDesarrolloFormativo
CREATE PROCEDURE [dbo].[InsertPlanDesarrolloFormativo]
    @FechaCreacion DATE,
    @FechaInicio DATE,
    @FechaFin DATE,
    @Objetivos VARCHAR(50),
    @idCronograma INT,
    @idNecesidadesFormativas INT
AS
BEGIN
    INSERT INTO dbo.PlanDesarrolloFormativo (FechaCreacion, FechaInicio, FechaFin, Objetivos, idCronograma, idNecesidadesFormativas)
    VALUES (@FechaCreacion, @FechaInicio, @FechaFin, @Objetivos, @idCronograma, @idNecesidadesFormativas);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertPreguntasEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert a new record into PreguntasEncuesta
CREATE PROCEDURE [dbo].[InsertPreguntasEncuesta]
    @Pregunta VARCHAR(50),
    @Opcion1 VARCHAR(50),
    @Opcion2 VARCHAR(50),
    @Opcion3 VARCHAR(50),
    @Opcion4 VARCHAR(50),
    @idEncuesta INT
AS
BEGIN
    INSERT INTO dbo.PreguntasEncuesta (Pregunta, Opcion1, Opcion2, Opcion3, Opcion4, idEncuesta)
    VALUES (@Pregunta, @Opcion1, @Opcion2, @Opcion3, @Opcion4, @idEncuesta);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertPreguntasEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertPreguntasEvaluacionDesempeño]
    @Pregunta VARCHAR(50),
    @Opcion1 VARCHAR(50),
    @Opcion2 VARCHAR(50),
    @Opcion3 VARCHAR(50),
    @Opcion4 VARCHAR(50),
    @Respuesta VARCHAR(50),
    @idEvaluacionDesempeño INT
AS
BEGIN
    INSERT INTO dbo.PreguntasEvaluacionDesempeño (Pregunta, Opcion1, Opcion2, Opcion3, Opcion4, Respuesta, idEvaluacionDesempeño)
    VALUES (@Pregunta, @Opcion1, @Opcion2, @Opcion3, @Opcion4, @Respuesta, @idEvaluacionDesempeño);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertResolucionEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert a new record into ResolucionEncuesta
CREATE PROCEDURE [dbo].[InsertResolucionEncuesta]
    @Fecha DATE,
    @idPreguntasEncuesta INT,
    @idEmpleado INT
AS
BEGIN
    INSERT INTO dbo.ResolucionEncuesta (Fecha, idPreguntasEncuesta, idEmpleado)
    VALUES (@Fecha, @idPreguntasEncuesta, @idEmpleado);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertResolucionEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertResolucionEvaluacionDesempeño]
    @Fecha DATE,
    @NotaTotal INT,
    @Comentarios VARCHAR(50),
    @idDetalleEvaluacionDesempeño INT,
    @idEmpleado INT
AS
BEGIN
    INSERT INTO dbo.ResolucionEvaluacionDesempeño (Fecha, NotaTotal, Comentarios, idDetalleEvaluacionDesempeño, idEmpleado)
    VALUES (@Fecha, @NotaTotal, @Comentarios, @idDetalleEvaluacionDesempeño, @idEmpleado);
END;
GO
/****** Object:  StoredProcedure [dbo].[spEditarEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditarEstandarCompetencia]
    @idEstandarCompetencia INT,
    @NivelRequerido INT,
    @Descripcion VARCHAR(MAX),
    @idArea INT
AS
BEGIN
    UPDATE [dbo].[EstandarCompetencia]
    SET
        [NivelRequerido] = @NivelRequerido,
        [Descripcion] = @Descripcion,
        [idArea] = @idArea
    WHERE [idEstandarCompetencia] = @idEstandarCompetencia;
END;
GO
/****** Object:  StoredProcedure [dbo].[spEliminarEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarEstandarCompetencia]
    @idEstandarCompetencia INT
AS
BEGIN
    DELETE FROM [dbo].[EstandarCompetencia]
    WHERE [idEstandarCompetencia] = @idEstandarCompetencia;
END;
GO
/****** Object:  StoredProcedure [dbo].[spEliminarNecesidadesFormativas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarNecesidadesFormativas]
    @idNecesidadesFormativas INT
AS
BEGIN
    DELETE FROM [dbo].[NecesidadesFormativas]
    WHERE [idNecesidadesFormativas] = @idNecesidadesFormativas;
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertarEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarEstandarCompetencia]
    @NivelRequerido INT,
    @Descripcion VARCHAR(MAX),
    @idArea INT
AS
BEGIN
    INSERT INTO [dbo].[EstandarCompetencia] ([NivelRequerido], [Descripcion], [idArea])
    VALUES (@NivelRequerido, @Descripcion, @idArea);
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertarNecesidadesFormativas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarNecesidadesFormativas]
    @FechaCreacion DATE,
    @FechaImplementacion DATE,
    @Necesidades VARCHAR(MAX),
    @idEstandarCompetencia INT,
    @idResolucionEvaluacionDesempeño INT
AS
BEGIN
    -- Insertar una nueva fila en la tabla NecesidadesFormativas
    INSERT INTO [dbo].[NecesidadesFormativas] (
        [FechaCreacion],
        [FechaImplementacion],
        [Necesidades],
        [idEstandarCompetencia],
        [idResolucionEvaluacionDesempeño]
    )
    VALUES (
        @FechaCreacion,
        @FechaImplementacion,
        @Necesidades,
        @idEstandarCompetencia,
        @idResolucionEvaluacionDesempeño
    );
END;
GO
/****** Object:  StoredProcedure [dbo].[spListaEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListaEstandarCompetencia]
AS
BEGIN
    SELECT
        [idEstandarCompetencia],
        [NivelRequerido],
        [Descripcion],
        [idArea]
    FROM
        [dbo].[EstandarCompetencia];
END;
GO
/****** Object:  StoredProcedure [dbo].[spListaNecesidadesFormativas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spListaNecesidadesFormativas]
AS
BEGIN
    SELECT
        [idNecesidadesFormativas],
        [FechaCreacion],
        [FechaImplementacion],
        [Necesidades],
        [idEstandarCompetencia],
        [idResolucionEvaluacionDesempeño]
    FROM
        [dbo].[NecesidadesFormativas];
END;
GO
/****** Object:  StoredProcedure [dbo].[spObtenerEstandarCompetenciaPorId]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spObtenerEstandarCompetenciaPorId]
    @idEstandarCompetencia INT
AS
BEGIN
    SELECT
        [idEstandarCompetencia],
        [NivelRequerido],
        [Descripcion],
        [idArea]
    FROM
        [dbo].[EstandarCompetencia]
    WHERE
        [idEstandarCompetencia] = @idEstandarCompetencia;
END;
GO
/****** Object:  StoredProcedure [dbo].[spObtenerNecesidadFormativaPorId]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spObtenerNecesidadFormativaPorId]
    @idNecesidadesFormativas INT
AS
BEGIN
    -- Seleccionar la necesidad formativa por su ID
    SELECT
        [idNecesidadesFormativas],
        [FechaCreacion],
        [FechaImplementacion],
        [Necesidades],
        [idEstandarCompetencia],
        [idResolucionEvaluacionDesempeño]
    FROM
        [dbo].[NecesidadesFormativas]
    WHERE
        [idNecesidadesFormativas] = @idNecesidadesFormativas;
END;
GO
/****** Object:  StoredProcedure [dbo].[spObtenerNivelRequeridoPorIdEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spObtenerNivelRequeridoPorIdEstandarCompetencia]
    @idEstandarCompetencia INT
AS
BEGIN
    SELECT [NivelRequerido]
    FROM [dbo].[EstandarCompetencia]
    WHERE [idEstandarCompetencia] = @idEstandarCompetencia;
END;
GO
/****** Object:  StoredProcedure [dbo].[spObtenerNotaTotalPorIdResolucionEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spObtenerNotaTotalPorIdResolucionEvaluacionDesempeño]
    @idResolucionEvaluacionDesempeño INT
AS
BEGIN
    SELECT [NotaTotal]
    FROM [dbo].[ResolucionEvaluacionDesempeño]
    WHERE [idResolucionEvaluacionDesempeño] = @idResolucionEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[spObtenerSiguienteIdEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spObtenerSiguienteIdEstandarCompetencia]
AS
BEGIN
    DECLARE @SiguienteId INT;

    SELECT @SiguienteId = ISNULL(MAX(idEstandarCompetencia), 0) + 1
    FROM EstandarCompetencia;

    SELECT @SiguienteId AS SiguienteId;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateActividad]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update a record in Actividad
CREATE PROCEDURE [dbo].[UpdateActividad]
    @idActividad INT,
    @NombreActividad VARCHAR(50),
    @Descripcion VARCHAR(50)
AS
BEGIN
    UPDATE dbo.Actividad
    SET NombreActividad = @NombreActividad, Descripcion = @Descripcion
    WHERE idActividad = @idActividad;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateArea]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update a record in Area
CREATE PROCEDURE [dbo].[UpdateArea]
    @idArea INT,
    @Nombre VARCHAR(50),
    @Descripcion VARCHAR(50)
AS
BEGIN
    UPDATE dbo.Area
    SET Nombre = @Nombre, Descripcion = @Descripcion
    WHERE idArea = @idArea;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCronograma]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update a record in Cronograma
CREATE PROCEDURE [dbo].[UpdateCronograma]
    @idCronograma INT,
    @Titulo VARCHAR(50),
    @Descripcion VARCHAR(50),
    @FechaInicio DATE,
    @FechaFin DATE,
    @idResolucionEncuesta INT,
    @idEmpleado INT,
    @idActividad INT
AS
BEGIN
    UPDATE dbo.Cronograma
    SET Titulo = @Titulo, Descripcion = @Descripcion, FechaInicio = @FechaInicio, FechaFin = @FechaFin,
        idResolucionEncuesta = @idResolucionEncuesta, idEmpleado = @idEmpleado, idActividad = @idActividad
    WHERE idCronograma = @idCronograma;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateDetalleEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDetalleEvaluacionDesempeño]
    @idDetalleEvaluacionDesempeño INT,
    @Nota INT,
    @idPreguntasEvaluacionDesempeño INT
AS
BEGIN
    UPDATE dbo.DetalleEvaluacionDesempeño
    SET Nota = @Nota, idPreguntasEvaluacionDesempeño = @idPreguntasEvaluacionDesempeño
    WHERE idDetalleEvaluacionDesempeño = @idDetalleEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmpleado]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateEmpleado]
    @idEmpleado INT,
    @NombreEmpleado VARCHAR(50),
    @Apellido VARCHAR(50),
    @FechaContratacion DATE,
    @Puesto VARCHAR(50),
    @Area VARCHAR(50)
AS
BEGIN
    UPDATE dbo.Empleado
    SET NombreEmpleado = @NombreEmpleado, Apellido = @Apellido, FechaContratacion = @FechaContratacion,
        Puesto = @Puesto, Area = @Area
    WHERE idEmpleado = @idEmpleado;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update a record in Encuesta
CREATE PROCEDURE [dbo].[UpdateEncuesta]
    @idEncuesta INT,
    @FechaCreacion DATE,
    @FechaCierre DATE,
    @Titulo VARCHAR(50),
    @idArea INT,
    @idEmpleado INT
AS
BEGIN
    UPDATE dbo.Encuesta
    SET FechaCreacion = @FechaCreacion, FechaCierre = @FechaCierre,
        Titulo = @Titulo, idArea = @idArea, idEmpleado = @idEmpleado
    WHERE idEncuesta = @idEncuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateEstandarCompetencia]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update a record in EstandarCompetencia
CREATE PROCEDURE [dbo].[UpdateEstandarCompetencia]
    @idEstandarCompetencia INT,
    @NivelRequerido INT,
    @Descripcion VARCHAR(50),
    @idArea INT
AS
BEGIN
    UPDATE dbo.EstandarCompetencia
    SET NivelRequerido = @NivelRequerido, Descripcion = @Descripcion, idArea = @idArea
    WHERE idEstandarCompetencia = @idEstandarCompetencia;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateEvaluacionDesempeño]
    @idEvaluacionDesempeño INT,
    @FechaCreacion DATE,
    @FechaCierre DATE,
    @Titulo VARCHAR(50),
    @Descripcion VARCHAR(50),
    @idArea INT
AS
BEGIN
    UPDATE dbo.EvaluacionDesempeño
    SET FechaCreacion = @FechaCreacion, FechaCierre = @FechaCierre,
        Titulo = @Titulo, Descripcion = @Descripcion, idArea = @idArea
    WHERE idEvaluacionDesempeño = @idEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateNecesidadesFormativas]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateNecesidadesFormativas]
    @idNecesidadesFormativas INT,
    @FechaCreacion DATE,
    @FechaImplementacion DATE,
    @Necesidades VARCHAR(50),
    @idEstandarCompetencia INT,
    @idResolucionEvaluacionDesempeño INT
AS
BEGIN
    UPDATE dbo.NecesidadesFormativas
    SET FechaCreacion = @FechaCreacion, FechaImplementacion = @FechaImplementacion,
        Necesidades = @Necesidades, idEstandarCompetencia = @idEstandarCompetencia, idResolucionEvaluacionDesempeño = @idResolucionEvaluacionDesempeño
    WHERE idNecesidadesFormativas = @idNecesidadesFormativas;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdatePlanDesarrolloFormativo]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update a record in PlanDesarrolloFormativo
CREATE PROCEDURE [dbo].[UpdatePlanDesarrolloFormativo]
    @idPlanDesarrolloFormativo INT,
    @FechaCreacion DATE,
    @FechaInicio DATE,
    @FechaFin DATE,
    @Objetivos VARCHAR(50),
    @idCronograma INT,
    @idNecesidadesFormativas INT
AS
BEGIN
    UPDATE dbo.PlanDesarrolloFormativo
    SET FechaCreacion = @FechaCreacion, FechaInicio = @FechaInicio, FechaFin = @FechaFin,
        Objetivos = @Objetivos, idCronograma = @idCronograma, idNecesidadesFormativas = @idNecesidadesFormativas
    WHERE idPlanDesarrolloFormativo = @idPlanDesarrolloFormativo;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdatePreguntasEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update a record in PreguntasEncuesta
CREATE PROCEDURE [dbo].[UpdatePreguntasEncuesta]
    @idPreguntasEncuesta INT,
    @Pregunta VARCHAR(50),
    @Opcion1 VARCHAR(50),
    @Opcion2 VARCHAR(50),
    @Opcion3 VARCHAR(50),
    @Opcion4 VARCHAR(50),
    @idEncuesta INT
AS
BEGIN
    UPDATE dbo.PreguntasEncuesta
    SET Pregunta = @Pregunta, Opcion1 = @Opcion1, Opcion2 = @Opcion2,
        Opcion3 = @Opcion3, Opcion4 = @Opcion4, idEncuesta = @idEncuesta
    WHERE idPreguntasEncuesta = @idPreguntasEncuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdatePreguntasEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePreguntasEvaluacionDesempeño]
    @idPreguntasEvaluacionDesempeño INT,
    @Pregunta VARCHAR(50),
    @Opcion1 VARCHAR(50),
    @Opcion2 VARCHAR(50),
    @Opcion3 VARCHAR(50),
    @Opcion4 VARCHAR(50),
    @Respuesta VARCHAR(50),
    @idEvaluacionDesempeño INT
AS
BEGIN
    UPDATE dbo.PreguntasEvaluacionDesempeño
    SET Pregunta = @Pregunta, Opcion1 = @Opcion1, Opcion2 = @Opcion2,
        Opcion3 = @Opcion3, Opcion4 = @Opcion4, Respuesta = @Respuesta, idEvaluacionDesempeño = @idEvaluacionDesempeño
    WHERE idPreguntasEvaluacionDesempeño = @idPreguntasEvaluacionDesempeño;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateResolucionEncuesta]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update a record in ResolucionEncuesta
CREATE PROCEDURE [dbo].[UpdateResolucionEncuesta]
    @idResolucionEncuesta INT,
    @Fecha DATE,
    @idPreguntasEncuesta INT,
    @idEmpleado INT
AS
BEGIN
    UPDATE dbo.ResolucionEncuesta
    SET Fecha = @Fecha, idPreguntasEncuesta = @idPreguntasEncuesta, idEmpleado = @idEmpleado
    WHERE idResolucionEncuesta = @idResolucionEncuesta;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateResolucionEvaluacionDesempeño]    Script Date: 21/11/2023 02:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateResolucionEvaluacionDesempeño]
    @idResolucionEvaluacionDesempeño INT,
    @Fecha DATE,
    @NotaTotal INT,
    @Comentarios VARCHAR(50),
    @idDetalleEvaluacionDesempeño INT,
    @idEmpleado INT
AS
BEGIN
    UPDATE dbo.ResolucionEvaluacionDesempeño
    SET Fecha = @Fecha, NotaTotal = @NotaTotal, Comentarios = @Comentarios,
        idDetalleEvaluacionDesempeño = @idDetalleEvaluacionDesempeño, idEmpleado = @idEmpleado
    WHERE idResolucionEvaluacionDesempeño = @idResolucionEvaluacionDesempeño;
END;
GO
