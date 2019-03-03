create database Usuario;
use Usuario;
drop table if exists Usuario;
create table if not exists Usuario(
	usuarioID int not null auto_increment primary key,
	ra varchar(200),
	nome varchar(200) ,
	senha varchar(500) ,
	instituicao varchar(200) 
);

insert into Usuario values(null, '31523541','Fernando Gonçalves',sha1('123456'),'Una');
insert into Usuario values(null, '31523542','Thales Heron',sha1('123456'),'Una');
insert into Usuario values(null, '31523543','Gabriel Ramon',sha1('123456'),'Una');
insert into Usuario values(null, '31523544','Thiago Henrique',sha1('123456'),'Una');
insert into Usuario values(null, '31523545','Fabiano Silvestre',sha1('123456'),'Una');

Select * from Usuario;