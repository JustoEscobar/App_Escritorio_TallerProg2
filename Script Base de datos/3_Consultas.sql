use nutricion_integral

/*OTRAS CONSULTAS*/

--PARA VER DETALLE COMPRAS

SELECT	C.IdCompra, u.Nombre,pr.Documento,pr.RazonSocial,c.TipoDocumento,c.NroDocumento,c.MontoTotal,CONVERT(char(10),c.FechaRegistro,103)[FechaRegistro] FROM COMPRA c
inner join USUARIO u on u.IdUsuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
where c.NroDocumento = '00002'

SELECT p.Descripcion,dc.PrecioCompra,dc.Cantidad, dc.MontoTotal FROM DETALLE_COMPRA dc
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
where dc.IdCompra = 2

SELECT * FROM PRODUCTO

UPDATE PRODUCTO SET stock = stock - 5 WHERE idproducto = 4

SELECT v.IdVenta,u.Nombre,
v.DocumentoCliente,v.NombreCliente,
v.TipoDocumento,v.NroDocumento,
v.MontoPago,v.MontoCambio,v.MontoTotal,
CONVERT(char(10),v.FechaRegistro,103)[FechaRegistro]
FROM VENTA v
inner join USUARIO u on u.IdUsuario = v.IdUsuario
where v.NroDocumento = '00001'

SELECT p.Descripcion,dv.PrecioVenta,dv.Cantidad,dv.SubTotal
FROM DETALLE_VENTA dv
inner join PRODUCTO	p on p.IdProducto = dv.IdProducto
where dv.IdVenta = 1

--------REPORTES SOBRE VETAS (CONSULTAS COMPLEJAS)------------

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
WHERE CONVERT(date,c.FechaRegistro) between '8/12/2023' and '13/12/2023'
AND pr.IdProveedor = 1

---------
select * from USUARIO

DECLARE @respuesta bit
DECLARE @mensaje varchar(500)

EXEC SP_EditarUsuario 2,'123', 'pruebas 2', 'test@gmail', '456', 2,1, @respuesta output, @mensaje output

SELECT @respuesta
SELECT @mensaje
---------

SELECT IdProducto,Codigo,p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria], Stock,PrecioCompra,PrecioVenta, p.Estado FROM PRODUCTO p
INNER JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria

insert into PRODUCTO(Codigo,Descripcion,IdCategoria,Estado) values ('101010','Harina integral',3,1)

SELECT * FROM PRODUCTO

----------
--prueba
exec SP_ReporteCompras '13/12/2023','13/12/2023',2

 --prueba
 exec SP_ReporteVentas '13/12/2023','13/12/2023'

 -------GRAFICOS ESTADISTICOS

 SELECT DATEPART(MONTH, FechaRegistro) AS Nombre_Mes, COUNT (*) AS CantVentas
                    from VENTA
                    where(FechaRegistro BETWEEN @fechadesde AND @fechahasta) OR (fecha_retiro BETWEEN @fechadesde AND @fechahasta) OR (fecha_ingreso < @fechadesde AND fecha_retiro > @fechahasta)
                    GROUP BY DATEPART(MONTH, FechaRegistro)
                    ORDER BY DATEPART(MONTH, FechaRegistro) ASC

SELECT DATEPART(MONTH,FechaRegistro)[MES],COUNT(*) FROM VENTA
GROUP BY DATEPART(MONTH,FechaRegistro)

SELECT * FROM VENTA
SELECT * FROM DETALLE_VENTA
-------------------------------------------------------------------------------------------

/*En el mes que elija, se muestre en porcentajes de las categorias, proporcion de torta, como se vendieron, para saber cuales se consumen mas*/

SELECT c.IdCategoria, SUM(dv.Cantidad) as 'cantidad vendida', DATEPART(MONTH,dv.FechaRegistro) as 'Mes' FROM DETALLE_VENTA dv
INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
INNER JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria
GROUP BY c.IdCategoria, dv.FechaRegistro

-------------------------------------------------------------------------------------------
SELECT c.IdCategoria,c.Descripcion, SUM(dv.Cantidad) as 'Cantidad_Vendida' FROM DETALLE_VENTA dv
INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
INNER JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria
GROUP BY c.IdCategoria,c.Descripcion
ORDER BY [Cantidad_Vendida] DESC

SELECT s.cod_servicio as ID, s.nombre as nombre ,  count(*) as ServiciosCantidad " +
                    "from DetalleServicios ds " +
                    "JOIN servicios s ON ds.cod_servicio = s.cod_servicio " +
                    "GROUP BY s.cod_servicio , s.nombre " +
                    "ORDER BY ServiciosCantidad DESC ";
