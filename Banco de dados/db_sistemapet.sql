create database db_sistemapet
use db_sistemapet

create table tb_funcionario (
id_func int primary key identity,
nome_func varchar (50) not null,
cargo_func varchar (20) not null,
fone_func varchar (15),
email_func varchar(50) not null,
rua_func varchar (80) not null,
numrua_func int not null, 
bairro_func varchar (30),
cidade_func varchar (50)
)

create table tb_adestrador (
id_ad int primary key identity,
nome_ad varchar (50) not null,
fone_ad varchar (15),
email_ad varchar(50) not null
)
go
create table tb_pet(
id_pet int primary key identity,
id_ad int references tb_adestrador(id_ad),
nome_pet varchar (20) not null,
tipo_pet varchar (20) not null,
raca_pet varchar (20) not null,
genero_pet varchar (1) not null
)
go
create table tb_adestramento(
id_adest int primary key identity,
id_ad int references tb_adestrador(id_ad),
id_pet int references tb_pet(id_pet),
tipo_adest varchar (20),
etapa_adest int,
avaliacao_pet varchar (300)
)
go
create table tb_dono(
id_dono int primary key identity,
nome_dono varchar (50) not null,
id_pet int references tb_pet(id_pet),
fone_dono varchar (15),
email_dono varchar (50),
rua_dono varchar(80),
numrua_dono int not null,
bairro_dono varchar (30),
cidade_dono varchar (50)
)
go

alter table tb_pet
add id_dono int references tb_dono(id_dono)

create table tb_agenda(
id_agenda int primary key identity,
data_agenda date,
id_ad int references tb_adestrador,
id_pet int references tb_pet,
id_dono int references tb_dono,
id_adest int references tb_adestramento
)

select * from tb_adestrador
select * from tb_adestramento
select * from tb_agenda
select * from tb_dono
select * from tb_funcionario
select * from tb_pet