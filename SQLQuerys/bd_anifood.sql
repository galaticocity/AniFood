
Drop database if exists AniFood;
CREATE DATABASE IF NOT EXISTS AniFood;
USE AniFood;
CREATE TABLE Usuario (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(60) NULL,
  statusUsuario CHAR NULL,
  senha VARCHAR(30) NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  PRIMARY KEY(id)
);

CREATE TABLE Categoria (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(60) NULL,
  statusCategoria CHAR NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  PRIMARY KEY(id)
);

insert into Categoria values (null, 'Salgados','d',now(), now());
select * from Categoria;

CREATE TABLE Aluno (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(60) NULL,
  instituicao VARCHAR(60) NULL,
  dataNascimento DATE NULL,
  ra VARCHAR(20) NULL,
  statusAluno CHAR NULL,
  senha VARCHAR(30) NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  PRIMARY KEY(id)
);

insert into Aluno values(null, 'Fernando Gonçalves','UNA', null, '10203040', 't', sha1('1234'), null, now());
select * from Aluno;

CREATE TABLE Produto (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idCategoria INTEGER UNSIGNED NOT NULL,
  nome VARCHAR(60) NULL,
  valor DOUBLE NULL,
  statusProduto CHAR NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  PRIMARY KEY(id),
  INDEX produto_FKIndex1(idCategoria),
  FOREIGN KEY(idCategoria)
    REFERENCES Categoria(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE Pedido (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idAluno INTEGER UNSIGNED NOT NULL,
  statusPedido CHAR NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  dataFinalizacao DATE NULL,
  PRIMARY KEY(id),
  INDEX pedido_FKIndex1(idAluno),
  FOREIGN KEY(idAluno)
    REFERENCES Aluno(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE Pedido_produto (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idProduto INTEGER UNSIGNED NOT NULL,
  idPedido INTEGER UNSIGNED NOT NULL,
  qtd INTEGER UNSIGNED NULL,
  statusPedidoProduto CHAR NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  PRIMARY KEY(id),
  INDEX pedido_produto_FKIndex1(idPedido),
  INDEX pedido_produto_FKIndex2(idProduto),
  FOREIGN KEY(idPedido)
    REFERENCES Pedido(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(idProduto)
    REFERENCES Produto(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);




