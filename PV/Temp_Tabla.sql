CREATE TABLE [dbo].[Temp_Ventas]
(
	[Codigo] INT NOT NULL PRIMARY KEY,
	[Cajero] nvarchar(30) not null,
	[Cantidad] int not null,
	[Precio] float not null,
	[Iva] INT not null
)
