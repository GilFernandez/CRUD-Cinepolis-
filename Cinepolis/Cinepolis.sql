use master
go

drop Database if exists  Cinepolis
go

create database Cinepolis
go

use Cinepolis
go

create table Pelicula 
(
idPelicula int identity(1,1),
nombre varchar (30) not null,
clasifiacion varchar (5) not null,
estatus int default 1,
idUsuarioCrea int not null,
fechaCrea dateTime default getDate(),
idUsuarioModifica int null,
fechaModifica dateTime null

Primary key (idPelicula)
)

create table Usuario
(
idUsuario int identity (1,1),
nombreUsuario varchar (15) not null,
clave varbinary(128) not null,
estatus int default 1

Primary Key (idUsuario)
)
go

------------------

alter table Pelicula
add constraint FKPeliculaUsuarioCrea
foreign key (idUsuarioCrea)
references Usuario (idUsuario)
go

alter table Pelicula
add constraint FKPeliculaUsuarioModifica
foreign key (idUsuarioModifica)
references Usuario (idUsuario)
go

------

create index ixPelicula
on Pelicula (idPelicula)
go

create index ixUsuario
on Usuario (idUsuario)
go

------

create view vwPelicula
as
select
Pelicula.nombre as Nombre,
Pelicula.clasifiacion as Clasificación,
Pelicula.estatus as Estatus,
Pelicula.idUsuarioCrea as 'Creado por',
Pelicula.fechaCrea as 'Fecha agregada',
Pelicula.idUsuarioModifica as 'Modificado por',
Pelicula.fechaModifica as 'Fecha modificada'
from Pelicula 

------

insert into Usuario (nombreUsuario,clave) values ('gil',PwdEncrypt('123'))
go

------

select * from Usuario
select * from Pelicula