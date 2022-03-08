/*
CREATE DATABASE Teste;

USE Teste;
*/
/*
CREATE TABLE A(
	a int primary key identity(1,1),
	b int
);

CREATE TABLE B(
	a int primary key identity(1,1),
	b int
);
*/
/*
INSERT INTO A (b) VALUES
(1),
(2),
(3),
(4),
(5);

INSERT INTO B (b) VALUES
(1),
(1),
(1),
(2),
(2),
(3),
(4);
*/
/*
CREATE TABLE C(
	a int primary key identity(1,1),
	b int
)

INSERT INTO C (b) VALUES
(1),
(2),
(3);
*/
/*
CREATE TABLE D(
	a int primary key identity(1,1),
	b CHAR(2)
)

INSERT INTO D (b) VALUES
('AB'),
('CD'),
('EF');

SELECT COUNT(*)
FROM D
WHERE SUBSTRING(b, -1)='B'


DROP TABLE IF EXISTS C

SELECT * FROM A
UNION ALL
SELECT * FROM C

UPDATE C
SET b = 7
WHERE a = 1;
*/

CREATE DATABASE xyz;

USE xyz;

CREATE TABLE estado(
	ESTADO_CODIGO CHAR(2) NOT NULL,
	ESTADO_NOME VARCHAR(25) NOT NULL,
	CONSTRAINT PK_ESTADO_CODIGO PRIMARY KEY (ESTADO_CODIGO)
);

CREATE TABLE ue_produto(
	UE_PRODUTO_COD CHAR(3) NOT NULL,
	UE_PRODUTO_DESCR VARCHAR(50) NOT NULL,
	CONSTRAINT PK_UE_PRODUTO_COD PRIMARY KEY (UE_PRODUTO_COD)
);

CREATE TABLE cliente(
	CLIENTE_ID INT NOT NULL IDENTITY(1,1),
	CLIENTE_NOME CHAR(50) NOT NULL,
	CLIENTE_END CHAR(50) NOT NULL,
	CLIENTE_END_CIDADE CHAR(20) NOT NULL,
	ESTADO_CODIGO CHAR(2) NOT NULL,
	CLIENTE_END_CEP CHAR(8) NOT NULL,
	CLIENTE_TELEFONE CHAR(10) NOT NULL,
	CLIENTE_PERC_DESCONTO DECIMAL(2,0),
	CONSTRAINT PK_CLIENTE_ID PRIMARY KEY (CLIENTE_ID),
	CONSTRAINT FK_ESTADO_CODIGO FOREIGN KEY (ESTADO_CODIGO) REFERENCES estado (ESTADO_CODIGO)
);

CREATE TABLE produto(
	PRODUTO_CODIGO SMALLINT NOT NULL IDENTITY(1,1),
	PRODUTO_NOME CHAR(40) NOT NULL,
	PRODUTO_PRECO DECIMAL(5,2) NOT NULL,
	UE_PRODUTO_COD CHAR(3) NOT NULL,
	CONSTRAINT PK_PRODUTO_CODIGO PRIMARY KEY (PRODUTO_CODIGO),
	CONSTRAINT FK_UE_PRODUTO_CODIGO FOREIGN KEY (UE_PRODUTO_COD) REFERENCES ue_produto (UE_PRODUTO_COD)
);

CREATE TABLE pedido(
	PEDIDO_IDENTIFICACAO INT NOT NULL IDENTITY(1,1),
	PEDIDO_TIPO VARCHAR(15) NOT NULL CHECK(PEDIDO_TIPO IN ('A VISTA', 'A PRAZO 30 Dias')),
	CLIENTE_ID INT NOT NULL,
	PEDIDO_DATA_ENTREGA DATE NOT NULL,
	PEDIDO_VALOR_TOTAL DECIMAL(7,2) NOT NULL,
	PEDIDO_DESCONTO DECIMAL(7,2) NOT NULL,
	PEDIDO_DT_EMBARQUE DATE NOT NULL,
	CONSTRAINT PK_PEDIDO_IDENTIFICACAO PRIMARY KEY (PEDIDO_IDENTIFICACAO),
	CONSTRAINT FK_CLIENTE_ID FOREIGN KEY (CLIENTE_ID) REFERENCES cliente (CLIENTE_ID)
);

CREATE TABLE item(
	PEDIDO_IDENTIFICACAO INT NOT NULL,
	PRODUTO_CODIGO SMALLINT NOT NULL,
	ITEM_QUANTIDADE SMALLINT NOT NULL,
	ITEM_VALOR_UNITARIO DECIMAL(5,2) NOT NULL,
	ITEM_VALOR_TOTAL DECIMAL(5,2) NOT NULL,
	CONSTRAINT PK_ITEM_CODIGO PRIMARY KEY (PEDIDO_IDENTIFICACAO, PRODUTO_CODIGO),
	CONSTRAINT FK_PEDIDO_IDENTIFICACAO FOREIGN KEY (PEDIDO_IDENTIFICACAO) REFERENCES pedido (PEDIDO_IDENTIFICACAO),
	CONSTRAINT FK_PRODUTO_CODIGO FOREIGN KEY (PRODUTO_CODIGO) REFERENCES produto (PRODUTO_CODIGO)
);