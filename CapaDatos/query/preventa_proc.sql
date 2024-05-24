CREATE PROCEDURE SP_registrarPreventa
	(
		@fecha DATE,
		@monto DECIMAL(10, 2),
		@baja BIT,
		@sucursal_id INT,
		@usuario_id INT,
		@cliente_id INT,
		@id_preventa_resultada INT OUTPUT,
		@mensaje VARCHAR(500) OUTPUT
	)
	AS
	BEGIN
		SET @baja = 0;
		SET @id_preventa_resultada = 0;
		SET @mensaje = '';

		INSERT INTO preventa(fecha, monto, baja, sucursal_id,usuario_id, cliente_id)
		VALUES (@fecha, @monto, @baja, @sucursal_id,@usuario_id, @cliente_id);

		SET @id_preventa_resultada = SCOPE_IDENTITY();
	END