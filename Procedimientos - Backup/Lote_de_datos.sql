USE TiendaDB;
GO

-- ===== Insertar Roles
INSERT INTO roles (nombre) VALUES ('ADMINISTRADOR');
INSERT INTO roles (nombre) VALUES ('VENDEDOR');
INSERT INTO roles (nombre) VALUES ('SUPERVISOR');


-- ===== Insertar usuarios
-- Admin (id_rol = 1)
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Karen','Rios','admin@tiendadb.com','admin',44407002,'2002-08-08',0,'123',1);

-- Vendedores (id_rol = 2)
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Bruno','Lopez','b.lopez@tiendadb.com','blopez',44100001,'1999-01-10',1,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Agustin','Sosa','a.sosa@tiendadb.com','asosa',44100002,'1998-02-12',1,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Micaela','Fernandez','m.fernandez@tiendadb.com','mfer',44100003,'2001-03-15',0,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Valentina','Martinez','v.martinez@tiendadb.com','vmart',44100004,'2000-04-20',0,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Elias','Brunaga','e.brunaga@tiendadb.com','elias',44100005,'2000-08-01',1,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Wilson','Merlo','w.merlo@tiendadb.com','wilmerlo',44100006,'2003-06-01',1,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Sofia','Gomez','s.gomez@tiendadb.com','sgomez',44100007,'2002-07-22',0,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Franco','Diaz','f.diaz@tiendadb.com','fdiaz',44100008,'1997-09-09',1,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Lucia','Acosta','l.acosta@tiendadb.com','lacosta',44100009,'2001-11-11',0,'123',2);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Camila','Vega','c.vega@tiendadb.com','cvega',44100010,'1998-12-30',0,'123',2);

-- Supervisores (id_rol = 3)
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Juan','Perez','j.perez@tiendadb.com','supervisor',44110001,'2000-12-08',1,'123',3);
INSERT INTO usuarios(nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, id_rol)
VALUES ('Nadia','Ruiz','n.ruiz@tiendadb.com','supervisor2',44110002,'1999-05-05',0,'123',3);



-- ===== Insertar permisos
insert into permisos(id_rol, nombre_menu) values --Admin
(1, 'menuUsuarios'),
(1, 'menuBackUp'),
(1, 'menuSalir')

insert into permisos(id_rol, nombre_menu) values --Vendedor
(2, 'menuVentas'),
(2, 'menuClientes'),
(2, 'menuReportes'),
(2, 'menuSalir')

INSERT INTO permisos (id_rol, nombre_menu) VALUES --Supervisor
(3, 'menuProductos'),
(3, 'menuReportes'),
(3, 'menuSalir');



-- ===== CLIENTES (20)
INSERT INTO clientes (dni, nombre, apellido, email, direccion, sexo, telefono, activo) VALUES
(45892123,'María','González','maria.gonzalez@gmail.com','Av. Corrientes 1234, CABA',0,'11-4058-673',1);
INSERT INTO clientes VALUES (42154896,'Juan','Pérez','juan.perez@hotmail.com','San Martín 554, Córdoba',1,'351-572-846',1);
INSERT INTO clientes VALUES (37984561,'Lucía','Fernández','lucia.fernandez@yahoo.com','Rivadavia 875, Rosario',0,'341-476-273',1);
INSERT INTO clientes VALUES (40658912,'Carlos','Ramírez','carlos.ramirez@gmail.com','Mitre 2345, Mendoza',1,'261-577-662',1);
INSERT INTO clientes VALUES (42365478,'Sofía','Martínez','sofia.martinez@outlook.com','Bv. Oroño 1750, Rosario',0,'341-400-827',1);
INSERT INTO clientes VALUES (40111222,'Martín','Suárez','martin.suarez@gmail.com','Belgrano 1010, La Plata',1,'221-455-120',1);
INSERT INTO clientes VALUES (38900123,'Paula','Rojas','paula.rojas@gmail.com','Colón 2222, Mar del Plata',0,'223-600-333',1);
INSERT INTO clientes VALUES (40222333,'Diego','Santos','diego.santos@yahoo.com','Urquiza 777, Paraná',1,'343-420-111',1);
INSERT INTO clientes VALUES (41222444,'Ana','Molina','ana.molina@gmail.com','Sarmiento 345, Salta',0,'387-530-222',1);
INSERT INTO clientes VALUES (43222555,'Camilo','Vera','camilo.vera@gmail.com','Catamarca 66, Resistencia',1,'362-700-555',1);
INSERT INTO clientes VALUES (45222666,'Julieta','Pardo','julieta.pardo@gmail.com','Alvear 890, Neuquén',0,'299-480-777',1);
INSERT INTO clientes VALUES (47222777,'Ramiro','Lagos','ramiro.lagos@gmail.com','9 de Julio 123, Tucumán',1,'381-420-888',1);
INSERT INTO clientes VALUES (48222888,'Nadia','Paz','nadia.paz@yahoo.com','Lavalle 321, Corrientes',0,'379-420-999',1);
INSERT INTO clientes VALUES (49222999,'Victoria','Ibarra','victoria.ibarra@gmail.com','San Juan 555, San Juan',0,'264-410-444',1);
INSERT INTO clientes VALUES (50223000,'Matías','Roldán','matias.roldan@gmail.com','España 1212, Posadas',1,'376-450-333',1);
INSERT INTO clientes VALUES (51223001,'Nahuel','Ayala','nahuel.ayala@gmail.com','Patricios 300, Bahía Blanca',1,'291-430-111',1);
INSERT INTO clientes VALUES (52223002,'Carla','Brito','carla.brito@gmail.com','Maipú 456, San Luis',0,'266-440-222',1);
INSERT INTO clientes VALUES (53223003,'Rocío','Delgado','rocio.delgado@gmail.com','Moreno 789, Jujuy',0,'388-420-333',1);
INSERT INTO clientes VALUES (54223004,'Tomás','Quiroga','tomas.quiroga@gmail.com','Güemes 654, Catamarca',1,'383-415-444',1);
INSERT INTO clientes VALUES (55223005,'Milagros','Benítez','milagros.benitez@gmail.com','Perú 234, Formosa',0,'370-460-555',1);



-- =======================
-- CARGA DE PRODUCTOS
-- =======================

INSERT INTO productos (codigo,nombre,descripcion,precio,imagen_url,activo) VALUES ('NK-AF1','Nike Air Force 1','Zapatillas Nike originales.',120.00,'air-force-1.jpg',1);
INSERT INTO productos VALUES ('NK-AM90','Nike Air Max 90','Zapatillas Nike originales.',140.00,'air-max-90.jpg',1);
INSERT INTO productos VALUES ('NK-DNKL','Nike Dunk Low','Zapatillas Nike originales.',130.00,'dunk-low.jpg',1);
INSERT INTO productos VALUES ('NK-BL77','Nike Blazer Mid 77','Zapatillas Nike originales.',110.00,'blazer-mid-77.jpg',1);
INSERT INTO productos VALUES ('NK-AM95','Nike Air Max 95','Zapatillas Nike originales.',160.00,'air-max-95.jpg',1);
INSERT INTO productos VALUES ('NK-AM97','Nike Air Max 97','Zapatillas Nike originales.',170.00,'air-max-97.jpg',1);
INSERT INTO productos VALUES ('NK-AM270','Nike Air Max 270','Zapatillas Nike originales.',155.00,'air-max-270.jpg',1);
INSERT INTO productos VALUES ('NK-RCT','Nike React Element 55','Zapatillas Nike originales.',145.00,'react-55.jpg',1);
INSERT INTO productos VALUES ('NK-PG6','Nike PG 6','Zapatillas Nike originales.',150.00,'pg6.jpg',1);
INSERT INTO productos VALUES ('NK-KD15','Nike KD 15','Zapatillas Nike originales.',175.00,'kd15.jpg',1);
INSERT INTO productos VALUES ('NK-METC','Nike Metcon 8','Zapatillas Nike originales.',135.00,'metcon8.jpg',1);
INSERT INTO productos VALUES ('NK-PEG','Nike Pegasus 40','Zapatillas Nike originales.',130.00,'pegasus40.jpg',1);
INSERT INTO productos VALUES ('NK-INV','Nike Invincible 3','Zapatillas Nike originales.',180.00,'invincible3.jpg',1);
INSERT INTO productos VALUES ('NK-VOM','Nike Vomero 17','Zapatillas Nike originales.',175.00,'vomero17.jpg',1);
INSERT INTO productos VALUES ('NK-CORT','Nike Cortez','Zapatillas Nike originales.',100.00,'cortez.jpg',1);



-- ===== TALLES POR PRODUCTO (id_producto 1..15)

-- 1 AF1
INSERT INTO talle_producto (id_producto,talla,stock) VALUES (1,'8US',12);
INSERT INTO talle_producto VALUES (1,'9US',18);
INSERT INTO talle_producto VALUES (1,'10US',25);

-- 2 AM90
INSERT INTO talle_producto VALUES (2,'9US',22);
INSERT INTO talle_producto VALUES (2,'10US',14);

-- 3 Dunk Low
INSERT INTO talle_producto VALUES (3,'8US',19);
INSERT INTO talle_producto VALUES (3,'9US',11);
INSERT INTO talle_producto VALUES (3,'10US',27);

-- 4 Blazer Mid 77
INSERT INTO talle_producto VALUES (4,'8US',9);
INSERT INTO talle_producto VALUES (4,'9US',17);

-- 5 AM95
INSERT INTO talle_producto VALUES (5,'9US',23);
INSERT INTO talle_producto VALUES (5,'10US',16);
INSERT INTO talle_producto VALUES (5,'8US',7);

-- 6 AM97
INSERT INTO talle_producto VALUES (6,'9US',21);
INSERT INTO talle_producto VALUES (6,'10US',15);

-- 7 AM270
INSERT INTO talle_producto VALUES (7,'8US',13);
INSERT INTO talle_producto VALUES (7,'9US',20);
INSERT INTO talle_producto VALUES (7,'10US',26);

-- 8 React 55
INSERT INTO talle_producto VALUES (8,'9US',12);
INSERT INTO talle_producto VALUES (8,'10US',18);

-- 9 PG 6
INSERT INTO talle_producto VALUES (9,'8US',8);
INSERT INTO talle_producto VALUES (9,'9US',19);
INSERT INTO talle_producto VALUES (9,'10US',24);

--10 KD 15
INSERT INTO talle_producto VALUES (10,'9US',16);
INSERT INTO talle_producto VALUES (10,'10US',11);

--11 Metcon 8
INSERT INTO talle_producto VALUES (11,'8US',10);
INSERT INTO talle_producto VALUES (11,'9US',15);
INSERT INTO talle_producto VALUES (11,'10US',22);

--12 Pegasus 40
INSERT INTO talle_producto VALUES (12,'9US',14);
INSERT INTO talle_producto VALUES (12,'10US',21);

--13 Invincible 3
INSERT INTO talle_producto VALUES (13,'8US',6);
INSERT INTO talle_producto VALUES (13,'9US',13);
INSERT INTO talle_producto VALUES (13,'10US',28);

--14 Vomero 17
INSERT INTO talle_producto VALUES (14,'9US',12);
INSERT INTO talle_producto VALUES (14,'10US',19);

--15 Cortez
INSERT INTO talle_producto VALUES (15,'8US',30);
INSERT INTO talle_producto VALUES (15,'9US',18);



/* ===== VENTAS: 10 por vendedor (10 vendedores) con 1–3 ítems ===== */

IF OBJECT_ID('tempdb..#map')      IS NOT NULL DROP TABLE #map;
IF OBJECT_ID('tempdb..#vend')     IS NOT NULL DROP TABLE #vend;
IF OBJECT_ID('tempdb..#cbte')     IS NOT NULL DROP TABLE #cbte;
IF OBJECT_ID('tempdb..#lineas')   IS NOT NULL DROP TABLE #lineas;
IF OBJECT_ID('tempdb..#totales')  IS NOT NULL DROP TABLE #totales;

CREATE TABLE #map    (id_usuario INT, nro_cbte INT, id_factura INT);
CREATE TABLE #vend   (id_usuario INT PRIMARY KEY);
CREATE TABLE #cbte   (id_usuario INT, nro_cbte INT, PRIMARY KEY(id_usuario, nro_cbte));
CREATE TABLE #lineas (id_usuario INT, nro_cbte INT, line_no INT, id_talle INT, cantidad INT);
CREATE TABLE #totales(id_usuario INT, nro_cbte INT, importe_total DECIMAL(12,2), PRIMARY KEY(id_usuario, nro_cbte));

-- 10 vendedores activos
INSERT INTO #vend(id_usuario)
SELECT TOP (10) id_usuario
FROM usuarios
WHERE id_rol = (SELECT id_rol FROM roles WHERE nombre='VENDEDOR') AND activo=1
ORDER BY id_usuario;

-- 10 comprobantes por vendedor (nro_cbte = 1..10)
INSERT INTO #cbte(id_usuario, nro_cbte)
SELECT v.id_usuario, s.n
FROM #vend v
CROSS JOIN (VALUES (1),(2),(3),(4),(5),(6),(7),(8),(9),(10)) AS S(n);

-- Renglones 1..3 por comprobante, filtrando para variar cantidad de ítems
INSERT INTO #lineas(id_usuario, nro_cbte, line_no, id_talle, cantidad)
SELECT
    c.id_usuario,
    c.nro_cbte,
    rn.line_no,
    1 + (( (c.id_usuario)*10 + c.nro_cbte + rn.line_no ) % (SELECT COUNT(*) FROM talle_producto)) AS id_talle,
    CASE ((c.nro_cbte + rn.line_no) % 3) WHEN 0 THEN 1 WHEN 1 THEN 2 ELSE 3 END AS cantidad
FROM #cbte c
CROSS APPLY (VALUES (1),(2),(3)) rn(line_no)
WHERE ((c.id_usuario + c.nro_cbte + rn.line_no) % 3) <> 0;  -- elimina aprox 1/3 de líneas

-- Totales por factura
INSERT INTO #totales(id_usuario, nro_cbte, importe_total)
SELECT l.id_usuario, l.nro_cbte,
       CAST(SUM(l.cantidad * p.precio) AS DECIMAL(12,2)) AS importe_total
FROM #lineas l
JOIN talle_producto tp ON tp.id_talle = l.id_talle
JOIN productos p ON p.id_producto = tp.id_producto
GROUP BY l.id_usuario, l.nro_cbte;

-- Inserta facturas y mapea a #map
INSERT INTO factura (punto_venta, nro_cbte, id_cliente, id_usuario, importe_total, fecha, id_factura_origen)
OUTPUT INSERTED.id_usuario, INSERTED.nro_cbte, INSERTED.id_factura INTO #map(id_usuario, nro_cbte, id_factura)
SELECT
    1 AS punto_venta,
    t.nro_cbte,
    1 + ((t.id_usuario + t.nro_cbte - 1) % 20) AS id_cliente,  -- clientes 1..20
    t.id_usuario,
    t.importe_total,
    DATEADD(DAY, -((t.id_usuario + t.nro_cbte) % 30), SYSDATETIME()),
    NULL
FROM #totales t;

-- Detalles
INSERT INTO detalle_factura (id_factura, id_talle, cantidad, precio_unitario)
SELECT m.id_factura,
       l.id_talle,
       l.cantidad,
       p.precio
FROM #lineas l
JOIN #map m
  ON m.id_usuario = l.id_usuario AND m.nro_cbte = l.nro_cbte
JOIN talle_producto tp ON tp.id_talle = l.id_talle
JOIN productos p ON p.id_producto = tp.id_producto;

-- Limpieza
DROP TABLE #totales;
DROP TABLE #lineas;
DROP TABLE #cbte;
DROP TABLE #vend;
DROP TABLE #map;

select * from roles
select * from usuarios
select * from permisos
select * from clientes
select * from productos
select * from talle_producto
select * from detalle_factura
select * from factura