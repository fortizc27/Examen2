﻿CREATE TABLE [dbo].[Orden]
(
	[IdOrden] INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Orden PRIMARY KEY CLUSTERED(IdOrden), 
    [IdProducto] INT NOT NULL CONSTRAINT [FK_Orden_Producto] FOREIGN KEY ([IdProducto]) REFERENCES dbo.Producto([IdProducto]), 
    [CantidadProducto] INT NOT NULL, 
    [Estado] BIT NOT NULL
)WITH (DATA_COMPRESSION = PAGE)
GO
