
/*cod_vendedor as numero, nome_vendedor as nome, salario_fixo as rendimentos, faxa_comissao as comissao*/

/*select * from vendedor*/

/*select cgc(cnpj), nome, endereco from cliente*/

/*select descricao, unidade, valor_unidade from produto*/




/*insert into pedido(numero_pedido, prazo_entrega, cod_cliente, cod_vendedor) values
(121, , , ),
(97, , , ),
(101, , , ),
(137, , , ),
(148, , , ),
(189, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , ),
(, , , )*/
/*Not finished*/

/*insert into produto(cod_produto, unidade, descricao, valor_unidade) values
(25, 'Kg', 'Queijo', 0.97),
(31, 'BAR', 'Chocolate', 0.87),
(78, 'L', 'Vinho', 2.00),
(22, 'M', 'Linho', 0.11),
(30, 'SAC', 'A��car', 0.30),
(53, 'M', 'Linha', 1.80),
(13, 'G', 'Ouro', 6.18),
(45, 'M', 'Madeira', 0.25),
(87, 'M', 'Cano', 1.97),
(77, 'M', 'Papel', 1.05)*/
/*Int Error*/

/*insert into vendedor (cod_vendedor, nome, salario, faixa_comissao) values
(209, 'Jos�', 1800, 'C'),
(111, 'Carlos', 2490, 'A'),
(11, 'Jo�o', 2780, 'C'),
(240, 'Ant�nio', 9500, 'C'),
(720, 'Felipe', 4600, 'A'),
(213, 'Jonas', 2300, 'A'),
(101, 'Jo�o', 2650, 'C'),
(310, 'Josias', 870, 'B'),
(250, 'Maur�cio', 2930, 'B')*/
/*Int Error*/

/*
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

create table item_pedido(
	numero_pedido int not null,
	cod_produto int not null,
	quantidade int not null
	foreign key (numero_pedido) references pedido,
	foreign key (cod_produto) references produto
);

create table pedido(
	numero_pedido int not null primary key,
	prazo_entrega int not null,
	cod_cliente int not null,
	cod_vendedor int not null,
	foreign key (cod_cliente) references cliente,
	foreign key (cod_vendedor) references vendedor
);

create table produto(
	cod_produto int not null primary key,
	unidade varchar(5) not null,
	descricao varchar(25) not null,
	valor_unidade decimal(2,2) not null
);

create table cliente(
	cod_cliente int not null primary key,
	nome varchar(50) not null,
	endereco varchar(100) not null,
	cidade varchar(50) not null,
	cep int,
	uf char(2) not null,
	cgc varchar(20) not null,
	ie int
);

create table vendedor(
	cod_vendedor int not null primary key,
	nome varchar(50) not null,
	salario decimal(4,2) not null,
	faixa_comissao char not null
);

use ClienteVendedor;

create database ClienteVendedor;
*/
