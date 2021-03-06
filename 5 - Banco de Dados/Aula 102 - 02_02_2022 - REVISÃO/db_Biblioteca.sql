/*
create database db_Biblioteca;

use db_Biblioteca;


create table tbl_Autores(
Id_Autor int identity (1,1) not null,
Nome_Autor char(50) not null,
Sobrenome_autor char(50) not null
constraint Pk_Autores primary key (Id_Autor)
)

create table tbl_Editoras(
Id_Editoras int identity (1,1) not null,
nome_Editora char(50) not null,
constraint Pk_Editoras primary key (Id_Editoras)
)

create table tbl_Livro(
Id_Livro int identity (1,1) not null,
Nome_livro char(50) not null,
ISBN char(50),
Data_Pub date,
Preco_livro decimal not null,
Id_Autor int not null,
Id_Editoras int not null,
constraint Pk_Livro primary key (Id_Livro),
constraint Fk_Id_Autor foreign key (Id_Autor) references tbl_Autores (Id_Autor),
constraint Fk_Id_Editoras foreign key (Id_Editoras) references tbl_Editoras (Id_Editoras)
)

-- Comando de altera??o de tabela exclus?o da coluna Id_Autor da tabela Livro:

 alter table tbl_Livro 
 drop column Id_Autor
--------------------------------------------------------------------------------------------------

-- Comando de altera??o de tabela adicionando uma constraint foreign key:

 alter table tbl_Livro
 add Id_Autor int not null
 constraint fk_Id_Autor foreign key (Id_Autor) references tbl_Autores
 -------------------------------------------------------------------------------------------------
 
 -- Comando de altera??o de coluna tipo do dado Ex: de char para int.
 -- somente alterar antes de j? ter informa??e inseridas:
 
 alter table tbl_Livro
 alter column Id_Livro
--------------------------------------------------------------------------------------------------

-- Comando de altera??o de tabela adicionando chave primaria.
-- Obs. A coluna Id_Livro deve existir antes de ser transformada em chave primaria:

 alter table tbl_Livro
 add primary key (Id_Livro)
 -------------------------------------------------------------------------------------------------
 
-- Comando de Exclus?o de Tabela:

 drop table tbl_Autores
 -------------------------------------------------------------------------------------------------
 
-- Comando Truncate Table
 --O comando exclui todos os registros da tabela, n?o exclui a tabela.
 -------------------------------------------------------------------------------------------------
 
 -- Comando Insert:
 
 insert into tbl_Autores(Nome_Autor,Sobrenome_autor) values ('Daniel', 'Barret')
 insert into tbl_Autores(Nome_Autor,Sobrenome_autor) values ('Gerald', 'Cater')
 insert into tbl_Autores(Nome_Autor,Sobrenome_autor) values ('Mark', 'Sobell')
 insert into tbl_Autores(Nome_Autor,Sobrenome_autor) values ('William', 'Stanek')
 insert into tbl_Autores(Nome_Autor,Sobrenome_autor) values ('Richard', 'Blum')
 
 select * from tbl_Autores
 
 insert into tbl_Editoras(nome_Editora) values ('Prentice Hall')
 insert into tbl_Editoras(nome_Editora) values ('O?Reilly')
 insert into tbl_Editoras(nome_Editora) values ('Microsoft Press')
 insert into tbl_Editoras(nome_Editora) values ('Wiley')
 
 select * from tbl_Editoras

 
 insert into tbl_Livro(Nome_livro, ISBN, Data_Pub, Preco_livro, Id_Autor, Id_Editoras) 
 values('Linux Command Line and Shell Scripting', 143856969, '20091221', 68.35, 5, 4 )
 
 insert into tbl_Livro(Nome_livro, ISBN, Data_Pub, Preco_livro, Id_Autor, Id_Editoras) 
 values('SSH the Secure Shell', 127658789, '20091221', 58.30, 1, 2)
 
 insert into tbl_Livro(Nome_livro, ISBN, Data_Pub, Preco_livro, Id_Autor, Id_Editoras) 
 values('Using Samba', 123856789, '20001221', 61.45, 2, 2)
 
 insert into tbl_Livro(Nome_livro, ISBN, Data_Pub, Preco_livro, Id_Autor, Id_Editoras)
 values('Fedora and Red Hat Linux', 123346789, '20101101', 62.24, 3, 1)
 
 insert into tbl_Livro(Nome_livro, ISBN, Data_Pub, Preco_livro, Id_Autor, Id_Editoras) 
 values('Windows Server 2012 Inside Out', 123356789, '20040517', 66.80, 4, 3)
 
 insert into tbl_Livro(Nome_livro, ISBN, Data_Pub, Preco_livro, Id_Autor, Id_Editoras) 
 values('Microsoft exchange Server 2010', 123366789, '20001221', 45.30, 4, 3)
 --------------------------------------------------------------------------------------------------
 
 -- SELECT FROM - Consultas simples a uma Tabela:
 
select Nome_Autor from tbl_Autores
select * from tbl_Autores
select Nome_Livro from tbl_Livro
select Nome_Livro, Id_Autor from tbl_Livro
---------------------------------------------------------------------------------------------------
*/

/* 02-02-2022 */

/*
CREATE TABLE tbl_Telefone(
	Id_Telefone int identity(1,1) not null,
	Telefone char(15) not null,
	constraint Pk_Telefone primary key (Id_Telefone)
);

CREATE TABLE tbl_Cliente(
	Id_Cliente int identity(1,1) not null,
	Nome varchar(70) not null,
	Cpf char(14) not null,
	constraint Pk_Cliente primary key (Id_Cliente)
);

CREATE TABLE tbl_ClienteTelefone(
	Id_ClienteTelefone int identity(1,1) not null,
	Id_Cliente int not null,
	Id_Telefone int not null,
	constraint Pk_ClienteTelefone primary key (Id_ClienteTelefone),
	constraint Fk_Id_Cliente foreign key (Id_Cliente) references tbl_Cliente (Id_Cliente),
	constraint Fk_Id_Telefone foreign key (Id_Telefone) references tbl_Telefone (Id_Telefone)
);

CREATE TABLE tbl_Emprestimo(
	Id_Emprestimo int identity(1,1) not null,
	Data_Emprestimo date default current_timestamp,
	Data_Devolucao date not null,
	Id_Cliente int not null,
	constraint Pk_Emprestimo primary key (Id_Emprestimo),
	constraint Fk_Cliente foreign key (Id_Cliente) references tbl_Cliente (Id_Cliente)
);

CREATE TABLE tbl_EmprestimoLivro(
	Id_EmprestimoLivro int identity(1,1) not null,
	Id_Emprestimo int not null,
	Id_Livro int not null,
	constraint Pk_EmprestimoLivro primary key (Id_EmprestimoLivro),
	constraint Fk_Id_Emprestimo foreign key (Id_Emprestimo) references tbl_Emprestimo (Id_Emprestimo),
	constraint Fk_Id_Livro foreign key (Id_Livro) references tbl_Livro (Id_Livro)
);
*/


/* 03_02_2022 */

/*
INSERT INTO tbl_Telefone (Telefone) VALUES
('(41) 99854-6325'),
('(41) 99862-4547'),
('(41) 99752-8423'),
('(26) 99856-8530'),
('(41) 99802-1502'),
('(43) 99536-4725'),
('(41) 99863-3004');

INSERT INTO tbl_Cliente (Nome, Cpf) VALUES
('Jos? Almeida', '136.846.812-58'),
('Maria Da Silva', '025.651.327-05'),
('Gultavo Pereira', '106.953.065-63'),
('Beatrice Nogueira', '100.256.913-27'),
('Mirian Toniollo', '035.657.329-02'),
('Thain? Dos Santos', '159.623.332.15'),
('Luana Tamaro', '254.958.325-12');

INSERT INTO tbl_ClienteTelefone (Id_Cliente, Id_Telefone) VALUES
(1,2),
(3,5),
(6,3),
(5,6),
(7,7),
(2,4),
(4,1);

INSERT INTO tbl_Emprestimo (Data_Emprestimo, Data_Devolucao, Id_Cliente) VALUES
('2022-01-31', '2022-02-07', 1),
('2022-01-26', '2022-02-02', 3),
('2022-01-12', '2022-01-19', 6),
('2022-01-27', '2022-02-03', 4),
('2022-01-16', '2022-01-23', 2),
('2022-02-02', '2022-02-09', 7),
('2022-01-08', '2022-01-15', 5),
('2022-01-29', '2022-02-05', 2),
('2022-01-14', '2022-01-21', 6);

INSERT INTO tbl_EmprestimoLivro (Id_Emprestimo, Id_Livro) VALUES
(9, 2),
(5, 4),
(4, 3),
(2, 5),
(8, 2),
(3, 1),
(3, 6),
(1, 5),
(6, 4),
(7, 3),
(7, 2),
(7, 6);
*/

SELECT * FROM tbl_Emprestimo;
