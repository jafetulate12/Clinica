	CREATE DATABASE PROYECTO_POO --CREACION DE LA TABLA
    GO
	

   -- USE PROYECTO_POO -- USO DE LA TABLE
   USE PROYECTO_POO
	GO




	-- CREACION DE LAS TABLAS DE LA BASE DE DATOS PROYECTO POO



	-- TABLA DE PAGOS
 CREATE TABLE FUNCIONARIOS (
	  ID_FUNCIONARIO INT IDENTITY PRIMARY KEY,
	  PUESTO_FUNCIONARIO VARCHAR(50),
	  NOMBRE_COMPLETO_FUNCIONARIO VARCHAR(100),
	  TELEFONO_FUNCIONARIO INT,
	  CORREO_FUNCIONARIO VARCHAR(30),
	)


	-- TABLA DE PAGOS
 CREATE TABLE PAGOS (
		ID_FACTURA INT IDENTITY PRIMARY KEY,
		ID_FUNCIONARIO INT,
		MONTO_PAGO DECIMAL(11,2),
		FECHA_PAGO DATE,
		TIPO_PAGO VARCHAR(25),
		ID_PACIENTE INT
	 
	)

	-- TABLA MEDICAMENTOS
 CREATE TABLE MEDICAMENTOS (
	  ID_MEDICAMENTO INT IDENTITY PRIMARY KEY,
	  NOMBRE_MEDICAMENTO VARCHAR(50),
	  DESCRIPCION VARCHAR(100),
	  INDICACIONES_USO VARCHAR(100)
)

	-- TABLA DE PACIENTES
 CREATE TABLE PACIENTES (
      ID_PACIENTE INT IDENTITY PRIMARY KEY,
	  CEDULA_PACIENTE VARCHAR(25) UNIQUE,
	  NOMBRE_COMPLETO_PACIENTE VARCHAR (100),
	  TELEFONO_PACIENTE INT,
	  CORREO_PACIENTE VARCHAR(50),
	  DIRECCION_PACIENTE VARCHAR(100)
)


 CREATE TABLE CITAS_A_PROGRAMAR (
	  ID_CITA_PROGRAMADA INT IDENTITY PRIMARY KEY,
	  ID_FUNCIONARIO INT ,
	  ID_CITAS  INT,
	  ID_PACIENTE INT 
)

	-- TABLA DE BITACORAS
 CREATE TABLE BITACORAS (
	  ID_BITACORA INT IDENTITY PRIMARY KEY,
	  FECHA DATE,
	  HORA TIME,
	  MOVIMIENTO_REALIZADO VARCHAR(200),
) 

	-- TABLA AGENDA ESPECIALITAS
 CREATE TABLE AGENDA_ESPECIALISTAS (
	  ID_CITAS INT IDENTITY PRIMARY KEY,
	  ID_ESPECIALISTA INT,
	  ID_ESPECIALIDAD INT,
	  HORA_INICIO TIME,
	  HORA_FINAL TIME,
	  FECHA_CITA DATE
)

	-- TABLA ESPECIALIDADES
 CREATE TABLE ESPECIALIDADES (
	  ID_ESPECIALIDAD INT IDENTITY PRIMARY KEY,
	  NOMBRE_ESPECIALIDAD VARCHAR(50),
	  DESCRIPCION_ESPECIALIDAD VARCHAR(50)
	)

	-- TABLA ESPECIALISTAS
 CREATE TABLE ESPECIALISTAS (
	  ID_ESPECIALISTA INT IDENTITY PRIMARY KEY,
      NOMBRE_COMPLETO_ESPECIALISTA VARCHAR(100),
	  TELEFONO_ESPECIALISTA INT,
	  CORREO_ESPECIALISTA VARCHAR(30),
	  DIRECCION_ESPECIALISTA VARCHAR(100)
)

	-- TABLA HISTORIAL CLINICO
 CREATE TABLE HISTORIAL_CLINICOS (
	  ID_HISTORIAL_CLINICO INT IDENTITY PRIMARY KEY,
	  ID_PACIENTE INT,
	  ID_MEDICAMENTO INT,
	  ID_DIAGNOSTICO INT
	  
) 

	-- TABLA DIAGNOSTICOS
 CREATE TABLE DIAGNOSTICOS (
	  ID_DIAGNOSTICO INT IDENTITY PRIMARY KEY,
	  ID_ESPECIALISTA INT,
	  FECHA_DIAGNOSTICO DATE,
	  RESULTADOS_DIAGNOSTICO VARCHAR(25)
)

CREATE TABLE ESPECIALISTAS_WEB (
    ID_ESPECIALISTA INT IDENTITY PRIMARY KEY,
    NOMBRE_COMPLETO VARCHAR(100),
    ESPECIALIDAD VARCHAR(50),
    HORA_INICIO TIME,
    HORA_FINAL TIME,
    FECHA DATE
);

CREATE TABLE AGENDA_CITA_WEB (
    ID_CITA_WEB INT IDENTITY PRIMARY KEY,
    ID_ESPECIALISTA INT,
    ID_PACIENTE INT,
    HORA_INICIO TIME,
    FECHA DATE
);

--
ALTER TABLE ESPECIALISTAS_WEB
ADD CONSTRAINT CK_Especialidad CHECK (ESPECIALIDAD IN 
('ODONOTOLOGIA', 'OFTALMOFLOGIA', 'GEDIATRIA', 'GINECOLOGIA', 'PODOLOGIA', 'UROLOGIA'));
--

-- insercion de datos

--///////////////////////////////////////////////////////////////////////////////////////
INSERT INTO ESPECIALISTAS_WEB (NOMBRE_COMPLETO, ESPECIALIDAD, HORA_INICIO, HORA_FINAL, FECHA)
VALUES
    ('Juan Perez', 'ODONOTOLOGIA', '08:00:00', '16:00:00', '2023-07-01'),
    ('Maria López', 'OFTALMOFLOGIA', '09:00:00', '17:00:00', '2023-07-02'),
    ('Pedro Ramirez', 'GEDIATRIA', '10:00:00', '18:00:00', '2023-07-03'),
    ('Ana Garcia', 'GINECOLOGIA', '11:00:00', '19:00:00', '2023-07-04'),
    ('Luis Torres', 'PODOLOGIA', '12:00:00', '20:00:00', '2023-07-05'),
    ('Carlos Gomez', 'UROLOGIA', '13:00:00', '21:00:00', '2023-07-06'),
    ('Laura Martinez', 'ODONOTOLOGIA', '08:00:00', '16:00:00', '2023-07-01'),
    ('Andres Rojas', 'OFTALMOFLOGIA', '09:00:00', '17:00:00', '2023-07-02'),
    ('Gabriela Sanchez', 'GEDIATRIA', '10:00:00', '18:00:00', '2023-07-03'),
    ('Javier Rodriguez', 'GINECOLOGIA', '11:00:00', '19:00:00', '2023-07-04'),
    ('Marta Lopez', 'PODOLOGIA', '12:00:00', '20:00:00', '2023-07-05'),
    ('David Torres', 'UROLOGIA', '13:00:00', '21:00:00', '2023-07-06'),
    ('Elena Garcia', 'ODONOTOLOGIA', '08:00:00', '16:00:00', '2023-07-07'),
    ('Fernando Rojas', 'OFTALMOFLOGIA', '09:00:00', '17:00:00', '2023-07-08'),
    ('Sara Sanchez', 'GEDIATRIA', '10:00:00', '18:00:00', '2023-07-09'),
    ('Daniel Rodriguez', 'GINECOLOGIA', '11:00:00', '19:00:00', '2023-07-10'),
    ('Maria Torres', 'PODOLOGIA', '12:00:00', '20:00:00', '2023-07-11'),
    ('Andres Gomez', 'UROLOGIA', '13:00:00', '21:00:00', '2023-07-12'),
    ('Carolina Martinez', 'ODONOTOLOGIA', '08:00:00', '16:00:00', '2023-07-07')
	  


INSERT INTO PACIENTES (CEDULA_PACIENTE ,NOMBRE_COMPLETO_PACIENTE, TELEFONO_PACIENTE, CORREO_PACIENTE, DIRECCION_PACIENTE)
VALUES
    ('208140015', 'Jafet', 86453779, 'ulatealvarezjafet@gmail.com', 'la cima san ramon alajuela'),
    ('208140016', 'Carlos', 87892514, 'carlos@gmail.com', 'heredia'),
    ('208140017', 'Maria', 87256123, 'maria@gmail.com', 'san jose'),
    ('208140018', 'Jose', 84253698, 'jose@gmail.com', 'cartago'),
    ('208140019', 'Laura', 87789956, 'laura@gmail.com', 'alajuela'),
    ('208140020', 'Pedro', 85369874, 'pedro@gmail.com', 'puntarenas'),
    ('208140021', 'Ana', 88887778, 'ana@gmail.com', 'limon'),
    ('208140022', 'Luis', 87878787, 'luis@gmail.com', 'heredia'),
    ('208140023', 'Paola', 86585959, 'paola@gmail.com', 'san jose'),
    ('208140024', 'Andres', 87787777, 'andres@gmail.com', 'cartago'),
    ('208140025', 'Linda', 84858585, 'linda@gmail.com', 'alajuela'),
    ('208140026', 'Roberto', 83483838, 'roberto@gmail.com', 'puntarenas'),
    ('208140027', 'Carolina', 88882222, 'carolina@gmail.com', 'limon'),
    ('208140028', 'Felipe', 85656565, 'felipe@gmail.com', 'heredia'),
    ('208140029', 'Julia', 87272727, 'julia@gmail.com', 'san jose'),
    ('208140030', 'Hector', 89898989, 'hector@gmail.com', 'cartago'),
    ('208140031', 'Patricia', 89767676, 'patricia@gmail.com', 'alajuela'),
    ('208140032', 'Miguel', 85545454, 'miguel@gmail.com', 'puntarenas'),
    ('208140033', 'Isabel', 87878181, 'isabel@gmail.com', 'limon'),
    ('208140034', 'Fernando', 82222999, 'fernando@gmail.com', 'heredia');




/*
-- CONSULTA LISTAR CITAS
SELECT ID_CITA_WEB, CW.ID_ESPECIALISTA, E.NOMBRE_COMPLETO, P.ID_PACIENTE, P.NOMBRE_COMPLETO_PACIENTE, 
CW.HORA_INICIO, CW.FECHA
FROM AGENDA_CITA_WEB CW INNER JOIN PACIENTES P ON CW.ID_PACIENTE = P.ID_PACIENTE
INNER JOIN ESPECIALISTAS_WEB E ON CW.ID_ESPECIALISTA= E.ID_ESPECIALISTA
-- CONSULTA OBTENER CITAS
Select ID_CITA_WEB,CW.ID_ESPECIALISTA,E.NOMBRE_COMPLETO,P.ID_PACIENTE,P.NOMBRE_COMPLETO_PACIENTE,
CW.HORA_INICIO, CW.FECHA
from AGENDA_CITA_WEB CW INNER JOIN PACIENTES P ON CW.ID_PACIENTE = P.ID_PACIENTE
INNER JOIN ESPECIALISTAS_WEB E ON CW.ID_ESPECIALISTA= E.ID_ESPECIALISTA WHERE ID_CITA_WEB =@ID_CITA_WEB*/






-- FIN DE LA TABLAS

--RELACIONES ENTRE LAS TABLAS

ALTER TABLE AGENDA_CITA_WEB ADD CONSTRAINT FK_CITA_WEB
	FOREIGN KEY (ID_ESPECIALISTA) REFERENCES ESPECIALISTAS_WEB(ID_ESPECIALISTA);


	ALTER TABLE AGENDA_CITA_WEB ADD CONSTRAINT FK_CITA_WEB_PACIENTE
	FOREIGN KEY (ID_PACIENTE) REFERENCES PACIENTES(ID_PACIENTE);

-- RELACION ENTRE CLINCA Y USUARIO

ALTER TABLE DIAGNOSTICOS ADD CONSTRAINT FK_ESPE_CLINI
	FOREIGN KEY (ID_ESPECIALISTA) REFERENCES ESPECIALISTAS(ID_ESPECIALISTA);


-- RELACION ENTRE ESPECIALISTAS Y AGENDA DE ESPECIALISTA
ALTER TABLE AGENDA_ESPECIALISTAS ADD CONSTRAINT FK_AGE_ESPECIALIS
	FOREIGN KEY (ID_ESPECIALISTA) REFERENCES ESPECIALISTAS(ID_ESPECIALISTA);

-- RELACION ENTRE ESPECIALIDADES Y AGENDA DE ESPECIALISTA
ALTER TABLE AGENDA_ESPECIALISTAS ADD CONSTRAINT FK_NOM_ESPECIALID
	FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES ESPECIALIDADES(ID_ESPECIALIDAD);
	
-- RELACION AGENDA DE ESPECIALISTA Y CITAS A PROGRAMAR
ALTER TABLE CITAS_A_PROGRAMAR ADD CONSTRAINT FK_ID_CIT
	FOREIGN KEY (ID_CITAS) REFERENCES AGENDA_ESPECIALISTAS (ID_CITAS);

-- RELACION SECRETARIO Y PAGOS
ALTER TABLE PAGOS ADD CONSTRAINT FK_ID_FUNC
	FOREIGN KEY (ID_FUNCIONARIO) REFERENCES FUNCIONARIOS (ID_FUNCIONARIO);

-- RELACION SECRETARIO Y CITAS A PROGRMAR
ALTER TABLE CITAS_A_PROGRAMAR ADD CONSTRAINT FK_ID_FUNCFUNC
	FOREIGN KEY (ID_FUNCIONARIO) REFERENCES FUNCIONARIOS (ID_FUNCIONARIO);
----------------
-- RELACION PACIENTES Y CITAS A PROGRMAR
ALTER TABLE CITAS_A_PROGRAMAR ADD CONSTRAINT FK_CED_PACIENTE
	FOREIGN KEY (ID_PACIENTE) REFERENCES PACIENTES (ID_PACIENTE);
--------------
-- RELACION PACIENTES Y  PAGOS
ALTER TABLE PAGOS ADD CONSTRAINT FK_CED_PACPAGOS
	FOREIGN KEY (ID_PACIENTE) REFERENCES PACIENTES (ID_PACIENTE);

-- RELACION PACIENTES Y  HISTORIAL CLINICO
ALTER TABLE HISTORIAL_CLINICOS ADD CONSTRAINT FK_HISTORIAL
	FOREIGN KEY (ID_PACIENTE) REFERENCES PACIENTES (ID_PACIENTE);

-- RELACION MEDICAMENTOS Y  HISTORIAL CLINICO
ALTER TABLE HISTORIAL_CLINICOS ADD CONSTRAINT FK_MEDICAMENTO
	FOREIGN KEY (ID_MEDICAMENTO) REFERENCES MEDICAMENTOS (ID_MEDICAMENTO);
	
-- RELACION DIAGNOSTICO Y  HISTORIAL CLINICO
ALTER TABLE HISTORIAL_CLINICOS ADD CONSTRAINT FK_DIAGNOS
	FOREIGN KEY (ID_DIAGNOSTICO) REFERENCES DIAGNOSTICOS (ID_DIAGNOSTICO);

---------------------------------------------------
---------------------------------------------------
---------------------------------------------------
---------------------------------------------------

-- PROCEDIMEINTOS ALMACENADOS

-- Preoceso de eliminar y verifica que no haya cita registrada en el id del paciente
	GO
CREATE OR ALTER PROCEDURE ELIMINAR
	@idPaciente INT,
	@msj VARCHAR(50) OUT
AS BEGIN
			if(not exists(select * from AGENDA_CITA_WEB where ID_PACIENTE = @idPaciente))
			BEGIN
				DELETE FROM PACIENTES WHERE ID_PACIENTE=@idPaciente
				SET @msj='Paciente ELIMINADO'
				RETURN 1
			END
			else
				begin
					SET @msj='El Paciente tiene citas'
					return 0
				end
		END
GO




-- Este metodo lo que hace es que inserta la cita pero verifica que este dentro del horario y tambien 
--verifica que no este en otro horario que ya este agendado
go
CREATE OR ALTER PROCEDURE InsertarCita
    @ID_ESPECIALISTA INT,
    @ID_PACIENTE INT,
    @HORA_INICIO TIME,
    @FECHA DATE,
    @mensaje VARCHAR(100) OUTPUT
AS
BEGIN
    DECLARE @HoraInicioTrabajo TIME
    DECLARE @HoraFinalTrabajo TIME

    -- Obtener el horario de trabajo del especialista
    SELECT @HoraInicioTrabajo = HORA_INICIO,
           @HoraFinalTrabajo = HORA_FINAL
    FROM ESPECIALISTAS_WEB
    WHERE ID_ESPECIALISTA = @ID_ESPECIALISTA

    -- Verificar si la cita está fuera del horario de trabajo
    IF @HORA_INICIO < @HoraInicioTrabajo OR @HORA_INICIO > @HoraFinalTrabajo
    BEGIN
        SET @mensaje = 'La cita está fuera del horario de trabajo'
        RETURN 0
    END

    -- Verificar si el horario está ocupado en un rango de media hora
    DECLARE @HoraFinCita TIME
    SET @HoraFinCita = DATEADD(MINUTE, 30, @HORA_INICIO)

    IF EXISTS (
        SELECT 1
        FROM AGENDA_CITA_WEB
        WHERE ID_ESPECIALISTA = @ID_ESPECIALISTA
          AND FECHA = @FECHA
          AND (
            (HORA_INICIO >= @HORA_INICIO AND HORA_INICIO < @HoraFinCita) OR
            (DATEADD(MINUTE, 30, HORA_INICIO) > @HORA_INICIO AND DATEADD(MINUTE, 30, HORA_INICIO) <= @HoraFinCita)
          )
    )
    BEGIN
        SET @mensaje = 'El horario seleccionado está ocupado'
        RETURN 0
    END
    ELSE
    BEGIN
        -- Insertar la cita en la tabla AGENDA_CITA_WEB
        INSERT INTO AGENDA_CITA_WEB (ID_ESPECIALISTA, ID_PACIENTE, HORA_INICIO, FECHA)
        VALUES (@ID_ESPECIALISTA, @ID_PACIENTE, @HORA_INICIO, @FECHA)

        -- Éxito
        SET @mensaje = 'Cita insertada correctamente'
        RETURN 1
    END
END
go






--
-- Registrar cita especialista
GO
CREATE PROCEDURE RegistrarCita
    @idEspecialista INT,
    @idEspecialidad INT,
    @horaInicio TIME,
    @horaFinal TIME,
    @fechaCita DATE,
	@mensaje varchar(100) OUTPUT 
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Verificar disponibilidad de horarios
        IF EXISTS (
            SELECT 1
            FROM AGENDA_ESPECIALISTAS
            WHERE ID_ESPECIALISTA = @idEspecialista
                AND FECHA_CITA = @fechaCita
                AND ((HORA_INICIO <= @horaInicio AND HORA_FINAL >= @horaInicio)
                OR (HORA_INICIO <= @horaFinal AND HORA_FINAL >= @horaFinal)
                OR (HORA_INICIO >= @horaInicio AND HORA_FINAL <= @horaFinal))
        )
        BEGIN
            -- Horario no disponible
           set @mensaje = 'El horario que esta eligiendo ya esta ocupado' ;
        END
		ELSE
		BEGIN
        -- Registrar la cita
           INSERT INTO AGENDA_ESPECIALISTAS (ID_ESPECIALISTA, ID_ESPECIALIDAD, HORA_INICIO, HORA_FINAL, FECHA_CITA)
           VALUES (@idEspecialista, @idEspecialidad, @horaInicio, @horaFinal, @fechaCita);

        set @mensaje = 'Se registro la cita Perfectamente';
		END
    END TRY
    BEGIN CATCH
        
        set @mensaje = 'problemas por el momento';
    END CATCH;
END
GO


-- REGISTRAR CITA
GO
CREATE PROCEDURE regiCita
    @IDAgendaEspecialista INT,
    @IdFuncionario VARCHAR(30),
    @IdPaciente INT,
    @msj VARCHAR(100) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificar disponibilidad de horarios
    IF EXISTS (
        SELECT 1
        FROM CITAS_A_PROGRAMAR
        WHERE ID_PACIENTE = @IdPaciente
    )
    BEGIN
        
        SET @msj = 'Este paciente ya tiene un cita asignada en este horario ';
        RETURN;
    END
    ELSE
    BEGIN
        -- Registrar la cita
        INSERT INTO CITAS_A_PROGRAMAR (ID_CITAS, ID_FUNCIONARIO, ID_PACIENTE)
        VALUES (@IDAgendaEspecialista, @IdFuncionario, @IdPaciente);

        -- Mostrar mensaje de éxito o realizar alguna acción necesaria
        SET @msj = 'La cita se registro perfectamente';
        RETURN;
    END
END
GO


-- tiger para bitacora
--1
GO
CREATE TRIGGER triger_FUNCIONARIOS
ON FUNCIONARIOS
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla FUNCIONARIOS';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla FUNCIONARIOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla FUNCIONARIOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO


--2
GO
CREATE TRIGGER triger_PAGOS
ON PAGOS
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla PAGOS';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla PAGOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla PAGOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO


--3

GO
CREATE TRIGGER triger_MEDICAMENTOS
ON MEDICAMENTOS
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla MEDICAMENTOS';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla MEDICAMENTOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla MEDICAMENTOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO



--4
GO
CREATE TRIGGER triger_CITAS_A_PROGRAMAR
ON CITAS_A_PROGRAMAR
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla CITAS_A_PROGRAMAR';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla CITAS_A_PROGRAMAR';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla USUARIOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO




--5
GO
CREATE TRIGGER triger_DIAGNOSTICOS
ON DIAGNOSTICOS
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla DIAGNOSTICOS';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla DIAGNOSTICOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES (GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla DIAGNOSTICOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO


--6

GO
CREATE TRIGGER triger_HISTORIAL_CLINICOS
ON HISTORIAL_CLINICOS
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla HISTORIAL_CLINICOS';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla HISTORIAL_CLINICOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla HISTORIAL_CLINICOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO
--7
GO
CREATE TRIGGER triger_AGENDA_ESPECIALISTAS
ON AGENDA_ESPECIALISTAS
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla AGENDA_ESPECIALISTAS';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla AGENDA_ESPECIALISTAS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla AGENDA_ESPECIALISTAS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO
--8
GO
CREATE TRIGGER triger_ESPECIALIDADES
ON ESPECIALIDADES
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla ESPECIALIDADES';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla ESPECIALIDADES';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla ESPECIALIDADES';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO
--9
GO
CREATE TRIGGER triger_PACIENTES
ON PACIENTES
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla PACIENTES';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla PACIENTES';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla PACIENTES';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO

--10

GO
CREATE TRIGGER triger_ESPECIALISTAS
ON ESPECIALISTAS
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Movimiento VARCHAR(200);

    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de inserción y actualización
        IF EXISTS (SELECT * FROM deleted)
            SET @Movimiento = 'Registro actualizado en la tabla ESPECIALISTAS';
        ELSE
            SET @Movimiento = 'Registro insertado en la tabla ESPECIALISTAS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        -- Insertar registros en la tabla de bitácora para las operaciones de eliminación
        SET @Movimiento = 'Registro eliminado en la tabla USUARIOS';

        INSERT INTO BITACORAS ( FECHA, HORA, MOVIMIENTO_REALIZADO)
        VALUES ( GETDATE(), CONVERT(TIME, GETDATE()), @Movimiento);
    END
END
GO