create database Prestamista

go

use Prestamista

go

create table facturacion(
idFactura int identity primary key,
idCliente int not null,
idPrestamo int not null,
fecha date not null 
)

go

create table prestamo(
idPrestamo int identity primary key,
monto int not null,
interes int not null,
cuotas int not null,
periodoPago int not null,
moraPrestamo int not null,
fechaInicial date not null,
fechaFinal date not null
)

go

create table pago(
idPago int identity primary key,
idCliente int not null,
moraPago int not null,
MontoTotal int not null,
MontoRestante int not null
)

go

create table clientes(
idCliente int identity primary key,
nombre varchar(30) not null,
cedula char(11) not null,
direccion varchar(50) not null,
telefono char(10) not null
)

go

create table empleados(
nombre varchar(20) not null,
contrasena varchar(20) not null
)

go

insert into empleados(nombre, contrasena) values('admin','123')





