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
email_ad varchar(50) not null,
)
