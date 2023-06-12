INSERT INTO Natureza (descricao) 
VALUES ('venda'), 
	   ('devolução'), 
       ('troca');

INSERT INTO Forma_Pag (descricao) 
VALUES ('cartão de credito'),
	   ('cartão de debito'), 
       ('dinheiro'), 
       ('pix');

INSERT INTO Grupo (descricao) 
VALUES ('bebidas'), 
	   ('doces'), 
	   ('produtos de higiene'),
       ('salgainhos');

INSERT INTO Fornecedor (nome, endereco, telefone, email, cnpj) 
VALUES ('Coca-cola company', 'rua 1', '11924372735', 'fornecedor1@email.com', '12345678901234'),
	   ('Fini ltda', 'Rua 2, 456', '21987654321', 'fornecedor2@email.com', '98765432109876'),
       ('Colgate', 'Rua 3, 789', '31912348765', 'fornecedor3@email.com', '56789012345678'),
       ('Pepsico', 'Rua 4, 012', '41987651234', 'fornecedor4@email.com', '43210987654321');


INSERT INTO Produto (idFornecedor, idGrupo, nome, preco, lote, quantidade_disp) 
VALUES (1, 1, 'coca-cola', 5.99, '009we54f', 100),
	   (2, 2, 'bala de goma fini', 7.59, '045tr54f', 150),
       (3, 3, 'pasta de dente colgate', 4.59, '103w454t', 200),
       (4, 4, 'doritos', 5.0, '119ee84s', 50),
       (1, 4, 'Pepsi', 5.99, '339re54f', 100),
       (1, 1, 'fanta laranja', 5.0, '214dd14f', 100),
       (3, 3, 'fio dental', 10.0, '779we54f', 67);
       
INSERT INTO Item (total) 
VALUES (55.67),
	   (18.0),
       (109.99),
       (567.0);



INSERT INTO Produto_Item (idProduto, idItem, quantidade) 
VALUES (1, 1, 2),
	   (3, 1, 1),
       (4, 1, 3),
       (5, 2, 5),
       (2, 2, 2),
       (6, 3, 7),
       (1, 3, 2),
       (7, 3, 1),
       (6, 4, 50),
       (4, 4, 20);


INSERT INTO Pedido (idNatureza, idItem, idForma_Pag) 
VALUES (1, 1, 3),
	   (1, 2, 4),
       (1, 3, 2),
       (1, 4, 1);

INSERT INTO Financeiro (idNatureza, TOTAL) 
VALUES (1, 10.0),
	   (1, 50.0),
       (1, 78.0),
       (1, 550.0);

INSERT INTO Tipo_Usuario (descricao)
VALUES ('Administrador'),
	   ('Funcionario');
       
INSERT INTO Usuario (idTipo_Usuario, email, senha) 
VALUES (1, 'gerente1@gmail.com', '123456'),
	   (2, 'funcionario2@gmail.com', '7654332'),
       (2, 'funcionario3@gmail.com', 'senha1'),
       (2, 'funcionario4@gmail.com', 'gtrfe111');
