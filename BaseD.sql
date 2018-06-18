CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulos
(
	ArticulosId int primary KEY identity(1,1),
	FechaVencimiento datetime,
	Descripcion varchar(max),
	Precio decimal,
	Existencia int,
	CantidadCotizada int
);