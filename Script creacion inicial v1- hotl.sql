--Me conecto a la base de datos a usar
USE [GD1C2018]
GO
----------------------------------------------------------------------------------------------
								/** CREACION DE SCHEMA **/
----------------------------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'pero_compila')
BEGIN
    EXEC ('CREATE SCHEMA pero_compila AUTHORIZATION gdHotel2018')
END
GO


----------------------------------------------------------------------------------------------
								/** FIN CREACION DE SCHEMA**/
----------------------------------------------------------------------------------------------



----------------------------------------------------------------------------------------------
								/** VALIDACION DE TABLAS **/
----------------------------------------------------------------------------------------------
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.FuncionalidadXRol'))
    DROP TABLE pero_compila.FuncionalidadXRol

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.RolXUsuario'))
    DROP TABLE pero_compila.RolXUsuario
        
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Funcionalidad'))
    DROP TABLE pero_compila.Funcionalidad

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Rol'))
    DROP TABLE pero_compila.Rol

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.UsuarioXHotel'))
    DROP TABLE pero_compila.UsuarioXHotel

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.HotelXRegimen'))
    DROP TABLE pero_compila.HotelXRegimen

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Regimen'))
    DROP TABLE pero_compila.Regimen
	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Usuario'))
    DROP TABLE pero_compila.Usuario
	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.EstadiaXConsumible'))
    DROP TABLE pero_compila.EstadiaXConsumible

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Factura'))
    DROP TABLE pero_compila.Factura

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Item'))
    DROP TABLE pero_compila.Item

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Consumible'))
    DROP TABLE pero_compila.Consumible

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.RegistroEstadia'))
    DROP TABLE pero_compila.RegistroEstadia
	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.ReservaXHabitacion'))
    DROP TABLE pero_compila.ReservaXHabitacion

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Reserva'))
    DROP TABLE pero_compila.Reserva

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Cliente'))
    DROP TABLE pero_compila.Cliente


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.HotelCerrado'))
    DROP TABLE pero_compila.HotelCerrado

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Hotel'))
    DROP TABLE pero_compila.Hotel

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.Habitacion'))
    DROP TABLE pero_compila.Habitacion

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.ConsumiblesXFactura'))
    DROP TABLE pero_compila.ConsumiblesXFactura

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.EstadiaXConsumible'))
    DROP TABLE pero_compila.EstadiaXConsumible

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'pero_compila.CancelarReserva'))
    DROP TABLE pero_compila.CancelarReserva




----------------------------------------------------------------------------------------------
							/** FIN VALIDACION DE TABLAS **/
----------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------
							/** VALIDACION DE PROCEDURES **/
----------------------------------------------------------------------------------------------


-- IF EXISTS (SELECT name FROM sysobjects WHERE name='registrarUsuario' AND type='p')
	-- DROP PROCEDURE [pero_compila].registrarUsuario
-- GO	
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='login' AND type='p')
	-- DROP PROCEDURE [pero_compila].login
-- GO

-- IF EXISTS (SELECT name FROM sysobjects WHERE name='[pero_compila].[sp_alta_solo_rol]')
	-- DROP PROCEDURE [pero_compila].[sp_alta_solo_rol]
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='pero_compila.sp_get_roles')
	-- DROP PROCEDURE pero_compila.sp_get_roles
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='pero_compila.sp_update_rol')
	-- DROP PROCEDURE pero_compila.sp_update_rol
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='pero_compila.sp_alta_rol')
	-- DROP PROCEDURE pero_compila.sp_alta_rol
-- GO

-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_clientes')
	-- DROP PROCEDURE pero_compila.sp_get_clientes
-- GO

-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_empresas')
	-- DROP PROCEDURE pero_compila.sp_get_empresas
-- GO

-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_items')
	-- DROP PROCEDURE pero_compila.sp_get_items
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_facturas')
	-- DROP PROCEDURE pero_compila.sp_get_facturas
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_usuarioXSucursal')
	-- DROP PROCEDURE pero_compila.sp_alta_usuarioXSucursal

-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_usuarioXRol')
	-- DROP PROCEDURE pero_compila.sp_alta_usuarioXRol

-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_funcionalidades')
	-- DROP PROCEDURE pero_compila.sp_alta_funcionalidades
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_item')
	-- DROP PROCEDURE pero_compila.sp_alta_item
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_factura')
	-- DROP PROCEDURE pero_compila.sp_alta_factura
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_pasar_a_pagada')
	-- DROP PROCEDURE pero_compila.sp_pasar_a_pagada
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='filtrarFacturas')
	-- DROP PROCEDURE pero_compila.filtrarFacturas
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_eliminar_factura')
	-- DROP PROCEDURE pero_compila.sp_eliminar_factura
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_update_factura')
	-- DROP PROCEDURE pero_compila.sp_update_factura
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_Pago_Factura')
	-- DROP PROCEDURE pero_compila.sp_alta_Pago_Factura
-- GO
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_cheque')
	-- DROP PROCEDURE pero_compila.sp_alta_cheque
-- GO	
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_tarjCredito')
	-- DROP PROCEDURE pero_compila.sp_alta_tarjCredito
-- GO	
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_tarjDebito')
	-- DROP PROCEDURE pero_compila.sp_alta_tarjDebito
-- GO
	
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_efectivo')
	-- DROP PROCEDURE pero_compila.sp_alta_efectivo
-- GO	
-- IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_rendicion')
	-- DROP PROCEDURE pero_compila.sp_alta_rendicion
-- GO

----------------------------------------------------------------------------------------------
							/** FIN VALIDACION DE PROCEDURES **/
----------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------
                          /** INICIO CREACION DE TABLAS **/
----------------------------------------------------------------------------------------------

create table [pero_compila].Funcionalidad(
funcionalidad_Id int primary key identity,
funcionalidad_descripcion nvarchar(255) not null,
)


create table [pero_compila].Rol(
rol_Id int primary key identity,
rol_nombre nvarchar(255) not null,
rol_estado bit default 1
)


create table [pero_compila].FuncionalidadXRol(
funcionalidadXRol_Id int primary key identity,
funcionalidadXRol_rol int not null references [pero_compila].Rol,
funcionalidadXRol_funcionalidad int not null references [pero_compila].Funcionalidad ,
)

create table [pero_compila].Usuario(
usuario_Id int primary key identity,
usuario_username varchar(255) unique not null,
usuario_password varchar(255) not null,
usuario_estado int default 1,
usuario_intentos int default 0,
usuario_nombre nvarchar(255),
usuario_apellido nvarchar(255),
usuario_dni  numeric(18,0) ,
usuario_email nvarchar(255),
usuario_telefono nvarchar(255),
usuario_direccion nvarchar(255),
usuario_fecha_nacimiento datetime,
)

create table [pero_compila].RolXUsuario(
rolXUsuario_Id int primary key identity,
rolXUsuario_usuario int not null references [pero_compila].Usuario,
rolXUsuario_rol int not null references [pero_compila].Rol,
)

create table [pero_compila].Habitacion (
habitacion_numero int,
habitacion_piso int,
habitacion_tipoPorcentual numeric(18,2),
habitacion_descripcion nvarchar(255),
habitacion_ubicacion nvarchar(50),
habitacion_codigo numeric(18,0),
habitacion_estado bit default 1,
PRIMARY KEY (habitacion_numero,habitacion_piso,habitacion_descripcion,habitacion_ubicacion)
)

create table [pero_compila].Hotel(
hotel_id int primary key identity,
hotel_direccion nvarchar(255),
hotel_nombre nvarchar(255),
hotel_mail nvarchar(255),
hotel_telefono nvarchar(255),
hotel_cantEstrellas int,
hotel_nroCalle int,
hotel_recargaEstrella int,
hotel_ciudad nvarchar(255),
hotel_pais nvarchar(255),
hotel_fechaCreacion datetime,
hotel_estado bit default 1,
hotel_habitacionNum int,
hotel_habitacionUbic nvarchar(50),
hotel_habitacionDescr nvarchar(255),
hotel_habitacionPiso int,
FOREIGN KEY (hotel_habitacionNum,hotel_habitacionPiso,hotel_habitacionDescr,hotel_habitacionUbic) REFERENCES pero_compila.Habitacion(habitacion_numero,habitacion_piso,habitacion_descripcion,habitacion_ubicacion)
)

create table [pero_compila].UsuarioXHotel(
usuarioXHotel_Id int primary key identity,
usuarioXHotel_hotel int not null references [pero_compila].Hotel,
usuarioXHotel_usuario int not null references [pero_compila].Usuario
)


create table [pero_compila].Regimen (
regimen_Id int primary key identity, -- codigo???
regimen_descripcion nvarchar(250),
regimen_precioBase numeric(18,2) ,
regimen_estado bit default 1
)

create table [pero_compila].HotelXRegimen (
hotelXRegimen_Id int primary key identity,
hotelXRegimen_hotel int not null references [pero_compila].Hotel,
hotelXRegimen_regimen int not null references [pero_compila].Regimen
)

create table [pero_compila].HotelCerrado (
hotelCerrado_Id int primary key identity,
hotelCerrado_descripcion nvarchar(255),
hotelCerrado_fechaInicio datetime,
hotelCerrado_fechaFin datetime,
hotelCerrado_hotel int not NULL references [pero_compila].Hotel
)

create table [pero_compila].Cliente (
cliente_nombre nvarchar(255),
cliente_apellido nvarchar(255),
cliente_identificacion numeric(18,0) ,
cliente_tipoIdentificacion nvarchar(255), -- preguntar
cliente_email nvarchar(255),
cliente_telefono nvarchar(255),
cliente_direccion nvarchar(255),
cliente_calle nvarchar(255),
cliente_piso int,
cliente_depto nvarchar(2),
cliente_localidad nvarchar(255),
cliente_paisOrigen nvarchar(255),
cliente_nacionalidad nvarchar(255),
cliente_fecha_nacimiento datetime,
cliente_estado bit default 1
PRIMARY KEY (cliente_identificacion,cliente_email)
)

create table [pero_compila].estadoReserva(
estadoReserva_id int primary key identity,
estadoReserva_descripcion nvarchar(255)
)

create table [pero_compila].Reserva (
reserva_Id int primary key identity, -- Codigo
reserva_fechaCreacion datetime , -- dia que se crea la reserva
reserva_fechaInicio datetime ,
reserva_cantDias int,
reserva_tipoHabitacion nvarchar(255),
reserva_tipoRegimen int references [pero_compila].Regimen,
reserva_activa bit default 1,
reserva_valor int,
reserva_estado int not null references [pero_compila].estadoReserva,
reserva_clienteIdentificacion numeric(18,0),
reserva_clienteMail	nvarchar(255),
reserva_usuario int not null references [pero_compila].Usuario,
FOREIGN KEY (reserva_clienteIdentificacion, reserva_clienteMail) REFERENCES pero_compila.Cliente(cliente_identificacion,cliente_email),
reserva_cantHuespedes int
)

create table [pero_compila].CancelarReserva(
cancelaReserva_Id int primary key identity,
cancelaReserva_nroReserva int not null references [pero_compila].Reserva,
cancelaReserva_motivo nvarchar(255),
cancelaReserva_fechaCancelacion datetime,
cancelarReserva_usuario int not null references [pero_compila].Usuario
--como hago para saber quien la cancelo porque es dif del usuario que la creo se puede dar  ese caso
)

create table [pero_compila].ReservaXHabitacion(
reservaXHabitacion_id int primary key identity,
reservaXHabitacion_nroHabitacion int not null references [pero_compila].Habitacion,
reservaXHabitacion_reserva int not null references [pero_compila].Reserva
)

create table [pero_compila].RegistroEstadia(
registroEstadia_id int primary key identity,
registroEstadia_reservaXHabit int not null references [pero_compila].ReservaXHabitacion,
registroEstadia_fechaIn datetime,
registroEstadia_fechaOut datetime,
registroEstadia_usuario int not null references [pero_compila].Usuario
)

create table [pero_compila].Item(
item_Id int primary key identity,
item_cantidad int ,
item_monto numeric(18,2),
)

create table [pero_compila].Consumible(
consumible_id int primary key identity,
consumible_descripcion nvarchar(255),
consumible_codigo numeric(18,0),
consumibe_precio numeric(18,2)
)

create table [pero_compila].Factura (
factura_Id int primary key identity	,
factura_pago nvarchar(250),
factura_fechaIn datetime ,
factura_item int not null references [pero_compila].Item,
factura_precio numeric(18,2)
)

create table [pero_compila].ConsumiblesXFactura (
consumibleXFactura_id int primary key identity,
consumibleXFactura_factura int not null references [pero_compila].Factura,
consumibleXFactura_consumible int not null references [pero_compila].Consumible
)


create table [pero_compila].EstadiaXConsumible (
estadiaXConsumible_Id int primary key identity,
estadiaXConsumible_estadia int not null references [pero_compila].RegistroEstadia,
estadiaXConsumible_consumible int not null references [pero_compila].Consumible,
)



-------------------------------------------------------------------------------------------
							/**FIN CREACION DE TABLAS**/
-------------------------------------------------------------------------------------------


		

-------------------------------------------------------------------------------------------
								/*STORED PROCEDURES*/
-------------------------------------------------------------------------------------------

	



-- 			/**********************REGISTRAR USUARIO*********************/




-- GO
-- --falta que se agreguen las sucursales
-- create PROCEDURE [pero_compila].[registrarUsuario](@user varchar(100),@pass varchar(100))
-- AS
-- BEGIN

-- 	if(@user IN (SELECT usuario_username from pero_compila.Usuario))
-- 			THROW 51000, 'Elija otro nombre de Usuario', 1;
-- 	else
-- 		INSERT INTO pero_compila.Usuario (usuario_username,usuario_password,usuario_intentos) 
-- 				VALUES (@user,HASHBYTES('SHA2_256', @pass),0)
		
-- 		Select Max(usuario_ID) from [pero_compila].[Usuario]	
-- END





-- 								/*FIN REGISTRAR USUARIO*/


-- /**********************LOGIN********************* */
-- go	
-- CREATE PROCEDURE [pero_compila].[login](@user VARCHAR(100), @pass varchar(100), @ret smallint output)
-- AS 
-- BEGIN

--   IF EXISTS( SELECT 1 FROM pero_compila.Usuario   WHERE usuario_username = @user )
  
--      BEGIN

-- 	    IF ( SELECT usuario_password FROM pero_compila.Usuario WHERE usuario_username = @user and usuario_estado=1) = HASHBYTES('SHA2_256', @pass)
-- 		    BEGIN
-- 			  UPDATE pero_compila.Usuario
--               SET usuario_intentos = 0
--               WHERE usuario_username = @user
-- 				set @ret = 0 -- user + psw correctos
-- 			END
           
-- 		ELSE
-- 			IF((select usuario_intentos from pero_compila.Usuario where usuario_username=@user and usuario_estado=1) < 3)
-- 				BEGIN 

-- 					UPDATE pero_compila.Usuario
-- 					SET usuario_intentos =usuario_intentos + 1
-- 					WHERE usuario_username = @user
-- 					SET @ret = -3 -- suma intentos fallidos
-- 		       END
-- 		   ELSE
-- 			   BEGIN
-- 				   UPDATE pero_compila.Usuario
-- 				   --SET ACTIVO = 0
-- 					set usuario_intentos = 3
-- 				   WHERE usuario_username = @user
-- 				  -- AND usuario_intentos = 3
		   
-- 				   SET @ret = -2 -- fallo en los intentos de login
		   
-- 			   END
--       END

--    ELSE
-- 		SET @ret= -1 -- no esta activo y usuario incorrecto
-- RETURN
-- END

   
-- /**********************FIN LOGIN **********************/

-- /**********************modifica la funciondalidad dado un idRol**********************/

-- go
-- create procedure [pero_compila].[sp_update_funcionalidades]
-- (@idRol int, @idFuncionalidad  int,@idFuncXRol int)
-- as
-- begin
-- 	update pero_compila.FuncionalidadXRol
-- 	set funcionalidadXRol_funcionalidad= @idFuncionalidad
-- 	where funcionalidadXRol_rol=@idRol and funcionalidadXRol_Id=@idFuncXRol
-- 	--select @@IDENTITY
-- end

-- /**************elimina una funcionalidad (cuando se saca el check en modif)****************/

-- go
-- create procedure [pero_compila].[sp_delete_funcionalidades]
-- (@idRol int, @idFuncionalidad  int,@idFuncXRol int)
-- as
-- begin
-- 	delete from pero_compila.FuncionalidadXRol
-- 	where funcionalidadXRol_rol=@idRol and funcionalidadXRol_Id=@idFuncXRol and funcionalidadXRol_funcionalidad=@idFuncionalidad
-- 	--select @@IDENTITY
-- end

-- /**********************ABM ROL**********************/

-- go
-- create procedure [pero_compila].[sp_alta_solo_rol] 
-- (@nombre varchar(255), @habilitado  bit)
-- as
-- begin
-- 	declare @id int
-- 	insert into pero_compila.Rol (rol_nombre, rol_estado)
-- 	values(@nombre, @habilitado)
	
-- 	Select Max(rol_Id) from [pero_compila].[Rol]
-- 	--select @id = scope_identity()[pero_compila].[Rol]
-- end




-- /*
-- *********************Obtiene todos los roles que se encuentran habilitados*********************
-- */
-- go
-- create procedure [pero_compila].[sp_get_roles]

-- as
-- begin
-- 	select * from pero_compila.Rol where rol_estado=1
-- end
-- /*
-- *********************Realiza el update de los roles de acuerdo a un identificador(id)*********************
-- */

-- go
-- create procedure [pero_compila].[sp_update_rol]
--  (@id numeric(10,0), @nombre varchar(255), @habilitado bit)	
-- as
-- begin

-- update pero_compila.Rol
-- set rol_nombre = @nombre, rol_estado = @habilitado
-- where rol_ID = @id

-- end

-- /*
-- ********************* alta los roles de acuerdo a un identificador(id)*********************
-- */

-- GO
-- SET QUOTED_IDENTIFIER ON
-- GO
-- createprocedure [pero_compila].[sp_alta_rol] (@nombre varchar(255), @habilitado  bit,@funcionalidad varchar(255))
-- as
-- begin
-- 	insert into pero_compila.Rol (rol_nombre, rol_estado)
-- 	values(@nombre, @habilitado)
-- 	insert into pero_compila.Funcionalidad (funcionalidad_descripcion)
-- 	values (@funcionalidad)
-- end

-- /*
-- *********************Obtiene todos los clientes que se encuentran habilitados*********************
-- */
-- GO
-- create procedure [pero_compila].[sp_get_clientes]

-- as
-- begin
-- 	select * from pero_compila.Cliente where cliente_estado=1
-- end
-- /*
-- *********************Obtiene todas las empresas que se encuentran habilitados*********************
-- */
-- GO

-- create procedure [pero_compila].[sp_get_empresas]

-- as
-- begin
-- 	select * from pero_compila.Empresa where empresa_estado=1
-- end
-- /*
-- *********************Obtiene todos los items *********************
-- */

-- GO
-- create procedure [pero_compila].[sp_get_items]

-- as
-- begin
-- 	select distinct item_Id,item_descripcion,item_precio from pero_compila.Item
-- end

-- /*
-- *********************Obtiene todas las facturas*********************
-- */

-- GO
-- create procedure [pero_compila].[sp_get_facturas]
-- as
-- begin
-- 	select * from pero_compila.Factura where factura_enviadoAPago=0 and factura_estado=1
-- end
-- /*
-- *********************modifica el total de una factura********************
-- */
-- go
-- create procedure [pero_compila].[sp_update_factura_total]
-- (@idFactura int, @total numeric(18,2))
-- as
-- begin
-- 	update pero_compila.Factura
-- 	set factura_total= @total
-- 	where factura_Id=@idFactura
-- 	--select @@IDENTITY
-- end


-- /*
-- *********************elimina una factura dado su id********************
-- */
-- go
-- create procedure [pero_compila].[sp_delete_factura]
-- (@idFactura int)
-- as
-- begin
-- 	delete from pero_compila.Factura
-- 	where factura_Id=@idFactura
-- 	--select @@IDENTITY
-- end

-- /*
-- *********************Alta del usuario con sucursales*********************
-- */

-- go
-- create procedure [pero_compila].[sp_alta_usuarioXSucursal]
-- (@idUsuario int, @idSucursal  int)
-- as
-- begin
-- 	insert into pero_compila.UsuarioXSucursal
-- 	(usuarioXSucursal_usuario, usuarioXSucursal_sucursal)
-- 	values(@idUsuario, @idSucursal)
-- 	--select @@IDENTITY
-- end
-- /*
-- *********************Realiza el alta de un usuario con roles*********************
-- */

-- go
-- create procedure [pero_compila].[sp_alta_usuarioXRol]
-- (@idUsuario int, @idRol  int)
-- as
-- begin
-- 	insert into pero_compila.RolXUsuario
-- 	(rolXUsuario_usuario, rolXUsuario_rol)
-- 	values(@idUsuario, @idRol)
-- 	--select @@IDENTITY
-- end

-- /*
-- *********************Realiza el alta de una funcionalidad*********************
-- */

-- go
-- create procedure [pero_compila].[sp_alta_funcionalidades]
-- (@idRol int, @idFuncionalidad  int)
-- as
-- begin
-- 	insert into pero_compila.FuncionalidadXRol
-- 	(funcionalidadXRol_rol, funcionalidadXRol_funcionalidad)
-- 	values(@idRol, @idFuncionalidad)
-- 	--select @@IDENTITY
-- end

-- /*
-- *********************Realiza el alta de un item*********************
-- */
-- go
-- create procedure [pero_compila].[sp_alta_item] (@descripcion nvarchar(255), @precio numeric(18,2),@cantidad int,@idFactura int)
-- as
-- begin
-- 	insert into pero_compila.Item (item_descripcion, item_precio,item_cantidad,item_factura)
-- 	values(@descripcion, @precio,@cantidad,@idFactura)
	
-- end

-- *************************ALTA DE FACTURA *******************************


-- GO
-- create procedure [pero_compila].[sp_alta_factura] 
-- (@cliente_dni numeric(18,0),@cliente_mail nvarchar(255),
-- @empresaId int,
-- @cod_factura nvarchar(255),
-- @fecha_alta datetime,@fecha_vencimiento datetime,
-- @total decimal(18,2))
-- as
-- begin
-- 	insert into pero_compila.Factura ([factura_cliente_dni],[factura_cliente_mail],[factura_empresa],[factura_cod_factura],
-- 	[factura_fecha_alta],[factura_fecha_vencimiento],[factura_total])
-- 	values(@cliente_dni,@cliente_mail,@empresaId,@cod_factura,
-- 	@fecha_alta,@fecha_vencimiento,@total)
-- 	Select Max(factura_id) from [pero_compila].Factura
-- end
-- /*
-- *********************PASA UNA FACTURA A ESTADO PAGA*********************
-- */

-- go
-- create procedure [pero_compila].[sp_pasar_a_pagada](@cliente_dni numeric(18,0),
-- @cliente_mail nvarchar(255),@cod_factura nvarchar(255))
-- AS 
-- BEGIN
-- UPDATE pero_compila.Factura
--               SET factura_enviadoAPago =1
--               WHERE factura_cliente_dni = @cliente_dni and factura_cliente_mail =@cliente_mail
-- 					and factura_cod_factura=@cod_factura

-- END

--  /*
-- *********************FILTRA UNA FACTURA POR UNO O TODOS LOS CAMPOS*********************
-- */

-- GO
-- create PROCEDURE [pero_compila].[filtrarFacturas]
-- 	(@fechaAlta datetime,
-- 	@fechaVencimiento datetime,
-- 	@nroFactura int,
-- 	@cliDni numeric(18,0),
-- 	@empresaId int,
-- 	@total numeric(18,2)
-- 	)
-- AS
-- BEGIN
-- 	select * from pero_compila.Factura where (factura_estado=1 and
-- 											factura_enviadoAPago=0) and(
-- 											 @fechaAlta is null or (factura_fecha_alta =@fechaAlta) or
-- 											 @fechaVencimiento is null or (factura_fecha_vencimiento =@fechaVencimiento) or
-- 											 @nroFactura is null or (factura_cod_factura =@nroFactura) or
-- 											 @cliDni is null or (factura_cliente_dni =@cliDni) or
-- 											 @empresaId is null or (factura_empresa =@empresaId) or
-- 											  @total is null or (factura_total =@total))
-- END

--  /*
-- ********************ELIMINA FACTURA(PASA A ESTADO 0)*********************
-- */

-- GO
-- CREATE PROCEDURE [pero_compila].[sp_eliminar_factura]
-- 	(@codFactura int,
-- 	@cli_dni numeric(18,0),
-- 	@facturaID int
-- 	)
-- AS
-- BEGIN
-- 	update pero_compila.Factura Set factura_estado=0 where factura_cod_factura=@codFactura and factura_cliente_dni=@cli_dni and factura_Id=@facturaID
-- END


--  /*
-- ********************UPDATE DE FACTURA*********************
-- */

-- GO
-- CREATE PROCEDURE [pero_compila].[sp_update_factura]
-- 	(@facturaId int,
-- 	@total numeric(18,2),
-- 	@codFactura int,
-- 	@cli_dni numeric(18,0),
-- 	@empresaId int,
-- 	@fechaAlta datetime,
-- 	@fechaVto datetime
-- 	)
-- AS
-- BEGIN
-- 	update pero_compila.Factura set 
-- 					factura_fecha_alta = @fechaAlta,
-- 					factura_fecha_vencimiento =@fechaVto,
-- 					factura_total=@total,
-- 					factura_cod_factura=@codFactura,
-- 					factura_cliente_dni=@cli_dni,
-- 					factura_empresa=@empresaId
	
-- 	where factura_id =@facturaId and ( factura_estado=1 and (
-- 		 @fechaAlta is null or (factura_fecha_alta =@fechaAlta) or
-- 		 @fechaVto is null or (factura_fecha_vencimiento =@fechaVto) or
-- 		 @codFactura is null or (factura_cod_factura =@codFactura) or
-- 		 @cli_dni is null or (factura_cliente_dni =@cli_dni) or
-- 		 @empresaId is null or (factura_empresa =@empresaId)))
-- END

--  /*
-- *********************modifica un item *********************
-- */
-- go
-- create PROCEDURE [pero_compila].[sp_update_item]
-- 	(@facturaId int,
-- 	@itemId int,
-- 	@descripcion nvarchar(255),
-- 	@precio numeric(18,2),
-- 	@cantidad int)
-- AS
-- BEGIN
-- 	update pero_compila.Item set 
-- 					item_descripcion=@descripcion,
-- 					item_precio=@precio,
-- 					item_cantidad=@cantidad
	
-- 	where item_Id =@itemId and item_factura=@facturaId
	
	
-- END

--  /*
-- *********************DA DE ALTA EN UN PAGO_FACTURA*********************
-- */

-- go
-- create procedure [pero_compila].[sp_alta_Pago_Factura](@facturaId int,
--         @sucursalId int,
--         @cliente_dni int,
--         @cliente_mail nvarchar(255),
--         @medioPagoId int,
--         @fechaCobro datetime,
--         @importe numeric(18,2))
-- AS 
-- BEGIN
-- insert into pero_compila.PagoFactura(pagoFactura_factura,pagoFactura_sucursal,pagoFactura_cliente_dni,pagoFactura_cliente_mail,pagoFactura_medioPago,pagoFactura_fecha_cobro,pagoFactura_importe,pagoFactura_estado)
-- values (@facturaId ,@sucursalId ,
--         @cliente_dni ,
--         @cliente_mail ,
--         @medioPagoId ,
--         @fechaCobro ,
--         @importe ,1)


-- END

-- /*
-- *********************dar de alta en un cheque*********************
-- */

-- go
-- create procedure [pero_compila].[sp_alta_cheque](@nroCheque INT, @dniTitular NUMERIC(18,0),
-- @destino NVARCHAR(255),@monto NUMERIC(18,2))
-- AS 
-- BEGIN
-- INSERT INTO pero_compila.MedioPago(medioPago_nroCheque,medioPago_dniTitular,medioPago_entidadAPagar,medioPago_monto,medioPago_descripcion)
-- values(@nroCheque , @dniTitular ,
-- @destino ,@monto,'Cheque' )
-- end



-- /*
-- *********************dar de alta en una tarj de credito *********************
-- */

-- GO
-- create procedure [pero_compila].[sp_alta_tarjCredito](@nroTarjCredit int,@fechaVtoTarjeta datetime,@codVerificacionTarjeta int, @dniTitular numeric(18,0),@monto numeric(18,2) )
-- as
-- begin
-- insert into pero_compila.MedioPago(medioPago_nroTarjCredito,medioPago_fechaVtoTarjeta,medioPago_codVerificacionTarjeta,medioPago_dniTitular,medioPago_monto,medioPago_descripcion)
-- values(@nroTarjCredit,@fechaVtoTarjeta ,@codVerificacionTarjeta, @dniTitular ,@monto,'Tarjeta de Crédito' )
-- end

-- /*
-- ********************** dar de alta en efectivo*********************
-- */	
-- GO
-- create procedure [pero_compila].[sp_alta_efectivo](@dniTitular NUMERIC(18,0),@monto NUMERIC(18,2))
-- AS 
-- BEGIN
-- INSERT INTO pero_compila.MedioPago(medioPago_dniTitular,medioPago_monto,medioPago_descripcion)
-- values( @dniTitular ,@monto,'Efectivo' )
-- end

-- /*
-- ********************** dar de alta en una tarj de debito*********************
-- */

-- GO
-- create procedure [pero_compila].[sp_alta_tarjDebito](@nroTarjDebito int,@fechaVtoTarjeta datetime,@codVerificacionTarjeta int, @dniTitular numeric(18,0),@monto numeric(18,2) )
-- as
-- begin
-- insert into pero_compila.MedioPago(medioPago_nroTarjDebito,medioPago_fechaVtoTarjeta,medioPago_codVerificacionTarjeta,medioPago_dniTitular,medioPago_monto,medioPago_descripcion)
-- values(@nroTarjDebito,@fechaVtoTarjeta ,@codVerificacionTarjeta, @dniTitular ,@monto,'Tarjeta de Débito' )
-- end

-- /*
-- ********************** dar de alta una rendicion en una fecha*********************
-- */
-- go
-- create  procedure [pero_compila].[sp_alta_rendicion](@rendicion_fecha datetime,
--              @cantidad int,
--              @empresa nvarchar(255),
--              @porcentaje numeric(18,2),
--              @total numeric(18,2),
-- 			 @importeRecaudado numeric(18,2))
-- AS
-- BEGIN
-- insert into pero_compila.Rendicion_Facturas(
-- rendicion_facturas_fecha,
-- rendicion_facturas_cantidad,
-- rendicion_facturas_empresa,
-- rendicion_facturas_porcentaje,
-- rendicion_facturas_total,
-- rendicion_facturas_importeRecaudado)
-- values (@rendicion_fecha,@cantidad,@empresa,
--              @porcentaje,@total,@importeRecaudado)

-- END




-----------------------------------------------------------------------------------------------------
									/*FIN DE STORED PROCEDURES*/
-----------------------------------------------------------------------------------------------------






-----------------------------------------------------------------------------------------------------
										/* CARGA DE DATOS */
-----------------------------------------------------------------------------------------------------

--Existen dos tipos de roles Administradores y Cobradores
					/*Rol*/
go
insert into [pero_compila].Rol (rol_nombre) values
('Administrador'), 
('Recepcionista'),
('Guest');

					/*Funcionalidad*/
go
insert into pero_compila.Funcionalidad (funcionalidad_descripcion) values
('ABM de Rol'),
('ABM de Usuarios'),
('ABM de Clientes'),
('ABM de Hotel'),
('ABM de Habitacion'),
('ABM Regimen de estadia'),
('Generar o Modificar Reserva'),
('Cancelar Reserva'),
('Registrar Estadia'),
('Registrar Consumible'),
('Listado estadistico');
					/*RolXFuncionalidad*/
					/RolXFuncionalidad/

go
insert into [pero_compila].FuncionalidadXRol (funcionalidadXRol_rol, funcionalidadXRol_funcionalidad) values
(1,1),(1,2),(2,3),(1,4),(1,5),(1,6),(2,7),(3,7),(2,8),(3,8),(2,9),(2,10).(2,11),(1,11);

					/*Usuarios*/


/*Usuario pedido*/
go
insert into pero_compila.Usuario (usuario_username, usuario_password) values
('admin',HASHBYTES('SHA2_256','w23e'))

/*usuarios creados por el grupo*/ 
go
insert into pero_compila.Usuario (usuario_username, usuario_password) values 
	('recepcionista',HASHBYTES('SHA2_256','recepcionista'))
--insert into pero_compila.Usuario (usuario_username,usuario_password) values
--	('guest',HASHBYTES('SHA2_256','guest'))
-- no se loguean los guest

					/*UsuariosXRoles*/
/*usuariosXRoles*/
insert into pero_compila.RolXUsuario (rolXUsuario_usuario, rolXUsuario_rol) values
	(1,1),(2,2),(1,2);


					/*Cliente*/
INSERT INTO [pero_compila].[Cliente]([cliente_Nombre],[cliente_apellido],
[cliente_identificacion],[cliente_email]
,[cliente_direccion],[cliente_calle],[cliente_piso],[cliente_depto],[cliente_nacionalidad]
,[cliente_fecha_nacimiento],[cliente_estado])
select distinct Cliente_Nombre,Cliente_Apellido,Cliente_Pasaporte_Nro,
Cliente_Mail,Cliente_Dom_Calle,Cliente_Nro_Calle,Cliente_Piso,Cliente_Depto,Cliente_Nacionalidad,Cliente_Fecha_Nac,1
from gd_esquema.Maestra
GO
--96944 filas 
				   /*Habitacion*/

SET IDENTITY_INSERT pero_compila.Habitacion ON
INSERT INTO [pero_compila].[Habitacion]([habitacion_numero],[habitacion_descripcion],
[habitacion_piso],[habitacion_codigo],[habitacion_ubicacion],[habitacion_tipo]
,[habitacion_estado])
select distinct Habitacion_Numero,Habitacion_Tipo_Descripcion,
Habitacion_Piso,Habitacion_Tipo_Codigo,Habitacion_Frente,Habitacion_Tipo_Porcentual,1
from gd_esquema.Maestra 
SET IDENTITY_INSERT pero_compila.Habitacion OFF
--309 filas

                  /*Hotel*/
INSERT INTO pero_compila.Hotel (hotel_ciudad,hotel_direccion,hotel_cantEstrellas,
hotel_nroCalle,hotel_recargaEstrella,hotel_habitacionNum,hotel_habitacionUbic,hotel_habitacionDescr,hotel_habitacionPiso,hotel_estado)
select distinct Hotel_Ciudad,Hotel_Calle,Hotel_CantEstrella,Hotel_Nro_Calle,Hotel_Recarga_Estrella,h.habitacion_numero,habitacion_ubicacion,habitacion_descripcion,
h.habitacion_piso,1 from gd_esquema.Maestra m, pero_compila.Habitacion h
--1470 filas


 				/*UsuarioXHotel*/
--suponemos que todos los usuarios trabajan en todos los hoteles 
insert into pero_compila.UsuarioXHotel (usuarioXHotel_hotel,usuarioXHotel_usuario)
select distinct h.hotel_id,u.usuario_Id from pero_compila.Hotel h,pero_compila.Usuario u
--2940 filas 

                /*Regimen*/
insert into pero_compila.Regimen(regimen_descripcion,regimen_precioBase,regimen_estado)
select distinct Regimen_Descripcion,Regimen_Precio,1 from gd_esquema.Maestra
-- 4 filas


			  /*HotelXRegimen*/
insert into pero_compila.HotelXRegimen (hotelXRegimen_hotel,hotelXRegimen_regimen)
select distinct h.hotel_Id, r.regimen_Id from pero_compila.Hotel h,  pero_compila.Regimen r
--5880 filas 


			  /*EstadoReserva*/
insert into pero_compila.estadoReserva(estadoReserva_descripcion)
values ('Reserva Correcta');
insert into pero_compila.estadoReserva(estadoReserva_descripcion)
values ('Reserva modificada');
insert into pero_compila.estadoReserva(estadoReserva_descripcion)
values ('Reserva cancelada por Recepcion')
insert into pero_compila.estadoReserva(estadoReserva_descripcion)
values ('Reserva cancelada por Cliente')
insert into pero_compila.estadoReserva(estadoReserva_descripcion)
values ('Reserva cancelada por No-Show')
insert into pero_compila.estadoReserva(estadoReserva_descripcion)
values ('Reserva con ingreso (efectivizada)')

         
               /*Reserva*/

--falta todo lo q tenga que ver con reserva, registroEstadia y estadiaXReserva


                /*Item*/
insert into pero_compila.Item(item_cantidad,item_monto)
select distinct Item_Factura_Cantidad,Item_Factura_Monto from gd_esquema.Maestra

			   /*Consumible*/
insert into pero_compila.Consumible (consumible_precio,consumible_descripcion,consumible_Codigo)
select distinct Consumible_Precio,Consumible_Descripcion,Consumible_Codigo from gd_esquema.Maestra
-----------------------------------------------------------------------------------------------------
										/*FIN CARGA DE DATOS */
-----------------------------------------------------------------------------------------------------