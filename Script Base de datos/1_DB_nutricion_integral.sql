--CREACION DE LA BASE DE DATOS Y DEFINICION DE LAS TABLAS 

CREATE DATABASE nutricion_integral
GO

USE nutricion_integral
GO

CREATE table ROL(
IdRol int PRIMARY KEY identity,
Descripcion varchar(50),
FechaRegistro datetime default getdate()
)

CREATE table PERMISO(
IdPermiso int PRIMARY KEY identity,
IdRol int REFERENCES ROL(IdRol),
Descripcion varchar(50),
FechaRegistro datetime default getdate()
)

CREATE table PROVEEDOR(
IdProveedor int PRIMARY KEY identity,
Documento varchar(50),
RazonSocial varchar(50),
Correo varchar(50),
Telefono varchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)

CREATE table CLIENTE(
IdCliente int PRIMARY KEY identity,
Documento varchar(50),
Nombre varchar(50),
Correo varchar(50),
Telefono varchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)

CREATE table USUARIO(
IdUsuario int PRIMARY KEY identity,
Documento varchar(50),
Nombre varchar(50),
Correo varchar(50),
Contraseña varchar(50),
IdRol int REFERENCES ROL(IdRol),
Estado bit,
FechaRegistro datetime default getdate()
)

CREATE table CATEGORIA(
IdCategoria int PRIMARY KEY identity,
Descripcion varchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)

CREATE table PRODUCTO(
IdProducto int PRIMARY KEY identity,
IdCategoria int REFERENCES CATEGORIA(IdCategoria),
Codigo varchar(50),
Descripcion varchar(50),
Stock int not null default 0,
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate()
)

CREATE table COMPRA(
IdCompra int PRIMARY KEY identity,
IdUsuario int REFERENCES USUARIO(IdUsuario),
IdProveedor int REFERENCES PROVEEDOR(IdProveedor),
TipoDocumento varchar(50),
NroDocumento varchar(50),
MontoTotal decimal (10,2),
FechaRegistro datetime default getdate()
)

CREATE table DETALLE_COMPRA(
IdDetalleCompra int PRIMARY KEY identity,
IdCompra int REFERENCES COMPRA(IdCompra),
IdProducto int REFERENCES PRODUCTO(IdProducto),
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Cantidad int,
MontoTotal decimal (10,2),
FechaRegistro datetime default getdate()
)

CREATE table VENTA(
IdVenta int PRIMARY KEY identity,
IdUsuario int REFERENCES USUARIO(IdUsuario),
TipoDocumento varchar(50),
NroDocumento varchar(50),
DocumentoCliente varchar(50),
NombreCliente varchar(100),
MontoPago decimal(10,2),
MontoCambio decimal(10,2),
MontoTotal decimal (10,2),
FechaRegistro datetime default getdate()
)

CREATE table DETALLE_VENTA(
IdDetalleVenta int PRIMARY KEY identity,
IdVenta int REFERENCES VENTA(IdVenta),
IdProducto int REFERENCES PRODUCTO(IdProducto),
PrecioVenta decimal(10,2),
Cantidad int,
SubTotal decimal (10,2),
FechaRegistro datetime default getdate()
)

CREATE table NEGOCIO(
IdNegocio int primary key,
Nombre varchar(60),
RUC varchar(60),
Direccion varchar(60),
Logo varbinary(max) NULL
)

-----------------------------------------------------------------------------------------------------------------------------------------
/*LOTE DE DATOS BASICO PARA INICIAR APLICACION Y LUEGO INGRESAR LOS DEMAS EN LA MISMA*/

/*ROLES PARA ASIGNAR A USUARIOS*/
insert into ROL(Descripcion) values ('ADMINISTRADOR');
insert into ROL(Descripcion) values ('GERENTE');
insert into ROL(Descripcion) values ('EMPLEADO');

/*USUARIOS PARA INICIAR SESION*/
insert into USUARIO(Documento,Nombre,Correo,Contraseña,IdRol,Estado) values ('1010','ADMIN', 'admin@gmail.com', '123',1,1);
insert into USUARIO(Documento,Nombre,Correo,Contraseña,IdRol,Estado) values ('2020','GERENTE', 'gerente@gmail.com', '456',2,1);
insert into USUARIO(Documento,Nombre,Correo,Contraseña,IdRol,Estado) values ('3030','EMPLEADO', 'empleado@gmail.com', '789',3,1);

/*PERMISOS PARA MOSTRAR MENU DE INICIO DE LOS DIFERENTES ROLES/PERFILES*/

/*ADMINISTRADOR-DIRECTIVO*/
insert into PERMISO(IdRol, Descripcion) values 
(1,'menu_usuario'),
(1,'menu_mantenedor'),
(1,'menu_ventas'),
(1,'menu_compras'),
(1,'menu_clientes'),
(1,'menu_proveedores'),
(1,'menu_reportes'),
(1,'menu_estadisticas'),
(1,'menu_backup'),
(1,'menu_acercade'),
/*GERENTE-SUPERIOR*/
(2,'menu_mantenedor'),
(2,'menu_ventas'),
(2,'menu_compras'),
(2,'menu_clientes'),
(2,'menu_proveedores'),
(2,'menu_acercade'),
/*EMPLEADO-OPERARIO*/ 
(3,'menu_ventas'),
(3,'menu_clientes'),
(3,'menu_acercade')

/*NEGOCIO CON LOGO PARA IMPRIMIR DETALLES*/
insert into NEGOCIO(IdNegocio,Nombre,RUC,Direccion)	values (1,'Nutricion Integral', 'N° Legajo:54503', 'Universidad Nacional del Nordeste')
-------------------------------------------------------------------------------------------------------------------------------------------

SELECT * FROM ROL
SELECT * FROM PERMISO
SELECT * FROM PROVEEDOR
SELECT * FROM CLIENTE
SELECT * FROM USUARIO
SELECT * FROM CATEGORIA
SELECT * FROM PRODUCTO
SELECT * FROM COMPRA
SELECT * FROM DETALLE_COMPRA
SELECT * FROM VENTA
SELECT * FROM DETALLE_VENTA
SELECT * FROM NEGOCIO
------------------------------------------------------------------------------------
SELECT COUNT(*) as 'Cantidad de roles' FROM ROL
SELECT COUNT(*) as 'Cantidad de permisos' FROM PERMISO
SELECT COUNT(*) as 'Cantidad de proveedores' FROM PROVEEDOR
SELECT COUNT(*) as 'Cantidad de clientes' FROM CLIENTE
SELECT COUNT(*) as 'Cantidad de usuarios' FROM USUARIO
SELECT COUNT(*) as 'Cantidad de categorias' FROM CATEGORIA
SELECT COUNT(*) as 'Cantidad de productos' FROM PRODUCTO
SELECT COUNT(*) as 'Cantidad de compras' FROM COMPRA
SELECT COUNT(*) as 'Cantidad de detalles de compras' FROM DETALLE_COMPRA
SELECT COUNT(*) as 'Cantidad de ventas' FROM VENTA
SELECT COUNT(*) as 'Cantidad de detalles de ventas' FROM DETALLE_VENTA
SELECT COUNT(*) as 'Cantidad de negocios' FROM NEGOCIO