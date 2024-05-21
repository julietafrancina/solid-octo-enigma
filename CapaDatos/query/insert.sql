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
GO

SELECT * FROM Preventa;
SELECT * FROM Sucursal;
SELECT * FROM Usuario;
SELECT * FROM Cliente;


/* ------ejecutado------ */

INSERT INTO Sucursal (descripcion, telefono)
VALUES
	('Junín', '+542364207067'),
	('Lincoln', '+5492355432532'),
	('Pergamino','+5492477441825'),
	('Los Toldos', '0810 222 6253');


INSERT INTO Cliente (nombre_completo, dni, correo, telefono, domicilio, fecha_nac)
VALUES
	('Facundo Topa', 45837263, 'facundo.topa@naldo.com.ar', '+549236477489', 'Cucha Cucha 45', '2001-06-18'),
	('Facundo Figueroa', 44693869, 'facundo.figueroa@naldo.com.ar', '+5492364655722', 'Pichincha 60', '2000-03-12'),
	('Santiago Fulderi', 43724957, 'santiago.fulderi@naldo.com.ar', '+5492364385720', 'Pichincha 60', '2001-08-27');


INSERT INTO Preventa (fecha, monto, baja, nro_operacion, sucursal_id, usuario_id, cliente_id)
VALUES
	(CONVERT(DATETIME, '2024-05-21 11:30:00', 120), 87999, 0, 0001, 1, 2, 1),
	(CONVERT(DATETIME, '2024-05-21 14:30:00', 120), 219999, 0, 0002, 2, 2, 2),
	(CONVERT(DATETIME, '2024-05-21 15:30:00', 120), 49000, 1, 0003, 3, 5, 3);

