USE nutricion_integral

INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Semillas',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Frutos secos',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Cereales y legumbres',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Especias',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Celiacos',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Orgánicos',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Harinas',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Veganos',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Hierbas',1);
INSERT INTO CATEGORIA(Descripcion,Estado) VALUES ('Infusiones',1);

SELECT * FROM CATEGORIA

INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (1,'100','Semillas de Chia',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (1,'101','Semillas de Sesamo',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (1,'102','Semillas de Zapallo',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (1,'103','Semillas de Amaranto',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (2,'104','Pistacho pelado',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (2,'105','Nuez Pecan',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (2,'106','Castañas de Caju',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (2,'139','Mani Japones',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (3,'107','Garbanzo Sauco',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (3,'108','Lentejas Turcas',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (3,'109','Poroto negro',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (3,'110','Arvejas',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (4,'111','Canela molida',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (4,'112','Merken',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (4,'113','Pimienta rosa',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (4,'114','Tomillo',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (5,'115','Fideos de arroz con espicana',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (5,'116','Pasta de sesamo',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (5,'117','Avellana con chocolate',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (5,'118','Fecula de mandioca',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (6,'119','Aceite de oliva',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (6,'120','Vinagre de manzana',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (6,'121','Ajo ahumado organico',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (6,'122','Azucar Mascabo',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (7,'123','Harina de centeno',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (7,'124','Harina de soja',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (7,'125','Harina de trigo',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (7,'126','Harina de lino',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (8,'127','Medallon de lentejas',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (8,'128','Budin de zanahoria',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (8,'129','Tokes de Thai',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (8,'130','Ñoquis de Sarraceno',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (9,'131','Manzanilla',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (9,'132','Cedrón',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (9,'133','Alcachofa',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (9,'134','Albahaca',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (10,'135','Te verde',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (10,'136','Te rojo',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (10,'137','Te negro',1);
INSERT INTO PRODUCTO(IdCategoria,Codigo,Descripcion,Estado) VALUES (10,'138','Te Miel',1);

SELECT * FROM PRODUCTO

INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('23871654','Jose Gonzalez','jose@gmail.com','3794001002',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('25896432','Analia Franco','analia@gmail.com','3794341002',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('45671654','Damian Alegre','damian@gmail.com','3794045662',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('42871654','David Fernandez','david@gmail.com','3794001432',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('26871654','Rosa Gimenez','rosa@gmail.com','3794054002',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('33871654','Marta Escobar','marta@gmail.com','3794054202',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('47871654','Olvia Repiso','olivia@gmail.com','3794357002',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('53871654','Oscar Busellato','oscar@gmail.com','3794987002',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('12871654','Raul Caceres','raul@gmail.com','3794023402',1);
INSERT INTO CLIENTE(Documento,Nombre,Correo,Telefono,Estado) VALUES('44871654','Susana Yacuzzi','susana@gmail.com','3794062502',1);

SELECT * FROM CLIENTE

INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('202424432422','Bio Salud','biosalud@gmail.com','08004356543',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('202424462342','LasFor Alimentos','lasforalimentos@gmail.com','08004356542',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('205452424432','Cafadya Dietetica','cafadyadietec@gmail.com','08004356541',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('202485732422','Idraet Suplementos Naturales','idraetsuplnaturales@gmail.com','08004356547',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('202486432422','Frutos del NOA','frutosdelnoa@gmail.com','08004356548',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('202424432425','Brotes Organic','brotesorganic@gmail.com','08004356549',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('20242424255','NutriBio Lite','ntribiolite@gmail.com','08004356540',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('223424432422','Sport Nutrition','sportnutrition@gmail.com','08002356543',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('207324432422','NorDiet','Nordiet@gmail.com','08004356544',1);
INSERT INTO PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) VALUES('282849432422','NutreMax Apu','Nutremax@gmail.com','08004325543',1);

SELECT * FROM PROVEEDOR