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

INSERT INTO Articulo (SKU, rubro, costo, marca, baja, descripcion)
VALUES
	(207443, 'Heladeras', 739999, 'Drean', 0, 'Heladera Drean HDR320F00N Ciclica 314L Negra'),
	(205196, 'Heladeras', 1355999, 'Samsung', 0, 'Heladera Samsung 382L Rt38K5932Sl Silver C/D N/F'),
	(205794, 'Depiladoras', 63399, 'Phillips', 0, 'Depiladora Philips Bre225/00 Satinelle Essential'),
	(701657, 'Smartwatchs', 493999, 'Samsung', 0, 'Smartwatch Samsung Galaxy Watch6 40mm Black R930'),
	(505416, 'Smart TV', 679999, 'Samsung', 0, 'Smart TV SAMSUNG 50" CU7000 4K HDR BT HDMI USB'),
	(206599, 'Batidoras', 179999, 'Peabody', 0, 'Batidora Peabody Planet. Pe-Bm101 1000W 4L Cl/Vs'),
	(208119, 'Cafeteras', 789999, 'Smartlife', 0, 'Cafetera Smartlife Expresso Sl-Ecg5020 C/Molinillo'),
	(505498, 'Auriculares', 97999, 'JBL', 0, 'Auricular Jbl Tune 520bt On Ear Cl/Vs');

INSERT INTO ItemPrevArt (prev_id, prevsuc_id, art_id)
VALUES 
	(6, 1, 2),
	(6, 1, 5),
	(7, 2, 1),
	(8, 3, 6),
	(8, 3, 3),
	(8, 3, 7);


UPDATE Cliente
SET dni = 43512205, fecha_nac = '2001-06-19 11:30:00', domicilio = 'Río Negro 332'
WHERE id_cliente = 1;


UPDATE Cliente
SET dni = 41740235, fecha_nac = '1999-03-12 11:30:00', domicilio = 'Bernardo de Irigoyen 379'
WHERE id_cliente = 2;

UPDATE Cliente
SET dni = 43248206, fecha_nac = '2001-02-12 11:30:00', domicilio = 'Alsina 175'
WHERE id_cliente = 3;

UPDATE Cliente
SET telefono = '+5492364412534'
WHERE id_cliente = 4;

SELECT * FROM Cliente