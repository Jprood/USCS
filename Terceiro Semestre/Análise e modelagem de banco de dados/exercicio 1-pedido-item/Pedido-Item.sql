CREATE TABLE cliente (
    chCliente int IDENTITY(1,1) NOT NULL,
    nome    varchar(50) NOT NULL,
    cnpj varchar(50) NOT NULL
)
CREATE TABLE produto (
    chProduto int IDENTITY(1,1) NOT NULL,
    descricao varchar(50) NOT NULL,
    valor decimal (10,2)  NOT NULL
)
CREATE TABLE pedido (
    chPedido int IDENTITY(1,1) NOT NULL,
    chCliente int NOT NULL
)
CREATE TABLE item (
    chItem int IDENTITY(1,1) NOT NULL,
    chPedido int NOT NULL,
    chProduto int NOT NULL,
    quantidade int NOT NULL,
    valor decimal (10,2) NOT NULL
)
-- ----------------------------------------------
-- ALIMENTANDO PRODUTOS
-- ----------------------------------------------
INSERT INTO PRODUTO (descricao,valor) values ('tomada', 1.10)
INSERT INTO PRODUTO (descricao,valor) values ('adaptador', 3.00)
INSERT INTO PRODUTO (descricao,valor)
values ('computador', 3000),
            ('mouse', 200)
-- insert into PRODUTO2 (descricao,valor)-- select descricao,valor  from produto
-- ----------------------------------------------------------
-- ALIMENTANDO CLIENTES
-- ----------------------------------------------------------
insert into cliente (nome,cnpj) values
('JOSE MARIA','1212312'),
('BAR DA ESQUINA','22343423')
SELECT * FROM CLIENTE

-- ----------------------------------------------------------
-- ALIMENTANDO PEDIDOS
-- ----------------------------------------------------------
insert into PEDIDO (chcliente) values (1)
insert into PEDIDO (chcliente) values (2)
select * from pedido

-- ----------------------------------------------------------
-- ALIMENTANDO ITENS 
-- ----------------------------------------------------------
INSERT INTO item (chpedido, chproduto,quantidade)
values (1,1,10),
       (1,2,20),
       (2,4,100)


SELECT cli = c.nome,
		idped = p.chpedido,
		total = i.valor,
		it = i.quantidade,
		pro = pr.valor

FROM cliente c
INNER JOIN
pedido p ON c.chcliente = p.chcliente
INNER JOIN
item i ON p.chpedido = i.chpedido 
INNER JOIN
produto pr ON pr.chproduto = i.chproduto 

WHERE c.nome LIKE 'a%'

ORDER BY i.valor DESC
