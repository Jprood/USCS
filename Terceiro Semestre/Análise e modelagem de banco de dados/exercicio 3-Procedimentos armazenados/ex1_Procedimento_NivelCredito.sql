CREATE PROCEDURE GetNivelCliente (@chCliente int)
AS
BEGIN
DECLARE @limite decimal(10,2)
DECLARE @nome varchar(100)
DECLARE @nivel varchar(20)
-- -------------------------------------------
SELECT @limite=limitecredito, @nome=fantasia FROM cliente WHERE chCliente= @chCliente
SELECT @nome, @limite
-- -------------------------------------------
SET @nivel = 'SILVER'
IF @limite IS NULL SET @nivel = 'Cliente não existe'

IF (@limite >= 10000 AND @limite <= 50000)
SET @nivel = 'GOLD'
ELSE IF @limite > 50000
SET @nivel = 'PLATINUM'
select Nivel=@nivel
END

EXEC GetNivelCliente 1