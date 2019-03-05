CREATE TABLE usuario (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(60) NULL,
  statusUsuario CHAR NULL,
  senha VARCHAR(30) NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  PRIMARY KEY(id)
);

CREATE TABLE categoria (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome INTEGER UNSIGNED NULL,
  statusCategoria CHAR NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  PRIMARY KEY(id)
);

CREATE TABLE aluno (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR(60) NULL,
  dataNascimento DATE NULL,
  ra VARCHAR(20) NULL,
  statusAluno CHAR NULL,
  senha VARCHAR(30) NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  PRIMARY KEY(id)
);

CREATE TABLE produto (
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
    REFERENCES categoria(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE pedido (
  id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  idAluno INTEGER UNSIGNED NOT NULL,
  statusPedido CHAR NULL,
  dataInsercao DATE NULL,
  dataAtualizacao DATE NULL,
  dataFinalizacao DATE NULL,
  PRIMARY KEY(id),
  INDEX pedido_FKIndex1(idAluno),
  FOREIGN KEY(idAluno)
    REFERENCES aluno(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);

CREATE TABLE pedido_produto (
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
    REFERENCES pedido(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(idProduto)
    REFERENCES produto(id)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
);


