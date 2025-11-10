
-- Crea la base de datos (podés cambiar el nombre)
CREATE DATABASE TiendaDB;
GO
USE TiendaDB;
GO

-- ===== ROLES =====
CREATE TABLE roles (
    id_rol INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL  -- ADMIN, VENDEDOR
);

-- ===== PERMISOS =====
CREATE TABLE permisos (
    id_permiso INT IDENTITY(1,1) PRIMARY KEY,
    nombre_menu VARCHAR(120) NOT NULL,
    id_rol INT NOT NULL,
    CONSTRAINT FK_permisos_roles
        FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);
CREATE INDEX IX_permisos_rol ON permisos(id_rol);

-- ===== USUARIOS =====
CREATE TABLE usuarios (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(80) NOT NULL,
    apellido VARCHAR(80) NOT NULL,
    email VARCHAR(120) NOT NULL UNIQUE,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    dni INT NOT NULL UNIQUE,
    fecha_nacimiento DATE NOT NULL,
    sexo BIT NOT NULL,
    hash_password VARCHAR(255) NOT NULL,
    activo BIT NOT NULL CONSTRAINT DF_usuarios_activo DEFAULT (1),
    id_rol INT NOT NULL,
    CONSTRAINT FK_usuarios_roles
        FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);

-- ===== CLIENTES =====
CREATE TABLE clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    dni INT NOT NULL UNIQUE,
    nombre VARCHAR(120) NOT NULL,
    apellido VARCHAR(120) NOT NULL,
    email VARCHAR(120) NOT NULL,
    direccion VARCHAR(120) NOT NULL,
    sexo BIT NOT NULL,
    telefono VARCHAR(40) NOT NULL,
    activo BIT NOT NULL CONSTRAINT DF_clientes_activo DEFAULT (1)
);

-- ===== PRODUCTOS =====
CREATE TABLE productos (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,
    codigo VARCHAR(20) NOT NULL,
    nombre VARCHAR(120) NOT NULL,
    descripcion VARCHAR(MAX) NOT NULL,
    precio DECIMAL(10,2) NOT NULL CHECK (precio >= 0),
    imagen_url VARCHAR(255) NULL,
    activo BIT NOT NULL CONSTRAINT DF_productos_activo DEFAULT (1)
);


-- ===== TALLE_PRODUCTO =====
CREATE TABLE talle_producto (
    id_talle INT IDENTITY(1,1) PRIMARY KEY,
    id_producto INT NOT NULL,
    talla VARCHAR(20) NOT NULL,
    stock INT NOT NULL CONSTRAINT DF_talle_stock DEFAULT (0),
    CONSTRAINT UQ_talle_producto UNIQUE (id_producto, talla),
    CONSTRAINT FK_talle_producto_producto
        FOREIGN KEY (id_producto) REFERENCES productos(id_producto)
);
CREATE INDEX IX_talle_producto_producto ON talle_producto(id_producto);


-----------------------------------
-- ===== FACTURAS =====
CREATE TABLE dbo.factura (
    id_factura   INT IDENTITY(1,1) PRIMARY KEY,

    punto_venta  SMALLINT NOT NULL
        CONSTRAINT CK_factura_pv CHECK (punto_venta BETWEEN 1 AND 9999),

    nro_cbte     INT NOT NULL
        CONSTRAINT CK_factura_cbte CHECK (nro_cbte BETWEEN 1 AND 99999999),

    -- "A 0001-00000001"
    nro_factura AS CAST(
       (CASE WHEN id_factura_origen IS NULL THEN 'A ' ELSE 'NC ' END) +
       RIGHT('0000'     + CAST(punto_venta AS VARCHAR(4)), 4) + '-' +
       RIGHT('00000000' + CAST(nro_cbte     AS VARCHAR(8)), 8)
     AS VARCHAR(16)) PERSISTED,

    id_cliente   INT NOT NULL,
    id_usuario   INT NOT NULL,

    -- TOTAL con regla de signo (ventas >=0; NC <=0 cuando referencian a otra factura)
    importe_total DECIMAL(12,2) NOT NULL,

    fecha        DATETIME2 NOT NULL CONSTRAINT DF_factura_fecha DEFAULT (SYSDATETIME()),

    -- vínculo para notas de crédito
    id_factura_origen INT NULL,

    CONSTRAINT FK_factura_clientes
        FOREIGN KEY (id_cliente) REFERENCES dbo.clientes(id_cliente),
    CONSTRAINT FK_factura_usuarios
        FOREIGN KEY (id_usuario) REFERENCES dbo.usuarios(id_usuario),
    CONSTRAINT FK_factura_origen
        FOREIGN KEY (id_factura_origen) REFERENCES dbo.factura(id_factura),

    CONSTRAINT CK_factura_importe_signo
        CHECK (
               (id_factura_origen IS NULL     AND importe_total >= 0)
            OR (id_factura_origen IS NOT NULL AND importe_total <= 0)
        )
);



-- ===== DETALLES_FACTURA =====
CREATE TABLE detalle_factura (
    id_detalle INT IDENTITY(1,1) PRIMARY KEY,
    id_factura INT NOT NULL,
    id_talle INT NOT NULL, 
    cantidad INT NOT NULL CHECK (cantidad > 0),
    precio_unitario DECIMAL(10,2) NOT NULL CHECK (precio_unitario >= 0),
    subtotal AS (CONVERT(DECIMAL(12,2), cantidad * precio_unitario)) PERSISTED,
    CONSTRAINT FK_detalles_factura
        FOREIGN KEY (id_factura) REFERENCES factura(id_factura) ON DELETE CASCADE,
    CONSTRAINT FK_detalle_producto
        FOREIGN KEY (id_talle) REFERENCES talle_producto(id_talle)
);
CREATE INDEX IX_detalle_factura_talle ON detalle_factura(id_talle);


select * from roles
select * from usuarios
select * from permisos
select * from clientes
select * from productos
select * from talle_producto
select * from detalle_factura
select * from factura
