create table PayMode
(
 Pay_Mode_Id int identity (100000,1) primary key,
 Pay_Mode_Name nvarchar (50) not null,
 Pay_Mode_Observation nvarchar (50) not null,
)
go
insert into PayMode values('Cash', 'Cash mode')
insert into PayMode values('Credit card', 'Credit card mode')

create table Products
(
 Products_Id int identity (100000,1) primary key,
 Products_Name nvarchar (50) not null,
 Products_Observation nvarchar (50) not null,
)
go
insert into Products values('Product', 'Product mode')
insert into Products values('Jabon', 'Credit card mode')

create table Categories
(
 Categories_Id int identity (100000,1) primary key,
 Categories_Name nvarchar (50) not null,
 Categories_Observation nvarchar (50) not null,
)
go
insert into Categories values('Categorie', 'Categorie mode')
insert into Categories values('Limpieza', 'Limpieza mode')

create table Providers
(
 Providers_Id int identity (100000,1) primary key,
 Providers_Name nvarchar (50) not null,
 Providers_Observation nvarchar (50) not null,
)
go
insert into Providers values('Provider', 'Provider mode')
insert into Providers values('Credit card', 'Credit card mode')



