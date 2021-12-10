/*
create database ClienteVendedor;

use ClienteVendedor;





create table vendedor(
	cod_vendedor integer not null primary key,
	nome_vendedor varchar(50) not null,
	salario numeric(10,2) not null,
	faixa_comissao char not null
);

create table cliente(
	cod_cliente integer not null primary key,
	nome varchar(50) not null,
	endereco varchar(100) not null,
	cidade varchar(50) not null,
	cep integer,
	uf char(2) not null,
	cgc varchar(20) not null,
	ie integer
);

create table produto(
	cod_produto integer not null primary key,
	unidade varchar(5) not null,
	descricao varchar(25) not null,
	valor_unidade numeric(10,2) not null
);

create table pedido(
	numero_pedido integer not null primary key,
	prazo_entrega integer not null,
	cod_cliente integer not null,
	cod_vendedor integer not null,
	foreign key (cod_cliente) references cliente,
	foreign key (cod_vendedor) references vendedor
);

create table item_pedido(
	numero_pedido integer not null,
	cod_produto integer not null,
	quantidade integer not null
	foreign key (numero_pedido) references pedido,
	foreign key (cod_produto) references produto
);





insert into cliente(cod_cliente, nome, endereco, cidade, cep, uf, cgc, ie) values
(720, 'Ana', 'Rua 17 n.19', 'Niter�i', 24358310, 'RJ', '12113231/0001-34', 2134),
(870, 'Fl�vio', 'Av. Pres. Vargas 10', 'S�o Paulo', 22763931, 'SP', '22534126/9387-9', 4631),
(110, 'Jorge', 'Rua Caiapo 13', 'Curitiba', 30078500, 'PR', '14512764/9834-9', null),
(222, 'L�cia', 'Rua Itabira 123 Loja 9', 'Belo Horizonte', 22124391, 'MG', '28315213/9348-8', 2985),
(830, 'Maur�cio', 'Av. Paulista 1236 sl/2345', 'S�o Paulo', 3012683, 'SP', '32816985/7465-6', 9343),
(130, 'Edmar', 'Rua da Prais sn/', 'Salvador', 30079300, 'BA', '23463284/234-9', 7121),
(410, 'Rodolfo', 'Largo da Lapa 27 sobrado', 'Rio de Janeiro', 30078900, 'RJ', '12835128/2346-9', 7431),
(20, 'Beth', 'Av. Clim�rio n.45', 'S�o Paulo', 25679300, 'SP', '32485126/7326-8', 9280),
(157, 'Paulo', 'Tv. Moraes c/3', 'Londrina', null, 'PR', '32848223/324-2', 1923),
(180, 'L�vio', 'Av. Beira Mar n.1256', 'Florian�polis', 30077500, 'SC', '12736571/2347-4', null),
(260, 'Susana', 'Rua Lopes Mendes 12', 'Niter�i', 30046500, 'RJ', '21763517/232-9', 2530),
(290, 'Renato', 'Rua Meireles n.123 bl.2 sl.345', 'S�o Paulo', 30225900, 'SP', '13276571/1231-4', 1820),
(390, 'Sebasti�o', 'Rua da Igreja n.10', 'Uberaba', 30438700, 'MG', '32176547/213-3', 9071),
(234, 'Jos�', 'Quadra 3 bl.3 sl.1003', 'Bras�lia', 22841650, 'DF', '21763576/1232-3', 2931)

insert into vendedor (cod_vendedor, nome_vendedor, salario, faixa_comissao) values
(209, 'Jos�', 1800, 'C'),
(111, 'Carlos', 2490, 'A'),
(11, 'Jo�o', 2780, 'C'),
(240, 'Ant�nio', 9500, 'C'),
(720, 'Felipe', 4600, 'A'),
(213, 'Jonas', 2300, 'A'),
(101, 'Jo�o', 2650, 'C'),
(310, 'Josias', 870, 'B'),
(250, 'Maur�cio', 2930, 'B')

insert into produto(cod_produto, unidade, descricao, valor_unidade) values
(25, 'Kg', 'Queijo', 0.97),
(31, 'BAR', 'Chocolate', 0.87),
(78, 'L', 'Vinho', 2.00),
(22, 'M', 'Linho', 0.11),
(30, 'SAC', 'A��car', 0.30),
(53, 'M', 'Linha', 1.80),
(13, 'G', 'Ouro', 6.18),
(45, 'M', 'Madeira', 0.25),
(87, 'M', 'Cano', 1.97),
(77, 'M', 'Papel', 1.05)

insert into pedido(numero_pedido, prazo_entrega, cod_cliente, cod_vendedor) values
(121, 20, 410, 209),
(97, 20, 720, 101),
(101, 15, 720, 101),
(137, 20, 720, 720),
(148, 20, 720, 101),
(189, 15, 870, 213),
(104, 30, 110, 101),
(203, 30, 830, 250),
(98, 20, 410, 209),
(143, 30, 20, 111),
(105, 15, 180, 240),
(111, 20, 260, 240),
(103, 20, 260, 11),
(91, 20, 260, 11),
(138, 20, 260, 11),
(108, 15, 290, 310),
(119, 30, 390, 250),
(127, 10, 410, 11)

insert into item_pedido(numero_pedido, cod_produto, quantidade) values
(121, 25, 10),
(121, 31, 35),
(97, 77, 20),
(101, 31, 9),
(101, 78, 18),
(101, 13, 5),
(98, 77, 5),
(148, 45, 8),
(148, 31, 7),
(148, 77, 3),
(148, 25, 10),
(148, 78, 30),
(104, 53, 32),
(203, 31, 6),
(189, 78, 45),
(143, 31, 20),
(143, 78, 10),
(105, 78, 10),
(111, 25, 10),
(111, 78, 70),
(103, 53, 37),
(91, 77, 40),
(138, 22, 10),
(138, 77, 35),
(138, 53, 18),
(108, 13, 17),
(119, 77, 40),
(119, 13, 6),
(119, 22, 10),
(119, 53, 43),
(137, 13, 8)





/* EX001 */
select descricao, unidade, valor_unidade from produto

/* EX002 */
select cgc as cnpj, nome, endereco from cliente

/* EX003 */
select * from vendedor

/* EX004 */
select cod_vendedor as numero, nome_vendedor as nome, salario as rendimentos, faixa_comissao as comissao from vendedor

/* EX005 */
select nome_vendedor, salario*2 from vendedor

/* EX006 */
select numero_pedido, cod_produto, quantidade from item_pedido where quantidade = 35

/* EX007 */
select nome, cidade from cliente where cidade = 'Niter�i'

/* EX008 */
select descricao from produto where unidade = 'M' and valor_unidade = 1.05

/* EX009 */
select nome, endereco from cliente where cidade = 'S�o Paulo' or cep > 30077000 and cep < 30079000

/* EX010 */
select numero_pedido from pedido where prazo_entrega != 15

/* EX011 */
select cod_produto,  descricao from produto where valor_unidade between 0.32 and 2

/* EX012 */
select cod_produto, descricao from produto where descricao like 'Q%'

/* EX013 */
select nome_vendedor from vendedor where nome_vendedor not like 'Jo%'

/* EX014 */
select nome_vendedor from vendedor where faixa_comissao = 'A' or faixa_comissao = 'B' order by nome_vendedor

/* EX015 */
select * from cliente where ie is null

/* EX016 */
select nome_vendedor, salario from vendedor order by nome_vendedor

/* EX017 */
select nome, cidade, uf from cliente order by uf desc, cidade desc

/* EX018 */
select descricao, valor_unidade from produto where unidade = 'M' order by valor_unidade

/* EX019 */
select nome_vendedor, salario*1.75+120 from vendedor where faixa_comissao = 'C' order by nome_vendedor

/* EX020 */
select min(salario) as 'MIN(salario)', max(salario) as 'MAX(salario)' from vendedor

/* EX021 */
select sum(quantidade) as 'SUM(quantidade)' from item_pedido where cod_produto = 78

/* EX022 */
select avg(salario) as 'AVG(salario)' from vendedor

/* EX023 */
select count(salario) as 'COUNT(*)' from vendedor where salario > 2500

/* EX024 */
select unidade from produto group by unidade

/* EX025 */
select numero_pedido, count(numero_pedido) from item_pedido group by numero_pedido

/* EX026 */
select numero_pedido, count(numero_pedido) as quantidade from item_pedido group by numero_pedido having count(numero_pedido) > 3

/* EX027 */
select cliente.nome, pedido.cod_cliente, pedido.numero_pedido from cliente
inner join pedido on cliente.cod_cliente = pedido.cod_cliente order by cod_cliente

/* EX028 */
select cliente.nome, pedido.cod_cliente, pedido.numero_pedido from cliente, pedido order by cod_cliente

/* EX029 */
select cliente.nome, pedido.cod_cliente, numero_pedido from cliente
left join pedido on cliente.cod_cliente = pedido.cod_cliente

/* EX030 */
select distinct cliente.nome, cliente.uf, pedido.prazo_entrega from cliente
inner join pedido on cliente.cod_cliente = pedido.cod_cliente
where prazo_entrega > 15 and (uf = 'SP' or uf = 'RJ')

/* EX031 */
select distinct cliente.nome, pedido.prazo_entrega from cliente 
inner join pedido on cliente.cod_cliente = pedido.cod_cliente order by pedido.prazo_entrega desc

/* EX032 */
select distinct vendedor.nome_vendedor, vendedor.salario, pedido.prazo_entrega from vendedor
inner join pedido on vendedor.cod_vendedor = pedido.cod_vendedor where prazo_entrega > 15 order by nome_vendedor

/* EX033 */
select cliente.nome from cliente
inner join pedido on cliente.cod_cliente = pedido.cod_cliente
inner join item_pedido on pedido.numero_pedido = item_pedido.numero_pedido
inner join produto on item_pedido.cod_produto = produto.cod_produto
where pedido.prazo_entrega > 15 and cliente.uf = 'RJ' and produto.descricao = 'Queijo' order by cliente.nome

/* EX034 */
select vendedor.nome_vendedor from vendedor
inner join pedido on vendedor.cod_vendedor = pedido.cod_vendedor
inner join item_pedido on pedido.numero_pedido = item_pedido.numero_pedido
inner join produto on item_pedido.cod_produto = produto.cod_produto
where produto.descricao = 'Chocolate' and item_pedido.quantidade > 10

/* EX035 */
select count(distinct cliente.nome) as ComprasComJo�o from cliente
inner join pedido on pedido.cod_cliente = cliente.cod_cliente
inner join vendedor on pedido.cod_vendedor = vendedor.cod_vendedor
where vendedor.nome_vendedor = 'Jo�o'

/* EX036 */
select count(distinct cliente.cod_cliente) as clientes, cliente.cidade from cliente
inner join pedido on cliente.cod_cliente = pedido.cod_cliente
inner join vendedor on pedido.cod_vendedor = vendedor.cod_vendedor
where vendedor.nome_vendedor = 'Jo�o' and (cliente.cidade = 'Rio de Janeiro' or cliente.cidade = 'Niter�i') group by cliente.cidade

/* EX037 */
select * from vendedor

/* EX038 */
select distinct descricao from produto
inner join item_pedido on produto.cod_produto = item_pedido.cod_produto
where item_pedido.quantidade in (10)

/* EX039 */
select distinct cod_vendedor, nome_vendedor from vendedor
where salario < (select avg(salario) from vendedor)

/* EX040 */
select produto.descricao from produto
left join item_pedido on produto.cod_produto = item_pedido.cod_produto
where produto.cod_produto not in(select cod_produto from item_pedido)

/* EX041 */
select vendedor.cod_vendedor, vendedor.nome_vendedor from vendedor
inner join pedido on vendedor.cod_vendedor = pedido.cod_vendedor
inner join item_pedido on pedido.numero_pedido = item_pedido.numero_pedido
inner join produto on item_pedido.cod_produto = produto.cod_produto
where unidade = 'G'

/* EX042 */
select cliente.nome from cliente
inner join pedido on cliente.cod_cliente = pedido.cod_cliente
group by cliente.nome having count(cliente.nome) > 3

/* EX043 */
insert into produto(cod_produto, unidade, descricao, valor_unidade) values
(108, 'Kg', 'Parafuso', 1.25)
select * from produto

/* EX044 */
update produto set valor_unidade = 1.62 where cod_produto = 108

/* EX045 */
select nome_vendedor, salario from vendedor

/* EX046 */
update vendedor set salario = (salario * 1.27 + 100)
select nome_vendedor, salario from vendedor

/* EX047 */
update produto set valor_unidade = (valor_unidade * 1.025)
where valor_unidade < (select avg(valor_unidade) from produto where unidade = 'Kg')
select * from produto

*/
