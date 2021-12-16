/*
create database Prova;

use Prova;

create table Departamentos(
	dep_id integer primary key identity(1,1),
	dep_nome varchar(20) not null,
	dep_local integer not null
);

create table Grade_salarial(
	grade integer primary key identity(1,1),
	sal_min integer not null,
	sal_max integer not null
);

create table Funcionarios(
	edv integer primary key,
	nome varchar(30) not null,
	lider varchar(15) not null,
	data_de_contratacao date not null,
	salario integer not null,
	dep_id integer not null,
	foreign key (dep_id) references Departamentos
);

insert into Departamentos(dep_nome, dep_local) values
('REMAN', 104),
('ICO', 101),
('ETS', 401),
('FCM', 303),
('INOVE', 303);

insert into Grade_salarial(sal_min, sal_max) values
(1500, 4000),
(4001, 9000),
(9001, 22000),
(22001, 50000);

insert into Funcionarios(edv,nome,lider,data_de_contratacao,salario,dep_id) values
(92890148,'Edna Carvalho','Andrea','1990-02-24',19000,1),
(92790062,'João Manfredo','Andrea','2001-09-26',12500,1),
(91004090,'Débora Junior','Andrea','1999-03-02',15600,1),
(94566222,'Carla Rodrigues','Andrea','1990-10-04',20000,1),
(96334100,'Maciel Oliveira','Andrea','1995-12-06',16500,1),
(97885245,'Guilherme Guilhermo','Marcos','2010-05-13',9000,2),
(92894706,'Jessica Lima','Marcos','2015-08-14',25678,2),
(91450032,'Isabella Machado','Marcos','1993-01-22',10900,2),
(94661932,'Carlo Daniel','Lucio','1990-01-31',13750,2),
(95780634,'Maria Santana','Lucio','2015-09-05',8000,2),
(97881945,'Dominic Ferreira','Pietra','2020-02-09',2000,3),
(98490620,'Daniela Silva','Pietra','2020-02-09',1500,3),
(96854299,'Felipe Augusto','Pietra','2020-02-09',1600,3),
(97805503,'Natalia Reis','Pietra','2019-06-14',2200,3),
(90103456,'Thiago Dias','Pietra','2018-08-24',2800,3),
(98462157,'Lorena Ray','Pietra','2017-02-25',1900,3),
(95482340,'Natanael Brasil','Pietra','2020-06-03',3500,3),
(96314782,'Ana Mass','Captu','1997-02-19',3600,4),
(97854318,'Otávio Luis','Captu','2017-05-19',9200,4),
(94862122,'Luisa Otávia','Captu','2002-11-11',10500,4),
(97864320,'Lucas Moura','Captu','1990-08-29',6600,4),
(96315782,'Fernanda Lacerda','Captu','1999-12-17',2900,4),
(97546210,'Caroline Adeus','Captu','2018-02-19',4555,4),
(94621573,'Marco Valastro','Captu','2003-03-30',7000,4),
(96548432,'Valdemir Cantante','Jonas','2020-03-15',1200,5),
(97511020,'Eduarda Souza','Jonas','2011-08-14',1100,5),
(96410654,'Allan Jonas','Felipe','2008-06-17',3200,5),
(95645012,'Diana Jones','Felipe','2002-09-24',2050,5),
(94746054,'Mario Bros','Felipe','1990-01-18',25600,5),
(92085478,'Aline Franco','Jonas','1996-05-05',3700,5);
*/

/* EX004 */
/*select top 1 f.nome as Nome, d.dep_nome as Setor, f.salario as Salário
from Funcionarios as f
inner join Departamentos as d on f.dep_id = d.dep_id
where f.nome like 'D%'
order by f.salario desc;*/

/* EX005 */
/*select f.nome as Nome, d.dep_nome as Nome_do_Departamento, d.dep_local as Local_de_Trabalho
from Funcionarios as f
inner join Departamentos as d on f.dep_id = d.dep_id;*/

/* EX006 */
/*update Funcionarios
set salario = salario + ((select sum(salario) from Funcionarios where lider = 'Jonas') / (select count(salario) from funcionarios where lider <> 'Jonas'))
where lider <> 'Jonas';
delete from Funcionarios
where lider = 'Jonas';
select nome, lider, salario from Funcionarios;
*/

/* EX007 */
/*select nome as Nome, edv as EDV, lider as Líder,
(select grade from Grade_salarial as g
inner join Funcionarios as f on f.salario > g.sal_min and f.salario < g.sal_max
where f.data_de_contratacao = (select min(data_de_contratacao) from Funcionarios)) as Grade_Salarial
from Funcionarios
where data_de_contratacao = (select min(data_de_contratacao) from Funcionarios);*/

/* EX008 */
/*select d.dep_nome as Nome_do_Departamento, count(f.salario) as Salarios_Maior_Que_4000
from Departamentos as d
inner join Funcionarios as f on d.dep_id = f.dep_id
where f.salario > 4000
group by d.dep_nome*/

/* EX009 */
/*update Funcionarios
set lider = 'Marcos'
where lider = 'Lucio'
select nome, edv, data_de_contratacao
from Funcionarios
where lider in ('Marcos', 'Captu') and data_de_contratacao >= '01-01-2015'*/

/* EX010 */
/*select d.dep_nome as Setor, avg(f.salario) as Média_Salário_Setor
from Departamentos as d
inner join Funcionarios as f on d.dep_id = f.dep_id
group by d.dep_nome;
select d.dep_nome as Setor, min(f.salario) as Menor_Salário_Setor, max(f.salario) as Maior_Salário_Setor
from Departamentos as d
inner join Funcionarios as f on d.dep_id = f.dep_id
group by d.dep_nome;*/
