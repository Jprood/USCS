Escreva uma instrução SELECT que produza o seguinte relatório, a partir das tabelas CLIENTE, PRODUTO, PEDIDO e ITEM.

Conteúdo do relatório:
Nome do cliente, id do pedido, valor unitário do item, quantidade, VALOR TOTAL DO ITEM

Filtro: somente para os clientes cujo nome se iniciem pela letra A 

Ordenação: Ordenado pelo valor total do item, de forma decrescente



INICIO DA ATIVIDADE (FEITO EM SALA)

SELECT C.nome,  
       P.chPedido,
       I.Quantidade,
       Total=I.valor
FROM CLIENTE C  INNER JOIN
     PEDIDO  P  ON C.chCliente=P.chCliente INNER JOIN
     ITEM    I  ON P.chPedido=I.chPedido