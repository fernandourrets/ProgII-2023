USE [master]
GO
/****** Object:  Database [Servicios_Informaticos]    Script Date: 05/09/2023 15:59:24 ******/
CREATE DATABASE [Servicios_Informaticos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Servicios_Informaticos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Servicios_Informaticos.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Servicios_Informaticos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Servicios_Informaticos_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Servicios_Informaticos] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Servicios_Informaticos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Servicios_Informaticos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET ARITHABORT OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Servicios_Informaticos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Servicios_Informaticos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Servicios_Informaticos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Servicios_Informaticos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Servicios_Informaticos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Servicios_Informaticos] SET  MULTI_USER 
GO
ALTER DATABASE [Servicios_Informaticos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Servicios_Informaticos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Servicios_Informaticos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Servicios_Informaticos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Servicios_Informaticos] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Servicios_Informaticos]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] IDENTITY(1,1) NOT NULL,
	[barrio] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CancelarPagos]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CancelarPagos](
	[id_cancelarPAgo] [int] IDENTITY(1,1) NOT NULL,
	[cancelarPago] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cancelarPAgo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[domicilio] [varchar](30) NULL,
	[nro_domicilio] [int] NULL,
	[id_barrio] [int] NULL,
	[id_tipoDni] [int] NULL,
	[nro_tipoDni] [int] NULL,
	[nro_telefono] [decimal](12, 0) NULL,
	[nro_cliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleEquipo]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleEquipo](
	[id_detalleEquipo] [int] IDENTITY(1,1) NOT NULL,
	[detalleEquipo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalleEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFacturaTecnicas]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFacturaTecnicas](
	[pk_id_tecnica] [int] NOT NULL,
	[pk_id_facturaTecnica] [int] NOT NULL,
	[falla] [varchar](30) NULL,
	[id_estadoEquipo] [int] NULL,
	[garantia] [bit] NULL,
	[id_detalleEquipo] [int] NULL,
	[id_producto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[pk_id_tecnica] ASC,
	[pk_id_facturaTecnica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoEquipo]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoEquipo](
	[id_estadoEquipo] [int] IDENTITY(1,1) NOT NULL,
	[estadoEquipo] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estadoEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaTecnicas]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaTecnicas](
	[id_facturaTecnica] [int] IDENTITY(1000,1) NOT NULL,
	[fechaFacturaTecnica] [datetime] NULL,
	[descuento] [int] NULL,
	[presupuesto] [money] NOT NULL,
	[id_pago] [int] NULL,
	[id_cliente] [int] NOT NULL,
	[id_cancelarPago] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_facturaTecnica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaPagos]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaPagos](
	[id_formaPago] [int] IDENTITY(1,1) NOT NULL,
	[formaPago] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_formaPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[pago] [varchar](30) NOT NULL,
	[detallePago] [varchar](30) NULL,
	[id_FormaPago] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](30) NOT NULL,
	[precio_producto] [money] NOT NULL,
	[modeloProducto] [varchar](25) NULL,
	[id_detalleFacturaTecnica] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnicas]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnicas](
	[id_tecnica] [int] IDENTITY(1,1) NOT NULL,
	[equipo] [varchar](30) NOT NULL,
	[precio_tecnica] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tecnica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDni]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDni](
	[id_tipoDni] [int] IDENTITY(1,1) NOT NULL,
	[tipoDni] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipoDni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD FOREIGN KEY([id_tipoDni])
REFERENCES [dbo].[TipoDni] ([id_tipoDni])
GO
ALTER TABLE [dbo].[DetalleFacturaTecnicas]  WITH CHECK ADD FOREIGN KEY([id_detalleEquipo])
REFERENCES [dbo].[DetalleEquipo] ([id_detalleEquipo])
GO
ALTER TABLE [dbo].[DetalleFacturaTecnicas]  WITH CHECK ADD FOREIGN KEY([id_estadoEquipo])
REFERENCES [dbo].[EstadoEquipo] ([id_estadoEquipo])
GO
ALTER TABLE [dbo].[DetalleFacturaTecnicas]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[DetalleFacturaTecnicas]  WITH CHECK ADD FOREIGN KEY([pk_id_tecnica])
REFERENCES [dbo].[Tecnicas] ([id_tecnica])
GO
ALTER TABLE [dbo].[DetalleFacturaTecnicas]  WITH CHECK ADD FOREIGN KEY([pk_id_tecnica])
REFERENCES [dbo].[FacturaTecnicas] ([id_facturaTecnica])
GO
ALTER TABLE [dbo].[FacturaTecnicas]  WITH CHECK ADD FOREIGN KEY([id_cancelarPago])
REFERENCES [dbo].[CancelarPagos] ([id_cancelarPAgo])
GO
ALTER TABLE [dbo].[FacturaTecnicas]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[FacturaTecnicas]  WITH CHECK ADD  CONSTRAINT [id_pago] FOREIGN KEY([id_pago])
REFERENCES [dbo].[FormaPagos] ([id_formaPago])
GO
ALTER TABLE [dbo].[FacturaTecnicas] CHECK CONSTRAINT [id_pago]
GO
/****** Object:  StoredProcedure [dbo].[AgregarClientes]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarClientes]




( 
 
  
  @apellido varchar(50),

  @nombre varchar (50), 

  @domicilio varchar (50),

  @nroDomicilio int ,

  @id_barrio int ,

  @id_tipoDni int,

  @nro_tipoDni numeric (18,0),

  @nroTelefono numeric(18,0),

  @nroCliente int
  
)






AS
BEGIN
	
	

	

	
   
	
	
	insert into Clientes values (@apellido,@nombre,@domicilio,@nroDomicilio,@id_barrio,@id_tipoDni,@nro_tipoDni,@nroTelefono,@nroCliente) 

	

	
	
	
END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarDetallePresupuesto]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RegistrarDetallePresupuesto] 
	-- Add the parameters for the stored procedure here
	(
	@id_tecnica int,
	
	@id_detalleFactura int,

	@falla varchar(100),

	@id_estadoEquipo int,

	@garantia bit,

	@id_detalleEquipo int,

	@id_producto int

	
	)


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into DetalleFacturaTecnicas (pk_id_tecnica,pk_id_facturaTecnica,falla,id_estadoEquipo,garantia,id_detalleEquipo,id_producto) 
	
	values (@id_tecnica,@id_detalleFactura,@falla,@id_estadoEquipo,@garantia,@id_detalleEquipo,@id_producto)


END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarPresupuesto]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RegistrarPresupuesto] 
	-- Add the parameters for the stored procedure here
	(
	@id_facturaTecnica int output, 
	
	@fechaFacturaTecnica datetime,

	@descuento decimal,

	@presupuesto money,
	
	@id_Pago int,

	@id_cliente int,

	@id_realizarPago int

	
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into FacturaTecnicas (fechaFacturaTecnica,descuento,presupuesto,id_pago,id_cliente,id_cancelarPago) values 
	(@fechaFacturaTecnica, @descuento,@presupuesto,@id_Pago,@id_cliente,@id_realizarPago);


	set @id_facturaTecnica = scope_identity()

END
GO
/****** Object:  StoredProcedure [dbo].[SP_PROXIMO_ID]    Script Date: 05/09/2023 15:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_PROXIMO_ID]
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_cliente)+1  FROM clientes);
END	
GO
USE [master]
GO
ALTER DATABASE [Servicios_Informaticos] SET  READ_WRITE 
GO
