﻿CREATE TABLE [dbo].[Clientes]
(
   Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
	Dui NVARCHAR(10) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL

);