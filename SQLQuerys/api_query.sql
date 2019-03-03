create database Aluno;
use Aluno;
drop table if exists Aluno;
create table if not exists Aluno(
	alunoID int not null auto_increment primary key,
	ra varchar(200),
	nome varchar(200) ,
	senha varchar(500) ,
	instituicao varchar(200) 
);

insert into Aluno values(null, '31523541','Fernando Gonçalves',sha1('123456'),'Una');
insert into Aluno values(null, '31523542','Thales Heron',sha1('123456'),'Una');
insert into Aluno values(null, '31523543','Gabriel Ramon',sha1('123456'),'Una');
insert into Aluno values(null, '31523544','Thiago Henrique',sha1('123456'),'Una');
insert into Aluno values(null, '31523545','Fabiano Silvestre',sha1('123456'),'Una');

Select * from Aluno;