ALTER PROCEDURE GetNivelCliente (@chCliente int, @nivel varchar(20)='' OUTPUT)
AS
BEGIN
set nocount on
DECLARE @limite decimal(10,2)
DECLARE @nome varchar(100)
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
END

declare @ret varchar(20)
EXEC GetNivelCliente 4, @ret OUTPUT
select Nível = @ret