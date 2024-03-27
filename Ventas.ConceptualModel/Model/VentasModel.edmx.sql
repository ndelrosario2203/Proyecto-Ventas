
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/25/2024 16:33:01
-- Generated from EDMX file: C:\Users\noel5\source\repos\Ventas.Domain\Ventas.ConceptualModel\Model\VentasModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Sales];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Producto__IdCate__5EBF139D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Productoes] DROP CONSTRAINT [FK__Producto__IdCate__5EBF139D];
GO
IF OBJECT_ID(N'[dbo].[FK__DetalleVe__IdVen__5CD6CB2B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleVentas] DROP CONSTRAINT [FK__DetalleVe__IdVen__5CD6CB2B];
GO
IF OBJECT_ID(N'[dbo].[FK__Menu__IdMenuPadr__5DCAEF64]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Menus] DROP CONSTRAINT [FK__Menu__IdMenuPadr__5DCAEF64];
GO
IF OBJECT_ID(N'[dbo].[FK__RolMenu__IdMenu__5FB337D6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolMenus] DROP CONSTRAINT [FK__RolMenu__IdMenu__5FB337D6];
GO
IF OBJECT_ID(N'[dbo].[FK__RolMenu__IdRol__60A75C0F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RolMenus] DROP CONSTRAINT [FK__RolMenu__IdRol__60A75C0F];
GO
IF OBJECT_ID(N'[dbo].[FK__Usuario__IdRol__619B8048]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK__Usuario__IdRol__619B8048];
GO
IF OBJECT_ID(N'[dbo].[FK__Venta__IdTipoDoc__628FA481]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ventas] DROP CONSTRAINT [FK__Venta__IdTipoDoc__628FA481];
GO
IF OBJECT_ID(N'[dbo].[FK__Venta__IdUsuario__6383C8BA]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ventas] DROP CONSTRAINT [FK__Venta__IdUsuario__6383C8BA];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Configuracions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Configuracions];
GO
IF OBJECT_ID(N'[dbo].[DetalleVentas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleVentas];
GO
IF OBJECT_ID(N'[dbo].[Menus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menus];
GO
IF OBJECT_ID(N'[dbo].[Negocios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Negocios];
GO
IF OBJECT_ID(N'[dbo].[NumeroCorrelativoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NumeroCorrelativoes];
GO
IF OBJECT_ID(N'[dbo].[Productoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Productoes];
GO
IF OBJECT_ID(N'[dbo].[Rols]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rols];
GO
IF OBJECT_ID(N'[dbo].[RolMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RolMenus];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TipoDocumentoVentas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoDocumentoVentas];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Ventas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ventas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NULL,
    [EsActivo] bit  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL,
    [FechaMod] datetime  NULL,
    [IdUsuarioMod] int  NULL,
    [IdUsuarioElimino] int  NULL,
    [FechaElimino] datetime  NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'Configuracions'
CREATE TABLE [dbo].[Configuracions] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [Recurso] varchar(50)  NULL,
    [Propiedad] varchar(50)  NULL,
    [Valor] varchar(60)  NULL
);
GO

-- Creating table 'DetalleVentas'
CREATE TABLE [dbo].[DetalleVentas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdVenta] int  NULL,
    [IdProducto] int  NULL,
    [MarcaProducto] varchar(100)  NULL,
    [DescripcionProducto] varchar(100)  NULL,
    [CategoriaProducto] varchar(100)  NULL,
    [Cantidad] int  NULL,
    [Precio] decimal(10,2)  NULL,
    [Total] decimal(10,2)  NULL
);
GO

-- Creating table 'Menus'
CREATE TABLE [dbo].[Menus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(30)  NULL,
    [IdMenuPadre] int  NULL,
    [Icono] varchar(30)  NULL,
    [Controlador] varchar(30)  NULL,
    [PaginaAccion] varchar(30)  NULL,
    [EsActivo] bit  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL,
    [FechaMod] datetime  NULL,
    [IdUsuarioMod] int  NULL,
    [IdUsuarioElimino] int  NULL,
    [FechaElimino] datetime  NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'Negocios'
CREATE TABLE [dbo].[Negocios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UrlLogo] varchar(500)  NULL,
    [NombreLogo] varchar(100)  NULL,
    [NumeroDocumento] varchar(50)  NULL,
    [Nombre] varchar(50)  NULL,
    [Correo] varchar(50)  NULL,
    [Direccion] varchar(50)  NULL,
    [Telefono] varchar(50)  NULL,
    [PorcentajeImpuesto] decimal(10,2)  NULL,
    [SimboloMoneda] varchar(5)  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL,
    [FechaMod] datetime  NULL,
    [IdUsuarioMod] int  NULL,
    [IdUsuarioElimino] int  NULL,
    [FechaElimino] datetime  NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'NumeroCorrelativoes'
CREATE TABLE [dbo].[NumeroCorrelativoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UltimoNumero] int  NULL,
    [CantidadDigitos] int  NULL,
    [Gestion] varchar(100)  NULL,
    [FechaActualizacion] datetime  NULL
);
GO

-- Creating table 'Productoes'
CREATE TABLE [dbo].[Productoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoBarra] varchar(50)  NULL,
    [Marca] varchar(50)  NULL,
    [Descripcion] varchar(100)  NULL,
    [IdCategoria] int  NULL,
    [Stock] int  NULL,
    [UrlImagen] varchar(500)  NULL,
    [NombreImagen] varchar(100)  NULL,
    [Precio] decimal(10,2)  NULL,
    [EsActivo] bit  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL,
    [FechaMod] datetime  NULL,
    [IdUsuarioMod] int  NULL,
    [IdUsuarioElimino] int  NULL,
    [FechaElimino] datetime  NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'Rols'
CREATE TABLE [dbo].[Rols] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(30)  NULL,
    [EsActivo] bit  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL,
    [FechaMod] datetime  NULL,
    [IdUsuarioMod] int  NULL,
    [IdUsuarioElimino] int  NULL,
    [FechaElimino] datetime  NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'RolMenus'
CREATE TABLE [dbo].[RolMenus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdRol] int  NULL,
    [IdMenu] int  NULL,
    [EsActivo] bit  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL,
    [FechaMod] datetime  NULL,
    [IdUsuarioMod] int  NULL,
    [IdUsuarioElimino] int  NULL,
    [FechaElimino] datetime  NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TipoDocumentoVentas'
CREATE TABLE [dbo].[TipoDocumentoVentas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NULL,
    [EsActivo] bit  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL,
    [FechaMod] datetime  NULL,
    [IdUsuarioMod] int  NULL,
    [IdUsuarioElimino] int  NULL,
    [FechaElimino] datetime  NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Correo] varchar(50)  NULL,
    [Telefono] varchar(50)  NULL,
    [IdRol] int  NULL,
    [UrlFoto] varchar(500)  NULL,
    [NombreFoto] varchar(100)  NULL,
    [Clave] varchar(100)  NULL,
    [EsActivo] bit  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL,
    [FechaMod] datetime  NULL,
    [IdUsuarioMod] int  NULL,
    [IdUsuarioElimino] int  NULL,
    [FechaElimino] datetime  NULL,
    [Eliminado] bit  NOT NULL
);
GO

-- Creating table 'Ventas'
CREATE TABLE [dbo].[Ventas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumeroVenta] varchar(6)  NULL,
    [IdTipoDocumentoVenta] int  NULL,
    [IdUsuario] int  NULL,
    [CocumentoCliente] varchar(10)  NULL,
    [NombreCliente] varchar(20)  NULL,
    [SubTotal] decimal(10,2)  NULL,
    [ImpuestoTotal] decimal(10,2)  NULL,
    [Total] decimal(10,2)  NULL,
    [FechaRegistro] datetime  NOT NULL,
    [IdUsuarioCreacion] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Configuracions'
ALTER TABLE [dbo].[Configuracions]
ADD CONSTRAINT [PK_Configuracions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetalleVentas'
ALTER TABLE [dbo].[DetalleVentas]
ADD CONSTRAINT [PK_DetalleVentas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [PK_Menus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Negocios'
ALTER TABLE [dbo].[Negocios]
ADD CONSTRAINT [PK_Negocios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NumeroCorrelativoes'
ALTER TABLE [dbo].[NumeroCorrelativoes]
ADD CONSTRAINT [PK_NumeroCorrelativoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Productoes'
ALTER TABLE [dbo].[Productoes]
ADD CONSTRAINT [PK_Productoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rols'
ALTER TABLE [dbo].[Rols]
ADD CONSTRAINT [PK_Rols]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RolMenus'
ALTER TABLE [dbo].[RolMenus]
ADD CONSTRAINT [PK_RolMenus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoDocumentoVentas'
ALTER TABLE [dbo].[TipoDocumentoVentas]
ADD CONSTRAINT [PK_TipoDocumentoVentas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [PK_Ventas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdCategoria] in table 'Productoes'
ALTER TABLE [dbo].[Productoes]
ADD CONSTRAINT [FK__Producto__IdCate__5EBF139D]
    FOREIGN KEY ([IdCategoria])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Producto__IdCate__5EBF139D'
CREATE INDEX [IX_FK__Producto__IdCate__5EBF139D]
ON [dbo].[Productoes]
    ([IdCategoria]);
GO

-- Creating foreign key on [IdVenta] in table 'DetalleVentas'
ALTER TABLE [dbo].[DetalleVentas]
ADD CONSTRAINT [FK__DetalleVe__IdVen__5CD6CB2B]
    FOREIGN KEY ([IdVenta])
    REFERENCES [dbo].[Ventas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__DetalleVe__IdVen__5CD6CB2B'
CREATE INDEX [IX_FK__DetalleVe__IdVen__5CD6CB2B]
ON [dbo].[DetalleVentas]
    ([IdVenta]);
GO

-- Creating foreign key on [IdMenuPadre] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [FK__Menu__IdMenuPadr__5DCAEF64]
    FOREIGN KEY ([IdMenuPadre])
    REFERENCES [dbo].[Menus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Menu__IdMenuPadr__5DCAEF64'
CREATE INDEX [IX_FK__Menu__IdMenuPadr__5DCAEF64]
ON [dbo].[Menus]
    ([IdMenuPadre]);
GO

-- Creating foreign key on [IdMenu] in table 'RolMenus'
ALTER TABLE [dbo].[RolMenus]
ADD CONSTRAINT [FK__RolMenu__IdMenu__5FB337D6]
    FOREIGN KEY ([IdMenu])
    REFERENCES [dbo].[Menus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RolMenu__IdMenu__5FB337D6'
CREATE INDEX [IX_FK__RolMenu__IdMenu__5FB337D6]
ON [dbo].[RolMenus]
    ([IdMenu]);
GO

-- Creating foreign key on [IdRol] in table 'RolMenus'
ALTER TABLE [dbo].[RolMenus]
ADD CONSTRAINT [FK__RolMenu__IdRol__60A75C0F]
    FOREIGN KEY ([IdRol])
    REFERENCES [dbo].[Rols]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__RolMenu__IdRol__60A75C0F'
CREATE INDEX [IX_FK__RolMenu__IdRol__60A75C0F]
ON [dbo].[RolMenus]
    ([IdRol]);
GO

-- Creating foreign key on [IdRol] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK__Usuario__IdRol__619B8048]
    FOREIGN KEY ([IdRol])
    REFERENCES [dbo].[Rols]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Usuario__IdRol__619B8048'
CREATE INDEX [IX_FK__Usuario__IdRol__619B8048]
ON [dbo].[Usuarios]
    ([IdRol]);
GO

-- Creating foreign key on [IdTipoDocumentoVenta] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [FK__Venta__IdTipoDoc__628FA481]
    FOREIGN KEY ([IdTipoDocumentoVenta])
    REFERENCES [dbo].[TipoDocumentoVentas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Venta__IdTipoDoc__628FA481'
CREATE INDEX [IX_FK__Venta__IdTipoDoc__628FA481]
ON [dbo].[Ventas]
    ([IdTipoDocumentoVenta]);
GO

-- Creating foreign key on [IdUsuario] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [FK__Venta__IdUsuario__6383C8BA]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Venta__IdUsuario__6383C8BA'
CREATE INDEX [IX_FK__Venta__IdUsuario__6383C8BA]
ON [dbo].[Ventas]
    ([IdUsuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------