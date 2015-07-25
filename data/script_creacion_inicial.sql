/***************************************************************************************************

   _____                  _              _                 _         _____          _ _             
  / ____|                | |            | |               | |       / ____|        | (_)            
 | |     ___  _   _ _ __ | |_ ___ _ __  | |     ___   __ _| | ___  | |     ___   __| |_ _ __   __ _ 
 | |    / _ \| | | | '_ \| __/ _ \ '__| | |    / _ \ / _` | |/ __| | |    / _ \ / _` | | '_ \ / _` |
 | |___| (_) | |_| | | | | ||  __/ |    | |___| (_) | (_| |_| (__  | |___| (_) | (_| | | | | | (_| |
  \_____\___/ \__,_|_| |_|\__\___|_|    |______\___/ \__, (_)\___|  \_____\___/ \__,_|_|_| |_|\__, |
                                                      __/ |                                    __/ |
                                                     |___/                                    |___/ 


											   _     _   
											  (c).-.(c)  
											   / ._. \   
											 __\( Y )/__ 
											(_.-/'-'\-._)
											   ||   ||   
											 _.' `-' '._ 
											(.-./`-'\.-.)
											 `-'     `-' 
											 
****************************************************************************************************/

USE GD1C2015
GO

-- ***********************************************************************************************
-- ***********************************************************************************************
-- ***********************************************************************************************
--   PARTE I - GeneraciÃ³n de esquema COUNTER_LOGIC_CODING e incorporaciÃ³n de datos desde MAESTRA
-- ***********************************************************************************************

-- ---------------------------------------------------------------------------------
-- Eliminacion ordenada de objetos existentes generados en ejecuciones anteriores
-- para que haya indepENDencia entre corridas del script de creaciÃ³n inicial
------------------------------------------------------------------------------------

IF OBJECT_ID('COUNTER_LOGIC_CODING.INHABILITACION_TRANSACCION') is not null
	DROP TABLE COUNTER_LOGIC_CODING.INHABILITACION_TRANSACCION
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.LOG_LOGIN') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.LOG_LOGIN;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.TRANSFERENCIA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.TRANSFERENCIA;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.RETIRO') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.RETIRO;	
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.DEPOSITO') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.DEPOSITO;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.COMISION') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.COMISION;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.CAMBIO_DE_TIPO_CUENTA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.CAMBIO_DE_TIPO_CUENTA

IF OBJECT_ID('COUNTER_LOGIC_CODING.APERTURA_CUENTA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.APERTURA_CUENTA
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.OPERACION') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.OPERACION;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.ROL_X_USUARIO') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.ROL_X_USUARIO;
		
IF OBJECT_ID('COUNTER_LOGIC_CODING.FUNCIONALIdAD_X_ROL') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.FUNCIONALIdAD_X_ROL;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.TARJETA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.TARJETA;

IF OBJECT_ID('COUNTER_LOGIC_CODING.EMISOR') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.EMISOR;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.CHEQUE') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.CHEQUE;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.FACTURA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.FACTURA;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.CUENTA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.CUENTA;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.ESTADOS_CUENTA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.ESTADOS_CUENTA;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.BANCO') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.BANCO;	
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.FUNCIONALIDAD') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.FUNCIONALIDAD;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.CLIENTE') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.CLIENTE;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.USUARIO') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.USUARIO;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.ROL') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.ROL;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.TIPO_CUENTA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.TIPO_CUENTA;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.TIPO_DOCUMENTO') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.TIPO_DOCUMENTO;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.PAIS') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.PAIS;	
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.MONEDA') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.MONEDA;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.INCONSISTENCIAS') IS NOT NULL
	DROP TABLE COUNTER_LOGIC_CODING.INCONSISTENCIAS;

IF OBJECT_ID('COUNTER_LOGIC_CODING.COMISION') is not null
	drop table COUNTER_LOGIC_CODING.COMISION

IF OBJECT_ID('COUNTER_LOGIC_CODING.OPERACION') is not null
	drop table COUNTER_LOGIC_CODING.OPERACION
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.EMISOR') is not null
	drop table COUNTER_LOGIC_CODING.EMISOR

IF OBJECT_ID('COUNTER_LOGIC_CODING.FACTURA') is not null
	drop table COUNTER_LOGIC_CODING.FACTURA
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.INCONSISTENCIAS') is not null
	drop table COUNTER_LOGIC_CODING.INCONSISTENCIAS

IF OBJECT_ID('COUNTER_LOGIC_TABLE.BANCO') is not null
	drop table COUNTER_LOGIC_CODING.BANCO
	
IF OBJECT_ID('COUNTER_LOGIC_TABLE.CUENTA') is not null
	drop table COUNTER_LOGIC_CODING.CUENTA
	
IF OBJECT_ID('COUNTER_LOGIC_TABLE.ESTADOS_CUENTA') is not null
	drop table COUNTER_LOGIC_CODING.ESTADOS_CUENTA
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.TIPO_CUENTA') is not null
	drop table COUNTER_LOGIC_CODING.TIPO_CUENTA

IF OBJECT_ID('COUNTER_LOGIC_TABLE.CLIENTE') is not null
	drop table COUNTER_LOGIC_CODING.CLIENTE

IF OBJECT_ID('COUNTER_LOGIC_CODING.PAIS') is not null
	drop table COUNTER_LOGIC_CODING.PAIS
	
IF OBJECT_ID('COUNTER_LOGIC_TABLE.MONEDA') is not null
	drop table COUNTER_LOGIC_CODING.MONEDA
	
IF OBJECT_ID('COUNTER_LOGIC_TABLE.TIPO_DOCUMENTO') is not null
	drop table COUNTER_LOGIC_CODING.TIPO_DOCUMENTO

IF OBJECT_ID('COUNTER_LOGIC_CODING.USUARIO') is not null
	drop table COUNTER_LOGIC_CODING.USUARIO

IF OBJECT_ID('COUNTER_LOGIC_CODING.validar_login') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.validar_login
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.validar_pregunta') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.validar_pregunta

IF OBJECT_ID('COUNTER_LOGIC_CODING.actualizarIntentos') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.actualizarIntentos

IF OBJECT_ID('COUNTER_LOGIC_CODING.funcionalidadDeRol') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.funcionalidadDeRol

IF OBJECT_ID('COUNTER_LOGIC_CODING.funcionalidades') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.funcionalidades

IF OBJECT_ID('COUNTER_LOGIC_CODING.getRolesById') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.getRolesById	
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getUsuario') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.getUsuario

if OBJECT_ID('COUNTER_LOGIC_CODING.getPreguntaUsuario') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.getPreguntaUsuario
	
if OBJECT_ID('COUNTER_LOGIC_CODING.setPassword') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.setPassword

IF OBJECT_ID('COUNTER_LOGIC_CODING.getClientes') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getClientes
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getCliente') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCliente
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.find_clientes') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.find_clientes
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.calcularEstadoCliente') is not null
	DROP FUNCTION COUNTER_LOGIC_CODING.calcularEstadoCliente

if OBJECT_ID('COUNTER_LOGIC_CODING.getPais') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getPais
	
if OBJECT_ID('COUNTER_LOGIC_CODING.getTipoDoc') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getTipoDoc
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.darDeBajaCliente') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.darDeBajaCliente
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.COINCIDE_DOCUMENTO') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.COINCIDE_DOCUMENTO

IF OBJECT_ID('COUNTER_LOGIC_CODING.getRoles') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getRoles

IF OBJECT_ID('COUNTER_LOGIC_CODING.getTipoCuenta') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getTipoCuenta	
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getEstado') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getEstado

IF OBJECT_ID('COUNTER_LOGIC_CODING.getMoneda') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getMoneda

IF OBJECT_ID('COUNTER_LOGIC_CODING.getCuentasByUserId') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCuentasByUserId	
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getCuentasByClienteId') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCuentasByClienteId	

IF OBJECT_ID('COUNTER_LOGIC_CODING.getCuentasByUserIdAndType') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCuentasByUserIdAndType

IF OBJECT_ID('COUNTER_LOGIC_CODING.getTiposCuentas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getTiposCuentas

IF OBJECT_ID('COUNTER_LOGIC_CODING.getMonedas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getMonedas

IF OBJECT_ID('COUNTER_LOGIC_CODING.getTiposCuentas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getTiposCuentas

IF OBJECT_ID('COUNTER_LOGIC_CODING.getPaises') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getPaises	

IF OBJECT_ID('COUNTER_LOGIC_CODING.ABMROL_AltaRol') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.ABMROL_AltaRol

IF OBJECT_ID('COUNTER_LOGIC_CODING.ABMROL_AltaRolFuncionalidad') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.ABMROL_AltaRolFuncionalidad

IF OBJECT_ID('COUNTER_LOGIC_CODING.ABMROL_getRoles') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.ABMROL_getRoles

IF OBJECT_ID('COUNTER_LOGIC_CODING.ABMROL_bajaRolFuncionalidad') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.ABMROL_bajaRolFuncionalidad

IF OBJECT_ID('COUNTER_LOGIC_CODING.ABMROL_habilitarRol') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.ABMROL_habilitarRol

IF OBJECT_ID('COUNTER_LOGIC_CODING.ABMROL_inhabilitarRol') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.ABMROL_inhabilitarRol
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimas10Transferencias') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimas10Transferencias

IF OBJECT_ID('COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimos5Depositos') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimos5Depositos

IF OBJECT_ID('COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimos5Retiros') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimos5Retiros

IF OBJECT_ID('COUNTER_LOGIC_CODING.darDeAltaCliente') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.darDeAltaCliente
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.darDeBajaUsuario') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.darDeBajaUsuario

IF OBJECT_ID('COUNTER_LOGIC_CODING.darAltaCuenta') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.darAltaCuenta	

IF OBJECT_ID('COUNTER_LOGIC_CODING.darBajaCuenta') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.darBajaCuenta		

IF OBJECT_ID('COUNTER_LOGIC_CODING.getCuentasHabilitadasByUserID') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCuentasHabilitadasByUserID

IF OBJECT_ID('COUNTER_LOGIC_CODING.getCuentasHabilitadas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCuentasHabilitadas
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getTarjetas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getTarjetas
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.calcularFechaExpiracion') is not null
	DROP FUNCTION COUNTER_LOGIC_CODING.calcularFechaExpiracion
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.editCuenta') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.editCuenta
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getCuentas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCuentas

IF OBJECT_ID('COUNTER_LOGIC_CODING.getIdUsuarioByClientName') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getIdUsuarioByClientName
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.tieneDeudas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.tieneDeudas
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getCuentasClientNameLike') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCuentasClientNameLike	
			
IF OBJECT_ID('COUNTER_LOGIC_CODING.modificarCliente') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.modificarCliente
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getUsuariosConCuentasActivas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getUsuariosConCuentasActivas
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getUserIdByUsername') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getUserIdByUsername

IF OBJECT_ID('COUNTER_LOGIC_CODING.getCuentaById') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getCuentaById
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.altaTransferencia') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.altaTransferencia
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getBanco') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getBanco
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getClienteByUserId') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getClienteByUserId
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getEmisor') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getEmisor
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.asociarTarjeta') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.asociarTarjeta
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getTarjetaByCliente') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getTarjetaByCliente
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.modificarTarjeta') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.modificarTarjeta

IF OBJECT_ID('COUNTER_LOGIC_CODING.esDocumentoCorrectoParaElUsuarioLogeado') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.esDocumentoCorrectoParaElUsuarioLogeado;	

IF OBJECT_ID('COUNTER_LOGIC_CODING.altaRetiro') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.altaRetiro;	

IF OBJECT_ID('COUNTER_LOGIC_CODING.DEPOSITAR') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.DEPOSITAR;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getComisionesById') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.getComisionesById;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getComisionesImpagasFromCuenta') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.getComisionesImpagasFromCuenta;

IF OBJECT_ID('COUNTER_LOGIC_CODING.cambiarEstadoCuenta') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.cambiarEstadoCuenta
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.cantidadComisionesImpagas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.cantidadComisionesImpagas
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getComisionesById') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.getComisionesById;
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getComisionesImpagasFromCuenta') IS NOT NULL
	DROP PROCEDURE COUNTER_LOGIC_CODING.getComisionesImpagasFromCuenta;

IF OBJECT_ID('COUNTER_LOGIC_CODING.cambiarEstadoCuenta') is not null
	drop procedure COUNTER_LOGIC_CODING.cambiarEstadoCuenta
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.tieneDeudasByID') is not null
DROP PROCEDURE COUNTER_LOGIC_CODING.tieneDeudasByID

IF OBJECT_ID('COUNTER_LOGIC_CODING.renovarSubscripcion') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.renovarSubscripcion

IF OBJECT_ID('COUNTER_LOGIC_CODING.editCuentaAdmin') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.editCuentaAdmin

IF OBJECT_ID('COUNTER_LOGIC_CODING.getEstados') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.getEstados
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.registrarInhabilitacion') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.registrarInhabilitacion

IF OBJECT_ID('COUNTER_LOGIC_CODING.getFacturasCli') is not null
	drop procedure COUNTER_LOGIC_CODING.getFacturasCli
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getComisionesFactura') is not null
	drop procedure COUNTER_LOGIC_CODING.getComisionesFactura
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.getFacturaById') is not null
	drop procedure COUNTER_LOGIC_CODING.getFacturaById
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.crearFactura') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.crearFactura

IF OBJECT_ID('COUNTER_LOGIC_CODING.agregarComisionPagada') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.agregarComisionPagada

IF OBJECT_ID('COUNTER_LOGIC_CODING.cantidadComisionesImpagas') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.cantidadComisionesImpagas

IF OBJECT_ID('COUNTER_LOGIC_CODING.TOTAL_FACTURADO_PARA_DISTINTOS_TIPOS_DE_CUENTAS') is not null
	drop procedure COUNTER_LOGIC_CODING.TOTAL_FACTURADO_PARA_DISTINTOS_TIPOS_DE_CUENTAS
	
IF OBJECT_ID('COUNTER_LOGIC_CODING.PAISES_CON_MAYOR_CANTIDAD_DE_MOVIMIENTOS') is not null
	drop procedure COUNTER_LOGIC_CODING.PAISES_CON_MAYOR_CANTIDAD_DE_MOVIMIENTOS

IF OBJECT_ID('COUNTER_LOGIC_CODING.CLIENTES_CON_MAYOR_CANTIDAD_DE_TRANSACCIONES_ENTRE_CUENTAS_PROPIAS') is not null
	drop procedure COUNTER_LOGIC_CODING.CLIENTES_CON_MAYOR_CANTIDAD_DE_TRANSACCIONES_ENTRE_CUENTAS_PROPIAS

IF OBJECT_ID('COUNTER_LOGIC_CODING.CLIENTES_CON_MAYOR_CANTIDAD_DE_COMISIONES') is not null
	drop procedure COUNTER_LOGIC_CODING.CLIENTES_CON_MAYOR_CANTIDAD_DE_COMISIONES

IF OBJECT_ID('COUNTER_LOGIC_CODING.CLIENTES_CON_CUENTAS_INHABILITADAS_POR_AUSENCIA_DE_PAGO') is not null
	drop procedure COUNTER_LOGIC_CODING.CLIENTES_CON_CUENTAS_INHABILITADAS_POR_AUSENCIA_DE_PAGO

IF OBJECT_ID('COUNTER_LOGIC_CODING.coincideTarjeta') is not null
	DROP PROCEDURE COUNTER_LOGIC_CODING.coincideTarjeta

------------------------------------------------
-- EliminaciÃ³n de  schema
------------------------------------------------

IF EXISTS (SELECT * FROM sys.schemas WHERE name = N'COUNTER_LOGIC_CODING')
	DROP SCHEMA COUNTER_LOGIC_CODING


--**************************************************************************
-- CREACION DE OBJETOS DE LA EJECUCION ACTUAL
--**************************************************************************

---------------------------
-- Creacin de schema -----
---------------------------
USE GD1C2015
GO

CREATE SCHEMA COUNTER_LOGIC_CODING AUTHORIZATION gd
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

-------------------------------------------------------------
-- Creacion de Tabla INCONSISTENCIAS
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.INCONSISTENCIAS(
	Codigo_Banco INT,
	Nombre_Banco VARCHAR(250),
	Direccion_Banco VARCHAR(250),
	Cheque_Numero NUMERIC(18,0),
	Cheque_Fecha DATETIME,
	Cheque_Importe NUMERIC(18,2),
	Retiro_Codigo NUMERIC(18,0),
	Retiro_Fecha DATETIME,
	Retiro_Importe NUMERIC(18,2)
);

------------------------------------------------------------
-- Creacion de Tabla Emisores
-- ---------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.EMISOR(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Descripcion VARCHAR(255)
);

------------------------------------------------------------
-- Creacion de Tabla BANCO
-- ---------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.BANCO (
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Nombre VARCHAR(255),
	Direccion VARCHAR(255)
);

-------------------------------------------------------------
-- Creacion de Tabla MONEDA
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.MONEDA (
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Descripcion VARCHAR(255) NOT NULL
);

-------------------------------------------------------------
-- Creacion de Tabla TIPO_CUENTA
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.TIPO_CUENTA (
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Descripcion VARCHAR(255) NOT NULL,
	Duracion INT,
	Costo_Subscripcion NUMERIC(18,2) NOT NULL,
	Costo_Transferencia_A_Terceros NUMERIC(18,2) NOT NULL,
	CONSTRAINT Chk_Costos_Tipo_Datos CHECK(Costo_Subscripcion >= 0 AND Costo_Transferencia_A_Terceros >= 0)
);

-------------------------------------------------------------
-- Creacion de Tabla FUNCIONALIDAD
-- ----------------------------------------------------------
CREATE TABLE COUNTER_LOGIC_CODING.FUNCIONALIDAD (
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Descripcion VARCHAR(255) NOT NULL
);

-------------------------------------------------------------
-- Creacion de Tabla ROL
-- ----------------------------------------------------------
CREATE TABLE COUNTER_LOGIC_CODING.ROL (
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Descripcion VARCHAR(25) NOT NULL,
	Estado BIT NOT NULL DEFAULT(1)
);

-------------------------------------------------------------
-- Creacion de Tabla USUARIO
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.USUARIO (
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Username VARCHAR(255) NOT NULL unique,
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Ultima_Modificacion DATETIME NOT NULL,
	Pregunta_Secreta VARCHAR(255) NOT NULL,
	Respuesta_Secreta varbinary(32) NOT NULL, /* Hash SHA256 */
	Contrasenia varbinary(32) NOT NULL,       /* Hash SHA256 */
	Estado BIT NOT NULL,
	Intentos_Login INT NOT NULL DEFAULT 0
);

-------------------------------------------------------------
-- Creacion de Tabla PAIS
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.PAIS (
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Descripcion VARCHAR(250) UNIQUE NOT NULL
);

-------------------------------------------------------------
-- Creacion de Tabla ROL_X_USUARIO
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.ROL_X_USUARIO (
	Usuario INT NOT NULL, 	/*FK*/
	Rol INT NOT NULL, 		/*FK*/
	CONSTRAINT Pk_Compuesta_Rol_X_Usuario PRIMARY KEY(Usuario,Rol),
	CONSTRAINT Fk_Rol_X_Usuario_Usuario FOREIGN KEY (Usuario) REFERENCES COUNTER_LOGIC_CODING.USUARIO(Id),
	CONSTRAINT Fk_Rol_X_Usuario_Rol FOREIGN KEY (Rol) REFERENCES COUNTER_LOGIC_CODING.ROL(Id)
);


-------------------------------------------------------------
-- Creacion de Tabla FUNCIONALIDAD_X_ROL
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.FUNCIONALIDAD_X_ROL (
	Rol INT NOT NULL, 				/*FK*/
	Funcionalidad INT NOT NULL, 	/*FK*/
	CONSTRAINT Pk_Compuesta_Funcionalidad_x_Rol PRIMARY KEY(Rol,Funcionalidad),
	CONSTRAINT Fk_Funcionalidad_x_Rol_Rol FOREIGN KEY (Rol) REFERENCES COUNTER_LOGIC_CODING.ROL(Id),
	CONSTRAINT Fk_Funcionalidad_x_Rol_Funcionalidad FOREIGN KEY (Funcionalidad) REFERENCES COUNTER_LOGIC_CODING.FUNCIONALIDAD(Id)
);



-------------------------------------------------------------
-- Creacion de Tabla TIPO_DOCUMENTO
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.TIPO_DOCUMENTO(
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Descripcion VARCHAR(255) NOT NULL
);

-------------------------------------------------------------
-- Creacion de Tabla CLIENTE
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.CLIENTE(
	ID INT IDENTITY(0,1) PRIMARY KEY,
	Usuario INT NOT NULL, 			/*FK*/	
	Pais INT NOT NULL, 				/*FK*/
	Tipo_Documento INT NOT NULL, 	/*FK*/
	Nacionalidad INT, 				/*FK*/
	Mail VARCHAR(255) NOT NULL,
	Fecha_nac DATETIME NOT NULL,
	Dom_Calle VARCHAR(255) NOT NULL,
	Dom_Nro NUMERIC(18,0) NOT NULL,
	Dom_Depto VARCHAR(10),
	Dom_Piso NUMERIC(18,0),
	Localidad VARCHAR(60) DEFAULT '',
	Nombre VARCHAR(255) NOT NULL,
	Apellido VARCHAR(255) NOT NULL,	
	Nro_Doc NUMERIC(18,0) NOT NULL,
	CONSTRAINT chk_Domicilio_y_Documento CHECK(Dom_Nro > 0 AND Nro_Doc > 0) ,
	CONSTRAINT Fk_Cliente_Usuario FOREIGN KEY (Usuario) REFERENCES COUNTER_LOGIC_CODING.USUARIO(Id),
	CONSTRAINT Fk_Cliente_PaIS FOREIGN KEY (Pais) REFERENCES COUNTER_LOGIC_CODING.PAIS(Id),
	CONSTRAINT Fk_Cliente_Tipo_Documento FOREIGN KEY (Tipo_Documento) REFERENCES COUNTER_LOGIC_CODING.TIPO_DOCUMENTO(Id),
	CONSTRAINT Fk_Cliente_Nacionalidad FOREIGN KEY (Nacionalidad) REFERENCES COUNTER_LOGIC_CODING.PAIS(Id)
);


-------------------------------------------------------------
-- Creacion de Tabla CHEQUE
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.CHEQUE (
	Id NUMERIC(18,0) IDENTITY(0,1) PRIMARY KEY,
	Banco INT NOT NULL,                 /*FK*/
	Cliente INT NOT NULL,
	CONSTRAINT Fk_Cheque_Cliente FOREIGN KEY (Cliente) REFERENCES COUNTER_LOGIC_CODING.CLIENTE(Id)
);

-------------------------------------------------------------
-- Creacion de Tabla TARJETA
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.TARJETA(
	id BIGINT IDENTITY(0,1) PRIMARY KEY,
	Numero varbinary(250) NOT NULL,
	Banco_Emisor INT NOT NULL,           /*FK*/
	Cliente INT NOT NULL,                /*FK*/
	Fecha_Emision DATETIME NOT NULL,
	Fecha_Vencimiento DATETIME NOT NULL,
	Codigo_Seguridad varbinary(250) NOT NULL,
	Ultimos_Digitos VARCHAR(4) NOT NULL,
	Estado bit default 1,
	Titular varchar(255),
	CONSTRAINT chk_Fecha_Emision_Menor_Fecha_Vencimiento CHECK(Fecha_Emision <= Fecha_Vencimiento),
	CONSTRAINT Fk_Tarjeta_Cliente FOREIGN KEY (Cliente) REFERENCES COUNTER_LOGIC_CODING.CLIENTE(Id),
	CONSTRAINT Fk_Tarjeta_Emisor FOREIGN KEY (Banco_Emisor) REFERENCES COUNTER_LOGIC_CODING.EMISOR(Id)
);



-------------------------------------------------------------
-- Creacion de Tabla CUENTA y ESTADOS_CUENTA
-- ----------------------------------------------------------
CREATE TABLE COUNTER_LOGIC_CODING.ESTADOS_CUENTA(
Id INT IDENTITY(1,1) PRIMARY KEY,
Descripcion VARCHAR(255) );

CREATE TABLE COUNTER_LOGIC_CODING.CUENTA (
	Id NUMERIC(18,0) IDENTITY(0,1) PRIMARY KEY,
	Tipo_Cuenta INT NOT NULL,              /*FK*/
	Moneda INT NOT NULL,                   /*FK*/
	Pais INT NOT NULL,                     /*FK*/
	Cliente INT NOT NULL,                  /*FK*/  
	Fecha_Creacion DATETIME NOT NULL,
	Fecha_Cierre DATETIME,
	Fecha_Expiracion datetime,
	Estado INT NOT NULL ,
	Saldo NUMERIC(18,2) CHECK(Saldo >= 0),
	CONSTRAINT Fk_Cuenta_Tipo_Cuenta FOREIGN KEY (Tipo_Cuenta) REFERENCES COUNTER_LOGIC_CODING.TIPO_CUENTA(Id),
	CONSTRAINT Fk_Cuenta_Moneda FOREIGN KEY (Moneda) REFERENCES COUNTER_LOGIC_CODING.MONEDA(Id),
	CONSTRAINT Fk_Cuenta_PaIS FOREIGN KEY (Pais) REFERENCES COUNTER_LOGIC_CODING.PAIS(Id),
	CONSTRAINT Fk_Cuenta_Cliente FOREIGN KEY (Cliente) REFERENCES COUNTER_LOGIC_CODING.CLIENTE(Id),
	CONSTRAINT Fk_Cuenta_EstadoCuenta FOREIGN KEY (Estado) REFERENCES COUNTER_LOGIC_CODING.ESTADOS_CUENTA(Id)
	
);
-------------------------------------------------------------
-- Creacion de Tabla INHABILITACION_TRANSACCION
-- ----------------------------------------------------------
CREATE TABLE COUNTER_LOGIC_CODING.INHABILITACION_TRANSACCION(
	Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
	Cuenta NUMERIC(18,0) not null,
	Fecha DATETIME not null,
	CONSTRAINT Fk_Inhabilitacion_Cuenta FOREIGN KEY (Cuenta) REFERENCES COUNTER_LOGIC_CODING.CUENTA(Id)
);

-------------------------------------------------------------
-- Creacion de Tabla Operaciones
-- ----------------------------------------------------------
CREATE TABLE COUNTER_LOGIC_CODING.OPERACION ( 
Id NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY,
Cuenta NUMERIC(18,0), 	/*FK*/
Moneda INT, 			/*FK*/
Fecha DATETIME,
Importe REAL CHECK (Importe >= 0),
CONSTRAINT Fk_Operacion_Cuenta FOREIGN KEY (Cuenta) REFERENCES COUNTER_LOGIC_CODING.CUENTA(Id),
CONSTRAINT FK_Operacion_Moneda FOREIGN KEY (Moneda) REFERENCES COUNTER_LOGIC_CODING.MONEDA(Id)
);

-------------------------------------------------------------
-- Creacion de Tabla Cambio de Cuenta y Apertura Cuenta
-- ----------------------------------------------------------
CREATE TABLE COUNTER_LOGIC_CODING.CAMBIO_DE_TIPO_CUENTA(
	Id NUMERIC(18,0) PRIMARY KEY,
	Cuenta NUMERIC(18,0) NOT NULL,
	Tipo_Original INT NOT NULL,
	Tipo_Destino INT NOT NULL,
	Fecha DATETIME,
	CONSTRAINT Fk_OP_CambioCuenta FOREIGN KEY (Id) REFERENCES COUNTER_LOGIC_CODING.OPERACION(Id),
	CONSTRAINT Fk_Cuenta_CambioCuenta FOREIGN KEY (Cuenta) REFERENCES COUNTER_LOGIC_CODING.CUENTA(Id),
	CONSTRAINT Fk_Cuenta_CambioCuenta_TipoOriginal  FOREIGN KEY (Tipo_Original) REFERENCES COUNTER_LOGIC_CODING.TIPO_CUENTA(Id),
	CONSTRAINT Fk_Cuenta_CambioCuenta_TipoDestino  FOREIGN KEY (Tipo_Destino) REFERENCES COUNTER_LOGIC_CODING.TIPO_CUENTA(Id)
	)
	
CREATE TABLE COUNTER_LOGIC_CODING.APERTURA_CUENTA(
	Id NUMERIC(18,0) PRIMARY KEY,   /*FK*/
	Cuenta NUMERIC(18,0), 			/*FK*/
	Tipo_Cuenta INT,				/*FK*/
	Cliente INT,					/*FK*/
	CONSTRAINT Fk_Apertura_Operacion FOREIGN KEY (Id) REFERENCES COUNTER_LOGIC_CODING.OPERACION(Id),
	CONSTRAINT Fk_Apertura_Cuenta FOREIGN KEY (Cuenta) REFERENCES COUNTER_LOGIC_CODING.CUENTA(Id),
	CONSTRAINT Fk_Apertura_TipoCuenta FOREIGN KEY (Tipo_Cuenta) REFERENCES COUNTER_LOGIC_CODING.TIPO_CUENTA(Id),
	CONSTRAINT Fk_Apertura_Cliente FOREIGN KEY (Cliente) REFERENCES COUNTER_LOGIC_CODING.CLIENTE(Id)
)
-------------------------------------------------------------
-- Creacion de Tabla RETIRO
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.RETIRO ( 
	Id NUMERIC(18,0) PRIMARY KEY,					/*FK*/
	Cheque NUMERIC(18,0) NOT NULL,				  	/*FK*/
	ID_retiro numeric(18,0) identity(1,1) unique,
	CONSTRAINT Fk_Retiro_Cheque FOREIGN KEY (Cheque) REFERENCES COUNTER_LOGIC_CODING.CHEQUE(Id),
	CONSTRAINT Fk_Retiro_Operacion FOREIGN KEY (Id) REFERENCES COUNTER_LOGIC_CODING.OPERACION(Id)
);

-------------------------------------------------------------
-- Creacion de tabla FACTURA
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.FACTURA (
	Id NUMERIC(18,0) IDENTITY(0,1) PRIMARY KEY,
	Cliente INT NOT NULL,           /*FK*/
	Fecha DATETIME NOT NULL,
	CONSTRAINT Fk_Factura_Cliente FOREIGN KEY (Cliente) REFERENCES COUNTER_LOGIC_CODING.CLIENTE(Id)	
);

-------------------------------------------------------------
-- Creacion de tabla DEPOSITO
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.DEPOSITO (
	Id NUMERIC(18,0) PRIMARY KEY,		/*FK*/
	Tarjeta BIGINT NOT NULL,            /*FK*/
	ID_Depo numeric(18,0) identity(1,1) unique,
	CONSTRAINT Fk_Deposito_Tarjeta FOREIGN KEY (tarjeta) REFERENCES COUNTER_LOGIC_CODING.TARJETA(Id),
	CONSTRAINT FK_Deposito_Operacion FOREIGN KEY (Id) REFERENCES COUNTER_LOGIC_CODING.OPERACION(Id)
);


-------------------------------------------------------------
-- Creacion de tabla TRANSFERENCIA
-- ----------------------------------------------------------


CREATE TABLE COUNTER_LOGIC_CODING.TRANSFERENCIA(
	Id NUMERIC(18,0) PRIMARY KEY,					/*FK*/
	Cuenta_Destino NUMERIC(18,0) NOT NULL,        	/*FK*/ 
	Costo REAL CHECK (Costo >= 0),
	ID_Transf numeric(18,0) identity(1,1) unique,
	CONSTRAINT Fk_Transferencia_Cuenta_Destino FOREIGN KEY (Cuenta_Destino) REFERENCES COUNTER_LOGIC_CODING.CUENTA(Id),
	CONSTRAINT FK_Transferencia_Oeracion FOREIGN KEY (Id) REFERENCES COUNTER_LOGIC_CODING.OPERACION(Id)
);

-------------------------------------------------------------
-- Creacion de Tabla ITEM && Comision
-- ----------------------------------------------------------
CREATE TABLE COUNTER_LOGIC_CODING.COMISION( 
	Id BIGINT IDENTITY(0,1) PRIMARY KEY,
	Cuenta NUMERIC(18,0) NOT NULL,
	Factura NUMERIC(18,0),
	Descripcion VARCHAR(255) NOT NULL,
	Operacion NUMERIC(18,0),
	Tipo_Cuenta INT NOT NULL,
	Monto NUMERIC(18,2) NOT NULL,
	CONSTRAINT FK_Comision_Cuenta FOREIGN KEY (Cuenta) REFERENCES COUNTER_LOGIC_CODING.CUENTA(Id),
	CONSTRAINT FK_Comision_TipoCuenta FOREIGN KEY (Tipo_Cuenta) REFERENCES COUNTER_LOGIC_CODING.TIPO_CUENTA(Id),
	CONSTRAINT FK_Comision_Operacion FOREIGN KEY (Operacion) REFERENCES COUNTER_LOGIC_CODING.OPERACION(Id),
	CONSTRAINT FK_Comision_Factura FOREIGN KEY (Factura) REFERENCES COUNTER_LOGIC_CODING.Factura(Id)
);

-------------------------------------------------------------
-- Creacion de Tabla LOG_LOGIN
-- ----------------------------------------------------------

CREATE TABLE COUNTER_LOGIC_CODING.LOG_LOGIN (
	Id INT IDENTITY(0,1) PRIMARY KEY,
	Usuario INT NOT NULL,                        /*FK*/
	Fecha DATETIME NOT NULL DEFAULT GETDATE(),
	Estado BIT NOT NULL,
	Numero_De_Intento INT,
	CONSTRAINT Fk_Login_Usuario FOREIGN KEY (Usuario) REFERENCES COUNTER_LOGIC_CODING.USUARIO(Id)
);



-------------------------------------------------------------
--
--
--
--        Migraciones
--
-- 
--
------------------------------------------------------------
--   Migracion de Pais
-- ---------------------------------------------------------

SET IDENTITY_INSERT COUNTER_LOGIC_CODING.PAIS ON
INSERT INTO COUNTER_LOGIC_CODING.PAIS (Id, Descripcion)
(
	SELECT Cuenta_Pais_Codigo, Cuenta_Pais_Desc
	FROM GD1C2015.gd_esquema.Maestra 
	UNION (SELECT Cli_Pais_Codigo,Cli_Pais_Desc FROM GD1C2015.gd_esquema.Maestra)
);
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.PAIS OFF

------------------------------------------------------------
--   Migracion de Tipo_Documento
-- ---------------------------------------------------------
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.TIPO_DOCUMENTO ON
INSERT INTO COUNTER_LOGIC_CODING.TIPO_DOCUMENTO(Id,Descripcion) 
SELECT DISTINCT Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc FROM gd_esquema.Maestra;
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.TIPO_DOCUMENTO OFF

------------------------------------------------------------
--   Creacion de Moneda
-- ---------------------------------------------------------

INSERT INTO COUNTER_LOGIC_CODING.MONEDA (Descripcion) VALUES ('Dolares');

------------------------------------------------------------
--   Creacion de Estados_Cuenta
-- ---------------------------------------------------------
INSERT INTO COUNTER_LOGIC_CODING.ESTADOS_CUENTA (descripcion) VALUES ('Habilitada'), ('Deshabilitada'), ('Pendiente de Activacion')
																	 ,('Cerrada')
------------------------------------------------------------
--   Migracion Emisores
-- ---------------------------------------------------------
INSERT INTO COUNTER_LOGIC_CODING.EMISOR(descripcion)
SELECT DISTINCT Tarjeta_Emisor_Descripcion FROM gd_esquema.Maestra WHERE Tarjeta_Emisor_Descripcion IS NOT NULL;

------------------------------------------------------------
--   Creacion de Tipo_Cuenta
-- ---------------------------------------------------------

INSERT INTO COUNTER_LOGIC_CODING.TIPO_CUENTA(Descripcion,Duracion,Costo_Subscripcion,Costo_Transferencia_A_Terceros)
					VALUES ('Gratuita',null,0,0),
						   ('Bronce',30,150,100),
						   ('Plata',60,350,60),
						   ('Oro',60,550,30);

------------------------------------------------------------
--   Creacion de Rol
-- ---------------------------------------------------------

INSERT INTO COUNTER_LOGIC_CODING.ROL(Descripcion) VALUES ('Administrador'), ('Cliente');

------------------------------------------------------------
--   Migracion de Banco
-- ---------------------------------------------------------

SET IDENTITY_INSERT COUNTER_LOGIC_CODING.BANCO ON
INSERT INTO COUNTER_LOGIC_CODING.BANCO(Id,Nombre,Direccion)
(
	SELECT DISTINCT Banco_Cogido,Banco_Nombre,Banco_Direccion
	FROM GD1C2015.gd_esquema.Maestra 
	WHERE Banco_Cogido IS NOT NULL AND Banco_Nombre IS NOT NULL AND Banco_Direccion IS NOT NULL AND NOT (Banco_Cogido = 10004)
);
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.BANCO OFF


INSERT INTO COUNTER_LOGIC_CODING.INCONSISTENCIAS(Codigo_Banco,Nombre_Banco,Direccion_Banco)
(
	SELECT DISTINCT Banco_Cogido,Banco_Nombre,Banco_Direccion
	FROM GD1C2015.gd_esquema.Maestra
	WHERE Banco_Cogido IS NOT NULL AND Banco_Nombre IS NOT NULL AND Banco_Direccion IS NOT NULL AND Banco_Cogido = 10004
);

------------------------------------------------------------
--   Migracion de Usuarios
-- ---------------------------------------------------------

INSERT INTO COUNTER_LOGIC_CODING.USUARIO(Username,Fecha_Creacion,Fecha_Ultima_Modificacion,Pregunta_Secreta,Respuesta_Secreta,Contrasenia,Estado,Intentos_Login) 
( SELECT  DISTINCT Cli_Nombre + Cli_Apellido,Cuenta_Fecha_Creacion,Cuenta_Fecha_Creacion,'',convert(varbinary(32),'5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),convert(varbinary(32),'5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),1,0 FROM gd_esquema.Maestra);

INSERT INTO COUNTER_LOGIC_CODING.ROL_X_USUARIO(Rol,Usuario) SELECT 1,Id FROM COUNTER_LOGIC_CODING.USUARIO

------------------------------------------------------------
--   Migracion de Cliente
-- ---------------------------------------------------------

INSERT INTO COUNTER_LOGIC_CODING.CLIENTE(Usuario,Nombre,Apellido,Pais,Mail,Fecha_nac,Dom_Calle,Dom_Nro,Dom_Depto,Dom_Piso,Tipo_Documento,Nro_Doc,Nacionalidad)
(SELECT DISTINCT (SELECT Id FROM COUNTER_LOGIC_CODING.USUARIO WHERE Username = (Cli_Nombre + Cli_Apellido)),Cli_Nombre,Cli_Apellido,Cli_Pais_Codigo,Cli_Mail,Cli_Fecha_Nac,Cli_Dom_Calle,Cli_Dom_Nro,Cli_Dom_Depto,Cli_Dom_Piso,Cli_Tipo_Doc_Cod,Cli_Nro_Doc,
					Cli_Pais_Codigo FROM gd_esquema.Maestra);

------------------------------------------------------------
--   Migracion de Tarjeta
-- ---------------------------------------------------------

INSERT INTO COUNTER_LOGIC_CODING.TARJETA(Numero,Banco_Emisor,Cliente,Fecha_Emision,Fecha_Vencimiento,Codigo_Seguridad,Ultimos_Digitos,Titular)
	   SELECT DISTINCT HashBytes('MD5',replicate('0',16 - len(Tarjeta_Numero)) + Tarjeta_Numero),(SELECT id FROM COUNTER_LOGIC_CODING.EMISOR WHERE descripcion = Tarjeta_Emisor_Descripcion ),
	   (SELECT cli.Id FROM COUNTER_LOGIC_CODING.CLIENTE cli WHERE Nro_Doc = Cli_Nro_Doc AND Tipo_Documento = (SELECT Id FROM COUNTER_LOGIC_CODING.TIPO_DOCUMENTO WHERE Descripcion = 'Pasaporte')),
		  Tarjeta_Fecha_Emision,Tarjeta_Fecha_Vencimiento,HashBytes('MD5',Tarjeta_Codigo_Seg), RIGHT(Tarjeta_Numero,4),Cli_Nombre + '' + Cli_Apellido	 FROM gd_esquema.Maestra 
			WHERE Tarjeta_Numero IS NOT NULL

------------------------------------------------------------
--   Migracion de Cuenta. Primero pone como DEFAULT a todas como habilitadas, luego hace un update para ver su estado REAL
-- ---------------------------------------------------------

SET IDENTITY_INSERT COUNTER_LOGIC_CODING.CUENTA ON --Fecha de expiracion en null significa cuenta gratuita
INSERT INTO COUNTER_LOGIC_CODING.CUENTA(Id,Tipo_Cuenta,Moneda,Pais,Cliente,Fecha_Creacion,Fecha_Cierre,Estado,Saldo)
(
SELECT DISTINCT Cuenta_Numero,0,0,
(SELECT Id FROM COUNTER_LOGIC_CODING.PAIS WHERE Id = Cuenta_Pais_Codigo AND Descripcion = Cuenta_Pais_Desc),
(SELECT id FROM COUNTER_LOGIC_CODING.CLIENTE WHERE
	    Tipo_Documento = Cli_Tipo_Doc_Cod AND Nro_Doc = Cli_Nro_Doc	) ,Cuenta_Fecha_Creacion,Cuenta_Fecha_Cierre,1,1 FROM gd_esquema.Maestra)

SET IDENTITY_INSERT COUNTER_LOGIC_CODING.CUENTA OFF
				
------------------------------------------------------------
--   Migracion de Cheques
-- ---------------------------------------------------------
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.CHEQUE ON
INSERT INTO COUNTER_LOGIC_CODING.CHEQUE(Id,Banco,Cliente)
	SELECT Cheque_Numero,case Banco_Cogido when 10004 then 10003 else Banco_Cogido END,(
				SELECT id FROM COUNTER_LOGIC_CODING.CLIENTE WHERE Tipo_Documento = Cli_Tipo_Doc_Cod AND Nro_Doc = Cli_Nro_Doc)
			FROM gd_esquema.Maestra WHERE Cheque_Numero IS NOT NULL AND Cheque_Importe > 0				  
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.CHEQUE OFF

------------------------------------------------------------
-- Migracion de datos inconsistentes de Retiros y cheques a inconsistencias
------------------------------------------------------------

INSERT INTO COUNTER_LOGIC_CODING.INCONSISTENCIAS(Cheque_Numero,Cheque_Importe,Cheque_Fecha,Retiro_Codigo,Retiro_Fecha,Retiro_Importe)
	SELECT Cheque_Numero,Cheque_Importe,Cheque_Fecha,Retiro_Codigo,Retiro_Fecha,Retiro_Importe FROM gd_esquema.Maestra WHERE Retiro_Codigo IS NOT NULL AND Retiro_Importe <= 0


-------------------------------------------------------------
-- Migracion de Operaciones pre-existentes (DEPO,RET,TRAN)
-------------------------------------------------------------

--Retiros
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.OPERACION ON
INSERT INTO COUNTER_LOGIC_CODING.OPERACION(Id,Cuenta,Moneda,Fecha,Importe)
		SELECT DISTINCT Retiro_Codigo,Cuenta_Numero,0,Retiro_Fecha,Retiro_Importe FROM gd_esquema.Maestra WHERE Retiro_Codigo IS NOT NULL AND Retiro_Importe > 0
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.OPERACION OFF


INSERT INTO COUNTER_LOGIC_CODING.RETIRO(Id,cheque)
	SELECT Id,Cheque_Numero FROM gd_esquema.Maestra,COUNTER_LOGIC_CODING.OPERACION WHERE Retiro_Codigo = Id

--Depositos
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.OPERACION ON
INSERT INTO COUNTER_LOGIC_CODING.OPERACION(Id,Cuenta,Moneda,Fecha,Importe)
		SELECT DISTINCT Deposito_Codigo,Cuenta_Numero,0,Deposito_Fecha,Deposito_Importe FROM gd_esquema.Maestra WHERE Deposito_Codigo IS NOT NULL
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.OPERACION OFF


INSERT INTO COUNTER_LOGIC_CODING.DEPOSITO(Id,Tarjeta)
		SELECT Id,
			(SELECT id FROM COUNTER_LOGIC_CODING.TARJETA WHERE Numero = HashBytes('MD5',replicate('0',16 - len(Tarjeta_Numero)) + Tarjeta_Numero)) FROM COUNTER_LOGIC_CODING.OPERACION,gd_esquema.Maestra
					WHERE Deposito_Codigo = Id

--Transferencias

CREATE TABLE COUNTER_LOGIC_CODING.#generadora_id_transferencia(
	Operacion NUMERIC(18,0) IDENTITY(1,1),
	Cuenta_origen NUMERIC(18,0),
	Moneda INT,
	Fecha DATETIME,
	Importe REAL,
	Cuenta_destino NUMERIC(18,0),
	Costo REAL,
	nro_fac NUMERIC(18,0),
	factura_Fecha DATETIME,
	item_desc VARCHAR(150))
	
INSERT INTO COUNTER_LOGIC_CODING.#generadora_id_transferencia(Cuenta_origen,Moneda,Fecha,Importe,Cuenta_destino,Costo,nro_fac,factura_Fecha,item_desc)
	SELECT DISTINCT Cuenta_Numero,0,Transf_Fecha,Trans_Importe,Cuenta_Dest_Numero,Item_Factura_Importe,Factura_Numero,Factura_Fecha,Item_Factura_Descr FROM gd_esquema.Maestra
							WHERE Factura_Numero IS NOT NULL AND Trans_Importe IS NOT NULL

SET IDENTITY_INSERT COUNTER_LOGIC_CODING.OPERACION ON
INSERT INTO COUNTER_LOGIC_CODING.OPERACION(Id,Cuenta,Importe,Moneda,Fecha)
	SELECT Operacion,Cuenta_origen,Importe,0,Fecha FROM COUNTER_LOGIC_CODING.#generadora_id_transferencia
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.OPERACION OFF

INSERT INTO COUNTER_LOGIC_CODING.TRANSFERENCIA(Id,Cuenta_destino,Costo)
	SELECT Operacion,Cuenta_destino,Costo FROM COUNTER_LOGIC_CODING.#generadora_id_transferencia

------------------------------------------------------------
-- Migracion de Facturas e Items -- Salen a partir de la anterior tabla temporal
------------------------------------------------------------

SET IDENTITY_INSERT COUNTER_LOGIC_CODING.FACTURA ON
INSERT INTO COUNTER_LOGIC_CODING.FACTURA(Id,Fecha,Cliente)
	SELECT DISTINCT Factura_Numero,factura_Fecha,(SELECT id FROM COUNTER_LOGIC_CODING.CLIENTE WHERE Tipo_Documento = Cli_Tipo_Doc_Cod AND Nro_Doc = Cli_Nro_Doc) FROM gd_esquema.Maestra WHERE Factura_Numero IS NOT NULL
SET IDENTITY_INSERT COUNTER_LOGIC_CODING.FACTURA OFF;

INSERT INTO COUNTER_LOGIC_CODING.COMISION(Cuenta,Descripcion,Factura,Monto,Operacion,Tipo_Cuenta)
	SELECT Cuenta_origen,item_desc,nro_fac,Importe,Operacion,0 FROM COUNTER_LOGIC_CODING.#generadora_id_transferencia


DROP TABLE COUNTER_LOGIC_CODING.#generadora_id_transferencia
------------------------------------------------------------
-- Update de Cuentas: habilitadas e inhabilitadas y saldo
------------------------------------------------------------

UPDATE COUNTER_LOGIC_CODING.CUENTA
SET Saldo = (SELECT ISNULL(SUM(a.Deposito_Importe),0) - ISNULL(SUM(a.Retiro_Importe),0) + ISNULL(SUM(b.Trans_Importe),0) - ISNULL(SUM(a.Trans_Importe),0)
FROM gd_esquema.Maestra a ,gd_esquema.Maestra b
WHERE Id = a.Cuenta_Numero AND Id = b.Cuenta_Numero AND b.Cuenta_Dest_Numero = a.Cuenta_Numero)

------------------------------------------------------------
--
--
--		Creacion de administrador
--
-- 
------------------------------------------------------------

INSERT INTO COUNTER_LOGIC_CODING.FUNCIONALIdAD(Descripcion) 
	VALUES ('ABM Rol'),('ABM Usuario'),('ABM Cliente'), ('ABM Cuenta'), ('Depositar'), ('Retirar'), ('Transferir'), ('Facturar'), ('Consultar Saldo'),('ListadosEstadisticos'), ('Asociar/Desasociar Tarjetas')

INSERT INTO COUNTER_LOGIC_CODING.USUARIO(Username,Contrasenia,Fecha_Creacion,Fecha_Ultima_Modificacion,Pregunta_Secreta,Respuesta_Secreta,Estado) --La respuesta es 'bien'
			VALUES('admin',CONVERT(varbinary(32),'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),GETDATE(),GETDATE(),'hola que tal?',CONVERT(varbinary(32),'48b3f8392fb766ae5aa762acd11fd9d1ad1ac82a5f54ca5fb70fe4aa71dc6ba1'),1)

INSERT INTO COUNTER_LOGIC_CODING.ROL_X_USUARIO(Usuario,Rol) 
	SELECT Id,0 FROM COUNTER_LOGIC_CODING.USUARIO WHERE Username = 'admin'
 

INSERT INTO COUNTER_LOGIC_CODING.FUNCIONALIDAD_X_ROL(Rol,Funcionalidad) 
		VALUES(0,0), (0,1), (0,2), (0,3), (0,4), (0,5), (0,6), (0,7), (0,8) ,(0,9), (0,10),
				  (1,10), (1,4), (1,5), (1,6), (1,7), (1,8), (1,3)
			
-------------------------------------------------------------
--
--
--
--        Creacion de Procedures
--
-- 
--
------------------------------------------------------------

GO
------------------------------------------------------------
-- Datos para parsear usuario en función del nombre de usuario
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.getUsuario(@username VARCHAR(255)) as
BEGIN
	SELECT Id,Username,Estado,Intentos_Login FROM COUNTER_LOGIC_CODING.USUARIO WHERE Username = @username
END

GO
------------------------------------------------------------
-- Funcionalidad a partir del Id del rol
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.funcionalidadDeRol(@rolId INT) as
BEGIN
	SELECT f.Id,f.Descripcion FROM COUNTER_LOGIC_CODING.FUNCIONALIdAD_X_ROL fxr, COUNTER_LOGIC_CODING.FUNCIONALIdAD f
			WHERE f.Id = fxr.Funcionalidad
			AND @rolId = fxr.Rol
END

GO

------------------------------------------------------------
-- Datos para parsear todas las funcionalidades
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.funcionalidades as
BEGIN
SELECT f.Id,f.Descripcion from COUNTER_LOGIC_CODING.FUNCIONALIDAD as f
END

GO

------------------------------------------------------------
-- Datos para parsear roles dado su Id
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.getRolesById(@userId INT) as
BEGIN
SELECT r.Id,r.Descripcion,r.Estado FROM COUNTER_LOGIC_CODING.ROL r, COUNTER_LOGIC_CODING.ROL_X_USUARIO rxu
			WHERE r.Id = rxu.Rol
			AND rxu.Usuario = @userId
END

GO

------------------------------------------------------------
-- Actualiza intentos de login
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.actualizarIntentos(@username VARCHAR(255),@Cantidad INT) as
BEGIN
if @Cantidad = 0 BEGIN
		declare @IntentosActuales INT
		update COUNTER_LOGIC_CODING.USUARIO SET Intentos_Login = Intentos_Login + 1 WHERE Username = @username
		SELECT @IntentosActuales = Intentos_Login FROM COUNTER_LOGIC_CODING.USUARIO WHERE Username = @username
		if (@IntentosActuales) >= 3 BEGIN	
			update COUNTER_LOGIC_CODING.USUARIO SET Estado = 0 WHERE Username = @username
		END
		INSERT INTO COUNTER_LOGIC_CODING.LOG_LOGIN(Usuario,Estado,Numero_De_Intento)
					VALUES((SELECT Id FROM COUNTER_LOGIC_CODING.USUARIO WHERE Username = @username)
						   ,0,@IntentosActuales)
	END
else
	BEGIN
	update COUNTER_LOGIC_CODING.USUARIO SET Intentos_Login = 0 WHERE Username = @username
	INSERT INTO COUNTER_LOGIC_CODING.LOG_LOGIN(Usuario,Estado)
				VALUES((SELECT Id FROM COUNTER_LOGIC_CODING.USUARIO WHERE Username = @username),
						1)
	END
END

GO

------------------------------------------------------------
-- Log IN
------------------------------------------------------------

CREATE PROCEDURE COUNTER_LOGIC_CODING.validar_login(@username VARCHAR(255),@password VARCHAR(255)) as
BEGIN
declare @HASH_PASS varbinary(32), @Cantidad INT
SET @HASH_PASS = CONVERT(VARBINARY(32), @PASSWORD)
	SELECT @Cantidad = COUNT(Username) FROM COUNTER_LOGIC_CODING.USUARIO
	WHERE Estado = 1 AND
		  USERNAME = @username AND
		  Contrasenia = @HASH_PASS
	exec COUNTER_LOGIC_CODING.actualizarIntentos @username,@Cantidad
	RETURN @Cantidad
END

GO

------------------------------------------------------------
-- Valida Pregunta
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.validar_pregunta(@username VARCHAR(255),@respuesta VARCHAR(255)) as
BEGIN
declare @HASH_PASS varbinary(32), @Cantidad INT
SET @HASH_PASS = CONVERT(VARBINARY(32), @respuesta)
SELECT @Cantidad = COUNT(Username) FROM COUNTER_LOGIC_CODING.USUARIO WHERE Estado = 1 AND
					Username = @username AND
					Respuesta_Secreta = @HASH_PASS
exec COUNTER_LOGIC_CODING.actualizarIntentos @username,@Cantidad
return @Cantidad
END

GO

------------------------------------------------------------
-- Pregunta secreta dado el nombre del usuario
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getPreguntaUsuario(@username VARCHAR(255)) as BEGIN
SELECT Pregunta_Secreta FROM COUNTER_LOGIC_CODING.USUARIO WHERE @username = Username
END

GO

------------------------------------------------------------
-- Setea Password
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.setPassword(@username VARCHAR(255), @password VARCHAR(255)) as BEGIN
declare @hash varbinary(32)
SET @hash = CONVERT(varbinary(32),@password)
update COUNTER_LOGIC_CODING.USUARIO SET Contrasenia = @hash WHERE Username = @username
END

GO

------------------------------------------------------------
-- Devuelve estado de un cliente 
------------------------------------------------------------
CREATE FUNCTION COUNTER_LOGIC_CODING.calcularEstadoCliente(@ID int) returns bit as BEGIN
RETURN (SELECT Count(*) FROM COUNTER_LOGIC_CODING.CLIENTE cli,COUNTER_LOGIC_CODING.ROL_X_USUARIO rxu
					where cli.ID = @ID and rxu.Rol = 1 and rxu.Usuario = cli.Usuario)
END

GO

------------------------------------------------------------
-- Datos para parsear a todos los clientes
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getClientes as BEGIN
	SELECT*,COUNTER_LOGIC_CODING.calcularEstadoCliente(ID) as 'Estado' from COUNTER_LOGIC_CODING.CLIENTE;
END

		
GO

------------------------------------------------------------
-- Datos para parsear un cliente. Parametros variables
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.find_clientes(@Nombre varchar(255) = null,@Apellido varchar(255) = null,@Tipo_Doc int,@Mail varchar(255) = null,@Nro_Doc int = null) 
AS
BEGIN
	SELECT * , COUNTER_LOGIC_CODING.calcularEstadoCliente(ID) as 'Estado' from COUNTER_LOGIC_CODING.CLIENTE where
				(Nombre like '%' + @Nombre + '%' or @Nombre is null) and
				(Apellido like '%' + @Apellido + '%' or @Apellido is null) and
				(Mail like '%' + @Mail + '%' or @Mail is null) and
				(Tipo_Documento = @Tipo_Doc or @Tipo_Doc = -1) and
				(CONVERT(varchar(255),Nro_Doc) like  '%' + CONVERT(varchar(255),@Nro_Doc) + '%' or @Nro_Doc is null)
				
END

GO

------------------------------------------------------------
-- Datos para parsear a un país en función de su id
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getPais(@id int = null) as BEGIN
SELECT* from COUNTER_LOGIC_CODING.PAIS where ID = @id or @id is null
END

GO

------------------------------------------------------------
-- Datos para parsear un documento en función de su id. Puede traerlos todos
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getTipoDoc(@id int = null) as BEGIN
SELECT* from COUNTER_LOGIC_CODING.TIPO_DOCUMENTO where (ID = @id or @id is null)
END

GO

------------------------------------------------------------
-- Datos para parsear un cliente en función de su id. Puede traerlos todos
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getCliente(@ID int = null) 
as BEGIN
	SELECT*,COUNTER_LOGIC_CODING.calcularEstadoCliente(ID) as 'Estado' from COUNTER_LOGIC_CODING.CLIENTE
					where ID = @ID or @ID is null
END

GO

------------------------------------------------------------
-- Da de baja un usuario
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.darDeBajaUsuario(@ID_U int) 
as BEGIN
	update COUNTER_LOGIC_CODING.USUARIO set Estado = 0 where ID = @ID_U
END	

GO

------------------------------------------------------------
-- Da de baja un cliente
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.darDeBajaCliente(@ID int) as BEGIN
	declare @U_ID int
	set @U_ID = (SELECT ID from COUNTER_LOGIC_CODING.USUARIO c where c.ID = @ID)
	delete from COUNTER_LOGIC_CODING.ROL_X_USUARIO where Usuario = @U_ID and Rol = 1
	declare @CantidadRoles int
	SELECT @CantidadRoles = COUNT(Rol) from COUNTER_LOGIC_CODING.ROL_X_USUARIO where Usuario = @U_ID group by Usuario
	if @CantidadRoles = 0
		exec COUNTER_LOGIC_CODING.darDeBajaUsuario @ID_U = @U_ID
END

GO

------------------------------------------------------------
-- Id del cliente dado los datos de su documento
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.COINCIDE_DOCUMENTO(@tipo int, @documento varchar(10)) as BEGIN
SELECT Id from COUNTER_LOGIC_CODING.CLIENTE where Tipo_Documento = @tipo and Nro_Doc = @documento
END

GO

------------------------------------------------------------
-- Tipo de una cuenta en función de su tipo
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getTipoCuenta (@IdTipoCuenta INT)
AS
BEGIN
	SELECT	*
	FROM COUNTER_LOGIC_CODING.TIPO_CUENTA TipoCuenta
	WHERE @IdTipoCuenta = TipoCuenta.Id
END

GO

------------------------------------------------------------
-- Datos para parsear todos los roles
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getRoles as BEGIN
	SELECT * from COUNTER_LOGIC_CODING.ROL
END

GO

------------------------------------------------------------
-- Da de alta un cliente
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.darDeAltaCliente(@cli_nombre varchar(255),@cli_appelido varchar(255),
														@cli_fechaNac datetime,@cli_mail varchar(255),
														@cli_pais int,@cli_doc_nro numeric(18,0),@cli_doc_tipo int, @cli_dom_calle varchar(255), @cli_dom_numero numeric(18,0),
														@cli_dom_Depto varchar(255), @cli_dom_piso int, @cli_dom_localidad varchar(255),
														@cli_nacionalidad int, @username varchar(255),@password varchar(255), @pregunta varchar(255),
														@respuesta varchar(255),@fecha_creacion datetime,@fecha_ultimaModif datetime)
as BEGIN

declare @HASH_PASS varbinary(32), @HASH_REP varbinary(32),@U_ID INT
set @HASH_PASS = CONVERT(varbinary(32),@password)
set @HASH_REP = CONVERT(varbinary(32),@respuesta)

INSERT INTO COUNTER_LOGIC_CODING.USUARIO(Username,Fecha_Creacion,Fecha_Ultima_Modificacion,Contrasenia,Pregunta_Secreta,Respuesta_Secreta,Intentos_Login,Estado)
	values(@username,@fecha_creacion,@fecha_ultimaModif,@HASH_PASS,@pregunta,@HASH_REP,0,1)

set @U_ID = SCOPE_IDENTITY()

insert into COUNTER_LOGIC_CODING.ROL_X_USUARIO(Usuario,Rol) values (@U_ID,1)


insert into COUNTER_LOGIC_CODING.CLIENTE(Nombre,Apellido,Fecha_nac,Nro_Doc,Tipo_Documento,Usuario,Mail,Dom_Calle,Dom_Nro,Dom_Piso,Dom_Depto,Nacionalidad,Localidad,Pais)
	values (@cli_nombre,@cli_appelido,@cli_fechaNac,@cli_doc_nro,@cli_doc_tipo,@U_ID,@cli_mail,@cli_dom_calle,@cli_dom_numero,@cli_dom_piso,@cli_dom_Depto,@cli_nacionalidad,@cli_dom_localidad,@cli_pais)

return SCOPE_IDENTITY()
END						

GO

------------------------------------------------------------
-- Modifica un cliente
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.modificarCliente(@cli_id int,@cli_nombre varchar(255),@cli_appelido varchar(255),
														@cli_fechaNac datetime,@cli_mail varchar(255),
														@cli_pais int,@cli_doc_nro numeric(18,0),@cli_doc_tipo int, @cli_dom_calle varchar(255), @cli_dom_numero numeric(18,0),
														@cli_dom_Depto varchar(255), @cli_dom_piso int, @cli_dom_localidad varchar(255),
														@cli_nacionalidad int,@cli_estado bit) as BEGIN


UPDATE COUNTER_LOGIC_CODING.CLIENTE SET
Nombre = @cli_nombre,
Apellido = @cli_appelido,
Fecha_nac = @cli_fechaNac,
Mail = @cli_mail,
Pais = @cli_pais,
Nro_Doc = @cli_doc_nro,
Tipo_Documento = @cli_doc_tipo,
Dom_Calle = @cli_dom_calle,
Dom_Depto = @cli_dom_Depto,
Dom_Piso = @cli_dom_piso,
Dom_Nro = @cli_dom_numero,
Localidad = @cli_dom_localidad,
Nacionalidad = @cli_nacionalidad 
		where ID = @cli_id			
		
BEGIN TRY
BEGIN TRAN actualizarEstado
	IF @cli_estado = 1
		INSERT INTO COUNTER_LOGIC_CODING.ROL_X_USUARIO(Rol,Usuario) values (1,(SELECT Usuario from COUNTER_LOGIC_CODING.CLIENTE c where c.ID = @cli_id))
	ELSE 
		exec COUNTER_LOGIC_CODING.darDeBajaCliente @ID = @cli_id
commit TRAN actualizarEstado
END try
BEGIN catch
	rollback tran actualizarEstado
END catch


END

GO
	
------------------------------------------------------------
-- Datos para parsear un estado dado su id
------------------------------------------------------------	
CREATE PROCEDURE COUNTER_LOGIC_CODING.getEstado (@IdEstado INT)
AS
BEGIN
	SELECT	*
	FROM COUNTER_LOGIC_CODING.ESTADOS_CUENTA Estado
	WHERE @IdEstado = Estado.Id
END

GO

------------------------------------------------------------
-- Datos para parsear un tipo de moneda en función de su id
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getMoneda (@IdMoneda INT)
AS
BEGIN
	SELECT	*
	FROM COUNTER_LOGIC_CODING.MONEDA Moneda
	WHERE @IdMoneda = Moneda.Id
END

GO

------------------------------------------------------------
-- Cuentas de un usuario por su id
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getCuentasByUserId (@IdUser INT)
AS
DECLARE @IdCliente INT
SET @IdCliente = (SELECT Cliente.Id 
			FROM COUNTER_LOGIC_CODING.CLIENTE Cliente
			WHERE @IdUser = Cliente.Usuario)
BEGIN
	SELECT	*
	FROM COUNTER_LOGIC_CODING.CUENTA Cuenta
	WHERE @IdCliente = Cuenta.Cliente
END

GO

------------------------------------------------------------
-- Cuentas de un cliente por su id
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getCuentasByClienteId (@IdCliente INT,@estado int = null)
AS
BEGIN
	SELECT	*
	FROM COUNTER_LOGIC_CODING.CUENTA Cuenta
	WHERE @IdCliente = Cuenta.Cliente and (Estado = @estado or @estado is null) 
END


GO

------------------------------------------------------------
-- Cuentas de un usuario por su id y el tipo de cuenta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getCuentasByUserIdAndType (@IdUser INT, @IdTipoCuenta INT)
AS
DECLARE @IdCliente INT
SET @IdCliente = (SELECT Cliente.Id 
			FROM COUNTER_LOGIC_CODING.CLIENTE Cliente
			WHERE @IdUser = Cliente.Id)
BEGIN
	SELECT	*
	FROM COUNTER_LOGIC_CODING.CUENTA Cuenta
	WHERE @IdCliente = Cuenta.Cliente AND Cuenta.Tipo_Cuenta = @IdTipoCuenta
END

GO

------------------------------------------------------------
-- Todos los tipos de cuentas
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getTiposCuentas
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.TIPO_CUENTA	
END
	
GO

------------------------------------------------------------
-- Todos los tipos de monedas
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getMonedas
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.MONEDA	
END

GO

------------------------------------------------------------
--Todos los paises
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getPaises
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.PAIS	
END

GO

------------------------------------------------------------
-- Alta de un rol
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.ABMROL_AltaRol (@NombreRol varchar(25))
AS
BEGIN
	INSERT INTO COUNTER_LOGIC_CODING.ROL (Descripcion,Estado)
		values (@NombreRol, 1)
	
	return SCOPE_IDENTITY()
END

GO

CREATE PROCEDURE COUNTER_LOGIC_CODING.ABMROL_AltaRolFuncionalidad (@IdRol int, @Funcionalidad int)
------------------------------------------------------------
-- Alta funcionalidad de un rol
------------------------------------------------------------
AS
BEGIN
	INSERT INTO COUNTER_LOGIC_CODING.FUNCIONALIDAD_X_ROL (Rol, Funcionalidad)
		values (@IdRol, @Funcionalidad)

END

GO

------------------------------------------------------------
-- Alta de cuenta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.darAltaCuenta (@IdUsuario NUMERIC(18,0) ,@IdPais NUMERIC(18,0), @FechaCreacion DATETIME,
														@IdMoneda NUMERIC(18,0), @IdTipoCuenta NUMERIC(18,0))
AS	
BEGIN
DECLARE @IdCliente NUMERIC(18,0) 
DECLARE @IdUltimaCuenta NUMERIC(18,0) 
DECLARE @IdUltimaOperacion NUMERIC(18,0) 
SET @IdCliente = (SELECT Cliente.Id 
			FROM COUNTER_LOGIC_CODING.CLIENTE Cliente
			WHERE @IdUsuario = Cliente.Usuario)
declare @duracion int
SELECT @duracion = Duracion from COUNTER_LOGIC_CODING.TIPO_CUENTA where Id = @IdTipoCuenta

INSERT INTO COUNTER_LOGIC_CODING.CUENTA(Tipo_Cuenta,Moneda,Pais,Cliente,Fecha_Creacion,Fecha_Cierre,Estado,Saldo,Fecha_Expiracion)
	VALUES (@IdTipoCuenta,@IdMoneda,@IdPais,
			@IdCliente,@FechaCreacion,NULL,(SELECT Estado.Id 
											FROM COUNTER_LOGIC_CODING.ESTADOS_CUENTA Estado 
											WHERE Estado.Descripcion = 'Pendiente de Activacion'),0,@FechaCreacion + @duracion)


SET @IdUltimaCuenta = SCOPE_IDENTITY()


	
INSERT INTO COUNTER_LOGIC_CODING.OPERACION
VALUES (@IdUltimaCuenta,@IdMoneda,@FechaCreacion,(SELECT Tipo.Costo_Subscripcion
												  FROM COUNTER_LOGIC_CODING.TIPO_CUENTA Tipo
												  WHERE Tipo.Id = @IdTipoCuenta))

SET @IdUltimaOperacion = SCOPE_IDENTITY()											  
												  
INSERT INTO COUNTER_LOGIC_CODING.APERTURA_CUENTA
VALUES (@IdUltimaOperacion,@IdUltimaCuenta,@IdTipoCuenta,@IdCliente)	
												  
INSERT INTO COUNTER_LOGIC_CODING.COMISION
VALUES (@IdUltimaCuenta,NULL,'Apertura de cuenta',@IdUltimaOperacion,@IdTipoCuenta, (SELECT Tipo.Costo_Subscripcion
												  FROM COUNTER_LOGIC_CODING.TIPO_CUENTA Tipo
												  WHERE Tipo.Id = @IdTipoCuenta))	
					
SELECT @IdUltimaCuenta	  
END

GO	

------------------------------------------------------------
-- Baja de una cuenta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.darBajaCuenta (@IdEstado NUMERIC(18,0), @FechaCierre DATETIME)
AS
BEGIN
	UPDATE COUNTER_LOGIC_CODING.CUENTA 
	SET Estado = (SELECT Estado.Id FROM COUNTER_LOGIC_CODING.ESTADOS_CUENTA Estado WHERE Estado.Descripcion = 'Cerrada'),
	Fecha_Cierre = @FechaCierre
	WHERE Id = @IdEstado
END

GO

------------------------------------------------------------
-- Cuentas habilitadas de un usuario
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getCuentasHabilitadasByUserID(@id int) AS
BEGIN
DECLARE @IdCliente INT
SET @IdCliente = (SELECT Cliente.Id 
			FROM COUNTER_LOGIC_CODING.CLIENTE Cliente
			WHERE @id = Cliente.Usuario)
SELECT * FROM COUNTER_LOGIC_CODING.CUENTA WHERE Cliente = @IdCliente AND Estado = 1 AND COUNTER_LOGIC_CODING.calcularEstadoCliente(@IdCliente) = 1
END

GO

------------------------------------------------------------
-- Todas las cuentas habilitadas
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getCuentasHabilitadas AS
BEGIN
SELECT * FROM COUNTER_LOGIC_CODING.CUENTA WHERE Estado = 1
END

GO

------------------------------------------------------------
--Datos para parsear una tarjeta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getTarjetas(@id int, @fechaSistema datetime = null,@estado int = null) AS
BEGIN
SELECT * FROM COUNTER_LOGIC_CODING.TARJETA t, COUNTER_LOGIC_CODING.CLIENTE c WHERE c.Usuario = @id and c.ID = t.Cliente and
												 (t.Fecha_Vencimiento >= @fechaSistema or @fechaSistema is null) and (@estado = Estado or @estado is null); 
END

GO

------------------------------------------------------------
-- Tarjetas de un cliente
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getTarjetaByCliente(@cli_id int) as BEGIN

SELECT * from COUNTER_LOGIC_CODING.TARJETA where @cli_id = Cliente

END

GO

------------------------------------------------------------
-- Datos de un banco por su Id
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getBanco(@ID int = null) as BEGIN
SELECT * from COUNTER_LOGIC_CODING.BANCO where Id = @ID or @ID is null
END

GO

------------------------------------------------------------
-- Calcula el periodo de vigencia de la cuenta
------------------------------------------------------------
CREATE FUNCTION COUNTER_LOGIC_CODING.calcularFechaExpiracion(@Expiracion datetime,@FechaSistema datetime, @Duracion int) returns datetime BEGIN

	IF @Expiracion > @FechaSistema	
			return @Expiracion + @Duracion
return @FechaSistema + @Duracion
END

GO

------------------------------------------------------------
-- Modifica una cuenta.
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.editCuenta (@IdCuenta NUMERIC(18,0),@IdMonedaVieja NUMERIC(18,0),@IdMonedaNueva NUMERIC(18,0),
@IdPaisViejo NUMERIC(18,0),@IdPaisNuevo NUMERIC(18,0),@IdTipoCuentaVieja NUMERIC(18,0) ,@IdTipoCuentaNueva NUMERIC(18,0),@FechaActual DATETIME)
AS
BEGIN
DECLARE @IdOperacion NUMERIC (18,0)
IF @IdMonedaNueva != @IdMonedaVieja
	BEGIN
		UPDATE COUNTER_LOGIC_CODING.CUENTA
		SET Moneda = @IdMonedaNueva
		WHERE Id = @IdCuenta
	END

IF @IdPaisNuevo != @IdPaisViejo
	BEGIN
		UPDATE COUNTER_LOGIC_CODING.CUENTA
		SET Pais = @IdPaisNuevo
		WHERE Id = @IdCuenta
	END

IF @IdTipoCuentaNueva != @IdTipoCuentaVieja
	BEGIN
		
		UPDATE COUNTER_LOGIC_CODING.CUENTA
		SET Tipo_Cuenta = @IdTipoCuentaNueva
		WHERE Id = @IdCuenta
		
		INSERT INTO COUNTER_LOGIC_CODING.OPERACION
		VALUES (@IdCuenta,(SELECT Cuenta.Moneda FROM COUNTER_LOGIC_CODING.CUENTA Cuenta WHERE Cuenta.Id = @IdCuenta),@FechaActual,(SELECT C.Costo_Subscripcion FROM COUNTER_LOGIC_CODING.TIPO_CUENTA C WHERE C.Id = @IdTipoCuentaNueva))
		
		SET @IdOperacion = SCOPE_IDENTITY()
		
		INSERT INTO COUNTER_LOGIC_CODING.CAMBIO_DE_TIPO_CUENTA
		VALUES (@IdOperacion,@IdCuenta,@IdTipoCuentaVieja,@IdTipoCuentaNueva,@FechaActual)
		
				
		INSERT INTO COUNTER_LOGIC_CODING.COMISION
		VALUES (@IdCuenta,NULL,'Cambio de tipo de cuenta',@IdOperacion,@IdTipoCuentaNueva,(SELECT C.Costo_Subscripcion FROM COUNTER_LOGIC_CODING.TIPO_CUENTA C WHERE C.Id = @IdTipoCuentaNueva))				
	
		
		
		IF @IdTipoCuentaNueva = 0
			BEGIN
				update COUNTER_LOGIC_CODING.CUENTA 
				SET Fecha_Expiracion = null 
				where Id = @IdCuenta
			END
		ELSE
			BEGIN
					DECLARE @Duracion INT
					SELECT @duracion = Duracion 
					from COUNTER_LOGIC_CODING.TIPO_CUENTA 
					where Id = @IdTipoCuentaNueva
					
					update COUNTER_LOGIC_CODING.CUENTA 
					set Fecha_Expiracion = COUNTER_LOGIC_CODING.calcularFechaExpiracion(Fecha_Expiracion,@FechaActual,@Duracion)
					where Id = @IdCuenta	
			END			
	
	END
END

GO

------------------------------------------------------------
-- Todas las cuentas
------------------------------------------------------------	
CREATE PROCEDURE COUNTER_LOGIC_CODING.getCuentas
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.CUENTA
END

GO

------------------------------------------------------------
-- Cuentas del cliente cuyo nombre es
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getCuentasClientNameLike (@NameLike VARCHAR(255))
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.CUENTA Cuenta
	WHERE Cuenta.Cliente IN(
	SELECT Cliente.ID	
	FROM COUNTER_LOGIC_CODING.CLIENTE Cliente	
	WHERE UPPER( Cliente.Nombre + ' ' + Cliente.Apellido ) like UPPER('%' + @NameLike + '%'))
END

GO

------------------------------------------------------------
-- Si tiene deudas
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.tieneDeudas (@IdCuenta NUMERIC(18,0))
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.COMISION Comision
	WHERE Comision.Cuenta = @IdCuenta AND Comision.Factura IS NULL 
	

END

GO

------------------------------------------------------------
-- Id de usuario en función de su nombre | Es para un filtro
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getIdUsuarioByClientName (@NyA VARCHAR(255))
AS
BEGIN
		SELECT Cliente.Usuario
		FROM COUNTER_LOGIC_CODING.CLIENTE Cliente
		WHERE Cliente.Nombre +' '+ Cliente.Apellido like @NyA
	

END

GO

------------------------------------------------------------
-- Todos los roles
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.ABMROL_getRoles AS
BEGIN
SELECT * from COUNTER_LOGIC_CODING.ROL
END

GO

CREATE PROCEDURE COUNTER_LOGIC_CODING.ABMROL_bajaRolFuncionalidad(@IdRol int, @Funcionalidad int) AS
begin
------------------------------------------------------------
-- Baja de una funcionalidad de un rol
------------------------------------------------------------
delete from COUNTER_LOGIC_CODING.FUNCIONALIDAD_X_ROL
where Rol = @IdRol and Funcionalidad = @Funcionalidad

END

GO

------------------------------------------------------------
-- Habilita rol
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.ABMROL_habilitarRol(@IdRol int) AS
BEGIN

update COUNTER_LOGIC_CODING.ROL set Estado = 1  where Id = @IdRol

END

GO

------------------------------------------------------------
-- Deshabilita rol
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.ABMROL_inhabilitarRol(@IdRol int) AS
BEGIN

update COUNTER_LOGIC_CODING.ROL set Estado = 0  where Id = @IdRol

END

GO

------------------------------------------------------------
-- Usuarios con cuentas  para recibir dinero
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.getUsuariosConCuentasActivas
AS
BEGIN
	SELECT DISTINCT Usuario.Id,Usuario.Username,Usuario.Fecha_Creacion,Usuario.Fecha_Ultima_Modificacion,
	Pregunta_Secreta,Usuario.Respuesta_Secreta,Usuario.Contrasenia,Usuario.Estado,Usuario.Intentos_Login
	FROM COUNTER_LOGIC_CODING.CUENTA Cuenta
	JOIN COUNTER_LOGIC_CODING.CLIENTE Cliente
	ON Cliente.ID = Cuenta.Cliente
	JOIN COUNTER_LOGIC_CODING.USUARIO Usuario
	ON Usuario.Id = Cliente.Usuario
	WHERE Cuenta.Estado NOT IN (3,4)
	ORDER BY Usuario.Username
END

GO

------------------------------------------------------------
-- Id de usuario en función su usuario
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.getUserIdByUsername( @UsernameLike VARCHAR(255))
AS
BEGIN
	SELECT Usuario.Id
	FROM COUNTER_LOGIC_CODING.USUARIO Usuario
	WHERE Usuario.Username like @UsernameLike
END

GO

------------------------------------------------------------
-- Cuenta dada su id
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.getCuentaById( @IdCuenta NUMERIC (18,0))
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.CUENTA Cuenta
	WHERE Cuenta.Id = @IdCuenta
END

GO

------------------------------------------------------------
-- Alta de una transferencia
------------------------------------------------------------
CREATE procedure COUNTER_LOGIC_CODING.altaTransferencia( @IdCuentaOrigen NUMERIC(18,0), @IdCuentaDestino NUMERIC(18,0), 
@IdMoneda NUMERIC(18,0) , @Monto REAL, @FechaTransaccion DATETIME,@CostoTransaccion NUMERIC (16,2))
AS

DECLARE @IdOperacion NUMERIC(18,0)
BEGIN
	INSERT INTO COUNTER_LOGIC_CODING.OPERACION
	VALUES(@IdCuentaOrigen,@IdMoneda,@FechaTransaccion,@Monto)

SET @IdOperacion = SCOPE_IDENTITY()

	INSERT INTO COUNTER_LOGIC_CODING.TRANSFERENCIA
	VALUES(@IdOperacion,@IdCuentaDestino,@CostoTransaccion)
	
	IF (@CostoTransaccion != 0)
	BEGIN
	INSERT INTO COUNTER_LOGIC_CODING.COMISION
	VALUES(@IdCuentaOrigen,NULL,'Transferencia de dinero',@IdOperacion,
	(SELECT Cuenta.Tipo_Cuenta FROM COUNTER_LOGIC_CODING.CUENTA Cuenta WHERE Cuenta.Id = @IdCuentaOrigen),@CostoTransaccion)
	END
	
	UPDATE COUNTER_LOGIC_CODING.Cuenta
	SET Saldo = Saldo - @Monto
	WHERE Id = @IdCuentaOrigen
	
	
	UPDATE COUNTER_LOGIC_CODING.Cuenta
	SET Saldo = Saldo + @Monto
	WHERE Id = @IdCuentaDestino
	
END

GO


------------------------------------------------------------
-- Cliente dado el id de usuario
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getClienteByUserId(@U_ID int) as BEGIN
	SELECT*, COUNTER_LOGIC_CODING.calcularEstadoCliente(ID) AS Estado from COUNTER_LOGIC_CODING.CLIENTE where Usuario = @U_ID
END

GO

------------------------------------------------------------
-- Emisor dado un Id. Puede traerlos todos
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getEmisor(@ID int = null) as BEGIN
	SELECT* from COUNTER_LOGIC_CODING.EMISOR where Id = @ID or @ID is null
END

GO

------------------------------------------------------------
-- Asocia una tarjeta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.asociarTarjeta(@cli_id int,@fecha_emision datetime, @fecha_vencimimento datetime,
													 @tarjeta_numero varchar(16),@ultimosDigitos varchar(4),@codSeg varchar(255),@emisor int, @titular varchar(255)) as BEGIN

insert into COUNTER_LOGIC_CODING.TARJETA(Cliente,Banco_Emisor,Fecha_Emision,Fecha_Vencimiento,Numero,Ultimos_Digitos,Codigo_Seguridad,Titular)
	values(@cli_id,@emisor,@fecha_emision,@fecha_vencimimento,HASHBYTES('MD5',@tarjeta_numero),@ultimosDigitos,HASHBYTES('MD5',@codSeg),@titular)													 									 

END

GO

------------------------------------------------------------
-- Verifica si el documento es el correspondiente del usuario
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.esDocumentoCorrectoParaElUsuarioLogeado(@NumeroDocumentoPosible NUMERIC (18,0),@IdTipoDocumentoPosible NUMERIC(18,0),
@IdUser NUMERIC (18,0))
AS
DECLARE @IdCliente NUMERIC(18,0)
SET @IdCliente = (SELECT Cliente.Id 
			FROM COUNTER_LOGIC_CODING.CLIENTE Cliente
			WHERE @IdUser = Cliente.Usuario)
BEGIN
		SELECT (CASE WHEN 
		((SELECT Cliente.Nro_Doc FROM COUNTER_LOGIC_CODING.Cliente Cliente WHERE Cliente.ID = @IdCliente) = @NumeroDocumentoPosible AND
		(SELECT Cliente.Tipo_Documento FROM COUNTER_LOGIC_CODING.Cliente Cliente WHERE Cliente.ID = @IdCliente) = @IdTipoDocumentoPosible)
		THEN 1 ELSE 0 END )
END
	
GO

------------------------------------------------------------
-- Realizar un retiro
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.altaRetiro( @IdCuenta NUMERIC(18,0), @IdMoneda NUMERIC(18,0), 
@IdBanco NUMERIC(18,0) , @Monto REAL, @FechaTransaccion DATETIME, @IdUser NUMERIC(18,0))
AS
DECLARE @IdOperacion NUMERIC(18,0)
DECLARE @IdCheque NUMERIC(18,0)
DECLARE @IdCliente NUMERIC(18,0)
SET @IdCliente = (SELECT Cliente.Id 
			FROM COUNTER_LOGIC_CODING.CLIENTE Cliente
			WHERE @IdUser = Cliente.Usuario)
BEGIN
	INSERT INTO COUNTER_LOGIC_CODING.OPERACION
	VALUES(@IdCuenta,@IdMoneda,@FechaTransaccion,@Monto)

SET @IdOperacion = SCOPE_IDENTITY()

	INSERT INTO COUNTER_LOGIC_CODING.CHEQUE
	VALUES(@IdBanco,@IdCliente)
	
SET @IdCheque = SCOPE_IDENTITY()

	INSERT INTO COUNTER_LOGIC_CODING.RETIRO
	VALUES(@IdOperacion,@IdCheque)
	
		
	UPDATE COUNTER_LOGIC_CODING.Cuenta
	SET Saldo = Saldo - @Monto
	WHERE Id = @IdCuenta
	
END

GO

------------------------------------------------------------
-- Modifica una tarjeta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.modificarTarjeta(@tj_id int,@tj_numero varchar(16),@tj_codigoSeguridad varchar(255),
													   @tj_ultimosDigitos varchar(4),@fechaEmision datetime,@fechaVencimiento datetime,
													   @titular varchar(255),@bancoEmisor int,@estado bit) as BEGIN

update COUNTER_LOGIC_CODING.TARJETA SET
Ultimos_Digitos = @tj_ultimosDigitos,
Titular = @titular,
Banco_Emisor = @bancoEmisor,
Estado = @estado,
Fecha_Emision = @fechaEmision,
Fecha_Vencimiento = @fechaVencimiento			
where id = @tj_id					

IF @tj_numero is not null BEGIN
	update COUNTER_LOGIC_CODING.TARJETA set
	Numero = HASHBYTES('MD5',@tj_numero) where id = @tj_id
END			   

IF @tj_codigoSeguridad is not null BEGIN
	update COUNTER_LOGIC_CODING.TARJETA set
	Codigo_Seguridad = HASHBYTES('MD5',@tj_codigoSeguridad) where id = @tj_id
END
												    
END

GO

------------------------------------------------------------
-- Saldo ultimos 5 depósitos
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimos5Depositos (@IdCuenta NUMERIC(18,0))
AS
BEGIN
SELECT top 5 oper.fecha as FECHA, oper.Importe as IMPORTE, mon.Descripcion as MONEDA, tar.Ultimos_Digitos as TARJETA
from COUNTER_LOGIC_CODING.OPERACION as oper, COUNTER_LOGIC_CODING.DEPOSITO as depo, COUNTER_LOGIC_CODING.MONEDA as mon, COUNTER_LOGIC_CODING.TARJETA AS tar
where oper.Id = depo.Id and 
	mon.Id = oper.Moneda and
	depo.Tarjeta = tar.id and
	oper.Cuenta = @IdCuenta

order by oper.Fecha desc
END

GO

------------------------------------------------------------
-- Saldo ultimos 5 retiros
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimos5Retiros (@IdCuenta NUMERIC(18,0))
AS
BEGIN
SELECT top 5 oper.fecha as FECHA, oper.Importe as IMPORTE, mon.Descripcion as MONEDA, che.id as CHEQUE
from COUNTER_LOGIC_CODING.OPERACION as oper, COUNTER_LOGIC_CODING.RETIRO as reti, COUNTER_LOGIC_CODING.MONEDA as mon, COUNTER_LOGIC_CODING.CHEQUE AS che
where oper.Id = reti.Id and 
	mon.Id = oper.Moneda and
	reti.Cheque = che.id and
	oper.Cuenta = @IdCuenta

order by oper.Fecha desc
END

GO

------------------------------------------------------------
-- Saldo ultimos 10 transferencias
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.Consulta_Saldos_Ultimas10Transferencias (@IdCuenta NUMERIC(18,0))
AS
BEGIN
SELECT top 10 oper.fecha as FECHA, oper.Importe as IMPORTE, mon.Descripcion as MONEDA, trans.Cuenta_Destino AS DESTINO
from COUNTER_LOGIC_CODING.OPERACION as oper, COUNTER_LOGIC_CODING.TRANSFERENCIA AS trans, COUNTER_LOGIC_CODING.MONEDA as mon
where oper.Id = trans.Id and 
	mon.Id = oper.Moneda and
	oper.Cuenta = @IdCuenta

order by oper.Fecha desc
END

GO

------------------------------------------------------------
-- Realizar un depósito
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.DEPOSITAR(@cuenta numeric(18,0),@tarjeta int,@importe float,@moneda int,@fecha datetime) AS
BEGIN
INSERT INTO COUNTER_LOGIC_CODING.OPERACION VALUES (@cuenta,@moneda,@fecha,@importe)
INSERT INTO COUNTER_LOGIC_CODING.DEPOSITO VALUES (SCOPE_IDENTITY(), @tarjeta)
UPDATE COUNTER_LOGIC_CODING.CUENTA SET Saldo = Saldo + @importe where Id = @cuenta
END

GO

------------------------------------------------------------
-- Comisiones de un cliente
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getComisionesById(@id int) AS
BEGIN
SELECT comision.Id AS ID, comision.Descripcion AS Descripcion, 
operacion.Fecha AS fecha, operacion.Cuenta AS cuenta, comision.Monto as Monto, cuentaTipo.Descripcion AS Tipo
FROM COUNTER_LOGIC_CODING.COMISION comision,COUNTER_LOGIC_CODING.OPERACION operacion,COUNTER_LOGIC_CODING.TIPO_CUENTA cuentaTipo,COUNTER_LOGIC_CODING.CUENTA cuenta
WHERE (comision.Operacion = operacion.Id) AND (comision.Tipo_Cuenta = cuentaTipo.Id) AND (cuenta.Id = operacion.Cuenta) AND (cuenta.Cliente = @id) AND (comision.Factura IS NULL)
END

GO

------------------------------------------------------------
-- Comisiones impagas de una cuenta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getComisionesImpagasFromCuenta(@cuenta numeric(18,0)) AS
BEGIN
SELECT Id FROM COUNTER_LOGIC_CODING.COMISION WHERE Cuenta = @cuenta AND Factura = NULL
END


GO

------------------------------------------------------------
-- Cantidad comisiones impagas
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.cantidadComisionesImpagas(@IdCuenta NUMERIC(18,0))
AS
BEGIN
	SELECT COUNT(*)
	FROM COUNTER_LOGIC_CODING.COMISION Comision
	WHERE Comision.Cuenta = @IdCuenta AND Comision.Factura IS NULL
END


GO

------------------------------------------------------------
-- Si una cuenta tiene deudas
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.tieneDeudasByID(@IdCuenta NUMERIC(18,0))
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.COMISION Comision
	WHERE Comision.Cuenta = @IdCuenta AND Comision.Factura IS NULL
END

GO

------------------------------------------------------------
-- Renueva una subscripción
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.renovarSubscripcion(@IdCuenta NUMERIC(18,0), @Fecha DATETIME)
AS
BEGIN

DECLARE @IdOperacion NUMERIC(18,0)

DECLARE @IdTipoCuenta NUMERIC(18,0)
SET @IdTipoCuenta = (SELECT TIPO_CUENTA FROM COUNTER_LOGIC_CODING.CUENTA WHERE Id = @IdCuenta)
DECLARE @IdMoneda NUMERIC(18,0)
SET @IdMoneda = (SELECT Moneda FROM COUNTER_LOGIC_CODING.CUENTA WHERE Id = @IdCuenta)
DECLARE @Importe REAL
SET @Importe = (SELECT TC.Costo_Subscripcion FROM COUNTER_LOGIC_CODING.TIPO_CUENTA TC WHERE TC.Id = @IdTipoCuenta)

INSERT INTO COUNTER_LOGIC_CODING.OPERACION
		VALUES (@IdCuenta,@IdMoneda,@Fecha,@Importe)
		
		SET @IdOperacion = SCOPE_IDENTITY()
		
		INSERT INTO COUNTER_LOGIC_CODING.CAMBIO_DE_TIPO_CUENTA
		VALUES (@IdOperacion,@IdCuenta,@IdTipoCuenta,@IdTipoCuenta,@Fecha)
		
				
		INSERT INTO COUNTER_LOGIC_CODING.COMISION
		VALUES (@IdCuenta,NULL,'Renovacion subscripcion',@IdOperacion,@IdTipoCuenta,@Importe)				
	
		DECLARE @Duracion INT
		SELECT @duracion = Duracion 
		from COUNTER_LOGIC_CODING.TIPO_CUENTA 
		where Id = @IdTipoCuenta
					
		update COUNTER_LOGIC_CODING.CUENTA 
		set Fecha_Expiracion = COUNTER_LOGIC_CODING.calcularFechaExpiracion(Fecha_Expiracion,@Fecha,@Duracion)
		where Id = @IdCuenta	
					
END

GO

------------------------------------------------------------
-- Edicion de una cuenta siendo administrador
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.editCuentaAdmin (@IdCuenta NUMERIC(18,0),@IdMonedaVieja NUMERIC(18,0),@IdMonedaNueva NUMERIC(18,0),
@IdPaisViejo NUMERIC(18,0),@IdPaisNuevo NUMERIC(18,0),@IdTipoCuentaVieja NUMERIC(18,0) ,@IdTipoCuentaNueva NUMERIC(18,0),@FechaActual DATETIME,@IdEstado NUMERIC(18,0))
AS
BEGIN
DECLARE @IdOperacion NUMERIC (18,0)

	UPDATE COUNTER_LOGIC_CODING.CUENTA
		SET Estado = @IdEstado
		WHERE Id = @IdCuenta

IF @IdMonedaNueva != @IdMonedaVieja
	BEGIN
		UPDATE COUNTER_LOGIC_CODING.CUENTA
		SET Moneda = @IdMonedaNueva
		WHERE Id = @IdCuenta
	END

IF @IdPaisNuevo != @IdPaisViejo
	BEGIN
		UPDATE COUNTER_LOGIC_CODING.CUENTA
		SET Pais = @IdPaisNuevo
		WHERE Id = @IdCuenta
	END

IF @IdTipoCuentaNueva != @IdTipoCuentaVieja
	BEGIN
		
		UPDATE COUNTER_LOGIC_CODING.CUENTA
		SET Tipo_Cuenta = @IdTipoCuentaNueva
		WHERE Id = @IdCuenta
		
		INSERT INTO COUNTER_LOGIC_CODING.OPERACION
		VALUES (@IdCuenta,(SELECT Cuenta.Moneda FROM COUNTER_LOGIC_CODING.CUENTA Cuenta WHERE Cuenta.Id = @IdCuenta),@FechaActual,(SELECT C.Costo_Subscripcion FROM COUNTER_LOGIC_CODING.TIPO_CUENTA C WHERE C.Id = @IdTipoCuentaNueva))
		
		SET @IdOperacion = SCOPE_IDENTITY()
		
		INSERT INTO COUNTER_LOGIC_CODING.CAMBIO_DE_TIPO_CUENTA
		VALUES (@IdOperacion,@IdCuenta,@IdTipoCuentaVieja,@IdTipoCuentaNueva,@FechaActual)
		
				
		INSERT INTO COUNTER_LOGIC_CODING.COMISION
		VALUES (@IdCuenta,NULL,'Cambio de tipo de cuenta',@IdOperacion,@IdTipoCuentaNueva,(SELECT C.Costo_Subscripcion FROM COUNTER_LOGIC_CODING.TIPO_CUENTA C WHERE C.Id = @IdTipoCuentaNueva))				
	
		
		
		IF @IdTipoCuentaNueva = 0
			BEGIN
				update COUNTER_LOGIC_CODING.CUENTA 
				SET Fecha_Expiracion = null 
				where Id = @IdCuenta
			END
		ELSE
			BEGIN
					DECLARE @Duracion INT
					SELECT @duracion = Duracion 
					from COUNTER_LOGIC_CODING.TIPO_CUENTA 
					where Id = @IdTipoCuentaNueva
					
					update COUNTER_LOGIC_CODING.CUENTA 
					set Fecha_Expiracion = COUNTER_LOGIC_CODING.calcularFechaExpiracion(Fecha_Expiracion,@FechaActual,@Duracion)
					where Id = @IdCuenta	
			END			
	
	END
END

GO

------------------------------------------------------------
-- Estados de cuenta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getEstados
AS
BEGIN
	SELECT *
	FROM COUNTER_LOGIC_CODING.ESTADOS_CUENTA	
END


GO
------------------------------------------------------------
-- Cambia el estado de una cuenta
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.cambiarEstadoCuenta(@cuenta numeric(18,0),@estado int) as BEGIN

declare @estadoPasado int
SELECT @estadoPasado = Estado from COUNTER_LOGIC_CODING.CUENTA where Id = @cuenta
if @estado != @estadoPasado BEGIN
	update COUNTER_LOGIC_CODING.CUENTA set Estado = @estado where Id = @cuenta
	return 1
	END
else 
BEGIN
	return 0
END
end
	

GO
------------------------------------------------------------
-- Facturas de un cliente
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.getFacturasCli(@cliente int = null) as begin

SELECT * FROM COUNTER_LOGIC_CODING.FACTURA where Cliente = @cliente or @cliente is null

END

GO
------------------------------------------------------------
-- Comisiones de una factura
------------------------------------------------------------
create procedure COUNTER_LOGIC_CODING.getComisionesFactura(@idFactura numeric(18,0)) as begin

	select * from COUNTER_LOGIC_CODING.COMISION where Factura = @idFactura

END

GO
------------------------------------------------------------
-- Factura en función de su id
------------------------------------------------------------
create procedure COUNTER_LOGIC_CODING.getFacturaById(@idFactura numeric(18,0)) as begin
	select * from COUNTER_LOGIC_CODING.FACTURA where @idFactura = Id
end

GO
------------------------------------------------------------
-- Nueva factura
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.crearFactura(@id int,@fecha DATETIME) AS
BEGIN
INSERT INTO COUNTER_LOGIC_CODING.FACTURA VALUES(@id,@fecha)
SELECT SCOPE_IDENTITY()
END

GO
------------------------------------------------------------
-- Nueva comision pagada
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.agregarComisionPagada(@factura numeric(18,0), @id int) AS
BEGIN
UPDATE COUNTER_LOGIC_CODING.COMISION SET Factura = @factura WHERE Factura IS NULL AND Id = @id
END

GO
------------------------------------------------------------
-- Listado estadístico 1 | Top inhabilitadas por exceso de comisión
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.CLIENTES_CON_CUENTAS_INHABILITADAS_POR_AUSENCIA_DE_PAGO(@FECHA_INICIO DATETIME, @FECHA_FIN DATETIME) 
AS
BEGIN
SELECT TOP 5 (SELECT C.Nombre + ' '+ C.Apellido FROM COUNTER_LOGIC_CODING.CLIENTE C WHERE C.ID = Cliente.ID) as Cliente, COUNT(IT.Id)as 'Cantidad de Inhabilitaciones'
        FROM COUNTER_LOGIC_CODING.INHABILITACION_TRANSACCION IT
        JOIN COUNTER_LOGIC_CODING.CUENTA Cuenta
        ON IT.Cuenta = Cuenta.Id
        JOIN COUNTER_LOGIC_CODING.CLIENTE Cliente
        ON Cliente.ID = Cuenta.Cliente
        WHERE IT.Fecha BETWEEN @FECHA_INICIO AND @FECHA_FIN
        GROUP BY Cliente.ID
        ORDER BY 'Cantidad de InHabilitaciones' DESC   
END

GO
------------------------------------------------------------
-- Listado estadístico 2 | Top comisiones facturadas
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.CLIENTES_CON_MAYOR_CANTIDAD_DE_COMISIONES(@FECHA_INICIO DATETIME, @FECHA_FIN DATETIME) 
AS
BEGIN
SELECT TOP 5 (SELECT C.Nombre + ' '+ C.Apellido FROM COUNTER_LOGIC_CODING.CLIENTE C WHERE C.ID = Cliente.ID) AS Cliente, COUNT (Comision.Id) AS 'Cantidad de Comisiones Facturadas'
		FROM COUNTER_LOGIC_CODING.FACTURA Facturas		--(SELECT * FROM COUNTER_LOGIC_CODING.FACTURA Factura WHERE Factura.Fecha BETWEEN @FECHA_INICIO AND @FECHA_FIN) as Facturas
		JOIN COUNTER_LOGIC_CODING.COMISION Comision
		ON Comision.Factura = Facturas.Id
		JOIN COUNTER_LOGIC_CODING.CLIENTE Cliente
		ON Cliente.ID = Facturas.Cliente
		WHERE Facturas.Fecha BETWEEN @FECHA_INICIO AND @FECHA_FIN
		GROUP BY Cliente.ID 
		ORDER BY 'Cantidad de Comisiones Facturadas' DESC		
	
END


GO

------------------------------------------------------------
-- Listado estadístico 3 | Top t
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.CLIENTES_CON_MAYOR_CANTIDAD_DE_TRANSACCIONES_ENTRE_CUENTAS_PROPIAS(@FECHA_INICIO DATETIME, @FECHA_FIN DATETIME) AS
BEGIN
SELECT TOP 5 (SELECT C.Nombre + ' '+ C.Apellido FROM COUNTER_LOGIC_CODING.CLIENTE C WHERE C.ID = Cliente1.ID) as Cliente, COUNT(T.Id) AS 'Cantidad de transferencias'
        FROM COUNTER_LOGIC_CODING.TRANSFERENCIA T
        JOIN COUNTER_LOGIC_CODING.CUENTA Cuenta1
        ON Cuenta1.Id = T.Cuenta_Destino
        JOIN COUNTER_LOGIC_CODING.CLIENTE Cliente1
        ON Cliente1.ID = Cuenta1.Cliente
        JOIN COUNTER_LOGIC_CODING.OPERACION Op
        ON Op.Id = T.Id
        JOIN COUNTER_LOGIC_CODING.CUENTA Cuenta2
        ON Cuenta2.Id = Op.Cuenta
        JOIN COUNTER_LOGIC_CODING.CLIENTE Cliente2
        ON Cliente2.ID = Cuenta2.Cliente
        WHERE Cliente1.ID = Cliente2.ID
        AND Op.Fecha BETWEEN @FECHA_INICIO AND @FECHA_FIN
        GROUP BY Cliente1.Id
        ORDER BY 'Cantidad de transferencias' DESC
END
GO


------------------------------------------------------------
-- Crea una deshabilitación por exceso de comisión
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.registrarInhabilitacion(@IdCuenta NUMERIC(18,0), @Fecha DATETIME)
AS
BEGIN
	INSERT INTO COUNTER_LOGIC_CODING.INHABILITACION_TRANSACCION
	VALUES(@IdCuenta,@Fecha)
END
go

------------------------------------------------------------
-- Listado estadístico 4 | Top paises cantidad de movimientos
------------------------------------------------------------

CREATE PROCEDURE COUNTER_LOGIC_CODING.PAISES_CON_MAYOR_CANTIDAD_DE_MOVIMIENTOS(@FECHA_INICIO DATETIME, @FECHA_FIN DATETIME) AS
BEGIN
SELECT TOP 5 P.descripcion as Pais, count (T.ID) as 'Cantidad de Movimientos'
FROM COUNTER_LOGIC_CODING.PAIS as P,
	 COUNTER_LOGIC_CODING.CUENTA AS C,
	 COUNTER_LOGIC_CODING.TRANSFERENCIA AS T,
	 COUNTER_LOGIC_CODING.OPERACION AS O
WHERE
	T.ID = O.ID and
	(O.Cuenta = C.Id or 
	 T.Cuenta_Destino = C.Id)and
	 P.Id = C.Pais and
	 O.FECHA BETWEEN @FECHA_INICIO AND @FECHA_FIN
GROUP BY P.Id, P.Descripcion
ORDER BY COUNT(T.Id) DESC
END

GO

------------------------------------------------------------
-- Listado estadístico 1 | Total facturado por tipo de cuenta
------------------------------------------------------------

CREATE PROCEDURE COUNTER_LOGIC_CODING.TOTAL_FACTURADO_PARA_DISTINTOS_TIPOS_DE_CUENTAS(@FECHA_INICIO DATETIME, @FECHA_FIN DATETIME) AS
BEGIN
SELECT top 5 tipo.Descripcion as 'Tipo de Cuenta', sum(comision.monto) as 'Monto Facturado'
FROM COUNTER_LOGIC_CODING.COMISION as comision,
	 COUNTER_LOGIC_CODING.TIPO_CUENTA as tipo,
	 COUNTER_LOGIC_CODING.FACTURA as fact
WHERE comision.tipo_cuenta = tipo.id and
	fact.Id = comision.factura and
	fact.Fecha BETWEEN @FECHA_INICIO AND @FECHA_FIN
GROUP BY tipo.Descripcion
ORDER BY 'Monto Facturado' DESC
END


GO

------------------------------------------------------------
-- Devuelve si hay tarjetas con el mismo numeros
------------------------------------------------------------
CREATE PROCEDURE COUNTER_LOGIC_CODING.coincideTarjeta(@NumeroTarjeta VARCHAR(16)) 
AS
BEGIN
DECLARE @NumeroHasheado VARBINARY(250)
SET @NumeroHasheado = HASHBYTES('MD5', @NumeroTarjeta)
	SELECT *
	FROM COUNTER_LOGIC_CODING.TARJETA Tarjeta
	WHERE Tarjeta.Numero = @NumeroHasheado
END

GO


