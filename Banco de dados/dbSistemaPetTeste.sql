create database db_sistemapet
go
use db_sistemapet
go

create table Adestrador(
id_adestrador int primary key identity,
nome_adestrador varchar (50),
telefone_adestrador varchar (18),
email_adestrador varchar (50),
rua_adestrador varchar (50),
numCasa_adestrador int,
bairro_adestrador varchar(50),
cidade_adestrador varchar(35),
estado_adestrador varchar(2),
senha_adestrador varchar(20),
cpf_adestrador int
)

create table Dono(
id_dono int primary key identity,
nome_dono varchar(50),
telefone_dono varchar (18),
email_dono varchar (50),
rua_dono varchar (50),
numCasa_dono int,
bairro_dono varchar(50),
cidade_dono varchar(35),
estado_dono varchar(2),
senha_dono varchar(20),
)

create table Pet(
id_pet int primary key identity,
id_dono int references Dono(id_dono),
id_adestrador int references Adestrador(id_adestrador),
nome_pet varchar(30),
tipo_pet varchar(30),
raca_pet varchar (20),
genero_pet varchar(30),
avaliacao varchar (500)
)

create table Pagamento(
id_pagamento int primary key identity,
id_dono int references Dono (id_dono),
id_adestrador int references Adestrador(id_adestrador),
valor_pagamento float,
situacao_pagamento varchar(15)
)

create table Adestramento (
id_adestramento int primary key identity,
id_pet int references Pet(id_pet),
id_pagamento int references Pagamento(id_pagamento),
tipo_adest varchar (20),
etapa_adest int
)

create table Agenda(
id_agenda int primary key identity,
id_adestrador int references Adestrador(id_adestrador),
id_dono int references Dono(id_dono),
id_pet int references Pet (id_pet),
id_adestramento int references Adestramento (id_adestramento),
data_agenda date
)

select * from Dono
select * from Pet

create table Funcionario (
id_func int primary key identity,
nome_func varchar (50) not null,
cargo_func varchar (50) not null,
telefone_func varchar (15),
email_func varchar(50) not null,
rua_func varchar (80) not null,
numCasa_func int not null, 
bairro_func varchar (30),
cidade_func varchar (50),
estado_func varchar(2),
senha_func varchar(20)
)

create table EAdestrador(
id_adestrador int primary key identity,
nome_adestrador varchar (50),
telefone_adestrador varchar (18),
email_adestrador varchar (50),
rua_adestrador varchar (50),
numCasa_adestrador int,
bairro_adestrador varchar(50),
cidade_adestrador varchar(35),
estado_adestrador varchar(2),
senha_adestrador varchar(20),
cpf_adestrador int
)


create table EDono(
id_dono int primary key identity,
nome_dono varchar(50),
telefone_dono varchar (18),
email_dono varchar (50),
rua_dono varchar (50),
numCasa_dono int,
bairro_dono varchar(50),
cidade_dono varchar(35),
estado_dono varchar(2),
senha_dono varchar(20),
)

create table EPet(
id_pet int primary key identity,
id_dono int references Dono(id_dono),
id_adestrador int references Adestrador(id_adestrador),
nome_pet varchar(30),
tipo_pet varchar(30),
raca_pet varchar (20),
genero_pet varchar(30),
avaliacao varchar (500)
)

insert into Funcionario values ('Rafael Rios','Analista de Sistemas','(011)4444-7777','rafael@abax.com','Guaipá',7,'Vila Leopoldina','São Paulo','SP','abax123')
insert into Funcionario values ('Guilherme Cardozo','Analista de Banco de Dados','(011)3333-7878','guilherme@abax.com','Guaipá',8,'Vila Leopoldina','São Paulo','SP','abax123')
insert into Funcionario values ('Lauro Gabriel','Analista de Desenvolvimento','(011)3232-1212','lauro@abax.com','Guaipá',9,'Vila Leopoldina','São Paulo','SP','abax123')
insert into Funcionario values ('Edson Araújo','Analista de Desenvolvimento','(011)7878-7777','edson@abax.com','Guaipá',4,'Vila Leopoldina','São Paulo','SP','abax123')
insert into Funcionario values ('Willian Santiago','Analista de Sistemas','(011)4444-7878','willian@abax.com','Guaipá',5,'Vila Leopoldina','São Paulo','SP','abax123')
insert into Funcionario values ('Maico Henrique','Analista de Infraestrutura','(011)1235-4789','maico@abax.com','Guaipá',3,'Vila Leopoldina','São Paulo','SP','abax123')
insert into Funcionario values ('Gisele Alves','Web Designer','(011)4444-7777','gisele@abax.com','Guaipá',2,'Vila Leopoldina','São Paulo','SP','abax123')
select * from Funcionario