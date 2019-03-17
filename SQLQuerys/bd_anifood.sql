
Drop database if exists AniFood;
CREATE DATABASE IF NOT EXISTS AniFood;
USE AniFood;

CREATE TABLE Instituicao (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(60) NULL,
  statusInstituicao CHAR NULL,
  dataInsercao DATETIME NULL,
  dataAtualizacao DATETIME NULL,
  PRIMARY KEY(id)
);

insert into Instituicao values(null, 'UNA', 'n', now(), now());
select * from Instituicao;

CREATE TABLE Categoria (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome INTEGER UNSIGNED NULL,
  statusCategoria CHAR NULL,
  dataInsercao DATETIME NULL,
  dataAtualizacao DATETIME NULL,
  PRIMARY KEY(id)
);

insert into Categoria values (null, 'Salgados','d',now(), now());
select * from Categoria;



CREATE TABLE Aluno (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(60) NULL,
  dataNascimento DATE NULL,
  ra VARCHAR(20) NULL,
  statusAluno CHAR NULL,
  senha VARCHAR(30) NULL,
  dataInsercao DATETIME NULL,
  dataAtualizacao DATETIME NULL,
  PRIMARY KEY(id)
);

insert into Aluno values(null, 'Fernando Gonçalves', now(), '10203040', 't', sha1('1234'), null, now());
select * from Aluno;

CREATE TABLE Pedido (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idAluno INTEGER UNSIGNED NOT NULL,
  statusPedido CHAR NULL,
  dataInsercao DATETIME NULL,
  dataAtualizacao DATETIME NULL,
  dataFinalizacao DATETIME NULL,
  PRIMARY KEY(id),
  INDEX pedido_FKIndex1(idAluno),
  FOREIGN KEY(idAluno)
    REFERENCES Aluno(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

insert into Pedido values (null, 1, 't',now(), now(), now());
select * from Pedido;

CREATE TABLE Loja (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idInstiuicao INTEGER UNSIGNED NOT NULL,
  nome VARCHAR(60) NULL,
  descricao TEXT NULL,
  campus VARCHAR(30) NULL,
  statusLoja CHAR NULL,
  dataInsercao DATETIME NULL,
  dataAtualizacao DATETIME NULL,
  PRIMARY KEY(id),
  INDEX loja_FKIndex1(idInstiuicao),
  FOREIGN KEY(idInstiuicao)
    REFERENCES Instituicao(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

insert into Loja values (null, 1, 'Coxinha Da Una', 'Aqui é mais legal','barro preto', 'n', now(), now());
insert into Loja values (null, 1, 'A negado B negado', 'Aqui é 0 ou 1','barro preto', 'n', now(), now());

select * from Loja;

CREATE TABLE Produto (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idLoja INTEGER UNSIGNED NOT NULL,
  idCategoria INTEGER UNSIGNED NOT NULL,
  nome VARCHAR(60) NULL,
  descricao VARCHAR(500) NULL,
  qtd INTEGER UNSIGNED NULL,
  valor DOUBLE NULL,
  statusProduto CHAR NULL,
  dataInsercao DATETIME NULL,
  dataAtualizacao DATETIME NULL,
  PRIMARY KEY(id),
  INDEX produto_FKIndex1(idCategoria),
  INDEX produto_FKIndex2(idLoja),
  FOREIGN KEY(idCategoria)
    REFERENCES Categoria(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(idLoja)
    REFERENCES Loja(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

insert into Produto values (null, 1, 1, 'Coxinha Pastel','Gosto de pastel e sabor de catupiry', 30, 2.50, 't', now(), now());
insert into Produto values (null, 2, 1, 'Empada','Empadinha ', 30, 2.50, 't', now(), now());

select * from Produto;

CREATE TABLE Pedido_produto (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idProduto INTEGER UNSIGNED NOT NULL,
  idPedido INTEGER UNSIGNED NOT NULL,
  qtd INTEGER UNSIGNED NULL,
  statusPedidoProduto CHAR NULL,
  dataInsercao DATETIME NULL,
  dataAtualizacao DATETIME NULL,
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

insert into Pedido_produto value(null, 1, 1, 5, 't', now(), now());
select * from Pedido_produto;

CREATE TABLE Usuario (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idLoja INTEGER UNSIGNED NOT NULL,
  nome VARCHAR(60) NULL,
  statusUsuario CHAR NULL,
  senha VARCHAR(30) NULL,
  dataInsercao DATETIME NULL,
  dataAtualizacao DATETIME NULL,
  PRIMARY KEY(id),
  INDEX usuario_FKIndex1(idLoja),
  FOREIGN KEY(idLoja)
    REFERENCES Loja(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

insert into Usuario values (null, 1, 'Admin','t',sha1('1234'),now(), now());
select * from Usuario;
