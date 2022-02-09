---------------------------------------------------------------------------------------------------
 
 -- SELECT FROM - Consultas simples a uma Tabela:
 
select Nome_Autor from tbl_Autores
select * from tbl_Autores
select Nome_Livro from tbl_Livro
select Nome_Livro, Id_Autor from tbl_Livro
---------------------------------------------------------------------------------------------------

 -- ORDER BY - Consultas com ordenação de Colunas:
 -- * ASC Ordem ascendente
 -- * DESC Ordem descendente
 
select * from tbl_Livro order by Nome_livro asc	
select * from tbl_Livro order by Nome_livro desc
select Nome_Livro, ISBN from tbl_Livro order by Nome_livro
---------------------------------------------------------------------------------------------------

 -- DISTINCT- Consultas com valores distintos, sem repetição:
 
 select distinct Id_Autor from tbl_Livro
---------------------------------------------------------------------------------------------------

 -- WHERE - Filtrando registros em uma consulta:
 
 select * from tbl_Livro where Id_Autor = '1'
 select Id_Autor from tbl_Autores where Sobrenome_Autor = 'stanek'
 --------------------------------------------------------------------------------------------------
 
 -- AND e OR - Operadores Lógicos:
 
 select * from tbl_Livro where Id_Livro > 2 and Id_Autor <3
 select * from tbl_Livro where Id_Livro > 2 or Id_Autor <3
 --------------------------------------------------------------------------------------------------
 
 -- SELECT TOP especificar número de registros a retornar:
 
 select top 10 percent Nome_livro from tbl_Livro -- este comando traz uma porcentagem do total da tabela ou seja 10%
 select top 3 Nome_livro from tbl_Livro
 select top 5 Nome_livro from tbl_Livro
 --------------------------------------------------------------------------------------------------
 
 -- Alias com AS - Nomes alternativos para colunas:
 -- * Pode- se dar um nome diferente a uma coluna ou tabela em uma consulta.
 
 select Nome_Livro as Livro from tbl_Livro
 select Nome_Livro as Livro,Id_Autor as Id from tbl_Livro
 --------------------------------------------------------------------------------------------------
 
 -- UNION - Unir resultados de declarações SELECT:
 -- * Permite combinar duas ou mais declarações SELECT.
 -- * Cada declaração Select deve ter o mesmo número de colunas, tipos de dados e ordem das colunas.
 
 select Id_Autor from tbl_Autores 
 union 
 select Id_Autor from tbl_Livro
 --------------------------------------------------------------------------------------------------
 
 -- SELECT INTO - Criar nova tabela a partir de uma tabela existente:
 -- * Seleciona dados de uma ou mais tabelas e os inserem em uma tabela diferente.
 
 select Id_Livro, Nome_Livro, ISBN into LivroAutor from tbl_Livro where Id_Livro > 2 
 --------------------------------------------------------------------------------------------------
 
 -- Funções Agregadas:
 -- * COUNT = CONTAR QUANTIDADE DE ITENS.
 
 select COUNT (*) from tbl_Autores
 select COUNT (Nome_Autor) from tbl_Autores
 
 -- * MAX = VALOR MÁXIMO.
 
 select MAX (Preco_Livro) from tbl_Livro
 select MAX (Preco_Livro) as PreçoMáximo from tbl_Livro
 
 -- * MIN = VALOR MÍNIMO.
 
 select MIN (Preco_Livro) from tbl_Livro
 select MIN (Preco_Livro) as PreçoMínimo from tbl_Livro
 
 -- * AVG = MÉDIA ARITMÉTICA.
 
 select AVG (Preco_Livro) from tbl_Livro
 select AVG (Preco_Livro) as MédiaPreço from tbl_Livro
 
 -- * SUM = TOTAL (SOMA).
 
 select SUM (Preco_Livro) from tbl_Livro
 select SUM (Preco_Livro) as PreçoTotal from tbl_Livro
 ---------------------------------------------------------------------------------------------------
 
 -- BETWEEN - Seleção de Intervalos em Registros:
 
 select * from tbl_Livro where Data_Pub between '20040517'and '20100517'
 select Nome_Livro as livro, Preco_Livro as Preço from tbl_Livro where Preco_livro between 40.00 and 60.00
 ---------------------------------------------------------------------------------------------------
 
 -- LIKE e NOT LIKE - Filtrar por padrões específicos:
 -- * Determina se uma cadeia de caracteres específica corresponde a uma padrão especificado.
 -- Um padrão pode incluir caracteres normais e curinga.
 -- * NOT LIKE: Inverte a comparação, verificando se a cadeia de caracteres 
 -- Não corresponde ao padrão especificado.
 -- * Usado junto com Where.
 
 -- Padrões Especificos - LIKE:
 -- '%' Qualquer cadeia de 0 ou mais caracteres.
 
 select Nome_Livro from tbl_Livro where Nome_Livro like 'S%' -- Começa com S oque vem depois não interesa.
 
 -- '_' Sublinhado: qualquer caractere único.
 
 select Nome_Livro from tbl_Livro where Nome_Livro like '_i%' -- Termina com I oque vem antes não interesa.
 
 -- '[]' Qualquer caractere único no intervalo ou conjunto especificado ([a-h]; [aeiou])
 
 select Nome_Livro from tbl_Livro where Nome_Livro like '[sl]%'
 select Nome_Livro from tbl_Livro where Nome_Livro like '_i__0%'
 
 -- '[^]' Qualquer caractere único que não esteja no intervalo ou conjunto especificado ([a-h]; [aeiou])
 
 select Nome_Livro from tbl_Livro where Nome_Livro not like 'M%'
 ----------------------------------------------------------------------------------------------------

 /* Cliente que mais emprestou livros */
 SELECT C.Nome, COUNT(C.Nome) AS Livros_Emprestados FROM tbl_Cliente AS C
 INNER JOIN tbl_Emprestimo AS E ON C.Id_Cliente = E.Id_Cliente
 GROUP BY C.Nome
 ORDER BY Livros_Emprestados DESC;

 SELECT L.Nome_livro AS Título, COUNT(L.Nome_livro) AS Livros_Mais_Emprestados FROM tbl_Livro AS L
 INNER JOIN tbl_EmprestimoLivro AS EL ON L.Id_Livro = EL.Id_Livro
 GROUP BY L.Nome_livro
 ORDER BY Livros_Mais_Emprestados DESC;
