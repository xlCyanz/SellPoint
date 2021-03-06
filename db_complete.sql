USE [sellpoint]
GO
/****** Object:  Table [dbo].[Entidades]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entidades](
	[IdEntidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](120) NOT NULL,
	[Direccion] [text] NOT NULL,
	[Localidad] [nvarchar](40) NOT NULL,
	[TipoEntidad] [text] NOT NULL,
	[TipoDocumento] [text] NOT NULL,
	[NumeroDocumento] [numeric](15, 0) NOT NULL,
	[Telefonos] [nvarchar](60) NOT NULL,
	[URLPaginaWeb] [nvarchar](120) NULL,
	[URLFacebook] [nvarchar](120) NULL,
	[URLInstagram] [nvarchar](120) NULL,
	[URLTwitter] [nvarchar](120) NULL,
	[URLTikTok] [nvarchar](120) NULL,
	[IdGrupoEntidad] [numeric](10, 0) NULL,
	[IdTipoEntidad] [numeric](10, 0) NULL,
	[LimiteCredito] [numeric](15, 0) NULL,
	[UserNameEntidad] [nvarchar](60) NOT NULL,
	[PasswordEntidad] [nvarchar](70) NOT NULL,
	[RolUserEntidad] [nchar](10) NOT NULL,
	[Comentario] [text] NULL,
	[Status] [nchar](10) NOT NULL,
	[NoEliminable] [bit] NOT NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_Entidades] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [AK_Username] UNIQUE NONCLUSTERED 
(
	[UserNameEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GruposEntidades]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GruposEntidades](
	[IdGrupoEntidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](120) NOT NULL,
	[Comentario] [text] NULL,
	[Status] [nchar](10) NULL,
	[NoEliminable] [bit] NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_GruposEntidades] PRIMARY KEY CLUSTERED 
(
	[IdGrupoEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposEntidades]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposEntidades](
	[IdTipoEntidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](120) NOT NULL,
	[IdGrupoEntidad] [int] NOT NULL,
	[Comentario] [text] NULL,
	[Status] [nchar](10) NULL,
	[NoEliminable] [bit] NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_TiposEntidades] PRIMARY KEY CLUSTERED 
(
	[IdTipoEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_TipoEntidad]  DEFAULT ('Juridica') FOR [TipoEntidad]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_TipoDocumento]  DEFAULT ('RNC') FOR [TipoDocumento]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_LimiteCredito]  DEFAULT ((0)) FOR [LimiteCredito]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_RolUserEntidad]  DEFAULT (N'User') FOR [RolUserEntidad]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_Status]  DEFAULT (N'Activa') FOR [Status]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_NoEliminable]  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_Status]  DEFAULT (N'Activa') FOR [Status]
GO
ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_NoEliminable]  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[TiposEntidades] ADD  CONSTRAINT [DF_TiposEntidades_Status]  DEFAULT (N'Activa') FOR [Status]
GO
ALTER TABLE [dbo].[TiposEntidades] ADD  CONSTRAINT [DF_TiposEntidades_NoEliminable]  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[TiposEntidades] ADD  CONSTRAINT [DF_TiposEntidades_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Entidades]  WITH CHECK ADD  CONSTRAINT [DF_Entidades_LimiteCreditoCK] CHECK  (((0)<=[LimiteCredito]))
GO
ALTER TABLE [dbo].[Entidades] CHECK CONSTRAINT [DF_Entidades_LimiteCreditoCK]
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesActualizar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpEntidadesActualizar]
@IdEntidad AS INT,
@Descripcion AS NVARCHAR(240),
@Direccion AS TEXT,
@Localidad AS NVARCHAR(80),
@TipoEntidad AS TEXT,
@TipoDocumento AS TEXT,
@NumeroDocumento AS NUMERIC(15,0),
@Telefonos AS NVARCHAR(120),
@URLPaginaWeb AS NVARCHAR(240),
@URLFacebook AS NVARCHAR(240),
@URLInstagram AS NVARCHAR(240),
@URLTwitter AS NVARCHAR(240),
@URLTikTok AS NVARCHAR(240),
@IdGrupoEntidad AS NUMERIC(10,0),
@IdTipoEntidad AS NUMERIC(10,0),
@LimiteCredito AS NUMERIC(15,0),
@UserNameEntidad AS NVARCHAR(120),
@PasswordEntidad AS NVARCHAR(60),
@RolUserEntidad AS NCHAR(20),
@Comentario AS TEXT,
@Status AS NCHAR(20),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
UPDATE Entidades
SET Descripcion = @Descripcion,
Direccion = @Direccion,
Localidad = @Localidad,
TipoEntidad = @TipoEntidad,
TipoDocumento = @TipoDocumento,
NumeroDocumento = @NumeroDocumento,
Telefonos = @Telefonos,
URLPaginaWeb = @URLPaginaWeb,
URLFacebook = @URLFacebook,
URLInstagram = @URLInstagram,
URLTwitter = @URLTwitter,
URLTikTok = @URLTikTok,
IdGrupoEntidad = @IdGrupoEntidad,
IdTipoEntidad = @IdTipoEntidad,
LimiteCredito = @LimiteCredito,
UserNameEntidad = @UserNameEntidad,
PasswordEntidad = @PasswordEntidad,
RolUserEntidad = @RolUserEntidad,
Comentario = @Comentario,
Status = @Status,
NoEliminable = @NoEliminable,
FechaRegistro = @FechaRegistro
WHERE IdEntidad = @IdEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesAnterior]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadesAnterior]
@IdEntidad AS INT
AS
IF(SELECT COUNT(IdEntidad) FROM Entidades WHERE IdEntidad < @IdEntidad) > 0
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Telefonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM Entidades
WHERE IdEntidad < @IdEntidad
ORDER BY  IdEntidad DESC
END
ELSE
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Telefonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM Entidades
ORDER BY  IdEntidad ASC
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesEliminar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadesEliminar]
@IdEntidad AS INT
AS
BEGIN
DELETE FROM Entidades
WHERE IdEntidad = @IdEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesInsertar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadesInsertar]
@Descripcion AS NVARCHAR(240),
@Direccion AS TEXT,
@Localidad AS NVARCHAR(80),
@TipoEntidad AS TEXT,
@TipoDocumento AS TEXT,
@NumeroDocumento AS NUMERIC(15,0),
@Telefonos AS NVARCHAR(120),
@URLPaginaWeb AS NVARCHAR(240),
@URLFacebook AS NVARCHAR(240),
@URLInstagram AS NVARCHAR(240),
@URLTwitter AS NVARCHAR(240),
@URLTikTok AS NVARCHAR(240),
@IdGrupoEntidad AS NUMERIC(10,0),
@IdTipoEntidad AS NUMERIC(10,0),
@LimiteCredito AS NUMERIC(15,0),
@UserNameEntidad AS NVARCHAR(120),
@PasswordEntidad AS NVARCHAR(70),
@RolUserEntidad AS NCHAR(20),
@Comentario AS TEXT,
@Status AS NCHAR(20),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
INSERT INTO Entidades (Descripcion,Direccion,Localidad,TipoEntidad,TipoDocumento,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PasswordEntidad,RolUserEntidad,Comentario,Status,NoEliminable,FechaRegistro)
VALUES (@Descripcion,@Direccion,@Localidad,@TipoEntidad,@TipoDocumento,@NumeroDocumento,@Telefonos,@URLPaginaWeb,@URLFacebook,@URLInstagram,@URLTwitter,@URLTikTok,@IdGrupoEntidad,@IdTipoEntidad,@LimiteCredito,@UserNameEntidad,@PasswordEntidad,@RolUserEntidad,@Comentario,@Status,@NoEliminable,@FechaRegistro)
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesListar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadesListar]
AS
BEGIN
SELECT IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Telefonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PasswordEntidad,
RolUserEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM Entidades
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesLogin]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpEntidadesLogin]
@UserNameEntidad AS NVARCHAR(120),
@PasswordEntidad AS NVARCHAR(120)
AS
BEGIN
SELECT
COUNT(*)
FROM Entidades
WHERE UserNameEntidad = @UserNameEntidad AND PasswordEntidad = @PasswordEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesObtener]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadesObtener]
@IdEntidad AS INT
AS
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Telefonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM Entidades
WHERE IdEntidad = @IdEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesPrimero]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadesPrimero]
AS
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Telefonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM Entidades
ORDER BY  IdEntidad ASC
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesSiguiente]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SpEntidadesSiguiente]
@IdEntidad AS INT
AS
IF(SELECT COUNT(IdEntidad) FROM Entidades WHERE IdEntidad > @IdEntidad) > 0
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Telefonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM Entidades
WHERE IdEntidad > @IdEntidad
ORDER BY  IdEntidad ASC
END
ELSE
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Telefonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM Entidades
ORDER BY  IdEntidad DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SpEntidadesUltimo]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpEntidadesUltimo]
AS
BEGIN
SELECT TOP 1 
IdEntidad,
Descripcion,
Direccion,
Localidad,
TipoEntidad,
TipoDocumento,
NumeroDocumento,
Telefonos,
URLPaginaWeb,
URLFacebook,
URLInstagram,
URLTwitter,
URLTikTok,
IdGrupoEntidad,
IdTipoEntidad,
LimiteCredito,
UserNameEntidad,
PassworEntidad,
RolUserEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM Entidades
ORDER BY  IdEntidad DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SpGruposEntidadesActualizar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpGruposEntidadesActualizar]
@IdGrupoEntidad AS INT,
@Descripcion AS NVARCHAR(240),
@Comentario AS TEXT,
@Status AS NCHAR(20),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
UPDATE GruposEntidades
SET Descripcion = @Descripcion,
Comentario = @Comentario,
Status = @Status,
NoEliminable = @NoEliminable,
FechaRegistro = @FechaRegistro
WHERE IdGrupoEntidad = @IdGrupoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpGruposEntidadesEliminar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpGruposEntidadesEliminar]
@IdGrupoEntidad AS INT
AS
BEGIN
DELETE FROM GruposEntidades
WHERE IdGrupoEntidad = @IdGrupoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpGruposEntidadesInsertar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpGruposEntidadesInsertar]
@Descripcion AS NVARCHAR(240),
@Comentario AS TEXT,
@Status AS NCHAR(20),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
INSERT INTO GruposEntidades (Descripcion,Comentario,Status,NoEliminable,FechaRegistro)
VALUES (@Descripcion,@Comentario,@Status,@NoEliminable,@FechaRegistro)
END
GO
/****** Object:  StoredProcedure [dbo].[SpGruposEntidadesListar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpGruposEntidadesListar]
AS
BEGIN
SELECT IdGrupoEntidad,
Descripcion,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM GruposEntidades
END
GO
/****** Object:  StoredProcedure [dbo].[SpLoginEntidades]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpLoginEntidades]
@Username AS NVARCHAR(120)
AS
BEGIN
SELECT * FROM Entidades
WHERE UserNameEntidad = @Username
END
GO
/****** Object:  StoredProcedure [dbo].[SpTiposEntidadesActualizar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpTiposEntidadesActualizar]
@IdTipoEntidad AS INT,
@Descripcion AS NVARCHAR(240),
@IdGrupoEntidad AS INT,
@Comentario AS TEXT,
@Status AS NCHAR(20),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
UPDATE TiposEntidades
SET Descripcion = @Descripcion,
IdGrupoEntidad = @IdGrupoEntidad,
Comentario = @Comentario,
Status = @Status,
NoEliminable = @NoEliminable,
FechaRegistro = @FechaRegistro
WHERE IdTipoEntidad = @IdTipoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpTiposEntidadesEliminar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpTiposEntidadesEliminar]
@IdTipoEntidad AS INT
AS
BEGIN
DELETE FROM TiposEntidades
WHERE IdTipoEntidad = @IdTipoEntidad
END
GO
/****** Object:  StoredProcedure [dbo].[SpTiposEntidadesInsertar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpTiposEntidadesInsertar]
@Descripcion AS NVARCHAR(240),
@IdGrupoEntidad AS INT,
@Comentario AS TEXT,
@Status AS NCHAR(20),
@NoEliminable AS BIT,
@FechaRegistro AS DATE
AS
BEGIN
INSERT INTO TiposEntidades (Descripcion,IdGrupoEntidad,Comentario,Status,NoEliminable,FechaRegistro)
VALUES (@Descripcion,@IdGrupoEntidad,@Comentario,@Status,@NoEliminable,@FechaRegistro)
END
GO
/****** Object:  StoredProcedure [dbo].[SpTiposEntidadesListar]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpTiposEntidadesListar]
AS
BEGIN
SELECT IdTipoEntidad,
Descripcion,
IdGrupoEntidad,
Comentario,
Status,
NoEliminable,
FechaRegistro
FROM TiposEntidades
END
GO
/****** Object:  StoredProcedure [dbo].[SpTiposEntidadesObtenerPerGrupoEntidad]    Script Date: 23/4/2022 8:04:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpTiposEntidadesObtenerPerGrupoEntidad]
@IdGrupoEntidad AS INT
AS
BEGIN
SELECT * FROM TiposEntidades
WHERE IdGrupoEntidad = @IdGrupoEntidad
END
GO
