
USE TiendaDB;
GO

--PROCEDIMIENTO: Registrar Usuario
create PROC SP_REGISTRARUSUARIO(
    @dni INT,
    @apellido VARCHAR(80),
    @nombre VARCHAR(80),
    @usuario VARCHAR(50),
    @hash_password VARCHAR(255),
    @email VARCHAR(120),
    @id_rol INT,
    @activo BIT,
    @sexo BIT,
    @fecha_nacimiento DATE,
    @IdUsuarioResultado int output,
    @Mensaje VARCHAR(500) output

)
as 
begin
    set @IdUsuarioResultado = 0
    set @Mensaje = ''

    -- Verifico DNI duplicado
    IF EXISTS(SELECT 1 FROM usuarios WHERE dni = @dni)
    BEGIN
        SET @Mensaje = 'Ya existe un usuario con ese DNI';
        RETURN;
    END

    -- Verifico NOMBRE DE USUARIO duplicado
    IF EXISTS(SELECT 1 FROM usuarios WHERE usuario = @usuario)
    BEGIN
        SET @Mensaje = 'Ya existe un usuario con ese nombre de usuario';
        RETURN;
    END

    -- Verifico EMAIL duplicado
    IF EXISTS(SELECT 1 FROM usuarios WHERE email = @email)
    BEGIN
        SET @Mensaje = 'Ya existe un usuario con ese correo electr�nico';
        RETURN;
    END

    if not exists(select * from usuarios where dni = @dni)
    begin
        insert into usuarios(dni, apellido, nombre, usuario, email, hash_password, id_rol, activo, sexo, fecha_nacimiento) values
(@dni, @apellido, @nombre, @usuario, @email, @hash_password, @id_rol, @activo, @sexo, @fecha_nacimiento)

        set @IdUsuarioResultado = SCOPE_IDENTITY()
        
    end
    else
        set @Mensaje = 'No se puede repetir el documento para m�s de un Usuario'
end
GO

--PROCEDIMIENTO: Editar Usuario
create PROC SP_EDITARUSUARIO(
    @id_usuario INT,
    @dni INT,
    @apellido VARCHAR(80),
    @nombre VARCHAR(80),
    @usuario VARCHAR(50),
    @hash_password VARCHAR(255),
    @email VARCHAR(120),
    @id_rol INT,
    @activo BIT,
    @sexo BIT,
    @fecha_nacimiento DATE,
    @Respuesta bit output,
    @Mensaje VARCHAR(500) output
)
as 
begin
    set @Respuesta = 0
    set @Mensaje = ''

    -- Verifico DNI duplicado
    IF EXISTS (SELECT 1 FROM usuarios WHERE dni = @dni AND id_usuario != @id_usuario)
    BEGIN
        SET @Mensaje = 'El documento ya est� registrado en otro usuario'
        RETURN
    END

    -- Verifico USUARIO duplicado
    IF EXISTS (SELECT 1 FROM usuarios WHERE usuario = @usuario AND id_usuario != @id_usuario)
    BEGIN
        SET @Mensaje = 'El nombre de usuario ya existe'
        RETURN
    END

    -- Verifico EMAIL duplicado
    IF EXISTS (SELECT 1 FROM usuarios WHERE email = @email AND id_usuario != @id_usuario)
    BEGIN
        SET @Mensaje = 'El correo electr�nico ya est� registrado en otro usuario'
        RETURN
    END

    -- Si no hay duplicados, actualizo
    UPDATE usuarios SET
        dni = @dni, 
        apellido = @apellido, 
        nombre = @nombre, 
        usuario = @usuario, 
        email = @email, 
        hash_password = @hash_password, 
        id_rol = @id_rol, 
        activo = @activo,
        sexo = @sexo, 
        fecha_nacimiento = @fecha_nacimiento
    WHERE id_usuario = @id_usuario 

    SET @Respuesta = 1
end
GO

--PROCEDIMIENTO: Alta y baja de Usuario
CREATE PROC SP_AltaBajaUsuario(
    @id_usuario INT,
    @Accion VARCHAR(10), -- 'BAJA' o 'ALTA'
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0;
    SET @Mensaje = '';

    -- Verifico que exista
    IF NOT EXISTS (SELECT 1 FROM usuarios WHERE id_usuario = @id_usuario)
    BEGIN
        SET @Mensaje = 'El usuario no existe';
        RETURN;
    END

    DECLARE @estado_actual BIT;
    SELECT @estado_actual = activo FROM usuarios WHERE id_usuario = @id_usuario;

    -- Acción: BAJA
    IF @Accion = 'BAJA'
    BEGIN
        IF @estado_actual = 0
        BEGIN
            SET @Mensaje = 'El usuario ya está dado de baja';
            RETURN;
        END

        UPDATE usuarios SET activo = 0 WHERE id_usuario = @id_usuario;
        SET @Respuesta = 1;
        SET @Mensaje = 'Usuario dado de baja correctamente';
        RETURN;
    END

    -- Acción: ALTA
    IF @Accion = 'ALTA'
    BEGIN
        IF @estado_actual = 1
        BEGIN
            SET @Mensaje = 'El usuario ya está activo';
            RETURN;
        END

        UPDATE usuarios SET activo = 1 WHERE id_usuario = @id_usuario;
        SET @Respuesta = 1;
        SET @Mensaje = 'Usuario habilitado correctamente';
        RETURN;
    END
END
GO

--PROCEDIMIENTO: Registrar Producto
CREATE PROC SP_REGISTRARPRODUCTO(
    @codigo VARCHAR(20),
    @nombre VARCHAR(120),
    @descripcion VARCHAR(MAX),
    @precio DECIMAL(10,2),
    @imagen_url VARCHAR(255) = NULL,
    @activo BIT,
    @Resultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET @Resultado = 0;
    SET @Mensaje = '';

    -- Verificar que el código no esté duplicado
    IF EXISTS(SELECT 1 FROM productos WHERE codigo = @codigo)
    BEGIN
        SET @Mensaje = 'Ya existe un producto con ese código.';
        RETURN;
    END

    -- 🔹 Verificar que el nombre no esté duplicado
    IF EXISTS(SELECT 1 FROM productos WHERE nombre = @nombre)
    BEGIN
        SET @Mensaje = 'Ya existe un producto con ese nombre.';
        RETURN;
    END

    BEGIN TRY
        INSERT INTO productos (codigo, nombre, descripcion, precio, imagen_url, activo)
        VALUES (@codigo, @nombre, @descripcion, @precio, @imagen_url, @activo);

        SET @Resultado = SCOPE_IDENTITY();
        SET @Mensaje = 'Producto registrado correctamente.';
    END TRY
    BEGIN CATCH
        SET @Resultado = 0;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH
END
GO

--PROCEDIMIENTO: Editar Producto
CREATE PROC SP_EDITARPRODUCTO(
    @id_producto INT,
    @codigo VARCHAR(20),
    @nombre VARCHAR(120),
    @descripcion VARCHAR(MAX),
    @precio DECIMAL(10,2),
    @imagen_url VARCHAR(255) = NULL,  -- puede venir vacío
    @activo BIT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET @Respuesta = 0;
    SET @Mensaje = '';

    -- Verifica que el producto exista
    IF NOT EXISTS (SELECT 1 FROM productos WHERE id_producto = @id_producto)
    BEGIN
        SET @Mensaje = 'El producto no existe.';
        RETURN;
    END

    -- Verifica código duplicado
    IF EXISTS (SELECT 1 FROM productos WHERE codigo = @codigo AND id_producto != @id_producto)
    BEGIN
        SET @Mensaje = 'Ya existe otro producto con ese código.';
        RETURN;
    END

    -- Verifica nombre duplicado
    IF EXISTS (SELECT 1 FROM productos WHERE nombre = @nombre AND id_producto != @id_producto)
    BEGIN
        SET @Mensaje = 'Ya existe otro producto con ese nombre.';
        RETURN;
    END

    BEGIN TRY
        -- Si no se envía una nueva imagen, conserva la anterior
        UPDATE productos
        SET codigo = @codigo,
            nombre = @nombre,
            descripcion = @descripcion,
            precio = @precio,
            imagen_url = ISNULL(@imagen_url, imagen_url),  -- mantiene la imagen actual si @imagen_url es NULL
            activo = @activo
        WHERE id_producto = @id_producto;

        SET @Respuesta = 1;
        SET @Mensaje = 'Producto actualizado correctamente.';
    END TRY
    BEGIN CATCH
        SET @Respuesta = 0;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH
END
GO


--PROCEDIMIENTO: Alta y Baja de Producto
CREATE PROC SP_AltaBajaProducto(
    @id_producto INT,
    @Accion VARCHAR(10), -- 'BAJA' o 'ALTA'
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET @Respuesta = 0;
    SET @Mensaje = '';

    -- Verifica que el producto exista
    IF NOT EXISTS (SELECT 1 FROM productos WHERE id_producto = @id_producto)
    BEGIN
        SET @Mensaje = 'El producto no existe.';
        RETURN;
    END

    DECLARE @estado_actual BIT;
    SELECT @estado_actual = activo FROM productos WHERE id_producto = @id_producto;

    -- Acción: BAJA
    IF @Accion = 'BAJA'
    BEGIN
        IF @estado_actual = 0
        BEGIN
            SET @Mensaje = 'El producto ya está dado de baja.';
            RETURN;
        END

        UPDATE productos SET activo = 0 WHERE id_producto = @id_producto;
        SET @Respuesta = 1;
        SET @Mensaje = 'Producto dado de baja correctamente.';
        RETURN;
    END

    -- Acción: ALTA
    IF @Accion = 'ALTA'
    BEGIN
        IF @estado_actual = 1
        BEGIN
            SET @Mensaje = 'El producto ya está activo.';
            RETURN;
        END

        UPDATE productos SET activo = 1 WHERE id_producto = @id_producto;
        SET @Respuesta = 1;
        SET @Mensaje = 'Producto habilitado correctamente.';
        RETURN;
    END
END
GO

-- PROCEDIMIENTO: Registrar Cliente
CREATE PROC SP_REGISTRARCLIENTE(
    @dni INT,
    @nombre VARCHAR(120),
    @apellido VARCHAR(120),
    @email VARCHAR(120),
    @direccion VARCHAR(120),
    @sexo BIT,
    @telefono VARCHAR(40),
    @activo BIT,
    @IdClienteResultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @IdClienteResultado = 0;
    SET @Mensaje = '';

    -- Verifico DNI duplicado
    IF EXISTS(SELECT 1 FROM clientes WHERE dni = @dni)
    BEGIN
        SET @Mensaje = 'Ya existe un cliente con ese DNI';
        RETURN;
    END

    -- Verifico EMAIL duplicado
    IF EXISTS(SELECT 1 FROM clientes WHERE email = @email)
    BEGIN
        SET @Mensaje = 'Ya existe un cliente con ese correo electrónico';
        RETURN;
    END

    BEGIN TRY
        INSERT INTO clientes (dni, nombre, apellido, email, direccion, sexo, telefono, activo)
        VALUES (@dni, @nombre, @apellido, @email, @direccion, @sexo, @telefono, @activo);

        SET @IdClienteResultado = SCOPE_IDENTITY();
        SET @Mensaje = 'Cliente registrado correctamente.';
    END TRY
    BEGIN CATCH
        SET @IdClienteResultado = 0;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH
END
GO


-- PROCEDIMIENTO: Editar Cliente
CREATE PROC SP_EDITARCLIENTE(
    @id_cliente INT,
    @dni INT,
    @nombre VARCHAR(120),
    @apellido VARCHAR(120),
    @email VARCHAR(120),
    @direccion VARCHAR(120),
    @sexo BIT,
    @telefono VARCHAR(40),
    @activo BIT,
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @Respuesta = 0;
    SET @Mensaje = '';

    -- Verifica que el cliente exista
    IF NOT EXISTS (SELECT 1 FROM clientes WHERE id_cliente = @id_cliente)
    BEGIN
        SET @Mensaje = 'El cliente no existe.';
        RETURN;
    END

    -- Verifica DNI duplicado
    IF EXISTS (SELECT 1 FROM clientes WHERE dni = @dni AND id_cliente != @id_cliente)
    BEGIN
        SET @Mensaje = 'Ya existe otro cliente con ese DNI.';
        RETURN;
    END

    -- Verifica EMAIL duplicado
    IF EXISTS (SELECT 1 FROM clientes WHERE email = @email AND id_cliente != @id_cliente)
    BEGIN
        SET @Mensaje = 'Ya existe otro cliente con ese correo electrónico.';
        RETURN;
    END

    BEGIN TRY
        UPDATE clientes
        SET dni = @dni,
            nombre = @nombre,
            apellido = @apellido,
            email = @email,
            direccion = @direccion,
            sexo = @sexo,
            telefono = @telefono,
            activo = @activo
        WHERE id_cliente = @id_cliente;

        SET @Respuesta = 1;
        SET @Mensaje = 'Cliente actualizado correctamente.';
    END TRY
    BEGIN CATCH
        SET @Respuesta = 0;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH
END
GO


-- PROCEDIMIENTO: Alta Baja Cliente
CREATE PROC SP_AltaBajaCliente(
    @id_cliente INT,
    @Accion VARCHAR(10), -- 'BAJA' o 'ALTA'
    @Respuesta BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET @Respuesta = 0;
    SET @Mensaje = '';

    -- Verifica que el cliente exista
    IF NOT EXISTS (SELECT 1 FROM clientes WHERE id_cliente = @id_cliente)
    BEGIN
        SET @Mensaje = 'El cliente no existe.';
        RETURN;
    END

    DECLARE @estado_actual BIT;
    SELECT @estado_actual = activo FROM clientes WHERE id_cliente = @id_cliente;

    -- Acción: BAJA
    IF @Accion = 'BAJA'
    BEGIN
        IF @estado_actual = 0
        BEGIN
            SET @Mensaje = 'El cliente ya está dado de baja.';
            RETURN;
        END

        UPDATE clientes SET activo = 0 WHERE id_cliente = @id_cliente;
        SET @Respuesta = 1;
        SET @Mensaje = 'Cliente dado de baja correctamente.';
        RETURN;
    END

    -- Acción: ALTA
    IF @Accion = 'ALTA'
    BEGIN
        IF @estado_actual = 1
        BEGIN
            SET @Mensaje = 'El cliente ya está activo.';
            RETURN;
        END

        UPDATE clientes SET activo = 1 WHERE id_cliente = @id_cliente;
        SET @Respuesta = 1;
        SET @Mensaje = 'Cliente habilitado correctamente.';
        RETURN;
    END
END
GO



CREATE TYPE dbo.Edetalles_factura AS TABLE
(
    id_talle        INT           NOT NULL,
    cantidad        INT           NOT NULL CHECK (cantidad > 0),
    precio_unitario DECIMAL(10,2) NOT NULL CHECK (precio_unitario >= 0)
);
GO


CREATE PROCEDURE dbo.SP_REGISTRARVENTA
(
    @punto_venta        SMALLINT,--
    @id_cliente          INT,
    @id_usuario          INT,
    @fecha               DATETIME2 = NULL,
    @detalles_factura dbo.Edetalles_factura READONLY,
    @IdFacturaResultado  INT           OUTPUT,
    @NroFactura         VARCHAR(15)  OUTPUT,   -- "A 0001-00000001"
    @Resultado           BIT           OUTPUT,
    @Mensaje             VARCHAR(500)  OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    SET @IdFacturaResultado = 0;
    SET @NroFactura = NULL; --
    SET @Resultado = 0;
    SET @Mensaje = '';

    -- Validaciones básicas
    IF NOT EXISTS (SELECT 1 FROM clientes WHERE id_cliente = @id_cliente AND activo = 1)
    BEGIN SET @Mensaje = 'Cliente inexistente o inactivo.'; RETURN; END

    IF NOT EXISTS (SELECT 1 FROM usuarios WHERE id_usuario = @id_usuario AND activo = 1)
    BEGIN SET @Mensaje = 'Usuario inexistente o inactivo.'; RETURN; END

    IF NOT EXISTS (SELECT 1 FROM @detalles_factura)
    BEGIN SET @Mensaje = 'La venta no tiene ítems.'; RETURN; END

    DECLARE @importe_total DECIMAL(12,2) =
        (SELECT SUM(CONVERT(DECIMAL(12,2), d.cantidad) * d.precio_unitario) FROM @detalles_factura d);

    IF @fecha IS NULL SET @fecha = SYSDATETIME();

    BEGIN TRAN;

    -- Bloqueo y validación de stock por talle
    IF EXISTS (
        SELECT 1
        FROM @detalles_factura d
        JOIN talle_producto t WITH (UPDLOCK, ROWLOCK)
             ON t.id_talle = d.id_talle
        WHERE d.cantidad > t.stock
    )
    BEGIN
        ROLLBACK TRAN;
        SET @Mensaje = 'Stock insuficiente para uno o más talles.';
        RETURN;
    END

    DECLARE @nro_cbte INT;
    SELECT @nro_cbte = ISNULL(MAX(f.nro_cbte), 0) + 1
    FROM factura f WITH (UPDLOCK, HOLDLOCK)
    WHERE f.punto_venta = @punto_venta;

    -- Cabecera
    INSERT INTO factura(punto_venta, nro_cbte, id_cliente, id_usuario, importe_total, fecha)
    VALUES(@punto_venta,  @nro_cbte, @id_cliente, @id_usuario, @importe_total, @fecha);

    SET @IdFacturaResultado = SCOPE_IDENTITY();

    -- Tomar el nro_factura
    SELECT @NroFactura = nro_factura --
    FROM factura --
    WHERE id_factura = @IdFacturaResultado; --

    -- Detalle
    INSERT INTO detalle_factura (id_factura, id_talle, cantidad, precio_unitario)
    SELECT @IdFacturaResultado, id_talle, cantidad, precio_unitario
    FROM @detalles_factura;

    -- Descuento de stock
    UPDATE t
        SET t.stock = t.stock - d.cantidad
    FROM talle_producto t
    JOIN @detalles_factura d ON d.id_talle = t.id_talle;

    COMMIT TRAN;

    SET @Resultado = 1;
    SET @Mensaje = 'OK';
END
GO

CREATE PROC dbo.SP_OBTENER_VENTA
  @id_factura INT
AS
BEGIN
  SET NOCOUNT ON;

  -- CABECERA
  SELECT
      f.id_factura,
      f.nro_factura,
      f.fecha,
      f.importe_total,
      c.dni,
      c.apellido + ', ' + c.nombre     AS cliente,
      c.email,
      c.telefono,
      u.apellido + ', ' + u.nombre     AS vendedor
  FROM factura f
  JOIN clientes c ON c.id_cliente = f.id_cliente
  JOIN usuarios u ON u.id_usuario = f.id_usuario
  WHERE f.id_factura = @id_factura;

  -- DETALLE
  SELECT
      p.id_producto,
      tp.id_talle,
      p.nombre         AS producto,
      tp.talla         AS talla,
      d.precio_unitario,
      d.cantidad,
      CONVERT(decimal(12,2), d.precio_unitario * d.cantidad) AS subtotal
  FROM detalle_factura d
  JOIN talle_producto tp ON tp.id_talle = d.id_talle
  JOIN productos p       ON p.id_producto = tp.id_producto
  WHERE d.id_factura = @id_factura;
END
GO


-------------------------------------------------- DEVOLUCION


CREATE PROC dbo.SP_REGISTRARDEVOLUCION_TOTAL
(
    @punto_venta        SMALLINT,
    @id_factura_origen  INT,
    @id_usuario         INT,
    @IdFacturaNC        INT          OUTPUT,
    @NroFacturaNC       VARCHAR(16)  OUTPUT,
    @Resultado          BIT          OUTPUT,
    @Mensaje            VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    SET @IdFacturaNC = 0;
    SET @NroFacturaNC = NULL;
    SET @Resultado = 0;
    SET @Mensaje = '';

    -- Existen factura y usuario
    IF NOT EXISTS (SELECT 1 FROM dbo.factura WHERE id_factura = @id_factura_origen)
    BEGIN SET @Mensaje = 'La factura de origen no existe.'; RETURN; END

    IF NOT EXISTS (SELECT 1 FROM dbo.usuarios WHERE id_usuario = @id_usuario AND activo = 1)
    BEGIN SET @Mensaje = 'Usuario inexistente o inactivo.'; RETURN; END

    -- Datos del origen
    DECLARE @id_cliente INT,
            @fecha_origen DATETIME2,
            @id_origen_de_origen INT,
            @importe_origen DECIMAL(12,2);

    SELECT
        @id_cliente          = f.id_cliente,
        @fecha_origen        = f.fecha,
        @id_origen_de_origen = f.id_factura_origen,
        @importe_origen      = f.importe_total
    FROM dbo.factura f
    WHERE f.id_factura = @id_factura_origen;

    -- No devolver una NC
    IF (@id_origen_de_origen IS NOT NULL OR @importe_origen < 0)
    BEGIN SET @Mensaje = 'No se puede devolver una Nota de Crédito.'; RETURN; END

    -- Ventana de 14 días
    IF DATEDIFF(DAY, @fecha_origen, SYSDATETIME()) > 14
    BEGIN SET @Mensaje = 'Plazo vencido: solo se aceptan devoluciones hasta 14 días desde la compra.'; RETURN; END

    -- No permitir segunda devolución de la misma factura (total es única)
    IF EXISTS (SELECT 1 FROM dbo.factura WHERE id_factura_origen = @id_factura_origen)
    BEGIN SET @Mensaje = 'La factura ya tiene una devolución registrada.'; RETURN; END

    -- Importe total a devolver = suma de la factura origen
    DECLARE @importe_devolucion DECIMAL(12,2) =
    (
        SELECT SUM(CONVERT(DECIMAL(12,2), od.cantidad) * od.precio_unitario)
        FROM dbo.detalle_factura od
        WHERE od.id_factura = @id_factura_origen
    );

    IF @importe_devolucion IS NULL OR @importe_devolucion <= 0
    BEGIN SET @Mensaje = 'La factura de origen no posee detalles válidos.'; RETURN; END

    BEGIN TRAN;

        -- Numeración por punto de venta
        DECLARE @nro_cbte INT;
        SELECT @nro_cbte = ISNULL(MAX(f.nro_cbte), 0) + 1
        FROM dbo.factura f WITH (UPDLOCK, HOLDLOCK)
        WHERE f.punto_venta = @punto_venta;

        -- Cabecera NC (total negativo) + referencia
        INSERT INTO dbo.factura
            (punto_venta, nro_cbte, id_cliente, id_usuario, importe_total, fecha, id_factura_origen)
        VALUES
            (@punto_venta, @nro_cbte, @id_cliente, @id_usuario, -@importe_devolucion, SYSDATETIME(), @id_factura_origen);

        SET @IdFacturaNC = SCOPE_IDENTITY();

        SELECT @NroFacturaNC = nro_factura
        FROM dbo.factura
        WHERE id_factura = @IdFacturaNC;

        -- Detalle NC = copia íntegra del detalle de origen (cantidades y precios positivos)
        INSERT INTO dbo.detalle_factura (id_factura, id_talle, cantidad, precio_unitario)
        SELECT @IdFacturaNC, od.id_talle, od.cantidad, od.precio_unitario
        FROM dbo.detalle_factura od
        WHERE od.id_factura = @id_factura_origen;

        -- Reponer stock por todos los talles
        UPDATE t
            SET t.stock = t.stock + od.cantidad
        FROM dbo.talle_producto t
        JOIN dbo.detalle_factura od ON od.id_talle = t.id_talle
        WHERE od.id_factura = @IdFacturaNC;

    COMMIT TRAN;

    SET @Resultado = 1;
    SET @Mensaje = 'OK';
END
GO

--------------------------------------REPORTES


--- Reporte "Recaudacion"
CREATE PROCEDURE SP_REPORTE_RECAUDACION
    @desde      DATE,
    @hasta      DATE,
    @id_usuario INT = 0,
    @incluir_nc BIT = 1
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        f.fecha,
        f.nro_factura,
        u.apellido + ', ' + u.nombre AS vendedor,
        c.apellido + ', ' + c.nombre AS cliente,
        f.importe_total
    FROM dbo.factura f
    INNER JOIN dbo.usuarios u ON u.id_usuario = f.id_usuario
    INNER JOIN dbo.clientes c ON c.id_cliente = f.id_cliente
    WHERE f.fecha >= @desde
      AND f.fecha < DATEADD(DAY, 1, @hasta)
      AND (@id_usuario = 0 OR f.id_usuario = @id_usuario)
      AND (
            @incluir_nc = 1
            OR ( @incluir_nc = 0 AND f.id_factura_origen IS NULL )
          )
    ORDER BY f.fecha, f.id_factura;
END
GO



----------Reporte "Productos Mas Vendidos"
CREATE PROCEDURE SP_REPORTE_PRODUCTOS_MAS_VENDIDOS
    @desde      DATE,
    @hasta      DATE,
    @id_usuario INT = 0,
    @incluir_nc BIT = 0
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH facturas_filtradas AS (
        SELECT
            f.id_factura,
            f.fecha,
            f.id_usuario,
            f.id_factura_origen,
            CASE 
                WHEN f.id_factura_origen IS NULL THEN 1
                ELSE -1
            END AS signo
        FROM dbo.factura f
        WHERE f.fecha >= @desde
          AND f.fecha < DATEADD(DAY, 1, @hasta)
          AND (@id_usuario = 0 OR f.id_usuario = @id_usuario)
          AND (@incluir_nc = 1 OR f.id_factura_origen IS NULL)
    )
    SELECT
        p.codigo,
        p.nombre,
        SUM(df.cantidad * ff.signo) AS total_cantidad,
        SUM(df.precio_unitario * df.cantidad * ff.signo) AS total_importe
    FROM dbo.detalle_factura df
    INNER JOIN facturas_filtradas ff ON ff.id_factura = df.id_factura
    INNER JOIN dbo.talle_producto tp ON tp.id_talle = df.id_talle
    INNER JOIN dbo.productos p       ON p.id_producto = tp.id_producto
    GROUP BY p.codigo, p.nombre
    HAVING SUM(df.cantidad * ff.signo) > 0
    ORDER BY total_cantidad DESC, p.nombre;
END
GO



----Reporte "Total Ventas"
CREATE PROCEDURE SP_REPORTE_TOTAL_VENTAS
    @desde      DATE,
    @hasta      DATE,
    @id_usuario INT = 0,   -- 0 = todos
    @incluir_nc BIT = 0    -- por defecto NO cuento NC/devoluciones
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH facturas_filtradas AS (
        SELECT
            f.id_factura,
            f.fecha,
            f.id_usuario,
            f.id_factura_origen,
            f.importe_total
        FROM dbo.factura f
        WHERE f.fecha >= @desde
          AND f.fecha < DATEADD(DAY, 1, @hasta)
          AND (@id_usuario = 0 OR f.id_usuario = @id_usuario)
    )
    SELECT
        u.apellido + ', ' + u.nombre AS vendedor,
        COUNT(*)                     AS cant_ventas,
        SUM(ff.importe_total)        AS total_facturado
    FROM facturas_filtradas ff
    INNER JOIN dbo.usuarios u ON u.id_usuario = ff.id_usuario
    WHERE (
            @incluir_nc = 1
            OR (@incluir_nc = 0 AND ff.id_factura_origen IS NULL)
          )
    GROUP BY u.apellido, u.nombre
    ORDER BY vendedor;
END
GO
