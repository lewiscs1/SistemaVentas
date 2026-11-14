IF DB_ID('BDVentas') IS NULL
CREATE DATABASE BDVentas;
GO
USE BDVentas;
GO
IF OBJECT_ID('Producto') IS NOT NULL DROP TABLE Producto;
GO
CREATE TABLE Producto(
IdProducto INT IDENTITY PRIMARY KEY,
Nombre VARCHAR(100) NOT NULL,
Categoria VARCHAR(50) NOT NULL,
Precio DECIMAL(10,2) NOT NULL,
Stock INT NOT NULL,
Activo BIT NOT NULL
);
GO
INSERT INTO Producto(Nombre, Categoria, Precio, Stock, Activo) VALUES
('Inca Kola 500ml', 'Bebidas', 2.50, 40, 1),
('Coca Cola 500ml', 'Bebidas', 2.50, 35, 1),
('Papas Lays', 'Snacks', 1.50, 60, 1),
('Leche Gloria', 'Lácteos', 4.20, 50, 1);
GO
SELECT * FROM Producto;
