use master
go
create database MyCarStore
go
use MyCarStore
go
drop table Cars
go
create table Cars(
	CarId int IDENTITY(1,1) constraint pk_carid primary key not null,
	CarName varchar(50),
	Manufacturer varchar(50),
	ListPrice decimal(6,2) default 0,
	ReleaseDate datetime
)
go
insert into Cars(CarName, Manufacturer, ListPrice, ReleaseDate) 
values('CRV', 'Honda',1200.23,'2022/04/10')

insert into Cars(CarName, Manufacturer, ListPrice, ReleaseDate) 
values('For', 'Honda',3200.23,'2021/02/10')
go

insert into Cars(CarName, Manufacturer, ListPrice, ReleaseDate) 
values('BMW', 'Suzuki',7200.23,'2021/03/10')
go
insert into Cars(CarName, Manufacturer, ListPrice, ReleaseDate) 
values('KIA', 'Huyndai',5200.23,'2019/02/10')

--SQL

select *
from Cars


