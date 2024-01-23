USE nutricion_integral

/*------------------------------PROCEDIMIENTOS PARA USUARIOS----------------------------------*/
--PROCEDIMIENTO PARA GURDAR UN USUARIO

CREATE PROC SP_RegistrarUsuario(
@documento varchar(50),
@nombre varchar(100),
@correo varchar(100),
@contraseña varchar(100),
@idRol int,
@estado bit,
@idUsuarioResultado int output,
@mensaje varchar(500) output
)

AS 
BEGIN
	set @idUsuarioResultado = 0
	set @mensaje = ''
	if not EXISTS (select * from USUARIO where Documento = @documento)
	begin 
		insert into USUARIO(Documento,Nombre,Correo,Contraseña,IdRol,Estado) values (@documento,@nombre,@correo,@contraseña,@idRol,@estado)
		set @idUsuarioResultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'No se puede repetir el documento para mas de un usuario'

END

--PROCEDIMIENTO PARA MODIFICAR UN USUARIO

CREATE PROC SP_EditarUsuario(
@idUsuario int,
@documento varchar(50),
@nombre varchar(100),
@correo varchar(100),
@contraseña varchar(100),
@idRol int,
@estado bit,
@respuesta bit output,
@mensaje varchar(500) output
)

AS 
BEGIN
	set @respuesta = 0
	set @mensaje = ''
	if not EXISTS (select * from USUARIO where Documento = @documento and IdUsuario != @idUsuario)
	begin 
		update USUARIO set
		Documento = @documento,
		Nombre = @nombre,
		Correo = @correo,
		Contraseña = @contraseña,
		IdRol = @idRol,
		Estado = @estado

		where IdUsuario = @idUsuario
		set @respuesta = 1
	end
	else
		set @mensaje = 'No se puede repetir el documento para mas de un usuario'

END

--PROCEDIMIENTO PARA ELIMINAR UN USUARIO

CREATE PROC SP_EliminarUsuario(
@idUsuario int,
@respuesta bit output,
@mensaje varchar(500) output
)

AS 
BEGIN
	set @respuesta = 0
	set @mensaje = ''
	declare @pasoreglas bit = 1

	if exists (select * from COMPRA c inner join USUARIO u on u.IdUsuario = c.IdUsuario
				where u.IdUsuario = @idUsuario)
	begin
		set @pasoreglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No es posible eliminar porque el usuario se encuentra relacionado a una COMPRA\n'	
	end

	if exists (select * from VENTA	v inner join USUARIO u on u.IdUsuario = v.IdUsuario
				where u.IdUsuario = @idUsuario)
	begin
		set @pasoreglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No es posible eliminar porque el usuario se encuentra relacionado a una VENTA\n'	
	end

	if (@pasoreglas =1) 
	begin
		delete from USUARIO where IdUsuario = @idUsuario
		set @respuesta = 1
	end
end

/*------------------------------PROCEDIMIENTOS PARA CATEGORIA----------------------------------*/

--PROCEDIMIENTO PARA GUARDAR UNA CATEGORIA

CREATE PROC SP_RegistrarCategoria(
@descripcion varchar(50),
@estado bit,
@resultado int output,
@mensaje varchar(500) output
)
AS 
BEGIN
	set @resultado = 0
	if not EXISTS (select * from CATEGORIA where Descripcion = @descripcion)
	begin 
		insert into CATEGORIA(Descripcion, Estado) values (@descripcion, @estado)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'No se puede repetir la descripcion de una categoria'
END

--PROCEDIMIENTO PARA EDITAR UNA CATEGORIA

CREATE PROC SP_EditarCategoria(
@idCategoria int,
@descripcion varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output
)
AS 
BEGIN
	set @resultado = 1
	if	NOT EXISTS (select * from CATEGORIA where Descripcion = @descripcion AND IdCategoria != @idCategoria)
	
		update CATEGORIA set
		Descripcion = @descripcion,
		Estado = @estado
		where IdCategoria = @idCategoria
	else
	begin
		set @resultado = 0
		set @mensaje = 'No se puede repetir la descripcion de una categoria'
	end
END

--PROCEDIMIENTO PARA ELIMINAR UNA CATEGORIA

CREATE PROC SP_EliminarCategoria(
@idCategoria int,
@resultado bit output,
@mensaje varchar(500) output
)
AS 
BEGIN
	set @resultado = 1
	if	NOT EXISTS (select * from CATEGORIA c inner join PRODUCTO p 
	on p.IdCategoria = c.IdCategoria
	where c.IdCategoria = @idCategoria
	)
	begin
		DELETE top(1) from CATEGORIA where IdCategoria = @idCategoria
	end
	else
	begin
		set @resultado = 0
		set @mensaje = 'La categoria se encuentra relacionada a un producto'
	end
END

---------------------PROCEDIMIENTOS ALMACENADOS PARA PRODUCTO------------------------------------

--PROCEDIMIENTO PARA GURDAR UN PRODUCTO

CREATE PROC SP_RegistrarProducto(
@codigo varchar(20),
@descripcion varchar(30),
@idCategoria int,
@estado bit,
@resultado int output,
@mensaje varchar(500) output
)
AS 
BEGIN
	set @resultado = 0
	if not EXISTS (select * from PRODUCTO where Codigo = @codigo)
	begin 
		insert into PRODUCTO(Codigo,Descripcion,IdCategoria, Estado) values (@codigo, @descripcion,@idCategoria, @estado)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'Ya existe un producto con el mismo codigo'
END

--PROCEDIMIENTO PARA EDITAR UN PRODUCTO

CREATE PROC SP_EditarProducto(
@idProducto int,
@codigo varchar(20),
@descripcion varchar(30),
@idCategoria int,
@estado bit,
@resultado bit output,
@mensaje varchar(500) output
)
AS 
BEGIN
	set @resultado = 1
	if	NOT EXISTS (select * from PRODUCTO where Codigo = @codigo AND IdProducto != @idProducto)
	
		update PRODUCTO set
		Codigo = @codigo,
		Descripcion = @descripcion,
		IdCategoria = @idCategoria,
		Estado = @estado
		where IdProducto = @idProducto
	else
	begin
		set @resultado = 0
		set @mensaje = 'Ya existe un producto con el mismo codigo'
	end
END

--PROCEDIMIENTO PARA ELIMINAR UN PRODUCTO

CREATE PROC SP_EliminarProducto(
@idProducto int,
@respuesta bit output,
@mensaje varchar(500) output
)
AS 
BEGIN
	set @respuesta = 0
	set @mensaje = ''
	declare @pasoreglas bit = 1

	if exists (select * from DETALLE_COMPRA dc inner join PRODUCTO p on p.IdProducto = dc.IdProducto
				where p.IdProducto = @idProducto)
	begin
		set @pasoreglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No es posible eliminar porque el usuario se encuentra relacionado a una COMPRA\n'	
	end

	if exists (select * from DETALLE_VENTA	dv inner join PRODUCTO p on p.IdProducto = dv.IdProducto
				where p.IdProducto = @idProducto)
	begin
		set @pasoreglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No es posible eliminar porque el usuario se encuentra relacionado a una VENTA\n'	
	end

	if (@pasoreglas =1) 
	begin
		delete from PRODUCTO where IdProducto = @idProducto
		set @respuesta = 1
	end
end

----------------------------PROCEDIMIENTO ALMACENADOS PARA CLIENTE----------------------------------

--PROCEDIMIENTO PARA GUARDAR UN CLIENTE

CREATE PROC SP_RegistrarCliente(
@documento varchar(50),
@nombre varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado int output,
@mensaje varchar(500) output
)

AS 
BEGIN
	set @resultado = 0
	declare @IDPERSONA int
	if not EXISTS (select * from CLIENTE where Documento = @documento)
	begin 
		insert into CLIENTE(Documento,Nombre,Correo,Telefono,Estado) values (@documento,@nombre,@correo,@telefono,@estado)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'El numero de documento ya existe'

END

--PROCEDIMIENTO PARA MODIFICAR UN CLIENTE

CREATE PROC SP_EditarCliente(
@idCliente int,
@documento varchar(50),
@nombre varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@respuesta bit output,
@mensaje varchar(500) output
)

AS 
BEGIN
	set @respuesta = 1
	Declare @IDPERSONA int
	if not EXISTS (select * from CLIENTE where Documento = @documento and IdCliente != @idCliente)
	begin 
		update CLIENTE set
		Documento = @documento,
		Nombre = @nombre,
		Correo = @correo,
		Telefono = @telefono,
		Estado = @estado

		where IdCliente = @idCliente
	end
	else
	begin
		set @respuesta= 0
		set @mensaje = 'El numero de documento ya existe'
	end

END

-----------------------PROCEDIMIENTOS ALMACENADOS DE PROVEEDORES---------------------------

----PROCEDIMIENTO PARA GUARDAR UN PROVEEDOR

CREATE PROC SP_RegistrarProveedor(
@documento varchar(50),
@razonSocial varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado int output,
@mensaje varchar(500) output
)

AS 
BEGIN
	set @resultado = 0
	declare @IDPERSONA int
	if not EXISTS (select * from PROVEEDOR where Documento = @documento)
	begin 
		insert into PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) values (@documento,@razonSocial,@correo,@telefono,@estado)
		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'El numero de documento ya existe'

END

--PROCEDIMIENTO PARA MODIFICAR UN PROVEEDOR

CREATE PROC SP_EditarProveedor(
@idProveedor int,
@documento varchar(50),
@razonSocial varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@respuesta bit output,
@mensaje varchar(500) output
)

AS 
BEGIN
	set @respuesta = 1
	Declare @IDPERSONA int
	if not EXISTS (select * from PROVEEDOR where Documento = @documento and IdProveedor != @idProveedor)
	begin 
		update PROVEEDOR set
		Documento = @documento,
		RazonSocial = @razonSocial,
		Correo = @correo,
		Telefono = @telefono,
		Estado = @estado

		where IdProveedor = @idProveedor
	end
	else
	begin
		set @respuesta= 0
		set @mensaje = 'El numero de documento ya existe'
	end

END

--PROCEDIMIENTO PARA ELIMINAR UN PROVEEDOR

CREATE PROC SP_EliminarProveedor(
@idProveedor int,
@resultado bit output,
@mensaje varchar(500) output
)
AS 
BEGIN
	set @resultado = 1
	if	NOT EXISTS (select * from PROVEEDOR p inner join COMPRA c 
	on p.IdProveedor = c.IdProveedor
	where c.IdProveedor = @idProveedor
	)
	begin
		DELETE top(1) from PROVEEDOR where IdProveedor = @idProveedor
	end
	else
	begin
		set @resultado = 0
		set @mensaje = 'El proveedor se encuentra relacionada a una compra'
	end
END

-----------------------PROCEDIMIENTOS ALMACENADOS DE COMPRAS---------------------------

--PROCEDIMIENTO PARA REGISTRAR UNA COMPRA

CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
	[IdProducto] int NULL,
	[PrecioCompra] decimal(18,2) NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[MontoTotal] decimal(18,2) NULL
)

CREATE PROCEDURE SP_RegistrarCompra(
@IdUsuario int,
@IdProveedor int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@MontoTotal decimal(18,2),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado bit output,
@mensaje varchar(500) output
)
as
begin
	begin try
		declare @idCompra int = 0
		set @Resultado = 1
		set @mensaje = ''

		begin transaction registro
			
			insert into COMPRA(IdUsuario,IdProveedor,TipoDocumento,NroDocumento,MontoTotal) values (@IdUsuario,@IdProveedor,@TipoDocumento,@NumeroDocumento,@MontoTotal)
			set @idCompra = SCOPE_IDENTITY()

			insert into DETALLE_COMPRA(IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal)
			select @idCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal from @DetalleCompra

			update p set p.stock = p.Stock + dc.Cantidad,
			p.PrecioCompra = dc.PrecioCompra,
			p.PrecioVenta = dc.PrecioVenta
			from PRODUCTO p
			inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto


		commit transaction registro

	end try

	begin catch
		
		set @Resultado = 0
		set @mensaje= ERROR_MESSAGE()
		rollback transaction registro
	
	end catch

end

-----------------------PROCEDIMIENTOS ALMACENADOS DE VENTAS---------------------------

--PROCEDIMIENTO PARA REGISTRAR UNA VENTA	

CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
	[IdProducto] int NULL,
	[PrecioVenta] decimal(18,2) NULL,
	[Cantidad] int NULL,
	[SubTotal] decimal(18,2) NULL
)

CREATE PROCEDURE SP_RegistrarVenta(
@IdUsuario int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@DocumentoCliente varchar(500),
@NombreCliente varchar(500),
@MontoPago decimal(18,2),
@MontoCambio decimal(18,2),
@MontoTotal decimal(18,2),
@DetalleVenta [EDetalle_Venta] READONLY,
@Resultado bit output,
@mensaje varchar(500) output
)
as
begin
	begin try
		declare @idVenta int = 0
		set @Resultado = 1
		set @mensaje = ''

		begin transaction registro
			
			insert into VENTA(IdUsuario,TipoDocumento,NroDocumento,DocumentoCliente,NombreCliente,MontoPago,MontoCambio,MontoTotal) 
			values (@IdUsuario,@TipoDocumento,@NumeroDocumento,@DocumentoCliente,@NombreCliente,@MontoPago,@MontoCambio,@MontoTotal)
			
			set @idVenta = SCOPE_IDENTITY()

			insert into DETALLE_VENTA(IdVenta,IdProducto,PrecioVenta,Cantidad,SubTotal)
			select @idVenta,IdProducto,PrecioVenta,Cantidad,SubTotal from @DetalleVenta

		commit transaction registro

	end try

	begin catch
		
		set @Resultado = 0
		set @mensaje= ERROR_MESSAGE()
		rollback transaction registro
	
	end catch

end
-----------------------PROCEDIMIENTOS ALMACENADOS DE REPORTES DE COMPRAS---------------------------

CREATE PROC SP_ReporteCompras(
@fechainicio varchar(10),
@fechafin varchar(10),
@idproveedor int
)

as
begin

	set DATEFORMAT dmy;
		SELECT CONVERT(char(10),c.FechaRegistro,103)[FechaRegistro], c.TipoDocumento,c.NroDocumento,c.MontoTotal,
		u.Nombre[UsuarioRegistro],
		pr.Documento[DocumentoProveedor],pr.RazonSocial,
		p.Codigo[CodigoProducto],p.Descripcion[NombreProducto],ca.Descripcion[Categoria],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]
		FROM COMPRA c
		inner join USUARIO u on u.IdUsuario = c.IdUsuario
		inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
		inner join DETALLE_COMPRA dc on dc.IdCompra = c.IdCompra
		inner join PRODUCTO p on p.IdProducto = dc.IdProducto
		inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
		WHERE CONVERT(date,c.FechaRegistro) between @fechainicio and @fechafin
		AND pr.IdProveedor = iif (@idproveedor = 0, pr.IdProveedor, @idproveedor)
end

-----------------------PROCEDIMIENTOS ALMACENADOS DE REPORTES DE VENTAS---------------------------
CREATE PROC SP_ReporteVentas(
@fechainicio varchar(10),
@fechafin varchar(10)
)

as
begin

	set DATEFORMAT dmy;
		SELECT CONVERT(char(10),v.FechaRegistro,103)[FechaRegistro], v.TipoDocumento,v.NroDocumento,v.MontoTotal,
		u.Nombre[UsuarioRegistro],
		v.DocumentoCliente,v.NombreCliente,
		p.Codigo[CodigoProducto],p.Descripcion[NombreProducto],ca.Descripcion[Categoria],dv.PrecioVenta,dv.Cantidad,dv.SubTotal
		FROM VENTA v
		inner join USUARIO u on u.IdUsuario = v.IdUsuario
		inner join DETALLE_VENTA dv on dv.IdVenta = v.IdVenta
		inner join PRODUCTO p on p.IdProducto = dv.IdProducto
		inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
		WHERE CONVERT(date,v.FechaRegistro) between @fechainicio and @fechafin
end
