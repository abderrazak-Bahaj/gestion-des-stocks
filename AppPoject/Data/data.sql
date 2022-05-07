
create database gestion_de_stock
go
use gestion_de_stock
go
create table type_user(
id int identity primary key,
name nvarchar(100) unique not null,
)
go 

create table store(
id int identity primary key,
name nvarchar(255) not null unique,
address nvarchar(255),
)
go

create table[dbo].[user](
id int identity primary key,
email nvarchar(100) not null unique,
password nvarchar(100) not null,
first_name nvarchar(100) not null,
last_name nvarchar(100) not null,
adderss nvarchar(100) not null,
date_burth Date not null,
type_user int,
CONSTRAINT fk_user_type FOREIGN KEY (type_user)REFERENCES type_user(id) ON DELETE CASCADE ON UPDATE CASCADE,
)
go
create table funded(
id int identity primary key,
email nvarchar(100) not null ,
name  nvarchar(100) not null ,
adderss nvarchar(100)  null,
)
go 



create table category(
id int identity primary key,
name nvarchar(100) unique not null,
image nvarchar(100) null,
)
go 

create table brande(
id int identity primary key,
name nvarchar(100) unique not null,
)
go 

create table product(
id int identity,
code_bar nvarchar(200) null,
name nvarchar(100) null,
description nvarchar(200) null,
product_image nvarchar(255) null,
price_bay decimal(12,2) not null,
price_sall decimal(12,2) not null,
quntity int not null,
created_at Date not null,
id_category int ,
id_brande int ,
id_store int,
id_funded int,
CONSTRAINT fk_product_category FOREIGN KEY (id_category)REFERENCES category(id) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT fk_brandes FOREIGN KEY (id_brande)REFERENCES brande(id) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT fk_store_product FOREIGN KEY (id_store)REFERENCES store(id) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT fk_funded_product FOREIGN KEY (id_funded)REFERENCES funded(id) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT Pk_product PRIMARY KEY (id),
)
go 


create table costumer(
id int identity primary key,
email nvarchar(100) not null ,
name  nvarchar(100) not null ,
adderss nvarchar(100)  null,
)
go 

create table transfer_details(
id int identity primary key,
product_id int not null,
store_from int not null,
store_to int not null,
quantity int,
transform_date Datetime,
CONSTRAINT fk_store_from FOREIGN KEY (store_from) REFERENCES store(id) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT fk_store_to_store FOREIGN KEY (store_to) REFERENCES store(id) ,
CONSTRAINT fk_product_transform_store FOREIGN KEY (product_id) REFERENCES product(id) ,
)
go

create table  [dbo].[order](
id int identity primary key,
id_product int ,
id_costumer int ,
id_user int ,
pay_type nvarchar(200)  null check(pay_type in (N'Cash',N'Checks',N'Credit Cards')),
price_sall_final decimal(12,2) not null,
quantity int not null,
state nvarchar(200) check(state in (N'success',N'in delvery',N'reversion')),
created_at Date not null,
end_in date null,
CONSTRAINT fk_product_order FOREIGN KEY (id_product)REFERENCES product(id) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT fk_costumer_order FOREIGN KEY (id_costumer)REFERENCES costumer(id) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT fk_user_order FOREIGN KEY (id_user)REFERENCES [dbo].[user](id) ON DELETE CASCADE ON UPDATE CASCADE,
)
go 

insert into type_user values(N'super admin'),(N'admin')
go
Select * from type_user
go

insert into [dbo].[user] values(N'super-admin@email.com',N'admin',N'abderrazak',N'Bahaj',N'Tinghir amzaouro','1998-05-12',1)
						,(N'admin@email.com',N'admin',N'abde',N'Bahaj',N'Tinghir amzaouro','1998-05-12',1)
						go
select * from [dbo].[user]
go

insert into store values('Store Main','Tinghir Maroc')
insert into store values('Store socend','case Maroc')
go
select * from store
go
insert into category values(N'Tv',N'imag.png'),(N'phone',N'url.png'),(N'camera',N'url.png'),(N'chargeur',N'url.png')
go
select * from category
go

insert into brande values(N'Samsung'),(N'LG'),(N'Appel'),(N'Oppo'),(N'Logetc')
go
select * from brande
go

insert into funded values(N'userfunded1@email.com',N'user',N'Casa'),
						   (N'Salimfunded2@email.com',N'Salim mimoni',N'Markech'),
						   (N'Mustphfunded3@email.com',N'Mustph srghat',N'Casa')
go
select * from funded
go


insert into product values(N'2278907665445',N'LG 783',N'description LG 783',N'C:\Users\BAHAJ\Documents\Images Project-App\img-1.png',2000,3000.33,23,'2022-05-12',1,2,1,1)
insert into product values(N'56789456722',N'Samsung SS1',N'description Samsung SS1',N'C:\Users\BAHAJ\Documents\Images Project-App\img-2.png',4000,5000,11,'2021-01-01',1,1,1,1)
insert into product values(N'56789422783',N'I phone 7',N'description I phone 7',N'C:\Users\BAHAJ\Documents\Images Project-App\img-3.png',4000,5000,11,'2021-01-01',2,3,1,1)
insert into product values(N'22289456783',N'OPPO A33',N'description OPPO A33',N'C:\Users\BAHAJ\Documents\Images Project-App\img-4.png',4000,5000,11,'2021-04-02',2,4,1,1)
insert into product values(N'51189456783',N'CANON D33',N'description CANON',N'C:\Users\BAHAJ\Documents\Images Project-App\img-5.png',1500,2000,11,'2022-03-03',3,5,1,1)
insert into product values(N'51111456783',N'SONEY D3',N'description SONEY D3',N'C:\Users\BAHAJ\Documents\Images Project-App\img-6.png',9000,10000,11,'2022-03-03',3,5,1,1)
insert into product values(N'54489456783',N'CANON D133',N'description CANON D133',N'C:\Users\BAHAJ\Documents\Images Project-App\img-7.png',1500,2000,11,'2022-03-03',3,5,1,1)
insert into product values(N'66189456783',N'OPPO D33',N'description OPPO D33',N'C:\Users\BAHAJ\Documents\Images Project-App\img-8.png',800,1000,11,'2022-03-03',3,5,1,1)
insert into product values(N'2278907665445',N'LG 783',N'description LG 783',N'C:\Users\BAHAJ\Documents\Images Project-App\img-9.png',2000,3000.33,23,'2022-05-12',1,2,1,1)

insert into product values(N'5678932722',N'Samsung S12',N'description Samsung S12',N'C:\Users\BAHAJ\Documents\Images Project-App\img-10.png',4000,5000,11,'2021-01-01',1,1,2,1)
insert into product values(N'56009422783',N'I phone 8',N'description I phone 8',N'C:\Users\BAHAJ\Documents\Images Project-App\img-11.png',4000,5000,11,'2021-01-01',2,3,2,2)
insert into product values(N'222800083',N'OPPO A33',N'description OPPO A33',N'C:\Users\BAHAJ\Documents\Images Project-App\img-12.png',4000,5000,11,'2021-04-02',2,4,2,1)
insert into product values(N'5118945603',N'CANON D383',N'description CANON D383',N'C:\Users\BAHAJ\Documents\Images Project-App\img-13.png',1500,2000,11,'2022-03-03',3,5,2,2)
insert into product values(N'5111056783',N'sony D333',N'description sony D333',N'C:\Users\BAHAJ\Documents\Images Project-App\img-14.png',9000,10000,11,'2022-03-03',3,5,2,2)
insert into product values(N'54406783',N'sony D133',N'description sony D133',N'C:\Users\BAHAJ\Documents\Images Project-App\img-15.png',1500,2000,11,'2022-03-03',3,5,2,2)
insert into product values(N'661806783',N'sumsung D33',N'description sumsung D33',N'C:\Users\BAHAJ\Documents\Images Project-App\img-16.png',800,1000,11,'2022-03-03',3,5,2,2)
go
select * from product

insert into costumer values(N'client1@email.com',N'omar Ossama',N'Casa'),
						   (N'client4@email.com',N'Yassin Lhadiri',N'Markech'),
						   (N'client2@email.com',N'Amin Ossama',N'Markech'),
						   (N'client3@email.com',N'Issam Mustph ',N'Casa')
go
select * from costumer
go

INSERT INTO [dbo].[order] values(1,2,2,N'Cash',4500,12,'success',N'2022-02-02',GETDATE())
INSERT INTO [dbo].[order] values(2,1,2,'Checks',2100,2,'success',N'2022-02-02',GETDATE())
INSERT INTO [dbo].[order] values(3,1,2,'Cash',2500,4,'delvery',N'2022-02-02',null)
INSERT INTO [dbo].[order] values(2,2,2,'Credit Cards',1100,7,'in delvery',N'2022-02-02',GETDATE())
INSERT INTO [dbo].[order] values(1,2,2,N'Cash',4500,12,'delvery',N'2022-02-02',GETDATE())
INSERT INTO [dbo].[order] values(2,1,2,'Checks',2100,2,'reversion',N'2022-02-02',GETDATE())
INSERT INTO [dbo].[order] values(3,1,2,'Cash',2500,4,'delvery',N'2022-02-02',null)
INSERT INTO [dbo].[order] values(2,2,2,'Credit Cards',1100,7,'in delvery',N'2022-02-02',GETDATE())
GO

select o.quantity,p.quntity from [dbo].[order] as o,product as p  where p.id = 1
go
insert into transfer_details values(1,1,2,45,'2022-05-06')
insert into transfer_details values(2,1,2,45,'2022-01-07')
insert into transfer_details values(1,1,2,45,'2020-08-11')
insert into transfer_details values(2,1,2,45,'2021-02-08')
insert into transfer_details values(8,1,2,10,'2022-05-01')
insert into transfer_details values(5,2,1,12,'2021-05-06')
insert into transfer_details values(4,2,2,40,'2022-05-06')
insert into transfer_details values(5,2,2,1,'2022-10-10')
go
select * from transfer_details
go
