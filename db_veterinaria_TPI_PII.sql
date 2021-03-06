USE [db_veterinaria4]
GO
/****** Object:  Table [dbo].[Atenciones]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atenciones](
	[Id_Atencion] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Importe] [decimal](18, 2) NOT NULL,
	[Id_Mascota] [int] NOT NULL,
	[Fecha_Control] [date] NULL,
	[Fecha_baja] [date] NULL,
 CONSTRAINT [PK_Atenciones] PRIMARY KEY CLUSTERED 
(
	[Id_Atencion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Id_domicilio] [int] NOT NULL,
	[Id_tipo] [int] NOT NULL,
	[nro_dni] [int] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[Id_Contactos] [int] NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
 CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED 
(
	[Id_Contactos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domicilios]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domicilios](
	[Id_domicilio] [int] IDENTITY(1,1) NOT NULL,
	[Calle] [varchar](50) NOT NULL,
	[Numero] [int] NOT NULL,
	[Id_localidad] [int] NOT NULL,
 CONSTRAINT [PK_Domicilios] PRIMARY KEY CLUSTERED 
(
	[Id_domicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especies]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especies](
	[Id_especie] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Id_Raza] [int] NOT NULL,
 CONSTRAINT [PK_Especies] PRIMARY KEY CLUSTERED 
(
	[Id_especie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[Id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[Id_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascotas]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascotas](
	[Id_Mascota] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[fecha_nac] [date] NOT NULL,
	[fecha_def] [date] NULL,
	[Sexo] [bit] NULL,
	[Peso] [decimal](6, 2) NULL,
	[Id_Especie] [int] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Esterilizado] [bit] NULL,
	[razas] [int] NULL,
 CONSTRAINT [PK_Mascotas] PRIMARY KEY CLUSTERED 
(
	[Id_Mascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Razas]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Razas](
	[Id_Raza] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Razas] PRIMARY KEY CLUSTERED 
(
	[Id_Raza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_dni]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_dni](
	[Id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipos_dni] PRIMARY KEY CLUSTERED 
(
	[Id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vacunas]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vacunas](
	[Id_Vacuna] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Vacunas] PRIMARY KEY CLUSTERED 
(
	[Id_Vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vacunas_por_mascotas]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vacunas_por_mascotas](
	[Id_vacuna_mascota] [int] IDENTITY(1,1) NOT NULL,
	[Id_vacuna] [int] NULL,
	[Id_mascota] [int] NULL,
	[fecha] [date] NULL,
	[dosis] [int] NULL,
 CONSTRAINT [pk_vacuna_mascota] PRIMARY KEY CLUSTERED 
(
	[Id_vacuna_mascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[veterinarios]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[veterinarios](
	[id_veterinario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Matricula] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
	[id_domicilio] [int] NULL,
	[id_tipo] [int] NULL,
	[nro_dni] [int] NULL,
	[Apellido] [varchar](50) NULL,
 CONSTRAINT [pk_veterinario] PRIMARY KEY CLUSTERED 
(
	[id_veterinario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (1, N'Disnea', CAST(N'2021-11-02' AS Date), CAST(500.00 AS Decimal(18, 2)), 1, CAST(N'2021-11-20' AS Date), CAST(N'2021-11-02' AS Date))
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (2, N'Moquillo', CAST(N'2021-09-30' AS Date), CAST(900.00 AS Decimal(18, 2)), 1, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (3, N'Diabetes', CAST(N'2021-11-02' AS Date), CAST(654.00 AS Decimal(18, 2)), 1, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (4, N'Stress', CAST(N'2021-11-02' AS Date), CAST(12.00 AS Decimal(18, 2)), 1, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (5, N'Moquillo', CAST(N'2021-11-01' AS Date), CAST(123.00 AS Decimal(18, 2)), 1, CAST(N'2021-11-03' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (6, N'Epilepsia', CAST(N'2021-11-03' AS Date), CAST(690.00 AS Decimal(18, 2)), 9, CAST(N'2021-11-02' AS Date), CAST(N'2021-11-02' AS Date))
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (7, N'Tumor', CAST(N'2021-11-02' AS Date), CAST(580.00 AS Decimal(18, 2)), 10, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (8, N'Consulta por castración', CAST(N'2021-11-02' AS Date), CAST(600.00 AS Decimal(18, 2)), 14, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (9, N'Catarro', CAST(N'2021-11-02' AS Date), CAST(200.00 AS Decimal(18, 2)), 3, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (10, N'Mocos', CAST(N'2021-11-02' AS Date), CAST(20.00 AS Decimal(18, 2)), 9, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (11, N'Hernia lumbar', CAST(N'2021-11-02' AS Date), CAST(200.00 AS Decimal(18, 2)), 3, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (12, N'Vomitos y diarrea', CAST(N'2021-11-02' AS Date), CAST(950.00 AS Decimal(18, 2)), 10, CAST(N'2021-11-02' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (13, N'Insuficiencia Renal', CAST(N'2021-11-03' AS Date), CAST(850.00 AS Decimal(18, 2)), 1, CAST(N'2021-11-03' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (14, N'Disfunción Renal', CAST(N'2021-11-03' AS Date), CAST(800.00 AS Decimal(18, 2)), 5, CAST(N'2021-11-03' AS Date), NULL)
INSERT [dbo].[Atenciones] ([Id_Atencion], [Descripcion], [Fecha], [Importe], [Id_Mascota], [Fecha_Control], [Fecha_baja]) VALUES (15, N'Desparasitación', CAST(N'2021-11-03' AS Date), CAST(650.00 AS Decimal(18, 2)), 15, CAST(N'2021-11-03' AS Date), NULL)
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (1, N'Gonzalo', N'Medrano', 1, 1, 20202020)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (2, N'Edmundo', N'Manzi', 19, 1, 6595201)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (3, N'Juana', N'Valenzuela', 1, 1, 456456456)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (4, N'Raymundo', N'Gonzales', 6, 1, 303030)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (5, N'comanche', N'salamanquero', 7, 1, 123123)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (6, N'Pedro', N'Azcuenaga', 11, 1, 14141414)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (7, N'MANUEL', N'BELGRANO', 12, 1, 32132132)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (8, N'Homero', N'Simpson', 16, 1, 49494965)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (9, N'Bartolomeo', N'Simpson', 17, 1, 6546545)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (10, N'Lisa', N'Simpson', 18, 1, 4564564)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (11, N'Max', N'Verstappen', 19, 1, 36363636)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (12, N'Jose', N'Cito', 20, 1, 32165454)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (13, N'Esteban', N'Quito', 21, 1, 65498789)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (14, N'Pamela', N'David', 22, 1, 30300300)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (15, N'Román', N'Riquelme', 23, 1, 3000000)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (16, N'jose', N'gonzales', 24, 1, 21323)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (17, N'Bonifacio', N'Torres', 26, 1, 3002001)
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Id_domicilio], [Id_tipo], [nro_dni]) VALUES (18, N'Matias', N'Medrano', 27, 1, 33900055)
GO
SET IDENTITY_INSERT [dbo].[Domicilios] ON 

INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (1, N'Colon', 110, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (2, N'C', 194, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (3, N'C', 194, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (4, N'C', 194, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (5, N'C', 194, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (6, N'Cochabamba', 210, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (7, N'Jacinto Rios', 194, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (11, N'Mariano Moreno', 194, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (12, N'Campana', 806, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (16, N'Av Siempre Viva', 194, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (17, N'Av Siempre Viva', 194, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (18, N'Av Siempre Viva', 800, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (19, N'Fangio', 1000, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (20, N'Medrano', 900, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (21, N'Santa Fé', 212, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (22, N'Colon', 1200, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (23, N'Juncales', 321, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (24, N'Juncales', 2020, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (25, N'Retamales', 105, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (26, N'Jacinto Ríos', 985, 1)
INSERT [dbo].[Domicilios] ([Id_domicilio], [Calle], [Numero], [Id_localidad]) VALUES (27, N'Pje Chichala', 354, 1)
SET IDENTITY_INSERT [dbo].[Domicilios] OFF
GO
INSERT [dbo].[Especies] ([Id_especie], [Nombre], [Id_Raza]) VALUES (1, N'perro', 1)
INSERT [dbo].[Especies] ([Id_especie], [Nombre], [Id_Raza]) VALUES (2, N'Gato', 2)
GO
SET IDENTITY_INSERT [dbo].[Localidades] ON 

INSERT [dbo].[Localidades] ([Id_localidad], [Nombre]) VALUES (1, N'Córdoba')
SET IDENTITY_INSERT [dbo].[Localidades] OFF
GO
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (1, N'Berni', CAST(N'2021-11-02' AS Date), NULL, 1, CAST(25.00 AS Decimal(6, 2)), 1, 1, 0, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (2, N'Toto', CAST(N'2021-11-02' AS Date), CAST(N'2021-11-02' AS Date), 1, NULL, 1, 1, 0, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (3, N'Ayudante de Santa', CAST(N'2021-11-02' AS Date), NULL, 1, NULL, 1, 8, 1, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (4, N'Eulasio', CAST(N'2021-11-03' AS Date), NULL, 1, NULL, 1, 6, 0, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (5, N'Jacinto', CAST(N'2021-11-02' AS Date), NULL, 1, NULL, 1, 11, 0, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (6, N'Eberto', CAST(N'2021-11-01' AS Date), CAST(N'2021-11-02' AS Date), 1, NULL, 1, 5, 0, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (7, N'Teo', CAST(N'2011-11-18' AS Date), NULL, 1, NULL, 1, 14, 0, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (8, N'Bunki', CAST(N'2021-11-02' AS Date), CAST(N'2021-11-02' AS Date), 1, NULL, 1, 15, 0, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (9, N'Mocho', CAST(N'2021-11-02' AS Date), NULL, 1, NULL, 1, 2, 1, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (10, N'bola de nieve', CAST(N'2021-11-02' AS Date), NULL, 0, NULL, 1, 10, 1, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (11, N'Chavo', CAST(N'2021-11-02' AS Date), CAST(N'2021-11-02' AS Date), 1, NULL, 1, 2, 1, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (12, N'Pancha', CAST(N'2021-11-02' AS Date), NULL, 0, NULL, 1, 13, 1, 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (13, N'Juancho', CAST(N'2021-11-02' AS Date), NULL, 1, NULL, 2, 12, 1, 2)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (14, N'Runa', CAST(N'2021-11-02' AS Date), NULL, 0, NULL, 2, 17, 0, 3)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [fecha_nac], [fecha_def], [Sexo], [Peso], [Id_Especie], [Id_Cliente], [Esterilizado], [razas]) VALUES (15, N'Puma', CAST(N'2011-11-03' AS Date), NULL, 0, NULL, 1, 18, 1, 1)
GO
INSERT [dbo].[Razas] ([Id_Raza], [Nombre]) VALUES (1, N'Bull Dog')
INSERT [dbo].[Razas] ([Id_Raza], [Nombre]) VALUES (2, N'Siames')
INSERT [dbo].[Razas] ([Id_Raza], [Nombre]) VALUES (3, N'otro')
INSERT [dbo].[Razas] ([Id_Raza], [Nombre]) VALUES (4, N'Doberman')
GO
SET IDENTITY_INSERT [dbo].[Tipos_dni] ON 

INSERT [dbo].[Tipos_dni] ([Id_tipo], [Descripcion]) VALUES (1, N'dni')
SET IDENTITY_INSERT [dbo].[Tipos_dni] OFF
GO
SET IDENTITY_INSERT [dbo].[veterinarios] ON 

INSERT [dbo].[veterinarios] ([id_veterinario], [Nombre], [Matricula], [Usuario], [contraseña], [id_domicilio], [id_tipo], [nro_dni], [Apellido]) VALUES (1, N'Marcos', N'123', N'MarcosJaurez123', N'123456789', 2, 1, 321654, N'Juarez')
INSERT [dbo].[veterinarios] ([id_veterinario], [Nombre], [Matricula], [Usuario], [contraseña], [id_domicilio], [id_tipo], [nro_dni], [Apellido]) VALUES (2, N'Matias', N'123456', N'MatiMedrano123', N'123456789', 2, 1, 33900055, N'Medrano')
SET IDENTITY_INSERT [dbo].[veterinarios] OFF
GO
ALTER TABLE [dbo].[Atenciones]  WITH CHECK ADD  CONSTRAINT [FK_Atenciones_Mascotas] FOREIGN KEY([Id_Mascota])
REFERENCES [dbo].[Mascotas] ([Id_Mascota])
GO
ALTER TABLE [dbo].[Atenciones] CHECK CONSTRAINT [FK_Atenciones_Mascotas]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Domicilios] FOREIGN KEY([Id_domicilio])
REFERENCES [dbo].[Domicilios] ([Id_domicilio])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Domicilios]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipos_dni] FOREIGN KEY([Id_tipo])
REFERENCES [dbo].[Tipos_dni] ([Id_tipo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipos_dni]
GO
ALTER TABLE [dbo].[Contactos]  WITH CHECK ADD  CONSTRAINT [FK_Contactos_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Contactos] CHECK CONSTRAINT [FK_Contactos_Clientes]
GO
ALTER TABLE [dbo].[Domicilios]  WITH CHECK ADD  CONSTRAINT [FK_Domicilios_Localidades] FOREIGN KEY([Id_localidad])
REFERENCES [dbo].[Localidades] ([Id_localidad])
GO
ALTER TABLE [dbo].[Domicilios] CHECK CONSTRAINT [FK_Domicilios_Localidades]
GO
ALTER TABLE [dbo].[Especies]  WITH CHECK ADD  CONSTRAINT [FK_Especies_Razas] FOREIGN KEY([Id_Raza])
REFERENCES [dbo].[Razas] ([Id_Raza])
GO
ALTER TABLE [dbo].[Especies] CHECK CONSTRAINT [FK_Especies_Razas]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD  CONSTRAINT [FK_Mascotas_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Mascotas] CHECK CONSTRAINT [FK_Mascotas_Clientes]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD  CONSTRAINT [FK_Mascotas_Especies] FOREIGN KEY([Id_Especie])
REFERENCES [dbo].[Especies] ([Id_especie])
GO
ALTER TABLE [dbo].[Mascotas] CHECK CONSTRAINT [FK_Mascotas_Especies]
GO
ALTER TABLE [dbo].[vacunas_por_mascotas]  WITH CHECK ADD  CONSTRAINT [fk_mascota] FOREIGN KEY([Id_mascota])
REFERENCES [dbo].[Mascotas] ([Id_Mascota])
GO
ALTER TABLE [dbo].[vacunas_por_mascotas] CHECK CONSTRAINT [fk_mascota]
GO
ALTER TABLE [dbo].[vacunas_por_mascotas]  WITH CHECK ADD  CONSTRAINT [fk_vacuna] FOREIGN KEY([Id_vacuna])
REFERENCES [dbo].[Vacunas] ([Id_Vacuna])
GO
ALTER TABLE [dbo].[vacunas_por_mascotas] CHECK CONSTRAINT [fk_vacuna]
GO
ALTER TABLE [dbo].[veterinarios]  WITH CHECK ADD  CONSTRAINT [fk_domicilio] FOREIGN KEY([id_domicilio])
REFERENCES [dbo].[Domicilios] ([Id_domicilio])
GO
ALTER TABLE [dbo].[veterinarios] CHECK CONSTRAINT [fk_domicilio]
GO
ALTER TABLE [dbo].[veterinarios]  WITH CHECK ADD  CONSTRAINT [fk_tipo] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[Tipos_dni] ([Id_tipo])
GO
ALTER TABLE [dbo].[veterinarios] CHECK CONSTRAINT [fk_tipo]
GO
/****** Object:  StoredProcedure [dbo].[consultar_atenciones]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultar_atenciones]
@nombreMascota varchar(50),
@nombreCliente varchar(50),
@apellidoCliente varchar(50),
@dni int,
@fechaDesde datetime,
@fechaHasta datetime,
@datosBaja char
AS
BEGIN
if @datosBaja = 'S'
begin
select 
	a.Id_Atencion,
	a.Fecha 'fecha',
	c.Nombre 'nombre cliente',
	C.Apellido 'apellido cliente',
	c.nro_dni 'dni',
	m.Nombre 'mascota',
	a.Descripcion 'descripcion',
	a.Importe 'importe',
	a.Fecha_Control 'fecha_control',
	a.fecha_baja 'fecha_baja'
from mascotas m JOIN clientes c ON m.Id_Cliente = c.Id_Cliente  
	join atenciones a ON m.Id_Mascota = a.Id_Mascota
	where m.Nombre like @nombreMascota and c.Nombre like @nombreCliente and c.Apellido like @apellidoCliente and c.nro_dni = @dni and a.Fecha between @fechaDesde AND @fechaHasta 
end
else 
begin
select 
	a.Id_Atencion,
	a.Fecha 'fecha',
	c.Nombre 'cliente',
	C.Apellido 'apellido cliente',
	c.nro_dni 'dni',
	m.Nombre 'mascota',
	a.Descripcion 'descripcion',
	a.Importe 'importe',
	a.Fecha_Control 'fecha_control',
	a.fecha_baja 'fecha_baja'
from mascotas m JOIN clientes c ON m.Id_Cliente = c.Id_Cliente  
	join atenciones a ON m.Id_Mascota = a.Id_Mascota
	where m.Nombre like @nombreMascota and c.Nombre like @nombreCliente and c.Apellido like @apellidoCliente and c.nro_dni = @dni and a.fecha_baja is null and a.Fecha between @fechaDesde AND @fechaHasta 
end
END
GO
/****** Object:  StoredProcedure [dbo].[get_all_mascotas]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[get_all_mascotas]
as
begin
select m.id_mascota,
		m.nombre, 
		m.fecha_nac,
		m.fecha_def, 
		sexo,
		e.nombre 'especie', 
		r.nombre 'raza', 
		c.nombre + ' ' + c.Apellido 'cliente',
		m.esterilizado
		from mascotas m inner join  especies e on m.Id_Especie = e.Id_especie
			inner join clientes c on m.Id_Cliente = c.Id_cliente
			inner join razas r on m.razas = r.Id_Raza
end
GO
/****** Object:  StoredProcedure [dbo].[GET_ATENCION]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[GET_ATENCION]
  @idAtencion int
  AS 
  BEGIN
	SELECT * from atenciones where id_atencion = @idAtencion
END
GO
/****** Object:  StoredProcedure [dbo].[GET_CLIENTE_by_id]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GET_CLIENTE_by_id]
@ID INT
AS 
BEGIN
	SELECT * FROM CLIENTES c inner join domicilios d on c.Id_domicilio = d.Id_domicilio WHERE Id_Cliente = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[get_clientes]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[get_clientes]
AS
BEGIN
SELECT c.Id_Cliente, c.nombre, c.apellido, c.nro_dni, td.Descripcion, d.Calle, d.Numero, l.Nombre 'nombre_localidad' FROM Clientes c inner join Tipos_dni  td on c.Id_tipo = td.Id_tipo INNER JOIN domicilios d ON c.Id_domicilio = d.Id_domicilio inner join localidades l on d.Id_localidad = l.Id_localidad
END
GO
/****** Object:  StoredProcedure [dbo].[get_mascota_por_id]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[get_mascota_por_id]
	@id int
	as 
	begin
	SELECT 
			m.id_mascota,
			m.nombre,
			m.fecha_nac,
			m.fecha_def, 
			sexo,
			e.id_Especie 'especie', 
			r.id_raza 'raza', 
			c.id_cliente,
			m.esterilizado
		FROM MASCOTAS m inner join clientes c on m.Id_Cliente = c.Id_Cliente
			inner join razas r on r.Id_Raza = m.razas 
			inner join Especies e on e.Id_especie = m.Id_Especie
		WHERE id_mascota = @id
	end
GO
/****** Object:  StoredProcedure [dbo].[get_mascotas]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[get_mascotas]
@idCliente int
AS
BEGIN
SELECT * FROM mascotas
WHERE Id_Cliente = @idCliente
END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_MASCOTA]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_MASCOTA]
	
	@Nombre varchar(50),
	@Fecha_nac date,
	@Fecha_def date,
	@sexo bit,
	@Id_Especie int,
	@Id_Cliente int,
	@Esterilizado bit,
	@raza int

AS	
	declare @id_mascota int
	set @id_mascota = (SELECT max(id_mascota)+1 FROM mascotas)

Begin
	insert into Mascotas(id_mascota, Nombre, fecha_nac, fecha_def, Sexo, Id_Especie, Id_Cliente, Esterilizado, razas)
			values(@id_mascota, @Nombre, @Fecha_nac, @Fecha_def, @sexo, @Id_Especie, @Id_Cliente, @Esterilizado, @raza);
end

GO
/****** Object:  StoredProcedure [dbo].[REGISTRAR_BAJA_ATENCION]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[REGISTRAR_BAJA_ATENCION] 
	@atencion_nro int
AS
BEGIN
	UPDATE Atenciones SET fecha_baja = GETDATE()
	WHERE id_atencion = @atencion_nro;
	
END
GO
/****** Object:  StoredProcedure [dbo].[SAVE_ATENCIONES]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SAVE_ATENCIONES]
@idAtencion int,
@idMascota int,
@fechaAtencion datetime,
@fechaControl datetime,
@Importe decimal(6,2),
@descripcion varchar(200)
AS
BEGIN
INSERT Atenciones (id_atencion, descripcion, Fecha, importe, id_mascota, fecha_control)
VALUES (@idAtencion, @descripcion, @fechaAtencion, @Importe, @idMascota, @fechaControl);
END
GO
/****** Object:  StoredProcedure [dbo].[SAVE_CLIENTES]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SAVE_CLIENTES]
  @CALLE VARCHAR(50),
  @NRO_DIRECCION INT, 
  @ID_LOCALIDAD INT,
  @ID_TIPO INT,
  @NOMBRE VARCHAR(50),
  @APELLIDO VARCHAR(50),
  @NRO_DNI INT
  AS
  BEGIN
	INSERT INTO DOMICILIOS (CALLE, Id_localidad, Numero)
	VALUES (@CALLE, @ID_LOCALIDAD, @NRO_DIRECCION)
	declare  @ID_DOMICILIO INT
	SET @ID_DOMICILIO = (SELECT  max(ID_DOMICILIO) FROM DOMICILIOS)
	declare  @ID_cliente int
	SET @ID_cliente = (SELECT  max(ID_cliente) + 1 FROM clientes)
	IF(@ID_cliente > 0)
	BEGIN	
		INSERT CLIENTES (id_cliente, NOMBRE, APELLIDO, ID_DOMICILIO, ID_TIPO, NRO_DNI)
		VALUES (@id_cliente, @NOMBRE, @APELLIDO, @ID_DOMICILIO, @ID_TIPO, @NRO_DNI )
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR]
@tabla varchar(50)
as
begin if @tabla = 'Domicilio'
			select * from Domicilios
	 else if @tabla = 'Localidad'
			select * from Localidades
	 else if @tabla = 'Tipo'
			select * from Tipos_dni

end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_E-R]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_CONSULTAR_E-R]
@tabla varchar(50)
as
begin if @tabla = 'Especies'
			select * from Especies
	 else if @tabla = 'Razas'
			select * from Razas

end
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_LOCALIDAD]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_LOCALIDAD]

AS
BEGIN

	SELECT * FROM Localidades;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPO_DNI]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPO_DNI]

AS
BEGIN

	SELECT * FROM Tipos_dni;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EXISTE_RESTABLECER]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_EXISTE_RESTABLECER]
@Usuario varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Matricula varchar(50)

as
begin
	select * from Veterinarios
	where Usuario = @Usuario 
	and Nombre = @Nombre
	and Apellido = @Apellido
	and Matricula = @Matricula
end
GO
/****** Object:  StoredProcedure [dbo].[SP_EXISTE_USUARIO]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_EXISTE_USUARIO]
@Usuario varchar(50)
as
begin
	select Usuario from Veterinarios
	where Usuario = @Usuario
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_VETERINARIO]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERT_VETERINARIO]
@Nombre varchar(50),
@Apellido varchar(50),
@Matricula int,
@Usuario varchar(50),
@Contraseña varchar(50),
--@Id_Domicilio int,
--@Tipo int,
@nro varchar(50)
as
begin


	insert into Veterinarios(Nombre, Apellido, Matricula, usuario, contraseña, Id_domicilio, Id_tipo, nro_dni)
				values(@Nombre, @Apellido, @Matricula, @Usuario, @Contraseña, 2, 1, @nro)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Login]
	@usuario varchar(50),
	@password varchar(50)
AS
BEGIN
	SELECT * FROM Veterinarios WHERE Usuario =  @usuario AND Contraseña =  @password

  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT max(id_Atencion)+1 FROM Atenciones);
END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ATENCION]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_ATENCION]
@idAtencion int,
@fecha datetime,
@fechaControl datetime,
@descripcion varchar(250),
@importe decimal(6,2)
AS
BEGIN 
	UPDATE atenciones 
		SET Fecha = @fecha,
		Fecha_Control = @fechaControl,
		Descripcion = @descripcion,
		Importe = @importe
		WHERE Id_Atencion = @idAtencion
end
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_CLIENTE]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATE_CLIENTE]
@CALLE VARCHAR(50),
@NRO_DIRECCION INT, 
@ID_LOCALIDAD INT,
@ID_CLIENTE INT,
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),

@ID_TIPO INT,
@NRO_DNI INT
AS
BEGIN
	UPDATE CLIENTES 
		SET  NOMBRE = @NOMBRE,
		APELLIDO = @APELLIDO,
		Id_tipo = @ID_TIPO,
		nro_dni = @NRO_DNI
		WHERE ID_CLIENTE = @ID_CLIENTE

	DECLARE @ID_DOMICILIO INT
	set @ID_DOMICILIO = (SELECT ID_DOMICILIO FROM CLIENTES WHERE ID_CLIENTE = @ID_CLIENTE)
	UPDATE domicilios
		SET Calle = @CALLE,
			Numero = @NRO_DIRECCION,
			Id_localidad = @ID_LOCALIDAD
			WHERE Id_domicilio = @Id_domicilio
END
GO
/****** Object:  StoredProcedure [dbo].[update_mascota]    Script Date: 03/11/2021 10:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[update_mascota]
	@Nombre varchar(50),
	@Fecha_nac date,
	@Fecha_def date,
	@sexo bit,
	@Id_Especie int,
	@Id_Cliente int,
	@Esterilizado bit,
	@raza int,
	@id_mascota int

	AS 
	BEGIN
	
	UPDATE mascotas 
		set nombre = @Nombre,
			fecha_nac = @Fecha_nac,
			fecha_def = @Fecha_def,
			Sexo = @sexo,
			Id_Especie = @Id_Especie,
			Id_Cliente = @Id_Cliente,
			Esterilizado = @Esterilizado,
			razas = @raza
			WHERE Id_Mascota = @Id_mascota
	END
GO
