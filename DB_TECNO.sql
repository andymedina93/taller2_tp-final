
CREATE DATABASE Tecno_Electro 
USE TecnoElectro


CREATE TABLE Personas
(
  id_persona INT IDENTITY(1,1) NOT NULL,
  nombre VARCHAR (50) NOT NULL,
  apellido VARCHAR(50) NOT NULL,
  N_Documento BIGINT NOT NULL,
  celular  VARCHAR(255)NOT NULL,
  direccion VARCHAR(50) NOT NULL,
  fecha_resgistro DATE NOT NULL,
  estado VARCHAR (20) NOT NULL,
  PRIMARY KEY (id_persona)
);

CREATE TABLE Perfiles
(
  id_perfil INT IDENTITY(1,1) NOT NULL,
  descripcion VARCHAR (50) NOT NULL,
  PRIMARY KEY (id_perfil)
);


CREATE TABLE Usuarios (
  id_usuario INT IDENTITY(1,1),
  usuario VARCHAR(50) UNIQUE NOT NULL,
  contraseña NUMERIC NOT NULL,
  perfil_id INT NOT NULL,
  persona_id INT NOT NULL,
  PRIMARY KEY (id_usuario), -- Aquí se agrega la coma
  FOREIGN KEY (perfil_id) REFERENCES Perfiles(id_perfil),
  FOREIGN KEY (persona_id) REFERENCES Personas(id_persona)
);

CREATE TABLE Proveedores
(
  id_proveedor INT IDENTITY(1,1) ,
  Razon_Social VARCHAR (50) unique  NOT NULL,
  persona_id INT NOT NULL,
   PRIMARY KEY (id_proveedor),
  FOREIGN KEY (persona_id) REFERENCES Personas(id_persona)
);

-- Tabla Productos
CREATE TABLE Productos
(
  id_producto INT IDENTITY(1,1) NOT NULL,
  nombre VARCHAR(255) NOT NULL,
  descripcion VARCHAR(255),
  codigo INT NOT NULL,
  precio_vta FLOAT NOT NULL,
  precio_compra FLOAT NOT NULL,
  stock INT NOT NULL,
  estado VARCHAR(20) NOT NULL, -- Ejemplo: 'Activo', 'Inactivo'
  categoria_id INT NOT NULL,
  PRIMARY KEY (id_producto),
  FOREIGN KEY (categoria_id) REFERENCES Categorias(id_categoria)
);

-- Tabla Categorias
CREATE TABLE Categorias
(
  id_categoria INT IDENTITY(1,1) NOT NULL,
  c_descripcion VARCHAR(255) NOT NULL,
  estado VARCHAR(20) NOT NULL, -- Ejemplo: 'Activa', 'Inactiva'
  PRIMARY KEY (id_categoria)
);

-- Tabla Ventas Cabecera
CREATE TABLE Ventas_Cabecera
(
  id_cabecera INT IDENTITY(1,1) NOT NULL,
  usuario_id INT NOT NULL,
  cliente_id INT NOT NULL,
  monto_total FLOAT NOT NULL,
  FechaVenta  DATE NULL,
  PRIMARY KEY (id_cabecera)
);

-- Tabla Ventas Detalles
CREATE TABLE Ventas_Detalles
(
  id_detalle INT IDENTITY(1,1) NOT NULL,
  cantidad INT NOT NULL,
  precio FLOAT NOT NULL,
  producto_id INT NOT NULL,
  cabecera_id INT NOT NULL,
  PRIMARY KEY (id_detalle),
  FOREIGN KEY (producto_id) REFERENCES Productos(id_producto),
  FOREIGN KEY (cabecera_id) REFERENCES Ventas_Cabecera(id_cabecera)
);

Select *from Personas
Select * from Perfiles
select * from Usuarios 
select * from Proveedores
select * from Productos
select * from Categorias
use tecno_electro
select * from Ventas_Detalles
select * from Ventas_Cabecera

INSERT INTO Perfiles ( descripcion)
VALUES 
('Administrador'),
('Cajero'),
('Gerente');

Use Tecno_Electro
INSERT INTO Categorias ( c_descripcion, estado)
VALUES 
('Computacion','Activo'),
('Televisores','Activo'),
('Celulares','Activo');

use tecno_electro
ALTER TABLE ventas_cabecera
ADD FechaVenta  DATE NULL;

use tecno_electro
ALTER TABLE personas
ALTER COLUMN celular VARCHAR(255);



INSERT INTO Personas (nombre, apellido, N_Documento, celular, direccion, fecha_resgistro, estado)
VALUES
('Juan', 'Perez', 1234567890, 3001234567, 'Av. Siempre Viva 123', GETDATE(), 'Activo'),
('Maria', 'Lopez', 2345678901, 3101234568, 'Calle Falsa 456', GETDATE(), 'Activo'),
('Pedro', 'Gomez', 3456789012, 3201234569, 'Carrera Z 789', GETDATE(), 'Inactivo'),
('Laura', 'Diaz', 4567890123, 3301234570, 'Calle 8', GETDATE(), 'Activo'),
('Carlos', 'Ramirez', 5678901234, 3401234571, 'Av. Libertad 999', GETDATE(), 'Inactivo'),
('Sofia', 'Martinez', 6789012345, 3501234572, 'Calle 7', GETDATE(), 'Activo'),
('Miguel', 'Suarez', 7890123456, 3601234573, 'Carrera 5', GETDATE(), 'Activo'),
('Ana', 'Garcia', 8901234567, 3701234574, 'Calle 10', GETDATE(), 'Inactivo'),
('Luis', 'Fernandez', 9012345678, 3801234575, 'Av. Principal', GETDATE(), 'Activo'),
('Elena', 'Morales', 1234567891, 3901234576, 'Calle Luna', GETDATE(), 'Activo');
('Andrea', 'Hernandez', 2345678910, 3001234577, 'Calle Sol 123', GETDATE(), 'Activo'),
('Javier', 'Ortiz', 3456789123, 3101234578, 'Carrera 6', GETDATE(), 'Activo'),
('Paola', 'Cruz', 4567891234, 3201234579, 'Av. Victoria 45', GETDATE(), 'Inactivo'),
('Esteban', 'Jimenez', 5678912345, 3301234580, 'Calle Jardín', GETDATE(), 'Activo'),
('Natalia', 'Vargas', 6789123456, 3401234581, 'Av. Siempre Verde', GETDATE(), 'Activo'),
('Francisco', 'Reyes', 7891234567, 3501234582, 'Calle Colombia', GETDATE(), 'Inactivo'),
('Gabriela', 'Gutierrez', 8901345678, 3601234583, 'Carrera Central', GETDATE(), 'Activo'),
('Ricardo', 'Castro', 9012456789, 3701234584, 'Av. Montaña', GETDATE(), 'Activo'),
('Daniela', 'Romero', 1123456789, 3801234585, 'Calle Norte', GETDATE(), 'Inactivo'),
('Sebastian', 'Marin', 2234567891, 3901234586, 'Carrera Este', GETDATE(), 'Activo'),
('Valentina', 'Paredes', 3345678902, 3001234587, 'Calle Oeste', GETDATE(), 'Activo'),
('Hugo', 'Rios', 4456789013, 3101234588, 'Av. Río', GETDATE(), 'Inactivo'),
('Isabel', 'Lozano', 5567890124, 3201234589, 'Carrera Centro', GETDATE(), 'Activo'),
('Diego', 'Mendoza', 6678901235, 3301234590, 'Calle Verano', GETDATE(), 'Activo'),
('Camila', 'Soto', 7789012346, 3401234591, 'Av. Invierno', GETDATE(), 'Inactivo');


INSERT INTO Usuarios (usuario, contraseña, perfil_id, persona_id)
VALUES
('admin1', 1234, 1, 1),   -- Administrador, persona_id 1
('cajero1', 1234, 2, 2),   -- Cajero, persona_id 2
('gerente1', 1234, 3, 3),  -- Gerente, persona_id 3
('admin2', 1234, 1, 4),    -- Administrador, persona_id 4
('cajero2', 1234, 2, 5),   -- Cajero, persona_id 5
('gerente2', 1234, 3, 6),  -- Gerente, persona_id 6
('admin3', 1234, 1, 7),    -- Administrador, persona_id 7
('cajero3', 1234, 2, 8),   -- Cajero, persona_id 8
('gerente3', 1234, 3, 9),  -- Gerente, persona_id 9
('usuario10', 1234, 2, 10); -- Cajero, persona_id 10


INSERT INTO Productos (nombre, descripcion, codigo, precio_vta, precio_compra, stock, estado, categoria_id)
VALUES
-- Productos de la categoría Computación (categoria_id 1)
('Laptop HP', 'Laptop HP con 8GB RAM y 256GB SSD', 101, 1500.0, 1200.0, 10, 'Activo', 1),
('Mouse Logitech', 'Mouse inalámbrico Logitech', 102, 25.0, 15.0, 50, 'Activo', 1),
('Teclado Mecánico', 'Teclado mecánico retroiluminado', 103, 80.0, 60.0, 20, 'Activo', 1),
('Monitor Samsung', 'Monitor 24 pulgadas Full HD', 104, 200.0, 150.0, 15, 'Activo', 1),
('Impresora Canon', 'Impresora multifuncional Canon', 105, 100.0, 70.0, 30, 'Activo', 1),

-- Productos de la categoría Televisores (categoria_id 2)
('Smart TV LG', 'Smart TV LG 50 pulgadas 4K', 201, 800.0, 600.0, 8, 'Activo', 2),
('Smart TV Samsung', 'Smart TV Samsung 55 pulgadas 4K', 202, 900.0, 650.0, 5, 'Activo', 2),
('Televisor Sony', 'Televisor Sony 40 pulgadas Full HD', 203, 600.0, 450.0, 12, 'Activo', 2),
('Soporte para TV', 'Soporte ajustable para TV de hasta 65 pulgadas', 204, 40.0, 25.0, 20, 'Activo', 2),
('Barra de Sonido', 'Barra de sonido Samsung Bluetooth', 205, 150.0, 100.0, 10, 'Activo', 2),

-- Productos de la categoría Celulares (categoria_id 3)
('iPhone 13', 'iPhone 13 de 128GB', 301, 1000.0, 850.0, 5, 'Activo', 3),
('Samsung Galaxy S21', 'Samsung Galaxy S21 de 128GB', 302, 950.0, 800.0, 8, 'Activo', 3),
('Xiaomi Redmi Note 10', 'Xiaomi Redmi Note 10 64GB', 303, 200.0, 150.0, 25, 'Activo', 3),
('Cargador Inalámbrico', 'Cargador inalámbrico universal', 304, 30.0, 20.0, 40, 'Activo', 3),
('Auriculares Bluetooth', 'Auriculares Bluetooth Xiaomi', 305, 50.0, 30.0, 60, 'Activo', 3);


INSERT INTO Proveedores (Razon_Social, persona_id)
VALUES
('Proveedor A', 1),
('Proveedor B', 2),
('Proveedor C', 3);

INSERT INTO Ventas_Cabecera (usuario_id, cliente_id, monto_total, FechaVenta)
VALUES
(1, 2, 5000.5, GETDATE()),
(2, 3, 1200.0, GETDATE()),
(3, 1, 750.0, GETDATE());

-- Poblar la tabla Ventas_Detalles
INSERT INTO Ventas_Detalles (cantidad, precio, producto_id, cabecera_id)
VALUES
(2, 1200.5, 1, 1),
(1, 1500.75, 2, 2),
(3, 999.99, 3, 3);