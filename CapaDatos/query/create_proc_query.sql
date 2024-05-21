SELECT * FROM Usuario


/*-------------registrar de usuario-------------*/

ALTER PROC SP_REGISTRARUSUARIO
	(
		@dni varchar(50),
		@nombre_completo varchar(100),
		@correo varchar(100),
		@contraseña varchar(100),
		@rol_id int,
		@id_usuario_resultado int output,
		@mensaje varchar(500) output
	)
	AS
	BEGIN
		SET @id_usuario_resultado = 0
		SET @mensaje = ''

		IF not exists(SELECT * FROM Usuario WHERE dni = @dni)
		BEGIN
			INSERT INTO usuario(dni, nombre_completo, correo, contraseña, rol_id)
			VALUES (@dni, @nombre_completo, @correo, @contraseña, @rol_id)

			SET @id_usuario_resultado = SCOPE_IDENTITY()
	END
	ELSE
			SET @mensaje = 'El DNI debe ser único para cada usuario'
END
GO


/*-------------editar de usuario-------------*/

CREATE PROC SP_EDITARUSUARIO
	(
		@id_usuario int,
		@dni varchar(50),
		@nombre_completo varchar(100),
		@correo varchar(100),
		@contraseña varchar(100),
		@rol_id int,
		@respuesta bit output,
		@mensaje varchar(500) output
	)
	AS
	BEGIN
		SET @respuesta = 0
		SET @mensaje = ''

		IF not exists(SELECT * FROM Usuario WHERE dni = @dni and id_usuario != @id_usuario)
		BEGIN
			UPDATE Usuario SET
				dni = @dni,
				nombre_completo = @nombre_completo,
				correo = @correo,
				contraseña = @contraseña,
				rol_id = @rol_id
			WHERE id_usuario = @id_usuario

			SET @respuesta = 1

	END
	ELSE
			SET @mensaje = 'El DNI debe ser único para cada usuario'
END
GO


/*-------------editar de usuario-------------*/

CREATE PROC SP_ELIMINARUSUARIO
	(
		@id_usuario int,
		@respuesta bit output,
		@mensaje varchar(500) output
	)
	AS
	BEGIN
		SET @respuesta = 0
		SET @mensaje = ''
		DECLARE @pasoreglas bit = 1

		IF exists (
			SELECT * FROM Preventa P
			INNER JOIN Usuario U ON U.id_usuario = P.usuario_id
			WHERE U.id_usuario = @id_usuario
			)
			BEGIN
				SET @pasoreglas = 0
				SET @respuesta = 0
				SET @mensaje = @mensaje + 'No se puede eliminar el usuario ya que está relacionado a una preventa\n'
			END

		IF (@pasoreglas = 1)
			BEGIN
				DELETE FROM Usuario WHERE id_usuario = @id_usuario
				SET @respuesta = 1 
			END
	END


/*-------------ejecución de pruebas-------------*/


/*
DECLARE @respuesta_edicion bit
DECLARE @mensaje_generado varchar(500)

EXEC SP_EDITARUSUARIO 6, '123', 'pruebas 2', 'testgmail.com', '456', 1, @respuesta_edicion OUTPUT, @mensaje_generado OUTPUT

SELECT @respuesta_edicion
SELECT @mensaje_generado

SELECT * FROM Usuario
*/
